using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Match
{
	// Token: 0x0200485F RID: 18527
	public struct IMatchAssistCharacterRole : IFlatbufferObject
	{
		// Token: 0x17008101 RID: 33025
		// (get) Token: 0x0601B623 RID: 112163 RVA: 0x003E0B08 File Offset: 0x003DED08
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B624 RID: 112164 RVA: 0x003E0B15 File Offset: 0x003DED15
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B625 RID: 112165 RVA: 0x003E0B1C File Offset: 0x003DED1C
		public static IMatchAssistCharacterRole GetRootAsIMatchAssistCharacterRole(ByteBuffer _bb)
		{
			return IMatchAssistCharacterRole.GetRootAsIMatchAssistCharacterRole(_bb, default(IMatchAssistCharacterRole));
		}

		// Token: 0x0601B626 RID: 112166 RVA: 0x003E0B38 File Offset: 0x003DED38
		public static IMatchAssistCharacterRole GetRootAsIMatchAssistCharacterRole(ByteBuffer _bb, IMatchAssistCharacterRole obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B627 RID: 112167 RVA: 0x003E0B55 File Offset: 0x003DED55
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B628 RID: 112168 RVA: 0x003E0B64 File Offset: 0x003DED64
		public IMatchAssistCharacterRole __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008102 RID: 33026
		// (get) Token: 0x0601B629 RID: 112169 RVA: 0x003E0B74 File Offset: 0x003DED74
		public EMatchRoleType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMatchRoleType.Player;
				}
				return (EMatchRoleType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601B62A RID: 112170 RVA: 0x003E0BB0 File Offset: 0x003DEDB0
		public int Characters(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17008103 RID: 33027
		// (get) Token: 0x0601B62B RID: 112171 RVA: 0x003E0BF0 File Offset: 0x003DEDF0
		public int CharactersLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0601B62C RID: 112172 RVA: 0x003E0C1B File Offset: 0x003DEE1B
		public Span<int> GetCharactersBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0601B62D RID: 112173 RVA: 0x003E0C2A File Offset: 0x003DEE2A
		public int[] GetCharactersArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x0601B62E RID: 112174 RVA: 0x003E0C38 File Offset: 0x003DEE38
		public static Offset<IMatchAssistCharacterRole> CreateIMatchAssistCharacterRole(FlatBufferBuilder builder, EMatchRoleType Type = EMatchRoleType.Player, VectorOffset CharactersOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IMatchAssistCharacterRole.AddCharacters(builder, CharactersOffset);
			IMatchAssistCharacterRole.AddType(builder, Type);
			return IMatchAssistCharacterRole.EndIMatchAssistCharacterRole(builder);
		}

		// Token: 0x0601B62F RID: 112175 RVA: 0x003E0C55 File Offset: 0x003DEE55
		public static void StartIMatchAssistCharacterRole(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601B630 RID: 112176 RVA: 0x003E0C5E File Offset: 0x003DEE5E
		public static void AddType(FlatBufferBuilder builder, EMatchRoleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B631 RID: 112177 RVA: 0x003E0C69 File Offset: 0x003DEE69
		public static void AddCharacters(FlatBufferBuilder builder, VectorOffset charactersOffset)
		{
			builder.AddOffset(1, charactersOffset.Value, 0);
		}

		// Token: 0x0601B632 RID: 112178 RVA: 0x003E0C7C File Offset: 0x003DEE7C
		public static VectorOffset CreateCharactersVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601B633 RID: 112179 RVA: 0x003E0CB3 File Offset: 0x003DEEB3
		public static VectorOffset CreateCharactersVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B634 RID: 112180 RVA: 0x003E0CCD File Offset: 0x003DEECD
		public static VectorOffset CreateCharactersVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B635 RID: 112181 RVA: 0x003E0CEB File Offset: 0x003DEEEB
		public static VectorOffset CreateCharactersVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601B636 RID: 112182 RVA: 0x003E0D04 File Offset: 0x003DEF04
		public static void StartCharactersVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601B637 RID: 112183 RVA: 0x003E0D0F File Offset: 0x003DEF0F
		public static Offset<IMatchAssistCharacterRole> EndIMatchAssistCharacterRole(FlatBufferBuilder builder)
		{
			return new Offset<IMatchAssistCharacterRole>(builder.EndTable());
		}

		// Token: 0x0601B638 RID: 112184 RVA: 0x003E0D1C File Offset: 0x003DEF1C
		public IMatchAssistCharacterRoleT UnPack()
		{
			IMatchAssistCharacterRoleT matchAssistCharacterRoleT = new IMatchAssistCharacterRoleT();
			this.UnPackTo(matchAssistCharacterRoleT);
			return matchAssistCharacterRoleT;
		}

		// Token: 0x0601B639 RID: 112185 RVA: 0x003E0D38 File Offset: 0x003DEF38
		public void UnPackTo(IMatchAssistCharacterRoleT _o)
		{
			_o.Type = this.Type;
			_o.Characters = new List<int>();
			for (int i = 0; i < this.CharactersLength; i++)
			{
				_o.Characters.Add(this.Characters(i));
			}
		}

		// Token: 0x0601B63A RID: 112186 RVA: 0x003E0D80 File Offset: 0x003DEF80
		public static Offset<IMatchAssistCharacterRole> Pack(FlatBufferBuilder builder, IMatchAssistCharacterRoleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMatchAssistCharacterRole>);
			}
			VectorOffset charactersOffset = default(VectorOffset);
			if (_o.Characters != null)
			{
				int[] data = _o.Characters.ToArray();
				charactersOffset = IMatchAssistCharacterRole.CreateCharactersVector(builder, data);
			}
			return IMatchAssistCharacterRole.CreateIMatchAssistCharacterRole(builder, _o.Type, charactersOffset);
		}

		// Token: 0x0400CD74 RID: 52596
		private Table __p;
	}
}
