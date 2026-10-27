using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000F02 RID: 3842
	[NullableContext(1)]
	[Nullable(0)]
	public class ICheckTrapDefenseBdBuffQualityUp : ICheckTrapDefenseEventBase
	{
		// Token: 0x060054C0 RID: 21696 RVA: 0x000CFE3C File Offset: 0x000CE03C
		private ICheckTrapDefenseBdBuffQualityUp_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICheckTrapDefenseBdBuffQualityUp 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICheckTrapDefenseBdBuffQualityUp_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICheckTrapDefenseBdBuffQualityUp_SetValue());
			}
			return result;
		}

		// Token: 0x060054C1 RID: 21697 RVA: 0x000CFE74 File Offset: 0x000CE074
		public static ICheckTrapDefenseBdBuffQualityUp Create([Nullable(2)] ICheckTrapDefenseBdBuffQualityUp instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICheckTrapDefenseBdBuffQualityUp
			{
				FbInstance = instance
			};
		}

		// Token: 0x060054C2 RID: 21698 RVA: 0x000CFE87 File Offset: 0x000CE087
		public static ICheckTrapDefenseBdBuffQualityUp CreateFromSetValue([Nullable(2)] ICheckTrapDefenseBdBuffQualityUp_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICheckTrapDefenseBdBuffQualityUp
			{
				PocoInterface = value
			};
		}

		// Token: 0x060054C3 RID: 21699 RVA: 0x000CFE9A File Offset: 0x000CE09A
		public new ICheckTrapDefenseBdBuffQualityUp_SetValue ToSetValue()
		{
			return new ICheckTrapDefenseBdBuffQualityUp_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001C5E RID: 7262
		// (get) Token: 0x060054C4 RID: 21700 RVA: 0x000CFEAD File Offset: 0x000CE0AD
		// (set) Token: 0x060054C5 RID: 21701 RVA: 0x000CFED8 File Offset: 0x000CE0D8
		public override ECheckTrapDefenseEvent Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECheckTrapDefenseEvent.MonsterKilled;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400334F RID: 13135
		[Nullable(2)]
		protected new ICheckTrapDefenseBdBuffQualityUp FbInstance;

		// Token: 0x04003350 RID: 13136
		[Nullable(2)]
		protected new ICheckTrapDefenseBdBuffQualityUp_SetValue PocoInterface;
	}
}
