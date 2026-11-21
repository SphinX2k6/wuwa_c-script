using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200436A RID: 17258
	public struct IMechaTrackScoreStuntAction : IFlatbufferObject
	{
		// Token: 0x17007660 RID: 30304
		// (get) Token: 0x060185D0 RID: 99792 RVA: 0x0037969F File Offset: 0x0037789F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060185D1 RID: 99793 RVA: 0x003796AC File Offset: 0x003778AC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060185D2 RID: 99794 RVA: 0x003796B4 File Offset: 0x003778B4
		public static IMechaTrackScoreStuntAction GetRootAsIMechaTrackScoreStuntAction(ByteBuffer _bb)
		{
			return IMechaTrackScoreStuntAction.GetRootAsIMechaTrackScoreStuntAction(_bb, default(IMechaTrackScoreStuntAction));
		}

		// Token: 0x060185D3 RID: 99795 RVA: 0x003796D0 File Offset: 0x003778D0
		public static IMechaTrackScoreStuntAction GetRootAsIMechaTrackScoreStuntAction(ByteBuffer _bb, IMechaTrackScoreStuntAction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060185D4 RID: 99796 RVA: 0x003796ED File Offset: 0x003778ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060185D5 RID: 99797 RVA: 0x003796FC File Offset: 0x003778FC
		public IMechaTrackScoreStuntAction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007661 RID: 30305
		// (get) Token: 0x060185D6 RID: 99798 RVA: 0x0037970C File Offset: 0x0037790C
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

		// Token: 0x060185D7 RID: 99799 RVA: 0x00379748 File Offset: 0x00377948
		public static Offset<IMechaTrackScoreStuntAction> CreateIMechaTrackScoreStuntAction(FlatBufferBuilder builder, EMechaTrackScoreDetectionType Type = EMechaTrackScoreDetectionType.StuntAction)
		{
			builder.StartTable(1);
			IMechaTrackScoreStuntAction.AddType(builder, Type);
			return IMechaTrackScoreStuntAction.EndIMechaTrackScoreStuntAction(builder);
		}

		// Token: 0x060185D8 RID: 99800 RVA: 0x0037975E File Offset: 0x0037795E
		public static void StartIMechaTrackScoreStuntAction(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060185D9 RID: 99801 RVA: 0x00379767 File Offset: 0x00377967
		public static void AddType(FlatBufferBuilder builder, EMechaTrackScoreDetectionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060185DA RID: 99802 RVA: 0x00379772 File Offset: 0x00377972
		public static Offset<IMechaTrackScoreStuntAction> EndIMechaTrackScoreStuntAction(FlatBufferBuilder builder)
		{
			return new Offset<IMechaTrackScoreStuntAction>(builder.EndTable());
		}

		// Token: 0x060185DB RID: 99803 RVA: 0x00379780 File Offset: 0x00377980
		public IMechaTrackScoreStuntActionT UnPack()
		{
			IMechaTrackScoreStuntActionT mechaTrackScoreStuntActionT = new IMechaTrackScoreStuntActionT();
			this.UnPackTo(mechaTrackScoreStuntActionT);
			return mechaTrackScoreStuntActionT;
		}

		// Token: 0x060185DC RID: 99804 RVA: 0x0037979B File Offset: 0x0037799B
		public void UnPackTo(IMechaTrackScoreStuntActionT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060185DD RID: 99805 RVA: 0x003797AC File Offset: 0x003779AC
		public static Offset<IMechaTrackScoreStuntAction> Pack(FlatBufferBuilder builder, IMechaTrackScoreStuntActionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMechaTrackScoreStuntAction>);
			}
			return IMechaTrackScoreStuntAction.CreateIMechaTrackScoreStuntAction(builder, _o.Type);
		}

		// Token: 0x0400C315 RID: 49941
		private Table __p;
	}
}
