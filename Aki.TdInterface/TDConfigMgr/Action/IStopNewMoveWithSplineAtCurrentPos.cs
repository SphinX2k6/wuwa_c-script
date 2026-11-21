using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020FC RID: 8444
	public class IStopNewMoveWithSplineAtCurrentPos : IStopNewMoveWithSplineType
	{
		// Token: 0x0600B366 RID: 45926 RVA: 0x00192964 File Offset: 0x00190B64
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

		// Token: 0x0600B367 RID: 45927 RVA: 0x0019299C File Offset: 0x00190B9C
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

		// Token: 0x0600B368 RID: 45928 RVA: 0x001929AF File Offset: 0x00190BAF
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

		// Token: 0x0600B369 RID: 45929 RVA: 0x001929C2 File Offset: 0x00190BC2
		public new IStopNewMoveWithSplineAtCurrentPos_SetValue ToSetValue()
		{
			return new IStopNewMoveWithSplineAtCurrentPos_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003648 RID: 13896
		// (get) Token: 0x0600B36A RID: 45930 RVA: 0x001929D5 File Offset: 0x00190BD5
		// (set) Token: 0x0600B36B RID: 45931 RVA: 0x00192A00 File Offset: 0x00190C00
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

		// Token: 0x04006A5B RID: 27227
		[Nullable(2)]
		protected new IStopNewMoveWithSplineAtCurrentPos FbInstance;

		// Token: 0x04006A5C RID: 27228
		[Nullable(2)]
		protected new IStopNewMoveWithSplineAtCurrentPos_SetValue PocoInterface;
	}
}
