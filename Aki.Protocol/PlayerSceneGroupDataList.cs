using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DAD RID: 3501
	public sealed class PlayerSceneGroupDataList : IMessage<PlayerSceneGroupDataList>, IMessage, IEquatable<PlayerSceneGroupDataList>, IDeepCloneable<PlayerSceneGroupDataList>, IBufferMessage
	{
		// Token: 0x06012DCD RID: 77261 RVA: 0x002C058B File Offset: 0x002BE78B
		[NullableContext(1)]
		public static PlayerSceneGroupDataList Create()
		{
			return new PlayerSceneGroupDataList();
		}

		// Token: 0x17003E98 RID: 16024
		// (get) Token: 0x06012DCE RID: 77262 RVA: 0x002C0592 File Offset: 0x002BE792
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PlayerSceneGroupDataList> Parser
		{
			get
			{
				return PlayerSceneGroupDataList._parser;
			}
		}

		// Token: 0x17003E99 RID: 16025
		// (get) Token: 0x06012DCF RID: 77263 RVA: 0x002C0599 File Offset: 0x002BE799
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003E9A RID: 16026
		// (get) Token: 0x06012DD0 RID: 77264 RVA: 0x002C059C File Offset: 0x002BE79C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerSceneGroupDataList.Descriptor;
			}
		}

		// Token: 0x06012DD1 RID: 77265 RVA: 0x002C05A3 File Offset: 0x002BE7A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerSceneGroupDataList()
		{
		}

		// Token: 0x06012DD2 RID: 77266 RVA: 0x002C05B8 File Offset: 0x002BE7B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerSceneGroupDataList(PlayerSceneGroupDataList other) : this()
		{
			this.playerId_ = other.playerId_;
			this.playerSceneGroupData_ = other.playerSceneGroupData_.Clone();
			this.currentGroup_ = other.currentGroup_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012DD3 RID: 77267 RVA: 0x002C0605 File Offset: 0x002BE805
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerSceneGroupDataList Clone()
		{
			return new PlayerSceneGroupDataList(this);
		}

		// Token: 0x17003E9B RID: 16027
		// (get) Token: 0x06012DD4 RID: 77268 RVA: 0x002C060D File Offset: 0x002BE80D
		// (set) Token: 0x06012DD5 RID: 77269 RVA: 0x002C0615 File Offset: 0x002BE815
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

		// Token: 0x17003E9C RID: 16028
		// (get) Token: 0x06012DD6 RID: 77270 RVA: 0x002C061E File Offset: 0x002BE81E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PlayerSceneGroupData> PlayerSceneGroupData
		{
			get
			{
				return this.playerSceneGroupData_;
			}
		}

		// Token: 0x17003E9D RID: 16029
		// (get) Token: 0x06012DD7 RID: 77271 RVA: 0x002C0626 File Offset: 0x002BE826
		// (set) Token: 0x06012DD8 RID: 77272 RVA: 0x002C062E File Offset: 0x002BE82E
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

		// Token: 0x06012DD9 RID: 77273 RVA: 0x002C0637 File Offset: 0x002BE837
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerSceneGroupDataList);
		}

		// Token: 0x06012DDA RID: 77274 RVA: 0x002C0648 File Offset: 0x002BE848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerSceneGroupDataList other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.playerSceneGroupData_.Equals(other.playerSceneGroupData_) && this.CurrentGroup == other.CurrentGroup && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012DDB RID: 77275 RVA: 0x002C06A8 File Offset: 0x002BE8A8
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

		// Token: 0x06012DDC RID: 77276 RVA: 0x002C070E File Offset: 0x002BE90E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012DDD RID: 77277 RVA: 0x002C071B File Offset: 0x002BE91B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012DDE RID: 77278 RVA: 0x002C0724 File Offset: 0x002BE924
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

		// Token: 0x06012DDF RID: 77279 RVA: 0x002C0790 File Offset: 0x002BE990
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

		// Token: 0x06012DE0 RID: 77280 RVA: 0x002C07FC File Offset: 0x002BE9FC
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

		// Token: 0x06012DE1 RID: 77281 RVA: 0x002C085D File Offset: 0x002BEA5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012DE2 RID: 77282 RVA: 0x002C0868 File Offset: 0x002BEA68
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

		// Token: 0x040074C1 RID: 29889
		private static readonly MessageParser<PlayerSceneGroupDataList> _parser = new MessageParser<PlayerSceneGroupDataList>(() => new PlayerSceneGroupDataList());

		// Token: 0x040074C2 RID: 29890
		private UnknownFieldSet _unknownFields;

		// Token: 0x040074C3 RID: 29891
		public const int PlayerIdFieldNumber = 1;

		// Token: 0x040074C4 RID: 29892
		private int playerId_;

		// Token: 0x040074C5 RID: 29893
		public const int PlayerSceneGroupDataFieldNumber = 2;

		// Token: 0x040074C6 RID: 29894
		private static readonly FieldCodec<PlayerSceneGroupData> _repeated_playerSceneGroupData_codec = FieldCodec.ForMessage<PlayerSceneGroupData>(18U, Aki.Protocol.PlayerSceneGroupData.Parser);

		// Token: 0x040074C7 RID: 29895
		private readonly RepeatedField<PlayerSceneGroupData> playerSceneGroupData_ = new RepeatedField<PlayerSceneGroupData>();

		// Token: 0x040074C8 RID: 29896
		public const int CurrentGroupFieldNumber = 3;

		// Token: 0x040074C9 RID: 29897
		private int currentGroup_;
	}
}
