using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018B8 RID: 6328
	[NullableContext(1)]
	[Nullable(0)]
	public class IClientFollowShooterLeisureInteractType
	{
		// Token: 0x060087CB RID: 34763 RVA: 0x00141AC8 File Offset: 0x0013FCC8
		private IClientFollowShooterLeisureInteractType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IClientFollowShooterLeisureInteractType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IClientFollowShooterLeisureInteractType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IClientFollowShooterLeisureInteractType_SetValue());
			}
			return result;
		}

		// Token: 0x060087CC RID: 34764 RVA: 0x00141B00 File Offset: 0x0013FD00
		public static IClientFollowShooterLeisureInteractType Create([Nullable(2)] IClientFollowShooterLeisureInteractType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IClientFollowShooterLeisureInteractType
			{
				FbInstance = instance
			};
		}

		// Token: 0x060087CD RID: 34765 RVA: 0x00141B13 File Offset: 0x0013FD13
		public static IClientFollowShooterLeisureInteractType CreateFromSetValue([Nullable(2)] IClientFollowShooterLeisureInteractType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IClientFollowShooterLeisureInteractType
			{
				PocoInterface = value
			};
		}

		// Token: 0x060087CE RID: 34766 RVA: 0x00141B26 File Offset: 0x0013FD26
		public IClientFollowShooterLeisureInteractType_SetValue ToSetValue()
		{
			return new IClientFollowShooterLeisureInteractType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002C26 RID: 11302
		// (get) Token: 0x060087CF RID: 34767 RVA: 0x00141B39 File Offset: 0x0013FD39
		// (set) Token: 0x060087D0 RID: 34768 RVA: 0x00141B64 File Offset: 0x0013FD64
		public virtual EClientFollowShooterLeisureInteractType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EClientFollowShooterLeisureInteractType.ResetToPlayer;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005567 RID: 21863
		[Nullable(2)]
		protected IClientFollowShooterLeisureInteractType FbInstance;

		// Token: 0x04005568 RID: 21864
		[Nullable(2)]
		protected IClientFollowShooterLeisureInteractType_SetValue PocoInterface;
	}
}
