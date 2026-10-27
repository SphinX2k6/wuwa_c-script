using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000017 RID: 23
	public sealed class AbyssChallengePassPlayerInfo : IMessage<AbyssChallengePassPlayerInfo>, IMessage, IEquatable<AbyssChallengePassPlayerInfo>, IDeepCloneable<AbyssChallengePassPlayerInfo>, IBufferMessage
	{
		// Token: 0x06001034 RID: 4148 RVA: 0x0002D6C9 File Offset: 0x0002B8C9
		[NullableContext(1)]
		public static AbyssChallengePassPlayerInfo Create()
		{
			return new AbyssChallengePassPlayerInfo();
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06001035 RID: 4149 RVA: 0x0002D6D0 File Offset: 0x0002B8D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AbyssChallengePassPlayerInfo> Parser
		{
			get
			{
				return AbyssChallengePassPlayerInfo._parser;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06001036 RID: 4150 RVA: 0x0002D6D7 File Offset: 0x0002B8D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06001037 RID: 4151 RVA: 0x0002D6DA File Offset: 0x0002B8DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssChallengePassPlayerInfo.Descriptor;
			}
		}

		// Token: 0x06001038 RID: 4152 RVA: 0x0002D6E1 File Offset: 0x0002B8E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengePassPlayerInfo()
		{
		}

		// Token: 0x06001039 RID: 4153 RVA: 0x0002D700 File Offset: 0x0002B900
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengePassPlayerInfo(AbyssChallengePassPlayerInfo other) : this()
		{
			this.name_ = other.name_;
			this.playerId_ = other.playerId_;
			this.roleInfos_ = other.roleInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600103A RID: 4154 RVA: 0x0002D74D File Offset: 0x0002B94D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengePassPlayerInfo Clone()
		{
			return new AbyssChallengePassPlayerInfo(this);
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600103B RID: 4155 RVA: 0x0002D755 File Offset: 0x0002B955
		// (set) Token: 0x0600103C RID: 4156 RVA: 0x0002D75D File Offset: 0x0002B95D
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

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x0600103D RID: 4157 RVA: 0x0002D770 File Offset: 0x0002B970
		// (set) Token: 0x0600103E RID: 4158 RVA: 0x0002D778 File Offset: 0x0002B978
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

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600103F RID: 4159 RVA: 0x0002D781 File Offset: 0x0002B981
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AbyssPassRoleInfo> RoleInfos
		{
			get
			{
				return this.roleInfos_;
			}
		}

		// Token: 0x06001040 RID: 4160 RVA: 0x0002D789 File Offset: 0x0002B989
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssChallengePassPlayerInfo);
		}

		// Token: 0x06001041 RID: 4161 RVA: 0x0002D798 File Offset: 0x0002B998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssChallengePassPlayerInfo other)
		{
			return other != null && (other == this || (!(this.Name != other.Name) && this.PlayerId == other.PlayerId && this.roleInfos_.Equals(other.roleInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001042 RID: 4162 RVA: 0x0002D7FC File Offset: 0x0002B9FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Name.Length != 0)
			{
				num ^= this.Name.GetHashCode();
			}
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			num ^= this.roleInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001043 RID: 4163 RVA: 0x0002D864 File Offset: 0x0002BA64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001044 RID: 4164 RVA: 0x0002D871 File Offset: 0x0002BA71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001045 RID: 4165 RVA: 0x0002D87C File Offset: 0x0002BA7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Name);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.PlayerId);
			}
			this.roleInfos_.WriteTo(ref output, AbyssChallengePassPlayerInfo._repeated_roleInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001046 RID: 4166 RVA: 0x0002D8EC File Offset: 0x0002BAEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			num += this.roleInfos_.CalculateSize(AbyssChallengePassPlayerInfo._repeated_roleInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001047 RID: 4167 RVA: 0x0002D95C File Offset: 0x0002BB5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AbyssChallengePassPlayerInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Name.Length != 0)
			{
				this.Name = other.Name;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			this.roleInfos_.Add(other.roleInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001048 RID: 4168 RVA: 0x0002D9C2 File Offset: 0x0002BBC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001049 RID: 4169 RVA: 0x0002D9CC File Offset: 0x0002BBCC
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
				if (num != 10U)
				{
					if (num != 16U)
					{
						if (num != 34U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.roleInfos_.AddEntriesFrom(ref input, AbyssChallengePassPlayerInfo._repeated_roleInfos_codec);
						}
					}
					else
					{
						this.PlayerId = input.ReadInt32();
					}
				}
				else
				{
					this.Name = input.ReadString();
				}
			}
		}

		// Token: 0x04001EFD RID: 7933
		private static readonly MessageParser<AbyssChallengePassPlayerInfo> _parser = new MessageParser<AbyssChallengePassPlayerInfo>(() => new AbyssChallengePassPlayerInfo());

		// Token: 0x04001EFE RID: 7934
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001EFF RID: 7935
		public const int NameFieldNumber = 1;

		// Token: 0x04001F00 RID: 7936
		private string name_ = "";

		// Token: 0x04001F01 RID: 7937
		public const int PlayerIdFieldNumber = 2;

		// Token: 0x04001F02 RID: 7938
		private int playerId_;

		// Token: 0x04001F03 RID: 7939
		public const int RoleInfosFieldNumber = 4;

		// Token: 0x04001F04 RID: 7940
		private static readonly FieldCodec<AbyssPassRoleInfo> _repeated_roleInfos_codec = FieldCodec.ForMessage<AbyssPassRoleInfo>(34U, AbyssPassRoleInfo.Parser);

		// Token: 0x04001F05 RID: 7941
		private readonly RepeatedField<AbyssPassRoleInfo> roleInfos_ = new RepeatedField<AbyssPassRoleInfo>();
	}
}
