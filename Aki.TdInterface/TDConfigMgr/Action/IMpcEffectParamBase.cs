using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E49 RID: 7753
	public class IMpcEffectParamBase
	{
		// Token: 0x0600A4DF RID: 42207 RVA: 0x00178680 File Offset: 0x00176880
		private IMpcEffectParamBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMpcEffectParamBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMpcEffectParamBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMpcEffectParamBase_SetValue());
			}
			return result;
		}

		// Token: 0x0600A4E0 RID: 42208 RVA: 0x001786B8 File Offset: 0x001768B8
		public static IMpcEffectParamBase Create([Nullable(2)] IMpcEffectParamBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMpcEffectParamBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A4E1 RID: 42209 RVA: 0x001786CB File Offset: 0x001768CB
		public static IMpcEffectParamBase CreateFromSetValue([Nullable(2)] IMpcEffectParamBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMpcEffectParamBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A4E2 RID: 42210 RVA: 0x001786DE File Offset: 0x001768DE
		public IMpcEffectParamBase_SetValue ToSetValue()
		{
			return new IMpcEffectParamBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003310 RID: 13072
		// (get) Token: 0x0600A4E3 RID: 42211 RVA: 0x001786F1 File Offset: 0x001768F1
		// (set) Token: 0x0600A4E4 RID: 42212 RVA: 0x0017871C File Offset: 0x0017691C
		public virtual EMpcEffectParamType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EMpcEffectParamType.PostProcessVolumeCenterPosition;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040063AB RID: 25515
		[Nullable(2)]
		protected IMpcEffectParamBase FbInstance;

		// Token: 0x040063AC RID: 25516
		[Nullable(2)]
		protected IMpcEffectParamBase_SetValue PocoInterface;
	}
}
