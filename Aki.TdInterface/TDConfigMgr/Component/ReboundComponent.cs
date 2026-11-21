using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200090A RID: 2314
	public class ReboundComponent : IComponentBase
	{
		// Token: 0x060032D9 RID: 13017 RVA: 0x00082294 File Offset: 0x00080494
		private ReboundComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ReboundComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ReboundComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ReboundComponent_SetValue());
			}
			return result;
		}

		// Token: 0x060032DA RID: 13018 RVA: 0x000822CC File Offset: 0x000804CC
		public static ReboundComponent Create([Nullable(2)] ReboundComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ReboundComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x060032DB RID: 13019 RVA: 0x000822DF File Offset: 0x000804DF
		public static ReboundComponent CreateFromSetValue([Nullable(2)] ReboundComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ReboundComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x060032DC RID: 13020 RVA: 0x000822F2 File Offset: 0x000804F2
		public new ReboundComponent_SetValue ToSetValue()
		{
			return new ReboundComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				BulletId = this.BulletId,
				Option = this.Option
			};
		}

		// Token: 0x17000D60 RID: 3424
		// (get) Token: 0x060032DD RID: 13021 RVA: 0x0008232C File Offset: 0x0008052C
		// (set) Token: 0x060032DE RID: 13022 RVA: 0x00082366 File Offset: 0x00080566
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				ReboundComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x17000D61 RID: 3425
		// (get) Token: 0x060032DF RID: 13023 RVA: 0x00082374 File Offset: 0x00080574
		// (set) Token: 0x060032E0 RID: 13024 RVA: 0x0008239E File Offset: 0x0008059E
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x17000D62 RID: 3426
		// (get) Token: 0x060032E1 RID: 13025 RVA: 0x000823AC File Offset: 0x000805AC
		// (set) Token: 0x060032E2 RID: 13026 RVA: 0x000823D8 File Offset: 0x000805D8
		public virtual long BulletId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BulletId;
				}
				if (this.PocoInterface == null)
				{
					return 0L;
				}
				return this.PocoInterface.BulletId;
			}
			set
			{
				this.GetOrCreatePoco().BulletId = value;
			}
		}

		// Token: 0x17000D63 RID: 3427
		// (get) Token: 0x060032E3 RID: 13027 RVA: 0x000823E8 File Offset: 0x000805E8
		// (set) Token: 0x060032E4 RID: 13028 RVA: 0x00082449 File Offset: 0x00080649
		public virtual IForwardFrontRebound Option
		{
			get
			{
				if (this._OptionInited)
				{
					return this._OptionCache;
				}
				this._OptionInited = true;
				if (this.FbInstance != null)
				{
					this._OptionCache = IForwardFrontRebound.Create(this.FbInstance.Option);
				}
				else
				{
					ReboundComponent_SetValue pocoInterface = this.PocoInterface;
					this._OptionCache = ((pocoInterface != null) ? pocoInterface.Option : null);
				}
				return this._OptionCache;
			}
			set
			{
				this.GetOrCreatePoco().Option = value;
				this._OptionInited = false;
			}
		}

		// Token: 0x0400217B RID: 8571
		[Nullable(2)]
		protected new ReboundComponent FbInstance;

		// Token: 0x0400217C RID: 8572
		[Nullable(2)]
		protected new ReboundComponent_SetValue PocoInterface;

		// Token: 0x0400217D RID: 8573
		private IForwardFrontRebound _OptionCache;

		// Token: 0x0400217E RID: 8574
		private bool _OptionInited;
	}
}
