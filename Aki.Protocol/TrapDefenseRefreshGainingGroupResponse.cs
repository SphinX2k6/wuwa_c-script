using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200143C RID: 5180
	[NetMessage(EMessageId.TrapDefenseRefreshGainingGroupResponse)]
	public sealed class TrapDefenseRefreshGainingGroupResponse : IMessage<TrapDefenseRefreshGainingGroupResponse>, IMessage, IEquatable<TrapDefenseRefreshGainingGroupResponse>, IDeepCloneable<TrapDefenseRefreshGainingGroupResponse>, IBufferMessage
	{
		// Token: 0x0601B6FE RID: 112382 RVA: 0x003F8CE6 File Offset: 0x003F6EE6
		[NullableContext(1)]
		public static TrapDefenseRefreshGainingGroupResponse Create()
		{
			return new TrapDefenseRefreshGainingGroupResponse();
		}

		// Token: 0x17005C80 RID: 23680
		// (get) Token: 0x0601B6FF RID: 112383 RVA: 0x003F8CED File Offset: 0x003F6EED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005C81 RID: 23681
		// (get) Token: 0x0601B700 RID: 112384 RVA: 0x003F8CF0 File Offset: 0x003F6EF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseRefreshGainingGroupResponse.Descriptor;
			}
		}

		// Token: 0x0601B701 RID: 112385 RVA: 0x003F8CF7 File Offset: 0x003F6EF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseRefreshGainingGroupResponse()
		{
		}

		// Token: 0x0601B702 RID: 112386 RVA: 0x003F8D00 File Offset: 0x003F6F00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseRefreshGainingGroupResponse(TrapDefenseRefreshGainingGroupResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.newRewardInfo_ = ((other.newRewardInfo_ != null) ? other.newRewardInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B703 RID: 112387 RVA: 0x003F8D4C File Offset: 0x003F6F4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseRefreshGainingGroupResponse Clone()
		{
			return new TrapDefenseRefreshGainingGroupResponse(this);
		}

		// Token: 0x17005C82 RID: 23682
		// (get) Token: 0x0601B704 RID: 112388 RVA: 0x003F8D54 File Offset: 0x003F6F54
		// (set) Token: 0x0601B705 RID: 112389 RVA: 0x003F8D5C File Offset: 0x003F6F5C
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

		// Token: 0x17005C83 RID: 23683
		// (get) Token: 0x0601B706 RID: 112390 RVA: 0x003F8D65 File Offset: 0x003F6F65
		// (set) Token: 0x0601B707 RID: 112391 RVA: 0x003F8D6D File Offset: 0x003F6F6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RewardGainingPanelInfo NewRewardInfo
		{
			get
			{
				return this.newRewardInfo_;
			}
			set
			{
				this.newRewardInfo_ = value;
			}
		}

		// Token: 0x0601B708 RID: 112392 RVA: 0x003F8D76 File Offset: 0x003F6F76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseRefreshGainingGroupResponse);
		}

		// Token: 0x0601B709 RID: 112393 RVA: 0x003F8D84 File Offset: 0x003F6F84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseRefreshGainingGroupResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.NewRewardInfo, other.NewRewardInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B70A RID: 112394 RVA: 0x003F8DD4 File Offset: 0x003F6FD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.newRewardInfo_ != null)
			{
				num ^= this.NewRewardInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B70B RID: 112395 RVA: 0x003F8E2F File Offset: 0x003F702F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B70C RID: 112396 RVA: 0x003F8E3C File Offset: 0x003F703C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B70D RID: 112397 RVA: 0x003F8E48 File Offset: 0x003F7048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.newRewardInfo_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.NewRewardInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B70E RID: 112398 RVA: 0x003F8EA4 File Offset: 0x003F70A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.newRewardInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.NewRewardInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B70F RID: 112399 RVA: 0x003F8EFC File Offset: 0x003F70FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseRefreshGainingGroupResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.newRewardInfo_ != null)
			{
				if (this.newRewardInfo_ == null)
				{
					this.NewRewardInfo = new RewardGainingPanelInfo();
				}
				this.NewRewardInfo.MergeFrom(other.NewRewardInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B710 RID: 112400 RVA: 0x003F8F64 File Offset: 0x003F7164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B711 RID: 112401 RVA: 0x003F8F70 File Offset: 0x003F7170
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
				if (num != 32U)
				{
					if (num != 90U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.newRewardInfo_ == null)
						{
							this.NewRewardInfo = new RewardGainingPanelInfo();
						}
						input.ReadMessage(this.NewRewardInfo);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009E4B RID: 40523
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009E4C RID: 40524
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04009E4D RID: 40525
		private ErrorCode errorCode_;

		// Token: 0x04009E4E RID: 40526
		public const int NewRewardInfoFieldNumber = 11;

		// Token: 0x04009E4F RID: 40527
		private RewardGainingPanelInfo newRewardInfo_;
	}
}
