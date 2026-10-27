using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003BC2 RID: 15298
	public struct IShowTimelineJump : IFlatbufferObject
	{
		// Token: 0x170068F0 RID: 26864
		// (get) Token: 0x06015007 RID: 86023 RVA: 0x0030B934 File Offset: 0x00309B34
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015008 RID: 86024 RVA: 0x0030B941 File Offset: 0x00309B41
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015009 RID: 86025 RVA: 0x0030B948 File Offset: 0x00309B48
		public static IShowTimelineJump GetRootAsIShowTimelineJump(ByteBuffer _bb)
		{
			return IShowTimelineJump.GetRootAsIShowTimelineJump(_bb, default(IShowTimelineJump));
		}

		// Token: 0x0601500A RID: 86026 RVA: 0x0030B964 File Offset: 0x00309B64
		public static IShowTimelineJump GetRootAsIShowTimelineJump(ByteBuffer _bb, IShowTimelineJump obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601500B RID: 86027 RVA: 0x0030B981 File Offset: 0x00309B81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601500C RID: 86028 RVA: 0x0030B990 File Offset: 0x00309B90
		public IShowTimelineJump __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170068F1 RID: 26865
		// (get) Token: 0x0601500D RID: 86029 RVA: 0x0030B9A0 File Offset: 0x00309BA0
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

		// Token: 0x0601500E RID: 86030 RVA: 0x0030B9DC File Offset: 0x00309BDC
		public static Offset<IShowTimelineJump> CreateIShowTimelineJump(FlatBufferBuilder builder, EShowTimelineActionType Type = EShowTimelineActionType.Skill)
		{
			builder.StartTable(1);
			IShowTimelineJump.AddType(builder, Type);
			return IShowTimelineJump.EndIShowTimelineJump(builder);
		}

		// Token: 0x0601500F RID: 86031 RVA: 0x0030B9F2 File Offset: 0x00309BF2
		public static void StartIShowTimelineJump(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06015010 RID: 86032 RVA: 0x0030B9FB File Offset: 0x00309BFB
		public static void AddType(FlatBufferBuilder builder, EShowTimelineActionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015011 RID: 86033 RVA: 0x0030BA06 File Offset: 0x00309C06
		public static Offset<IShowTimelineJump> EndIShowTimelineJump(FlatBufferBuilder builder)
		{
			return new Offset<IShowTimelineJump>(builder.EndTable());
		}

		// Token: 0x06015012 RID: 86034 RVA: 0x0030BA14 File Offset: 0x00309C14
		public IShowTimelineJumpT UnPack()
		{
			IShowTimelineJumpT showTimelineJumpT = new IShowTimelineJumpT();
			this.UnPackTo(showTimelineJumpT);
			return showTimelineJumpT;
		}

		// Token: 0x06015013 RID: 86035 RVA: 0x0030BA2F File Offset: 0x00309C2F
		public void UnPackTo(IShowTimelineJumpT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06015014 RID: 86036 RVA: 0x0030BA40 File Offset: 0x00309C40
		public static Offset<IShowTimelineJump> Pack(FlatBufferBuilder builder, IShowTimelineJumpT _o)
		{
			if (_o == null)
			{
				return default(Offset<IShowTimelineJump>);
			}
			return IShowTimelineJump.CreateIShowTimelineJump(builder, _o.Type);
		}

		// Token: 0x0400B14B RID: 45387
		private Table __p;
	}
}
