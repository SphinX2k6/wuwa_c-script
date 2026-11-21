using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Entrance
{
	// Token: 0x0200412D RID: 16685
	public class EntranceGymRepeatItem : GymItemBase
	{
		// Token: 0x0602A2F7 RID: 172791 RVA: 0x00BE92D8 File Offset: 0x00BE74D8
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUISprite)),
				new ValueTuple<int, Type>(5, typeof(UUITexture)),
				new ValueTuple<int, Type>(6, typeof(UUITexture)),
				new ValueTuple<int, Type>(7, typeof(UUISprite)),
				new ValueTuple<int, Type>(8, typeof(UUISprite)),
				new ValueTuple<int, Type>(9, typeof(UUISprite)),
				new ValueTuple<int, Type>(10, typeof(UUISprite)),
				new ValueTuple<int, Type>(11, typeof(UUIText)),
				new ValueTuple<int, Type>(12, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(base.OnClickLevel))
			};
		}

		// Token: 0x0602A2F8 RID: 172792 RVA: 0x00BE9435 File Offset: 0x00BE7635
		protected override void OnStart()
		{
			this.SequencePlayer = new UiSequencePlayer(this.RootItem);
			base.GetButton(0).FocusListenerDelegate.Bind(new Action(base.OnFocus));
		}

		// Token: 0x0602A2F9 RID: 172793 RVA: 0x00BE9465 File Offset: 0x00BE7665
		protected override void OnBeforeShow()
		{
			UUIButtonComponent button = base.GetButton(0);
			button.OnPointEnterCallBack.Bind(new Action(base.OnHover));
			button.OnPointExitCallBack.Bind(new Action(base.OnUnHover));
			this.Refresh();
		}

		// Token: 0x0602A2FA RID: 172794 RVA: 0x00BE94A4 File Offset: 0x00BE76A4
		public override void Refresh()
		{
			if (this.Level < 0)
			{
				return;
			}
			PhantomArenaModel instance = PhantomArenaModel.Instance;
			bool flag = instance.IsGymLock(this.Level, this.ActivityId) || !instance.IsGymUnlockChecked(this.Level, this.ActivityId);
			PhantomBattleGym? phantomBattleGymConfigByLevel = instance.GetPhantomBattleGymConfigByLevel(this.Level, this.ActivityId);
			base.GetSprite(4).SetUIActive(!flag);
			base.GetTexture(5).SetUIActive(flag);
			base.GetTexture(6).SetUIActive(!flag);
			base.GetSprite(7).SetUIActive(flag);
			base.GetSprite(8).SetUIActive(!flag);
			base.GetSprite(9).SetUIActive(flag);
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(1), (phantomBattleGymConfigByLevel != null) ? phantomBattleGymConfigByLevel.GetValueOrDefault().Name : null, Array.Empty<object>());
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(11), (phantomBattleGymConfigByLevel != null) ? phantomBattleGymConfigByLevel.GetValueOrDefault().Name : null, Array.Empty<object>());
			this.RefreshRedDot();
		}

		// Token: 0x0602A2FB RID: 172795 RVA: 0x00BE95C2 File Offset: 0x00BE77C2
		public override void RefreshRedDot()
		{
			base.GetItem(12).SetUIActive(base.GetRedDotState());
		}

		// Token: 0x02009CF6 RID: 40182
		private class EComponentRepeat
		{
			// Token: 0x04030CC0 RID: 199872
			public const int BtnLevel = 0;

			// Token: 0x04030CC1 RID: 199873
			public const int TextName = 1;

			// Token: 0x04030CC2 RID: 199874
			public const int LayoutStar = 2;

			// Token: 0x04030CC3 RID: 199875
			public const int ItemStar = 3;

			// Token: 0x04030CC4 RID: 199876
			public const int SpriteBg = 4;

			// Token: 0x04030CC5 RID: 199877
			public const int TextureBgLock = 5;

			// Token: 0x04030CC6 RID: 199878
			public const int IconMain = 6;

			// Token: 0x04030CC7 RID: 199879
			public const int SpriteLock = 7;

			// Token: 0x04030CC8 RID: 199880
			public const int SpriteLight = 8;

			// Token: 0x04030CC9 RID: 199881
			public const int SpriteGray = 9;

			// Token: 0x04030CCA RID: 199882
			public const int SpriteRoman = 10;

			// Token: 0x04030CCB RID: 199883
			public const int TextNameLock = 11;

			// Token: 0x04030CCC RID: 199884
			public const int ItemRedDot = 12;
		}
	}
}
