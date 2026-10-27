using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071DE RID: 29150
	public struct IStopNewMoveWithSplineAtCurrentPos : IFlatbufferObject
	{
		// Token: 0x1700D885 RID: 55429
		// (get) Token: 0x06033B4E RID: 211790 RVA: 0x006F6500 File Offset: 0x006F4700
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033B4F RID: 211791 RVA: 0x006F650D File Offset: 0x006F470D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033B50 RID: 211792 RVA: 0x006F6514 File Offset: 0x006F4714
		public static IStopNewMoveWithSplineAtCurrentPos GetRootAsIStopNewMoveWithSplineAtCurrentPos(ByteBuffer _bb)
		{
			return IStopNewMoveWithSplineAtCurrentPos.GetRootAsIStopNewMoveWithSplineAtCurrentPos(_bb, default(IStopNewMoveWithSplineAtCurrentPos));
		}

		// Token: 0x06033B51 RID: 211793 RVA: 0x006F6530 File Offset: 0x006F4730
		public static IStopNewMoveWithSplineAtCurrentPos GetRootAsIStopNewMoveWithSplineAtCurrentPos(ByteBuffer _bb, IStopNewMoveWithSplineAtCurrentPos obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033B52 RID: 211794 RVA: 0x006F654D File Offset: 0x006F474D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033B53 RID: 211795 RVA: 0x006F655C File Offset: 0x006F475C
		public IStopNewMoveWithSplineAtCurrentPos __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D886 RID: 55430
		// (get) Token: 0x06033B54 RID: 211796 RVA: 0x006F656C File Offset: 0x006F476C
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

		// Token: 0x06033B55 RID: 211797 RVA: 0x006F65A8 File Offset: 0x006F47A8
		public static Offset<IStopNewMoveWithSplineAtCurrentPos> CreateIStopNewMoveWithSplineAtCurrentPos(FlatBufferBuilder builder, EStopNewMoveWithSplineType Type = EStopNewMoveWithSplineType.StopAtCurrentPos)
		{
			builder.StartTable(1);
			IStopNewMoveWithSplineAtCurrentPos.AddType(builder, Type);
			return IStopNewMoveWithSplineAtCurrentPos.EndIStopNewMoveWithSplineAtCurrentPos(builder);
		}

		// Token: 0x06033B56 RID: 211798 RVA: 0x006F65BE File Offset: 0x006F47BE
		public static void StartIStopNewMoveWithSplineAtCurrentPos(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06033B57 RID: 211799 RVA: 0x006F65C7 File Offset: 0x006F47C7
		public static void AddType(FlatBufferBuilder builder, EStopNewMoveWithSplineType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033B58 RID: 211800 RVA: 0x006F65D2 File Offset: 0x006F47D2
		public static Offset<IStopNewMoveWithSplineAtCurrentPos> EndIStopNewMoveWithSplineAtCurrentPos(FlatBufferBuilder builder)
		{
			return new Offset<IStopNewMoveWithSplineAtCurrentPos>(builder.EndTable());
		}

		// Token: 0x06033B59 RID: 211801 RVA: 0x006F65E0 File Offset: 0x006F47E0
		public IStopNewMoveWithSplineAtCurrentPosT UnPack()
		{
			IStopNewMoveWithSplineAtCurrentPosT stopNewMoveWithSplineAtCurrentPosT = new IStopNewMoveWithSplineAtCurrentPosT();
			this.UnPackTo(stopNewMoveWithSplineAtCurrentPosT);
			return stopNewMoveWithSplineAtCurrentPosT;
		}

		// Token: 0x06033B5A RID: 211802 RVA: 0x006F65FB File Offset: 0x006F47FB
		public void UnPackTo(IStopNewMoveWithSplineAtCurrentPosT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06033B5B RID: 211803 RVA: 0x006F660C File Offset: 0x006F480C
		public static Offset<IStopNewMoveWithSplineAtCurrentPos> Pack(FlatBufferBuilder builder, IStopNewMoveWithSplineAtCurrentPosT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStopNewMoveWithSplineAtCurrentPos>);
			}
			return IStopNewMoveWithSplineAtCurrentPos.CreateIStopNewMoveWithSplineAtCurrentPos(builder, _o.Type);
		}

		// Token: 0x04011CBF RID: 72895
		private Table __p;
	}
}
