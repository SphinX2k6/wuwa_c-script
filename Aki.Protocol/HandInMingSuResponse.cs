using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000727 RID: 1831
	[NetMessage(EMessageId.HandInMingSuResponse)]
	public sealed class HandInMingSuResponse : IMessage<HandInMingSuResponse>, IMessage, IEquatable<HandInMingSuResponse>, IDeepCloneable<HandInMingSuResponse>, IBufferMessage
	{
		// Token: 0x0600A671 RID: 42609 RVA: 0x00191280 File Offset: 0x0018F480
		[NullableContext(1)]
		public static HandInMingSuResponse Create()
		{
			return new HandInMingSuResponse();
		}

		// Token: 0x17002171 RID: 8561
		// (get) Token: 0x0600A672 RID: 42610 RVA: 0x00191287 File Offset: 0x0018F487
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002172 RID: 8562
		// (get) Token: 0x0600A673 RID: 42611 RVA: 0x0019128A File Offset: 0x0018F48A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HandInMingSuResponse.Descriptor;
			}
		}

		// Token: 0x0600A674 RID: 42612 RVA: 0x00191291 File Offset: 0x0018F491
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HandInMingSuResponse()
		{
		}

		// Token: 0x0600A675 RID: 42613 RVA: 0x0019129C File Offset: 0x0018F49C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HandInMingSuResponse(HandInMingSuResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.dragonPoolId_ = other.dragonPoolId_;
			this.level_ = other.level_;
			this.injectedCoreItemCount_ = other.injectedCoreItemCount_;
			this.levelGains_ = other.levelGains_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A676 RID: 42614 RVA: 0x001912FC File Offset: 0x0018F4FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HandInMingSuResponse Clone()
		{
			return new HandInMingSuResponse(this);
		}

		// Token: 0x17002173 RID: 8563
		// (get) Token: 0x0600A677 RID: 42615 RVA: 0x00191304 File Offset: 0x0018F504
		// (set) Token: 0x0600A678 RID: 42616 RVA: 0x0019130C File Offset: 0x0018F50C
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

		// Token: 0x17002174 RID: 8564
		// (get) Token: 0x0600A679 RID: 42617 RVA: 0x00191315 File Offset: 0x0018F515
		// (set) Token: 0x0600A67A RID: 42618 RVA: 0x0019131D File Offset: 0x0018F51D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DragonPoolId
		{
			get
			{
				return this.dragonPoolId_;
			}
			set
			{
				this.dragonPoolId_ = value;
			}
		}

		// Token: 0x17002175 RID: 8565
		// (get) Token: 0x0600A67B RID: 42619 RVA: 0x00191326 File Offset: 0x0018F526
		// (set) Token: 0x0600A67C RID: 42620 RVA: 0x0019132E File Offset: 0x0018F52E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x17002176 RID: 8566
		// (get) Token: 0x0600A67D RID: 42621 RVA: 0x00191337 File Offset: 0x0018F537
		// (set) Token: 0x0600A67E RID: 42622 RVA: 0x0019133F File Offset: 0x0018F53F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InjectedCoreItemCount
		{
			get
			{
				return this.injectedCoreItemCount_;
			}
			set
			{
				this.injectedCoreItemCount_ = value;
			}
		}

		// Token: 0x17002177 RID: 8567
		// (get) Token: 0x0600A67F RID: 42623 RVA: 0x00191348 File Offset: 0x0018F548
		// (set) Token: 0x0600A680 RID: 42624 RVA: 0x00191350 File Offset: 0x0018F550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LevelGains
		{
			get
			{
				return this.levelGains_;
			}
			set
			{
				this.levelGains_ = value;
			}
		}

		// Token: 0x0600A681 RID: 42625 RVA: 0x00191359 File Offset: 0x0018F559
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HandInMingSuResponse);
		}

		// Token: 0x0600A682 RID: 42626 RVA: 0x00191368 File Offset: 0x0018F568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HandInMingSuResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.DragonPoolId == other.DragonPoolId && this.Level == other.Level && this.InjectedCoreItemCount == other.InjectedCoreItemCount && this.LevelGains == other.LevelGains && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A683 RID: 42627 RVA: 0x001913E4 File Offset: 0x0018F5E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.DragonPoolId != 0)
			{
				num ^= this.DragonPoolId.GetHashCode();
			}
			if (this.Level != 0)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.InjectedCoreItemCount != 0)
			{
				num ^= this.InjectedCoreItemCount.GetHashCode();
			}
			if (this.LevelGains != 0)
			{
				num ^= this.LevelGains.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A684 RID: 42628 RVA: 0x0019148D File Offset: 0x0018F68D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A685 RID: 42629 RVA: 0x0019149A File Offset: 0x0018F69A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A686 RID: 42630 RVA: 0x001914A4 File Offset: 0x0018F6A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InjectedCoreItemCount != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.InjectedCoreItemCount);
			}
			if (this.Level != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.Level);
			}
			if (this.DragonPoolId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.DragonPoolId);
			}
			if (this.LevelGains != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.LevelGains);
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

		// Token: 0x0600A687 RID: 42631 RVA: 0x00191554 File Offset: 0x0018F754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.DragonPoolId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DragonPoolId);
			}
			if (this.Level != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			if (this.InjectedCoreItemCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InjectedCoreItemCount);
			}
			if (this.LevelGains != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelGains);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A688 RID: 42632 RVA: 0x001915F4 File Offset: 0x0018F7F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HandInMingSuResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.DragonPoolId != 0)
			{
				this.DragonPoolId = other.DragonPoolId;
			}
			if (other.Level != 0)
			{
				this.Level = other.Level;
			}
			if (other.InjectedCoreItemCount != 0)
			{
				this.InjectedCoreItemCount = other.InjectedCoreItemCount;
			}
			if (other.LevelGains != 0)
			{
				this.LevelGains = other.LevelGains;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A689 RID: 42633 RVA: 0x00191680 File Offset: 0x0018F880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A68A RID: 42634 RVA: 0x0019168C File Offset: 0x0018F88C
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
				if (num <= 64U)
				{
					if (num == 48U)
					{
						this.InjectedCoreItemCount = input.ReadInt32();
						continue;
					}
					if (num == 64U)
					{
						this.Level = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.DragonPoolId = input.ReadInt32();
						continue;
					}
					if (num == 104U)
					{
						this.LevelGains = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004C9E RID: 19614
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004C9F RID: 19615
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04004CA0 RID: 19616
		private ErrorCode errorCode_;

		// Token: 0x04004CA1 RID: 19617
		public const int DragonPoolIdFieldNumber = 10;

		// Token: 0x04004CA2 RID: 19618
		private int dragonPoolId_;

		// Token: 0x04004CA3 RID: 19619
		public const int LevelFieldNumber = 8;

		// Token: 0x04004CA4 RID: 19620
		private int level_;

		// Token: 0x04004CA5 RID: 19621
		public const int InjectedCoreItemCountFieldNumber = 6;

		// Token: 0x04004CA6 RID: 19622
		private int injectedCoreItemCount_;

		// Token: 0x04004CA7 RID: 19623
		public const int LevelGainsFieldNumber = 13;

		// Token: 0x04004CA8 RID: 19624
		private int levelGains_;
	}
}
