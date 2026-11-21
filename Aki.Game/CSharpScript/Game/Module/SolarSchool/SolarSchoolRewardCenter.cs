using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x0200597E RID: 22910
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolRewardCenter : Singleton
	{
		// Token: 0x17006C16 RID: 27670
		// (get) Token: 0x0603877F RID: 231295 RVA: 0x00FCB13C File Offset: 0x00FC933C
		private static SolarSchoolGamePlayModel Model
		{
			get
			{
				return SolarSchoolGamePlayModel.Instance;
			}
		}

		// Token: 0x06038780 RID: 231296 RVA: 0x00FCB144 File Offset: 0x00FC9344
		public unsafe bool TryGiveReward(int rewardGroupId)
		{
			string item;
			if (this.TryGiveReward(rewardGroupId, out item))
			{
				return true;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SolarSchool;
			ELogAuthor author = ELogAuthor.SWC;
			string message = "[SolarSchool] 发奖失败";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("rewardGroupId", rewardGroupId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("error", item);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return false;
		}

		// Token: 0x06038781 RID: 231297 RVA: 0x00FCB1BA File Offset: 0x00FC93BA
		public bool TryGiveReward(int rewardGroupId, out string error)
		{
			return this.TryGiveReward(rewardGroupId, 0, out error);
		}

		// Token: 0x06038782 RID: 231298 RVA: 0x00FCB1C8 File Offset: 0x00FC93C8
		public bool TryGiveReward(int rewardGroupId, int valueBonus, out string error)
		{
			List<SolarSchoolReward> list;
			if (!this.TryGetGroupRewards(rewardGroupId, out list, out error))
			{
				return false;
			}
			List<SolarSchoolRewardValue> list2 = new List<SolarSchoolRewardValue>();
			foreach (SolarSchoolReward reward in list)
			{
				SolarSchoolRewardValue solarSchoolRewardValue = this.ToValue(reward);
				List<SolarSchoolRewardValue> list3 = list2;
				SolarSchoolRewardValue item = solarSchoolRewardValue;
				int value;
				switch (solarSchoolRewardValue.RewardType)
				{
				case ESolarSchoolRewardType.PlayerAttr:
					value = solarSchoolRewardValue.Value + valueBonus;
					break;
				case ESolarSchoolRewardType.RoleFavor:
					value = solarSchoolRewardValue.Value + valueBonus;
					break;
				case ESolarSchoolRewardType.Item:
					value = solarSchoolRewardValue.Value + valueBonus;
					break;
				case (ESolarSchoolRewardType)3:
					goto IL_90;
				case ESolarSchoolRewardType.Buff:
					value = solarSchoolRewardValue.Value;
					break;
				default:
					goto IL_90;
				}
				IL_99:
				item.Value = value;
				list3.Add(item);
				continue;
				IL_90:
				value = solarSchoolRewardValue.Value;
				goto IL_99;
			}
			return this.TryGiveReward(list2, out error);
		}

		// Token: 0x06038783 RID: 231299 RVA: 0x00FCB2B4 File Offset: 0x00FC94B4
		public bool TryGiveReward(IReadOnlyList<SolarSchoolReward> rewards, out string error)
		{
			return this.TryGiveReward(this.ToValueList(rewards), out error);
		}

		// Token: 0x06038784 RID: 231300 RVA: 0x00FCB2C4 File Offset: 0x00FC94C4
		private bool TryGiveReward(IReadOnlyList<SolarSchoolRewardValue> rewards, out string error)
		{
			if (!this.CanGiveReward(rewards, out error))
			{
				return false;
			}
			foreach (SolarSchoolRewardValue reward in rewards)
			{
				if (!this.Apply(reward))
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(7, 1);
					defaultInterpolatedStringHandler.AppendLiteral("奖励应用失败：");
					defaultInterpolatedStringHandler.AppendFormatted<int>(reward.Id);
					error = defaultInterpolatedStringHandler.ToStringAndClear();
					return false;
				}
			}
			return true;
		}

		// Token: 0x06038785 RID: 231301 RVA: 0x00FCB34C File Offset: 0x00FC954C
		public bool TryGiveWeeklyReward(int rewardGroupId, out string error)
		{
			List<SolarSchoolReward> rewards;
			if (!this.TryGetGroupRewards(rewardGroupId, out rewards, out error))
			{
				return false;
			}
			List<SolarSchoolRewardValue> list = this.ToValueList(rewards);
			foreach (SolarSchoolRewardValue solarSchoolRewardValue in list)
			{
				if (solarSchoolRewardValue.RewardType != ESolarSchoolRewardType.PlayerAttr)
				{
					error = "周奖励组只允许 PlayerAttr";
					return false;
				}
			}
			return this.TryGiveReward(list, out error);
		}

		// Token: 0x06038786 RID: 231302 RVA: 0x00FCB3CC File Offset: 0x00FC95CC
		public bool CanGiveReward(int rewardGroupId, out string error)
		{
			List<SolarSchoolReward> rewards;
			return this.TryGetGroupRewards(rewardGroupId, out rewards, out error) && this.CanGiveReward(rewards, out error);
		}

		// Token: 0x06038787 RID: 231303 RVA: 0x00FCB3EF File Offset: 0x00FC95EF
		public bool CanGiveReward(IReadOnlyList<SolarSchoolReward> rewards, out string error)
		{
			if (rewards == null)
			{
				return this.CanGiveReward(Array.Empty<SolarSchoolRewardValue>(), out error);
			}
			return this.CanGiveReward(this.ToValueList(rewards), out error);
		}

		// Token: 0x06038788 RID: 231304 RVA: 0x00FCB410 File Offset: 0x00FC9610
		private bool CanGiveReward(IReadOnlyList<SolarSchoolRewardValue> rewards, out string error)
		{
			if (!SolarSchoolRewardCenter.Model.IsInGamePlay)
			{
				error = "当前不在第二索拉学院局内";
				return false;
			}
			if (rewards == null || rewards.Count == 0)
			{
				error = "奖励明细为空";
				return false;
			}
			foreach (SolarSchoolRewardValue reward in rewards)
			{
				if (!this.IsValid(reward))
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 1);
					defaultInterpolatedStringHandler.AppendLiteral("奖励明细校验失败：");
					defaultInterpolatedStringHandler.AppendFormatted<int>(reward.Id);
					error = defaultInterpolatedStringHandler.ToStringAndClear();
					return false;
				}
			}
			error = "";
			return true;
		}

		// Token: 0x06038789 RID: 231305 RVA: 0x00FCB4C0 File Offset: 0x00FC96C0
		public List<SolarSchoolReward> GetRewardPreview(int rewardGroupId)
		{
			List<SolarSchoolReward> result;
			string text;
			this.TryGetGroupRewards(rewardGroupId, out result, out text);
			return result;
		}

		// Token: 0x0603878A RID: 231306 RVA: 0x00FCB4DC File Offset: 0x00FC96DC
		public bool TryGetPermanentBuffRewardIds(int rewardGroupId, out List<int> buffIds, out string error)
		{
			buffIds = new List<int>();
			List<SolarSchoolReward> list;
			if (!this.TryGetGroupRewards(rewardGroupId, out list, out error) || !this.CanGiveReward(list, out error))
			{
				return false;
			}
			HashSet<int> hashSet = new HashSet<int>();
			foreach (SolarSchoolReward solarSchoolReward in list)
			{
				if (solarSchoolReward.RewardType == 4)
				{
					SolarSchoolBuff? buff = SolarSchoolConfig.Instance.GetBuff(solarSchoolReward.TargetId);
					if (buff != null && buff.Value.DurationDays == -1)
					{
						hashSet.Add(solarSchoolReward.TargetId);
					}
				}
			}
			buffIds.AddRange(hashSet);
			buffIds.Sort();
			error = string.Empty;
			return true;
		}

		// Token: 0x0603878B RID: 231307 RVA: 0x00FCB5A8 File Offset: 0x00FC97A8
		private bool TryGetGroupRewards(int rewardGroupId, out List<SolarSchoolReward> rewards, out string error)
		{
			rewards = new List<SolarSchoolReward>();
			if (rewardGroupId <= 0)
			{
				error = "奖励组 Id 必须大于 0";
				return false;
			}
			SolarSchoolRewards? rewards2 = SolarSchoolConfig.Instance.GetRewards(rewardGroupId);
			if (rewards2 == null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 1);
				defaultInterpolatedStringHandler.AppendLiteral("未找到奖励组配置：");
				defaultInterpolatedStringHandler.AppendFormatted<int>(rewardGroupId);
				error = defaultInterpolatedStringHandler.ToStringAndClear();
				return false;
			}
			int[] rewardIdsArray = rewards2.Value.GetRewardIdsArray();
			if (rewardIdsArray == null || rewardIdsArray.Length == 0)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(11, 1);
				defaultInterpolatedStringHandler.AppendLiteral("奖励组未配置奖励明细：");
				defaultInterpolatedStringHandler.AppendFormatted<int>(rewardGroupId);
				error = defaultInterpolatedStringHandler.ToStringAndClear();
				return false;
			}
			foreach (int num in rewardIdsArray)
			{
				SolarSchoolReward? reward = SolarSchoolConfig.Instance.GetReward(num);
				if (reward == null)
				{
					rewards.Clear();
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 1);
					defaultInterpolatedStringHandler.AppendLiteral("奖励组引用了不存在的奖励明细：");
					defaultInterpolatedStringHandler.AppendFormatted<int>(num);
					error = defaultInterpolatedStringHandler.ToStringAndClear();
					return false;
				}
				rewards.Add(reward.Value);
			}
			error = "";
			return true;
		}

		// Token: 0x0603878C RID: 231308 RVA: 0x00FCB6C4 File Offset: 0x00FC98C4
		private List<SolarSchoolRewardValue> ToValueList(IReadOnlyList<SolarSchoolReward> rewards)
		{
			List<SolarSchoolRewardValue> list = new List<SolarSchoolRewardValue>();
			foreach (SolarSchoolReward reward in rewards)
			{
				list.Add(this.ToValue(reward));
			}
			return list;
		}

		// Token: 0x0603878D RID: 231309 RVA: 0x00FCB71C File Offset: 0x00FC991C
		private SolarSchoolRewardValue ToValue(SolarSchoolReward reward)
		{
			return new SolarSchoolRewardValue(reward.Id, (ESolarSchoolRewardType)reward.RewardType, reward.TargetId, reward.Value);
		}

		// Token: 0x0603878E RID: 231310 RVA: 0x00FCB740 File Offset: 0x00FC9940
		private bool IsValid(SolarSchoolRewardValue reward)
		{
			if (reward.TargetId <= 0)
			{
				return false;
			}
			switch (reward.RewardType)
			{
			case ESolarSchoolRewardType.PlayerAttr:
			{
				ESolarSchoolSecondAttr esolarSchoolSecondAttr;
				return this.TryGetAttr(reward.TargetId, out esolarSchoolSecondAttr);
			}
			case ESolarSchoolRewardType.RoleFavor:
				return this.IsRoleValid(reward.TargetId);
			case ESolarSchoolRewardType.Item:
				return reward.Value > 0 && this.IsItemValid(reward.TargetId);
			case ESolarSchoolRewardType.Buff:
				return this.IsBuffRewardValid(reward);
			}
			return false;
		}

		// Token: 0x0603878F RID: 231311 RVA: 0x00FCB7CC File Offset: 0x00FC99CC
		private bool TryGetAttr(int attrConfigId, out ESolarSchoolSecondAttr attr)
		{
			attr = ESolarSchoolSecondAttr.None;
			SolarSchoolAttr? attr2 = SolarSchoolConfig.Instance.GetAttr(attrConfigId);
			if (attr2 == null || attr2.Value.ActivityId != SolarSchoolRewardCenter.Model.ActivityId)
			{
				return false;
			}
			attr = (ESolarSchoolSecondAttr)attr2.Value.AttrType;
			return attr != ESolarSchoolSecondAttr.None && Enum.IsDefined<ESolarSchoolSecondAttr>(attr);
		}

		// Token: 0x06038790 RID: 231312 RVA: 0x00FCB82C File Offset: 0x00FC9A2C
		private bool IsRoleValid(int roleId)
		{
			SolarSchoolRole? role = SolarSchoolConfig.Instance.GetRole(roleId);
			return role != null && role.Value.ActivityId == SolarSchoolRewardCenter.Model.ActivityId && SolarSchoolRewardCenter.Model.FriendData.IsRoleUnlocked(roleId);
		}

		// Token: 0x06038791 RID: 231313 RVA: 0x00FCB87C File Offset: 0x00FC9A7C
		private bool IsItemValid(int itemId)
		{
			SolarSchoolItem? item = SolarSchoolConfig.Instance.GetItem(itemId);
			return item != null && item.Value.ActivityId == SolarSchoolRewardCenter.Model.ActivityId && item.Value.StackLimit > 0;
		}

		// Token: 0x06038792 RID: 231314 RVA: 0x00FCB8D0 File Offset: 0x00FC9AD0
		private bool IsBuffRewardValid(SolarSchoolRewardValue reward)
		{
			string text;
			return SolarSchoolRewardCenter.Model.CanAddBuff(reward.TargetId, out text);
		}

		// Token: 0x06038793 RID: 231315 RVA: 0x00FCB8F0 File Offset: 0x00FC9AF0
		private bool Apply(SolarSchoolRewardValue reward)
		{
			switch (reward.RewardType)
			{
			case ESolarSchoolRewardType.PlayerAttr:
				return this.ApplyPlayerAttr(reward);
			case ESolarSchoolRewardType.RoleFavor:
				if (!this.IsRoleValid(reward.TargetId))
				{
					return false;
				}
				SolarSchoolRewardCenter.Model.AddFavor(reward.TargetId, reward.Value);
				return true;
			case ESolarSchoolRewardType.Item:
				if (reward.Value <= 0 || !this.IsItemValid(reward.TargetId))
				{
					return false;
				}
				SolarSchoolRewardCenter.Model.AddItem(reward.TargetId, reward.Value);
				return true;
			case ESolarSchoolRewardType.Buff:
				return SolarSchoolRewardCenter.Model.AddBuff(reward.TargetId);
			}
			return false;
		}

		// Token: 0x06038794 RID: 231316 RVA: 0x00FCB9A0 File Offset: 0x00FC9BA0
		private bool ApplyPlayerAttr(SolarSchoolRewardValue reward)
		{
			ESolarSchoolSecondAttr attr;
			if (!this.TryGetAttr(reward.TargetId, out attr))
			{
				return false;
			}
			SolarSchoolRewardCenter.Model.PlayerData.SetAttr(attr, SolarSchoolRewardCenter.Model.PlayerData.GetBaseAttr(attr) + reward.Value);
			return true;
		}

		// Token: 0x17006C17 RID: 27671
		// (get) Token: 0x06038795 RID: 231317 RVA: 0x00FCB9E9 File Offset: 0x00FC9BE9
		public static SolarSchoolRewardCenter Instance
		{
			get
			{
				if (SolarSchoolRewardCenter._instance == null)
				{
					SolarSchoolRewardCenter._instance = new SolarSchoolRewardCenter();
					SolarSchoolRewardCenter._instance.OnInit();
				}
				return SolarSchoolRewardCenter._instance;
			}
		}

		// Token: 0x06038796 RID: 231318 RVA: 0x00FCBA0C File Offset: 0x00FC9C0C
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06038797 RID: 231319 RVA: 0x00FCBA0E File Offset: 0x00FC9C0E
		public static void ResetStaticDefaultValue()
		{
			SolarSchoolRewardCenter instance = SolarSchoolRewardCenter._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			SolarSchoolRewardCenter._instance = null;
		}

		// Token: 0x06038798 RID: 231320 RVA: 0x00FCBA27 File Offset: 0x00FC9C27
		static SolarSchoolRewardCenter()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SolarSchoolRewardCenter.CreateStaticDefaultValue), new Action(SolarSchoolRewardCenter.ResetStaticDefaultValue));
		}

		// Token: 0x0401DC3E RID: 121918
		[Nullable(2)]
		private static SolarSchoolRewardCenter _instance;
	}
}
