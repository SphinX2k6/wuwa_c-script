using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075E8 RID: 30184
	public struct IRemovePreloadResourceTrialCharacter : IFlatbufferObject
	{
		// Token: 0x1700DDD4 RID: 56788
		// (get) Token: 0x06034F38 RID: 216888 RVA: 0x0071D59B File Offset: 0x0071B79B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034F39 RID: 216889 RVA: 0x0071D5A8 File Offset: 0x0071B7A8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034F3A RID: 216890 RVA: 0x0071D5B0 File Offset: 0x0071B7B0
		public static IRemovePreloadResourceTrialCharacter GetRootAsIRemovePreloadResourceTrialCharacter(ByteBuffer _bb)
		{
			return IRemovePreloadResourceTrialCharacter.GetRootAsIRemovePreloadResourceTrialCharacter(_bb, default(IRemovePreloadResourceTrialCharacter));
		}

		// Token: 0x06034F3B RID: 216891 RVA: 0x0071D5CC File Offset: 0x0071B7CC
		public static IRemovePreloadResourceTrialCharacter GetRootAsIRemovePreloadResourceTrialCharacter(ByteBuffer _bb, IRemovePreloadResourceTrialCharacter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034F3C RID: 216892 RVA: 0x0071D5E9 File Offset: 0x0071B7E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034F3D RID: 216893 RVA: 0x0071D5F8 File Offset: 0x0071B7F8
		public IRemovePreloadResourceTrialCharacter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DDD5 RID: 56789
		// (get) Token: 0x06034F3E RID: 216894 RVA: 0x0071D608 File Offset: 0x0071B808
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

		// Token: 0x06034F3F RID: 216895 RVA: 0x0071D644 File Offset: 0x0071B844
		public int CharacterGroup(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700DDD6 RID: 56790
		// (get) Token: 0x06034F40 RID: 216896 RVA: 0x0071D684 File Offset: 0x0071B884
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

		// Token: 0x06034F41 RID: 216897 RVA: 0x0071D6AF File Offset: 0x0071B8AF
		public Span<int> GetCharacterGroupBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06034F42 RID: 216898 RVA: 0x0071D6BE File Offset: 0x0071B8BE
		public int[] GetCharacterGroupArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x06034F43 RID: 216899 RVA: 0x0071D6CC File Offset: 0x0071B8CC
		public static Offset<IRemovePreloadResourceTrialCharacter> CreateIRemovePreloadResourceTrialCharacter(FlatBufferBuilder builder, ERemovePreloadResourceObjectType Type = ERemovePreloadResourceObjectType.RemovePreloadResourceTrialCharacter, VectorOffset CharacterGroupOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IRemovePreloadResourceTrialCharacter.AddCharacterGroup(builder, CharacterGroupOffset);
			IRemovePreloadResourceTrialCharacter.AddType(builder, Type);
			return IRemovePreloadResourceTrialCharacter.EndIRemovePreloadResourceTrialCharacter(builder);
		}

		// Token: 0x06034F44 RID: 216900 RVA: 0x0071D6E9 File Offset: 0x0071B8E9
		public static void StartIRemovePreloadResourceTrialCharacter(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06034F45 RID: 216901 RVA: 0x0071D6F2 File Offset: 0x0071B8F2
		public static void AddType(FlatBufferBuilder builder, ERemovePreloadResourceObjectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06034F46 RID: 216902 RVA: 0x0071D6FD File Offset: 0x0071B8FD
		public static void AddCharacterGroup(FlatBufferBuilder builder, VectorOffset characterGroupOffset)
		{
			builder.AddOffset(1, characterGroupOffset.Value, 0);
		}

		// Token: 0x06034F47 RID: 216903 RVA: 0x0071D710 File Offset: 0x0071B910
		public static VectorOffset CreateCharacterGroupVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06034F48 RID: 216904 RVA: 0x0071D747 File Offset: 0x0071B947
		public static VectorOffset CreateCharacterGroupVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06034F49 RID: 216905 RVA: 0x0071D761 File Offset: 0x0071B961
		public static VectorOffset CreateCharacterGroupVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06034F4A RID: 216906 RVA: 0x0071D77F File Offset: 0x0071B97F
		public static VectorOffset CreateCharacterGroupVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06034F4B RID: 216907 RVA: 0x0071D798 File Offset: 0x0071B998
		public static void StartCharacterGroupVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06034F4C RID: 216908 RVA: 0x0071D7A3 File Offset: 0x0071B9A3
		public static Offset<IRemovePreloadResourceTrialCharacter> EndIRemovePreloadResourceTrialCharacter(FlatBufferBuilder builder)
		{
			return new Offset<IRemovePreloadResourceTrialCharacter>(builder.EndTable());
		}

		// Token: 0x06034F4D RID: 216909 RVA: 0x0071D7B0 File Offset: 0x0071B9B0
		public IRemovePreloadResourceTrialCharacterT UnPack()
		{
			IRemovePreloadResourceTrialCharacterT removePreloadResourceTrialCharacterT = new IRemovePreloadResourceTrialCharacterT();
			this.UnPackTo(removePreloadResourceTrialCharacterT);
			return removePreloadResourceTrialCharacterT;
		}

		// Token: 0x06034F4E RID: 216910 RVA: 0x0071D7CC File Offset: 0x0071B9CC
		public void UnPackTo(IRemovePreloadResourceTrialCharacterT _o)
		{
			_o.Type = this.Type;
			_o.CharacterGroup = new List<int>();
			for (int i = 0; i < this.CharacterGroupLength; i++)
			{
				_o.CharacterGroup.Add(this.CharacterGroup(i));
			}
		}

		// Token: 0x06034F4F RID: 216911 RVA: 0x0071D814 File Offset: 0x0071BA14
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

		// Token: 0x040127D3 RID: 75731
		private Table __p;
	}
}
