using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A79 RID: 23161
	public struct ITimelineControlGroup : IFlatbufferObject
	{
		// Token: 0x1700AE6A RID: 44650
		// (get) Token: 0x060276F7 RID: 161527 RVA: 0x0056D16B File Offset: 0x0056B36B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060276F8 RID: 161528 RVA: 0x0056D178 File Offset: 0x0056B378
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060276F9 RID: 161529 RVA: 0x0056D180 File Offset: 0x0056B380
		public static ITimelineControlGroup GetRootAsITimelineControlGroup(ByteBuffer _bb)
		{
			return ITimelineControlGroup.GetRootAsITimelineControlGroup(_bb, default(ITimelineControlGroup));
		}

		// Token: 0x060276FA RID: 161530 RVA: 0x0056D19C File Offset: 0x0056B39C
		public static ITimelineControlGroup GetRootAsITimelineControlGroup(ByteBuffer _bb, ITimelineControlGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060276FB RID: 161531 RVA: 0x0056D1B9 File Offset: 0x0056B3B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060276FC RID: 161532 RVA: 0x0056D1C8 File Offset: 0x0056B3C8
		public ITimelineControlGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AE6B RID: 44651
		// (get) Token: 0x060276FD RID: 161533 RVA: 0x0056D1D8 File Offset: 0x0056B3D8
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

		// Token: 0x1700AE6C RID: 44652
		// (get) Token: 0x060276FE RID: 161534 RVA: 0x0056D238 File Offset: 0x0056B438
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

		// Token: 0x060276FF RID: 161535 RVA: 0x0056D26F File Offset: 0x0056B46F
		public Span<byte> GetTidContentBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06027700 RID: 161536 RVA: 0x0056D27E File Offset: 0x0056B47E
		public byte[] GetTidContentArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700AE6D RID: 44653
		// (get) Token: 0x06027701 RID: 161537 RVA: 0x0056D28C File Offset: 0x0056B48C
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

		// Token: 0x06027702 RID: 161538 RVA: 0x0056D2CC File Offset: 0x0056B4CC
		public TTimelineTrackControlConfig ControlConfigsType(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return TTimelineTrackControlConfig.NONE;
			}
			return (TTimelineTrackControlConfig)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700AE6E RID: 44654
		// (get) Token: 0x06027703 RID: 161539 RVA: 0x0056D30C File Offset: 0x0056B50C
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

		// Token: 0x06027704 RID: 161540 RVA: 0x0056D338 File Offset: 0x0056B538
		public Span<TTimelineTrackControlConfig> GetControlConfigsTypeBytes()
		{
			return this.__p.__vector_as_span<TTimelineTrackControlConfig>(10, 1);
		}

		// Token: 0x06027705 RID: 161541 RVA: 0x0056D348 File Offset: 0x0056B548
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

		// Token: 0x06027706 RID: 161542 RVA: 0x0056D3B4 File Offset: 0x0056B5B4
		public TTable? ControlConfigs<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700AE6F RID: 44655
		// (get) Token: 0x06027707 RID: 161543 RVA: 0x0056D3FC File Offset: 0x0056B5FC
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

		// Token: 0x06027708 RID: 161544 RVA: 0x0056D428 File Offset: 0x0056B628
		public IControlPointEventConfig? ControlPointEvents(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new IControlPointEventConfig?(default(IControlPointEventConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AE70 RID: 44656
		// (get) Token: 0x06027709 RID: 161545 RVA: 0x0056D48C File Offset: 0x0056B68C
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

		// Token: 0x1700AE71 RID: 44657
		// (get) Token: 0x0602770A RID: 161546 RVA: 0x0056D4B8 File Offset: 0x0056B6B8
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

		// Token: 0x0602770B RID: 161547 RVA: 0x0056D4F0 File Offset: 0x0056B6F0
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0602770C RID: 161548 RVA: 0x0056D500 File Offset: 0x0056B700
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(16);
		}

		// Token: 0x1700AE72 RID: 44658
		// (get) Token: 0x0602770D RID: 161549 RVA: 0x0056D510 File Offset: 0x0056B710
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

		// Token: 0x0602770E RID: 161550 RVA: 0x0056D550 File Offset: 0x0056B750
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

		// Token: 0x0602770F RID: 161551 RVA: 0x0056D5A7 File Offset: 0x0056B7A7
		public static void StartITimelineControlGroup(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06027710 RID: 161552 RVA: 0x0056D5B0 File Offset: 0x0056B7B0
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(0, conditionOffset.Value, 0);
		}

		// Token: 0x06027711 RID: 161553 RVA: 0x0056D5C0 File Offset: 0x0056B7C0
		public static void AddTidContent(FlatBufferBuilder builder, StringOffset tidContentOffset)
		{
			builder.AddOffset(1, tidContentOffset.Value, 0);
		}

		// Token: 0x06027712 RID: 161554 RVA: 0x0056D5D0 File Offset: 0x0056B7D0
		public static void AddSegmentTime(FlatBufferBuilder builder, float segmentTime)
		{
			builder.AddFloat(2, segmentTime, 0.0);
		}

		// Token: 0x06027713 RID: 161555 RVA: 0x0056D5E3 File Offset: 0x0056B7E3
		public static void AddControlConfigsType(FlatBufferBuilder builder, VectorOffset controlConfigsTypeOffset)
		{
			builder.AddOffset(3, controlConfigsTypeOffset.Value, 0);
		}

		// Token: 0x06027714 RID: 161556 RVA: 0x0056D5F4 File Offset: 0x0056B7F4
		public static VectorOffset CreateControlConfigsTypeVector(FlatBufferBuilder builder, TTimelineTrackControlConfig[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06027715 RID: 161557 RVA: 0x0056D62B File Offset: 0x0056B82B
		public static VectorOffset CreateControlConfigsTypeVectorBlock(FlatBufferBuilder builder, TTimelineTrackControlConfig[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TTimelineTrackControlConfig>(data);
			return builder.EndVector();
		}

		// Token: 0x06027716 RID: 161558 RVA: 0x0056D645 File Offset: 0x0056B845
		public static VectorOffset CreateControlConfigsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TTimelineTrackControlConfig> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TTimelineTrackControlConfig>(data);
			return builder.EndVector();
		}

		// Token: 0x06027717 RID: 161559 RVA: 0x0056D663 File Offset: 0x0056B863
		public static VectorOffset CreateControlConfigsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TTimelineTrackControlConfig>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06027718 RID: 161560 RVA: 0x0056D67C File Offset: 0x0056B87C
		public static void StartControlConfigsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06027719 RID: 161561 RVA: 0x0056D687 File Offset: 0x0056B887
		public static void AddControlConfigs(FlatBufferBuilder builder, VectorOffset controlConfigsOffset)
		{
			builder.AddOffset(4, controlConfigsOffset.Value, 0);
		}

		// Token: 0x0602771A RID: 161562 RVA: 0x0056D698 File Offset: 0x0056B898
		public static VectorOffset CreateControlConfigsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602771B RID: 161563 RVA: 0x0056D6CF File Offset: 0x0056B8CF
		public static VectorOffset CreateControlConfigsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602771C RID: 161564 RVA: 0x0056D6E9 File Offset: 0x0056B8E9
		public static VectorOffset CreateControlConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602771D RID: 161565 RVA: 0x0056D707 File Offset: 0x0056B907
		public static VectorOffset CreateControlConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602771E RID: 161566 RVA: 0x0056D720 File Offset: 0x0056B920
		public static void StartControlConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602771F RID: 161567 RVA: 0x0056D72B File Offset: 0x0056B92B
		public static void AddControlPointEvents(FlatBufferBuilder builder, VectorOffset controlPointEventsOffset)
		{
			builder.AddOffset(5, controlPointEventsOffset.Value, 0);
		}

		// Token: 0x06027720 RID: 161568 RVA: 0x0056D73C File Offset: 0x0056B93C
		public static VectorOffset CreateControlPointEventsVector(FlatBufferBuilder builder, Offset<IControlPointEventConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06027721 RID: 161569 RVA: 0x0056D77C File Offset: 0x0056B97C
		public static VectorOffset CreateControlPointEventsVectorBlock(FlatBufferBuilder builder, Offset<IControlPointEventConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IControlPointEventConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027722 RID: 161570 RVA: 0x0056D796 File Offset: 0x0056B996
		public static VectorOffset CreateControlPointEventsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IControlPointEventConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IControlPointEventConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027723 RID: 161571 RVA: 0x0056D7B4 File Offset: 0x0056B9B4
		public static VectorOffset CreateControlPointEventsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IControlPointEventConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06027724 RID: 161572 RVA: 0x0056D7CD File Offset: 0x0056B9CD
		public static void StartControlPointEventsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06027725 RID: 161573 RVA: 0x0056D7D8 File Offset: 0x0056B9D8
		public static void AddDescription(FlatBufferBuilder builder, StringOffset descriptionOffset)
		{
			builder.AddOffset(6, descriptionOffset.Value, 0);
		}

		// Token: 0x06027726 RID: 161574 RVA: 0x0056D7E8 File Offset: 0x0056B9E8
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x06027727 RID: 161575 RVA: 0x0056D7F3 File Offset: 0x0056B9F3
		public static Offset<ITimelineControlGroup> EndITimelineControlGroup(FlatBufferBuilder builder)
		{
			return new Offset<ITimelineControlGroup>(builder.EndTable());
		}

		// Token: 0x06027728 RID: 161576 RVA: 0x0056D800 File Offset: 0x0056BA00
		public ITimelineControlGroupT UnPack()
		{
			ITimelineControlGroupT timelineControlGroupT = new ITimelineControlGroupT();
			this.UnPackTo(timelineControlGroupT);
			return timelineControlGroupT;
		}

		// Token: 0x06027729 RID: 161577 RVA: 0x0056D81C File Offset: 0x0056BA1C
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

		// Token: 0x0602772A RID: 161578 RVA: 0x0056D9A4 File Offset: 0x0056BBA4
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

		// Token: 0x0400F125 RID: 61733
		private Table __p;
	}
}
