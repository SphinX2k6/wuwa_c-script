using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FDF RID: 8159
	public class IRogueRoleSelectRoom : IRogueSelectRoomType
	{
		// Token: 0x0600AD55 RID: 44373 RVA: 0x00187568 File Offset: 0x00185768
		private IRogueRoleSelectRoom_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRogueRoleSelectRoom 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRogueRoleSelectRoom_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRogueRoleSelectRoom_SetValue());
			}
			return result;
		}

		// Token: 0x0600AD56 RID: 44374 RVA: 0x001875A0 File Offset: 0x001857A0
		public static IRogueRoleSelectRoom Create([Nullable(2)] IRogueRoleSelectRoom instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRogueRoleSelectRoom
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AD57 RID: 44375 RVA: 0x001875B3 File Offset: 0x001857B3
		public static IRogueRoleSelectRoom CreateFromSetValue([Nullable(2)] IRogueRoleSelectRoom_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRogueRoleSelectRoom
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AD58 RID: 44376 RVA: 0x001875C6 File Offset: 0x001857C6
		public new IRogueRoleSelectRoom_SetValue ToSetValue()
		{
			return new IRogueRoleSelectRoom_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170034EA RID: 13546
		// (get) Token: 0x0600AD59 RID: 44377 RVA: 0x001875D9 File Offset: 0x001857D9
		// (set) Token: 0x0600AD5A RID: 44378 RVA: 0x00187604 File Offset: 0x00185804
		public override ERogueSelectRoomType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ERogueSelectRoomType.Role;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006777 RID: 26487
		[Nullable(2)]
		protected new IRogueRoleSelectRoom FbInstance;

		// Token: 0x04006778 RID: 26488
		[Nullable(2)]
		protected new IRogueRoleSelectRoom_SetValue PocoInterface;
	}
}
