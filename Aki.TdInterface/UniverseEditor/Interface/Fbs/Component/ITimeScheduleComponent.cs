using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200609D RID: 24733
	public struct ITimeScheduleComponent : IFlatbufferObject
	{
		// Token: 0x1700B7DE RID: 47070
		// (get) Token: 0x06029D64 RID: 171364 RVA: 0x005B6282 File Offset: 0x005B4482
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029D65 RID: 171365 RVA: 0x005B628F File Offset: 0x005B448F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029D66 RID: 171366 RVA: 0x005B6298 File Offset: 0x005B4498
		public static ITimeScheduleComponent GetRootAsITimeScheduleComponent(ByteBuffer _bb)
		{
			return ITimeScheduleComponent.GetRootAsITimeScheduleComponent(_bb, default(ITimeScheduleComponent));
		}

		// Token: 0x06029D67 RID: 171367 RVA: 0x005B62B4 File Offset: 0x005B44B4
		public static ITimeScheduleComponent GetRootAsITimeScheduleComponent(ByteBuffer _bb, ITimeScheduleComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029D68 RID: 171368 RVA: 0x005B62D1 File Offset: 0x005B44D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029D69 RID: 171369 RVA: 0x005B62E0 File Offset: 0x005B44E0
		public ITimeScheduleComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B7DF RID: 47071
		// (get) Token: 0x06029D6A RID: 171370 RVA: 0x005B62F0 File Offset: 0x005B44F0
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06029D6B RID: 171371 RVA: 0x005B6330 File Offset: 0x005B4530
		public ITimeScheduleConfig? TimeScheduleConfigs(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ITimeScheduleConfig?(default(ITimeScheduleConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B7E0 RID: 47072
		// (get) Token: 0x06029D6C RID: 171372 RVA: 0x005B6390 File Offset: 0x005B4590
		public int TimeScheduleConfigsLength
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

		// Token: 0x1700B7E1 RID: 47073
		// (get) Token: 0x06029D6D RID: 171373 RVA: 0x005B63BC File Offset: 0x005B45BC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06029D6E RID: 171374 RVA: 0x005B63F8 File Offset: 0x005B45F8
		public static Offset<ITimeScheduleComponent> CreateITimeScheduleComponent(FlatBufferBuilder builder, bool Disabled = false, VectorOffset TimeScheduleConfigsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			ITimeScheduleComponent.AddTimeScheduleConfigs(builder, TimeScheduleConfigsOffset);
			ITimeScheduleComponent.AddNullMask(builder, NullMask);
			ITimeScheduleComponent.AddDisabled(builder, Disabled);
			return ITimeScheduleComponent.EndITimeScheduleComponent(builder);
		}

		// Token: 0x06029D6F RID: 171375 RVA: 0x005B641C File Offset: 0x005B461C
		public static void StartITimeScheduleComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06029D70 RID: 171376 RVA: 0x005B6425 File Offset: 0x005B4625
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06029D71 RID: 171377 RVA: 0x005B6430 File Offset: 0x005B4630
		public static void AddTimeScheduleConfigs(FlatBufferBuilder builder, VectorOffset timeScheduleConfigsOffset)
		{
			builder.AddOffset(1, timeScheduleConfigsOffset.Value, 0);
		}

		// Token: 0x06029D72 RID: 171378 RVA: 0x005B6440 File Offset: 0x005B4640
		public static VectorOffset CreateTimeScheduleConfigsVector(FlatBufferBuilder builder, Offset<ITimeScheduleConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06029D73 RID: 171379 RVA: 0x005B6480 File Offset: 0x005B4680
		public static VectorOffset CreateTimeScheduleConfigsVectorBlock(FlatBufferBuilder builder, Offset<ITimeScheduleConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ITimeScheduleConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06029D74 RID: 171380 RVA: 0x005B649A File Offset: 0x005B469A
		public static VectorOffset CreateTimeScheduleConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ITimeScheduleConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ITimeScheduleConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06029D75 RID: 171381 RVA: 0x005B64B8 File Offset: 0x005B46B8
		public static VectorOffset CreateTimeScheduleConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ITimeScheduleConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06029D76 RID: 171382 RVA: 0x005B64D1 File Offset: 0x005B46D1
		public static void StartTimeScheduleConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06029D77 RID: 171383 RVA: 0x005B64DC File Offset: 0x005B46DC
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06029D78 RID: 171384 RVA: 0x005B64E7 File Offset: 0x005B46E7
		public static Offset<ITimeScheduleComponent> EndITimeScheduleComponent(FlatBufferBuilder builder)
		{
			return new Offset<ITimeScheduleComponent>(builder.EndTable());
		}

		// Token: 0x06029D79 RID: 171385 RVA: 0x005B64F4 File Offset: 0x005B46F4
		public ITimeScheduleComponentT UnPack()
		{
			ITimeScheduleComponentT timeScheduleComponentT = new ITimeScheduleComponentT();
			this.UnPackTo(timeScheduleComponentT);
			return timeScheduleComponentT;
		}

		// Token: 0x06029D7A RID: 171386 RVA: 0x005B6510 File Offset: 0x005B4710
		public void UnPackTo(ITimeScheduleComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.TimeScheduleConfigs = new List<ITimeScheduleConfigT>();
			for (int i = 0; i < this.TimeScheduleConfigsLength; i++)
			{
				_o.TimeScheduleConfigs.Add((this.TimeScheduleConfigs(i) != null) ? this.TimeScheduleConfigs(i).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06029D7B RID: 171387 RVA: 0x005B6588 File Offset: 0x005B4788
		public static Offset<ITimeScheduleComponent> Pack(FlatBufferBuilder builder, ITimeScheduleComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITimeScheduleComponent>);
			}
			VectorOffset timeScheduleConfigsOffset = default(VectorOffset);
			if (_o.TimeScheduleConfigs != null)
			{
				Offset<ITimeScheduleConfig>[] array = new Offset<ITimeScheduleConfig>[_o.TimeScheduleConfigs.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ITimeScheduleConfig.Pack(builder, _o.TimeScheduleConfigs[i]);
				}
				timeScheduleConfigsOffset = ITimeScheduleComponent.CreateTimeScheduleConfigsVector(builder, array);
			}
			return ITimeScheduleComponent.CreateITimeScheduleComponent(builder, _o.Disabled, timeScheduleConfigsOffset, _o.NullMask);
		}

		// Token: 0x0400FE43 RID: 65091
		private Table __p;
	}
}
