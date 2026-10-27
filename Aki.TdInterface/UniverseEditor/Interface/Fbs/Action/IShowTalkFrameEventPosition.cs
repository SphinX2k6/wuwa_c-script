using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070FD RID: 28925
	public struct IShowTalkFrameEventPosition : IFlatbufferObject
	{
		// Token: 0x1700D706 RID: 55046
		// (get) Token: 0x06033459 RID: 210009 RVA: 0x006E9C3B File Offset: 0x006E7E3B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603345A RID: 210010 RVA: 0x006E9C48 File Offset: 0x006E7E48
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603345B RID: 210011 RVA: 0x006E9C50 File Offset: 0x006E7E50
		public static IShowTalkFrameEventPosition GetRootAsIShowTalkFrameEventPosition(ByteBuffer _bb)
		{
			return IShowTalkFrameEventPosition.GetRootAsIShowTalkFrameEventPosition(_bb, default(IShowTalkFrameEventPosition));
		}

		// Token: 0x0603345C RID: 210012 RVA: 0x006E9C6C File Offset: 0x006E7E6C
		public static IShowTalkFrameEventPosition GetRootAsIShowTalkFrameEventPosition(ByteBuffer _bb, IShowTalkFrameEventPosition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603345D RID: 210013 RVA: 0x006E9C89 File Offset: 0x006E7E89
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603345E RID: 210014 RVA: 0x006E9C98 File Offset: 0x006E7E98
		public IShowTalkFrameEventPosition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D707 RID: 55047
		// (get) Token: 0x0603345F RID: 210015 RVA: 0x006E9CA8 File Offset: 0x006E7EA8
		public int TalkItemId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D708 RID: 55048
		// (get) Token: 0x06033460 RID: 210016 RVA: 0x006E9CE4 File Offset: 0x006E7EE4
		public int Offset
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033461 RID: 210017 RVA: 0x006E9D20 File Offset: 0x006E7F20
		public static Offset<IShowTalkFrameEventPosition> CreateIShowTalkFrameEventPosition(FlatBufferBuilder builder, int TalkItemId = 0, int Offset = 0)
		{
			builder.StartTable(2);
			IShowTalkFrameEventPosition.AddOffset(builder, Offset);
			IShowTalkFrameEventPosition.AddTalkItemId(builder, TalkItemId);
			return IShowTalkFrameEventPosition.EndIShowTalkFrameEventPosition(builder);
		}

		// Token: 0x06033462 RID: 210018 RVA: 0x006E9D3D File Offset: 0x006E7F3D
		public static void StartIShowTalkFrameEventPosition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06033463 RID: 210019 RVA: 0x006E9D46 File Offset: 0x006E7F46
		public static void AddTalkItemId(FlatBufferBuilder builder, int talkItemId)
		{
			builder.AddInt(0, talkItemId, 0);
		}

		// Token: 0x06033464 RID: 210020 RVA: 0x006E9D51 File Offset: 0x006E7F51
		public static void AddOffset(FlatBufferBuilder builder, int offset)
		{
			builder.AddInt(1, offset, 0);
		}

		// Token: 0x06033465 RID: 210021 RVA: 0x006E9D5C File Offset: 0x006E7F5C
		public static Offset<IShowTalkFrameEventPosition> EndIShowTalkFrameEventPosition(FlatBufferBuilder builder)
		{
			return new Offset<IShowTalkFrameEventPosition>(builder.EndTable());
		}

		// Token: 0x06033466 RID: 210022 RVA: 0x006E9D6C File Offset: 0x006E7F6C
		public IShowTalkFrameEventPositionT UnPack()
		{
			IShowTalkFrameEventPositionT showTalkFrameEventPositionT = new IShowTalkFrameEventPositionT();
			this.UnPackTo(showTalkFrameEventPositionT);
			return showTalkFrameEventPositionT;
		}

		// Token: 0x06033467 RID: 210023 RVA: 0x006E9D87 File Offset: 0x006E7F87
		public void UnPackTo(IShowTalkFrameEventPositionT _o)
		{
			_o.TalkItemId = this.TalkItemId;
			_o.Offset = this.Offset;
		}

		// Token: 0x06033468 RID: 210024 RVA: 0x006E9DA4 File Offset: 0x006E7FA4
		public static Offset<IShowTalkFrameEventPosition> Pack(FlatBufferBuilder builder, IShowTalkFrameEventPositionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IShowTalkFrameEventPosition>);
			}
			return IShowTalkFrameEventPosition.CreateIShowTalkFrameEventPosition(builder, _o.TalkItemId, _o.Offset);
		}

		// Token: 0x04011B8B RID: 72587
		private Table __p;
	}
}
