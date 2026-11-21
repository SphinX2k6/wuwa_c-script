using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022BA RID: 8890
	public class IVisualNovelDisplayItemPrefab : IVisualNovelDisplayItemBase
	{
		// Token: 0x0600C198 RID: 49560 RVA: 0x001BD724 File Offset: 0x001BB924
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

		// Token: 0x0600C199 RID: 49561 RVA: 0x001BD75C File Offset: 0x001BB95C
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

		// Token: 0x0600C19A RID: 49562 RVA: 0x001BD76F File Offset: 0x001BB96F
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

		// Token: 0x0600C19B RID: 49563 RVA: 0x001BD782 File Offset: 0x001BB982
		public new IVisualNovelDisplayItemPrefab_SetValue ToSetValue()
		{
			return new IVisualNovelDisplayItemPrefab_SetValue
			{
				Type = this.Type,
				PrefabId = this.PrefabId
			};
		}

		// Token: 0x17003AC5 RID: 15045
		// (get) Token: 0x0600C19C RID: 49564 RVA: 0x001BD7A1 File Offset: 0x001BB9A1
		// (set) Token: 0x0600C19D RID: 49565 RVA: 0x001BD7CC File Offset: 0x001BB9CC
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

		// Token: 0x17003AC6 RID: 15046
		// (get) Token: 0x0600C19E RID: 49566 RVA: 0x001BD7DA File Offset: 0x001BB9DA
		// (set) Token: 0x0600C19F RID: 49567 RVA: 0x001BD805 File Offset: 0x001BBA05
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

		// Token: 0x040073A0 RID: 29600
		[Nullable(2)]
		protected new IVisualNovelDisplayItemPrefab FbInstance;

		// Token: 0x040073A1 RID: 29601
		[Nullable(2)]
		protected new IVisualNovelDisplayItemPrefab_SetValue PocoInterface;
	}
}
