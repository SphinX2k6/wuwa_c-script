using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002AC RID: 684
	[NetMessage(EMessageId.ClientVersionNoMatchNotify)]
	public sealed class ClientVersionNoMatchNotify : IMessage<ClientVersionNoMatchNotify>, IMessage, IEquatable<ClientVersionNoMatchNotify>, IDeepCloneable<ClientVersionNoMatchNotify>, IBufferMessage
	{
		// Token: 0x060046DD RID: 18141 RVA: 0x000AE122 File Offset: 0x000AC322
		[NullableContext(1)]
		public static ClientVersionNoMatchNotify Create()
		{
			return new ClientVersionNoMatchNotify();
		}

		// Token: 0x17000C4C RID: 3148
		// (get) Token: 0x060046DE RID: 18142 RVA: 0x000AE129 File Offset: 0x000AC329
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000C4D RID: 3149
		// (get) Token: 0x060046DF RID: 18143 RVA: 0x000AE12C File Offset: 0x000AC32C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClientVersionNoMatchNotify.Descriptor;
			}
		}

		// Token: 0x060046E0 RID: 18144 RVA: 0x000AE133 File Offset: 0x000AC333
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientVersionNoMatchNotify()
		{
		}

		// Token: 0x060046E1 RID: 18145 RVA: 0x000AE13B File Offset: 0x000AC33B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientVersionNoMatchNotify(ClientVersionNoMatchNotify other) : this()
		{
			this.teamType_ = other.teamType_;
			this.playerId_ = other.playerId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060046E2 RID: 18146 RVA: 0x000AE16C File Offset: 0x000AC36C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientVersionNoMatchNotify Clone()
		{
			return new ClientVersionNoMatchNotify(this);
		}

		// Token: 0x17000C4E RID: 3150
		// (get) Token: 0x060046E3 RID: 18147 RVA: 0x000AE174 File Offset: 0x000AC374
		// (set) Token: 0x060046E4 RID: 18148 RVA: 0x000AE17C File Offset: 0x000AC37C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamType TeamType
		{
			get
			{
				return this.teamType_;
			}
			set
			{
				this.teamType_ = value;
			}
		}

		// Token: 0x17000C4F RID: 3151
		// (get) Token: 0x060046E5 RID: 18149 RVA: 0x000AE185 File Offset: 0x000AC385
		// (set) Token: 0x060046E6 RID: 18150 RVA: 0x000AE18D File Offset: 0x000AC38D
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

		// Token: 0x060046E7 RID: 18151 RVA: 0x000AE196 File Offset: 0x000AC396
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClientVersionNoMatchNotify);
		}

		// Token: 0x060046E8 RID: 18152 RVA: 0x000AE1A4 File Offset: 0x000AC3A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ClientVersionNoMatchNotify other)
		{
			return other != null && (other == this || (this.TeamType == other.TeamType && this.PlayerId == other.PlayerId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060046E9 RID: 18153 RVA: 0x000AE1E4 File Offset: 0x000AC3E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TeamType != TeamType.WorldTeam)
			{
				num ^= this.TeamType.GetHashCode();
			}
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060046EA RID: 18154 RVA: 0x000AE242 File Offset: 0x000AC442
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060046EB RID: 18155 RVA: 0x000AE24F File Offset: 0x000AC44F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060046EC RID: 18156 RVA: 0x000AE258 File Offset: 0x000AC458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.PlayerId);
			}
			if (this.TeamType != TeamType.WorldTeam)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.TeamType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060046ED RID: 18157 RVA: 0x000AE2B4 File Offset: 0x000AC4B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TeamType != TeamType.WorldTeam)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.TeamType);
			}
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060046EE RID: 18158 RVA: 0x000AE30C File Offset: 0x000AC50C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ClientVersionNoMatchNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TeamType != TeamType.WorldTeam)
			{
				this.TeamType = other.TeamType;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060046EF RID: 18159 RVA: 0x000AE35C File Offset: 0x000AC55C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060046F0 RID: 18160 RVA: 0x000AE368 File Offset: 0x000AC568
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
				if (num != 104U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.TeamType = (TeamType)input.ReadEnum();
					}
				}
				else
				{
					this.PlayerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002F6D RID: 12141
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002F6E RID: 12142
		public const int TeamTypeFieldNumber = 15;

		// Token: 0x04002F6F RID: 12143
		private TeamType teamType_;

		// Token: 0x04002F70 RID: 12144
		public const int PlayerIdFieldNumber = 13;

		// Token: 0x04002F71 RID: 12145
		private int playerId_;
	}
}
