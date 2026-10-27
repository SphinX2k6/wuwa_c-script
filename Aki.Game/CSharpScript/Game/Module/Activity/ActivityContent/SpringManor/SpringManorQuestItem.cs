using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SpringManor
{
	// Token: 0x02006064 RID: 24676
	[NullableContext(1)]
	[Nullable(0)]
	public class SpringManorQuestItem : GridProxyAbstract<int>
	{
		// Token: 0x0603E6AE RID: 255662 RVA: 0x00F13C2C File Offset: 0x00F11E2C
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

		// Token: 0x0603E6AF RID: 255663 RVA: 0x00F13D98 File Offset: 0x00F11F98
		private void OnToggleClicked(EToggleState state)
		{
			Action<int, int> toggleClickCallback = this.ToggleClickCallback;
			if (toggleClickCallback != null)
			{
				toggleClickCallback(base.GridIndex, this.QuestId);
			}
			this.RefreshRedDot();
		}

		// Token: 0x0603E6B0 RID: 255664 RVA: 0x00F13DBD File Offset: 0x00F11FBD
		public override void Refresh(int questId, bool isSelected, int gridIndex)
		{
			this.UpdateItem(questId);
		}

		// Token: 0x0603E6B1 RID: 255665 RVA: 0x00F13DC6 File Offset: 0x00F11FC6
		public void RefreshWithoutData()
		{
			this.UpdateItem(this.QuestId);
		}

		// Token: 0x0603E6B2 RID: 255666 RVA: 0x00F13DD4 File Offset: 0x00F11FD4
		public void RefreshRedPoint(bool show)
		{
			UUIItem item = base.GetItem(1);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(show);
		}

		// Token: 0x0603E6B3 RID: 255667 RVA: 0x00F13DE8 File Offset: 0x00F11FE8
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

		// Token: 0x0603E6B4 RID: 255668 RVA: 0x00F13E44 File Offset: 0x00F12044
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

		// Token: 0x0603E6B5 RID: 255669 RVA: 0x00F13EB0 File Offset: 0x00F120B0
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

		// Token: 0x0603E6B6 RID: 255670 RVA: 0x00F13F20 File Offset: 0x00F12120
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

		// Token: 0x0603E6B7 RID: 255671 RVA: 0x00F13F8C File Offset: 0x00F1218C
		private void SetTrackIcon(global::Quest quest)
		{
			this.SetSpriteByPath(QuestNewConfig.Instance.GetQuestTypeMark(quest.QuestMarkId), base.GetSprite(4), false, null, null);
		}

		// Token: 0x0603E6B8 RID: 255672 RVA: 0x00F13FC1 File Offset: 0x00F121C1
		public void UpdateTrackIconActive()
		{
			base.GetSprite(4).SetUIActive(SpringManorModel.Instance.IsCurrentTrackQuest(this.QuestId));
		}

		// Token: 0x0603E6B9 RID: 255673 RVA: 0x00F13FDF File Offset: 0x00F121DF
		private void UpdateQuestName(global::Quest quest)
		{
			base.GetText(5).SetText(quest.Name, true);
		}

		// Token: 0x0603E6BA RID: 255674 RVA: 0x00F13FF4 File Offset: 0x00F121F4
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

		// Token: 0x0603E6BB RID: 255675 RVA: 0x00F1404E File Offset: 0x00F1224E
		public override void OnDeselected(bool fireEvent)
		{
			this.SetToggleSelect(false, false);
		}

		// Token: 0x0603E6BC RID: 255676 RVA: 0x00F14058 File Offset: 0x00F12258
		public void SetToggleSelect(bool select, bool fireEvent)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleStateForce(select ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, fireEvent, false, false);
		}

		// Token: 0x040209F1 RID: 133617
		private int QuestId;

		// Token: 0x040209F2 RID: 133618
		[Nullable(2)]
		public Action<int, int> ToggleClickCallback;
	}
}
