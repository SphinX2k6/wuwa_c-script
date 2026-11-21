using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008B1 RID: 2225
	[NetMessage(EMessageId.KurotatoSettlementResponse)]
	public sealed class KurotatoSettlementResponse : IMessage<KurotatoSettlementResponse>, IMessage, IEquatable<KurotatoSettlementResponse>, IDeepCloneable<KurotatoSettlementResponse>, IBufferMessage
	{
		// Token: 0x0600C5AC RID: 50604 RVA: 0x001D44DE File Offset: 0x001D26DE
		[NullableContext(1)]
		public static KurotatoSettlementResponse Create()
		{
			return new KurotatoSettlementResponse();
		}

		// Token: 0x170027EC RID: 10220
		// (get) Token: 0x0600C5AD RID: 50605 RVA: 0x001D44E5 File Offset: 0x001D26E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170027ED RID: 10221
		// (get) Token: 0x0600C5AE RID: 50606 RVA: 0x001D44E8 File Offset: 0x001D26E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoSettlementResponse.Descriptor;
			}
		}

		// Token: 0x0600C5AF RID: 50607 RVA: 0x001D44EF File Offset: 0x001D26EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoSettlementResponse()
		{
		}

		// Token: 0x0600C5B0 RID: 50608 RVA: 0x001D44F8 File Offset: 0x001D26F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoSettlementResponse(KurotatoSettlementResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.kurotatoSettlementInfo_ = ((other.kurotatoSettlementInfo_ != null) ? other.kurotatoSettlementInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C5B1 RID: 50609 RVA: 0x001D4544 File Offset: 0x001D2744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoSettlementResponse Clone()
		{
			return new KurotatoSettlementResponse(this);
		}

		// Token: 0x170027EE RID: 10222
		// (get) Token: 0x0600C5B2 RID: 50610 RVA: 0x001D454C File Offset: 0x001D274C
		// (set) Token: 0x0600C5B3 RID: 50611 RVA: 0x001D4554 File Offset: 0x001D2754
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

		// Token: 0x170027EF RID: 10223
		// (get) Token: 0x0600C5B4 RID: 50612 RVA: 0x001D455D File Offset: 0x001D275D
		// (set) Token: 0x0600C5B5 RID: 50613 RVA: 0x001D4565 File Offset: 0x001D2765
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

		// Token: 0x0600C5B6 RID: 50614 RVA: 0x001D456E File Offset: 0x001D276E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoSettlementResponse);
		}

		// Token: 0x0600C5B7 RID: 50615 RVA: 0x001D457C File Offset: 0x001D277C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoSettlementResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.KurotatoSettlementInfo, other.KurotatoSettlementInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C5B8 RID: 50616 RVA: 0x001D45CC File Offset: 0x001D27CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
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

		// Token: 0x0600C5B9 RID: 50617 RVA: 0x001D4627 File Offset: 0x001D2827
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C5BA RID: 50618 RVA: 0x001D4634 File Offset: 0x001D2834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C5BB RID: 50619 RVA: 0x001D4640 File Offset: 0x001D2840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.kurotatoSettlementInfo_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.KurotatoSettlementInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C5BC RID: 50620 RVA: 0x001D4698 File Offset: 0x001D2898
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
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

		// Token: 0x0600C5BD RID: 50621 RVA: 0x001D46F0 File Offset: 0x001D28F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoSettlementResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
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

		// Token: 0x0600C5BE RID: 50622 RVA: 0x001D4758 File Offset: 0x001D2958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C5BF RID: 50623 RVA: 0x001D4764 File Offset: 0x001D2964
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
					if (num != 98U)
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
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005558 RID: 21848
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005559 RID: 21849
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x0400555A RID: 21850
		private ErrorCode errorCode_;

		// Token: 0x0400555B RID: 21851
		public const int KurotatoSettlementInfoFieldNumber = 12;

		// Token: 0x0400555C RID: 21852
		private KurotatoSettlementInfo kurotatoSettlementInfo_;
	}
}
