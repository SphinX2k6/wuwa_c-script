using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200048B RID: 1163
	[NullableContext(1)]
	[Nullable(0)]
	public class IInteractScreenDetectShapeBase
	{
		// Token: 0x06001764 RID: 5988 RVA: 0x00046ED8 File Offset: 0x000450D8
		private IInteractScreenDetectShapeBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInteractScreenDetectShapeBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInteractScreenDetectShapeBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInteractScreenDetectShapeBase_SetValue());
			}
			return result;
		}

		// Token: 0x06001765 RID: 5989 RVA: 0x00046F10 File Offset: 0x00045110
		public static IInteractScreenDetectShapeBase Create([Nullable(2)] IInteractScreenDetectShapeBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInteractScreenDetectShapeBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001766 RID: 5990 RVA: 0x00046F23 File Offset: 0x00045123
		public static IInteractScreenDetectShapeBase CreateFromSetValue([Nullable(2)] IInteractScreenDetectShapeBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInteractScreenDetectShapeBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001767 RID: 5991 RVA: 0x00046F36 File Offset: 0x00045136
		public IInteractScreenDetectShapeBase_SetValue ToSetValue()
		{
			return new IInteractScreenDetectShapeBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x06001768 RID: 5992 RVA: 0x00046F49 File Offset: 0x00045149
		// (set) Token: 0x06001769 RID: 5993 RVA: 0x00046F74 File Offset: 0x00045174
		public virtual EInteractScreenDetectShape Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EInteractScreenDetectShape.Circle;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400118B RID: 4491
		[Nullable(2)]
		protected IInteractScreenDetectShapeBase FbInstance;

		// Token: 0x0400118C RID: 4492
		[Nullable(2)]
		protected IInteractScreenDetectShapeBase_SetValue PocoInterface;
	}
}
