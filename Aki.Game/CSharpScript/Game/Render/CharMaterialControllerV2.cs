using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Manager;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x020045A6 RID: 17830
	[NullableContext(1)]
	[Nullable(0)]
	public class CharMaterialControllerV2 : CharRenderBase
	{
		// Token: 0x0602DFA4 RID: 188324 RVA: 0x00A93676 File Offset: 0x00A91876
		public override string GetStatName()
		{
			return "CharMaterialControllerV2";
		}

		// Token: 0x0602DFA5 RID: 188325 RVA: 0x00A9367D File Offset: 0x00A9187D
		public override void Start()
		{
			this.MaterialContainer = (base.GetRenderingComponent().GetComponent(13) as CharMaterialContainerV2);
			this.MaterialContainer.AddEffectFinishCallback(new Action<int>(this.OnEffectFinished));
			base.OnInitSuccess();
		}

		// Token: 0x0602DFA6 RID: 188326 RVA: 0x00A936B4 File Offset: 0x00A918B4
		public int GetEffectCount()
		{
			return this.EffectsAdded.Count;
		}

		// Token: 0x0602DFA7 RID: 188327 RVA: 0x00A936C1 File Offset: 0x00A918C1
		public bool GetRuntimeMaterialControllerValid(int handle)
		{
			return this.EffectsAdded.ContainsKey(handle);
		}

		// Token: 0x0602DFA8 RID: 188328 RVA: 0x00A936CF File Offset: 0x00A918CF
		public void SetEffectProgress(float progress, int handle)
		{
			if (this.EffectsAdded.ContainsKey(handle))
			{
				CharMaterialContainerV2 materialContainer = this.MaterialContainer;
				if (materialContainer == null)
				{
					return;
				}
				materialContainer.SetEffectProgress(handle, progress);
			}
		}

		// Token: 0x0602DFA9 RID: 188329 RVA: 0x00A936F4 File Offset: 0x00A918F4
		[NullableContext(2)]
		public unsafe int AddMaterialControllerData([Nullable(1)] PD_CharacterControllerData_C data, UObject userData = null, USkeletalMeshComponent animObject = null)
		{
			Stat.CreateNoFlameGraph("CharMaterialControllerV2_AddData_" + data.GetName(), "", "");
			CharRenderingComponent renderingComponent = base.GetRenderingComponent();
			ECharacterRenderingType? echaracterRenderingType = (renderingComponent != null) ? renderingComponent.GetRenderType() : null;
			if (data.OnlyApplyOnLocalPlayer)
			{
				ECharacterRenderingType? echaracterRenderingType2 = echaracterRenderingType;
				ECharacterRenderingType echaracterRenderingType3 = ECharacterRenderingType.LocalPlayer;
				if (!(echaracterRenderingType2.GetValueOrDefault() == echaracterRenderingType3 & echaracterRenderingType2 != null))
				{
					return -1;
				}
			}
			if (data.NeverApplyOnLocalPlayer)
			{
				ECharacterRenderingType? echaracterRenderingType2 = echaracterRenderingType;
				ECharacterRenderingType echaracterRenderingType3 = ECharacterRenderingType.LocalPlayer;
				if (echaracterRenderingType2.GetValueOrDefault() == echaracterRenderingType3 & echaracterRenderingType2 != null)
				{
					return -1;
				}
			}
			CharMaterialControllerHandle charMaterialControllerHandle = new CharMaterialControllerHandle();
			bool needLoop = data.DataType == ECharacterControllerType.Runtime;
			bool paused = data.DataType == ECharacterControllerType.Manual;
			bool hiddenAfterEffect = data.HiddenAfterEffect;
			int num = this.MaterialContainer.AddEffect(data, needLoop, paused, animObject, hiddenAfterEffect);
			if (num < 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RenderCharacter;
				ELogAuthor author = ELogAuthor.LSY;
				string message = "添加材质控制器失败";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("IdentifyName", this.MaterialContainer.IdentifyName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("AssetData", data);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return num;
			}
			charMaterialControllerHandle.HandleId = num;
			charMaterialControllerHandle.UserData = userData;
			charMaterialControllerHandle.AssetData = data;
			this.EffectsAdded[num] = charMaterialControllerHandle;
			if (data.ForceUpdateOnAdd)
			{
				this.MaterialContainer.UpdateEffectsOnly();
			}
			return num;
		}

		// Token: 0x0602DFAA RID: 188330 RVA: 0x00A9386C File Offset: 0x00A91A6C
		public bool RemoveMaterialControllerData(int handle)
		{
			CharMaterialControllerHandle charMaterialControllerHandle;
			if (this.EffectsAdded.TryGetValue(handle, out charMaterialControllerHandle))
			{
				CharMaterialContainerV2 materialContainer = this.MaterialContainer;
				if (materialContainer != null)
				{
					materialContainer.RemoveEffect(handle);
				}
				return true;
			}
			return false;
		}

		// Token: 0x0602DFAB RID: 188331 RVA: 0x00A938A0 File Offset: 0x00A91AA0
		public bool RemoveMaterialControllerDataWithEnding(int handle)
		{
			CharMaterialControllerHandle charMaterialControllerHandle;
			if (this.EffectsAdded.TryGetValue(handle, out charMaterialControllerHandle))
			{
				CharMaterialContainerV2 materialContainer = this.MaterialContainer;
				if (materialContainer != null)
				{
					materialContainer.SetEffectLoop(handle, false);
				}
				CharMaterialContainerV2 materialContainer2 = this.MaterialContainer;
				if (materialContainer2 != null)
				{
					materialContainer2.SetEffectPause(handle, false);
				}
				return true;
			}
			return false;
		}

		// Token: 0x0602DFAC RID: 188332 RVA: 0x00A938E8 File Offset: 0x00A91AE8
		public override void OnResetRenderState()
		{
			foreach (int num in this.EffectsAdded.Keys)
			{
				EventSystem.Instance.EmitWithTarget<int>(this, EEventName.OnRemoveMaterialController, num);
				this.RenderComponent.OnRemoveMaterialController(num);
			}
			this.EffectsAdded.Clear();
		}

		// Token: 0x0602DFAD RID: 188333 RVA: 0x00A93964 File Offset: 0x00A91B64
		public void CleanOriginEffectByOtherData()
		{
			foreach (KeyValuePair<int, CharMaterialControllerHandle> keyValuePair in this.EffectsAdded)
			{
				CharMaterialControllerHandle value = keyValuePair.Value;
				if (value.AssetData == null || !value.AssetData.NeverBeCleanedByOthers)
				{
					this.RemoveMaterialControllerData(value.HandleId);
				}
			}
		}

		// Token: 0x0602DFAE RID: 188334 RVA: 0x00A939DC File Offset: 0x00A91BDC
		private void OnEffectFinished(int handle)
		{
			CharMaterialControllerHandle charMaterialControllerHandle;
			if (this.EffectsAdded.TryGetValue(handle, out charMaterialControllerHandle))
			{
				this.EffectsAdded.Remove(handle);
				EventSystem.Instance.EmitWithTarget<int>(this.RenderComponent, EEventName.OnRemoveMaterialController, handle);
				this.RenderComponent.OnRemoveMaterialController(handle);
			}
		}

		// Token: 0x0602DFAF RID: 188335 RVA: 0x00A93A29 File Offset: 0x00A91C29
		public override void Update()
		{
		}

		// Token: 0x0602DFB0 RID: 188336 RVA: 0x00A93A2B File Offset: 0x00A91C2B
		public override void LateUpdate()
		{
		}

		// Token: 0x0602DFB1 RID: 188337 RVA: 0x00A93A2D File Offset: 0x00A91C2D
		public override void Destroy()
		{
		}

		// Token: 0x0602DFB2 RID: 188338 RVA: 0x00A93A2F File Offset: 0x00A91C2F
		public override int GetComponentId()
		{
			return 14;
		}

		// Token: 0x040188B7 RID: 100535
		[Nullable(2)]
		private CharMaterialContainerV2 MaterialContainer;

		// Token: 0x040188B8 RID: 100536
		private readonly Dictionary<int, CharMaterialControllerHandle> EffectsAdded = new Dictionary<int, CharMaterialControllerHandle>();
	}
}
