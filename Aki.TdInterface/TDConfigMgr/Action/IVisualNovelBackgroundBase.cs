using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002059 RID: 8281
	[NullableContext(1)]
	[Nullable(0)]
	public class IVisualNovelBackgroundBase
	{
		// Token: 0x0600B5F8 RID: 46584 RVA: 0x001A62C8 File Offset: 0x001A44C8
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

		// Token: 0x0600B5F9 RID: 46585 RVA: 0x001A6300 File Offset: 0x001A4500
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

		// Token: 0x0600B5FA RID: 46586 RVA: 0x001A6313 File Offset: 0x001A4513
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

		// Token: 0x0600B5FB RID: 46587 RVA: 0x001A6326 File Offset: 0x001A4526
		public IVisualNovelBackgroundBase_SetValue ToSetValue()
		{
			return new IVisualNovelBackgroundBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170037CF RID: 14287
		// (get) Token: 0x0600B5FC RID: 46588 RVA: 0x001A6339 File Offset: 0x001A4539
		// (set) Token: 0x0600B5FD RID: 46589 RVA: 0x001A6364 File Offset: 0x001A4564
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

		// Token: 0x04006D64 RID: 28004
		[Nullable(2)]
		protected IVisualNovelBackgroundBase FbInstance;

		// Token: 0x04006D65 RID: 28005
		[Nullable(2)]
		protected IVisualNovelBackgroundBase_SetValue PocoInterface;
	}
}
