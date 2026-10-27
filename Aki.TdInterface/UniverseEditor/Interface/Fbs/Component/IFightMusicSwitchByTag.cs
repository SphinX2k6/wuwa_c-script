using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200524C RID: 21068
	public struct IFightMusicSwitchByTag : IFlatbufferObject
	{
		// Token: 0x17009A57 RID: 39511
		// (get) Token: 0x0602244F RID: 140367 RVA: 0x004C0B0A File Offset: 0x004BED0A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022450 RID: 140368 RVA: 0x004C0B17 File Offset: 0x004BED17
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022451 RID: 140369 RVA: 0x004C0B20 File Offset: 0x004BED20
		public static IFightMusicSwitchByTag GetRootAsIFightMusicSwitchByTag(ByteBuffer _bb)
		{
			return IFightMusicSwitchByTag.GetRootAsIFightMusicSwitchByTag(_bb, default(IFightMusicSwitchByTag));
		}

		// Token: 0x06022452 RID: 140370 RVA: 0x004C0B3C File Offset: 0x004BED3C
		public static IFightMusicSwitchByTag GetRootAsIFightMusicSwitchByTag(ByteBuffer _bb, IFightMusicSwitchByTag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022453 RID: 140371 RVA: 0x004C0B59 File Offset: 0x004BED59
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022454 RID: 140372 RVA: 0x004C0B68 File Offset: 0x004BED68
		public IFightMusicSwitchByTag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009A58 RID: 39512
		// (get) Token: 0x06022455 RID: 140373 RVA: 0x004C0B78 File Offset: 0x004BED78
		public string FightMusic
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06022456 RID: 140374 RVA: 0x004C0BAF File Offset: 0x004BEDAF
		public Span<byte> GetFightMusicBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06022457 RID: 140375 RVA: 0x004C0BBE File Offset: 0x004BEDBE
		public byte[] GetFightMusicArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17009A59 RID: 39513
		// (get) Token: 0x06022458 RID: 140376 RVA: 0x004C0BCC File Offset: 0x004BEDCC
		public string ActivateTag
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06022459 RID: 140377 RVA: 0x004C0C03 File Offset: 0x004BEE03
		public Span<byte> GetActivateTagBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602245A RID: 140378 RVA: 0x004C0C12 File Offset: 0x004BEE12
		public byte[] GetActivateTagArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602245B RID: 140379 RVA: 0x004C0C20 File Offset: 0x004BEE20
		public static Offset<IFightMusicSwitchByTag> CreateIFightMusicSwitchByTag(FlatBufferBuilder builder, StringOffset FightMusicOffset = default(StringOffset), StringOffset ActivateTagOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IFightMusicSwitchByTag.AddActivateTag(builder, ActivateTagOffset);
			IFightMusicSwitchByTag.AddFightMusic(builder, FightMusicOffset);
			return IFightMusicSwitchByTag.EndIFightMusicSwitchByTag(builder);
		}

		// Token: 0x0602245C RID: 140380 RVA: 0x004C0C3D File Offset: 0x004BEE3D
		public static void StartIFightMusicSwitchByTag(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602245D RID: 140381 RVA: 0x004C0C46 File Offset: 0x004BEE46
		public static void AddFightMusic(FlatBufferBuilder builder, StringOffset fightMusicOffset)
		{
			builder.AddOffset(0, fightMusicOffset.Value, 0);
		}

		// Token: 0x0602245E RID: 140382 RVA: 0x004C0C56 File Offset: 0x004BEE56
		public static void AddActivateTag(FlatBufferBuilder builder, StringOffset activateTagOffset)
		{
			builder.AddOffset(1, activateTagOffset.Value, 0);
		}

		// Token: 0x0602245F RID: 140383 RVA: 0x004C0C66 File Offset: 0x004BEE66
		public static Offset<IFightMusicSwitchByTag> EndIFightMusicSwitchByTag(FlatBufferBuilder builder)
		{
			return new Offset<IFightMusicSwitchByTag>(builder.EndTable());
		}

		// Token: 0x06022460 RID: 140384 RVA: 0x004C0C74 File Offset: 0x004BEE74
		public IFightMusicSwitchByTagT UnPack()
		{
			IFightMusicSwitchByTagT fightMusicSwitchByTagT = new IFightMusicSwitchByTagT();
			this.UnPackTo(fightMusicSwitchByTagT);
			return fightMusicSwitchByTagT;
		}

		// Token: 0x06022461 RID: 140385 RVA: 0x004C0C8F File Offset: 0x004BEE8F
		public void UnPackTo(IFightMusicSwitchByTagT _o)
		{
			_o.FightMusic = this.FightMusic;
			_o.ActivateTag = this.ActivateTag;
		}

		// Token: 0x06022462 RID: 140386 RVA: 0x004C0CAC File Offset: 0x004BEEAC
		public static Offset<IFightMusicSwitchByTag> Pack(FlatBufferBuilder builder, IFightMusicSwitchByTagT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFightMusicSwitchByTag>);
			}
			StringOffset fightMusicOffset = (_o.FightMusic == null) ? default(StringOffset) : builder.CreateString(_o.FightMusic);
			StringOffset activateTagOffset = (_o.ActivateTag == null) ? default(StringOffset) : builder.CreateString(_o.ActivateTag);
			return IFightMusicSwitchByTag.CreateIFightMusicSwitchByTag(builder, fightMusicOffset, activateTagOffset);
		}

		// Token: 0x0400E39A RID: 58266
		private Table __p;
	}
}
