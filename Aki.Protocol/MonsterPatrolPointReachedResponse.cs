using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A05 RID: 2565
	[NetMessage(EMessageId.MonsterPatrolPointReachedResponse)]
	public sealed class MonsterPatrolPointReachedResponse : IMessage<MonsterPatrolPointReachedResponse>, IMessage, IEquatable<MonsterPatrolPointReachedResponse>, IDeepCloneable<MonsterPatrolPointReachedResponse>, IBufferMessage
	{
		// Token: 0x0600E07A RID: 57466 RVA: 0x0020E483 File Offset: 0x0020C683
		[NullableContext(1)]
		public static MonsterPatrolPointReachedResponse Create()
		{
			return new MonsterPatrolPointReachedResponse();
		}

		// Token: 0x17002D82 RID: 11650
		// (get) Token: 0x0600E07B RID: 57467 RVA: 0x0020E48A File Offset: 0x0020C68A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002D83 RID: 11651
		// (get) Token: 0x0600E07C RID: 57468 RVA: 0x0020E48D File Offset: 0x0020C68D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonsterPatrolPointReachedResponse.Descriptor;
			}
		}

		// Token: 0x0600E07D RID: 57469 RVA: 0x0020E494 File Offset: 0x0020C694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterPatrolPointReachedResponse()
		{
		}

		// Token: 0x0600E07E RID: 57470 RVA: 0x0020E49C File Offset: 0x0020C69C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterPatrolPointReachedResponse(MonsterPatrolPointReachedResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E07F RID: 57471 RVA: 0x0020E4C1 File Offset: 0x0020C6C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterPatrolPointReachedResponse Clone()
		{
			return new MonsterPatrolPointReachedResponse(this);
		}

		// Token: 0x17002D84 RID: 11652
		// (get) Token: 0x0600E080 RID: 57472 RVA: 0x0020E4C9 File Offset: 0x0020C6C9
		// (set) Token: 0x0600E081 RID: 57473 RVA: 0x0020E4D1 File Offset: 0x0020C6D1
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

		// Token: 0x0600E082 RID: 57474 RVA: 0x0020E4DA File Offset: 0x0020C6DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonsterPatrolPointReachedResponse);
		}

		// Token: 0x0600E083 RID: 57475 RVA: 0x0020E4E8 File Offset: 0x0020C6E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonsterPatrolPointReachedResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E084 RID: 57476 RVA: 0x0020E518 File Offset: 0x0020C718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E085 RID: 57477 RVA: 0x0020E55D File Offset: 0x0020C75D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E086 RID: 57478 RVA: 0x0020E56A File Offset: 0x0020C76A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E087 RID: 57479 RVA: 0x0020E573 File Offset: 0x0020C773
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E088 RID: 57480 RVA: 0x0020E5A8 File Offset: 0x0020C7A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E089 RID: 57481 RVA: 0x0020E5E6 File Offset: 0x0020C7E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonsterPatrolPointReachedResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E08A RID: 57482 RVA: 0x0020E617 File Offset: 0x0020C817
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E08B RID: 57483 RVA: 0x0020E620 File Offset: 0x0020C820
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005C67 RID: 23655
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005C68 RID: 23656
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04005C69 RID: 23657
		private ErrorCode errorCode_;
	}
}
