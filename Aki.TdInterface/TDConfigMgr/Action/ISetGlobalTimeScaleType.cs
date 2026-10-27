using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E20 RID: 7712
	[NullableContext(1)]
	[Nullable(0)]
	public class ISetGlobalTimeScaleType
	{
		// Token: 0x0600A4F9 RID: 42233 RVA: 0x00175EC8 File Offset: 0x001740C8
		private ISetGlobalTimeScaleType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISetGlobalTimeScaleType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISetGlobalTimeScaleType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISetGlobalTimeScaleType_SetValue());
			}
			return result;
		}

		// Token: 0x0600A4FA RID: 42234 RVA: 0x00175F00 File Offset: 0x00174100
		public static ISetGlobalTimeScaleType Create([Nullable(2)] ISetGlobalTimeScaleType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetGlobalTimeScaleType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A4FB RID: 42235 RVA: 0x00175F13 File Offset: 0x00174113
		public static ISetGlobalTimeScaleType CreateFromSetValue([Nullable(2)] ISetGlobalTimeScaleType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISetGlobalTimeScaleType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A4FC RID: 42236 RVA: 0x00175F26 File Offset: 0x00174126
		public ISetGlobalTimeScaleType_SetValue ToSetValue()
		{
			return new ISetGlobalTimeScaleType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170032A3 RID: 12963
		// (get) Token: 0x0600A4FD RID: 42237 RVA: 0x00175F39 File Offset: 0x00174139
		// (set) Token: 0x0600A4FE RID: 42238 RVA: 0x00175F64 File Offset: 0x00174164
		public virtual ESetTimeScaleType Type
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

		// Token: 0x040062B6 RID: 25270
		[Nullable(2)]
		protected ISetGlobalTimeScaleType FbInstance;

		// Token: 0x040062B7 RID: 25271
		[Nullable(2)]
		protected ISetGlobalTimeScaleType_SetValue PocoInterface;
	}
}
