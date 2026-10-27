using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Level
{
	// Token: 0x0200440F RID: 17423
	public struct ILevelsConfig : IFlatbufferObject
	{
		// Token: 0x17007AEE RID: 31470
		// (get) Token: 0x06019F1A RID: 106266 RVA: 0x003B5E5F File Offset: 0x003B405F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019F1B RID: 106267 RVA: 0x003B5E6C File Offset: 0x003B406C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019F1C RID: 106268 RVA: 0x003B5E74 File Offset: 0x003B4074
		public static ILevelsConfig GetRootAsILevelsConfig(ByteBuffer _bb)
		{
			return ILevelsConfig.GetRootAsILevelsConfig(_bb, default(ILevelsConfig));
		}

		// Token: 0x06019F1D RID: 106269 RVA: 0x003B5E90 File Offset: 0x003B4090
		public static ILevelsConfig GetRootAsILevelsConfig(ByteBuffer _bb, ILevelsConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019F1E RID: 106270 RVA: 0x003B5EAD File Offset: 0x003B40AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019F1F RID: 106271 RVA: 0x003B5EBC File Offset: 0x003B40BC
		public ILevelsConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06019F20 RID: 106272 RVA: 0x003B5ECC File Offset: 0x003B40CC
		public ILevelConfig? Levels(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new ILevelConfig?(default(ILevelConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007AEF RID: 31471
		// (get) Token: 0x06019F21 RID: 106273 RVA: 0x003B5F2C File Offset: 0x003B412C
		public int LevelsLength
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06019F22 RID: 106274 RVA: 0x003B5F57 File Offset: 0x003B4157
		public static Offset<ILevelsConfig> CreateILevelsConfig(FlatBufferBuilder builder, VectorOffset LevelsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			ILevelsConfig.AddLevels(builder, LevelsOffset);
			return ILevelsConfig.EndILevelsConfig(builder);
		}

		// Token: 0x06019F23 RID: 106275 RVA: 0x003B5F6D File Offset: 0x003B416D
		public static void StartILevelsConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06019F24 RID: 106276 RVA: 0x003B5F76 File Offset: 0x003B4176
		public static void AddLevels(FlatBufferBuilder builder, VectorOffset levelsOffset)
		{
			builder.AddOffset(0, levelsOffset.Value, 0);
		}

		// Token: 0x06019F25 RID: 106277 RVA: 0x003B5F88 File Offset: 0x003B4188
		public static VectorOffset CreateLevelsVector(FlatBufferBuilder builder, Offset<ILevelConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06019F26 RID: 106278 RVA: 0x003B5FC8 File Offset: 0x003B41C8
		public static VectorOffset CreateLevelsVectorBlock(FlatBufferBuilder builder, Offset<ILevelConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ILevelConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06019F27 RID: 106279 RVA: 0x003B5FE2 File Offset: 0x003B41E2
		public static VectorOffset CreateLevelsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ILevelConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ILevelConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06019F28 RID: 106280 RVA: 0x003B6000 File Offset: 0x003B4200
		public static VectorOffset CreateLevelsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ILevelConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06019F29 RID: 106281 RVA: 0x003B6019 File Offset: 0x003B4219
		public static void StartLevelsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06019F2A RID: 106282 RVA: 0x003B6024 File Offset: 0x003B4224
		public static Offset<ILevelsConfig> EndILevelsConfig(FlatBufferBuilder builder)
		{
			return new Offset<ILevelsConfig>(builder.EndTable());
		}

		// Token: 0x06019F2B RID: 106283 RVA: 0x003B6034 File Offset: 0x003B4234
		public ILevelsConfigT UnPack()
		{
			ILevelsConfigT levelsConfigT = new ILevelsConfigT();
			this.UnPackTo(levelsConfigT);
			return levelsConfigT;
		}

		// Token: 0x06019F2C RID: 106284 RVA: 0x003B6050 File Offset: 0x003B4250
		public void UnPackTo(ILevelsConfigT _o)
		{
			_o.Levels = new List<ILevelConfigT>();
			for (int i = 0; i < this.LevelsLength; i++)
			{
				_o.Levels.Add((this.Levels(i) != null) ? this.Levels(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06019F2D RID: 106285 RVA: 0x003B60B0 File Offset: 0x003B42B0
		public static Offset<ILevelsConfig> Pack(FlatBufferBuilder builder, ILevelsConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILevelsConfig>);
			}
			VectorOffset levelsOffset = default(VectorOffset);
			if (_o.Levels != null)
			{
				Offset<ILevelConfig>[] array = new Offset<ILevelConfig>[_o.Levels.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ILevelConfig.Pack(builder, _o.Levels[i]);
				}
				levelsOffset = ILevelsConfig.CreateLevelsVector(builder, array);
			}
			return ILevelsConfig.CreateILevelsConfig(builder, levelsOffset);
		}

		// Token: 0x0400C36D RID: 50029
		private Table __p;
	}
}
