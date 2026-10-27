using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B7B RID: 2939
	[NetMessage(EMessageId.NpcTraceFailedResponse)]
	public sealed class NpcTraceFailedResponse : IMessage<NpcTraceFailedResponse>, IMessage, IEquatable<NpcTraceFailedResponse>, IDeepCloneable<NpcTraceFailedResponse>, IBufferMessage
	{
		// Token: 0x0600FEC0 RID: 65216 RVA: 0x002528B7 File Offset: 0x00250AB7
		[NullableContext(1)]
		public static NpcTraceFailedResponse Create()
		{
			return new NpcTraceFailedResponse();
		}

		// Token: 0x17003403 RID: 13315
		// (get) Token: 0x0600FEC1 RID: 65217 RVA: 0x002528BE File Offset: 0x00250ABE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003404 RID: 13316
		// (get) Token: 0x0600FEC2 RID: 65218 RVA: 0x002528C1 File Offset: 0x00250AC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NpcTraceFailedResponse.Descriptor;
			}
		}

		// Token: 0x0600FEC3 RID: 65219 RVA: 0x002528C8 File Offset: 0x00250AC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcTraceFailedResponse()
		{
		}

		// Token: 0x0600FEC4 RID: 65220 RVA: 0x002528D0 File Offset: 0x00250AD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcTraceFailedResponse(NpcTraceFailedResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FEC5 RID: 65221 RVA: 0x002528F5 File Offset: 0x00250AF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcTraceFailedResponse Clone()
		{
			return new NpcTraceFailedResponse(this);
		}

		// Token: 0x17003405 RID: 13317
		// (get) Token: 0x0600FEC6 RID: 65222 RVA: 0x002528FD File Offset: 0x00250AFD
		// (set) Token: 0x0600FEC7 RID: 65223 RVA: 0x00252905 File Offset: 0x00250B05
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

		// Token: 0x0600FEC8 RID: 65224 RVA: 0x0025290E File Offset: 0x00250B0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NpcTraceFailedResponse);
		}

		// Token: 0x0600FEC9 RID: 65225 RVA: 0x0025291C File Offset: 0x00250B1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NpcTraceFailedResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FECA RID: 65226 RVA: 0x0025294C File Offset: 0x00250B4C
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

		// Token: 0x0600FECB RID: 65227 RVA: 0x00252991 File Offset: 0x00250B91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FECC RID: 65228 RVA: 0x0025299E File Offset: 0x00250B9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FECD RID: 65229 RVA: 0x002529A7 File Offset: 0x00250BA7
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

		// Token: 0x0600FECE RID: 65230 RVA: 0x002529DC File Offset: 0x00250BDC
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

		// Token: 0x0600FECF RID: 65231 RVA: 0x00252A1A File Offset: 0x00250C1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NpcTraceFailedResponse other)
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

		// Token: 0x0600FED0 RID: 65232 RVA: 0x00252A4B File Offset: 0x00250C4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FED1 RID: 65233 RVA: 0x00252A54 File Offset: 0x00250C54
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

		// Token: 0x04006587 RID: 25991
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006588 RID: 25992
		public const int ErrorIdFieldNumber = 6;

		// Token: 0x04006589 RID: 25993
		private ErrorCode errorId_;
	}
}
