using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004E05 RID: 19973
	public class RoguelikeActivityTabItem : UiPanelBase
	{
		// Token: 0x06033887 RID: 211079 RVA: 0x00C0AEF6 File Offset: 0x00C090F6
		public RoguelikeActivityTabItem(int seasonId, int index)
		{
			this.SeasonId = seasonId;
			this.Index = index;
		}

		// Token: 0x06033888 RID: 211080 RVA: 0x00C0AF0C File Offset: 0x00C0910C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06033889 RID: 211081 RVA: 0x00C0AFD3 File Offset: 0x00C091D3
		protected override void OnStart()
		{
			this.Update(this.SeasonId);
		}

		// Token: 0x0603388A RID: 211082 RVA: 0x00C0AFE1 File Offset: 0x00C091E1
		protected void OnClickToggle(EToggleState _)
		{
			EventSystem.Instance.Emit<int, int>(EEventName.RoguelikeSelectSeason, this.SeasonId, this.Index);
		}

		// Token: 0x0603388B RID: 211083 RVA: 0x00C0AFFF File Offset: 0x00C091FF
		public void SetToggleState(EToggleState state)
		{
			base.GetExtendToggle(0).SetToggleState(state, false, false, false);
		}

		// Token: 0x0603388C RID: 211084 RVA: 0x00C0B014 File Offset: 0x00C09214
		protected void Update(int seasonId)
		{
			this.SeasonId = seasonId;
			RogueSeason? rogueSeasonConfigById = RoguelikeConfig.Instance.GetRogueSeasonConfigById(seasonId);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), rogueSeasonConfigById.Value.SeasonName, Array.Empty<object>());
			this.SetSpriteByPath(rogueSeasonConfigById.Value.TabIcon, base.GetSprite(2), false, null, null);
		}

		// Token: 0x0401B56C RID: 111980
		public int SeasonId;

		// Token: 0x0401B56D RID: 111981
		public int Index;

		// Token: 0x0200AF95 RID: 44949
		private class ERoguelikeActivityTabItemDefine
		{
			// Token: 0x040354ED RID: 218349
			public const int Toggle = 0;

			// Token: 0x040354EE RID: 218350
			public const int TxtName = 1;

			// Token: 0x040354EF RID: 218351
			public const int SpriteIcon = 2;
		}
	}
}
