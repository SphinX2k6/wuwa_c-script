using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004EC RID: 1260
	[NetMessage(EMessageId.ExploreSkillActionResponse)]
	public sealed class ExploreSkillActionResponse : IMessage<ExploreSkillActionResponse>, IMessage, IEquatable<ExploreSkillActionResponse>, IDeepCloneable<ExploreSkillActionResponse>, IBufferMessage
	{
		// Token: 0x06007753 RID: 30547 RVA: 0x0012302D File Offset: 0x0012122D
		[NullableContext(1)]
		public static ExploreSkillActionResponse Create()
		{
			return new ExploreSkillActionResponse();
		}

		// Token: 0x17001717 RID: 5911
		// (get) Token: 0x06007754 RID: 30548 RVA: 0x00123034 File Offset: 0x00121234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001718 RID: 5912
		// (get) Token: 0x06007755 RID: 30549 RVA: 0x00123037 File Offset: 0x00121237
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExploreSkillActionResponse.Descriptor;
			}
		}

		// Token: 0x06007756 RID: 30550 RVA: 0x0012303E File Offset: 0x0012123E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillActionResponse()
		{
		}

		// Token: 0x06007757 RID: 30551 RVA: 0x00123046 File Offset: 0x00121246
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillActionResponse(ExploreSkillActionResponse other) : this()
		{
			this.entityId_ = other.entityId_;
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007758 RID: 30552 RVA: 0x00123077 File Offset: 0x00121277
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillActionResponse Clone()
		{
			return new ExploreSkillActionResponse(this);
		}

		// Token: 0x17001719 RID: 5913
		// (get) Token: 0x06007759 RID: 30553 RVA: 0x0012307F File Offset: 0x0012127F
		// (set) Token: 0x0600775A RID: 30554 RVA: 0x00123087 File Offset: 0x00121287
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x1700171A RID: 5914
		// (get) Token: 0x0600775B RID: 30555 RVA: 0x00123090 File Offset: 0x00121290
		// (set) Token: 0x0600775C RID: 30556 RVA: 0x00123098 File Offset: 0x00121298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x0600775D RID: 30557 RVA: 0x001230A1 File Offset: 0x001212A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExploreSkillActionResponse);
		}

		// Token: 0x0600775E RID: 30558 RVA: 0x001230AF File Offset: 0x001212AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExploreSkillActionResponse other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600775F RID: 30559 RVA: 0x001230F0 File Offset: 0x001212F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007760 RID: 30560 RVA: 0x0012314E File Offset: 0x0012134E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007761 RID: 30561 RVA: 0x0012315B File Offset: 0x0012135B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007762 RID: 30562 RVA: 0x00123164 File Offset: 0x00121364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.EntityId);
			}
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007763 RID: 30563 RVA: 0x001231C0 File Offset: 0x001213C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007764 RID: 30564 RVA: 0x00123218 File Offset: 0x00121418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExploreSkillActionResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007765 RID: 30565 RVA: 0x00123268 File Offset: 0x00121468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007766 RID: 30566 RVA: 0x00123274 File Offset: 0x00121474
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
				if (num != 48U)
				{
					if (num != 56U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Code = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003E6E RID: 15982
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E6F RID: 15983
		public const int EntityIdFieldNumber = 6;

		// Token: 0x04003E70 RID: 15984
		private long entityId_;

		// Token: 0x04003E71 RID: 15985
		public const int CodeFieldNumber = 7;

		// Token: 0x04003E72 RID: 15986
		private ErrorCode code_;
	}
}
