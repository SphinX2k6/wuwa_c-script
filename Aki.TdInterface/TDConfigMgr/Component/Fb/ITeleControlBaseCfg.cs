using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B34 RID: 2868
	[NullableContext(1)]
	[Nullable(0)]
	public class ITeleControlBaseCfg
	{
		// Token: 0x06004237 RID: 16951 RVA: 0x000A9989 File Offset: 0x000A7B89
		public static ITeleControlBaseCfg Create(ITeleControlBaseCfg? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITeleControlBaseCfg
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700118C RID: 4492
		// (get) Token: 0x06004238 RID: 16952 RVA: 0x000A99A8 File Offset: 0x000A7BA8
		public virtual string CommonConfig
		{
			get
			{
				return this.Instance.CommonConfig;
			}
		}

		// Token: 0x1700118D RID: 4493
		// (get) Token: 0x06004239 RID: 16953 RVA: 0x000A99B8 File Offset: 0x000A7BB8
		public virtual bool? CanRotate
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.CanRotate);
			}
		}

		// Token: 0x1700118E RID: 4494
		// (get) Token: 0x0600423A RID: 16954 RVA: 0x000A99F0 File Offset: 0x000A7BF0
		public virtual bool? InitialGravity
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.InitialGravity);
			}
		}

		// Token: 0x04002557 RID: 9559
		private ITeleControlBaseCfg Instance;
	}
}
