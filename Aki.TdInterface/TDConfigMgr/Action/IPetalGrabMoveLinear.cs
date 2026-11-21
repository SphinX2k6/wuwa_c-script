using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001EE7 RID: 7911
	public class IPetalGrabMoveLinear : IPetalGrabMoveType
	{
		// Token: 0x0600A869 RID: 43113 RVA: 0x0017EBA0 File Offset: 0x0017CDA0
		private IPetalGrabMoveLinear_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPetalGrabMoveLinear 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPetalGrabMoveLinear_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPetalGrabMoveLinear_SetValue());
			}
			return result;
		}

		// Token: 0x0600A86A RID: 43114 RVA: 0x0017EBD8 File Offset: 0x0017CDD8
		public static IPetalGrabMoveLinear Create([Nullable(2)] IPetalGrabMoveLinear instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPetalGrabMoveLinear
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A86B RID: 43115 RVA: 0x0017EBEB File Offset: 0x0017CDEB
		public static IPetalGrabMoveLinear CreateFromSetValue([Nullable(2)] IPetalGrabMoveLinear_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPetalGrabMoveLinear
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A86C RID: 43116 RVA: 0x0017EBFE File Offset: 0x0017CDFE
		public new IPetalGrabMoveLinear_SetValue ToSetValue()
		{
			return new IPetalGrabMoveLinear_SetValue
			{
				Type = this.Type,
				StartHalfWidth = this.StartHalfWidth,
				EndHalfWidth = this.EndHalfWidth
			};
		}

		// Token: 0x170033E8 RID: 13288
		// (get) Token: 0x0600A86D RID: 43117 RVA: 0x0017EC29 File Offset: 0x0017CE29
		// (set) Token: 0x0600A86E RID: 43118 RVA: 0x0017EC54 File Offset: 0x0017CE54
		public override EPetalGrabMoveType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPetalGrabMoveType.Linear;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170033E9 RID: 13289
		// (get) Token: 0x0600A86F RID: 43119 RVA: 0x0017EC62 File Offset: 0x0017CE62
		// (set) Token: 0x0600A870 RID: 43120 RVA: 0x0017EC8D File Offset: 0x0017CE8D
		public virtual int StartHalfWidth
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.StartHalfWidth;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.StartHalfWidth;
			}
			set
			{
				this.GetOrCreatePoco().StartHalfWidth = value;
			}
		}

		// Token: 0x170033EA RID: 13290
		// (get) Token: 0x0600A871 RID: 43121 RVA: 0x0017EC9B File Offset: 0x0017CE9B
		// (set) Token: 0x0600A872 RID: 43122 RVA: 0x0017ECC6 File Offset: 0x0017CEC6
		public virtual int EndHalfWidth
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EndHalfWidth;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EndHalfWidth;
			}
			set
			{
				this.GetOrCreatePoco().EndHalfWidth = value;
			}
		}

		// Token: 0x04006541 RID: 25921
		[Nullable(2)]
		protected new IPetalGrabMoveLinear FbInstance;

		// Token: 0x04006542 RID: 25922
		[Nullable(2)]
		protected new IPetalGrabMoveLinear_SetValue PocoInterface;
	}
}
