using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071E4 RID: 29156
	public struct IStopNewMoveWithSplineAtStartPoint : IFlatbufferObject
	{
		// Token: 0x1700D88B RID: 55435
		// (get) Token: 0x06033B72 RID: 211826 RVA: 0x006F67ED File Offset: 0x006F49ED
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033B73 RID: 211827 RVA: 0x006F67FA File Offset: 0x006F49FA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033B74 RID: 211828 RVA: 0x006F6804 File Offset: 0x006F4A04
		public static IStopNewMoveWithSplineAtStartPoint GetRootAsIStopNewMoveWithSplineAtStartPoint(ByteBuffer _bb)
		{
			return IStopNewMoveWithSplineAtStartPoint.GetRootAsIStopNewMoveWithSplineAtStartPoint(_bb, default(IStopNewMoveWithSplineAtStartPoint));
		}

		// Token: 0x06033B75 RID: 211829 RVA: 0x006F6820 File Offset: 0x006F4A20
		public static IStopNewMoveWithSplineAtStartPoint GetRootAsIStopNewMoveWithSplineAtStartPoint(ByteBuffer _bb, IStopNewMoveWithSplineAtStartPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033B76 RID: 211830 RVA: 0x006F683D File Offset: 0x006F4A3D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033B77 RID: 211831 RVA: 0x006F684C File Offset: 0x006F4A4C
		public IStopNewMoveWithSplineAtStartPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D88C RID: 55436
		// (get) Token: 0x06033B78 RID: 211832 RVA: 0x006F685C File Offset: 0x006F4A5C
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

		// Token: 0x06033B79 RID: 211833 RVA: 0x006F6898 File Offset: 0x006F4A98
		public static Offset<IStopNewMoveWithSplineAtStartPoint> CreateIStopNewMoveWithSplineAtStartPoint(FlatBufferBuilder builder, EStopNewMoveWithSplineType Type = EStopNewMoveWithSplineType.StopAtCurrentPos)
		{
			builder.StartTable(1);
			IStopNewMoveWithSplineAtStartPoint.AddType(builder, Type);
			return IStopNewMoveWithSplineAtStartPoint.EndIStopNewMoveWithSplineAtStartPoint(builder);
		}

		// Token: 0x06033B7A RID: 211834 RVA: 0x006F68AE File Offset: 0x006F4AAE
		public static void StartIStopNewMoveWithSplineAtStartPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06033B7B RID: 211835 RVA: 0x006F68B7 File Offset: 0x006F4AB7
		public static void AddType(FlatBufferBuilder builder, EStopNewMoveWithSplineType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033B7C RID: 211836 RVA: 0x006F68C2 File Offset: 0x006F4AC2
		public static Offset<IStopNewMoveWithSplineAtStartPoint> EndIStopNewMoveWithSplineAtStartPoint(FlatBufferBuilder builder)
		{
			return new Offset<IStopNewMoveWithSplineAtStartPoint>(builder.EndTable());
		}

		// Token: 0x06033B7D RID: 211837 RVA: 0x006F68D0 File Offset: 0x006F4AD0
		public IStopNewMoveWithSplineAtStartPointT UnPack()
		{
			IStopNewMoveWithSplineAtStartPointT stopNewMoveWithSplineAtStartPointT = new IStopNewMoveWithSplineAtStartPointT();
			this.UnPackTo(stopNewMoveWithSplineAtStartPointT);
			return stopNewMoveWithSplineAtStartPointT;
		}

		// Token: 0x06033B7E RID: 211838 RVA: 0x006F68EB File Offset: 0x006F4AEB
		public void UnPackTo(IStopNewMoveWithSplineAtStartPointT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06033B7F RID: 211839 RVA: 0x006F68FC File Offset: 0x006F4AFC
		public static Offset<IStopNewMoveWithSplineAtStartPoint> Pack(FlatBufferBuilder builder, IStopNewMoveWithSplineAtStartPointT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStopNewMoveWithSplineAtStartPoint>);
			}
			return IStopNewMoveWithSplineAtStartPoint.CreateIStopNewMoveWithSplineAtStartPoint(builder, _o.Type);
		}

		// Token: 0x04011CC3 RID: 72899
		private Table __p;
	}
}
