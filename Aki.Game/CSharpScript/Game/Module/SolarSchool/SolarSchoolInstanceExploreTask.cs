using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.ActivityAction;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058EB RID: 22763
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolInstanceExploreTask : SolarSchoolTaskBase
	{
		// Token: 0x17006BB1 RID: 27569
		// (get) Token: 0x060381E9 RID: 229865 RVA: 0x00FAF3BD File Offset: 0x00FAD5BD
		public bool IsEnding
		{
			get
			{
				return this.Phase == SolarSchoolInstanceExploreTask.ESolarSchoolInstancePhase.End;
			}
		}

		// Token: 0x060381EA RID: 229866 RVA: 0x00FAF3C8 File Offset: 0x00FAD5C8
		protected unsafe override void OnExecute()
		{
			this.LocationAvgProgress.Clear();
			this.EndLocationId = 0;
			this.PendingSettleLocation = 0;
			this.PendingOptionLocation = 0;
			this.Phase = SolarSchoolInstanceExploreTask.ESolarSchoolInstancePhase.Enter;
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			int activityId = instance.ActivityId;
			int instanceId = instance.InstanceId;
			foreach (SolarSchoolLocation solarSchoolLocation in SolarSchoolConfig.Instance.GetLocationList(activityId, instanceId))
			{
				if (solarSchoolLocation.IsEndLocation)
				{
					this.EndLocationId = solarSchoolLocation.Id;
					break;
				}
			}
			Log instance2 = Log.Instance;
			ELogModule module = ELogModule.SolarSchool;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "[SolarSchool] 副本进入探索";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("instanceId", instanceId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("instanceType", instance.InstanceType);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("endLocationId", this.EndLocationId);
			instance2.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			Log.Instance.Info(ELogModule.SolarSchool, ELogAuthor.LRC, "[SolarSchool] 副本探索中（GM: 进地点#locId / 选选项#optionId）", default(ReadOnlySpan<ValueTuple<string, object>>));
			List<SolarSchoolActionBase> list = new List<SolarSchoolActionBase>();
			SolarSchoolActionBase solarSchoolActionBase = instance.CreateAction(EActivityActionType.SolarSchoolTimeSlotSwitch, new Dictionary<string, string>
			{
				{
					"SolarSchoolTimeSlot",
					1.ToString()
				}
			});
			if (solarSchoolActionBase != null)
			{
				list.Add(solarSchoolActionBase);
			}
			SolarSchoolActionBase solarSchoolActionBase2 = instance.CreateAction(EActivityActionType.SolarSchoolGoHome, null);
			if (solarSchoolActionBase2 != null)
			{
				list.Add(solarSchoolActionBase2);
			}
			SolarSchoolInstance? instance3 = SolarSchoolConfig.Instance.GetInstance(activityId, instanceId);
			this.AppendActions(list, (instance3 != null) ? instance3.GetValueOrDefault().GetEnterActionIdListArray() : null);
			base.RunThen(list, new Action(this.OnEnterActionsFinished));
		}

		// Token: 0x060381EB RID: 229867 RVA: 0x00FAF5AC File Offset: 0x00FAD7AC
		private void OnEnterActionsFinished()
		{
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			if (SolarSchoolConfig.Instance.GetLocationList(instance.ActivityId, instance.InstanceId).Count == 0)
			{
				SolarSchoolInstance? instance2 = SolarSchoolConfig.Instance.GetInstance(instance.ActivityId, instance.InstanceId);
				if (((instance2 != null) ? instance2.GetValueOrDefault().MapActionIdListLength : 0) > 0)
				{
					Log instance3 = Log.Instance;
					ELogModule module = ELogModule.SolarSchool;
					ELogAuthor author = ELogAuthor.LRC;
					string message = "[SolarSchool] 副本没配地点，MapActionIdList 不会播，剧情要挪到 Enter/EndActionIdList";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("instanceId", instance.InstanceId);
					instance3.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				Log instance4 = Log.Instance;
				ELogModule module2 = ELogModule.SolarSchool;
				ELogAuthor author2 = ELogAuthor.LRC;
				string message2 = "[SolarSchool] 副本没配地点，开场剧情播完直接结束这一天";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("instanceId", instance.InstanceId);
				instance4.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				this.BeginEnd();
				return;
			}
			this.Phase = SolarSchoolInstanceExploreTask.ESolarSchoolInstancePhase.WaitGoOut;
			Log.Instance.Info(ELogModule.SolarSchool, ELogAuthor.LRC, "[SolarSchool] 副本入场流程结束，等待玩家【前往】", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x060381EC RID: 229868 RVA: 0x00FAF6AC File Offset: 0x00FAD8AC
		private void AppendActions(List<SolarSchoolActionBase> target, [Nullable(2)] int[] actionIds)
		{
			if (actionIds == null)
			{
				return;
			}
			foreach (int num in actionIds)
			{
				SolarSchoolActionBase solarSchoolActionBase = SolarSchoolGamePlayModel.Instance.CreateAction(num);
				if (solarSchoolActionBase == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.SolarSchool;
					ELogAuthor author = ELogAuthor.LRC;
					string message = "[SolarSchool] 副本流程 action 造失败";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("actionId", num);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				else
				{
					target.Add(solarSchoolActionBase);
				}
			}
		}

		// Token: 0x060381ED RID: 229869 RVA: 0x00FAF71C File Offset: 0x00FAD91C
		public void OnClickGoOut()
		{
			if (!base.IsExecuting)
			{
				Log.Instance.Error(ELogModule.SolarSchool, ELogAuthor.LRC, "[SolarSchool] 副本未激活，无法【前往】", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (this.Phase == SolarSchoolInstanceExploreTask.ESolarSchoolInstancePhase.Enter)
			{
				Log.Instance.Error(ELogModule.SolarSchool, ELogAuthor.LRC, "[SolarSchool] 副本开场播放中，忽略【前往】", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			Log.Instance.Info(ELogModule.SolarSchool, ELogAuthor.LRC, "[SolarSchool] 【前往】副本：打开地图界面", default(ReadOnlySpan<ValueTuple<string, object>>));
			if (this.Phase != SolarSchoolInstanceExploreTask.ESolarSchoolInstancePhase.WaitGoOut)
			{
				SolarSchoolGamePlayModel.Instance.OpenMapView(null);
				return;
			}
			this.Phase = SolarSchoolInstanceExploreTask.ESolarSchoolInstancePhase.Explore;
			this.GoOutAsync().Forget();
		}

		// Token: 0x060381EE RID: 229870 RVA: 0x00FAF7C0 File Offset: 0x00FAD9C0
		private UniTask GoOutAsync()
		{
			SolarSchoolInstanceExploreTask.<GoOutAsync>d__12 <GoOutAsync>d__;
			<GoOutAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<GoOutAsync>d__.<>4__this = this;
			<GoOutAsync>d__.<>1__state = -1;
			<GoOutAsync>d__.<>t__builder.Start<SolarSchoolInstanceExploreTask.<GoOutAsync>d__12>(ref <GoOutAsync>d__);
			return <GoOutAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060381EF RID: 229871 RVA: 0x00FAF804 File Offset: 0x00FADA04
		private unsafe void DrainInstanceMapNodes()
		{
			int instanceId = SolarSchoolGamePlayModel.Instance.InstanceId;
			int nodeId;
			SolarSchoolActionBase solarSchoolActionBase;
			if (!SolarSchoolQuestCenter.Instance.TryTakePendingNode(ESolarSchoolTriggerTiming.AtInstanceMap, instanceId, out nodeId, out solarSchoolActionBase) || solarSchoolActionBase == null)
			{
				this.EvaluateProgress();
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SolarSchool;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "[SolarSchool] 副本地图流程结束触发 QuestNode 剧情线";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("instanceId", instanceId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("nodeId", nodeId);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			base.RunThen(new List<SolarSchoolActionBase>
			{
				solarSchoolActionBase
			}, delegate()
			{
				SolarSchoolQuestNodeData nodeData = SolarSchoolGamePlayModel.Instance.QuestData.GetNodeData(nodeId);
				if (nodeData != null && nodeData.Completed)
				{
					this.DrainInstanceMapNodes();
					return;
				}
				this.EvaluateProgress();
			});
		}

		// Token: 0x060381F0 RID: 229872 RVA: 0x00FAF8CC File Offset: 0x00FADACC
		public unsafe void OnClickMapLocation(int locationId)
		{
			if (!this.CanInteract())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 当前不可进地点";
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("locationId", locationId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("executing", base.IsExecuting);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("handlerBusy", base.HandlerHasWork);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("phase", this.Phase);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
				return;
			}
			if (this.EndLocationId != 0 && locationId == this.EndLocationId)
			{
				if (!this.IsAllLocationCompleted())
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.SolarSchool;
					ELogAuthor author2 = ELogAuthor.LRC;
					string message2 = "[SolarSchool] 有地点未完成，结束地点不可点";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("locationId", locationId);
					instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					return;
				}
				this.AskEndConfirm();
				return;
			}
			else
			{
				if (!this.IsLocationOpen(locationId))
				{
					Log instance3 = Log.Instance;
					ELogModule module3 = ELogModule.SolarSchool;
					ELogAuthor author3 = ELogAuthor.LRC;
					string message3 = "[SolarSchool] 该地点当前显示/解锁条件不满足，不可进入";
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("locationId", locationId);
					instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
					return;
				}
				SolarSchoolGamePlayModel instance4 = SolarSchoolGamePlayModel.Instance;
				SolarSchoolLocation? location = SolarSchoolConfig.Instance.GetLocation(locationId);
				int[] array = ((location != null) ? location.GetValueOrDefault().GetActionIdListArray() : null) ?? Array.Empty<int>();
				int valueOrDefault = this.LocationAvgProgress.GetValueOrDefault(locationId, 0);
				if (valueOrDefault < array.Length)
				{
					int num = (location != null && location.GetValueOrDefault().IsSeparate) ? 1 : (array.Length - valueOrDefault);
					if (this.RunLocationActions(array, valueOrDefault, num, locationId))
					{
						this.LocationAvgProgress[locationId] = valueOrDefault + num;
						instance4.MapData.MarkLocationEntered(locationId);
					}
					return;
				}
				if (this.HasOptions(locationId))
				{
					Log instance5 = Log.Instance;
					ELogModule module4 = ELogModule.SolarSchool;
					ELogAuthor author4 = ELogAuthor.LRC;
					string message4 = "[SolarSchool] 地点剧情已播完，进入地点界面选选项";
					ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("locationId", locationId);
					instance5.Info(module4, author4, message4, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
					instance4.OpenLocationViewAsync(locationId).Forget();
					return;
				}
				Log instance6 = Log.Instance;
				ELogModule module5 = ELogModule.SolarSchool;
				ELogAuthor author5 = ELogAuthor.LRC;
				string message5 = "[SolarSchool] 地点剧情已播完且无选项，点了没内容，检查该地点的显示条件是否漏配";
				ValueTuple<string, object> valueTuple4 = new ValueTuple<string, object>("locationId", locationId);
				instance6.Warn(module5, author5, message5, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple4));
				return;
			}
		}

		// Token: 0x060381F1 RID: 229873 RVA: 0x00FAFB2C File Offset: 0x00FADD2C
		public unsafe void OnPlayerChooseOption(int locationId, int optionId)
		{
			if (!this.CanInteract())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 副本忙碌中或未激活，忽略选项 action";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("locationId", locationId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("optionId", optionId);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			SolarSchoolActionBase solarSchoolActionBase;
			if (!SolarSchoolGamePlayModel.Instance.TryGetOptionAction(locationId, optionId, out solarSchoolActionBase) || solarSchoolActionBase == null)
			{
				return;
			}
			this.PendingOptionLocation = locationId;
			base.RunThen(new List<SolarSchoolActionBase>
			{
				solarSchoolActionBase
			}, new Action(this.OnLocationActionFinished));
		}

		// Token: 0x060381F2 RID: 229874 RVA: 0x00FAFBDB File Offset: 0x00FADDDB
		private bool CanInteract()
		{
			return base.IsExecuting && !base.HandlerHasWork && this.Phase == SolarSchoolInstanceExploreTask.ESolarSchoolInstancePhase.Explore;
		}

		// Token: 0x060381F3 RID: 229875 RVA: 0x00FAFBF8 File Offset: 0x00FADDF8
		private bool RunLocationActions(int[] actionIds, int startIndex, int count, int settleLocation)
		{
			List<SolarSchoolActionBase> list = new List<SolarSchoolActionBase>();
			int num = startIndex;
			while (num < startIndex + count && num < actionIds.Length)
			{
				SolarSchoolActionBase solarSchoolActionBase = SolarSchoolGamePlayModel.Instance.CreateAction(actionIds[num]);
				if (solarSchoolActionBase == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.SolarSchool;
					ELogAuthor author = ELogAuthor.LRC;
					string message = "[SolarSchool] 副本地点 action 造失败";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("actionId", actionIds[num]);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				else
				{
					list.Add(solarSchoolActionBase);
				}
				num++;
			}
			if (list.Count == 0)
			{
				return false;
			}
			this.PendingSettleLocation = settleLocation;
			base.RunThen(list, new Action(this.OnLocationActionFinished));
			return true;
		}

		// Token: 0x060381F4 RID: 229876 RVA: 0x00FAFC90 File Offset: 0x00FADE90
		private void OnLocationActionFinished()
		{
			if (this.PendingOptionLocation != 0)
			{
				int pendingOptionLocation = this.PendingOptionLocation;
				this.PendingOptionLocation = 0;
				this.PendingSettleLocation = 0;
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 选项执行完，停留地点";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("locationId", pendingOptionLocation);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				SolarSchoolGamePlayModel.Instance.OpenLocationViewAsync(pendingOptionLocation).Forget();
				this.EvaluateProgress();
				return;
			}
			if (this.PendingSettleLocation == 0)
			{
				this.EvaluateProgress();
				return;
			}
			int pendingSettleLocation = this.PendingSettleLocation;
			this.PendingSettleLocation = 0;
			this.SettleLocation(pendingSettleLocation);
		}

		// Token: 0x060381F5 RID: 229877 RVA: 0x00FAFD24 File Offset: 0x00FADF24
		private unsafe void SettleLocation(int locationId)
		{
			SolarSchoolLocation? location = SolarSchoolConfig.Instance.GetLocation(locationId);
			int? num;
			if (location == null)
			{
				num = null;
			}
			else
			{
				int[] actionIdListArray = location.GetValueOrDefault().GetActionIdListArray();
				num = ((actionIdListArray != null) ? new int?(actionIdListArray.Length) : null);
			}
			int? num2 = num;
			int valueOrDefault = num2.GetValueOrDefault();
			int valueOrDefault2 = this.LocationAvgProgress.GetValueOrDefault(locationId, 0);
			if (valueOrDefault2 < valueOrDefault)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] AVG 段播完，返回地图等待续播";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("locationId", locationId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("played", valueOrDefault2);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("total", valueOrDefault);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			}
			else
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.SolarSchool;
				ELogAuthor author2 = ELogAuthor.LRC;
				string message2 = "[SolarSchool] 地点剧情全部播完";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("locationId", locationId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("total", valueOrDefault);
				instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				if ((location == null || !location.GetValueOrDefault().IsSeparate) && this.HasOptions(locationId))
				{
					Log instance3 = Log.Instance;
					ELogModule module3 = ELogModule.SolarSchool;
					ELogAuthor author3 = ELogAuthor.LRC;
					string message3 = "[SolarSchool] 地点不分段：剧情连播完直接进选项界面";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("locationId", locationId);
					instance3.Info(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					SolarSchoolGamePlayModel.Instance.OpenLocationViewAsync(locationId).Forget();
				}
			}
			this.EvaluateProgress();
		}

		// Token: 0x060381F6 RID: 229878 RVA: 0x00FAFEE8 File Offset: 0x00FAE0E8
		private void EvaluateProgress()
		{
			if (this.Phase == SolarSchoolInstanceExploreTask.ESolarSchoolInstancePhase.End)
			{
				return;
			}
			SolarSchoolGamePlayModel.Instance.RefreshMapView();
			if (!this.IsAllLocationCompleted())
			{
				return;
			}
			if (this.EndLocationId == 0)
			{
				Log.Instance.Info(ELogModule.SolarSchool, ELogAuthor.LRC, "[SolarSchool] 无结束地点：地点全部完成，自动结束", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.BeginEnd();
			}
		}

		// Token: 0x060381F7 RID: 229879 RVA: 0x00FAFF40 File Offset: 0x00FAE140
		private void AskEndConfirm()
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.SolarSchoolInstanceEndConfirm);
			confirmBoxDataNew.FunctionMap[2] = new Action(this.BeginEnd);
			if (ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew))
			{
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SolarSchool;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "[SolarSchool] 副本结束确认框弹出失败，检查 ConfirmBox 配表";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("configId", 577);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x060381F8 RID: 229880 RVA: 0x00FAFFB4 File Offset: 0x00FAE1B4
		private unsafe void BeginEnd()
		{
			if (this.Phase == SolarSchoolInstanceExploreTask.ESolarSchoolInstancePhase.End)
			{
				return;
			}
			this.Phase = SolarSchoolInstanceExploreTask.ESolarSchoolInstancePhase.End;
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			SolarSchoolInstance? instance2 = SolarSchoolConfig.Instance.GetInstance(instance.ActivityId, instance.InstanceId);
			List<SolarSchoolActionBase> list = new List<SolarSchoolActionBase>();
			this.AppendActions(list, (instance2 != null) ? instance2.GetValueOrDefault().GetEndActionIdListArray() : null);
			Log instance3 = Log.Instance;
			ELogModule module = ELogModule.SolarSchool;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "[SolarSchool] 副本结束流程开始";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("instanceId", instance.InstanceId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("endActionCount", list.Count);
			instance3.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			base.RunThen(list, new Action(this.DrainInstanceEndNodes));
		}

		// Token: 0x060381F9 RID: 229881 RVA: 0x00FB0098 File Offset: 0x00FAE298
		private unsafe void DrainInstanceEndNodes()
		{
			int instanceId = SolarSchoolGamePlayModel.Instance.InstanceId;
			int num;
			SolarSchoolActionBase solarSchoolActionBase;
			if (!SolarSchoolQuestCenter.Instance.TryTakePendingNode(ESolarSchoolTriggerTiming.AtInstanceEnd, instanceId, out num, out solarSchoolActionBase) || solarSchoolActionBase == null)
			{
				base.Complete(null);
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SolarSchool;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "[SolarSchool] 副本结束触发 QuestNode 剧情线";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("instanceId", instanceId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("nodeId", num);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			base.RunThen(new List<SolarSchoolActionBase>
			{
				solarSchoolActionBase
			}, new Action(this.DrainInstanceEndNodes));
		}

		// Token: 0x060381FA RID: 229882 RVA: 0x00FB014B File Offset: 0x00FAE34B
		private bool IsLocationOpen(int locationId)
		{
			return SolarSchoolGamePlayModel.Instance.MapData.IsLocationAvailable(locationId);
		}

		// Token: 0x060381FB RID: 229883 RVA: 0x00FB0160 File Offset: 0x00FAE360
		private bool IsAllLocationCompleted()
		{
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			foreach (SolarSchoolLocation insLoc in SolarSchoolConfig.Instance.GetLocationList(instance.ActivityId, instance.InstanceId))
			{
				if (!insLoc.IsEndLocation && this.IsLocationOpen(insLoc.Id) && !this.IsLocationCompleted(insLoc))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060381FC RID: 229884 RVA: 0x00FB01E4 File Offset: 0x00FAE3E4
		private bool IsLocationCompleted(SolarSchoolLocation insLoc)
		{
			int[] actionIdListArray = insLoc.GetActionIdListArray();
			int num = (actionIdListArray != null) ? actionIdListArray.Length : 0;
			int num2 = (insLoc.IsSeparate && num > 0) ? 1 : num;
			return this.LocationAvgProgress.GetValueOrDefault(insLoc.Id, 0) >= num2;
		}

		// Token: 0x060381FD RID: 229885 RVA: 0x00FB0230 File Offset: 0x00FAE430
		private bool HasOptions(int locationId)
		{
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			return SolarSchoolConfig.Instance.HasOptionRows(instance.ActivityId, instance.InstanceId, 1, locationId);
		}

		// Token: 0x0401D8F3 RID: 121075
		private readonly Dictionary<int, int> LocationAvgProgress = new Dictionary<int, int>();

		// Token: 0x0401D8F4 RID: 121076
		private int EndLocationId;

		// Token: 0x0401D8F5 RID: 121077
		private int PendingSettleLocation;

		// Token: 0x0401D8F6 RID: 121078
		private int PendingOptionLocation;

		// Token: 0x0401D8F7 RID: 121079
		private SolarSchoolInstanceExploreTask.ESolarSchoolInstancePhase Phase;

		// Token: 0x0200B4B5 RID: 46261
		[NullableContext(0)]
		private enum ESolarSchoolInstancePhase
		{
			// Token: 0x04037E07 RID: 228871
			Enter,
			// Token: 0x04037E08 RID: 228872
			WaitGoOut,
			// Token: 0x04037E09 RID: 228873
			Explore,
			// Token: 0x04037E0A RID: 228874
			End
		}
	}
}
