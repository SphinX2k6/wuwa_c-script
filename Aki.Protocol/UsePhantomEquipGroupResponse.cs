using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200152A RID: 5418
	[NetMessage(EMessageId.UsePhantomEquipGroupResponse)]
	public sealed class UsePhantomEquipGroupResponse : IMessage<UsePhantomEquipGroupResponse>, IMessage, IEquatable<UsePhantomEquipGroupResponse>, IDeepCloneable<UsePhantomEquipGroupResponse>, IBufferMessage
	{
		// Token: 0x0601CB36 RID: 117558 RVA: 0x00428A78 File Offset: 0x00426C78
		[NullableContext(1)]
		public static UsePhantomEquipGroupResponse Create()
		{
			return new UsePhantomEquipGroupResponse();
		}

		// Token: 0x17006114 RID: 24852
		// (get) Token: 0x0601CB37 RID: 117559 RVA: 0x00428A7F File Offset: 0x00426C7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006115 RID: 24853
		// (get) Token: 0x0601CB38 RID: 117560 RVA: 0x00428A82 File Offset: 0x00426C82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UsePhantomEquipGroupResponse.Descriptor;
			}
		}

		// Token: 0x0601CB39 RID: 117561 RVA: 0x00428A89 File Offset: 0x00426C89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UsePhantomEquipGroupResponse()
		{
		}

		// Token: 0x0601CB3A RID: 117562 RVA: 0x00428AB4 File Offset: 0x00426CB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UsePhantomEquipGroupResponse(UsePhantomEquipGroupResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.equipInfoList_ = other.equipInfoList_.Clone();
			this.stackSplitInfos_ = other.stackSplitInfos_.Clone();
			this.stackMergeInfos_ = other.stackMergeInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CB3B RID: 117563 RVA: 0x00428B17 File Offset: 0x00426D17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UsePhantomEquipGroupResponse Clone()
		{
			return new UsePhantomEquipGroupResponse(this);
		}

		// Token: 0x17006116 RID: 24854
		// (get) Token: 0x0601CB3C RID: 117564 RVA: 0x00428B1F File Offset: 0x00426D1F
		// (set) Token: 0x0601CB3D RID: 117565 RVA: 0x00428B27 File Offset: 0x00426D27
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

		// Token: 0x17006117 RID: 24855
		// (get) Token: 0x0601CB3E RID: 117566 RVA: 0x00428B30 File Offset: 0x00426D30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RolePhantomEquipInfo> EquipInfoList
		{
			get
			{
				return this.equipInfoList_;
			}
		}

		// Token: 0x17006118 RID: 24856
		// (get) Token: 0x0601CB3F RID: 117567 RVA: 0x00428B38 File Offset: 0x00426D38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomStackSplitInfo> StackSplitInfos
		{
			get
			{
				return this.stackSplitInfos_;
			}
		}

		// Token: 0x17006119 RID: 24857
		// (get) Token: 0x0601CB40 RID: 117568 RVA: 0x00428B40 File Offset: 0x00426D40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomStackMergeInfo> StackMergeInfos
		{
			get
			{
				return this.stackMergeInfos_;
			}
		}

		// Token: 0x0601CB41 RID: 117569 RVA: 0x00428B48 File Offset: 0x00426D48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UsePhantomEquipGroupResponse);
		}

		// Token: 0x0601CB42 RID: 117570 RVA: 0x00428B58 File Offset: 0x00426D58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UsePhantomEquipGroupResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.equipInfoList_.Equals(other.equipInfoList_) && this.stackSplitInfos_.Equals(other.stackSplitInfos_) && this.stackMergeInfos_.Equals(other.stackMergeInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CB43 RID: 117571 RVA: 0x00428BD0 File Offset: 0x00426DD0
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

		// Token: 0x0601CB44 RID: 117572 RVA: 0x00428C3F File Offset: 0x00426E3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CB45 RID: 117573 RVA: 0x00428C4C File Offset: 0x00426E4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CB46 RID: 117574 RVA: 0x00428C58 File Offset: 0x00426E58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.stackMergeInfos_.WriteTo(ref output, UsePhantomEquipGroupResponse._repeated_stackMergeInfos_codec);
			this.equipInfoList_.WriteTo(ref output, UsePhantomEquipGroupResponse._repeated_equipInfoList_codec);
			this.stackSplitInfos_.WriteTo(ref output, UsePhantomEquipGroupResponse._repeated_stackSplitInfos_codec);
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

		// Token: 0x0601CB47 RID: 117575 RVA: 0x00428CC8 File Offset: 0x00426EC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.equipInfoList_.CalculateSize(UsePhantomEquipGroupResponse._repeated_equipInfoList_codec);
			num += this.stackSplitInfos_.CalculateSize(UsePhantomEquipGroupResponse._repeated_stackSplitInfos_codec);
			num += this.stackMergeInfos_.CalculateSize(UsePhantomEquipGroupResponse._repeated_stackMergeInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601CB48 RID: 117576 RVA: 0x00428D40 File Offset: 0x00426F40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UsePhantomEquipGroupResponse other)
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

		// Token: 0x0601CB49 RID: 117577 RVA: 0x00428DAF File Offset: 0x00426FAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CB4A RID: 117578 RVA: 0x00428DB8 File Offset: 0x00426FB8
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
				if (num <= 98U)
				{
					if (num == 90U)
					{
						this.stackMergeInfos_.AddEntriesFrom(ref input, UsePhantomEquipGroupResponse._repeated_stackMergeInfos_codec);
						continue;
					}
					if (num == 98U)
					{
						this.equipInfoList_.AddEntriesFrom(ref input, UsePhantomEquipGroupResponse._repeated_equipInfoList_codec);
						continue;
					}
				}
				else
				{
					if (num == 106U)
					{
						this.stackSplitInfos_.AddEntriesFrom(ref input, UsePhantomEquipGroupResponse._repeated_stackSplitInfos_codec);
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

		// Token: 0x0400A54A RID: 42314
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A54B RID: 42315
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x0400A54C RID: 42316
		private ErrorCode errorCode_;

		// Token: 0x0400A54D RID: 42317
		public const int EquipInfoListFieldNumber = 12;

		// Token: 0x0400A54E RID: 42318
		private static readonly FieldCodec<RolePhantomEquipInfo> _repeated_equipInfoList_codec = FieldCodec.ForMessage<RolePhantomEquipInfo>(98U, RolePhantomEquipInfo.Parser);

		// Token: 0x0400A54F RID: 42319
		private readonly RepeatedField<RolePhantomEquipInfo> equipInfoList_ = new RepeatedField<RolePhantomEquipInfo>();

		// Token: 0x0400A550 RID: 42320
		public const int StackSplitInfosFieldNumber = 13;

		// Token: 0x0400A551 RID: 42321
		private static readonly FieldCodec<PhantomStackSplitInfo> _repeated_stackSplitInfos_codec = FieldCodec.ForMessage<PhantomStackSplitInfo>(106U, PhantomStackSplitInfo.Parser);

		// Token: 0x0400A552 RID: 42322
		private readonly RepeatedField<PhantomStackSplitInfo> stackSplitInfos_ = new RepeatedField<PhantomStackSplitInfo>();

		// Token: 0x0400A553 RID: 42323
		public const int StackMergeInfosFieldNumber = 11;

		// Token: 0x0400A554 RID: 42324
		private static readonly FieldCodec<PhantomStackMergeInfo> _repeated_stackMergeInfos_codec = FieldCodec.ForMessage<PhantomStackMergeInfo>(90U, PhantomStackMergeInfo.Parser);

		// Token: 0x0400A555 RID: 42325
		private readonly RepeatedField<PhantomStackMergeInfo> stackMergeInfos_ = new RepeatedField<PhantomStackMergeInfo>();
	}
}
