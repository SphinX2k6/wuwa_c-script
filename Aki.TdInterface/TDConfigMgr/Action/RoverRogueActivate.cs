using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200217A RID: 8570
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverRogueActivate : ActionParams
	{
		// Token: 0x0600BC64 RID: 48228 RVA: 0x001B2600 File Offset: 0x001B0800
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

		// Token: 0x0600BC65 RID: 48229 RVA: 0x001B2638 File Offset: 0x001B0838
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

		// Token: 0x0600BC66 RID: 48230 RVA: 0x001B264B File Offset: 0x001B084B
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

		// Token: 0x0600BC67 RID: 48231 RVA: 0x001B265E File Offset: 0x001B085E
		public RoverRogueActivate_SetValue ToSetValue()
		{
			return new RoverRogueActivate_SetValue
			{
				InteractType = this.InteractType
			};
		}

		// Token: 0x1700395B RID: 14683
		// (get) Token: 0x0600BC68 RID: 48232 RVA: 0x001B2671 File Offset: 0x001B0871
		// (set) Token: 0x0600BC69 RID: 48233 RVA: 0x001B269C File Offset: 0x001B089C
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

		// Token: 0x04007085 RID: 28805
		[Nullable(2)]
		protected new RoverRogueActivate FbInstance;

		// Token: 0x04007086 RID: 28806
		[Nullable(2)]
		protected RoverRogueActivate_SetValue PocoInterface;
	}
}
