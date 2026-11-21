using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BEE RID: 7150
	[JsonConverter(typeof(IFadeBackgroundUiPrefabTypeConverter))]
	public class IFadeBackgroundUiPrefabType
	{
		// Token: 0x060097D0 RID: 38864 RVA: 0x00160920 File Offset: 0x0015EB20
		private IFadeBackgroundUiPrefabType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFadeBackgroundUiPrefabType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFadeBackgroundUiPrefabType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFadeBackgroundUiPrefabType_SetValue());
			}
			return result;
		}

		// Token: 0x060097D1 RID: 38865 RVA: 0x00160958 File Offset: 0x0015EB58
		public static IFadeBackgroundUiPrefabType Create([Nullable(2)] IFadeBackgroundUiPrefabType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFadeBackgroundUiPrefabType
			{
				FbInstance = instance
			};
		}

		// Token: 0x060097D2 RID: 38866 RVA: 0x0016096B File Offset: 0x0015EB6B
		public static IFadeBackgroundUiPrefabType CreateFromSetValue([Nullable(2)] IFadeBackgroundUiPrefabType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFadeBackgroundUiPrefabType
			{
				PocoInterface = value
			};
		}

		// Token: 0x060097D3 RID: 38867 RVA: 0x0016097E File Offset: 0x0015EB7E
		public IFadeBackgroundUiPrefabType_SetValue ToSetValue()
		{
			return new IFadeBackgroundUiPrefabType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003010 RID: 12304
		// (get) Token: 0x060097D4 RID: 38868 RVA: 0x00160991 File Offset: 0x0015EB91
		// (set) Token: 0x060097D5 RID: 38869 RVA: 0x001609BC File Offset: 0x0015EBBC
		public virtual EFadeBackgroundUiPrefabType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EFadeBackgroundUiPrefabType.BlackScreenWhiteText;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005D93 RID: 23955
		[Nullable(2)]
		protected IFadeBackgroundUiPrefabType FbInstance;

		// Token: 0x04005D94 RID: 23956
		[Nullable(2)]
		protected IFadeBackgroundUiPrefabType_SetValue PocoInterface;
	}
}
