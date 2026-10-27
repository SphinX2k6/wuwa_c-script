using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071E1 RID: 29153
	public struct IStopNewMoveWithSplineAtEndPoint : IFlatbufferObject
	{
		// Token: 0x1700D888 RID: 55432
		// (get) Token: 0x06033B60 RID: 211808 RVA: 0x006F6675 File Offset: 0x006F4875
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033B61 RID: 211809 RVA: 0x006F6682 File Offset: 0x006F4882
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033B62 RID: 211810 RVA: 0x006F668C File Offset: 0x006F488C
		public static IStopNewMoveWithSplineAtEndPoint GetRootAsIStopNewMoveWithSplineAtEndPoint(ByteBuffer _bb)
		{
			return IStopNewMoveWithSplineAtEndPoint.GetRootAsIStopNewMoveWithSplineAtEndPoint(_bb, default(IStopNewMoveWithSplineAtEndPoint));
		}

		// Token: 0x06033B63 RID: 211811 RVA: 0x006F66A8 File Offset: 0x006F48A8
		public static IStopNewMoveWithSplineAtEndPoint GetRootAsIStopNewMoveWithSplineAtEndPoint(ByteBuffer _bb, IStopNewMoveWithSplineAtEndPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033B64 RID: 211812 RVA: 0x006F66C5 File Offset: 0x006F48C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033B65 RID: 211813 RVA: 0x006F66D4 File Offset: 0x006F48D4
		public IStopNewMoveWithSplineAtEndPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D889 RID: 55433
		// (get) Token: 0x06033B66 RID: 211814 RVA: 0x006F66E4 File Offset: 0x006F48E4
		public EStopNewMoveWithSplineType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EStopNewMoveWithSplineType.StopAtCurrentPos;
				}
				return (EStopNewMoveWithSplineType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033B67 RID: 211815 RVA: 0x006F6720 File Offset: 0x006F4920
		public static Offset<IStopNewMoveWithSplineAtEndPoint> CreateIStopNewMoveWithSplineAtEndPoint(FlatBufferBuilder builder, EStopNewMoveWithSplineType Type = EStopNewMoveWithSplineType.StopAtCurrentPos)
		{
			builder.StartTable(1);
			IStopNewMoveWithSplineAtEndPoint.AddType(builder, Type);
			return IStopNewMoveWithSplineAtEndPoint.EndIStopNewMoveWithSplineAtEndPoint(builder);
		}

		// Token: 0x06033B68 RID: 211816 RVA: 0x006F6736 File Offset: 0x006F4936
		public static void StartIStopNewMoveWithSplineAtEndPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06033B69 RID: 211817 RVA: 0x006F673F File Offset: 0x006F493F
		public static void AddType(FlatBufferBuilder builder, EStopNewMoveWithSplineType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033B6A RID: 211818 RVA: 0x006F674A File Offset: 0x006F494A
		public static Offset<IStopNewMoveWithSplineAtEndPoint> EndIStopNewMoveWithSplineAtEndPoint(FlatBufferBuilder builder)
		{
			return new Offset<IStopNewMoveWithSplineAtEndPoint>(builder.EndTable());
		}

		// Token: 0x06033B6B RID: 211819 RVA: 0x006F6758 File Offset: 0x006F4958
		public IStopNewMoveWithSplineAtEndPointT UnPack()
		{
			IStopNewMoveWithSplineAtEndPointT stopNewMoveWithSplineAtEndPointT = new IStopNewMoveWithSplineAtEndPointT();
			this.UnPackTo(stopNewMoveWithSplineAtEndPointT);
			return stopNewMoveWithSplineAtEndPointT;
		}

		// Token: 0x06033B6C RID: 211820 RVA: 0x006F6773 File Offset: 0x006F4973
		public void UnPackTo(IStopNewMoveWithSplineAtEndPointT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06033B6D RID: 211821 RVA: 0x006F6784 File Offset: 0x006F4984
		public static Offset<IStopNewMoveWithSplineAtEndPoint> Pack(FlatBufferBuilder builder, IStopNewMoveWithSplineAtEndPointT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStopNewMoveWithSplineAtEndPoint>);
			}
			return IStopNewMoveWithSplineAtEndPoint.CreateIStopNewMoveWithSplineAtEndPoint(builder, _o.Type);
		}

		// Token: 0x04011CC1 RID: 72897
		private Table __p;
	}
}
