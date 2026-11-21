using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005EF7 RID: 24311
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelConditionGroupRegData
	{
		// Token: 0x0603A8FF RID: 239871 RVA: 0x0108D7F4 File Offset: 0x0108B9F4
		public LevelConditionGroupRegData(int conditionGroupId)
		{
			this.ConditionGroupId = conditionGroupId;
			ConditionGroup? config = ConfigConditionGroupById.GetConfig(this.ConditionGroupId, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.LevelConditionRegistry;
				ELogAuthor author = ELogAuthor.TL;
				string message = "初始化事件条件组时, 找不到条件组配置";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("条件组Id", this.ConditionGroupId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.ConditionRelation = (config.Value.Relation == 1);
			for (int i = 0; i < config.Value.GroupIdLength; i++)
			{
				Condition? config2 = ConfigConditionById.GetConfig(config.Value.GroupId(i), true);
				if (config2 != null)
				{
					List<EEventName> conditionEventNames = LevelConditionCenter.Instance.GetConditionEventNames(config2.Value.Type);
					if (conditionEventNames.Count != 0)
					{
						this.ConditionRegDataSet.Add(new LevelConditionRegData(this, config2.Value, conditionEventNames));
					}
				}
			}
		}

		// Token: 0x0603A900 RID: 239872 RVA: 0x0108D8FF File Offset: 0x0108BAFF
		public bool IsValid()
		{
			return this.ConditionRegDataSet.Count > 0;
		}

		// Token: 0x0603A901 RID: 239873 RVA: 0x0108D910 File Offset: 0x0108BB10
		private void InvokeCallbacks()
		{
			foreach (ConditionPassCallback conditionPassCallback in this.ConditionPassCallbackSet)
			{
				TConditionPassCallback callback = conditionPassCallback.Callback;
				if (callback != null)
				{
					callback(conditionPassCallback.Params);
				}
			}
		}

		// Token: 0x0603A902 RID: 239874 RVA: 0x0108D974 File Offset: 0x0108BB74
		public void CheckReached()
		{
			if (this.ConditionRelation)
			{
				using (HashSet<LevelConditionRegData>.Enumerator enumerator = this.ConditionRegDataSet.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (enumerator.Current.ConditionReached)
						{
							this.InvokeCallbacks();
							break;
						}
					}
					return;
				}
			}
			using (HashSet<LevelConditionRegData>.Enumerator enumerator = this.ConditionRegDataSet.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (!enumerator.Current.ConditionReached)
					{
						return;
					}
				}
			}
			this.InvokeCallbacks();
		}

		// Token: 0x0603A903 RID: 239875 RVA: 0x0108DA20 File Offset: 0x0108BC20
		public void AddCallBack(ConditionPassCallback conditionPassCallback)
		{
			this.ConditionPassCallbackSet.Add(conditionPassCallback);
		}

		// Token: 0x0603A904 RID: 239876 RVA: 0x0108DA30 File Offset: 0x0108BC30
		public bool RemoveCallBack(ConditionPassCallback conditionPassCallback)
		{
			if (!this.ConditionPassCallbackSet.Remove(conditionPassCallback))
			{
				return false;
			}
			if (this.ConditionPassCallbackSet.Count > 0)
			{
				return false;
			}
			foreach (LevelConditionRegData levelConditionRegData in this.ConditionRegDataSet)
			{
				levelConditionRegData.Destroy();
			}
			this.ConditionRegDataSet.Clear();
			return true;
		}

		// Token: 0x0401EC86 RID: 126086
		public readonly int ConditionGroupId;

		// Token: 0x0401EC87 RID: 126087
		private readonly bool ConditionRelation;

		// Token: 0x0401EC88 RID: 126088
		private readonly HashSet<LevelConditionRegData> ConditionRegDataSet = new HashSet<LevelConditionRegData>();

		// Token: 0x0401EC89 RID: 126089
		private readonly HashSet<ConditionPassCallback> ConditionPassCallbackSet = new HashSet<ConditionPassCallback>();
	}
}
