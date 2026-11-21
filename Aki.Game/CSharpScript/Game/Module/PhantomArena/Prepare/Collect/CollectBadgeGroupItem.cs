using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Collect
{
	// Token: 0x0200417C RID: 16764
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class CollectBadgeGroupItem : GridProxyAbstract<CollectBadgeGroupData>
	{
		// Token: 0x0602A78A RID: 173962 RVA: 0x00BFBEC4 File Offset: 0x00BFA0C4
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIGridLayout)),
				new ValueTuple<int, Type>(2, typeof(UUIItem))
			};
		}

		// Token: 0x0602A78B RID: 173963 RVA: 0x00BFBF1E File Offset: 0x00BFA11E
		protected override void OnStart()
		{
			this.LayoutBadge = new GenericLayout<CollectBadgeItem, int>(base.GetGridLayout(1), new Func<CollectBadgeItem>(this.CreateBadgeItem), null, false, true);
		}

		// Token: 0x0602A78C RID: 173964 RVA: 0x00BFBF41 File Offset: 0x00BFA141
		private CollectBadgeItem CreateBadgeItem()
		{
			return new CollectBadgeItem
			{
				CallbackClickBadge = new Action<int>(this.OnClickBadge),
				CallbackCanChange = new Func<int, EToggleState, bool>(this.OnCanChange)
			};
		}

		// Token: 0x0602A78D RID: 173965 RVA: 0x00BFBF6C File Offset: 0x00BFA16C
		public override void Refresh(CollectBadgeGroupData data, bool isSelected, int gridIndex)
		{
			this.GroupId = data.GroupId;
			PhantomBattleBadgeGroup phantomBattleBadgeGroupById = PhantomArenaConfig.Instance.GetPhantomBattleBadgeGroupById(data.GroupId);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), phantomBattleBadgeGroupById.Name, Array.Empty<object>());
			this.LayoutBadge.RefreshByData(data.BadgeIdList, null, false);
		}

		// Token: 0x0602A78E RID: 173966 RVA: 0x00BFBFC6 File Offset: 0x00BFA1C6
		private void OnClickBadge(int badgeId)
		{
			if (this.CallbackClickBadge != null && this.GroupId > 0)
			{
				this.CallbackClickBadge(badgeId, this);
			}
		}

		// Token: 0x0602A78F RID: 173967 RVA: 0x00BFBFE6 File Offset: 0x00BFA1E6
		private bool OnCanChange(int badgeId, EToggleState state)
		{
			return this.CallbackCanChange != null && this.GroupId > 0 && this.CallbackCanChange(badgeId, state);
		}

		// Token: 0x0602A790 RID: 173968 RVA: 0x00BFC008 File Offset: 0x00BFA208
		public void SetSelect(int badgeId)
		{
			this.LayoutBadge.DeselectCurrentGridProxy();
			this.LayoutBadge.SelectGridProxyByKey(badgeId, false);
		}

		// Token: 0x0602A791 RID: 173969 RVA: 0x00BFC027 File Offset: 0x00BFA227
		public void SetSelectByIndex(int index)
		{
			this.LayoutBadge.DeselectCurrentGridProxy();
			this.LayoutBadge.SelectGridProxy(index, false);
		}

		// Token: 0x0602A792 RID: 173970 RVA: 0x00BFC041 File Offset: 0x00BFA241
		public void SetDeselect()
		{
			this.LayoutBadge.DeselectCurrentGridProxy();
		}

		// Token: 0x0602A793 RID: 173971 RVA: 0x00BFC04E File Offset: 0x00BFA24E
		public override void OnSelected(bool fireEvent)
		{
		}

		// Token: 0x0602A794 RID: 173972 RVA: 0x00BFC050 File Offset: 0x00BFA250
		public override void OnDeselected(bool fireEvent)
		{
		}

		// Token: 0x0602A795 RID: 173973 RVA: 0x00BFC052 File Offset: 0x00BFA252
		public override object GetKey(CollectBadgeGroupData data, int displayIndex)
		{
			return this.GroupId;
		}

		// Token: 0x040170FB RID: 94459
		private int GroupId;

		// Token: 0x040170FC RID: 94460
		private GenericLayout<CollectBadgeItem, int> LayoutBadge;

		// Token: 0x040170FD RID: 94461
		public Action<int, CollectBadgeGroupItem> CallbackClickBadge;

		// Token: 0x040170FE RID: 94462
		public Func<int, EToggleState, bool> CallbackCanChange;

		// Token: 0x02009D6B RID: 40299
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x04030F4D RID: 200525
			public const int TextTypeName = 0;

			// Token: 0x04030F4E RID: 200526
			public const int LayoutBadge = 1;

			// Token: 0x04030F4F RID: 200527
			public const int ItemBadge = 2;
		}
	}
}
