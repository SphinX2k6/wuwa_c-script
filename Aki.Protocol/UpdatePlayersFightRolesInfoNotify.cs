using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001519 RID: 5401
	[NetMessage(EMessageId.UpdatePlayersFightRolesInfoNotify)]
	public sealed class UpdatePlayersFightRolesInfoNotify : IMessage<UpdatePlayersFightRolesInfoNotify>, IMessage, IEquatable<UpdatePlayersFightRolesInfoNotify>, IDeepCloneable<UpdatePlayersFightRolesInfoNotify>, IBufferMessage
	{
		// Token: 0x0601C9D8 RID: 117208 RVA: 0x00425971 File Offset: 0x00423B71
		[NullableContext(1)]
		public static UpdatePlayersFightRolesInfoNotify Create()
		{
			return new UpdatePlayersFightRolesInfoNotify();
		}

		// Token: 0x170060CB RID: 24779
		// (get) Token: 0x0601C9D9 RID: 117209 RVA: 0x00425978 File Offset: 0x00423B78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170060CC RID: 24780
		// (get) Token: 0x0601C9DA RID: 117210 RVA: 0x0042597B File Offset: 0x00423B7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdatePlayersFightRolesInfoNotify.Descriptor;
			}
		}

		// Token: 0x0601C9DB RID: 117211 RVA: 0x00425982 File Offset: 0x00423B82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdatePlayersFightRolesInfoNotify()
		{
		}

		// Token: 0x0601C9DC RID: 117212 RVA: 0x00425995 File Offset: 0x00423B95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdatePlayersFightRolesInfoNotify(UpdatePlayersFightRolesInfoNotify other) : this()
		{
			this.playersFightRoles_ = other.playersFightRoles_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C9DD RID: 117213 RVA: 0x004259BF File Offset: 0x00423BBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdatePlayersFightRolesInfoNotify Clone()
		{
			return new UpdatePlayersFightRolesInfoNotify(this);
		}

		// Token: 0x170060CD RID: 24781
		// (get) Token: 0x0601C9DE RID: 117214 RVA: 0x004259C7 File Offset: 0x00423BC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PlayerFightRolesInfo> PlayersFightRoles
		{
			get
			{
				return this.playersFightRoles_;
			}
		}

		// Token: 0x0601C9DF RID: 117215 RVA: 0x004259CF File Offset: 0x00423BCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdatePlayersFightRolesInfoNotify);
		}

		// Token: 0x0601C9E0 RID: 117216 RVA: 0x004259DD File Offset: 0x00423BDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdatePlayersFightRolesInfoNotify other)
		{
			return other != null && (other == this || (this.playersFightRoles_.Equals(other.playersFightRoles_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C9E1 RID: 117217 RVA: 0x00425A10 File Offset: 0x00423C10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.playersFightRoles_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C9E2 RID: 117218 RVA: 0x00425A44 File Offset: 0x00423C44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C9E3 RID: 117219 RVA: 0x00425A51 File Offset: 0x00423C51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C9E4 RID: 117220 RVA: 0x00425A5A File Offset: 0x00423C5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.playersFightRoles_.WriteTo(ref output, UpdatePlayersFightRolesInfoNotify._repeated_playersFightRoles_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C9E5 RID: 117221 RVA: 0x00425A84 File Offset: 0x00423C84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.playersFightRoles_.CalculateSize(UpdatePlayersFightRolesInfoNotify._repeated_playersFightRoles_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C9E6 RID: 117222 RVA: 0x00425ABD File Offset: 0x00423CBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UpdatePlayersFightRolesInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.playersFightRoles_.Add(other.playersFightRoles_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C9E7 RID: 117223 RVA: 0x00425AEB File Offset: 0x00423CEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C9E8 RID: 117224 RVA: 0x00425AF4 File Offset: 0x00423CF4
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
				if (num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.playersFightRoles_.AddEntriesFrom(ref input, UpdatePlayersFightRolesInfoNotify._repeated_playersFightRoles_codec);
				}
			}
		}

		// Token: 0x0400A4E4 RID: 42212
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A4E5 RID: 42213
		public const int PlayersFightRolesFieldNumber = 14;

		// Token: 0x0400A4E6 RID: 42214
		private static readonly FieldCodec<PlayerFightRolesInfo> _repeated_playersFightRoles_codec = FieldCodec.ForMessage<PlayerFightRolesInfo>(114U, PlayerFightRolesInfo.Parser);

		// Token: 0x0400A4E7 RID: 42215
		private readonly RepeatedField<PlayerFightRolesInfo> playersFightRoles_ = new RepeatedField<PlayerFightRolesInfo>();
	}
}
