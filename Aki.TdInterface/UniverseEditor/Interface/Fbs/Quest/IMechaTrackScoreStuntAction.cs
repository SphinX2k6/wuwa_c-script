using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F2C RID: 16172
	public struct IMechaTrackScoreStuntAction : IFlatbufferObject
	{
		// Token: 0x17007071 RID: 28785
		// (get) Token: 0x06016F78 RID: 94072 RVA: 0x00350477 File Offset: 0x0034E677
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016F79 RID: 94073 RVA: 0x00350484 File Offset: 0x0034E684
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016F7A RID: 94074 RVA: 0x0035048C File Offset: 0x0034E68C
		public static IMechaTrackScoreStuntAction GetRootAsIMechaTrackScoreStuntAction(ByteBuffer _bb)
		{
			return IMechaTrackScoreStuntAction.GetRootAsIMechaTrackScoreStuntAction(_bb, default(IMechaTrackScoreStuntAction));
		}

		// Token: 0x06016F7B RID: 94075 RVA: 0x003504A8 File Offset: 0x0034E6A8
		public static IMechaTrackScoreStuntAction GetRootAsIMechaTrackScoreStuntAction(ByteBuffer _bb, IMechaTrackScoreStuntAction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016F7C RID: 94076 RVA: 0x003504C5 File Offset: 0x0034E6C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016F7D RID: 94077 RVA: 0x003504D4 File Offset: 0x0034E6D4
		public IMechaTrackScoreStuntAction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007072 RID: 28786
		// (get) Token: 0x06016F7E RID: 94078 RVA: 0x003504E4 File Offset: 0x0034E6E4
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

		// Token: 0x06016F7F RID: 94079 RVA: 0x00350520 File Offset: 0x0034E720
		public static Offset<IMechaTrackScoreStuntAction> CreateIMechaTrackScoreStuntAction(FlatBufferBuilder builder, EMechaTrackScoreDetectionType Type = EMechaTrackScoreDetectionType.StuntAction)
		{
			builder.StartTable(1);
			IMechaTrackScoreStuntAction.AddType(builder, Type);
			return IMechaTrackScoreStuntAction.EndIMechaTrackScoreStuntAction(builder);
		}

		// Token: 0x06016F80 RID: 94080 RVA: 0x00350536 File Offset: 0x0034E736
		public static void StartIMechaTrackScoreStuntAction(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06016F81 RID: 94081 RVA: 0x0035053F File Offset: 0x0034E73F
		public static void AddType(FlatBufferBuilder builder, EMechaTrackScoreDetectionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016F82 RID: 94082 RVA: 0x0035054A File Offset: 0x0034E74A
		public static Offset<IMechaTrackScoreStuntAction> EndIMechaTrackScoreStuntAction(FlatBufferBuilder builder)
		{
			return new Offset<IMechaTrackScoreStuntAction>(builder.EndTable());
		}

		// Token: 0x06016F83 RID: 94083 RVA: 0x00350558 File Offset: 0x0034E758
		public IMechaTrackScoreStuntActionT UnPack()
		{
			IMechaTrackScoreStuntActionT mechaTrackScoreStuntActionT = new IMechaTrackScoreStuntActionT();
			this.UnPackTo(mechaTrackScoreStuntActionT);
			return mechaTrackScoreStuntActionT;
		}

		// Token: 0x06016F84 RID: 94084 RVA: 0x00350573 File Offset: 0x0034E773
		public void UnPackTo(IMechaTrackScoreStuntActionT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06016F85 RID: 94085 RVA: 0x00350584 File Offset: 0x0034E784
		public static Offset<IMechaTrackScoreStuntAction> Pack(FlatBufferBuilder builder, IMechaTrackScoreStuntActionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMechaTrackScoreStuntAction>);
			}
			return IMechaTrackScoreStuntAction.CreateIMechaTrackScoreStuntAction(builder, _o.Type);
		}

		// Token: 0x0400B938 RID: 47416
		private Table __p;
	}
}
