using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A80 RID: 10880
	public class IFlowDefineNpcGroupPerformType
	{
		// Token: 0x0600EF28 RID: 61224 RVA: 0x0022C8CD File Offset: 0x0022AACD
		[NullableContext(1)]
		public static IFlowDefineNpcGroupPerformType Create(IFlowDefineNpcGroupPerformType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlowDefineNpcGroupPerformType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004BEA RID: 19434
		// (get) Token: 0x0600EF29 RID: 61225 RVA: 0x0022C8EC File Offset: 0x0022AAEC
		public virtual ENpcGroupPerformType Type
		{
			get
			{
				return (ENpcGroupPerformType)this.Instance.Type;
			}
		}

		// Token: 0x0400839C RID: 33692
		private IFlowDefineNpcGroupPerformType Instance;
	}
}
