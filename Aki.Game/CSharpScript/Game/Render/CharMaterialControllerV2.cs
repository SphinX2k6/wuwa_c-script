using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Manager;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x020034CE RID: 13518
	[NullableContext(1)]
	[Nullable(0)]
	public class CharMaterialControllerV2 : CharRenderBase
	{
		// Token: 0x0602268E RID: 140942 RVA: 0x009BF896 File Offset: 0x009BDA96
		public override string GetStatName()
		{
			return "CharMaterialControllerV2";
		}

		// Token: 0x0602268F RID: 140943 RVA: 0x009BF89D File Offset: 0x009BDA9D
		public override void Start()
		{
			this.MaterialContainer = (base.GetRenderingComponent().GetComponent(13) as CharMaterialContainerV2);
			this.MaterialContainer.AddEffectFinishCallback(new Action<int>(this.OnEffectFinished));
			base.OnInitSuccess();
		}

		// Token: 0x06022690 RID: 140944 RVA: 0x009BF8D4 File Offset: 0x009BDAD4
		public int GetEffectCount()
		{
			return this.EffectsAdded.Count;
		}

		// Token: 0x06022691 RID: 140945 RVA: 0x009BF8E1 File Offset: 0x009BDAE1
		public bool GetRuntimeMaterialControllerValid(int handle)
		{
			return this.EffectsAdded.ContainsKey(handle);
		}

		// Token: 0x06022692 RID: 140946 RVA: 0x009BF8EF File Offset: 0x009BDAEF
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

		// Token: 0x06022693 RID: 140947 RVA: 0x009BF914 File Offset: 0x009BDB14
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

		// Token: 0x06022694 RID: 140948 RVA: 0x009BFA8C File Offset: 0x009BDC8C
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

		// Token: 0x06022695 RID: 140949 RVA: 0x009BFAC0 File Offset: 0x009BDCC0
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

		// Token: 0x06022696 RID: 140950 RVA: 0x009BFB08 File Offset: 0x009BDD08
		public override void OnResetRenderState()
		{
			foreach (int num in this.EffectsAdded.Keys)
			{
				EventSystem.Instance.EmitWithTarget<int>(this, EEventName.OnRemoveMaterialController, num);
				this.RenderComponent.OnRemoveMaterialController(num);
			}
			this.EffectsAdded.Clear();
		}

		// Token: 0x06022697 RID: 140951 RVA: 0x009BFB84 File Offset: 0x009BDD84
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

		// Token: 0x06022698 RID: 140952 RVA: 0x009BFBFC File Offset: 0x009BDDFC
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

		// Token: 0x06022699 RID: 140953 RVA: 0x009BFC49 File Offset: 0x009BDE49
		public override void Update()
		{
		}

		// Token: 0x0602269A RID: 140954 RVA: 0x009BFC4B File Offset: 0x009BDE4B
		public override void LateUpdate()
		{
		}

		// Token: 0x0602269B RID: 140955 RVA: 0x009BFC4D File Offset: 0x009BDE4D
		public override void Destroy()
		{
		}

		// Token: 0x0602269C RID: 140956 RVA: 0x009BFC4F File Offset: 0x009BDE4F
		public override int GetComponentId()
		{
			return 14;
		}

		// Token: 0x04012EF2 RID: 77554
		[Nullable(2)]
		private CharMaterialContainerV2 MaterialContainer;

		// Token: 0x04012EF3 RID: 77555
		private readonly Dictionary<int, CharMaterialControllerHandle> EffectsAdded = new Dictionary<int, CharMaterialControllerHandle>();
	}
}
