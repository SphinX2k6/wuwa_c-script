using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004965 RID: 18789
	public struct ILevelPlayInfoMappingSoaringChallenge : IFlatbufferObject
	{
		// Token: 0x1700836E RID: 33646
		// (get) Token: 0x0601C01C RID: 114716 RVA: 0x003F5BCE File Offset: 0x003F3DCE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C01D RID: 114717 RVA: 0x003F5BDB File Offset: 0x003F3DDB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C01E RID: 114718 RVA: 0x003F5BE4 File Offset: 0x003F3DE4
		public static ILevelPlayInfoMappingSoaringChallenge GetRootAsILevelPlayInfoMappingSoaringChallenge(ByteBuffer _bb)
		{
			return ILevelPlayInfoMappingSoaringChallenge.GetRootAsILevelPlayInfoMappingSoaringChallenge(_bb, default(ILevelPlayInfoMappingSoaringChallenge));
		}

		// Token: 0x0601C01F RID: 114719 RVA: 0x003F5C00 File Offset: 0x003F3E00
		public static ILevelPlayInfoMappingSoaringChallenge GetRootAsILevelPlayInfoMappingSoaringChallenge(ByteBuffer _bb, ILevelPlayInfoMappingSoaringChallenge obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C020 RID: 114720 RVA: 0x003F5C1D File Offset: 0x003F3E1D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C021 RID: 114721 RVA: 0x003F5C2C File Offset: 0x003F3E2C
		public ILevelPlayInfoMappingSoaringChallenge __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700836F RID: 33647
		// (get) Token: 0x0601C022 RID: 114722 RVA: 0x003F5C3C File Offset: 0x003F3E3C
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

		// Token: 0x17008370 RID: 33648
		// (get) Token: 0x0601C023 RID: 114723 RVA: 0x003F5C78 File Offset: 0x003F3E78
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

		// Token: 0x0601C024 RID: 114724 RVA: 0x003F5CB4 File Offset: 0x003F3EB4
		public string Vars(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17008371 RID: 33649
		// (get) Token: 0x0601C025 RID: 114725 RVA: 0x003F5CF0 File Offset: 0x003F3EF0
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

		// Token: 0x17008372 RID: 33650
		// (get) Token: 0x0601C026 RID: 114726 RVA: 0x003F5D1C File Offset: 0x003F3F1C
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

		// Token: 0x0601C027 RID: 114727 RVA: 0x003F5D59 File Offset: 0x003F3F59
		public static Offset<ILevelPlayInfoMappingSoaringChallenge> CreateILevelPlayInfoMappingSoaringChallenge(FlatBufferBuilder builder, ELevelPlayInfoMappingType Type = ELevelPlayInfoMappingType.PunishReport, int LevelPlayId = 0, VectorOffset VarsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			ILevelPlayInfoMappingSoaringChallenge.AddVars(builder, VarsOffset);
			ILevelPlayInfoMappingSoaringChallenge.AddLevelPlayId(builder, LevelPlayId);
			ILevelPlayInfoMappingSoaringChallenge.AddNullMask(builder, NullMask);
			ILevelPlayInfoMappingSoaringChallenge.AddType(builder, Type);
			return ILevelPlayInfoMappingSoaringChallenge.EndILevelPlayInfoMappingSoaringChallenge(builder);
		}

		// Token: 0x0601C028 RID: 114728 RVA: 0x003F5D85 File Offset: 0x003F3F85
		public static void StartILevelPlayInfoMappingSoaringChallenge(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601C029 RID: 114729 RVA: 0x003F5D8E File Offset: 0x003F3F8E
		public static void AddType(FlatBufferBuilder builder, ELevelPlayInfoMappingType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601C02A RID: 114730 RVA: 0x003F5D99 File Offset: 0x003F3F99
		public static void AddLevelPlayId(FlatBufferBuilder builder, int levelPlayId)
		{
			builder.AddInt(1, levelPlayId, 0);
		}

		// Token: 0x0601C02B RID: 114731 RVA: 0x003F5DA4 File Offset: 0x003F3FA4
		public static void AddVars(FlatBufferBuilder builder, VectorOffset varsOffset)
		{
			builder.AddOffset(2, varsOffset.Value, 0);
		}

		// Token: 0x0601C02C RID: 114732 RVA: 0x003F5DB4 File Offset: 0x003F3FB4
		public static VectorOffset CreateVarsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C02D RID: 114733 RVA: 0x003F5DF4 File Offset: 0x003F3FF4
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C02E RID: 114734 RVA: 0x003F5E0E File Offset: 0x003F400E
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C02F RID: 114735 RVA: 0x003F5E2C File Offset: 0x003F402C
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C030 RID: 114736 RVA: 0x003F5E45 File Offset: 0x003F4045
		public static void StartVarsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C031 RID: 114737 RVA: 0x003F5E50 File Offset: 0x003F4050
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0601C032 RID: 114738 RVA: 0x003F5E5B File Offset: 0x003F405B
		public static Offset<ILevelPlayInfoMappingSoaringChallenge> EndILevelPlayInfoMappingSoaringChallenge(FlatBufferBuilder builder)
		{
			return new Offset<ILevelPlayInfoMappingSoaringChallenge>(builder.EndTable());
		}

		// Token: 0x0601C033 RID: 114739 RVA: 0x003F5E68 File Offset: 0x003F4068
		public ILevelPlayInfoMappingSoaringChallengeT UnPack()
		{
			ILevelPlayInfoMappingSoaringChallengeT levelPlayInfoMappingSoaringChallengeT = new ILevelPlayInfoMappingSoaringChallengeT();
			this.UnPackTo(levelPlayInfoMappingSoaringChallengeT);
			return levelPlayInfoMappingSoaringChallengeT;
		}

		// Token: 0x0601C034 RID: 114740 RVA: 0x003F5E84 File Offset: 0x003F4084
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

		// Token: 0x0601C035 RID: 114741 RVA: 0x003F5EE4 File Offset: 0x003F40E4
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

		// Token: 0x0400CF90 RID: 53136
		private Table __p;
	}
}
