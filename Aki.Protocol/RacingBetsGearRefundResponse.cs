using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E4D RID: 3661
	[NetMessage(EMessageId.RacingBetsGearRefundResponse)]
	public sealed class RacingBetsGearRefundResponse : IMessage<RacingBetsGearRefundResponse>, IMessage, IEquatable<RacingBetsGearRefundResponse>, IDeepCloneable<RacingBetsGearRefundResponse>, IBufferMessage
	{
		// Token: 0x06013AEB RID: 80619 RVA: 0x002DCF93 File Offset: 0x002DB193
		[NullableContext(1)]
		public static RacingBetsGearRefundResponse Create()
		{
			return new RacingBetsGearRefundResponse();
		}

		// Token: 0x17004159 RID: 16729
		// (get) Token: 0x06013AEC RID: 80620 RVA: 0x002DCF9A File Offset: 0x002DB19A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700415A RID: 16730
		// (get) Token: 0x06013AED RID: 80621 RVA: 0x002DCF9D File Offset: 0x002DB19D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsGearRefundResponse.Descriptor;
			}
		}

		// Token: 0x06013AEE RID: 80622 RVA: 0x002DCFA4 File Offset: 0x002DB1A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsGearRefundResponse()
		{
		}

		// Token: 0x06013AEF RID: 80623 RVA: 0x002DCFAC File Offset: 0x002DB1AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsGearRefundResponse(RacingBetsGearRefundResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.playerInfo_ = ((other.playerInfo_ != null) ? other.playerInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013AF0 RID: 80624 RVA: 0x002DCFF8 File Offset: 0x002DB1F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsGearRefundResponse Clone()
		{
			return new RacingBetsGearRefundResponse(this);
		}

		// Token: 0x1700415B RID: 16731
		// (get) Token: 0x06013AF1 RID: 80625 RVA: 0x002DD000 File Offset: 0x002DB200
		// (set) Token: 0x06013AF2 RID: 80626 RVA: 0x002DD008 File Offset: 0x002DB208
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

		// Token: 0x1700415C RID: 16732
		// (get) Token: 0x06013AF3 RID: 80627 RVA: 0x002DD011 File Offset: 0x002DB211
		// (set) Token: 0x06013AF4 RID: 80628 RVA: 0x002DD019 File Offset: 0x002DB219
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetPlayerInfo PlayerInfo
		{
			get
			{
				return this.playerInfo_;
			}
			set
			{
				this.playerInfo_ = value;
			}
		}

		// Token: 0x06013AF5 RID: 80629 RVA: 0x002DD022 File Offset: 0x002DB222
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsGearRefundResponse);
		}

		// Token: 0x06013AF6 RID: 80630 RVA: 0x002DD030 File Offset: 0x002DB230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsGearRefundResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.PlayerInfo, other.PlayerInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013AF7 RID: 80631 RVA: 0x002DD080 File Offset: 0x002DB280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.playerInfo_ != null)
			{
				num ^= this.PlayerInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013AF8 RID: 80632 RVA: 0x002DD0DB File Offset: 0x002DB2DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013AF9 RID: 80633 RVA: 0x002DD0E8 File Offset: 0x002DB2E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013AFA RID: 80634 RVA: 0x002DD0F4 File Offset: 0x002DB2F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.playerInfo_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.PlayerInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013AFB RID: 80635 RVA: 0x002DD150 File Offset: 0x002DB350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.playerInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PlayerInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013AFC RID: 80636 RVA: 0x002DD1A8 File Offset: 0x002DB3A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsGearRefundResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.playerInfo_ != null)
			{
				if (this.playerInfo_ == null)
				{
					this.PlayerInfo = new RacingBetPlayerInfo();
				}
				this.PlayerInfo.MergeFrom(other.PlayerInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013AFD RID: 80637 RVA: 0x002DD210 File Offset: 0x002DB410
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013AFE RID: 80638 RVA: 0x002DD21C File Offset: 0x002DB41C
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
				if (num != 48U)
				{
					if (num != 82U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.playerInfo_ == null)
						{
							this.PlayerInfo = new RacingBetPlayerInfo();
						}
						input.ReadMessage(this.PlayerInfo);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040078DA RID: 30938
		private UnknownFieldSet _unknownFields;

		// Token: 0x040078DB RID: 30939
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x040078DC RID: 30940
		private ErrorCode errorCode_;

		// Token: 0x040078DD RID: 30941
		public const int PlayerInfoFieldNumber = 10;

		// Token: 0x040078DE RID: 30942
		private RacingBetPlayerInfo playerInfo_;
	}
}
