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
		// Token: 0x0600105F RID: 4191 RVA: 0x0002DC7D File Offset: 0x0002BE7D
		[NullableContext(1)]
		public static AbyssChallengePassPlayerInfo Create()
		{
			return new AbyssChallengePassPlayerInfo();
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06001060 RID: 4192 RVA: 0x0002DC84 File Offset: 0x0002BE84
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
		// (get) Token: 0x06001061 RID: 4193 RVA: 0x0002DC8B File Offset: 0x0002BE8B
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
		// (get) Token: 0x06001062 RID: 4194 RVA: 0x0002DC8E File Offset: 0x0002BE8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssChallengePassPlayerInfo.Descriptor;
			}
		}

		// Token: 0x06001063 RID: 4195 RVA: 0x0002DC95 File Offset: 0x0002BE95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengePassPlayerInfo()
		{
		}

		// Token: 0x06001064 RID: 4196 RVA: 0x0002DCB4 File Offset: 0x0002BEB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengePassPlayerInfo(AbyssChallengePassPlayerInfo other) : this()
		{
			this.name_ = other.name_;
			this.playerId_ = other.playerId_;
			this.roleInfos_ = other.roleInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001065 RID: 4197 RVA: 0x0002DD01 File Offset: 0x0002BF01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengePassPlayerInfo Clone()
		{
			return new AbyssChallengePassPlayerInfo(this);
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06001066 RID: 4198 RVA: 0x0002DD09 File Offset: 0x0002BF09
		// (set) Token: 0x06001067 RID: 4199 RVA: 0x0002DD11 File Offset: 0x0002BF11
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
		// (get) Token: 0x06001068 RID: 4200 RVA: 0x0002DD24 File Offset: 0x0002BF24
		// (set) Token: 0x06001069 RID: 4201 RVA: 0x0002DD2C File Offset: 0x0002BF2C
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
		// (get) Token: 0x0600106A RID: 4202 RVA: 0x0002DD35 File Offset: 0x0002BF35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AbyssPassRoleInfo> RoleInfos
		{
			get
			{
				return this.roleInfos_;
			}
		}

		// Token: 0x0600106B RID: 4203 RVA: 0x0002DD3D File Offset: 0x0002BF3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssChallengePassPlayerInfo);
		}

		// Token: 0x0600106C RID: 4204 RVA: 0x0002DD4C File Offset: 0x0002BF4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssChallengePassPlayerInfo other)
		{
			return other != null && (other == this || (!(this.Name != other.Name) && this.PlayerId == other.PlayerId && this.roleInfos_.Equals(other.roleInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600106D RID: 4205 RVA: 0x0002DDB0 File Offset: 0x0002BFB0
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

		// Token: 0x0600106E RID: 4206 RVA: 0x0002DE18 File Offset: 0x0002C018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600106F RID: 4207 RVA: 0x0002DE25 File Offset: 0x0002C025
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001070 RID: 4208 RVA: 0x0002DE30 File Offset: 0x0002C030
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

		// Token: 0x06001071 RID: 4209 RVA: 0x0002DEA0 File Offset: 0x0002C0A0
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

		// Token: 0x06001072 RID: 4210 RVA: 0x0002DF10 File Offset: 0x0002C110
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

		// Token: 0x06001073 RID: 4211 RVA: 0x0002DF76 File Offset: 0x0002C176
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001074 RID: 4212 RVA: 0x0002DF80 File Offset: 0x0002C180
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

		// Token: 0x04001F53 RID: 8019
		private static readonly MessageParser<AbyssChallengePassPlayerInfo> _parser = new MessageParser<AbyssChallengePassPlayerInfo>(() => new AbyssChallengePassPlayerInfo());

		// Token: 0x04001F54 RID: 8020
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F55 RID: 8021
		public const int NameFieldNumber = 1;

		// Token: 0x04001F56 RID: 8022
		private string name_ = "";

		// Token: 0x04001F57 RID: 8023
		public const int PlayerIdFieldNumber = 2;

		// Token: 0x04001F58 RID: 8024
		private int playerId_;

		// Token: 0x04001F59 RID: 8025
		public const int RoleInfosFieldNumber = 4;

		// Token: 0x04001F5A RID: 8026
		private static readonly FieldCodec<AbyssPassRoleInfo> _repeated_roleInfos_codec = FieldCodec.ForMessage<AbyssPassRoleInfo>(34U, AbyssPassRoleInfo.Parser);

		// Token: 0x04001F5B RID: 8027
		private readonly RepeatedField<AbyssPassRoleInfo> roleInfos_ = new RepeatedField<AbyssPassRoleInfo>();
	}
}
