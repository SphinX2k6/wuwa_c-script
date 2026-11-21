using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A15 RID: 6677
	public class ICharacterLookAtUnlockData : ICharacterLookAtData
	{
		// Token: 0x06008E15 RID: 36373 RVA: 0x0014FB08 File Offset: 0x0014DD08
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

		// Token: 0x06008E16 RID: 36374 RVA: 0x0014FB40 File Offset: 0x0014DD40
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

		// Token: 0x06008E17 RID: 36375 RVA: 0x0014FB53 File Offset: 0x0014DD53
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

		// Token: 0x06008E18 RID: 36376 RVA: 0x0014FB66 File Offset: 0x0014DD66
		public new ICharacterLookAtUnlockData_SetValue ToSetValue()
		{
			return new ICharacterLookAtUnlockData_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002DF7 RID: 11767
		// (get) Token: 0x06008E19 RID: 36377 RVA: 0x0014FB79 File Offset: 0x0014DD79
		// (set) Token: 0x06008E1A RID: 36378 RVA: 0x0014FBA4 File Offset: 0x0014DDA4
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

		// Token: 0x0400594E RID: 22862
		[Nullable(2)]
		protected new ICharacterLookAtUnlockData FbInstance;

		// Token: 0x0400594F RID: 22863
		[Nullable(2)]
		protected new ICharacterLookAtUnlockData_SetValue PocoInterface;
	}
}
