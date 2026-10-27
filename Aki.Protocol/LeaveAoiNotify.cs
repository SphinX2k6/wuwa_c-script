using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008E8 RID: 2280
	[NetMessage(EMessageId.LeaveAoiNotify)]
	public sealed class LeaveAoiNotify : IMessage<LeaveAoiNotify>, IMessage, IEquatable<LeaveAoiNotify>, IDeepCloneable<LeaveAoiNotify>, IBufferMessage
	{
		// Token: 0x0600C9B4 RID: 51636 RVA: 0x001DCB72 File Offset: 0x001DAD72
		[NullableContext(1)]
		public static LeaveAoiNotify Create()
		{
			return new LeaveAoiNotify();
		}

		// Token: 0x170028BE RID: 10430
		// (get) Token: 0x0600C9B5 RID: 51637 RVA: 0x001DCB79 File Offset: 0x001DAD79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170028BF RID: 10431
		// (get) Token: 0x0600C9B6 RID: 51638 RVA: 0x001DCB7C File Offset: 0x001DAD7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LeaveAoiNotify.Descriptor;
			}
		}

		// Token: 0x0600C9B7 RID: 51639 RVA: 0x001DCB83 File Offset: 0x001DAD83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveAoiNotify()
		{
		}

		// Token: 0x0600C9B8 RID: 51640 RVA: 0x001DCB96 File Offset: 0x001DAD96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveAoiNotify(LeaveAoiNotify other) : this()
		{
			this.entityIds_ = other.entityIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C9B9 RID: 51641 RVA: 0x001DCBC0 File Offset: 0x001DADC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveAoiNotify Clone()
		{
			return new LeaveAoiNotify(this);
		}

		// Token: 0x170028C0 RID: 10432
		// (get) Token: 0x0600C9BA RID: 51642 RVA: 0x001DCBC8 File Offset: 0x001DADC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> EntityIds
		{
			get
			{
				return this.entityIds_;
			}
		}

		// Token: 0x0600C9BB RID: 51643 RVA: 0x001DCBD0 File Offset: 0x001DADD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LeaveAoiNotify);
		}

		// Token: 0x0600C9BC RID: 51644 RVA: 0x001DCBDE File Offset: 0x001DADDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LeaveAoiNotify other)
		{
			return other != null && (other == this || (this.entityIds_.Equals(other.entityIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C9BD RID: 51645 RVA: 0x001DCC14 File Offset: 0x001DAE14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.entityIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C9BE RID: 51646 RVA: 0x001DCC48 File Offset: 0x001DAE48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C9BF RID: 51647 RVA: 0x001DCC55 File Offset: 0x001DAE55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C9C0 RID: 51648 RVA: 0x001DCC5E File Offset: 0x001DAE5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.entityIds_.WriteTo(ref output, LeaveAoiNotify._repeated_entityIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C9C1 RID: 51649 RVA: 0x001DCC88 File Offset: 0x001DAE88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.entityIds_.CalculateSize(LeaveAoiNotify._repeated_entityIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C9C2 RID: 51650 RVA: 0x001DCCC1 File Offset: 0x001DAEC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LeaveAoiNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.entityIds_.Add(other.entityIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C9C3 RID: 51651 RVA: 0x001DCCEF File Offset: 0x001DAEEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C9C4 RID: 51652 RVA: 0x001DCCF8 File Offset: 0x001DAEF8
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
				if (num != 120U && num != 122U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.entityIds_.AddEntriesFrom(ref input, LeaveAoiNotify._repeated_entityIds_codec);
				}
			}
		}

		// Token: 0x04005600 RID: 22016
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005601 RID: 22017
		public const int EntityIdsFieldNumber = 15;

		// Token: 0x04005602 RID: 22018
		private static readonly FieldCodec<long> _repeated_entityIds_codec = FieldCodec.ForInt64(122U);

		// Token: 0x04005603 RID: 22019
		private readonly RepeatedField<long> entityIds_ = new RepeatedField<long>();
	}
}
