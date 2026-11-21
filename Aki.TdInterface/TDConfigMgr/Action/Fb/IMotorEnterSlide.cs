using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AC7 RID: 10951
	public class IMotorEnterSlide : ILeisureInteractType
	{
		// Token: 0x0600F149 RID: 61769 RVA: 0x00234EFC File Offset: 0x002330FC
		public static IMotorEnterSlide Create(IMotorEnterSlide? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMotorEnterSlide
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004869 RID: 18537
		// (get) Token: 0x0600F14A RID: 61770 RVA: 0x00234F1B File Offset: 0x0023311B
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x1700486A RID: 18538
		// (get) Token: 0x0600F14B RID: 61771 RVA: 0x00234F28 File Offset: 0x00233128
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x1700486B RID: 18539
		// (get) Token: 0x0600F14C RID: 61772 RVA: 0x00234F38 File Offset: 0x00233138
		public virtual EMotorEnterSlideMode? EnterMode
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new EMotorEnterSlideMode?((EMotorEnterSlideMode)this.Instance.EnterMode);
			}
		}

		// Token: 0x04008495 RID: 33941
		private IMotorEnterSlide Instance;
	}
}
