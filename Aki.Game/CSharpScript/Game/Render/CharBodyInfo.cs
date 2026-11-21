using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialContainer;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x020034D3 RID: 13523
	[NullableContext(2)]
	[Nullable(0)]
	public class CharBodyInfo
	{
		// Token: 0x060226B7 RID: 140983 RVA: 0x009C03A8 File Offset: 0x009BE5A8
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

		// Token: 0x060226B8 RID: 140984 RVA: 0x009C075C File Offset: 0x009BE95C
		[NullableContext(1)]
		private static int[] AppendIndex(int[] array, int index)
		{
			int[] array2 = new int[array.Length + 1];
			array.CopyTo(array2, 0);
			array2[array.Length] = index;
			return array2;
		}

		// Token: 0x060226B9 RID: 140985 RVA: 0x009C0784 File Offset: 0x009BE984
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

		// Token: 0x060226BA RID: 140986 RVA: 0x009C0818 File Offset: 0x009BEA18
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

		// Token: 0x060226BB RID: 140987 RVA: 0x009C093D File Offset: 0x009BEB3D
		public void RevertBattleMaskCommon()
		{
			if (this.UseBattleMaskCount > 0)
			{
				this.UseBattleMaskCount--;
				this.BattleMaskDirty = true;
			}
			this.UpdateBattleMask();
		}

		// Token: 0x060226BC RID: 140988 RVA: 0x009C0964 File Offset: 0x009BEB64
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

		// Token: 0x060226BD RID: 140989 RVA: 0x009C0A24 File Offset: 0x009BEC24
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

		// Token: 0x060226BE RID: 140990 RVA: 0x009C0AB8 File Offset: 0x009BECB8
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

		// Token: 0x060226BF RID: 140991 RVA: 0x009C0BE3 File Offset: 0x009BEDE3
		public void RevertBattleCommon()
		{
			if (this.UseBattleCount > 0)
			{
				this.UseBattleCount--;
				this.BattleDirty = true;
			}
			this.UpdateBattle();
		}

		// Token: 0x060226C0 RID: 140992 RVA: 0x009C0C0C File Offset: 0x009BEE0C
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

		// Token: 0x060226C1 RID: 140993 RVA: 0x009C0CCC File Offset: 0x009BEECC
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

		// Token: 0x060226C2 RID: 140994 RVA: 0x009C0D5C File Offset: 0x009BEF5C
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

		// Token: 0x060226C3 RID: 140995 RVA: 0x009C0E81 File Offset: 0x009BF081
		public void RevertAlphaTestCommon()
		{
			if (this.UseAlphaTestCount > 0)
			{
				this.UseAlphaTestCount--;
				this.AlphaTestDirty = true;
			}
			this.UpdateAlphaTest();
		}

		// Token: 0x060226C4 RID: 140996 RVA: 0x009C0EA8 File Offset: 0x009BF0A8
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

		// Token: 0x060226C5 RID: 140997 RVA: 0x009C0F68 File Offset: 0x009BF168
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

		// Token: 0x060226C6 RID: 140998 RVA: 0x009C0FF8 File Offset: 0x009BF1F8
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

		// Token: 0x060226C7 RID: 140999 RVA: 0x009C111D File Offset: 0x009BF31D
		public void RevertOutlineStencilTestCommon()
		{
			if (this.UseOutlineStencilCount > 0)
			{
				this.UseOutlineStencilCount--;
				this.OutlineStencilDirty = true;
			}
			this.UpdateStencilOutlineTest();
		}

		// Token: 0x060226C8 RID: 141000 RVA: 0x009C1144 File Offset: 0x009BF344
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

		// Token: 0x060226C9 RID: 141001 RVA: 0x009C1204 File Offset: 0x009BF404
		public void SetColor(FName propertyName, FLinearColor color, ECharacterSlotSpecifiedType specifiedSlotType)
		{
			int[] array = this.SpecifiedSlotList[(int)specifiedSlotType];
			int num = array.Length;
			for (int i = 0; i < num; i++)
			{
				this.MaterialSlotList[array[i]].SetColor(propertyName, color);
			}
		}

		// Token: 0x060226CA RID: 141002 RVA: 0x009C123C File Offset: 0x009BF43C
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

		// Token: 0x060226CB RID: 141003 RVA: 0x009C1280 File Offset: 0x009BF480
		public void SetFloat(FName propertyName, float value, ECharacterSlotSpecifiedType specifiedSlotType)
		{
			int[] array = this.SpecifiedSlotList[(int)specifiedSlotType];
			int num = array.Length;
			for (int i = 0; i < num; i++)
			{
				this.MaterialSlotList[array[i]].SetFloat(propertyName, value);
			}
		}

		// Token: 0x060226CC RID: 141004 RVA: 0x009C12B8 File Offset: 0x009BF4B8
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

		// Token: 0x060226CD RID: 141005 RVA: 0x009C12FC File Offset: 0x009BF4FC
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

		// Token: 0x060226CE RID: 141006 RVA: 0x009C1334 File Offset: 0x009BF534
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

		// Token: 0x060226CF RID: 141007 RVA: 0x009C1378 File Offset: 0x009BF578
		public void SetStarScarEnergy(float value)
		{
			int num = this.MaterialSlotList.Length;
			for (int i = 0; i < num; i++)
			{
				this.MaterialSlotList[i].SetStarScarEnergy(value);
			}
		}

		// Token: 0x060226D0 RID: 141008 RVA: 0x009C13A8 File Offset: 0x009BF5A8
		public void SetNoWater(bool value)
		{
			if (this.SkeletalComp != null && this.SkeletalComp.IsValid())
			{
				this.SkeletalComp.SetDisableWaterForToon(value);
			}
		}

		// Token: 0x060226D1 RID: 141009 RVA: 0x009C13CC File Offset: 0x009BF5CC
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

		// Token: 0x060226D2 RID: 141010 RVA: 0x009C1428 File Offset: 0x009BF628
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

		// Token: 0x060226D3 RID: 141011 RVA: 0x009C14D0 File Offset: 0x009BF6D0
		private void DebugPrint()
		{
			CharMaterialController charMaterialController = this.MaterialContainer.GetRenderingComponent().GetComponent(2) as CharMaterialController;
			if (charMaterialController != null)
			{
				charMaterialController.PrintCurrentInfo();
			}
		}

		// Token: 0x060226D4 RID: 141012 RVA: 0x009C1500 File Offset: 0x009BF700
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

		// Token: 0x060226D5 RID: 141013 RVA: 0x009C155C File Offset: 0x009BF75C
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

		// Token: 0x060226D6 RID: 141014 RVA: 0x009C15FC File Offset: 0x009BF7FC
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

		// Token: 0x060226D7 RID: 141015 RVA: 0x009C169C File Offset: 0x009BF89C
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

		// Token: 0x060226D8 RID: 141016 RVA: 0x009C173C File Offset: 0x009BF93C
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

		// Token: 0x04012F09 RID: 77577
		[Nullable(1)]
		public string ActorName = string.Empty;

		// Token: 0x04012F0A RID: 77578
		[Nullable(1)]
		public string BodyName = string.Empty;

		// Token: 0x04012F0B RID: 77579
		public ECharacterBodyType? BodyType;

		// Token: 0x04012F0C RID: 77580
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public CharMaterialSlot[] MaterialSlotList;

		// Token: 0x04012F0D RID: 77581
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public int[][] SpecifiedSlotList;

		// Token: 0x04012F0E RID: 77582
		public USkeletalMeshComponent SkeletalComp;

		// Token: 0x04012F0F RID: 77583
		public USkeletalMesh SkeletalMesh;

		// Token: 0x04012F10 RID: 77584
		private int[] SectionMainMatIndex;

		// Token: 0x04012F11 RID: 77585
		private bool AlphaTestDirty;

		// Token: 0x04012F12 RID: 77586
		private bool OutlineStencilDirty;

		// Token: 0x04012F13 RID: 77587
		private bool BattleDirty;

		// Token: 0x04012F14 RID: 77588
		private bool BattleMaskDirty;

		// Token: 0x04012F15 RID: 77589
		private int UseAlphaTestCount;

		// Token: 0x04012F16 RID: 77590
		private int UseOutlineStencilCount;

		// Token: 0x04012F17 RID: 77591
		private int UseBattleCount;

		// Token: 0x04012F18 RID: 77592
		private int UseBattleMaskCount;

		// Token: 0x04012F19 RID: 77593
		private int[] UseAlphaTestMaskCount;

		// Token: 0x04012F1A RID: 77594
		private int[] UseOutlineStencilMaskCount;

		// Token: 0x04012F1B RID: 77595
		private int[] UseBattleBitCount;

		// Token: 0x04012F1C RID: 77596
		private int[] UseBattleMaskBitCount;

		// Token: 0x04012F1D RID: 77597
		private Stat StatUpdateMaterial;

		// Token: 0x04012F1E RID: 77598
		private Stat StatUpdateAlphaTest;

		// Token: 0x04012F1F RID: 77599
		private Stat StatUpdateBattle;

		// Token: 0x04012F20 RID: 77600
		private Stat StatUpdateBattleMask;

		// Token: 0x04012F21 RID: 77601
		private Stat StatUpdateOutlineStencil;

		// Token: 0x04012F22 RID: 77602
		private CharMaterialContainer MaterialContainer;

		// Token: 0x04012F23 RID: 77603
		public int LastUpdateCounter;
	}
}
