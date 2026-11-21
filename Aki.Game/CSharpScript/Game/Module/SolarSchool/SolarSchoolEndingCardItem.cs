using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.AutoAttach;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005995 RID: 22933
	[NullableContext(2)]
	[Nullable(0)]
	public class SolarSchoolEndingCardItem : AutoAttachItem<SolarSchoolEnding>
	{
		// Token: 0x17006C24 RID: 27684
		// (get) Token: 0x060388CB RID: 231627 RVA: 0x00FD26BB File Offset: 0x00FD08BB
		// (set) Token: 0x060388CC RID: 231628 RVA: 0x00FD26C3 File Offset: 0x00FD08C3
		public Action<int> SelectCallback { get; set; }

		// Token: 0x17006C25 RID: 27685
		// (get) Token: 0x060388CD RID: 231629 RVA: 0x00FD26CC File Offset: 0x00FD08CC
		// (set) Token: 0x060388CE RID: 231630 RVA: 0x00FD26D4 File Offset: 0x00FD08D4
		public Action<int> AttachCallback { get; set; }

		// Token: 0x17006C26 RID: 27686
		// (get) Token: 0x060388CF RID: 231631 RVA: 0x00FD26DD File Offset: 0x00FD08DD
		// (set) Token: 0x060388D0 RID: 231632 RVA: 0x00FD26E5 File Offset: 0x00FD08E5
		public Func<bool> CanClickCallback { get; set; }

		// Token: 0x17006C27 RID: 27687
		// (get) Token: 0x060388D1 RID: 231633 RVA: 0x00FD26EE File Offset: 0x00FD08EE
		// (set) Token: 0x060388D2 RID: 231634 RVA: 0x00FD26F6 File Offset: 0x00FD08F6
		public UCurveFloat MoveCurve { get; set; }

		// Token: 0x17006C28 RID: 27688
		// (get) Token: 0x060388D3 RID: 231635 RVA: 0x00FD26FF File Offset: 0x00FD08FF
		// (set) Token: 0x060388D4 RID: 231636 RVA: 0x00FD2707 File Offset: 0x00FD0907
		public float ItemSpacing { get; set; }

		// Token: 0x17006C29 RID: 27689
		// (get) Token: 0x060388D5 RID: 231637 RVA: 0x00FD2710 File Offset: 0x00FD0910
		// (set) Token: 0x060388D6 RID: 231638 RVA: 0x00FD2718 File Offset: 0x00FD0918
		public float SelectedItemSpacing { get; set; }

		// Token: 0x17006C2A RID: 27690
		// (get) Token: 0x060388D7 RID: 231639 RVA: 0x00FD2721 File Offset: 0x00FD0921
		// (set) Token: 0x060388D8 RID: 231640 RVA: 0x00FD2729 File Offset: 0x00FD0929
		public int MaxHierarchyIndex { get; set; }

		// Token: 0x060388D9 RID: 231641 RVA: 0x00FD2732 File Offset: 0x00FD0932
		public SolarSchoolEndingCardItem(AActor actor = null) : base(actor)
		{
		}

		// Token: 0x060388DA RID: 231642 RVA: 0x00FD273C File Offset: 0x00FD093C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060388DB RID: 231643 RVA: 0x00FD2890 File Offset: 0x00FD0A90
		protected override void OnStart()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle != null)
			{
				extendToggle.CanExecuteChange.Bind(new Func<bool>(this.CanClick));
			}
			UUIHorizontalLayout horizontalLayout = base.GetHorizontalLayout(4);
			UUIItem item = base.GetItem(5);
			AUIBaseActor auibaseActor = ((item != null) ? item.GetOwner() : null) as AUIBaseActor;
			if (horizontalLayout != null && auibaseActor != null)
			{
				this.StarLayout = new GenericLayout<SolarSchoolStarItem, bool>(horizontalLayout, () => new SolarSchoolStarItem(), auibaseActor, false, true);
			}
		}

		// Token: 0x060388DC RID: 231644 RVA: 0x00FD2915 File Offset: 0x00FD0B15
		protected override UUIExtendToggle GetSelectToggle()
		{
			return base.GetExtendToggle(0);
		}

		// Token: 0x060388DD RID: 231645 RVA: 0x00FD2920 File Offset: 0x00FD0B20
		protected override void OnRefreshItem(SolarSchoolEnding data)
		{
			this.Data = new SolarSchoolEnding?(data);
			string text = (SolarSchoolGamePlayModel.Instance.GetPlayerGender() == EPlayerGender.Male) ? data.IconMale : data.IconFemale;
			bool flag = !string.IsNullOrEmpty(text);
			UUITexture texture = base.GetTexture(1);
			if (texture != null)
			{
				texture.SetUIActive(flag);
			}
			if (flag)
			{
				base.SetTextureByPath(text, base.GetTexture(1), null, null);
			}
			UUIItem item = base.GetItem(2);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			base.SetTextureByPath(data.IconQuality, base.GetTexture(3), null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(6), data.Desc ?? string.Empty, Array.Empty<object>());
			bool[] array = new bool[Math.Max(0, data.Star)];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = true;
			}
			GenericLayout<SolarSchoolStarItem, bool> starLayout = this.StarLayout;
			if (starLayout == null)
			{
				return;
			}
			starLayout.RefreshByData(array, null, false);
		}

		// Token: 0x060388DE RID: 231646 RVA: 0x00FD2A28 File Offset: 0x00FD0C28
		public override void OnSelect()
		{
			UUIItem item = base.GetItem(7);
			if (item != null)
			{
				item.SetUIActive(true);
			}
			if (this.Data != null)
			{
				Action<int> selectCallback = this.SelectCallback;
				if (selectCallback == null)
				{
					return;
				}
				selectCallback(this.Data.Value.Id);
			}
		}

		// Token: 0x060388DF RID: 231647 RVA: 0x00FD2A78 File Offset: 0x00FD0C78
		protected override void OnUnSelect()
		{
			UUIItem item = base.GetItem(7);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
		}

		// Token: 0x060388E0 RID: 231648 RVA: 0x00FD2A8C File Offset: 0x00FD0C8C
		protected override void OnMoveItem()
		{
			if (this.RootItem == null)
			{
				return;
			}
			float currentPosition = base.GetCurrentPosition();
			float num = Math.Max(this.ItemSpacing, 1f);
			float num2 = Math.Abs(currentPosition);
			UCurveFloat moveCurve = this.MoveCurve;
			float num3 = Math.Clamp((moveCurve != null) ? moveCurve.GetFloatValue(base.GetCurrentMovePercentage()) : (1f - Math.Clamp(num2 / num, 0f, 1f)), 0f, 1f);
			float num4 = 0.55f + 0.45f * num3;
			int num5 = (int)MathF.Round(num2 / num);
			int hierarchyIndex = Math.Max(0, this.MaxHierarchyIndex - num5);
			float inYaw = -15f * num3;
			float num6 = Math.Max(this.SelectedItemSpacing - num, 0f);
			float anchorOffsetX = Math.Clamp(currentPosition / num, -1f, 1f) * num6 / num4;
			this.RootItem.SetAnchorOffsetY(0f);
			this.RootItem.SetUIItemScale(new FVector(num4, num4, 1f));
			UUIItem rootItem = this.RootItem;
			FRotator frotator = new FRotator(0f, inYaw, 0f);
			rootItem.SetUIRelativeRotation(frotator);
			this.RootItem.SetHierarchyIndex(hierarchyIndex);
			UUIItem item = base.GetItem(8);
			if (item == null)
			{
				return;
			}
			item.SetAnchorOffsetX(anchorOffsetX);
		}

		// Token: 0x060388E1 RID: 231649 RVA: 0x00FD2BC5 File Offset: 0x00FD0DC5
		protected override void OnSelectToggleClick()
		{
			Action<int> attachCallback = this.AttachCallback;
			if (attachCallback == null)
			{
				return;
			}
			attachCallback(base.GetCurrentShowItemIndex());
		}

		// Token: 0x060388E2 RID: 231650 RVA: 0x00FD2BDD File Offset: 0x00FD0DDD
		private bool CanClick()
		{
			Func<bool> canClickCallback = this.CanClickCallback;
			return canClickCallback != null && canClickCallback();
		}

		// Token: 0x060388E3 RID: 231651 RVA: 0x00FD2BF0 File Offset: 0x00FD0DF0
		protected override void OnBeforeDestroy()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.CanExecuteChange.Unbind();
		}

		// Token: 0x0401DC8E RID: 121998
		private const float CARD_ANGLE_DEGREES = 15f;

		// Token: 0x0401DC8F RID: 121999
		private const float MIN_SCALE = 0.55f;

		// Token: 0x0401DC90 RID: 122000
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<SolarSchoolStarItem, bool> StarLayout;

		// Token: 0x0401DC91 RID: 122001
		private SolarSchoolEnding? Data;

		// Token: 0x0200B53D RID: 46397
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x04038098 RID: 229528
			public const int Toggle = 0;

			// Token: 0x04038099 RID: 229529
			public const int Icon = 1;

			// Token: 0x0403809A RID: 229530
			public const int PnlLock = 2;

			// Token: 0x0403809B RID: 229531
			public const int TexQuality = 3;

			// Token: 0x0403809C RID: 229532
			public const int StarLayout = 4;

			// Token: 0x0403809D RID: 229533
			public const int StarItem = 5;

			// Token: 0x0403809E RID: 229534
			public const int TxtName = 6;

			// Token: 0x0403809F RID: 229535
			public const int PnlSelect = 7;

			// Token: 0x040380A0 RID: 229536
			public const int PnlOffset = 8;
		}
	}
}
