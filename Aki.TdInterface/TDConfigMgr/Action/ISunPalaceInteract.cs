using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200212A RID: 8490
	public class ISunPalaceInteract : ILeisureInteractType
	{
		// Token: 0x0600B43C RID: 46140 RVA: 0x00193FF4 File Offset: 0x001921F4
		private ISunPalaceInteract_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISunPalaceInteract 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISunPalaceInteract_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISunPalaceInteract_SetValue());
			}
			return result;
		}

		// Token: 0x0600B43D RID: 46141 RVA: 0x0019402C File Offset: 0x0019222C
		public static ISunPalaceInteract Create([Nullable(2)] ISunPalaceInteract instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISunPalaceInteract
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B43E RID: 46142 RVA: 0x0019403F File Offset: 0x0019223F
		public static ISunPalaceInteract CreateFromSetValue([Nullable(2)] ISunPalaceInteract_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISunPalaceInteract
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B43F RID: 46143 RVA: 0x00194052 File Offset: 0x00192252
		public new ISunPalaceInteract_SetValue ToSetValue()
		{
			return new ISunPalaceInteract_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700366E RID: 13934
		// (get) Token: 0x0600B440 RID: 46144 RVA: 0x00194065 File Offset: 0x00192265
		// (set) Token: 0x0600B441 RID: 46145 RVA: 0x00194090 File Offset: 0x00192290
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

		// Token: 0x04006AB9 RID: 27321
		[Nullable(2)]
		protected new ISunPalaceInteract FbInstance;

		// Token: 0x04006ABA RID: 27322
		[Nullable(2)]
		protected new ISunPalaceInteract_SetValue PocoInterface;
	}
}
