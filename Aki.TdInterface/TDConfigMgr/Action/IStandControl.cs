using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020EA RID: 8426
	public class IStandControl : ILeisureInteractType
	{
		// Token: 0x0600B2E2 RID: 45794 RVA: 0x0019194C File Offset: 0x0018FB4C
		private IStandControl_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IStandControl 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IStandControl_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IStandControl_SetValue());
			}
			return result;
		}

		// Token: 0x0600B2E3 RID: 45795 RVA: 0x00191984 File Offset: 0x0018FB84
		public static IStandControl Create([Nullable(2)] IStandControl instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStandControl
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B2E4 RID: 45796 RVA: 0x00191997 File Offset: 0x0018FB97
		public static IStandControl CreateFromSetValue([Nullable(2)] IStandControl_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IStandControl
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B2E5 RID: 45797 RVA: 0x001919AA File Offset: 0x0018FBAA
		public new IStandControl_SetValue ToSetValue()
		{
			return new IStandControl_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003621 RID: 13857
		// (get) Token: 0x0600B2E6 RID: 45798 RVA: 0x001919BD File Offset: 0x0018FBBD
		// (set) Token: 0x0600B2E7 RID: 45799 RVA: 0x001919E8 File Offset: 0x0018FBE8
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

		// Token: 0x04006A1A RID: 27162
		[Nullable(2)]
		protected new IStandControl FbInstance;

		// Token: 0x04006A1B RID: 27163
		[Nullable(2)]
		protected new IStandControl_SetValue PocoInterface;
	}
}
