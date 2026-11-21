using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BCC RID: 11212
	public class IPetalGrabConfig : ISportConfig
	{
		// Token: 0x0600F723 RID: 63267 RVA: 0x0023FC1E File Offset: 0x0023DE1E
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

		// Token: 0x17004C39 RID: 19513
		// (get) Token: 0x0600F724 RID: 63268 RVA: 0x0023FC3D File Offset: 0x0023DE3D
		public override ESportStateType Type
		{
			get
			{
				return (ESportStateType)this.Instance.Type;
			}
		}

		// Token: 0x17004C3A RID: 19514
		// (get) Token: 0x0600F725 RID: 63269 RVA: 0x0023FC4A File Offset: 0x0023DE4A
		public virtual int FirstGrabEntityId
		{
			get
			{
				return this.Instance.FirstGrabEntityId;
			}
		}

		// Token: 0x04008754 RID: 34644
		private IPetalGrabConfig Instance;
	}
}
