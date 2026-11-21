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
	// Token: 0x02004DBC RID: 19900
	[NullableContext(1)]
	[Nullable(0)]
	public class SpecialEnergyBarFuLuoLuo : SpecialEnergyBarBase
	{
		// Token: 0x0603206B RID: 204907 RVA: 0x00E01340 File Offset: 0x00DFF540
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

		// Token: 0x0603206C RID: 204908 RVA: 0x00E015E5 File Offset: 0x00DFF7E5
		protected override void OnInitData()
		{
			this.BurstConfig = BattleUiModel.Instance.SpecialEnergyBarData.GetSpecialEnergyBarInfo(160801);
		}

		// Token: 0x0603206D RID: 204909 RVA: 0x00E01604 File Offset: 0x00DFF804
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarFuLuoLuo.<OnBeforeStartAsync>d__26 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarFuLuoLuo.<OnBeforeStartAsync>d__26>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603206E RID: 204910 RVA: 0x00E01648 File Offset: 0x00DFF848
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

		// Token: 0x0603206F RID: 204911 RVA: 0x00E01694 File Offset: 0x00DFF894
		private UniTask InitNoteItems()
		{
			SpecialEnergyBarFuLuoLuo.<InitNoteItems>d__28 <InitNoteItems>d__;
			<InitNoteItems>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitNoteItems>d__.<>4__this = this;
			<InitNoteItems>d__.<>1__state = -1;
			<InitNoteItems>d__.<>t__builder.Start<SpecialEnergyBarFuLuoLuo.<InitNoteItems>d__28>(ref <InitNoteItems>d__);
			return <InitNoteItems>d__.<>t__builder.Task;
		}

		// Token: 0x06032070 RID: 204912 RVA: 0x00E016D8 File Offset: 0x00DFF8D8
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

		// Token: 0x06032071 RID: 204913 RVA: 0x00E01820 File Offset: 0x00DFFA20
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

		// Token: 0x06032072 RID: 204914 RVA: 0x00E018D4 File Offset: 0x00DFFAD4
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

		// Token: 0x06032073 RID: 204915 RVA: 0x00E01940 File Offset: 0x00DFFB40
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

		// Token: 0x06032074 RID: 204916 RVA: 0x00E01969 File Offset: 0x00DFFB69
		private void OnLockTagChange(int tagId, bool tagExist)
		{
			this.SetLockState(tagExist, false);
		}

		// Token: 0x06032075 RID: 204917 RVA: 0x00E01973 File Offset: 0x00DFFB73
		private void OnBurstTagChange(int tagId, bool tagExist)
		{
			this.SetBurstState(tagExist, false);
		}

		// Token: 0x06032076 RID: 204918 RVA: 0x00E0197D File Offset: 0x00DFFB7D
		private void OnDisableTagChange(int tagId, bool tagExist)
		{
			this.SetKeyDisableState(tagExist);
		}

		// Token: 0x06032077 RID: 204919 RVA: 0x00E01986 File Offset: 0x00DFFB86
		private void CharBeHitTimeScale(float _1, ETimeScaleSourceType _2)
		{
			this.OnTimeScaleChange();
		}

		// Token: 0x06032078 RID: 204920 RVA: 0x00E0198E File Offset: 0x00DFFB8E
		private void OnTimeScaleChange()
		{
			if (this.IsPerforming)
			{
				this.RefreshTimeScale();
			}
		}

		// Token: 0x06032079 RID: 204921 RVA: 0x00E019A0 File Offset: 0x00DFFBA0
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

		// Token: 0x0603207A RID: 204922 RVA: 0x00E01A7C File Offset: 0x00DFFC7C
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

		// Token: 0x0603207B RID: 204923 RVA: 0x00E01AE7 File Offset: 0x00DFFCE7
		protected override void OnAttributeChanged()
		{
			this.RefreshBar(false);
		}

		// Token: 0x0603207C RID: 204924 RVA: 0x00E01AF0 File Offset: 0x00DFFCF0
		protected override void OnMaxAttributeChanged()
		{
		}

		// Token: 0x0603207D RID: 204925 RVA: 0x00E01AF4 File Offset: 0x00DFFCF4
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

		// Token: 0x0603207E RID: 204926 RVA: 0x00E01CB0 File Offset: 0x00DFFEB0
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

		// Token: 0x0603207F RID: 204927 RVA: 0x00E01D74 File Offset: 0x00DFFF74
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

		// Token: 0x06032080 RID: 204928 RVA: 0x00E01E10 File Offset: 0x00E00010
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

		// Token: 0x06032081 RID: 204929 RVA: 0x00E01E36 File Offset: 0x00E00036
		protected override bool GetKeyEnable()
		{
			return this.SpecialEnergyTypeList.Count >= 6 && !this.KeyDisableState;
		}

		// Token: 0x06032082 RID: 204930 RVA: 0x00E01E53 File Offset: 0x00E00053
		private void SetKeyDisableState(bool state)
		{
			if (this.KeyDisableState == state)
			{
				return;
			}
			this.KeyDisableState = state;
			this.RefreshKeyEnable(false);
		}

		// Token: 0x06032083 RID: 204931 RVA: 0x00E01E70 File Offset: 0x00E00070
		private void RefreshAllNoteItemEnergyType()
		{
			for (int i = 0; i < this.NoteItemList.Count; i++)
			{
				SpecialEnergyBarFuLuoLuoNoteItem specialEnergyBarFuLuoLuoNoteItem = this.NoteItemList[i];
				int valueOrDefault = this.SpecialEnergyTypeList.GetValueOrDefault(i, 0);
				specialEnergyBarFuLuoLuoNoteItem.SetEnergyType(valueOrDefault);
			}
		}

		// Token: 0x06032084 RID: 204932 RVA: 0x00E01EB4 File Offset: 0x00E000B4
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

		// Token: 0x06032085 RID: 204933 RVA: 0x00E01F48 File Offset: 0x00E00148
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

		// Token: 0x06032086 RID: 204934 RVA: 0x00E01F78 File Offset: 0x00E00178
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

		// Token: 0x06032087 RID: 204935 RVA: 0x00E02054 File Offset: 0x00E00254
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

		// Token: 0x06032088 RID: 204936 RVA: 0x00E02114 File Offset: 0x00E00314
		private void OnFirstNoteTimer(float _)
		{
			this.NextNotePerform();
			this.NoteCount++;
			this.PerformTimer = TimerSystem.Instance.Loop(new TTimerAction(this.OnTimer), 4000f, 5, this.TimeScale, null, null, true);
		}

		// Token: 0x06032089 RID: 204937 RVA: 0x00E02160 File Offset: 0x00E00360
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

		// Token: 0x0603208A RID: 204938 RVA: 0x00E02188 File Offset: 0x00E00388
		private void NextNotePerform()
		{
			SpecialEnergyBarFuLuoLuoNoteItem specialEnergyBarFuLuoLuoNoteItem = this.NoteItemList.Shift<SpecialEnergyBarFuLuoLuoNoteItem>();
			this.NoteItemList.Add(specialEnergyBarFuLuoLuoNoteItem);
			specialEnergyBarFuLuoLuoNoteItem.SetPerformState(true);
		}

		// Token: 0x0603208B RID: 204939 RVA: 0x00E021B4 File Offset: 0x00E003B4
		private void RemovePerformTimer()
		{
			if (this.PerformTimer != null && TimerSystem.Instance.Has(this.PerformTimer))
			{
				TimerSystem.Instance.Remove(this.PerformTimer);
				this.PerformTimer = null;
			}
		}

		// Token: 0x0401A7C3 RID: 108483
		private const int SPECIAL_ENERGY_COUNT = 6;

		// Token: 0x0401A7C4 RID: 108484
		[StaticVariableRuleIgnore]
		private static readonly int LockTag = GameplayTagDefine.EGameplayTagId["角色.R2T1FuluoluoMd10011.状态标识.乐谱锁定"];

		// Token: 0x0401A7C5 RID: 108485
		[StaticVariableRuleIgnore]
		private static readonly int BurstTag = GameplayTagDefine.EGameplayTagId["角色.R2T1FuluoluoMd10011.状态标识.大招状态"];

		// Token: 0x0401A7C6 RID: 108486
		[StaticVariableRuleIgnore]
		private static readonly int DisableTag = GameplayTagDefine.EGameplayTagId["角色.R2T1FuluoluoMd10011.状态标识.强化重击CD"];

		// Token: 0x0401A7C7 RID: 108487
		private const int FIRST_NOTE_TIME = 1250;

		// Token: 0x0401A7C8 RID: 108488
		private const int NOTE_INTERVAL_TIME = 4000;

		// Token: 0x0401A7C9 RID: 108489
		private const int BURST_CONFIG_ID = 160801;

		// Token: 0x0401A7CA RID: 108490
		[Nullable(2)]
		private Entity Entity;

		// Token: 0x0401A7CB RID: 108491
		[Nullable(2)]
		private SpecialEnergyBarInfo BurstConfig;

		// Token: 0x0401A7CC RID: 108492
		[Nullable(2)]
		private SpecialEnergyBarKeyItem BurstKeyItem;

		// Token: 0x0401A7CD RID: 108493
		private List<int> SpecialEnergyTypeList = new List<int>();

		// Token: 0x0401A7CE RID: 108494
		private List<int> LastSpecialEnergyTypeList = new List<int>();

		// Token: 0x0401A7CF RID: 108495
		private readonly List<FColor> ColorList = new List<FColor>();

		// Token: 0x0401A7D0 RID: 108496
		private readonly List<SpecialEnergyBarFuLuoLuoNoteItem> NoteItemList = new List<SpecialEnergyBarFuLuoLuoNoteItem>();

		// Token: 0x0401A7D1 RID: 108497
		private readonly List<UUIItem> SlotItemList = new List<UUIItem>();

		// Token: 0x0401A7D2 RID: 108498
		private readonly List<UUIItem> PosItemList = new List<UUIItem>();

		// Token: 0x0401A7D3 RID: 108499
		private bool LockState;

		// Token: 0x0401A7D4 RID: 108500
		private bool BurstState;

		// Token: 0x0401A7D5 RID: 108501
		private bool KeyDisableState;

		// Token: 0x0401A7D6 RID: 108502
		private bool IsPerforming;

		// Token: 0x0401A7D7 RID: 108503
		[Nullable(2)]
		private TimerHandle PerformTimer;

		// Token: 0x0401A7D8 RID: 108504
		private int NoteCount;

		// Token: 0x0401A7D9 RID: 108505
		private float TimeScale = -1f;

		// Token: 0x0200AAFE RID: 43774
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04034DA2 RID: 216482
			KeyItem,
			// Token: 0x04034DA3 RID: 216483
			SlotItem1,
			// Token: 0x04034DA4 RID: 216484
			SlotItem2,
			// Token: 0x04034DA5 RID: 216485
			SlotItem3,
			// Token: 0x04034DA6 RID: 216486
			SlotItem4,
			// Token: 0x04034DA7 RID: 216487
			SlotItem5,
			// Token: 0x04034DA8 RID: 216488
			SlotItem6,
			// Token: 0x04034DA9 RID: 216489
			PosItem1,
			// Token: 0x04034DAA RID: 216490
			PosItem2,
			// Token: 0x04034DAB RID: 216491
			PosItem3,
			// Token: 0x04034DAC RID: 216492
			PosItem4,
			// Token: 0x04034DAD RID: 216493
			PosItem5,
			// Token: 0x04034DAE RID: 216494
			PosItem6,
			// Token: 0x04034DAF RID: 216495
			AniNoteOffset,
			// Token: 0x04034DB0 RID: 216496
			AniNoteReset,
			// Token: 0x04034DB1 RID: 216497
			AniLock,
			// Token: 0x04034DB2 RID: 216498
			AniDefault,
			// Token: 0x04034DB3 RID: 216499
			AniBurst,
			// Token: 0x04034DB4 RID: 216500
			NoteItem
		}
	}
}
