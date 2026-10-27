using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Collect
{
	// Token: 0x020051AD RID: 20909
	[NullableContext(1)]
	[Nullable(0)]
	public class CollectBadgeItem : GridProxyAbstract<int>
	{
		// Token: 0x0603589C RID: 219292 RVA: 0x00CAEA2C File Offset: 0x00CACC2C
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

		// Token: 0x0603589D RID: 219293 RVA: 0x00CAEAEB File Offset: 0x00CACCEB
		protected override void OnStart()
		{
			base.GetExtendToggle(0).CanExecuteChange.Bind(new Func<bool>(this.OnCanChange));
		}

		// Token: 0x0603589E RID: 219294 RVA: 0x00CAEB0C File Offset: 0x00CACD0C
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

		// Token: 0x0603589F RID: 219295 RVA: 0x00CAEBB9 File Offset: 0x00CACDB9
		private void OnClickBadge(EToggleState toggleState)
		{
			if (this.CallbackClickBadge != null && this.BadgeId > 0)
			{
				this.CallbackClickBadge(this.BadgeId);
			}
		}

		// Token: 0x060358A0 RID: 219296 RVA: 0x00CAEBE0 File Offset: 0x00CACDE0
		private bool OnCanChange()
		{
			if (this.CallbackCanChange != null && this.BadgeId > 0)
			{
				EToggleState toggleState = base.GetExtendToggle(0).GetToggleState();
				return this.CallbackCanChange(this.BadgeId, toggleState);
			}
			return false;
		}

		// Token: 0x060358A1 RID: 219297 RVA: 0x00CAEC1F File Offset: 0x00CACE1F
		private void SetSelected(bool isSelected)
		{
			if (isSelected)
			{
				this.OnSelected(false);
				return;
			}
			this.OnDeselected(false);
		}

		// Token: 0x060358A2 RID: 219298 RVA: 0x00CAEC33 File Offset: 0x00CACE33
		public override void OnSelected(bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, false, false, false);
		}

		// Token: 0x060358A3 RID: 219299 RVA: 0x00CAEC46 File Offset: 0x00CACE46
		public override void OnDeselected(bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x060358A4 RID: 219300 RVA: 0x00CAEC59 File Offset: 0x00CACE59
		public override object GetKey(int data, int displayIndex)
		{
			return this.BadgeId;
		}

		// Token: 0x0401C6CA RID: 116426
		private int BadgeId;

		// Token: 0x0401C6CB RID: 116427
		public Action<int> CallbackClickBadge;

		// Token: 0x0401C6CC RID: 116428
		public Func<int, EToggleState, bool> CallbackCanChange;

		// Token: 0x0200B334 RID: 45876
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x040364FD RID: 222461
			public const int ToggleBadge = 0;

			// Token: 0x040364FE RID: 222462
			public const int PanelLock = 1;

			// Token: 0x040364FF RID: 222463
			public const int SpriteLock = 2;

			// Token: 0x04036500 RID: 222464
			public const int PanelUnlock = 3;

			// Token: 0x04036501 RID: 222465
			public const int SpriteUnlock = 4;

			// Token: 0x04036502 RID: 222466
			public const int TextName = 5;
		}
	}
}
