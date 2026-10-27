using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E6F RID: 3695
	[NetMessage(EMessageId.RacingBetsPlayerInfoResponse)]
	public sealed class RacingBetsPlayerInfoResponse : IMessage<RacingBetsPlayerInfoResponse>, IMessage, IEquatable<RacingBetsPlayerInfoResponse>, IDeepCloneable<RacingBetsPlayerInfoResponse>, IBufferMessage
	{
		// Token: 0x06013DA1 RID: 81313 RVA: 0x002E42F1 File Offset: 0x002E24F1
		[NullableContext(1)]
		public static RacingBetsPlayerInfoResponse Create()
		{
			return new RacingBetsPlayerInfoResponse();
		}

		// Token: 0x17004206 RID: 16902
		// (get) Token: 0x06013DA2 RID: 81314 RVA: 0x002E42F8 File Offset: 0x002E24F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004207 RID: 16903
		// (get) Token: 0x06013DA3 RID: 81315 RVA: 0x002E42FB File Offset: 0x002E24FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsPlayerInfoResponse.Descriptor;
			}
		}

		// Token: 0x06013DA4 RID: 81316 RVA: 0x002E4302 File Offset: 0x002E2502
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsPlayerInfoResponse()
		{
		}

		// Token: 0x06013DA5 RID: 81317 RVA: 0x002E430C File Offset: 0x002E250C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsPlayerInfoResponse(RacingBetsPlayerInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.playerInfo_ = ((other.playerInfo_ != null) ? other.playerInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013DA6 RID: 81318 RVA: 0x002E4358 File Offset: 0x002E2558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsPlayerInfoResponse Clone()
		{
			return new RacingBetsPlayerInfoResponse(this);
		}

		// Token: 0x17004208 RID: 16904
		// (get) Token: 0x06013DA7 RID: 81319 RVA: 0x002E4360 File Offset: 0x002E2560
		// (set) Token: 0x06013DA8 RID: 81320 RVA: 0x002E4368 File Offset: 0x002E2568
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

		// Token: 0x17004209 RID: 16905
		// (get) Token: 0x06013DA9 RID: 81321 RVA: 0x002E4371 File Offset: 0x002E2571
		// (set) Token: 0x06013DAA RID: 81322 RVA: 0x002E4379 File Offset: 0x002E2579
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

		// Token: 0x06013DAB RID: 81323 RVA: 0x002E4382 File Offset: 0x002E2582
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsPlayerInfoResponse);
		}

		// Token: 0x06013DAC RID: 81324 RVA: 0x002E4390 File Offset: 0x002E2590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsPlayerInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.PlayerInfo, other.PlayerInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013DAD RID: 81325 RVA: 0x002E43E0 File Offset: 0x002E25E0
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

		// Token: 0x06013DAE RID: 81326 RVA: 0x002E443B File Offset: 0x002E263B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013DAF RID: 81327 RVA: 0x002E4448 File Offset: 0x002E2648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013DB0 RID: 81328 RVA: 0x002E4454 File Offset: 0x002E2654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
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

		// Token: 0x06013DB1 RID: 81329 RVA: 0x002E44B0 File Offset: 0x002E26B0
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

		// Token: 0x06013DB2 RID: 81330 RVA: 0x002E4508 File Offset: 0x002E2708
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

		// Token: 0x06013DB3 RID: 81331 RVA: 0x002E4570 File Offset: 0x002E2770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013DB4 RID: 81332 RVA: 0x002E457C File Offset: 0x002E277C
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
				if (num != 56U)
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

		// Token: 0x04007971 RID: 31089
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007972 RID: 31090
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x04007973 RID: 31091
		private ErrorCode errorCode_;

		// Token: 0x04007974 RID: 31092
		public const int PlayerInfoFieldNumber = 11;

		// Token: 0x04007975 RID: 31093
		private RacingBetPlayerInfo playerInfo_;
	}
}
