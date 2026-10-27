using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002224 RID: 8740
	[NullableContext(1)]
	[Nullable(0)]
	public class StopUiScreenEffect : ActionParams
	{
		// Token: 0x0600BFDA RID: 49114 RVA: 0x001B8F64 File Offset: 0x001B7164
		private StopUiScreenEffect_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("StopUiScreenEffect 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			StopUiScreenEffect_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new StopUiScreenEffect_SetValue());
			}
			return result;
		}

		// Token: 0x0600BFDB RID: 49115 RVA: 0x001B8F9C File Offset: 0x001B719C
		public static StopUiScreenEffect Create([Nullable(2)] StopUiScreenEffect instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new StopUiScreenEffect
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BFDC RID: 49116 RVA: 0x001B8FAF File Offset: 0x001B71AF
		public static StopUiScreenEffect CreateFromSetValue([Nullable(2)] StopUiScreenEffect_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new StopUiScreenEffect
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BFDD RID: 49117 RVA: 0x001B8FC2 File Offset: 0x001B71C2
		public StopUiScreenEffect_SetValue ToSetValue()
		{
			return new StopUiScreenEffect_SetValue
			{
				EffectDaPath = this.EffectDaPath
			};
		}

		// Token: 0x17003A1C RID: 14876
		// (get) Token: 0x0600BFDE RID: 49118 RVA: 0x001B8FD5 File Offset: 0x001B71D5
		// (set) Token: 0x0600BFDF RID: 49119 RVA: 0x001B9000 File Offset: 0x001B7200
		public virtual string EffectDaPath
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EffectDaPath;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.EffectDaPath;
			}
			set
			{
				this.GetOrCreatePoco().EffectDaPath = value;
			}
		}

		// Token: 0x04007266 RID: 29286
		[Nullable(2)]
		protected new StopUiScreenEffect FbInstance;

		// Token: 0x04007267 RID: 29287
		[Nullable(2)]
		protected StopUiScreenEffect_SetValue PocoInterface;
	}
}
