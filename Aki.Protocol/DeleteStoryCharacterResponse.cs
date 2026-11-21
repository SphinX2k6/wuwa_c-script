using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003AB RID: 939
	[NetMessage(EMessageId.DeleteStoryCharacterResponse)]
	public sealed class DeleteStoryCharacterResponse : IMessage<DeleteStoryCharacterResponse>, IMessage, IEquatable<DeleteStoryCharacterResponse>, IDeepCloneable<DeleteStoryCharacterResponse>, IBufferMessage
	{
		// Token: 0x06005C83 RID: 23683 RVA: 0x000E0D76 File Offset: 0x000DEF76
		[NullableContext(1)]
		public static DeleteStoryCharacterResponse Create()
		{
			return new DeleteStoryCharacterResponse();
		}

		// Token: 0x17001123 RID: 4387
		// (get) Token: 0x06005C84 RID: 23684 RVA: 0x000E0D7D File Offset: 0x000DEF7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001124 RID: 4388
		// (get) Token: 0x06005C85 RID: 23685 RVA: 0x000E0D80 File Offset: 0x000DEF80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DeleteStoryCharacterResponse.Descriptor;
			}
		}

		// Token: 0x06005C86 RID: 23686 RVA: 0x000E0D87 File Offset: 0x000DEF87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeleteStoryCharacterResponse()
		{
		}

		// Token: 0x06005C87 RID: 23687 RVA: 0x000E0D8F File Offset: 0x000DEF8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeleteStoryCharacterResponse(DeleteStoryCharacterResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.fightRoleId_ = other.fightRoleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005C88 RID: 23688 RVA: 0x000E0DC0 File Offset: 0x000DEFC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeleteStoryCharacterResponse Clone()
		{
			return new DeleteStoryCharacterResponse(this);
		}

		// Token: 0x17001125 RID: 4389
		// (get) Token: 0x06005C89 RID: 23689 RVA: 0x000E0DC8 File Offset: 0x000DEFC8
		// (set) Token: 0x06005C8A RID: 23690 RVA: 0x000E0DD0 File Offset: 0x000DEFD0
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

		// Token: 0x17001126 RID: 4390
		// (get) Token: 0x06005C8B RID: 23691 RVA: 0x000E0DD9 File Offset: 0x000DEFD9
		// (set) Token: 0x06005C8C RID: 23692 RVA: 0x000E0DE1 File Offset: 0x000DEFE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FightRoleId
		{
			get
			{
				return this.fightRoleId_;
			}
			set
			{
				this.fightRoleId_ = value;
			}
		}

		// Token: 0x06005C8D RID: 23693 RVA: 0x000E0DEA File Offset: 0x000DEFEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DeleteStoryCharacterResponse);
		}

		// Token: 0x06005C8E RID: 23694 RVA: 0x000E0DF8 File Offset: 0x000DEFF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DeleteStoryCharacterResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.FightRoleId == other.FightRoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005C8F RID: 23695 RVA: 0x000E0E38 File Offset: 0x000DF038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.FightRoleId != 0)
			{
				num ^= this.FightRoleId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005C90 RID: 23696 RVA: 0x000E0E96 File Offset: 0x000DF096
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005C91 RID: 23697 RVA: 0x000E0EA3 File Offset: 0x000DF0A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005C92 RID: 23698 RVA: 0x000E0EAC File Offset: 0x000DF0AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.FightRoleId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.FightRoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005C93 RID: 23699 RVA: 0x000E0F08 File Offset: 0x000DF108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.FightRoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FightRoleId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005C94 RID: 23700 RVA: 0x000E0F60 File Offset: 0x000DF160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DeleteStoryCharacterResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.FightRoleId != 0)
			{
				this.FightRoleId = other.FightRoleId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005C95 RID: 23701 RVA: 0x000E0FB0 File Offset: 0x000DF1B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005C96 RID: 23702 RVA: 0x000E0FBC File Offset: 0x000DF1BC
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
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.FightRoleId = input.ReadInt32();
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400369F RID: 13983
		private UnknownFieldSet _unknownFields;

		// Token: 0x040036A0 RID: 13984
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x040036A1 RID: 13985
		private ErrorCode errorCode_;

		// Token: 0x040036A2 RID: 13986
		public const int FightRoleIdFieldNumber = 13;

		// Token: 0x040036A3 RID: 13987
		private int fightRoleId_;
	}
}
