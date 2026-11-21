using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060C7 RID: 24775
	public struct ITimeStopTarget : IFlatbufferObject
	{
		// Token: 0x1700B827 RID: 47143
		// (get) Token: 0x06029EB0 RID: 171696 RVA: 0x005B893F File Offset: 0x005B6B3F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029EB1 RID: 171697 RVA: 0x005B894C File Offset: 0x005B6B4C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029EB2 RID: 171698 RVA: 0x005B8954 File Offset: 0x005B6B54
		public static ITimeStopTarget GetRootAsITimeStopTarget(ByteBuffer _bb)
		{
			return ITimeStopTarget.GetRootAsITimeStopTarget(_bb, default(ITimeStopTarget));
		}

		// Token: 0x06029EB3 RID: 171699 RVA: 0x005B8970 File Offset: 0x005B6B70
		public static ITimeStopTarget GetRootAsITimeStopTarget(ByteBuffer _bb, ITimeStopTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029EB4 RID: 171700 RVA: 0x005B898D File Offset: 0x005B6B8D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029EB5 RID: 171701 RVA: 0x005B899C File Offset: 0x005B6B9C
		public ITimeStopTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06029EB6 RID: 171702 RVA: 0x005B89AC File Offset: 0x005B6BAC
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700B828 RID: 47144
		// (get) Token: 0x06029EB7 RID: 171703 RVA: 0x005B89EC File Offset: 0x005B6BEC
		public int EntityIdsLength
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

		// Token: 0x06029EB8 RID: 171704 RVA: 0x005B8A17 File Offset: 0x005B6C17
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x06029EB9 RID: 171705 RVA: 0x005B8A26 File Offset: 0x005B6C26
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x1700B829 RID: 47145
		// (get) Token: 0x06029EBA RID: 171706 RVA: 0x005B8A34 File Offset: 0x005B6C34
		public IDynamicEntityMatch? EntityMatch
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IDynamicEntityMatch?(default(IDynamicEntityMatch).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06029EBB RID: 171707 RVA: 0x005B8A91 File Offset: 0x005B6C91
		public static Offset<ITimeStopTarget> CreateITimeStopTarget(FlatBufferBuilder builder, VectorOffset EntityIdsOffset = default(VectorOffset), Offset<IDynamicEntityMatch> EntityMatchOffset = default(Offset<IDynamicEntityMatch>))
		{
			builder.StartTable(2);
			ITimeStopTarget.AddEntityMatch(builder, EntityMatchOffset);
			ITimeStopTarget.AddEntityIds(builder, EntityIdsOffset);
			return ITimeStopTarget.EndITimeStopTarget(builder);
		}

		// Token: 0x06029EBC RID: 171708 RVA: 0x005B8AAE File Offset: 0x005B6CAE
		public static void StartITimeStopTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06029EBD RID: 171709 RVA: 0x005B8AB7 File Offset: 0x005B6CB7
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(0, entityIdsOffset.Value, 0);
		}

		// Token: 0x06029EBE RID: 171710 RVA: 0x005B8AC8 File Offset: 0x005B6CC8
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06029EBF RID: 171711 RVA: 0x005B8AFF File Offset: 0x005B6CFF
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06029EC0 RID: 171712 RVA: 0x005B8B19 File Offset: 0x005B6D19
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06029EC1 RID: 171713 RVA: 0x005B8B37 File Offset: 0x005B6D37
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06029EC2 RID: 171714 RVA: 0x005B8B50 File Offset: 0x005B6D50
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06029EC3 RID: 171715 RVA: 0x005B8B5B File Offset: 0x005B6D5B
		public static void AddEntityMatch(FlatBufferBuilder builder, Offset<IDynamicEntityMatch> entityMatchOffset)
		{
			builder.AddOffset(1, entityMatchOffset.Value, 0);
		}

		// Token: 0x06029EC4 RID: 171716 RVA: 0x005B8B6B File Offset: 0x005B6D6B
		public static Offset<ITimeStopTarget> EndITimeStopTarget(FlatBufferBuilder builder)
		{
			return new Offset<ITimeStopTarget>(builder.EndTable());
		}

		// Token: 0x06029EC5 RID: 171717 RVA: 0x005B8B78 File Offset: 0x005B6D78
		public ITimeStopTargetT UnPack()
		{
			ITimeStopTargetT timeStopTargetT = new ITimeStopTargetT();
			this.UnPackTo(timeStopTargetT);
			return timeStopTargetT;
		}

		// Token: 0x06029EC6 RID: 171718 RVA: 0x005B8B94 File Offset: 0x005B6D94
		public void UnPackTo(ITimeStopTargetT _o)
		{
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
			_o.EntityMatch = ((this.EntityMatch != null) ? this.EntityMatch.Value.UnPack() : null);
		}

		// Token: 0x06029EC7 RID: 171719 RVA: 0x005B8C00 File Offset: 0x005B6E00
		public static Offset<ITimeStopTarget> Pack(FlatBufferBuilder builder, ITimeStopTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITimeStopTarget>);
			}
			VectorOffset entityIdsOffset = default(VectorOffset);
			if (_o.EntityIds != null)
			{
				int[] data = _o.EntityIds.ToArray();
				entityIdsOffset = ITimeStopTarget.CreateEntityIdsVector(builder, data);
			}
			Offset<IDynamicEntityMatch> entityMatchOffset = (_o.EntityMatch == null) ? default(Offset<IDynamicEntityMatch>) : IDynamicEntityMatch.Pack(builder, _o.EntityMatch);
			return ITimeStopTarget.CreateITimeStopTarget(builder, entityIdsOffset, entityMatchOffset);
		}

		// Token: 0x0400FE7C RID: 65148
		private Table __p;
	}
}
