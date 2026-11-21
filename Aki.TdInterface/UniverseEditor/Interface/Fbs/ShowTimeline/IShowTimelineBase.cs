using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003FAF RID: 16303
	public struct IShowTimelineBase : IFlatbufferObject
	{
		// Token: 0x17006E4E RID: 28238
		// (get) Token: 0x060163B3 RID: 91059 RVA: 0x0032F9BE File Offset: 0x0032DBBE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060163B4 RID: 91060 RVA: 0x0032F9CB File Offset: 0x0032DBCB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060163B5 RID: 91061 RVA: 0x0032F9D4 File Offset: 0x0032DBD4
		public static IShowTimelineBase GetRootAsIShowTimelineBase(ByteBuffer _bb)
		{
			return IShowTimelineBase.GetRootAsIShowTimelineBase(_bb, default(IShowTimelineBase));
		}

		// Token: 0x060163B6 RID: 91062 RVA: 0x0032F9F0 File Offset: 0x0032DBF0
		public static IShowTimelineBase GetRootAsIShowTimelineBase(ByteBuffer _bb, IShowTimelineBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060163B7 RID: 91063 RVA: 0x0032FA0D File Offset: 0x0032DC0D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060163B8 RID: 91064 RVA: 0x0032FA1C File Offset: 0x0032DC1C
		public IShowTimelineBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006E4F RID: 28239
		// (get) Token: 0x060163B9 RID: 91065 RVA: 0x0032FA2C File Offset: 0x0032DC2C
		public EShowTimelineType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EShowTimelineType.Checkpoint;
				}
				return (EShowTimelineType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060163BA RID: 91066 RVA: 0x0032FA68 File Offset: 0x0032DC68
		public static Offset<IShowTimelineBase> CreateIShowTimelineBase(FlatBufferBuilder builder, EShowTimelineType Type = EShowTimelineType.Checkpoint)
		{
			builder.StartTable(1);
			IShowTimelineBase.AddType(builder, Type);
			return IShowTimelineBase.EndIShowTimelineBase(builder);
		}

		// Token: 0x060163BB RID: 91067 RVA: 0x0032FA7E File Offset: 0x0032DC7E
		public static void StartIShowTimelineBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060163BC RID: 91068 RVA: 0x0032FA87 File Offset: 0x0032DC87
		public static void AddType(FlatBufferBuilder builder, EShowTimelineType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060163BD RID: 91069 RVA: 0x0032FA92 File Offset: 0x0032DC92
		public static Offset<IShowTimelineBase> EndIShowTimelineBase(FlatBufferBuilder builder)
		{
			return new Offset<IShowTimelineBase>(builder.EndTable());
		}

		// Token: 0x060163BE RID: 91070 RVA: 0x0032FAA0 File Offset: 0x0032DCA0
		public IShowTimelineBaseT UnPack()
		{
			IShowTimelineBaseT showTimelineBaseT = new IShowTimelineBaseT();
			this.UnPackTo(showTimelineBaseT);
			return showTimelineBaseT;
		}

		// Token: 0x060163BF RID: 91071 RVA: 0x0032FABB File Offset: 0x0032DCBB
		public void UnPackTo(IShowTimelineBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060163C0 RID: 91072 RVA: 0x0032FACC File Offset: 0x0032DCCC
		public static Offset<IShowTimelineBase> Pack(FlatBufferBuilder builder, IShowTimelineBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IShowTimelineBase>);
			}
			return IShowTimelineBase.CreateIShowTimelineBase(builder, _o.Type);
		}

		// Token: 0x0400BA9B RID: 47771
		private Table __p;
	}
}
