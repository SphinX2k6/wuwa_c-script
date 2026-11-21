using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B66 RID: 31590
	public struct ITeleportDungeonFunction : IFlatbufferObject
	{
		// Token: 0x1700EC8B RID: 60555
		// (get) Token: 0x06038E48 RID: 233032 RVA: 0x007B10D0 File Offset: 0x007AF2D0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06038E49 RID: 233033 RVA: 0x007B10DD File Offset: 0x007AF2DD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06038E4A RID: 233034 RVA: 0x007B10E4 File Offset: 0x007AF2E4
		public static ITeleportDungeonFunction GetRootAsITeleportDungeonFunction(ByteBuffer _bb)
		{
			return ITeleportDungeonFunction.GetRootAsITeleportDungeonFunction(_bb, default(ITeleportDungeonFunction));
		}

		// Token: 0x06038E4B RID: 233035 RVA: 0x007B1100 File Offset: 0x007AF300
		public static ITeleportDungeonFunction GetRootAsITeleportDungeonFunction(ByteBuffer _bb, ITeleportDungeonFunction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06038E4C RID: 233036 RVA: 0x007B111D File Offset: 0x007AF31D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06038E4D RID: 233037 RVA: 0x007B112C File Offset: 0x007AF32C
		public ITeleportDungeonFunction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EC8C RID: 60556
		// (get) Token: 0x06038E4E RID: 233038 RVA: 0x007B113C File Offset: 0x007AF33C
		public EEnableFunctionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EEnableFunctionType.TeleportDungeon;
				}
				return (EEnableFunctionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700EC8D RID: 60557
		// (get) Token: 0x06038E4F RID: 233039 RVA: 0x007B1178 File Offset: 0x007AF378
		public bool Enable
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06038E50 RID: 233040 RVA: 0x007B11B8 File Offset: 0x007AF3B8
		public int DungeonList(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700EC8E RID: 60558
		// (get) Token: 0x06038E51 RID: 233041 RVA: 0x007B11F8 File Offset: 0x007AF3F8
		public int DungeonListLength
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

		// Token: 0x06038E52 RID: 233042 RVA: 0x007B1223 File Offset: 0x007AF423
		public Span<int> GetDungeonListBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06038E53 RID: 233043 RVA: 0x007B1232 File Offset: 0x007AF432
		public int[] GetDungeonListArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x1700EC8F RID: 60559
		// (get) Token: 0x06038E54 RID: 233044 RVA: 0x007B1240 File Offset: 0x007AF440
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

		// Token: 0x06038E55 RID: 233045 RVA: 0x007B127D File Offset: 0x007AF47D
		public static Offset<ITeleportDungeonFunction> CreateITeleportDungeonFunction(FlatBufferBuilder builder, EEnableFunctionType Type = EEnableFunctionType.TeleportDungeon, bool Enable = false, VectorOffset DungeonListOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			ITeleportDungeonFunction.AddDungeonList(builder, DungeonListOffset);
			ITeleportDungeonFunction.AddNullMask(builder, NullMask);
			ITeleportDungeonFunction.AddEnable(builder, Enable);
			ITeleportDungeonFunction.AddType(builder, Type);
			return ITeleportDungeonFunction.EndITeleportDungeonFunction(builder);
		}

		// Token: 0x06038E56 RID: 233046 RVA: 0x007B12A9 File Offset: 0x007AF4A9
		public static void StartITeleportDungeonFunction(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06038E57 RID: 233047 RVA: 0x007B12B2 File Offset: 0x007AF4B2
		public static void AddType(FlatBufferBuilder builder, EEnableFunctionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06038E58 RID: 233048 RVA: 0x007B12BD File Offset: 0x007AF4BD
		public static void AddEnable(FlatBufferBuilder builder, bool enable)
		{
			builder.AddBool(1, enable, false);
		}

		// Token: 0x06038E59 RID: 233049 RVA: 0x007B12C8 File Offset: 0x007AF4C8
		public static void AddDungeonList(FlatBufferBuilder builder, VectorOffset dungeonListOffset)
		{
			builder.AddOffset(2, dungeonListOffset.Value, 0);
		}

		// Token: 0x06038E5A RID: 233050 RVA: 0x007B12D8 File Offset: 0x007AF4D8
		public static VectorOffset CreateDungeonListVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06038E5B RID: 233051 RVA: 0x007B130F File Offset: 0x007AF50F
		public static VectorOffset CreateDungeonListVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06038E5C RID: 233052 RVA: 0x007B1329 File Offset: 0x007AF529
		public static VectorOffset CreateDungeonListVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06038E5D RID: 233053 RVA: 0x007B1347 File Offset: 0x007AF547
		public static VectorOffset CreateDungeonListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06038E5E RID: 233054 RVA: 0x007B1360 File Offset: 0x007AF560
		public static void StartDungeonListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06038E5F RID: 233055 RVA: 0x007B136B File Offset: 0x007AF56B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06038E60 RID: 233056 RVA: 0x007B1376 File Offset: 0x007AF576
		public static Offset<ITeleportDungeonFunction> EndITeleportDungeonFunction(FlatBufferBuilder builder)
		{
			return new Offset<ITeleportDungeonFunction>(builder.EndTable());
		}

		// Token: 0x06038E61 RID: 233057 RVA: 0x007B1384 File Offset: 0x007AF584
		public ITeleportDungeonFunctionT UnPack()
		{
			ITeleportDungeonFunctionT teleportDungeonFunctionT = new ITeleportDungeonFunctionT();
			this.UnPackTo(teleportDungeonFunctionT);
			return teleportDungeonFunctionT;
		}

		// Token: 0x06038E62 RID: 233058 RVA: 0x007B13A0 File Offset: 0x007AF5A0
		public void UnPackTo(ITeleportDungeonFunctionT _o)
		{
			_o.Type = this.Type;
			_o.Enable = this.Enable;
			_o.DungeonList = new List<int>();
			for (int i = 0; i < this.DungeonListLength; i++)
			{
				_o.DungeonList.Add(this.DungeonList(i));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06038E63 RID: 233059 RVA: 0x007B1400 File Offset: 0x007AF600
		public static Offset<ITeleportDungeonFunction> Pack(FlatBufferBuilder builder, ITeleportDungeonFunctionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITeleportDungeonFunction>);
			}
			VectorOffset dungeonListOffset = default(VectorOffset);
			if (_o.DungeonList != null)
			{
				int[] data = _o.DungeonList.ToArray();
				dungeonListOffset = ITeleportDungeonFunction.CreateDungeonListVector(builder, data);
			}
			return ITeleportDungeonFunction.CreateITeleportDungeonFunction(builder, _o.Type, _o.Enable, dungeonListOffset, _o.NullMask);
		}

		// Token: 0x040131B3 RID: 78259
		private Table __p;
	}
}
