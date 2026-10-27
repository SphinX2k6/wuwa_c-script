using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018DC RID: 6364
	[NullableContext(1)]
	[Nullable(0)]
	public class ICloseGlobalTimeScale : ISetGlobalTimeScaleType
	{
		// Token: 0x06008875 RID: 34933 RVA: 0x00142C3C File Offset: 0x00140E3C
		private ICloseGlobalTimeScale_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICloseGlobalTimeScale 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICloseGlobalTimeScale_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICloseGlobalTimeScale_SetValue());
			}
			return result;
		}

		// Token: 0x06008876 RID: 34934 RVA: 0x00142C74 File Offset: 0x00140E74
		public static ICloseGlobalTimeScale Create([Nullable(2)] ICloseGlobalTimeScale instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICloseGlobalTimeScale
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008877 RID: 34935 RVA: 0x00142C87 File Offset: 0x00140E87
		public static ICloseGlobalTimeScale CreateFromSetValue([Nullable(2)] ICloseGlobalTimeScale_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICloseGlobalTimeScale
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008878 RID: 34936 RVA: 0x00142C9A File Offset: 0x00140E9A
		public new ICloseGlobalTimeScale_SetValue ToSetValue()
		{
			return new ICloseGlobalTimeScale_SetValue
			{
				Type = this.Type,
				TimeScaleCloseSource = this.TimeScaleCloseSource
			};
		}

		// Token: 0x17002C45 RID: 11333
		// (get) Token: 0x06008879 RID: 34937 RVA: 0x00142CB9 File Offset: 0x00140EB9
		// (set) Token: 0x0600887A RID: 34938 RVA: 0x00142CE4 File Offset: 0x00140EE4
		public override ESetTimeScaleType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESetTimeScaleType.Open;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002C46 RID: 11334
		// (get) Token: 0x0600887B RID: 34939 RVA: 0x00142CF4 File Offset: 0x00140EF4
		// (set) Token: 0x0600887C RID: 34940 RVA: 0x00142D2E File Offset: 0x00140F2E
		public virtual ETimeScaleCloseSource? TimeScaleCloseSource
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TimeScaleCloseSource;
				}
				ICloseGlobalTimeScale_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TimeScaleCloseSource;
			}
			set
			{
				this.GetOrCreatePoco().TimeScaleCloseSource = value;
			}
		}

		// Token: 0x040055B0 RID: 21936
		[Nullable(2)]
		protected new ICloseGlobalTimeScale FbInstance;

		// Token: 0x040055B1 RID: 21937
		[Nullable(2)]
		protected new ICloseGlobalTimeScale_SetValue PocoInterface;
	}
}
