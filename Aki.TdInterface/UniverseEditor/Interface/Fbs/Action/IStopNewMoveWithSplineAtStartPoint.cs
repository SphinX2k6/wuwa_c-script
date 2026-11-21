using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079B9 RID: 31161
	public struct IStopNewMoveWithSplineAtStartPoint : IFlatbufferObject
	{
		// Token: 0x1700E484 RID: 58500
		// (get) Token: 0x06036E74 RID: 224884 RVA: 0x00757B4D File Offset: 0x00755D4D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036E75 RID: 224885 RVA: 0x00757B5A File Offset: 0x00755D5A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036E76 RID: 224886 RVA: 0x00757B64 File Offset: 0x00755D64
		public static IStopNewMoveWithSplineAtStartPoint GetRootAsIStopNewMoveWithSplineAtStartPoint(ByteBuffer _bb)
		{
			return IStopNewMoveWithSplineAtStartPoint.GetRootAsIStopNewMoveWithSplineAtStartPoint(_bb, default(IStopNewMoveWithSplineAtStartPoint));
		}

		// Token: 0x06036E77 RID: 224887 RVA: 0x00757B80 File Offset: 0x00755D80
		public static IStopNewMoveWithSplineAtStartPoint GetRootAsIStopNewMoveWithSplineAtStartPoint(ByteBuffer _bb, IStopNewMoveWithSplineAtStartPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036E78 RID: 224888 RVA: 0x00757B9D File Offset: 0x00755D9D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036E79 RID: 224889 RVA: 0x00757BAC File Offset: 0x00755DAC
		public IStopNewMoveWithSplineAtStartPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E485 RID: 58501
		// (get) Token: 0x06036E7A RID: 224890 RVA: 0x00757BBC File Offset: 0x00755DBC
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

		// Token: 0x06036E7B RID: 224891 RVA: 0x00757BF8 File Offset: 0x00755DF8
		public static Offset<IStopNewMoveWithSplineAtStartPoint> CreateIStopNewMoveWithSplineAtStartPoint(FlatBufferBuilder builder, EStopNewMoveWithSplineType Type = EStopNewMoveWithSplineType.StopAtCurrentPos)
		{
			builder.StartTable(1);
			IStopNewMoveWithSplineAtStartPoint.AddType(builder, Type);
			return IStopNewMoveWithSplineAtStartPoint.EndIStopNewMoveWithSplineAtStartPoint(builder);
		}

		// Token: 0x06036E7C RID: 224892 RVA: 0x00757C0E File Offset: 0x00755E0E
		public static void StartIStopNewMoveWithSplineAtStartPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06036E7D RID: 224893 RVA: 0x00757C17 File Offset: 0x00755E17
		public static void AddType(FlatBufferBuilder builder, EStopNewMoveWithSplineType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036E7E RID: 224894 RVA: 0x00757C22 File Offset: 0x00755E22
		public static Offset<IStopNewMoveWithSplineAtStartPoint> EndIStopNewMoveWithSplineAtStartPoint(FlatBufferBuilder builder)
		{
			return new Offset<IStopNewMoveWithSplineAtStartPoint>(builder.EndTable());
		}

		// Token: 0x06036E7F RID: 224895 RVA: 0x00757C30 File Offset: 0x00755E30
		public IStopNewMoveWithSplineAtStartPointT UnPack()
		{
			IStopNewMoveWithSplineAtStartPointT stopNewMoveWithSplineAtStartPointT = new IStopNewMoveWithSplineAtStartPointT();
			this.UnPackTo(stopNewMoveWithSplineAtStartPointT);
			return stopNewMoveWithSplineAtStartPointT;
		}

		// Token: 0x06036E80 RID: 224896 RVA: 0x00757C4B File Offset: 0x00755E4B
		public void UnPackTo(IStopNewMoveWithSplineAtStartPointT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06036E81 RID: 224897 RVA: 0x00757C5C File Offset: 0x00755E5C
		public static Offset<IStopNewMoveWithSplineAtStartPoint> Pack(FlatBufferBuilder builder, IStopNewMoveWithSplineAtStartPointT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStopNewMoveWithSplineAtStartPoint>);
			}
			return IStopNewMoveWithSplineAtStartPoint.CreateIStopNewMoveWithSplineAtStartPoint(builder, _o.Type);
		}

		// Token: 0x04012CC5 RID: 76997
		private Table __p;
	}
}
