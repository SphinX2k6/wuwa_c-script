using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A1A RID: 6682
	[NullableContext(1)]
	[Nullable(0)]
	public class IExecBattleActionType
	{
		// Token: 0x06008F2B RID: 36651 RVA: 0x0014E7BC File Offset: 0x0014C9BC
		private IExecBattleActionType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IExecBattleActionType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IExecBattleActionType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IExecBattleActionType_SetValue());
			}
			return result;
		}

		// Token: 0x06008F2C RID: 36652 RVA: 0x0014E7F4 File Offset: 0x0014C9F4
		public static IExecBattleActionType Create([Nullable(2)] IExecBattleActionType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IExecBattleActionType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008F2D RID: 36653 RVA: 0x0014E807 File Offset: 0x0014CA07
		public static IExecBattleActionType CreateFromSetValue([Nullable(2)] IExecBattleActionType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IExecBattleActionType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008F2E RID: 36654 RVA: 0x0014E81A File Offset: 0x0014CA1A
		public IExecBattleActionType_SetValue ToSetValue()
		{
			return new IExecBattleActionType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002DC3 RID: 11715
		// (get) Token: 0x06008F2F RID: 36655 RVA: 0x0014E82D File Offset: 0x0014CA2D
		// (set) Token: 0x06008F30 RID: 36656 RVA: 0x0014E858 File Offset: 0x0014CA58
		public virtual EExecBattleActionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EExecBattleActionType.SetBattleTags;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040058A0 RID: 22688
		[Nullable(2)]
		protected IExecBattleActionType FbInstance;

		// Token: 0x040058A1 RID: 22689
		[Nullable(2)]
		protected IExecBattleActionType_SetValue PocoInterface;
	}
}
