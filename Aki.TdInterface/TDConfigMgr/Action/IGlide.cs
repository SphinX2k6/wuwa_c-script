using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C7C RID: 7292
	public class IGlide : ILeisureInteractType
	{
		// Token: 0x06009AFA RID: 39674 RVA: 0x00166510 File Offset: 0x00164710
		private IGlide_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IGlide 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IGlide_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IGlide_SetValue());
			}
			return result;
		}

		// Token: 0x06009AFB RID: 39675 RVA: 0x00166548 File Offset: 0x00164748
		public static IGlide Create([Nullable(2)] IGlide instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGlide
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009AFC RID: 39676 RVA: 0x0016655B File Offset: 0x0016475B
		public static IGlide CreateFromSetValue([Nullable(2)] IGlide_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IGlide
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009AFD RID: 39677 RVA: 0x0016656E File Offset: 0x0016476E
		public new IGlide_SetValue ToSetValue()
		{
			return new IGlide_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170030D0 RID: 12496
		// (get) Token: 0x06009AFE RID: 39678 RVA: 0x00166581 File Offset: 0x00164781
		// (set) Token: 0x06009AFF RID: 39679 RVA: 0x001665AC File Offset: 0x001647AC
		public override ELeisureInteract Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELeisureInteract.CustomSkill;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005F0F RID: 24335
		[Nullable(2)]
		protected new IGlide FbInstance;

		// Token: 0x04005F10 RID: 24336
		[Nullable(2)]
		protected new IGlide_SetValue PocoInterface;
	}
}
