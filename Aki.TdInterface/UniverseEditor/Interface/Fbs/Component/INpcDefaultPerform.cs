using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BBE RID: 23486
	public struct INpcDefaultPerform : IFlatbufferObject
	{
		// Token: 0x1700ABA8 RID: 43944
		// (get) Token: 0x06026B85 RID: 158597 RVA: 0x0054CC78 File Offset: 0x0054AE78
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026B86 RID: 158598 RVA: 0x0054CC85 File Offset: 0x0054AE85
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026B87 RID: 158599 RVA: 0x0054CC8C File Offset: 0x0054AE8C
		public static INpcDefaultPerform GetRootAsINpcDefaultPerform(ByteBuffer _bb)
		{
			return INpcDefaultPerform.GetRootAsINpcDefaultPerform(_bb, default(INpcDefaultPerform));
		}

		// Token: 0x06026B88 RID: 158600 RVA: 0x0054CCA8 File Offset: 0x0054AEA8
		public static INpcDefaultPerform GetRootAsINpcDefaultPerform(ByteBuffer _bb, INpcDefaultPerform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026B89 RID: 158601 RVA: 0x0054CCC5 File Offset: 0x0054AEC5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026B8A RID: 158602 RVA: 0x0054CCD4 File Offset: 0x0054AED4
		public INpcDefaultPerform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06026B8B RID: 158603 RVA: 0x0054CCE4 File Offset: 0x0054AEE4
		public int BuffEffectIds(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700ABA9 RID: 43945
		// (get) Token: 0x06026B8C RID: 158604 RVA: 0x0054CD24 File Offset: 0x0054AF24
		public int BuffEffectIdsLength
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

		// Token: 0x06026B8D RID: 158605 RVA: 0x0054CD4F File Offset: 0x0054AF4F
		public Span<int> GetBuffEffectIdsBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x06026B8E RID: 158606 RVA: 0x0054CD5E File Offset: 0x0054AF5E
		public int[] GetBuffEffectIdsArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x1700ABAA RID: 43946
		// (get) Token: 0x06026B8F RID: 158607 RVA: 0x0054CD6C File Offset: 0x0054AF6C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026B90 RID: 158608 RVA: 0x0054CDA8 File Offset: 0x0054AFA8
		public static Offset<INpcDefaultPerform> CreateINpcDefaultPerform(FlatBufferBuilder builder, VectorOffset BuffEffectIdsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(2);
			INpcDefaultPerform.AddBuffEffectIds(builder, BuffEffectIdsOffset);
			INpcDefaultPerform.AddNullMask(builder, NullMask);
			return INpcDefaultPerform.EndINpcDefaultPerform(builder);
		}

		// Token: 0x06026B91 RID: 158609 RVA: 0x0054CDC5 File Offset: 0x0054AFC5
		public static void StartINpcDefaultPerform(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06026B92 RID: 158610 RVA: 0x0054CDCE File Offset: 0x0054AFCE
		public static void AddBuffEffectIds(FlatBufferBuilder builder, VectorOffset buffEffectIdsOffset)
		{
			builder.AddOffset(0, buffEffectIdsOffset.Value, 0);
		}

		// Token: 0x06026B93 RID: 158611 RVA: 0x0054CDE0 File Offset: 0x0054AFE0
		public static VectorOffset CreateBuffEffectIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06026B94 RID: 158612 RVA: 0x0054CE17 File Offset: 0x0054B017
		public static VectorOffset CreateBuffEffectIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06026B95 RID: 158613 RVA: 0x0054CE31 File Offset: 0x0054B031
		public static VectorOffset CreateBuffEffectIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06026B96 RID: 158614 RVA: 0x0054CE4F File Offset: 0x0054B04F
		public static VectorOffset CreateBuffEffectIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06026B97 RID: 158615 RVA: 0x0054CE68 File Offset: 0x0054B068
		public static void StartBuffEffectIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06026B98 RID: 158616 RVA: 0x0054CE73 File Offset: 0x0054B073
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(1, nullMask, 0);
		}

		// Token: 0x06026B99 RID: 158617 RVA: 0x0054CE7E File Offset: 0x0054B07E
		public static Offset<INpcDefaultPerform> EndINpcDefaultPerform(FlatBufferBuilder builder)
		{
			return new Offset<INpcDefaultPerform>(builder.EndTable());
		}

		// Token: 0x06026B9A RID: 158618 RVA: 0x0054CE8C File Offset: 0x0054B08C
		public INpcDefaultPerformT UnPack()
		{
			INpcDefaultPerformT npcDefaultPerformT = new INpcDefaultPerformT();
			this.UnPackTo(npcDefaultPerformT);
			return npcDefaultPerformT;
		}

		// Token: 0x06026B9B RID: 158619 RVA: 0x0054CEA8 File Offset: 0x0054B0A8
		public void UnPackTo(INpcDefaultPerformT _o)
		{
			_o.BuffEffectIds = new List<int>();
			for (int i = 0; i < this.BuffEffectIdsLength; i++)
			{
				_o.BuffEffectIds.Add(this.BuffEffectIds(i));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06026B9C RID: 158620 RVA: 0x0054CEF0 File Offset: 0x0054B0F0
		public static Offset<INpcDefaultPerform> Pack(FlatBufferBuilder builder, INpcDefaultPerformT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcDefaultPerform>);
			}
			VectorOffset buffEffectIdsOffset = default(VectorOffset);
			if (_o.BuffEffectIds != null)
			{
				int[] data = _o.BuffEffectIds.ToArray();
				buffEffectIdsOffset = INpcDefaultPerform.CreateBuffEffectIdsVector(builder, data);
			}
			return INpcDefaultPerform.CreateINpcDefaultPerform(builder, buffEffectIdsOffset, _o.NullMask);
		}

		// Token: 0x0400F606 RID: 62982
		private Table __p;
	}
}
