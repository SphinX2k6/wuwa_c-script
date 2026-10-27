using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200188A RID: 6282
	[NullableContext(1)]
	[Nullable(0)]
	public class ICharacterLookAtUnlockData : ICharacterLookAtData
	{
		// Token: 0x060086ED RID: 34541 RVA: 0x001402D4 File Offset: 0x0013E4D4
		private ICharacterLookAtUnlockData_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICharacterLookAtUnlockData 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICharacterLookAtUnlockData_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICharacterLookAtUnlockData_SetValue());
			}
			return result;
		}

		// Token: 0x060086EE RID: 34542 RVA: 0x0014030C File Offset: 0x0013E50C
		public static ICharacterLookAtUnlockData Create([Nullable(2)] ICharacterLookAtUnlockData instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICharacterLookAtUnlockData
			{
				FbInstance = instance
			};
		}

		// Token: 0x060086EF RID: 34543 RVA: 0x0014031F File Offset: 0x0013E51F
		public static ICharacterLookAtUnlockData CreateFromSetValue([Nullable(2)] ICharacterLookAtUnlockData_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICharacterLookAtUnlockData
			{
				PocoInterface = value
			};
		}

		// Token: 0x060086F0 RID: 34544 RVA: 0x00140332 File Offset: 0x0013E532
		public new ICharacterLookAtUnlockData_SetValue ToSetValue()
		{
			return new ICharacterLookAtUnlockData_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002BFC RID: 11260
		// (get) Token: 0x060086F1 RID: 34545 RVA: 0x00140345 File Offset: 0x0013E545
		// (set) Token: 0x060086F2 RID: 34546 RVA: 0x00140370 File Offset: 0x0013E570
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

		// Token: 0x04005501 RID: 21761
		[Nullable(2)]
		protected new ICharacterLookAtUnlockData FbInstance;

		// Token: 0x04005502 RID: 21762
		[Nullable(2)]
		protected new ICharacterLookAtUnlockData_SetValue PocoInterface;
	}
}
