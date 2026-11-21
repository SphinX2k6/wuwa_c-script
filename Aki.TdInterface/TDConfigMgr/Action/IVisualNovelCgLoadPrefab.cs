using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022AE RID: 8878
	public class IVisualNovelCgLoadPrefab : IVisualNovelCgBase
	{
		// Token: 0x0600C152 RID: 49490 RVA: 0x001BCF24 File Offset: 0x001BB124
		private IVisualNovelCgLoadPrefab_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVisualNovelCgLoadPrefab 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVisualNovelCgLoadPrefab_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVisualNovelCgLoadPrefab_SetValue());
			}
			return result;
		}

		// Token: 0x0600C153 RID: 49491 RVA: 0x001BCF5C File Offset: 0x001BB15C
		public static IVisualNovelCgLoadPrefab Create([Nullable(2)] IVisualNovelCgLoadPrefab instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelCgLoadPrefab
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C154 RID: 49492 RVA: 0x001BCF6F File Offset: 0x001BB16F
		public static IVisualNovelCgLoadPrefab CreateFromSetValue([Nullable(2)] IVisualNovelCgLoadPrefab_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVisualNovelCgLoadPrefab
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C155 RID: 49493 RVA: 0x001BCF82 File Offset: 0x001BB182
		public new IVisualNovelCgLoadPrefab_SetValue ToSetValue()
		{
			return new IVisualNovelCgLoadPrefab_SetValue
			{
				Type = this.Type,
				PrefabId = this.PrefabId,
				AnimationName = this.AnimationName
			};
		}

		// Token: 0x17003AB4 RID: 15028
		// (get) Token: 0x0600C156 RID: 49494 RVA: 0x001BCFAD File Offset: 0x001BB1AD
		// (set) Token: 0x0600C157 RID: 49495 RVA: 0x001BCFD8 File Offset: 0x001BB1D8
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
					return EVisualNovelCgType.LoadPrefab;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003AB5 RID: 15029
		// (get) Token: 0x0600C158 RID: 49496 RVA: 0x001BCFE6 File Offset: 0x001BB1E6
		// (set) Token: 0x0600C159 RID: 49497 RVA: 0x001BD011 File Offset: 0x001BB211
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

		// Token: 0x17003AB6 RID: 15030
		// (get) Token: 0x0600C15A RID: 49498 RVA: 0x001BD01F File Offset: 0x001BB21F
		// (set) Token: 0x0600C15B RID: 49499 RVA: 0x001BD04A File Offset: 0x001BB24A
		public virtual string AnimationName
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AnimationName;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.AnimationName;
			}
			set
			{
				this.GetOrCreatePoco().AnimationName = value;
			}
		}

		// Token: 0x04007381 RID: 29569
		[Nullable(2)]
		protected new IVisualNovelCgLoadPrefab FbInstance;

		// Token: 0x04007382 RID: 29570
		[Nullable(2)]
		protected new IVisualNovelCgLoadPrefab_SetValue PocoInterface;
	}
}
