using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000ECA RID: 3786
	[NetMessage(EMessageId.RecallTeleportToMarkIdResponse)]
	public sealed class RecallTeleportToMarkIdResponse : IMessage<RecallTeleportToMarkIdResponse>, IMessage, IEquatable<RecallTeleportToMarkIdResponse>, IDeepCloneable<RecallTeleportToMarkIdResponse>, IBufferMessage
	{
		// Token: 0x060144C5 RID: 83141 RVA: 0x002F3351 File Offset: 0x002F1551
		[NullableContext(1)]
		public static RecallTeleportToMarkIdResponse Create()
		{
			return new RecallTeleportToMarkIdResponse();
		}

		// Token: 0x17004379 RID: 17273
		// (get) Token: 0x060144C6 RID: 83142 RVA: 0x002F3358 File Offset: 0x002F1558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700437A RID: 17274
		// (get) Token: 0x060144C7 RID: 83143 RVA: 0x002F335B File Offset: 0x002F155B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecallTeleportToMarkIdResponse.Descriptor;
			}
		}

		// Token: 0x060144C8 RID: 83144 RVA: 0x002F3362 File Offset: 0x002F1562
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallTeleportToMarkIdResponse()
		{
		}

		// Token: 0x060144C9 RID: 83145 RVA: 0x002F336A File Offset: 0x002F156A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallTeleportToMarkIdResponse(RecallTeleportToMarkIdResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060144CA RID: 83146 RVA: 0x002F338F File Offset: 0x002F158F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallTeleportToMarkIdResponse Clone()
		{
			return new RecallTeleportToMarkIdResponse(this);
		}

		// Token: 0x1700437B RID: 17275
		// (get) Token: 0x060144CB RID: 83147 RVA: 0x002F3397 File Offset: 0x002F1597
		// (set) Token: 0x060144CC RID: 83148 RVA: 0x002F339F File Offset: 0x002F159F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorId
		{
			get
			{
				return this.errorId_;
			}
			set
			{
				this.errorId_ = value;
			}
		}

		// Token: 0x060144CD RID: 83149 RVA: 0x002F33A8 File Offset: 0x002F15A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecallTeleportToMarkIdResponse);
		}

		// Token: 0x060144CE RID: 83150 RVA: 0x002F33B6 File Offset: 0x002F15B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecallTeleportToMarkIdResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060144CF RID: 83151 RVA: 0x002F33E4 File Offset: 0x002F15E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorId != ErrorCode.Success)
			{
				num ^= this.ErrorId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060144D0 RID: 83152 RVA: 0x002F3429 File Offset: 0x002F1629
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060144D1 RID: 83153 RVA: 0x002F3436 File Offset: 0x002F1636
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060144D2 RID: 83154 RVA: 0x002F343F File Offset: 0x002F163F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorId != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060144D3 RID: 83155 RVA: 0x002F3474 File Offset: 0x002F1674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorId != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060144D4 RID: 83156 RVA: 0x002F34B2 File Offset: 0x002F16B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RecallTeleportToMarkIdResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorId != ErrorCode.Success)
			{
				this.ErrorId = other.ErrorId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060144D5 RID: 83157 RVA: 0x002F34E3 File Offset: 0x002F16E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060144D6 RID: 83158 RVA: 0x002F34EC File Offset: 0x002F16EC
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorId = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007B4F RID: 31567
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007B50 RID: 31568
		public const int ErrorIdFieldNumber = 6;

		// Token: 0x04007B51 RID: 31569
		private ErrorCode errorId_;
	}
}
