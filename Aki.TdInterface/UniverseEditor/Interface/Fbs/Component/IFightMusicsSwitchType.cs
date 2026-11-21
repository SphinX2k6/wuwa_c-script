using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057AE RID: 22446
	public struct IFightMusicsSwitchType : IFlatbufferObject
	{
		// Token: 0x1700A24E RID: 41550
		// (get) Token: 0x060243C7 RID: 148423 RVA: 0x004FB35C File Offset: 0x004F955C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060243C8 RID: 148424 RVA: 0x004FB369 File Offset: 0x004F9569
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060243C9 RID: 148425 RVA: 0x004FB370 File Offset: 0x004F9570
		public static IFightMusicsSwitchType GetRootAsIFightMusicsSwitchType(ByteBuffer _bb)
		{
			return IFightMusicsSwitchType.GetRootAsIFightMusicsSwitchType(_bb, default(IFightMusicsSwitchType));
		}

		// Token: 0x060243CA RID: 148426 RVA: 0x004FB38C File Offset: 0x004F958C
		public static IFightMusicsSwitchType GetRootAsIFightMusicsSwitchType(ByteBuffer _bb, IFightMusicsSwitchType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060243CB RID: 148427 RVA: 0x004FB3A9 File Offset: 0x004F95A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060243CC RID: 148428 RVA: 0x004FB3B8 File Offset: 0x004F95B8
		public IFightMusicsSwitchType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A24F RID: 41551
		// (get) Token: 0x060243CD RID: 148429 RVA: 0x004FB3C8 File Offset: 0x004F95C8
		public EFightMusicsSwitchType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EFightMusicsSwitchType.SwitchByTag;
				}
				return (EFightMusicsSwitchType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060243CE RID: 148430 RVA: 0x004FB404 File Offset: 0x004F9604
		public static Offset<IFightMusicsSwitchType> CreateIFightMusicsSwitchType(FlatBufferBuilder builder, EFightMusicsSwitchType Type = EFightMusicsSwitchType.SwitchByTag)
		{
			builder.StartTable(1);
			IFightMusicsSwitchType.AddType(builder, Type);
			return IFightMusicsSwitchType.EndIFightMusicsSwitchType(builder);
		}

		// Token: 0x060243CF RID: 148431 RVA: 0x004FB41A File Offset: 0x004F961A
		public static void StartIFightMusicsSwitchType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060243D0 RID: 148432 RVA: 0x004FB423 File Offset: 0x004F9623
		public static void AddType(FlatBufferBuilder builder, EFightMusicsSwitchType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060243D1 RID: 148433 RVA: 0x004FB42E File Offset: 0x004F962E
		public static Offset<IFightMusicsSwitchType> EndIFightMusicsSwitchType(FlatBufferBuilder builder)
		{
			return new Offset<IFightMusicsSwitchType>(builder.EndTable());
		}

		// Token: 0x060243D2 RID: 148434 RVA: 0x004FB43C File Offset: 0x004F963C
		public IFightMusicsSwitchTypeT UnPack()
		{
			IFightMusicsSwitchTypeT fightMusicsSwitchTypeT = new IFightMusicsSwitchTypeT();
			this.UnPackTo(fightMusicsSwitchTypeT);
			return fightMusicsSwitchTypeT;
		}

		// Token: 0x060243D3 RID: 148435 RVA: 0x004FB457 File Offset: 0x004F9657
		public void UnPackTo(IFightMusicsSwitchTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060243D4 RID: 148436 RVA: 0x004FB468 File Offset: 0x004F9668
		public static Offset<IFightMusicsSwitchType> Pack(FlatBufferBuilder builder, IFightMusicsSwitchTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFightMusicsSwitchType>);
			}
			return IFightMusicsSwitchType.CreateIFightMusicsSwitchType(builder, _o.Type);
		}

		// Token: 0x0400EF98 RID: 61336
		private Table __p;
	}
}
