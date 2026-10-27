using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A81 RID: 10881
	[NullableContext(1)]
	[Nullable(0)]
	public class IFlowDefineNpcHandInHandPerform : IFlowDefineNpcGroupPerformType
	{
		// Token: 0x0600EF2B RID: 61227 RVA: 0x0022C901 File Offset: 0x0022AB01
		public static IFlowDefineNpcHandInHandPerform Create(IFlowDefineNpcHandInHandPerform? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlowDefineNpcHandInHandPerform
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004BEB RID: 19435
		// (get) Token: 0x0600EF2C RID: 61228 RVA: 0x0022C920 File Offset: 0x0022AB20
		public override ENpcGroupPerformType Type
		{
			get
			{
				return (ENpcGroupPerformType)this.Instance.Type;
			}
		}

		// Token: 0x17004BEC RID: 19436
		// (get) Token: 0x0600EF2D RID: 61229 RVA: 0x0022C92D File Offset: 0x0022AB2D
		public virtual string Key
		{
			get
			{
				return this.Instance.Key;
			}
		}

		// Token: 0x0400839D RID: 33693
		private IFlowDefineNpcHandInHandPerform Instance;
	}
}
