using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200204B RID: 8267
	public class ISetBattleTagType
	{
		// Token: 0x0600AF77 RID: 44919 RVA: 0x0018B460 File Offset: 0x00189660
		private ISetBattleTagType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISetBattleTagType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISetBattleTagType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISetBattleTagType_SetValue());
			}
			return result;
		}

		// Token: 0x0600AF78 RID: 44920 RVA: 0x0018B498 File Offset: 0x00189698
		public static ISetBattleTagType Create([Nullable(2)] ISetBattleTagType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetBattleTagType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AF79 RID: 44921 RVA: 0x0018B4AB File Offset: 0x001896AB
		public static ISetBattleTagType CreateFromSetValue([Nullable(2)] ISetBattleTagType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISetBattleTagType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AF7A RID: 44922 RVA: 0x0018B4BE File Offset: 0x001896BE
		public ISetBattleTagType_SetValue ToSetValue()
		{
			return new ISetBattleTagType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003559 RID: 13657
		// (get) Token: 0x0600AF7B RID: 44923 RVA: 0x0018B4D1 File Offset: 0x001896D1
		// (set) Token: 0x0600AF7C RID: 44924 RVA: 0x0018B4FC File Offset: 0x001896FC
		public virtual ESetBattleTagType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESetBattleTagType.BattleMonsterLanding;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400687C RID: 26748
		[Nullable(2)]
		protected ISetBattleTagType FbInstance;

		// Token: 0x0400687D RID: 26749
		[Nullable(2)]
		protected ISetBattleTagType_SetValue PocoInterface;
	}
}
