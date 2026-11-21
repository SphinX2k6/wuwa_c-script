using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200495F RID: 18783
	public struct ILevelPlayInfoMappingNightmareSpawnPoint : IFlatbufferObject
	{
		// Token: 0x17008358 RID: 33624
		// (get) Token: 0x0601BFBC RID: 114620 RVA: 0x003F4FA6 File Offset: 0x003F31A6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601BFBD RID: 114621 RVA: 0x003F4FB3 File Offset: 0x003F31B3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601BFBE RID: 114622 RVA: 0x003F4FBC File Offset: 0x003F31BC
		public static ILevelPlayInfoMappingNightmareSpawnPoint GetRootAsILevelPlayInfoMappingNightmareSpawnPoint(ByteBuffer _bb)
		{
			return ILevelPlayInfoMappingNightmareSpawnPoint.GetRootAsILevelPlayInfoMappingNightmareSpawnPoint(_bb, default(ILevelPlayInfoMappingNightmareSpawnPoint));
		}

		// Token: 0x0601BFBF RID: 114623 RVA: 0x003F4FD8 File Offset: 0x003F31D8
		public static ILevelPlayInfoMappingNightmareSpawnPoint GetRootAsILevelPlayInfoMappingNightmareSpawnPoint(ByteBuffer _bb, ILevelPlayInfoMappingNightmareSpawnPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601BFC0 RID: 114624 RVA: 0x003F4FF5 File Offset: 0x003F31F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601BFC1 RID: 114625 RVA: 0x003F5004 File Offset: 0x003F3204
		public ILevelPlayInfoMappingNightmareSpawnPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008359 RID: 33625
		// (get) Token: 0x0601BFC2 RID: 114626 RVA: 0x003F5014 File Offset: 0x003F3214
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

		// Token: 0x1700835A RID: 33626
		// (get) Token: 0x0601BFC3 RID: 114627 RVA: 0x003F5050 File Offset: 0x003F3250
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

		// Token: 0x0601BFC4 RID: 114628 RVA: 0x003F508C File Offset: 0x003F328C
		public string Vars(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700835B RID: 33627
		// (get) Token: 0x0601BFC5 RID: 114629 RVA: 0x003F50C8 File Offset: 0x003F32C8
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

		// Token: 0x0601BFC6 RID: 114630 RVA: 0x003F50F4 File Offset: 0x003F32F4
		public int DefaultValues(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700835C RID: 33628
		// (get) Token: 0x0601BFC7 RID: 114631 RVA: 0x003F5134 File Offset: 0x003F3334
		public int DefaultValuesLength
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

		// Token: 0x0601BFC8 RID: 114632 RVA: 0x003F5160 File Offset: 0x003F3360
		public Span<int> GetDefaultValuesBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0601BFC9 RID: 114633 RVA: 0x003F5170 File Offset: 0x003F3370
		public int[] GetDefaultValuesArray()
		{
			return this.__p.__vector_as_array<int>(10);
		}

		// Token: 0x1700835D RID: 33629
		// (get) Token: 0x0601BFCA RID: 114634 RVA: 0x003F5180 File Offset: 0x003F3380
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

		// Token: 0x0601BFCB RID: 114635 RVA: 0x003F51BD File Offset: 0x003F33BD
		public static Offset<ILevelPlayInfoMappingNightmareSpawnPoint> CreateILevelPlayInfoMappingNightmareSpawnPoint(FlatBufferBuilder builder, ELevelPlayInfoMappingType Type = ELevelPlayInfoMappingType.PunishReport, int LevelPlayId = 0, VectorOffset VarsOffset = default(VectorOffset), VectorOffset DefaultValuesOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(5);
			ILevelPlayInfoMappingNightmareSpawnPoint.AddDefaultValues(builder, DefaultValuesOffset);
			ILevelPlayInfoMappingNightmareSpawnPoint.AddVars(builder, VarsOffset);
			ILevelPlayInfoMappingNightmareSpawnPoint.AddLevelPlayId(builder, LevelPlayId);
			ILevelPlayInfoMappingNightmareSpawnPoint.AddNullMask(builder, NullMask);
			ILevelPlayInfoMappingNightmareSpawnPoint.AddType(builder, Type);
			return ILevelPlayInfoMappingNightmareSpawnPoint.EndILevelPlayInfoMappingNightmareSpawnPoint(builder);
		}

		// Token: 0x0601BFCC RID: 114636 RVA: 0x003F51F1 File Offset: 0x003F33F1
		public static void StartILevelPlayInfoMappingNightmareSpawnPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601BFCD RID: 114637 RVA: 0x003F51FA File Offset: 0x003F33FA
		public static void AddType(FlatBufferBuilder builder, ELevelPlayInfoMappingType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601BFCE RID: 114638 RVA: 0x003F5205 File Offset: 0x003F3405
		public static void AddLevelPlayId(FlatBufferBuilder builder, int levelPlayId)
		{
			builder.AddInt(1, levelPlayId, 0);
		}

		// Token: 0x0601BFCF RID: 114639 RVA: 0x003F5210 File Offset: 0x003F3410
		public static void AddVars(FlatBufferBuilder builder, VectorOffset varsOffset)
		{
			builder.AddOffset(2, varsOffset.Value, 0);
		}

		// Token: 0x0601BFD0 RID: 114640 RVA: 0x003F5220 File Offset: 0x003F3420
		public static VectorOffset CreateVarsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601BFD1 RID: 114641 RVA: 0x003F5260 File Offset: 0x003F3460
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BFD2 RID: 114642 RVA: 0x003F527A File Offset: 0x003F347A
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BFD3 RID: 114643 RVA: 0x003F5298 File Offset: 0x003F3498
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601BFD4 RID: 114644 RVA: 0x003F52B1 File Offset: 0x003F34B1
		public static void StartVarsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601BFD5 RID: 114645 RVA: 0x003F52BC File Offset: 0x003F34BC
		public static void AddDefaultValues(FlatBufferBuilder builder, VectorOffset defaultValuesOffset)
		{
			builder.AddOffset(3, defaultValuesOffset.Value, 0);
		}

		// Token: 0x0601BFD6 RID: 114646 RVA: 0x003F52CC File Offset: 0x003F34CC
		public static VectorOffset CreateDefaultValuesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601BFD7 RID: 114647 RVA: 0x003F5303 File Offset: 0x003F3503
		public static VectorOffset CreateDefaultValuesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BFD8 RID: 114648 RVA: 0x003F531D File Offset: 0x003F351D
		public static VectorOffset CreateDefaultValuesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BFD9 RID: 114649 RVA: 0x003F533B File Offset: 0x003F353B
		public static VectorOffset CreateDefaultValuesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601BFDA RID: 114650 RVA: 0x003F5354 File Offset: 0x003F3554
		public static void StartDefaultValuesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601BFDB RID: 114651 RVA: 0x003F535F File Offset: 0x003F355F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0601BFDC RID: 114652 RVA: 0x003F536A File Offset: 0x003F356A
		public static Offset<ILevelPlayInfoMappingNightmareSpawnPoint> EndILevelPlayInfoMappingNightmareSpawnPoint(FlatBufferBuilder builder)
		{
			return new Offset<ILevelPlayInfoMappingNightmareSpawnPoint>(builder.EndTable());
		}

		// Token: 0x0601BFDD RID: 114653 RVA: 0x003F5378 File Offset: 0x003F3578
		public ILevelPlayInfoMappingNightmareSpawnPointT UnPack()
		{
			ILevelPlayInfoMappingNightmareSpawnPointT levelPlayInfoMappingNightmareSpawnPointT = new ILevelPlayInfoMappingNightmareSpawnPointT();
			this.UnPackTo(levelPlayInfoMappingNightmareSpawnPointT);
			return levelPlayInfoMappingNightmareSpawnPointT;
		}

		// Token: 0x0601BFDE RID: 114654 RVA: 0x003F5394 File Offset: 0x003F3594
		public void UnPackTo(ILevelPlayInfoMappingNightmareSpawnPointT _o)
		{
			_o.Type = this.Type;
			_o.LevelPlayId = this.LevelPlayId;
			_o.Vars = new List<string>();
			for (int i = 0; i < this.VarsLength; i++)
			{
				_o.Vars.Add(this.Vars(i));
			}
			_o.DefaultValues = new List<int>();
			for (int j = 0; j < this.DefaultValuesLength; j++)
			{
				_o.DefaultValues.Add(this.DefaultValues(j));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601BFDF RID: 114655 RVA: 0x003F5424 File Offset: 0x003F3624
		public static Offset<ILevelPlayInfoMappingNightmareSpawnPoint> Pack(FlatBufferBuilder builder, ILevelPlayInfoMappingNightmareSpawnPointT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILevelPlayInfoMappingNightmareSpawnPoint>);
			}
			VectorOffset varsOffset = default(VectorOffset);
			if (_o.Vars != null)
			{
				StringOffset[] array = new StringOffset[_o.Vars.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = builder.CreateString(_o.Vars[i]);
				}
				varsOffset = ILevelPlayInfoMappingNightmareSpawnPoint.CreateVarsVector(builder, array);
			}
			VectorOffset defaultValuesOffset = default(VectorOffset);
			if (_o.DefaultValues != null)
			{
				int[] data = _o.DefaultValues.ToArray();
				defaultValuesOffset = ILevelPlayInfoMappingNightmareSpawnPoint.CreateDefaultValuesVector(builder, data);
			}
			return ILevelPlayInfoMappingNightmareSpawnPoint.CreateILevelPlayInfoMappingNightmareSpawnPoint(builder, _o.Type, _o.LevelPlayId, varsOffset, defaultValuesOffset, _o.NullMask);
		}

		// Token: 0x0400CF84 RID: 53124
		private Table __p;
	}
}
