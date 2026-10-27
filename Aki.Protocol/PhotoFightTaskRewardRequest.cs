using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D30 RID: 3376
	[NetMessage(EMessageId.PhotoFightTaskRewardRequest)]
	public sealed class PhotoFightTaskRewardRequest : IMessage<PhotoFightTaskRewardRequest>, IMessage, IEquatable<PhotoFightTaskRewardRequest>, IDeepCloneable<PhotoFightTaskRewardRequest>, IBufferMessage
	{
		// Token: 0x060123A8 RID: 74664 RVA: 0x002A97FA File Offset: 0x002A79FA
		[NullableContext(1)]
		public static PhotoFightTaskRewardRequest Create()
		{
			return new PhotoFightTaskRewardRequest();
		}

		// Token: 0x17003C6A RID: 15466
		// (get) Token: 0x060123A9 RID: 74665 RVA: 0x002A9801 File Offset: 0x002A7A01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003C6B RID: 15467
		// (get) Token: 0x060123AA RID: 74666 RVA: 0x002A9804 File Offset: 0x002A7A04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhotoFightTaskRewardRequest.Descriptor;
			}
		}

		// Token: 0x060123AB RID: 74667 RVA: 0x002A980B File Offset: 0x002A7A0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoFightTaskRewardRequest()
		{
		}

		// Token: 0x060123AC RID: 74668 RVA: 0x002A981E File Offset: 0x002A7A1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoFightTaskRewardRequest(PhotoFightTaskRewardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.targetIds_ = other.targetIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060123AD RID: 74669 RVA: 0x002A9854 File Offset: 0x002A7A54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoFightTaskRewardRequest Clone()
		{
			return new PhotoFightTaskRewardRequest(this);
		}

		// Token: 0x17003C6C RID: 15468
		// (get) Token: 0x060123AE RID: 74670 RVA: 0x002A985C File Offset: 0x002A7A5C
		// (set) Token: 0x060123AF RID: 74671 RVA: 0x002A9864 File Offset: 0x002A7A64
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

		// Token: 0x17003C6D RID: 15469
		// (get) Token: 0x060123B0 RID: 74672 RVA: 0x002A986D File Offset: 0x002A7A6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TargetIds
		{
			get
			{
				return this.targetIds_;
			}
		}

		// Token: 0x060123B1 RID: 74673 RVA: 0x002A9875 File Offset: 0x002A7A75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhotoFightTaskRewardRequest);
		}

		// Token: 0x060123B2 RID: 74674 RVA: 0x002A9884 File Offset: 0x002A7A84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhotoFightTaskRewardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.targetIds_.Equals(other.targetIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060123B3 RID: 74675 RVA: 0x002A98D4 File Offset: 0x002A7AD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.targetIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060123B4 RID: 74676 RVA: 0x002A9921 File Offset: 0x002A7B21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060123B5 RID: 74677 RVA: 0x002A992E File Offset: 0x002A7B2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060123B6 RID: 74678 RVA: 0x002A9938 File Offset: 0x002A7B38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.targetIds_.WriteTo(ref output, PhotoFightTaskRewardRequest._repeated_targetIds_codec);
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060123B7 RID: 74679 RVA: 0x002A9988 File Offset: 0x002A7B88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.targetIds_.CalculateSize(PhotoFightTaskRewardRequest._repeated_targetIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060123B8 RID: 74680 RVA: 0x002A99DC File Offset: 0x002A7BDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhotoFightTaskRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.targetIds_.Add(other.targetIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060123B9 RID: 74681 RVA: 0x002A9A29 File Offset: 0x002A7C29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060123BA RID: 74682 RVA: 0x002A9A34 File Offset: 0x002A7C34
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
				if (num != 80U && num != 82U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ActivityId = input.ReadInt32();
					}
				}
				else
				{
					this.targetIds_.AddEntriesFrom(ref input, PhotoFightTaskRewardRequest._repeated_targetIds_codec);
				}
			}
		}

		// Token: 0x040071CF RID: 29135
		private UnknownFieldSet _unknownFields;

		// Token: 0x040071D0 RID: 29136
		public const int ActivityIdFieldNumber = 11;

		// Token: 0x040071D1 RID: 29137
		private int activityId_;

		// Token: 0x040071D2 RID: 29138
		public const int TargetIdsFieldNumber = 10;

		// Token: 0x040071D3 RID: 29139
		private static readonly FieldCodec<int> _repeated_targetIds_codec = FieldCodec.ForInt32(82U);

		// Token: 0x040071D4 RID: 29140
		private readonly RepeatedField<int> targetIds_ = new RepeatedField<int>();
	}
}
