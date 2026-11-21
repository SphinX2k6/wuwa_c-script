using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SpringManor
{
	// Token: 0x02004FFE RID: 20478
	public class GetWayItem : GridProxyAbstract<int>
	{
		// Token: 0x0603343A RID: 209978 RVA: 0x00E5F5C0 File Offset: 0x00E5D7C0
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUISprite)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(this.OnButtonClick))
			};
		}

		// Token: 0x0603343B RID: 209979 RVA: 0x00E5F67F File Offset: 0x00E5D87F
		private void OnButtonClick()
		{
			if (this.State != EGetWayState.Normal || this.SkipEntryId <= 0)
			{
				return;
			}
			SpringManorController instance = SpringManorController.Instance;
			if (instance == null)
			{
				return;
			}
			instance.ExecuteSkipEntry(this.SkipEntryId, this.OnTrackPositionCallback);
		}

		// Token: 0x0603343C RID: 209980 RVA: 0x00E5F6B0 File Offset: 0x00E5D8B0
		public override void Refresh(int data, bool isSelected, int gridIndex)
		{
			this.SkipEntryId = data;
			SpringFestivalSkipEntry? skipEntryConfigById = SpringManorConfig.Instance.GetSkipEntryConfigById(data);
			if (skipEntryConfigById == null)
			{
				return;
			}
			UUIText text = base.GetText(2);
			if (text != null)
			{
				text.ShowTextNew(skipEntryConfigById.Value.Name);
			}
			if (!SpringManorModel.Instance.ActivityData.IsSkipEntryUnLock(data))
			{
				this.RefreshState(EGetWayState.Lock);
				return;
			}
			if (SpringManorModel.Instance.ActivityData.IsSkipEntryFinish(data))
			{
				this.RefreshState(EGetWayState.Finish);
				return;
			}
			bool flag = skipEntryConfigById.Value.JumpId > 0;
			bool flag2 = skipEntryConfigById.Value.TrackPositionLength > 0;
			this.RefreshState((flag || flag2) ? EGetWayState.Normal : EGetWayState.CantJump);
		}

		// Token: 0x0603343D RID: 209981 RVA: 0x00E5F764 File Offset: 0x00E5D964
		private void RefreshState(EGetWayState state)
		{
			this.State = state;
			UUIButtonComponent button = base.GetButton(0);
			if (button != null)
			{
				button.SetSelfInteractive(state != EGetWayState.Lock && state != EGetWayState.CantJump);
			}
			UUIItem item = base.GetItem(3);
			if (item != null)
			{
				item.SetUIActive(state == EGetWayState.Normal);
			}
			UUIItem item2 = base.GetItem(4);
			if (item2 != null)
			{
				item2.SetUIActive(state == EGetWayState.Lock);
			}
			UUIItem item3 = base.GetItem(5);
			if (item3 == null)
			{
				return;
			}
			item3.SetUIActive(state == EGetWayState.Finish);
		}

		// Token: 0x0401B3FF RID: 111615
		private int SkipEntryId;

		// Token: 0x0401B400 RID: 111616
		private EGetWayState State;

		// Token: 0x0401B401 RID: 111617
		[Nullable(2)]
		public Action OnTrackPositionCallback;
	}
}
