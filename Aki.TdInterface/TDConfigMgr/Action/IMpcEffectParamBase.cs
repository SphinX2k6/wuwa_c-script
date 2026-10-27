using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C52 RID: 7250
	[NullableContext(1)]
	[Nullable(0)]
	public class IMpcEffectParamBase
	{
		// Token: 0x06009B87 RID: 39815 RVA: 0x00165340 File Offset: 0x00163540
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

		// Token: 0x06009B88 RID: 39816 RVA: 0x00165378 File Offset: 0x00163578
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

		// Token: 0x06009B89 RID: 39817 RVA: 0x0016538B File Offset: 0x0016358B
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

		// Token: 0x06009B8A RID: 39818 RVA: 0x0016539E File Offset: 0x0016359E
		public IMpcEffectParamBase_SetValue ToSetValue()
		{
			return new IMpcEffectParamBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700309F RID: 12447
		// (get) Token: 0x06009B8B RID: 39819 RVA: 0x001653B1 File Offset: 0x001635B1
		// (set) Token: 0x06009B8C RID: 39820 RVA: 0x001653DC File Offset: 0x001635DC
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

		// Token: 0x04005E74 RID: 24180
		[Nullable(2)]
		protected IMpcEffectParamBase FbInstance;

		// Token: 0x04005E75 RID: 24181
		[Nullable(2)]
		protected IMpcEffectParamBase_SetValue PocoInterface;
	}
}
