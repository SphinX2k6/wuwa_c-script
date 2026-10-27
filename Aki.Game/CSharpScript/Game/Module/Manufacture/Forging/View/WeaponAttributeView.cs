using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Manufacture.Forging.View
{
	// Token: 0x0200564E RID: 22094
	[NullableContext(1)]
	[Nullable(0)]
	public class WeaponAttributeView : UiPanelBase
	{
		// Token: 0x060382B6 RID: 230070 RVA: 0x00D4E138 File Offset: 0x00D4C338
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>();
		}

		// Token: 0x060382B7 RID: 230071 RVA: 0x00D4E254 File Offset: 0x00D4C454
		protected override void OnStart()
		{
			if (this.FirstAttributeComponent == null)
			{
				this.FirstAttributeComponent = new AttributeItemInternal();
				this.FirstAttributeComponent.CreateThenShowByActor(base.GetItem(5).GetOwner());
			}
			if (this.SecondAttributeComponent == null)
			{
				this.SecondAttributeComponent = new AttributeItemInternal();
				this.SecondAttributeComponent.CreateThenShowByActor(base.GetItem(6).GetOwner());
			}
			this.StarView = new GenericLayout<WeaponAttributeView.StarItem, EStartState>(base.GetHorizontalLayout(3), new Func<WeaponAttributeView.StarItem>(this.InitStarItem), null, false, true);
			TArray<UUIItem> attachUIChildren = this.StarView.GetRootUiItem().GetAttachUIChildren();
			for (int i = 0; i < attachUIChildren.Num(); i++)
			{
				attachUIChildren.Get(i).SetUIActive(false);
			}
		}

		// Token: 0x060382B8 RID: 230072 RVA: 0x00D4E305 File Offset: 0x00D4C505
		private WeaponAttributeView.StarItem InitStarItem()
		{
			return new WeaponAttributeView.StarItem();
		}

		// Token: 0x060382B9 RID: 230073 RVA: 0x00D4E30C File Offset: 0x00D4C50C
		private void RefreshSkillNameText()
		{
			WeaponReson? weaponResonanceConfig = global::WeaponConfig.Instance.GetWeaponResonanceConfig(this.WeaponConfig.Value.ResonId, 1);
			if (weaponResonanceConfig != null)
			{
				base.GetText(1).ShowTextNew(weaponResonanceConfig.Value.Name);
			}
		}

		// Token: 0x060382BA RID: 230074 RVA: 0x00D4E35C File Offset: 0x00D4C55C
		private void RefreshStar()
		{
			List<EStartState> data = new List<EStartState>(WeaponModel.Instance.GetWeaponBreachMaxLevel(this.WeaponConfig.Value.BreachId));
			this.StarView.RefreshByData(data, null, false);
		}

		// Token: 0x060382BB RID: 230075 RVA: 0x00D4E39C File Offset: 0x00D4C59C
		private void RefreshWeaponLevel()
		{
			int num = 1;
			int levelLimit = this.WeaponBreachConfig.Value.LevelLimit;
			LguiUtil.Instance.SetLocalText(base.GetText(2), "ForgingWeaponLevel", new <>z__ReadOnlyArray<object>(new object[]
			{
				num,
				levelLimit
			}));
		}

		// Token: 0x060382BC RID: 230076 RVA: 0x00D4E3F4 File Offset: 0x00D4C5F4
		private void RefreshWeaponAttribute()
		{
			this.FirstAttributeComponent.UpdateParam(this.WeaponConfig.Value.FirstPropId.Value.Id, this.WeaponConfig.Value.FirstPropId.Value.IsRatio);
			float curveValue = WeaponModel.Instance.GetCurveValue(this.WeaponConfig.Value.FirstCurve, this.WeaponConfig.Value.FirstPropId.Value.Value, 1, 0);
			this.FirstAttributeComponent.SetCurrentValue(curveValue);
			this.SecondAttributeComponent.UpdateParam(this.WeaponConfig.Value.SecondPropId.Value.Id, this.WeaponConfig.Value.SecondPropId.Value.IsRatio);
			float curveValue2 = WeaponModel.Instance.GetCurveValue(this.WeaponConfig.Value.SecondCurve, this.WeaponConfig.Value.SecondPropId.Value.Value, 1, 0);
			this.SecondAttributeComponent.SetCurrentValue(curveValue2);
			LguiUtil.Instance.SetLocalText(base.GetText(0), "WeaponResonanceItemLevelText", new <>z__ReadOnlySingleElementList<object>("1"));
		}

		// Token: 0x060382BD RID: 230077 RVA: 0x00D4E568 File Offset: 0x00D4C768
		public void RefreshTips(IWeaponForgingData data)
		{
			ForgeFormula? forgeFormulaById = ForgingConfig.Instance.GetForgeFormulaById(data.ItemId);
			this.WeaponConfig = global::WeaponConfig.Instance.GetWeaponConfigByItemId(forgeFormulaById.Value.ItemId);
			this.WeaponBreachConfig = global::WeaponConfig.Instance.GetWeaponBreach(this.WeaponConfig.Value.BreachId, 1);
			this.RefreshSkillNameText();
			this.RefreshWeaponLevel();
			this.RefreshStar();
			this.RefreshWeaponAttribute();
		}

		// Token: 0x0401D8C3 RID: 121027
		private WeaponConf? WeaponConfig;

		// Token: 0x0401D8C4 RID: 121028
		private WeaponBreach? WeaponBreachConfig;

		// Token: 0x0401D8C5 RID: 121029
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<WeaponAttributeView.StarItem, EStartState> StarView;

		// Token: 0x0401D8C6 RID: 121030
		[Nullable(2)]
		private AttributeItemInternal FirstAttributeComponent;

		// Token: 0x0401D8C7 RID: 121031
		[Nullable(2)]
		private AttributeItemInternal SecondAttributeComponent;

		// Token: 0x0401D8C8 RID: 121032
		private const int CurrentLevel = 1;

		// Token: 0x0401D8C9 RID: 121033
		private const int CurrentBreach = 0;

		// Token: 0x0200B801 RID: 47105
		[Nullable(0)]
		public class StarItem : UiPanelBase, IGridProxy<EStartState>
		{
			// Token: 0x1700A1B8 RID: 41400
			// (get) Token: 0x0604F304 RID: 324356 RVA: 0x0152D732 File Offset: 0x0152B932
			// (set) Token: 0x0604F305 RID: 324357 RVA: 0x0152D73A File Offset: 0x0152B93A
			[Nullable(new byte[]
			{
				2,
				1
			})]
			public IScrollViewDelegate<IGridProxy<EStartState>, EStartState> ScrollViewDelegate { [return: Nullable(new byte[]
			{
				2,
				1
			})] get; [param: Nullable(new byte[]
			{
				2,
				1
			})] set; }

			// Token: 0x1700A1B9 RID: 41401
			// (get) Token: 0x0604F306 RID: 324358 RVA: 0x0152D743 File Offset: 0x0152B943
			// (set) Token: 0x0604F307 RID: 324359 RVA: 0x0152D74B File Offset: 0x0152B94B
			public int GridIndex { get; set; }

			// Token: 0x1700A1BA RID: 41402
			// (get) Token: 0x0604F308 RID: 324360 RVA: 0x0152D754 File Offset: 0x0152B954
			// (set) Token: 0x0604F309 RID: 324361 RVA: 0x0152D75C File Offset: 0x0152B95C
			public int DisplayIndex { get; set; }

			// Token: 0x0604F30A RID: 324362 RVA: 0x0152D765 File Offset: 0x0152B965
			public void Refresh(EStartState data, bool isSelected, int gridIndex)
			{
				if (data == EStartState.ON)
				{
					base.GetSprite(0).SetUIActive(true);
					base.GetSprite(1).SetUIActive(false);
					return;
				}
				base.GetSprite(0).SetUIActive(false);
				base.GetSprite(1).SetUIActive(true);
			}

			// Token: 0x0604F30B RID: 324363 RVA: 0x0152D7A2 File Offset: 0x0152B9A2
			public void Clear()
			{
			}

			// Token: 0x0604F30C RID: 324364 RVA: 0x0152D7A4 File Offset: 0x0152B9A4
			public void OnSelected(bool fireEvent)
			{
			}

			// Token: 0x0604F30D RID: 324365 RVA: 0x0152D7A6 File Offset: 0x0152B9A6
			public void OnDeselected(bool fireEvent)
			{
			}

			// Token: 0x0604F30E RID: 324366 RVA: 0x0152D7A8 File Offset: 0x0152B9A8
			public void CreateThenShowByActor(AActor actor)
			{
				base.CreateThenShowByActor(actor, null);
			}

			// Token: 0x0604F30F RID: 324367 RVA: 0x0152D7B4 File Offset: 0x0152B9B4
			public UniTask CreateThenShowByActorAsync(AActor actor)
			{
				WeaponAttributeView.StarItem.<CreateThenShowByActorAsync>d__18 <CreateThenShowByActorAsync>d__;
				<CreateThenShowByActorAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<CreateThenShowByActorAsync>d__.<>4__this = this;
				<CreateThenShowByActorAsync>d__.actor = actor;
				<CreateThenShowByActorAsync>d__.<>1__state = -1;
				<CreateThenShowByActorAsync>d__.<>t__builder.Start<WeaponAttributeView.StarItem.<CreateThenShowByActorAsync>d__18>(ref <CreateThenShowByActorAsync>d__);
				return <CreateThenShowByActorAsync>d__.<>t__builder.Task;
			}

			// Token: 0x0604F310 RID: 324368 RVA: 0x0152D800 File Offset: 0x0152BA00
			public UniTask CreateByActorAsync(AActor actor)
			{
				WeaponAttributeView.StarItem.<CreateByActorAsync>d__19 <CreateByActorAsync>d__;
				<CreateByActorAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<CreateByActorAsync>d__.<>4__this = this;
				<CreateByActorAsync>d__.actor = actor;
				<CreateByActorAsync>d__.<>1__state = -1;
				<CreateByActorAsync>d__.<>t__builder.Start<WeaponAttributeView.StarItem.<CreateByActorAsync>d__19>(ref <CreateByActorAsync>d__);
				return <CreateByActorAsync>d__.<>t__builder.Task;
			}

			// Token: 0x0604F311 RID: 324369 RVA: 0x0152D84B File Offset: 0x0152BA4B
			public object GetKey(EStartState data, int gridIndex)
			{
				return data;
			}

			// Token: 0x0604F312 RID: 324370 RVA: 0x0152D854 File Offset: 0x0152BA54
			protected unsafe override void OnRegisterComponent()
			{
				int num = 3;
				List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
				CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
				Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
				int num2 = 0;
				*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
				num2++;
				*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
				num2++;
				*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
				this.ComponentRegisterInfos = list;
				this.BtnBindInfo = new List<ValueTuple<int, Delegate>>();
			}

			// Token: 0x0604F313 RID: 324371 RVA: 0x0152D8E9 File Offset: 0x0152BAE9
			protected override void OnStart()
			{
				base.GetSprite(2).SetUIActive(false);
			}

			// Token: 0x0604F314 RID: 324372 RVA: 0x0152D8F8 File Offset: 0x0152BAF8
			public void SetState(bool isOn)
			{
			}

			// Token: 0x0200D163 RID: 53603
			[NullableContext(0)]
			public class EStarItemComponents
			{
				// Token: 0x0403ED72 RID: 257394
				public const int ImgStarOn = 0;

				// Token: 0x0403ED73 RID: 257395
				public const int ImgStarOff = 1;

				// Token: 0x0403ED74 RID: 257396
				public const int ImgStarNext = 2;
			}
		}

		// Token: 0x0200B802 RID: 47106
		[NullableContext(0)]
		private class EWeaponAttributeComponents
		{
			// Token: 0x04037AA9 RID: 228009
			public const int TxtSkillGrade = 0;

			// Token: 0x04037AAA RID: 228010
			public const int TxtSkillName = 1;

			// Token: 0x04037AAB RID: 228011
			public const int TxtLevel = 2;

			// Token: 0x04037AAC RID: 228012
			public const int PnlStar = 3;

			// Token: 0x04037AAD RID: 228013
			public const int PnlAttr = 4;

			// Token: 0x04037AAE RID: 228014
			public const int FirstAttributeItem = 5;

			// Token: 0x04037AAF RID: 228015
			public const int SecondAttributeItem = 6;
		}
	}
}
