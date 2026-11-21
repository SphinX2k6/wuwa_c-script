using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020EC RID: 8428
	public class IStandControl2 : ILeisureInteractType
	{
		// Token: 0x0600B2EA RID: 45802 RVA: 0x00191A08 File Offset: 0x0018FC08
		private IStandControl2_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IStandControl2 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IStandControl2_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IStandControl2_SetValue());
			}
			return result;
		}

		// Token: 0x0600B2EB RID: 45803 RVA: 0x00191A40 File Offset: 0x0018FC40
		public static IStandControl2 Create([Nullable(2)] IStandControl2 instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStandControl2
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B2EC RID: 45804 RVA: 0x00191A53 File Offset: 0x0018FC53
		public static IStandControl2 CreateFromSetValue([Nullable(2)] IStandControl2_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IStandControl2
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B2ED RID: 45805 RVA: 0x00191A66 File Offset: 0x0018FC66
		public new IStandControl2_SetValue ToSetValue()
		{
			return new IStandControl2_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003622 RID: 13858
		// (get) Token: 0x0600B2EE RID: 45806 RVA: 0x00191A79 File Offset: 0x0018FC79
		// (set) Token: 0x0600B2EF RID: 45807 RVA: 0x00191AA4 File Offset: 0x0018FCA4
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

		// Token: 0x04006A1D RID: 27165
		[Nullable(2)]
		protected new IStandControl2 FbInstance;

		// Token: 0x04006A1E RID: 27166
		[Nullable(2)]
		protected new IStandControl2_SetValue PocoInterface;
	}
}
