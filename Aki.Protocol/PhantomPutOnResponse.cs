using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CF5 RID: 3317
	[NetMessage(EMessageId.PhantomPutOnResponse)]
	public sealed class PhantomPutOnResponse : IMessage<PhantomPutOnResponse>, IMessage, IEquatable<PhantomPutOnResponse>, IDeepCloneable<PhantomPutOnResponse>, IBufferMessage
	{
		// Token: 0x06011EFC RID: 73468 RVA: 0x0029F7A3 File Offset: 0x0029D9A3
		[NullableContext(1)]
		public static PhantomPutOnResponse Create()
		{
			return new PhantomPutOnResponse();
		}

		// Token: 0x17003B6F RID: 15215
		// (get) Token: 0x06011EFD RID: 73469 RVA: 0x0029F7AA File Offset: 0x0029D9AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003B70 RID: 15216
		// (get) Token: 0x06011EFE RID: 73470 RVA: 0x0029F7AD File Offset: 0x0029D9AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomPutOnResponse.Descriptor;
			}
		}

		// Token: 0x06011EFF RID: 73471 RVA: 0x0029F7B4 File Offset: 0x0029D9B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomPutOnResponse()
		{
		}

		// Token: 0x06011F00 RID: 73472 RVA: 0x0029F7E0 File Offset: 0x0029D9E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomPutOnResponse(PhantomPutOnResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.equipInfoList_ = other.equipInfoList_.Clone();
			this.stackSplitInfos_ = other.stackSplitInfos_.Clone();
			this.stackMergeInfos_ = other.stackMergeInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011F01 RID: 73473 RVA: 0x0029F843 File Offset: 0x0029DA43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomPutOnResponse Clone()
		{
			return new PhantomPutOnResponse(this);
		}

		// Token: 0x17003B71 RID: 15217
		// (get) Token: 0x06011F02 RID: 73474 RVA: 0x0029F84B File Offset: 0x0029DA4B
		// (set) Token: 0x06011F03 RID: 73475 RVA: 0x0029F853 File Offset: 0x0029DA53
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

		// Token: 0x17003B72 RID: 15218
		// (get) Token: 0x06011F04 RID: 73476 RVA: 0x0029F85C File Offset: 0x0029DA5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RolePhantomEquipInfo> EquipInfoList
		{
			get
			{
				return this.equipInfoList_;
			}
		}

		// Token: 0x17003B73 RID: 15219
		// (get) Token: 0x06011F05 RID: 73477 RVA: 0x0029F864 File Offset: 0x0029DA64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomStackSplitInfo> StackSplitInfos
		{
			get
			{
				return this.stackSplitInfos_;
			}
		}

		// Token: 0x17003B74 RID: 15220
		// (get) Token: 0x06011F06 RID: 73478 RVA: 0x0029F86C File Offset: 0x0029DA6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomStackMergeInfo> StackMergeInfos
		{
			get
			{
				return this.stackMergeInfos_;
			}
		}

		// Token: 0x06011F07 RID: 73479 RVA: 0x0029F874 File Offset: 0x0029DA74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomPutOnResponse);
		}

		// Token: 0x06011F08 RID: 73480 RVA: 0x0029F884 File Offset: 0x0029DA84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomPutOnResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.equipInfoList_.Equals(other.equipInfoList_) && this.stackSplitInfos_.Equals(other.stackSplitInfos_) && this.stackMergeInfos_.Equals(other.stackMergeInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011F09 RID: 73481 RVA: 0x0029F8FC File Offset: 0x0029DAFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.equipInfoList_.GetHashCode();
			num ^= this.stackSplitInfos_.GetHashCode();
			num ^= this.stackMergeInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011F0A RID: 73482 RVA: 0x0029F96B File Offset: 0x0029DB6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011F0B RID: 73483 RVA: 0x0029F978 File Offset: 0x0029DB78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011F0C RID: 73484 RVA: 0x0029F984 File Offset: 0x0029DB84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.stackSplitInfos_.WriteTo(ref output, PhantomPutOnResponse._repeated_stackSplitInfos_codec);
			this.stackMergeInfos_.WriteTo(ref output, PhantomPutOnResponse._repeated_stackMergeInfos_codec);
			this.equipInfoList_.WriteTo(ref output, PhantomPutOnResponse._repeated_equipInfoList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011F0D RID: 73485 RVA: 0x0029F9F4 File Offset: 0x0029DBF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.equipInfoList_.CalculateSize(PhantomPutOnResponse._repeated_equipInfoList_codec);
			num += this.stackSplitInfos_.CalculateSize(PhantomPutOnResponse._repeated_stackSplitInfos_codec);
			num += this.stackMergeInfos_.CalculateSize(PhantomPutOnResponse._repeated_stackMergeInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011F0E RID: 73486 RVA: 0x0029FA6C File Offset: 0x0029DC6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomPutOnResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.equipInfoList_.Add(other.equipInfoList_);
			this.stackSplitInfos_.Add(other.stackSplitInfos_);
			this.stackMergeInfos_.Add(other.stackMergeInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011F0F RID: 73487 RVA: 0x0029FADB File Offset: 0x0029DCDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011F10 RID: 73488 RVA: 0x0029FAE4 File Offset: 0x0029DCE4
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
				if (num <= 58U)
				{
					if (num == 8U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 58U)
					{
						this.stackSplitInfos_.AddEntriesFrom(ref input, PhantomPutOnResponse._repeated_stackSplitInfos_codec);
						continue;
					}
				}
				else
				{
					if (num == 90U)
					{
						this.stackMergeInfos_.AddEntriesFrom(ref input, PhantomPutOnResponse._repeated_stackMergeInfos_codec);
						continue;
					}
					if (num == 98U)
					{
						this.equipInfoList_.AddEntriesFrom(ref input, PhantomPutOnResponse._repeated_equipInfoList_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007073 RID: 28787
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007074 RID: 28788
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x04007075 RID: 28789
		private ErrorCode errorCode_;

		// Token: 0x04007076 RID: 28790
		public const int EquipInfoListFieldNumber = 12;

		// Token: 0x04007077 RID: 28791
		private static readonly FieldCodec<RolePhantomEquipInfo> _repeated_equipInfoList_codec = FieldCodec.ForMessage<RolePhantomEquipInfo>(98U, RolePhantomEquipInfo.Parser);

		// Token: 0x04007078 RID: 28792
		private readonly RepeatedField<RolePhantomEquipInfo> equipInfoList_ = new RepeatedField<RolePhantomEquipInfo>();

		// Token: 0x04007079 RID: 28793
		public const int StackSplitInfosFieldNumber = 7;

		// Token: 0x0400707A RID: 28794
		private static readonly FieldCodec<PhantomStackSplitInfo> _repeated_stackSplitInfos_codec = FieldCodec.ForMessage<PhantomStackSplitInfo>(58U, PhantomStackSplitInfo.Parser);

		// Token: 0x0400707B RID: 28795
		private readonly RepeatedField<PhantomStackSplitInfo> stackSplitInfos_ = new RepeatedField<PhantomStackSplitInfo>();

		// Token: 0x0400707C RID: 28796
		public const int StackMergeInfosFieldNumber = 11;

		// Token: 0x0400707D RID: 28797
		private static readonly FieldCodec<PhantomStackMergeInfo> _repeated_stackMergeInfos_codec = FieldCodec.ForMessage<PhantomStackMergeInfo>(90U, PhantomStackMergeInfo.Parser);

		// Token: 0x0400707E RID: 28798
		private readonly RepeatedField<PhantomStackMergeInfo> stackMergeInfos_ = new RepeatedField<PhantomStackMergeInfo>();
	}
}
