using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021BF RID: 8639
	[NullableContext(1)]
	[Nullable(0)]
	public class SetJigsawFoundation : ActionParams
	{
		// Token: 0x0600BDC0 RID: 48576 RVA: 0x001B4FC8 File Offset: 0x001B31C8
		private SetJigsawFoundation_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SetJigsawFoundation 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SetJigsawFoundation_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SetJigsawFoundation_SetValue());
			}
			return result;
		}

		// Token: 0x0600BDC1 RID: 48577 RVA: 0x001B5000 File Offset: 0x001B3200
		public static SetJigsawFoundation Create([Nullable(2)] SetJigsawFoundation instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetJigsawFoundation
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BDC2 RID: 48578 RVA: 0x001B5013 File Offset: 0x001B3213
		public static SetJigsawFoundation CreateFromSetValue([Nullable(2)] SetJigsawFoundation_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SetJigsawFoundation
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BDC3 RID: 48579 RVA: 0x001B5026 File Offset: 0x001B3226
		public SetJigsawFoundation_SetValue ToSetValue()
		{
			return new SetJigsawFoundation_SetValue
			{
				Config = this.Config
			};
		}

		// Token: 0x170039A2 RID: 14754
		// (get) Token: 0x0600BDC4 RID: 48580 RVA: 0x001B503C File Offset: 0x001B323C
		// (set) Token: 0x0600BDC5 RID: 48581 RVA: 0x001B509D File Offset: 0x001B329D
		public virtual ISetPieceState Config
		{
			get
			{
				if (this._ConfigInited)
				{
					return this._ConfigCache;
				}
				this._ConfigInited = true;
				if (this.FbInstance != null)
				{
					this._ConfigCache = ISetPieceState.Create(this.FbInstance.Config);
				}
				else
				{
					SetJigsawFoundation_SetValue pocoInterface = this.PocoInterface;
					this._ConfigCache = ((pocoInterface != null) ? pocoInterface.Config : null);
				}
				return this._ConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().Config = value;
				this._ConfigInited = false;
			}
		}

		// Token: 0x0400713F RID: 28991
		[Nullable(2)]
		protected new SetJigsawFoundation FbInstance;

		// Token: 0x04007140 RID: 28992
		[Nullable(2)]
		protected SetJigsawFoundation_SetValue PocoInterface;

		// Token: 0x04007141 RID: 28993
		private ISetPieceState _ConfigCache;

		// Token: 0x04007142 RID: 28994
		private bool _ConfigInited;
	}
}
