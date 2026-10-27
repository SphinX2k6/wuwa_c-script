using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.DirectTrain.MainActivity;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DirectTrain
{
	// Token: 0x02006742 RID: 26434
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class ActivityDirectTrainModel : ModelBase
	{
		// Token: 0x06041F9F RID: 270239 RVA: 0x01001047 File Offset: 0x00FFF247
		public bool HasInitData()
		{
			return this.HasInitDataInternal;
		}

		// Token: 0x06041FA0 RID: 270240 RVA: 0x01001050 File Offset: 0x00FFF250
		[NullableContext(2)]
		public void LoadDataFromInfoProto(DirectTrainInfoResponse proto)
		{
			this.HasInitDataInternal = true;
			this.ActivityDataMap.Clear();
			this.ActivityDataList.Clear();
			this.HasValidDirectTrainProData = false;
			if (proto == null)
			{
				return;
			}
			RepeatedField<ActivityData> activitys = proto.Activitys;
			if (activitys == null || activitys.Count <= 0)
			{
				return;
			}
			foreach (ActivityData data in activitys)
			{
				ActivityDirectTrainData activityDirectTrainData = ActivityController.Instance.CreateActivityData(data) as ActivityDirectTrainData;
				if (activityDirectTrainData != null)
				{
					activityDirectTrainData.Phrase(data);
					this.ActivityDataMap[activityDirectTrainData.Id] = activityDirectTrainData;
					this.ActivityDataList.Add(activityDirectTrainData);
				}
			}
			this.HasValidDirectTrainProData = (this.ActivityDataList.Count > 0);
			ActivityModel.SortActivityList<ActivityDirectTrainData>(this.ActivityDataList);
			if (this.ForceRemindIndex != null)
			{
				int? forceRemindIndex = this.ForceRemindIndex;
				int num = 0;
				if (!(forceRemindIndex.GetValueOrDefault() == num & forceRemindIndex != null))
				{
					goto IL_14B;
				}
			}
			for (int i = 0; i < this.ActivityDataList.Count; i++)
			{
				ActivityDirectTrainData activityDirectTrainData2 = this.ActivityDataList[i];
				DirectTrainActivity? directTrainActivityConfById = ActivityDirectTrainConfig.Instance.GetDirectTrainActivityConfById(activityDirectTrainData2.Id);
				if (directTrainActivityConfById != null && directTrainActivityConfById.Value.IsForceRemind)
				{
					this.ForceRemindIndex = new int?(i);
					break;
				}
			}
			IL_14B:
			EventSystem.Instance.Emit<int>(EEventName.ActivityDirectTrainRedDotUpdate, 0);
		}

		// Token: 0x06041FA1 RID: 270241 RVA: 0x010011CC File Offset: 0x00FFF3CC
		[NullableContext(2)]
		public void UpdateDataFromNotify(DirectTrainInfoUpdateNotify proto)
		{
			RepeatedField<ActivityData> repeatedField = (proto != null) ? proto.Activitys : null;
			if (repeatedField == null || repeatedField.Count <= 0)
			{
				return;
			}
			bool flag = false;
			foreach (ActivityData activityData in repeatedField)
			{
				int id = activityData.Id;
				ActivityDirectTrainData activityDirectTrainData;
				if (this.ActivityDataMap.TryGetValue(id, out activityDirectTrainData))
				{
					activityDirectTrainData.Phrase(activityData);
				}
				else
				{
					activityDirectTrainData = (ActivityController.Instance.CreateActivityData(activityData) as ActivityDirectTrainData);
					if (activityDirectTrainData == null)
					{
						continue;
					}
					activityDirectTrainData.Phrase(activityData);
					this.ActivityDataMap[activityDirectTrainData.Id] = activityDirectTrainData;
					this.ActivityDataList.Add(activityDirectTrainData);
					flag = true;
				}
				DirectTrainModel instance = DirectTrainModel.Instance;
				if (instance != null)
				{
					instance.RefreshProSubActivityCache(id);
				}
			}
			if (flag)
			{
				this.HasValidDirectTrainProData = (this.ActivityDataList.Count > 0);
				ActivityModel.SortActivityList<ActivityDirectTrainData>(this.ActivityDataList);
				this.ForceRemindIndex = null;
				for (int i = 0; i < this.ActivityDataList.Count; i++)
				{
					ActivityDirectTrainData activityDirectTrainData2 = this.ActivityDataList[i];
					DirectTrainActivity? directTrainActivityConfById = ActivityDirectTrainConfig.Instance.GetDirectTrainActivityConfById(activityDirectTrainData2.Id);
					if (directTrainActivityConfById != null && directTrainActivityConfById.Value.IsForceRemind)
					{
						this.ForceRemindIndex = new int?(i);
						break;
					}
				}
			}
			EventSystem.Instance.Emit<int>(EEventName.ActivityDirectTrainRedDotUpdate, 0);
		}

		// Token: 0x06041FA2 RID: 270242 RVA: 0x0100134C File Offset: 0x00FFF54C
		public void SetServerRemindActivityId(int actId)
		{
			this.ServerRemindActivityId = actId;
		}

		// Token: 0x06041FA3 RID: 270243 RVA: 0x01001358 File Offset: 0x00FFF558
		[NullableContext(2)]
		public ActivityDirectTrainData GetActivityById(int id)
		{
			ActivityDirectTrainData result;
			if (!this.ActivityDataMap.TryGetValue(id, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06041FA4 RID: 270244 RVA: 0x01001378 File Offset: 0x00FFF578
		public int GetDirectTrainServerRemindId()
		{
			return this.ServerRemindActivityId;
		}

		// Token: 0x06041FA5 RID: 270245 RVA: 0x01001380 File Offset: 0x00FFF580
		public int GetRecommendQuestId(int actId)
		{
			return ActivityDirectTrainConfig.Instance.GetDirectTrainActivityConfById(actId).Value.RecommendQuestId;
		}

		// Token: 0x06041FA6 RID: 270246 RVA: 0x010013A8 File Offset: 0x00FFF5A8
		public string GetRecommendQuestTipsTextId(int actId)
		{
			return ActivityDirectTrainConfig.Instance.GetDirectTrainActivityConfById(actId).Value.RecommendQuestLabel;
		}

		// Token: 0x06041FA7 RID: 270247 RVA: 0x010013D0 File Offset: 0x00FFF5D0
		public string GetSkipTipTitleTextId(int actId)
		{
			return ActivityDirectTrainConfig.Instance.GetDirectTrainActivityConfById(actId).Value.SkipTipTitle;
		}

		// Token: 0x06041FA8 RID: 270248 RVA: 0x010013F8 File Offset: 0x00FFF5F8
		public string GetSkipTipContentTextId(int actId)
		{
			return ActivityDirectTrainConfig.Instance.GetDirectTrainActivityConfById(actId).Value.SkipTipContent;
		}

		// Token: 0x06041FA9 RID: 270249 RVA: 0x01001420 File Offset: 0x00FFF620
		public string GetPrefabResource(int actId)
		{
			return ActivityDirectTrainConfig.Instance.GetDirectTrainActivityConfById(actId).Value.PrefabResource;
		}

		// Token: 0x06041FAA RID: 270250 RVA: 0x01001448 File Offset: 0x00FFF648
		public int GetSkipQuestId(int actId)
		{
			return ActivityDirectTrainConfig.Instance.GetDirectTrainActivityConfById(actId).Value.SkipQuestId;
		}

		// Token: 0x17009660 RID: 38496
		// (get) Token: 0x06041FAB RID: 270251 RVA: 0x01001470 File Offset: 0x00FFF670
		public static ActivityDirectTrainModel Instance
		{
			get
			{
				return ActivityDirectTrainModel._Instance;
			}
		}

		// Token: 0x06041FAC RID: 270252 RVA: 0x01001477 File Offset: 0x00FFF677
		public static ActivityDirectTrainModel GetOrCreateInstance()
		{
			if (ActivityDirectTrainModel._Instance == null)
			{
				ActivityDirectTrainModel.CreateInstance();
			}
			return ActivityDirectTrainModel._Instance;
		}

		// Token: 0x06041FAD RID: 270253 RVA: 0x0100148B File Offset: 0x00FFF68B
		public static bool CreateInstance()
		{
			if (ActivityDirectTrainModel._Instance != null)
			{
				return true;
			}
			ActivityDirectTrainModel._Instance = new ActivityDirectTrainModel();
			return true;
		}

		// Token: 0x06041FAE RID: 270254 RVA: 0x010014A1 File Offset: 0x00FFF6A1
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06041FAF RID: 270255 RVA: 0x010014A3 File Offset: 0x00FFF6A3
		public static void ResetStaticDefaultValue()
		{
			ActivityDirectTrainModel._Instance = null;
		}

		// Token: 0x06041FB0 RID: 270256 RVA: 0x010014AB File Offset: 0x00FFF6AB
		static ActivityDirectTrainModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityDirectTrainModel.CreateStaticDefaultValue), new Action(ActivityDirectTrainModel.ResetStaticDefaultValue));
		}

		// Token: 0x040225EC RID: 140780
		private int ServerRemindActivityId;

		// Token: 0x040225ED RID: 140781
		private readonly Dictionary<int, ActivityDirectTrainData> ActivityDataMap = new Dictionary<int, ActivityDirectTrainData>();

		// Token: 0x040225EE RID: 140782
		public readonly List<ActivityDirectTrainData> ActivityDataList = new List<ActivityDirectTrainData>();

		// Token: 0x040225EF RID: 140783
		public int? ForceRemindIndex;

		// Token: 0x040225F0 RID: 140784
		public bool HasValidDirectTrainProData;

		// Token: 0x040225F1 RID: 140785
		public bool AlreadyStartView;

		// Token: 0x040225F2 RID: 140786
		private bool HasInitDataInternal;

		// Token: 0x040225F3 RID: 140787
		[Nullable(2)]
		private static ActivityDirectTrainModel _Instance;
	}
}
