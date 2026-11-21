using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FB9 RID: 28601
	public struct IHideSpecifyLevelPlayGroup : IFlatbufferObject
	{
		// Token: 0x1700D177 RID: 53623
		// (get) Token: 0x06031861 RID: 202849 RVA: 0x006B637A File Offset: 0x006B457A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031862 RID: 202850 RVA: 0x006B6387 File Offset: 0x006B4587
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031863 RID: 202851 RVA: 0x006B6390 File Offset: 0x006B4590
		public static IHideSpecifyLevelPlayGroup GetRootAsIHideSpecifyLevelPlayGroup(ByteBuffer _bb)
		{
			return IHideSpecifyLevelPlayGroup.GetRootAsIHideSpecifyLevelPlayGroup(_bb, default(IHideSpecifyLevelPlayGroup));
		}

		// Token: 0x06031864 RID: 202852 RVA: 0x006B63AC File Offset: 0x006B45AC
		public static IHideSpecifyLevelPlayGroup GetRootAsIHideSpecifyLevelPlayGroup(ByteBuffer _bb, IHideSpecifyLevelPlayGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031865 RID: 202853 RVA: 0x006B63C9 File Offset: 0x006B45C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031866 RID: 202854 RVA: 0x006B63D8 File Offset: 0x006B45D8
		public IHideSpecifyLevelPlayGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D178 RID: 53624
		// (get) Token: 0x06031867 RID: 202855 RVA: 0x006B63E8 File Offset: 0x006B45E8
		public EHideType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EHideType.WorldMonsterAndMonsterTreasure;
				}
				return (EHideType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031868 RID: 202856 RVA: 0x006B6424 File Offset: 0x006B4624
		public int LevelPlays(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700D179 RID: 53625
		// (get) Token: 0x06031869 RID: 202857 RVA: 0x006B6464 File Offset: 0x006B4664
		public int LevelPlaysLength
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

		// Token: 0x0603186A RID: 202858 RVA: 0x006B648F File Offset: 0x006B468F
		public Span<int> GetLevelPlaysBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0603186B RID: 202859 RVA: 0x006B649E File Offset: 0x006B469E
		public int[] GetLevelPlaysArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x0603186C RID: 202860 RVA: 0x006B64AC File Offset: 0x006B46AC
		public static Offset<IHideSpecifyLevelPlayGroup> CreateIHideSpecifyLevelPlayGroup(FlatBufferBuilder builder, EHideType Type = EHideType.WorldMonsterAndMonsterTreasure, VectorOffset LevelPlaysOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IHideSpecifyLevelPlayGroup.AddLevelPlays(builder, LevelPlaysOffset);
			IHideSpecifyLevelPlayGroup.AddType(builder, Type);
			return IHideSpecifyLevelPlayGroup.EndIHideSpecifyLevelPlayGroup(builder);
		}

		// Token: 0x0603186D RID: 202861 RVA: 0x006B64C9 File Offset: 0x006B46C9
		public static void StartIHideSpecifyLevelPlayGroup(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603186E RID: 202862 RVA: 0x006B64D2 File Offset: 0x006B46D2
		public static void AddType(FlatBufferBuilder builder, EHideType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603186F RID: 202863 RVA: 0x006B64DD File Offset: 0x006B46DD
		public static void AddLevelPlays(FlatBufferBuilder builder, VectorOffset levelPlaysOffset)
		{
			builder.AddOffset(1, levelPlaysOffset.Value, 0);
		}

		// Token: 0x06031870 RID: 202864 RVA: 0x006B64F0 File Offset: 0x006B46F0
		public static VectorOffset CreateLevelPlaysVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06031871 RID: 202865 RVA: 0x006B6527 File Offset: 0x006B4727
		public static VectorOffset CreateLevelPlaysVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06031872 RID: 202866 RVA: 0x006B6541 File Offset: 0x006B4741
		public static VectorOffset CreateLevelPlaysVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06031873 RID: 202867 RVA: 0x006B655F File Offset: 0x006B475F
		public static VectorOffset CreateLevelPlaysVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06031874 RID: 202868 RVA: 0x006B6578 File Offset: 0x006B4778
		public static void StartLevelPlaysVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06031875 RID: 202869 RVA: 0x006B6583 File Offset: 0x006B4783
		public static Offset<IHideSpecifyLevelPlayGroup> EndIHideSpecifyLevelPlayGroup(FlatBufferBuilder builder)
		{
			return new Offset<IHideSpecifyLevelPlayGroup>(builder.EndTable());
		}

		// Token: 0x06031876 RID: 202870 RVA: 0x006B6590 File Offset: 0x006B4790
		public IHideSpecifyLevelPlayGroupT UnPack()
		{
			IHideSpecifyLevelPlayGroupT hideSpecifyLevelPlayGroupT = new IHideSpecifyLevelPlayGroupT();
			this.UnPackTo(hideSpecifyLevelPlayGroupT);
			return hideSpecifyLevelPlayGroupT;
		}

		// Token: 0x06031877 RID: 202871 RVA: 0x006B65AC File Offset: 0x006B47AC
		public void UnPackTo(IHideSpecifyLevelPlayGroupT _o)
		{
			_o.Type = this.Type;
			_o.LevelPlays = new List<int>();
			for (int i = 0; i < this.LevelPlaysLength; i++)
			{
				_o.LevelPlays.Add(this.LevelPlays(i));
			}
		}

		// Token: 0x06031878 RID: 202872 RVA: 0x006B65F4 File Offset: 0x006B47F4
		public static Offset<IHideSpecifyLevelPlayGroup> Pack(FlatBufferBuilder builder, IHideSpecifyLevelPlayGroupT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHideSpecifyLevelPlayGroup>);
			}
			VectorOffset levelPlaysOffset = default(VectorOffset);
			if (_o.LevelPlays != null)
			{
				int[] data = _o.LevelPlays.ToArray();
				levelPlaysOffset = IHideSpecifyLevelPlayGroup.CreateLevelPlaysVector(builder, data);
			}
			return IHideSpecifyLevelPlayGroup.CreateIHideSpecifyLevelPlayGroup(builder, _o.Type, levelPlaysOffset);
		}

		// Token: 0x04011EE7 RID: 73447
		private Table __p;
	}
}
