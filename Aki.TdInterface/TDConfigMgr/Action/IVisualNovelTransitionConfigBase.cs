using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020A7 RID: 8359
	[NullableContext(1)]
	[Nullable(0)]
	public class IVisualNovelTransitionConfigBase
	{
		// Token: 0x0600B7DC RID: 47068 RVA: 0x001A9DB4 File Offset: 0x001A7FB4
		private IVisualNovelTransitionConfigBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVisualNovelTransitionConfigBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVisualNovelTransitionConfigBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVisualNovelTransitionConfigBase_SetValue());
			}
			return result;
		}

		// Token: 0x0600B7DD RID: 47069 RVA: 0x001A9DEC File Offset: 0x001A7FEC
		public static IVisualNovelTransitionConfigBase Create([Nullable(2)] IVisualNovelTransitionConfigBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelTransitionConfigBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B7DE RID: 47070 RVA: 0x001A9DFF File Offset: 0x001A7FFF
		public static IVisualNovelTransitionConfigBase CreateFromSetValue([Nullable(2)] IVisualNovelTransitionConfigBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVisualNovelTransitionConfigBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B7DF RID: 47071 RVA: 0x001A9E12 File Offset: 0x001A8012
		public IVisualNovelTransitionConfigBase_SetValue ToSetValue()
		{
			return new IVisualNovelTransitionConfigBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700384C RID: 14412
		// (get) Token: 0x0600B7E0 RID: 47072 RVA: 0x001A9E25 File Offset: 0x001A8025
		// (set) Token: 0x0600B7E1 RID: 47073 RVA: 0x001A9E50 File Offset: 0x001A8050
		public virtual EVisualNovelTransitionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EVisualNovelTransitionType.Location;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006E4F RID: 28239
		[Nullable(2)]
		protected IVisualNovelTransitionConfigBase FbInstance;

		// Token: 0x04006E50 RID: 28240
		[Nullable(2)]
		protected IVisualNovelTransitionConfigBase_SetValue PocoInterface;
	}
}
