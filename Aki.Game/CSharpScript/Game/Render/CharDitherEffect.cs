using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Manager;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialContainer;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x020034C7 RID: 13511
	[NullableContext(1)]
	[Nullable(0)]
	public class CharDitherEffect : CharRenderBase
	{
		// Token: 0x06022633 RID: 140851 RVA: 0x009BE04C File Offset: 0x009BC24C
		public override void Start()
		{
			if (this.RenderComponent.UseMaterialContainerV2)
			{
				this.MaterialContainerV2 = (this.RenderComponent.GetComponent(13) as CharMaterialContainerV2);
				this.MaterialContainer = null;
			}
			else
			{
				this.MaterialContainer = (this.RenderComponent.GetComponent(1) as CharMaterialContainer);
				this.MaterialContainerV2 = null;
			}
			if (this.MaterialContainer == null && this.MaterialContainerV2 == null)
			{
				Log.Instance.Error(ELogModule.RenderCharacter, ELogAuthor.HCS, "非NPC类型没有添加组件 material container", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			this.CachedDitherRate = 1f;
			this.DitheringRate = 0f;
			this.DitherOutRangeA = -0.2f;
			this.DitherOutRangeB = 1f;
			this.DitherType = ECharacterDitherType.UnDefined;
			this.IsDithering = false;
			this.DitherTypeMap = new Dictionary<ECharacterDitherType, bool>();
			base.OnInitSuccess();
		}

		// Token: 0x06022634 RID: 140852 RVA: 0x009BE11C File Offset: 0x009BC31C
		public override void OnResetRenderState()
		{
			this.SetDitherRate(1f);
			this.DitherType = ECharacterDitherType.UnDefined;
			this.IsDithering = false;
			this.DitherTypeMap.Clear();
		}

		// Token: 0x06022635 RID: 140853 RVA: 0x009BE142 File Offset: 0x009BC342
		public void UpdateNpcDitherComponent()
		{
		}

		// Token: 0x06022636 RID: 140854 RVA: 0x009BE144 File Offset: 0x009BC344
		public void SetDitherEffect(float ditherRate, ECharacterDitherType ditherType)
		{
			if (ditherRate == this.CachedDitherRate)
			{
				return;
			}
			if (ditherRate >= 0f && ditherRate < 1f)
			{
				this.DitherTypeMap[ditherType] = true;
				if (this.DitherType == ditherType || this.DitherType < ditherType)
				{
					this.DitherType = ditherType;
					if (!this.IsDithering)
					{
						this.EnableDitherEffect();
					}
					this.SetDitherRate(ditherRate);
					return;
				}
			}
			else
			{
				if (this.DitherTypeMap.ContainsKey(ditherType))
				{
					this.DitherTypeMap[ditherType] = false;
				}
				bool flag = false;
				ECharacterDitherType echaracterDitherType = ECharacterDitherType.UnDefined;
				foreach (KeyValuePair<ECharacterDitherType, bool> keyValuePair in this.DitherTypeMap)
				{
					bool value = keyValuePair.Value;
					ECharacterDitherType key = keyValuePair.Key;
					flag = (flag || value);
					if (value && echaracterDitherType < key)
					{
						echaracterDitherType = key;
					}
				}
				this.DitherType = echaracterDitherType;
				if (!flag && this.IsDithering)
				{
					this.RemoveDitherEffect();
				}
			}
		}

		// Token: 0x06022637 RID: 140855 RVA: 0x009BE24C File Offset: 0x009BC44C
		public void SetDitherMask(IEnumerable<EKuroCharMeshPart> mask, bool onlyDitherInMainPass)
		{
			this.DitherMask.Clear();
			this.DitherMask.AddRange(mask);
			this.OnlyDitherInMainPass = onlyDitherInMainPass;
			if (this.IsDithering)
			{
				this.DoRemoveDither();
				this.DoEnableDither();
				this.DoSetDitherParams(this.DitheringRate);
			}
		}

		// Token: 0x06022638 RID: 140856 RVA: 0x009BE28C File Offset: 0x009BC48C
		public void RemoveDitherEffect()
		{
			this.DoRemoveDither();
			this.SetDitherRate(1f);
			this.IsDithering = false;
		}

		// Token: 0x06022639 RID: 140857 RVA: 0x009BE2A6 File Offset: 0x009BC4A6
		public void TempRemoveDither()
		{
			if (this.IsDithering)
			{
				this.DoRemoveDither();
			}
		}

		// Token: 0x0602263A RID: 140858 RVA: 0x009BE2B6 File Offset: 0x009BC4B6
		public void TempRecoverDither()
		{
			if (this.IsDithering)
			{
				this.DoEnableDither();
			}
		}

		// Token: 0x0602263B RID: 140859 RVA: 0x009BE2C6 File Offset: 0x009BC4C6
		private void EnableDitherEffect()
		{
			this.DoEnableDither();
			this.IsDithering = true;
		}

		// Token: 0x0602263C RID: 140860 RVA: 0x009BE2D5 File Offset: 0x009BC4D5
		public override void PreBodyInfoRuntimeInit(FName bodyName)
		{
			if (this.IsDithering)
			{
				this.DoRemoveDither();
			}
		}

		// Token: 0x0602263D RID: 140861 RVA: 0x009BE2E5 File Offset: 0x009BC4E5
		public override void PostBodyInfoRuntimeInit(FName bodyName)
		{
			if (this.IsDithering)
			{
				this.DoEnableDither();
				this.DoSetDitherParams(this.DitheringRate);
			}
		}

		// Token: 0x0602263E RID: 140862 RVA: 0x009BE301 File Offset: 0x009BC501
		public override void Update()
		{
		}

		// Token: 0x0602263F RID: 140863 RVA: 0x009BE303 File Offset: 0x009BC503
		public override int GetComponentId()
		{
			return 3;
		}

		// Token: 0x06022640 RID: 140864 RVA: 0x009BE306 File Offset: 0x009BC506
		public float GetDitherRate()
		{
			return this.CachedDitherRate;
		}

		// Token: 0x06022641 RID: 140865 RVA: 0x009BE310 File Offset: 0x009BC510
		private void SetDitherRate(float ditherRate)
		{
			this.DitheringRate = MathUtils.Instance.RangeClamp(ditherRate, 0f, 1f, this.DitherOutRangeA, this.DitherOutRangeB);
			if ((double)Math.Abs(this.CachedDitherRate - ditherRate) < 1E-06)
			{
				return;
			}
			this.DoSetDitherParams(this.DitheringRate);
			this.CachedDitherRate = ditherRate;
		}

		// Token: 0x06022642 RID: 140866 RVA: 0x009BE374 File Offset: 0x009BC574
		private unsafe void DoEnableDither()
		{
			ECharacterRenderingType? renderType = base.GetRenderingComponent().RenderType;
			ECharacterRenderingType echaracterRenderingType = ECharacterRenderingType.Npc;
			if (!(renderType.GetValueOrDefault() == echaracterRenderingType & renderType != null))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RenderCharacter;
				ELogAuthor author = ELogAuthor.LSY;
				string message = "CharacterEnableDither";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
				string item = "CharName";
				CharRenderingComponent renderingComponent = base.GetRenderingComponent();
				ptr = new ValueTuple<string, object>(item, (renderingComponent != null) ? renderingComponent.GetCachedOwnerName() : null);
				ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
				string item2 = "Entity";
				CharRenderingComponent renderingComponent2 = base.GetRenderingComponent();
				int? num;
				if (renderingComponent2 == null)
				{
					num = null;
				}
				else
				{
					Entity cachedOwnerEntity = renderingComponent2.GetCachedOwnerEntity();
					num = ((cachedOwnerEntity != null) ? new int?(cachedOwnerEntity.Id) : null);
				}
				ptr2 = new ValueTuple<string, object>(item2, num);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Type", this.DitherType);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			}
			if (this.MaterialContainerV2 != null)
			{
				this.MaterialContainerV2.AddAlphaTestCount(EKuroCharBodySpecifiedType.All);
				if (this.DitherMask.Count > 0)
				{
					using (List<EKuroCharMeshPart>.Enumerator enumerator = this.DitherMask.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							EKuroCharMeshPart value = enumerator.Current;
							this.MaterialContainerV2.SetFloatUpdateParamPermanent(RenderConfig.UseDitherEffect, 1f, EKuroCharBodySpecifiedType.All, EKuroCharSlotSpecifiedType.All, new EKuroCharMeshPart?(value));
						}
						return;
					}
				}
				this.MaterialContainerV2.SetFloatUpdateParamPermanent(RenderConfig.UseDitherEffect, 1f, EKuroCharBodySpecifiedType.All, EKuroCharSlotSpecifiedType.All, null);
				return;
			}
			if (this.MaterialContainer != null)
			{
				this.MaterialContainer.UseAlphaTestCommon();
				this.MaterialContainer.SetFloat(new FName?(RenderConfig.UseDitherEffect), 1f, ECharacterBodySpecifiedType.All, ECharacterSlotSpecifiedType.All);
			}
		}

		// Token: 0x06022643 RID: 140867 RVA: 0x009BE538 File Offset: 0x009BC738
		private void DoSetDitherParams(float value)
		{
			if (this.MaterialContainerV2 != null)
			{
				this.MaterialContainerV2.SetFloatUpdateParamPermanent(RenderConfig.DitherValue, this.OnlyDitherInMainPass ? 1.2f : value, EKuroCharBodySpecifiedType.All, EKuroCharSlotSpecifiedType.All, null);
				this.MaterialContainerV2.SetFloatUpdateParamPermanent(RenderConfig.DitherValueMainPass, this.OnlyDitherInMainPass ? value : 1.2f, EKuroCharBodySpecifiedType.All, EKuroCharSlotSpecifiedType.All, null);
				return;
			}
			if (this.MaterialContainer != null)
			{
				this.MaterialContainer.SetFloat(new FName?(RenderConfig.DitherValue), this.OnlyDitherInMainPass ? 1.2f : value, ECharacterBodySpecifiedType.All, ECharacterSlotSpecifiedType.All);
				this.MaterialContainer.SetFloat(new FName?(RenderConfig.DitherValueMainPass), this.OnlyDitherInMainPass ? value : 1.2f, ECharacterBodySpecifiedType.All, ECharacterSlotSpecifiedType.All);
			}
		}

		// Token: 0x06022644 RID: 140868 RVA: 0x009BE5FC File Offset: 0x009BC7FC
		private unsafe void DoRemoveDither()
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RenderCharacter;
			ELogAuthor author = ELogAuthor.LSY;
			string message = "CharacterDisableDither";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
			string item = "CharName";
			CharRenderingComponent renderingComponent = base.GetRenderingComponent();
			ptr = new ValueTuple<string, object>(item, (renderingComponent != null) ? renderingComponent.GetCachedOwnerName() : null);
			ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
			string item2 = "Entity";
			CharRenderingComponent renderingComponent2 = base.GetRenderingComponent();
			int? num;
			if (renderingComponent2 == null)
			{
				num = null;
			}
			else
			{
				Entity cachedOwnerEntity = renderingComponent2.GetCachedOwnerEntity();
				num = ((cachedOwnerEntity != null) ? new int?(cachedOwnerEntity.Id) : null);
			}
			ptr2 = new ValueTuple<string, object>(item2, num);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Type", this.DitherType);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			if (this.MaterialContainerV2 != null)
			{
				this.MaterialContainerV2.RemoveFloatUpdateParamPermanent(RenderConfig.UseDitherEffect, EKuroCharBodySpecifiedType.All, EKuroCharSlotSpecifiedType.All, null);
				this.MaterialContainerV2.RemoveFloatUpdateParamPermanent(RenderConfig.DitherValue, EKuroCharBodySpecifiedType.All, EKuroCharSlotSpecifiedType.All, null);
				this.MaterialContainerV2.RemoveFloatUpdateParamPermanent(RenderConfig.DitherValueMainPass, EKuroCharBodySpecifiedType.All, EKuroCharSlotSpecifiedType.All, null);
				this.MaterialContainerV2.RemoveAlphaTestCount(EKuroCharBodySpecifiedType.All);
				return;
			}
			if (this.MaterialContainer != null)
			{
				this.MaterialContainer.RevertAlphaTestCommon();
				this.MaterialContainer.SetFloat(new FName?(RenderConfig.UseDitherEffect), 0f, ECharacterBodySpecifiedType.All, ECharacterSlotSpecifiedType.All);
			}
		}

		// Token: 0x06022645 RID: 140869 RVA: 0x009BE75B File Offset: 0x009BC95B
		public override string GetStatName()
		{
			return "CharDitherEffect";
		}

		// Token: 0x04012ECC RID: 77516
		[Nullable(2)]
		public CharMaterialContainer MaterialContainer;

		// Token: 0x04012ECD RID: 77517
		[Nullable(2)]
		public CharMaterialContainerV2 MaterialContainerV2;

		// Token: 0x04012ECE RID: 77518
		private float DitheringRate = --0f;

		// Token: 0x04012ECF RID: 77519
		private float DitherOutRangeA = --0f;

		// Token: 0x04012ED0 RID: 77520
		private float DitherOutRangeB = --0f;

		// Token: 0x04012ED1 RID: 77521
		private ECharacterDitherType DitherType;

		// Token: 0x04012ED2 RID: 77522
		private float CachedDitherRate = --0f;

		// Token: 0x04012ED3 RID: 77523
		private bool IsDithering;

		// Token: 0x04012ED4 RID: 77524
		[Nullable(2)]
		private Dictionary<ECharacterDitherType, bool> DitherTypeMap;

		// Token: 0x04012ED5 RID: 77525
		private bool OnlyDitherInMainPass;

		// Token: 0x04012ED6 RID: 77526
		private readonly List<EKuroCharMeshPart> DitherMask = new List<EKuroCharMeshPart>();
	}
}
