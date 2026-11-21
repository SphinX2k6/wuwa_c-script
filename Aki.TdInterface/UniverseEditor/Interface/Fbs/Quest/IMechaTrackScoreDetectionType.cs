using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200435E RID: 17246
	public struct IMechaTrackScoreDetectionType : IFlatbufferObject
	{
		// Token: 0x1700764F RID: 30287
		// (get) Token: 0x06018576 RID: 99702 RVA: 0x00378C9F File Offset: 0x00376E9F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018577 RID: 99703 RVA: 0x00378CAC File Offset: 0x00376EAC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018578 RID: 99704 RVA: 0x00378CB4 File Offset: 0x00376EB4
		public static IMechaTrackScoreDetectionType GetRootAsIMechaTrackScoreDetectionType(ByteBuffer _bb)
		{
			return IMechaTrackScoreDetectionType.GetRootAsIMechaTrackScoreDetectionType(_bb, default(IMechaTrackScoreDetectionType));
		}

		// Token: 0x06018579 RID: 99705 RVA: 0x00378CD0 File Offset: 0x00376ED0
		public static IMechaTrackScoreDetectionType GetRootAsIMechaTrackScoreDetectionType(ByteBuffer _bb, IMechaTrackScoreDetectionType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601857A RID: 99706 RVA: 0x00378CED File Offset: 0x00376EED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601857B RID: 99707 RVA: 0x00378CFC File Offset: 0x00376EFC
		public IMechaTrackScoreDetectionType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007650 RID: 30288
		// (get) Token: 0x0601857C RID: 99708 RVA: 0x00378D0C File Offset: 0x00376F0C
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

		// Token: 0x0601857D RID: 99709 RVA: 0x00378D48 File Offset: 0x00376F48
		public static Offset<IMechaTrackScoreDetectionType> CreateIMechaTrackScoreDetectionType(FlatBufferBuilder builder, EMechaTrackScoreDetectionType Type = EMechaTrackScoreDetectionType.StuntAction)
		{
			builder.StartTable(1);
			IMechaTrackScoreDetectionType.AddType(builder, Type);
			return IMechaTrackScoreDetectionType.EndIMechaTrackScoreDetectionType(builder);
		}

		// Token: 0x0601857E RID: 99710 RVA: 0x00378D5E File Offset: 0x00376F5E
		public static void StartIMechaTrackScoreDetectionType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601857F RID: 99711 RVA: 0x00378D67 File Offset: 0x00376F67
		public static void AddType(FlatBufferBuilder builder, EMechaTrackScoreDetectionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06018580 RID: 99712 RVA: 0x00378D72 File Offset: 0x00376F72
		public static Offset<IMechaTrackScoreDetectionType> EndIMechaTrackScoreDetectionType(FlatBufferBuilder builder)
		{
			return new Offset<IMechaTrackScoreDetectionType>(builder.EndTable());
		}

		// Token: 0x06018581 RID: 99713 RVA: 0x00378D80 File Offset: 0x00376F80
		public IMechaTrackScoreDetectionTypeT UnPack()
		{
			IMechaTrackScoreDetectionTypeT mechaTrackScoreDetectionTypeT = new IMechaTrackScoreDetectionTypeT();
			this.UnPackTo(mechaTrackScoreDetectionTypeT);
			return mechaTrackScoreDetectionTypeT;
		}

		// Token: 0x06018582 RID: 99714 RVA: 0x00378D9B File Offset: 0x00376F9B
		public void UnPackTo(IMechaTrackScoreDetectionTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06018583 RID: 99715 RVA: 0x00378DAC File Offset: 0x00376FAC
		public static Offset<IMechaTrackScoreDetectionType> Pack(FlatBufferBuilder builder, IMechaTrackScoreDetectionTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMechaTrackScoreDetectionType>);
			}
			return IMechaTrackScoreDetectionType.CreateIMechaTrackScoreDetectionType(builder, _o.Type);
		}

		// Token: 0x0400C304 RID: 49924
		private Table __p;
	}
}
