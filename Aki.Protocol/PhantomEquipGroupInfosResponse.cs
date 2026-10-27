using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CCE RID: 3278
	[NetMessage(EMessageId.PhantomEquipGroupInfosResponse)]
	public sealed class PhantomEquipGroupInfosResponse : IMessage<PhantomEquipGroupInfosResponse>, IMessage, IEquatable<PhantomEquipGroupInfosResponse>, IDeepCloneable<PhantomEquipGroupInfosResponse>, IBufferMessage
	{
		// Token: 0x06011BE8 RID: 72680 RVA: 0x00298BCE File Offset: 0x00296DCE
		[NullableContext(1)]
		public static PhantomEquipGroupInfosResponse Create()
		{
			return new PhantomEquipGroupInfosResponse();
		}

		// Token: 0x17003AC9 RID: 15049
		// (get) Token: 0x06011BE9 RID: 72681 RVA: 0x00298BD5 File Offset: 0x00296DD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003ACA RID: 15050
		// (get) Token: 0x06011BEA RID: 72682 RVA: 0x00298BD8 File Offset: 0x00296DD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomEquipGroupInfosResponse.Descriptor;
			}
		}

		// Token: 0x06011BEB RID: 72683 RVA: 0x00298BDF File Offset: 0x00296DDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomEquipGroupInfosResponse()
		{
		}

		// Token: 0x06011BEC RID: 72684 RVA: 0x00298BF2 File Offset: 0x00296DF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomEquipGroupInfosResponse(PhantomEquipGroupInfosResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.phantomEquipGroupInfos_ = other.phantomEquipGroupInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011BED RID: 72685 RVA: 0x00298C28 File Offset: 0x00296E28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomEquipGroupInfosResponse Clone()
		{
			return new PhantomEquipGroupInfosResponse(this);
		}

		// Token: 0x17003ACB RID: 15051
		// (get) Token: 0x06011BEE RID: 72686 RVA: 0x00298C30 File Offset: 0x00296E30
		// (set) Token: 0x06011BEF RID: 72687 RVA: 0x00298C38 File Offset: 0x00296E38
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

		// Token: 0x17003ACC RID: 15052
		// (get) Token: 0x06011BF0 RID: 72688 RVA: 0x00298C41 File Offset: 0x00296E41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomEquipGroupInfo> PhantomEquipGroupInfos
		{
			get
			{
				return this.phantomEquipGroupInfos_;
			}
		}

		// Token: 0x06011BF1 RID: 72689 RVA: 0x00298C49 File Offset: 0x00296E49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomEquipGroupInfosResponse);
		}

		// Token: 0x06011BF2 RID: 72690 RVA: 0x00298C58 File Offset: 0x00296E58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomEquipGroupInfosResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.phantomEquipGroupInfos_.Equals(other.phantomEquipGroupInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011BF3 RID: 72691 RVA: 0x00298CA8 File Offset: 0x00296EA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.phantomEquipGroupInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011BF4 RID: 72692 RVA: 0x00298CFB File Offset: 0x00296EFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011BF5 RID: 72693 RVA: 0x00298D08 File Offset: 0x00296F08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011BF6 RID: 72694 RVA: 0x00298D14 File Offset: 0x00296F14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.phantomEquipGroupInfos_.WriteTo(ref output, PhantomEquipGroupInfosResponse._repeated_phantomEquipGroupInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011BF7 RID: 72695 RVA: 0x00298D64 File Offset: 0x00296F64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.phantomEquipGroupInfos_.CalculateSize(PhantomEquipGroupInfosResponse._repeated_phantomEquipGroupInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011BF8 RID: 72696 RVA: 0x00298DB8 File Offset: 0x00296FB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomEquipGroupInfosResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.phantomEquipGroupInfos_.Add(other.phantomEquipGroupInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011BF9 RID: 72697 RVA: 0x00298E05 File Offset: 0x00297005
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011BFA RID: 72698 RVA: 0x00298E10 File Offset: 0x00297010
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
				if (num != 16U)
				{
					if (num != 82U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.phantomEquipGroupInfos_.AddEntriesFrom(ref input, PhantomEquipGroupInfosResponse._repeated_phantomEquipGroupInfos_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04006F82 RID: 28546
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006F83 RID: 28547
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04006F84 RID: 28548
		private ErrorCode errorCode_;

		// Token: 0x04006F85 RID: 28549
		public const int PhantomEquipGroupInfosFieldNumber = 10;

		// Token: 0x04006F86 RID: 28550
		private static readonly FieldCodec<PhantomEquipGroupInfo> _repeated_phantomEquipGroupInfos_codec = FieldCodec.ForMessage<PhantomEquipGroupInfo>(82U, PhantomEquipGroupInfo.Parser);

		// Token: 0x04006F87 RID: 28551
		private readonly RepeatedField<PhantomEquipGroupInfo> phantomEquipGroupInfos_ = new RepeatedField<PhantomEquipGroupInfo>();
	}
}
