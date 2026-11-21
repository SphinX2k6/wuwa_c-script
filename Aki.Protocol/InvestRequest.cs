using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200082A RID: 2090
	[NetMessage(EMessageId.InvestRequest)]
	public sealed class InvestRequest : IMessage<InvestRequest>, IMessage, IEquatable<InvestRequest>, IDeepCloneable<InvestRequest>, IBufferMessage
	{
		// Token: 0x0600BB10 RID: 47888 RVA: 0x001BDB64 File Offset: 0x001BBD64
		[NullableContext(1)]
		public static InvestRequest Create()
		{
			return new InvestRequest();
		}

		// Token: 0x170025C0 RID: 9664
		// (get) Token: 0x0600BB11 RID: 47889 RVA: 0x001BDB6B File Offset: 0x001BBD6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170025C1 RID: 9665
		// (get) Token: 0x0600BB12 RID: 47890 RVA: 0x001BDB6E File Offset: 0x001BBD6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InvestRequest.Descriptor;
			}
		}

		// Token: 0x0600BB13 RID: 47891 RVA: 0x001BDB75 File Offset: 0x001BBD75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InvestRequest()
		{
		}

		// Token: 0x0600BB14 RID: 47892 RVA: 0x001BDB7D File Offset: 0x001BBD7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InvestRequest(InvestRequest other) : this()
		{
			this.entrustId_ = other.entrustId_;
			this.amount_ = other.amount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BB15 RID: 47893 RVA: 0x001BDBAE File Offset: 0x001BBDAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InvestRequest Clone()
		{
			return new InvestRequest(this);
		}

		// Token: 0x170025C2 RID: 9666
		// (get) Token: 0x0600BB16 RID: 47894 RVA: 0x001BDBB6 File Offset: 0x001BBDB6
		// (set) Token: 0x0600BB17 RID: 47895 RVA: 0x001BDBBE File Offset: 0x001BBDBE
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

		// Token: 0x170025C3 RID: 9667
		// (get) Token: 0x0600BB18 RID: 47896 RVA: 0x001BDBC7 File Offset: 0x001BBDC7
		// (set) Token: 0x0600BB19 RID: 47897 RVA: 0x001BDBCF File Offset: 0x001BBDCF
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

		// Token: 0x0600BB1A RID: 47898 RVA: 0x001BDBD8 File Offset: 0x001BBDD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InvestRequest);
		}

		// Token: 0x0600BB1B RID: 47899 RVA: 0x001BDBE6 File Offset: 0x001BBDE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InvestRequest other)
		{
			return other != null && (other == this || (this.EntrustId == other.EntrustId && this.Amount == other.Amount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BB1C RID: 47900 RVA: 0x001BDC24 File Offset: 0x001BBE24
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

		// Token: 0x0600BB1D RID: 47901 RVA: 0x001BDC7C File Offset: 0x001BBE7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BB1E RID: 47902 RVA: 0x001BDC89 File Offset: 0x001BBE89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BB1F RID: 47903 RVA: 0x001BDC94 File Offset: 0x001BBE94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntrustId != 0)
			{
				output.WriteRawTag(96);
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

		// Token: 0x0600BB20 RID: 47904 RVA: 0x001BDCF0 File Offset: 0x001BBEF0
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

		// Token: 0x0600BB21 RID: 47905 RVA: 0x001BDD48 File Offset: 0x001BBF48
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

		// Token: 0x0600BB22 RID: 47906 RVA: 0x001BDD98 File Offset: 0x001BBF98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BB23 RID: 47907 RVA: 0x001BDDA4 File Offset: 0x001BBFA4
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
				if (num != 96U)
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

		// Token: 0x0400527A RID: 21114
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400527B RID: 21115
		public const int EntrustIdFieldNumber = 12;

		// Token: 0x0400527C RID: 21116
		private int entrustId_;

		// Token: 0x0400527D RID: 21117
		public const int AmountFieldNumber = 13;

		// Token: 0x0400527E RID: 21118
		private int amount_;
	}
}
