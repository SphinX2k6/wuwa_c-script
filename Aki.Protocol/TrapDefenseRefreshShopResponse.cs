using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014B1 RID: 5297
	[NetMessage(EMessageId.TrapDefenseRefreshShopResponse)]
	public sealed class TrapDefenseRefreshShopResponse : IMessage<TrapDefenseRefreshShopResponse>, IMessage, IEquatable<TrapDefenseRefreshShopResponse>, IDeepCloneable<TrapDefenseRefreshShopResponse>, IBufferMessage
	{
		// Token: 0x0601C1AD RID: 115117 RVA: 0x004143EA File Offset: 0x004125EA
		[NullableContext(1)]
		public static TrapDefenseRefreshShopResponse Create()
		{
			return new TrapDefenseRefreshShopResponse();
		}

		// Token: 0x17005F1B RID: 24347
		// (get) Token: 0x0601C1AE RID: 115118 RVA: 0x004143F1 File Offset: 0x004125F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005F1C RID: 24348
		// (get) Token: 0x0601C1AF RID: 115119 RVA: 0x004143F4 File Offset: 0x004125F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseRefreshShopResponse.Descriptor;
			}
		}

		// Token: 0x0601C1B0 RID: 115120 RVA: 0x004143FB File Offset: 0x004125FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseRefreshShopResponse()
		{
		}

		// Token: 0x0601C1B1 RID: 115121 RVA: 0x00414404 File Offset: 0x00412604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseRefreshShopResponse(TrapDefenseRefreshShopResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.newShopInfo_ = ((other.newShopInfo_ != null) ? other.newShopInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C1B2 RID: 115122 RVA: 0x00414450 File Offset: 0x00412650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseRefreshShopResponse Clone()
		{
			return new TrapDefenseRefreshShopResponse(this);
		}

		// Token: 0x17005F1D RID: 24349
		// (get) Token: 0x0601C1B3 RID: 115123 RVA: 0x00414458 File Offset: 0x00412658
		// (set) Token: 0x0601C1B4 RID: 115124 RVA: 0x00414460 File Offset: 0x00412660
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

		// Token: 0x17005F1E RID: 24350
		// (get) Token: 0x0601C1B5 RID: 115125 RVA: 0x00414469 File Offset: 0x00412669
		// (set) Token: 0x0601C1B6 RID: 115126 RVA: 0x00414471 File Offset: 0x00412671
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseShopPanelInfo NewShopInfo
		{
			get
			{
				return this.newShopInfo_;
			}
			set
			{
				this.newShopInfo_ = value;
			}
		}

		// Token: 0x0601C1B7 RID: 115127 RVA: 0x0041447A File Offset: 0x0041267A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseRefreshShopResponse);
		}

		// Token: 0x0601C1B8 RID: 115128 RVA: 0x00414488 File Offset: 0x00412688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseRefreshShopResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.NewShopInfo, other.NewShopInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C1B9 RID: 115129 RVA: 0x004144D8 File Offset: 0x004126D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.newShopInfo_ != null)
			{
				num ^= this.NewShopInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C1BA RID: 115130 RVA: 0x00414533 File Offset: 0x00412733
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C1BB RID: 115131 RVA: 0x00414540 File Offset: 0x00412740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C1BC RID: 115132 RVA: 0x0041454C File Offset: 0x0041274C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.newShopInfo_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.NewShopInfo);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C1BD RID: 115133 RVA: 0x004145A8 File Offset: 0x004127A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.newShopInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.NewShopInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C1BE RID: 115134 RVA: 0x00414600 File Offset: 0x00412800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseRefreshShopResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.newShopInfo_ != null)
			{
				if (this.newShopInfo_ == null)
				{
					this.NewShopInfo = new TrapDefenseShopPanelInfo();
				}
				this.NewShopInfo.MergeFrom(other.NewShopInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C1BF RID: 115135 RVA: 0x00414668 File Offset: 0x00412868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C1C0 RID: 115136 RVA: 0x00414674 File Offset: 0x00412874
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
				if (num != 90U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					if (this.newShopInfo_ == null)
					{
						this.NewShopInfo = new TrapDefenseShopPanelInfo();
					}
					input.ReadMessage(this.NewShopInfo);
				}
			}
		}

		// Token: 0x0400A298 RID: 41624
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A299 RID: 41625
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x0400A29A RID: 41626
		private ErrorCode errorCode_;

		// Token: 0x0400A29B RID: 41627
		public const int NewShopInfoFieldNumber = 11;

		// Token: 0x0400A29C RID: 41628
		private TrapDefenseShopPanelInfo newShopInfo_;
	}
}
