using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200113C RID: 4412
	[NetMessage(EMessageId.RoverRogueGiveUpGainResponse)]
	public sealed class RoverRogueGiveUpGainResponse : IMessage<RoverRogueGiveUpGainResponse>, IMessage, IEquatable<RoverRogueGiveUpGainResponse>, IDeepCloneable<RoverRogueGiveUpGainResponse>, IBufferMessage
	{
		// Token: 0x0601791A RID: 96538 RVA: 0x0036DDA1 File Offset: 0x0036BFA1
		[NullableContext(1)]
		public static RoverRogueGiveUpGainResponse Create()
		{
			return new RoverRogueGiveUpGainResponse();
		}

		// Token: 0x17004F3B RID: 20283
		// (get) Token: 0x0601791B RID: 96539 RVA: 0x0036DDA8 File Offset: 0x0036BFA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004F3C RID: 20284
		// (get) Token: 0x0601791C RID: 96540 RVA: 0x0036DDAB File Offset: 0x0036BFAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueGiveUpGainResponse.Descriptor;
			}
		}

		// Token: 0x0601791D RID: 96541 RVA: 0x0036DDB2 File Offset: 0x0036BFB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueGiveUpGainResponse()
		{
		}

		// Token: 0x0601791E RID: 96542 RVA: 0x0036DDBA File Offset: 0x0036BFBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueGiveUpGainResponse(RoverRogueGiveUpGainResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601791F RID: 96543 RVA: 0x0036DDDF File Offset: 0x0036BFDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueGiveUpGainResponse Clone()
		{
			return new RoverRogueGiveUpGainResponse(this);
		}

		// Token: 0x17004F3D RID: 20285
		// (get) Token: 0x06017920 RID: 96544 RVA: 0x0036DDE7 File Offset: 0x0036BFE7
		// (set) Token: 0x06017921 RID: 96545 RVA: 0x0036DDEF File Offset: 0x0036BFEF
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

		// Token: 0x06017922 RID: 96546 RVA: 0x0036DDF8 File Offset: 0x0036BFF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueGiveUpGainResponse);
		}

		// Token: 0x06017923 RID: 96547 RVA: 0x0036DE06 File Offset: 0x0036C006
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueGiveUpGainResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017924 RID: 96548 RVA: 0x0036DE34 File Offset: 0x0036C034
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

		// Token: 0x06017925 RID: 96549 RVA: 0x0036DE79 File Offset: 0x0036C079
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017926 RID: 96550 RVA: 0x0036DE86 File Offset: 0x0036C086
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017927 RID: 96551 RVA: 0x0036DE8F File Offset: 0x0036C08F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017928 RID: 96552 RVA: 0x0036DEC0 File Offset: 0x0036C0C0
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

		// Token: 0x06017929 RID: 96553 RVA: 0x0036DEFE File Offset: 0x0036C0FE
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

		// Token: 0x0601792A RID: 96554 RVA: 0x0036DF2F File Offset: 0x0036C12F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601792B RID: 96555 RVA: 0x0036DF38 File Offset: 0x0036C138
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008CA6 RID: 36006
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008CA7 RID: 36007
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x04008CA8 RID: 36008
		private ErrorCode errorCode_;
	}
}
