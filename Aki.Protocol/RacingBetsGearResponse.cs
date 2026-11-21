using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E4F RID: 3663
	[NetMessage(EMessageId.RacingBetsGearResponse)]
	public sealed class RacingBetsGearResponse : IMessage<RacingBetsGearResponse>, IMessage, IEquatable<RacingBetsGearResponse>, IDeepCloneable<RacingBetsGearResponse>, IBufferMessage
	{
		// Token: 0x06013B1B RID: 80667 RVA: 0x002DD7F1 File Offset: 0x002DB9F1
		[NullableContext(1)]
		public static RacingBetsGearResponse Create()
		{
			return new RacingBetsGearResponse();
		}

		// Token: 0x17004165 RID: 16741
		// (get) Token: 0x06013B1C RID: 80668 RVA: 0x002DD7F8 File Offset: 0x002DB9F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004166 RID: 16742
		// (get) Token: 0x06013B1D RID: 80669 RVA: 0x002DD7FB File Offset: 0x002DB9FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsGearResponse.Descriptor;
			}
		}

		// Token: 0x06013B1E RID: 80670 RVA: 0x002DD802 File Offset: 0x002DBA02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsGearResponse()
		{
		}

		// Token: 0x06013B1F RID: 80671 RVA: 0x002DD80C File Offset: 0x002DBA0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsGearResponse(RacingBetsGearResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.playerInfo_ = ((other.playerInfo_ != null) ? other.playerInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013B20 RID: 80672 RVA: 0x002DD858 File Offset: 0x002DBA58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsGearResponse Clone()
		{
			return new RacingBetsGearResponse(this);
		}

		// Token: 0x17004167 RID: 16743
		// (get) Token: 0x06013B21 RID: 80673 RVA: 0x002DD860 File Offset: 0x002DBA60
		// (set) Token: 0x06013B22 RID: 80674 RVA: 0x002DD868 File Offset: 0x002DBA68
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

		// Token: 0x17004168 RID: 16744
		// (get) Token: 0x06013B23 RID: 80675 RVA: 0x002DD871 File Offset: 0x002DBA71
		// (set) Token: 0x06013B24 RID: 80676 RVA: 0x002DD879 File Offset: 0x002DBA79
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

		// Token: 0x06013B25 RID: 80677 RVA: 0x002DD882 File Offset: 0x002DBA82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsGearResponse);
		}

		// Token: 0x06013B26 RID: 80678 RVA: 0x002DD890 File Offset: 0x002DBA90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsGearResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.PlayerInfo, other.PlayerInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013B27 RID: 80679 RVA: 0x002DD8E0 File Offset: 0x002DBAE0
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

		// Token: 0x06013B28 RID: 80680 RVA: 0x002DD93B File Offset: 0x002DBB3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013B29 RID: 80681 RVA: 0x002DD948 File Offset: 0x002DBB48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013B2A RID: 80682 RVA: 0x002DD954 File Offset: 0x002DBB54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.playerInfo_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.PlayerInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013B2B RID: 80683 RVA: 0x002DD9AC File Offset: 0x002DBBAC
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

		// Token: 0x06013B2C RID: 80684 RVA: 0x002DDA04 File Offset: 0x002DBC04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsGearResponse other)
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

		// Token: 0x06013B2D RID: 80685 RVA: 0x002DDA6C File Offset: 0x002DBC6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013B2E RID: 80686 RVA: 0x002DDA78 File Offset: 0x002DBC78
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

		// Token: 0x040078EC RID: 30956
		private UnknownFieldSet _unknownFields;

		// Token: 0x040078ED RID: 30957
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x040078EE RID: 30958
		private ErrorCode errorCode_;

		// Token: 0x040078EF RID: 30959
		public const int PlayerInfoFieldNumber = 12;

		// Token: 0x040078F0 RID: 30960
		private RacingBetPlayerInfo playerInfo_;
	}
}
