using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000855 RID: 2133
	[NetMessage(EMessageId.JoinWorldTeamNotify)]
	public sealed class JoinWorldTeamNotify : IMessage<JoinWorldTeamNotify>, IMessage, IEquatable<JoinWorldTeamNotify>, IDeepCloneable<JoinWorldTeamNotify>, IBufferMessage
	{
		// Token: 0x0600BE6F RID: 48751 RVA: 0x001C4BC2 File Offset: 0x001C2DC2
		[NullableContext(1)]
		public static JoinWorldTeamNotify Create()
		{
			return new JoinWorldTeamNotify();
		}

		// Token: 0x1700266F RID: 9839
		// (get) Token: 0x0600BE70 RID: 48752 RVA: 0x001C4BC9 File Offset: 0x001C2DC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002670 RID: 9840
		// (get) Token: 0x0600BE71 RID: 48753 RVA: 0x001C4BCC File Offset: 0x001C2DCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JoinWorldTeamNotify.Descriptor;
			}
		}

		// Token: 0x0600BE72 RID: 48754 RVA: 0x001C4BD3 File Offset: 0x001C2DD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JoinWorldTeamNotify()
		{
		}

		// Token: 0x0600BE73 RID: 48755 RVA: 0x001C4BE6 File Offset: 0x001C2DE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JoinWorldTeamNotify(JoinWorldTeamNotify other) : this()
		{
			this.ownerId_ = other.ownerId_;
			this.playerInfos_ = other.playerInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BE74 RID: 48756 RVA: 0x001C4C1C File Offset: 0x001C2E1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JoinWorldTeamNotify Clone()
		{
			return new JoinWorldTeamNotify(this);
		}

		// Token: 0x17002671 RID: 9841
		// (get) Token: 0x0600BE75 RID: 48757 RVA: 0x001C4C24 File Offset: 0x001C2E24
		// (set) Token: 0x0600BE76 RID: 48758 RVA: 0x001C4C2C File Offset: 0x001C2E2C
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

		// Token: 0x17002672 RID: 9842
		// (get) Token: 0x0600BE77 RID: 48759 RVA: 0x001C4C35 File Offset: 0x001C2E35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<WorldTeamPlayerInfo> PlayerInfos
		{
			get
			{
				return this.playerInfos_;
			}
		}

		// Token: 0x0600BE78 RID: 48760 RVA: 0x001C4C3D File Offset: 0x001C2E3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JoinWorldTeamNotify);
		}

		// Token: 0x0600BE79 RID: 48761 RVA: 0x001C4C4C File Offset: 0x001C2E4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JoinWorldTeamNotify other)
		{
			return other != null && (other == this || (this.OwnerId == other.OwnerId && this.playerInfos_.Equals(other.playerInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BE7A RID: 48762 RVA: 0x001C4C9C File Offset: 0x001C2E9C
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

		// Token: 0x0600BE7B RID: 48763 RVA: 0x001C4CE9 File Offset: 0x001C2EE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BE7C RID: 48764 RVA: 0x001C4CF6 File Offset: 0x001C2EF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BE7D RID: 48765 RVA: 0x001C4D00 File Offset: 0x001C2F00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.playerInfos_.WriteTo(ref output, JoinWorldTeamNotify._repeated_playerInfos_codec);
			if (this.OwnerId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.OwnerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BE7E RID: 48766 RVA: 0x001C4D50 File Offset: 0x001C2F50
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

		// Token: 0x0600BE7F RID: 48767 RVA: 0x001C4DA4 File Offset: 0x001C2FA4
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

		// Token: 0x0600BE80 RID: 48768 RVA: 0x001C4DF1 File Offset: 0x001C2FF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BE81 RID: 48769 RVA: 0x001C4DFC File Offset: 0x001C2FFC
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
				if (num != 50U)
				{
					if (num != 104U)
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

		// Token: 0x04005361 RID: 21345
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005362 RID: 21346
		public const int OwnerIdFieldNumber = 13;

		// Token: 0x04005363 RID: 21347
		private int ownerId_;

		// Token: 0x04005364 RID: 21348
		public const int PlayerInfosFieldNumber = 6;

		// Token: 0x04005365 RID: 21349
		private static readonly FieldCodec<WorldTeamPlayerInfo> _repeated_playerInfos_codec = FieldCodec.ForMessage<WorldTeamPlayerInfo>(50U, WorldTeamPlayerInfo.Parser);

		// Token: 0x04005366 RID: 21350
		private readonly RepeatedField<WorldTeamPlayerInfo> playerInfos_ = new RepeatedField<WorldTeamPlayerInfo>();
	}
}
