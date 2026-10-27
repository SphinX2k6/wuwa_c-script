using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020012E6 RID: 4838
	public class ILinkSystemConfig : IEnableSystemConfig
	{
		// Token: 0x06006E7E RID: 28286 RVA: 0x0010AFD9 File Offset: 0x001091D9
		[NullableContext(1)]
		public static ILinkSystemConfig Create(ILinkSystemConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILinkSystemConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002285 RID: 8837
		// (get) Token: 0x06006E7F RID: 28287 RVA: 0x0010AFF8 File Offset: 0x001091F8
		public override EEnableSystemType Type
		{
			get
			{
				return (EEnableSystemType)this.Instance.Type;
			}
		}

		// Token: 0x17002286 RID: 8838
		// (get) Token: 0x06006E80 RID: 28288 RVA: 0x0010B005 File Offset: 0x00109205
		public virtual int LinkDataId
		{
			get
			{
				return this.Instance.LinkDataId;
			}
		}

		// Token: 0x04003F50 RID: 16208
		private ILinkSystemConfig Instance;
	}
}
