using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A4D RID: 6733
	[NullableContext(1)]
	[Nullable(0)]
	[JsonConverter(typeof(IFadeBackgroundFadeOutEffectTypeBaseConverter))]
	public class IFadeBackgroundFadeOutEffectTypeBase
	{
		// Token: 0x06009022 RID: 36898 RVA: 0x001501A8 File Offset: 0x0014E3A8
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

		// Token: 0x06009023 RID: 36899 RVA: 0x001501E0 File Offset: 0x0014E3E0
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

		// Token: 0x06009024 RID: 36900 RVA: 0x001501F3 File Offset: 0x0014E3F3
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

		// Token: 0x06009025 RID: 36901 RVA: 0x00150206 File Offset: 0x0014E406
		public IFadeBackgroundFadeOutEffectTypeBase_SetValue ToSetValue()
		{
			return new IFadeBackgroundFadeOutEffectTypeBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002DF3 RID: 11763
		// (get) Token: 0x06009026 RID: 36902 RVA: 0x00150219 File Offset: 0x0014E419
		// (set) Token: 0x06009027 RID: 36903 RVA: 0x00150244 File Offset: 0x0014E444
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

		// Token: 0x04005908 RID: 22792
		[Nullable(2)]
		protected IFadeBackgroundFadeOutEffectTypeBase FbInstance;

		// Token: 0x04005909 RID: 22793
		[Nullable(2)]
		protected IFadeBackgroundFadeOutEffectTypeBase_SetValue PocoInterface;
	}
}
