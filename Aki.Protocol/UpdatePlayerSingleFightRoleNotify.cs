using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200151A RID: 5402
	[NetMessage(EMessageId.UpdatePlayerSingleFightRoleNotify)]
	public sealed class UpdatePlayerSingleFightRoleNotify : IMessage<UpdatePlayerSingleFightRoleNotify>, IMessage, IEquatable<UpdatePlayerSingleFightRoleNotify>, IDeepCloneable<UpdatePlayerSingleFightRoleNotify>, IBufferMessage
	{
		// Token: 0x0601C9EA RID: 117226 RVA: 0x00425B51 File Offset: 0x00423D51
		[NullableContext(1)]
		public static UpdatePlayerSingleFightRoleNotify Create()
		{
			return new UpdatePlayerSingleFightRoleNotify();
		}

		// Token: 0x170060CE RID: 24782
		// (get) Token: 0x0601C9EB RID: 117227 RVA: 0x00425B58 File Offset: 0x00423D58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170060CF RID: 24783
		// (get) Token: 0x0601C9EC RID: 117228 RVA: 0x00425B5B File Offset: 0x00423D5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdatePlayerSingleFightRoleNotify.Descriptor;
			}
		}

		// Token: 0x0601C9ED RID: 117229 RVA: 0x00425B62 File Offset: 0x00423D62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdatePlayerSingleFightRoleNotify()
		{
		}

		// Token: 0x0601C9EE RID: 117230 RVA: 0x00425B6C File Offset: 0x00423D6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdatePlayerSingleFightRoleNotify(UpdatePlayerSingleFightRoleNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.fightRoleInfo_ = ((other.fightRoleInfo_ != null) ? other.fightRoleInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C9EF RID: 117231 RVA: 0x00425BB8 File Offset: 0x00423DB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdatePlayerSingleFightRoleNotify Clone()
		{
			return new UpdatePlayerSingleFightRoleNotify(this);
		}

		// Token: 0x170060D0 RID: 24784
		// (get) Token: 0x0601C9F0 RID: 117232 RVA: 0x00425BC0 File Offset: 0x00423DC0
		// (set) Token: 0x0601C9F1 RID: 117233 RVA: 0x00425BC8 File Offset: 0x00423DC8
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

		// Token: 0x170060D1 RID: 24785
		// (get) Token: 0x0601C9F2 RID: 117234 RVA: 0x00425BD1 File Offset: 0x00423DD1
		// (set) Token: 0x0601C9F3 RID: 117235 RVA: 0x00425BD9 File Offset: 0x00423DD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightRoleInformation FightRoleInfo
		{
			get
			{
				return this.fightRoleInfo_;
			}
			set
			{
				this.fightRoleInfo_ = value;
			}
		}

		// Token: 0x0601C9F4 RID: 117236 RVA: 0x00425BE2 File Offset: 0x00423DE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdatePlayerSingleFightRoleNotify);
		}

		// Token: 0x0601C9F5 RID: 117237 RVA: 0x00425BF0 File Offset: 0x00423DF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdatePlayerSingleFightRoleNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && object.Equals(this.FightRoleInfo, other.FightRoleInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C9F6 RID: 117238 RVA: 0x00425C40 File Offset: 0x00423E40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.fightRoleInfo_ != null)
			{
				num ^= this.FightRoleInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C9F7 RID: 117239 RVA: 0x00425C95 File Offset: 0x00423E95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C9F8 RID: 117240 RVA: 0x00425CA2 File Offset: 0x00423EA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C9F9 RID: 117241 RVA: 0x00425CAC File Offset: 0x00423EAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.fightRoleInfo_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.FightRoleInfo);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C9FA RID: 117242 RVA: 0x00425D08 File Offset: 0x00423F08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.fightRoleInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FightRoleInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C9FB RID: 117243 RVA: 0x00425D60 File Offset: 0x00423F60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UpdatePlayerSingleFightRoleNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.fightRoleInfo_ != null)
			{
				if (this.fightRoleInfo_ == null)
				{
					this.FightRoleInfo = new FightRoleInformation();
				}
				this.FightRoleInfo.MergeFrom(other.FightRoleInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C9FC RID: 117244 RVA: 0x00425DC8 File Offset: 0x00423FC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C9FD RID: 117245 RVA: 0x00425DD4 File Offset: 0x00423FD4
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
				if (num != 18U)
				{
					if (num != 40U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.PlayerId = input.ReadInt32();
					}
				}
				else
				{
					if (this.fightRoleInfo_ == null)
					{
						this.FightRoleInfo = new FightRoleInformation();
					}
					input.ReadMessage(this.FightRoleInfo);
				}
			}
		}

		// Token: 0x0400A4E8 RID: 42216
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A4E9 RID: 42217
		public const int PlayerIdFieldNumber = 5;

		// Token: 0x0400A4EA RID: 42218
		private int playerId_;

		// Token: 0x0400A4EB RID: 42219
		public const int FightRoleInfoFieldNumber = 2;

		// Token: 0x0400A4EC RID: 42220
		private FightRoleInformation fightRoleInfo_;
	}
}
