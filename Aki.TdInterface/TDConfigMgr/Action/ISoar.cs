using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020C6 RID: 8390
	public class ISoar : ILeisureInteractType
	{
		// Token: 0x0600B22A RID: 45610 RVA: 0x00190464 File Offset: 0x0018E664
		private ISoar_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISoar 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISoar_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISoar_SetValue());
			}
			return result;
		}

		// Token: 0x0600B22B RID: 45611 RVA: 0x0019049C File Offset: 0x0018E69C
		public static ISoar Create([Nullable(2)] ISoar instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISoar
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B22C RID: 45612 RVA: 0x001904AF File Offset: 0x0018E6AF
		public static ISoar CreateFromSetValue([Nullable(2)] ISoar_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISoar
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B22D RID: 45613 RVA: 0x001904C2 File Offset: 0x0018E6C2
		public new ISoar_SetValue ToSetValue()
		{
			return new ISoar_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170035FB RID: 13819
		// (get) Token: 0x0600B22E RID: 45614 RVA: 0x001904D5 File Offset: 0x0018E6D5
		// (set) Token: 0x0600B22F RID: 45615 RVA: 0x00190500 File Offset: 0x0018E700
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

		// Token: 0x040069C4 RID: 27076
		[Nullable(2)]
		protected new ISoar FbInstance;

		// Token: 0x040069C5 RID: 27077
		[Nullable(2)]
		protected new ISoar_SetValue PocoInterface;
	}
}
