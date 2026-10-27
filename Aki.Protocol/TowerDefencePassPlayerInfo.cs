using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013A5 RID: 5029
	public sealed class TowerDefencePassPlayerInfo : IMessage<TowerDefencePassPlayerInfo>, IMessage, IEquatable<TowerDefencePassPlayerInfo>, IDeepCloneable<TowerDefencePassPlayerInfo>, IBufferMessage
	{
		// Token: 0x0601AAF0 RID: 109296 RVA: 0x003DEC79 File Offset: 0x003DCE79
		[NullableContext(1)]
		public static TowerDefencePassPlayerInfo Create()
		{
			return new TowerDefencePassPlayerInfo();
		}

		// Token: 0x170059FA RID: 23034
		// (get) Token: 0x0601AAF1 RID: 109297 RVA: 0x003DEC80 File Offset: 0x003DCE80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TowerDefencePassPlayerInfo> Parser
		{
			get
			{
				return TowerDefencePassPlayerInfo._parser;
			}
		}

		// Token: 0x170059FB RID: 23035
		// (get) Token: 0x0601AAF2 RID: 109298 RVA: 0x003DEC87 File Offset: 0x003DCE87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170059FC RID: 23036
		// (get) Token: 0x0601AAF3 RID: 109299 RVA: 0x003DEC8A File Offset: 0x003DCE8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerDefencePassPlayerInfo.Descriptor;
			}
		}

		// Token: 0x0601AAF4 RID: 109300 RVA: 0x003DEC91 File Offset: 0x003DCE91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefencePassPlayerInfo()
		{
		}

		// Token: 0x0601AAF5 RID: 109301 RVA: 0x003DECB0 File Offset: 0x003DCEB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefencePassPlayerInfo(TowerDefencePassPlayerInfo other) : this()
		{
			this.roleList_ = other.roleList_.Clone();
			this.name_ = other.name_;
			this.playerId_ = other.playerId_;
			this.headId_ = other.headId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AAF6 RID: 109302 RVA: 0x003DED09 File Offset: 0x003DCF09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefencePassPlayerInfo Clone()
		{
			return new TowerDefencePassPlayerInfo(this);
		}

		// Token: 0x170059FD RID: 23037
		// (get) Token: 0x0601AAF7 RID: 109303 RVA: 0x003DED11 File Offset: 0x003DCF11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TowerDefenceRolePassInfo> RoleList
		{
			get
			{
				return this.roleList_;
			}
		}

		// Token: 0x170059FE RID: 23038
		// (get) Token: 0x0601AAF8 RID: 109304 RVA: 0x003DED19 File Offset: 0x003DCF19
		// (set) Token: 0x0601AAF9 RID: 109305 RVA: 0x003DED21 File Offset: 0x003DCF21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name
		{
			get
			{
				return this.name_;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170059FF RID: 23039
		// (get) Token: 0x0601AAFA RID: 109306 RVA: 0x003DED34 File Offset: 0x003DCF34
		// (set) Token: 0x0601AAFB RID: 109307 RVA: 0x003DED3C File Offset: 0x003DCF3C
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

		// Token: 0x17005A00 RID: 23040
		// (get) Token: 0x0601AAFC RID: 109308 RVA: 0x003DED45 File Offset: 0x003DCF45
		// (set) Token: 0x0601AAFD RID: 109309 RVA: 0x003DED4D File Offset: 0x003DCF4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HeadId
		{
			get
			{
				return this.headId_;
			}
			set
			{
				this.headId_ = value;
			}
		}

		// Token: 0x0601AAFE RID: 109310 RVA: 0x003DED56 File Offset: 0x003DCF56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerDefencePassPlayerInfo);
		}

		// Token: 0x0601AAFF RID: 109311 RVA: 0x003DED64 File Offset: 0x003DCF64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerDefencePassPlayerInfo other)
		{
			return other != null && (other == this || (this.roleList_.Equals(other.roleList_) && !(this.Name != other.Name) && this.PlayerId == other.PlayerId && this.HeadId == other.HeadId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AB00 RID: 109312 RVA: 0x003DEDD8 File Offset: 0x003DCFD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.roleList_.GetHashCode();
			if (this.Name.Length != 0)
			{
				num ^= this.Name.GetHashCode();
			}
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.HeadId != 0)
			{
				num ^= this.HeadId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601AB01 RID: 109313 RVA: 0x003DEE59 File Offset: 0x003DD059
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AB02 RID: 109314 RVA: 0x003DEE66 File Offset: 0x003DD066
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AB03 RID: 109315 RVA: 0x003DEE70 File Offset: 0x003DD070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.roleList_.WriteTo(ref output, TowerDefencePassPlayerInfo._repeated_roleList_codec);
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Name);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.PlayerId);
			}
			if (this.HeadId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.HeadId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AB04 RID: 109316 RVA: 0x003DEEFC File Offset: 0x003DD0FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.roleList_.CalculateSize(TowerDefencePassPlayerInfo._repeated_roleList_codec);
			if (this.Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.HeadId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HeadId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601AB05 RID: 109317 RVA: 0x003DEF84 File Offset: 0x003DD184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerDefencePassPlayerInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.roleList_.Add(other.roleList_);
			if (other.Name.Length != 0)
			{
				this.Name = other.Name;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.HeadId != 0)
			{
				this.HeadId = other.HeadId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601AB06 RID: 109318 RVA: 0x003DEFFE File Offset: 0x003DD1FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AB07 RID: 109319 RVA: 0x003DF008 File Offset: 0x003DD208
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
				if (num <= 18U)
				{
					if (num == 10U)
					{
						this.roleList_.AddEntriesFrom(ref input, TowerDefencePassPlayerInfo._repeated_roleList_codec);
						continue;
					}
					if (num == 18U)
					{
						this.Name = input.ReadString();
						continue;
					}
				}
				else
				{
					if (num == 32U)
					{
						this.PlayerId = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.HeadId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009AFF RID: 39679
		private static readonly MessageParser<TowerDefencePassPlayerInfo> _parser = new MessageParser<TowerDefencePassPlayerInfo>(() => new TowerDefencePassPlayerInfo());

		// Token: 0x04009B00 RID: 39680
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009B01 RID: 39681
		public const int RoleListFieldNumber = 1;

		// Token: 0x04009B02 RID: 39682
		private static readonly FieldCodec<TowerDefenceRolePassInfo> _repeated_roleList_codec = FieldCodec.ForMessage<TowerDefenceRolePassInfo>(10U, TowerDefenceRolePassInfo.Parser);

		// Token: 0x04009B03 RID: 39683
		private readonly RepeatedField<TowerDefenceRolePassInfo> roleList_ = new RepeatedField<TowerDefenceRolePassInfo>();

		// Token: 0x04009B04 RID: 39684
		public const int NameFieldNumber = 2;

		// Token: 0x04009B05 RID: 39685
		private string name_ = "";

		// Token: 0x04009B06 RID: 39686
		public const int PlayerIdFieldNumber = 4;

		// Token: 0x04009B07 RID: 39687
		private int playerId_;

		// Token: 0x04009B08 RID: 39688
		public const int HeadIdFieldNumber = 5;

		// Token: 0x04009B09 RID: 39689
		private int headId_;
	}
}
