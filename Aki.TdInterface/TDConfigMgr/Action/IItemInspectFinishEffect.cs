using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D0F RID: 7439
	public class IItemInspectFinishEffect
	{
		// Token: 0x06009DF3 RID: 40435 RVA: 0x0016B760 File Offset: 0x00169960
		private IItemInspectFinishEffect_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IItemInspectFinishEffect 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IItemInspectFinishEffect_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IItemInspectFinishEffect_SetValue());
			}
			return result;
		}

		// Token: 0x06009DF4 RID: 40436 RVA: 0x0016B798 File Offset: 0x00169998
		public static IItemInspectFinishEffect Create([Nullable(2)] IItemInspectFinishEffect instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IItemInspectFinishEffect
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009DF5 RID: 40437 RVA: 0x0016B7AB File Offset: 0x001699AB
		public static IItemInspectFinishEffect CreateFromSetValue([Nullable(2)] IItemInspectFinishEffect_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IItemInspectFinishEffect
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009DF6 RID: 40438 RVA: 0x0016B7BE File Offset: 0x001699BE
		public IItemInspectFinishEffect_SetValue ToSetValue()
		{
			return new IItemInspectFinishEffect_SetValue
			{
				EffectList = this.EffectList,
				ProtectTime = this.ProtectTime
			};
		}

		// Token: 0x17003171 RID: 12657
		// (get) Token: 0x06009DF7 RID: 40439 RVA: 0x0016B7DD File Offset: 0x001699DD
		// (set) Token: 0x06009DF8 RID: 40440 RVA: 0x0016B804 File Offset: 0x00169A04
		public virtual List<IInteractEffect> EffectList
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EffectList;
				}
				IItemInspectFinishEffect_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EffectList;
			}
			set
			{
				this.GetOrCreatePoco().EffectList = value;
			}
		}

		// Token: 0x17003172 RID: 12658
		// (get) Token: 0x06009DF9 RID: 40441 RVA: 0x0016B814 File Offset: 0x00169A14
		// (set) Token: 0x06009DFA RID: 40442 RVA: 0x0016B84E File Offset: 0x00169A4E
		public virtual float? ProtectTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ProtectTime;
				}
				IItemInspectFinishEffect_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ProtectTime;
			}
			set
			{
				this.GetOrCreatePoco().ProtectTime = value;
			}
		}

		// Token: 0x04006060 RID: 24672
		[Nullable(2)]
		protected IItemInspectFinishEffect FbInstance;

		// Token: 0x04006061 RID: 24673
		[Nullable(2)]
		protected IItemInspectFinishEffect_SetValue PocoInterface;
	}
}
