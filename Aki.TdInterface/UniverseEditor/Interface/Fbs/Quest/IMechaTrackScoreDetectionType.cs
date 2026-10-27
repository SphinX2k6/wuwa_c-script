using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F20 RID: 16160
	public struct IMechaTrackScoreDetectionType : IFlatbufferObject
	{
		// Token: 0x17007060 RID: 28768
		// (get) Token: 0x06016F1E RID: 93982 RVA: 0x0034FA77 File Offset: 0x0034DC77
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016F1F RID: 93983 RVA: 0x0034FA84 File Offset: 0x0034DC84
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016F20 RID: 93984 RVA: 0x0034FA8C File Offset: 0x0034DC8C
		public static IMechaTrackScoreDetectionType GetRootAsIMechaTrackScoreDetectionType(ByteBuffer _bb)
		{
			return IMechaTrackScoreDetectionType.GetRootAsIMechaTrackScoreDetectionType(_bb, default(IMechaTrackScoreDetectionType));
		}

		// Token: 0x06016F21 RID: 93985 RVA: 0x0034FAA8 File Offset: 0x0034DCA8
		public static IMechaTrackScoreDetectionType GetRootAsIMechaTrackScoreDetectionType(ByteBuffer _bb, IMechaTrackScoreDetectionType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016F22 RID: 93986 RVA: 0x0034FAC5 File Offset: 0x0034DCC5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016F23 RID: 93987 RVA: 0x0034FAD4 File Offset: 0x0034DCD4
		public IMechaTrackScoreDetectionType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007061 RID: 28769
		// (get) Token: 0x06016F24 RID: 93988 RVA: 0x0034FAE4 File Offset: 0x0034DCE4
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

		// Token: 0x06016F25 RID: 93989 RVA: 0x0034FB20 File Offset: 0x0034DD20
		public static Offset<IMechaTrackScoreDetectionType> CreateIMechaTrackScoreDetectionType(FlatBufferBuilder builder, EMechaTrackScoreDetectionType Type = EMechaTrackScoreDetectionType.StuntAction)
		{
			builder.StartTable(1);
			IMechaTrackScoreDetectionType.AddType(builder, Type);
			return IMechaTrackScoreDetectionType.EndIMechaTrackScoreDetectionType(builder);
		}

		// Token: 0x06016F26 RID: 93990 RVA: 0x0034FB36 File Offset: 0x0034DD36
		public static void StartIMechaTrackScoreDetectionType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06016F27 RID: 93991 RVA: 0x0034FB3F File Offset: 0x0034DD3F
		public static void AddType(FlatBufferBuilder builder, EMechaTrackScoreDetectionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016F28 RID: 93992 RVA: 0x0034FB4A File Offset: 0x0034DD4A
		public static Offset<IMechaTrackScoreDetectionType> EndIMechaTrackScoreDetectionType(FlatBufferBuilder builder)
		{
			return new Offset<IMechaTrackScoreDetectionType>(builder.EndTable());
		}

		// Token: 0x06016F29 RID: 93993 RVA: 0x0034FB58 File Offset: 0x0034DD58
		public IMechaTrackScoreDetectionTypeT UnPack()
		{
			IMechaTrackScoreDetectionTypeT mechaTrackScoreDetectionTypeT = new IMechaTrackScoreDetectionTypeT();
			this.UnPackTo(mechaTrackScoreDetectionTypeT);
			return mechaTrackScoreDetectionTypeT;
		}

		// Token: 0x06016F2A RID: 93994 RVA: 0x0034FB73 File Offset: 0x0034DD73
		public void UnPackTo(IMechaTrackScoreDetectionTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06016F2B RID: 93995 RVA: 0x0034FB84 File Offset: 0x0034DD84
		public static Offset<IMechaTrackScoreDetectionType> Pack(FlatBufferBuilder builder, IMechaTrackScoreDetectionTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMechaTrackScoreDetectionType>);
			}
			return IMechaTrackScoreDetectionType.CreateIMechaTrackScoreDetectionType(builder, _o.Type);
		}

		// Token: 0x0400B927 RID: 47399
		private Table __p;
	}
}
