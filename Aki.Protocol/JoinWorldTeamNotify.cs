using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000866 RID: 2150
	[NetMessage(EMessageId.JoinWorldTeamNotify)]
	public sealed class JoinWorldTeamNotify : IMessage<JoinWorldTeamNotify>, IMessage, IEquatable<JoinWorldTeamNotify>, IDeepCloneable<JoinWorldTeamNotify>, IBufferMessage
	{
		// Token: 0x0600BF8B RID: 49035 RVA: 0x001C6EAA File Offset: 0x001C50AA
		[NullableContext(1)]
		public static JoinWorldTeamNotify Create()
		{
			return new JoinWorldTeamNotify();
		}

		// Token: 0x170026AE RID: 9902
		// (get) Token: 0x0600BF8C RID: 49036 RVA: 0x001C6EB1 File Offset: 0x001C50B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170026AF RID: 9903
		// (get) Token: 0x0600BF8D RID: 49037 RVA: 0x001C6EB4 File Offset: 0x001C50B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JoinWorldTeamNotify.Descriptor;
			}
		}

		// Token: 0x0600BF8E RID: 49038 RVA: 0x001C6EBB File Offset: 0x001C50BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JoinWorldTeamNotify()
		{
		}

		// Token: 0x0600BF8F RID: 49039 RVA: 0x001C6ECE File Offset: 0x001C50CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JoinWorldTeamNotify(JoinWorldTeamNotify other) : this()
		{
			this.ownerId_ = other.ownerId_;
			this.playerInfos_ = other.playerInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BF90 RID: 49040 RVA: 0x001C6F04 File Offset: 0x001C5104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JoinWorldTeamNotify Clone()
		{
			return new JoinWorldTeamNotify(this);
		}

		// Token: 0x170026B0 RID: 9904
		// (get) Token: 0x0600BF91 RID: 49041 RVA: 0x001C6F0C File Offset: 0x001C510C
		// (set) Token: 0x0600BF92 RID: 49042 RVA: 0x001C6F14 File Offset: 0x001C5114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int OwnerId
		{
			get
			{
				return this.ownerId_;
			}
			set
			{
				this.ownerId_ = value;
			}
		}

		// Token: 0x170026B1 RID: 9905
		// (get) Token: 0x0600BF93 RID: 49043 RVA: 0x001C6F1D File Offset: 0x001C511D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<WorldTeamPlayerInfo> PlayerInfos
		{
			get
			{
				return this.playerInfos_;
			}
		}

		// Token: 0x0600BF94 RID: 49044 RVA: 0x001C6F25 File Offset: 0x001C5125
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JoinWorldTeamNotify);
		}

		// Token: 0x0600BF95 RID: 49045 RVA: 0x001C6F34 File Offset: 0x001C5134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JoinWorldTeamNotify other)
		{
			return other != null && (other == this || (this.OwnerId == other.OwnerId && this.playerInfos_.Equals(other.playerInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BF96 RID: 49046 RVA: 0x001C6F84 File Offset: 0x001C5184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.OwnerId != 0)
			{
				num ^= this.OwnerId.GetHashCode();
			}
			num ^= this.playerInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BF97 RID: 49047 RVA: 0x001C6FD1 File Offset: 0x001C51D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BF98 RID: 49048 RVA: 0x001C6FDE File Offset: 0x001C51DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BF99 RID: 49049 RVA: 0x001C6FE8 File Offset: 0x001C51E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.playerInfos_.WriteTo(ref output, JoinWorldTeamNotify._repeated_playerInfos_codec);
			if (this.OwnerId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.OwnerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BF9A RID: 49050 RVA: 0x001C7038 File Offset: 0x001C5238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.OwnerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.OwnerId);
			}
			num += this.playerInfos_.CalculateSize(JoinWorldTeamNotify._repeated_playerInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BF9B RID: 49051 RVA: 0x001C708C File Offset: 0x001C528C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(JoinWorldTeamNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.OwnerId != 0)
			{
				this.OwnerId = other.OwnerId;
			}
			this.playerInfos_.Add(other.playerInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BF9C RID: 49052 RVA: 0x001C70D9 File Offset: 0x001C52D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BF9D RID: 49053 RVA: 0x001C70E4 File Offset: 0x001C52E4
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
				if (num != 58U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.OwnerId = input.ReadInt32();
					}
				}
				else
				{
					this.playerInfos_.AddEntriesFrom(ref input, JoinWorldTeamNotify._repeated_playerInfos_codec);
				}
			}
		}

		// Token: 0x0400535A RID: 21338
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400535B RID: 21339
		public const int OwnerIdFieldNumber = 11;

		// Token: 0x0400535C RID: 21340
		private int ownerId_;

		// Token: 0x0400535D RID: 21341
		public const int PlayerInfosFieldNumber = 7;

		// Token: 0x0400535E RID: 21342
		private static readonly FieldCodec<WorldTeamPlayerInfo> _repeated_playerInfos_codec = FieldCodec.ForMessage<WorldTeamPlayerInfo>(58U, WorldTeamPlayerInfo.Parser);

		// Token: 0x0400535F RID: 21343
		private readonly RepeatedField<WorldTeamPlayerInfo> playerInfos_ = new RepeatedField<WorldTeamPlayerInfo>();
	}
}
