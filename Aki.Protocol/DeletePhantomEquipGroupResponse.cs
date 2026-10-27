using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003C0 RID: 960
	[NetMessage(EMessageId.DeletePhantomEquipGroupResponse)]
	public sealed class DeletePhantomEquipGroupResponse : IMessage<DeletePhantomEquipGroupResponse>, IMessage, IEquatable<DeletePhantomEquipGroupResponse>, IDeepCloneable<DeletePhantomEquipGroupResponse>, IBufferMessage
	{
		// Token: 0x06005DEF RID: 24047 RVA: 0x000E3B0D File Offset: 0x000E1D0D
		[NullableContext(1)]
		public static DeletePhantomEquipGroupResponse Create()
		{
			return new DeletePhantomEquipGroupResponse();
		}

		// Token: 0x17001172 RID: 4466
		// (get) Token: 0x06005DF0 RID: 24048 RVA: 0x000E3B14 File Offset: 0x000E1D14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001173 RID: 4467
		// (get) Token: 0x06005DF1 RID: 24049 RVA: 0x000E3B17 File Offset: 0x000E1D17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DeletePhantomEquipGroupResponse.Descriptor;
			}
		}

		// Token: 0x06005DF2 RID: 24050 RVA: 0x000E3B1E File Offset: 0x000E1D1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeletePhantomEquipGroupResponse()
		{
		}

		// Token: 0x06005DF3 RID: 24051 RVA: 0x000E3B31 File Offset: 0x000E1D31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeletePhantomEquipGroupResponse(DeletePhantomEquipGroupResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.phantomEquipGroupInfos_ = other.phantomEquipGroupInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005DF4 RID: 24052 RVA: 0x000E3B67 File Offset: 0x000E1D67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeletePhantomEquipGroupResponse Clone()
		{
			return new DeletePhantomEquipGroupResponse(this);
		}

		// Token: 0x17001174 RID: 4468
		// (get) Token: 0x06005DF5 RID: 24053 RVA: 0x000E3B6F File Offset: 0x000E1D6F
		// (set) Token: 0x06005DF6 RID: 24054 RVA: 0x000E3B77 File Offset: 0x000E1D77
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

		// Token: 0x17001175 RID: 4469
		// (get) Token: 0x06005DF7 RID: 24055 RVA: 0x000E3B80 File Offset: 0x000E1D80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomEquipGroupInfo> PhantomEquipGroupInfos
		{
			get
			{
				return this.phantomEquipGroupInfos_;
			}
		}

		// Token: 0x06005DF8 RID: 24056 RVA: 0x000E3B88 File Offset: 0x000E1D88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DeletePhantomEquipGroupResponse);
		}

		// Token: 0x06005DF9 RID: 24057 RVA: 0x000E3B98 File Offset: 0x000E1D98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DeletePhantomEquipGroupResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.phantomEquipGroupInfos_.Equals(other.phantomEquipGroupInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005DFA RID: 24058 RVA: 0x000E3BE8 File Offset: 0x000E1DE8
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

		// Token: 0x06005DFB RID: 24059 RVA: 0x000E3C3B File Offset: 0x000E1E3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005DFC RID: 24060 RVA: 0x000E3C48 File Offset: 0x000E1E48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005DFD RID: 24061 RVA: 0x000E3C54 File Offset: 0x000E1E54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.phantomEquipGroupInfos_.WriteTo(ref output, DeletePhantomEquipGroupResponse._repeated_phantomEquipGroupInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005DFE RID: 24062 RVA: 0x000E3CA4 File Offset: 0x000E1EA4
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

		// Token: 0x06005DFF RID: 24063 RVA: 0x000E3CF8 File Offset: 0x000E1EF8
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

		// Token: 0x06005E00 RID: 24064 RVA: 0x000E3D45 File Offset: 0x000E1F45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005E01 RID: 24065 RVA: 0x000E3D50 File Offset: 0x000E1F50
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
				if (num != 80U)
				{
					if (num != 98U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.phantomEquipGroupInfos_.AddEntriesFrom(ref input, DeletePhantomEquipGroupResponse._repeated_phantomEquipGroupInfos_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040036AB RID: 13995
		private UnknownFieldSet _unknownFields;

		// Token: 0x040036AC RID: 13996
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x040036AD RID: 13997
		private ErrorCode errorCode_;

		// Token: 0x040036AE RID: 13998
		public const int PhantomEquipGroupInfosFieldNumber = 12;

		// Token: 0x040036AF RID: 13999
		private static readonly FieldCodec<PhantomEquipGroupInfo> _repeated_phantomEquipGroupInfos_codec = FieldCodec.ForMessage<PhantomEquipGroupInfo>(98U, PhantomEquipGroupInfo.Parser);

		// Token: 0x040036B0 RID: 14000
		private readonly RepeatedField<PhantomEquipGroupInfo> phantomEquipGroupInfos_ = new RepeatedField<PhantomEquipGroupInfo>();
	}
}
