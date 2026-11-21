using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000166 RID: 358
	[NetMessage(EMessageId.BathChangeCameraResponse)]
	public sealed class BathChangeCameraResponse : IMessage<BathChangeCameraResponse>, IMessage, IEquatable<BathChangeCameraResponse>, IDeepCloneable<BathChangeCameraResponse>, IBufferMessage
	{
		// Token: 0x06002CCC RID: 11468 RVA: 0x00074A75 File Offset: 0x00072C75
		[NullableContext(1)]
		public static BathChangeCameraResponse Create()
		{
			return new BathChangeCameraResponse();
		}

		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x06002CCD RID: 11469 RVA: 0x00074A7C File Offset: 0x00072C7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x06002CCE RID: 11470 RVA: 0x00074A7F File Offset: 0x00072C7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BathChangeCameraResponse.Descriptor;
			}
		}

		// Token: 0x06002CCF RID: 11471 RVA: 0x00074A86 File Offset: 0x00072C86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BathChangeCameraResponse()
		{
		}

		// Token: 0x06002CD0 RID: 11472 RVA: 0x00074A8E File Offset: 0x00072C8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BathChangeCameraResponse(BathChangeCameraResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002CD1 RID: 11473 RVA: 0x00074AB3 File Offset: 0x00072CB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BathChangeCameraResponse Clone()
		{
			return new BathChangeCameraResponse(this);
		}

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x06002CD2 RID: 11474 RVA: 0x00074ABB File Offset: 0x00072CBB
		// (set) Token: 0x06002CD3 RID: 11475 RVA: 0x00074AC3 File Offset: 0x00072CC3
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

		// Token: 0x06002CD4 RID: 11476 RVA: 0x00074ACC File Offset: 0x00072CCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BathChangeCameraResponse);
		}

		// Token: 0x06002CD5 RID: 11477 RVA: 0x00074ADA File Offset: 0x00072CDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BathChangeCameraResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002CD6 RID: 11478 RVA: 0x00074B08 File Offset: 0x00072D08
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

		// Token: 0x06002CD7 RID: 11479 RVA: 0x00074B4D File Offset: 0x00072D4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002CD8 RID: 11480 RVA: 0x00074B5A File Offset: 0x00072D5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002CD9 RID: 11481 RVA: 0x00074B63 File Offset: 0x00072D63
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

		// Token: 0x06002CDA RID: 11482 RVA: 0x00074B98 File Offset: 0x00072D98
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

		// Token: 0x06002CDB RID: 11483 RVA: 0x00074BD6 File Offset: 0x00072DD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BathChangeCameraResponse other)
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

		// Token: 0x06002CDC RID: 11484 RVA: 0x00074C07 File Offset: 0x00072E07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002CDD RID: 11485 RVA: 0x00074C10 File Offset: 0x00072E10
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

		// Token: 0x04002866 RID: 10342
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002867 RID: 10343
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04002868 RID: 10344
		private ErrorCode errorCode_;
	}
}
