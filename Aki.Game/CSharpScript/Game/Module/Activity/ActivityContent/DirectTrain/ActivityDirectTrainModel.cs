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
	// Token: 0x02005692 RID: 22162
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class ActivityDirectTrainModel : ModelBase
	{
		// Token: 0x06036AEB RID: 223979 RVA: 0x00F423F7 File Offset: 0x00F405F7
		public bool HasInitData()
		{
			return this.HasInitDataInternal;
		}

		// Token: 0x06036AEC RID: 223980 RVA: 0x00F42400 File Offset: 0x00F40600
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

		// Token: 0x06036AED RID: 223981 RVA: 0x00F4257C File Offset: 0x00F4077C
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

		// Token: 0x06036AEE RID: 223982 RVA: 0x00F426FC File Offset: 0x00F408FC
		public void SetServerRemindActivityId(int actId)
		{
			this.ServerRemindActivityId = actId;
		}

		// Token: 0x06036AEF RID: 223983 RVA: 0x00F42708 File Offset: 0x00F40908
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

		// Token: 0x06036AF0 RID: 223984 RVA: 0x00F42728 File Offset: 0x00F40928
		public int GetDirectTrainServerRemindId()
		{
			return this.ServerRemindActivityId;
		}

		// Token: 0x06036AF1 RID: 223985 RVA: 0x00F42730 File Offset: 0x00F40930
		public int GetRecommendQuestId(int actId)
		{
			return ActivityDirectTrainConfig.Instance.GetDirectTrainActivityConfById(actId).Value.RecommendQuestId;
		}

		// Token: 0x06036AF2 RID: 223986 RVA: 0x00F42758 File Offset: 0x00F40958
		public string GetRecommendQuestTipsTextId(int actId)
		{
			return ActivityDirectTrainConfig.Instance.GetDirectTrainActivityConfById(actId).Value.RecommendQuestLabel;
		}

		// Token: 0x06036AF3 RID: 223987 RVA: 0x00F42780 File Offset: 0x00F40980
		public string GetSkipTipTitleTextId(int actId)
		{
			return ActivityDirectTrainConfig.Instance.GetDirectTrainActivityConfById(actId).Value.SkipTipTitle;
		}

		// Token: 0x06036AF4 RID: 223988 RVA: 0x00F427A8 File Offset: 0x00F409A8
		public string GetSkipTipContentTextId(int actId)
		{
			return ActivityDirectTrainConfig.Instance.GetDirectTrainActivityConfById(actId).Value.SkipTipContent;
		}

		// Token: 0x06036AF5 RID: 223989 RVA: 0x00F427D0 File Offset: 0x00F409D0
		public string GetPrefabResource(int actId)
		{
			return ActivityDirectTrainConfig.Instance.GetDirectTrainActivityConfById(actId).Value.PrefabResource;
		}

		// Token: 0x06036AF6 RID: 223990 RVA: 0x00F427F8 File Offset: 0x00F409F8
		public int GetSkipQuestId(int actId)
		{
			return ActivityDirectTrainConfig.Instance.GetDirectTrainActivityConfById(actId).Value.SkipQuestId;
		}

		// Token: 0x1700699F RID: 27039
		// (get) Token: 0x06036AF7 RID: 223991 RVA: 0x00F42820 File Offset: 0x00F40A20
		public static ActivityDirectTrainModel Instance
		{
			get
			{
				return ActivityDirectTrainModel._Instance;
			}
		}

		// Token: 0x06036AF8 RID: 223992 RVA: 0x00F42827 File Offset: 0x00F40A27
		public static ActivityDirectTrainModel GetOrCreateInstance()
		{
			if (ActivityDirectTrainModel._Instance == null)
			{
				ActivityDirectTrainModel.CreateInstance();
			}
			return ActivityDirectTrainModel._Instance;
		}

		// Token: 0x06036AF9 RID: 223993 RVA: 0x00F4283B File Offset: 0x00F40A3B
		public static bool CreateInstance()
		{
			if (ActivityDirectTrainModel._Instance != null)
			{
				return true;
			}
			ActivityDirectTrainModel._Instance = new ActivityDirectTrainModel();
			return true;
		}

		// Token: 0x06036AFA RID: 223994 RVA: 0x00F42851 File Offset: 0x00F40A51
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06036AFB RID: 223995 RVA: 0x00F42853 File Offset: 0x00F40A53
		public static void ResetStaticDefaultValue()
		{
			ActivityDirectTrainModel._Instance = null;
		}

		// Token: 0x06036AFC RID: 223996 RVA: 0x00F4285B File Offset: 0x00F40A5B
		static ActivityDirectTrainModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityDirectTrainModel.CreateStaticDefaultValue), new Action(ActivityDirectTrainModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401CE45 RID: 118341
		private int ServerRemindActivityId;

		// Token: 0x0401CE46 RID: 118342
		private readonly Dictionary<int, ActivityDirectTrainData> ActivityDataMap = new Dictionary<int, ActivityDirectTrainData>();

		// Token: 0x0401CE47 RID: 118343
		public readonly List<ActivityDirectTrainData> ActivityDataList = new List<ActivityDirectTrainData>();

		// Token: 0x0401CE48 RID: 118344
		public int? ForceRemindIndex;

		// Token: 0x0401CE49 RID: 118345
		public bool HasValidDirectTrainProData;

		// Token: 0x0401CE4A RID: 118346
		public bool AlreadyStartView;

		// Token: 0x0401CE4B RID: 118347
		private bool HasInitDataInternal;

		// Token: 0x0401CE4C RID: 118348
		[Nullable(2)]
		private static ActivityDirectTrainModel _Instance;
	}
}
