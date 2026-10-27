using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002065 RID: 8293
	[NullableContext(1)]
	[Nullable(0)]
	public class IVisualNovelCgLoadSpine : IVisualNovelCgBase
	{
		// Token: 0x0600B62C RID: 46636 RVA: 0x001A67B8 File Offset: 0x001A49B8
		private IVisualNovelCgLoadSpine_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVisualNovelCgLoadSpine 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVisualNovelCgLoadSpine_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVisualNovelCgLoadSpine_SetValue());
			}
			return result;
		}

		// Token: 0x0600B62D RID: 46637 RVA: 0x001A67F0 File Offset: 0x001A49F0
		public static IVisualNovelCgLoadSpine Create([Nullable(2)] IVisualNovelCgLoadSpine instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelCgLoadSpine
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B62E RID: 46638 RVA: 0x001A6803 File Offset: 0x001A4A03
		public static IVisualNovelCgLoadSpine CreateFromSetValue([Nullable(2)] IVisualNovelCgLoadSpine_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVisualNovelCgLoadSpine
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B62F RID: 46639 RVA: 0x001A6816 File Offset: 0x001A4A16
		public new IVisualNovelCgLoadSpine_SetValue ToSetValue()
		{
			return new IVisualNovelCgLoadSpine_SetValue
			{
				Type = this.Type,
				SpineId = this.SpineId
			};
		}

		// Token: 0x170037D7 RID: 14295
		// (get) Token: 0x0600B630 RID: 46640 RVA: 0x001A6835 File Offset: 0x001A4A35
		// (set) Token: 0x0600B631 RID: 46641 RVA: 0x001A6860 File Offset: 0x001A4A60
		public override EVisualNovelCgType Type
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

		// Token: 0x170037D8 RID: 14296
		// (get) Token: 0x0600B632 RID: 46642 RVA: 0x001A686E File Offset: 0x001A4A6E
		// (set) Token: 0x0600B633 RID: 46643 RVA: 0x001A6899 File Offset: 0x001A4A99
		public virtual int SpineId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SpineId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.SpineId;
			}
			set
			{
				this.GetOrCreatePoco().SpineId = value;
			}
		}

		// Token: 0x04006D78 RID: 28024
		[Nullable(2)]
		protected new IVisualNovelCgLoadSpine FbInstance;

		// Token: 0x04006D79 RID: 28025
		[Nullable(2)]
		protected new IVisualNovelCgLoadSpine_SetValue PocoInterface;
	}
}
