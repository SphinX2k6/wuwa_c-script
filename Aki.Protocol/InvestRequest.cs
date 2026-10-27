using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200083E RID: 2110
	[NetMessage(EMessageId.InvestRequest)]
	public sealed class InvestRequest : IMessage<InvestRequest>, IMessage, IEquatable<InvestRequest>, IDeepCloneable<InvestRequest>, IBufferMessage
	{
		// Token: 0x0600BC66 RID: 48230 RVA: 0x001C059B File Offset: 0x001BE79B
		[NullableContext(1)]
		public static InvestRequest Create()
		{
			return new InvestRequest();
		}

		// Token: 0x1700260A RID: 9738
		// (get) Token: 0x0600BC67 RID: 48231 RVA: 0x001C05A2 File Offset: 0x001BE7A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700260B RID: 9739
		// (get) Token: 0x0600BC68 RID: 48232 RVA: 0x001C05A5 File Offset: 0x001BE7A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InvestRequest.Descriptor;
			}
		}

		// Token: 0x0600BC69 RID: 48233 RVA: 0x001C05AC File Offset: 0x001BE7AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InvestRequest()
		{
		}

		// Token: 0x0600BC6A RID: 48234 RVA: 0x001C05B4 File Offset: 0x001BE7B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InvestRequest(InvestRequest other) : this()
		{
			this.entrustId_ = other.entrustId_;
			this.amount_ = other.amount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BC6B RID: 48235 RVA: 0x001C05E5 File Offset: 0x001BE7E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InvestRequest Clone()
		{
			return new InvestRequest(this);
		}

		// Token: 0x1700260C RID: 9740
		// (get) Token: 0x0600BC6C RID: 48236 RVA: 0x001C05ED File Offset: 0x001BE7ED
		// (set) Token: 0x0600BC6D RID: 48237 RVA: 0x001C05F5 File Offset: 0x001BE7F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EntrustId
		{
			get
			{
				return this.entrustId_;
			}
			set
			{
				this.entrustId_ = value;
			}
		}

		// Token: 0x1700260D RID: 9741
		// (get) Token: 0x0600BC6E RID: 48238 RVA: 0x001C05FE File Offset: 0x001BE7FE
		// (set) Token: 0x0600BC6F RID: 48239 RVA: 0x001C0606 File Offset: 0x001BE806
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Amount
		{
			get
			{
				return this.amount_;
			}
			set
			{
				this.amount_ = value;
			}
		}

		// Token: 0x0600BC70 RID: 48240 RVA: 0x001C060F File Offset: 0x001BE80F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InvestRequest);
		}

		// Token: 0x0600BC71 RID: 48241 RVA: 0x001C061D File Offset: 0x001BE81D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InvestRequest other)
		{
			return other != null && (other == this || (this.EntrustId == other.EntrustId && this.Amount == other.Amount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BC72 RID: 48242 RVA: 0x001C065C File Offset: 0x001BE85C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntrustId != 0)
			{
				num ^= this.EntrustId.GetHashCode();
			}
			if (this.Amount != 0)
			{
				num ^= this.Amount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BC73 RID: 48243 RVA: 0x001C06B4 File Offset: 0x001BE8B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BC74 RID: 48244 RVA: 0x001C06C1 File Offset: 0x001BE8C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BC75 RID: 48245 RVA: 0x001C06CC File Offset: 0x001BE8CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntrustId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.EntrustId);
			}
			if (this.Amount != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.Amount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BC76 RID: 48246 RVA: 0x001C0728 File Offset: 0x001BE928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntrustId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EntrustId);
			}
			if (this.Amount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Amount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BC77 RID: 48247 RVA: 0x001C0780 File Offset: 0x001BE980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InvestRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntrustId != 0)
			{
				this.EntrustId = other.EntrustId;
			}
			if (other.Amount != 0)
			{
				this.Amount = other.Amount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BC78 RID: 48248 RVA: 0x001C07D0 File Offset: 0x001BE9D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BC79 RID: 48249 RVA: 0x001C07DC File Offset: 0x001BE9DC
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
				if (num != 72U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Amount = input.ReadInt32();
					}
				}
				else
				{
					this.EntrustId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005281 RID: 21121
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005282 RID: 21122
		public const int EntrustIdFieldNumber = 9;

		// Token: 0x04005283 RID: 21123
		private int entrustId_;

		// Token: 0x04005284 RID: 21124
		public const int AmountFieldNumber = 13;

		// Token: 0x04005285 RID: 21125
		private int amount_;
	}
}
