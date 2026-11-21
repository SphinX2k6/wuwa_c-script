using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006089 RID: 24713
	public struct ITimelineTrackControlComponent : IFlatbufferObject
	{
		// Token: 0x1700B7B2 RID: 47026
		// (get) Token: 0x06029CB3 RID: 171187 RVA: 0x005B4CB7 File Offset: 0x005B2EB7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029CB4 RID: 171188 RVA: 0x005B4CC4 File Offset: 0x005B2EC4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029CB5 RID: 171189 RVA: 0x005B4CCC File Offset: 0x005B2ECC
		public static ITimelineTrackControlComponent GetRootAsITimelineTrackControlComponent(ByteBuffer _bb)
		{
			return ITimelineTrackControlComponent.GetRootAsITimelineTrackControlComponent(_bb, default(ITimelineTrackControlComponent));
		}

		// Token: 0x06029CB6 RID: 171190 RVA: 0x005B4CE8 File Offset: 0x005B2EE8
		public static ITimelineTrackControlComponent GetRootAsITimelineTrackControlComponent(ByteBuffer _bb, ITimelineTrackControlComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029CB7 RID: 171191 RVA: 0x005B4D05 File Offset: 0x005B2F05
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029CB8 RID: 171192 RVA: 0x005B4D14 File Offset: 0x005B2F14
		public ITimelineTrackControlComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B7B3 RID: 47027
		// (get) Token: 0x06029CB9 RID: 171193 RVA: 0x005B4D24 File Offset: 0x005B2F24
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06029CBA RID: 171194 RVA: 0x005B4D64 File Offset: 0x005B2F64
		public ITimelineControlGroup? ControlGroups(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ITimelineControlGroup?(default(ITimelineControlGroup).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B7B4 RID: 47028
		// (get) Token: 0x06029CBB RID: 171195 RVA: 0x005B4DC4 File Offset: 0x005B2FC4
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

		// Token: 0x1700B7B5 RID: 47029
		// (get) Token: 0x06029CBC RID: 171196 RVA: 0x005B4DF0 File Offset: 0x005B2FF0
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

		// Token: 0x06029CBD RID: 171197 RVA: 0x005B4E2C File Offset: 0x005B302C
		public static Offset<ITimelineTrackControlComponent> CreateITimelineTrackControlComponent(FlatBufferBuilder builder, bool Disabled = false, VectorOffset ControlGroupsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			ITimelineTrackControlComponent.AddControlGroups(builder, ControlGroupsOffset);
			ITimelineTrackControlComponent.AddNullMask(builder, NullMask);
			ITimelineTrackControlComponent.AddDisabled(builder, Disabled);
			return ITimelineTrackControlComponent.EndITimelineTrackControlComponent(builder);
		}

		// Token: 0x06029CBE RID: 171198 RVA: 0x005B4E50 File Offset: 0x005B3050
		public static void StartITimelineTrackControlComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06029CBF RID: 171199 RVA: 0x005B4E59 File Offset: 0x005B3059
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06029CC0 RID: 171200 RVA: 0x005B4E64 File Offset: 0x005B3064
		public static void AddControlGroups(FlatBufferBuilder builder, VectorOffset controlGroupsOffset)
		{
			builder.AddOffset(1, controlGroupsOffset.Value, 0);
		}

		// Token: 0x06029CC1 RID: 171201 RVA: 0x005B4E74 File Offset: 0x005B3074
		public static VectorOffset CreateControlGroupsVector(FlatBufferBuilder builder, Offset<ITimelineControlGroup>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06029CC2 RID: 171202 RVA: 0x005B4EB4 File Offset: 0x005B30B4
		public static VectorOffset CreateControlGroupsVectorBlock(FlatBufferBuilder builder, Offset<ITimelineControlGroup>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ITimelineControlGroup>>(data);
			return builder.EndVector();
		}

		// Token: 0x06029CC3 RID: 171203 RVA: 0x005B4ECE File Offset: 0x005B30CE
		public static VectorOffset CreateControlGroupsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ITimelineControlGroup>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ITimelineControlGroup>>(data);
			return builder.EndVector();
		}

		// Token: 0x06029CC4 RID: 171204 RVA: 0x005B4EEC File Offset: 0x005B30EC
		public static VectorOffset CreateControlGroupsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ITimelineControlGroup>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06029CC5 RID: 171205 RVA: 0x005B4F05 File Offset: 0x005B3105
		public static void StartControlGroupsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06029CC6 RID: 171206 RVA: 0x005B4F10 File Offset: 0x005B3110
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06029CC7 RID: 171207 RVA: 0x005B4F1B File Offset: 0x005B311B
		public static Offset<ITimelineTrackControlComponent> EndITimelineTrackControlComponent(FlatBufferBuilder builder)
		{
			return new Offset<ITimelineTrackControlComponent>(builder.EndTable());
		}

		// Token: 0x06029CC8 RID: 171208 RVA: 0x005B4F28 File Offset: 0x005B3128
		public ITimelineTrackControlComponentT UnPack()
		{
			ITimelineTrackControlComponentT timelineTrackControlComponentT = new ITimelineTrackControlComponentT();
			this.UnPackTo(timelineTrackControlComponentT);
			return timelineTrackControlComponentT;
		}

		// Token: 0x06029CC9 RID: 171209 RVA: 0x005B4F44 File Offset: 0x005B3144
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

		// Token: 0x06029CCA RID: 171210 RVA: 0x005B4FBC File Offset: 0x005B31BC
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

		// Token: 0x0400FE24 RID: 65060
		private Table __p;
	}
}
