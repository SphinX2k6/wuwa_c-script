using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003A9 RID: 937
	[NetMessage(EMessageId.DeletePhantomEquipGroupResponse)]
	public sealed class DeletePhantomEquipGroupResponse : IMessage<DeletePhantomEquipGroupResponse>, IMessage, IEquatable<DeletePhantomEquipGroupResponse>, IDeepCloneable<DeletePhantomEquipGroupResponse>, IBufferMessage
	{
		// Token: 0x06005C5F RID: 23647 RVA: 0x000E0988 File Offset: 0x000DEB88
		[NullableContext(1)]
		public static DeletePhantomEquipGroupResponse Create()
		{
			return new DeletePhantomEquipGroupResponse();
		}

		// Token: 0x1700111D RID: 4381
		// (get) Token: 0x06005C60 RID: 23648 RVA: 0x000E098F File Offset: 0x000DEB8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700111E RID: 4382
		// (get) Token: 0x06005C61 RID: 23649 RVA: 0x000E0992 File Offset: 0x000DEB92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DeletePhantomEquipGroupResponse.Descriptor;
			}
		}

		// Token: 0x06005C62 RID: 23650 RVA: 0x000E0999 File Offset: 0x000DEB99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeletePhantomEquipGroupResponse()
		{
		}

		// Token: 0x06005C63 RID: 23651 RVA: 0x000E09AC File Offset: 0x000DEBAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeletePhantomEquipGroupResponse(DeletePhantomEquipGroupResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.phantomEquipGroupInfos_ = other.phantomEquipGroupInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005C64 RID: 23652 RVA: 0x000E09E2 File Offset: 0x000DEBE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeletePhantomEquipGroupResponse Clone()
		{
			return new DeletePhantomEquipGroupResponse(this);
		}

		// Token: 0x1700111F RID: 4383
		// (get) Token: 0x06005C65 RID: 23653 RVA: 0x000E09EA File Offset: 0x000DEBEA
		// (set) Token: 0x06005C66 RID: 23654 RVA: 0x000E09F2 File Offset: 0x000DEBF2
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

		// Token: 0x17001120 RID: 4384
		// (get) Token: 0x06005C67 RID: 23655 RVA: 0x000E09FB File Offset: 0x000DEBFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomEquipGroupInfo> PhantomEquipGroupInfos
		{
			get
			{
				return this.phantomEquipGroupInfos_;
			}
		}

		// Token: 0x06005C68 RID: 23656 RVA: 0x000E0A03 File Offset: 0x000DEC03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DeletePhantomEquipGroupResponse);
		}

		// Token: 0x06005C69 RID: 23657 RVA: 0x000E0A14 File Offset: 0x000DEC14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DeletePhantomEquipGroupResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.phantomEquipGroupInfos_.Equals(other.phantomEquipGroupInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005C6A RID: 23658 RVA: 0x000E0A64 File Offset: 0x000DEC64
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

		// Token: 0x06005C6B RID: 23659 RVA: 0x000E0AB7 File Offset: 0x000DECB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005C6C RID: 23660 RVA: 0x000E0AC4 File Offset: 0x000DECC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005C6D RID: 23661 RVA: 0x000E0AD0 File Offset: 0x000DECD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.phantomEquipGroupInfos_.WriteTo(ref output, DeletePhantomEquipGroupResponse._repeated_phantomEquipGroupInfos_codec);
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

		// Token: 0x06005C6E RID: 23662 RVA: 0x000E0B20 File Offset: 0x000DED20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.phantomEquipGroupInfos_.CalculateSize(DeletePhantomEquipGroupResponse._repeated_phantomEquipGroupInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005C6F RID: 23663 RVA: 0x000E0B74 File Offset: 0x000DED74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DeletePhantomEquipGroupResponse other)
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

		// Token: 0x06005C70 RID: 23664 RVA: 0x000E0BC1 File Offset: 0x000DEDC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005C71 RID: 23665 RVA: 0x000E0BCC File Offset: 0x000DEDCC
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
					this.phantomEquipGroupInfos_.AddEntriesFrom(ref input, DeletePhantomEquipGroupResponse._repeated_phantomEquipGroupInfos_codec);
				}
			}
		}

		// Token: 0x04003698 RID: 13976
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003699 RID: 13977
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x0400369A RID: 13978
		private ErrorCode errorCode_;

		// Token: 0x0400369B RID: 13979
		public const int PhantomEquipGroupInfosFieldNumber = 3;

		// Token: 0x0400369C RID: 13980
		private static readonly FieldCodec<PhantomEquipGroupInfo> _repeated_phantomEquipGroupInfos_codec = FieldCodec.ForMessage<PhantomEquipGroupInfo>(26U, PhantomEquipGroupInfo.Parser);

		// Token: 0x0400369D RID: 13981
		private readonly RepeatedField<PhantomEquipGroupInfo> phantomEquipGroupInfos_ = new RepeatedField<PhantomEquipGroupInfo>();
	}
}
