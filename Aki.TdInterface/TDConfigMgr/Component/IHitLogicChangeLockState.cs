using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200047D RID: 1149
	public class IHitLogicChangeLockState : IHitLogicType
	{
		// Token: 0x060016FB RID: 5883 RVA: 0x00046ECC File Offset: 0x000450CC
		private IHitLogicChangeLockState_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHitLogicChangeLockState 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHitLogicChangeLockState_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHitLogicChangeLockState_SetValue());
			}
			return result;
		}

		// Token: 0x060016FC RID: 5884 RVA: 0x00046F04 File Offset: 0x00045104
		public static IHitLogicChangeLockState Create([Nullable(2)] IHitLogicChangeLockState instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHitLogicChangeLockState
			{
				FbInstance = instance
			};
		}

		// Token: 0x060016FD RID: 5885 RVA: 0x00046F17 File Offset: 0x00045117
		public static IHitLogicChangeLockState CreateFromSetValue([Nullable(2)] IHitLogicChangeLockState_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHitLogicChangeLockState
			{
				PocoInterface = value
			};
		}

		// Token: 0x060016FE RID: 5886 RVA: 0x00046F2A File Offset: 0x0004512A
		public new IHitLogicChangeLockState_SetValue ToSetValue()
		{
			return new IHitLogicChangeLockState_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x060016FF RID: 5887 RVA: 0x00046F3D File Offset: 0x0004513D
		// (set) Token: 0x06001700 RID: 5888 RVA: 0x00046F68 File Offset: 0x00045168
		public override EHitLogicType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EHitLogicType.ChangeNextState;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040011AF RID: 4527
		[Nullable(2)]
		protected new IHitLogicChangeLockState FbInstance;

		// Token: 0x040011B0 RID: 4528
		[Nullable(2)]
		protected new IHitLogicChangeLockState_SetValue PocoInterface;
	}
}
