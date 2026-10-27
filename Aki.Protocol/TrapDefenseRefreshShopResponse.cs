using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200143E RID: 5182
	[NetMessage(EMessageId.TrapDefenseRefreshShopResponse)]
	public sealed class TrapDefenseRefreshShopResponse : IMessage<TrapDefenseRefreshShopResponse>, IMessage, IEquatable<TrapDefenseRefreshShopResponse>, IDeepCloneable<TrapDefenseRefreshShopResponse>, IBufferMessage
	{
		// Token: 0x0601B722 RID: 112418 RVA: 0x003F9116 File Offset: 0x003F7316
		[NullableContext(1)]
		public static TrapDefenseRefreshShopResponse Create()
		{
			return new TrapDefenseRefreshShopResponse();
		}

		// Token: 0x17005C86 RID: 23686
		// (get) Token: 0x0601B723 RID: 112419 RVA: 0x003F911D File Offset: 0x003F731D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005C87 RID: 23687
		// (get) Token: 0x0601B724 RID: 112420 RVA: 0x003F9120 File Offset: 0x003F7320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseRefreshShopResponse.Descriptor;
			}
		}

		// Token: 0x0601B725 RID: 112421 RVA: 0x003F9127 File Offset: 0x003F7327
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseRefreshShopResponse()
		{
		}

		// Token: 0x0601B726 RID: 112422 RVA: 0x003F9130 File Offset: 0x003F7330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseRefreshShopResponse(TrapDefenseRefreshShopResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.newShopInfo_ = ((other.newShopInfo_ != null) ? other.newShopInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B727 RID: 112423 RVA: 0x003F917C File Offset: 0x003F737C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseRefreshShopResponse Clone()
		{
			return new TrapDefenseRefreshShopResponse(this);
		}

		// Token: 0x17005C88 RID: 23688
		// (get) Token: 0x0601B728 RID: 112424 RVA: 0x003F9184 File Offset: 0x003F7384
		// (set) Token: 0x0601B729 RID: 112425 RVA: 0x003F918C File Offset: 0x003F738C
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

		// Token: 0x17005C89 RID: 23689
		// (get) Token: 0x0601B72A RID: 112426 RVA: 0x003F9195 File Offset: 0x003F7395
		// (set) Token: 0x0601B72B RID: 112427 RVA: 0x003F919D File Offset: 0x003F739D
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

		// Token: 0x0601B72C RID: 112428 RVA: 0x003F91A6 File Offset: 0x003F73A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseRefreshShopResponse);
		}

		// Token: 0x0601B72D RID: 112429 RVA: 0x003F91B4 File Offset: 0x003F73B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseRefreshShopResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.NewShopInfo, other.NewShopInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B72E RID: 112430 RVA: 0x003F9204 File Offset: 0x003F7404
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

		// Token: 0x0601B72F RID: 112431 RVA: 0x003F925F File Offset: 0x003F745F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B730 RID: 112432 RVA: 0x003F926C File Offset: 0x003F746C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B731 RID: 112433 RVA: 0x003F9278 File Offset: 0x003F7478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.newShopInfo_ != null)
			{
				output.WriteRawTag(26);
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

		// Token: 0x0601B732 RID: 112434 RVA: 0x003F92D4 File Offset: 0x003F74D4
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

		// Token: 0x0601B733 RID: 112435 RVA: 0x003F932C File Offset: 0x003F752C
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

		// Token: 0x0601B734 RID: 112436 RVA: 0x003F9394 File Offset: 0x003F7594
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B735 RID: 112437 RVA: 0x003F93A0 File Offset: 0x003F75A0
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
				if (num != 26U)
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

		// Token: 0x04009E51 RID: 40529
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009E52 RID: 40530
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04009E53 RID: 40531
		private ErrorCode errorCode_;

		// Token: 0x04009E54 RID: 40532
		public const int NewShopInfoFieldNumber = 3;

		// Token: 0x04009E55 RID: 40533
		private TrapDefenseShopPanelInfo newShopInfo_;
	}
}
