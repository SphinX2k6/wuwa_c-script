using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EDC RID: 3804
	[NetMessage(EMessageId.RegressBuyBonusLvRequest)]
	public sealed class RegressBuyBonusLvRequest : IMessage<RegressBuyBonusLvRequest>, IMessage, IEquatable<RegressBuyBonusLvRequest>, IDeepCloneable<RegressBuyBonusLvRequest>, IBufferMessage
	{
		// Token: 0x06014636 RID: 83510 RVA: 0x002F652B File Offset: 0x002F472B
		[NullableContext(1)]
		public static RegressBuyBonusLvRequest Create()
		{
			return new RegressBuyBonusLvRequest();
		}

		// Token: 0x170043C7 RID: 17351
		// (get) Token: 0x06014637 RID: 83511 RVA: 0x002F6532 File Offset: 0x002F4732
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170043C8 RID: 17352
		// (get) Token: 0x06014638 RID: 83512 RVA: 0x002F6535 File Offset: 0x002F4735
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RegressBuyBonusLvRequest.Descriptor;
			}
		}

		// Token: 0x06014639 RID: 83513 RVA: 0x002F653C File Offset: 0x002F473C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressBuyBonusLvRequest()
		{
		}

		// Token: 0x0601463A RID: 83514 RVA: 0x002F6544 File Offset: 0x002F4744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressBuyBonusLvRequest(RegressBuyBonusLvRequest other) : this()
		{
			this.buyLv_ = other.buyLv_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601463B RID: 83515 RVA: 0x002F6569 File Offset: 0x002F4769
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressBuyBonusLvRequest Clone()
		{
			return new RegressBuyBonusLvRequest(this);
		}

		// Token: 0x170043C9 RID: 17353
		// (get) Token: 0x0601463C RID: 83516 RVA: 0x002F6571 File Offset: 0x002F4771
		// (set) Token: 0x0601463D RID: 83517 RVA: 0x002F6579 File Offset: 0x002F4779
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BuyLv
		{
			get
			{
				return this.buyLv_;
			}
			set
			{
				this.buyLv_ = value;
			}
		}

		// Token: 0x0601463E RID: 83518 RVA: 0x002F6582 File Offset: 0x002F4782
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RegressBuyBonusLvRequest);
		}

		// Token: 0x0601463F RID: 83519 RVA: 0x002F6590 File Offset: 0x002F4790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RegressBuyBonusLvRequest other)
		{
			return other != null && (other == this || (this.BuyLv == other.BuyLv && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014640 RID: 83520 RVA: 0x002F65C0 File Offset: 0x002F47C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BuyLv != 0)
			{
				num ^= this.BuyLv.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014641 RID: 83521 RVA: 0x002F65FF File Offset: 0x002F47FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014642 RID: 83522 RVA: 0x002F660C File Offset: 0x002F480C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014643 RID: 83523 RVA: 0x002F6615 File Offset: 0x002F4815
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BuyLv != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.BuyLv);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014644 RID: 83524 RVA: 0x002F6648 File Offset: 0x002F4848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BuyLv != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BuyLv);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014645 RID: 83525 RVA: 0x002F6686 File Offset: 0x002F4886
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RegressBuyBonusLvRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BuyLv != 0)
			{
				this.BuyLv = other.BuyLv;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014646 RID: 83526 RVA: 0x002F66B7 File Offset: 0x002F48B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014647 RID: 83527 RVA: 0x002F66C0 File Offset: 0x002F48C0
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
					this.BuyLv = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007BBB RID: 31675
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007BBC RID: 31676
		public const int BuyLvFieldNumber = 7;

		// Token: 0x04007BBD RID: 31677
		private int buyLv_;
	}
}
