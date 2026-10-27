using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002A3 RID: 675
	[NullableContext(1)]
	[Nullable(0)]
	public class ICycleModeType
	{
		// Token: 0x06000C9B RID: 3227 RVA: 0x000307A4 File Offset: 0x0002E9A4
		private ICycleModeType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICycleModeType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICycleModeType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICycleModeType_SetValue());
			}
			return result;
		}

		// Token: 0x06000C9C RID: 3228 RVA: 0x000307DC File Offset: 0x0002E9DC
		public static ICycleModeType Create([Nullable(2)] ICycleModeType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICycleModeType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000C9D RID: 3229 RVA: 0x000307EF File Offset: 0x0002E9EF
		public static ICycleModeType CreateFromSetValue([Nullable(2)] ICycleModeType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICycleModeType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000C9E RID: 3230 RVA: 0x00030802 File Offset: 0x0002EA02
		public ICycleModeType_SetValue ToSetValue()
		{
			return new ICycleModeType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06000C9F RID: 3231 RVA: 0x00030815 File Offset: 0x0002EA15
		// (set) Token: 0x06000CA0 RID: 3232 RVA: 0x00030840 File Offset: 0x0002EA40
		public virtual EPatrolCycleMode Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPatrolCycleMode.Loop;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04000BBF RID: 3007
		[Nullable(2)]
		protected ICycleModeType FbInstance;

		// Token: 0x04000BC0 RID: 3008
		[Nullable(2)]
		protected ICycleModeType_SetValue PocoInterface;
	}
}
