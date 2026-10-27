using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002071 RID: 8305
	[NullableContext(1)]
	[Nullable(0)]
	public class IVisualNovelDisplayItemPrefab : IVisualNovelDisplayItemBase
	{
		// Token: 0x0600B66C RID: 46700 RVA: 0x001A6ECC File Offset: 0x001A50CC
		private IVisualNovelDisplayItemPrefab_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVisualNovelDisplayItemPrefab 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVisualNovelDisplayItemPrefab_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVisualNovelDisplayItemPrefab_SetValue());
			}
			return result;
		}

		// Token: 0x0600B66D RID: 46701 RVA: 0x001A6F04 File Offset: 0x001A5104
		public static IVisualNovelDisplayItemPrefab Create([Nullable(2)] IVisualNovelDisplayItemPrefab instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelDisplayItemPrefab
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B66E RID: 46702 RVA: 0x001A6F17 File Offset: 0x001A5117
		public static IVisualNovelDisplayItemPrefab CreateFromSetValue([Nullable(2)] IVisualNovelDisplayItemPrefab_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVisualNovelDisplayItemPrefab
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B66F RID: 46703 RVA: 0x001A6F2A File Offset: 0x001A512A
		public new IVisualNovelDisplayItemPrefab_SetValue ToSetValue()
		{
			return new IVisualNovelDisplayItemPrefab_SetValue
			{
				Type = this.Type,
				PrefabId = this.PrefabId
			};
		}

		// Token: 0x170037E5 RID: 14309
		// (get) Token: 0x0600B670 RID: 46704 RVA: 0x001A6F49 File Offset: 0x001A5149
		// (set) Token: 0x0600B671 RID: 46705 RVA: 0x001A6F74 File Offset: 0x001A5174
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

		// Token: 0x170037E6 RID: 14310
		// (get) Token: 0x0600B672 RID: 46706 RVA: 0x001A6F82 File Offset: 0x001A5182
		// (set) Token: 0x0600B673 RID: 46707 RVA: 0x001A6FAD File Offset: 0x001A51AD
		public virtual int PrefabId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PrefabId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.PrefabId;
			}
			set
			{
				this.GetOrCreatePoco().PrefabId = value;
			}
		}

		// Token: 0x04006D94 RID: 28052
		[Nullable(2)]
		protected new IVisualNovelDisplayItemPrefab FbInstance;

		// Token: 0x04006D95 RID: 28053
		[Nullable(2)]
		protected new IVisualNovelDisplayItemPrefab_SetValue PocoInterface;
	}
}
