using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001101 RID: 4353
	[NetMessage(EMessageId.RoverRogueGiveUpGainRequest)]
	public sealed class RoverRogueGiveUpGainRequest : IMessage<RoverRogueGiveUpGainRequest>, IMessage, IEquatable<RoverRogueGiveUpGainRequest>, IDeepCloneable<RoverRogueGiveUpGainRequest>, IBufferMessage
	{
		// Token: 0x06017367 RID: 95079 RVA: 0x0035E872 File Offset: 0x0035CA72
		[NullableContext(1)]
		public static RoverRogueGiveUpGainRequest Create()
		{
			return new RoverRogueGiveUpGainRequest();
		}

		// Token: 0x17004DCC RID: 19916
		// (get) Token: 0x06017368 RID: 95080 RVA: 0x0035E879 File Offset: 0x0035CA79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004DCD RID: 19917
		// (get) Token: 0x06017369 RID: 95081 RVA: 0x0035E87C File Offset: 0x0035CA7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueGiveUpGainRequest.Descriptor;
			}
		}

		// Token: 0x0601736A RID: 95082 RVA: 0x0035E883 File Offset: 0x0035CA83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueGiveUpGainRequest()
		{
		}

		// Token: 0x0601736B RID: 95083 RVA: 0x0035E88B File Offset: 0x0035CA8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueGiveUpGainRequest(RoverRogueGiveUpGainRequest other) : this()
		{
			this.bindId_ = other.bindId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601736C RID: 95084 RVA: 0x0035E8B0 File Offset: 0x0035CAB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueGiveUpGainRequest Clone()
		{
			return new RoverRogueGiveUpGainRequest(this);
		}

		// Token: 0x17004DCE RID: 19918
		// (get) Token: 0x0601736D RID: 95085 RVA: 0x0035E8B8 File Offset: 0x0035CAB8
		// (set) Token: 0x0601736E RID: 95086 RVA: 0x0035E8C0 File Offset: 0x0035CAC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BindId
		{
			get
			{
				return this.bindId_;
			}
			set
			{
				this.bindId_ = value;
			}
		}

		// Token: 0x0601736F RID: 95087 RVA: 0x0035E8C9 File Offset: 0x0035CAC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueGiveUpGainRequest);
		}

		// Token: 0x06017370 RID: 95088 RVA: 0x0035E8D7 File Offset: 0x0035CAD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueGiveUpGainRequest other)
		{
			return other != null && (other == this || (this.BindId == other.BindId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017371 RID: 95089 RVA: 0x0035E908 File Offset: 0x0035CB08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BindId != 0)
			{
				num ^= this.BindId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017372 RID: 95090 RVA: 0x0035E947 File Offset: 0x0035CB47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017373 RID: 95091 RVA: 0x0035E954 File Offset: 0x0035CB54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017374 RID: 95092 RVA: 0x0035E95D File Offset: 0x0035CB5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BindId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.BindId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017375 RID: 95093 RVA: 0x0035E990 File Offset: 0x0035CB90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BindId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BindId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017376 RID: 95094 RVA: 0x0035E9CE File Offset: 0x0035CBCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueGiveUpGainRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BindId != 0)
			{
				this.BindId = other.BindId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017377 RID: 95095 RVA: 0x0035E9FF File Offset: 0x0035CBFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017378 RID: 95096 RVA: 0x0035EA08 File Offset: 0x0035CC08
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
					this.BindId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008A10 RID: 35344
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008A11 RID: 35345
		public const int BindIdFieldNumber = 1;

		// Token: 0x04008A12 RID: 35346
		private int bindId_;
	}
}
