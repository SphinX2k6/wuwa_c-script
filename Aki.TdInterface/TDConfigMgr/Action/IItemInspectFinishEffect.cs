using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B62 RID: 7010
	[NullableContext(1)]
	[Nullable(0)]
	public class IItemInspectFinishEffect
	{
		// Token: 0x06009611 RID: 38417 RVA: 0x0015ABB4 File Offset: 0x00158DB4
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

		// Token: 0x06009612 RID: 38418 RVA: 0x0015ABEC File Offset: 0x00158DEC
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

		// Token: 0x06009613 RID: 38419 RVA: 0x0015ABFF File Offset: 0x00158DFF
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

		// Token: 0x06009614 RID: 38420 RVA: 0x0015AC12 File Offset: 0x00158E12
		public IItemInspectFinishEffect_SetValue ToSetValue()
		{
			return new IItemInspectFinishEffect_SetValue
			{
				EffectList = this.EffectList,
				ProtectTime = this.ProtectTime
			};
		}

		// Token: 0x17002F4C RID: 12108
		// (get) Token: 0x06009615 RID: 38421 RVA: 0x0015AC31 File Offset: 0x00158E31
		// (set) Token: 0x06009616 RID: 38422 RVA: 0x0015AC58 File Offset: 0x00158E58
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

		// Token: 0x17002F4D RID: 12109
		// (get) Token: 0x06009617 RID: 38423 RVA: 0x0015AC68 File Offset: 0x00158E68
		// (set) Token: 0x06009618 RID: 38424 RVA: 0x0015ACA2 File Offset: 0x00158EA2
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

		// Token: 0x04005BC7 RID: 23495
		[Nullable(2)]
		protected IItemInspectFinishEffect FbInstance;

		// Token: 0x04005BC8 RID: 23496
		[Nullable(2)]
		protected IItemInspectFinishEffect_SetValue PocoInterface;
	}
}
