using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000AA RID: 170
	[NetMessage(EMessageId.AddPhantomEquipGroupResponse)]
	public sealed class AddPhantomEquipGroupResponse : IMessage<AddPhantomEquipGroupResponse>, IMessage, IEquatable<AddPhantomEquipGroupResponse>, IDeepCloneable<AddPhantomEquipGroupResponse>, IBufferMessage
	{
		// Token: 0x06001D07 RID: 7431 RVA: 0x000501B8 File Offset: 0x0004E3B8
		[NullableContext(1)]
		public static AddPhantomEquipGroupResponse Create()
		{
			return new AddPhantomEquipGroupResponse();
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06001D08 RID: 7432 RVA: 0x000501BF File Offset: 0x0004E3BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06001D09 RID: 7433 RVA: 0x000501C2 File Offset: 0x0004E3C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AddPhantomEquipGroupResponse.Descriptor;
			}
		}

		// Token: 0x06001D0A RID: 7434 RVA: 0x000501C9 File Offset: 0x0004E3C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddPhantomEquipGroupResponse()
		{
		}

		// Token: 0x06001D0B RID: 7435 RVA: 0x000501DC File Offset: 0x0004E3DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddPhantomEquipGroupResponse(AddPhantomEquipGroupResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.phantomEquipGroupInfos_ = other.phantomEquipGroupInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001D0C RID: 7436 RVA: 0x00050212 File Offset: 0x0004E412
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddPhantomEquipGroupResponse Clone()
		{
			return new AddPhantomEquipGroupResponse(this);
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06001D0D RID: 7437 RVA: 0x0005021A File Offset: 0x0004E41A
		// (set) Token: 0x06001D0E RID: 7438 RVA: 0x00050222 File Offset: 0x0004E422
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

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06001D0F RID: 7439 RVA: 0x0005022B File Offset: 0x0004E42B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomEquipGroupInfo> PhantomEquipGroupInfos
		{
			get
			{
				return this.phantomEquipGroupInfos_;
			}
		}

		// Token: 0x06001D10 RID: 7440 RVA: 0x00050233 File Offset: 0x0004E433
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AddPhantomEquipGroupResponse);
		}

		// Token: 0x06001D11 RID: 7441 RVA: 0x00050244 File Offset: 0x0004E444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AddPhantomEquipGroupResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.phantomEquipGroupInfos_.Equals(other.phantomEquipGroupInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001D12 RID: 7442 RVA: 0x00050294 File Offset: 0x0004E494
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

		// Token: 0x06001D13 RID: 7443 RVA: 0x000502E7 File Offset: 0x0004E4E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001D14 RID: 7444 RVA: 0x000502F4 File Offset: 0x0004E4F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001D15 RID: 7445 RVA: 0x00050300 File Offset: 0x0004E500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.phantomEquipGroupInfos_.WriteTo(ref output, AddPhantomEquipGroupResponse._repeated_phantomEquipGroupInfos_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001D16 RID: 7446 RVA: 0x00050350 File Offset: 0x0004E550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.phantomEquipGroupInfos_.CalculateSize(AddPhantomEquipGroupResponse._repeated_phantomEquipGroupInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001D17 RID: 7447 RVA: 0x000503A4 File Offset: 0x0004E5A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AddPhantomEquipGroupResponse other)
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

		// Token: 0x06001D18 RID: 7448 RVA: 0x000503F1 File Offset: 0x0004E5F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001D19 RID: 7449 RVA: 0x000503FC File Offset: 0x0004E5FC
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
				if (num != 26U)
				{
					if (num != 120U)
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
					this.phantomEquipGroupInfos_.AddEntriesFrom(ref input, AddPhantomEquipGroupResponse._repeated_phantomEquipGroupInfos_codec);
				}
			}
		}

		// Token: 0x04002303 RID: 8963
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002304 RID: 8964
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x04002305 RID: 8965
		private ErrorCode errorCode_;

		// Token: 0x04002306 RID: 8966
		public const int PhantomEquipGroupInfosFieldNumber = 3;

		// Token: 0x04002307 RID: 8967
		private static readonly FieldCodec<PhantomEquipGroupInfo> _repeated_phantomEquipGroupInfos_codec = FieldCodec.ForMessage<PhantomEquipGroupInfo>(26U, PhantomEquipGroupInfo.Parser);

		// Token: 0x04002308 RID: 8968
		private readonly RepeatedField<PhantomEquipGroupInfo> phantomEquipGroupInfos_ = new RepeatedField<PhantomEquipGroupInfo>();
	}
}
