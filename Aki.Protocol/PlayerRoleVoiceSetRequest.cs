using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DA9 RID: 3497
	[NetMessage(EMessageId.PlayerRoleVoiceSetRequest)]
	public sealed class PlayerRoleVoiceSetRequest : IMessage<PlayerRoleVoiceSetRequest>, IMessage, IEquatable<PlayerRoleVoiceSetRequest>, IDeepCloneable<PlayerRoleVoiceSetRequest>, IBufferMessage
	{
		// Token: 0x06012D7A RID: 77178 RVA: 0x002BF9A6 File Offset: 0x002BDBA6
		[NullableContext(1)]
		public static PlayerRoleVoiceSetRequest Create()
		{
			return new PlayerRoleVoiceSetRequest();
		}

		// Token: 0x17003E85 RID: 16005
		// (get) Token: 0x06012D7B RID: 77179 RVA: 0x002BF9AD File Offset: 0x002BDBAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003E86 RID: 16006
		// (get) Token: 0x06012D7C RID: 77180 RVA: 0x002BF9B0 File Offset: 0x002BDBB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerRoleVoiceSetRequest.Descriptor;
			}
		}

		// Token: 0x06012D7D RID: 77181 RVA: 0x002BF9B7 File Offset: 0x002BDBB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerRoleVoiceSetRequest()
		{
		}

		// Token: 0x06012D7E RID: 77182 RVA: 0x002BF9CA File Offset: 0x002BDBCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerRoleVoiceSetRequest(PlayerRoleVoiceSetRequest other) : this()
		{
			this.roleVoices_ = other.roleVoices_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012D7F RID: 77183 RVA: 0x002BF9F4 File Offset: 0x002BDBF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerRoleVoiceSetRequest Clone()
		{
			return new PlayerRoleVoiceSetRequest(this);
		}

		// Token: 0x17003E87 RID: 16007
		// (get) Token: 0x06012D80 RID: 77184 RVA: 0x002BF9FC File Offset: 0x002BDBFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleVoiceSetting> RoleVoices
		{
			get
			{
				return this.roleVoices_;
			}
		}

		// Token: 0x06012D81 RID: 77185 RVA: 0x002BFA04 File Offset: 0x002BDC04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerRoleVoiceSetRequest);
		}

		// Token: 0x06012D82 RID: 77186 RVA: 0x002BFA12 File Offset: 0x002BDC12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerRoleVoiceSetRequest other)
		{
			return other != null && (other == this || (this.roleVoices_.Equals(other.roleVoices_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012D83 RID: 77187 RVA: 0x002BFA48 File Offset: 0x002BDC48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.roleVoices_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012D84 RID: 77188 RVA: 0x002BFA7C File Offset: 0x002BDC7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012D85 RID: 77189 RVA: 0x002BFA89 File Offset: 0x002BDC89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012D86 RID: 77190 RVA: 0x002BFA92 File Offset: 0x002BDC92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.roleVoices_.WriteTo(ref output, PlayerRoleVoiceSetRequest._repeated_roleVoices_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012D87 RID: 77191 RVA: 0x002BFABC File Offset: 0x002BDCBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.roleVoices_.CalculateSize(PlayerRoleVoiceSetRequest._repeated_roleVoices_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012D88 RID: 77192 RVA: 0x002BFAF5 File Offset: 0x002BDCF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerRoleVoiceSetRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.roleVoices_.Add(other.roleVoices_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012D89 RID: 77193 RVA: 0x002BFB23 File Offset: 0x002BDD23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012D8A RID: 77194 RVA: 0x002BFB2C File Offset: 0x002BDD2C
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.roleVoices_.AddEntriesFrom(ref input, PlayerRoleVoiceSetRequest._repeated_roleVoices_codec);
				}
			}
		}

		// Token: 0x040074A3 RID: 29859
		private UnknownFieldSet _unknownFields;

		// Token: 0x040074A4 RID: 29860
		public const int RoleVoicesFieldNumber = 2;

		// Token: 0x040074A5 RID: 29861
		private static readonly FieldCodec<RoleVoiceSetting> _repeated_roleVoices_codec = FieldCodec.ForMessage<RoleVoiceSetting>(18U, RoleVoiceSetting.Parser);

		// Token: 0x040074A6 RID: 29862
		private readonly RepeatedField<RoleVoiceSetting> roleVoices_ = new RepeatedField<RoleVoiceSetting>();
	}
}
