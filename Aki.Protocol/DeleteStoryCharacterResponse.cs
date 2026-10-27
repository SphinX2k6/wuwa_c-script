using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003C2 RID: 962
	[NetMessage(EMessageId.DeleteStoryCharacterResponse)]
	public sealed class DeleteStoryCharacterResponse : IMessage<DeleteStoryCharacterResponse>, IMessage, IEquatable<DeleteStoryCharacterResponse>, IDeepCloneable<DeleteStoryCharacterResponse>, IBufferMessage
	{
		// Token: 0x06005E13 RID: 24083 RVA: 0x000E3EFA File Offset: 0x000E20FA
		[NullableContext(1)]
		public static DeleteStoryCharacterResponse Create()
		{
			return new DeleteStoryCharacterResponse();
		}

		// Token: 0x17001178 RID: 4472
		// (get) Token: 0x06005E14 RID: 24084 RVA: 0x000E3F01 File Offset: 0x000E2101
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001179 RID: 4473
		// (get) Token: 0x06005E15 RID: 24085 RVA: 0x000E3F04 File Offset: 0x000E2104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DeleteStoryCharacterResponse.Descriptor;
			}
		}

		// Token: 0x06005E16 RID: 24086 RVA: 0x000E3F0B File Offset: 0x000E210B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeleteStoryCharacterResponse()
		{
		}

		// Token: 0x06005E17 RID: 24087 RVA: 0x000E3F13 File Offset: 0x000E2113
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeleteStoryCharacterResponse(DeleteStoryCharacterResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.fightRoleId_ = other.fightRoleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005E18 RID: 24088 RVA: 0x000E3F44 File Offset: 0x000E2144
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeleteStoryCharacterResponse Clone()
		{
			return new DeleteStoryCharacterResponse(this);
		}

		// Token: 0x1700117A RID: 4474
		// (get) Token: 0x06005E19 RID: 24089 RVA: 0x000E3F4C File Offset: 0x000E214C
		// (set) Token: 0x06005E1A RID: 24090 RVA: 0x000E3F54 File Offset: 0x000E2154
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

		// Token: 0x1700117B RID: 4475
		// (get) Token: 0x06005E1B RID: 24091 RVA: 0x000E3F5D File Offset: 0x000E215D
		// (set) Token: 0x06005E1C RID: 24092 RVA: 0x000E3F65 File Offset: 0x000E2165
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

		// Token: 0x06005E1D RID: 24093 RVA: 0x000E3F6E File Offset: 0x000E216E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DeleteStoryCharacterResponse);
		}

		// Token: 0x06005E1E RID: 24094 RVA: 0x000E3F7C File Offset: 0x000E217C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DeleteStoryCharacterResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.FightRoleId == other.FightRoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005E1F RID: 24095 RVA: 0x000E3FBC File Offset: 0x000E21BC
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

		// Token: 0x06005E20 RID: 24096 RVA: 0x000E401A File Offset: 0x000E221A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005E21 RID: 24097 RVA: 0x000E4027 File Offset: 0x000E2227
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005E22 RID: 24098 RVA: 0x000E4030 File Offset: 0x000E2230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.FightRoleId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.FightRoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005E23 RID: 24099 RVA: 0x000E408C File Offset: 0x000E228C
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

		// Token: 0x06005E24 RID: 24100 RVA: 0x000E40E4 File Offset: 0x000E22E4
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

		// Token: 0x06005E25 RID: 24101 RVA: 0x000E4134 File Offset: 0x000E2334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005E26 RID: 24102 RVA: 0x000E4140 File Offset: 0x000E2340
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
					if (num != 80U)
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

		// Token: 0x040036B2 RID: 14002
		private UnknownFieldSet _unknownFields;

		// Token: 0x040036B3 RID: 14003
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x040036B4 RID: 14004
		private ErrorCode errorCode_;

		// Token: 0x040036B5 RID: 14005
		public const int FightRoleIdFieldNumber = 10;

		// Token: 0x040036B6 RID: 14006
		private int fightRoleId_;
	}
}
