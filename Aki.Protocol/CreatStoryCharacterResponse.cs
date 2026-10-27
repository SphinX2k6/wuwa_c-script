using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000317 RID: 791
	[NetMessage(EMessageId.CreatStoryCharacterResponse)]
	public sealed class CreatStoryCharacterResponse : IMessage<CreatStoryCharacterResponse>, IMessage, IEquatable<CreatStoryCharacterResponse>, IDeepCloneable<CreatStoryCharacterResponse>, IBufferMessage
	{
		// Token: 0x06004FC5 RID: 20421 RVA: 0x000C29BA File Offset: 0x000C0BBA
		[NullableContext(1)]
		public static CreatStoryCharacterResponse Create()
		{
			return new CreatStoryCharacterResponse();
		}

		// Token: 0x17000E47 RID: 3655
		// (get) Token: 0x06004FC6 RID: 20422 RVA: 0x000C29C1 File Offset: 0x000C0BC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000E48 RID: 3656
		// (get) Token: 0x06004FC7 RID: 20423 RVA: 0x000C29C4 File Offset: 0x000C0BC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CreatStoryCharacterResponse.Descriptor;
			}
		}

		// Token: 0x06004FC8 RID: 20424 RVA: 0x000C29CB File Offset: 0x000C0BCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CreatStoryCharacterResponse()
		{
		}

		// Token: 0x06004FC9 RID: 20425 RVA: 0x000C29D3 File Offset: 0x000C0BD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CreatStoryCharacterResponse(CreatStoryCharacterResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004FCA RID: 20426 RVA: 0x000C2A04 File Offset: 0x000C0C04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CreatStoryCharacterResponse Clone()
		{
			return new CreatStoryCharacterResponse(this);
		}

		// Token: 0x17000E49 RID: 3657
		// (get) Token: 0x06004FCB RID: 20427 RVA: 0x000C2A0C File Offset: 0x000C0C0C
		// (set) Token: 0x06004FCC RID: 20428 RVA: 0x000C2A14 File Offset: 0x000C0C14
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

		// Token: 0x17000E4A RID: 3658
		// (get) Token: 0x06004FCD RID: 20429 RVA: 0x000C2A1D File Offset: 0x000C0C1D
		// (set) Token: 0x06004FCE RID: 20430 RVA: 0x000C2A25 File Offset: 0x000C0C25
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

		// Token: 0x06004FCF RID: 20431 RVA: 0x000C2A2E File Offset: 0x000C0C2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CreatStoryCharacterResponse);
		}

		// Token: 0x06004FD0 RID: 20432 RVA: 0x000C2A3C File Offset: 0x000C0C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CreatStoryCharacterResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004FD1 RID: 20433 RVA: 0x000C2A7C File Offset: 0x000C0C7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004FD2 RID: 20434 RVA: 0x000C2ADA File Offset: 0x000C0CDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004FD3 RID: 20435 RVA: 0x000C2AE7 File Offset: 0x000C0CE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004FD4 RID: 20436 RVA: 0x000C2AF0 File Offset: 0x000C0CF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.EntityId);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004FD5 RID: 20437 RVA: 0x000C2B4C File Offset: 0x000C0D4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004FD6 RID: 20438 RVA: 0x000C2BA4 File Offset: 0x000C0DA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CreatStoryCharacterResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004FD7 RID: 20439 RVA: 0x000C2BF4 File Offset: 0x000C0DF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004FD8 RID: 20440 RVA: 0x000C2C00 File Offset: 0x000C0E00
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
				if (num != 24U)
				{
					if (num != 96U)
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
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400322C RID: 12844
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400322D RID: 12845
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x0400322E RID: 12846
		private ErrorCode errorCode_;

		// Token: 0x0400322F RID: 12847
		public const int EntityIdFieldNumber = 3;

		// Token: 0x04003230 RID: 12848
		private long entityId_;
	}
}
