using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D78 RID: 28024
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelConditionGroupRegData
	{
		// Token: 0x0604479B RID: 280475 RVA: 0x010E3610 File Offset: 0x010E1810
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

		// Token: 0x0604479C RID: 280476 RVA: 0x010E371B File Offset: 0x010E191B
		public bool IsValid()
		{
			return this.ConditionRegDataSet.Count > 0;
		}

		// Token: 0x0604479D RID: 280477 RVA: 0x010E372C File Offset: 0x010E192C
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

		// Token: 0x0604479E RID: 280478 RVA: 0x010E3790 File Offset: 0x010E1990
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

		// Token: 0x0604479F RID: 280479 RVA: 0x010E383C File Offset: 0x010E1A3C
		public void AddCallBack(ConditionPassCallback conditionPassCallback)
		{
			this.ConditionPassCallbackSet.Add(conditionPassCallback);
		}

		// Token: 0x060447A0 RID: 280480 RVA: 0x010E384C File Offset: 0x010E1A4C
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

		// Token: 0x040239E4 RID: 145892
		public readonly int ConditionGroupId;

		// Token: 0x040239E5 RID: 145893
		private readonly bool ConditionRelation;

		// Token: 0x040239E6 RID: 145894
		private readonly HashSet<LevelConditionRegData> ConditionRegDataSet = new HashSet<LevelConditionRegData>();

		// Token: 0x040239E7 RID: 145895
		private readonly HashSet<ConditionPassCallback> ConditionPassCallbackSet = new HashSet<ConditionPassCallback>();
	}
}
