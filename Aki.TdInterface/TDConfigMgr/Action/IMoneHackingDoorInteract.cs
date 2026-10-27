using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BF2 RID: 7154
	[NullableContext(1)]
	[Nullable(0)]
	public class IMoneHackingDoorInteract : ILeisureInteractType
	{
		// Token: 0x06009937 RID: 39223 RVA: 0x00160B18 File Offset: 0x0015ED18
		private IMoneHackingDoorInteract_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMoneHackingDoorInteract 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMoneHackingDoorInteract_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMoneHackingDoorInteract_SetValue());
			}
			return result;
		}

		// Token: 0x06009938 RID: 39224 RVA: 0x00160B50 File Offset: 0x0015ED50
		public static IMoneHackingDoorInteract Create([Nullable(2)] IMoneHackingDoorInteract instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMoneHackingDoorInteract
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009939 RID: 39225 RVA: 0x00160B63 File Offset: 0x0015ED63
		public static IMoneHackingDoorInteract CreateFromSetValue([Nullable(2)] IMoneHackingDoorInteract_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMoneHackingDoorInteract
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600993A RID: 39226 RVA: 0x00160B76 File Offset: 0x0015ED76
		public new IMoneHackingDoorInteract_SetValue ToSetValue()
		{
			return new IMoneHackingDoorInteract_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003007 RID: 12295
		// (get) Token: 0x0600993B RID: 39227 RVA: 0x00160B89 File Offset: 0x0015ED89
		// (set) Token: 0x0600993C RID: 39228 RVA: 0x00160BB4 File Offset: 0x0015EDB4
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

		// Token: 0x04005D50 RID: 23888
		[Nullable(2)]
		protected new IMoneHackingDoorInteract FbInstance;

		// Token: 0x04005D51 RID: 23889
		[Nullable(2)]
		protected new IMoneHackingDoorInteract_SetValue PocoInterface;
	}
}
