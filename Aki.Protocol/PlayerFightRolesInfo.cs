using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D7E RID: 3454
	public sealed class PlayerFightRolesInfo : IMessage<PlayerFightRolesInfo>, IMessage, IEquatable<PlayerFightRolesInfo>, IDeepCloneable<PlayerFightRolesInfo>, IBufferMessage
	{
		// Token: 0x06012A6D RID: 76397 RVA: 0x002B9901 File Offset: 0x002B7B01
		[NullableContext(1)]
		public static PlayerFightRolesInfo Create()
		{
			return new PlayerFightRolesInfo();
		}

		// Token: 0x17003DE8 RID: 15848
		// (get) Token: 0x06012A6E RID: 76398 RVA: 0x002B9908 File Offset: 0x002B7B08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PlayerFightRolesInfo> Parser
		{
			get
			{
				return PlayerFightRolesInfo._parser;
			}
		}

		// Token: 0x17003DE9 RID: 15849
		// (get) Token: 0x06012A6F RID: 76399 RVA: 0x002B990F File Offset: 0x002B7B0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003DEA RID: 15850
		// (get) Token: 0x06012A70 RID: 76400 RVA: 0x002B9912 File Offset: 0x002B7B12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerFightRolesInfo.Descriptor;
			}
		}

		// Token: 0x06012A71 RID: 76401 RVA: 0x002B9919 File Offset: 0x002B7B19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerFightRolesInfo()
		{
		}

		// Token: 0x06012A72 RID: 76402 RVA: 0x002B992C File Offset: 0x002B7B2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerFightRolesInfo(PlayerFightRolesInfo other) : this()
		{
			this.playerId_ = other.playerId_;
			this.fightRolesInfo_ = other.fightRolesInfo_.Clone();
			this.isPhantom_ = other.isPhantom_;
			this.isRetain_ = other.isRetain_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012A73 RID: 76403 RVA: 0x002B9985 File Offset: 0x002B7B85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerFightRolesInfo Clone()
		{
			return new PlayerFightRolesInfo(this);
		}

		// Token: 0x17003DEB RID: 15851
		// (get) Token: 0x06012A74 RID: 76404 RVA: 0x002B998D File Offset: 0x002B7B8D
		// (set) Token: 0x06012A75 RID: 76405 RVA: 0x002B9995 File Offset: 0x002B7B95
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

		// Token: 0x17003DEC RID: 15852
		// (get) Token: 0x06012A76 RID: 76406 RVA: 0x002B999E File Offset: 0x002B7B9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FightRoleInformation> FightRolesInfo
		{
			get
			{
				return this.fightRolesInfo_;
			}
		}

		// Token: 0x17003DED RID: 15853
		// (get) Token: 0x06012A77 RID: 76407 RVA: 0x002B99A6 File Offset: 0x002B7BA6
		// (set) Token: 0x06012A78 RID: 76408 RVA: 0x002B99AE File Offset: 0x002B7BAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsPhantom
		{
			get
			{
				return this.isPhantom_;
			}
			set
			{
				this.isPhantom_ = value;
			}
		}

		// Token: 0x17003DEE RID: 15854
		// (get) Token: 0x06012A79 RID: 76409 RVA: 0x002B99B7 File Offset: 0x002B7BB7
		// (set) Token: 0x06012A7A RID: 76410 RVA: 0x002B99BF File Offset: 0x002B7BBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsRetain
		{
			get
			{
				return this.isRetain_;
			}
			set
			{
				this.isRetain_ = value;
			}
		}

		// Token: 0x06012A7B RID: 76411 RVA: 0x002B99C8 File Offset: 0x002B7BC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerFightRolesInfo);
		}

		// Token: 0x06012A7C RID: 76412 RVA: 0x002B99D8 File Offset: 0x002B7BD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerFightRolesInfo other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.fightRolesInfo_.Equals(other.fightRolesInfo_) && this.IsPhantom == other.IsPhantom && this.IsRetain == other.IsRetain && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012A7D RID: 76413 RVA: 0x002B9A48 File Offset: 0x002B7C48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			num ^= this.fightRolesInfo_.GetHashCode();
			if (this.IsPhantom)
			{
				num ^= this.IsPhantom.GetHashCode();
			}
			if (this.IsRetain)
			{
				num ^= this.IsRetain.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012A7E RID: 76414 RVA: 0x002B9AC7 File Offset: 0x002B7CC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012A7F RID: 76415 RVA: 0x002B9AD4 File Offset: 0x002B7CD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012A80 RID: 76416 RVA: 0x002B9AE0 File Offset: 0x002B7CE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PlayerId);
			}
			this.fightRolesInfo_.WriteTo(ref output, PlayerFightRolesInfo._repeated_fightRolesInfo_codec);
			if (this.IsPhantom)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsPhantom);
			}
			if (this.IsRetain)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsRetain);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012A81 RID: 76417 RVA: 0x002B9B68 File Offset: 0x002B7D68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			num += this.fightRolesInfo_.CalculateSize(PlayerFightRolesInfo._repeated_fightRolesInfo_codec);
			if (this.IsPhantom)
			{
				num += 2;
			}
			if (this.IsRetain)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012A82 RID: 76418 RVA: 0x002B9BD4 File Offset: 0x002B7DD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerFightRolesInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			this.fightRolesInfo_.Add(other.fightRolesInfo_);
			if (other.IsPhantom)
			{
				this.IsPhantom = other.IsPhantom;
			}
			if (other.IsRetain)
			{
				this.IsRetain = other.IsRetain;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012A83 RID: 76419 RVA: 0x002B9C49 File Offset: 0x002B7E49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012A84 RID: 76420 RVA: 0x002B9C54 File Offset: 0x002B7E54
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
					if (num == 8U)
					{
						this.PlayerId = input.ReadInt32();
						continue;
					}
					if (num == 18U)
					{
						this.fightRolesInfo_.AddEntriesFrom(ref input, PlayerFightRolesInfo._repeated_fightRolesInfo_codec);
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.IsPhantom = input.ReadBool();
						continue;
					}
					if (num == 32U)
					{
						this.IsRetain = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007435 RID: 29749
		private static readonly MessageParser<PlayerFightRolesInfo> _parser = new MessageParser<PlayerFightRolesInfo>(() => new PlayerFightRolesInfo());

		// Token: 0x04007436 RID: 29750
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007437 RID: 29751
		public const int PlayerIdFieldNumber = 1;

		// Token: 0x04007438 RID: 29752
		private int playerId_;

		// Token: 0x04007439 RID: 29753
		public const int FightRolesInfoFieldNumber = 2;

		// Token: 0x0400743A RID: 29754
		private static readonly FieldCodec<FightRoleInformation> _repeated_fightRolesInfo_codec = FieldCodec.ForMessage<FightRoleInformation>(18U, FightRoleInformation.Parser);

		// Token: 0x0400743B RID: 29755
		private readonly RepeatedField<FightRoleInformation> fightRolesInfo_ = new RepeatedField<FightRoleInformation>();

		// Token: 0x0400743C RID: 29756
		public const int IsPhantomFieldNumber = 3;

		// Token: 0x0400743D RID: 29757
		private bool isPhantom_;

		// Token: 0x0400743E RID: 29758
		public const int IsRetainFieldNumber = 4;

		// Token: 0x0400743F RID: 29759
		private bool isRetain_;
	}
}
