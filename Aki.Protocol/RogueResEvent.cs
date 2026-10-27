using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FDA RID: 4058
	public sealed class RogueResEvent : IMessage<RogueResEvent>, IMessage, IEquatable<RogueResEvent>, IDeepCloneable<RogueResEvent>, IBufferMessage
	{
		// Token: 0x06015AFD RID: 88829 RVA: 0x00325A16 File Offset: 0x00323C16
		[NullableContext(1)]
		public static RogueResEvent Create()
		{
			return new RogueResEvent();
		}

		// Token: 0x17004851 RID: 18513
		// (get) Token: 0x06015AFE RID: 88830 RVA: 0x00325A1D File Offset: 0x00323C1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004852 RID: 18514
		// (get) Token: 0x06015AFF RID: 88831 RVA: 0x00325A20 File Offset: 0x00323C20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResEvent.Descriptor;
			}
		}

		// Token: 0x06015B00 RID: 88832 RVA: 0x00325A27 File Offset: 0x00323C27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResEvent()
		{
		}

		// Token: 0x06015B01 RID: 88833 RVA: 0x00325A48 File Offset: 0x00323C48
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

		// Token: 0x06015B02 RID: 88834 RVA: 0x00325AA6 File Offset: 0x00323CA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResEvent Clone()
		{
			return new RogueResEvent(this);
		}

		// Token: 0x17004853 RID: 18515
		// (get) Token: 0x06015B03 RID: 88835 RVA: 0x00325AAE File Offset: 0x00323CAE
		// (set) Token: 0x06015B04 RID: 88836 RVA: 0x00325AB6 File Offset: 0x00323CB6
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

		// Token: 0x17004854 RID: 18516
		// (get) Token: 0x06015B05 RID: 88837 RVA: 0x00325ABF File Offset: 0x00323CBF
		// (set) Token: 0x06015B06 RID: 88838 RVA: 0x00325AC7 File Offset: 0x00323CC7
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

		// Token: 0x17004855 RID: 18517
		// (get) Token: 0x06015B07 RID: 88839 RVA: 0x00325AD0 File Offset: 0x00323CD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EventOption> EventOptions
		{
			get
			{
				return this.eventOptions_;
			}
		}

		// Token: 0x17004856 RID: 18518
		// (get) Token: 0x06015B08 RID: 88840 RVA: 0x00325AD8 File Offset: 0x00323CD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SelectOptions
		{
			get
			{
				return this.selectOptions_;
			}
		}

		// Token: 0x06015B09 RID: 88841 RVA: 0x00325AE0 File Offset: 0x00323CE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResEvent);
		}

		// Token: 0x06015B0A RID: 88842 RVA: 0x00325AF0 File Offset: 0x00323CF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResEvent other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && this.CurOption == other.CurOption && this.eventOptions_.Equals(other.eventOptions_) && this.selectOptions_.Equals(other.selectOptions_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015B0B RID: 88843 RVA: 0x00325B64 File Offset: 0x00323D64
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

		// Token: 0x06015B0C RID: 88844 RVA: 0x00325BD8 File Offset: 0x00323DD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015B0D RID: 88845 RVA: 0x00325BE5 File Offset: 0x00323DE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015B0E RID: 88846 RVA: 0x00325BF0 File Offset: 0x00323DF0
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

		// Token: 0x06015B0F RID: 88847 RVA: 0x00325C6C File Offset: 0x00323E6C
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

		// Token: 0x06015B10 RID: 88848 RVA: 0x00325CE8 File Offset: 0x00323EE8
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

		// Token: 0x06015B11 RID: 88849 RVA: 0x00325D5A File Offset: 0x00323F5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015B12 RID: 88850 RVA: 0x00325D64 File Offset: 0x00323F64
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

		// Token: 0x04008224 RID: 33316
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008225 RID: 33317
		public const int ConfigIdFieldNumber = 1;

		// Token: 0x04008226 RID: 33318
		private int configId_;

		// Token: 0x04008227 RID: 33319
		public const int CurOptionFieldNumber = 2;

		// Token: 0x04008228 RID: 33320
		private int curOption_;

		// Token: 0x04008229 RID: 33321
		public const int EventOptionsFieldNumber = 3;

		// Token: 0x0400822A RID: 33322
		private static readonly FieldCodec<EventOption> _repeated_eventOptions_codec = FieldCodec.ForMessage<EventOption>(26U, EventOption.Parser);

		// Token: 0x0400822B RID: 33323
		private readonly RepeatedField<EventOption> eventOptions_ = new RepeatedField<EventOption>();

		// Token: 0x0400822C RID: 33324
		public const int SelectOptionsFieldNumber = 4;

		// Token: 0x0400822D RID: 33325
		private static readonly FieldCodec<int> _repeated_selectOptions_codec = FieldCodec.ForInt32(34U);

		// Token: 0x0400822E RID: 33326
		private readonly RepeatedField<int> selectOptions_ = new RepeatedField<int>();
	}
}
