using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003BAD RID: 15277
	public struct IShowTimelineBuff : IFlatbufferObject
	{
		// Token: 0x170068B4 RID: 26804
		// (get) Token: 0x06014F0F RID: 85775 RVA: 0x003097AE File Offset: 0x003079AE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06014F10 RID: 85776 RVA: 0x003097BB File Offset: 0x003079BB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06014F11 RID: 85777 RVA: 0x003097C4 File Offset: 0x003079C4
		public static IShowTimelineBuff GetRootAsIShowTimelineBuff(ByteBuffer _bb)
		{
			return IShowTimelineBuff.GetRootAsIShowTimelineBuff(_bb, default(IShowTimelineBuff));
		}

		// Token: 0x06014F12 RID: 85778 RVA: 0x003097E0 File Offset: 0x003079E0
		public static IShowTimelineBuff GetRootAsIShowTimelineBuff(ByteBuffer _bb, IShowTimelineBuff obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06014F13 RID: 85779 RVA: 0x003097FD File Offset: 0x003079FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06014F14 RID: 85780 RVA: 0x0030980C File Offset: 0x00307A0C
		public IShowTimelineBuff __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170068B5 RID: 26805
		// (get) Token: 0x06014F15 RID: 85781 RVA: 0x0030981C File Offset: 0x00307A1C
		public EShowTimelineType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EShowTimelineType.Checkpoint;
				}
				return (EShowTimelineType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06014F16 RID: 85782 RVA: 0x00309858 File Offset: 0x00307A58
		public long BuffIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0L;
			}
			return this.__p.bb.GetLong(this.__p.__vector(num) + j * 8);
		}

		// Token: 0x170068B6 RID: 26806
		// (get) Token: 0x06014F17 RID: 85783 RVA: 0x00309898 File Offset: 0x00307A98
		public int BuffIdsLength
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

		// Token: 0x06014F18 RID: 85784 RVA: 0x003098C3 File Offset: 0x00307AC3
		public Span<long> GetBuffIdsBytes()
		{
			return this.__p.__vector_as_span<long>(6, 8);
		}

		// Token: 0x06014F19 RID: 85785 RVA: 0x003098D2 File Offset: 0x00307AD2
		public long[] GetBuffIdsArray()
		{
			return this.__p.__vector_as_array<long>(6);
		}

		// Token: 0x06014F1A RID: 85786 RVA: 0x003098E0 File Offset: 0x00307AE0
		public static Offset<IShowTimelineBuff> CreateIShowTimelineBuff(FlatBufferBuilder builder, EShowTimelineType Type = EShowTimelineType.Checkpoint, VectorOffset BuffIdsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IShowTimelineBuff.AddBuffIds(builder, BuffIdsOffset);
			IShowTimelineBuff.AddType(builder, Type);
			return IShowTimelineBuff.EndIShowTimelineBuff(builder);
		}

		// Token: 0x06014F1B RID: 85787 RVA: 0x003098FD File Offset: 0x00307AFD
		public static void StartIShowTimelineBuff(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06014F1C RID: 85788 RVA: 0x00309906 File Offset: 0x00307B06
		public static void AddType(FlatBufferBuilder builder, EShowTimelineType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06014F1D RID: 85789 RVA: 0x00309911 File Offset: 0x00307B11
		public static void AddBuffIds(FlatBufferBuilder builder, VectorOffset buffIdsOffset)
		{
			builder.AddOffset(1, buffIdsOffset.Value, 0);
		}

		// Token: 0x06014F1E RID: 85790 RVA: 0x00309924 File Offset: 0x00307B24
		public static VectorOffset CreateBuffIdsVector(FlatBufferBuilder builder, long[] data)
		{
			builder.StartVector(8, data.Length, 8);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddLong(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06014F1F RID: 85791 RVA: 0x0030995B File Offset: 0x00307B5B
		public static VectorOffset CreateBuffIdsVectorBlock(FlatBufferBuilder builder, long[] data)
		{
			builder.StartVector(8, data.Length, 8);
			builder.Add<long>(data);
			return builder.EndVector();
		}

		// Token: 0x06014F20 RID: 85792 RVA: 0x00309975 File Offset: 0x00307B75
		public static VectorOffset CreateBuffIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data)
		{
			builder.StartVector(8, data.Count, 8);
			builder.Add<long>(data);
			return builder.EndVector();
		}

		// Token: 0x06014F21 RID: 85793 RVA: 0x00309993 File Offset: 0x00307B93
		public static VectorOffset CreateBuffIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<long>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06014F22 RID: 85794 RVA: 0x003099AC File Offset: 0x00307BAC
		public static void StartBuffIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(8, numElems, 8);
		}

		// Token: 0x06014F23 RID: 85795 RVA: 0x003099B7 File Offset: 0x00307BB7
		public static Offset<IShowTimelineBuff> EndIShowTimelineBuff(FlatBufferBuilder builder)
		{
			return new Offset<IShowTimelineBuff>(builder.EndTable());
		}

		// Token: 0x06014F24 RID: 85796 RVA: 0x003099C4 File Offset: 0x00307BC4
		public IShowTimelineBuffT UnPack()
		{
			IShowTimelineBuffT showTimelineBuffT = new IShowTimelineBuffT();
			this.UnPackTo(showTimelineBuffT);
			return showTimelineBuffT;
		}

		// Token: 0x06014F25 RID: 85797 RVA: 0x003099E0 File Offset: 0x00307BE0
		public void UnPackTo(IShowTimelineBuffT _o)
		{
			_o.Type = this.Type;
			_o.BuffIds = new List<long>();
			for (int i = 0; i < this.BuffIdsLength; i++)
			{
				_o.BuffIds.Add(this.BuffIds(i));
			}
		}

		// Token: 0x06014F26 RID: 85798 RVA: 0x00309A28 File Offset: 0x00307C28
		public static Offset<IShowTimelineBuff> Pack(FlatBufferBuilder builder, IShowTimelineBuffT _o)
		{
			if (_o == null)
			{
				return default(Offset<IShowTimelineBuff>);
			}
			VectorOffset buffIdsOffset = default(VectorOffset);
			if (_o.BuffIds != null)
			{
				long[] data = _o.BuffIds.ToArray();
				buffIdsOffset = IShowTimelineBuff.CreateBuffIdsVector(builder, data);
			}
			return IShowTimelineBuff.CreateIShowTimelineBuff(builder, _o.Type, buffIdsOffset);
		}

		// Token: 0x0400B12A RID: 45354
		private Table __p;
	}
}
