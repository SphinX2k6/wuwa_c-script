using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CE5 RID: 3301
	[NetMessage(EMessageId.PhantomPutOnResponse)]
	public sealed class PhantomPutOnResponse : IMessage<PhantomPutOnResponse>, IMessage, IEquatable<PhantomPutOnResponse>, IDeepCloneable<PhantomPutOnResponse>, IBufferMessage
	{
		// Token: 0x06011E00 RID: 73216 RVA: 0x0029DB8B File Offset: 0x0029BD8B
		[NullableContext(1)]
		public static PhantomPutOnResponse Create()
		{
			return new PhantomPutOnResponse();
		}

		// Token: 0x17003B3A RID: 15162
		// (get) Token: 0x06011E01 RID: 73217 RVA: 0x0029DB92 File Offset: 0x0029BD92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003B3B RID: 15163
		// (get) Token: 0x06011E02 RID: 73218 RVA: 0x0029DB95 File Offset: 0x0029BD95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomPutOnResponse.Descriptor;
			}
		}

		// Token: 0x06011E03 RID: 73219 RVA: 0x0029DB9C File Offset: 0x0029BD9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomPutOnResponse()
		{
		}

		// Token: 0x06011E04 RID: 73220 RVA: 0x0029DBC8 File Offset: 0x0029BDC8
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

		// Token: 0x06011E05 RID: 73221 RVA: 0x0029DC2B File Offset: 0x0029BE2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomPutOnResponse Clone()
		{
			return new PhantomPutOnResponse(this);
		}

		// Token: 0x17003B3C RID: 15164
		// (get) Token: 0x06011E06 RID: 73222 RVA: 0x0029DC33 File Offset: 0x0029BE33
		// (set) Token: 0x06011E07 RID: 73223 RVA: 0x0029DC3B File Offset: 0x0029BE3B
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

		// Token: 0x17003B3D RID: 15165
		// (get) Token: 0x06011E08 RID: 73224 RVA: 0x0029DC44 File Offset: 0x0029BE44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RolePhantomEquipInfo> EquipInfoList
		{
			get
			{
				return this.equipInfoList_;
			}
		}

		// Token: 0x17003B3E RID: 15166
		// (get) Token: 0x06011E09 RID: 73225 RVA: 0x0029DC4C File Offset: 0x0029BE4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomStackSplitInfo> StackSplitInfos
		{
			get
			{
				return this.stackSplitInfos_;
			}
		}

		// Token: 0x17003B3F RID: 15167
		// (get) Token: 0x06011E0A RID: 73226 RVA: 0x0029DC54 File Offset: 0x0029BE54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomStackMergeInfo> StackMergeInfos
		{
			get
			{
				return this.stackMergeInfos_;
			}
		}

		// Token: 0x06011E0B RID: 73227 RVA: 0x0029DC5C File Offset: 0x0029BE5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomPutOnResponse);
		}

		// Token: 0x06011E0C RID: 73228 RVA: 0x0029DC6C File Offset: 0x0029BE6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomPutOnResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.equipInfoList_.Equals(other.equipInfoList_) && this.stackSplitInfos_.Equals(other.stackSplitInfos_) && this.stackMergeInfos_.Equals(other.stackMergeInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011E0D RID: 73229 RVA: 0x0029DCE4 File Offset: 0x0029BEE4
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

		// Token: 0x06011E0E RID: 73230 RVA: 0x0029DD53 File Offset: 0x0029BF53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011E0F RID: 73231 RVA: 0x0029DD60 File Offset: 0x0029BF60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011E10 RID: 73232 RVA: 0x0029DD6C File Offset: 0x0029BF6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.stackMergeInfos_.WriteTo(ref output, PhantomPutOnResponse._repeated_stackMergeInfos_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.stackSplitInfos_.WriteTo(ref output, PhantomPutOnResponse._repeated_stackSplitInfos_codec);
			this.equipInfoList_.WriteTo(ref output, PhantomPutOnResponse._repeated_equipInfoList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011E11 RID: 73233 RVA: 0x0029DDDC File Offset: 0x0029BFDC
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

		// Token: 0x06011E12 RID: 73234 RVA: 0x0029DE54 File Offset: 0x0029C054
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

		// Token: 0x06011E13 RID: 73235 RVA: 0x0029DEC3 File Offset: 0x0029C0C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011E14 RID: 73236 RVA: 0x0029DECC File Offset: 0x0029C0CC
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
				if (num <= 56U)
				{
					if (num == 18U)
					{
						this.stackMergeInfos_.AddEntriesFrom(ref input, PhantomPutOnResponse._repeated_stackMergeInfos_codec);
						continue;
					}
					if (num == 56U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 90U)
					{
						this.stackSplitInfos_.AddEntriesFrom(ref input, PhantomPutOnResponse._repeated_stackSplitInfos_codec);
						continue;
					}
					if (num == 122U)
					{
						this.equipInfoList_.AddEntriesFrom(ref input, PhantomPutOnResponse._repeated_equipInfoList_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400708B RID: 28811
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400708C RID: 28812
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x0400708D RID: 28813
		private ErrorCode errorCode_;

		// Token: 0x0400708E RID: 28814
		public const int EquipInfoListFieldNumber = 15;

		// Token: 0x0400708F RID: 28815
		private static readonly FieldCodec<RolePhantomEquipInfo> _repeated_equipInfoList_codec = FieldCodec.ForMessage<RolePhantomEquipInfo>(122U, RolePhantomEquipInfo.Parser);

		// Token: 0x04007090 RID: 28816
		private readonly RepeatedField<RolePhantomEquipInfo> equipInfoList_ = new RepeatedField<RolePhantomEquipInfo>();

		// Token: 0x04007091 RID: 28817
		public const int StackSplitInfosFieldNumber = 11;

		// Token: 0x04007092 RID: 28818
		private static readonly FieldCodec<PhantomStackSplitInfo> _repeated_stackSplitInfos_codec = FieldCodec.ForMessage<PhantomStackSplitInfo>(90U, PhantomStackSplitInfo.Parser);

		// Token: 0x04007093 RID: 28819
		private readonly RepeatedField<PhantomStackSplitInfo> stackSplitInfos_ = new RepeatedField<PhantomStackSplitInfo>();

		// Token: 0x04007094 RID: 28820
		public const int StackMergeInfosFieldNumber = 2;

		// Token: 0x04007095 RID: 28821
		private static readonly FieldCodec<PhantomStackMergeInfo> _repeated_stackMergeInfos_codec = FieldCodec.ForMessage<PhantomStackMergeInfo>(18U, PhantomStackMergeInfo.Parser);

		// Token: 0x04007096 RID: 28822
		private readonly RepeatedField<PhantomStackMergeInfo> stackMergeInfos_ = new RepeatedField<PhantomStackMergeInfo>();
	}
}
