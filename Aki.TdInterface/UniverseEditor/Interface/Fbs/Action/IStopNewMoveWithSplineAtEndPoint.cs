using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079B6 RID: 31158
	public struct IStopNewMoveWithSplineAtEndPoint : IFlatbufferObject
	{
		// Token: 0x1700E481 RID: 58497
		// (get) Token: 0x06036E62 RID: 224866 RVA: 0x007579D5 File Offset: 0x00755BD5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036E63 RID: 224867 RVA: 0x007579E2 File Offset: 0x00755BE2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036E64 RID: 224868 RVA: 0x007579EC File Offset: 0x00755BEC
		public static IStopNewMoveWithSplineAtEndPoint GetRootAsIStopNewMoveWithSplineAtEndPoint(ByteBuffer _bb)
		{
			return IStopNewMoveWithSplineAtEndPoint.GetRootAsIStopNewMoveWithSplineAtEndPoint(_bb, default(IStopNewMoveWithSplineAtEndPoint));
		}

		// Token: 0x06036E65 RID: 224869 RVA: 0x00757A08 File Offset: 0x00755C08
		public static IStopNewMoveWithSplineAtEndPoint GetRootAsIStopNewMoveWithSplineAtEndPoint(ByteBuffer _bb, IStopNewMoveWithSplineAtEndPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036E66 RID: 224870 RVA: 0x00757A25 File Offset: 0x00755C25
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036E67 RID: 224871 RVA: 0x00757A34 File Offset: 0x00755C34
		public IStopNewMoveWithSplineAtEndPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E482 RID: 58498
		// (get) Token: 0x06036E68 RID: 224872 RVA: 0x00757A44 File Offset: 0x00755C44
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

		// Token: 0x06036E69 RID: 224873 RVA: 0x00757A80 File Offset: 0x00755C80
		public static Offset<IStopNewMoveWithSplineAtEndPoint> CreateIStopNewMoveWithSplineAtEndPoint(FlatBufferBuilder builder, EStopNewMoveWithSplineType Type = EStopNewMoveWithSplineType.StopAtCurrentPos)
		{
			builder.StartTable(1);
			IStopNewMoveWithSplineAtEndPoint.AddType(builder, Type);
			return IStopNewMoveWithSplineAtEndPoint.EndIStopNewMoveWithSplineAtEndPoint(builder);
		}

		// Token: 0x06036E6A RID: 224874 RVA: 0x00757A96 File Offset: 0x00755C96
		public static void StartIStopNewMoveWithSplineAtEndPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06036E6B RID: 224875 RVA: 0x00757A9F File Offset: 0x00755C9F
		public static void AddType(FlatBufferBuilder builder, EStopNewMoveWithSplineType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036E6C RID: 224876 RVA: 0x00757AAA File Offset: 0x00755CAA
		public static Offset<IStopNewMoveWithSplineAtEndPoint> EndIStopNewMoveWithSplineAtEndPoint(FlatBufferBuilder builder)
		{
			return new Offset<IStopNewMoveWithSplineAtEndPoint>(builder.EndTable());
		}

		// Token: 0x06036E6D RID: 224877 RVA: 0x00757AB8 File Offset: 0x00755CB8
		public IStopNewMoveWithSplineAtEndPointT UnPack()
		{
			IStopNewMoveWithSplineAtEndPointT stopNewMoveWithSplineAtEndPointT = new IStopNewMoveWithSplineAtEndPointT();
			this.UnPackTo(stopNewMoveWithSplineAtEndPointT);
			return stopNewMoveWithSplineAtEndPointT;
		}

		// Token: 0x06036E6E RID: 224878 RVA: 0x00757AD3 File Offset: 0x00755CD3
		public void UnPackTo(IStopNewMoveWithSplineAtEndPointT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06036E6F RID: 224879 RVA: 0x00757AE4 File Offset: 0x00755CE4
		public static Offset<IStopNewMoveWithSplineAtEndPoint> Pack(FlatBufferBuilder builder, IStopNewMoveWithSplineAtEndPointT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStopNewMoveWithSplineAtEndPoint>);
			}
			return IStopNewMoveWithSplineAtEndPoint.CreateIStopNewMoveWithSplineAtEndPoint(builder, _o.Type);
		}

		// Token: 0x04012CC3 RID: 76995
		private Table __p;
	}
}
