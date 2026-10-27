using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E67 RID: 28263
	public struct IRemovePreloadResourceTrialCharacter : IFlatbufferObject
	{
		// Token: 0x1700D282 RID: 53890
		// (get) Token: 0x06031F10 RID: 204560 RVA: 0x006C1A9B File Offset: 0x006BFC9B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031F11 RID: 204561 RVA: 0x006C1AA8 File Offset: 0x006BFCA8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031F12 RID: 204562 RVA: 0x006C1AB0 File Offset: 0x006BFCB0
		public static IRemovePreloadResourceTrialCharacter GetRootAsIRemovePreloadResourceTrialCharacter(ByteBuffer _bb)
		{
			return IRemovePreloadResourceTrialCharacter.GetRootAsIRemovePreloadResourceTrialCharacter(_bb, default(IRemovePreloadResourceTrialCharacter));
		}

		// Token: 0x06031F13 RID: 204563 RVA: 0x006C1ACC File Offset: 0x006BFCCC
		public static IRemovePreloadResourceTrialCharacter GetRootAsIRemovePreloadResourceTrialCharacter(ByteBuffer _bb, IRemovePreloadResourceTrialCharacter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031F14 RID: 204564 RVA: 0x006C1AE9 File Offset: 0x006BFCE9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031F15 RID: 204565 RVA: 0x006C1AF8 File Offset: 0x006BFCF8
		public IRemovePreloadResourceTrialCharacter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D283 RID: 53891
		// (get) Token: 0x06031F16 RID: 204566 RVA: 0x006C1B08 File Offset: 0x006BFD08
		public ERemovePreloadResourceObjectType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERemovePreloadResourceObjectType.RemovePreloadResourceTrialCharacter;
				}
				return (ERemovePreloadResourceObjectType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031F17 RID: 204567 RVA: 0x006C1B44 File Offset: 0x006BFD44
		public int CharacterGroup(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700D284 RID: 53892
		// (get) Token: 0x06031F18 RID: 204568 RVA: 0x006C1B84 File Offset: 0x006BFD84
		public int CharacterGroupLength
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

		// Token: 0x06031F19 RID: 204569 RVA: 0x006C1BAF File Offset: 0x006BFDAF
		public Span<int> GetCharacterGroupBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06031F1A RID: 204570 RVA: 0x006C1BBE File Offset: 0x006BFDBE
		public int[] GetCharacterGroupArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x06031F1B RID: 204571 RVA: 0x006C1BCC File Offset: 0x006BFDCC
		public static Offset<IRemovePreloadResourceTrialCharacter> CreateIRemovePreloadResourceTrialCharacter(FlatBufferBuilder builder, ERemovePreloadResourceObjectType Type = ERemovePreloadResourceObjectType.RemovePreloadResourceTrialCharacter, VectorOffset CharacterGroupOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IRemovePreloadResourceTrialCharacter.AddCharacterGroup(builder, CharacterGroupOffset);
			IRemovePreloadResourceTrialCharacter.AddType(builder, Type);
			return IRemovePreloadResourceTrialCharacter.EndIRemovePreloadResourceTrialCharacter(builder);
		}

		// Token: 0x06031F1C RID: 204572 RVA: 0x006C1BE9 File Offset: 0x006BFDE9
		public static void StartIRemovePreloadResourceTrialCharacter(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06031F1D RID: 204573 RVA: 0x006C1BF2 File Offset: 0x006BFDF2
		public static void AddType(FlatBufferBuilder builder, ERemovePreloadResourceObjectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031F1E RID: 204574 RVA: 0x006C1BFD File Offset: 0x006BFDFD
		public static void AddCharacterGroup(FlatBufferBuilder builder, VectorOffset characterGroupOffset)
		{
			builder.AddOffset(1, characterGroupOffset.Value, 0);
		}

		// Token: 0x06031F1F RID: 204575 RVA: 0x006C1C10 File Offset: 0x006BFE10
		public static VectorOffset CreateCharacterGroupVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06031F20 RID: 204576 RVA: 0x006C1C47 File Offset: 0x006BFE47
		public static VectorOffset CreateCharacterGroupVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06031F21 RID: 204577 RVA: 0x006C1C61 File Offset: 0x006BFE61
		public static VectorOffset CreateCharacterGroupVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06031F22 RID: 204578 RVA: 0x006C1C7F File Offset: 0x006BFE7F
		public static VectorOffset CreateCharacterGroupVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06031F23 RID: 204579 RVA: 0x006C1C98 File Offset: 0x006BFE98
		public static void StartCharacterGroupVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06031F24 RID: 204580 RVA: 0x006C1CA3 File Offset: 0x006BFEA3
		public static Offset<IRemovePreloadResourceTrialCharacter> EndIRemovePreloadResourceTrialCharacter(FlatBufferBuilder builder)
		{
			return new Offset<IRemovePreloadResourceTrialCharacter>(builder.EndTable());
		}

		// Token: 0x06031F25 RID: 204581 RVA: 0x006C1CB0 File Offset: 0x006BFEB0
		public IRemovePreloadResourceTrialCharacterT UnPack()
		{
			IRemovePreloadResourceTrialCharacterT removePreloadResourceTrialCharacterT = new IRemovePreloadResourceTrialCharacterT();
			this.UnPackTo(removePreloadResourceTrialCharacterT);
			return removePreloadResourceTrialCharacterT;
		}

		// Token: 0x06031F26 RID: 204582 RVA: 0x006C1CCC File Offset: 0x006BFECC
		public void UnPackTo(IRemovePreloadResourceTrialCharacterT _o)
		{
			_o.Type = this.Type;
			_o.CharacterGroup = new List<int>();
			for (int i = 0; i < this.CharacterGroupLength; i++)
			{
				_o.CharacterGroup.Add(this.CharacterGroup(i));
			}
		}

		// Token: 0x06031F27 RID: 204583 RVA: 0x006C1D14 File Offset: 0x006BFF14
		public static Offset<IRemovePreloadResourceTrialCharacter> Pack(FlatBufferBuilder builder, IRemovePreloadResourceTrialCharacterT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRemovePreloadResourceTrialCharacter>);
			}
			VectorOffset characterGroupOffset = default(VectorOffset);
			if (_o.CharacterGroup != null)
			{
				int[] data = _o.CharacterGroup.ToArray();
				characterGroupOffset = IRemovePreloadResourceTrialCharacter.CreateCharacterGroupVector(builder, data);
			}
			return IRemovePreloadResourceTrialCharacter.CreateIRemovePreloadResourceTrialCharacter(builder, _o.Type, characterGroupOffset);
		}

		// Token: 0x04011851 RID: 71761
		private Table __p;
	}
}
