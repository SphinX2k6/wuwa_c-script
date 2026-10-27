using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001996 RID: 6550
	[NullableContext(1)]
	[Nullable(0)]
	public class IDetectBattleStateType
	{
		// Token: 0x06008C31 RID: 35889 RVA: 0x0014915C File Offset: 0x0014735C
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

		// Token: 0x06008C32 RID: 35890 RVA: 0x00149194 File Offset: 0x00147394
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

		// Token: 0x06008C33 RID: 35891 RVA: 0x001491A7 File Offset: 0x001473A7
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

		// Token: 0x06008C34 RID: 35892 RVA: 0x001491BA File Offset: 0x001473BA
		public IDetectBattleStateType_SetValue ToSetValue()
		{
			return new IDetectBattleStateType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002D0C RID: 11532
		// (get) Token: 0x06008C35 RID: 35893 RVA: 0x001491CD File Offset: 0x001473CD
		// (set) Token: 0x06008C36 RID: 35894 RVA: 0x001491F8 File Offset: 0x001473F8
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

		// Token: 0x0400574F RID: 22351
		[Nullable(2)]
		protected IDetectBattleStateType FbInstance;

		// Token: 0x04005750 RID: 22352
		[Nullable(2)]
		protected IDetectBattleStateType_SetValue PocoInterface;
	}
}
