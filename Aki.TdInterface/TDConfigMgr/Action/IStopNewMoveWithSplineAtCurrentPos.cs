using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001EC3 RID: 7875
	[NullableContext(1)]
	[Nullable(0)]
	public class IStopNewMoveWithSplineAtCurrentPos : IStopNewMoveWithSplineType
	{
		// Token: 0x0600A894 RID: 43156 RVA: 0x0017C96C File Offset: 0x0017AB6C
		private IStopNewMoveWithSplineAtCurrentPos_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IStopNewMoveWithSplineAtCurrentPos 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IStopNewMoveWithSplineAtCurrentPos_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IStopNewMoveWithSplineAtCurrentPos_SetValue());
			}
			return result;
		}

		// Token: 0x0600A895 RID: 43157 RVA: 0x0017C9A4 File Offset: 0x0017ABA4
		public static IStopNewMoveWithSplineAtCurrentPos Create([Nullable(2)] IStopNewMoveWithSplineAtCurrentPos instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStopNewMoveWithSplineAtCurrentPos
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A896 RID: 43158 RVA: 0x0017C9B7 File Offset: 0x0017ABB7
		public static IStopNewMoveWithSplineAtCurrentPos CreateFromSetValue([Nullable(2)] IStopNewMoveWithSplineAtCurrentPos_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IStopNewMoveWithSplineAtCurrentPos
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A897 RID: 43159 RVA: 0x0017C9CA File Offset: 0x0017ABCA
		public new IStopNewMoveWithSplineAtCurrentPos_SetValue ToSetValue()
		{
			return new IStopNewMoveWithSplineAtCurrentPos_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700337D RID: 13181
		// (get) Token: 0x0600A898 RID: 43160 RVA: 0x0017C9DD File Offset: 0x0017ABDD
		// (set) Token: 0x0600A899 RID: 43161 RVA: 0x0017CA08 File Offset: 0x0017AC08
		public override EStopNewMoveWithSplineType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EStopNewMoveWithSplineType.StopAtCurrentPos;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400646C RID: 25708
		[Nullable(2)]
		protected new IStopNewMoveWithSplineAtCurrentPos FbInstance;

		// Token: 0x0400646D RID: 25709
		[Nullable(2)]
		protected new IStopNewMoveWithSplineAtCurrentPos_SetValue PocoInterface;
	}
}
