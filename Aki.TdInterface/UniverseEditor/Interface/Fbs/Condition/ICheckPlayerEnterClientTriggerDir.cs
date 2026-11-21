using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004FB9 RID: 20409
	public struct ICheckPlayerEnterClientTriggerDir : IFlatbufferObject
	{
		// Token: 0x170091F6 RID: 37366
		// (get) Token: 0x0601FCEF RID: 130287 RVA: 0x0046B2A8 File Offset: 0x004694A8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FCF0 RID: 130288 RVA: 0x0046B2B5 File Offset: 0x004694B5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FCF1 RID: 130289 RVA: 0x0046B2BC File Offset: 0x004694BC
		public static ICheckPlayerEnterClientTriggerDir GetRootAsICheckPlayerEnterClientTriggerDir(ByteBuffer _bb)
		{
			return ICheckPlayerEnterClientTriggerDir.GetRootAsICheckPlayerEnterClientTriggerDir(_bb, default(ICheckPlayerEnterClientTriggerDir));
		}

		// Token: 0x0601FCF2 RID: 130290 RVA: 0x0046B2D8 File Offset: 0x004694D8
		public static ICheckPlayerEnterClientTriggerDir GetRootAsICheckPlayerEnterClientTriggerDir(ByteBuffer _bb, ICheckPlayerEnterClientTriggerDir obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FCF3 RID: 130291 RVA: 0x0046B2F5 File Offset: 0x004694F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FCF4 RID: 130292 RVA: 0x0046B304 File Offset: 0x00469504
		public ICheckPlayerEnterClientTriggerDir __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170091F7 RID: 37367
		// (get) Token: 0x0601FCF5 RID: 130293 RVA: 0x0046B314 File Offset: 0x00469514
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170091F8 RID: 37368
		// (get) Token: 0x0601FCF6 RID: 130294 RVA: 0x0046B350 File Offset: 0x00469550
		public ECheckEnterClientTriggerTargetType TargetType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ECheckEnterClientTriggerTargetType.Player;
				}
				return (ECheckEnterClientTriggerTargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601FCF7 RID: 130295 RVA: 0x0046B38C File Offset: 0x0046958C
		public TCheckEnterTriggerDirType DirConfigsType(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return TCheckEnterTriggerDirType.NONE;
			}
			return (TCheckEnterTriggerDirType)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x170091F9 RID: 37369
		// (get) Token: 0x0601FCF8 RID: 130296 RVA: 0x0046B3CC File Offset: 0x004695CC
		public int DirConfigsTypeLength
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

		// Token: 0x0601FCF9 RID: 130297 RVA: 0x0046B3F7 File Offset: 0x004695F7
		public Span<TCheckEnterTriggerDirType> GetDirConfigsTypeBytes()
		{
			return this.__p.__vector_as_span<TCheckEnterTriggerDirType>(8, 1);
		}

		// Token: 0x0601FCFA RID: 130298 RVA: 0x0046B408 File Offset: 0x00469608
		public TCheckEnterTriggerDirType[] GetDirConfigsTypeArray()
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TCheckEnterTriggerDirType[] array = new TCheckEnterTriggerDirType[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TCheckEnterTriggerDirType)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x0601FCFB RID: 130299 RVA: 0x0046B474 File Offset: 0x00469674
		public TTable? DirConfigs<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x170091FA RID: 37370
		// (get) Token: 0x0601FCFC RID: 130300 RVA: 0x0046B4BC File Offset: 0x004696BC
		public int DirConfigsLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x170091FB RID: 37371
		// (get) Token: 0x0601FCFD RID: 130301 RVA: 0x0046B4E8 File Offset: 0x004696E8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601FCFE RID: 130302 RVA: 0x0046B525 File Offset: 0x00469725
		public static Offset<ICheckPlayerEnterClientTriggerDir> CreateICheckPlayerEnterClientTriggerDir(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, ECheckEnterClientTriggerTargetType TargetType = ECheckEnterClientTriggerTargetType.Player, VectorOffset DirConfigs_typeOffset = default(VectorOffset), VectorOffset DirConfigsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(5);
			ICheckPlayerEnterClientTriggerDir.AddDirConfigs(builder, DirConfigsOffset);
			ICheckPlayerEnterClientTriggerDir.AddDirConfigsType(builder, DirConfigs_typeOffset);
			ICheckPlayerEnterClientTriggerDir.AddNullMask(builder, NullMask);
			ICheckPlayerEnterClientTriggerDir.AddTargetType(builder, TargetType);
			ICheckPlayerEnterClientTriggerDir.AddType(builder, Type);
			return ICheckPlayerEnterClientTriggerDir.EndICheckPlayerEnterClientTriggerDir(builder);
		}

		// Token: 0x0601FCFF RID: 130303 RVA: 0x0046B559 File Offset: 0x00469759
		public static void StartICheckPlayerEnterClientTriggerDir(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601FD00 RID: 130304 RVA: 0x0046B562 File Offset: 0x00469762
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601FD01 RID: 130305 RVA: 0x0046B56D File Offset: 0x0046976D
		public static void AddTargetType(FlatBufferBuilder builder, ECheckEnterClientTriggerTargetType targetType)
		{
			builder.AddByte(1, (byte)targetType, 0);
		}

		// Token: 0x0601FD02 RID: 130306 RVA: 0x0046B578 File Offset: 0x00469778
		public static void AddDirConfigsType(FlatBufferBuilder builder, VectorOffset dirConfigsTypeOffset)
		{
			builder.AddOffset(2, dirConfigsTypeOffset.Value, 0);
		}

		// Token: 0x0601FD03 RID: 130307 RVA: 0x0046B588 File Offset: 0x00469788
		public static VectorOffset CreateDirConfigsTypeVector(FlatBufferBuilder builder, TCheckEnterTriggerDirType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601FD04 RID: 130308 RVA: 0x0046B5BF File Offset: 0x004697BF
		public static VectorOffset CreateDirConfigsTypeVectorBlock(FlatBufferBuilder builder, TCheckEnterTriggerDirType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TCheckEnterTriggerDirType>(data);
			return builder.EndVector();
		}

		// Token: 0x0601FD05 RID: 130309 RVA: 0x0046B5D9 File Offset: 0x004697D9
		public static VectorOffset CreateDirConfigsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TCheckEnterTriggerDirType> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TCheckEnterTriggerDirType>(data);
			return builder.EndVector();
		}

		// Token: 0x0601FD06 RID: 130310 RVA: 0x0046B5F7 File Offset: 0x004697F7
		public static VectorOffset CreateDirConfigsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TCheckEnterTriggerDirType>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601FD07 RID: 130311 RVA: 0x0046B610 File Offset: 0x00469810
		public static void StartDirConfigsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601FD08 RID: 130312 RVA: 0x0046B61B File Offset: 0x0046981B
		public static void AddDirConfigs(FlatBufferBuilder builder, VectorOffset dirConfigsOffset)
		{
			builder.AddOffset(3, dirConfigsOffset.Value, 0);
		}

		// Token: 0x0601FD09 RID: 130313 RVA: 0x0046B62C File Offset: 0x0046982C
		public static VectorOffset CreateDirConfigsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601FD0A RID: 130314 RVA: 0x0046B663 File Offset: 0x00469863
		public static VectorOffset CreateDirConfigsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601FD0B RID: 130315 RVA: 0x0046B67D File Offset: 0x0046987D
		public static VectorOffset CreateDirConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601FD0C RID: 130316 RVA: 0x0046B69B File Offset: 0x0046989B
		public static VectorOffset CreateDirConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601FD0D RID: 130317 RVA: 0x0046B6B4 File Offset: 0x004698B4
		public static void StartDirConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601FD0E RID: 130318 RVA: 0x0046B6BF File Offset: 0x004698BF
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0601FD0F RID: 130319 RVA: 0x0046B6CA File Offset: 0x004698CA
		public static Offset<ICheckPlayerEnterClientTriggerDir> EndICheckPlayerEnterClientTriggerDir(FlatBufferBuilder builder)
		{
			return new Offset<ICheckPlayerEnterClientTriggerDir>(builder.EndTable());
		}

		// Token: 0x0601FD10 RID: 130320 RVA: 0x0046B6D8 File Offset: 0x004698D8
		public ICheckPlayerEnterClientTriggerDirT UnPack()
		{
			ICheckPlayerEnterClientTriggerDirT checkPlayerEnterClientTriggerDirT = new ICheckPlayerEnterClientTriggerDirT();
			this.UnPackTo(checkPlayerEnterClientTriggerDirT);
			return checkPlayerEnterClientTriggerDirT;
		}

		// Token: 0x0601FD11 RID: 130321 RVA: 0x0046B6F4 File Offset: 0x004698F4
		public void UnPackTo(ICheckPlayerEnterClientTriggerDirT _o)
		{
			_o.Type = this.Type;
			_o.TargetType = this.TargetType;
			_o.DirConfigs = new List<TCheckEnterTriggerDirTypeUnion>();
			for (int i = 0; i < this.DirConfigsLength; i++)
			{
				TCheckEnterTriggerDirTypeUnion tcheckEnterTriggerDirTypeUnion = new TCheckEnterTriggerDirTypeUnion();
				tcheckEnterTriggerDirTypeUnion.Type = this.DirConfigsType(i);
				TCheckEnterTriggerDirType tcheckEnterTriggerDirType = this.DirConfigsType(i);
				if (tcheckEnterTriggerDirType != TCheckEnterTriggerDirType.ICheckEnterTriggerDirTypeForwardAngle)
				{
					if (tcheckEnterTriggerDirType == TCheckEnterTriggerDirType.ICheckEnterTriggerDirTypeVelocityDirAngle)
					{
						tcheckEnterTriggerDirTypeUnion.Value = ((this.DirConfigs<ICheckEnterTriggerDirTypeVelocityDirAngle>(i) != null) ? this.DirConfigs<ICheckEnterTriggerDirTypeVelocityDirAngle>(i).Value.UnPack() : null);
					}
				}
				else
				{
					tcheckEnterTriggerDirTypeUnion.Value = ((this.DirConfigs<ICheckEnterTriggerDirTypeForwardAngle>(i) != null) ? this.DirConfigs<ICheckEnterTriggerDirTypeForwardAngle>(i).Value.UnPack() : null);
				}
				_o.DirConfigs.Add(tcheckEnterTriggerDirTypeUnion);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601FD12 RID: 130322 RVA: 0x0046B7E0 File Offset: 0x004699E0
		public static Offset<ICheckPlayerEnterClientTriggerDir> Pack(FlatBufferBuilder builder, ICheckPlayerEnterClientTriggerDirT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckPlayerEnterClientTriggerDir>);
			}
			VectorOffset dirConfigs_typeOffset = default(VectorOffset);
			if (_o.DirConfigs != null)
			{
				TCheckEnterTriggerDirType[] array = new TCheckEnterTriggerDirType[_o.DirConfigs.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.DirConfigs[i].Type;
				}
				dirConfigs_typeOffset = ICheckPlayerEnterClientTriggerDir.CreateDirConfigsTypeVector(builder, array);
			}
			VectorOffset dirConfigsOffset = default(VectorOffset);
			if (_o.DirConfigs != null)
			{
				int[] array2 = new int[_o.DirConfigs.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TCheckEnterTriggerDirTypeUnion.Pack(builder, _o.DirConfigs[j]);
				}
				dirConfigsOffset = ICheckPlayerEnterClientTriggerDir.CreateDirConfigsVector(builder, array2);
			}
			return ICheckPlayerEnterClientTriggerDir.CreateICheckPlayerEnterClientTriggerDir(builder, _o.Type, _o.TargetType, dirConfigs_typeOffset, dirConfigsOffset, _o.NullMask);
		}

		// Token: 0x0400DE5D RID: 56925
		private Table __p;
	}
}
