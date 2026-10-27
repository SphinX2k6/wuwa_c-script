using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000965 RID: 2405
	[NetMessage(EMessageId.LordGymReadResponse)]
	public sealed class LordGymReadResponse : IMessage<LordGymReadResponse>, IMessage, IEquatable<LordGymReadResponse>, IDeepCloneable<LordGymReadResponse>, IBufferMessage
	{
		// Token: 0x0600D3E0 RID: 54240 RVA: 0x001F37A5 File Offset: 0x001F19A5
		[NullableContext(1)]
		public static LordGymReadResponse Create()
		{
			return new LordGymReadResponse();
		}

		// Token: 0x17002AEC RID: 10988
		// (get) Token: 0x0600D3E1 RID: 54241 RVA: 0x001F37AC File Offset: 0x001F19AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002AED RID: 10989
		// (get) Token: 0x0600D3E2 RID: 54242 RVA: 0x001F37AF File Offset: 0x001F19AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LordGymReadResponse.Descriptor;
			}
		}

		// Token: 0x0600D3E3 RID: 54243 RVA: 0x001F37B6 File Offset: 0x001F19B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LordGymReadResponse()
		{
		}

		// Token: 0x0600D3E4 RID: 54244 RVA: 0x001F37BE File Offset: 0x001F19BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LordGymReadResponse(LordGymReadResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D3E5 RID: 54245 RVA: 0x001F37E3 File Offset: 0x001F19E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LordGymReadResponse Clone()
		{
			return new LordGymReadResponse(this);
		}

		// Token: 0x17002AEE RID: 10990
		// (get) Token: 0x0600D3E6 RID: 54246 RVA: 0x001F37EB File Offset: 0x001F19EB
		// (set) Token: 0x0600D3E7 RID: 54247 RVA: 0x001F37F3 File Offset: 0x001F19F3
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

		// Token: 0x0600D3E8 RID: 54248 RVA: 0x001F37FC File Offset: 0x001F19FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LordGymReadResponse);
		}

		// Token: 0x0600D3E9 RID: 54249 RVA: 0x001F380A File Offset: 0x001F1A0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LordGymReadResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D3EA RID: 54250 RVA: 0x001F3838 File Offset: 0x001F1A38
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

		// Token: 0x0600D3EB RID: 54251 RVA: 0x001F387D File Offset: 0x001F1A7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D3EC RID: 54252 RVA: 0x001F388A File Offset: 0x001F1A8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D3ED RID: 54253 RVA: 0x001F3893 File Offset: 0x001F1A93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D3EE RID: 54254 RVA: 0x001F38C8 File Offset: 0x001F1AC8
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

		// Token: 0x0600D3EF RID: 54255 RVA: 0x001F3906 File Offset: 0x001F1B06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LordGymReadResponse other)
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

		// Token: 0x0600D3F0 RID: 54256 RVA: 0x001F3937 File Offset: 0x001F1B37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D3F1 RID: 54257 RVA: 0x001F3940 File Offset: 0x001F1B40
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005904 RID: 22788
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005905 RID: 22789
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04005906 RID: 22790
		private ErrorCode errorCode_;
	}
}
