using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022A2 RID: 8866
	public class IVisualNovelBackgroundBase
	{
		// Token: 0x0600C11E RID: 49438 RVA: 0x001BCA34 File Offset: 0x001BAC34
		private IVisualNovelBackgroundBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVisualNovelBackgroundBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVisualNovelBackgroundBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVisualNovelBackgroundBase_SetValue());
			}
			return result;
		}

		// Token: 0x0600C11F RID: 49439 RVA: 0x001BCA6C File Offset: 0x001BAC6C
		public static IVisualNovelBackgroundBase Create([Nullable(2)] IVisualNovelBackgroundBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelBackgroundBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C120 RID: 49440 RVA: 0x001BCA7F File Offset: 0x001BAC7F
		public static IVisualNovelBackgroundBase CreateFromSetValue([Nullable(2)] IVisualNovelBackgroundBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVisualNovelBackgroundBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C121 RID: 49441 RVA: 0x001BCA92 File Offset: 0x001BAC92
		public IVisualNovelBackgroundBase_SetValue ToSetValue()
		{
			return new IVisualNovelBackgroundBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003AAC RID: 15020
		// (get) Token: 0x0600C122 RID: 49442 RVA: 0x001BCAA5 File Offset: 0x001BACA5
		// (set) Token: 0x0600C123 RID: 49443 RVA: 0x001BCAD0 File Offset: 0x001BACD0
		public virtual EVisualNovelBackgroundType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EVisualNovelBackgroundType.Load;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400736D RID: 29549
		[Nullable(2)]
		protected IVisualNovelBackgroundBase FbInstance;

		// Token: 0x0400736E RID: 29550
		[Nullable(2)]
		protected IVisualNovelBackgroundBase_SetValue PocoInterface;
	}
}
