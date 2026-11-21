using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BDA RID: 7130
	[JsonConverter(typeof(IFadeBackgroundFadeInEffectTypeBaseConverter))]
	public class IFadeBackgroundFadeInEffectTypeBase
	{
		// Token: 0x06009764 RID: 38756 RVA: 0x0015FCB8 File Offset: 0x0015DEB8
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

		// Token: 0x06009765 RID: 38757 RVA: 0x0015FCF0 File Offset: 0x0015DEF0
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

		// Token: 0x06009766 RID: 38758 RVA: 0x0015FD03 File Offset: 0x0015DF03
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

		// Token: 0x06009767 RID: 38759 RVA: 0x0015FD16 File Offset: 0x0015DF16
		public IFadeBackgroundFadeInEffectTypeBase_SetValue ToSetValue()
		{
			return new IFadeBackgroundFadeInEffectTypeBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002FF8 RID: 12280
		// (get) Token: 0x06009768 RID: 38760 RVA: 0x0015FD29 File Offset: 0x0015DF29
		// (set) Token: 0x06009769 RID: 38761 RVA: 0x0015FD54 File Offset: 0x0015DF54
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

		// Token: 0x04005D5D RID: 23901
		[Nullable(2)]
		protected IFadeBackgroundFadeInEffectTypeBase FbInstance;

		// Token: 0x04005D5E RID: 23902
		[Nullable(2)]
		protected IFadeBackgroundFadeInEffectTypeBase_SetValue PocoInterface;
	}
}
