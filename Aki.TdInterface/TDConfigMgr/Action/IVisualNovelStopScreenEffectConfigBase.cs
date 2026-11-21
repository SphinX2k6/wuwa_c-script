using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022F8 RID: 8952
	public class IVisualNovelStopScreenEffectConfigBase
	{
		// Token: 0x0600C322 RID: 49954 RVA: 0x001C0840 File Offset: 0x001BEA40
		private IVisualNovelStopScreenEffectConfigBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVisualNovelStopScreenEffectConfigBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVisualNovelStopScreenEffectConfigBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVisualNovelStopScreenEffectConfigBase_SetValue());
			}
			return result;
		}

		// Token: 0x0600C323 RID: 49955 RVA: 0x001C0878 File Offset: 0x001BEA78
		public static IVisualNovelStopScreenEffectConfigBase Create([Nullable(2)] IVisualNovelStopScreenEffectConfigBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelStopScreenEffectConfigBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C324 RID: 49956 RVA: 0x001C088B File Offset: 0x001BEA8B
		public static IVisualNovelStopScreenEffectConfigBase CreateFromSetValue([Nullable(2)] IVisualNovelStopScreenEffectConfigBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVisualNovelStopScreenEffectConfigBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C325 RID: 49957 RVA: 0x001C089E File Offset: 0x001BEA9E
		public IVisualNovelStopScreenEffectConfigBase_SetValue ToSetValue()
		{
			return new IVisualNovelStopScreenEffectConfigBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003B2D RID: 15149
		// (get) Token: 0x0600C326 RID: 49958 RVA: 0x001C08B1 File Offset: 0x001BEAB1
		// (set) Token: 0x0600C327 RID: 49959 RVA: 0x001C08DC File Offset: 0x001BEADC
		public virtual EVisualNovelStopScreenEffectType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EVisualNovelStopScreenEffectType.Persistent;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04007466 RID: 29798
		[Nullable(2)]
		protected IVisualNovelStopScreenEffectConfigBase FbInstance;

		// Token: 0x04007467 RID: 29799
		[Nullable(2)]
		protected IVisualNovelStopScreenEffectConfigBase_SetValue PocoInterface;
	}
}
