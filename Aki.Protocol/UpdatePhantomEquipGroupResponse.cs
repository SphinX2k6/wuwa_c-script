using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001515 RID: 5397
	[NetMessage(EMessageId.UpdatePhantomEquipGroupResponse)]
	public sealed class UpdatePhantomEquipGroupResponse : IMessage<UpdatePhantomEquipGroupResponse>, IMessage, IEquatable<UpdatePhantomEquipGroupResponse>, IDeepCloneable<UpdatePhantomEquipGroupResponse>, IBufferMessage
	{
		// Token: 0x0601C988 RID: 117128 RVA: 0x00424EEE File Offset: 0x004230EE
		[NullableContext(1)]
		public static UpdatePhantomEquipGroupResponse Create()
		{
			return new UpdatePhantomEquipGroupResponse();
		}

		// Token: 0x170060BB RID: 24763
		// (get) Token: 0x0601C989 RID: 117129 RVA: 0x00424EF5 File Offset: 0x004230F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170060BC RID: 24764
		// (get) Token: 0x0601C98A RID: 117130 RVA: 0x00424EF8 File Offset: 0x004230F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdatePhantomEquipGroupResponse.Descriptor;
			}
		}

		// Token: 0x0601C98B RID: 117131 RVA: 0x00424EFF File Offset: 0x004230FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdatePhantomEquipGroupResponse()
		{
		}

		// Token: 0x0601C98C RID: 117132 RVA: 0x00424F12 File Offset: 0x00423112
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdatePhantomEquipGroupResponse(UpdatePhantomEquipGroupResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.phantomEquipGroupInfos_ = other.phantomEquipGroupInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C98D RID: 117133 RVA: 0x00424F48 File Offset: 0x00423148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdatePhantomEquipGroupResponse Clone()
		{
			return new UpdatePhantomEquipGroupResponse(this);
		}

		// Token: 0x170060BD RID: 24765
		// (get) Token: 0x0601C98E RID: 117134 RVA: 0x00424F50 File Offset: 0x00423150
		// (set) Token: 0x0601C98F RID: 117135 RVA: 0x00424F58 File Offset: 0x00423158
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

		// Token: 0x170060BE RID: 24766
		// (get) Token: 0x0601C990 RID: 117136 RVA: 0x00424F61 File Offset: 0x00423161
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomEquipGroupInfo> PhantomEquipGroupInfos
		{
			get
			{
				return this.phantomEquipGroupInfos_;
			}
		}

		// Token: 0x0601C991 RID: 117137 RVA: 0x00424F69 File Offset: 0x00423169
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdatePhantomEquipGroupResponse);
		}

		// Token: 0x0601C992 RID: 117138 RVA: 0x00424F78 File Offset: 0x00423178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdatePhantomEquipGroupResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.phantomEquipGroupInfos_.Equals(other.phantomEquipGroupInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C993 RID: 117139 RVA: 0x00424FC8 File Offset: 0x004231C8
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

		// Token: 0x0601C994 RID: 117140 RVA: 0x0042501B File Offset: 0x0042321B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C995 RID: 117141 RVA: 0x00425028 File Offset: 0x00423228
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C996 RID: 117142 RVA: 0x00425034 File Offset: 0x00423234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.phantomEquipGroupInfos_.WriteTo(ref output, UpdatePhantomEquipGroupResponse._repeated_phantomEquipGroupInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C997 RID: 117143 RVA: 0x00425084 File Offset: 0x00423284
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.phantomEquipGroupInfos_.CalculateSize(UpdatePhantomEquipGroupResponse._repeated_phantomEquipGroupInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C998 RID: 117144 RVA: 0x004250D8 File Offset: 0x004232D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UpdatePhantomEquipGroupResponse other)
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

		// Token: 0x0601C999 RID: 117145 RVA: 0x00425125 File Offset: 0x00423325
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C99A RID: 117146 RVA: 0x00425130 File Offset: 0x00423330
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
				if (num != 88U)
				{
					if (num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.phantomEquipGroupInfos_.AddEntriesFrom(ref input, UpdatePhantomEquipGroupResponse._repeated_phantomEquipGroupInfos_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400A4CE RID: 42190
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A4CF RID: 42191
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x0400A4D0 RID: 42192
		private ErrorCode errorCode_;

		// Token: 0x0400A4D1 RID: 42193
		public const int PhantomEquipGroupInfosFieldNumber = 14;

		// Token: 0x0400A4D2 RID: 42194
		private static readonly FieldCodec<PhantomEquipGroupInfo> _repeated_phantomEquipGroupInfos_codec = FieldCodec.ForMessage<PhantomEquipGroupInfo>(114U, PhantomEquipGroupInfo.Parser);

		// Token: 0x0400A4D3 RID: 42195
		private readonly RepeatedField<PhantomEquipGroupInfo> phantomEquipGroupInfos_ = new RepeatedField<PhantomEquipGroupInfo>();
	}
}
