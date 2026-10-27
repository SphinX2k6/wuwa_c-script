using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using CSharpScript.Game.World.Controller;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005CAF RID: 23727
	[NullableContext(1)]
	[Nullable(0)]
	public class AlterMarksView : BattleChildView
	{
		// Token: 0x0603BF0E RID: 245518 RVA: 0x00E52FB4 File Offset: 0x00E511B4
		[NullableContext(2)]
		public override void Initialize(object param = null)
		{
			base.Initialize(param);
			this.BindMarksEvents();
			this.BindStalkEvents();
			this.BindEavesdropEvents();
			this.ProcessPendingMarkInfo();
			EventSystem.Instance.Add<int, int>(EEventName.BattleUiCurRoleDataChanged, new Action<int, int>(this.OnChangeRole));
			EventSystem.Instance.Add<bool, long>(EEventName.OnSneakFoundChange, new Action<bool, long>(this.OnFoundStateChange));
			EventSystem.Instance.Add(EEventName.SneakStart, new Action(this.OnSneakStart));
			EventSystem.Instance.Add(EEventName.SneakEnd, new Action(this.OnSneakEnd));
			AlertMarkModel.Instance.AlertMarkInit = true;
			if (ConfigCommonParamById.GetBoolConfig("ShowSneakMask").GetValueOrDefault())
			{
				UUIItem layerRootUiItem = UiLayer.Instance.GetLayerRootUiItem(ELayerType.HUD);
				LguiUtil.Instance.LoadPrefabByResourceIdAsync("UiItem_Sneakzhezhao", layerRootUiItem, null, ResourceSystem.EResourceLoadPriority.Default, "js_undefined").ContinueWith(delegate(AActor actor)
				{
					if (actor == null)
					{
						return;
					}
					this.MaskItem = (actor.GetComponentByClass(UUIItem.StaticClass()) as UUIItem);
					UUIItem maskItem = this.MaskItem;
					if (maskItem != null)
					{
						maskItem.SetHierarchyIndex(0);
					}
					UUIItem maskItem2 = this.MaskItem;
					if (maskItem2 == null)
					{
						return;
					}
					maskItem2.SetUIActive(false);
				}).Forget();
			}
			this.TimeItem = new AlterTime();
			this.TimeItem.CreateByResourceIdAsync("UiItem_Sneakshijian", this.RootItem, false).Forget();
			BattleUiRoleData curRoleData = BattleUiModel.Instance.GetCurRoleData();
			this.UpdateListenTagTask(curRoleData);
			this.SetActive(false);
		}

		// Token: 0x0603BF0F RID: 245519 RVA: 0x00E530EC File Offset: 0x00E512EC
		[NullableContext(2)]
		private void UpdateListenTagTask(BattleUiRoleData roleData)
		{
			ITagTask listenTagTask = this.ListenTagTask;
			if (listenTagTask != null)
			{
				listenTagTask.EndTask();
			}
			BaseTagComponent baseTagComponent = (roleData != null) ? roleData.GameplayTagComponent : null;
			if (baseTagComponent == null)
			{
				Log.Instance.Error(ELogModule.UiCommon, ELogAuthor.CH, "获取当前角色BaseTagComponent失败", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.ListenTagTask = baseTagComponent.ListenForTagAddOrRemove(new int?(GameplayTagDefine.EGameplayTagId["功能.逻辑状态标识.潜行状态"]), new BaseTagComponent.TTagSwitchedCallback(this.OnTagChange), AlterMarksView.ListenTagStat);
		}

		// Token: 0x0603BF10 RID: 245520 RVA: 0x00E53168 File Offset: 0x00E51368
		public override void Reset()
		{
			base.Reset();
			this.UnbindMarksEvents();
			this.UnbindStalkEvents();
			this.UnbindEavesdropEvents();
			EventSystem.Instance.Remove(EEventName.BattleUiCurRoleDataChanged, new Action<int, int>(this.OnChangeRole));
			EventSystem.Instance.Remove(EEventName.OnSneakFoundChange, new Action<bool, long>(this.OnFoundStateChange));
			EventSystem.Instance.Remove(EEventName.SneakStart, new Action(this.OnSneakStart));
			EventSystem.Instance.Remove(EEventName.SneakEnd, new Action(this.OnSneakEnd));
			if (EventSystem.Instance.Has(EEventName.OnChildQuestNodeFinish, new Action(this.OnFinish)))
			{
				EventSystem.Instance.Remove(EEventName.OnChildQuestNodeFinish, new Action(this.OnFinish));
			}
			if (this.CurPlayerEntity != null)
			{
				EventSystem.Instance.RemoveWithTarget(this.CurPlayerEntity.Entity, EEventName.AiHateAddOrRemove, new Action<bool, AiController>(this.OnAiHateChanged));
				this.CurPlayerEntity = null;
			}
			foreach (AlterMark alterMark in this.AlterMarks.Values)
			{
				alterMark.Destroy(null);
			}
			this.AlterMarks.Clear();
			foreach (StalkAlertMark stalkAlertMark in this.StalkAlertMarks.Values)
			{
				stalkAlertMark.Destroy(null);
			}
			this.StalkAlertMarks.Clear();
		}

		// Token: 0x0603BF11 RID: 245521 RVA: 0x00E53310 File Offset: 0x00E51510
		public void Update(float delta)
		{
			this.UpdateAddMark();
			foreach (AlterMark alterMark in this.AlterMarks.Values)
			{
				alterMark.Update();
			}
			foreach (AlterTipMark alterTipMark in this.AlterTipMarks.Values)
			{
				alterTipMark.Update();
			}
			foreach (EavesdropMark eavesdropMark in this.EavesdropMarks.Values)
			{
				eavesdropMark.Update();
			}
			foreach (StalkAlertMark stalkAlertMark in this.StalkAlertMarks.Values)
			{
				if (stalkAlertMark.CheckShowUiCondition())
				{
					stalkAlertMark.Update();
				}
			}
			if (this.IsCountdown)
			{
				this.CurTimeStamp = TimeUtil.Instance.GetServerTimeStamp() / (double)TimeUtil.Instance.InverseMillisecond;
				this.CountdownTime = ((double)this.EndTimeStamp - this.CurTimeStamp) * (double)TimeUtil.Instance.InverseMillisecond;
				if (this.CountdownTime < 0.0)
				{
					this.HideCountdown();
					return;
				}
				this.TimeItem.SetCountdownText(this.CountdownTime);
			}
		}

		// Token: 0x0603BF12 RID: 245522 RVA: 0x00E534B4 File Offset: 0x00E516B4
		private void UpdateAddMark()
		{
			foreach (KeyValuePair<int, AlterMarksView.WaitOperationUnit> keyValuePair in this.WaitOperationMarks)
			{
				int num;
				AlterMarksView.WaitOperationUnit waitOperationUnit;
				keyValuePair.Deconstruct(out num, out waitOperationUnit);
				int num2 = num;
				AlterMarksView.WaitOperationUnit waitOperationUnit2 = waitOperationUnit;
				if (waitOperationUnit2.Type == AlterMarksView.EOperationType.Add)
				{
					AlterMark value = new AlterMark(this.RootItem, waitOperationUnit2.OriginPosition ?? global::Vector.Create(), waitOperationUnit2.TrackActor);
					this.AlterMarks[num2] = value;
					this.AddStalkAlertMark(num2, waitOperationUnit2.TrackActor);
				}
				else
				{
					AlterMark alterMark;
					if (this.AlterMarks.Remove(num2, out alterMark))
					{
						alterMark.Destroy(null);
					}
					this.RemoveStalkAlertMark(num2);
				}
			}
			this.WaitOperationMarks.Clear();
		}

		// Token: 0x0603BF13 RID: 245523 RVA: 0x00E53588 File Offset: 0x00E51788
		private void AddMark(int id, global::Vector originPosition, AActor trackActor)
		{
			if (!this.AlterMarks.ContainsKey(id))
			{
				AlterMarksView.WaitOperationUnit waitOperationUnit;
				if (this.WaitOperationMarks.TryGetValue(id, out waitOperationUnit))
				{
					if (waitOperationUnit.Type == AlterMarksView.EOperationType.Delete)
					{
						this.WaitOperationMarks.Remove(id);
						return;
					}
				}
				else
				{
					this.WaitOperationMarks[id] = new AlterMarksView.WaitOperationUnit
					{
						Type = AlterMarksView.EOperationType.Add,
						OriginPosition = originPosition,
						TrackActor = trackActor
					};
				}
			}
		}

		// Token: 0x0603BF14 RID: 245524 RVA: 0x00E535F0 File Offset: 0x00E517F0
		private void RemoveMark(int id)
		{
			bool flag = this.AlterMarks.ContainsKey(id);
			bool flag2 = this.WaitOperationMarks.ContainsKey(id);
			if (!flag && !flag2)
			{
				return;
			}
			if (flag2)
			{
				this.WaitOperationMarks.Remove(id);
				return;
			}
			if (flag)
			{
				this.WaitOperationMarks[id] = new AlterMarksView.WaitOperationUnit
				{
					Type = AlterMarksView.EOperationType.Delete,
					OriginPosition = null,
					TrackActor = null
				};
			}
		}

		// Token: 0x0603BF15 RID: 245525 RVA: 0x00E53658 File Offset: 0x00E51858
		private void AddStalkAlertMark(int id, AActor trackActor)
		{
			if (!this.StalkAlertMarks.ContainsKey(id))
			{
				StalkAlertMark stalkAlertMark = new StalkAlertMark(this.RootItem, trackActor);
				stalkAlertMark.InitEntityId(id);
				if (this.StalkAlertMarks.Count == 0)
				{
					this.SetActive(true);
				}
				this.StalkAlertMarks[id] = stalkAlertMark;
			}
		}

		// Token: 0x0603BF16 RID: 245526 RVA: 0x00E536A8 File Offset: 0x00E518A8
		private void RemoveStalkAlertMark(int id)
		{
			StalkAlertMark stalkAlertMark;
			if (this.StalkAlertMarks.TryGetValue(id, out stalkAlertMark))
			{
				stalkAlertMark.Destroy(null);
				this.StalkAlertMarks.Remove(id);
				if (this.StalkAlertMarks.Count == 0 && !SneakController.Instance.IsSneaking)
				{
					this.SetActive(false);
				}
			}
		}

		// Token: 0x0603BF17 RID: 245527 RVA: 0x00E536FC File Offset: 0x00E518FC
		private void AddEavesdropMark(int id, AActor trackActor, float showDist)
		{
			if (!this.EavesdropMarks.ContainsKey(id))
			{
				EavesdropMark eavesdropMark = new EavesdropMark(trackActor, id);
				eavesdropMark.Initialize(UiLayer.Instance.WorldSpaceUiRootItem, showDist);
				this.EavesdropMarks[id] = eavesdropMark;
			}
		}

		// Token: 0x0603BF18 RID: 245528 RVA: 0x00E53740 File Offset: 0x00E51940
		private void RemoveEavesdropMark(int id)
		{
			EavesdropMark eavesdropMark;
			if (this.EavesdropMarks.TryGetValue(id, out eavesdropMark))
			{
				eavesdropMark.Destroy(null);
				this.EavesdropMarks.Remove(id);
			}
		}

		// Token: 0x0603BF19 RID: 245529 RVA: 0x00E53774 File Offset: 0x00E51974
		private void OnEavesdropFound(int id)
		{
			foreach (KeyValuePair<int, EavesdropMark> keyValuePair in this.EavesdropMarks)
			{
				int num;
				EavesdropMark eavesdropMark;
				keyValuePair.Deconstruct(out num, out eavesdropMark);
				int num2 = num;
				EavesdropMark eavesdropMark2 = eavesdropMark;
				if (num2 == id)
				{
					eavesdropMark2.PlayFoundSeq();
				}
				else
				{
					eavesdropMark2.PlayEndSeq();
				}
			}
		}

		// Token: 0x0603BF1A RID: 245530 RVA: 0x00E537E0 File Offset: 0x00E519E0
		private void HideCountdown()
		{
			if (!this.IsCountdown)
			{
				return;
			}
			this.IsCountdown = false;
			this.TimeItem.SetUiActive(this.IsCountdown);
		}

		// Token: 0x0603BF1B RID: 245531 RVA: 0x00E53804 File Offset: 0x00E51A04
		private void OnFoundStateChange(bool isFound, long endTimeStamp)
		{
			if (isFound)
			{
				if (!this.IsCountdown)
				{
					this.UnbindMarksEvents();
				}
				foreach (AlterMark alterMark in this.AlterMarks.Values)
				{
					alterMark.Destroy(null);
				}
				foreach (StalkAlertMark stalkAlertMark in this.StalkAlertMarks.Values)
				{
					stalkAlertMark.Destroy(null);
				}
				this.AlterMarks.Clear();
				this.StalkAlertMarks.Clear();
				this.IsCountdown = true;
				this.EndTimeStamp = endTimeStamp;
				if (!EventSystem.Instance.Has(EEventName.OnChildQuestNodeFinish, new Action(this.OnFinish)))
				{
					EventSystem.Instance.Add(EEventName.OnChildQuestNodeFinish, new Action(this.OnFinish));
				}
			}
			else
			{
				if (!this.IsBindMarkEvent)
				{
					this.BindMarksEvents();
				}
				this.IsCountdown = false;
			}
			this.TimeItem.SetUiActive(this.IsCountdown);
			this.OnBattleStateChanged(isFound);
		}

		// Token: 0x0603BF1C RID: 245532 RVA: 0x00E53940 File Offset: 0x00E51B40
		private void OnFinish()
		{
			this.HideCountdown();
		}

		// Token: 0x0603BF1D RID: 245533 RVA: 0x00E53948 File Offset: 0x00E51B48
		private void BindEavesdropEvents()
		{
			EventSystem.Instance.Add(EEventName.AddEavesdropMark, new Action<int, AActor, float>(this.AddEavesdropMark));
			EventSystem.Instance.Add(EEventName.RemoveEavesdropMark, new Action<int>(this.RemoveEavesdropMark));
			EventSystem.Instance.Add(EEventName.OnEavesdropFound, new Action<int>(this.OnEavesdropFound));
		}

		// Token: 0x0603BF1E RID: 245534 RVA: 0x00E539AC File Offset: 0x00E51BAC
		private void UnbindEavesdropEvents()
		{
			EventSystem.Instance.Remove(EEventName.AddEavesdropMark, new Action<int, AActor, float>(this.AddEavesdropMark));
			EventSystem.Instance.Remove(EEventName.RemoveEavesdropMark, new Action<int>(this.RemoveEavesdropMark));
			EventSystem.Instance.Remove(EEventName.OnEavesdropFound, new Action<int>(this.OnEavesdropFound));
		}

		// Token: 0x0603BF1F RID: 245535 RVA: 0x00E53A10 File Offset: 0x00E51C10
		private void BindStalkEvents()
		{
			EventSystem.Instance.Add(EEventName.AddStalkAlertMark, new Action<int, AActor>(this.AddStalkAlertMark));
			EventSystem.Instance.Add(EEventName.RemoveStalkAlertMark, new Action<int>(this.RemoveStalkAlertMark));
			EventSystem.Instance.Add(EEventName.OnStalkFound, new Action<int>(this.OnStalkFound));
			EventSystem.Instance.Add(EEventName.OnStalkFailed, new Action(this.OnStalkFailed));
		}

		// Token: 0x0603BF20 RID: 245536 RVA: 0x00E53A90 File Offset: 0x00E51C90
		private void UnbindStalkEvents()
		{
			EventSystem.Instance.Remove(EEventName.AddStalkAlertMark, new Action<int, AActor>(this.AddStalkAlertMark));
			EventSystem.Instance.Remove(EEventName.RemoveStalkAlertMark, new Action<int>(this.RemoveStalkAlertMark));
			EventSystem.Instance.Remove(EEventName.OnStalkFound, new Action<int>(this.OnStalkFound));
			EventSystem.Instance.Remove(EEventName.OnStalkFailed, new Action(this.OnStalkFailed));
		}

		// Token: 0x0603BF21 RID: 245537 RVA: 0x00E53B10 File Offset: 0x00E51D10
		private void BindMarksEvents()
		{
			EventSystem.Instance.Add(EEventName.AddAlterMark, new Action<int, global::Vector, AActor>(this.AddMark));
			EventSystem.Instance.Add(EEventName.RemoveAlterMark, new Action<int>(this.RemoveMark));
			this.IsBindMarkEvent = true;
		}

		// Token: 0x0603BF22 RID: 245538 RVA: 0x00E53B5C File Offset: 0x00E51D5C
		private void UnbindMarksEvents()
		{
			EventSystem.Instance.Remove(EEventName.AddAlterMark, new Action<int, global::Vector, AActor>(this.AddMark));
			EventSystem.Instance.Remove(EEventName.RemoveAlterMark, new Action<int>(this.RemoveMark));
			this.IsBindMarkEvent = false;
		}

		// Token: 0x0603BF23 RID: 245539 RVA: 0x00E53BA8 File Offset: 0x00E51DA8
		private void OnTagChange(int tagId, bool tagExists)
		{
			UUIItem maskItem = this.MaskItem;
			if (maskItem == null)
			{
				return;
			}
			maskItem.SetUIActive(tagExists);
		}

		// Token: 0x0603BF24 RID: 245540 RVA: 0x00E53BBC File Offset: 0x00E51DBC
		private void OnChangeRole(int i, int i1)
		{
			BattleUiRoleData curRoleData = BattleUiModel.Instance.GetCurRoleData();
			this.UpdateListenTagTask(curRoleData);
			if (this.CurPlayerEntity != null)
			{
				this.UpdateAiHateChangedEvent(curRoleData.EntityHandle);
			}
		}

		// Token: 0x0603BF25 RID: 245541 RVA: 0x00E53BEF File Offset: 0x00E51DEF
		private void OnSneakStart()
		{
			this.SetActive(true);
		}

		// Token: 0x0603BF26 RID: 245542 RVA: 0x00E53BF8 File Offset: 0x00E51DF8
		private void OnSneakEnd()
		{
			if (this.StalkAlertMarks.Count == 0)
			{
				this.SetActive(false);
			}
		}

		// Token: 0x0603BF27 RID: 245543 RVA: 0x00E53C10 File Offset: 0x00E51E10
		private void OnBattleStateChanged(bool isInBattleState)
		{
			foreach (AlterTipMark alterTipMark in this.AlterTipMarks.Values)
			{
				alterTipMark.Destroy(null);
			}
			this.AlterTipMarks.Clear();
			if (isInBattleState)
			{
				if (!this.IsCountdown)
				{
					return;
				}
				if (this.CurPlayerEntity != null)
				{
					EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
					if (getCurrentEntity != this.CurPlayerEntity)
					{
						this.UpdateAiHateChangedEvent(getCurrentEntity);
					}
				}
				else
				{
					this.CurPlayerEntity = SceneTeamModel.Instance.GetCurrentEntity;
					EventSystem.Instance.AddWithTarget(this.CurPlayerEntity.Entity, EEventName.AiHateAddOrRemove, new Action<bool, AiController>(this.OnAiHateChanged));
				}
				using (HashSet<int>.Enumerator enumerator2 = this.CurPlayerEntity.Entity.CheckGetComponent<CharacterUnifiedStateComponent>().GetAggroSet().GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						int num = enumerator2.Current;
						AActor owner = CreatureModel.Instance.GetEntityById(num).Entity.CheckGetComponent<BaseActorComponent>().Owner;
						if (!this.AlterTipMarks.ContainsKey(num))
						{
							AlterTipMark alterTipMark2 = new AlterTipMark(this.RootItem, owner, true);
							this.AlterTipMarks[num] = alterTipMark2;
							alterTipMark2.ChangeToError();
						}
					}
					return;
				}
			}
			if (this.CurPlayerEntity != null)
			{
				EventSystem.Instance.RemoveWithTarget(this.CurPlayerEntity.Entity, EEventName.AiHateAddOrRemove, new Action<bool, AiController>(this.OnAiHateChanged));
				this.CurPlayerEntity = null;
			}
		}

		// Token: 0x0603BF28 RID: 245544 RVA: 0x00E53DAC File Offset: 0x00E51FAC
		private void OnAiHateChanged(bool addOrRemove, AiController from)
		{
			AActor owner = from.CharActorComp.Owner;
			int id = from.CharActorComp.Entity.Id;
			if (!this.AlterTipMarks.ContainsKey(id) && addOrRemove && this.IsCountdown)
			{
				AlterTipMark alterTipMark = new AlterTipMark(this.RootItem, owner, true);
				this.AlterTipMarks[id] = alterTipMark;
				alterTipMark.ChangeToError();
			}
		}

		// Token: 0x0603BF29 RID: 245545 RVA: 0x00E53E14 File Offset: 0x00E52014
		private void UpdateAiHateChangedEvent(EntityHandle newEntityHandle)
		{
			if (EventSystem.Instance.HasWithTarget(this.CurPlayerEntity.Entity, EEventName.AiHateAddOrRemove, new Action<bool, AiController>(this.OnAiHateChanged)))
			{
				EventSystem.Instance.RemoveWithTarget(this.CurPlayerEntity.Entity, EEventName.AiHateAddOrRemove, new Action<bool, AiController>(this.OnAiHateChanged));
				this.CurPlayerEntity = newEntityHandle;
				EventSystem.Instance.AddWithTarget(this.CurPlayerEntity.Entity, EEventName.AiHateAddOrRemove, new Action<bool, AiController>(this.OnAiHateChanged));
			}
		}

		// Token: 0x0603BF2A RID: 245546 RVA: 0x00E53EA0 File Offset: 0x00E520A0
		private void OnStalkFound(int id)
		{
			StalkAlertMark stalkAlertMark;
			if (this.StalkAlertMarks.TryGetValue(id, out stalkAlertMark))
			{
				stalkAlertMark.SetAlertIcon("/Game/Aki/UI/UIResources/Common/Atlas/SP_ComIconSign.SP_ComIconSign");
				stalkAlertMark.StopUpdateAlertValue();
				stalkAlertMark.ActivateAlertEffect();
			}
		}

		// Token: 0x0603BF2B RID: 245547 RVA: 0x00E53ED4 File Offset: 0x00E520D4
		private void OnStalkFailed()
		{
			foreach (StalkAlertMark stalkAlertMark in this.StalkAlertMarks.Values)
			{
				stalkAlertMark.Destroy(null);
			}
			this.StalkAlertMarks.Clear();
		}

		// Token: 0x0603BF2C RID: 245548 RVA: 0x00E53F38 File Offset: 0x00E52138
		public void ProcessPendingMarkInfo()
		{
			if (AlertMarkModel.Instance.PendingMarkInfos.Count == 0)
			{
				return;
			}
			foreach (KeyValuePair<int, ValueTuple<AActor, EAlertnessType, float>> keyValuePair in AlertMarkModel.Instance.PendingMarkInfos)
			{
				int num;
				ValueTuple<AActor, EAlertnessType, float> valueTuple;
				keyValuePair.Deconstruct(out num, out valueTuple);
				ValueTuple<AActor, EAlertnessType, float> valueTuple2 = valueTuple;
				int id = num;
				AActor item = valueTuple2.Item1;
				EAlertnessType item2 = valueTuple2.Item2;
				float item3 = valueTuple2.Item3;
				if (item2 != EAlertnessType.Stalk)
				{
					if (item2 == EAlertnessType.Eavesdrop)
					{
						this.AddEavesdropMark(id, item, item3);
					}
				}
				else
				{
					this.AddStalkAlertMark(id, item);
				}
			}
			AlertMarkModel.Instance.PendingMarkInfos.Clear();
		}

		// Token: 0x0603BF2D RID: 245549 RVA: 0x00E53FF0 File Offset: 0x00E521F0
		public void OnBattleHudVisibleChanged(bool visible)
		{
			if (SneakController.Instance.IsSneaking)
			{
				this.SetActive(visible);
			}
		}

		// Token: 0x0401F483 RID: 128131
		[StaticVariableRuleIgnore]
		private static readonly Stat ListenTagStat = Stat.Create("[AlterMarksView]ListenTag", "", "");

		// Token: 0x0401F484 RID: 128132
		private readonly Dictionary<int, AlterMark> AlterMarks = new Dictionary<int, AlterMark>();

		// Token: 0x0401F485 RID: 128133
		private readonly Dictionary<int, AlterTipMark> AlterTipMarks = new Dictionary<int, AlterTipMark>();

		// Token: 0x0401F486 RID: 128134
		private readonly Dictionary<int, StalkAlertMark> StalkAlertMarks = new Dictionary<int, StalkAlertMark>();

		// Token: 0x0401F487 RID: 128135
		private readonly Dictionary<int, EavesdropMark> EavesdropMarks = new Dictionary<int, EavesdropMark>();

		// Token: 0x0401F488 RID: 128136
		private readonly Dictionary<int, AlterMarksView.WaitOperationUnit> WaitOperationMarks = new Dictionary<int, AlterMarksView.WaitOperationUnit>();

		// Token: 0x0401F489 RID: 128137
		private bool IsCountdown;

		// Token: 0x0401F48A RID: 128138
		private long EndTimeStamp;

		// Token: 0x0401F48B RID: 128139
		private double CountdownTime;

		// Token: 0x0401F48C RID: 128140
		private double CurTimeStamp;

		// Token: 0x0401F48D RID: 128141
		[Nullable(2)]
		private UUIItem MaskItem;

		// Token: 0x0401F48E RID: 128142
		[Nullable(2)]
		private AlterTime TimeItem;

		// Token: 0x0401F48F RID: 128143
		[Nullable(2)]
		private ITagTask ListenTagTask;

		// Token: 0x0401F490 RID: 128144
		[Nullable(2)]
		private EntityHandle CurPlayerEntity;

		// Token: 0x0401F491 RID: 128145
		private bool IsBindMarkEvent;

		// Token: 0x0200BE88 RID: 48776
		[NullableContext(0)]
		private enum EOperationType
		{
			// Token: 0x04039759 RID: 235353
			Add,
			// Token: 0x0403975A RID: 235354
			Delete
		}

		// Token: 0x0200BE89 RID: 48777
		[NullableContext(2)]
		[Nullable(0)]
		private class WaitOperationUnit
		{
			// Token: 0x0403975B RID: 235355
			public AlterMarksView.EOperationType Type;

			// Token: 0x0403975C RID: 235356
			public global::Vector OriginPosition;

			// Token: 0x0403975D RID: 235357
			public AActor TrackActor;
		}
	}
}
