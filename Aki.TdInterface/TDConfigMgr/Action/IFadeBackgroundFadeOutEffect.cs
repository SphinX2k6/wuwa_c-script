using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BDC RID: 7132
	[JsonConverter(typeof(IFadeBackgroundFadeOutEffectConverter))]
	public class IFadeBackgroundFadeOutEffect
	{
		// Token: 0x0600976C RID: 38764 RVA: 0x0015FD74 File Offset: 0x0015DF74
		private IFadeBackgroundFadeOutEffect_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFadeBackgroundFadeOutEffect 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFadeBackgroundFadeOutEffect_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFadeBackgroundFadeOutEffect_SetValue());
			}
			return result;
		}

		// Token: 0x0600976D RID: 38765 RVA: 0x0015FDAC File Offset: 0x0015DFAC
		public static IFadeBackgroundFadeOutEffect Create([Nullable(2)] IFadeBackgroundFadeOutEffect instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFadeBackgroundFadeOutEffect
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600976E RID: 38766 RVA: 0x0015FDBF File Offset: 0x0015DFBF
		public static IFadeBackgroundFadeOutEffect CreateFromSetValue([Nullable(2)] IFadeBackgroundFadeOutEffect_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFadeBackgroundFadeOutEffect
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600976F RID: 38767 RVA: 0x0015FDD2 File Offset: 0x0015DFD2
		public IFadeBackgroundFadeOutEffect_SetValue ToSetValue()
		{
			return new IFadeBackgroundFadeOutEffect_SetValue
			{
				FadeOutEffect = this.FadeOutEffect
			};
		}

		// Token: 0x17002FF9 RID: 12281
		// (get) Token: 0x06009770 RID: 38768 RVA: 0x0015FDE5 File Offset: 0x0015DFE5
		// (set) Token: 0x06009771 RID: 38769 RVA: 0x0015FE0C File Offset: 0x0015E00C
		public virtual IFadeBackgroundFadeOutEffectTypeBase FadeOutEffect
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FadeOutEffect;
				}
				IFadeBackgroundFadeOutEffect_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.FadeOutEffect;
			}
			set
			{
				this.GetOrCreatePoco().FadeOutEffect = value;
			}
		}

		// Token: 0x04005D60 RID: 23904
		[Nullable(2)]
		protected IFadeBackgroundFadeOutEffect FbInstance;

		// Token: 0x04005D61 RID: 23905
		[Nullable(2)]
		protected IFadeBackgroundFadeOutEffect_SetValue PocoInterface;
	}
}
