using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BE2 RID: 7138
	[JsonConverter(typeof(IFadeBackgroundFadeOutEffectTypeBaseConverter))]
	public class IFadeBackgroundFadeOutEffectTypeBase
	{
		// Token: 0x0600978C RID: 38796 RVA: 0x001600D4 File Offset: 0x0015E2D4
		private IFadeBackgroundFadeOutEffectTypeBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFadeBackgroundFadeOutEffectTypeBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFadeBackgroundFadeOutEffectTypeBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFadeBackgroundFadeOutEffectTypeBase_SetValue());
			}
			return result;
		}

		// Token: 0x0600978D RID: 38797 RVA: 0x0016010C File Offset: 0x0015E30C
		public static IFadeBackgroundFadeOutEffectTypeBase Create([Nullable(2)] IFadeBackgroundFadeOutEffectTypeBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFadeBackgroundFadeOutEffectTypeBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600978E RID: 38798 RVA: 0x0016011F File Offset: 0x0015E31F
		public static IFadeBackgroundFadeOutEffectTypeBase CreateFromSetValue([Nullable(2)] IFadeBackgroundFadeOutEffectTypeBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFadeBackgroundFadeOutEffectTypeBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600978F RID: 38799 RVA: 0x00160132 File Offset: 0x0015E332
		public IFadeBackgroundFadeOutEffectTypeBase_SetValue ToSetValue()
		{
			return new IFadeBackgroundFadeOutEffectTypeBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003000 RID: 12288
		// (get) Token: 0x06009790 RID: 38800 RVA: 0x00160145 File Offset: 0x0015E345
		// (set) Token: 0x06009791 RID: 38801 RVA: 0x00160170 File Offset: 0x0015E370
		public virtual EFadeBackgroundFadeOutEffectType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EFadeBackgroundFadeOutEffectType.Black;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005D6D RID: 23917
		[Nullable(2)]
		protected IFadeBackgroundFadeOutEffectTypeBase FbInstance;

		// Token: 0x04005D6E RID: 23918
		[Nullable(2)]
		protected IFadeBackgroundFadeOutEffectTypeBase_SetValue PocoInterface;
	}
}
