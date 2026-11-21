using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Collect
{
	// Token: 0x0200417D RID: 16765
	[NullableContext(1)]
	[Nullable(0)]
	public class CollectBadgeItem : GridProxyAbstract<int>
	{
		// Token: 0x0602A797 RID: 173975 RVA: 0x00BFC068 File Offset: 0x00BFA268
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUISprite)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUISprite)),
				new ValueTuple<int, Type>(5, typeof(UUIText))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickBadge))
			};
		}

		// Token: 0x0602A798 RID: 173976 RVA: 0x00BFC127 File Offset: 0x00BFA327
		protected override void OnStart()
		{
			base.GetExtendToggle(0).CanExecuteChange.Bind(new Func<bool>(this.OnCanChange));
		}

		// Token: 0x0602A799 RID: 173977 RVA: 0x00BFC148 File Offset: 0x00BFA348
		public override void Refresh(int data, bool isSelected, int gridIndex)
		{
			this.BadgeId = data;
			bool flag = PhantomArenaModel.Instance.IsBadgeUnlock(data);
			base.GetItem(1).SetUIActive(!flag);
			base.GetItem(3).SetUIActive(flag);
			PhantomBattleBadge phantomBattleBadgeById = PhantomArenaConfig.Instance.GetPhantomBattleBadgeById(data);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), phantomBattleBadgeById.Name, Array.Empty<object>());
			this.SetSpriteByPath(phantomBattleBadgeById.ShowIcon, base.GetSprite(4), false, null, null);
			this.SetSpriteByPath(phantomBattleBadgeById.ShowIcon, base.GetSprite(2), false, null, null);
			this.SetSelected(isSelected);
		}

		// Token: 0x0602A79A RID: 173978 RVA: 0x00BFC1F5 File Offset: 0x00BFA3F5
		private void OnClickBadge(EToggleState toggleState)
		{
			if (this.CallbackClickBadge != null && this.BadgeId > 0)
			{
				this.CallbackClickBadge(this.BadgeId);
			}
		}

		// Token: 0x0602A79B RID: 173979 RVA: 0x00BFC21C File Offset: 0x00BFA41C
		private bool OnCanChange()
		{
			if (this.CallbackCanChange != null && this.BadgeId > 0)
			{
				EToggleState toggleState = base.GetExtendToggle(0).GetToggleState();
				return this.CallbackCanChange(this.BadgeId, toggleState);
			}
			return false;
		}

		// Token: 0x0602A79C RID: 173980 RVA: 0x00BFC25B File Offset: 0x00BFA45B
		private void SetSelected(bool isSelected)
		{
			if (isSelected)
			{
				this.OnSelected(false);
				return;
			}
			this.OnDeselected(false);
		}

		// Token: 0x0602A79D RID: 173981 RVA: 0x00BFC26F File Offset: 0x00BFA46F
		public override void OnSelected(bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, false, false, false);
		}

		// Token: 0x0602A79E RID: 173982 RVA: 0x00BFC282 File Offset: 0x00BFA482
		public override void OnDeselected(bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x0602A79F RID: 173983 RVA: 0x00BFC295 File Offset: 0x00BFA495
		public override object GetKey(int data, int displayIndex)
		{
			return this.BadgeId;
		}

		// Token: 0x040170FF RID: 94463
		private int BadgeId;

		// Token: 0x04017100 RID: 94464
		public Action<int> CallbackClickBadge;

		// Token: 0x04017101 RID: 94465
		public Func<int, EToggleState, bool> CallbackCanChange;

		// Token: 0x02009D6C RID: 40300
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x04030F50 RID: 200528
			public const int ToggleBadge = 0;

			// Token: 0x04030F51 RID: 200529
			public const int PanelLock = 1;

			// Token: 0x04030F52 RID: 200530
			public const int SpriteLock = 2;

			// Token: 0x04030F53 RID: 200531
			public const int PanelUnlock = 3;

			// Token: 0x04030F54 RID: 200532
			public const int SpriteUnlock = 4;

			// Token: 0x04030F55 RID: 200533
			public const int TextName = 5;
		}
	}
}
