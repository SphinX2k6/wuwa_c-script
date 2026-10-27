using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Collect
{
	// Token: 0x020051AC RID: 20908
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class CollectBadgeGroupItem : GridProxyAbstract<CollectBadgeGroupData>
	{
		// Token: 0x0603588F RID: 219279 RVA: 0x00CAE888 File Offset: 0x00CACA88
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIGridLayout)),
				new ValueTuple<int, Type>(2, typeof(UUIItem))
			};
		}

		// Token: 0x06035890 RID: 219280 RVA: 0x00CAE8E2 File Offset: 0x00CACAE2
		protected override void OnStart()
		{
			this.LayoutBadge = new GenericLayout<CollectBadgeItem, int>(base.GetGridLayout(1), new Func<CollectBadgeItem>(this.CreateBadgeItem), null, false, true);
		}

		// Token: 0x06035891 RID: 219281 RVA: 0x00CAE905 File Offset: 0x00CACB05
		private CollectBadgeItem CreateBadgeItem()
		{
			return new CollectBadgeItem
			{
				CallbackClickBadge = new Action<int>(this.OnClickBadge),
				CallbackCanChange = new Func<int, EToggleState, bool>(this.OnCanChange)
			};
		}

		// Token: 0x06035892 RID: 219282 RVA: 0x00CAE930 File Offset: 0x00CACB30
		public override void Refresh(CollectBadgeGroupData data, bool isSelected, int gridIndex)
		{
			this.GroupId = data.GroupId;
			PhantomBattleBadgeGroup phantomBattleBadgeGroupById = PhantomArenaConfig.Instance.GetPhantomBattleBadgeGroupById(data.GroupId);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), phantomBattleBadgeGroupById.Name, Array.Empty<object>());
			this.LayoutBadge.RefreshByData(data.BadgeIdList, null, false);
		}

		// Token: 0x06035893 RID: 219283 RVA: 0x00CAE98A File Offset: 0x00CACB8A
		private void OnClickBadge(int badgeId)
		{
			if (this.CallbackClickBadge != null && this.GroupId > 0)
			{
				this.CallbackClickBadge(badgeId, this);
			}
		}

		// Token: 0x06035894 RID: 219284 RVA: 0x00CAE9AA File Offset: 0x00CACBAA
		private bool OnCanChange(int badgeId, EToggleState state)
		{
			return this.CallbackCanChange != null && this.GroupId > 0 && this.CallbackCanChange(badgeId, state);
		}

		// Token: 0x06035895 RID: 219285 RVA: 0x00CAE9CC File Offset: 0x00CACBCC
		public void SetSelect(int badgeId)
		{
			this.LayoutBadge.DeselectCurrentGridProxy();
			this.LayoutBadge.SelectGridProxyByKey(badgeId, false);
		}

		// Token: 0x06035896 RID: 219286 RVA: 0x00CAE9EB File Offset: 0x00CACBEB
		public void SetSelectByIndex(int index)
		{
			this.LayoutBadge.DeselectCurrentGridProxy();
			this.LayoutBadge.SelectGridProxy(index, false);
		}

		// Token: 0x06035897 RID: 219287 RVA: 0x00CAEA05 File Offset: 0x00CACC05
		public void SetDeselect()
		{
			this.LayoutBadge.DeselectCurrentGridProxy();
		}

		// Token: 0x06035898 RID: 219288 RVA: 0x00CAEA12 File Offset: 0x00CACC12
		public override void OnSelected(bool fireEvent)
		{
		}

		// Token: 0x06035899 RID: 219289 RVA: 0x00CAEA14 File Offset: 0x00CACC14
		public override void OnDeselected(bool fireEvent)
		{
		}

		// Token: 0x0603589A RID: 219290 RVA: 0x00CAEA16 File Offset: 0x00CACC16
		public override object GetKey(CollectBadgeGroupData data, int displayIndex)
		{
			return this.GroupId;
		}

		// Token: 0x0401C6C6 RID: 116422
		private int GroupId;

		// Token: 0x0401C6C7 RID: 116423
		private GenericLayout<CollectBadgeItem, int> LayoutBadge;

		// Token: 0x0401C6C8 RID: 116424
		public Action<int, CollectBadgeGroupItem> CallbackClickBadge;

		// Token: 0x0401C6C9 RID: 116425
		public Func<int, EToggleState, bool> CallbackCanChange;

		// Token: 0x0200B333 RID: 45875
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x040364FA RID: 222458
			public const int TextTypeName = 0;

			// Token: 0x040364FB RID: 222459
			public const int LayoutBadge = 1;

			// Token: 0x040364FC RID: 222460
			public const int ItemBadge = 2;
		}
	}
}
