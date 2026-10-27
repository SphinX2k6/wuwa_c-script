using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200113E RID: 4414
	[NetMessage(EMessageId.RunTestResponse)]
	public sealed class RunTestResponse : IMessage<RunTestResponse>, IMessage, IEquatable<RunTestResponse>, IDeepCloneable<RunTestResponse>, IBufferMessage
	{
		// Token: 0x0601789A RID: 96410 RVA: 0x0036AF78 File Offset: 0x00369178
		[NullableContext(1)]
		public static RunTestResponse Create()
		{
			return new RunTestResponse();
		}

		// Token: 0x17004EFE RID: 20222
		// (get) Token: 0x0601789B RID: 96411 RVA: 0x0036AF7F File Offset: 0x0036917F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004EFF RID: 20223
		// (get) Token: 0x0601789C RID: 96412 RVA: 0x0036AF82 File Offset: 0x00369182
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RunTestResponse.Descriptor;
			}
		}

		// Token: 0x0601789D RID: 96413 RVA: 0x0036AF89 File Offset: 0x00369189
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RunTestResponse()
		{
		}

		// Token: 0x0601789E RID: 96414 RVA: 0x0036AF91 File Offset: 0x00369191
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RunTestResponse(RunTestResponse other) : this()
		{
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601789F RID: 96415 RVA: 0x0036AFB6 File Offset: 0x003691B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RunTestResponse Clone()
		{
			return new RunTestResponse(this);
		}

		// Token: 0x17004F00 RID: 20224
		// (get) Token: 0x060178A0 RID: 96416 RVA: 0x0036AFBE File Offset: 0x003691BE
		// (set) Token: 0x060178A1 RID: 96417 RVA: 0x0036AFC6 File Offset: 0x003691C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x060178A2 RID: 96418 RVA: 0x0036AFCF File Offset: 0x003691CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RunTestResponse);
		}

		// Token: 0x060178A3 RID: 96419 RVA: 0x0036AFDD File Offset: 0x003691DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RunTestResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060178A4 RID: 96420 RVA: 0x0036B00C File Offset: 0x0036920C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060178A5 RID: 96421 RVA: 0x0036B051 File Offset: 0x00369251
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060178A6 RID: 96422 RVA: 0x0036B05E File Offset: 0x0036925E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060178A7 RID: 96423 RVA: 0x0036B067 File Offset: 0x00369267
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060178A8 RID: 96424 RVA: 0x0036B09C File Offset: 0x0036929C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060178A9 RID: 96425 RVA: 0x0036B0DA File Offset: 0x003692DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RunTestResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060178AA RID: 96426 RVA: 0x0036B10B File Offset: 0x0036930B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060178AB RID: 96427 RVA: 0x0036B114 File Offset: 0x00369314
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
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008BD2 RID: 35794
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008BD3 RID: 35795
		public const int CodeFieldNumber = 13;

		// Token: 0x04008BD4 RID: 35796
		private ErrorCode code_;
	}
}
