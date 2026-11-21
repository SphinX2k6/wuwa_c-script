using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Level
{
	// Token: 0x02004877 RID: 18551
	public struct ILevelsConfig : IFlatbufferObject
	{
		// Token: 0x1700812D RID: 33069
		// (get) Token: 0x0601B6EB RID: 112363 RVA: 0x003E206B File Offset: 0x003E026B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B6EC RID: 112364 RVA: 0x003E2078 File Offset: 0x003E0278
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B6ED RID: 112365 RVA: 0x003E2080 File Offset: 0x003E0280
		public static ILevelsConfig GetRootAsILevelsConfig(ByteBuffer _bb)
		{
			return ILevelsConfig.GetRootAsILevelsConfig(_bb, default(ILevelsConfig));
		}

		// Token: 0x0601B6EE RID: 112366 RVA: 0x003E209C File Offset: 0x003E029C
		public static ILevelsConfig GetRootAsILevelsConfig(ByteBuffer _bb, ILevelsConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B6EF RID: 112367 RVA: 0x003E20B9 File Offset: 0x003E02B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B6F0 RID: 112368 RVA: 0x003E20C8 File Offset: 0x003E02C8
		public ILevelsConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0601B6F1 RID: 112369 RVA: 0x003E20D8 File Offset: 0x003E02D8
		public ILevelConfig? Levels(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new ILevelConfig?(default(ILevelConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700812E RID: 33070
		// (get) Token: 0x0601B6F2 RID: 112370 RVA: 0x003E2138 File Offset: 0x003E0338
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

		// Token: 0x0601B6F3 RID: 112371 RVA: 0x003E2163 File Offset: 0x003E0363
		public static Offset<ILevelsConfig> CreateILevelsConfig(FlatBufferBuilder builder, VectorOffset LevelsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			ILevelsConfig.AddLevels(builder, LevelsOffset);
			return ILevelsConfig.EndILevelsConfig(builder);
		}

		// Token: 0x0601B6F4 RID: 112372 RVA: 0x003E2179 File Offset: 0x003E0379
		public static void StartILevelsConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601B6F5 RID: 112373 RVA: 0x003E2182 File Offset: 0x003E0382
		public static void AddLevels(FlatBufferBuilder builder, VectorOffset levelsOffset)
		{
			builder.AddOffset(0, levelsOffset.Value, 0);
		}

		// Token: 0x0601B6F6 RID: 112374 RVA: 0x003E2194 File Offset: 0x003E0394
		public static VectorOffset CreateLevelsVector(FlatBufferBuilder builder, Offset<ILevelConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601B6F7 RID: 112375 RVA: 0x003E21D4 File Offset: 0x003E03D4
		public static VectorOffset CreateLevelsVectorBlock(FlatBufferBuilder builder, Offset<ILevelConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ILevelConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B6F8 RID: 112376 RVA: 0x003E21EE File Offset: 0x003E03EE
		public static VectorOffset CreateLevelsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ILevelConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ILevelConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B6F9 RID: 112377 RVA: 0x003E220C File Offset: 0x003E040C
		public static VectorOffset CreateLevelsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ILevelConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601B6FA RID: 112378 RVA: 0x003E2225 File Offset: 0x003E0425
		public static void StartLevelsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601B6FB RID: 112379 RVA: 0x003E2230 File Offset: 0x003E0430
		public static Offset<ILevelsConfig> EndILevelsConfig(FlatBufferBuilder builder)
		{
			return new Offset<ILevelsConfig>(builder.EndTable());
		}

		// Token: 0x0601B6FC RID: 112380 RVA: 0x003E2240 File Offset: 0x003E0440
		public ILevelsConfigT UnPack()
		{
			ILevelsConfigT levelsConfigT = new ILevelsConfigT();
			this.UnPackTo(levelsConfigT);
			return levelsConfigT;
		}

		// Token: 0x0601B6FD RID: 112381 RVA: 0x003E225C File Offset: 0x003E045C
		public void UnPackTo(ILevelsConfigT _o)
		{
			_o.Levels = new List<ILevelConfigT>();
			for (int i = 0; i < this.LevelsLength; i++)
			{
				_o.Levels.Add((this.Levels(i) != null) ? this.Levels(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601B6FE RID: 112382 RVA: 0x003E22BC File Offset: 0x003E04BC
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

		// Token: 0x0400CD9A RID: 52634
		private Table __p;
	}
}
