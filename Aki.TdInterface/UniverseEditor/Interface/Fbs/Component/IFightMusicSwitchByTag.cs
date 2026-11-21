using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057B4 RID: 22452
	public struct IFightMusicSwitchByTag : IFlatbufferObject
	{
		// Token: 0x1700A253 RID: 41555
		// (get) Token: 0x060243E5 RID: 148453 RVA: 0x004FB5CE File Offset: 0x004F97CE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060243E6 RID: 148454 RVA: 0x004FB5DB File Offset: 0x004F97DB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060243E7 RID: 148455 RVA: 0x004FB5E4 File Offset: 0x004F97E4
		public static IFightMusicSwitchByTag GetRootAsIFightMusicSwitchByTag(ByteBuffer _bb)
		{
			return IFightMusicSwitchByTag.GetRootAsIFightMusicSwitchByTag(_bb, default(IFightMusicSwitchByTag));
		}

		// Token: 0x060243E8 RID: 148456 RVA: 0x004FB600 File Offset: 0x004F9800
		public static IFightMusicSwitchByTag GetRootAsIFightMusicSwitchByTag(ByteBuffer _bb, IFightMusicSwitchByTag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060243E9 RID: 148457 RVA: 0x004FB61D File Offset: 0x004F981D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060243EA RID: 148458 RVA: 0x004FB62C File Offset: 0x004F982C
		public IFightMusicSwitchByTag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A254 RID: 41556
		// (get) Token: 0x060243EB RID: 148459 RVA: 0x004FB63C File Offset: 0x004F983C
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

		// Token: 0x060243EC RID: 148460 RVA: 0x004FB673 File Offset: 0x004F9873
		public Span<byte> GetFightMusicBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x060243ED RID: 148461 RVA: 0x004FB682 File Offset: 0x004F9882
		public byte[] GetFightMusicArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700A255 RID: 41557
		// (get) Token: 0x060243EE RID: 148462 RVA: 0x004FB690 File Offset: 0x004F9890
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

		// Token: 0x060243EF RID: 148463 RVA: 0x004FB6C7 File Offset: 0x004F98C7
		public Span<byte> GetActivateTagBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060243F0 RID: 148464 RVA: 0x004FB6D6 File Offset: 0x004F98D6
		public byte[] GetActivateTagArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x060243F1 RID: 148465 RVA: 0x004FB6E4 File Offset: 0x004F98E4
		public static Offset<IFightMusicSwitchByTag> CreateIFightMusicSwitchByTag(FlatBufferBuilder builder, StringOffset FightMusicOffset = default(StringOffset), StringOffset ActivateTagOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IFightMusicSwitchByTag.AddActivateTag(builder, ActivateTagOffset);
			IFightMusicSwitchByTag.AddFightMusic(builder, FightMusicOffset);
			return IFightMusicSwitchByTag.EndIFightMusicSwitchByTag(builder);
		}

		// Token: 0x060243F2 RID: 148466 RVA: 0x004FB701 File Offset: 0x004F9901
		public static void StartIFightMusicSwitchByTag(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060243F3 RID: 148467 RVA: 0x004FB70A File Offset: 0x004F990A
		public static void AddFightMusic(FlatBufferBuilder builder, StringOffset fightMusicOffset)
		{
			builder.AddOffset(0, fightMusicOffset.Value, 0);
		}

		// Token: 0x060243F4 RID: 148468 RVA: 0x004FB71A File Offset: 0x004F991A
		public static void AddActivateTag(FlatBufferBuilder builder, StringOffset activateTagOffset)
		{
			builder.AddOffset(1, activateTagOffset.Value, 0);
		}

		// Token: 0x060243F5 RID: 148469 RVA: 0x004FB72A File Offset: 0x004F992A
		public static Offset<IFightMusicSwitchByTag> EndIFightMusicSwitchByTag(FlatBufferBuilder builder)
		{
			return new Offset<IFightMusicSwitchByTag>(builder.EndTable());
		}

		// Token: 0x060243F6 RID: 148470 RVA: 0x004FB738 File Offset: 0x004F9938
		public IFightMusicSwitchByTagT UnPack()
		{
			IFightMusicSwitchByTagT fightMusicSwitchByTagT = new IFightMusicSwitchByTagT();
			this.UnPackTo(fightMusicSwitchByTagT);
			return fightMusicSwitchByTagT;
		}

		// Token: 0x060243F7 RID: 148471 RVA: 0x004FB753 File Offset: 0x004F9953
		public void UnPackTo(IFightMusicSwitchByTagT _o)
		{
			_o.FightMusic = this.FightMusic;
			_o.ActivateTag = this.ActivateTag;
		}

		// Token: 0x060243F8 RID: 148472 RVA: 0x004FB770 File Offset: 0x004F9970
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

		// Token: 0x0400EFA0 RID: 61344
		private Table __p;
	}
}
