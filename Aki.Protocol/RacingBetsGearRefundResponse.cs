using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E5D RID: 3677
	[NetMessage(EMessageId.RacingBetsGearRefundResponse)]
	public sealed class RacingBetsGearRefundResponse : IMessage<RacingBetsGearRefundResponse>, IMessage, IEquatable<RacingBetsGearRefundResponse>, IDeepCloneable<RacingBetsGearRefundResponse>, IBufferMessage
	{
		// Token: 0x06013BD0 RID: 80848 RVA: 0x002DE64A File Offset: 0x002DC84A
		[NullableContext(1)]
		public static RacingBetsGearRefundResponse Create()
		{
			return new RacingBetsGearRefundResponse();
		}

		// Token: 0x17004183 RID: 16771
		// (get) Token: 0x06013BD1 RID: 80849 RVA: 0x002DE651 File Offset: 0x002DC851
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004184 RID: 16772
		// (get) Token: 0x06013BD2 RID: 80850 RVA: 0x002DE654 File Offset: 0x002DC854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsGearRefundResponse.Descriptor;
			}
		}

		// Token: 0x06013BD3 RID: 80851 RVA: 0x002DE65B File Offset: 0x002DC85B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsGearRefundResponse()
		{
		}

		// Token: 0x06013BD4 RID: 80852 RVA: 0x002DE664 File Offset: 0x002DC864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsGearRefundResponse(RacingBetsGearRefundResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.playerInfo_ = ((other.playerInfo_ != null) ? other.playerInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013BD5 RID: 80853 RVA: 0x002DE6B0 File Offset: 0x002DC8B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsGearRefundResponse Clone()
		{
			return new RacingBetsGearRefundResponse(this);
		}

		// Token: 0x17004185 RID: 16773
		// (get) Token: 0x06013BD6 RID: 80854 RVA: 0x002DE6B8 File Offset: 0x002DC8B8
		// (set) Token: 0x06013BD7 RID: 80855 RVA: 0x002DE6C0 File Offset: 0x002DC8C0
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

		// Token: 0x17004186 RID: 16774
		// (get) Token: 0x06013BD8 RID: 80856 RVA: 0x002DE6C9 File Offset: 0x002DC8C9
		// (set) Token: 0x06013BD9 RID: 80857 RVA: 0x002DE6D1 File Offset: 0x002DC8D1
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

		// Token: 0x06013BDA RID: 80858 RVA: 0x002DE6DA File Offset: 0x002DC8DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsGearRefundResponse);
		}

		// Token: 0x06013BDB RID: 80859 RVA: 0x002DE6E8 File Offset: 0x002DC8E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsGearRefundResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.PlayerInfo, other.PlayerInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013BDC RID: 80860 RVA: 0x002DE738 File Offset: 0x002DC938
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

		// Token: 0x06013BDD RID: 80861 RVA: 0x002DE793 File Offset: 0x002DC993
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013BDE RID: 80862 RVA: 0x002DE7A0 File Offset: 0x002DC9A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013BDF RID: 80863 RVA: 0x002DE7AC File Offset: 0x002DC9AC
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

		// Token: 0x06013BE0 RID: 80864 RVA: 0x002DE808 File Offset: 0x002DCA08
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

		// Token: 0x06013BE1 RID: 80865 RVA: 0x002DE860 File Offset: 0x002DCA60
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

		// Token: 0x06013BE2 RID: 80866 RVA: 0x002DE8C8 File Offset: 0x002DCAC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013BE3 RID: 80867 RVA: 0x002DE8D4 File Offset: 0x002DCAD4
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

		// Token: 0x040078B0 RID: 30896
		private UnknownFieldSet _unknownFields;

		// Token: 0x040078B1 RID: 30897
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x040078B2 RID: 30898
		private ErrorCode errorCode_;

		// Token: 0x040078B3 RID: 30899
		public const int PlayerInfoFieldNumber = 10;

		// Token: 0x040078B4 RID: 30900
		private RacingBetPlayerInfo playerInfo_;
	}
}
