using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003DA RID: 986
	[NetMessage(EMessageId.DollGrabPauseEndResponse)]
	public sealed class DollGrabPauseEndResponse : IMessage<DollGrabPauseEndResponse>, IMessage, IEquatable<DollGrabPauseEndResponse>, IDeepCloneable<DollGrabPauseEndResponse>, IBufferMessage
	{
		// Token: 0x06006031 RID: 24625 RVA: 0x000E8A39 File Offset: 0x000E6C39
		[NullableContext(1)]
		public static DollGrabPauseEndResponse Create()
		{
			return new DollGrabPauseEndResponse();
		}

		// Token: 0x170011E3 RID: 4579
		// (get) Token: 0x06006032 RID: 24626 RVA: 0x000E8A40 File Offset: 0x000E6C40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170011E4 RID: 4580
		// (get) Token: 0x06006033 RID: 24627 RVA: 0x000E8A43 File Offset: 0x000E6C43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DollGrabPauseEndResponse.Descriptor;
			}
		}

		// Token: 0x06006034 RID: 24628 RVA: 0x000E8A4A File Offset: 0x000E6C4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGrabPauseEndResponse()
		{
		}

		// Token: 0x06006035 RID: 24629 RVA: 0x000E8A52 File Offset: 0x000E6C52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGrabPauseEndResponse(DollGrabPauseEndResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006036 RID: 24630 RVA: 0x000E8A77 File Offset: 0x000E6C77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGrabPauseEndResponse Clone()
		{
			return new DollGrabPauseEndResponse(this);
		}

		// Token: 0x170011E5 RID: 4581
		// (get) Token: 0x06006037 RID: 24631 RVA: 0x000E8A7F File Offset: 0x000E6C7F
		// (set) Token: 0x06006038 RID: 24632 RVA: 0x000E8A87 File Offset: 0x000E6C87
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

		// Token: 0x06006039 RID: 24633 RVA: 0x000E8A90 File Offset: 0x000E6C90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DollGrabPauseEndResponse);
		}

		// Token: 0x0600603A RID: 24634 RVA: 0x000E8A9E File Offset: 0x000E6C9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DollGrabPauseEndResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600603B RID: 24635 RVA: 0x000E8ACC File Offset: 0x000E6CCC
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

		// Token: 0x0600603C RID: 24636 RVA: 0x000E8B11 File Offset: 0x000E6D11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600603D RID: 24637 RVA: 0x000E8B1E File Offset: 0x000E6D1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600603E RID: 24638 RVA: 0x000E8B27 File Offset: 0x000E6D27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600603F RID: 24639 RVA: 0x000E8B5C File Offset: 0x000E6D5C
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

		// Token: 0x06006040 RID: 24640 RVA: 0x000E8B9A File Offset: 0x000E6D9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DollGrabPauseEndResponse other)
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

		// Token: 0x06006041 RID: 24641 RVA: 0x000E8BCB File Offset: 0x000E6DCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006042 RID: 24642 RVA: 0x000E8BD4 File Offset: 0x000E6DD4
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400379E RID: 14238
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400379F RID: 14239
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x040037A0 RID: 14240
		private ErrorCode errorCode_;
	}
}
