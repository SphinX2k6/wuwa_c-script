using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A59 RID: 6745
	[NullableContext(1)]
	[Nullable(0)]
	[JsonConverter(typeof(IFadeBackgroundUiPrefabTypeConverter))]
	public class IFadeBackgroundUiPrefabType
	{
		// Token: 0x06009066 RID: 36966 RVA: 0x001509F4 File Offset: 0x0014EBF4
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

		// Token: 0x06009067 RID: 36967 RVA: 0x00150A2C File Offset: 0x0014EC2C
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

		// Token: 0x06009068 RID: 36968 RVA: 0x00150A3F File Offset: 0x0014EC3F
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

		// Token: 0x06009069 RID: 36969 RVA: 0x00150A52 File Offset: 0x0014EC52
		public IFadeBackgroundUiPrefabType_SetValue ToSetValue()
		{
			return new IFadeBackgroundUiPrefabType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002E03 RID: 11779
		// (get) Token: 0x0600906A RID: 36970 RVA: 0x00150A65 File Offset: 0x0014EC65
		// (set) Token: 0x0600906B RID: 36971 RVA: 0x00150A90 File Offset: 0x0014EC90
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

		// Token: 0x0400592E RID: 22830
		[Nullable(2)]
		protected IFadeBackgroundUiPrefabType FbInstance;

		// Token: 0x0400592F RID: 22831
		[Nullable(2)]
		protected IFadeBackgroundUiPrefabType_SetValue PocoInterface;
	}
}
