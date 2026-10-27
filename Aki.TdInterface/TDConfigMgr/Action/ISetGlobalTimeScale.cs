using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E1E RID: 7710
	[NullableContext(1)]
	[Nullable(0)]
	public class ISetGlobalTimeScale : ITimeScaleType
	{
		// Token: 0x0600A4EF RID: 42223 RVA: 0x00175DCC File Offset: 0x00173FCC
		private ISetGlobalTimeScale_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISetGlobalTimeScale 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISetGlobalTimeScale_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISetGlobalTimeScale_SetValue());
			}
			return result;
		}

		// Token: 0x0600A4F0 RID: 42224 RVA: 0x00175E04 File Offset: 0x00174004
		public static ISetGlobalTimeScale Create([Nullable(2)] ISetGlobalTimeScale instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetGlobalTimeScale
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A4F1 RID: 42225 RVA: 0x00175E17 File Offset: 0x00174017
		public static ISetGlobalTimeScale CreateFromSetValue([Nullable(2)] ISetGlobalTimeScale_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISetGlobalTimeScale
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A4F2 RID: 42226 RVA: 0x00175E2A File Offset: 0x0017402A
		public new ISetGlobalTimeScale_SetValue ToSetValue()
		{
			return new ISetGlobalTimeScale_SetValue
			{
				Type = this.Type,
				Config = this.Config
			};
		}

		// Token: 0x170032A1 RID: 12961
		// (get) Token: 0x0600A4F3 RID: 42227 RVA: 0x00175E49 File Offset: 0x00174049
		// (set) Token: 0x0600A4F4 RID: 42228 RVA: 0x00175E74 File Offset: 0x00174074
		public override ETimeScaleType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETimeScaleType.Global;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170032A2 RID: 12962
		// (get) Token: 0x0600A4F5 RID: 42229 RVA: 0x00175E82 File Offset: 0x00174082
		// (set) Token: 0x0600A4F6 RID: 42230 RVA: 0x00175EA9 File Offset: 0x001740A9
		public virtual ISetGlobalTimeScaleType Config
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Config;
				}
				ISetGlobalTimeScale_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Config;
			}
			set
			{
				this.GetOrCreatePoco().Config = value;
			}
		}

		// Token: 0x040062B2 RID: 25266
		[Nullable(2)]
		protected new ISetGlobalTimeScale FbInstance;

		// Token: 0x040062B3 RID: 25267
		[Nullable(2)]
		protected new ISetGlobalTimeScale_SetValue PocoInterface;
	}
}
