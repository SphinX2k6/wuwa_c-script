using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200193C RID: 6460
	[NullableContext(1)]
	[Nullable(0)]
	public class IControlTrackingSelf : IControlTrackingType
	{
		// Token: 0x06008A7F RID: 35455 RVA: 0x0014639C File Offset: 0x0014459C
		private IControlTrackingSelf_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IControlTrackingSelf 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IControlTrackingSelf_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IControlTrackingSelf_SetValue());
			}
			return result;
		}

		// Token: 0x06008A80 RID: 35456 RVA: 0x001463D4 File Offset: 0x001445D4
		public static IControlTrackingSelf Create([Nullable(2)] IControlTrackingSelf instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IControlTrackingSelf
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008A81 RID: 35457 RVA: 0x001463E7 File Offset: 0x001445E7
		public static IControlTrackingSelf CreateFromSetValue([Nullable(2)] IControlTrackingSelf_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IControlTrackingSelf
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008A82 RID: 35458 RVA: 0x001463FA File Offset: 0x001445FA
		public new IControlTrackingSelf_SetValue ToSetValue()
		{
			return new IControlTrackingSelf_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002CBA RID: 11450
		// (get) Token: 0x06008A83 RID: 35459 RVA: 0x0014640D File Offset: 0x0014460D
		// (set) Token: 0x06008A84 RID: 35460 RVA: 0x00146438 File Offset: 0x00144638
		public override EControlTrackingType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EControlTrackingType.Self;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005691 RID: 22161
		[Nullable(2)]
		protected new IControlTrackingSelf FbInstance;

		// Token: 0x04005692 RID: 22162
		[Nullable(2)]
		protected new IControlTrackingSelf_SetValue PocoInterface;
	}
}
