using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027F4 RID: 10228
	public class IMotorEnterSlide : ILeisureInteractType
	{
		// Token: 0x0600E324 RID: 58148 RVA: 0x00218099 File Offset: 0x00216299
		[NullableContext(1)]
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

		// Token: 0x170044FE RID: 17662
		// (get) Token: 0x0600E325 RID: 58149 RVA: 0x002180B8 File Offset: 0x002162B8
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x170044FF RID: 17663
		// (get) Token: 0x0600E326 RID: 58150 RVA: 0x002180C5 File Offset: 0x002162C5
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x17004500 RID: 17664
		// (get) Token: 0x0600E327 RID: 58151 RVA: 0x002180D4 File Offset: 0x002162D4
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

		// Token: 0x04007DD8 RID: 32216
		private IMotorEnterSlide Instance;
	}
}
