using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A5D RID: 6749
	[NullableContext(1)]
	[Nullable(0)]
	public class IFaithJump : ILeisureInteractType
	{
		// Token: 0x06009078 RID: 36984 RVA: 0x00150BF0 File Offset: 0x0014EDF0
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

		// Token: 0x06009079 RID: 36985 RVA: 0x00150C28 File Offset: 0x0014EE28
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

		// Token: 0x0600907A RID: 36986 RVA: 0x00150C3B File Offset: 0x0014EE3B
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

		// Token: 0x0600907B RID: 36987 RVA: 0x00150C4E File Offset: 0x0014EE4E
		public new IFaithJump_SetValue ToSetValue()
		{
			return new IFaithJump_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002E06 RID: 11782
		// (get) Token: 0x0600907C RID: 36988 RVA: 0x00150C61 File Offset: 0x0014EE61
		// (set) Token: 0x0600907D RID: 36989 RVA: 0x00150C8C File Offset: 0x0014EE8C
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

		// Token: 0x04005937 RID: 22839
		[Nullable(2)]
		protected new IFaithJump FbInstance;

		// Token: 0x04005938 RID: 22840
		[Nullable(2)]
		protected new IFaithJump_SetValue PocoInterface;
	}
}
