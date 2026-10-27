using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004AFC RID: 19196
	public struct ICheckPlayerRelativeDistance : IFlatbufferObject
	{
		// Token: 0x17008B3A RID: 35642
		// (get) Token: 0x0601E2CF RID: 123599 RVA: 0x0043B518 File Offset: 0x00439718
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E2D0 RID: 123600 RVA: 0x0043B525 File Offset: 0x00439725
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E2D1 RID: 123601 RVA: 0x0043B52C File Offset: 0x0043972C
		public static ICheckPlayerRelativeDistance GetRootAsICheckPlayerRelativeDistance(ByteBuffer _bb)
		{
			return ICheckPlayerRelativeDistance.GetRootAsICheckPlayerRelativeDistance(_bb, default(ICheckPlayerRelativeDistance));
		}

		// Token: 0x0601E2D2 RID: 123602 RVA: 0x0043B548 File Offset: 0x00439748
		public static ICheckPlayerRelativeDistance GetRootAsICheckPlayerRelativeDistance(ByteBuffer _bb, ICheckPlayerRelativeDistance obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E2D3 RID: 123603 RVA: 0x0043B565 File Offset: 0x00439765
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E2D4 RID: 123604 RVA: 0x0043B574 File Offset: 0x00439774
		public ICheckPlayerRelativeDistance __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008B3B RID: 35643
		// (get) Token: 0x0601E2D5 RID: 123605 RVA: 0x0043B584 File Offset: 0x00439784
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

		// Token: 0x17008B3C RID: 35644
		// (get) Token: 0x0601E2D6 RID: 123606 RVA: 0x0043B5C0 File Offset: 0x004397C0
		public int TargetEntityId
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

		// Token: 0x0601E2D7 RID: 123607 RVA: 0x0043B5FC File Offset: 0x004397FC
		public IDistanceRange? ValidDistanceRanges(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IDistanceRange?(default(IDistanceRange).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008B3D RID: 35645
		// (get) Token: 0x0601E2D8 RID: 123608 RVA: 0x0043B65C File Offset: 0x0043985C
		public int ValidDistanceRangesLength
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

		// Token: 0x0601E2D9 RID: 123609 RVA: 0x0043B687 File Offset: 0x00439887
		public static Offset<ICheckPlayerRelativeDistance> CreateICheckPlayerRelativeDistance(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int TargetEntityId = 0, VectorOffset ValidDistanceRangesOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			ICheckPlayerRelativeDistance.AddValidDistanceRanges(builder, ValidDistanceRangesOffset);
			ICheckPlayerRelativeDistance.AddTargetEntityId(builder, TargetEntityId);
			ICheckPlayerRelativeDistance.AddType(builder, Type);
			return ICheckPlayerRelativeDistance.EndICheckPlayerRelativeDistance(builder);
		}

		// Token: 0x0601E2DA RID: 123610 RVA: 0x0043B6AB File Offset: 0x004398AB
		public static void StartICheckPlayerRelativeDistance(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601E2DB RID: 123611 RVA: 0x0043B6B4 File Offset: 0x004398B4
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E2DC RID: 123612 RVA: 0x0043B6BF File Offset: 0x004398BF
		public static void AddTargetEntityId(FlatBufferBuilder builder, int targetEntityId)
		{
			builder.AddInt(1, targetEntityId, 0);
		}

		// Token: 0x0601E2DD RID: 123613 RVA: 0x0043B6CA File Offset: 0x004398CA
		public static void AddValidDistanceRanges(FlatBufferBuilder builder, VectorOffset validDistanceRangesOffset)
		{
			builder.AddOffset(2, validDistanceRangesOffset.Value, 0);
		}

		// Token: 0x0601E2DE RID: 123614 RVA: 0x0043B6DC File Offset: 0x004398DC
		public static VectorOffset CreateValidDistanceRangesVector(FlatBufferBuilder builder, Offset<IDistanceRange>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601E2DF RID: 123615 RVA: 0x0043B71C File Offset: 0x0043991C
		public static VectorOffset CreateValidDistanceRangesVectorBlock(FlatBufferBuilder builder, Offset<IDistanceRange>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IDistanceRange>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E2E0 RID: 123616 RVA: 0x0043B736 File Offset: 0x00439936
		public static VectorOffset CreateValidDistanceRangesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IDistanceRange>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IDistanceRange>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E2E1 RID: 123617 RVA: 0x0043B754 File Offset: 0x00439954
		public static VectorOffset CreateValidDistanceRangesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IDistanceRange>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601E2E2 RID: 123618 RVA: 0x0043B76D File Offset: 0x0043996D
		public static void StartValidDistanceRangesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601E2E3 RID: 123619 RVA: 0x0043B778 File Offset: 0x00439978
		public static Offset<ICheckPlayerRelativeDistance> EndICheckPlayerRelativeDistance(FlatBufferBuilder builder)
		{
			return new Offset<ICheckPlayerRelativeDistance>(builder.EndTable());
		}

		// Token: 0x0601E2E4 RID: 123620 RVA: 0x0043B788 File Offset: 0x00439988
		public ICheckPlayerRelativeDistanceT UnPack()
		{
			ICheckPlayerRelativeDistanceT checkPlayerRelativeDistanceT = new ICheckPlayerRelativeDistanceT();
			this.UnPackTo(checkPlayerRelativeDistanceT);
			return checkPlayerRelativeDistanceT;
		}

		// Token: 0x0601E2E5 RID: 123621 RVA: 0x0043B7A4 File Offset: 0x004399A4
		public void UnPackTo(ICheckPlayerRelativeDistanceT _o)
		{
			_o.Type = this.Type;
			_o.TargetEntityId = this.TargetEntityId;
			_o.ValidDistanceRanges = new List<IDistanceRangeT>();
			for (int i = 0; i < this.ValidDistanceRangesLength; i++)
			{
				_o.ValidDistanceRanges.Add((this.ValidDistanceRanges(i) != null) ? this.ValidDistanceRanges(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601E2E6 RID: 123622 RVA: 0x0043B81C File Offset: 0x00439A1C
		public static Offset<ICheckPlayerRelativeDistance> Pack(FlatBufferBuilder builder, ICheckPlayerRelativeDistanceT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckPlayerRelativeDistance>);
			}
			VectorOffset validDistanceRangesOffset = default(VectorOffset);
			if (_o.ValidDistanceRanges != null)
			{
				Offset<IDistanceRange>[] array = new Offset<IDistanceRange>[_o.ValidDistanceRanges.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IDistanceRange.Pack(builder, _o.ValidDistanceRanges[i]);
				}
				validDistanceRangesOffset = ICheckPlayerRelativeDistance.CreateValidDistanceRangesVector(builder, array);
			}
			return ICheckPlayerRelativeDistance.CreateICheckPlayerRelativeDistance(builder, _o.Type, _o.TargetEntityId, validDistanceRangesOffset);
		}

		// Token: 0x0400D393 RID: 54163
		private Table __p;
	}
}
