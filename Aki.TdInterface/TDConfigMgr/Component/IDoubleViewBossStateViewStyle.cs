using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000314 RID: 788
	public class IDoubleViewBossStateViewStyle : IBossStateViewStyle
	{
		// Token: 0x06000EB1 RID: 3761 RVA: 0x00035334 File Offset: 0x00033534
		private IDoubleViewBossStateViewStyle_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDoubleViewBossStateViewStyle 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDoubleViewBossStateViewStyle_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDoubleViewBossStateViewStyle_SetValue());
			}
			return result;
		}

		// Token: 0x06000EB2 RID: 3762 RVA: 0x0003536C File Offset: 0x0003356C
		public static IDoubleViewBossStateViewStyle Create([Nullable(2)] IDoubleViewBossStateViewStyle instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDoubleViewBossStateViewStyle
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000EB3 RID: 3763 RVA: 0x0003537F File Offset: 0x0003357F
		public static IDoubleViewBossStateViewStyle CreateFromSetValue([Nullable(2)] IDoubleViewBossStateViewStyle_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDoubleViewBossStateViewStyle
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000EB4 RID: 3764 RVA: 0x00035392 File Offset: 0x00033592
		public new IDoubleViewBossStateViewStyle_SetValue ToSetValue()
		{
			return new IDoubleViewBossStateViewStyle_SetValue
			{
				Type = this.Type,
				Slot = this.Slot,
				MainStateTextTarget = this.MainStateTextTarget,
				BindMonsterEntityId = this.BindMonsterEntityId
			};
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06000EB5 RID: 3765 RVA: 0x000353C9 File Offset: 0x000335C9
		// (set) Token: 0x06000EB6 RID: 3766 RVA: 0x000353F4 File Offset: 0x000335F4
		public override EBossStateViewStyle Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EBossStateViewStyle.DoubleView;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06000EB7 RID: 3767 RVA: 0x00035402 File Offset: 0x00033602
		// (set) Token: 0x06000EB8 RID: 3768 RVA: 0x0003542D File Offset: 0x0003362D
		public virtual EDoubleViewSlot Slot
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Slot;
				}
				if (this.PocoInterface == null)
				{
					return EDoubleViewSlot.Left;
				}
				return this.PocoInterface.Slot;
			}
			set
			{
				this.GetOrCreatePoco().Slot = value;
			}
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06000EB9 RID: 3769 RVA: 0x0003543C File Offset: 0x0003363C
		// (set) Token: 0x06000EBA RID: 3770 RVA: 0x0003549D File Offset: 0x0003369D
		[Nullable(2)]
		public virtual IMarkMainStateTextTarget MainStateTextTarget
		{
			[NullableContext(2)]
			get
			{
				if (this._MainStateTextTargetInited)
				{
					return this._MainStateTextTargetCache;
				}
				this._MainStateTextTargetInited = true;
				if (this.FbInstance != null)
				{
					this._MainStateTextTargetCache = IMarkMainStateTextTarget.Create(this.FbInstance.MainStateTextTarget);
				}
				else
				{
					IDoubleViewBossStateViewStyle_SetValue pocoInterface = this.PocoInterface;
					this._MainStateTextTargetCache = ((pocoInterface != null) ? pocoInterface.MainStateTextTarget : null);
				}
				return this._MainStateTextTargetCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().MainStateTextTarget = value;
				this._MainStateTextTargetInited = false;
			}
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x06000EBB RID: 3771 RVA: 0x000354B4 File Offset: 0x000336B4
		// (set) Token: 0x06000EBC RID: 3772 RVA: 0x000354EE File Offset: 0x000336EE
		public virtual int? BindMonsterEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BindMonsterEntityId;
				}
				IDoubleViewBossStateViewStyle_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.BindMonsterEntityId;
			}
			set
			{
				this.GetOrCreatePoco().BindMonsterEntityId = value;
			}
		}

		// Token: 0x04000D21 RID: 3361
		[Nullable(2)]
		protected new IDoubleViewBossStateViewStyle FbInstance;

		// Token: 0x04000D22 RID: 3362
		[Nullable(2)]
		protected new IDoubleViewBossStateViewStyle_SetValue PocoInterface;

		// Token: 0x04000D23 RID: 3363
		private IMarkMainStateTextTarget _MainStateTextTargetCache;

		// Token: 0x04000D24 RID: 3364
		private bool _MainStateTextTargetInited;
	}
}
