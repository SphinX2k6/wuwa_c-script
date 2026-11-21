using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012C0 RID: 4800
	public sealed class SolarSchoolSavePreviewPb : IMessage<SolarSchoolSavePreviewPb>, IMessage, IEquatable<SolarSchoolSavePreviewPb>, IDeepCloneable<SolarSchoolSavePreviewPb>, IBufferMessage
	{
		// Token: 0x060199F4 RID: 104948 RVA: 0x003BD148 File Offset: 0x003BB348
		[NullableContext(1)]
		public static SolarSchoolSavePreviewPb Create()
		{
			return new SolarSchoolSavePreviewPb();
		}

		// Token: 0x170056C0 RID: 22208
		// (get) Token: 0x060199F5 RID: 104949 RVA: 0x003BD14F File Offset: 0x003BB34F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SolarSchoolSavePreviewPb> Parser
		{
			get
			{
				return SolarSchoolSavePreviewPb._parser;
			}
		}

		// Token: 0x170056C1 RID: 22209
		// (get) Token: 0x060199F6 RID: 104950 RVA: 0x003BD156 File Offset: 0x003BB356
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170056C2 RID: 22210
		// (get) Token: 0x060199F7 RID: 104951 RVA: 0x003BD159 File Offset: 0x003BB359
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SolarSchoolSavePreviewPb.Descriptor;
			}
		}

		// Token: 0x060199F8 RID: 104952 RVA: 0x003BD160 File Offset: 0x003BB360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolSavePreviewPb()
		{
		}

		// Token: 0x060199F9 RID: 104953 RVA: 0x003BD174 File Offset: 0x003BB374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolSavePreviewPb(SolarSchoolSavePreviewPb other) : this()
		{
			this.slotId_ = other.slotId_;
			this.cycleCount_ = other.cycleCount_;
			this.attr_ = other.attr_.Clone();
			this.gameDay_ = other.gameDay_;
			this.lastSaveTime_ = other.lastSaveTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060199FA RID: 104954 RVA: 0x003BD1D9 File Offset: 0x003BB3D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolSavePreviewPb Clone()
		{
			return new SolarSchoolSavePreviewPb(this);
		}

		// Token: 0x170056C3 RID: 22211
		// (get) Token: 0x060199FB RID: 104955 RVA: 0x003BD1E1 File Offset: 0x003BB3E1
		// (set) Token: 0x060199FC RID: 104956 RVA: 0x003BD1E9 File Offset: 0x003BB3E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SlotId
		{
			get
			{
				return this.slotId_;
			}
			set
			{
				this.slotId_ = value;
			}
		}

		// Token: 0x170056C4 RID: 22212
		// (get) Token: 0x060199FD RID: 104957 RVA: 0x003BD1F2 File Offset: 0x003BB3F2
		// (set) Token: 0x060199FE RID: 104958 RVA: 0x003BD1FA File Offset: 0x003BB3FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CycleCount
		{
			get
			{
				return this.cycleCount_;
			}
			set
			{
				this.cycleCount_ = value;
			}
		}

		// Token: 0x170056C5 RID: 22213
		// (get) Token: 0x060199FF RID: 104959 RVA: 0x003BD203 File Offset: 0x003BB403
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SolarSchoolAttrPb> Attr
		{
			get
			{
				return this.attr_;
			}
		}

		// Token: 0x170056C6 RID: 22214
		// (get) Token: 0x06019A00 RID: 104960 RVA: 0x003BD20B File Offset: 0x003BB40B
		// (set) Token: 0x06019A01 RID: 104961 RVA: 0x003BD213 File Offset: 0x003BB413
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GameDay
		{
			get
			{
				return this.gameDay_;
			}
			set
			{
				this.gameDay_ = value;
			}
		}

		// Token: 0x170056C7 RID: 22215
		// (get) Token: 0x06019A02 RID: 104962 RVA: 0x003BD21C File Offset: 0x003BB41C
		// (set) Token: 0x06019A03 RID: 104963 RVA: 0x003BD224 File Offset: 0x003BB424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long LastSaveTime
		{
			get
			{
				return this.lastSaveTime_;
			}
			set
			{
				this.lastSaveTime_ = value;
			}
		}

		// Token: 0x06019A04 RID: 104964 RVA: 0x003BD22D File Offset: 0x003BB42D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SolarSchoolSavePreviewPb);
		}

		// Token: 0x06019A05 RID: 104965 RVA: 0x003BD23C File Offset: 0x003BB43C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SolarSchoolSavePreviewPb other)
		{
			return other != null && (other == this || (this.SlotId == other.SlotId && this.CycleCount == other.CycleCount && this.attr_.Equals(other.attr_) && this.GameDay == other.GameDay && this.LastSaveTime == other.LastSaveTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019A06 RID: 104966 RVA: 0x003BD2BC File Offset: 0x003BB4BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SlotId != 0)
			{
				num ^= this.SlotId.GetHashCode();
			}
			if (this.CycleCount != 0)
			{
				num ^= this.CycleCount.GetHashCode();
			}
			num ^= this.attr_.GetHashCode();
			if (this.GameDay != 0)
			{
				num ^= this.GameDay.GetHashCode();
			}
			if (this.LastSaveTime != 0L)
			{
				num ^= this.LastSaveTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019A07 RID: 104967 RVA: 0x003BD354 File Offset: 0x003BB554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019A08 RID: 104968 RVA: 0x003BD361 File Offset: 0x003BB561
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019A09 RID: 104969 RVA: 0x003BD36C File Offset: 0x003BB56C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SlotId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SlotId);
			}
			if (this.CycleCount != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CycleCount);
			}
			this.attr_.WriteTo(ref output, SolarSchoolSavePreviewPb._repeated_attr_codec);
			if (this.GameDay != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.GameDay);
			}
			if (this.LastSaveTime != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.LastSaveTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019A0A RID: 104970 RVA: 0x003BD410 File Offset: 0x003BB610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SlotId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SlotId);
			}
			if (this.CycleCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CycleCount);
			}
			num += this.attr_.CalculateSize(SolarSchoolSavePreviewPb._repeated_attr_codec);
			if (this.GameDay != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GameDay);
			}
			if (this.LastSaveTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.LastSaveTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019A0B RID: 104971 RVA: 0x003BD4AC File Offset: 0x003BB6AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SolarSchoolSavePreviewPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SlotId != 0)
			{
				this.SlotId = other.SlotId;
			}
			if (other.CycleCount != 0)
			{
				this.CycleCount = other.CycleCount;
			}
			this.attr_.Add(other.attr_);
			if (other.GameDay != 0)
			{
				this.GameDay = other.GameDay;
			}
			if (other.LastSaveTime != 0L)
			{
				this.LastSaveTime = other.LastSaveTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019A0C RID: 104972 RVA: 0x003BD535 File Offset: 0x003BB735
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019A0D RID: 104973 RVA: 0x003BD540 File Offset: 0x003BB740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.SlotId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.CycleCount = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 26U)
					{
						this.attr_.AddEntriesFrom(ref input, SolarSchoolSavePreviewPb._repeated_attr_codec);
						continue;
					}
					if (num == 32U)
					{
						this.GameDay = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.LastSaveTime = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009764 RID: 38756
		private static readonly MessageParser<SolarSchoolSavePreviewPb> _parser = new MessageParser<SolarSchoolSavePreviewPb>(() => new SolarSchoolSavePreviewPb());

		// Token: 0x04009765 RID: 38757
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009766 RID: 38758
		public const int SlotIdFieldNumber = 1;

		// Token: 0x04009767 RID: 38759
		private int slotId_;

		// Token: 0x04009768 RID: 38760
		public const int CycleCountFieldNumber = 2;

		// Token: 0x04009769 RID: 38761
		private int cycleCount_;

		// Token: 0x0400976A RID: 38762
		public const int AttrFieldNumber = 3;

		// Token: 0x0400976B RID: 38763
		private static readonly FieldCodec<SolarSchoolAttrPb> _repeated_attr_codec = FieldCodec.ForMessage<SolarSchoolAttrPb>(26U, SolarSchoolAttrPb.Parser);

		// Token: 0x0400976C RID: 38764
		private readonly RepeatedField<SolarSchoolAttrPb> attr_ = new RepeatedField<SolarSchoolAttrPb>();

		// Token: 0x0400976D RID: 38765
		public const int GameDayFieldNumber = 4;

		// Token: 0x0400976E RID: 38766
		private int gameDay_;

		// Token: 0x0400976F RID: 38767
		public const int LastSaveTimeFieldNumber = 5;

		// Token: 0x04009770 RID: 38768
		private long lastSaveTime_;
	}
}
