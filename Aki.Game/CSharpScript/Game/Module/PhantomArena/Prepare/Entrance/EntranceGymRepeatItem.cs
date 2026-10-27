using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Entrance
{
	// Token: 0x0200515D RID: 20829
	public class EntranceGymRepeatItem : GymItemBase
	{
		// Token: 0x060353FB RID: 218107 RVA: 0x00C9BDD8 File Offset: 0x00C99FD8
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

		// Token: 0x060353FC RID: 218108 RVA: 0x00C9BF35 File Offset: 0x00C9A135
		protected override void OnStart()
		{
			this.SequencePlayer = new UiSequencePlayer(this.RootItem);
			base.GetButton(0).FocusListenerDelegate.Bind(new Action(base.OnFocus));
		}

		// Token: 0x060353FD RID: 218109 RVA: 0x00C9BF65 File Offset: 0x00C9A165
		protected override void OnBeforeShow()
		{
			UUIButtonComponent button = base.GetButton(0);
			button.OnPointEnterCallBack.Bind(new Action(base.OnHover));
			button.OnPointExitCallBack.Bind(new Action(base.OnUnHover));
			this.Refresh();
		}

		// Token: 0x060353FE RID: 218110 RVA: 0x00C9BFA4 File Offset: 0x00C9A1A4
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

		// Token: 0x060353FF RID: 218111 RVA: 0x00C9C0C2 File Offset: 0x00C9A2C2
		public override void RefreshRedDot()
		{
			base.GetItem(12).SetUIActive(base.GetRedDotState());
		}

		// Token: 0x0200B2BD RID: 45757
		private class EComponentRepeat
		{
			// Token: 0x0403626B RID: 221803
			public const int BtnLevel = 0;

			// Token: 0x0403626C RID: 221804
			public const int TextName = 1;

			// Token: 0x0403626D RID: 221805
			public const int LayoutStar = 2;

			// Token: 0x0403626E RID: 221806
			public const int ItemStar = 3;

			// Token: 0x0403626F RID: 221807
			public const int SpriteBg = 4;

			// Token: 0x04036270 RID: 221808
			public const int TextureBgLock = 5;

			// Token: 0x04036271 RID: 221809
			public const int IconMain = 6;

			// Token: 0x04036272 RID: 221810
			public const int SpriteLock = 7;

			// Token: 0x04036273 RID: 221811
			public const int SpriteLight = 8;

			// Token: 0x04036274 RID: 221812
			public const int SpriteGray = 9;

			// Token: 0x04036275 RID: 221813
			public const int SpriteRoman = 10;

			// Token: 0x04036276 RID: 221814
			public const int TextNameLock = 11;

			// Token: 0x04036277 RID: 221815
			public const int ItemRedDot = 12;
		}
	}
}
