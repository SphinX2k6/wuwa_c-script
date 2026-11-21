using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002B2 RID: 690
	[NetMessage(EMessageId.ClientVersionNoMatchNotify)]
	public sealed class ClientVersionNoMatchNotify : IMessage<ClientVersionNoMatchNotify>, IMessage, IEquatable<ClientVersionNoMatchNotify>, IDeepCloneable<ClientVersionNoMatchNotify>, IBufferMessage
	{
		// Token: 0x060047A4 RID: 18340 RVA: 0x000B0332 File Offset: 0x000AE532
		[NullableContext(1)]
		public static ClientVersionNoMatchNotify Create()
		{
			return new ClientVersionNoMatchNotify();
		}

		// Token: 0x17000C76 RID: 3190
		// (get) Token: 0x060047A5 RID: 18341 RVA: 0x000B0339 File Offset: 0x000AE539
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000C77 RID: 3191
		// (get) Token: 0x060047A6 RID: 18342 RVA: 0x000B033C File Offset: 0x000AE53C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClientVersionNoMatchNotify.Descriptor;
			}
		}

		// Token: 0x060047A7 RID: 18343 RVA: 0x000B0343 File Offset: 0x000AE543
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientVersionNoMatchNotify()
		{
		}

		// Token: 0x060047A8 RID: 18344 RVA: 0x000B034B File Offset: 0x000AE54B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientVersionNoMatchNotify(ClientVersionNoMatchNotify other) : this()
		{
			this.teamType_ = other.teamType_;
			this.playerId_ = other.playerId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060047A9 RID: 18345 RVA: 0x000B037C File Offset: 0x000AE57C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientVersionNoMatchNotify Clone()
		{
			return new ClientVersionNoMatchNotify(this);
		}

		// Token: 0x17000C78 RID: 3192
		// (get) Token: 0x060047AA RID: 18346 RVA: 0x000B0384 File Offset: 0x000AE584
		// (set) Token: 0x060047AB RID: 18347 RVA: 0x000B038C File Offset: 0x000AE58C
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

		// Token: 0x17000C79 RID: 3193
		// (get) Token: 0x060047AC RID: 18348 RVA: 0x000B0395 File Offset: 0x000AE595
		// (set) Token: 0x060047AD RID: 18349 RVA: 0x000B039D File Offset: 0x000AE59D
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

		// Token: 0x060047AE RID: 18350 RVA: 0x000B03A6 File Offset: 0x000AE5A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClientVersionNoMatchNotify);
		}

		// Token: 0x060047AF RID: 18351 RVA: 0x000B03B4 File Offset: 0x000AE5B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ClientVersionNoMatchNotify other)
		{
			return other != null && (other == this || (this.TeamType == other.TeamType && this.PlayerId == other.PlayerId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060047B0 RID: 18352 RVA: 0x000B03F4 File Offset: 0x000AE5F4
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

		// Token: 0x060047B1 RID: 18353 RVA: 0x000B0452 File Offset: 0x000AE652
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060047B2 RID: 18354 RVA: 0x000B045F File Offset: 0x000AE65F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060047B3 RID: 18355 RVA: 0x000B0468 File Offset: 0x000AE668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TeamType != TeamType.WorldTeam)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.TeamType);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060047B4 RID: 18356 RVA: 0x000B04C0 File Offset: 0x000AE6C0
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

		// Token: 0x060047B5 RID: 18357 RVA: 0x000B0518 File Offset: 0x000AE718
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

		// Token: 0x060047B6 RID: 18358 RVA: 0x000B0568 File Offset: 0x000AE768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060047B7 RID: 18359 RVA: 0x000B0574 File Offset: 0x000AE774
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
					if (num != 24U)
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
					this.TeamType = (TeamType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003000 RID: 12288
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003001 RID: 12289
		public const int TeamTypeFieldNumber = 1;

		// Token: 0x04003002 RID: 12290
		private TeamType teamType_;

		// Token: 0x04003003 RID: 12291
		public const int PlayerIdFieldNumber = 3;

		// Token: 0x04003004 RID: 12292
		private int playerId_;
	}
}
