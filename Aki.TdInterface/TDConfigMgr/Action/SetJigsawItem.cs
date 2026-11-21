using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200242C RID: 9260
	public class SetJigsawItem : ActionParams
	{
		// Token: 0x0600C982 RID: 51586 RVA: 0x001CC6FC File Offset: 0x001CA8FC
		private SetJigsawItem_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SetJigsawItem 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SetJigsawItem_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SetJigsawItem_SetValue());
			}
			return result;
		}

		// Token: 0x0600C983 RID: 51587 RVA: 0x001CC734 File Offset: 0x001CA934
		public static SetJigsawItem Create([Nullable(2)] SetJigsawItem instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetJigsawItem
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C984 RID: 51588 RVA: 0x001CC747 File Offset: 0x001CA947
		public static SetJigsawItem CreateFromSetValue([Nullable(2)] SetJigsawItem_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SetJigsawItem
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C985 RID: 51589 RVA: 0x001CC75A File Offset: 0x001CA95A
		public SetJigsawItem_SetValue ToSetValue()
		{
			return new SetJigsawItem_SetValue
			{
				Config = this.Config
			};
		}

		// Token: 0x17003C97 RID: 15511
		// (get) Token: 0x0600C986 RID: 51590 RVA: 0x001CC770 File Offset: 0x001CA970
		// (set) Token: 0x0600C987 RID: 51591 RVA: 0x001CC7D1 File Offset: 0x001CA9D1
		public virtual IMoveJigsawItem Config
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
					this._ConfigCache = IMoveJigsawItem.Create(this.FbInstance.Config);
				}
				else
				{
					SetJigsawItem_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x0400778C RID: 30604
		[Nullable(2)]
		protected new SetJigsawItem FbInstance;

		// Token: 0x0400778D RID: 30605
		[Nullable(2)]
		protected SetJigsawItem_SetValue PocoInterface;

		// Token: 0x0400778E RID: 30606
		private IMoveJigsawItem _ConfigCache;

		// Token: 0x0400778F RID: 30607
		private bool _ConfigInited;
	}
}
