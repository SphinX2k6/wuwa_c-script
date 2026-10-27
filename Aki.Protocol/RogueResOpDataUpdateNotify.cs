using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FFB RID: 4091
	[NetMessage(EMessageId.RogueResOpDataUpdateNotify)]
	public sealed class RogueResOpDataUpdateNotify : IMessage<RogueResOpDataUpdateNotify>, IMessage, IEquatable<RogueResOpDataUpdateNotify>, IDeepCloneable<RogueResOpDataUpdateNotify>, IBufferMessage
	{
		// Token: 0x06015DEA RID: 89578 RVA: 0x0032D849 File Offset: 0x0032BA49
		[NullableContext(1)]
		public static RogueResOpDataUpdateNotify Create()
		{
			return new RogueResOpDataUpdateNotify();
		}

		// Token: 0x17004907 RID: 18695
		// (get) Token: 0x06015DEB RID: 89579 RVA: 0x0032D850 File Offset: 0x0032BA50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004908 RID: 18696
		// (get) Token: 0x06015DEC RID: 89580 RVA: 0x0032D853 File Offset: 0x0032BA53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResOpDataUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06015DED RID: 89581 RVA: 0x0032D85A File Offset: 0x0032BA5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResOpDataUpdateNotify()
		{
		}

		// Token: 0x06015DEE RID: 89582 RVA: 0x0032D884 File Offset: 0x0032BA84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResOpDataUpdateNotify(RogueResOpDataUpdateNotify other) : this()
		{
			this.adds_ = other.adds_.Clone();
			this.updates_ = other.updates_.Clone();
			this.removes_ = other.removes_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015DEF RID: 89583 RVA: 0x0032D8DB File Offset: 0x0032BADB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResOpDataUpdateNotify Clone()
		{
			return new RogueResOpDataUpdateNotify(this);
		}

		// Token: 0x17004909 RID: 18697
		// (get) Token: 0x06015DF0 RID: 89584 RVA: 0x0032D8E3 File Offset: 0x0032BAE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueResOpData> Adds
		{
			get
			{
				return this.adds_;
			}
		}

		// Token: 0x1700490A RID: 18698
		// (get) Token: 0x06015DF1 RID: 89585 RVA: 0x0032D8EB File Offset: 0x0032BAEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueResOpData> Updates
		{
			get
			{
				return this.updates_;
			}
		}

		// Token: 0x1700490B RID: 18699
		// (get) Token: 0x06015DF2 RID: 89586 RVA: 0x0032D8F3 File Offset: 0x0032BAF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Removes
		{
			get
			{
				return this.removes_;
			}
		}

		// Token: 0x06015DF3 RID: 89587 RVA: 0x0032D8FB File Offset: 0x0032BAFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResOpDataUpdateNotify);
		}

		// Token: 0x06015DF4 RID: 89588 RVA: 0x0032D90C File Offset: 0x0032BB0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResOpDataUpdateNotify other)
		{
			return other != null && (other == this || (this.adds_.Equals(other.adds_) && this.updates_.Equals(other.updates_) && this.removes_.Equals(other.removes_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015DF5 RID: 89589 RVA: 0x0032D974 File Offset: 0x0032BB74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.adds_.GetHashCode();
			num ^= this.updates_.GetHashCode();
			num ^= this.removes_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015DF6 RID: 89590 RVA: 0x0032D9C4 File Offset: 0x0032BBC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015DF7 RID: 89591 RVA: 0x0032D9D1 File Offset: 0x0032BBD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015DF8 RID: 89592 RVA: 0x0032D9DC File Offset: 0x0032BBDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.updates_.WriteTo(ref output, RogueResOpDataUpdateNotify._repeated_updates_codec);
			this.adds_.WriteTo(ref output, RogueResOpDataUpdateNotify._repeated_adds_codec);
			this.removes_.WriteTo(ref output, RogueResOpDataUpdateNotify._repeated_removes_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015DF9 RID: 89593 RVA: 0x0032DA30 File Offset: 0x0032BC30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.adds_.CalculateSize(RogueResOpDataUpdateNotify._repeated_adds_codec);
			num += this.updates_.CalculateSize(RogueResOpDataUpdateNotify._repeated_updates_codec);
			num += this.removes_.CalculateSize(RogueResOpDataUpdateNotify._repeated_removes_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015DFA RID: 89594 RVA: 0x0032DA90 File Offset: 0x0032BC90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResOpDataUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.adds_.Add(other.adds_);
			this.updates_.Add(other.updates_);
			this.removes_.Add(other.removes_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015DFB RID: 89595 RVA: 0x0032DAEB File Offset: 0x0032BCEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015DFC RID: 89596 RVA: 0x0032DAF4 File Offset: 0x0032BCF4
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
				if (num <= 42U)
				{
					if (num == 34U)
					{
						this.updates_.AddEntriesFrom(ref input, RogueResOpDataUpdateNotify._repeated_updates_codec);
						continue;
					}
					if (num == 42U)
					{
						this.adds_.AddEntriesFrom(ref input, RogueResOpDataUpdateNotify._repeated_adds_codec);
						continue;
					}
				}
				else if (num == 72U || num == 74U)
				{
					this.removes_.AddEntriesFrom(ref input, RogueResOpDataUpdateNotify._repeated_removes_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400832A RID: 33578
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400832B RID: 33579
		public const int AddsFieldNumber = 5;

		// Token: 0x0400832C RID: 33580
		private static readonly FieldCodec<RogueResOpData> _repeated_adds_codec = FieldCodec.ForMessage<RogueResOpData>(42U, RogueResOpData.Parser);

		// Token: 0x0400832D RID: 33581
		private readonly RepeatedField<RogueResOpData> adds_ = new RepeatedField<RogueResOpData>();

		// Token: 0x0400832E RID: 33582
		public const int UpdatesFieldNumber = 4;

		// Token: 0x0400832F RID: 33583
		private static readonly FieldCodec<RogueResOpData> _repeated_updates_codec = FieldCodec.ForMessage<RogueResOpData>(34U, RogueResOpData.Parser);

		// Token: 0x04008330 RID: 33584
		private readonly RepeatedField<RogueResOpData> updates_ = new RepeatedField<RogueResOpData>();

		// Token: 0x04008331 RID: 33585
		public const int RemovesFieldNumber = 9;

		// Token: 0x04008332 RID: 33586
		private static readonly FieldCodec<int> _repeated_removes_codec = FieldCodec.ForInt32(74U);

		// Token: 0x04008333 RID: 33587
		private readonly RepeatedField<int> removes_ = new RepeatedField<int>();
	}
}
