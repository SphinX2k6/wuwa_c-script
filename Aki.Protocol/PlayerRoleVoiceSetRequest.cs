using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D99 RID: 3481
	[NetMessage(EMessageId.PlayerRoleVoiceSetRequest)]
	public sealed class PlayerRoleVoiceSetRequest : IMessage<PlayerRoleVoiceSetRequest>, IMessage, IEquatable<PlayerRoleVoiceSetRequest>, IDeepCloneable<PlayerRoleVoiceSetRequest>, IBufferMessage
	{
		// Token: 0x06012C7E RID: 76926 RVA: 0x002BDD82 File Offset: 0x002BBF82
		[NullableContext(1)]
		public static PlayerRoleVoiceSetRequest Create()
		{
			return new PlayerRoleVoiceSetRequest();
		}

		// Token: 0x17003E50 RID: 15952
		// (get) Token: 0x06012C7F RID: 76927 RVA: 0x002BDD89 File Offset: 0x002BBF89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003E51 RID: 15953
		// (get) Token: 0x06012C80 RID: 76928 RVA: 0x002BDD8C File Offset: 0x002BBF8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerRoleVoiceSetRequest.Descriptor;
			}
		}

		// Token: 0x06012C81 RID: 76929 RVA: 0x002BDD93 File Offset: 0x002BBF93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerRoleVoiceSetRequest()
		{
		}

		// Token: 0x06012C82 RID: 76930 RVA: 0x002BDDA6 File Offset: 0x002BBFA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerRoleVoiceSetRequest(PlayerRoleVoiceSetRequest other) : this()
		{
			this.roleVoices_ = other.roleVoices_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012C83 RID: 76931 RVA: 0x002BDDD0 File Offset: 0x002BBFD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerRoleVoiceSetRequest Clone()
		{
			return new PlayerRoleVoiceSetRequest(this);
		}

		// Token: 0x17003E52 RID: 15954
		// (get) Token: 0x06012C84 RID: 76932 RVA: 0x002BDDD8 File Offset: 0x002BBFD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleVoiceSetting> RoleVoices
		{
			get
			{
				return this.roleVoices_;
			}
		}

		// Token: 0x06012C85 RID: 76933 RVA: 0x002BDDE0 File Offset: 0x002BBFE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerRoleVoiceSetRequest);
		}

		// Token: 0x06012C86 RID: 76934 RVA: 0x002BDDEE File Offset: 0x002BBFEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerRoleVoiceSetRequest other)
		{
			return other != null && (other == this || (this.roleVoices_.Equals(other.roleVoices_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012C87 RID: 76935 RVA: 0x002BDE24 File Offset: 0x002BC024
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

		// Token: 0x06012C88 RID: 76936 RVA: 0x002BDE58 File Offset: 0x002BC058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012C89 RID: 76937 RVA: 0x002BDE65 File Offset: 0x002BC065
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012C8A RID: 76938 RVA: 0x002BDE6E File Offset: 0x002BC06E
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

		// Token: 0x06012C8B RID: 76939 RVA: 0x002BDE98 File Offset: 0x002BC098
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

		// Token: 0x06012C8C RID: 76940 RVA: 0x002BDED1 File Offset: 0x002BC0D1
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

		// Token: 0x06012C8D RID: 76941 RVA: 0x002BDEFF File Offset: 0x002BC0FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012C8E RID: 76942 RVA: 0x002BDF08 File Offset: 0x002BC108
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.roleVoices_.AddEntriesFrom(ref input, PlayerRoleVoiceSetRequest._repeated_roleVoices_codec);
				}
			}
		}

		// Token: 0x040074BB RID: 29883
		private UnknownFieldSet _unknownFields;

		// Token: 0x040074BC RID: 29884
		public const int RoleVoicesFieldNumber = 6;

		// Token: 0x040074BD RID: 29885
		private static readonly FieldCodec<RoleVoiceSetting> _repeated_roleVoices_codec = FieldCodec.ForMessage<RoleVoiceSetting>(50U, RoleVoiceSetting.Parser);

		// Token: 0x040074BE RID: 29886
		private readonly RepeatedField<RoleVoiceSetting> roleVoices_ = new RepeatedField<RoleVoiceSetting>();
	}
}
