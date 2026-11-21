using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FCA RID: 4042
	public sealed class RogueResEvent : IMessage<RogueResEvent>, IMessage, IEquatable<RogueResEvent>, IDeepCloneable<RogueResEvent>, IBufferMessage
	{
		// Token: 0x06015A18 RID: 88600 RVA: 0x00324362 File Offset: 0x00322562
		[NullableContext(1)]
		public static RogueResEvent Create()
		{
			return new RogueResEvent();
		}

		// Token: 0x17004827 RID: 18471
		// (get) Token: 0x06015A19 RID: 88601 RVA: 0x00324369 File Offset: 0x00322569
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004828 RID: 18472
		// (get) Token: 0x06015A1A RID: 88602 RVA: 0x0032436C File Offset: 0x0032256C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResEvent.Descriptor;
			}
		}

		// Token: 0x06015A1B RID: 88603 RVA: 0x00324373 File Offset: 0x00322573
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResEvent()
		{
		}

		// Token: 0x06015A1C RID: 88604 RVA: 0x00324394 File Offset: 0x00322594
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResEvent(RogueResEvent other) : this()
		{
			this.configId_ = other.configId_;
			this.curOption_ = other.curOption_;
			this.eventOptions_ = other.eventOptions_.Clone();
			this.selectOptions_ = other.selectOptions_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015A1D RID: 88605 RVA: 0x003243F2 File Offset: 0x003225F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResEvent Clone()
		{
			return new RogueResEvent(this);
		}

		// Token: 0x17004829 RID: 18473
		// (get) Token: 0x06015A1E RID: 88606 RVA: 0x003243FA File Offset: 0x003225FA
		// (set) Token: 0x06015A1F RID: 88607 RVA: 0x00324402 File Offset: 0x00322602
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConfigId
		{
			get
			{
				return this.configId_;
			}
			set
			{
				this.configId_ = value;
			}
		}

		// Token: 0x1700482A RID: 18474
		// (get) Token: 0x06015A20 RID: 88608 RVA: 0x0032440B File Offset: 0x0032260B
		// (set) Token: 0x06015A21 RID: 88609 RVA: 0x00324413 File Offset: 0x00322613
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurOption
		{
			get
			{
				return this.curOption_;
			}
			set
			{
				this.curOption_ = value;
			}
		}

		// Token: 0x1700482B RID: 18475
		// (get) Token: 0x06015A22 RID: 88610 RVA: 0x0032441C File Offset: 0x0032261C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EventOption> EventOptions
		{
			get
			{
				return this.eventOptions_;
			}
		}

		// Token: 0x1700482C RID: 18476
		// (get) Token: 0x06015A23 RID: 88611 RVA: 0x00324424 File Offset: 0x00322624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SelectOptions
		{
			get
			{
				return this.selectOptions_;
			}
		}

		// Token: 0x06015A24 RID: 88612 RVA: 0x0032442C File Offset: 0x0032262C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResEvent);
		}

		// Token: 0x06015A25 RID: 88613 RVA: 0x0032443C File Offset: 0x0032263C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResEvent other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && this.CurOption == other.CurOption && this.eventOptions_.Equals(other.eventOptions_) && this.selectOptions_.Equals(other.selectOptions_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015A26 RID: 88614 RVA: 0x003244B0 File Offset: 0x003226B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ConfigId != 0)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this.CurOption != 0)
			{
				num ^= this.CurOption.GetHashCode();
			}
			num ^= this.eventOptions_.GetHashCode();
			num ^= this.selectOptions_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015A27 RID: 88615 RVA: 0x00324524 File Offset: 0x00322724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015A28 RID: 88616 RVA: 0x00324531 File Offset: 0x00322731
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015A29 RID: 88617 RVA: 0x0032453C File Offset: 0x0032273C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ConfigId);
			}
			if (this.CurOption != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CurOption);
			}
			this.eventOptions_.WriteTo(ref output, RogueResEvent._repeated_eventOptions_codec);
			this.selectOptions_.WriteTo(ref output, RogueResEvent._repeated_selectOptions_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015A2A RID: 88618 RVA: 0x003245B8 File Offset: 0x003227B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfigId);
			}
			if (this.CurOption != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurOption);
			}
			num += this.eventOptions_.CalculateSize(RogueResEvent._repeated_eventOptions_codec);
			num += this.selectOptions_.CalculateSize(RogueResEvent._repeated_selectOptions_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015A2B RID: 88619 RVA: 0x00324634 File Offset: 0x00322834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResEvent other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ConfigId != 0)
			{
				this.ConfigId = other.ConfigId;
			}
			if (other.CurOption != 0)
			{
				this.CurOption = other.CurOption;
			}
			this.eventOptions_.Add(other.eventOptions_);
			this.selectOptions_.Add(other.selectOptions_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015A2C RID: 88620 RVA: 0x003246A6 File Offset: 0x003228A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015A2D RID: 88621 RVA: 0x003246B0 File Offset: 0x003228B0
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
						this.ConfigId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.CurOption = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 26U)
					{
						this.eventOptions_.AddEntriesFrom(ref input, RogueResEvent._repeated_eventOptions_codec);
						continue;
					}
					if (num == 32U || num == 34U)
					{
						this.selectOptions_.AddEntriesFrom(ref input, RogueResEvent._repeated_selectOptions_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400824E RID: 33358
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400824F RID: 33359
		public const int ConfigIdFieldNumber = 1;

		// Token: 0x04008250 RID: 33360
		private int configId_;

		// Token: 0x04008251 RID: 33361
		public const int CurOptionFieldNumber = 2;

		// Token: 0x04008252 RID: 33362
		private int curOption_;

		// Token: 0x04008253 RID: 33363
		public const int EventOptionsFieldNumber = 3;

		// Token: 0x04008254 RID: 33364
		private static readonly FieldCodec<EventOption> _repeated_eventOptions_codec = FieldCodec.ForMessage<EventOption>(26U, EventOption.Parser);

		// Token: 0x04008255 RID: 33365
		private readonly RepeatedField<EventOption> eventOptions_ = new RepeatedField<EventOption>();

		// Token: 0x04008256 RID: 33366
		public const int SelectOptionsFieldNumber = 4;

		// Token: 0x04008257 RID: 33367
		private static readonly FieldCodec<int> _repeated_selectOptions_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04008258 RID: 33368
		private readonly RepeatedField<int> selectOptions_ = new RepeatedField<int>();
	}
}
