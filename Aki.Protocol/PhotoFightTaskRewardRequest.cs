using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D20 RID: 3360
	[NetMessage(EMessageId.PhotoFightTaskRewardRequest)]
	public sealed class PhotoFightTaskRewardRequest : IMessage<PhotoFightTaskRewardRequest>, IMessage, IEquatable<PhotoFightTaskRewardRequest>, IDeepCloneable<PhotoFightTaskRewardRequest>, IBufferMessage
	{
		// Token: 0x060122AC RID: 74412 RVA: 0x002A7BD6 File Offset: 0x002A5DD6
		[NullableContext(1)]
		public static PhotoFightTaskRewardRequest Create()
		{
			return new PhotoFightTaskRewardRequest();
		}

		// Token: 0x17003C35 RID: 15413
		// (get) Token: 0x060122AD RID: 74413 RVA: 0x002A7BDD File Offset: 0x002A5DDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003C36 RID: 15414
		// (get) Token: 0x060122AE RID: 74414 RVA: 0x002A7BE0 File Offset: 0x002A5DE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhotoFightTaskRewardRequest.Descriptor;
			}
		}

		// Token: 0x060122AF RID: 74415 RVA: 0x002A7BE7 File Offset: 0x002A5DE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoFightTaskRewardRequest()
		{
		}

		// Token: 0x060122B0 RID: 74416 RVA: 0x002A7BFA File Offset: 0x002A5DFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoFightTaskRewardRequest(PhotoFightTaskRewardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.targetIds_ = other.targetIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060122B1 RID: 74417 RVA: 0x002A7C30 File Offset: 0x002A5E30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoFightTaskRewardRequest Clone()
		{
			return new PhotoFightTaskRewardRequest(this);
		}

		// Token: 0x17003C37 RID: 15415
		// (get) Token: 0x060122B2 RID: 74418 RVA: 0x002A7C38 File Offset: 0x002A5E38
		// (set) Token: 0x060122B3 RID: 74419 RVA: 0x002A7C40 File Offset: 0x002A5E40
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

		// Token: 0x17003C38 RID: 15416
		// (get) Token: 0x060122B4 RID: 74420 RVA: 0x002A7C49 File Offset: 0x002A5E49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TargetIds
		{
			get
			{
				return this.targetIds_;
			}
		}

		// Token: 0x060122B5 RID: 74421 RVA: 0x002A7C51 File Offset: 0x002A5E51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhotoFightTaskRewardRequest);
		}

		// Token: 0x060122B6 RID: 74422 RVA: 0x002A7C60 File Offset: 0x002A5E60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhotoFightTaskRewardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.targetIds_.Equals(other.targetIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060122B7 RID: 74423 RVA: 0x002A7CB0 File Offset: 0x002A5EB0
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

		// Token: 0x060122B8 RID: 74424 RVA: 0x002A7CFD File Offset: 0x002A5EFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060122B9 RID: 74425 RVA: 0x002A7D0A File Offset: 0x002A5F0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060122BA RID: 74426 RVA: 0x002A7D14 File Offset: 0x002A5F14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.targetIds_.WriteTo(ref output, PhotoFightTaskRewardRequest._repeated_targetIds_codec);
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060122BB RID: 74427 RVA: 0x002A7D64 File Offset: 0x002A5F64
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

		// Token: 0x060122BC RID: 74428 RVA: 0x002A7DB8 File Offset: 0x002A5FB8
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

		// Token: 0x060122BD RID: 74429 RVA: 0x002A7E05 File Offset: 0x002A6005
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060122BE RID: 74430 RVA: 0x002A7E10 File Offset: 0x002A6010
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
				if (num != 8U && num != 10U)
				{
					if (num != 80U)
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

		// Token: 0x040071E7 RID: 29159
		private UnknownFieldSet _unknownFields;

		// Token: 0x040071E8 RID: 29160
		public const int ActivityIdFieldNumber = 10;

		// Token: 0x040071E9 RID: 29161
		private int activityId_;

		// Token: 0x040071EA RID: 29162
		public const int TargetIdsFieldNumber = 1;

		// Token: 0x040071EB RID: 29163
		private static readonly FieldCodec<int> _repeated_targetIds_codec = FieldCodec.ForInt32(10U);

		// Token: 0x040071EC RID: 29164
		private readonly RepeatedField<int> targetIds_ = new RepeatedField<int>();
	}
}
