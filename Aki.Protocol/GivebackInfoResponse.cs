using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006DB RID: 1755
	[NetMessage(EMessageId.GivebackInfoResponse)]
	public sealed class GivebackInfoResponse : IMessage<GivebackInfoResponse>, IMessage, IEquatable<GivebackInfoResponse>, IDeepCloneable<GivebackInfoResponse>, IBufferMessage
	{
		// Token: 0x0600A077 RID: 41079 RVA: 0x00184CD2 File Offset: 0x00182ED2
		[NullableContext(1)]
		public static GivebackInfoResponse Create()
		{
			return new GivebackInfoResponse();
		}

		// Token: 0x17002038 RID: 8248
		// (get) Token: 0x0600A078 RID: 41080 RVA: 0x00184CD9 File Offset: 0x00182ED9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002039 RID: 8249
		// (get) Token: 0x0600A079 RID: 41081 RVA: 0x00184CDC File Offset: 0x00182EDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GivebackInfoResponse.Descriptor;
			}
		}

		// Token: 0x0600A07A RID: 41082 RVA: 0x00184CE3 File Offset: 0x00182EE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GivebackInfoResponse()
		{
		}

		// Token: 0x0600A07B RID: 41083 RVA: 0x00184CEB File Offset: 0x00182EEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GivebackInfoResponse(GivebackInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A07C RID: 41084 RVA: 0x00184D10 File Offset: 0x00182F10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GivebackInfoResponse Clone()
		{
			return new GivebackInfoResponse(this);
		}

		// Token: 0x1700203A RID: 8250
		// (get) Token: 0x0600A07D RID: 41085 RVA: 0x00184D18 File Offset: 0x00182F18
		// (set) Token: 0x0600A07E RID: 41086 RVA: 0x00184D20 File Offset: 0x00182F20
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

		// Token: 0x0600A07F RID: 41087 RVA: 0x00184D29 File Offset: 0x00182F29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GivebackInfoResponse);
		}

		// Token: 0x0600A080 RID: 41088 RVA: 0x00184D37 File Offset: 0x00182F37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GivebackInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A081 RID: 41089 RVA: 0x00184D68 File Offset: 0x00182F68
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

		// Token: 0x0600A082 RID: 41090 RVA: 0x00184DAD File Offset: 0x00182FAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A083 RID: 41091 RVA: 0x00184DBA File Offset: 0x00182FBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A084 RID: 41092 RVA: 0x00184DC3 File Offset: 0x00182FC3
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

		// Token: 0x0600A085 RID: 41093 RVA: 0x00184DF8 File Offset: 0x00182FF8
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

		// Token: 0x0600A086 RID: 41094 RVA: 0x00184E36 File Offset: 0x00183036
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GivebackInfoResponse other)
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

		// Token: 0x0600A087 RID: 41095 RVA: 0x00184E67 File Offset: 0x00183067
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A088 RID: 41096 RVA: 0x00184E70 File Offset: 0x00183070
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

		// Token: 0x04004B0E RID: 19214
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004B0F RID: 19215
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x04004B10 RID: 19216
		private ErrorCode errorCode_;
	}
}
