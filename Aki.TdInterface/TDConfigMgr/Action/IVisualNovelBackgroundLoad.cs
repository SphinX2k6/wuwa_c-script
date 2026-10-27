using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200205D RID: 8285
	[NullableContext(1)]
	[Nullable(0)]
	public class IVisualNovelBackgroundLoad : IVisualNovelBackgroundBase
	{
		// Token: 0x0600B608 RID: 46600 RVA: 0x001A6440 File Offset: 0x001A4640
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

		// Token: 0x0600B609 RID: 46601 RVA: 0x001A6478 File Offset: 0x001A4678
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

		// Token: 0x0600B60A RID: 46602 RVA: 0x001A648B File Offset: 0x001A468B
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

		// Token: 0x0600B60B RID: 46603 RVA: 0x001A649E File Offset: 0x001A469E
		public new IVisualNovelBackgroundLoad_SetValue ToSetValue()
		{
			return new IVisualNovelBackgroundLoad_SetValue
			{
				Type = this.Type,
				BackgroundId = this.BackgroundId
			};
		}

		// Token: 0x170037D1 RID: 14289
		// (get) Token: 0x0600B60C RID: 46604 RVA: 0x001A64BD File Offset: 0x001A46BD
		// (set) Token: 0x0600B60D RID: 46605 RVA: 0x001A64E8 File Offset: 0x001A46E8
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

		// Token: 0x170037D2 RID: 14290
		// (get) Token: 0x0600B60E RID: 46606 RVA: 0x001A64F6 File Offset: 0x001A46F6
		// (set) Token: 0x0600B60F RID: 46607 RVA: 0x001A6521 File Offset: 0x001A4721
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

		// Token: 0x04006D6A RID: 28010
		[Nullable(2)]
		protected new IVisualNovelBackgroundLoad FbInstance;

		// Token: 0x04006D6B RID: 28011
		[Nullable(2)]
		protected new IVisualNovelBackgroundLoad_SetValue PocoInterface;
	}
}
