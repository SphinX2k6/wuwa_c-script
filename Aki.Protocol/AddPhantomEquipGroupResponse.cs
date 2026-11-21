using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000AB RID: 171
	[NetMessage(EMessageId.AddPhantomEquipGroupResponse)]
	public sealed class AddPhantomEquipGroupResponse : IMessage<AddPhantomEquipGroupResponse>, IMessage, IEquatable<AddPhantomEquipGroupResponse>, IDeepCloneable<AddPhantomEquipGroupResponse>, IBufferMessage
	{
		// Token: 0x06001D4E RID: 7502 RVA: 0x00050DD0 File Offset: 0x0004EFD0
		[NullableContext(1)]
		public static AddPhantomEquipGroupResponse Create()
		{
			return new AddPhantomEquipGroupResponse();
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06001D4F RID: 7503 RVA: 0x00050DD7 File Offset: 0x0004EFD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06001D50 RID: 7504 RVA: 0x00050DDA File Offset: 0x0004EFDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AddPhantomEquipGroupResponse.Descriptor;
			}
		}

		// Token: 0x06001D51 RID: 7505 RVA: 0x00050DE1 File Offset: 0x0004EFE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddPhantomEquipGroupResponse()
		{
		}

		// Token: 0x06001D52 RID: 7506 RVA: 0x00050DF4 File Offset: 0x0004EFF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddPhantomEquipGroupResponse(AddPhantomEquipGroupResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.phantomEquipGroupInfos_ = other.phantomEquipGroupInfos_.Clone();
			this.isOldData_ = other.isOldData_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001D53 RID: 7507 RVA: 0x00050E41 File Offset: 0x0004F041
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddPhantomEquipGroupResponse Clone()
		{
			return new AddPhantomEquipGroupResponse(this);
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06001D54 RID: 7508 RVA: 0x00050E49 File Offset: 0x0004F049
		// (set) Token: 0x06001D55 RID: 7509 RVA: 0x00050E51 File Offset: 0x0004F051
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

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x06001D56 RID: 7510 RVA: 0x00050E5A File Offset: 0x0004F05A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomEquipGroupInfo> PhantomEquipGroupInfos
		{
			get
			{
				return this.phantomEquipGroupInfos_;
			}
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06001D57 RID: 7511 RVA: 0x00050E62 File Offset: 0x0004F062
		// (set) Token: 0x06001D58 RID: 7512 RVA: 0x00050E6A File Offset: 0x0004F06A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsOldData
		{
			get
			{
				return this.isOldData_;
			}
			set
			{
				this.isOldData_ = value;
			}
		}

		// Token: 0x06001D59 RID: 7513 RVA: 0x00050E73 File Offset: 0x0004F073
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AddPhantomEquipGroupResponse);
		}

		// Token: 0x06001D5A RID: 7514 RVA: 0x00050E84 File Offset: 0x0004F084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AddPhantomEquipGroupResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.phantomEquipGroupInfos_.Equals(other.phantomEquipGroupInfos_) && this.IsOldData == other.IsOldData && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001D5B RID: 7515 RVA: 0x00050EE4 File Offset: 0x0004F0E4
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
			if (this.IsOldData)
			{
				num ^= this.IsOldData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001D5C RID: 7516 RVA: 0x00050F50 File Offset: 0x0004F150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001D5D RID: 7517 RVA: 0x00050F5D File Offset: 0x0004F15D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001D5E RID: 7518 RVA: 0x00050F68 File Offset: 0x0004F168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.phantomEquipGroupInfos_.WriteTo(ref output, AddPhantomEquipGroupResponse._repeated_phantomEquipGroupInfos_codec);
			if (this.IsOldData)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.IsOldData);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001D5F RID: 7519 RVA: 0x00050FD4 File Offset: 0x0004F1D4
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
			if (this.IsOldData)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001D60 RID: 7520 RVA: 0x00051034 File Offset: 0x0004F234
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
			if (other.IsOldData)
			{
				this.IsOldData = other.IsOldData;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001D61 RID: 7521 RVA: 0x00051095 File Offset: 0x0004F295
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001D62 RID: 7522 RVA: 0x000510A0 File Offset: 0x0004F2A0
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
					if (num != 48U)
					{
						if (num != 80U)
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
						this.IsOldData = input.ReadBool();
					}
				}
				else
				{
					this.phantomEquipGroupInfos_.AddEntriesFrom(ref input, AddPhantomEquipGroupResponse._repeated_phantomEquipGroupInfos_codec);
				}
			}
		}

		// Token: 0x04002364 RID: 9060
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002365 RID: 9061
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04002366 RID: 9062
		private ErrorCode errorCode_;

		// Token: 0x04002367 RID: 9063
		public const int PhantomEquipGroupInfosFieldNumber = 3;

		// Token: 0x04002368 RID: 9064
		private static readonly FieldCodec<PhantomEquipGroupInfo> _repeated_phantomEquipGroupInfos_codec = FieldCodec.ForMessage<PhantomEquipGroupInfo>(26U, PhantomEquipGroupInfo.Parser);

		// Token: 0x04002369 RID: 9065
		private readonly RepeatedField<PhantomEquipGroupInfo> phantomEquipGroupInfos_ = new RepeatedField<PhantomEquipGroupInfo>();

		// Token: 0x0400236A RID: 9066
		public const int IsOldDataFieldNumber = 6;

		// Token: 0x0400236B RID: 9067
		private bool isOldData_;
	}
}
