using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006F1 RID: 1777
	[NetMessage(EMessageId.GolemCrackUpdateResponse)]
	public sealed class GolemCrackUpdateResponse : IMessage<GolemCrackUpdateResponse>, IMessage, IEquatable<GolemCrackUpdateResponse>, IDeepCloneable<GolemCrackUpdateResponse>, IBufferMessage
	{
		// Token: 0x0600A236 RID: 41526 RVA: 0x00188693 File Offset: 0x00186893
		[NullableContext(1)]
		public static GolemCrackUpdateResponse Create()
		{
			return new GolemCrackUpdateResponse();
		}

		// Token: 0x17002096 RID: 8342
		// (get) Token: 0x0600A237 RID: 41527 RVA: 0x0018869A File Offset: 0x0018689A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002097 RID: 8343
		// (get) Token: 0x0600A238 RID: 41528 RVA: 0x0018869D File Offset: 0x0018689D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GolemCrackUpdateResponse.Descriptor;
			}
		}

		// Token: 0x0600A239 RID: 41529 RVA: 0x001886A4 File Offset: 0x001868A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GolemCrackUpdateResponse()
		{
		}

		// Token: 0x0600A23A RID: 41530 RVA: 0x001886AC File Offset: 0x001868AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GolemCrackUpdateResponse(GolemCrackUpdateResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A23B RID: 41531 RVA: 0x001886D1 File Offset: 0x001868D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GolemCrackUpdateResponse Clone()
		{
			return new GolemCrackUpdateResponse(this);
		}

		// Token: 0x17002098 RID: 8344
		// (get) Token: 0x0600A23C RID: 41532 RVA: 0x001886D9 File Offset: 0x001868D9
		// (set) Token: 0x0600A23D RID: 41533 RVA: 0x001886E1 File Offset: 0x001868E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrCode
		{
			get
			{
				return this.errCode_;
			}
			set
			{
				this.errCode_ = value;
			}
		}

		// Token: 0x0600A23E RID: 41534 RVA: 0x001886EA File Offset: 0x001868EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GolemCrackUpdateResponse);
		}

		// Token: 0x0600A23F RID: 41535 RVA: 0x001886F8 File Offset: 0x001868F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GolemCrackUpdateResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A240 RID: 41536 RVA: 0x00188728 File Offset: 0x00186928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A241 RID: 41537 RVA: 0x0018876D File Offset: 0x0018696D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A242 RID: 41538 RVA: 0x0018877A File Offset: 0x0018697A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A243 RID: 41539 RVA: 0x00188783 File Offset: 0x00186983
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A244 RID: 41540 RVA: 0x001887B8 File Offset: 0x001869B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A245 RID: 41541 RVA: 0x001887F6 File Offset: 0x001869F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GolemCrackUpdateResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A246 RID: 41542 RVA: 0x00188827 File Offset: 0x00186A27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A247 RID: 41543 RVA: 0x00188830 File Offset: 0x00186A30
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004B89 RID: 19337
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004B8A RID: 19338
		public const int ErrCodeFieldNumber = 13;

		// Token: 0x04004B8B RID: 19339
		private ErrorCode errCode_;
	}
}
