using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C1B RID: 3099
	[NetMessage(EMessageId.PhantomAutoPutResponse)]
	public sealed class PhantomAutoPutResponse : IMessage<PhantomAutoPutResponse>, IMessage, IEquatable<PhantomAutoPutResponse>, IDeepCloneable<PhantomAutoPutResponse>, IBufferMessage
	{
		// Token: 0x06010D23 RID: 68899 RVA: 0x002769BC File Offset: 0x00274BBC
		[NullableContext(1)]
		public static PhantomAutoPutResponse Create()
		{
			return new PhantomAutoPutResponse();
		}

		// Token: 0x17003786 RID: 14214
		// (get) Token: 0x06010D24 RID: 68900 RVA: 0x002769C3 File Offset: 0x00274BC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003787 RID: 14215
		// (get) Token: 0x06010D25 RID: 68901 RVA: 0x002769C6 File Offset: 0x00274BC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomAutoPutResponse.Descriptor;
			}
		}

		// Token: 0x06010D26 RID: 68902 RVA: 0x002769CD File Offset: 0x00274BCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomAutoPutResponse()
		{
		}

		// Token: 0x06010D27 RID: 68903 RVA: 0x002769F8 File Offset: 0x00274BF8
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

		// Token: 0x06010D28 RID: 68904 RVA: 0x00276A5B File Offset: 0x00274C5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomAutoPutResponse Clone()
		{
			return new PhantomAutoPutResponse(this);
		}

		// Token: 0x17003788 RID: 14216
		// (get) Token: 0x06010D29 RID: 68905 RVA: 0x00276A63 File Offset: 0x00274C63
		// (set) Token: 0x06010D2A RID: 68906 RVA: 0x00276A6B File Offset: 0x00274C6B
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

		// Token: 0x17003789 RID: 14217
		// (get) Token: 0x06010D2B RID: 68907 RVA: 0x00276A74 File Offset: 0x00274C74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RolePhantomEquipInfo> EquipInfoList
		{
			get
			{
				return this.equipInfoList_;
			}
		}

		// Token: 0x1700378A RID: 14218
		// (get) Token: 0x06010D2C RID: 68908 RVA: 0x00276A7C File Offset: 0x00274C7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomStackSplitInfo> StackSplitInfos
		{
			get
			{
				return this.stackSplitInfos_;
			}
		}

		// Token: 0x1700378B RID: 14219
		// (get) Token: 0x06010D2D RID: 68909 RVA: 0x00276A84 File Offset: 0x00274C84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomStackMergeInfo> StackMergeInfos
		{
			get
			{
				return this.stackMergeInfos_;
			}
		}

		// Token: 0x06010D2E RID: 68910 RVA: 0x00276A8C File Offset: 0x00274C8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomAutoPutResponse);
		}

		// Token: 0x06010D2F RID: 68911 RVA: 0x00276A9C File Offset: 0x00274C9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomAutoPutResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.equipInfoList_.Equals(other.equipInfoList_) && this.stackSplitInfos_.Equals(other.stackSplitInfos_) && this.stackMergeInfos_.Equals(other.stackMergeInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010D30 RID: 68912 RVA: 0x00276B14 File Offset: 0x00274D14
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

		// Token: 0x06010D31 RID: 68913 RVA: 0x00276B83 File Offset: 0x00274D83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010D32 RID: 68914 RVA: 0x00276B90 File Offset: 0x00274D90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010D33 RID: 68915 RVA: 0x00276B9C File Offset: 0x00274D9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.equipInfoList_.WriteTo(ref output, PhantomAutoPutResponse._repeated_equipInfoList_codec);
			this.stackMergeInfos_.WriteTo(ref output, PhantomAutoPutResponse._repeated_stackMergeInfos_codec);
			this.stackSplitInfos_.WriteTo(ref output, PhantomAutoPutResponse._repeated_stackSplitInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010D34 RID: 68916 RVA: 0x00276C0C File Offset: 0x00274E0C
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

		// Token: 0x06010D35 RID: 68917 RVA: 0x00276C84 File Offset: 0x00274E84
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

		// Token: 0x06010D36 RID: 68918 RVA: 0x00276CF3 File Offset: 0x00274EF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010D37 RID: 68919 RVA: 0x00276CFC File Offset: 0x00274EFC
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
				if (num <= 34U)
				{
					if (num == 24U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 34U)
					{
						this.equipInfoList_.AddEntriesFrom(ref input, PhantomAutoPutResponse._repeated_equipInfoList_codec);
						continue;
					}
				}
				else
				{
					if (num == 42U)
					{
						this.stackMergeInfos_.AddEntriesFrom(ref input, PhantomAutoPutResponse._repeated_stackMergeInfos_codec);
						continue;
					}
					if (num == 122U)
					{
						this.stackSplitInfos_.AddEntriesFrom(ref input, PhantomAutoPutResponse._repeated_stackSplitInfos_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006AC9 RID: 27337
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006ACA RID: 27338
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x04006ACB RID: 27339
		private ErrorCode errorCode_;

		// Token: 0x04006ACC RID: 27340
		public const int EquipInfoListFieldNumber = 4;

		// Token: 0x04006ACD RID: 27341
		private static readonly FieldCodec<RolePhantomEquipInfo> _repeated_equipInfoList_codec = FieldCodec.ForMessage<RolePhantomEquipInfo>(34U, RolePhantomEquipInfo.Parser);

		// Token: 0x04006ACE RID: 27342
		private readonly RepeatedField<RolePhantomEquipInfo> equipInfoList_ = new RepeatedField<RolePhantomEquipInfo>();

		// Token: 0x04006ACF RID: 27343
		public const int StackSplitInfosFieldNumber = 15;

		// Token: 0x04006AD0 RID: 27344
		private static readonly FieldCodec<PhantomStackSplitInfo> _repeated_stackSplitInfos_codec = FieldCodec.ForMessage<PhantomStackSplitInfo>(122U, PhantomStackSplitInfo.Parser);

		// Token: 0x04006AD1 RID: 27345
		private readonly RepeatedField<PhantomStackSplitInfo> stackSplitInfos_ = new RepeatedField<PhantomStackSplitInfo>();

		// Token: 0x04006AD2 RID: 27346
		public const int StackMergeInfosFieldNumber = 5;

		// Token: 0x04006AD3 RID: 27347
		private static readonly FieldCodec<PhantomStackMergeInfo> _repeated_stackMergeInfos_codec = FieldCodec.ForMessage<PhantomStackMergeInfo>(42U, PhantomStackMergeInfo.Parser);

		// Token: 0x04006AD4 RID: 27348
		private readonly RepeatedField<PhantomStackMergeInfo> stackMergeInfos_ = new RepeatedField<PhantomStackMergeInfo>();
	}
}
