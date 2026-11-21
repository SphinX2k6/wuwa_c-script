using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000ECC RID: 3788
	[NetMessage(EMessageId.RegressBuyBonusLvRequest)]
	public sealed class RegressBuyBonusLvRequest : IMessage<RegressBuyBonusLvRequest>, IMessage, IEquatable<RegressBuyBonusLvRequest>, IDeepCloneable<RegressBuyBonusLvRequest>, IBufferMessage
	{
		// Token: 0x06014551 RID: 83281 RVA: 0x002F4E77 File Offset: 0x002F3077
		[NullableContext(1)]
		public static RegressBuyBonusLvRequest Create()
		{
			return new RegressBuyBonusLvRequest();
		}

		// Token: 0x1700439D RID: 17309
		// (get) Token: 0x06014552 RID: 83282 RVA: 0x002F4E7E File Offset: 0x002F307E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700439E RID: 17310
		// (get) Token: 0x06014553 RID: 83283 RVA: 0x002F4E81 File Offset: 0x002F3081
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RegressBuyBonusLvRequest.Descriptor;
			}
		}

		// Token: 0x06014554 RID: 83284 RVA: 0x002F4E88 File Offset: 0x002F3088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressBuyBonusLvRequest()
		{
		}

		// Token: 0x06014555 RID: 83285 RVA: 0x002F4E90 File Offset: 0x002F3090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressBuyBonusLvRequest(RegressBuyBonusLvRequest other) : this()
		{
			this.buyLv_ = other.buyLv_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014556 RID: 83286 RVA: 0x002F4EB5 File Offset: 0x002F30B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressBuyBonusLvRequest Clone()
		{
			return new RegressBuyBonusLvRequest(this);
		}

		// Token: 0x1700439F RID: 17311
		// (get) Token: 0x06014557 RID: 83287 RVA: 0x002F4EBD File Offset: 0x002F30BD
		// (set) Token: 0x06014558 RID: 83288 RVA: 0x002F4EC5 File Offset: 0x002F30C5
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

		// Token: 0x06014559 RID: 83289 RVA: 0x002F4ECE File Offset: 0x002F30CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RegressBuyBonusLvRequest);
		}

		// Token: 0x0601455A RID: 83290 RVA: 0x002F4EDC File Offset: 0x002F30DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RegressBuyBonusLvRequest other)
		{
			return other != null && (other == this || (this.BuyLv == other.BuyLv && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601455B RID: 83291 RVA: 0x002F4F0C File Offset: 0x002F310C
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

		// Token: 0x0601455C RID: 83292 RVA: 0x002F4F4B File Offset: 0x002F314B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601455D RID: 83293 RVA: 0x002F4F58 File Offset: 0x002F3158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601455E RID: 83294 RVA: 0x002F4F61 File Offset: 0x002F3161
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BuyLv != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.BuyLv);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601455F RID: 83295 RVA: 0x002F4F94 File Offset: 0x002F3194
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

		// Token: 0x06014560 RID: 83296 RVA: 0x002F4FD2 File Offset: 0x002F31D2
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

		// Token: 0x06014561 RID: 83297 RVA: 0x002F5003 File Offset: 0x002F3203
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014562 RID: 83298 RVA: 0x002F500C File Offset: 0x002F320C
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
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.BuyLv = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007BE5 RID: 31717
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007BE6 RID: 31718
		public const int BuyLvFieldNumber = 2;

		// Token: 0x04007BE7 RID: 31719
		private int buyLv_;
	}
}
