using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B8E RID: 7054
	[NullableContext(1)]
	[Nullable(0)]
	public class ILimitPlayerCamera : ILimitPlayerOption
	{
		// Token: 0x06009709 RID: 38665 RVA: 0x0015C8E8 File Offset: 0x0015AAE8
		private ILimitPlayerCamera_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILimitPlayerCamera 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILimitPlayerCamera_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILimitPlayerCamera_SetValue());
			}
			return result;
		}

		// Token: 0x0600970A RID: 38666 RVA: 0x0015C920 File Offset: 0x0015AB20
		public static ILimitPlayerCamera Create([Nullable(2)] ILimitPlayerCamera instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILimitPlayerCamera
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600970B RID: 38667 RVA: 0x0015C933 File Offset: 0x0015AB33
		public static ILimitPlayerCamera CreateFromSetValue([Nullable(2)] ILimitPlayerCamera_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILimitPlayerCamera
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600970C RID: 38668 RVA: 0x0015C946 File Offset: 0x0015AB46
		public new ILimitPlayerCamera_SetValue ToSetValue()
		{
			return new ILimitPlayerCamera_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002F86 RID: 12166
		// (get) Token: 0x0600970D RID: 38669 RVA: 0x0015C959 File Offset: 0x0015AB59
		// (set) Token: 0x0600970E RID: 38670 RVA: 0x0015C984 File Offset: 0x0015AB84
		public override ELimitPlayOperation Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELimitPlayOperation.AllowCamera;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005C3F RID: 23615
		[Nullable(2)]
		protected new ILimitPlayerCamera FbInstance;

		// Token: 0x04005C40 RID: 23616
		[Nullable(2)]
		protected new ILimitPlayerCamera_SetValue PocoInterface;
	}
}
