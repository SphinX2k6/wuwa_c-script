using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FB2 RID: 4018
	[NetMessage(EMessageId.RoguelikeRoleInstStartResponse)]
	public sealed class RoguelikeRoleInstStartResponse : IMessage<RoguelikeRoleInstStartResponse>, IMessage, IEquatable<RoguelikeRoleInstStartResponse>, IDeepCloneable<RoguelikeRoleInstStartResponse>, IBufferMessage
	{
		// Token: 0x060157C7 RID: 88007 RVA: 0x0031E868 File Offset: 0x0031CA68
		[NullableContext(1)]
		public static RoguelikeRoleInstStartResponse Create()
		{
			return new RoguelikeRoleInstStartResponse();
		}

		// Token: 0x170047A4 RID: 18340
		// (get) Token: 0x060157C8 RID: 88008 RVA: 0x0031E86F File Offset: 0x0031CA6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170047A5 RID: 18341
		// (get) Token: 0x060157C9 RID: 88009 RVA: 0x0031E872 File Offset: 0x0031CA72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeRoleInstStartResponse.Descriptor;
			}
		}

		// Token: 0x060157CA RID: 88010 RVA: 0x0031E879 File Offset: 0x0031CA79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeRoleInstStartResponse()
		{
		}

		// Token: 0x060157CB RID: 88011 RVA: 0x0031E881 File Offset: 0x0031CA81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeRoleInstStartResponse(RoguelikeRoleInstStartResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060157CC RID: 88012 RVA: 0x0031E8A6 File Offset: 0x0031CAA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeRoleInstStartResponse Clone()
		{
			return new RoguelikeRoleInstStartResponse(this);
		}

		// Token: 0x170047A6 RID: 18342
		// (get) Token: 0x060157CD RID: 88013 RVA: 0x0031E8AE File Offset: 0x0031CAAE
		// (set) Token: 0x060157CE RID: 88014 RVA: 0x0031E8B6 File Offset: 0x0031CAB6
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

		// Token: 0x060157CF RID: 88015 RVA: 0x0031E8BF File Offset: 0x0031CABF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeRoleInstStartResponse);
		}

		// Token: 0x060157D0 RID: 88016 RVA: 0x0031E8CD File Offset: 0x0031CACD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeRoleInstStartResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060157D1 RID: 88017 RVA: 0x0031E8FC File Offset: 0x0031CAFC
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

		// Token: 0x060157D2 RID: 88018 RVA: 0x0031E941 File Offset: 0x0031CB41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060157D3 RID: 88019 RVA: 0x0031E94E File Offset: 0x0031CB4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060157D4 RID: 88020 RVA: 0x0031E957 File Offset: 0x0031CB57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060157D5 RID: 88021 RVA: 0x0031E98C File Offset: 0x0031CB8C
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

		// Token: 0x060157D6 RID: 88022 RVA: 0x0031E9CA File Offset: 0x0031CBCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeRoleInstStartResponse other)
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

		// Token: 0x060157D7 RID: 88023 RVA: 0x0031E9FB File Offset: 0x0031CBFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060157D8 RID: 88024 RVA: 0x0031EA04 File Offset: 0x0031CC04
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008131 RID: 33073
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008132 RID: 33074
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x04008133 RID: 33075
		private ErrorCode errorCode_;
	}
}
