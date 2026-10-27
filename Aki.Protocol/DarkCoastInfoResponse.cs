using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000396 RID: 918
	[NetMessage(EMessageId.DarkCoastInfoResponse)]
	public sealed class DarkCoastInfoResponse : IMessage<DarkCoastInfoResponse>, IMessage, IEquatable<DarkCoastInfoResponse>, IDeepCloneable<DarkCoastInfoResponse>, IBufferMessage
	{
		// Token: 0x06005A8F RID: 23183 RVA: 0x000DC43D File Offset: 0x000DA63D
		[NullableContext(1)]
		public static DarkCoastInfoResponse Create()
		{
			return new DarkCoastInfoResponse();
		}

		// Token: 0x170010BC RID: 4284
		// (get) Token: 0x06005A90 RID: 23184 RVA: 0x000DC444 File Offset: 0x000DA644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170010BD RID: 4285
		// (get) Token: 0x06005A91 RID: 23185 RVA: 0x000DC447 File Offset: 0x000DA647
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DarkCoastInfoResponse.Descriptor;
			}
		}

		// Token: 0x06005A92 RID: 23186 RVA: 0x000DC44E File Offset: 0x000DA64E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkCoastInfoResponse()
		{
		}

		// Token: 0x06005A93 RID: 23187 RVA: 0x000DC46C File Offset: 0x000DA66C
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

		// Token: 0x06005A94 RID: 23188 RVA: 0x000DC4E6 File Offset: 0x000DA6E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkCoastInfoResponse Clone()
		{
			return new DarkCoastInfoResponse(this);
		}

		// Token: 0x170010BE RID: 4286
		// (get) Token: 0x06005A95 RID: 23189 RVA: 0x000DC4EE File Offset: 0x000DA6EE
		// (set) Token: 0x06005A96 RID: 23190 RVA: 0x000DC4F6 File Offset: 0x000DA6F6
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

		// Token: 0x170010BF RID: 4287
		// (get) Token: 0x06005A97 RID: 23191 RVA: 0x000DC4FF File Offset: 0x000DA6FF
		// (set) Token: 0x06005A98 RID: 23192 RVA: 0x000DC507 File Offset: 0x000DA707
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

		// Token: 0x170010C0 RID: 4288
		// (get) Token: 0x06005A99 RID: 23193 RVA: 0x000DC510 File Offset: 0x000DA710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> GuardIds
		{
			get
			{
				return this.guardIds_;
			}
		}

		// Token: 0x170010C1 RID: 4289
		// (get) Token: 0x06005A9A RID: 23194 RVA: 0x000DC518 File Offset: 0x000DA718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TreasureBoxDone
		{
			get
			{
				return this.treasureBoxDone_;
			}
		}

		// Token: 0x170010C2 RID: 4290
		// (get) Token: 0x06005A9B RID: 23195 RVA: 0x000DC520 File Offset: 0x000DA720
		// (set) Token: 0x06005A9C RID: 23196 RVA: 0x000DC528 File Offset: 0x000DA728
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

		// Token: 0x06005A9D RID: 23197 RVA: 0x000DC531 File Offset: 0x000DA731
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DarkCoastInfoResponse);
		}

		// Token: 0x06005A9E RID: 23198 RVA: 0x000DC540 File Offset: 0x000DA740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DarkCoastInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.DragonPoolConf, other.DragonPoolConf) && this.guardIds_.Equals(other.guardIds_) && this.treasureBoxDone_.Equals(other.treasureBoxDone_) && this.LevelGains == other.LevelGains && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005A9F RID: 23199 RVA: 0x000DC5C8 File Offset: 0x000DA7C8
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

		// Token: 0x06005AA0 RID: 23200 RVA: 0x000DC658 File Offset: 0x000DA858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005AA1 RID: 23201 RVA: 0x000DC665 File Offset: 0x000DA865
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005AA2 RID: 23202 RVA: 0x000DC670 File Offset: 0x000DA870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.guardIds_.WriteTo(ref output, DarkCoastInfoResponse._repeated_guardIds_codec);
			if (this.dragonPoolConf_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.DragonPoolConf);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.treasureBoxDone_.WriteTo(ref output, DarkCoastInfoResponse._repeated_treasureBoxDone_codec);
			if (this.LevelGains != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.LevelGains);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005AA3 RID: 23203 RVA: 0x000DC708 File Offset: 0x000DA908
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

		// Token: 0x06005AA4 RID: 23204 RVA: 0x000DC79C File Offset: 0x000DA99C
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

		// Token: 0x06005AA5 RID: 23205 RVA: 0x000DC83A File Offset: 0x000DAA3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005AA6 RID: 23206 RVA: 0x000DC844 File Offset: 0x000DAA44
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
				if (num > 26U)
				{
					if (num <= 96U)
					{
						if (num == 40U)
						{
							this.ErrorCode = (ErrorCode)input.ReadEnum();
							continue;
						}
						if (num != 96U)
						{
							goto IL_3C;
						}
					}
					else if (num != 98U)
					{
						if (num != 104U)
						{
							goto IL_3C;
						}
						this.LevelGains = input.ReadInt32();
						continue;
					}
					this.treasureBoxDone_.AddEntriesFrom(ref input, DarkCoastInfoResponse._repeated_treasureBoxDone_codec);
					continue;
				}
				if (num == 8U || num == 10U)
				{
					this.guardIds_.AddEntriesFrom(ref input, DarkCoastInfoResponse._repeated_guardIds_codec);
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
				IL_3C:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040035BA RID: 13754
		private UnknownFieldSet _unknownFields;

		// Token: 0x040035BB RID: 13755
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x040035BC RID: 13756
		private ErrorCode errorCode_;

		// Token: 0x040035BD RID: 13757
		public const int DragonPoolConfFieldNumber = 3;

		// Token: 0x040035BE RID: 13758
		private DragonPoolConf dragonPoolConf_;

		// Token: 0x040035BF RID: 13759
		public const int GuardIdsFieldNumber = 1;

		// Token: 0x040035C0 RID: 13760
		private static readonly FieldCodec<int> _repeated_guardIds_codec = FieldCodec.ForInt32(10U);

		// Token: 0x040035C1 RID: 13761
		private readonly RepeatedField<int> guardIds_ = new RepeatedField<int>();

		// Token: 0x040035C2 RID: 13762
		public const int TreasureBoxDoneFieldNumber = 12;

		// Token: 0x040035C3 RID: 13763
		private static readonly FieldCodec<int> _repeated_treasureBoxDone_codec = FieldCodec.ForInt32(98U);

		// Token: 0x040035C4 RID: 13764
		private readonly RepeatedField<int> treasureBoxDone_ = new RepeatedField<int>();

		// Token: 0x040035C5 RID: 13765
		public const int LevelGainsFieldNumber = 13;

		// Token: 0x040035C6 RID: 13766
		private int levelGains_;
	}
}
