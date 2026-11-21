using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DE1 RID: 7649
	public class IMoneHackingDoorInteract : ILeisureInteractType
	{
		// Token: 0x0600A265 RID: 41573 RVA: 0x00173A10 File Offset: 0x00171C10
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

		// Token: 0x0600A266 RID: 41574 RVA: 0x00173A48 File Offset: 0x00171C48
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

		// Token: 0x0600A267 RID: 41575 RVA: 0x00173A5B File Offset: 0x00171C5B
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

		// Token: 0x0600A268 RID: 41576 RVA: 0x00173A6E File Offset: 0x00171C6E
		public new IMoneHackingDoorInteract_SetValue ToSetValue()
		{
			return new IMoneHackingDoorInteract_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700326F RID: 12911
		// (get) Token: 0x0600A269 RID: 41577 RVA: 0x00173A81 File Offset: 0x00171C81
		// (set) Token: 0x0600A26A RID: 41578 RVA: 0x00173AAC File Offset: 0x00171CAC
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

		// Token: 0x04006276 RID: 25206
		[Nullable(2)]
		protected new IMoneHackingDoorInteract FbInstance;

		// Token: 0x04006277 RID: 25207
		[Nullable(2)]
		protected new IMoneHackingDoorInteract_SetValue PocoInterface;
	}
}
