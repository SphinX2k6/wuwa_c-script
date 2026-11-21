using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D31 RID: 7473
	public class ILiftMoveTypeCustomSpeed : ILiftMoveType
	{
		// Token: 0x06009EB7 RID: 40631 RVA: 0x0016CF30 File Offset: 0x0016B130
		private ILiftMoveTypeCustomSpeed_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILiftMoveTypeCustomSpeed 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILiftMoveTypeCustomSpeed_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILiftMoveTypeCustomSpeed_SetValue());
			}
			return result;
		}

		// Token: 0x06009EB8 RID: 40632 RVA: 0x0016CF68 File Offset: 0x0016B168
		public static ILiftMoveTypeCustomSpeed Create([Nullable(2)] ILiftMoveTypeCustomSpeed instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILiftMoveTypeCustomSpeed
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009EB9 RID: 40633 RVA: 0x0016CF7B File Offset: 0x0016B17B
		public static ILiftMoveTypeCustomSpeed CreateFromSetValue([Nullable(2)] ILiftMoveTypeCustomSpeed_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILiftMoveTypeCustomSpeed
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009EBA RID: 40634 RVA: 0x0016CF8E File Offset: 0x0016B18E
		public new ILiftMoveTypeCustomSpeed_SetValue ToSetValue()
		{
			return new ILiftMoveTypeCustomSpeed_SetValue
			{
				Type = this.Type,
				TotalTime = this.TotalTime,
				TimePathCurve = this.TimePathCurve
			};
		}

		// Token: 0x170031A0 RID: 12704
		// (get) Token: 0x06009EBB RID: 40635 RVA: 0x0016CFB9 File Offset: 0x0016B1B9
		// (set) Token: 0x06009EBC RID: 40636 RVA: 0x0016CFE4 File Offset: 0x0016B1E4
		public override ELiftMoveType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELiftMoveType.Default;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170031A1 RID: 12705
		// (get) Token: 0x06009EBD RID: 40637 RVA: 0x0016CFF2 File Offset: 0x0016B1F2
		// (set) Token: 0x06009EBE RID: 40638 RVA: 0x0016D021 File Offset: 0x0016B221
		public virtual float TotalTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TotalTime;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.TotalTime;
			}
			set
			{
				this.GetOrCreatePoco().TotalTime = value;
			}
		}

		// Token: 0x170031A2 RID: 12706
		// (get) Token: 0x06009EBF RID: 40639 RVA: 0x0016D02F File Offset: 0x0016B22F
		// (set) Token: 0x06009EC0 RID: 40640 RVA: 0x0016D05A File Offset: 0x0016B25A
		public virtual string TimePathCurve
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TimePathCurve;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.TimePathCurve;
			}
			set
			{
				this.GetOrCreatePoco().TimePathCurve = value;
			}
		}

		// Token: 0x040060C3 RID: 24771
		[Nullable(2)]
		protected new ILiftMoveTypeCustomSpeed FbInstance;

		// Token: 0x040060C4 RID: 24772
		[Nullable(2)]
		protected new ILiftMoveTypeCustomSpeed_SetValue PocoInterface;
	}
}
