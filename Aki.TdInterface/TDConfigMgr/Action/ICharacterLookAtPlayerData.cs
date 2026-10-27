using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001886 RID: 6278
	[NullableContext(1)]
	[Nullable(0)]
	public class ICharacterLookAtPlayerData : ICharacterLookAtData
	{
		// Token: 0x060086DB RID: 34523 RVA: 0x001400D8 File Offset: 0x0013E2D8
		private ICharacterLookAtPlayerData_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICharacterLookAtPlayerData 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICharacterLookAtPlayerData_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICharacterLookAtPlayerData_SetValue());
			}
			return result;
		}

		// Token: 0x060086DC RID: 34524 RVA: 0x00140110 File Offset: 0x0013E310
		public static ICharacterLookAtPlayerData Create([Nullable(2)] ICharacterLookAtPlayerData instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICharacterLookAtPlayerData
			{
				FbInstance = instance
			};
		}

		// Token: 0x060086DD RID: 34525 RVA: 0x00140123 File Offset: 0x0013E323
		public static ICharacterLookAtPlayerData CreateFromSetValue([Nullable(2)] ICharacterLookAtPlayerData_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICharacterLookAtPlayerData
			{
				PocoInterface = value
			};
		}

		// Token: 0x060086DE RID: 34526 RVA: 0x00140136 File Offset: 0x0013E336
		public new ICharacterLookAtPlayerData_SetValue ToSetValue()
		{
			return new ICharacterLookAtPlayerData_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002BF9 RID: 11257
		// (get) Token: 0x060086DF RID: 34527 RVA: 0x00140149 File Offset: 0x0013E349
		// (set) Token: 0x060086E0 RID: 34528 RVA: 0x00140174 File Offset: 0x0013E374
		public override ECharacterLookAt Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECharacterLookAt.Empty;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040054F8 RID: 21752
		[Nullable(2)]
		protected new ICharacterLookAtPlayerData FbInstance;

		// Token: 0x040054F9 RID: 21753
		[Nullable(2)]
		protected new ICharacterLookAtPlayerData_SetValue PocoInterface;
	}
}
