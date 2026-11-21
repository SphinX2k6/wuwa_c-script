using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006086 RID: 24710
	public struct ITimelineControlGroup : IFlatbufferObject
	{
		// Token: 0x1700B7A2 RID: 47010
		// (get) Token: 0x06029C6F RID: 171119 RVA: 0x005B4177 File Offset: 0x005B2377
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029C70 RID: 171120 RVA: 0x005B4184 File Offset: 0x005B2384
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029C71 RID: 171121 RVA: 0x005B418C File Offset: 0x005B238C
		public static ITimelineControlGroup GetRootAsITimelineControlGroup(ByteBuffer _bb)
		{
			return ITimelineControlGroup.GetRootAsITimelineControlGroup(_bb, default(ITimelineControlGroup));
		}

		// Token: 0x06029C72 RID: 171122 RVA: 0x005B41A8 File Offset: 0x005B23A8
		public static ITimelineControlGroup GetRootAsITimelineControlGroup(ByteBuffer _bb, ITimelineControlGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029C73 RID: 171123 RVA: 0x005B41C5 File Offset: 0x005B23C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029C74 RID: 171124 RVA: 0x005B41D4 File Offset: 0x005B23D4
		public ITimelineControlGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B7A3 RID: 47011
		// (get) Token: 0x06029C75 RID: 171125 RVA: 0x005B41E4 File Offset: 0x005B23E4
		public IConditionGroup? Condition
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B7A4 RID: 47012
		// (get) Token: 0x06029C76 RID: 171126 RVA: 0x005B4244 File Offset: 0x005B2444
		public string TidContent
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06029C77 RID: 171127 RVA: 0x005B427B File Offset: 0x005B247B
		public Span<byte> GetTidContentBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06029C78 RID: 171128 RVA: 0x005B428A File Offset: 0x005B248A
		public byte[] GetTidContentArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700B7A5 RID: 47013
		// (get) Token: 0x06029C79 RID: 171129 RVA: 0x005B4298 File Offset: 0x005B2498
		public float SegmentTime
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06029C7A RID: 171130 RVA: 0x005B42D8 File Offset: 0x005B24D8
		public TTimelineTrackControlConfig ControlConfigsType(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return TTimelineTrackControlConfig.NONE;
			}
			return (TTimelineTrackControlConfig)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700B7A6 RID: 47014
		// (get) Token: 0x06029C7B RID: 171131 RVA: 0x005B4318 File Offset: 0x005B2518
		public int ControlConfigsTypeLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06029C7C RID: 171132 RVA: 0x005B4344 File Offset: 0x005B2544
		public Span<TTimelineTrackControlConfig> GetControlConfigsTypeBytes()
		{
			return this.__p.__vector_as_span<TTimelineTrackControlConfig>(10, 1);
		}

		// Token: 0x06029C7D RID: 171133 RVA: 0x005B4354 File Offset: 0x005B2554
		public TTimelineTrackControlConfig[] GetControlConfigsTypeArray()
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TTimelineTrackControlConfig[] array = new TTimelineTrackControlConfig[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TTimelineTrackControlConfig)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x06029C7E RID: 171134 RVA: 0x005B43C0 File Offset: 0x005B25C0
		public TTable? ControlConfigs<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700B7A7 RID: 47015
		// (get) Token: 0x06029C7F RID: 171135 RVA: 0x005B4408 File Offset: 0x005B2608
		public int ControlConfigsLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06029C80 RID: 171136 RVA: 0x005B4434 File Offset: 0x005B2634
		public IControlPointEventConfig? ControlPointEvents(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new IControlPointEventConfig?(default(IControlPointEventConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B7A8 RID: 47016
		// (get) Token: 0x06029C81 RID: 171137 RVA: 0x005B4498 File Offset: 0x005B2698
		public int ControlPointEventsLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700B7A9 RID: 47017
		// (get) Token: 0x06029C82 RID: 171138 RVA: 0x005B44C4 File Offset: 0x005B26C4
		public string Description
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06029C83 RID: 171139 RVA: 0x005B44FC File Offset: 0x005B26FC
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06029C84 RID: 171140 RVA: 0x005B450C File Offset: 0x005B270C
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(16);
		}

		// Token: 0x1700B7AA RID: 47018
		// (get) Token: 0x06029C85 RID: 171141 RVA: 0x005B451C File Offset: 0x005B271C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06029C86 RID: 171142 RVA: 0x005B455C File Offset: 0x005B275C
		public static Offset<ITimelineControlGroup> CreateITimelineControlGroup(FlatBufferBuilder builder, Offset<IConditionGroup> ConditionOffset = default(Offset<IConditionGroup>), StringOffset TidContentOffset = default(StringOffset), float SegmentTime = 0f, VectorOffset ControlConfigs_typeOffset = default(VectorOffset), VectorOffset ControlConfigsOffset = default(VectorOffset), VectorOffset ControlPointEventsOffset = default(VectorOffset), StringOffset DescriptionOffset = default(StringOffset), byte NullMask = 0)
		{
			builder.StartTable(8);
			ITimelineControlGroup.AddDescription(builder, DescriptionOffset);
			ITimelineControlGroup.AddControlPointEvents(builder, ControlPointEventsOffset);
			ITimelineControlGroup.AddControlConfigs(builder, ControlConfigsOffset);
			ITimelineControlGroup.AddControlConfigsType(builder, ControlConfigs_typeOffset);
			ITimelineControlGroup.AddSegmentTime(builder, SegmentTime);
			ITimelineControlGroup.AddTidContent(builder, TidContentOffset);
			ITimelineControlGroup.AddCondition(builder, ConditionOffset);
			ITimelineControlGroup.AddNullMask(builder, NullMask);
			return ITimelineControlGroup.EndITimelineControlGroup(builder);
		}

		// Token: 0x06029C87 RID: 171143 RVA: 0x005B45B3 File Offset: 0x005B27B3
		public static void StartITimelineControlGroup(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06029C88 RID: 171144 RVA: 0x005B45BC File Offset: 0x005B27BC
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(0, conditionOffset.Value, 0);
		}

		// Token: 0x06029C89 RID: 171145 RVA: 0x005B45CC File Offset: 0x005B27CC
		public static void AddTidContent(FlatBufferBuilder builder, StringOffset tidContentOffset)
		{
			builder.AddOffset(1, tidContentOffset.Value, 0);
		}

		// Token: 0x06029C8A RID: 171146 RVA: 0x005B45DC File Offset: 0x005B27DC
		public static void AddSegmentTime(FlatBufferBuilder builder, float segmentTime)
		{
			builder.AddFloat(2, segmentTime, 0.0);
		}

		// Token: 0x06029C8B RID: 171147 RVA: 0x005B45EF File Offset: 0x005B27EF
		public static void AddControlConfigsType(FlatBufferBuilder builder, VectorOffset controlConfigsTypeOffset)
		{
			builder.AddOffset(3, controlConfigsTypeOffset.Value, 0);
		}

		// Token: 0x06029C8C RID: 171148 RVA: 0x005B4600 File Offset: 0x005B2800
		public static VectorOffset CreateControlConfigsTypeVector(FlatBufferBuilder builder, TTimelineTrackControlConfig[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06029C8D RID: 171149 RVA: 0x005B4637 File Offset: 0x005B2837
		public static VectorOffset CreateControlConfigsTypeVectorBlock(FlatBufferBuilder builder, TTimelineTrackControlConfig[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TTimelineTrackControlConfig>(data);
			return builder.EndVector();
		}

		// Token: 0x06029C8E RID: 171150 RVA: 0x005B4651 File Offset: 0x005B2851
		public static VectorOffset CreateControlConfigsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TTimelineTrackControlConfig> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TTimelineTrackControlConfig>(data);
			return builder.EndVector();
		}

		// Token: 0x06029C8F RID: 171151 RVA: 0x005B466F File Offset: 0x005B286F
		public static VectorOffset CreateControlConfigsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TTimelineTrackControlConfig>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06029C90 RID: 171152 RVA: 0x005B4688 File Offset: 0x005B2888
		public static void StartControlConfigsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06029C91 RID: 171153 RVA: 0x005B4693 File Offset: 0x005B2893
		public static void AddControlConfigs(FlatBufferBuilder builder, VectorOffset controlConfigsOffset)
		{
			builder.AddOffset(4, controlConfigsOffset.Value, 0);
		}

		// Token: 0x06029C92 RID: 171154 RVA: 0x005B46A4 File Offset: 0x005B28A4
		public static VectorOffset CreateControlConfigsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06029C93 RID: 171155 RVA: 0x005B46DB File Offset: 0x005B28DB
		public static VectorOffset CreateControlConfigsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06029C94 RID: 171156 RVA: 0x005B46F5 File Offset: 0x005B28F5
		public static VectorOffset CreateControlConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06029C95 RID: 171157 RVA: 0x005B4713 File Offset: 0x005B2913
		public static VectorOffset CreateControlConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06029C96 RID: 171158 RVA: 0x005B472C File Offset: 0x005B292C
		public static void StartControlConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06029C97 RID: 171159 RVA: 0x005B4737 File Offset: 0x005B2937
		public static void AddControlPointEvents(FlatBufferBuilder builder, VectorOffset controlPointEventsOffset)
		{
			builder.AddOffset(5, controlPointEventsOffset.Value, 0);
		}

		// Token: 0x06029C98 RID: 171160 RVA: 0x005B4748 File Offset: 0x005B2948
		public static VectorOffset CreateControlPointEventsVector(FlatBufferBuilder builder, Offset<IControlPointEventConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06029C99 RID: 171161 RVA: 0x005B4788 File Offset: 0x005B2988
		public static VectorOffset CreateControlPointEventsVectorBlock(FlatBufferBuilder builder, Offset<IControlPointEventConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IControlPointEventConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06029C9A RID: 171162 RVA: 0x005B47A2 File Offset: 0x005B29A2
		public static VectorOffset CreateControlPointEventsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IControlPointEventConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IControlPointEventConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06029C9B RID: 171163 RVA: 0x005B47C0 File Offset: 0x005B29C0
		public static VectorOffset CreateControlPointEventsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IControlPointEventConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06029C9C RID: 171164 RVA: 0x005B47D9 File Offset: 0x005B29D9
		public static void StartControlPointEventsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06029C9D RID: 171165 RVA: 0x005B47E4 File Offset: 0x005B29E4
		public static void AddDescription(FlatBufferBuilder builder, StringOffset descriptionOffset)
		{
			builder.AddOffset(6, descriptionOffset.Value, 0);
		}

		// Token: 0x06029C9E RID: 171166 RVA: 0x005B47F4 File Offset: 0x005B29F4
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x06029C9F RID: 171167 RVA: 0x005B47FF File Offset: 0x005B29FF
		public static Offset<ITimelineControlGroup> EndITimelineControlGroup(FlatBufferBuilder builder)
		{
			return new Offset<ITimelineControlGroup>(builder.EndTable());
		}

		// Token: 0x06029CA0 RID: 171168 RVA: 0x005B480C File Offset: 0x005B2A0C
		public ITimelineControlGroupT UnPack()
		{
			ITimelineControlGroupT timelineControlGroupT = new ITimelineControlGroupT();
			this.UnPackTo(timelineControlGroupT);
			return timelineControlGroupT;
		}

		// Token: 0x06029CA1 RID: 171169 RVA: 0x005B4828 File Offset: 0x005B2A28
		public void UnPackTo(ITimelineControlGroupT _o)
		{
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
			_o.TidContent = this.TidContent;
			_o.SegmentTime = this.SegmentTime;
			_o.ControlConfigs = new List<TTimelineTrackControlConfigUnion>();
			for (int i = 0; i < this.ControlConfigsLength; i++)
			{
				TTimelineTrackControlConfigUnion ttimelineTrackControlConfigUnion = new TTimelineTrackControlConfigUnion();
				ttimelineTrackControlConfigUnion.Type = this.ControlConfigsType(i);
				TTimelineTrackControlConfig ttimelineTrackControlConfig = this.ControlConfigsType(i);
				if (ttimelineTrackControlConfig != TTimelineTrackControlConfig.IEntityTrackControl)
				{
					if (ttimelineTrackControlConfig == TTimelineTrackControlConfig.ISequenceTrackControl)
					{
						ttimelineTrackControlConfigUnion.Value = ((this.ControlConfigs<ISequenceTrackControl>(i) != null) ? this.ControlConfigs<ISequenceTrackControl>(i).Value.UnPack() : null);
					}
				}
				else
				{
					ttimelineTrackControlConfigUnion.Value = ((this.ControlConfigs<IEntityTrackControl>(i) != null) ? this.ControlConfigs<IEntityTrackControl>(i).Value.UnPack() : null);
				}
				_o.ControlConfigs.Add(ttimelineTrackControlConfigUnion);
			}
			_o.ControlPointEvents = new List<IControlPointEventConfigT>();
			for (int j = 0; j < this.ControlPointEventsLength; j++)
			{
				_o.ControlPointEvents.Add((this.ControlPointEvents(j) != null) ? this.ControlPointEvents(j).Value.UnPack() : null);
			}
			_o.Description = this.Description;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06029CA2 RID: 171170 RVA: 0x005B49B0 File Offset: 0x005B2BB0
		public static Offset<ITimelineControlGroup> Pack(FlatBufferBuilder builder, ITimelineControlGroupT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITimelineControlGroup>);
			}
			Offset<IConditionGroup> conditionOffset = (_o.Condition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.Condition);
			StringOffset tidContentOffset = (_o.TidContent == null) ? default(StringOffset) : builder.CreateString(_o.TidContent);
			VectorOffset controlConfigs_typeOffset = default(VectorOffset);
			if (_o.ControlConfigs != null)
			{
				TTimelineTrackControlConfig[] array = new TTimelineTrackControlConfig[_o.ControlConfigs.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.ControlConfigs[i].Type;
				}
				controlConfigs_typeOffset = ITimelineControlGroup.CreateControlConfigsTypeVector(builder, array);
			}
			VectorOffset controlConfigsOffset = default(VectorOffset);
			if (_o.ControlConfigs != null)
			{
				int[] array2 = new int[_o.ControlConfigs.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TTimelineTrackControlConfigUnion.Pack(builder, _o.ControlConfigs[j]);
				}
				controlConfigsOffset = ITimelineControlGroup.CreateControlConfigsVector(builder, array2);
			}
			VectorOffset controlPointEventsOffset = default(VectorOffset);
			if (_o.ControlPointEvents != null)
			{
				Offset<IControlPointEventConfig>[] array3 = new Offset<IControlPointEventConfig>[_o.ControlPointEvents.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = IControlPointEventConfig.Pack(builder, _o.ControlPointEvents[k]);
				}
				controlPointEventsOffset = ITimelineControlGroup.CreateControlPointEventsVector(builder, array3);
			}
			StringOffset descriptionOffset = (_o.Description == null) ? default(StringOffset) : builder.CreateString(_o.Description);
			return ITimelineControlGroup.CreateITimelineControlGroup(builder, conditionOffset, tidContentOffset, _o.SegmentTime, controlConfigs_typeOffset, controlConfigsOffset, controlPointEventsOffset, descriptionOffset, _o.NullMask);
		}

		// Token: 0x0400FE1C RID: 65052
		private Table __p;
	}
}
