using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B42 RID: 27458
	public struct IControlTrackingOther : IFlatbufferObject
	{
		// Token: 0x1700C9A4 RID: 51620
		// (get) Token: 0x0602F3FA RID: 193530 RVA: 0x0067371C File Offset: 0x0067191C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F3FB RID: 193531 RVA: 0x00673729 File Offset: 0x00671929
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F3FC RID: 193532 RVA: 0x00673730 File Offset: 0x00671930
		public static IControlTrackingOther GetRootAsIControlTrackingOther(ByteBuffer _bb)
		{
			return IControlTrackingOther.GetRootAsIControlTrackingOther(_bb, default(IControlTrackingOther));
		}

		// Token: 0x0602F3FD RID: 193533 RVA: 0x0067374C File Offset: 0x0067194C
		public static IControlTrackingOther GetRootAsIControlTrackingOther(ByteBuffer _bb, IControlTrackingOther obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F3FE RID: 193534 RVA: 0x00673769 File Offset: 0x00671969
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F3FF RID: 193535 RVA: 0x00673778 File Offset: 0x00671978
		public IControlTrackingOther __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C9A5 RID: 51621
		// (get) Token: 0x0602F400 RID: 193536 RVA: 0x00673788 File Offset: 0x00671988
		public EControlTrackingType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EControlTrackingType.Self;
				}
				return (EControlTrackingType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602F401 RID: 193537 RVA: 0x006737C4 File Offset: 0x006719C4
		public int Entities(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700C9A6 RID: 51622
		// (get) Token: 0x0602F402 RID: 193538 RVA: 0x00673804 File Offset: 0x00671A04
		public int EntitiesLength
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

		// Token: 0x0602F403 RID: 193539 RVA: 0x0067382F File Offset: 0x00671A2F
		public Span<int> GetEntitiesBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0602F404 RID: 193540 RVA: 0x0067383E File Offset: 0x00671A3E
		public int[] GetEntitiesArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x0602F405 RID: 193541 RVA: 0x0067384C File Offset: 0x00671A4C
		public static Offset<IControlTrackingOther> CreateIControlTrackingOther(FlatBufferBuilder builder, EControlTrackingType Type = EControlTrackingType.Self, VectorOffset EntitiesOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IControlTrackingOther.AddEntities(builder, EntitiesOffset);
			IControlTrackingOther.AddType(builder, Type);
			return IControlTrackingOther.EndIControlTrackingOther(builder);
		}

		// Token: 0x0602F406 RID: 193542 RVA: 0x00673869 File Offset: 0x00671A69
		public static void StartIControlTrackingOther(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602F407 RID: 193543 RVA: 0x00673872 File Offset: 0x00671A72
		public static void AddType(FlatBufferBuilder builder, EControlTrackingType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F408 RID: 193544 RVA: 0x0067387D File Offset: 0x00671A7D
		public static void AddEntities(FlatBufferBuilder builder, VectorOffset entitiesOffset)
		{
			builder.AddOffset(1, entitiesOffset.Value, 0);
		}

		// Token: 0x0602F409 RID: 193545 RVA: 0x00673890 File Offset: 0x00671A90
		public static VectorOffset CreateEntitiesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602F40A RID: 193546 RVA: 0x006738C7 File Offset: 0x00671AC7
		public static VectorOffset CreateEntitiesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602F40B RID: 193547 RVA: 0x006738E1 File Offset: 0x00671AE1
		public static VectorOffset CreateEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602F40C RID: 193548 RVA: 0x006738FF File Offset: 0x00671AFF
		public static VectorOffset CreateEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602F40D RID: 193549 RVA: 0x00673918 File Offset: 0x00671B18
		public static void StartEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602F40E RID: 193550 RVA: 0x00673923 File Offset: 0x00671B23
		public static Offset<IControlTrackingOther> EndIControlTrackingOther(FlatBufferBuilder builder)
		{
			return new Offset<IControlTrackingOther>(builder.EndTable());
		}

		// Token: 0x0602F40F RID: 193551 RVA: 0x00673930 File Offset: 0x00671B30
		public IControlTrackingOtherT UnPack()
		{
			IControlTrackingOtherT controlTrackingOtherT = new IControlTrackingOtherT();
			this.UnPackTo(controlTrackingOtherT);
			return controlTrackingOtherT;
		}

		// Token: 0x0602F410 RID: 193552 RVA: 0x0067394C File Offset: 0x00671B4C
		public void UnPackTo(IControlTrackingOtherT _o)
		{
			_o.Type = this.Type;
			_o.Entities = new List<int>();
			for (int i = 0; i < this.EntitiesLength; i++)
			{
				_o.Entities.Add(this.Entities(i));
			}
		}

		// Token: 0x0602F411 RID: 193553 RVA: 0x00673994 File Offset: 0x00671B94
		public static Offset<IControlTrackingOther> Pack(FlatBufferBuilder builder, IControlTrackingOtherT _o)
		{
			if (_o == null)
			{
				return default(Offset<IControlTrackingOther>);
			}
			VectorOffset entitiesOffset = default(VectorOffset);
			if (_o.Entities != null)
			{
				int[] data = _o.Entities.ToArray();
				entitiesOffset = IControlTrackingOther.CreateEntitiesVector(builder, data);
			}
			return IControlTrackingOther.CreateIControlTrackingOther(builder, _o.Type, entitiesOffset);
		}

		// Token: 0x04011928 RID: 71976
		private Table __p;
	}
}
