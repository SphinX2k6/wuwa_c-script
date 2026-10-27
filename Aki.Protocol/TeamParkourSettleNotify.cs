using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001330 RID: 4912
	[NetMessage(EMessageId.TeamParkourSettleNotify)]
	public sealed class TeamParkourSettleNotify : IMessage<TeamParkourSettleNotify>, IMessage, IEquatable<TeamParkourSettleNotify>, IDeepCloneable<TeamParkourSettleNotify>, IBufferMessage
	{
		// Token: 0x0601A193 RID: 106899 RVA: 0x003CA755 File Offset: 0x003C8955
		[NullableContext(1)]
		public static TeamParkourSettleNotify Create()
		{
			return new TeamParkourSettleNotify();
		}

		// Token: 0x17005805 RID: 22533
		// (get) Token: 0x0601A194 RID: 106900 RVA: 0x003CA75C File Offset: 0x003C895C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005806 RID: 22534
		// (get) Token: 0x0601A195 RID: 106901 RVA: 0x003CA75F File Offset: 0x003C895F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TeamParkourSettleNotify.Descriptor;
			}
		}

		// Token: 0x0601A196 RID: 106902 RVA: 0x003CA766 File Offset: 0x003C8966
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamParkourSettleNotify()
		{
		}

		// Token: 0x0601A197 RID: 106903 RVA: 0x003CA779 File Offset: 0x003C8979
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamParkourSettleNotify(TeamParkourSettleNotify other) : this()
		{
			this.levelId_ = other.levelId_;
			this.playerSettleInfos_ = other.playerSettleInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A198 RID: 106904 RVA: 0x003CA7AF File Offset: 0x003C89AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamParkourSettleNotify Clone()
		{
			return new TeamParkourSettleNotify(this);
		}

		// Token: 0x17005807 RID: 22535
		// (get) Token: 0x0601A199 RID: 106905 RVA: 0x003CA7B7 File Offset: 0x003C89B7
		// (set) Token: 0x0601A19A RID: 106906 RVA: 0x003CA7BF File Offset: 0x003C89BF
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

		// Token: 0x17005808 RID: 22536
		// (get) Token: 0x0601A19B RID: 106907 RVA: 0x003CA7C8 File Offset: 0x003C89C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PlayerSettleInfo> PlayerSettleInfos
		{
			get
			{
				return this.playerSettleInfos_;
			}
		}

		// Token: 0x0601A19C RID: 106908 RVA: 0x003CA7D0 File Offset: 0x003C89D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TeamParkourSettleNotify);
		}

		// Token: 0x0601A19D RID: 106909 RVA: 0x003CA7E0 File Offset: 0x003C89E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TeamParkourSettleNotify other)
		{
			return other != null && (other == this || (this.LevelId == other.LevelId && this.playerSettleInfos_.Equals(other.playerSettleInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A19E RID: 106910 RVA: 0x003CA830 File Offset: 0x003C8A30
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

		// Token: 0x0601A19F RID: 106911 RVA: 0x003CA87D File Offset: 0x003C8A7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A1A0 RID: 106912 RVA: 0x003CA88A File Offset: 0x003C8A8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A1A1 RID: 106913 RVA: 0x003CA894 File Offset: 0x003C8A94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.playerSettleInfos_.WriteTo(ref output, TeamParkourSettleNotify._repeated_playerSettleInfos_codec);
			if (this.LevelId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.LevelId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A1A2 RID: 106914 RVA: 0x003CA8E4 File Offset: 0x003C8AE4
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

		// Token: 0x0601A1A3 RID: 106915 RVA: 0x003CA938 File Offset: 0x003C8B38
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

		// Token: 0x0601A1A4 RID: 106916 RVA: 0x003CA985 File Offset: 0x003C8B85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A1A5 RID: 106917 RVA: 0x003CA990 File Offset: 0x003C8B90
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
				if (num != 58U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.LevelId = input.ReadInt32();
					}
				}
				else
				{
					this.playerSettleInfos_.AddEntriesFrom(ref input, TeamParkourSettleNotify._repeated_playerSettleInfos_codec);
				}
			}
		}

		// Token: 0x0400985A RID: 39002
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400985B RID: 39003
		public const int LevelIdFieldNumber = 13;

		// Token: 0x0400985C RID: 39004
		private int levelId_;

		// Token: 0x0400985D RID: 39005
		public const int PlayerSettleInfosFieldNumber = 7;

		// Token: 0x0400985E RID: 39006
		private static readonly FieldCodec<PlayerSettleInfo> _repeated_playerSettleInfos_codec = FieldCodec.ForMessage<PlayerSettleInfo>(58U, PlayerSettleInfo.Parser);

		// Token: 0x0400985F RID: 39007
		private readonly RepeatedField<PlayerSettleInfo> playerSettleInfos_ = new RepeatedField<PlayerSettleInfo>();
	}
}
