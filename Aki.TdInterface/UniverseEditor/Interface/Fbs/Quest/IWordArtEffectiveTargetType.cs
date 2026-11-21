using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004700 RID: 18176
	public struct IWordArtEffectiveTargetType : IFlatbufferObject
	{
		// Token: 0x17007F4D RID: 32589
		// (get) Token: 0x0601ABE3 RID: 109539 RVA: 0x003CCC18 File Offset: 0x003CAE18
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601ABE4 RID: 109540 RVA: 0x003CCC25 File Offset: 0x003CAE25
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601ABE5 RID: 109541 RVA: 0x003CCC2C File Offset: 0x003CAE2C
		public static IWordArtEffectiveTargetType GetRootAsIWordArtEffectiveTargetType(ByteBuffer _bb)
		{
			return IWordArtEffectiveTargetType.GetRootAsIWordArtEffectiveTargetType(_bb, default(IWordArtEffectiveTargetType));
		}

		// Token: 0x0601ABE6 RID: 109542 RVA: 0x003CCC48 File Offset: 0x003CAE48
		public static IWordArtEffectiveTargetType GetRootAsIWordArtEffectiveTargetType(ByteBuffer _bb, IWordArtEffectiveTargetType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601ABE7 RID: 109543 RVA: 0x003CCC65 File Offset: 0x003CAE65
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601ABE8 RID: 109544 RVA: 0x003CCC74 File Offset: 0x003CAE74
		public IWordArtEffectiveTargetType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007F4E RID: 32590
		// (get) Token: 0x0601ABE9 RID: 109545 RVA: 0x003CCC84 File Offset: 0x003CAE84
		public EWordArtEffectiveTargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EWordArtEffectiveTargetType.Number;
				}
				return (EWordArtEffectiveTargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601ABEA RID: 109546 RVA: 0x003CCCC0 File Offset: 0x003CAEC0
		public static Offset<IWordArtEffectiveTargetType> CreateIWordArtEffectiveTargetType(FlatBufferBuilder builder, EWordArtEffectiveTargetType Type = EWordArtEffectiveTargetType.Number)
		{
			builder.StartTable(1);
			IWordArtEffectiveTargetType.AddType(builder, Type);
			return IWordArtEffectiveTargetType.EndIWordArtEffectiveTargetType(builder);
		}

		// Token: 0x0601ABEB RID: 109547 RVA: 0x003CCCD6 File Offset: 0x003CAED6
		public static void StartIWordArtEffectiveTargetType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601ABEC RID: 109548 RVA: 0x003CCCDF File Offset: 0x003CAEDF
		public static void AddType(FlatBufferBuilder builder, EWordArtEffectiveTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601ABED RID: 109549 RVA: 0x003CCCEA File Offset: 0x003CAEEA
		public static Offset<IWordArtEffectiveTargetType> EndIWordArtEffectiveTargetType(FlatBufferBuilder builder)
		{
			return new Offset<IWordArtEffectiveTargetType>(builder.EndTable());
		}

		// Token: 0x0601ABEE RID: 109550 RVA: 0x003CCCF8 File Offset: 0x003CAEF8
		public IWordArtEffectiveTargetTypeT UnPack()
		{
			IWordArtEffectiveTargetTypeT wordArtEffectiveTargetTypeT = new IWordArtEffectiveTargetTypeT();
			this.UnPackTo(wordArtEffectiveTargetTypeT);
			return wordArtEffectiveTargetTypeT;
		}

		// Token: 0x0601ABEF RID: 109551 RVA: 0x003CCD13 File Offset: 0x003CAF13
		public void UnPackTo(IWordArtEffectiveTargetTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601ABF0 RID: 109552 RVA: 0x003CCD24 File Offset: 0x003CAF24
		public static Offset<IWordArtEffectiveTargetType> Pack(FlatBufferBuilder builder, IWordArtEffectiveTargetTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWordArtEffectiveTargetType>);
			}
			return IWordArtEffectiveTargetType.CreateIWordArtEffectiveTargetType(builder, _o.Type);
		}

		// Token: 0x0400C953 RID: 51539
		private Table __p;
	}
}
