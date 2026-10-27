using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044FD RID: 17661
	public struct ILevelPlayInfoMappingSoaringChallenge : IFlatbufferObject
	{
		// Token: 0x17007D2D RID: 32045
		// (get) Token: 0x0601A847 RID: 108615 RVA: 0x003C9932 File Offset: 0x003C7B32
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A848 RID: 108616 RVA: 0x003C993F File Offset: 0x003C7B3F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A849 RID: 108617 RVA: 0x003C9948 File Offset: 0x003C7B48
		public static ILevelPlayInfoMappingSoaringChallenge GetRootAsILevelPlayInfoMappingSoaringChallenge(ByteBuffer _bb)
		{
			return ILevelPlayInfoMappingSoaringChallenge.GetRootAsILevelPlayInfoMappingSoaringChallenge(_bb, default(ILevelPlayInfoMappingSoaringChallenge));
		}

		// Token: 0x0601A84A RID: 108618 RVA: 0x003C9964 File Offset: 0x003C7B64
		public static ILevelPlayInfoMappingSoaringChallenge GetRootAsILevelPlayInfoMappingSoaringChallenge(ByteBuffer _bb, ILevelPlayInfoMappingSoaringChallenge obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A84B RID: 108619 RVA: 0x003C9981 File Offset: 0x003C7B81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A84C RID: 108620 RVA: 0x003C9990 File Offset: 0x003C7B90
		public ILevelPlayInfoMappingSoaringChallenge __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007D2E RID: 32046
		// (get) Token: 0x0601A84D RID: 108621 RVA: 0x003C99A0 File Offset: 0x003C7BA0
		public ELevelPlayInfoMappingType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELevelPlayInfoMappingType.PunishReport;
				}
				return (ELevelPlayInfoMappingType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007D2F RID: 32047
		// (get) Token: 0x0601A84E RID: 108622 RVA: 0x003C99DC File Offset: 0x003C7BDC
		public int LevelPlayId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601A84F RID: 108623 RVA: 0x003C9A18 File Offset: 0x003C7C18
		public string Vars(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007D30 RID: 32048
		// (get) Token: 0x0601A850 RID: 108624 RVA: 0x003C9A54 File Offset: 0x003C7C54
		public int VarsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17007D31 RID: 32049
		// (get) Token: 0x0601A851 RID: 108625 RVA: 0x003C9A80 File Offset: 0x003C7C80
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601A852 RID: 108626 RVA: 0x003C9ABD File Offset: 0x003C7CBD
		public static Offset<ILevelPlayInfoMappingSoaringChallenge> CreateILevelPlayInfoMappingSoaringChallenge(FlatBufferBuilder builder, ELevelPlayInfoMappingType Type = ELevelPlayInfoMappingType.PunishReport, int LevelPlayId = 0, VectorOffset VarsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			ILevelPlayInfoMappingSoaringChallenge.AddVars(builder, VarsOffset);
			ILevelPlayInfoMappingSoaringChallenge.AddLevelPlayId(builder, LevelPlayId);
			ILevelPlayInfoMappingSoaringChallenge.AddNullMask(builder, NullMask);
			ILevelPlayInfoMappingSoaringChallenge.AddType(builder, Type);
			return ILevelPlayInfoMappingSoaringChallenge.EndILevelPlayInfoMappingSoaringChallenge(builder);
		}

		// Token: 0x0601A853 RID: 108627 RVA: 0x003C9AE9 File Offset: 0x003C7CE9
		public static void StartILevelPlayInfoMappingSoaringChallenge(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601A854 RID: 108628 RVA: 0x003C9AF2 File Offset: 0x003C7CF2
		public static void AddType(FlatBufferBuilder builder, ELevelPlayInfoMappingType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A855 RID: 108629 RVA: 0x003C9AFD File Offset: 0x003C7CFD
		public static void AddLevelPlayId(FlatBufferBuilder builder, int levelPlayId)
		{
			builder.AddInt(1, levelPlayId, 0);
		}

		// Token: 0x0601A856 RID: 108630 RVA: 0x003C9B08 File Offset: 0x003C7D08
		public static void AddVars(FlatBufferBuilder builder, VectorOffset varsOffset)
		{
			builder.AddOffset(2, varsOffset.Value, 0);
		}

		// Token: 0x0601A857 RID: 108631 RVA: 0x003C9B18 File Offset: 0x003C7D18
		public static VectorOffset CreateVarsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601A858 RID: 108632 RVA: 0x003C9B58 File Offset: 0x003C7D58
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A859 RID: 108633 RVA: 0x003C9B72 File Offset: 0x003C7D72
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A85A RID: 108634 RVA: 0x003C9B90 File Offset: 0x003C7D90
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601A85B RID: 108635 RVA: 0x003C9BA9 File Offset: 0x003C7DA9
		public static void StartVarsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601A85C RID: 108636 RVA: 0x003C9BB4 File Offset: 0x003C7DB4
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0601A85D RID: 108637 RVA: 0x003C9BBF File Offset: 0x003C7DBF
		public static Offset<ILevelPlayInfoMappingSoaringChallenge> EndILevelPlayInfoMappingSoaringChallenge(FlatBufferBuilder builder)
		{
			return new Offset<ILevelPlayInfoMappingSoaringChallenge>(builder.EndTable());
		}

		// Token: 0x0601A85E RID: 108638 RVA: 0x003C9BCC File Offset: 0x003C7DCC
		public ILevelPlayInfoMappingSoaringChallengeT UnPack()
		{
			ILevelPlayInfoMappingSoaringChallengeT levelPlayInfoMappingSoaringChallengeT = new ILevelPlayInfoMappingSoaringChallengeT();
			this.UnPackTo(levelPlayInfoMappingSoaringChallengeT);
			return levelPlayInfoMappingSoaringChallengeT;
		}

		// Token: 0x0601A85F RID: 108639 RVA: 0x003C9BE8 File Offset: 0x003C7DE8
		public void UnPackTo(ILevelPlayInfoMappingSoaringChallengeT _o)
		{
			_o.Type = this.Type;
			_o.LevelPlayId = this.LevelPlayId;
			_o.Vars = new List<string>();
			for (int i = 0; i < this.VarsLength; i++)
			{
				_o.Vars.Add(this.Vars(i));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601A860 RID: 108640 RVA: 0x003C9C48 File Offset: 0x003C7E48
		public static Offset<ILevelPlayInfoMappingSoaringChallenge> Pack(FlatBufferBuilder builder, ILevelPlayInfoMappingSoaringChallengeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILevelPlayInfoMappingSoaringChallenge>);
			}
			VectorOffset varsOffset = default(VectorOffset);
			if (_o.Vars != null)
			{
				StringOffset[] array = new StringOffset[_o.Vars.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = builder.CreateString(_o.Vars[i]);
				}
				varsOffset = ILevelPlayInfoMappingSoaringChallenge.CreateVarsVector(builder, array);
			}
			return ILevelPlayInfoMappingSoaringChallenge.CreateILevelPlayInfoMappingSoaringChallenge(builder, _o.Type, _o.LevelPlayId, varsOffset, _o.NullMask);
		}

		// Token: 0x0400C561 RID: 50529
		private Table __p;
	}
}
