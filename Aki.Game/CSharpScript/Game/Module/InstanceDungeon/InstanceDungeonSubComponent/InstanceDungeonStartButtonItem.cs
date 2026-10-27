using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonSubComponent
{
	// Token: 0x020058AC RID: 22700
	[NullableContext(2)]
	[Nullable(0)]
	public class InstanceDungeonStartButtonItem : UiPanelBase
	{
		// Token: 0x06039BD0 RID: 236496 RVA: 0x00DB8D28 File Offset: 0x00DB6F28
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

		// Token: 0x06039BD1 RID: 236497 RVA: 0x00DB8E38 File Offset: 0x00DB7038
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

		// Token: 0x06039BD2 RID: 236498 RVA: 0x00DB8F01 File Offset: 0x00DB7101
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

		// Token: 0x06039BD3 RID: 236499 RVA: 0x00DB8F36 File Offset: 0x00DB7136
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

		// Token: 0x06039BD4 RID: 236500 RVA: 0x00DB8F6B File Offset: 0x00DB716B
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

		// Token: 0x06039BD5 RID: 236501 RVA: 0x00DB8FA0 File Offset: 0x00DB71A0
		private bool GetIsAllowedClickBegin()
		{
			return this.NextCanClickButtonTime <= TimeUtil.Instance.GetServerTimeStamp();
		}

		// Token: 0x0401E279 RID: 123513
		private double NextCanClickButtonTime;

		// Token: 0x0401E27A RID: 123514
		public Action OnClickBtnSoloCallBack;

		// Token: 0x0401E27B RID: 123515
		public Action OnClickBtnMultipleCallBack;

		// Token: 0x0401E27C RID: 123516
		public Action OnClickBtnTeamCallBack;

		// Token: 0x0401E27D RID: 123517
		private const int CLICK_INSTANCE_BEGIN_BUTTON_CD = 500;

		// Token: 0x0200BB13 RID: 47891
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04038839 RID: 231481
			BtnMultiple,
			// Token: 0x0403883A RID: 231482
			BtnSolo,
			// Token: 0x0403883B RID: 231483
			BtnTeam
		}
	}
}
