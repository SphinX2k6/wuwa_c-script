using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C96 RID: 7318
	[NullableContext(1)]
	[Nullable(0)]
	public class IOpenGlobalTimeScale : ISetGlobalTimeScaleType
	{
		// Token: 0x06009D07 RID: 40199 RVA: 0x00167DD4 File Offset: 0x00165FD4
		private IOpenGlobalTimeScale_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IOpenGlobalTimeScale 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IOpenGlobalTimeScale_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IOpenGlobalTimeScale_SetValue());
			}
			return result;
		}

		// Token: 0x06009D08 RID: 40200 RVA: 0x00167E0C File Offset: 0x0016600C
		public static IOpenGlobalTimeScale Create([Nullable(2)] IOpenGlobalTimeScale instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IOpenGlobalTimeScale
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009D09 RID: 40201 RVA: 0x00167E1F File Offset: 0x0016601F
		public static IOpenGlobalTimeScale CreateFromSetValue([Nullable(2)] IOpenGlobalTimeScale_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IOpenGlobalTimeScale
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009D0A RID: 40202 RVA: 0x00167E32 File Offset: 0x00166032
		public new IOpenGlobalTimeScale_SetValue ToSetValue()
		{
			return new IOpenGlobalTimeScale_SetValue
			{
				Type = this.Type,
				TimeScale = this.TimeScale,
				Duration = this.Duration
			};
		}

		// Token: 0x170030F9 RID: 12537
		// (get) Token: 0x06009D0B RID: 40203 RVA: 0x00167E5D File Offset: 0x0016605D
		// (set) Token: 0x06009D0C RID: 40204 RVA: 0x00167E88 File Offset: 0x00166088
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

		// Token: 0x170030FA RID: 12538
		// (get) Token: 0x06009D0D RID: 40205 RVA: 0x00167E96 File Offset: 0x00166096
		// (set) Token: 0x06009D0E RID: 40206 RVA: 0x00167EC5 File Offset: 0x001660C5
		public virtual float TimeScale
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TimeScale;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.TimeScale;
			}
			set
			{
				this.GetOrCreatePoco().TimeScale = value;
			}
		}

		// Token: 0x170030FB RID: 12539
		// (get) Token: 0x06009D0F RID: 40207 RVA: 0x00167ED3 File Offset: 0x001660D3
		// (set) Token: 0x06009D10 RID: 40208 RVA: 0x00167F02 File Offset: 0x00166102
		public virtual float Duration
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Duration;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Duration;
			}
			set
			{
				this.GetOrCreatePoco().Duration = value;
			}
		}

		// Token: 0x04005F20 RID: 24352
		[Nullable(2)]
		protected new IOpenGlobalTimeScale FbInstance;

		// Token: 0x04005F21 RID: 24353
		[Nullable(2)]
		protected new IOpenGlobalTimeScale_SetValue PocoInterface;
	}
}
