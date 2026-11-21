using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200242A RID: 9258
	public class SetJigsawFoundation : ActionParams
	{
		// Token: 0x0600C97A RID: 51578 RVA: 0x001CC600 File Offset: 0x001CA800
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

		// Token: 0x0600C97B RID: 51579 RVA: 0x001CC638 File Offset: 0x001CA838
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

		// Token: 0x0600C97C RID: 51580 RVA: 0x001CC64B File Offset: 0x001CA84B
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

		// Token: 0x0600C97D RID: 51581 RVA: 0x001CC65E File Offset: 0x001CA85E
		public SetJigsawFoundation_SetValue ToSetValue()
		{
			return new SetJigsawFoundation_SetValue
			{
				Config = this.Config
			};
		}

		// Token: 0x17003C96 RID: 15510
		// (get) Token: 0x0600C97E RID: 51582 RVA: 0x001CC674 File Offset: 0x001CA874
		// (set) Token: 0x0600C97F RID: 51583 RVA: 0x001CC6D5 File Offset: 0x001CA8D5
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

		// Token: 0x04007787 RID: 30599
		[Nullable(2)]
		protected new SetJigsawFoundation FbInstance;

		// Token: 0x04007788 RID: 30600
		[Nullable(2)]
		protected SetJigsawFoundation_SetValue PocoInterface;

		// Token: 0x04007789 RID: 30601
		private ISetPieceState _ConfigCache;

		// Token: 0x0400778A RID: 30602
		private bool _ConfigInited;
	}
}
