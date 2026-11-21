using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B5C RID: 2908
	public class IStateRepPerfMontagePath : IStateRepPerfBase
	{
		// Token: 0x06004267 RID: 16999 RVA: 0x000A8BBB File Offset: 0x000A6DBB
		public static IStateRepPerfMontagePath Create(IStateRepPerfMontagePath? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStateRepPerfMontagePath
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000FAA RID: 4010
		// (get) Token: 0x06004268 RID: 17000 RVA: 0x000A8BDA File Offset: 0x000A6DDA
		public override EStateRepPerfType Type
		{
			get
			{
				return (EStateRepPerfType)this.Instance.Type;
			}
		}

		// Token: 0x17000FAB RID: 4011
		// (get) Token: 0x06004269 RID: 17001 RVA: 0x000A8BE7 File Offset: 0x000A6DE7
		public virtual string MontagePath
		{
			get
			{
				return this.Instance.MontagePath;
			}
		}

		// Token: 0x17000FAC RID: 4012
		// (get) Token: 0x0600426A RID: 17002 RVA: 0x000A8BF4 File Offset: 0x000A6DF4
		public virtual string MontageName
		{
			get
			{
				return this.Instance.MontageName;
			}
		}

		// Token: 0x040024C7 RID: 9415
		private IStateRepPerfMontagePath Instance;
	}
}
