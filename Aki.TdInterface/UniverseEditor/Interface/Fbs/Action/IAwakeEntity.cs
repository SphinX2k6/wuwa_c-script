using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061CD RID: 25037
	public struct IAwakeEntity : IFlatbufferObject
	{
		// Token: 0x1700BAB0 RID: 47792
		// (get) Token: 0x0602B260 RID: 176736 RVA: 0x005F2B06 File Offset: 0x005F0D06
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B261 RID: 176737 RVA: 0x005F2B13 File Offset: 0x005F0D13
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B262 RID: 176738 RVA: 0x005F2B1C File Offset: 0x005F0D1C
		public static IAwakeEntity GetRootAsIAwakeEntity(ByteBuffer _bb)
		{
			return IAwakeEntity.GetRootAsIAwakeEntity(_bb, default(IAwakeEntity));
		}

		// Token: 0x0602B263 RID: 176739 RVA: 0x005F2B38 File Offset: 0x005F0D38
		public static IAwakeEntity GetRootAsIAwakeEntity(ByteBuffer _bb, IAwakeEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B264 RID: 176740 RVA: 0x005F2B55 File Offset: 0x005F0D55
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B265 RID: 176741 RVA: 0x005F2B64 File Offset: 0x005F0D64
		public IAwakeEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BAB1 RID: 47793
		// (get) Token: 0x0602B266 RID: 176742 RVA: 0x005F2B74 File Offset: 0x005F0D74
		public IAwakeWithTransformVar? Position
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IAwakeWithTransformVar?(default(IAwakeWithTransformVar).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700BAB2 RID: 47794
		// (get) Token: 0x0602B267 RID: 176743 RVA: 0x005F2BD4 File Offset: 0x005F0DD4
		public bool IsSnap
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0602B268 RID: 176744 RVA: 0x005F2C14 File Offset: 0x005F0E14
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700BAB3 RID: 47795
		// (get) Token: 0x0602B269 RID: 176745 RVA: 0x005F2C54 File Offset: 0x005F0E54
		public int EntityIdsLength
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

		// Token: 0x0602B26A RID: 176746 RVA: 0x005F2C7F File Offset: 0x005F0E7F
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0602B26B RID: 176747 RVA: 0x005F2C8E File Offset: 0x005F0E8E
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x1700BAB4 RID: 47796
		// (get) Token: 0x0602B26C RID: 176748 RVA: 0x005F2C9C File Offset: 0x005F0E9C
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

		// Token: 0x0602B26D RID: 176749 RVA: 0x005F2CD9 File Offset: 0x005F0ED9
		public static Offset<IAwakeEntity> CreateIAwakeEntity(FlatBufferBuilder builder, Offset<IAwakeWithTransformVar> PositionOffset = default(Offset<IAwakeWithTransformVar>), bool IsSnap = false, VectorOffset EntityIdsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			IAwakeEntity.AddEntityIds(builder, EntityIdsOffset);
			IAwakeEntity.AddPosition(builder, PositionOffset);
			IAwakeEntity.AddNullMask(builder, NullMask);
			IAwakeEntity.AddIsSnap(builder, IsSnap);
			return IAwakeEntity.EndIAwakeEntity(builder);
		}

		// Token: 0x0602B26E RID: 176750 RVA: 0x005F2D05 File Offset: 0x005F0F05
		public static void StartIAwakeEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602B26F RID: 176751 RVA: 0x005F2D0E File Offset: 0x005F0F0E
		public static void AddPosition(FlatBufferBuilder builder, Offset<IAwakeWithTransformVar> positionOffset)
		{
			builder.AddOffset(0, positionOffset.Value, 0);
		}

		// Token: 0x0602B270 RID: 176752 RVA: 0x005F2D1E File Offset: 0x005F0F1E
		public static void AddIsSnap(FlatBufferBuilder builder, bool isSnap)
		{
			builder.AddBool(1, isSnap, false);
		}

		// Token: 0x0602B271 RID: 176753 RVA: 0x005F2D29 File Offset: 0x005F0F29
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(2, entityIdsOffset.Value, 0);
		}

		// Token: 0x0602B272 RID: 176754 RVA: 0x005F2D3C File Offset: 0x005F0F3C
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602B273 RID: 176755 RVA: 0x005F2D73 File Offset: 0x005F0F73
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602B274 RID: 176756 RVA: 0x005F2D8D File Offset: 0x005F0F8D
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602B275 RID: 176757 RVA: 0x005F2DAB File Offset: 0x005F0FAB
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602B276 RID: 176758 RVA: 0x005F2DC4 File Offset: 0x005F0FC4
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602B277 RID: 176759 RVA: 0x005F2DCF File Offset: 0x005F0FCF
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602B278 RID: 176760 RVA: 0x005F2DDA File Offset: 0x005F0FDA
		public static Offset<IAwakeEntity> EndIAwakeEntity(FlatBufferBuilder builder)
		{
			return new Offset<IAwakeEntity>(builder.EndTable());
		}

		// Token: 0x0602B279 RID: 176761 RVA: 0x005F2DE8 File Offset: 0x005F0FE8
		public IAwakeEntityT UnPack()
		{
			IAwakeEntityT awakeEntityT = new IAwakeEntityT();
			this.UnPackTo(awakeEntityT);
			return awakeEntityT;
		}

		// Token: 0x0602B27A RID: 176762 RVA: 0x005F2E04 File Offset: 0x005F1004
		public void UnPackTo(IAwakeEntityT _o)
		{
			_o.Position = ((this.Position != null) ? this.Position.Value.UnPack() : null);
			_o.IsSnap = this.IsSnap;
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602B27B RID: 176763 RVA: 0x005F2E88 File Offset: 0x005F1088
		public static Offset<IAwakeEntity> Pack(FlatBufferBuilder builder, IAwakeEntityT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAwakeEntity>);
			}
			Offset<IAwakeWithTransformVar> positionOffset = (_o.Position == null) ? default(Offset<IAwakeWithTransformVar>) : IAwakeWithTransformVar.Pack(builder, _o.Position);
			VectorOffset entityIdsOffset = default(VectorOffset);
			if (_o.EntityIds != null)
			{
				int[] data = _o.EntityIds.ToArray();
				entityIdsOffset = IAwakeEntity.CreateEntityIdsVector(builder, data);
			}
			return IAwakeEntity.CreateIAwakeEntity(builder, positionOffset, _o.IsSnap, entityIdsOffset, _o.NullMask);
		}

		// Token: 0x040106F4 RID: 67316
		private Table __p;
	}
}
