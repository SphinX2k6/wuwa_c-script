using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002968 RID: 10600
	public class SetRegionConfig : ActionParams
	{
		// Token: 0x0600EAF2 RID: 60146 RVA: 0x002263A1 File Offset: 0x002245A1
		[NullableContext(1)]
		public static SetRegionConfig Create(ISetRegionConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetRegionConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170049E4 RID: 18916
		// (get) Token: 0x0600EAF3 RID: 60147 RVA: 0x002263C0 File Offset: 0x002245C0
		public virtual ERegionConfigType Type
		{
			get
			{
				return (ERegionConfigType)this.Instance.Type;
			}
		}

		// Token: 0x04008172 RID: 33138
		private ISetRegionConfig Instance;
	}
}
