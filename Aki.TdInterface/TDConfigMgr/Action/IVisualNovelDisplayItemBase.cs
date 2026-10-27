using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200206B RID: 8299
	[NullableContext(1)]
	[Nullable(0)]
	public class IVisualNovelDisplayItemBase
	{
		// Token: 0x0600B652 RID: 46674 RVA: 0x001A6C54 File Offset: 0x001A4E54
		private IVisualNovelDisplayItemBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVisualNovelDisplayItemBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVisualNovelDisplayItemBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVisualNovelDisplayItemBase_SetValue());
			}
			return result;
		}

		// Token: 0x0600B653 RID: 46675 RVA: 0x001A6C8C File Offset: 0x001A4E8C
		public static IVisualNovelDisplayItemBase Create([Nullable(2)] IVisualNovelDisplayItemBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelDisplayItemBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B654 RID: 46676 RVA: 0x001A6C9F File Offset: 0x001A4E9F
		public static IVisualNovelDisplayItemBase CreateFromSetValue([Nullable(2)] IVisualNovelDisplayItemBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVisualNovelDisplayItemBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B655 RID: 46677 RVA: 0x001A6CB2 File Offset: 0x001A4EB2
		public IVisualNovelDisplayItemBase_SetValue ToSetValue()
		{
			return new IVisualNovelDisplayItemBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170037E1 RID: 14305
		// (get) Token: 0x0600B656 RID: 46678 RVA: 0x001A6CC5 File Offset: 0x001A4EC5
		// (set) Token: 0x0600B657 RID: 46679 RVA: 0x001A6CF0 File Offset: 0x001A4EF0
		public virtual EVisualNovelDisplayItemType Type
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

		// Token: 0x04006D8A RID: 28042
		[Nullable(2)]
		protected IVisualNovelDisplayItemBase FbInstance;

		// Token: 0x04006D8B RID: 28043
		[Nullable(2)]
		protected IVisualNovelDisplayItemBase_SetValue PocoInterface;
	}
}
