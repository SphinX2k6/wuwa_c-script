using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E12 RID: 24082
	public struct IOutAreaBorderBuffEffect : IFlatbufferObject
	{
		// Token: 0x1700B432 RID: 46130
		// (get) Token: 0x060293AE RID: 168878 RVA: 0x005A7F68 File Offset: 0x005A6168
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060293AF RID: 168879 RVA: 0x005A7F75 File Offset: 0x005A6175
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060293B0 RID: 168880 RVA: 0x005A7F7C File Offset: 0x005A617C
		public static IOutAreaBorderBuffEffect GetRootAsIOutAreaBorderBuffEffect(ByteBuffer _bb)
		{
			return IOutAreaBorderBuffEffect.GetRootAsIOutAreaBorderBuffEffect(_bb, default(IOutAreaBorderBuffEffect));
		}

		// Token: 0x060293B1 RID: 168881 RVA: 0x005A7F98 File Offset: 0x005A6198
		public static IOutAreaBorderBuffEffect GetRootAsIOutAreaBorderBuffEffect(ByteBuffer _bb, IOutAreaBorderBuffEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060293B2 RID: 168882 RVA: 0x005A7FB5 File Offset: 0x005A61B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060293B3 RID: 168883 RVA: 0x005A7FC4 File Offset: 0x005A61C4
		public IOutAreaBorderBuffEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B433 RID: 46131
		// (get) Token: 0x060293B4 RID: 168884 RVA: 0x005A7FD4 File Offset: 0x005A61D4
		public EOutAreaBorderEffectType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EOutAreaBorderEffectType.BuffId;
				}
				return (EOutAreaBorderEffectType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060293B5 RID: 168885 RVA: 0x005A8010 File Offset: 0x005A6210
		public int BuffIdList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700B434 RID: 46132
		// (get) Token: 0x060293B6 RID: 168886 RVA: 0x005A8050 File Offset: 0x005A6250
		public int BuffIdListLength
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

		// Token: 0x060293B7 RID: 168887 RVA: 0x005A807B File Offset: 0x005A627B
		public Span<int> GetBuffIdListBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x060293B8 RID: 168888 RVA: 0x005A808A File Offset: 0x005A628A
		public int[] GetBuffIdListArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x060293B9 RID: 168889 RVA: 0x005A8098 File Offset: 0x005A6298
		public static Offset<IOutAreaBorderBuffEffect> CreateIOutAreaBorderBuffEffect(FlatBufferBuilder builder, EOutAreaBorderEffectType Type = EOutAreaBorderEffectType.BuffId, VectorOffset BuffIdListOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IOutAreaBorderBuffEffect.AddBuffIdList(builder, BuffIdListOffset);
			IOutAreaBorderBuffEffect.AddType(builder, Type);
			return IOutAreaBorderBuffEffect.EndIOutAreaBorderBuffEffect(builder);
		}

		// Token: 0x060293BA RID: 168890 RVA: 0x005A80B5 File Offset: 0x005A62B5
		public static void StartIOutAreaBorderBuffEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060293BB RID: 168891 RVA: 0x005A80BE File Offset: 0x005A62BE
		public static void AddType(FlatBufferBuilder builder, EOutAreaBorderEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060293BC RID: 168892 RVA: 0x005A80C9 File Offset: 0x005A62C9
		public static void AddBuffIdList(FlatBufferBuilder builder, VectorOffset buffIdListOffset)
		{
			builder.AddOffset(1, buffIdListOffset.Value, 0);
		}

		// Token: 0x060293BD RID: 168893 RVA: 0x005A80DC File Offset: 0x005A62DC
		public static VectorOffset CreateBuffIdListVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060293BE RID: 168894 RVA: 0x005A8113 File Offset: 0x005A6313
		public static VectorOffset CreateBuffIdListVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060293BF RID: 168895 RVA: 0x005A812D File Offset: 0x005A632D
		public static VectorOffset CreateBuffIdListVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060293C0 RID: 168896 RVA: 0x005A814B File Offset: 0x005A634B
		public static VectorOffset CreateBuffIdListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060293C1 RID: 168897 RVA: 0x005A8164 File Offset: 0x005A6364
		public static void StartBuffIdListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060293C2 RID: 168898 RVA: 0x005A816F File Offset: 0x005A636F
		public static Offset<IOutAreaBorderBuffEffect> EndIOutAreaBorderBuffEffect(FlatBufferBuilder builder)
		{
			return new Offset<IOutAreaBorderBuffEffect>(builder.EndTable());
		}

		// Token: 0x060293C3 RID: 168899 RVA: 0x005A817C File Offset: 0x005A637C
		public IOutAreaBorderBuffEffectT UnPack()
		{
			IOutAreaBorderBuffEffectT outAreaBorderBuffEffectT = new IOutAreaBorderBuffEffectT();
			this.UnPackTo(outAreaBorderBuffEffectT);
			return outAreaBorderBuffEffectT;
		}

		// Token: 0x060293C4 RID: 168900 RVA: 0x005A8198 File Offset: 0x005A6398
		public void UnPackTo(IOutAreaBorderBuffEffectT _o)
		{
			_o.Type = this.Type;
			_o.BuffIdList = new List<int>();
			for (int i = 0; i < this.BuffIdListLength; i++)
			{
				_o.BuffIdList.Add(this.BuffIdList(i));
			}
		}

		// Token: 0x060293C5 RID: 168901 RVA: 0x005A81E0 File Offset: 0x005A63E0
		public static Offset<IOutAreaBorderBuffEffect> Pack(FlatBufferBuilder builder, IOutAreaBorderBuffEffectT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOutAreaBorderBuffEffect>);
			}
			VectorOffset buffIdListOffset = default(VectorOffset);
			if (_o.BuffIdList != null)
			{
				int[] data = _o.BuffIdList.ToArray();
				buffIdListOffset = IOutAreaBorderBuffEffect.CreateBuffIdListVector(builder, data);
			}
			return IOutAreaBorderBuffEffect.CreateIOutAreaBorderBuffEffect(builder, _o.Type, buffIdListOffset);
		}

		// Token: 0x0400F808 RID: 63496
		private Table __p;
	}
}
