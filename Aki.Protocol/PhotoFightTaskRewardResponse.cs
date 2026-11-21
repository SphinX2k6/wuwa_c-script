using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D21 RID: 3361
	[NetMessage(EMessageId.PhotoFightTaskRewardResponse)]
	public sealed class PhotoFightTaskRewardResponse : IMessage<PhotoFightTaskRewardResponse>, IMessage, IEquatable<PhotoFightTaskRewardResponse>, IDeepCloneable<PhotoFightTaskRewardResponse>, IBufferMessage
	{
		// Token: 0x060122C0 RID: 74432 RVA: 0x002A7E7F File Offset: 0x002A607F
		[NullableContext(1)]
		public static PhotoFightTaskRewardResponse Create()
		{
			return new PhotoFightTaskRewardResponse();
		}

		// Token: 0x17003C39 RID: 15417
		// (get) Token: 0x060122C1 RID: 74433 RVA: 0x002A7E86 File Offset: 0x002A6086
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003C3A RID: 15418
		// (get) Token: 0x060122C2 RID: 74434 RVA: 0x002A7E89 File Offset: 0x002A6089
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhotoFightTaskRewardResponse.Descriptor;
			}
		}

		// Token: 0x060122C3 RID: 74435 RVA: 0x002A7E90 File Offset: 0x002A6090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoFightTaskRewardResponse()
		{
		}

		// Token: 0x060122C4 RID: 74436 RVA: 0x002A7EA3 File Offset: 0x002A60A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoFightTaskRewardResponse(PhotoFightTaskRewardResponse other) : this()
		{
			this.targets_ = other.targets_.Clone();
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060122C5 RID: 74437 RVA: 0x002A7ED9 File Offset: 0x002A60D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoFightTaskRewardResponse Clone()
		{
			return new PhotoFightTaskRewardResponse(this);
		}

		// Token: 0x17003C3B RID: 15419
		// (get) Token: 0x060122C6 RID: 74438 RVA: 0x002A7EE1 File Offset: 0x002A60E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhotoFightTargetPb> Targets
		{
			get
			{
				return this.targets_;
			}
		}

		// Token: 0x17003C3C RID: 15420
		// (get) Token: 0x060122C7 RID: 74439 RVA: 0x002A7EE9 File Offset: 0x002A60E9
		// (set) Token: 0x060122C8 RID: 74440 RVA: 0x002A7EF1 File Offset: 0x002A60F1
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

		// Token: 0x060122C9 RID: 74441 RVA: 0x002A7EFA File Offset: 0x002A60FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhotoFightTaskRewardResponse);
		}

		// Token: 0x060122CA RID: 74442 RVA: 0x002A7F08 File Offset: 0x002A6108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhotoFightTaskRewardResponse other)
		{
			return other != null && (other == this || (this.targets_.Equals(other.targets_) && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060122CB RID: 74443 RVA: 0x002A7F58 File Offset: 0x002A6158
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

		// Token: 0x060122CC RID: 74444 RVA: 0x002A7FAB File Offset: 0x002A61AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060122CD RID: 74445 RVA: 0x002A7FB8 File Offset: 0x002A61B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060122CE RID: 74446 RVA: 0x002A7FC4 File Offset: 0x002A61C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.targets_.WriteTo(ref output, PhotoFightTaskRewardResponse._repeated_targets_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060122CF RID: 74447 RVA: 0x002A8014 File Offset: 0x002A6214
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

		// Token: 0x060122D0 RID: 74448 RVA: 0x002A8068 File Offset: 0x002A6268
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

		// Token: 0x060122D1 RID: 74449 RVA: 0x002A80B5 File Offset: 0x002A62B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060122D2 RID: 74450 RVA: 0x002A80C0 File Offset: 0x002A62C0
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
				if (num != 42U)
				{
					if (num != 96U)
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

		// Token: 0x040071ED RID: 29165
		private UnknownFieldSet _unknownFields;

		// Token: 0x040071EE RID: 29166
		public const int TargetsFieldNumber = 5;

		// Token: 0x040071EF RID: 29167
		private static readonly FieldCodec<PhotoFightTargetPb> _repeated_targets_codec = FieldCodec.ForMessage<PhotoFightTargetPb>(42U, PhotoFightTargetPb.Parser);

		// Token: 0x040071F0 RID: 29168
		private readonly RepeatedField<PhotoFightTargetPb> targets_ = new RepeatedField<PhotoFightTargetPb>();

		// Token: 0x040071F1 RID: 29169
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x040071F2 RID: 29170
		private ErrorCode errorCode_;
	}
}
