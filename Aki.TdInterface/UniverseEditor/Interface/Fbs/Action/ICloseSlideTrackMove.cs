using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006433 RID: 25651
	public struct ICloseSlideTrackMove : IFlatbufferObject
	{
		// Token: 0x1700BEFE RID: 48894
		// (get) Token: 0x0602C641 RID: 181825 RVA: 0x006173B4 File Offset: 0x006155B4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C642 RID: 181826 RVA: 0x006173C1 File Offset: 0x006155C1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C643 RID: 181827 RVA: 0x006173C8 File Offset: 0x006155C8
		public static ICloseSlideTrackMove GetRootAsICloseSlideTrackMove(ByteBuffer _bb)
		{
			return ICloseSlideTrackMove.GetRootAsICloseSlideTrackMove(_bb, default(ICloseSlideTrackMove));
		}

		// Token: 0x0602C644 RID: 181828 RVA: 0x006173E4 File Offset: 0x006155E4
		public static ICloseSlideTrackMove GetRootAsICloseSlideTrackMove(ByteBuffer _bb, ICloseSlideTrackMove obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C645 RID: 181829 RVA: 0x00617401 File Offset: 0x00615601
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C646 RID: 181830 RVA: 0x00617410 File Offset: 0x00615610
		public ICloseSlideTrackMove __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BEFF RID: 48895
		// (get) Token: 0x0602C647 RID: 181831 RVA: 0x00617420 File Offset: 0x00615620
		public ESplineMovePattern Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESplineMovePattern.PathLine;
				}
				return (ESplineMovePattern)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BF00 RID: 48896
		// (get) Token: 0x0602C648 RID: 181832 RVA: 0x0061745C File Offset: 0x0061565C
		public float GravitySwitchAngularVelocity
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BF01 RID: 48897
		// (get) Token: 0x0602C649 RID: 181833 RVA: 0x0061749C File Offset: 0x0061569C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602C64A RID: 181834 RVA: 0x006174D8 File Offset: 0x006156D8
		public static Offset<ICloseSlideTrackMove> CreateICloseSlideTrackMove(FlatBufferBuilder builder, ESplineMovePattern Type = ESplineMovePattern.PathLine, float GravitySwitchAngularVelocity = 0f, byte NullMask = 0)
		{
			builder.StartTable(3);
			ICloseSlideTrackMove.AddGravitySwitchAngularVelocity(builder, GravitySwitchAngularVelocity);
			ICloseSlideTrackMove.AddNullMask(builder, NullMask);
			ICloseSlideTrackMove.AddType(builder, Type);
			return ICloseSlideTrackMove.EndICloseSlideTrackMove(builder);
		}

		// Token: 0x0602C64B RID: 181835 RVA: 0x006174FC File Offset: 0x006156FC
		public static void StartICloseSlideTrackMove(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602C64C RID: 181836 RVA: 0x00617505 File Offset: 0x00615705
		public static void AddType(FlatBufferBuilder builder, ESplineMovePattern type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602C64D RID: 181837 RVA: 0x00617510 File Offset: 0x00615710
		public static void AddGravitySwitchAngularVelocity(FlatBufferBuilder builder, float gravitySwitchAngularVelocity)
		{
			builder.AddFloat(1, gravitySwitchAngularVelocity, 0.0);
		}

		// Token: 0x0602C64E RID: 181838 RVA: 0x00617523 File Offset: 0x00615723
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602C64F RID: 181839 RVA: 0x0061752E File Offset: 0x0061572E
		public static Offset<ICloseSlideTrackMove> EndICloseSlideTrackMove(FlatBufferBuilder builder)
		{
			return new Offset<ICloseSlideTrackMove>(builder.EndTable());
		}

		// Token: 0x0602C650 RID: 181840 RVA: 0x0061753C File Offset: 0x0061573C
		public ICloseSlideTrackMoveT UnPack()
		{
			ICloseSlideTrackMoveT closeSlideTrackMoveT = new ICloseSlideTrackMoveT();
			this.UnPackTo(closeSlideTrackMoveT);
			return closeSlideTrackMoveT;
		}

		// Token: 0x0602C651 RID: 181841 RVA: 0x00617557 File Offset: 0x00615757
		public void UnPackTo(ICloseSlideTrackMoveT _o)
		{
			_o.Type = this.Type;
			_o.GravitySwitchAngularVelocity = this.GravitySwitchAngularVelocity;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602C652 RID: 181842 RVA: 0x00617580 File Offset: 0x00615780
		public static Offset<ICloseSlideTrackMove> Pack(FlatBufferBuilder builder, ICloseSlideTrackMoveT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICloseSlideTrackMove>);
			}
			return ICloseSlideTrackMove.CreateICloseSlideTrackMove(builder, _o.Type, _o.GravitySwitchAngularVelocity, _o.NullMask);
		}

		// Token: 0x04010A24 RID: 68132
		private Table __p;
	}
}
