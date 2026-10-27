using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200206D RID: 8301
	[NullableContext(1)]
	[Nullable(0)]
	public class IVisualNovelDisplayItemClose : IVisualNovelDisplayItemBase
	{
		// Token: 0x0600B65A RID: 46682 RVA: 0x001A6D10 File Offset: 0x001A4F10
		private IVisualNovelDisplayItemClose_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVisualNovelDisplayItemClose 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVisualNovelDisplayItemClose_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVisualNovelDisplayItemClose_SetValue());
			}
			return result;
		}

		// Token: 0x0600B65B RID: 46683 RVA: 0x001A6D48 File Offset: 0x001A4F48
		public static IVisualNovelDisplayItemClose Create([Nullable(2)] IVisualNovelDisplayItemClose instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelDisplayItemClose
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B65C RID: 46684 RVA: 0x001A6D5B File Offset: 0x001A4F5B
		public static IVisualNovelDisplayItemClose CreateFromSetValue([Nullable(2)] IVisualNovelDisplayItemClose_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVisualNovelDisplayItemClose
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B65D RID: 46685 RVA: 0x001A6D6E File Offset: 0x001A4F6E
		public new IVisualNovelDisplayItemClose_SetValue ToSetValue()
		{
			return new IVisualNovelDisplayItemClose_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170037E2 RID: 14306
		// (get) Token: 0x0600B65E RID: 46686 RVA: 0x001A6D81 File Offset: 0x001A4F81
		// (set) Token: 0x0600B65F RID: 46687 RVA: 0x001A6DAC File Offset: 0x001A4FAC
		public override EVisualNovelDisplayItemType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EVisualNovelDisplayItemType.Image;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006D8D RID: 28045
		[Nullable(2)]
		protected new IVisualNovelDisplayItemClose FbInstance;

		// Token: 0x04006D8E RID: 28046
		[Nullable(2)]
		protected new IVisualNovelDisplayItemClose_SetValue PocoInterface;
	}
}
