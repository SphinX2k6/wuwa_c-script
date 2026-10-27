using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.Pawn.Component;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005DD8 RID: 24024
	[NullableContext(1)]
	[Nullable(0)]
	public class SpecialEnergyBarFuLuoLuo : SpecialEnergyBarBase
	{
		// Token: 0x0603D0F4 RID: 250100 RVA: 0x00EB044C File Offset: 0x00EAE64C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 19;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603D0F5 RID: 250101 RVA: 0x00EB06F1 File Offset: 0x00EAE8F1
		protected override void OnInitData()
		{
			this.BurstConfig = BattleUiModel.Instance.SpecialEnergyBarData.GetSpecialEnergyBarInfo(160801);
		}

		// Token: 0x0603D0F6 RID: 250102 RVA: 0x00EB0710 File Offset: 0x00EAE910
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarFuLuoLuo.<OnBeforeStartAsync>d__26 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarFuLuoLuo.<OnBeforeStartAsync>d__26>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603D0F7 RID: 250103 RVA: 0x00EB0754 File Offset: 0x00EAE954
		protected UniTask InitBurstKeyItem(UUIItem keyItemContainer)
		{
			SpecialEnergyBarFuLuoLuo.<InitBurstKeyItem>d__27 <InitBurstKeyItem>d__;
			<InitBurstKeyItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBurstKeyItem>d__.<>4__this = this;
			<InitBurstKeyItem>d__.keyItemContainer = keyItemContainer;
			<InitBurstKeyItem>d__.<>1__state = -1;
			<InitBurstKeyItem>d__.<>t__builder.Start<SpecialEnergyBarFuLuoLuo.<InitBurstKeyItem>d__27>(ref <InitBurstKeyItem>d__);
			return <InitBurstKeyItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603D0F8 RID: 250104 RVA: 0x00EB07A0 File Offset: 0x00EAE9A0
		private UniTask InitNoteItems()
		{
			SpecialEnergyBarFuLuoLuo.<InitNoteItems>d__28 <InitNoteItems>d__;
			<InitNoteItems>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitNoteItems>d__.<>4__this = this;
			<InitNoteItems>d__.<>1__state = -1;
			<InitNoteItems>d__.<>t__builder.Start<SpecialEnergyBarFuLuoLuo.<InitNoteItems>d__28>(ref <InitNoteItems>d__);
			return <InitNoteItems>d__.<>t__builder.Task;
		}

		// Token: 0x0603D0F9 RID: 250105 RVA: 0x00EB07E4 File Offset: 0x00EAE9E4
		protected override void OnStart()
		{
			base.OnStart();
			BattleUiRoleData roleData = this.RoleData;
			Entity entity;
			if (roleData == null)
			{
				entity = null;
			}
			else
			{
				EntityHandle entityHandle = roleData.EntityHandle;
				entity = ((entityHandle != null) ? entityHandle.Entity : null);
			}
			this.Entity = entity;
			SpecialEnergyBarInfo config = this.Config;
			if (!string.IsNullOrEmpty((config != null) ? config.EffectColor : null))
			{
				FColor item = FColor.FromHex(this.Config.EffectColor);
				this.ColorList.Add(item);
			}
			SpecialEnergyBarInfo config2 = this.Config;
			if (((config2 != null) ? config2.OtherEffectColorList : null) != null)
			{
				foreach (string hexStr in this.Config.OtherEffectColorList)
				{
					FColor item2 = FColor.FromHex(hexStr);
					this.ColorList.Add(item2);
				}
			}
			base.InitTweenAnim(13);
			base.InitTweenAnim(14);
			base.InitTweenAnim(15);
			base.InitTweenAnim(16);
			base.InitTweenAnim(17);
			for (int i = 0; i < 6; i++)
			{
				UUIItem item3 = base.GetItem(7 + i);
				this.PosItemList.Add(item3);
				UUIItem item4 = base.GetItem(1 + i);
				this.SlotItemList.Add(item4);
			}
			this.RefreshBar(true);
			this.RefreshTimeScale();
		}

		// Token: 0x0603D0FA RID: 250106 RVA: 0x00EB092C File Offset: 0x00EAEB2C
		protected override void AddEvents()
		{
			base.AddEvents();
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarFuLuoLuo.LockTag, new BaseTagComponent.TTagSwitchedCallback(this.OnLockTagChange));
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarFuLuoLuo.BurstTag, new BaseTagComponent.TTagSwitchedCallback(this.OnBurstTagChange));
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarFuLuoLuo.DisableTag, new BaseTagComponent.TTagSwitchedCallback(this.OnDisableTagChange));
			if (this.Entity != null)
			{
				EventSystem.Instance.AddWithTarget<float, ETimeScaleSourceType>(this.Entity, EEventName.CharBeHitTimeScale, new Action<float, ETimeScaleSourceType>(this.CharBeHitTimeScale));
			}
			EventSystem.Instance.Add(EEventName.TriggerUiTimeDilation, new Action(this.OnTimeScaleChange));
			EventSystem.Instance.Add<int>(EEventName.FuLuoLuoAddDuplicatedEnergy, new Action<int>(this.OnAddDuplicatedEnergy));
		}

		// Token: 0x0603D0FB RID: 250107 RVA: 0x00EB09E0 File Offset: 0x00EAEBE0
		protected override void RemoveEvents()
		{
			base.RemoveEvents();
			if (this.Entity != null)
			{
				EventSystem.Instance.RemoveWithTarget<float, ETimeScaleSourceType>(this.Entity, EEventName.CharBeHitTimeScale, new Action<float, ETimeScaleSourceType>(this.CharBeHitTimeScale));
			}
			EventSystem.Instance.Remove(EEventName.TriggerUiTimeDilation, new Action(this.OnTimeScaleChange));
			EventSystem.Instance.Remove<int>(EEventName.FuLuoLuoAddDuplicatedEnergy, new Action<int>(this.OnAddDuplicatedEnergy));
		}

		// Token: 0x0603D0FC RID: 250108 RVA: 0x00EB0A4C File Offset: 0x00EAEC4C
		protected override void OnBeforeDestroy()
		{
			if (this.BurstKeyItem != null)
			{
				SpecialEnergyBarKeyItem burstKeyItem = this.BurstKeyItem;
				if (burstKeyItem != null)
				{
					burstKeyItem.Destroy(null);
				}
				this.BurstKeyItem = null;
			}
			base.OnBeforeDestroy();
		}

		// Token: 0x0603D0FD RID: 250109 RVA: 0x00EB0A75 File Offset: 0x00EAEC75
		private void OnLockTagChange(int tagId, bool tagExist)
		{
			this.SetLockState(tagExist, false);
		}

		// Token: 0x0603D0FE RID: 250110 RVA: 0x00EB0A7F File Offset: 0x00EAEC7F
		private void OnBurstTagChange(int tagId, bool tagExist)
		{
			this.SetBurstState(tagExist, false);
		}

		// Token: 0x0603D0FF RID: 250111 RVA: 0x00EB0A89 File Offset: 0x00EAEC89
		private void OnDisableTagChange(int tagId, bool tagExist)
		{
			this.SetKeyDisableState(tagExist);
		}

		// Token: 0x0603D100 RID: 250112 RVA: 0x00EB0A92 File Offset: 0x00EAEC92
		private void CharBeHitTimeScale(float _1, ETimeScaleSourceType _2)
		{
			this.OnTimeScaleChange();
		}

		// Token: 0x0603D101 RID: 250113 RVA: 0x00EB0A9A File Offset: 0x00EAEC9A
		private void OnTimeScaleChange()
		{
			if (this.IsPerforming)
			{
				this.RefreshTimeScale();
			}
		}

		// Token: 0x0603D102 RID: 250114 RVA: 0x00EB0AAC File Offset: 0x00EAECAC
		private void RefreshTimeScale()
		{
			float num = 1f;
			if (this.BuffComponent != null)
			{
				num = this.BuffComponent.GetTimeScale();
			}
			if (this.TimeScale == num)
			{
				return;
			}
			this.TimeScale = num;
			if (this.PerformTimer != null && TimerSystem.Instance.Has(this.PerformTimer))
			{
				if (this.TimeScale <= 0f)
				{
					if (!TimerSystem.Instance.IsPause(this.PerformTimer))
					{
						TimerSystem.Instance.Pause(this.PerformTimer, null);
					}
				}
				else
				{
					if (TimerSystem.Instance.IsPause(this.PerformTimer))
					{
						TimerSystem.Instance.Resume(this.PerformTimer);
					}
					TimerSystem.Instance.ChangeDilation(this.PerformTimer, this.TimeScale, null);
				}
			}
			float timeScale = num / Time.Instance.InverseSelfCenteredTimeDilation;
			base.SetTweenTimeScale(17, timeScale);
		}

		// Token: 0x0603D103 RID: 250115 RVA: 0x00EB0B88 File Offset: 0x00EAED88
		private void OnAddDuplicatedEnergy(int entityId)
		{
			if (this.SpecialEnergyTypeList.Count < 6)
			{
				return;
			}
			int num = -1;
			int num2 = 0;
			for (int i = 0; i < 6; i++)
			{
				num2 = this.SpecialEnergyTypeList[i];
				if (num2 != 3)
				{
					num = i;
					break;
				}
			}
			if (num2 == 0)
			{
				return;
			}
			for (int j = num + 1; j < 6; j++)
			{
				if (this.SpecialEnergyTypeList[j] != num2)
				{
					return;
				}
			}
			this.PlayAniNoteOffset(num, 6);
		}

		// Token: 0x0603D104 RID: 250116 RVA: 0x00EB0BF3 File Offset: 0x00EAEDF3
		protected override void OnAttributeChanged()
		{
			this.RefreshBar(false);
		}

		// Token: 0x0603D105 RID: 250117 RVA: 0x00EB0BFC File Offset: 0x00EAEDFC
		protected override void OnMaxAttributeChanged()
		{
		}

		// Token: 0x0603D106 RID: 250118 RVA: 0x00EB0C00 File Offset: 0x00EAEE00
		private void RefreshBar(bool isStart = false)
		{
			if (!isStart)
			{
				List<int> lastSpecialEnergyTypeList = this.LastSpecialEnergyTypeList;
				this.LastSpecialEnergyTypeList = this.SpecialEnergyTypeList;
				this.SpecialEnergyTypeList = lastSpecialEnergyTypeList;
			}
			this.SpecialEnergyTypeList.Clear();
			int num = (int)this.AttributeComponent.GetCurrentValue(this.AttributeId);
			for (int i = 0; i < 6; i++)
			{
				int num2 = (6 - i - 1) * 2;
				int num3 = (num & 3 << num2) >> num2;
				if (num3 > 0)
				{
					this.SpecialEnergyTypeList.Add(num3);
				}
			}
			if (isStart)
			{
				for (int j = 0; j < 6; j++)
				{
					SpecialEnergyBarFuLuoLuoNoteItem specialEnergyBarFuLuoLuoNoteItem = this.NoteItemList[j];
					int valueOrDefault = this.SpecialEnergyTypeList.GetValueOrDefault(j, 0);
					specialEnergyBarFuLuoLuoNoteItem.SetEnergyType(valueOrDefault);
					specialEnergyBarFuLuoLuoNoteItem.SetParent(this.SlotItemList[j]);
				}
				this.NoteItemList[6].SetEnergyType(0);
				BaseTagComponent tagComponent = this.TagComponent;
				this.SetLockState(tagComponent != null && tagComponent.HasTag(SpecialEnergyBarFuLuoLuo.LockTag), isStart);
				BaseTagComponent tagComponent2 = this.TagComponent;
				this.SetBurstState(tagComponent2 != null && tagComponent2.HasTag(SpecialEnergyBarFuLuoLuo.BurstTag), isStart);
				BaseTagComponent tagComponent3 = this.TagComponent;
				this.SetKeyDisableState(tagComponent3 != null && tagComponent3.HasTag(SpecialEnergyBarFuLuoLuo.DisableTag));
			}
			else
			{
				int count = this.LastSpecialEnergyTypeList.Count;
				int count2 = this.SpecialEnergyTypeList.Count;
				if (count2 > count)
				{
					this.RefreshAllNoteItemEnergyType();
				}
				else if (count2 == count)
				{
					int num4 = -1;
					for (int k = 0; k < count2; k++)
					{
						if (this.LastSpecialEnergyTypeList[k] != 3)
						{
							num4 = k;
							break;
						}
					}
					if (num4 >= 0)
					{
						this.PlayAniNoteOffset(num4, count2);
					}
				}
				else if (!this.BurstState)
				{
					this.RefreshAllNoteItemEnergyType();
				}
			}
			this.RefreshKeyItem(isStart);
			this.RefreshKeyEnable(isStart);
		}

		// Token: 0x0603D107 RID: 250119 RVA: 0x00EB0DBC File Offset: 0x00EAEFBC
		private void PlayAniNoteOffset(int startIndex, int specialEnergyTypeNum)
		{
			SpecialEnergyBarFuLuoLuoNoteItem specialEnergyBarFuLuoLuoNoteItem = this.NoteItemList[startIndex];
			this.NoteItemList.RemoveAt(startIndex);
			this.NoteItemList.Add(specialEnergyBarFuLuoLuoNoteItem);
			base.StopTweenAnim(13);
			this.PosItemList[5].SetAlpha(1f);
			specialEnergyBarFuLuoLuoNoteItem.SetParent(this.SlotItemList[startIndex]);
			for (int i = 0; i < startIndex; i++)
			{
				this.NoteItemList[i].SetParent(this.SlotItemList[i]);
			}
			for (int j = startIndex; j < specialEnergyTypeNum; j++)
			{
				this.NoteItemList[j].SetParent(this.PosItemList[j]);
			}
			this.RefreshAllNoteItemEnergyType();
			base.PlayTweenAnim(13);
		}

		// Token: 0x0603D108 RID: 250120 RVA: 0x00EB0E80 File Offset: 0x00EAF080
		private void RefreshKeyItem(bool isStart)
		{
			if (this.BurstState)
			{
				SpecialEnergyBarKeyItem keyItem = this.KeyItem;
				if (keyItem != null)
				{
					keyItem.SetUiActive(false);
				}
				SpecialEnergyBarKeyItem burstKeyItem = this.BurstKeyItem;
				if (burstKeyItem == null)
				{
					return;
				}
				burstKeyItem.SetUiActive(false);
				return;
			}
			else if (this.LockState)
			{
				SpecialEnergyBarKeyItem keyItem2 = this.KeyItem;
				if (keyItem2 != null)
				{
					keyItem2.SetUiActive(false);
				}
				SpecialEnergyBarKeyItem burstKeyItem2 = this.BurstKeyItem;
				if (burstKeyItem2 != null)
				{
					burstKeyItem2.SetUiActive(true);
				}
				SpecialEnergyBarKeyItem burstKeyItem3 = this.BurstKeyItem;
				if (burstKeyItem3 == null)
				{
					return;
				}
				burstKeyItem3.RefreshKeyEnable(true, isStart);
				return;
			}
			else
			{
				SpecialEnergyBarKeyItem keyItem3 = this.KeyItem;
				if (keyItem3 != null)
				{
					keyItem3.SetUiActive(true);
				}
				SpecialEnergyBarKeyItem burstKeyItem4 = this.BurstKeyItem;
				if (burstKeyItem4 == null)
				{
					return;
				}
				burstKeyItem4.SetUiActive(false);
				return;
			}
		}

		// Token: 0x0603D109 RID: 250121 RVA: 0x00EB0F1C File Offset: 0x00EAF11C
		private void RefreshKeyEnable(bool isStart)
		{
			bool keyEnable = this.GetKeyEnable();
			SpecialEnergyBarKeyItem keyItem = this.KeyItem;
			if (keyItem == null)
			{
				return;
			}
			keyItem.RefreshKeyEnable(keyEnable, isStart);
		}

		// Token: 0x0603D10A RID: 250122 RVA: 0x00EB0F42 File Offset: 0x00EAF142
		protected override bool GetKeyEnable()
		{
			return this.SpecialEnergyTypeList.Count >= 6 && !this.KeyDisableState;
		}

		// Token: 0x0603D10B RID: 250123 RVA: 0x00EB0F5F File Offset: 0x00EAF15F
		private void SetKeyDisableState(bool state)
		{
			if (this.KeyDisableState == state)
			{
				return;
			}
			this.KeyDisableState = state;
			this.RefreshKeyEnable(false);
		}

		// Token: 0x0603D10C RID: 250124 RVA: 0x00EB0F7C File Offset: 0x00EAF17C
		private void RefreshAllNoteItemEnergyType()
		{
			for (int i = 0; i < this.NoteItemList.Count; i++)
			{
				SpecialEnergyBarFuLuoLuoNoteItem specialEnergyBarFuLuoLuoNoteItem = this.NoteItemList[i];
				int valueOrDefault = this.SpecialEnergyTypeList.GetValueOrDefault(i, 0);
				specialEnergyBarFuLuoLuoNoteItem.SetEnergyType(valueOrDefault);
			}
		}

		// Token: 0x0603D10D RID: 250125 RVA: 0x00EB0FC0 File Offset: 0x00EAF1C0
		private void SetLockState(bool state, bool isStart = false)
		{
			if (this.LockState == state)
			{
				return;
			}
			this.LockState = state;
			if (state)
			{
				base.StopTweenAnim(16);
				base.PlayTweenAnim(15);
			}
			else
			{
				base.StopTweenAnim(15);
				base.PlayTweenAnim(16);
			}
			foreach (SpecialEnergyBarFuLuoLuoNoteItem specialEnergyBarFuLuoLuoNoteItem in this.NoteItemList)
			{
				specialEnergyBarFuLuoLuoNoteItem.SetLockState(state);
			}
			if (!isStart)
			{
				this.RefreshKeyItem(isStart);
			}
		}

		// Token: 0x0603D10E RID: 250126 RVA: 0x00EB1054 File Offset: 0x00EAF254
		private void SetBurstState(bool state, bool isStart = false)
		{
			if (this.BurstState == state)
			{
				return;
			}
			this.BurstState = state;
			if (state)
			{
				this.StartBurstAnim();
			}
			else
			{
				this.StopBurstAnim();
			}
			if (!isStart)
			{
				this.RefreshKeyItem(isStart);
			}
		}

		// Token: 0x0603D10F RID: 250127 RVA: 0x00EB1084 File Offset: 0x00EAF284
		private void StartBurstAnim()
		{
			if (this.IsPerforming)
			{
				return;
			}
			this.IsPerforming = true;
			this.NoteCount = 0;
			for (int i = 0; i < 6; i++)
			{
				this.NoteItemList[i].SetParent(this.SlotItemList[i]);
			}
			base.StopTweenAnim(16);
			base.PlayTweenAnim(17);
			this.RefreshTimeScale();
			this.PerformTimer = TimerSystem.Instance.Delay(new TTimerAction(this.OnFirstNoteTimer), 1250f, null, null, true, 1f);
			if (this.PerformTimer != null && this.TimeScale != 1f)
			{
				if (this.TimeScale <= 0f)
				{
					TimerSystem.Instance.Pause(this.PerformTimer, null);
					return;
				}
				TimerSystem.Instance.ChangeDilation(this.PerformTimer, this.TimeScale, null);
			}
		}

		// Token: 0x0603D110 RID: 250128 RVA: 0x00EB1160 File Offset: 0x00EAF360
		private void StopBurstAnim()
		{
			this.IsPerforming = false;
			base.StopTweenAnim(17);
			base.PlayTweenAnim(16);
			this.RefreshAllNoteItemEnergyType();
			foreach (UUIItem uuiitem in this.SlotItemList)
			{
				uuiitem.SetAlpha(1f);
			}
			for (int i = 0; i < 6; i++)
			{
				SpecialEnergyBarFuLuoLuoNoteItem specialEnergyBarFuLuoLuoNoteItem = this.NoteItemList[i];
				specialEnergyBarFuLuoLuoNoteItem.SetParent(this.SlotItemList[i]);
				specialEnergyBarFuLuoLuoNoteItem.SetPerformState(false);
			}
			this.NoteItemList[6].SetPerformState(false);
			this.RemovePerformTimer();
			this.RefreshTimeScale();
		}

		// Token: 0x0603D111 RID: 250129 RVA: 0x00EB1220 File Offset: 0x00EAF420
		private void OnFirstNoteTimer(float _)
		{
			this.NextNotePerform();
			this.NoteCount++;
			this.PerformTimer = TimerSystem.Instance.Loop(new TTimerAction(this.OnTimer), 4000f, 5, this.TimeScale, null, null, true);
		}

		// Token: 0x0603D112 RID: 250130 RVA: 0x00EB126C File Offset: 0x00EAF46C
		private void OnTimer(float _)
		{
			this.NextNotePerform();
			this.NoteCount++;
			if (this.NoteCount < 6)
			{
				return;
			}
			this.RemovePerformTimer();
		}

		// Token: 0x0603D113 RID: 250131 RVA: 0x00EB1294 File Offset: 0x00EAF494
		private void NextNotePerform()
		{
			SpecialEnergyBarFuLuoLuoNoteItem specialEnergyBarFuLuoLuoNoteItem = this.NoteItemList.Shift<SpecialEnergyBarFuLuoLuoNoteItem>();
			this.NoteItemList.Add(specialEnergyBarFuLuoLuoNoteItem);
			specialEnergyBarFuLuoLuoNoteItem.SetPerformState(true);
		}

		// Token: 0x0603D114 RID: 250132 RVA: 0x00EB12C0 File Offset: 0x00EAF4C0
		private void RemovePerformTimer()
		{
			if (this.PerformTimer != null && TimerSystem.Instance.Has(this.PerformTimer))
			{
				TimerSystem.Instance.Remove(this.PerformTimer);
				this.PerformTimer = null;
			}
		}

		// Token: 0x0401FD06 RID: 130310
		private const int SPECIAL_ENERGY_COUNT = 6;

		// Token: 0x0401FD07 RID: 130311
		[StaticVariableRuleIgnore]
		private static readonly int LockTag = GameplayTagDefine.EGameplayTagId["角色.R2T1FuluoluoMd10011.状态标识.乐谱锁定"];

		// Token: 0x0401FD08 RID: 130312
		[StaticVariableRuleIgnore]
		private static readonly int BurstTag = GameplayTagDefine.EGameplayTagId["角色.R2T1FuluoluoMd10011.状态标识.大招状态"];

		// Token: 0x0401FD09 RID: 130313
		[StaticVariableRuleIgnore]
		private static readonly int DisableTag = GameplayTagDefine.EGameplayTagId["角色.R2T1FuluoluoMd10011.状态标识.强化重击CD"];

		// Token: 0x0401FD0A RID: 130314
		private const int FIRST_NOTE_TIME = 1250;

		// Token: 0x0401FD0B RID: 130315
		private const int NOTE_INTERVAL_TIME = 4000;

		// Token: 0x0401FD0C RID: 130316
		private const int BURST_CONFIG_ID = 160801;

		// Token: 0x0401FD0D RID: 130317
		[Nullable(2)]
		private Entity Entity;

		// Token: 0x0401FD0E RID: 130318
		[Nullable(2)]
		private SpecialEnergyBarInfo BurstConfig;

		// Token: 0x0401FD0F RID: 130319
		[Nullable(2)]
		private SpecialEnergyBarKeyItem BurstKeyItem;

		// Token: 0x0401FD10 RID: 130320
		private List<int> SpecialEnergyTypeList = new List<int>();

		// Token: 0x0401FD11 RID: 130321
		private List<int> LastSpecialEnergyTypeList = new List<int>();

		// Token: 0x0401FD12 RID: 130322
		private readonly List<FColor> ColorList = new List<FColor>();

		// Token: 0x0401FD13 RID: 130323
		private readonly List<SpecialEnergyBarFuLuoLuoNoteItem> NoteItemList = new List<SpecialEnergyBarFuLuoLuoNoteItem>();

		// Token: 0x0401FD14 RID: 130324
		private readonly List<UUIItem> SlotItemList = new List<UUIItem>();

		// Token: 0x0401FD15 RID: 130325
		private readonly List<UUIItem> PosItemList = new List<UUIItem>();

		// Token: 0x0401FD16 RID: 130326
		private bool LockState;

		// Token: 0x0401FD17 RID: 130327
		private bool BurstState;

		// Token: 0x0401FD18 RID: 130328
		private bool KeyDisableState;

		// Token: 0x0401FD19 RID: 130329
		private bool IsPerforming;

		// Token: 0x0401FD1A RID: 130330
		[Nullable(2)]
		private TimerHandle PerformTimer;

		// Token: 0x0401FD1B RID: 130331
		private int NoteCount;

		// Token: 0x0401FD1C RID: 130332
		private float TimeScale = -1f;

		// Token: 0x0200C0F5 RID: 49397
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x0403A3D0 RID: 238544
			KeyItem,
			// Token: 0x0403A3D1 RID: 238545
			SlotItem1,
			// Token: 0x0403A3D2 RID: 238546
			SlotItem2,
			// Token: 0x0403A3D3 RID: 238547
			SlotItem3,
			// Token: 0x0403A3D4 RID: 238548
			SlotItem4,
			// Token: 0x0403A3D5 RID: 238549
			SlotItem5,
			// Token: 0x0403A3D6 RID: 238550
			SlotItem6,
			// Token: 0x0403A3D7 RID: 238551
			PosItem1,
			// Token: 0x0403A3D8 RID: 238552
			PosItem2,
			// Token: 0x0403A3D9 RID: 238553
			PosItem3,
			// Token: 0x0403A3DA RID: 238554
			PosItem4,
			// Token: 0x0403A3DB RID: 238555
			PosItem5,
			// Token: 0x0403A3DC RID: 238556
			PosItem6,
			// Token: 0x0403A3DD RID: 238557
			AniNoteOffset,
			// Token: 0x0403A3DE RID: 238558
			AniNoteReset,
			// Token: 0x0403A3DF RID: 238559
			AniLock,
			// Token: 0x0403A3E0 RID: 238560
			AniDefault,
			// Token: 0x0403A3E1 RID: 238561
			AniBurst,
			// Token: 0x0403A3E2 RID: 238562
			NoteItem
		}
	}
}
