using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialContainer;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x020045AB RID: 17835
	[NullableContext(2)]
	[Nullable(0)]
	public class CharBodyInfo
	{
		// Token: 0x0602DFCD RID: 188365 RVA: 0x00A94188 File Offset: 0x00A92388
		[NullableContext(1)]
		public void Init(string actorName, string skelName, USkeletalMeshComponent skeletalComp, CharMaterialContainer materialContainer, bool useEmptyMaterial = false)
		{
			this.MaterialContainer = materialContainer;
			this.ActorName = actorName;
			this.BodyName = skelName;
			this.BodyType = new ECharacterBodyType?(RenderConfig.GetBodyTypeByName(skelName));
			this.SkeletalComp = skeletalComp;
			this.SkeletalMesh = skeletalComp.SkeletalMesh;
			this.SpecifiedSlotList = new int[4][];
			this.SpecifiedSlotList[0] = Array.Empty<int>();
			this.SpecifiedSlotList[2] = Array.Empty<int>();
			this.SpecifiedSlotList[1] = Array.Empty<int>();
			this.SpecifiedSlotList[3] = Array.Empty<int>();
			TArray<FName> materialSlotNames = skeletalComp.GetMaterialSlotNames();
			int num = materialSlotNames.Num();
			this.MaterialSlotList = new CharMaterialSlot[num];
			int i = 0;
			while (i < num)
			{
				UMaterialInstanceDynamic umaterialInstanceDynamic = null;
				if (useEmptyMaterial)
				{
					goto IL_129;
				}
				UMaterialInterface skeletalMaterialInterface = UKuroRenderingRuntimeBPPluginBPLibrary.GetSkeletalMaterialInterface(skeletalComp.SkeletalMesh, i);
				if (skeletalMaterialInterface == null || !skeletalMaterialInterface.IsValid())
				{
					Log.Instance.Warn(ELogModule.RenderCharacter, ELogAuthor.ZJF, "CharBodyInfo.Init: originalMat is not valid", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
				else
				{
					umaterialInstanceDynamic = skeletalComp.CreateDynamicMaterialInstance(i, skeletalMaterialInterface, default(FName));
					if (umaterialInstanceDynamic != null && umaterialInstanceDynamic.IsValid())
					{
						goto IL_129;
					}
					Log.Instance.Warn(ELogModule.RenderCharacter, ELogAuthor.ZJF, "CharBodyInfo.Init: dynamicMaterial is not valid", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
				IL_200:
				i++;
				continue;
				IL_129:
				this.MaterialSlotList[i] = new CharMaterialSlot();
				this.MaterialSlotList[i].Init(i, materialSlotNames.Get(i).ToString(), umaterialInstanceDynamic);
				this.SpecifiedSlotList[0] = CharBodyInfo.AppendIndex(this.SpecifiedSlotList[0], i);
				switch (this.MaterialSlotList[i].SlotType)
				{
				case ECharacterSlotType.Body:
				case ECharacterSlotType.HairEyeTransparent:
					this.SpecifiedSlotList[2] = CharBodyInfo.AppendIndex(this.SpecifiedSlotList[2], i);
					this.SpecifiedSlotList[1] = CharBodyInfo.AppendIndex(this.SpecifiedSlotList[1], i);
					goto IL_200;
				case ECharacterSlotType.Outline:
					this.SpecifiedSlotList[3] = CharBodyInfo.AppendIndex(this.SpecifiedSlotList[3], i);
					this.SpecifiedSlotList[1] = CharBodyInfo.AppendIndex(this.SpecifiedSlotList[1], i);
					goto IL_200;
				case ECharacterSlotType.EyeMask:
					goto IL_200;
				default:
					goto IL_200;
				}
			}
			int characterSectionCount = UKuroRenderingRuntimeBPPluginBPLibrary.GetCharacterSectionCount(this.SkeletalMesh);
			this.SectionMainMatIndex = new int[characterSectionCount];
			this.UseAlphaTestMaskCount = new int[characterSectionCount];
			this.UseOutlineStencilMaskCount = new int[characterSectionCount];
			this.UseBattleBitCount = new int[characterSectionCount];
			this.UseBattleMaskBitCount = new int[characterSectionCount];
			for (int j = 0; j < characterSectionCount; j++)
			{
				int characterSectionMaterialIndex = UKuroRenderingRuntimeBPPluginBPLibrary.GetCharacterSectionMaterialIndex(this.SkeletalMesh, j);
				this.MaterialSlotList[characterSectionMaterialIndex].SectionIndex = j;
				this.SectionMainMatIndex[j] = characterSectionMaterialIndex;
				this.UseAlphaTestMaskCount[j] = 0;
				this.UseOutlineStencilMaskCount[j] = 0;
				this.UseBattleBitCount[j] = 0;
				this.UseBattleMaskBitCount[j] = 0;
			}
			this.AlphaTestDirty = true;
			this.OutlineStencilDirty = true;
			this.BattleDirty = true;
			this.BattleMaskDirty = true;
			this.UseAlphaTestCount = 0;
			this.UseOutlineStencilCount = 0;
			this.UseBattleCount = 0;
			this.UseBattleMaskCount = 0;
			string str = this.ActorName + "_" + this.BodyName;
			this.StatUpdateMaterial = Stat.CreateNoFlameGraph("Render_CharBodyInfo_UpdateMaterial_" + str, "", "");
			this.StatUpdateAlphaTest = Stat.CreateNoFlameGraph("Render_CharBodyInfo_UpdateAlphaTest_" + str, "", "");
			this.StatUpdateOutlineStencil = Stat.CreateNoFlameGraph("Render_CharBodyInfo_UpdateOutlineStencil_" + str, "", "");
			this.StatUpdateBattle = Stat.CreateNoFlameGraph("Render_CharBodyInfo_UpdateBattle_" + str, "", "");
			this.StatUpdateBattleMask = Stat.CreateNoFlameGraph("Render_CharBodyInfo_UpdateBattleMask_" + str, "", "");
		}

		// Token: 0x0602DFCE RID: 188366 RVA: 0x00A9453C File Offset: 0x00A9273C
		[NullableContext(1)]
		private static int[] AppendIndex(int[] array, int index)
		{
			int[] array2 = new int[array.Length + 1];
			array.CopyTo(array2, 0);
			array2[array.Length] = index;
			return array2;
		}

		// Token: 0x0602DFCF RID: 188367 RVA: 0x00A94564 File Offset: 0x00A92764
		public unsafe void UseBattleMaskCommon()
		{
			this.UseBattleMaskCount++;
			this.BattleMaskDirty = true;
			if (this.UseBattleMaskCount >= 20)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RenderCharacter;
				ELogAuthor author = ELogAuthor.MY;
				string message = "Battle类型引用异常，检查UseBattleMask调用情况";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Battle Mask Reference Count", this.UseBattleMaskCount);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Actor", this.ActorName);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				this.DebugPrint();
			}
		}

		// Token: 0x0602DFD0 RID: 188368 RVA: 0x00A945F8 File Offset: 0x00A927F8
		public unsafe void UseBattleMask(int sectionIndex)
		{
			int num = this.UseBattleMaskBitCount.Length;
			if (sectionIndex < num)
			{
				this.UseBattleMaskBitCount[sectionIndex]++;
				this.BattleMaskDirty = true;
				if (this.UseBattleMaskBitCount[sectionIndex] >= 20)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.RenderCharacter;
					ELogAuthor author = ELogAuthor.MY;
					string message = "BattleMask类型引用异常，检查UseBattleMask调用情况";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Battle Mask Reference Count", this.UseBattleMaskBitCount[sectionIndex]);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Actor", this.ActorName);
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					return;
				}
			}
			else
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.RenderCharacter;
				ELogAuthor author2 = ELogAuthor.MY;
				string message2 = "UseBattleMask索引超过最大值";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("索引", sectionIndex);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("最大值", num - 1);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("Actor", this.ActorName);
				instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
			}
		}

		// Token: 0x0602DFD1 RID: 188369 RVA: 0x00A9471D File Offset: 0x00A9291D
		public void RevertBattleMaskCommon()
		{
			if (this.UseBattleMaskCount > 0)
			{
				this.UseBattleMaskCount--;
				this.BattleMaskDirty = true;
			}
			this.UpdateBattleMask();
		}

		// Token: 0x0602DFD2 RID: 188370 RVA: 0x00A94744 File Offset: 0x00A92944
		public unsafe void RevertBattleMask(int sectionIndex)
		{
			int num = this.UseBattleMaskBitCount.Length;
			if (sectionIndex < num)
			{
				if (this.UseBattleMaskBitCount[sectionIndex] > 0)
				{
					this.UseBattleMaskBitCount[sectionIndex]--;
					this.BattleMaskDirty = true;
					return;
				}
			}
			else
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RenderCharacter;
				ELogAuthor author = ELogAuthor.MY;
				string message = "RevertBattleMask索引超过最大值";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("索引", sectionIndex);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("最大值", num - 1);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Actor", this.ActorName);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			}
		}

		// Token: 0x0602DFD3 RID: 188371 RVA: 0x00A94804 File Offset: 0x00A92A04
		public unsafe void UseBattleCommon()
		{
			this.UseBattleCount++;
			this.BattleDirty = true;
			if (this.UseBattleCount >= 20)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RenderCharacter;
				ELogAuthor author = ELogAuthor.MY;
				string message = "Battle类型引用异常，检查UseBattleCommon调用情况";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Battle Reference Count", this.UseBattleCount);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Actor", this.ActorName);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				this.DebugPrint();
			}
		}

		// Token: 0x0602DFD4 RID: 188372 RVA: 0x00A94898 File Offset: 0x00A92A98
		public unsafe void UseBattle(int sectionIndex)
		{
			int num = this.UseBattleBitCount.Length;
			if (sectionIndex < num)
			{
				this.UseBattleBitCount[sectionIndex]++;
				this.BattleDirty = true;
				if (this.UseBattleBitCount[sectionIndex] >= 20)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.RenderCharacter;
					ELogAuthor author = ELogAuthor.MY;
					string message = "Battle类型引用异常，检查UseBattle调用情况";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Battle Reference Count", this.UseBattleBitCount[sectionIndex]);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Actor", this.ActorName);
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					this.DebugPrint();
					return;
				}
			}
			else
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.RenderCharacter;
				ELogAuthor author2 = ELogAuthor.MY;
				string message2 = "UseBattle索引超过最大值";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("索引", sectionIndex);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("最大值", num - 1);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("Actor", this.ActorName);
				instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
			}
		}

		// Token: 0x0602DFD5 RID: 188373 RVA: 0x00A949C3 File Offset: 0x00A92BC3
		public void RevertBattleCommon()
		{
			if (this.UseBattleCount > 0)
			{
				this.UseBattleCount--;
				this.BattleDirty = true;
			}
			this.UpdateBattle();
		}

		// Token: 0x0602DFD6 RID: 188374 RVA: 0x00A949EC File Offset: 0x00A92BEC
		public unsafe void RevertBattle(int sectionIndex)
		{
			int num = this.UseBattleBitCount.Length;
			if (sectionIndex < num)
			{
				if (this.UseBattleBitCount[sectionIndex] > 0)
				{
					this.UseBattleBitCount[sectionIndex]--;
					this.BattleDirty = true;
					return;
				}
			}
			else
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RenderCharacter;
				ELogAuthor author = ELogAuthor.MY;
				string message = "RevertBattle索引超过最大值";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("索引", sectionIndex);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("最大值", num - 1);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Actor", this.ActorName);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			}
		}

		// Token: 0x0602DFD7 RID: 188375 RVA: 0x00A94AAC File Offset: 0x00A92CAC
		public unsafe void UseAlphaTestCommon()
		{
			this.UseAlphaTestCount++;
			this.AlphaTestDirty = true;
			if (this.UseAlphaTestCount >= 20)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RenderCharacter;
				ELogAuthor author = ELogAuthor.MY;
				string message = "AlphaTest类型引用异常，检查UseAlphaTest调用情况";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("AlphaTest Reference Count", this.UseAlphaTestCount);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Actor", this.ActorName);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
		}

		// Token: 0x0602DFD8 RID: 188376 RVA: 0x00A94B3C File Offset: 0x00A92D3C
		public unsafe void UseAlphaTest(int sectionIndex)
		{
			int num = this.UseAlphaTestMaskCount.Length;
			if (sectionIndex < num)
			{
				this.UseAlphaTestMaskCount[sectionIndex]++;
				this.AlphaTestDirty = true;
				if (this.UseAlphaTestMaskCount[sectionIndex] >= 20)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.RenderCharacter;
					ELogAuthor author = ELogAuthor.MY;
					string message = "AlphaTestMask类型引用异常，检查UseAlphaTest调用情况";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("AlphaTest Reference Count", this.UseAlphaTestMaskCount[sectionIndex]);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Actor", this.ActorName);
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					return;
				}
			}
			else
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.RenderCharacter;
				ELogAuthor author2 = ELogAuthor.MY;
				string message2 = "UseAlphaTestMask索引超过最大值";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("索引", sectionIndex);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("最大值", num - 1);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("Actor", this.ActorName);
				instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
			}
		}

		// Token: 0x0602DFD9 RID: 188377 RVA: 0x00A94C61 File Offset: 0x00A92E61
		public void RevertAlphaTestCommon()
		{
			if (this.UseAlphaTestCount > 0)
			{
				this.UseAlphaTestCount--;
				this.AlphaTestDirty = true;
			}
			this.UpdateAlphaTest();
		}

		// Token: 0x0602DFDA RID: 188378 RVA: 0x00A94C88 File Offset: 0x00A92E88
		public unsafe void RevertAlphaTest(int sectionIndex)
		{
			int num = this.UseAlphaTestMaskCount.Length;
			if (sectionIndex < num)
			{
				if (this.UseAlphaTestMaskCount[sectionIndex] > 0)
				{
					this.UseAlphaTestMaskCount[sectionIndex]--;
					this.AlphaTestDirty = true;
					return;
				}
			}
			else
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RenderCharacter;
				ELogAuthor author = ELogAuthor.MY;
				string message = "RevertAlphaTestMask索引超过最大值";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("索引", sectionIndex);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("最大值", num - 1);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Actor", this.ActorName);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			}
		}

		// Token: 0x0602DFDB RID: 188379 RVA: 0x00A94D48 File Offset: 0x00A92F48
		public unsafe void UseOutlineStencilTestCommon()
		{
			this.UseOutlineStencilCount++;
			this.OutlineStencilDirty = true;
			if (this.UseOutlineStencilCount >= 20)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RenderCharacter;
				ELogAuthor author = ELogAuthor.MY;
				string message = "StencilOutline类型引用异常，检查UseAlphaTest调用情况";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("StencilOutline Reference Count", this.UseAlphaTestCount);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Actor", this.ActorName);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
		}

		// Token: 0x0602DFDC RID: 188380 RVA: 0x00A94DD8 File Offset: 0x00A92FD8
		public unsafe void UseOutlineStencilTest(int sectionIndex)
		{
			int num = this.UseOutlineStencilMaskCount.Length;
			if (sectionIndex < num)
			{
				this.UseOutlineStencilMaskCount[sectionIndex]++;
				this.OutlineStencilDirty = true;
				if (this.UseOutlineStencilMaskCount[sectionIndex] >= 20)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.RenderCharacter;
					ELogAuthor author = ELogAuthor.MY;
					string message = "StencilOutlineMask类型引用异常，检查UseStencilOutline调用情况";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("StencilOutline Reference Count", this.UseOutlineStencilMaskCount[sectionIndex]);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Actor", this.ActorName);
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					return;
				}
			}
			else
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.RenderCharacter;
				ELogAuthor author2 = ELogAuthor.MY;
				string message2 = "UseStencilOutlineMask索引超过最大值";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("索引", sectionIndex);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("最大值", num - 1);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("Actor", this.ActorName);
				instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
			}
		}

		// Token: 0x0602DFDD RID: 188381 RVA: 0x00A94EFD File Offset: 0x00A930FD
		public void RevertOutlineStencilTestCommon()
		{
			if (this.UseOutlineStencilCount > 0)
			{
				this.UseOutlineStencilCount--;
				this.OutlineStencilDirty = true;
			}
			this.UpdateStencilOutlineTest();
		}

		// Token: 0x0602DFDE RID: 188382 RVA: 0x00A94F24 File Offset: 0x00A93124
		public unsafe void RevertOutlineStencilTest(int sectionIndex)
		{
			int num = this.UseOutlineStencilMaskCount.Length;
			if (sectionIndex < num)
			{
				if (this.UseOutlineStencilMaskCount[sectionIndex] > 0)
				{
					this.UseOutlineStencilMaskCount[sectionIndex]--;
					this.OutlineStencilDirty = true;
					return;
				}
			}
			else
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RenderCharacter;
				ELogAuthor author = ELogAuthor.MY;
				string message = "RevertOutlineStencilMask索引超过最大值";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("索引", sectionIndex);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("最大值", num - 1);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Actor", this.ActorName);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			}
		}

		// Token: 0x0602DFDF RID: 188383 RVA: 0x00A94FE4 File Offset: 0x00A931E4
		public void SetColor(FName propertyName, FLinearColor color, ECharacterSlotSpecifiedType specifiedSlotType)
		{
			int[] array = this.SpecifiedSlotList[(int)specifiedSlotType];
			int num = array.Length;
			for (int i = 0; i < num; i++)
			{
				this.MaterialSlotList[array[i]].SetColor(propertyName, color);
			}
		}

		// Token: 0x0602DFE0 RID: 188384 RVA: 0x00A9501C File Offset: 0x00A9321C
		public void RevertColor(FName propertyName, ECharacterSlotSpecifiedType specifiedSlotType)
		{
			int[] array = this.SpecifiedSlotList[(int)specifiedSlotType];
			int num = array.Length;
			string propertyStr = propertyName.ToString();
			for (int i = 0; i < num; i++)
			{
				this.MaterialSlotList[array[i]].RevertColor(propertyStr);
			}
		}

		// Token: 0x0602DFE1 RID: 188385 RVA: 0x00A95060 File Offset: 0x00A93260
		public void SetFloat(FName propertyName, float value, ECharacterSlotSpecifiedType specifiedSlotType)
		{
			int[] array = this.SpecifiedSlotList[(int)specifiedSlotType];
			int num = array.Length;
			for (int i = 0; i < num; i++)
			{
				this.MaterialSlotList[array[i]].SetFloat(propertyName, value);
			}
		}

		// Token: 0x0602DFE2 RID: 188386 RVA: 0x00A95098 File Offset: 0x00A93298
		public void RevertFloat(FName propertyName, ECharacterSlotSpecifiedType specifiedSlotType)
		{
			int[] array = this.SpecifiedSlotList[(int)specifiedSlotType];
			int num = array.Length;
			string propertyStr = propertyName.ToString();
			for (int i = 0; i < num; i++)
			{
				this.MaterialSlotList[array[i]].RevertFloat(propertyStr);
			}
		}

		// Token: 0x0602DFE3 RID: 188387 RVA: 0x00A950DC File Offset: 0x00A932DC
		[NullableContext(1)]
		public void SetTexture(FName propertyName, UTexture texture, ECharacterSlotSpecifiedType specifiedSlotType)
		{
			int[] array = this.SpecifiedSlotList[(int)specifiedSlotType];
			int num = array.Length;
			for (int i = 0; i < num; i++)
			{
				this.MaterialSlotList[array[i]].SetTexture(propertyName, texture);
			}
		}

		// Token: 0x0602DFE4 RID: 188388 RVA: 0x00A95114 File Offset: 0x00A93314
		public void RevertTexture(FName propertyName, ECharacterSlotSpecifiedType specifiedSlotType)
		{
			int[] array = this.SpecifiedSlotList[(int)specifiedSlotType];
			int num = array.Length;
			string propertyStr = propertyName.ToString();
			for (int i = 0; i < num; i++)
			{
				this.MaterialSlotList[array[i]].RevertTexture(propertyStr);
			}
		}

		// Token: 0x0602DFE5 RID: 188389 RVA: 0x00A95158 File Offset: 0x00A93358
		public void SetStarScarEnergy(float value)
		{
			int num = this.MaterialSlotList.Length;
			for (int i = 0; i < num; i++)
			{
				this.MaterialSlotList[i].SetStarScarEnergy(value);
			}
		}

		// Token: 0x0602DFE6 RID: 188390 RVA: 0x00A95188 File Offset: 0x00A93388
		public void SetNoWater(bool value)
		{
			if (this.SkeletalComp != null && this.SkeletalComp.IsValid())
			{
				this.SkeletalComp.SetDisableWaterForToon(value);
			}
		}

		// Token: 0x0602DFE7 RID: 188391 RVA: 0x00A951AC File Offset: 0x00A933AC
		public int Update(EMaterialShadingRate? meshShadingRate = null)
		{
			if (meshShadingRate != null && this.SkeletalComp != null && this.SkeletalComp.IsValid())
			{
				this.SkeletalComp.SetMeshShadingRate(meshShadingRate.Value);
			}
			int result = this.UpdateMaterial();
			this.UpdateAlphaTest();
			this.UpdateStencilOutlineTest();
			this.UpdateBattle();
			this.UpdateBattleMask();
			return result;
		}

		// Token: 0x0602DFE8 RID: 188392 RVA: 0x00A95208 File Offset: 0x00A93408
		public void ResetAllState()
		{
			this.AlphaTestDirty = true;
			this.OutlineStencilDirty = true;
			this.UseAlphaTestCount = 0;
			this.UseOutlineStencilCount = 0;
			this.UseAlphaTestMaskCount.AsSpan<int>().Fill(0);
			this.UseOutlineStencilMaskCount.AsSpan<int>().Fill(0);
			this.UseBattleBitCount.AsSpan<int>().Fill(0);
			this.UseBattleMaskBitCount.AsSpan<int>().Fill(0);
			this.UseOutlineStencilMaskCount.AsSpan<int>().Fill(0);
			this.UpdateAlphaTest();
			this.UpdateStencilOutlineTest();
			this.UpdateBattle();
			this.UpdateBattleMask();
		}

		// Token: 0x0602DFE9 RID: 188393 RVA: 0x00A952B0 File Offset: 0x00A934B0
		private void DebugPrint()
		{
			CharMaterialController charMaterialController = this.MaterialContainer.GetRenderingComponent().GetComponent(2) as CharMaterialController;
			if (charMaterialController != null)
			{
				charMaterialController.PrintCurrentInfo();
			}
		}

		// Token: 0x0602DFEA RID: 188394 RVA: 0x00A952E0 File Offset: 0x00A934E0
		private int UpdateMaterial()
		{
			if (this.SkeletalComp == null || !this.SkeletalComp.IsValid())
			{
				return 0;
			}
			int num = 0;
			int num2 = this.MaterialSlotList.Length;
			for (int i = 0; i < num2; i++)
			{
				CharMaterialSlot charMaterialSlot = this.MaterialSlotList[i];
				num += charMaterialSlot.UpdateMaterialParam();
				charMaterialSlot.SetSkeletalMeshMaterial(this.SkeletalComp);
			}
			return num;
		}

		// Token: 0x0602DFEB RID: 188395 RVA: 0x00A9533C File Offset: 0x00A9353C
		public void UpdateBattleMask()
		{
			if (!this.BattleMaskDirty)
			{
				return;
			}
			this.BattleMaskDirty = false;
			TArray<int> tarray = new TArray<int>();
			bool flag;
			bool useSectionMask;
			if (this.UseBattleMaskCount > 0)
			{
				flag = true;
				useSectionMask = false;
			}
			else
			{
				int num = this.UseBattleMaskBitCount.Length;
				for (int i = 0; i < num; i++)
				{
					if (this.UseBattleMaskBitCount[i] > 0)
					{
						tarray.Add(i);
					}
				}
				flag = (tarray.Num() > 0);
				useSectionMask = flag;
			}
			if (this.SkeletalComp != null && this.SkeletalComp.IsValid())
			{
				this.SkeletalComp.SetUseEnableBattleMask(flag);
				this.SkeletalComp.SetUseEnableBattleMaskSectionMask(useSectionMask, tarray);
			}
		}

		// Token: 0x0602DFEC RID: 188396 RVA: 0x00A953DC File Offset: 0x00A935DC
		public void UpdateBattle()
		{
			if (!this.BattleDirty)
			{
				return;
			}
			this.BattleDirty = false;
			TArray<int> tarray = new TArray<int>();
			bool flag;
			bool useSectionMask;
			if (this.UseBattleCount > 0)
			{
				flag = true;
				useSectionMask = false;
			}
			else
			{
				int num = this.UseBattleBitCount.Length;
				for (int i = 0; i < num; i++)
				{
					if (this.UseBattleBitCount[i] > 0)
					{
						tarray.Add(i);
					}
				}
				flag = (tarray.Num() > 0);
				useSectionMask = flag;
			}
			if (this.SkeletalComp != null && this.SkeletalComp.IsValid())
			{
				this.SkeletalComp.SetUseEnableBattle(flag);
				this.SkeletalComp.SetUseEnableBattleSectionMask(useSectionMask, tarray);
			}
		}

		// Token: 0x0602DFED RID: 188397 RVA: 0x00A9547C File Offset: 0x00A9367C
		public void UpdateAlphaTest()
		{
			if (!this.AlphaTestDirty)
			{
				return;
			}
			this.AlphaTestDirty = false;
			TArray<int> tarray = new TArray<int>();
			bool flag;
			bool useSectionMask;
			if (this.UseAlphaTestCount > 0)
			{
				flag = true;
				useSectionMask = false;
			}
			else
			{
				int num = this.UseAlphaTestMaskCount.Length;
				for (int i = 0; i < num; i++)
				{
					if (this.UseAlphaTestMaskCount[i] > 0)
					{
						tarray.Add(i);
					}
				}
				flag = (tarray.Num() > 0);
				useSectionMask = flag;
			}
			if (this.SkeletalComp != null && this.SkeletalComp.IsValid())
			{
				this.SkeletalComp.SetUseCustomAlphaTest(flag);
				this.SkeletalComp.SetUseCustomAlphaTestSectionMask(useSectionMask, tarray);
			}
		}

		// Token: 0x0602DFEE RID: 188398 RVA: 0x00A9551C File Offset: 0x00A9371C
		public void UpdateStencilOutlineTest()
		{
			if (!this.OutlineStencilDirty)
			{
				return;
			}
			this.OutlineStencilDirty = false;
			TArray<int> tarray = new TArray<int>();
			bool flag;
			bool useSectionMask;
			if (this.UseOutlineStencilCount > 0)
			{
				flag = true;
				useSectionMask = false;
			}
			else
			{
				int num = this.UseOutlineStencilMaskCount.Length;
				for (int i = 0; i < num; i++)
				{
					if (this.UseOutlineStencilMaskCount[i] > 0)
					{
						tarray.Add(i);
					}
				}
				flag = (tarray.Num() > 0);
				useSectionMask = flag;
			}
			if (this.SkeletalComp != null && this.SkeletalComp.IsValid())
			{
				this.SkeletalComp.SetUseOutlineStencilTest(flag);
				this.SkeletalComp.SetUseOutlineStencilTestSectionMask(useSectionMask, tarray);
			}
		}

		// Token: 0x040188CE RID: 100558
		[Nullable(1)]
		public string ActorName = string.Empty;

		// Token: 0x040188CF RID: 100559
		[Nullable(1)]
		public string BodyName = string.Empty;

		// Token: 0x040188D0 RID: 100560
		public ECharacterBodyType? BodyType;

		// Token: 0x040188D1 RID: 100561
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public CharMaterialSlot[] MaterialSlotList;

		// Token: 0x040188D2 RID: 100562
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public int[][] SpecifiedSlotList;

		// Token: 0x040188D3 RID: 100563
		public USkeletalMeshComponent SkeletalComp;

		// Token: 0x040188D4 RID: 100564
		public USkeletalMesh SkeletalMesh;

		// Token: 0x040188D5 RID: 100565
		private int[] SectionMainMatIndex;

		// Token: 0x040188D6 RID: 100566
		private bool AlphaTestDirty;

		// Token: 0x040188D7 RID: 100567
		private bool OutlineStencilDirty;

		// Token: 0x040188D8 RID: 100568
		private bool BattleDirty;

		// Token: 0x040188D9 RID: 100569
		private bool BattleMaskDirty;

		// Token: 0x040188DA RID: 100570
		private int UseAlphaTestCount;

		// Token: 0x040188DB RID: 100571
		private int UseOutlineStencilCount;

		// Token: 0x040188DC RID: 100572
		private int UseBattleCount;

		// Token: 0x040188DD RID: 100573
		private int UseBattleMaskCount;

		// Token: 0x040188DE RID: 100574
		private int[] UseAlphaTestMaskCount;

		// Token: 0x040188DF RID: 100575
		private int[] UseOutlineStencilMaskCount;

		// Token: 0x040188E0 RID: 100576
		private int[] UseBattleBitCount;

		// Token: 0x040188E1 RID: 100577
		private int[] UseBattleMaskBitCount;

		// Token: 0x040188E2 RID: 100578
		private Stat StatUpdateMaterial;

		// Token: 0x040188E3 RID: 100579
		private Stat StatUpdateAlphaTest;

		// Token: 0x040188E4 RID: 100580
		private Stat StatUpdateBattle;

		// Token: 0x040188E5 RID: 100581
		private Stat StatUpdateBattleMask;

		// Token: 0x040188E6 RID: 100582
		private Stat StatUpdateOutlineStencil;

		// Token: 0x040188E7 RID: 100583
		private CharMaterialContainer MaterialContainer;

		// Token: 0x040188E8 RID: 100584
		public int LastUpdateCounter;
	}
}
