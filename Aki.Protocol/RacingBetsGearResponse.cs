using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E5F RID: 3679
	[NetMessage(EMessageId.RacingBetsGearResponse)]
	public sealed class RacingBetsGearResponse : IMessage<RacingBetsGearResponse>, IMessage, IEquatable<RacingBetsGearResponse>, IDeepCloneable<RacingBetsGearResponse>, IBufferMessage
	{
		// Token: 0x06013C00 RID: 80896 RVA: 0x002DEEA9 File Offset: 0x002DD0A9
		[NullableContext(1)]
		public static RacingBetsGearResponse Create()
		{
			return new RacingBetsGearResponse();
		}

		// Token: 0x1700418F RID: 16783
		// (get) Token: 0x06013C01 RID: 80897 RVA: 0x002DEEB0 File Offset: 0x002DD0B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004190 RID: 16784
		// (get) Token: 0x06013C02 RID: 80898 RVA: 0x002DEEB3 File Offset: 0x002DD0B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsGearResponse.Descriptor;
			}
		}

		// Token: 0x06013C03 RID: 80899 RVA: 0x002DEEBA File Offset: 0x002DD0BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsGearResponse()
		{
		}

		// Token: 0x06013C04 RID: 80900 RVA: 0x002DEEC4 File Offset: 0x002DD0C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsGearResponse(RacingBetsGearResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.playerInfo_ = ((other.playerInfo_ != null) ? other.playerInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013C05 RID: 80901 RVA: 0x002DEF10 File Offset: 0x002DD110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsGearResponse Clone()
		{
			return new RacingBetsGearResponse(this);
		}

		// Token: 0x17004191 RID: 16785
		// (get) Token: 0x06013C06 RID: 80902 RVA: 0x002DEF18 File Offset: 0x002DD118
		// (set) Token: 0x06013C07 RID: 80903 RVA: 0x002DEF20 File Offset: 0x002DD120
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

		// Token: 0x17004192 RID: 16786
		// (get) Token: 0x06013C08 RID: 80904 RVA: 0x002DEF29 File Offset: 0x002DD129
		// (set) Token: 0x06013C09 RID: 80905 RVA: 0x002DEF31 File Offset: 0x002DD131
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

		// Token: 0x06013C0A RID: 80906 RVA: 0x002DEF3A File Offset: 0x002DD13A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsGearResponse);
		}

		// Token: 0x06013C0B RID: 80907 RVA: 0x002DEF48 File Offset: 0x002DD148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsGearResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.PlayerInfo, other.PlayerInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013C0C RID: 80908 RVA: 0x002DEF98 File Offset: 0x002DD198
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

		// Token: 0x06013C0D RID: 80909 RVA: 0x002DEFF3 File Offset: 0x002DD1F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013C0E RID: 80910 RVA: 0x002DF000 File Offset: 0x002DD200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013C0F RID: 80911 RVA: 0x002DF00C File Offset: 0x002DD20C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.playerInfo_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.PlayerInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013C10 RID: 80912 RVA: 0x002DF068 File Offset: 0x002DD268
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

		// Token: 0x06013C11 RID: 80913 RVA: 0x002DF0C0 File Offset: 0x002DD2C0
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

		// Token: 0x06013C12 RID: 80914 RVA: 0x002DF128 File Offset: 0x002DD328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013C13 RID: 80915 RVA: 0x002DF134 File Offset: 0x002DD334
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
				if (num != 16U)
				{
					if (num != 58U)
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

		// Token: 0x040078C2 RID: 30914
		private UnknownFieldSet _unknownFields;

		// Token: 0x040078C3 RID: 30915
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x040078C4 RID: 30916
		private ErrorCode errorCode_;

		// Token: 0x040078C5 RID: 30917
		public const int PlayerInfoFieldNumber = 7;

		// Token: 0x040078C6 RID: 30918
		private RacingBetPlayerInfo playerInfo_;
	}
}
