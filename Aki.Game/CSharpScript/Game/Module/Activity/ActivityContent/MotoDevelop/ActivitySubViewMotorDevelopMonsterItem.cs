using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotoDevelop
{
	// Token: 0x020053DA RID: 21466
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class ActivitySubViewMotorDevelopMonsterItem : GridProxyAbstract<ConditionTask>
	{
		// Token: 0x060355D5 RID: 218581 RVA: 0x00EE79A8 File Offset: 0x00EE5BA8
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUIText)),
				new ValueTuple<int, Type>(4, typeof(UUITexture)),
				new ValueTuple<int, Type>(5, typeof(UUITexture))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(this.OnClickBtnSelf))
			};
		}

		// Token: 0x060355D6 RID: 218582 RVA: 0x00EE7A67 File Offset: 0x00EE5C67
		protected override void OnStart()
		{
			this.RewardItem = new CommonItemSmallItemGrid();
			this.RewardItem.Initialize(base.GetItem(1).GetOwner());
			this.RewardItem.BindOnExtendTogglePress(delegate(MediumItemGridExtendCallback callbackParameter)
			{
				int id = this.Data.Id;
				switch (this.Data.Status)
				{
				case ConditionTaskState.ConditionTaskRunning:
				case ConditionTaskState.ConditionTaskTaken:
					break;
				case ConditionTaskState.ConditionTaskFinish:
					ActivityMotorDevelopController.Instance.RewardReceiveRequest(new List<int>
					{
						id
					});
					break;
				default:
					return;
				}
			});
		}

		// Token: 0x060355D7 RID: 218583 RVA: 0x00EE7AA2 File Offset: 0x00EE5CA2
		private void OnClickBtnSelf()
		{
		}

		// Token: 0x060355D8 RID: 218584 RVA: 0x00EE7AA4 File Offset: 0x00EE5CA4
		[NullableContext(1)]
		public override void Refresh(ConditionTask taskData, bool isSelected, int gridIndex)
		{
			this.Data = taskData;
			ActivityMotorDevelopConfig instance = ActivityMotorDevelopConfig.Instance;
			MotorDevelopTask? motorDevelopTask = (instance != null) ? instance.GetMotorDevelopTaskById(taskData.Id) : null;
			if (motorDevelopTask == null)
			{
				return;
			}
			int itemId = 0;
			int count = 0;
			using (IEnumerator<DicIntInt> enumerator = motorDevelopTask.Value.TaskRewardShowIter().GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					DicIntInt dicIntInt = enumerator.Current;
					itemId = dicIntInt.Key;
					count = dicIntInt.Value;
				}
			}
			TItem data = new TItem(new InventoryDefine.GetItemData(itemId, 0), count);
			this.RewardItem.Refresh(data);
			this.RewardItem.SetReceivedVisible(taskData.Status == ConditionTaskState.ConditionTaskTaken);
			this.RewardItem.SetLockVisible(taskData.Status == ConditionTaskState.ConditionTaskRunning);
			this.RewardItem.SetReceivableVisible(taskData.Status == ConditionTaskState.ConditionTaskFinish);
			UUITexture texture = base.GetTexture(5);
			UUITexture texture2 = base.GetTexture(4);
			texture.SetUIActive(false);
			texture2.SetUIActive(false);
			switch (taskData.Status)
			{
			case ConditionTaskState.ConditionTaskFinish:
				texture.SetUIActive(true);
				break;
			case ConditionTaskState.ConditionTaskTaken:
				texture2.SetUIActive(true);
				break;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), motorDevelopTask.Value.TaskName, Array.Empty<object>());
			UUIText text = base.GetText(3);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 2);
			defaultInterpolatedStringHandler.AppendLiteral("(");
			defaultInterpolatedStringHandler.AppendFormatted<int>(taskData.Current);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(taskData.Target);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}

		// Token: 0x0401C26C RID: 115308
		public ConditionTask Data;

		// Token: 0x0401C26D RID: 115309
		public CommonItemSmallItemGrid RewardItem;
	}
}
