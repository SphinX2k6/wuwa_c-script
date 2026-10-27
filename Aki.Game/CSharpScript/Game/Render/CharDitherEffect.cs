using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Manager;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialContainer;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x0200459F RID: 17823
	[NullableContext(1)]
	[Nullable(0)]
	public class CharDitherEffect : CharRenderBase
	{
		// Token: 0x0602DF49 RID: 188233 RVA: 0x00A91E2C File Offset: 0x00A9002C
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

		// Token: 0x0602DF4A RID: 188234 RVA: 0x00A91EFC File Offset: 0x00A900FC
		public override void OnResetRenderState()
		{
			this.SetDitherRate(1f);
			this.DitherType = ECharacterDitherType.UnDefined;
			this.IsDithering = false;
			this.DitherTypeMap.Clear();
		}

		// Token: 0x0602DF4B RID: 188235 RVA: 0x00A91F22 File Offset: 0x00A90122
		public void UpdateNpcDitherComponent()
		{
		}

		// Token: 0x0602DF4C RID: 188236 RVA: 0x00A91F24 File Offset: 0x00A90124
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

		// Token: 0x0602DF4D RID: 188237 RVA: 0x00A9202C File Offset: 0x00A9022C
		public void SetDitherMask(List<EKuroCharMeshPart> mask, bool onlyDitherInMainPass)
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

		// Token: 0x0602DF4E RID: 188238 RVA: 0x00A9206C File Offset: 0x00A9026C
		public void RemoveDitherEffect()
		{
			this.DoRemoveDither();
			this.SetDitherRate(1f);
			this.IsDithering = false;
		}

		// Token: 0x0602DF4F RID: 188239 RVA: 0x00A92086 File Offset: 0x00A90286
		public void TempRemoveDither()
		{
			if (this.IsDithering)
			{
				this.DoRemoveDither();
			}
		}

		// Token: 0x0602DF50 RID: 188240 RVA: 0x00A92096 File Offset: 0x00A90296
		public void TempRecoverDither()
		{
			if (this.IsDithering)
			{
				this.DoEnableDither();
			}
		}

		// Token: 0x0602DF51 RID: 188241 RVA: 0x00A920A6 File Offset: 0x00A902A6
		private void EnableDitherEffect()
		{
			this.DoEnableDither();
			this.IsDithering = true;
		}

		// Token: 0x0602DF52 RID: 188242 RVA: 0x00A920B5 File Offset: 0x00A902B5
		public override void PreBodyInfoRuntimeInit(FName bodyName)
		{
			if (this.IsDithering)
			{
				this.DoRemoveDither();
			}
		}

		// Token: 0x0602DF53 RID: 188243 RVA: 0x00A920C5 File Offset: 0x00A902C5
		public override void PostBodyInfoRuntimeInit(FName bodyName)
		{
			if (this.IsDithering)
			{
				this.DoEnableDither();
				this.DoSetDitherParams(this.DitheringRate);
			}
		}

		// Token: 0x0602DF54 RID: 188244 RVA: 0x00A920E1 File Offset: 0x00A902E1
		public override void Update()
		{
		}

		// Token: 0x0602DF55 RID: 188245 RVA: 0x00A920E3 File Offset: 0x00A902E3
		public override int GetComponentId()
		{
			return 3;
		}

		// Token: 0x0602DF56 RID: 188246 RVA: 0x00A920E6 File Offset: 0x00A902E6
		public float GetDitherRate()
		{
			return this.CachedDitherRate;
		}

		// Token: 0x0602DF57 RID: 188247 RVA: 0x00A920F0 File Offset: 0x00A902F0
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

		// Token: 0x0602DF58 RID: 188248 RVA: 0x00A92154 File Offset: 0x00A90354
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

		// Token: 0x0602DF59 RID: 188249 RVA: 0x00A92318 File Offset: 0x00A90518
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

		// Token: 0x0602DF5A RID: 188250 RVA: 0x00A923DC File Offset: 0x00A905DC
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

		// Token: 0x0602DF5B RID: 188251 RVA: 0x00A9253B File Offset: 0x00A9073B
		public override string GetStatName()
		{
			return "CharDitherEffect";
		}

		// Token: 0x04018891 RID: 100497
		[Nullable(2)]
		public CharMaterialContainer MaterialContainer;

		// Token: 0x04018892 RID: 100498
		[Nullable(2)]
		public CharMaterialContainerV2 MaterialContainerV2;

		// Token: 0x04018893 RID: 100499
		private float DitheringRate = --0f;

		// Token: 0x04018894 RID: 100500
		private float DitherOutRangeA = --0f;

		// Token: 0x04018895 RID: 100501
		private float DitherOutRangeB = --0f;

		// Token: 0x04018896 RID: 100502
		private ECharacterDitherType DitherType;

		// Token: 0x04018897 RID: 100503
		private float CachedDitherRate = --0f;

		// Token: 0x04018898 RID: 100504
		private bool IsDithering;

		// Token: 0x04018899 RID: 100505
		[Nullable(2)]
		private Dictionary<ECharacterDitherType, bool> DitherTypeMap;

		// Token: 0x0401889A RID: 100506
		private bool OnlyDitherInMainPass;

		// Token: 0x0401889B RID: 100507
		private readonly List<EKuroCharMeshPart> DitherMask = new List<EKuroCharMeshPart>();
	}
}
