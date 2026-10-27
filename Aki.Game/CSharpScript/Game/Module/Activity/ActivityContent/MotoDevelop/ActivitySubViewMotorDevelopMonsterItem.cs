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
	// Token: 0x0200645C RID: 25692
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class ActivitySubViewMotorDevelopMonsterItem : GridProxyAbstract<ConditionTask>
	{
		// Token: 0x06040914 RID: 264468 RVA: 0x00FA0A2C File Offset: 0x00F9EC2C
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

		// Token: 0x06040915 RID: 264469 RVA: 0x00FA0AEB File Offset: 0x00F9ECEB
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

		// Token: 0x06040916 RID: 264470 RVA: 0x00FA0B26 File Offset: 0x00F9ED26
		private void OnClickBtnSelf()
		{
		}

		// Token: 0x06040917 RID: 264471 RVA: 0x00FA0B28 File Offset: 0x00F9ED28
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

		// Token: 0x0402193D RID: 137533
		public ConditionTask Data;

		// Token: 0x0402193E RID: 137534
		public CommonItemSmallItemGrid RewardItem;
	}
}
