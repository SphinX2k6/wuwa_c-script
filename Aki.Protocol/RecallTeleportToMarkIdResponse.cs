using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EBA RID: 3770
	[NetMessage(EMessageId.RecallTeleportToMarkIdResponse)]
	public sealed class RecallTeleportToMarkIdResponse : IMessage<RecallTeleportToMarkIdResponse>, IMessage, IEquatable<RecallTeleportToMarkIdResponse>, IDeepCloneable<RecallTeleportToMarkIdResponse>, IBufferMessage
	{
		// Token: 0x060143E0 RID: 82912 RVA: 0x002F1C9D File Offset: 0x002EFE9D
		[NullableContext(1)]
		public static RecallTeleportToMarkIdResponse Create()
		{
			return new RecallTeleportToMarkIdResponse();
		}

		// Token: 0x1700434F RID: 17231
		// (get) Token: 0x060143E1 RID: 82913 RVA: 0x002F1CA4 File Offset: 0x002EFEA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004350 RID: 17232
		// (get) Token: 0x060143E2 RID: 82914 RVA: 0x002F1CA7 File Offset: 0x002EFEA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecallTeleportToMarkIdResponse.Descriptor;
			}
		}

		// Token: 0x060143E3 RID: 82915 RVA: 0x002F1CAE File Offset: 0x002EFEAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallTeleportToMarkIdResponse()
		{
		}

		// Token: 0x060143E4 RID: 82916 RVA: 0x002F1CB6 File Offset: 0x002EFEB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallTeleportToMarkIdResponse(RecallTeleportToMarkIdResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060143E5 RID: 82917 RVA: 0x002F1CDB File Offset: 0x002EFEDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallTeleportToMarkIdResponse Clone()
		{
			return new RecallTeleportToMarkIdResponse(this);
		}

		// Token: 0x17004351 RID: 17233
		// (get) Token: 0x060143E6 RID: 82918 RVA: 0x002F1CE3 File Offset: 0x002EFEE3
		// (set) Token: 0x060143E7 RID: 82919 RVA: 0x002F1CEB File Offset: 0x002EFEEB
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

		// Token: 0x060143E8 RID: 82920 RVA: 0x002F1CF4 File Offset: 0x002EFEF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecallTeleportToMarkIdResponse);
		}

		// Token: 0x060143E9 RID: 82921 RVA: 0x002F1D02 File Offset: 0x002EFF02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecallTeleportToMarkIdResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060143EA RID: 82922 RVA: 0x002F1D30 File Offset: 0x002EFF30
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

		// Token: 0x060143EB RID: 82923 RVA: 0x002F1D75 File Offset: 0x002EFF75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060143EC RID: 82924 RVA: 0x002F1D82 File Offset: 0x002EFF82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060143ED RID: 82925 RVA: 0x002F1D8B File Offset: 0x002EFF8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorId != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060143EE RID: 82926 RVA: 0x002F1DC0 File Offset: 0x002EFFC0
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

		// Token: 0x060143EF RID: 82927 RVA: 0x002F1DFE File Offset: 0x002EFFFE
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

		// Token: 0x060143F0 RID: 82928 RVA: 0x002F1E2F File Offset: 0x002F002F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060143F1 RID: 82929 RVA: 0x002F1E38 File Offset: 0x002F0038
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorId = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007B79 RID: 31609
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007B7A RID: 31610
		public const int ErrorIdFieldNumber = 4;

		// Token: 0x04007B7B RID: 31611
		private ErrorCode errorId_;
	}
}
