using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200039E RID: 926
	[NetMessage(EMessageId.DarkCoastInfoResponse)]
	public sealed class DarkCoastInfoResponse : IMessage<DarkCoastInfoResponse>, IMessage, IEquatable<DarkCoastInfoResponse>, IDeepCloneable<DarkCoastInfoResponse>, IBufferMessage
	{
		// Token: 0x06005B7C RID: 23420 RVA: 0x000DEAC5 File Offset: 0x000DCCC5
		[NullableContext(1)]
		public static DarkCoastInfoResponse Create()
		{
			return new DarkCoastInfoResponse();
		}

		// Token: 0x170010ED RID: 4333
		// (get) Token: 0x06005B7D RID: 23421 RVA: 0x000DEACC File Offset: 0x000DCCCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170010EE RID: 4334
		// (get) Token: 0x06005B7E RID: 23422 RVA: 0x000DEACF File Offset: 0x000DCCCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DarkCoastInfoResponse.Descriptor;
			}
		}

		// Token: 0x06005B7F RID: 23423 RVA: 0x000DEAD6 File Offset: 0x000DCCD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkCoastInfoResponse()
		{
		}

		// Token: 0x06005B80 RID: 23424 RVA: 0x000DEAF4 File Offset: 0x000DCCF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkCoastInfoResponse(DarkCoastInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.dragonPoolConf_ = ((other.dragonPoolConf_ != null) ? other.dragonPoolConf_.Clone() : null);
			this.guardIds_ = other.guardIds_.Clone();
			this.treasureBoxDone_ = other.treasureBoxDone_.Clone();
			this.levelGains_ = other.levelGains_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005B81 RID: 23425 RVA: 0x000DEB6E File Offset: 0x000DCD6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkCoastInfoResponse Clone()
		{
			return new DarkCoastInfoResponse(this);
		}

		// Token: 0x170010EF RID: 4335
		// (get) Token: 0x06005B82 RID: 23426 RVA: 0x000DEB76 File Offset: 0x000DCD76
		// (set) Token: 0x06005B83 RID: 23427 RVA: 0x000DEB7E File Offset: 0x000DCD7E
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

		// Token: 0x170010F0 RID: 4336
		// (get) Token: 0x06005B84 RID: 23428 RVA: 0x000DEB87 File Offset: 0x000DCD87
		// (set) Token: 0x06005B85 RID: 23429 RVA: 0x000DEB8F File Offset: 0x000DCD8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DragonPoolConf DragonPoolConf
		{
			get
			{
				return this.dragonPoolConf_;
			}
			set
			{
				this.dragonPoolConf_ = value;
			}
		}

		// Token: 0x170010F1 RID: 4337
		// (get) Token: 0x06005B86 RID: 23430 RVA: 0x000DEB98 File Offset: 0x000DCD98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> GuardIds
		{
			get
			{
				return this.guardIds_;
			}
		}

		// Token: 0x170010F2 RID: 4338
		// (get) Token: 0x06005B87 RID: 23431 RVA: 0x000DEBA0 File Offset: 0x000DCDA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TreasureBoxDone
		{
			get
			{
				return this.treasureBoxDone_;
			}
		}

		// Token: 0x170010F3 RID: 4339
		// (get) Token: 0x06005B88 RID: 23432 RVA: 0x000DEBA8 File Offset: 0x000DCDA8
		// (set) Token: 0x06005B89 RID: 23433 RVA: 0x000DEBB0 File Offset: 0x000DCDB0
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

		// Token: 0x06005B8A RID: 23434 RVA: 0x000DEBB9 File Offset: 0x000DCDB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DarkCoastInfoResponse);
		}

		// Token: 0x06005B8B RID: 23435 RVA: 0x000DEBC8 File Offset: 0x000DCDC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DarkCoastInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.DragonPoolConf, other.DragonPoolConf) && this.guardIds_.Equals(other.guardIds_) && this.treasureBoxDone_.Equals(other.treasureBoxDone_) && this.LevelGains == other.LevelGains && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005B8C RID: 23436 RVA: 0x000DEC50 File Offset: 0x000DCE50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.dragonPoolConf_ != null)
			{
				num ^= this.DragonPoolConf.GetHashCode();
			}
			num ^= this.guardIds_.GetHashCode();
			num ^= this.treasureBoxDone_.GetHashCode();
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

		// Token: 0x06005B8D RID: 23437 RVA: 0x000DECE0 File Offset: 0x000DCEE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005B8E RID: 23438 RVA: 0x000DECED File Offset: 0x000DCEED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005B8F RID: 23439 RVA: 0x000DECF8 File Offset: 0x000DCEF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelGains != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.LevelGains);
			}
			if (this.dragonPoolConf_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.DragonPoolConf);
			}
			this.guardIds_.WriteTo(ref output, DarkCoastInfoResponse._repeated_guardIds_codec);
			this.treasureBoxDone_.WriteTo(ref output, DarkCoastInfoResponse._repeated_treasureBoxDone_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005B90 RID: 23440 RVA: 0x000DED90 File Offset: 0x000DCF90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.dragonPoolConf_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.DragonPoolConf);
			}
			num += this.guardIds_.CalculateSize(DarkCoastInfoResponse._repeated_guardIds_codec);
			num += this.treasureBoxDone_.CalculateSize(DarkCoastInfoResponse._repeated_treasureBoxDone_codec);
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

		// Token: 0x06005B91 RID: 23441 RVA: 0x000DEE24 File Offset: 0x000DD024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DarkCoastInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.dragonPoolConf_ != null)
			{
				if (this.dragonPoolConf_ == null)
				{
					this.DragonPoolConf = new DragonPoolConf();
				}
				this.DragonPoolConf.MergeFrom(other.DragonPoolConf);
			}
			this.guardIds_.Add(other.guardIds_);
			this.treasureBoxDone_.Add(other.treasureBoxDone_);
			if (other.LevelGains != 0)
			{
				this.LevelGains = other.LevelGains;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005B92 RID: 23442 RVA: 0x000DEEC2 File Offset: 0x000DD0C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005B93 RID: 23443 RVA: 0x000DEECC File Offset: 0x000DD0CC
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
				if (num > 32U)
				{
					if (num <= 112U)
					{
						if (num == 34U)
						{
							goto IL_80;
						}
						if (num != 112U)
						{
							goto IL_3D;
						}
					}
					else if (num != 114U)
					{
						if (num != 120U)
						{
							goto IL_3D;
						}
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					this.treasureBoxDone_.AddEntriesFrom(ref input, DarkCoastInfoResponse._repeated_treasureBoxDone_codec);
					continue;
				}
				if (num == 16U)
				{
					this.LevelGains = input.ReadInt32();
					continue;
				}
				if (num == 26U)
				{
					if (this.dragonPoolConf_ == null)
					{
						this.DragonPoolConf = new DragonPoolConf();
					}
					input.ReadMessage(this.DragonPoolConf);
					continue;
				}
				if (num == 32U)
				{
					goto IL_80;
				}
				IL_3D:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_80:
				this.guardIds_.AddEntriesFrom(ref input, DarkCoastInfoResponse._repeated_guardIds_codec);
			}
		}

		// Token: 0x04003656 RID: 13910
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003657 RID: 13911
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x04003658 RID: 13912
		private ErrorCode errorCode_;

		// Token: 0x04003659 RID: 13913
		public const int DragonPoolConfFieldNumber = 3;

		// Token: 0x0400365A RID: 13914
		private DragonPoolConf dragonPoolConf_;

		// Token: 0x0400365B RID: 13915
		public const int GuardIdsFieldNumber = 4;

		// Token: 0x0400365C RID: 13916
		private static readonly FieldCodec<int> _repeated_guardIds_codec = FieldCodec.ForInt32(34U);

		// Token: 0x0400365D RID: 13917
		private readonly RepeatedField<int> guardIds_ = new RepeatedField<int>();

		// Token: 0x0400365E RID: 13918
		public const int TreasureBoxDoneFieldNumber = 14;

		// Token: 0x0400365F RID: 13919
		private static readonly FieldCodec<int> _repeated_treasureBoxDone_codec = FieldCodec.ForInt32(114U);

		// Token: 0x04003660 RID: 13920
		private readonly RepeatedField<int> treasureBoxDone_ = new RepeatedField<int>();

		// Token: 0x04003661 RID: 13921
		public const int LevelGainsFieldNumber = 2;

		// Token: 0x04003662 RID: 13922
		private int levelGains_;
	}
}
