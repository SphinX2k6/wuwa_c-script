using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ActivityCondition
{
	// Token: 0x02005A83 RID: 23171
	[NullableContext(1)]
	[Nullable(0)]
	internal sealed class ActivityConditionGroup : ActivityConditionBase
	{
		// Token: 0x17006CC9 RID: 27849
		// (get) Token: 0x060391D7 RID: 233943 RVA: 0x00FFF7A8 File Offset: 0x00FFD9A8
		protected override bool CanListenInternal
		{
			get
			{
				if (this.Children.Count == 0)
				{
					return false;
				}
				using (List<ActivityConditionBase>.Enumerator enumerator = this.Children.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (!enumerator.Current.CanListen)
						{
							return false;
						}
					}
				}
				return true;
			}
		}

		// Token: 0x060391D8 RID: 233944 RVA: 0x00FFF810 File Offset: 0x00FFDA10
		internal bool Initialize(int groupId, EActivityConditionLogic logic, List<ActivityConditionBase> children)
		{
			return base.InitializeCore(groupId, () => this.InitializeChildren(groupId, logic, children));
		}

		// Token: 0x060391D9 RID: 233945 RVA: 0x00FFF858 File Offset: 0x00FFDA58
		protected override bool OnCheck()
		{
			if (this.Children.Count == 0)
			{
				return false;
			}
			foreach (ActivityConditionBase child in this.Children)
			{
				ActivityConditionGroup.ThrowIfChildInvalid(child);
			}
			if (this.Logic == EActivityConditionLogic.Or)
			{
				foreach (ActivityConditionBase activityConditionBase in this.Children)
				{
					bool flag = ActivityConditionCenter.Instance.Check(activityConditionBase);
					ActivityConditionGroup.ThrowIfChildInvalid(activityConditionBase);
					if (flag)
					{
						return true;
					}
				}
				return false;
			}
			foreach (ActivityConditionBase activityConditionBase2 in this.Children)
			{
				bool flag2 = ActivityConditionCenter.Instance.Check(activityConditionBase2);
				ActivityConditionGroup.ThrowIfChildInvalid(activityConditionBase2);
				if (!flag2)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060391DA RID: 233946 RVA: 0x00FFF96C File Offset: 0x00FFDB6C
		protected override void OnClear()
		{
			for (int i = this.Children.Count - 1; i >= 0; i--)
			{
				ActivityConditionCenter.Instance.Release(this.Children[i]);
			}
			this.Children.Clear();
			this.Logic = EActivityConditionLogic.And;
		}

		// Token: 0x060391DB RID: 233947 RVA: 0x00FFF9BC File Offset: 0x00FFDBBC
		private unsafe bool InitializeChildren(int groupId, EActivityConditionLogic logic, List<ActivityConditionBase> children)
		{
			this.Children = children;
			if (this.Children.Count == 0)
			{
				return false;
			}
			if (logic != EActivityConditionLogic.And && logic != EActivityConditionLogic.Or)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.ActivityCondition;
				ELogAuthor author = ELogAuthor.BB;
				string message = "[ActivityCondition] 条件组逻辑类型非法";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("groupId", groupId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("logic", logic);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return false;
			}
			this.Logic = logic;
			Action finishCallback = new Action(base.Recheck);
			using (List<ActivityConditionBase>.Enumerator enumerator = this.Children.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (!enumerator.Current.SetFinishCallback(finishCallback))
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x060391DC RID: 233948 RVA: 0x00FFFAA8 File Offset: 0x00FFDCA8
		private static void ThrowIfChildInvalid(ActivityConditionBase child)
		{
			if (child.State != EActivityConditionState.Active)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(53, 2);
				defaultInterpolatedStringHandler.AppendLiteral("ActivityConditionGroup 子条件状态异常，ChildUniqueId:");
				defaultInterpolatedStringHandler.AppendFormatted<long>(child.UniqueId);
				defaultInterpolatedStringHandler.AppendLiteral(", State:");
				defaultInterpolatedStringHandler.AppendFormatted<EActivityConditionState>(child.State);
				throw new InvalidOperationException(defaultInterpolatedStringHandler.ToStringAndClear());
			}
		}

		// Token: 0x0401E0E8 RID: 123112
		private List<ActivityConditionBase> Children = new List<ActivityConditionBase>();

		// Token: 0x0401E0E9 RID: 123113
		private EActivityConditionLogic Logic;
	}
}
