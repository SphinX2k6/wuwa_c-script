using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001210 RID: 4624
	[NetMessage(EMessageId.SetInitTagResponse)]
	public sealed class SetInitTagResponse : IMessage<SetInitTagResponse>, IMessage, IEquatable<SetInitTagResponse>, IDeepCloneable<SetInitTagResponse>, IBufferMessage
	{
		// Token: 0x06018B33 RID: 101171 RVA: 0x00399EB5 File Offset: 0x003980B5
		[NullableContext(1)]
		public static SetInitTagResponse Create()
		{
			return new SetInitTagResponse();
		}

		// Token: 0x17005368 RID: 21352
		// (get) Token: 0x06018B34 RID: 101172 RVA: 0x00399EBC File Offset: 0x003980BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005369 RID: 21353
		// (get) Token: 0x06018B35 RID: 101173 RVA: 0x00399EBF File Offset: 0x003980BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetInitTagResponse.Descriptor;
			}
		}

		// Token: 0x06018B36 RID: 101174 RVA: 0x00399EC6 File Offset: 0x003980C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetInitTagResponse()
		{
		}

		// Token: 0x06018B37 RID: 101175 RVA: 0x00399ECE File Offset: 0x003980CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetInitTagResponse(SetInitTagResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018B38 RID: 101176 RVA: 0x00399EF3 File Offset: 0x003980F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetInitTagResponse Clone()
		{
			return new SetInitTagResponse(this);
		}

		// Token: 0x1700536A RID: 21354
		// (get) Token: 0x06018B39 RID: 101177 RVA: 0x00399EFB File Offset: 0x003980FB
		// (set) Token: 0x06018B3A RID: 101178 RVA: 0x00399F03 File Offset: 0x00398103
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

		// Token: 0x06018B3B RID: 101179 RVA: 0x00399F0C File Offset: 0x0039810C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetInitTagResponse);
		}

		// Token: 0x06018B3C RID: 101180 RVA: 0x00399F1A File Offset: 0x0039811A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetInitTagResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018B3D RID: 101181 RVA: 0x00399F48 File Offset: 0x00398148
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

		// Token: 0x06018B3E RID: 101182 RVA: 0x00399F8D File Offset: 0x0039818D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018B3F RID: 101183 RVA: 0x00399F9A File Offset: 0x0039819A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018B40 RID: 101184 RVA: 0x00399FA3 File Offset: 0x003981A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018B41 RID: 101185 RVA: 0x00399FD8 File Offset: 0x003981D8
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

		// Token: 0x06018B42 RID: 101186 RVA: 0x0039A016 File Offset: 0x00398216
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetInitTagResponse other)
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

		// Token: 0x06018B43 RID: 101187 RVA: 0x0039A047 File Offset: 0x00398247
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018B44 RID: 101188 RVA: 0x0039A050 File Offset: 0x00398250
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040092AB RID: 37547
		private UnknownFieldSet _unknownFields;

		// Token: 0x040092AC RID: 37548
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x040092AD RID: 37549
		private ErrorCode errorCode_;
	}
}
