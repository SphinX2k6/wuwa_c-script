using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022A6 RID: 8870
	public class IVisualNovelBackgroundLoad : IVisualNovelBackgroundBase
	{
		// Token: 0x0600C12E RID: 49454 RVA: 0x001BCBAC File Offset: 0x001BADAC
		private IVisualNovelBackgroundLoad_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVisualNovelBackgroundLoad 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVisualNovelBackgroundLoad_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVisualNovelBackgroundLoad_SetValue());
			}
			return result;
		}

		// Token: 0x0600C12F RID: 49455 RVA: 0x001BCBE4 File Offset: 0x001BADE4
		public static IVisualNovelBackgroundLoad Create([Nullable(2)] IVisualNovelBackgroundLoad instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelBackgroundLoad
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C130 RID: 49456 RVA: 0x001BCBF7 File Offset: 0x001BADF7
		public static IVisualNovelBackgroundLoad CreateFromSetValue([Nullable(2)] IVisualNovelBackgroundLoad_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVisualNovelBackgroundLoad
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C131 RID: 49457 RVA: 0x001BCC0A File Offset: 0x001BAE0A
		public new IVisualNovelBackgroundLoad_SetValue ToSetValue()
		{
			return new IVisualNovelBackgroundLoad_SetValue
			{
				Type = this.Type,
				BackgroundId = this.BackgroundId
			};
		}

		// Token: 0x17003AAE RID: 15022
		// (get) Token: 0x0600C132 RID: 49458 RVA: 0x001BCC29 File Offset: 0x001BAE29
		// (set) Token: 0x0600C133 RID: 49459 RVA: 0x001BCC54 File Offset: 0x001BAE54
		public override EVisualNovelBackgroundType Type
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

		// Token: 0x17003AAF RID: 15023
		// (get) Token: 0x0600C134 RID: 49460 RVA: 0x001BCC62 File Offset: 0x001BAE62
		// (set) Token: 0x0600C135 RID: 49461 RVA: 0x001BCC8D File Offset: 0x001BAE8D
		public virtual int BackgroundId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BackgroundId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.BackgroundId;
			}
			set
			{
				this.GetOrCreatePoco().BackgroundId = value;
			}
		}

		// Token: 0x04007373 RID: 29555
		[Nullable(2)]
		protected new IVisualNovelBackgroundLoad FbInstance;

		// Token: 0x04007374 RID: 29556
		[Nullable(2)]
		protected new IVisualNovelBackgroundLoad_SetValue PocoInterface;
	}
}
