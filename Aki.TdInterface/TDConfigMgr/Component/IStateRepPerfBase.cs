using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000711 RID: 1809
	[NullableContext(1)]
	[Nullable(0)]
	public class IStateRepPerfBase
	{
		// Token: 0x060026EB RID: 9963 RVA: 0x00067D0C File Offset: 0x00065F0C
		private IStateRepPerfBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IStateRepPerfBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IStateRepPerfBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IStateRepPerfBase_SetValue());
			}
			return result;
		}

		// Token: 0x060026EC RID: 9964 RVA: 0x00067D44 File Offset: 0x00065F44
		public static IStateRepPerfBase Create([Nullable(2)] IStateRepPerfBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStateRepPerfBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x060026ED RID: 9965 RVA: 0x00067D57 File Offset: 0x00065F57
		public static IStateRepPerfBase CreateFromSetValue([Nullable(2)] IStateRepPerfBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IStateRepPerfBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x060026EE RID: 9966 RVA: 0x00067D6A File Offset: 0x00065F6A
		public IStateRepPerfBase_SetValue ToSetValue()
		{
			return new IStateRepPerfBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000A3C RID: 2620
		// (get) Token: 0x060026EF RID: 9967 RVA: 0x00067D7D File Offset: 0x00065F7D
		// (set) Token: 0x060026F0 RID: 9968 RVA: 0x00067DA8 File Offset: 0x00065FA8
		public virtual EStateRepPerfType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EStateRepPerfType.SkillId;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001A50 RID: 6736
		[Nullable(2)]
		protected IStateRepPerfBase FbInstance;

		// Token: 0x04001A51 RID: 6737
		[Nullable(2)]
		protected IStateRepPerfBase_SetValue PocoInterface;
	}
}
