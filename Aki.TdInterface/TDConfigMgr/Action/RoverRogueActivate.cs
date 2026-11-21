using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023DB RID: 9179
	public class RoverRogueActivate : ActionParams
	{
		// Token: 0x0600C7F2 RID: 51186 RVA: 0x001C97B4 File Offset: 0x001C79B4
		private RoverRogueActivate_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("RoverRogueActivate 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			RoverRogueActivate_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new RoverRogueActivate_SetValue());
			}
			return result;
		}

		// Token: 0x0600C7F3 RID: 51187 RVA: 0x001C97EC File Offset: 0x001C79EC
		public static RoverRogueActivate Create([Nullable(2)] RoverRogueActivate instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RoverRogueActivate
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C7F4 RID: 51188 RVA: 0x001C97FF File Offset: 0x001C79FF
		public static RoverRogueActivate CreateFromSetValue([Nullable(2)] RoverRogueActivate_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new RoverRogueActivate
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C7F5 RID: 51189 RVA: 0x001C9812 File Offset: 0x001C7A12
		public RoverRogueActivate_SetValue ToSetValue()
		{
			return new RoverRogueActivate_SetValue
			{
				InteractType = this.InteractType
			};
		}

		// Token: 0x17003C48 RID: 15432
		// (get) Token: 0x0600C7F6 RID: 51190 RVA: 0x001C9825 File Offset: 0x001C7A25
		// (set) Token: 0x0600C7F7 RID: 51191 RVA: 0x001C9850 File Offset: 0x001C7A50
		public virtual ERoverRogueActivateType InteractType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.InteractType;
				}
				if (this.PocoInterface == null)
				{
					return ERoverRogueActivateType.Shop;
				}
				return this.PocoInterface.InteractType;
			}
			set
			{
				this.GetOrCreatePoco().InteractType = value;
			}
		}

		// Token: 0x040076BA RID: 30394
		[Nullable(2)]
		protected new RoverRogueActivate FbInstance;

		// Token: 0x040076BB RID: 30395
		[Nullable(2)]
		protected RoverRogueActivate_SetValue PocoInterface;
	}
}
