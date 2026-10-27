using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D78 RID: 3448
	public class IGravityFlipConfig
	{
		// Token: 0x06004E74 RID: 20084 RVA: 0x000C2A26 File Offset: 0x000C0C26
		[NullableContext(1)]
		public static IGravityFlipConfig Create(IGravityFlipConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGravityFlipConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001941 RID: 6465
		// (get) Token: 0x06004E75 RID: 20085 RVA: 0x000C2A45 File Offset: 0x000C0C45
		public virtual EGravityFlipType Type
		{
			get
			{
				return (EGravityFlipType)this.Instance.Type;
			}
		}

		// Token: 0x17001942 RID: 6466
		// (get) Token: 0x06004E76 RID: 20086 RVA: 0x000C2A52 File Offset: 0x000C0C52
		public virtual int LocationEntityId
		{
			get
			{
				return this.Instance.LocationEntityId;
			}
		}

		// Token: 0x04002D09 RID: 11529
		private IGravityFlipConfig Instance;
	}
}
