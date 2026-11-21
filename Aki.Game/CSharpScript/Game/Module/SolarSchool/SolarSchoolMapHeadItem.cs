using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059C1 RID: 22977
	public class SolarSchoolMapHeadItem : UiPanelBase
	{
		// Token: 0x06038A14 RID: 231956 RVA: 0x00FD8810 File Offset: 0x00FD6A10
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06038A15 RID: 231957 RVA: 0x00FD889C File Offset: 0x00FD6A9C
		protected override void OnStart()
		{
			this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.SequencePlayer.PlayLevelSequenceByName("Loop", false, null, false);
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUIItem item2 = base.GetItem(2);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(false);
		}

		// Token: 0x06038A16 RID: 231958 RVA: 0x00FD88FC File Offset: 0x00FD6AFC
		public void RefreshByRole(int roleId)
		{
			if (roleId == 0)
			{
				base.SetUiActive(false);
				return;
			}
			base.SetTextureShowUntilLoaded(SolarSchoolConfig.Instance.GetRole(roleId).Value.MapHeadIcon, base.GetTexture(0), null);
			base.SetUiActive(true);
		}

		// Token: 0x06038A17 RID: 231959 RVA: 0x00FD8944 File Offset: 0x00FD6B44
		public void RefreshSpecialBehaviorState(bool showAcceptEntry, bool hasUnviewedSpecialBehavior)
		{
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(hasUnviewedSpecialBehavior);
			}
			UUIItem item2 = base.GetItem(2);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(showAcceptEntry);
		}

		// Token: 0x06038A18 RID: 231960 RVA: 0x00FD896B File Offset: 0x00FD6B6B
		[NullableContext(2)]
		public UUIItem GetUnviewedSpecialBehaviorItem()
		{
			return base.GetItem(1);
		}

		// Token: 0x0401DD24 RID: 122148
		[Nullable(2)]
		private LevelSequencePlayer SequencePlayer;

		// Token: 0x0200B56D RID: 46445
		private class EComponents
		{
			// Token: 0x04038185 RID: 229765
			public const int TexHead = 0;

			// Token: 0x04038186 RID: 229766
			public const int PnlTips = 1;

			// Token: 0x04038187 RID: 229767
			public const int PnlTepiRedPoint = 2;
		}
	}
}
