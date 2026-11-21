using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonSubComponent
{
	// Token: 0x02004884 RID: 18564
	[NullableContext(2)]
	[Nullable(0)]
	public class InstanceDungeonStartButtonItem : UiPanelBase
	{
		// Token: 0x0602EAF3 RID: 191219 RVA: 0x00D07C40 File Offset: 0x00D05E40
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 3;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickBtnSolo));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickBtnMultiple));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickBtnTeam));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602EAF4 RID: 191220 RVA: 0x00D07D50 File Offset: 0x00D05F50
		public void RefreshItem(InstOnlineType instanceOnlineType)
		{
			this.SetActive(true);
			if (GameModeModel.Instance.IsMulti && !OnlineModel.Instance.GetIsMyTeam())
			{
				base.SetButtonUiActive(0, false);
				base.SetButtonUiActive(1, false);
				base.SetButtonUiActive(2, false);
				return;
			}
			if (instanceOnlineType == InstOnlineType.Single)
			{
				base.SetButtonUiActive(0, false);
				base.SetButtonUiActive(1, true);
				base.SetButtonUiActive(2, false);
				return;
			}
			if (instanceOnlineType == InstOnlineType.Multi)
			{
				base.SetButtonUiActive(0, true);
				base.SetButtonUiActive(1, false);
				if (GameModeModel.Instance.IsMulti)
				{
					base.SetButtonUiActive(2, true);
					return;
				}
				base.SetButtonUiActive(2, false);
				return;
			}
			else
			{
				base.SetButtonUiActive(0, true);
				if (!GameModeModel.Instance.IsMulti)
				{
					base.SetButtonUiActive(1, true);
					base.SetButtonUiActive(2, false);
					return;
				}
				base.SetButtonUiActive(1, false);
				base.SetButtonUiActive(2, true);
				return;
			}
		}

		// Token: 0x0602EAF5 RID: 191221 RVA: 0x00D07E19 File Offset: 0x00D06019
		public void OnClickBtnSolo()
		{
			if (!this.GetIsAllowedClickBegin())
			{
				return;
			}
			this.NextCanClickButtonTime = TimeUtil.Instance.GetServerTimeStamp() + 500.0;
			Action onClickBtnSoloCallBack = this.OnClickBtnSoloCallBack;
			if (onClickBtnSoloCallBack == null)
			{
				return;
			}
			onClickBtnSoloCallBack();
		}

		// Token: 0x0602EAF6 RID: 191222 RVA: 0x00D07E4E File Offset: 0x00D0604E
		private void OnClickBtnMultiple()
		{
			if (!this.GetIsAllowedClickBegin())
			{
				return;
			}
			this.NextCanClickButtonTime = TimeUtil.Instance.GetServerTimeStamp() + 500.0;
			Action onClickBtnMultipleCallBack = this.OnClickBtnMultipleCallBack;
			if (onClickBtnMultipleCallBack == null)
			{
				return;
			}
			onClickBtnMultipleCallBack();
		}

		// Token: 0x0602EAF7 RID: 191223 RVA: 0x00D07E83 File Offset: 0x00D06083
		private void OnClickBtnTeam()
		{
			if (!this.GetIsAllowedClickBegin())
			{
				return;
			}
			this.NextCanClickButtonTime = TimeUtil.Instance.GetServerTimeStamp() + 500.0;
			Action onClickBtnTeamCallBack = this.OnClickBtnTeamCallBack;
			if (onClickBtnTeamCallBack == null)
			{
				return;
			}
			onClickBtnTeamCallBack();
		}

		// Token: 0x0602EAF8 RID: 191224 RVA: 0x00D07EB8 File Offset: 0x00D060B8
		private bool GetIsAllowedClickBegin()
		{
			return this.NextCanClickButtonTime <= TimeUtil.Instance.GetServerTimeStamp();
		}

		// Token: 0x04018D16 RID: 101654
		private double NextCanClickButtonTime;

		// Token: 0x04018D17 RID: 101655
		public Action OnClickBtnSoloCallBack;

		// Token: 0x04018D18 RID: 101656
		public Action OnClickBtnMultipleCallBack;

		// Token: 0x04018D19 RID: 101657
		public Action OnClickBtnTeamCallBack;

		// Token: 0x04018D1A RID: 101658
		private const int CLICK_INSTANCE_BEGIN_BUTTON_CD = 500;

		// Token: 0x0200A52C RID: 42284
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x0403323A RID: 209466
			BtnMultiple,
			// Token: 0x0403323B RID: 209467
			BtnSolo,
			// Token: 0x0403323C RID: 209468
			BtnTeam
		}
	}
}
