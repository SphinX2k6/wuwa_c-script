using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000526 RID: 1318
	[NetMessage(EMessageId.FarmGoldPointRepeatedRequest)]
	public sealed class FarmGoldPointRepeatedRequest : IMessage<FarmGoldPointRepeatedRequest>, IMessage, IEquatable<FarmGoldPointRepeatedRequest>, IDeepCloneable<FarmGoldPointRepeatedRequest>, IBufferMessage
	{
		// Token: 0x06007BA6 RID: 31654 RVA: 0x0012BE00 File Offset: 0x0012A000
		[NullableContext(1)]
		public static FarmGoldPointRepeatedRequest Create()
		{
			return new FarmGoldPointRepeatedRequest();
		}

		// Token: 0x170017FD RID: 6141
		// (get) Token: 0x06007BA7 RID: 31655 RVA: 0x0012BE07 File Offset: 0x0012A007
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170017FE RID: 6142
		// (get) Token: 0x06007BA8 RID: 31656 RVA: 0x0012BE0A File Offset: 0x0012A00A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FarmGoldPointRepeatedRequest.Descriptor;
			}
		}

		// Token: 0x06007BA9 RID: 31657 RVA: 0x0012BE11 File Offset: 0x0012A011
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldPointRepeatedRequest()
		{
		}

		// Token: 0x06007BAA RID: 31658 RVA: 0x0012BE24 File Offset: 0x0012A024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldPointRepeatedRequest(FarmGoldPointRepeatedRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.ids_ = other.ids_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007BAB RID: 31659 RVA: 0x0012BE5A File Offset: 0x0012A05A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldPointRepeatedRequest Clone()
		{
			return new FarmGoldPointRepeatedRequest(this);
		}

		// Token: 0x170017FF RID: 6143
		// (get) Token: 0x06007BAC RID: 31660 RVA: 0x0012BE62 File Offset: 0x0012A062
		// (set) Token: 0x06007BAD RID: 31661 RVA: 0x0012BE6A File Offset: 0x0012A06A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x17001800 RID: 6144
		// (get) Token: 0x06007BAE RID: 31662 RVA: 0x0012BE73 File Offset: 0x0012A073
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Ids
		{
			get
			{
				return this.ids_;
			}
		}

		// Token: 0x06007BAF RID: 31663 RVA: 0x0012BE7B File Offset: 0x0012A07B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FarmGoldPointRepeatedRequest);
		}

		// Token: 0x06007BB0 RID: 31664 RVA: 0x0012BE8C File Offset: 0x0012A08C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FarmGoldPointRepeatedRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.ids_.Equals(other.ids_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007BB1 RID: 31665 RVA: 0x0012BEDC File Offset: 0x0012A0DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.ids_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007BB2 RID: 31666 RVA: 0x0012BF29 File Offset: 0x0012A129
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007BB3 RID: 31667 RVA: 0x0012BF36 File Offset: 0x0012A136
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007BB4 RID: 31668 RVA: 0x0012BF40 File Offset: 0x0012A140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.ActivityId);
			}
			this.ids_.WriteTo(ref output, FarmGoldPointRepeatedRequest._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007BB5 RID: 31669 RVA: 0x0012BF90 File Offset: 0x0012A190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.ids_.CalculateSize(FarmGoldPointRepeatedRequest._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007BB6 RID: 31670 RVA: 0x0012BFE4 File Offset: 0x0012A1E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FarmGoldPointRepeatedRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.ids_.Add(other.ids_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007BB7 RID: 31671 RVA: 0x0012C031 File Offset: 0x0012A231
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007BB8 RID: 31672 RVA: 0x0012C03C File Offset: 0x0012A23C
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
				if (num != 48U)
				{
					if (num != 96U && num != 98U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ids_.AddEntriesFrom(ref input, FarmGoldPointRepeatedRequest._repeated_ids_codec);
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003F3B RID: 16187
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F3C RID: 16188
		public const int ActivityIdFieldNumber = 6;

		// Token: 0x04003F3D RID: 16189
		private int activityId_;

		// Token: 0x04003F3E RID: 16190
		public const int IdsFieldNumber = 12;

		// Token: 0x04003F3F RID: 16191
		private static readonly FieldCodec<int> _repeated_ids_codec = FieldCodec.ForInt32(98U);

		// Token: 0x04003F40 RID: 16192
		private readonly RepeatedField<int> ids_ = new RepeatedField<int>();
	}
}
