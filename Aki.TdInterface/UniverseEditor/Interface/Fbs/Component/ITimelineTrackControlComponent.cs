using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A7C RID: 23164
	public struct ITimelineTrackControlComponent : IFlatbufferObject
	{
		// Token: 0x1700AE7A RID: 44666
		// (get) Token: 0x0602773B RID: 161595 RVA: 0x0056DCAB File Offset: 0x0056BEAB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602773C RID: 161596 RVA: 0x0056DCB8 File Offset: 0x0056BEB8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602773D RID: 161597 RVA: 0x0056DCC0 File Offset: 0x0056BEC0
		public static ITimelineTrackControlComponent GetRootAsITimelineTrackControlComponent(ByteBuffer _bb)
		{
			return ITimelineTrackControlComponent.GetRootAsITimelineTrackControlComponent(_bb, default(ITimelineTrackControlComponent));
		}

		// Token: 0x0602773E RID: 161598 RVA: 0x0056DCDC File Offset: 0x0056BEDC
		public static ITimelineTrackControlComponent GetRootAsITimelineTrackControlComponent(ByteBuffer _bb, ITimelineTrackControlComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602773F RID: 161599 RVA: 0x0056DCF9 File Offset: 0x0056BEF9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027740 RID: 161600 RVA: 0x0056DD08 File Offset: 0x0056BF08
		public ITimelineTrackControlComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AE7B RID: 44667
		// (get) Token: 0x06027741 RID: 161601 RVA: 0x0056DD18 File Offset: 0x0056BF18
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06027742 RID: 161602 RVA: 0x0056DD58 File Offset: 0x0056BF58
		public ITimelineControlGroup? ControlGroups(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ITimelineControlGroup?(default(ITimelineControlGroup).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AE7C RID: 44668
		// (get) Token: 0x06027743 RID: 161603 RVA: 0x0056DDB8 File Offset: 0x0056BFB8
		public int ControlGroupsLength
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

		// Token: 0x1700AE7D RID: 44669
		// (get) Token: 0x06027744 RID: 161604 RVA: 0x0056DDE4 File Offset: 0x0056BFE4
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

		// Token: 0x06027745 RID: 161605 RVA: 0x0056DE20 File Offset: 0x0056C020
		public static Offset<ITimelineTrackControlComponent> CreateITimelineTrackControlComponent(FlatBufferBuilder builder, bool Disabled = false, VectorOffset ControlGroupsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			ITimelineTrackControlComponent.AddControlGroups(builder, ControlGroupsOffset);
			ITimelineTrackControlComponent.AddNullMask(builder, NullMask);
			ITimelineTrackControlComponent.AddDisabled(builder, Disabled);
			return ITimelineTrackControlComponent.EndITimelineTrackControlComponent(builder);
		}

		// Token: 0x06027746 RID: 161606 RVA: 0x0056DE44 File Offset: 0x0056C044
		public static void StartITimelineTrackControlComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06027747 RID: 161607 RVA: 0x0056DE4D File Offset: 0x0056C04D
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06027748 RID: 161608 RVA: 0x0056DE58 File Offset: 0x0056C058
		public static void AddControlGroups(FlatBufferBuilder builder, VectorOffset controlGroupsOffset)
		{
			builder.AddOffset(1, controlGroupsOffset.Value, 0);
		}

		// Token: 0x06027749 RID: 161609 RVA: 0x0056DE68 File Offset: 0x0056C068
		public static VectorOffset CreateControlGroupsVector(FlatBufferBuilder builder, Offset<ITimelineControlGroup>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602774A RID: 161610 RVA: 0x0056DEA8 File Offset: 0x0056C0A8
		public static VectorOffset CreateControlGroupsVectorBlock(FlatBufferBuilder builder, Offset<ITimelineControlGroup>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ITimelineControlGroup>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602774B RID: 161611 RVA: 0x0056DEC2 File Offset: 0x0056C0C2
		public static VectorOffset CreateControlGroupsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ITimelineControlGroup>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ITimelineControlGroup>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602774C RID: 161612 RVA: 0x0056DEE0 File Offset: 0x0056C0E0
		public static VectorOffset CreateControlGroupsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ITimelineControlGroup>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602774D RID: 161613 RVA: 0x0056DEF9 File Offset: 0x0056C0F9
		public static void StartControlGroupsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602774E RID: 161614 RVA: 0x0056DF04 File Offset: 0x0056C104
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602774F RID: 161615 RVA: 0x0056DF0F File Offset: 0x0056C10F
		public static Offset<ITimelineTrackControlComponent> EndITimelineTrackControlComponent(FlatBufferBuilder builder)
		{
			return new Offset<ITimelineTrackControlComponent>(builder.EndTable());
		}

		// Token: 0x06027750 RID: 161616 RVA: 0x0056DF1C File Offset: 0x0056C11C
		public ITimelineTrackControlComponentT UnPack()
		{
			ITimelineTrackControlComponentT timelineTrackControlComponentT = new ITimelineTrackControlComponentT();
			this.UnPackTo(timelineTrackControlComponentT);
			return timelineTrackControlComponentT;
		}

		// Token: 0x06027751 RID: 161617 RVA: 0x0056DF38 File Offset: 0x0056C138
		public void UnPackTo(ITimelineTrackControlComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.ControlGroups = new List<ITimelineControlGroupT>();
			for (int i = 0; i < this.ControlGroupsLength; i++)
			{
				_o.ControlGroups.Add((this.ControlGroups(i) != null) ? this.ControlGroups(i).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06027752 RID: 161618 RVA: 0x0056DFB0 File Offset: 0x0056C1B0
		public static Offset<ITimelineTrackControlComponent> Pack(FlatBufferBuilder builder, ITimelineTrackControlComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITimelineTrackControlComponent>);
			}
			VectorOffset controlGroupsOffset = default(VectorOffset);
			if (_o.ControlGroups != null)
			{
				Offset<ITimelineControlGroup>[] array = new Offset<ITimelineControlGroup>[_o.ControlGroups.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ITimelineControlGroup.Pack(builder, _o.ControlGroups[i]);
				}
				controlGroupsOffset = ITimelineTrackControlComponent.CreateControlGroupsVector(builder, array);
			}
			return ITimelineTrackControlComponent.CreateITimelineTrackControlComponent(builder, _o.Disabled, controlGroupsOffset, _o.NullMask);
		}

		// Token: 0x0400F12D RID: 61741
		private Table __p;
	}
}
