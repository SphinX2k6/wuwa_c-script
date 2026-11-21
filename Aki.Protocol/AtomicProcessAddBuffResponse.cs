using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200011C RID: 284
	[NetMessage(EMessageId.AtomicProcessAddBuffResponse)]
	public sealed class AtomicProcessAddBuffResponse : IMessage<AtomicProcessAddBuffResponse>, IMessage, IEquatable<AtomicProcessAddBuffResponse>, IDeepCloneable<AtomicProcessAddBuffResponse>, IBufferMessage
	{
		// Token: 0x060026C4 RID: 9924 RVA: 0x00067116 File Offset: 0x00065316
		[NullableContext(1)]
		public static AtomicProcessAddBuffResponse Create()
		{
			return new AtomicProcessAddBuffResponse();
		}

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x060026C5 RID: 9925 RVA: 0x0006711D File Offset: 0x0006531D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x060026C6 RID: 9926 RVA: 0x00067120 File Offset: 0x00065320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AtomicProcessAddBuffResponse.Descriptor;
			}
		}

		// Token: 0x060026C7 RID: 9927 RVA: 0x00067127 File Offset: 0x00065327
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AtomicProcessAddBuffResponse()
		{
		}

		// Token: 0x060026C8 RID: 9928 RVA: 0x0006712F File Offset: 0x0006532F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AtomicProcessAddBuffResponse(AtomicProcessAddBuffResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060026C9 RID: 9929 RVA: 0x00067154 File Offset: 0x00065354
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AtomicProcessAddBuffResponse Clone()
		{
			return new AtomicProcessAddBuffResponse(this);
		}

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x060026CA RID: 9930 RVA: 0x0006715C File Offset: 0x0006535C
		// (set) Token: 0x060026CB RID: 9931 RVA: 0x00067164 File Offset: 0x00065364
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

		// Token: 0x060026CC RID: 9932 RVA: 0x0006716D File Offset: 0x0006536D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AtomicProcessAddBuffResponse);
		}

		// Token: 0x060026CD RID: 9933 RVA: 0x0006717B File Offset: 0x0006537B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AtomicProcessAddBuffResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060026CE RID: 9934 RVA: 0x000671AC File Offset: 0x000653AC
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

		// Token: 0x060026CF RID: 9935 RVA: 0x000671F1 File Offset: 0x000653F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060026D0 RID: 9936 RVA: 0x000671FE File Offset: 0x000653FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060026D1 RID: 9937 RVA: 0x00067207 File Offset: 0x00065407
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorId != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060026D2 RID: 9938 RVA: 0x0006723C File Offset: 0x0006543C
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

		// Token: 0x060026D3 RID: 9939 RVA: 0x0006727A File Offset: 0x0006547A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AtomicProcessAddBuffResponse other)
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

		// Token: 0x060026D4 RID: 9940 RVA: 0x000672AB File Offset: 0x000654AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060026D5 RID: 9941 RVA: 0x000672B4 File Offset: 0x000654B4
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorId = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002680 RID: 9856
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002681 RID: 9857
		public const int ErrorIdFieldNumber = 12;

		// Token: 0x04002682 RID: 9858
		private ErrorCode errorId_;
	}
}
