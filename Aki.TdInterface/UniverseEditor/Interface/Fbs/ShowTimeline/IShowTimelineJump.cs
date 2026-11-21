using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003FCA RID: 16330
	public struct IShowTimelineJump : IFlatbufferObject
	{
		// Token: 0x17006E93 RID: 28307
		// (get) Token: 0x060164DF RID: 91359 RVA: 0x00332190 File Offset: 0x00330390
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060164E0 RID: 91360 RVA: 0x0033219D File Offset: 0x0033039D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060164E1 RID: 91361 RVA: 0x003321A4 File Offset: 0x003303A4
		public static IShowTimelineJump GetRootAsIShowTimelineJump(ByteBuffer _bb)
		{
			return IShowTimelineJump.GetRootAsIShowTimelineJump(_bb, default(IShowTimelineJump));
		}

		// Token: 0x060164E2 RID: 91362 RVA: 0x003321C0 File Offset: 0x003303C0
		public static IShowTimelineJump GetRootAsIShowTimelineJump(ByteBuffer _bb, IShowTimelineJump obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060164E3 RID: 91363 RVA: 0x003321DD File Offset: 0x003303DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060164E4 RID: 91364 RVA: 0x003321EC File Offset: 0x003303EC
		public IShowTimelineJump __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006E94 RID: 28308
		// (get) Token: 0x060164E5 RID: 91365 RVA: 0x003321FC File Offset: 0x003303FC
		public EShowTimelineActionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EShowTimelineActionType.Skill;
				}
				return (EShowTimelineActionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060164E6 RID: 91366 RVA: 0x00332238 File Offset: 0x00330438
		public static Offset<IShowTimelineJump> CreateIShowTimelineJump(FlatBufferBuilder builder, EShowTimelineActionType Type = EShowTimelineActionType.Skill)
		{
			builder.StartTable(1);
			IShowTimelineJump.AddType(builder, Type);
			return IShowTimelineJump.EndIShowTimelineJump(builder);
		}

		// Token: 0x060164E7 RID: 91367 RVA: 0x0033224E File Offset: 0x0033044E
		public static void StartIShowTimelineJump(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060164E8 RID: 91368 RVA: 0x00332257 File Offset: 0x00330457
		public static void AddType(FlatBufferBuilder builder, EShowTimelineActionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060164E9 RID: 91369 RVA: 0x00332262 File Offset: 0x00330462
		public static Offset<IShowTimelineJump> EndIShowTimelineJump(FlatBufferBuilder builder)
		{
			return new Offset<IShowTimelineJump>(builder.EndTable());
		}

		// Token: 0x060164EA RID: 91370 RVA: 0x00332270 File Offset: 0x00330470
		public IShowTimelineJumpT UnPack()
		{
			IShowTimelineJumpT showTimelineJumpT = new IShowTimelineJumpT();
			this.UnPackTo(showTimelineJumpT);
			return showTimelineJumpT;
		}

		// Token: 0x060164EB RID: 91371 RVA: 0x0033228B File Offset: 0x0033048B
		public void UnPackTo(IShowTimelineJumpT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060164EC RID: 91372 RVA: 0x0033229C File Offset: 0x0033049C
		public static Offset<IShowTimelineJump> Pack(FlatBufferBuilder builder, IShowTimelineJumpT _o)
		{
			if (_o == null)
			{
				return default(Offset<IShowTimelineJump>);
			}
			return IShowTimelineJump.CreateIShowTimelineJump(builder, _o.Type);
		}

		// Token: 0x0400BACA RID: 47818
		private Table __p;
	}
}
