using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200117B RID: 4475
	public class IPhotoTarget
	{
		// Token: 0x0600636C RID: 25452 RVA: 0x000EF478 File Offset: 0x000ED678
		private IPhotoTarget_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPhotoTarget 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPhotoTarget_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPhotoTarget_SetValue());
			}
			return result;
		}

		// Token: 0x0600636D RID: 25453 RVA: 0x000EF4B0 File Offset: 0x000ED6B0
		public static IPhotoTarget Create([Nullable(2)] IPhotoTarget instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPhotoTarget
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600636E RID: 25454 RVA: 0x000EF4C3 File Offset: 0x000ED6C3
		public static IPhotoTarget CreateFromSetValue([Nullable(2)] IPhotoTarget_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPhotoTarget
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600636F RID: 25455 RVA: 0x000EF4D8 File Offset: 0x000ED6D8
		public IPhotoTarget_SetValue ToSetValue()
		{
			return new IPhotoTarget_SetValue
			{
				EntityId = this.EntityId,
				TidDescription = this.TidDescription,
				IsOptionalTarget = this.IsOptionalTarget,
				SetVar = this.SetVar,
				EdTidDescription = this.EdTidDescription
			};
		}

		// Token: 0x1700207A RID: 8314
		// (get) Token: 0x06006370 RID: 25456 RVA: 0x000EF526 File Offset: 0x000ED726
		// (set) Token: 0x06006371 RID: 25457 RVA: 0x000EF551 File Offset: 0x000ED751
		public virtual int EntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EntityId;
			}
			set
			{
				this.GetOrCreatePoco().EntityId = value;
			}
		}

		// Token: 0x1700207B RID: 8315
		// (get) Token: 0x06006372 RID: 25458 RVA: 0x000EF55F File Offset: 0x000ED75F
		// (set) Token: 0x06006373 RID: 25459 RVA: 0x000EF58A File Offset: 0x000ED78A
		public virtual string TidDescription
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TidDescription;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.TidDescription;
			}
			set
			{
				this.GetOrCreatePoco().TidDescription = value;
			}
		}

		// Token: 0x1700207C RID: 8316
		// (get) Token: 0x06006374 RID: 25460 RVA: 0x000EF598 File Offset: 0x000ED798
		// (set) Token: 0x06006375 RID: 25461 RVA: 0x000EF5D2 File Offset: 0x000ED7D2
		public virtual bool? IsOptionalTarget
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsOptionalTarget;
				}
				IPhotoTarget_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsOptionalTarget;
			}
			set
			{
				this.GetOrCreatePoco().IsOptionalTarget = value;
			}
		}

		// Token: 0x1700207D RID: 8317
		// (get) Token: 0x06006376 RID: 25462 RVA: 0x000EF5E0 File Offset: 0x000ED7E0
		// (set) Token: 0x06006377 RID: 25463 RVA: 0x000EF641 File Offset: 0x000ED841
		[Nullable(2)]
		public virtual SetVar SetVar
		{
			[NullableContext(2)]
			get
			{
				if (this._SetVarInited)
				{
					return this._SetVarCache;
				}
				this._SetVarInited = true;
				if (this.FbInstance != null)
				{
					this._SetVarCache = SetVar.Create(this.FbInstance.SetVar);
				}
				else
				{
					IPhotoTarget_SetValue pocoInterface = this.PocoInterface;
					this._SetVarCache = ((pocoInterface != null) ? pocoInterface.SetVar : null);
				}
				return this._SetVarCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().SetVar = value;
				this._SetVarInited = false;
			}
		}

		// Token: 0x1700207E RID: 8318
		// (get) Token: 0x06006378 RID: 25464 RVA: 0x000EF656 File Offset: 0x000ED856
		// (set) Token: 0x06006379 RID: 25465 RVA: 0x000EF66D File Offset: 0x000ED86D
		[Nullable(2)]
		public virtual string EdTidDescription
		{
			[NullableContext(2)]
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdTidDescription;
				}
				return null;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().EdTidDescription = value;
			}
		}

		// Token: 0x04003B90 RID: 15248
		[Nullable(2)]
		protected IPhotoTarget FbInstance;

		// Token: 0x04003B91 RID: 15249
		[Nullable(2)]
		protected IPhotoTarget_SetValue PocoInterface;

		// Token: 0x04003B92 RID: 15250
		private SetVar _SetVarCache;

		// Token: 0x04003B93 RID: 15251
		private bool _SetVarInited;
	}
}
