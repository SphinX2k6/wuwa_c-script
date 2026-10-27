using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005620 RID: 22048
	public struct INpcDefaultPerform : IFlatbufferObject
	{
		// Token: 0x1700A320 RID: 41760
		// (get) Token: 0x06024975 RID: 149877 RVA: 0x0050C660 File Offset: 0x0050A860
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024976 RID: 149878 RVA: 0x0050C66D File Offset: 0x0050A86D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024977 RID: 149879 RVA: 0x0050C674 File Offset: 0x0050A874
		public static INpcDefaultPerform GetRootAsINpcDefaultPerform(ByteBuffer _bb)
		{
			return INpcDefaultPerform.GetRootAsINpcDefaultPerform(_bb, default(INpcDefaultPerform));
		}

		// Token: 0x06024978 RID: 149880 RVA: 0x0050C690 File Offset: 0x0050A890
		public static INpcDefaultPerform GetRootAsINpcDefaultPerform(ByteBuffer _bb, INpcDefaultPerform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024979 RID: 149881 RVA: 0x0050C6AD File Offset: 0x0050A8AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602497A RID: 149882 RVA: 0x0050C6BC File Offset: 0x0050A8BC
		public INpcDefaultPerform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602497B RID: 149883 RVA: 0x0050C6CC File Offset: 0x0050A8CC
		public int BuffEffectIds(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700A321 RID: 41761
		// (get) Token: 0x0602497C RID: 149884 RVA: 0x0050C70C File Offset: 0x0050A90C
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

		// Token: 0x0602497D RID: 149885 RVA: 0x0050C737 File Offset: 0x0050A937
		public Span<int> GetBuffEffectIdsBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x0602497E RID: 149886 RVA: 0x0050C746 File Offset: 0x0050A946
		public int[] GetBuffEffectIdsArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x1700A322 RID: 41762
		// (get) Token: 0x0602497F RID: 149887 RVA: 0x0050C754 File Offset: 0x0050A954
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

		// Token: 0x06024980 RID: 149888 RVA: 0x0050C790 File Offset: 0x0050A990
		public static Offset<INpcDefaultPerform> CreateINpcDefaultPerform(FlatBufferBuilder builder, VectorOffset BuffEffectIdsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(2);
			INpcDefaultPerform.AddBuffEffectIds(builder, BuffEffectIdsOffset);
			INpcDefaultPerform.AddNullMask(builder, NullMask);
			return INpcDefaultPerform.EndINpcDefaultPerform(builder);
		}

		// Token: 0x06024981 RID: 149889 RVA: 0x0050C7AD File Offset: 0x0050A9AD
		public static void StartINpcDefaultPerform(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06024982 RID: 149890 RVA: 0x0050C7B6 File Offset: 0x0050A9B6
		public static void AddBuffEffectIds(FlatBufferBuilder builder, VectorOffset buffEffectIdsOffset)
		{
			builder.AddOffset(0, buffEffectIdsOffset.Value, 0);
		}

		// Token: 0x06024983 RID: 149891 RVA: 0x0050C7C8 File Offset: 0x0050A9C8
		public static VectorOffset CreateBuffEffectIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06024984 RID: 149892 RVA: 0x0050C7FF File Offset: 0x0050A9FF
		public static VectorOffset CreateBuffEffectIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06024985 RID: 149893 RVA: 0x0050C819 File Offset: 0x0050AA19
		public static VectorOffset CreateBuffEffectIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06024986 RID: 149894 RVA: 0x0050C837 File Offset: 0x0050AA37
		public static VectorOffset CreateBuffEffectIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06024987 RID: 149895 RVA: 0x0050C850 File Offset: 0x0050AA50
		public static void StartBuffEffectIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06024988 RID: 149896 RVA: 0x0050C85B File Offset: 0x0050AA5B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(1, nullMask, 0);
		}

		// Token: 0x06024989 RID: 149897 RVA: 0x0050C866 File Offset: 0x0050AA66
		public static Offset<INpcDefaultPerform> EndINpcDefaultPerform(FlatBufferBuilder builder)
		{
			return new Offset<INpcDefaultPerform>(builder.EndTable());
		}

		// Token: 0x0602498A RID: 149898 RVA: 0x0050C874 File Offset: 0x0050AA74
		public INpcDefaultPerformT UnPack()
		{
			INpcDefaultPerformT npcDefaultPerformT = new INpcDefaultPerformT();
			this.UnPackTo(npcDefaultPerformT);
			return npcDefaultPerformT;
		}

		// Token: 0x0602498B RID: 149899 RVA: 0x0050C890 File Offset: 0x0050AA90
		public void UnPackTo(INpcDefaultPerformT _o)
		{
			_o.BuffEffectIds = new List<int>();
			for (int i = 0; i < this.BuffEffectIdsLength; i++)
			{
				_o.BuffEffectIds.Add(this.BuffEffectIds(i));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602498C RID: 149900 RVA: 0x0050C8D8 File Offset: 0x0050AAD8
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

		// Token: 0x0400E9A3 RID: 59811
		private Table __p;
	}
}
