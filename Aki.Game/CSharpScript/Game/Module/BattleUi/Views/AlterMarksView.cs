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
	// Token: 0x02004C91 RID: 19601
	[NullableContext(1)]
	[Nullable(0)]
	public class AlterMarksView : BattleChildView
	{
		// Token: 0x06030E61 RID: 200289 RVA: 0x00DA365C File Offset: 0x00DA185C
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

		// Token: 0x06030E62 RID: 200290 RVA: 0x00DA3794 File Offset: 0x00DA1994
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

		// Token: 0x06030E63 RID: 200291 RVA: 0x00DA3810 File Offset: 0x00DA1A10
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

		// Token: 0x06030E64 RID: 200292 RVA: 0x00DA39B8 File Offset: 0x00DA1BB8
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

		// Token: 0x06030E65 RID: 200293 RVA: 0x00DA3B5C File Offset: 0x00DA1D5C
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

		// Token: 0x06030E66 RID: 200294 RVA: 0x00DA3C30 File Offset: 0x00DA1E30
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

		// Token: 0x06030E67 RID: 200295 RVA: 0x00DA3C98 File Offset: 0x00DA1E98
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

		// Token: 0x06030E68 RID: 200296 RVA: 0x00DA3D00 File Offset: 0x00DA1F00
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

		// Token: 0x06030E69 RID: 200297 RVA: 0x00DA3D50 File Offset: 0x00DA1F50
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

		// Token: 0x06030E6A RID: 200298 RVA: 0x00DA3DA4 File Offset: 0x00DA1FA4
		private void AddEavesdropMark(int id, AActor trackActor, float showDist)
		{
			if (!this.EavesdropMarks.ContainsKey(id))
			{
				EavesdropMark eavesdropMark = new EavesdropMark(trackActor, id);
				eavesdropMark.Initialize(UiLayer.Instance.WorldSpaceUiRootItem, showDist);
				this.EavesdropMarks[id] = eavesdropMark;
			}
		}

		// Token: 0x06030E6B RID: 200299 RVA: 0x00DA3DE8 File Offset: 0x00DA1FE8
		private void RemoveEavesdropMark(int id)
		{
			EavesdropMark eavesdropMark;
			if (this.EavesdropMarks.TryGetValue(id, out eavesdropMark))
			{
				eavesdropMark.Destroy(null);
				this.EavesdropMarks.Remove(id);
			}
		}

		// Token: 0x06030E6C RID: 200300 RVA: 0x00DA3E1C File Offset: 0x00DA201C
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

		// Token: 0x06030E6D RID: 200301 RVA: 0x00DA3E88 File Offset: 0x00DA2088
		private void HideCountdown()
		{
			if (!this.IsCountdown)
			{
				return;
			}
			this.IsCountdown = false;
			this.TimeItem.SetUiActive(this.IsCountdown);
		}

		// Token: 0x06030E6E RID: 200302 RVA: 0x00DA3EAC File Offset: 0x00DA20AC
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

		// Token: 0x06030E6F RID: 200303 RVA: 0x00DA3FE8 File Offset: 0x00DA21E8
		private void OnFinish()
		{
			this.HideCountdown();
		}

		// Token: 0x06030E70 RID: 200304 RVA: 0x00DA3FF0 File Offset: 0x00DA21F0
		private void BindEavesdropEvents()
		{
			EventSystem.Instance.Add(EEventName.AddEavesdropMark, new Action<int, AActor, float>(this.AddEavesdropMark));
			EventSystem.Instance.Add(EEventName.RemoveEavesdropMark, new Action<int>(this.RemoveEavesdropMark));
			EventSystem.Instance.Add(EEventName.OnEavesdropFound, new Action<int>(this.OnEavesdropFound));
		}

		// Token: 0x06030E71 RID: 200305 RVA: 0x00DA4054 File Offset: 0x00DA2254
		private void UnbindEavesdropEvents()
		{
			EventSystem.Instance.Remove(EEventName.AddEavesdropMark, new Action<int, AActor, float>(this.AddEavesdropMark));
			EventSystem.Instance.Remove(EEventName.RemoveEavesdropMark, new Action<int>(this.RemoveEavesdropMark));
			EventSystem.Instance.Remove(EEventName.OnEavesdropFound, new Action<int>(this.OnEavesdropFound));
		}

		// Token: 0x06030E72 RID: 200306 RVA: 0x00DA40B8 File Offset: 0x00DA22B8
		private void BindStalkEvents()
		{
			EventSystem.Instance.Add(EEventName.AddStalkAlertMark, new Action<int, AActor>(this.AddStalkAlertMark));
			EventSystem.Instance.Add(EEventName.RemoveStalkAlertMark, new Action<int>(this.RemoveStalkAlertMark));
			EventSystem.Instance.Add(EEventName.OnStalkFound, new Action<int>(this.OnStalkFound));
			EventSystem.Instance.Add(EEventName.OnStalkFailed, new Action(this.OnStalkFailed));
		}

		// Token: 0x06030E73 RID: 200307 RVA: 0x00DA4138 File Offset: 0x00DA2338
		private void UnbindStalkEvents()
		{
			EventSystem.Instance.Remove(EEventName.AddStalkAlertMark, new Action<int, AActor>(this.AddStalkAlertMark));
			EventSystem.Instance.Remove(EEventName.RemoveStalkAlertMark, new Action<int>(this.RemoveStalkAlertMark));
			EventSystem.Instance.Remove(EEventName.OnStalkFound, new Action<int>(this.OnStalkFound));
			EventSystem.Instance.Remove(EEventName.OnStalkFailed, new Action(this.OnStalkFailed));
		}

		// Token: 0x06030E74 RID: 200308 RVA: 0x00DA41B8 File Offset: 0x00DA23B8
		private void BindMarksEvents()
		{
			EventSystem.Instance.Add(EEventName.AddAlterMark, new Action<int, global::Vector, AActor>(this.AddMark));
			EventSystem.Instance.Add(EEventName.RemoveAlterMark, new Action<int>(this.RemoveMark));
			this.IsBindMarkEvent = true;
		}

		// Token: 0x06030E75 RID: 200309 RVA: 0x00DA4204 File Offset: 0x00DA2404
		private void UnbindMarksEvents()
		{
			EventSystem.Instance.Remove(EEventName.AddAlterMark, new Action<int, global::Vector, AActor>(this.AddMark));
			EventSystem.Instance.Remove(EEventName.RemoveAlterMark, new Action<int>(this.RemoveMark));
			this.IsBindMarkEvent = false;
		}

		// Token: 0x06030E76 RID: 200310 RVA: 0x00DA4250 File Offset: 0x00DA2450
		private void OnTagChange(int tagId, bool tagExists)
		{
			UUIItem maskItem = this.MaskItem;
			if (maskItem == null)
			{
				return;
			}
			maskItem.SetUIActive(tagExists);
		}

		// Token: 0x06030E77 RID: 200311 RVA: 0x00DA4264 File Offset: 0x00DA2464
		private void OnChangeRole(int i, int i1)
		{
			BattleUiRoleData curRoleData = BattleUiModel.Instance.GetCurRoleData();
			this.UpdateListenTagTask(curRoleData);
			if (this.CurPlayerEntity != null)
			{
				this.UpdateAiHateChangedEvent(curRoleData.EntityHandle);
			}
		}

		// Token: 0x06030E78 RID: 200312 RVA: 0x00DA4297 File Offset: 0x00DA2497
		private void OnSneakStart()
		{
			this.SetActive(true);
		}

		// Token: 0x06030E79 RID: 200313 RVA: 0x00DA42A0 File Offset: 0x00DA24A0
		private void OnSneakEnd()
		{
			if (this.StalkAlertMarks.Count == 0)
			{
				this.SetActive(false);
			}
		}

		// Token: 0x06030E7A RID: 200314 RVA: 0x00DA42B8 File Offset: 0x00DA24B8
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

		// Token: 0x06030E7B RID: 200315 RVA: 0x00DA4454 File Offset: 0x00DA2654
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

		// Token: 0x06030E7C RID: 200316 RVA: 0x00DA44BC File Offset: 0x00DA26BC
		private void UpdateAiHateChangedEvent(EntityHandle newEntityHandle)
		{
			if (EventSystem.Instance.HasWithTarget(this.CurPlayerEntity.Entity, EEventName.AiHateAddOrRemove, new Action<bool, AiController>(this.OnAiHateChanged)))
			{
				EventSystem.Instance.RemoveWithTarget(this.CurPlayerEntity.Entity, EEventName.AiHateAddOrRemove, new Action<bool, AiController>(this.OnAiHateChanged));
				this.CurPlayerEntity = newEntityHandle;
				EventSystem.Instance.AddWithTarget(this.CurPlayerEntity.Entity, EEventName.AiHateAddOrRemove, new Action<bool, AiController>(this.OnAiHateChanged));
			}
		}

		// Token: 0x06030E7D RID: 200317 RVA: 0x00DA4548 File Offset: 0x00DA2748
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

		// Token: 0x06030E7E RID: 200318 RVA: 0x00DA457C File Offset: 0x00DA277C
		private void OnStalkFailed()
		{
			foreach (StalkAlertMark stalkAlertMark in this.StalkAlertMarks.Values)
			{
				stalkAlertMark.Destroy(null);
			}
			this.StalkAlertMarks.Clear();
		}

		// Token: 0x06030E7F RID: 200319 RVA: 0x00DA45E0 File Offset: 0x00DA27E0
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

		// Token: 0x06030E80 RID: 200320 RVA: 0x00DA4698 File Offset: 0x00DA2898
		public void OnBattleHudVisibleChanged(bool visible)
		{
			if (SneakController.Instance.IsSneaking)
			{
				this.SetActive(visible);
			}
		}

		// Token: 0x04019F3C RID: 106300
		[StaticVariableRuleIgnore]
		private static readonly Stat ListenTagStat = Stat.Create("[AlterMarksView]ListenTag", "", "");

		// Token: 0x04019F3D RID: 106301
		private readonly Dictionary<int, AlterMark> AlterMarks = new Dictionary<int, AlterMark>();

		// Token: 0x04019F3E RID: 106302
		private readonly Dictionary<int, AlterTipMark> AlterTipMarks = new Dictionary<int, AlterTipMark>();

		// Token: 0x04019F3F RID: 106303
		private readonly Dictionary<int, StalkAlertMark> StalkAlertMarks = new Dictionary<int, StalkAlertMark>();

		// Token: 0x04019F40 RID: 106304
		private readonly Dictionary<int, EavesdropMark> EavesdropMarks = new Dictionary<int, EavesdropMark>();

		// Token: 0x04019F41 RID: 106305
		private readonly Dictionary<int, AlterMarksView.WaitOperationUnit> WaitOperationMarks = new Dictionary<int, AlterMarksView.WaitOperationUnit>();

		// Token: 0x04019F42 RID: 106306
		private bool IsCountdown;

		// Token: 0x04019F43 RID: 106307
		private long EndTimeStamp;

		// Token: 0x04019F44 RID: 106308
		private double CountdownTime;

		// Token: 0x04019F45 RID: 106309
		private double CurTimeStamp;

		// Token: 0x04019F46 RID: 106310
		[Nullable(2)]
		private UUIItem MaskItem;

		// Token: 0x04019F47 RID: 106311
		[Nullable(2)]
		private AlterTime TimeItem;

		// Token: 0x04019F48 RID: 106312
		[Nullable(2)]
		private ITagTask ListenTagTask;

		// Token: 0x04019F49 RID: 106313
		[Nullable(2)]
		private EntityHandle CurPlayerEntity;

		// Token: 0x04019F4A RID: 106314
		private bool IsBindMarkEvent;

		// Token: 0x0200A88E RID: 43150
		[NullableContext(0)]
		private enum EOperationType
		{
			// Token: 0x0403411A RID: 213274
			Add,
			// Token: 0x0403411B RID: 213275
			Delete
		}

		// Token: 0x0200A88F RID: 43151
		[NullableContext(2)]
		[Nullable(0)]
		private class WaitOperationUnit
		{
			// Token: 0x0403411C RID: 213276
			public AlterMarksView.EOperationType Type;

			// Token: 0x0403411D RID: 213277
			public global::Vector OriginPosition;

			// Token: 0x0403411E RID: 213278
			public AActor TrackActor;
		}
	}
}
