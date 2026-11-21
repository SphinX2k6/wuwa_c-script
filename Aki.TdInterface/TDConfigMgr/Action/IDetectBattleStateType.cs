using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B1D RID: 6941
	public class IDetectBattleStateType
	{
		// Token: 0x06009355 RID: 37717 RVA: 0x0015896C File Offset: 0x00156B6C
		private IDetectBattleStateType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDetectBattleStateType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDetectBattleStateType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDetectBattleStateType_SetValue());
			}
			return result;
		}

		// Token: 0x06009356 RID: 37718 RVA: 0x001589A4 File Offset: 0x00156BA4
		public static IDetectBattleStateType Create([Nullable(2)] IDetectBattleStateType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDetectBattleStateType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009357 RID: 37719 RVA: 0x001589B7 File Offset: 0x00156BB7
		public static IDetectBattleStateType CreateFromSetValue([Nullable(2)] IDetectBattleStateType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDetectBattleStateType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009358 RID: 37720 RVA: 0x001589CA File Offset: 0x00156BCA
		public IDetectBattleStateType_SetValue ToSetValue()
		{
			return new IDetectBattleStateType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002F0B RID: 12043
		// (get) Token: 0x06009359 RID: 37721 RVA: 0x001589DD File Offset: 0x00156BDD
		// (set) Token: 0x0600935A RID: 37722 RVA: 0x00158A08 File Offset: 0x00156C08
		public virtual EDetectBattleConditionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EDetectBattleConditionType.DetectBattleTag;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005B98 RID: 23448
		[Nullable(2)]
		protected IDetectBattleStateType FbInstance;

		// Token: 0x04005B99 RID: 23449
		[Nullable(2)]
		protected IDetectBattleStateType_SetValue PocoInterface;
	}
}
