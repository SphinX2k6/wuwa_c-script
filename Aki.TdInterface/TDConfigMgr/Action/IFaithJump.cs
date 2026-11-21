using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BF2 RID: 7154
	public class IFaithJump : ILeisureInteractType
	{
		// Token: 0x060097E2 RID: 38882 RVA: 0x00160B1C File Offset: 0x0015ED1C
		private IFaithJump_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFaithJump 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFaithJump_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFaithJump_SetValue());
			}
			return result;
		}

		// Token: 0x060097E3 RID: 38883 RVA: 0x00160B54 File Offset: 0x0015ED54
		public static IFaithJump Create([Nullable(2)] IFaithJump instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFaithJump
			{
				FbInstance = instance
			};
		}

		// Token: 0x060097E4 RID: 38884 RVA: 0x00160B67 File Offset: 0x0015ED67
		public static IFaithJump CreateFromSetValue([Nullable(2)] IFaithJump_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFaithJump
			{
				PocoInterface = value
			};
		}

		// Token: 0x060097E5 RID: 38885 RVA: 0x00160B7A File Offset: 0x0015ED7A
		public new IFaithJump_SetValue ToSetValue()
		{
			return new IFaithJump_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003013 RID: 12307
		// (get) Token: 0x060097E6 RID: 38886 RVA: 0x00160B8D File Offset: 0x0015ED8D
		// (set) Token: 0x060097E7 RID: 38887 RVA: 0x00160BB8 File Offset: 0x0015EDB8
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

		// Token: 0x04005D9C RID: 23964
		[Nullable(2)]
		protected new IFaithJump FbInstance;

		// Token: 0x04005D9D RID: 23965
		[Nullable(2)]
		protected new IFaithJump_SetValue PocoInterface;
	}
}
