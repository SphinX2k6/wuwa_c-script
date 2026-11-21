using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020C8 RID: 8392
	public class ISoar2 : ILeisureInteractType
	{
		// Token: 0x0600B232 RID: 45618 RVA: 0x00190520 File Offset: 0x0018E720
		private ISoar2_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISoar2 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISoar2_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISoar2_SetValue());
			}
			return result;
		}

		// Token: 0x0600B233 RID: 45619 RVA: 0x00190558 File Offset: 0x0018E758
		public static ISoar2 Create([Nullable(2)] ISoar2 instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISoar2
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B234 RID: 45620 RVA: 0x0019056B File Offset: 0x0018E76B
		public static ISoar2 CreateFromSetValue([Nullable(2)] ISoar2_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISoar2
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B235 RID: 45621 RVA: 0x0019057E File Offset: 0x0018E77E
		public new ISoar2_SetValue ToSetValue()
		{
			return new ISoar2_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170035FC RID: 13820
		// (get) Token: 0x0600B236 RID: 45622 RVA: 0x00190591 File Offset: 0x0018E791
		// (set) Token: 0x0600B237 RID: 45623 RVA: 0x001905BC File Offset: 0x0018E7BC
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

		// Token: 0x040069C7 RID: 27079
		[Nullable(2)]
		protected new ISoar2 FbInstance;

		// Token: 0x040069C8 RID: 27080
		[Nullable(2)]
		protected new ISoar2_SetValue PocoInterface;
	}
}
