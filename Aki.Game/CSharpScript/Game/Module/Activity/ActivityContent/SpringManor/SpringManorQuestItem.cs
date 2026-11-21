using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SpringManor
{
	// Token: 0x02004FE2 RID: 20450
	[NullableContext(1)]
	[Nullable(0)]
	public class SpringManorQuestItem : GridProxyAbstract<int>
	{
		// Token: 0x06033372 RID: 209778 RVA: 0x00E5A9F0 File Offset: 0x00E58BF0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleClicked));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06033373 RID: 209779 RVA: 0x00E5AB5C File Offset: 0x00E58D5C
		private void OnToggleClicked(EToggleState state)
		{
			Action<int, int> toggleClickCallback = this.ToggleClickCallback;
			if (toggleClickCallback != null)
			{
				toggleClickCallback(base.GridIndex, this.QuestId);
			}
			this.RefreshRedDot();
		}

		// Token: 0x06033374 RID: 209780 RVA: 0x00E5AB81 File Offset: 0x00E58D81
		public override void Refresh(int questId, bool isSelected, int gridIndex)
		{
			this.UpdateItem(questId);
		}

		// Token: 0x06033375 RID: 209781 RVA: 0x00E5AB8A File Offset: 0x00E58D8A
		public void RefreshWithoutData()
		{
			this.UpdateItem(this.QuestId);
		}

		// Token: 0x06033376 RID: 209782 RVA: 0x00E5AB98 File Offset: 0x00E58D98
		public void RefreshRedPoint(bool show)
		{
			UUIItem item = base.GetItem(1);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(show);
		}

		// Token: 0x06033377 RID: 209783 RVA: 0x00E5ABAC File Offset: 0x00E58DAC
		public void UpdateItem(int inQuestId)
		{
			this.QuestId = inQuestId;
			this.UpdateTrackIconActive();
			global::Quest quest = QuestNewModel.Instance.GetQuest(this.QuestId);
			if (quest == null)
			{
				this.RefreshLockState();
				return;
			}
			this.SetLockIcon();
			this.SetTrackIcon(quest);
			this.UpdateQuestName(quest);
			this.UpdateDistance(this.QuestId);
			this.RefreshRedDot();
		}

		// Token: 0x06033378 RID: 209784 RVA: 0x00E5AC08 File Offset: 0x00E58E08
		public void RefreshRedDot()
		{
			UUIItem item = base.GetItem(1);
			if (!SpringManorModel.Instance.IsSubQuest(this.QuestId))
			{
				if (item != null)
				{
					item.SetUIActive(false);
				}
				return;
			}
			SpringManorModel instance = SpringManorModel.Instance;
			bool? flag = (instance != null) ? new bool?(instance.ActivityData.HasSubQuestRedDot(this.QuestId)) : null;
			if (item != null)
			{
				item.SetUIActive(flag.GetValueOrDefault());
			}
		}

		// Token: 0x06033379 RID: 209785 RVA: 0x00E5AC74 File Offset: 0x00E58E74
		private void RefreshLockState()
		{
			IQuest questConfig = QuestNewModel.Instance.GetQuestConfig(this.QuestId);
			UUISprite sprite = base.GetSprite(2);
			if (sprite != null)
			{
				sprite.SetUIActive(true);
			}
			UUIItem item = base.GetItem(7);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUIText text = base.GetText(5);
			if (text != null)
			{
				text.ShowTextNew(questConfig.TidName);
			}
			UUIText text2 = base.GetText(6);
			if (text2 == null)
			{
				return;
			}
			text2.SetUIActive(false);
		}

		// Token: 0x0603337A RID: 209786 RVA: 0x00E5ACE4 File Offset: 0x00E58EE4
		private void SetLockIcon()
		{
			string questLockIconPath = QuestNewModel.Instance.GetQuestLockIconPath(this.QuestId);
			UUISprite sprite = base.GetSprite(2);
			if (StringUtils.IsEmpty(questLockIconPath))
			{
				sprite.SetUIActive(false);
				return;
			}
			if (SpringManorModel.Instance.IsCurrentTrackQuest(this.QuestId))
			{
				sprite.SetUIActive(false);
				return;
			}
			this.SetSpriteByPath(questLockIconPath, sprite, true, null, null);
			sprite.SetUIActive(true);
		}

		// Token: 0x0603337B RID: 209787 RVA: 0x00E5AD50 File Offset: 0x00E58F50
		private void SetTrackIcon(global::Quest quest)
		{
			this.SetSpriteByPath(QuestNewConfig.Instance.GetQuestTypeMark(quest.QuestMarkId), base.GetSprite(4), false, null, null);
		}

		// Token: 0x0603337C RID: 209788 RVA: 0x00E5AD85 File Offset: 0x00E58F85
		public void UpdateTrackIconActive()
		{
			base.GetSprite(4).SetUIActive(SpringManorModel.Instance.IsCurrentTrackQuest(this.QuestId));
		}

		// Token: 0x0603337D RID: 209789 RVA: 0x00E5ADA3 File Offset: 0x00E58FA3
		private void UpdateQuestName(global::Quest quest)
		{
			base.GetText(5).SetText(quest.Name, true);
		}

		// Token: 0x0603337E RID: 209790 RVA: 0x00E5ADB8 File Offset: 0x00E58FB8
		private void UpdateDistance(int questId)
		{
			SpringManorModel instance = SpringManorModel.Instance;
			bool flag = instance.IsSubQuest(questId);
			bool flag2 = instance.IsCurrentTrackQuest(questId);
			UUIText text = base.GetText(6);
			if (flag && !flag2)
			{
				text.SetUIActive(false);
				return;
			}
			string questTrackDistanceText = instance.GetQuestTrackDistanceText(questId);
			text.SetUIActive(questTrackDistanceText != null);
			if (questTrackDistanceText != null)
			{
				text.SetText(questTrackDistanceText, true);
			}
		}

		// Token: 0x0603337F RID: 209791 RVA: 0x00E5AE12 File Offset: 0x00E59012
		public override void OnDeselected(bool fireEvent)
		{
			this.SetToggleSelect(false, false);
		}

		// Token: 0x06033380 RID: 209792 RVA: 0x00E5AE1C File Offset: 0x00E5901C
		public void SetToggleSelect(bool select, bool fireEvent)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleStateForce(select ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, fireEvent, false, false);
		}

		// Token: 0x0401B31E RID: 111390
		private int QuestId;

		// Token: 0x0401B31F RID: 111391
		[Nullable(2)]
		public Action<int, int> ToggleClickCallback;
	}
}
