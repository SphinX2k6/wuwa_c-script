using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005566 RID: 21862
	public struct IMonitorComponent : IFlatbufferObject
	{
		// Token: 0x1700A17C RID: 41340
		// (get) Token: 0x06024289 RID: 148105 RVA: 0x004FE88A File Offset: 0x004FCA8A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602428A RID: 148106 RVA: 0x004FE897 File Offset: 0x004FCA97
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602428B RID: 148107 RVA: 0x004FE8A0 File Offset: 0x004FCAA0
		public static IMonitorComponent GetRootAsIMonitorComponent(ByteBuffer _bb)
		{
			return IMonitorComponent.GetRootAsIMonitorComponent(_bb, default(IMonitorComponent));
		}

		// Token: 0x0602428C RID: 148108 RVA: 0x004FE8BC File Offset: 0x004FCABC
		public static IMonitorComponent GetRootAsIMonitorComponent(ByteBuffer _bb, IMonitorComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602428D RID: 148109 RVA: 0x004FE8D9 File Offset: 0x004FCAD9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602428E RID: 148110 RVA: 0x004FE8E8 File Offset: 0x004FCAE8
		public IMonitorComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A17D RID: 41341
		// (get) Token: 0x0602428F RID: 148111 RVA: 0x004FE8F8 File Offset: 0x004FCAF8
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A17E RID: 41342
		// (get) Token: 0x06024290 RID: 148112 RVA: 0x004FE938 File Offset: 0x004FCB38
		public IConeTriggerShape? Range
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IConeTriggerShape?(default(IConeTriggerShape).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A17F RID: 41343
		// (get) Token: 0x06024291 RID: 148113 RVA: 0x004FE998 File Offset: 0x004FCB98
		public string AttachPoint
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024292 RID: 148114 RVA: 0x004FE9CF File Offset: 0x004FCBCF
		public Span<byte> GetAttachPointBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06024293 RID: 148115 RVA: 0x004FE9DE File Offset: 0x004FCBDE
		public byte[] GetAttachPointArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x06024294 RID: 148116 RVA: 0x004FE9EC File Offset: 0x004FCBEC
		public string AvailableStates(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700A180 RID: 41344
		// (get) Token: 0x06024295 RID: 148117 RVA: 0x004FEA28 File Offset: 0x004FCC28
		public int AvailableStatesLength
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

		// Token: 0x1700A181 RID: 41345
		// (get) Token: 0x06024296 RID: 148118 RVA: 0x004FEA54 File Offset: 0x004FCC54
		public string StateAfterTriggered
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024297 RID: 148119 RVA: 0x004FEA8C File Offset: 0x004FCC8C
		public Span<byte> GetStateAfterTriggeredBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06024298 RID: 148120 RVA: 0x004FEA9C File Offset: 0x004FCC9C
		public byte[] GetStateAfterTriggeredArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x1700A182 RID: 41346
		// (get) Token: 0x06024299 RID: 148121 RVA: 0x004FEAAC File Offset: 0x004FCCAC
		public string StateAfterLeaved
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602429A RID: 148122 RVA: 0x004FEAE4 File Offset: 0x004FCCE4
		public Span<byte> GetStateAfterLeavedBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0602429B RID: 148123 RVA: 0x004FEAF4 File Offset: 0x004FCCF4
		public byte[] GetStateAfterLeavedArray()
		{
			return this.__p.__vector_as_array<byte>(14);
		}

		// Token: 0x1700A183 RID: 41347
		// (get) Token: 0x0602429C RID: 148124 RVA: 0x004FEB04 File Offset: 0x004FCD04
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602429D RID: 148125 RVA: 0x004FEB44 File Offset: 0x004FCD44
		public static Offset<IMonitorComponent> CreateIMonitorComponent(FlatBufferBuilder builder, bool Disabled = false, Offset<IConeTriggerShape> RangeOffset = default(Offset<IConeTriggerShape>), StringOffset AttachPointOffset = default(StringOffset), VectorOffset AvailableStatesOffset = default(VectorOffset), StringOffset StateAfterTriggeredOffset = default(StringOffset), StringOffset StateAfterLeavedOffset = default(StringOffset), byte NullMask = 0)
		{
			builder.StartTable(7);
			IMonitorComponent.AddStateAfterLeaved(builder, StateAfterLeavedOffset);
			IMonitorComponent.AddStateAfterTriggered(builder, StateAfterTriggeredOffset);
			IMonitorComponent.AddAvailableStates(builder, AvailableStatesOffset);
			IMonitorComponent.AddAttachPoint(builder, AttachPointOffset);
			IMonitorComponent.AddRange(builder, RangeOffset);
			IMonitorComponent.AddNullMask(builder, NullMask);
			IMonitorComponent.AddDisabled(builder, Disabled);
			return IMonitorComponent.EndIMonitorComponent(builder);
		}

		// Token: 0x0602429E RID: 148126 RVA: 0x004FEB93 File Offset: 0x004FCD93
		public static void StartIMonitorComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0602429F RID: 148127 RVA: 0x004FEB9C File Offset: 0x004FCD9C
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060242A0 RID: 148128 RVA: 0x004FEBA7 File Offset: 0x004FCDA7
		public static void AddRange(FlatBufferBuilder builder, Offset<IConeTriggerShape> rangeOffset)
		{
			builder.AddOffset(1, rangeOffset.Value, 0);
		}

		// Token: 0x060242A1 RID: 148129 RVA: 0x004FEBB7 File Offset: 0x004FCDB7
		public static void AddAttachPoint(FlatBufferBuilder builder, StringOffset attachPointOffset)
		{
			builder.AddOffset(2, attachPointOffset.Value, 0);
		}

		// Token: 0x060242A2 RID: 148130 RVA: 0x004FEBC7 File Offset: 0x004FCDC7
		public static void AddAvailableStates(FlatBufferBuilder builder, VectorOffset availableStatesOffset)
		{
			builder.AddOffset(3, availableStatesOffset.Value, 0);
		}

		// Token: 0x060242A3 RID: 148131 RVA: 0x004FEBD8 File Offset: 0x004FCDD8
		public static VectorOffset CreateAvailableStatesVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060242A4 RID: 148132 RVA: 0x004FEC18 File Offset: 0x004FCE18
		public static VectorOffset CreateAvailableStatesVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x060242A5 RID: 148133 RVA: 0x004FEC32 File Offset: 0x004FCE32
		public static VectorOffset CreateAvailableStatesVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x060242A6 RID: 148134 RVA: 0x004FEC50 File Offset: 0x004FCE50
		public static VectorOffset CreateAvailableStatesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060242A7 RID: 148135 RVA: 0x004FEC69 File Offset: 0x004FCE69
		public static void StartAvailableStatesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060242A8 RID: 148136 RVA: 0x004FEC74 File Offset: 0x004FCE74
		public static void AddStateAfterTriggered(FlatBufferBuilder builder, StringOffset stateAfterTriggeredOffset)
		{
			builder.AddOffset(4, stateAfterTriggeredOffset.Value, 0);
		}

		// Token: 0x060242A9 RID: 148137 RVA: 0x004FEC84 File Offset: 0x004FCE84
		public static void AddStateAfterLeaved(FlatBufferBuilder builder, StringOffset stateAfterLeavedOffset)
		{
			builder.AddOffset(5, stateAfterLeavedOffset.Value, 0);
		}

		// Token: 0x060242AA RID: 148138 RVA: 0x004FEC94 File Offset: 0x004FCE94
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x060242AB RID: 148139 RVA: 0x004FEC9F File Offset: 0x004FCE9F
		public static Offset<IMonitorComponent> EndIMonitorComponent(FlatBufferBuilder builder)
		{
			return new Offset<IMonitorComponent>(builder.EndTable());
		}

		// Token: 0x060242AC RID: 148140 RVA: 0x004FECAC File Offset: 0x004FCEAC
		public IMonitorComponentT UnPack()
		{
			IMonitorComponentT monitorComponentT = new IMonitorComponentT();
			this.UnPackTo(monitorComponentT);
			return monitorComponentT;
		}

		// Token: 0x060242AD RID: 148141 RVA: 0x004FECC8 File Offset: 0x004FCEC8
		public void UnPackTo(IMonitorComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.Range = ((this.Range != null) ? this.Range.Value.UnPack() : null);
			_o.AttachPoint = this.AttachPoint;
			_o.AvailableStates = new List<string>();
			for (int i = 0; i < this.AvailableStatesLength; i++)
			{
				_o.AvailableStates.Add(this.AvailableStates(i));
			}
			_o.StateAfterTriggered = this.StateAfterTriggered;
			_o.StateAfterLeaved = this.StateAfterLeaved;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060242AE RID: 148142 RVA: 0x004FED70 File Offset: 0x004FCF70
		public static Offset<IMonitorComponent> Pack(FlatBufferBuilder builder, IMonitorComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMonitorComponent>);
			}
			Offset<IConeTriggerShape> rangeOffset = (_o.Range == null) ? default(Offset<IConeTriggerShape>) : IConeTriggerShape.Pack(builder, _o.Range);
			StringOffset attachPointOffset = (_o.AttachPoint == null) ? default(StringOffset) : builder.CreateString(_o.AttachPoint);
			VectorOffset availableStatesOffset = default(VectorOffset);
			if (_o.AvailableStates != null)
			{
				StringOffset[] array = new StringOffset[_o.AvailableStates.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = builder.CreateString(_o.AvailableStates[i]);
				}
				availableStatesOffset = IMonitorComponent.CreateAvailableStatesVector(builder, array);
			}
			StringOffset stateAfterTriggeredOffset = (_o.StateAfterTriggered == null) ? default(StringOffset) : builder.CreateString(_o.StateAfterTriggered);
			StringOffset stateAfterLeavedOffset = (_o.StateAfterLeaved == null) ? default(StringOffset) : builder.CreateString(_o.StateAfterLeaved);
			return IMonitorComponent.CreateIMonitorComponent(builder, _o.Disabled, rangeOffset, attachPointOffset, availableStatesOffset, stateAfterTriggeredOffset, stateAfterLeavedOffset, _o.NullMask);
		}

		// Token: 0x0400E882 RID: 59522
		private Table __p;
	}
}
