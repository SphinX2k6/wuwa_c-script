using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02008010 RID: 32784
	public class TTeleportConfigUnion
	{
		// Token: 0x1700F32D RID: 62253
		// (get) Token: 0x0603AFE7 RID: 241639 RVA: 0x007EBFC8 File Offset: 0x007EA1C8
		// (set) Token: 0x0603AFE8 RID: 241640 RVA: 0x007EBFD0 File Offset: 0x007EA1D0
		public TTeleportConfig Type { get; set; }

		// Token: 0x1700F32E RID: 62254
		// (get) Token: 0x0603AFE9 RID: 241641 RVA: 0x007EBFD9 File Offset: 0x007EA1D9
		// (set) Token: 0x0603AFEA RID: 241642 RVA: 0x007EBFE1 File Offset: 0x007EA1E1
		public object Value { get; set; }

		// Token: 0x0603AFEB RID: 241643 RVA: 0x007EBFEA File Offset: 0x007EA1EA
		public TTeleportConfigUnion()
		{
			this.Type = TTeleportConfig.NONE;
			this.Value = null;
		}

		// Token: 0x0603AFEC RID: 241644 RVA: 0x007EC000 File Offset: 0x007EA200
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603AFED RID: 241645 RVA: 0x007EC012 File Offset: 0x007EA212
		public IFixedPosT AsIFixedPos()
		{
			return this.As<IFixedPosT>();
		}

		// Token: 0x0603AFEE RID: 241646 RVA: 0x007EC01A File Offset: 0x007EA21A
		public static TTeleportConfigUnion FromIFixedPos(IFixedPosT _ifixedpos)
		{
			return new TTeleportConfigUnion
			{
				Type = TTeleportConfig.IFixedPos,
				Value = _ifixedpos
			};
		}

		// Token: 0x0603AFEF RID: 241647 RVA: 0x007EC02F File Offset: 0x007EA22F
		public IGravityFlipFixedPosT AsIGravityFlipFixedPos()
		{
			return this.As<IGravityFlipFixedPosT>();
		}

		// Token: 0x0603AFF0 RID: 241648 RVA: 0x007EC037 File Offset: 0x007EA237
		public static TTeleportConfigUnion FromIGravityFlipFixedPos(IGravityFlipFixedPosT _igravityflipfixedpos)
		{
			return new TTeleportConfigUnion
			{
				Type = TTeleportConfig.IGravityFlipFixedPos,
				Value = _igravityflipfixedpos
			};
		}

		// Token: 0x0603AFF1 RID: 241649 RVA: 0x007EC04C File Offset: 0x007EA24C
		public INearestEntityT AsINearestEntity()
		{
			return this.As<INearestEntityT>();
		}

		// Token: 0x0603AFF2 RID: 241650 RVA: 0x007EC054 File Offset: 0x007EA254
		public static TTeleportConfigUnion FromINearestEntity(INearestEntityT _inearestentity)
		{
			return new TTeleportConfigUnion
			{
				Type = TTeleportConfig.INearestEntity,
				Value = _inearestentity
			};
		}

		// Token: 0x0603AFF3 RID: 241651 RVA: 0x007EC069 File Offset: 0x007EA269
		public ISafePosT AsISafePos()
		{
			return this.As<ISafePosT>();
		}

		// Token: 0x0603AFF4 RID: 241652 RVA: 0x007EC071 File Offset: 0x007EA271
		public static TTeleportConfigUnion FromISafePos(ISafePosT _isafepos)
		{
			return new TTeleportConfigUnion
			{
				Type = TTeleportConfig.ISafePos,
				Value = _isafepos
			};
		}

		// Token: 0x0603AFF5 RID: 241653 RVA: 0x007EC088 File Offset: 0x007EA288
		public static int Pack(FlatBufferBuilder builder, TTeleportConfigUnion _o)
		{
			switch (_o.Type)
			{
			case TTeleportConfig.IFixedPos:
				return IFixedPos.Pack(builder, _o.AsIFixedPos()).Value;
			case TTeleportConfig.IGravityFlipFixedPos:
				return IGravityFlipFixedPos.Pack(builder, _o.AsIGravityFlipFixedPos()).Value;
			case TTeleportConfig.INearestEntity:
				return INearestEntity.Pack(builder, _o.AsINearestEntity()).Value;
			case TTeleportConfig.ISafePos:
				return ISafePos.Pack(builder, _o.AsISafePos()).Value;
			default:
				return 0;
			}
		}
	}
}
