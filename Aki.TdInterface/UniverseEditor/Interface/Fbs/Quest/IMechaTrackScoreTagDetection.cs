using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200436D RID: 17261
	public struct IMechaTrackScoreTagDetection : IFlatbufferObject
	{
		// Token: 0x17007663 RID: 30307
		// (get) Token: 0x060185E2 RID: 99810 RVA: 0x00379815 File Offset: 0x00377A15
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060185E3 RID: 99811 RVA: 0x00379822 File Offset: 0x00377A22
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060185E4 RID: 99812 RVA: 0x0037982C File Offset: 0x00377A2C
		public static IMechaTrackScoreTagDetection GetRootAsIMechaTrackScoreTagDetection(ByteBuffer _bb)
		{
			return IMechaTrackScoreTagDetection.GetRootAsIMechaTrackScoreTagDetection(_bb, default(IMechaTrackScoreTagDetection));
		}

		// Token: 0x060185E5 RID: 99813 RVA: 0x00379848 File Offset: 0x00377A48
		public static IMechaTrackScoreTagDetection GetRootAsIMechaTrackScoreTagDetection(ByteBuffer _bb, IMechaTrackScoreTagDetection obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060185E6 RID: 99814 RVA: 0x00379865 File Offset: 0x00377A65
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060185E7 RID: 99815 RVA: 0x00379874 File Offset: 0x00377A74
		public IMechaTrackScoreTagDetection __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007664 RID: 30308
		// (get) Token: 0x060185E8 RID: 99816 RVA: 0x00379884 File Offset: 0x00377A84
		public EMechaTrackScoreDetectionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMechaTrackScoreDetectionType.StuntAction;
				}
				return (EMechaTrackScoreDetectionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060185E9 RID: 99817 RVA: 0x003798C0 File Offset: 0x00377AC0
		public static Offset<IMechaTrackScoreTagDetection> CreateIMechaTrackScoreTagDetection(FlatBufferBuilder builder, EMechaTrackScoreDetectionType Type = EMechaTrackScoreDetectionType.StuntAction)
		{
			builder.StartTable(1);
			IMechaTrackScoreTagDetection.AddType(builder, Type);
			return IMechaTrackScoreTagDetection.EndIMechaTrackScoreTagDetection(builder);
		}

		// Token: 0x060185EA RID: 99818 RVA: 0x003798D6 File Offset: 0x00377AD6
		public static void StartIMechaTrackScoreTagDetection(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060185EB RID: 99819 RVA: 0x003798DF File Offset: 0x00377ADF
		public static void AddType(FlatBufferBuilder builder, EMechaTrackScoreDetectionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060185EC RID: 99820 RVA: 0x003798EA File Offset: 0x00377AEA
		public static Offset<IMechaTrackScoreTagDetection> EndIMechaTrackScoreTagDetection(FlatBufferBuilder builder)
		{
			return new Offset<IMechaTrackScoreTagDetection>(builder.EndTable());
		}

		// Token: 0x060185ED RID: 99821 RVA: 0x003798F8 File Offset: 0x00377AF8
		public IMechaTrackScoreTagDetectionT UnPack()
		{
			IMechaTrackScoreTagDetectionT mechaTrackScoreTagDetectionT = new IMechaTrackScoreTagDetectionT();
			this.UnPackTo(mechaTrackScoreTagDetectionT);
			return mechaTrackScoreTagDetectionT;
		}

		// Token: 0x060185EE RID: 99822 RVA: 0x00379913 File Offset: 0x00377B13
		public void UnPackTo(IMechaTrackScoreTagDetectionT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060185EF RID: 99823 RVA: 0x00379924 File Offset: 0x00377B24
		public static Offset<IMechaTrackScoreTagDetection> Pack(FlatBufferBuilder builder, IMechaTrackScoreTagDetectionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMechaTrackScoreTagDetection>);
			}
			return IMechaTrackScoreTagDetection.CreateIMechaTrackScoreTagDetection(builder, _o.Type);
		}

		// Token: 0x0400C317 RID: 49943
		private Table __p;
	}
}
