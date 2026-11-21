using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E5F RID: 3679
	[NetMessage(EMessageId.RacingBetsPlayerInfoResponse)]
	public sealed class RacingBetsPlayerInfoResponse : IMessage<RacingBetsPlayerInfoResponse>, IMessage, IEquatable<RacingBetsPlayerInfoResponse>, IDeepCloneable<RacingBetsPlayerInfoResponse>, IBufferMessage
	{
		// Token: 0x06013CBC RID: 81084 RVA: 0x002E2C31 File Offset: 0x002E0E31
		[NullableContext(1)]
		public static RacingBetsPlayerInfoResponse Create()
		{
			return new RacingBetsPlayerInfoResponse();
		}

		// Token: 0x170041DC RID: 16860
		// (get) Token: 0x06013CBD RID: 81085 RVA: 0x002E2C38 File Offset: 0x002E0E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170041DD RID: 16861
		// (get) Token: 0x06013CBE RID: 81086 RVA: 0x002E2C3B File Offset: 0x002E0E3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsPlayerInfoResponse.Descriptor;
			}
		}

		// Token: 0x06013CBF RID: 81087 RVA: 0x002E2C42 File Offset: 0x002E0E42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsPlayerInfoResponse()
		{
		}

		// Token: 0x06013CC0 RID: 81088 RVA: 0x002E2C4C File Offset: 0x002E0E4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsPlayerInfoResponse(RacingBetsPlayerInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.playerInfo_ = ((other.playerInfo_ != null) ? other.playerInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013CC1 RID: 81089 RVA: 0x002E2C98 File Offset: 0x002E0E98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsPlayerInfoResponse Clone()
		{
			return new RacingBetsPlayerInfoResponse(this);
		}

		// Token: 0x170041DE RID: 16862
		// (get) Token: 0x06013CC2 RID: 81090 RVA: 0x002E2CA0 File Offset: 0x002E0EA0
		// (set) Token: 0x06013CC3 RID: 81091 RVA: 0x002E2CA8 File Offset: 0x002E0EA8
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

		// Token: 0x170041DF RID: 16863
		// (get) Token: 0x06013CC4 RID: 81092 RVA: 0x002E2CB1 File Offset: 0x002E0EB1
		// (set) Token: 0x06013CC5 RID: 81093 RVA: 0x002E2CB9 File Offset: 0x002E0EB9
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

		// Token: 0x06013CC6 RID: 81094 RVA: 0x002E2CC2 File Offset: 0x002E0EC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsPlayerInfoResponse);
		}

		// Token: 0x06013CC7 RID: 81095 RVA: 0x002E2CD0 File Offset: 0x002E0ED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsPlayerInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.PlayerInfo, other.PlayerInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013CC8 RID: 81096 RVA: 0x002E2D20 File Offset: 0x002E0F20
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

		// Token: 0x06013CC9 RID: 81097 RVA: 0x002E2D7B File Offset: 0x002E0F7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013CCA RID: 81098 RVA: 0x002E2D88 File Offset: 0x002E0F88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013CCB RID: 81099 RVA: 0x002E2D94 File Offset: 0x002E0F94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.playerInfo_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.PlayerInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013CCC RID: 81100 RVA: 0x002E2DF0 File Offset: 0x002E0FF0
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

		// Token: 0x06013CCD RID: 81101 RVA: 0x002E2E48 File Offset: 0x002E1048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsPlayerInfoResponse other)
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

		// Token: 0x06013CCE RID: 81102 RVA: 0x002E2EB0 File Offset: 0x002E10B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013CCF RID: 81103 RVA: 0x002E2EBC File Offset: 0x002E10BC
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
				if (num != 64U)
				{
					if (num != 90U)
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

		// Token: 0x0400799B RID: 31131
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400799C RID: 31132
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x0400799D RID: 31133
		private ErrorCode errorCode_;

		// Token: 0x0400799E RID: 31134
		public const int PlayerInfoFieldNumber = 11;

		// Token: 0x0400799F RID: 31135
		private RacingBetPlayerInfo playerInfo_;
	}
}
