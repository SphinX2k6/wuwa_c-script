using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B50 RID: 6992
	[NullableContext(1)]
	[Nullable(0)]
	public class IInteractOptionConfirmBox
	{
		// Token: 0x060095B7 RID: 38327 RVA: 0x0015A1D0 File Offset: 0x001583D0
		private IInteractOptionConfirmBox_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInteractOptionConfirmBox 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInteractOptionConfirmBox_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInteractOptionConfirmBox_SetValue());
			}
			return result;
		}

		// Token: 0x060095B8 RID: 38328 RVA: 0x0015A208 File Offset: 0x00158408
		public static IInteractOptionConfirmBox Create([Nullable(2)] IInteractOptionConfirmBox instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInteractOptionConfirmBox
			{
				FbInstance = instance
			};
		}

		// Token: 0x060095B9 RID: 38329 RVA: 0x0015A21B File Offset: 0x0015841B
		public static IInteractOptionConfirmBox CreateFromSetValue([Nullable(2)] IInteractOptionConfirmBox_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInteractOptionConfirmBox
			{
				PocoInterface = value
			};
		}

		// Token: 0x060095BA RID: 38330 RVA: 0x0015A22E File Offset: 0x0015842E
		public IInteractOptionConfirmBox_SetValue ToSetValue()
		{
			return new IInteractOptionConfirmBox_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002F3A RID: 12090
		// (get) Token: 0x060095BB RID: 38331 RVA: 0x0015A241 File Offset: 0x00158441
		// (set) Token: 0x060095BC RID: 38332 RVA: 0x0015A268 File Offset: 0x00158468
		public virtual IInteractionConfirmBoxType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				IInteractOptionConfirmBox_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005B9F RID: 23455
		[Nullable(2)]
		protected IInteractOptionConfirmBox FbInstance;

		// Token: 0x04005BA0 RID: 23456
		[Nullable(2)]
		protected IInteractOptionConfirmBox_SetValue PocoInterface;
	}
}
