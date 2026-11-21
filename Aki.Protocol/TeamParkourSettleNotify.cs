using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200139D RID: 5021
	[NetMessage(EMessageId.TeamParkourSettleNotify)]
	public sealed class TeamParkourSettleNotify : IMessage<TeamParkourSettleNotify>, IMessage, IEquatable<TeamParkourSettleNotify>, IDeepCloneable<TeamParkourSettleNotify>, IBufferMessage
	{
		// Token: 0x0601ABA3 RID: 109475 RVA: 0x003E4A11 File Offset: 0x003E2C11
		[NullableContext(1)]
		public static TeamParkourSettleNotify Create()
		{
			return new TeamParkourSettleNotify();
		}

		// Token: 0x17005A7F RID: 23167
		// (get) Token: 0x0601ABA4 RID: 109476 RVA: 0x003E4A18 File Offset: 0x003E2C18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005A80 RID: 23168
		// (get) Token: 0x0601ABA5 RID: 109477 RVA: 0x003E4A1B File Offset: 0x003E2C1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TeamParkourSettleNotify.Descriptor;
			}
		}

		// Token: 0x0601ABA6 RID: 109478 RVA: 0x003E4A22 File Offset: 0x003E2C22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamParkourSettleNotify()
		{
		}

		// Token: 0x0601ABA7 RID: 109479 RVA: 0x003E4A35 File Offset: 0x003E2C35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamParkourSettleNotify(TeamParkourSettleNotify other) : this()
		{
			this.levelId_ = other.levelId_;
			this.playerSettleInfos_ = other.playerSettleInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601ABA8 RID: 109480 RVA: 0x003E4A6B File Offset: 0x003E2C6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamParkourSettleNotify Clone()
		{
			return new TeamParkourSettleNotify(this);
		}

		// Token: 0x17005A81 RID: 23169
		// (get) Token: 0x0601ABA9 RID: 109481 RVA: 0x003E4A73 File Offset: 0x003E2C73
		// (set) Token: 0x0601ABAA RID: 109482 RVA: 0x003E4A7B File Offset: 0x003E2C7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LevelId
		{
			get
			{
				return this.levelId_;
			}
			set
			{
				this.levelId_ = value;
			}
		}

		// Token: 0x17005A82 RID: 23170
		// (get) Token: 0x0601ABAB RID: 109483 RVA: 0x003E4A84 File Offset: 0x003E2C84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PlayerSettleInfo> PlayerSettleInfos
		{
			get
			{
				return this.playerSettleInfos_;
			}
		}

		// Token: 0x0601ABAC RID: 109484 RVA: 0x003E4A8C File Offset: 0x003E2C8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TeamParkourSettleNotify);
		}

		// Token: 0x0601ABAD RID: 109485 RVA: 0x003E4A9C File Offset: 0x003E2C9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TeamParkourSettleNotify other)
		{
			return other != null && (other == this || (this.LevelId == other.LevelId && this.playerSettleInfos_.Equals(other.playerSettleInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601ABAE RID: 109486 RVA: 0x003E4AEC File Offset: 0x003E2CEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LevelId != 0)
			{
				num ^= this.LevelId.GetHashCode();
			}
			num ^= this.playerSettleInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601ABAF RID: 109487 RVA: 0x003E4B39 File Offset: 0x003E2D39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601ABB0 RID: 109488 RVA: 0x003E4B46 File Offset: 0x003E2D46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601ABB1 RID: 109489 RVA: 0x003E4B50 File Offset: 0x003E2D50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.LevelId);
			}
			this.playerSettleInfos_.WriteTo(ref output, TeamParkourSettleNotify._repeated_playerSettleInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601ABB2 RID: 109490 RVA: 0x003E4BA0 File Offset: 0x003E2DA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LevelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelId);
			}
			num += this.playerSettleInfos_.CalculateSize(TeamParkourSettleNotify._repeated_playerSettleInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601ABB3 RID: 109491 RVA: 0x003E4BF4 File Offset: 0x003E2DF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TeamParkourSettleNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LevelId != 0)
			{
				this.LevelId = other.LevelId;
			}
			this.playerSettleInfos_.Add(other.playerSettleInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601ABB4 RID: 109492 RVA: 0x003E4C41 File Offset: 0x003E2E41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601ABB5 RID: 109493 RVA: 0x003E4C4C File Offset: 0x003E2E4C
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
				if (num != 88U)
				{
					if (num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.playerSettleInfos_.AddEntriesFrom(ref input, TeamParkourSettleNotify._repeated_playerSettleInfos_codec);
					}
				}
				else
				{
					this.LevelId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009C7C RID: 40060
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009C7D RID: 40061
		public const int LevelIdFieldNumber = 11;

		// Token: 0x04009C7E RID: 40062
		private int levelId_;

		// Token: 0x04009C7F RID: 40063
		public const int PlayerSettleInfosFieldNumber = 13;

		// Token: 0x04009C80 RID: 40064
		private static readonly FieldCodec<PlayerSettleInfo> _repeated_playerSettleInfos_codec = FieldCodec.ForMessage<PlayerSettleInfo>(106U, PlayerSettleInfo.Parser);

		// Token: 0x04009C81 RID: 40065
		private readonly RepeatedField<PlayerSettleInfo> playerSettleInfos_ = new RepeatedField<PlayerSettleInfo>();
	}
}
