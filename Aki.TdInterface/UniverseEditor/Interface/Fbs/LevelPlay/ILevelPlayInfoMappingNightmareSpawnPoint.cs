using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044F7 RID: 17655
	public struct ILevelPlayInfoMappingNightmareSpawnPoint : IFlatbufferObject
	{
		// Token: 0x17007D17 RID: 32023
		// (get) Token: 0x0601A7E7 RID: 108519 RVA: 0x003C8D0A File Offset: 0x003C6F0A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A7E8 RID: 108520 RVA: 0x003C8D17 File Offset: 0x003C6F17
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A7E9 RID: 108521 RVA: 0x003C8D20 File Offset: 0x003C6F20
		public static ILevelPlayInfoMappingNightmareSpawnPoint GetRootAsILevelPlayInfoMappingNightmareSpawnPoint(ByteBuffer _bb)
		{
			return ILevelPlayInfoMappingNightmareSpawnPoint.GetRootAsILevelPlayInfoMappingNightmareSpawnPoint(_bb, default(ILevelPlayInfoMappingNightmareSpawnPoint));
		}

		// Token: 0x0601A7EA RID: 108522 RVA: 0x003C8D3C File Offset: 0x003C6F3C
		public static ILevelPlayInfoMappingNightmareSpawnPoint GetRootAsILevelPlayInfoMappingNightmareSpawnPoint(ByteBuffer _bb, ILevelPlayInfoMappingNightmareSpawnPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A7EB RID: 108523 RVA: 0x003C8D59 File Offset: 0x003C6F59
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A7EC RID: 108524 RVA: 0x003C8D68 File Offset: 0x003C6F68
		public ILevelPlayInfoMappingNightmareSpawnPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007D18 RID: 32024
		// (get) Token: 0x0601A7ED RID: 108525 RVA: 0x003C8D78 File Offset: 0x003C6F78
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

		// Token: 0x17007D19 RID: 32025
		// (get) Token: 0x0601A7EE RID: 108526 RVA: 0x003C8DB4 File Offset: 0x003C6FB4
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

		// Token: 0x0601A7EF RID: 108527 RVA: 0x003C8DF0 File Offset: 0x003C6FF0
		public string Vars(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007D1A RID: 32026
		// (get) Token: 0x0601A7F0 RID: 108528 RVA: 0x003C8E2C File Offset: 0x003C702C
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

		// Token: 0x0601A7F1 RID: 108529 RVA: 0x003C8E58 File Offset: 0x003C7058
		public int DefaultValues(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007D1B RID: 32027
		// (get) Token: 0x0601A7F2 RID: 108530 RVA: 0x003C8E98 File Offset: 0x003C7098
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

		// Token: 0x0601A7F3 RID: 108531 RVA: 0x003C8EC4 File Offset: 0x003C70C4
		public Span<int> GetDefaultValuesBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0601A7F4 RID: 108532 RVA: 0x003C8ED4 File Offset: 0x003C70D4
		public int[] GetDefaultValuesArray()
		{
			return this.__p.__vector_as_array<int>(10);
		}

		// Token: 0x17007D1C RID: 32028
		// (get) Token: 0x0601A7F5 RID: 108533 RVA: 0x003C8EE4 File Offset: 0x003C70E4
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

		// Token: 0x0601A7F6 RID: 108534 RVA: 0x003C8F21 File Offset: 0x003C7121
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

		// Token: 0x0601A7F7 RID: 108535 RVA: 0x003C8F55 File Offset: 0x003C7155
		public static void StartILevelPlayInfoMappingNightmareSpawnPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601A7F8 RID: 108536 RVA: 0x003C8F5E File Offset: 0x003C715E
		public static void AddType(FlatBufferBuilder builder, ELevelPlayInfoMappingType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A7F9 RID: 108537 RVA: 0x003C8F69 File Offset: 0x003C7169
		public static void AddLevelPlayId(FlatBufferBuilder builder, int levelPlayId)
		{
			builder.AddInt(1, levelPlayId, 0);
		}

		// Token: 0x0601A7FA RID: 108538 RVA: 0x003C8F74 File Offset: 0x003C7174
		public static void AddVars(FlatBufferBuilder builder, VectorOffset varsOffset)
		{
			builder.AddOffset(2, varsOffset.Value, 0);
		}

		// Token: 0x0601A7FB RID: 108539 RVA: 0x003C8F84 File Offset: 0x003C7184
		public static VectorOffset CreateVarsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601A7FC RID: 108540 RVA: 0x003C8FC4 File Offset: 0x003C71C4
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A7FD RID: 108541 RVA: 0x003C8FDE File Offset: 0x003C71DE
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A7FE RID: 108542 RVA: 0x003C8FFC File Offset: 0x003C71FC
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601A7FF RID: 108543 RVA: 0x003C9015 File Offset: 0x003C7215
		public static void StartVarsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601A800 RID: 108544 RVA: 0x003C9020 File Offset: 0x003C7220
		public static void AddDefaultValues(FlatBufferBuilder builder, VectorOffset defaultValuesOffset)
		{
			builder.AddOffset(3, defaultValuesOffset.Value, 0);
		}

		// Token: 0x0601A801 RID: 108545 RVA: 0x003C9030 File Offset: 0x003C7230
		public static VectorOffset CreateDefaultValuesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601A802 RID: 108546 RVA: 0x003C9067 File Offset: 0x003C7267
		public static VectorOffset CreateDefaultValuesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A803 RID: 108547 RVA: 0x003C9081 File Offset: 0x003C7281
		public static VectorOffset CreateDefaultValuesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A804 RID: 108548 RVA: 0x003C909F File Offset: 0x003C729F
		public static VectorOffset CreateDefaultValuesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601A805 RID: 108549 RVA: 0x003C90B8 File Offset: 0x003C72B8
		public static void StartDefaultValuesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601A806 RID: 108550 RVA: 0x003C90C3 File Offset: 0x003C72C3
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0601A807 RID: 108551 RVA: 0x003C90CE File Offset: 0x003C72CE
		public static Offset<ILevelPlayInfoMappingNightmareSpawnPoint> EndILevelPlayInfoMappingNightmareSpawnPoint(FlatBufferBuilder builder)
		{
			return new Offset<ILevelPlayInfoMappingNightmareSpawnPoint>(builder.EndTable());
		}

		// Token: 0x0601A808 RID: 108552 RVA: 0x003C90DC File Offset: 0x003C72DC
		public ILevelPlayInfoMappingNightmareSpawnPointT UnPack()
		{
			ILevelPlayInfoMappingNightmareSpawnPointT levelPlayInfoMappingNightmareSpawnPointT = new ILevelPlayInfoMappingNightmareSpawnPointT();
			this.UnPackTo(levelPlayInfoMappingNightmareSpawnPointT);
			return levelPlayInfoMappingNightmareSpawnPointT;
		}

		// Token: 0x0601A809 RID: 108553 RVA: 0x003C90F8 File Offset: 0x003C72F8
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

		// Token: 0x0601A80A RID: 108554 RVA: 0x003C9188 File Offset: 0x003C7388
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

		// Token: 0x0400C555 RID: 50517
		private Table __p;
	}
}
