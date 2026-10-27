using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200009E RID: 158
	[NetMessage(EMessageId.AddChapterResultResponse)]
	public sealed class AddChapterResultResponse : IMessage<AddChapterResultResponse>, IMessage, IEquatable<AddChapterResultResponse>, IDeepCloneable<AddChapterResultResponse>, IBufferMessage
	{
		// Token: 0x06001C19 RID: 7193 RVA: 0x0004E23B File Offset: 0x0004C43B
		[NullableContext(1)]
		public static AddChapterResultResponse Create()
		{
			return new AddChapterResultResponse();
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06001C1A RID: 7194 RVA: 0x0004E242 File Offset: 0x0004C442
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06001C1B RID: 7195 RVA: 0x0004E245 File Offset: 0x0004C445
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AddChapterResultResponse.Descriptor;
			}
		}

		// Token: 0x06001C1C RID: 7196 RVA: 0x0004E24C File Offset: 0x0004C44C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddChapterResultResponse()
		{
		}

		// Token: 0x06001C1D RID: 7197 RVA: 0x0004E254 File Offset: 0x0004C454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddChapterResultResponse(AddChapterResultResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001C1E RID: 7198 RVA: 0x0004E279 File Offset: 0x0004C479
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddChapterResultResponse Clone()
		{
			return new AddChapterResultResponse(this);
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06001C1F RID: 7199 RVA: 0x0004E281 File Offset: 0x0004C481
		// (set) Token: 0x06001C20 RID: 7200 RVA: 0x0004E289 File Offset: 0x0004C489
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

		// Token: 0x06001C21 RID: 7201 RVA: 0x0004E292 File Offset: 0x0004C492
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AddChapterResultResponse);
		}

		// Token: 0x06001C22 RID: 7202 RVA: 0x0004E2A0 File Offset: 0x0004C4A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AddChapterResultResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001C23 RID: 7203 RVA: 0x0004E2D0 File Offset: 0x0004C4D0
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

		// Token: 0x06001C24 RID: 7204 RVA: 0x0004E315 File Offset: 0x0004C515
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001C25 RID: 7205 RVA: 0x0004E322 File Offset: 0x0004C522
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001C26 RID: 7206 RVA: 0x0004E32B File Offset: 0x0004C52B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001C27 RID: 7207 RVA: 0x0004E360 File Offset: 0x0004C560
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

		// Token: 0x06001C28 RID: 7208 RVA: 0x0004E39E File Offset: 0x0004C59E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AddChapterResultResponse other)
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

		// Token: 0x06001C29 RID: 7209 RVA: 0x0004E3CF File Offset: 0x0004C5CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001C2A RID: 7210 RVA: 0x0004E3D8 File Offset: 0x0004C5D8
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040022C7 RID: 8903
		private UnknownFieldSet _unknownFields;

		// Token: 0x040022C8 RID: 8904
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x040022C9 RID: 8905
		private ErrorCode errorCode_;
	}
}
