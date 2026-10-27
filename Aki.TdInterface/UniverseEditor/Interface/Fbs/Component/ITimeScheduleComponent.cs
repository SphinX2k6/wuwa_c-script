using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A90 RID: 23184
	public struct ITimeScheduleComponent : IFlatbufferObject
	{
		// Token: 0x1700AEA6 RID: 44710
		// (get) Token: 0x060277EC RID: 161772 RVA: 0x0056F276 File Offset: 0x0056D476
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060277ED RID: 161773 RVA: 0x0056F283 File Offset: 0x0056D483
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060277EE RID: 161774 RVA: 0x0056F28C File Offset: 0x0056D48C
		public static ITimeScheduleComponent GetRootAsITimeScheduleComponent(ByteBuffer _bb)
		{
			return ITimeScheduleComponent.GetRootAsITimeScheduleComponent(_bb, default(ITimeScheduleComponent));
		}

		// Token: 0x060277EF RID: 161775 RVA: 0x0056F2A8 File Offset: 0x0056D4A8
		public static ITimeScheduleComponent GetRootAsITimeScheduleComponent(ByteBuffer _bb, ITimeScheduleComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060277F0 RID: 161776 RVA: 0x0056F2C5 File Offset: 0x0056D4C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060277F1 RID: 161777 RVA: 0x0056F2D4 File Offset: 0x0056D4D4
		public ITimeScheduleComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AEA7 RID: 44711
		// (get) Token: 0x060277F2 RID: 161778 RVA: 0x0056F2E4 File Offset: 0x0056D4E4
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060277F3 RID: 161779 RVA: 0x0056F324 File Offset: 0x0056D524
		public ITimeScheduleConfig? TimeScheduleConfigs(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ITimeScheduleConfig?(default(ITimeScheduleConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AEA8 RID: 44712
		// (get) Token: 0x060277F4 RID: 161780 RVA: 0x0056F384 File Offset: 0x0056D584
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

		// Token: 0x1700AEA9 RID: 44713
		// (get) Token: 0x060277F5 RID: 161781 RVA: 0x0056F3B0 File Offset: 0x0056D5B0
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

		// Token: 0x060277F6 RID: 161782 RVA: 0x0056F3EC File Offset: 0x0056D5EC
		public static Offset<ITimeScheduleComponent> CreateITimeScheduleComponent(FlatBufferBuilder builder, bool Disabled = false, VectorOffset TimeScheduleConfigsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			ITimeScheduleComponent.AddTimeScheduleConfigs(builder, TimeScheduleConfigsOffset);
			ITimeScheduleComponent.AddNullMask(builder, NullMask);
			ITimeScheduleComponent.AddDisabled(builder, Disabled);
			return ITimeScheduleComponent.EndITimeScheduleComponent(builder);
		}

		// Token: 0x060277F7 RID: 161783 RVA: 0x0056F410 File Offset: 0x0056D610
		public static void StartITimeScheduleComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060277F8 RID: 161784 RVA: 0x0056F419 File Offset: 0x0056D619
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060277F9 RID: 161785 RVA: 0x0056F424 File Offset: 0x0056D624
		public static void AddTimeScheduleConfigs(FlatBufferBuilder builder, VectorOffset timeScheduleConfigsOffset)
		{
			builder.AddOffset(1, timeScheduleConfigsOffset.Value, 0);
		}

		// Token: 0x060277FA RID: 161786 RVA: 0x0056F434 File Offset: 0x0056D634
		public static VectorOffset CreateTimeScheduleConfigsVector(FlatBufferBuilder builder, Offset<ITimeScheduleConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060277FB RID: 161787 RVA: 0x0056F474 File Offset: 0x0056D674
		public static VectorOffset CreateTimeScheduleConfigsVectorBlock(FlatBufferBuilder builder, Offset<ITimeScheduleConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ITimeScheduleConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x060277FC RID: 161788 RVA: 0x0056F48E File Offset: 0x0056D68E
		public static VectorOffset CreateTimeScheduleConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ITimeScheduleConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ITimeScheduleConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x060277FD RID: 161789 RVA: 0x0056F4AC File Offset: 0x0056D6AC
		public static VectorOffset CreateTimeScheduleConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ITimeScheduleConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060277FE RID: 161790 RVA: 0x0056F4C5 File Offset: 0x0056D6C5
		public static void StartTimeScheduleConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060277FF RID: 161791 RVA: 0x0056F4D0 File Offset: 0x0056D6D0
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06027800 RID: 161792 RVA: 0x0056F4DB File Offset: 0x0056D6DB
		public static Offset<ITimeScheduleComponent> EndITimeScheduleComponent(FlatBufferBuilder builder)
		{
			return new Offset<ITimeScheduleComponent>(builder.EndTable());
		}

		// Token: 0x06027801 RID: 161793 RVA: 0x0056F4E8 File Offset: 0x0056D6E8
		public ITimeScheduleComponentT UnPack()
		{
			ITimeScheduleComponentT timeScheduleComponentT = new ITimeScheduleComponentT();
			this.UnPackTo(timeScheduleComponentT);
			return timeScheduleComponentT;
		}

		// Token: 0x06027802 RID: 161794 RVA: 0x0056F504 File Offset: 0x0056D704
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

		// Token: 0x06027803 RID: 161795 RVA: 0x0056F57C File Offset: 0x0056D77C
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

		// Token: 0x0400F14C RID: 61772
		private Table __p;
	}
}
