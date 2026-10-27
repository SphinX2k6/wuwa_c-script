using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200205F RID: 8287
	[NullableContext(1)]
	[Nullable(0)]
	public class IVisualNovelCgBase
	{
		// Token: 0x0600B612 RID: 46610 RVA: 0x001A6540 File Offset: 0x001A4740
		private IVisualNovelCgBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVisualNovelCgBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVisualNovelCgBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVisualNovelCgBase_SetValue());
			}
			return result;
		}

		// Token: 0x0600B613 RID: 46611 RVA: 0x001A6578 File Offset: 0x001A4778
		public static IVisualNovelCgBase Create([Nullable(2)] IVisualNovelCgBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelCgBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B614 RID: 46612 RVA: 0x001A658B File Offset: 0x001A478B
		public static IVisualNovelCgBase CreateFromSetValue([Nullable(2)] IVisualNovelCgBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVisualNovelCgBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B615 RID: 46613 RVA: 0x001A659E File Offset: 0x001A479E
		public IVisualNovelCgBase_SetValue ToSetValue()
		{
			return new IVisualNovelCgBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170037D3 RID: 14291
		// (get) Token: 0x0600B616 RID: 46614 RVA: 0x001A65B1 File Offset: 0x001A47B1
		// (set) Token: 0x0600B617 RID: 46615 RVA: 0x001A65DC File Offset: 0x001A47DC
		public virtual EVisualNovelCgType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EVisualNovelCgType.LoadSpine;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006D6E RID: 28014
		[Nullable(2)]
		protected IVisualNovelCgBase FbInstance;

		// Token: 0x04006D6F RID: 28015
		[Nullable(2)]
		protected IVisualNovelCgBase_SetValue PocoInterface;
	}
}
