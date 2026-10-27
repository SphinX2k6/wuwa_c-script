using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001102 RID: 4354
	[NetMessage(EMessageId.RoverRogueGiveUpGainResponse)]
	public sealed class RoverRogueGiveUpGainResponse : IMessage<RoverRogueGiveUpGainResponse>, IMessage, IEquatable<RoverRogueGiveUpGainResponse>, IDeepCloneable<RoverRogueGiveUpGainResponse>, IBufferMessage
	{
		// Token: 0x06017379 RID: 95097 RVA: 0x0035EA4C File Offset: 0x0035CC4C
		[NullableContext(1)]
		public static RoverRogueGiveUpGainResponse Create()
		{
			return new RoverRogueGiveUpGainResponse();
		}

		// Token: 0x17004DCF RID: 19919
		// (get) Token: 0x0601737A RID: 95098 RVA: 0x0035EA53 File Offset: 0x0035CC53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004DD0 RID: 19920
		// (get) Token: 0x0601737B RID: 95099 RVA: 0x0035EA56 File Offset: 0x0035CC56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueGiveUpGainResponse.Descriptor;
			}
		}

		// Token: 0x0601737C RID: 95100 RVA: 0x0035EA5D File Offset: 0x0035CC5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueGiveUpGainResponse()
		{
		}

		// Token: 0x0601737D RID: 95101 RVA: 0x0035EA65 File Offset: 0x0035CC65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueGiveUpGainResponse(RoverRogueGiveUpGainResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601737E RID: 95102 RVA: 0x0035EA8A File Offset: 0x0035CC8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueGiveUpGainResponse Clone()
		{
			return new RoverRogueGiveUpGainResponse(this);
		}

		// Token: 0x17004DD1 RID: 19921
		// (get) Token: 0x0601737F RID: 95103 RVA: 0x0035EA92 File Offset: 0x0035CC92
		// (set) Token: 0x06017380 RID: 95104 RVA: 0x0035EA9A File Offset: 0x0035CC9A
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

		// Token: 0x06017381 RID: 95105 RVA: 0x0035EAA3 File Offset: 0x0035CCA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueGiveUpGainResponse);
		}

		// Token: 0x06017382 RID: 95106 RVA: 0x0035EAB1 File Offset: 0x0035CCB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueGiveUpGainResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017383 RID: 95107 RVA: 0x0035EAE0 File Offset: 0x0035CCE0
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

		// Token: 0x06017384 RID: 95108 RVA: 0x0035EB25 File Offset: 0x0035CD25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017385 RID: 95109 RVA: 0x0035EB32 File Offset: 0x0035CD32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017386 RID: 95110 RVA: 0x0035EB3B File Offset: 0x0035CD3B
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

		// Token: 0x06017387 RID: 95111 RVA: 0x0035EB70 File Offset: 0x0035CD70
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

		// Token: 0x06017388 RID: 95112 RVA: 0x0035EBAE File Offset: 0x0035CDAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueGiveUpGainResponse other)
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

		// Token: 0x06017389 RID: 95113 RVA: 0x0035EBDF File Offset: 0x0035CDDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601738A RID: 95114 RVA: 0x0035EBE8 File Offset: 0x0035CDE8
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

		// Token: 0x04008A13 RID: 35347
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008A14 RID: 35348
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04008A15 RID: 35349
		private ErrorCode errorCode_;
	}
}
