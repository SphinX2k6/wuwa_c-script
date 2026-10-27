using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D8E RID: 3470
	public sealed class PlayerFightRolesInfo : IMessage<PlayerFightRolesInfo>, IMessage, IEquatable<PlayerFightRolesInfo>, IDeepCloneable<PlayerFightRolesInfo>, IBufferMessage
	{
		// Token: 0x06012B69 RID: 76649 RVA: 0x002BB525 File Offset: 0x002B9725
		[NullableContext(1)]
		public static PlayerFightRolesInfo Create()
		{
			return new PlayerFightRolesInfo();
		}

		// Token: 0x17003E1D RID: 15901
		// (get) Token: 0x06012B6A RID: 76650 RVA: 0x002BB52C File Offset: 0x002B972C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PlayerFightRolesInfo> Parser
		{
			get
			{
				return PlayerFightRolesInfo._parser;
			}
		}

		// Token: 0x17003E1E RID: 15902
		// (get) Token: 0x06012B6B RID: 76651 RVA: 0x002BB533 File Offset: 0x002B9733
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003E1F RID: 15903
		// (get) Token: 0x06012B6C RID: 76652 RVA: 0x002BB536 File Offset: 0x002B9736
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerFightRolesInfo.Descriptor;
			}
		}

		// Token: 0x06012B6D RID: 76653 RVA: 0x002BB53D File Offset: 0x002B973D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerFightRolesInfo()
		{
		}

		// Token: 0x06012B6E RID: 76654 RVA: 0x002BB550 File Offset: 0x002B9750
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

		// Token: 0x06012B6F RID: 76655 RVA: 0x002BB5A9 File Offset: 0x002B97A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerFightRolesInfo Clone()
		{
			return new PlayerFightRolesInfo(this);
		}

		// Token: 0x17003E20 RID: 15904
		// (get) Token: 0x06012B70 RID: 76656 RVA: 0x002BB5B1 File Offset: 0x002B97B1
		// (set) Token: 0x06012B71 RID: 76657 RVA: 0x002BB5B9 File Offset: 0x002B97B9
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

		// Token: 0x17003E21 RID: 15905
		// (get) Token: 0x06012B72 RID: 76658 RVA: 0x002BB5C2 File Offset: 0x002B97C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FightRoleInformation> FightRolesInfo
		{
			get
			{
				return this.fightRolesInfo_;
			}
		}

		// Token: 0x17003E22 RID: 15906
		// (get) Token: 0x06012B73 RID: 76659 RVA: 0x002BB5CA File Offset: 0x002B97CA
		// (set) Token: 0x06012B74 RID: 76660 RVA: 0x002BB5D2 File Offset: 0x002B97D2
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

		// Token: 0x17003E23 RID: 15907
		// (get) Token: 0x06012B75 RID: 76661 RVA: 0x002BB5DB File Offset: 0x002B97DB
		// (set) Token: 0x06012B76 RID: 76662 RVA: 0x002BB5E3 File Offset: 0x002B97E3
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

		// Token: 0x06012B77 RID: 76663 RVA: 0x002BB5EC File Offset: 0x002B97EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerFightRolesInfo);
		}

		// Token: 0x06012B78 RID: 76664 RVA: 0x002BB5FC File Offset: 0x002B97FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerFightRolesInfo other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.fightRolesInfo_.Equals(other.fightRolesInfo_) && this.IsPhantom == other.IsPhantom && this.IsRetain == other.IsRetain && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012B79 RID: 76665 RVA: 0x002BB66C File Offset: 0x002B986C
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

		// Token: 0x06012B7A RID: 76666 RVA: 0x002BB6EB File Offset: 0x002B98EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012B7B RID: 76667 RVA: 0x002BB6F8 File Offset: 0x002B98F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012B7C RID: 76668 RVA: 0x002BB704 File Offset: 0x002B9904
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

		// Token: 0x06012B7D RID: 76669 RVA: 0x002BB78C File Offset: 0x002B998C
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

		// Token: 0x06012B7E RID: 76670 RVA: 0x002BB7F8 File Offset: 0x002B99F8
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

		// Token: 0x06012B7F RID: 76671 RVA: 0x002BB86D File Offset: 0x002B9A6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012B80 RID: 76672 RVA: 0x002BB878 File Offset: 0x002B9A78
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

		// Token: 0x0400741D RID: 29725
		private static readonly MessageParser<PlayerFightRolesInfo> _parser = new MessageParser<PlayerFightRolesInfo>(() => new PlayerFightRolesInfo());

		// Token: 0x0400741E RID: 29726
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400741F RID: 29727
		public const int PlayerIdFieldNumber = 1;

		// Token: 0x04007420 RID: 29728
		private int playerId_;

		// Token: 0x04007421 RID: 29729
		public const int FightRolesInfoFieldNumber = 2;

		// Token: 0x04007422 RID: 29730
		private static readonly FieldCodec<FightRoleInformation> _repeated_fightRolesInfo_codec = FieldCodec.ForMessage<FightRoleInformation>(18U, FightRoleInformation.Parser);

		// Token: 0x04007423 RID: 29731
		private readonly RepeatedField<FightRoleInformation> fightRolesInfo_ = new RepeatedField<FightRoleInformation>();

		// Token: 0x04007424 RID: 29732
		public const int IsPhantomFieldNumber = 3;

		// Token: 0x04007425 RID: 29733
		private bool isPhantom_;

		// Token: 0x04007426 RID: 29734
		public const int IsRetainFieldNumber = 4;

		// Token: 0x04007427 RID: 29735
		private bool isRetain_;
	}
}
