using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BD0 RID: 7120
	[NullableContext(1)]
	[Nullable(0)]
	public class IMechStuntClimbFly : IMechStuntConfigType
	{
		// Token: 0x06009891 RID: 39057 RVA: 0x0015F9E8 File Offset: 0x0015DBE8
		private IMechStuntClimbFly_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMechStuntClimbFly 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMechStuntClimbFly_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMechStuntClimbFly_SetValue());
			}
			return result;
		}

		// Token: 0x06009892 RID: 39058 RVA: 0x0015FA20 File Offset: 0x0015DC20
		public static IMechStuntClimbFly Create([Nullable(2)] IMechStuntClimbFly instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMechStuntClimbFly
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009893 RID: 39059 RVA: 0x0015FA33 File Offset: 0x0015DC33
		public static IMechStuntClimbFly CreateFromSetValue([Nullable(2)] IMechStuntClimbFly_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMechStuntClimbFly
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009894 RID: 39060 RVA: 0x0015FA46 File Offset: 0x0015DC46
		public new IMechStuntClimbFly_SetValue ToSetValue()
		{
			return new IMechStuntClimbFly_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002FE7 RID: 12263
		// (get) Token: 0x06009895 RID: 39061 RVA: 0x0015FA59 File Offset: 0x0015DC59
		// (set) Token: 0x06009896 RID: 39062 RVA: 0x0015FA84 File Offset: 0x0015DC84
		public override EMechStuntType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EMechStuntType.Dive;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005D0A RID: 23818
		[Nullable(2)]
		protected new IMechStuntClimbFly FbInstance;

		// Token: 0x04005D0B RID: 23819
		[Nullable(2)]
		protected new IMechStuntClimbFly_SetValue PocoInterface;
	}
}
