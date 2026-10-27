using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042A4 RID: 17060
	public struct IWordArtEffectiveTargetType : IFlatbufferObject
	{
		// Token: 0x1700791C RID: 31004
		// (get) Token: 0x06019477 RID: 103543 RVA: 0x003A1540 File Offset: 0x0039F740
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019478 RID: 103544 RVA: 0x003A154D File Offset: 0x0039F74D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019479 RID: 103545 RVA: 0x003A1554 File Offset: 0x0039F754
		public static IWordArtEffectiveTargetType GetRootAsIWordArtEffectiveTargetType(ByteBuffer _bb)
		{
			return IWordArtEffectiveTargetType.GetRootAsIWordArtEffectiveTargetType(_bb, default(IWordArtEffectiveTargetType));
		}

		// Token: 0x0601947A RID: 103546 RVA: 0x003A1570 File Offset: 0x0039F770
		public static IWordArtEffectiveTargetType GetRootAsIWordArtEffectiveTargetType(ByteBuffer _bb, IWordArtEffectiveTargetType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601947B RID: 103547 RVA: 0x003A158D File Offset: 0x0039F78D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601947C RID: 103548 RVA: 0x003A159C File Offset: 0x0039F79C
		public IWordArtEffectiveTargetType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700791D RID: 31005
		// (get) Token: 0x0601947D RID: 103549 RVA: 0x003A15AC File Offset: 0x0039F7AC
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

		// Token: 0x0601947E RID: 103550 RVA: 0x003A15E8 File Offset: 0x0039F7E8
		public static Offset<IWordArtEffectiveTargetType> CreateIWordArtEffectiveTargetType(FlatBufferBuilder builder, EWordArtEffectiveTargetType Type = EWordArtEffectiveTargetType.Number)
		{
			builder.StartTable(1);
			IWordArtEffectiveTargetType.AddType(builder, Type);
			return IWordArtEffectiveTargetType.EndIWordArtEffectiveTargetType(builder);
		}

		// Token: 0x0601947F RID: 103551 RVA: 0x003A15FE File Offset: 0x0039F7FE
		public static void StartIWordArtEffectiveTargetType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06019480 RID: 103552 RVA: 0x003A1607 File Offset: 0x0039F807
		public static void AddType(FlatBufferBuilder builder, EWordArtEffectiveTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019481 RID: 103553 RVA: 0x003A1612 File Offset: 0x0039F812
		public static Offset<IWordArtEffectiveTargetType> EndIWordArtEffectiveTargetType(FlatBufferBuilder builder)
		{
			return new Offset<IWordArtEffectiveTargetType>(builder.EndTable());
		}

		// Token: 0x06019482 RID: 103554 RVA: 0x003A1620 File Offset: 0x0039F820
		public IWordArtEffectiveTargetTypeT UnPack()
		{
			IWordArtEffectiveTargetTypeT wordArtEffectiveTargetTypeT = new IWordArtEffectiveTargetTypeT();
			this.UnPackTo(wordArtEffectiveTargetTypeT);
			return wordArtEffectiveTargetTypeT;
		}

		// Token: 0x06019483 RID: 103555 RVA: 0x003A163B File Offset: 0x0039F83B
		public void UnPackTo(IWordArtEffectiveTargetTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06019484 RID: 103556 RVA: 0x003A164C File Offset: 0x0039F84C
		public static Offset<IWordArtEffectiveTargetType> Pack(FlatBufferBuilder builder, IWordArtEffectiveTargetTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWordArtEffectiveTargetType>);
			}
			return IWordArtEffectiveTargetType.CreateIWordArtEffectiveTargetType(builder, _o.Type);
		}

		// Token: 0x0400BF46 RID: 48966
		private Table __p;
	}
}
