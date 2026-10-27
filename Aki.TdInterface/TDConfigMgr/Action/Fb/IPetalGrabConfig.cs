using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028F4 RID: 10484
	public class IPetalGrabConfig : ISportConfig
	{
		// Token: 0x0600E8E2 RID: 59618 RVA: 0x00222A66 File Offset: 0x00220C66
		[NullableContext(1)]
		public static IPetalGrabConfig Create(IPetalGrabConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPetalGrabConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170048BC RID: 18620
		// (get) Token: 0x0600E8E3 RID: 59619 RVA: 0x00222A85 File Offset: 0x00220C85
		public override ESportStateType Type
		{
			get
			{
				return (ESportStateType)this.Instance.Type;
			}
		}

		// Token: 0x170048BD RID: 18621
		// (get) Token: 0x0600E8E4 RID: 59620 RVA: 0x00222A92 File Offset: 0x00220C92
		public virtual int FirstGrabEntityId
		{
			get
			{
				return this.Instance.FirstGrabEntityId;
			}
		}

		// Token: 0x04008090 RID: 32912
		private IPetalGrabConfig Instance;
	}
}
