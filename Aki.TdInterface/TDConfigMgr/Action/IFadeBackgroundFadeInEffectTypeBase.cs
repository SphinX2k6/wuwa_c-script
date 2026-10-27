using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A45 RID: 6725
	[NullableContext(1)]
	[Nullable(0)]
	[JsonConverter(typeof(IFadeBackgroundFadeInEffectTypeBaseConverter))]
	public class IFadeBackgroundFadeInEffectTypeBase
	{
		// Token: 0x06008FFA RID: 36858 RVA: 0x0014FD8C File Offset: 0x0014DF8C
		private IFadeBackgroundFadeInEffectTypeBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFadeBackgroundFadeInEffectTypeBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFadeBackgroundFadeInEffectTypeBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFadeBackgroundFadeInEffectTypeBase_SetValue());
			}
			return result;
		}

		// Token: 0x06008FFB RID: 36859 RVA: 0x0014FDC4 File Offset: 0x0014DFC4
		public static IFadeBackgroundFadeInEffectTypeBase Create([Nullable(2)] IFadeBackgroundFadeInEffectTypeBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFadeBackgroundFadeInEffectTypeBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008FFC RID: 36860 RVA: 0x0014FDD7 File Offset: 0x0014DFD7
		public static IFadeBackgroundFadeInEffectTypeBase CreateFromSetValue([Nullable(2)] IFadeBackgroundFadeInEffectTypeBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFadeBackgroundFadeInEffectTypeBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008FFD RID: 36861 RVA: 0x0014FDEA File Offset: 0x0014DFEA
		public IFadeBackgroundFadeInEffectTypeBase_SetValue ToSetValue()
		{
			return new IFadeBackgroundFadeInEffectTypeBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002DEB RID: 11755
		// (get) Token: 0x06008FFE RID: 36862 RVA: 0x0014FDFD File Offset: 0x0014DFFD
		// (set) Token: 0x06008FFF RID: 36863 RVA: 0x0014FE28 File Offset: 0x0014E028
		public virtual EFadeBackgroundFadeInEffectType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EFadeBackgroundFadeInEffectType.Black;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040058F8 RID: 22776
		[Nullable(2)]
		protected IFadeBackgroundFadeInEffectTypeBase FbInstance;

		// Token: 0x040058F9 RID: 22777
		[Nullable(2)]
		protected IFadeBackgroundFadeInEffectTypeBase_SetValue PocoInterface;
	}
}
