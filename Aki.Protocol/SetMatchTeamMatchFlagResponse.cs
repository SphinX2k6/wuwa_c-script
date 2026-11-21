using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001212 RID: 4626
	[NetMessage(EMessageId.SetMatchTeamMatchFlagResponse)]
	public sealed class SetMatchTeamMatchFlagResponse : IMessage<SetMatchTeamMatchFlagResponse>, IMessage, IEquatable<SetMatchTeamMatchFlagResponse>, IDeepCloneable<SetMatchTeamMatchFlagResponse>, IBufferMessage
	{
		// Token: 0x06018B57 RID: 101207 RVA: 0x0039A261 File Offset: 0x00398461
		[NullableContext(1)]
		public static SetMatchTeamMatchFlagResponse Create()
		{
			return new SetMatchTeamMatchFlagResponse();
		}

		// Token: 0x1700536E RID: 21358
		// (get) Token: 0x06018B58 RID: 101208 RVA: 0x0039A268 File Offset: 0x00398468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700536F RID: 21359
		// (get) Token: 0x06018B59 RID: 101209 RVA: 0x0039A26B File Offset: 0x0039846B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetMatchTeamMatchFlagResponse.Descriptor;
			}
		}

		// Token: 0x06018B5A RID: 101210 RVA: 0x0039A272 File Offset: 0x00398472
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetMatchTeamMatchFlagResponse()
		{
		}

		// Token: 0x06018B5B RID: 101211 RVA: 0x0039A27A File Offset: 0x0039847A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetMatchTeamMatchFlagResponse(SetMatchTeamMatchFlagResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018B5C RID: 101212 RVA: 0x0039A29F File Offset: 0x0039849F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetMatchTeamMatchFlagResponse Clone()
		{
			return new SetMatchTeamMatchFlagResponse(this);
		}

		// Token: 0x17005370 RID: 21360
		// (get) Token: 0x06018B5D RID: 101213 RVA: 0x0039A2A7 File Offset: 0x003984A7
		// (set) Token: 0x06018B5E RID: 101214 RVA: 0x0039A2AF File Offset: 0x003984AF
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

		// Token: 0x06018B5F RID: 101215 RVA: 0x0039A2B8 File Offset: 0x003984B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetMatchTeamMatchFlagResponse);
		}

		// Token: 0x06018B60 RID: 101216 RVA: 0x0039A2C6 File Offset: 0x003984C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetMatchTeamMatchFlagResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018B61 RID: 101217 RVA: 0x0039A2F4 File Offset: 0x003984F4
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

		// Token: 0x06018B62 RID: 101218 RVA: 0x0039A339 File Offset: 0x00398539
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018B63 RID: 101219 RVA: 0x0039A346 File Offset: 0x00398546
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018B64 RID: 101220 RVA: 0x0039A34F File Offset: 0x0039854F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018B65 RID: 101221 RVA: 0x0039A384 File Offset: 0x00398584
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

		// Token: 0x06018B66 RID: 101222 RVA: 0x0039A3C2 File Offset: 0x003985C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetMatchTeamMatchFlagResponse other)
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

		// Token: 0x06018B67 RID: 101223 RVA: 0x0039A3F3 File Offset: 0x003985F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018B68 RID: 101224 RVA: 0x0039A3FC File Offset: 0x003985FC
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040092B1 RID: 37553
		private UnknownFieldSet _unknownFields;

		// Token: 0x040092B2 RID: 37554
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x040092B3 RID: 37555
		private ErrorCode errorCode_;
	}
}
