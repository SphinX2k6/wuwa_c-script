using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D31 RID: 3377
	[NetMessage(EMessageId.PhotoFightTaskRewardResponse)]
	public sealed class PhotoFightTaskRewardResponse : IMessage<PhotoFightTaskRewardResponse>, IMessage, IEquatable<PhotoFightTaskRewardResponse>, IDeepCloneable<PhotoFightTaskRewardResponse>, IBufferMessage
	{
		// Token: 0x060123BC RID: 74684 RVA: 0x002A9AA4 File Offset: 0x002A7CA4
		[NullableContext(1)]
		public static PhotoFightTaskRewardResponse Create()
		{
			return new PhotoFightTaskRewardResponse();
		}

		// Token: 0x17003C6E RID: 15470
		// (get) Token: 0x060123BD RID: 74685 RVA: 0x002A9AAB File Offset: 0x002A7CAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003C6F RID: 15471
		// (get) Token: 0x060123BE RID: 74686 RVA: 0x002A9AAE File Offset: 0x002A7CAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhotoFightTaskRewardResponse.Descriptor;
			}
		}

		// Token: 0x060123BF RID: 74687 RVA: 0x002A9AB5 File Offset: 0x002A7CB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoFightTaskRewardResponse()
		{
		}

		// Token: 0x060123C0 RID: 74688 RVA: 0x002A9AC8 File Offset: 0x002A7CC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoFightTaskRewardResponse(PhotoFightTaskRewardResponse other) : this()
		{
			this.targets_ = other.targets_.Clone();
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060123C1 RID: 74689 RVA: 0x002A9AFE File Offset: 0x002A7CFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoFightTaskRewardResponse Clone()
		{
			return new PhotoFightTaskRewardResponse(this);
		}

		// Token: 0x17003C70 RID: 15472
		// (get) Token: 0x060123C2 RID: 74690 RVA: 0x002A9B06 File Offset: 0x002A7D06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhotoFightTargetPb> Targets
		{
			get
			{
				return this.targets_;
			}
		}

		// Token: 0x17003C71 RID: 15473
		// (get) Token: 0x060123C3 RID: 74691 RVA: 0x002A9B0E File Offset: 0x002A7D0E
		// (set) Token: 0x060123C4 RID: 74692 RVA: 0x002A9B16 File Offset: 0x002A7D16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x060123C5 RID: 74693 RVA: 0x002A9B1F File Offset: 0x002A7D1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhotoFightTaskRewardResponse);
		}

		// Token: 0x060123C6 RID: 74694 RVA: 0x002A9B30 File Offset: 0x002A7D30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhotoFightTaskRewardResponse other)
		{
			return other != null && (other == this || (this.targets_.Equals(other.targets_) && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060123C7 RID: 74695 RVA: 0x002A9B80 File Offset: 0x002A7D80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.targets_.GetHashCode();
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060123C8 RID: 74696 RVA: 0x002A9BD3 File Offset: 0x002A7DD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060123C9 RID: 74697 RVA: 0x002A9BE0 File Offset: 0x002A7DE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060123CA RID: 74698 RVA: 0x002A9BEC File Offset: 0x002A7DEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.targets_.WriteTo(ref output, PhotoFightTaskRewardResponse._repeated_targets_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060123CB RID: 74699 RVA: 0x002A9C3C File Offset: 0x002A7E3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.targets_.CalculateSize(PhotoFightTaskRewardResponse._repeated_targets_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060123CC RID: 74700 RVA: 0x002A9C90 File Offset: 0x002A7E90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhotoFightTaskRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.targets_.Add(other.targets_);
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060123CD RID: 74701 RVA: 0x002A9CDD File Offset: 0x002A7EDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060123CE RID: 74702 RVA: 0x002A9CE8 File Offset: 0x002A7EE8
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
				if (num != 10U)
				{
					if (num != 56U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.targets_.AddEntriesFrom(ref input, PhotoFightTaskRewardResponse._repeated_targets_codec);
				}
			}
		}

		// Token: 0x040071D5 RID: 29141
		private UnknownFieldSet _unknownFields;

		// Token: 0x040071D6 RID: 29142
		public const int TargetsFieldNumber = 1;

		// Token: 0x040071D7 RID: 29143
		private static readonly FieldCodec<PhotoFightTargetPb> _repeated_targets_codec = FieldCodec.ForMessage<PhotoFightTargetPb>(10U, PhotoFightTargetPb.Parser);

		// Token: 0x040071D8 RID: 29144
		private readonly RepeatedField<PhotoFightTargetPb> targets_ = new RepeatedField<PhotoFightTargetPb>();

		// Token: 0x040071D9 RID: 29145
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x040071DA RID: 29146
		private ErrorCode errorCode_;
	}
}
