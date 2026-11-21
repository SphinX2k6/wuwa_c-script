using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C0B RID: 3083
	[NetMessage(EMessageId.PhantomAutoPutResponse)]
	public sealed class PhantomAutoPutResponse : IMessage<PhantomAutoPutResponse>, IMessage, IEquatable<PhantomAutoPutResponse>, IDeepCloneable<PhantomAutoPutResponse>, IBufferMessage
	{
		// Token: 0x06010C23 RID: 68643 RVA: 0x00274C58 File Offset: 0x00272E58
		[NullableContext(1)]
		public static PhantomAutoPutResponse Create()
		{
			return new PhantomAutoPutResponse();
		}

		// Token: 0x1700374F RID: 14159
		// (get) Token: 0x06010C24 RID: 68644 RVA: 0x00274C5F File Offset: 0x00272E5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003750 RID: 14160
		// (get) Token: 0x06010C25 RID: 68645 RVA: 0x00274C62 File Offset: 0x00272E62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomAutoPutResponse.Descriptor;
			}
		}

		// Token: 0x06010C26 RID: 68646 RVA: 0x00274C69 File Offset: 0x00272E69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomAutoPutResponse()
		{
		}

		// Token: 0x06010C27 RID: 68647 RVA: 0x00274C94 File Offset: 0x00272E94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomAutoPutResponse(PhantomAutoPutResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.equipInfoList_ = other.equipInfoList_.Clone();
			this.stackSplitInfos_ = other.stackSplitInfos_.Clone();
			this.stackMergeInfos_ = other.stackMergeInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010C28 RID: 68648 RVA: 0x00274CF7 File Offset: 0x00272EF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomAutoPutResponse Clone()
		{
			return new PhantomAutoPutResponse(this);
		}

		// Token: 0x17003751 RID: 14161
		// (get) Token: 0x06010C29 RID: 68649 RVA: 0x00274CFF File Offset: 0x00272EFF
		// (set) Token: 0x06010C2A RID: 68650 RVA: 0x00274D07 File Offset: 0x00272F07
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

		// Token: 0x17003752 RID: 14162
		// (get) Token: 0x06010C2B RID: 68651 RVA: 0x00274D10 File Offset: 0x00272F10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RolePhantomEquipInfo> EquipInfoList
		{
			get
			{
				return this.equipInfoList_;
			}
		}

		// Token: 0x17003753 RID: 14163
		// (get) Token: 0x06010C2C RID: 68652 RVA: 0x00274D18 File Offset: 0x00272F18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomStackSplitInfo> StackSplitInfos
		{
			get
			{
				return this.stackSplitInfos_;
			}
		}

		// Token: 0x17003754 RID: 14164
		// (get) Token: 0x06010C2D RID: 68653 RVA: 0x00274D20 File Offset: 0x00272F20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomStackMergeInfo> StackMergeInfos
		{
			get
			{
				return this.stackMergeInfos_;
			}
		}

		// Token: 0x06010C2E RID: 68654 RVA: 0x00274D28 File Offset: 0x00272F28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomAutoPutResponse);
		}

		// Token: 0x06010C2F RID: 68655 RVA: 0x00274D38 File Offset: 0x00272F38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomAutoPutResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.equipInfoList_.Equals(other.equipInfoList_) && this.stackSplitInfos_.Equals(other.stackSplitInfos_) && this.stackMergeInfos_.Equals(other.stackMergeInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010C30 RID: 68656 RVA: 0x00274DB0 File Offset: 0x00272FB0
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

		// Token: 0x06010C31 RID: 68657 RVA: 0x00274E1F File Offset: 0x0027301F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010C32 RID: 68658 RVA: 0x00274E2C File Offset: 0x0027302C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010C33 RID: 68659 RVA: 0x00274E38 File Offset: 0x00273038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.stackMergeInfos_.WriteTo(ref output, PhantomAutoPutResponse._repeated_stackMergeInfos_codec);
			this.equipInfoList_.WriteTo(ref output, PhantomAutoPutResponse._repeated_equipInfoList_codec);
			this.stackSplitInfos_.WriteTo(ref output, PhantomAutoPutResponse._repeated_stackSplitInfos_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010C34 RID: 68660 RVA: 0x00274EA8 File Offset: 0x002730A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.equipInfoList_.CalculateSize(PhantomAutoPutResponse._repeated_equipInfoList_codec);
			num += this.stackSplitInfos_.CalculateSize(PhantomAutoPutResponse._repeated_stackSplitInfos_codec);
			num += this.stackMergeInfos_.CalculateSize(PhantomAutoPutResponse._repeated_stackMergeInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010C35 RID: 68661 RVA: 0x00274F20 File Offset: 0x00273120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomAutoPutResponse other)
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

		// Token: 0x06010C36 RID: 68662 RVA: 0x00274F8F File Offset: 0x0027318F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010C37 RID: 68663 RVA: 0x00274F98 File Offset: 0x00273198
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
					if (num == 26U)
					{
						this.stackMergeInfos_.AddEntriesFrom(ref input, PhantomAutoPutResponse._repeated_stackMergeInfos_codec);
						continue;
					}
					if (num == 42U)
					{
						this.equipInfoList_.AddEntriesFrom(ref input, PhantomAutoPutResponse._repeated_equipInfoList_codec);
						continue;
					}
				}
				else
				{
					if (num == 90U)
					{
						this.stackSplitInfos_.AddEntriesFrom(ref input, PhantomAutoPutResponse._repeated_stackSplitInfos_codec);
						continue;
					}
					if (num == 112U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006ADD RID: 27357
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006ADE RID: 27358
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04006ADF RID: 27359
		private ErrorCode errorCode_;

		// Token: 0x04006AE0 RID: 27360
		public const int EquipInfoListFieldNumber = 5;

		// Token: 0x04006AE1 RID: 27361
		private static readonly FieldCodec<RolePhantomEquipInfo> _repeated_equipInfoList_codec = FieldCodec.ForMessage<RolePhantomEquipInfo>(42U, RolePhantomEquipInfo.Parser);

		// Token: 0x04006AE2 RID: 27362
		private readonly RepeatedField<RolePhantomEquipInfo> equipInfoList_ = new RepeatedField<RolePhantomEquipInfo>();

		// Token: 0x04006AE3 RID: 27363
		public const int StackSplitInfosFieldNumber = 11;

		// Token: 0x04006AE4 RID: 27364
		private static readonly FieldCodec<PhantomStackSplitInfo> _repeated_stackSplitInfos_codec = FieldCodec.ForMessage<PhantomStackSplitInfo>(90U, PhantomStackSplitInfo.Parser);

		// Token: 0x04006AE5 RID: 27365
		private readonly RepeatedField<PhantomStackSplitInfo> stackSplitInfos_ = new RepeatedField<PhantomStackSplitInfo>();

		// Token: 0x04006AE6 RID: 27366
		public const int StackMergeInfosFieldNumber = 3;

		// Token: 0x04006AE7 RID: 27367
		private static readonly FieldCodec<PhantomStackMergeInfo> _repeated_stackMergeInfos_codec = FieldCodec.ForMessage<PhantomStackMergeInfo>(26U, PhantomStackMergeInfo.Parser);

		// Token: 0x04006AE8 RID: 27368
		private readonly RepeatedField<PhantomStackMergeInfo> stackMergeInfos_ = new RepeatedField<PhantomStackMergeInfo>();
	}
}
