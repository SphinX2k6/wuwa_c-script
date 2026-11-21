using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Entrance
{
	// Token: 0x0200412C RID: 16684
	public class EntranceGymItem : GymItemBase
	{
		// Token: 0x0602A2F0 RID: 172784 RVA: 0x00BE8EF0 File Offset: 0x00BE70F0
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUISprite)),
				new ValueTuple<int, Type>(5, typeof(UUISprite)),
				new ValueTuple<int, Type>(6, typeof(UUISprite)),
				new ValueTuple<int, Type>(7, typeof(UUISprite)),
				new ValueTuple<int, Type>(8, typeof(UUISprite)),
				new ValueTuple<int, Type>(9, typeof(UUISprite)),
				new ValueTuple<int, Type>(10, typeof(UUISprite)),
				new ValueTuple<int, Type>(11, typeof(UUIItem)),
				new ValueTuple<int, Type>(12, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(base.OnClickLevel))
			};
		}

		// Token: 0x0602A2F1 RID: 172785 RVA: 0x00BE9050 File Offset: 0x00BE7250
		protected override void OnStart()
		{
			this.SequencePlayer = new UiSequencePlayer(this.RootItem);
			this.LayoutStar = new GenericLayout<GymStarItem, GymChallengeData>(base.GetHorizontalLayout(2), new Func<GymStarItem>(this.CreateStarItem), null, false, true);
			base.GetButton(0).SetSelectionState(EUISelectableSelectionState.Normal);
			base.GetButton(0).FocusListenerDelegate.Bind(new Action(base.OnFocus));
		}

		// Token: 0x0602A2F2 RID: 172786 RVA: 0x00BE90B9 File Offset: 0x00BE72B9
		[NullableContext(1)]
		private GymStarItem CreateStarItem()
		{
			return new GymStarItem();
		}

		// Token: 0x0602A2F3 RID: 172787 RVA: 0x00BE90C0 File Offset: 0x00BE72C0
		protected override void OnBeforeShow()
		{
			UUIButtonComponent button = base.GetButton(0);
			button.OnPointEnterCallBack.Bind(new Action(base.OnHover));
			button.OnPointExitCallBack.Bind(new Action(base.OnUnHover));
			this.Refresh();
		}

		// Token: 0x0602A2F4 RID: 172788 RVA: 0x00BE90FC File Offset: 0x00BE72FC
		public override void Refresh()
		{
			if (this.Level < 0)
			{
				return;
			}
			PhantomArenaModel instance = PhantomArenaModel.Instance;
			bool flag = instance.IsGymLock(this.Level, this.ActivityId) || !instance.IsGymUnlockChecked(this.Level, this.ActivityId);
			PhantomBattleGym? phantomBattleGymConfigByLevel = instance.GetPhantomBattleGymConfigByLevel(this.Level, this.ActivityId);
			if (phantomBattleGymConfigByLevel == null)
			{
				return;
			}
			base.GetSprite(4).SetUIActive(!flag);
			base.GetSprite(5).SetUIActive(flag);
			this.SetSpriteByPath(phantomBattleGymConfigByLevel.Value.IconBg, base.GetSprite(4), false, null, null);
			base.GetSprite(7).SetUIActive(flag);
			base.GetSprite(8).SetUIActive(!flag);
			base.GetSprite(9).SetUIActive(flag);
			base.GetItem(11).SetUIActive(!flag);
			string path = flag ? phantomBattleGymConfigByLevel.Value.IconLock : phantomBattleGymConfigByLevel.Value.Icon;
			this.SetSpriteByPath(path, base.GetSprite(6), false, null, null);
			this.SetSpriteByPath(phantomBattleGymConfigByLevel.Value.IconRoman, base.GetSprite(10), false, null, null);
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(1), (phantomBattleGymConfigByLevel != null) ? phantomBattleGymConfigByLevel.GetValueOrDefault().Name : null, Array.Empty<object>());
			List<GymChallengeData> challengeStateListByGymLevel = instance.GetChallengeStateListByGymLevel(this.Level, this.ActivityId);
			this.LayoutStar.RefreshByData(challengeStateListByGymLevel, null, false);
			this.LayoutStar.SetActive(!flag);
			this.RefreshRedDot();
		}

		// Token: 0x0602A2F5 RID: 172789 RVA: 0x00BE92B9 File Offset: 0x00BE74B9
		public override void RefreshRedDot()
		{
			base.GetItem(12).SetUIActive(base.GetRedDotState());
		}

		// Token: 0x04016F8A RID: 94090
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<GymStarItem, GymChallengeData> LayoutStar;

		// Token: 0x02009CF5 RID: 40181
		private class EComponent
		{
			// Token: 0x04030CB3 RID: 199859
			public const int BtnLevel = 0;

			// Token: 0x04030CB4 RID: 199860
			public const int TextName = 1;

			// Token: 0x04030CB5 RID: 199861
			public const int LayoutStar = 2;

			// Token: 0x04030CB6 RID: 199862
			public const int ItemStar = 3;

			// Token: 0x04030CB7 RID: 199863
			public const int SpriteBg = 4;

			// Token: 0x04030CB8 RID: 199864
			public const int SpriteBgLock = 5;

			// Token: 0x04030CB9 RID: 199865
			public const int SpriteIcon = 6;

			// Token: 0x04030CBA RID: 199866
			public const int SpriteLock = 7;

			// Token: 0x04030CBB RID: 199867
			public const int SpriteLight = 8;

			// Token: 0x04030CBC RID: 199868
			public const int SpriteGray = 9;

			// Token: 0x04030CBD RID: 199869
			public const int SpriteRoman = 10;

			// Token: 0x04030CBE RID: 199870
			public const int PanelUnlock = 11;

			// Token: 0x04030CBF RID: 199871
			public const int ItemRedDot = 12;
		}
	}
}
