using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002061 RID: 8289
	[NullableContext(1)]
	[Nullable(0)]
	public class IVisualNovelCgClean : IVisualNovelCgBase
	{
		// Token: 0x0600B61A RID: 46618 RVA: 0x001A65FC File Offset: 0x001A47FC
		private IVisualNovelCgClean_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVisualNovelCgClean 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVisualNovelCgClean_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVisualNovelCgClean_SetValue());
			}
			return result;
		}

		// Token: 0x0600B61B RID: 46619 RVA: 0x001A6634 File Offset: 0x001A4834
		public static IVisualNovelCgClean Create([Nullable(2)] IVisualNovelCgClean instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelCgClean
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B61C RID: 46620 RVA: 0x001A6647 File Offset: 0x001A4847
		public static IVisualNovelCgClean CreateFromSetValue([Nullable(2)] IVisualNovelCgClean_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVisualNovelCgClean
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B61D RID: 46621 RVA: 0x001A665A File Offset: 0x001A485A
		public new IVisualNovelCgClean_SetValue ToSetValue()
		{
			return new IVisualNovelCgClean_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170037D4 RID: 14292
		// (get) Token: 0x0600B61E RID: 46622 RVA: 0x001A666D File Offset: 0x001A486D
		// (set) Token: 0x0600B61F RID: 46623 RVA: 0x001A6698 File Offset: 0x001A4898
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

		// Token: 0x04006D71 RID: 28017
		[Nullable(2)]
		protected new IVisualNovelCgClean FbInstance;

		// Token: 0x04006D72 RID: 28018
		[Nullable(2)]
		protected new IVisualNovelCgClean_SetValue PocoInterface;
	}
}
