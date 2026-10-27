using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014B4 RID: 5300
	[NetMessage(EMessageId.UsePhantomEquipGroupResponse)]
	public sealed class UsePhantomEquipGroupResponse : IMessage<UsePhantomEquipGroupResponse>, IMessage, IEquatable<UsePhantomEquipGroupResponse>, IDeepCloneable<UsePhantomEquipGroupResponse>, IBufferMessage
	{
		// Token: 0x0601C06F RID: 114799 RVA: 0x0040CFC0 File Offset: 0x0040B1C0
		[NullableContext(1)]
		public static UsePhantomEquipGroupResponse Create()
		{
			return new UsePhantomEquipGroupResponse();
		}

		// Token: 0x17005E73 RID: 24179
		// (get) Token: 0x0601C070 RID: 114800 RVA: 0x0040CFC7 File Offset: 0x0040B1C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005E74 RID: 24180
		// (get) Token: 0x0601C071 RID: 114801 RVA: 0x0040CFCA File Offset: 0x0040B1CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UsePhantomEquipGroupResponse.Descriptor;
			}
		}

		// Token: 0x0601C072 RID: 114802 RVA: 0x0040CFD1 File Offset: 0x0040B1D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UsePhantomEquipGroupResponse()
		{
		}

		// Token: 0x0601C073 RID: 114803 RVA: 0x0040CFFC File Offset: 0x0040B1FC
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

		// Token: 0x0601C074 RID: 114804 RVA: 0x0040D05F File Offset: 0x0040B25F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UsePhantomEquipGroupResponse Clone()
		{
			return new UsePhantomEquipGroupResponse(this);
		}

		// Token: 0x17005E75 RID: 24181
		// (get) Token: 0x0601C075 RID: 114805 RVA: 0x0040D067 File Offset: 0x0040B267
		// (set) Token: 0x0601C076 RID: 114806 RVA: 0x0040D06F File Offset: 0x0040B26F
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

		// Token: 0x17005E76 RID: 24182
		// (get) Token: 0x0601C077 RID: 114807 RVA: 0x0040D078 File Offset: 0x0040B278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RolePhantomEquipInfo> EquipInfoList
		{
			get
			{
				return this.equipInfoList_;
			}
		}

		// Token: 0x17005E77 RID: 24183
		// (get) Token: 0x0601C078 RID: 114808 RVA: 0x0040D080 File Offset: 0x0040B280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomStackSplitInfo> StackSplitInfos
		{
			get
			{
				return this.stackSplitInfos_;
			}
		}

		// Token: 0x17005E78 RID: 24184
		// (get) Token: 0x0601C079 RID: 114809 RVA: 0x0040D088 File Offset: 0x0040B288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomStackMergeInfo> StackMergeInfos
		{
			get
			{
				return this.stackMergeInfos_;
			}
		}

		// Token: 0x0601C07A RID: 114810 RVA: 0x0040D090 File Offset: 0x0040B290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UsePhantomEquipGroupResponse);
		}

		// Token: 0x0601C07B RID: 114811 RVA: 0x0040D0A0 File Offset: 0x0040B2A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UsePhantomEquipGroupResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.equipInfoList_.Equals(other.equipInfoList_) && this.stackSplitInfos_.Equals(other.stackSplitInfos_) && this.stackMergeInfos_.Equals(other.stackMergeInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C07C RID: 114812 RVA: 0x0040D118 File Offset: 0x0040B318
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

		// Token: 0x0601C07D RID: 114813 RVA: 0x0040D187 File Offset: 0x0040B387
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C07E RID: 114814 RVA: 0x0040D194 File Offset: 0x0040B394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C07F RID: 114815 RVA: 0x0040D1A0 File Offset: 0x0040B3A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.equipInfoList_.WriteTo(ref output, UsePhantomEquipGroupResponse._repeated_equipInfoList_codec);
			this.stackSplitInfos_.WriteTo(ref output, UsePhantomEquipGroupResponse._repeated_stackSplitInfos_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.stackMergeInfos_.WriteTo(ref output, UsePhantomEquipGroupResponse._repeated_stackMergeInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C080 RID: 114816 RVA: 0x0040D210 File Offset: 0x0040B410
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

		// Token: 0x0601C081 RID: 114817 RVA: 0x0040D288 File Offset: 0x0040B488
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

		// Token: 0x0601C082 RID: 114818 RVA: 0x0040D2F7 File Offset: 0x0040B4F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C083 RID: 114819 RVA: 0x0040D300 File Offset: 0x0040B500
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
				if (num <= 50U)
				{
					if (num == 42U)
					{
						this.equipInfoList_.AddEntriesFrom(ref input, UsePhantomEquipGroupResponse._repeated_equipInfoList_codec);
						continue;
					}
					if (num == 50U)
					{
						this.stackSplitInfos_.AddEntriesFrom(ref input, UsePhantomEquipGroupResponse._repeated_stackSplitInfos_codec);
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 114U)
					{
						this.stackMergeInfos_.AddEntriesFrom(ref input, UsePhantomEquipGroupResponse._repeated_stackMergeInfos_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400A0F1 RID: 41201
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A0F2 RID: 41202
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x0400A0F3 RID: 41203
		private ErrorCode errorCode_;

		// Token: 0x0400A0F4 RID: 41204
		public const int EquipInfoListFieldNumber = 5;

		// Token: 0x0400A0F5 RID: 41205
		private static readonly FieldCodec<RolePhantomEquipInfo> _repeated_equipInfoList_codec = FieldCodec.ForMessage<RolePhantomEquipInfo>(42U, RolePhantomEquipInfo.Parser);

		// Token: 0x0400A0F6 RID: 41206
		private readonly RepeatedField<RolePhantomEquipInfo> equipInfoList_ = new RepeatedField<RolePhantomEquipInfo>();

		// Token: 0x0400A0F7 RID: 41207
		public const int StackSplitInfosFieldNumber = 6;

		// Token: 0x0400A0F8 RID: 41208
		private static readonly FieldCodec<PhantomStackSplitInfo> _repeated_stackSplitInfos_codec = FieldCodec.ForMessage<PhantomStackSplitInfo>(50U, PhantomStackSplitInfo.Parser);

		// Token: 0x0400A0F9 RID: 41209
		private readonly RepeatedField<PhantomStackSplitInfo> stackSplitInfos_ = new RepeatedField<PhantomStackSplitInfo>();

		// Token: 0x0400A0FA RID: 41210
		public const int StackMergeInfosFieldNumber = 14;

		// Token: 0x0400A0FB RID: 41211
		private static readonly FieldCodec<PhantomStackMergeInfo> _repeated_stackMergeInfos_codec = FieldCodec.ForMessage<PhantomStackMergeInfo>(114U, PhantomStackMergeInfo.Parser);

		// Token: 0x0400A0FC RID: 41212
		private readonly RepeatedField<PhantomStackMergeInfo> stackMergeInfos_ = new RepeatedField<PhantomStackMergeInfo>();
	}
}
