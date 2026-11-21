using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008AF RID: 2223
	[NetMessage(EMessageId.KurotatoSettlementNotify)]
	public sealed class KurotatoSettlementNotify : IMessage<KurotatoSettlementNotify>, IMessage, IEquatable<KurotatoSettlementNotify>, IDeepCloneable<KurotatoSettlementNotify>, IBufferMessage
	{
		// Token: 0x0600C58A RID: 50570 RVA: 0x001D4180 File Offset: 0x001D2380
		[NullableContext(1)]
		public static KurotatoSettlementNotify Create()
		{
			return new KurotatoSettlementNotify();
		}

		// Token: 0x170027E7 RID: 10215
		// (get) Token: 0x0600C58B RID: 50571 RVA: 0x001D4187 File Offset: 0x001D2387
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170027E8 RID: 10216
		// (get) Token: 0x0600C58C RID: 50572 RVA: 0x001D418A File Offset: 0x001D238A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoSettlementNotify.Descriptor;
			}
		}

		// Token: 0x0600C58D RID: 50573 RVA: 0x001D4191 File Offset: 0x001D2391
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoSettlementNotify()
		{
		}

		// Token: 0x0600C58E RID: 50574 RVA: 0x001D4199 File Offset: 0x001D2399
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoSettlementNotify(KurotatoSettlementNotify other) : this()
		{
			this.kurotatoSettlementInfo_ = ((other.kurotatoSettlementInfo_ != null) ? other.kurotatoSettlementInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C58F RID: 50575 RVA: 0x001D41CE File Offset: 0x001D23CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoSettlementNotify Clone()
		{
			return new KurotatoSettlementNotify(this);
		}

		// Token: 0x170027E9 RID: 10217
		// (get) Token: 0x0600C590 RID: 50576 RVA: 0x001D41D6 File Offset: 0x001D23D6
		// (set) Token: 0x0600C591 RID: 50577 RVA: 0x001D41DE File Offset: 0x001D23DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoSettlementInfo KurotatoSettlementInfo
		{
			get
			{
				return this.kurotatoSettlementInfo_;
			}
			set
			{
				this.kurotatoSettlementInfo_ = value;
			}
		}

		// Token: 0x0600C592 RID: 50578 RVA: 0x001D41E7 File Offset: 0x001D23E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoSettlementNotify);
		}

		// Token: 0x0600C593 RID: 50579 RVA: 0x001D41F5 File Offset: 0x001D23F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoSettlementNotify other)
		{
			return other != null && (other == this || (object.Equals(this.KurotatoSettlementInfo, other.KurotatoSettlementInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C594 RID: 50580 RVA: 0x001D4228 File Offset: 0x001D2428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.kurotatoSettlementInfo_ != null)
			{
				num ^= this.KurotatoSettlementInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C595 RID: 50581 RVA: 0x001D4264 File Offset: 0x001D2464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C596 RID: 50582 RVA: 0x001D4271 File Offset: 0x001D2471
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C597 RID: 50583 RVA: 0x001D427A File Offset: 0x001D247A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.kurotatoSettlementInfo_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.KurotatoSettlementInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C598 RID: 50584 RVA: 0x001D42AC File Offset: 0x001D24AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.kurotatoSettlementInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.KurotatoSettlementInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C599 RID: 50585 RVA: 0x001D42EC File Offset: 0x001D24EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoSettlementNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.kurotatoSettlementInfo_ != null)
			{
				if (this.kurotatoSettlementInfo_ == null)
				{
					this.KurotatoSettlementInfo = new KurotatoSettlementInfo();
				}
				this.KurotatoSettlementInfo.MergeFrom(other.KurotatoSettlementInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C59A RID: 50586 RVA: 0x001D4340 File Offset: 0x001D2540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C59B RID: 50587 RVA: 0x001D434C File Offset: 0x001D254C
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.kurotatoSettlementInfo_ == null)
					{
						this.KurotatoSettlementInfo = new KurotatoSettlementInfo();
					}
					input.ReadMessage(this.KurotatoSettlementInfo);
				}
			}
		}

		// Token: 0x04005554 RID: 21844
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005555 RID: 21845
		public const int KurotatoSettlementInfoFieldNumber = 1;

		// Token: 0x04005556 RID: 21846
		private KurotatoSettlementInfo kurotatoSettlementInfo_;
	}
}
