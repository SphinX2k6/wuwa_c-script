using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D9D RID: 3485
	public sealed class PlayerSceneGroupDataList : IMessage<PlayerSceneGroupDataList>, IMessage, IEquatable<PlayerSceneGroupDataList>, IDeepCloneable<PlayerSceneGroupDataList>, IBufferMessage
	{
		// Token: 0x06012CD1 RID: 77009 RVA: 0x002BE967 File Offset: 0x002BCB67
		[NullableContext(1)]
		public static PlayerSceneGroupDataList Create()
		{
			return new PlayerSceneGroupDataList();
		}

		// Token: 0x17003E63 RID: 15971
		// (get) Token: 0x06012CD2 RID: 77010 RVA: 0x002BE96E File Offset: 0x002BCB6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PlayerSceneGroupDataList> Parser
		{
			get
			{
				return PlayerSceneGroupDataList._parser;
			}
		}

		// Token: 0x17003E64 RID: 15972
		// (get) Token: 0x06012CD3 RID: 77011 RVA: 0x002BE975 File Offset: 0x002BCB75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003E65 RID: 15973
		// (get) Token: 0x06012CD4 RID: 77012 RVA: 0x002BE978 File Offset: 0x002BCB78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerSceneGroupDataList.Descriptor;
			}
		}

		// Token: 0x06012CD5 RID: 77013 RVA: 0x002BE97F File Offset: 0x002BCB7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerSceneGroupDataList()
		{
		}

		// Token: 0x06012CD6 RID: 77014 RVA: 0x002BE994 File Offset: 0x002BCB94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerSceneGroupDataList(PlayerSceneGroupDataList other) : this()
		{
			this.playerId_ = other.playerId_;
			this.playerSceneGroupData_ = other.playerSceneGroupData_.Clone();
			this.currentGroup_ = other.currentGroup_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012CD7 RID: 77015 RVA: 0x002BE9E1 File Offset: 0x002BCBE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerSceneGroupDataList Clone()
		{
			return new PlayerSceneGroupDataList(this);
		}

		// Token: 0x17003E66 RID: 15974
		// (get) Token: 0x06012CD8 RID: 77016 RVA: 0x002BE9E9 File Offset: 0x002BCBE9
		// (set) Token: 0x06012CD9 RID: 77017 RVA: 0x002BE9F1 File Offset: 0x002BCBF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x17003E67 RID: 15975
		// (get) Token: 0x06012CDA RID: 77018 RVA: 0x002BE9FA File Offset: 0x002BCBFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PlayerSceneGroupData> PlayerSceneGroupData
		{
			get
			{
				return this.playerSceneGroupData_;
			}
		}

		// Token: 0x17003E68 RID: 15976
		// (get) Token: 0x06012CDB RID: 77019 RVA: 0x002BEA02 File Offset: 0x002BCC02
		// (set) Token: 0x06012CDC RID: 77020 RVA: 0x002BEA0A File Offset: 0x002BCC0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurrentGroup
		{
			get
			{
				return this.currentGroup_;
			}
			set
			{
				this.currentGroup_ = value;
			}
		}

		// Token: 0x06012CDD RID: 77021 RVA: 0x002BEA13 File Offset: 0x002BCC13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerSceneGroupDataList);
		}

		// Token: 0x06012CDE RID: 77022 RVA: 0x002BEA24 File Offset: 0x002BCC24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerSceneGroupDataList other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.playerSceneGroupData_.Equals(other.playerSceneGroupData_) && this.CurrentGroup == other.CurrentGroup && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012CDF RID: 77023 RVA: 0x002BEA84 File Offset: 0x002BCC84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			num ^= this.playerSceneGroupData_.GetHashCode();
			if (this.CurrentGroup != 0)
			{
				num ^= this.CurrentGroup.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012CE0 RID: 77024 RVA: 0x002BEAEA File Offset: 0x002BCCEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012CE1 RID: 77025 RVA: 0x002BEAF7 File Offset: 0x002BCCF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012CE2 RID: 77026 RVA: 0x002BEB00 File Offset: 0x002BCD00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PlayerId);
			}
			this.playerSceneGroupData_.WriteTo(ref output, PlayerSceneGroupDataList._repeated_playerSceneGroupData_codec);
			if (this.CurrentGroup != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.CurrentGroup);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012CE3 RID: 77027 RVA: 0x002BEB6C File Offset: 0x002BCD6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			num += this.playerSceneGroupData_.CalculateSize(PlayerSceneGroupDataList._repeated_playerSceneGroupData_codec);
			if (this.CurrentGroup != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurrentGroup);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012CE4 RID: 77028 RVA: 0x002BEBD8 File Offset: 0x002BCDD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerSceneGroupDataList other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			this.playerSceneGroupData_.Add(other.playerSceneGroupData_);
			if (other.CurrentGroup != 0)
			{
				this.CurrentGroup = other.CurrentGroup;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012CE5 RID: 77029 RVA: 0x002BEC39 File Offset: 0x002BCE39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012CE6 RID: 77030 RVA: 0x002BEC44 File Offset: 0x002BCE44
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
					if (num != 18U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.CurrentGroup = input.ReadInt32();
						}
					}
					else
					{
						this.playerSceneGroupData_.AddEntriesFrom(ref input, PlayerSceneGroupDataList._repeated_playerSceneGroupData_codec);
					}
				}
				else
				{
					this.PlayerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040074D9 RID: 29913
		private static readonly MessageParser<PlayerSceneGroupDataList> _parser = new MessageParser<PlayerSceneGroupDataList>(() => new PlayerSceneGroupDataList());

		// Token: 0x040074DA RID: 29914
		private UnknownFieldSet _unknownFields;

		// Token: 0x040074DB RID: 29915
		public const int PlayerIdFieldNumber = 1;

		// Token: 0x040074DC RID: 29916
		private int playerId_;

		// Token: 0x040074DD RID: 29917
		public const int PlayerSceneGroupDataFieldNumber = 2;

		// Token: 0x040074DE RID: 29918
		private static readonly FieldCodec<PlayerSceneGroupData> _repeated_playerSceneGroupData_codec = FieldCodec.ForMessage<PlayerSceneGroupData>(18U, Aki.Protocol.PlayerSceneGroupData.Parser);

		// Token: 0x040074DF RID: 29919
		private readonly RepeatedField<PlayerSceneGroupData> playerSceneGroupData_ = new RepeatedField<PlayerSceneGroupData>();

		// Token: 0x040074E0 RID: 29920
		public const int CurrentGroupFieldNumber = 3;

		// Token: 0x040074E1 RID: 29921
		private int currentGroup_;
	}
}
