using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C87 RID: 27783
	public struct IPerformerAiMoveToPlayer : IFlatbufferObject
	{
		// Token: 0x1700CEE7 RID: 52967
		// (get) Token: 0x06030F51 RID: 200529 RVA: 0x006A5AFA File Offset: 0x006A3CFA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030F52 RID: 200530 RVA: 0x006A5B07 File Offset: 0x006A3D07
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030F53 RID: 200531 RVA: 0x006A5B10 File Offset: 0x006A3D10
		public static IPerformerAiMoveToPlayer GetRootAsIPerformerAiMoveToPlayer(ByteBuffer _bb)
		{
			return IPerformerAiMoveToPlayer.GetRootAsIPerformerAiMoveToPlayer(_bb, default(IPerformerAiMoveToPlayer));
		}

		// Token: 0x06030F54 RID: 200532 RVA: 0x006A5B2C File Offset: 0x006A3D2C
		public static IPerformerAiMoveToPlayer GetRootAsIPerformerAiMoveToPlayer(ByteBuffer _bb, IPerformerAiMoveToPlayer obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030F55 RID: 200533 RVA: 0x006A5B49 File Offset: 0x006A3D49
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030F56 RID: 200534 RVA: 0x006A5B58 File Offset: 0x006A3D58
		public IPerformerAiMoveToPlayer __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CEE8 RID: 52968
		// (get) Token: 0x06030F57 RID: 200535 RVA: 0x006A5B68 File Offset: 0x006A3D68
		public EPerformerAiMoveToType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPerformerAiMoveToType.Position;
				}
				return (EPerformerAiMoveToType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030F58 RID: 200536 RVA: 0x006A5BA4 File Offset: 0x006A3DA4
		public static Offset<IPerformerAiMoveToPlayer> CreateIPerformerAiMoveToPlayer(FlatBufferBuilder builder, EPerformerAiMoveToType Type = EPerformerAiMoveToType.Position)
		{
			builder.StartTable(1);
			IPerformerAiMoveToPlayer.AddType(builder, Type);
			return IPerformerAiMoveToPlayer.EndIPerformerAiMoveToPlayer(builder);
		}

		// Token: 0x06030F59 RID: 200537 RVA: 0x006A5BBA File Offset: 0x006A3DBA
		public static void StartIPerformerAiMoveToPlayer(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06030F5A RID: 200538 RVA: 0x006A5BC3 File Offset: 0x006A3DC3
		public static void AddType(FlatBufferBuilder builder, EPerformerAiMoveToType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030F5B RID: 200539 RVA: 0x006A5BCE File Offset: 0x006A3DCE
		public static Offset<IPerformerAiMoveToPlayer> EndIPerformerAiMoveToPlayer(FlatBufferBuilder builder)
		{
			return new Offset<IPerformerAiMoveToPlayer>(builder.EndTable());
		}

		// Token: 0x06030F5C RID: 200540 RVA: 0x006A5BDC File Offset: 0x006A3DDC
		public IPerformerAiMoveToPlayerT UnPack()
		{
			IPerformerAiMoveToPlayerT performerAiMoveToPlayerT = new IPerformerAiMoveToPlayerT();
			this.UnPackTo(performerAiMoveToPlayerT);
			return performerAiMoveToPlayerT;
		}

		// Token: 0x06030F5D RID: 200541 RVA: 0x006A5BF7 File Offset: 0x006A3DF7
		public void UnPackTo(IPerformerAiMoveToPlayerT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06030F5E RID: 200542 RVA: 0x006A5C08 File Offset: 0x006A3E08
		public static Offset<IPerformerAiMoveToPlayer> Pack(FlatBufferBuilder builder, IPerformerAiMoveToPlayerT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPerformerAiMoveToPlayer>);
			}
			return IPerformerAiMoveToPlayer.CreateIPerformerAiMoveToPlayer(builder, _o.Type);
		}

		// Token: 0x040115DC RID: 71132
		private Table __p;
	}
}
