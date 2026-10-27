using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.MapRogue;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004EEE RID: 20206
	public class RogueBattleMapSummaryGridEffectTabView : UiTabViewBase
	{
		// Token: 0x06033D80 RID: 212352 RVA: 0x00C24ED8 File Offset: 0x00C230D8
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIArtText)),
				new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIArtText)),
				new ValueTuple<int, Type>(5, typeof(UUIVerticalLayout)),
				new ValueTuple<int, Type>(6, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(2, new Action(this.OnClickedMore))
			};
		}

		// Token: 0x06033D81 RID: 212353 RVA: 0x00C24FAD File Offset: 0x00C231AD
		protected override void OnStart()
		{
			this.Layout = new GenericLayout<RogueBattleMapGridEffectTabItem, IRogueBattleMapGridEffectInfo>(base.GetVerticalLayout(5), new Func<RogueBattleMapGridEffectTabItem>(this.InitItem), null, false, true);
		}

		// Token: 0x06033D82 RID: 212354 RVA: 0x00C24FD0 File Offset: 0x00C231D0
		protected override void OnBeforeShow()
		{
			this.OnClickedTeam();
		}

		// Token: 0x06033D83 RID: 212355 RVA: 0x00C24FD8 File Offset: 0x00C231D8
		protected override void OnAfterShow()
		{
			this.UiViewSequence.PlaySequence("Start", false, null);
		}

		// Token: 0x06033D84 RID: 212356 RVA: 0x00C24FFF File Offset: 0x00C231FF
		protected override void OnBeforeDestroy()
		{
			this.Layout = null;
		}

		// Token: 0x06033D85 RID: 212357 RVA: 0x00C25008 File Offset: 0x00C23208
		private void OnClickedTeam()
		{
			UUIItem item = base.GetItem(0);
			if (item != null)
			{
				item.SetUIActive(true);
			}
			UUIItem item2 = base.GetItem(3);
			if (item2 != null)
			{
				item2.SetUIActive(false);
			}
			List<IRogueBattleMapGridEffectInfo> effectList = RogueBattleModel.Instance.GetEffectList();
			GenericLayout<RogueBattleMapGridEffectTabItem, IRogueBattleMapGridEffectInfo> layout = this.Layout;
			if (layout != null)
			{
				layout.RefreshByData(effectList, null, true);
			}
			int teamLv = MapRogueModel.Instance.GameInfo.TeamLv;
			string text;
			if (teamLv <= 10)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
				defaultInterpolatedStringHandler.AppendLiteral("0");
				defaultInterpolatedStringHandler.AppendFormatted<int>(teamLv);
				text = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			else
			{
				text = teamLv.ToString();
			}
			string text2 = text;
			base.GetArtText(1).SetText(text2);
		}

		// Token: 0x06033D86 RID: 212358 RVA: 0x00C250AA File Offset: 0x00C232AA
		[NullableContext(1)]
		private RogueBattleMapGridEffectTabItem InitItem()
		{
			return new RogueBattleMapGridEffectTabItem();
		}

		// Token: 0x06033D87 RID: 212359 RVA: 0x00C250B1 File Offset: 0x00C232B1
		private void OnClickedMore()
		{
			HelpController.Instance.OpenHelpById(260);
		}

		// Token: 0x0401B8B6 RID: 112822
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RogueBattleMapGridEffectTabItem, IRogueBattleMapGridEffectInfo> Layout;

		// Token: 0x0401B8B7 RID: 112823
		private const int MORE_HELPID = 260;
	}
}
