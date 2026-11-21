using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008A9 RID: 2217
	[NetMessage(EMessageId.KurotatoRoleUnlockNotify)]
	public sealed class KurotatoRoleUnlockNotify : IMessage<KurotatoRoleUnlockNotify>, IMessage, IEquatable<KurotatoRoleUnlockNotify>, IDeepCloneable<KurotatoRoleUnlockNotify>, IBufferMessage
	{
		// Token: 0x0600C50D RID: 50445 RVA: 0x001D2E71 File Offset: 0x001D1071
		[NullableContext(1)]
		public static KurotatoRoleUnlockNotify Create()
		{
			return new KurotatoRoleUnlockNotify();
		}

		// Token: 0x170027CB RID: 10187
		// (get) Token: 0x0600C50E RID: 50446 RVA: 0x001D2E78 File Offset: 0x001D1078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170027CC RID: 10188
		// (get) Token: 0x0600C50F RID: 50447 RVA: 0x001D2E7B File Offset: 0x001D107B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoRoleUnlockNotify.Descriptor;
			}
		}

		// Token: 0x0600C510 RID: 50448 RVA: 0x001D2E82 File Offset: 0x001D1082
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoRoleUnlockNotify()
		{
		}

		// Token: 0x0600C511 RID: 50449 RVA: 0x001D2E95 File Offset: 0x001D1095
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoRoleUnlockNotify(KurotatoRoleUnlockNotify other) : this()
		{
			this.kurotatoRoleInfos_ = other.kurotatoRoleInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C512 RID: 50450 RVA: 0x001D2EBF File Offset: 0x001D10BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoRoleUnlockNotify Clone()
		{
			return new KurotatoRoleUnlockNotify(this);
		}

		// Token: 0x170027CD RID: 10189
		// (get) Token: 0x0600C513 RID: 50451 RVA: 0x001D2EC7 File Offset: 0x001D10C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<KurotatoRoleInfo> KurotatoRoleInfos
		{
			get
			{
				return this.kurotatoRoleInfos_;
			}
		}

		// Token: 0x0600C514 RID: 50452 RVA: 0x001D2ECF File Offset: 0x001D10CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoRoleUnlockNotify);
		}

		// Token: 0x0600C515 RID: 50453 RVA: 0x001D2EDD File Offset: 0x001D10DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoRoleUnlockNotify other)
		{
			return other != null && (other == this || (this.kurotatoRoleInfos_.Equals(other.kurotatoRoleInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C516 RID: 50454 RVA: 0x001D2F10 File Offset: 0x001D1110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.kurotatoRoleInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C517 RID: 50455 RVA: 0x001D2F44 File Offset: 0x001D1144
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C518 RID: 50456 RVA: 0x001D2F51 File Offset: 0x001D1151
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C519 RID: 50457 RVA: 0x001D2F5A File Offset: 0x001D115A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.kurotatoRoleInfos_.WriteTo(ref output, KurotatoRoleUnlockNotify._repeated_kurotatoRoleInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C51A RID: 50458 RVA: 0x001D2F84 File Offset: 0x001D1184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.kurotatoRoleInfos_.CalculateSize(KurotatoRoleUnlockNotify._repeated_kurotatoRoleInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C51B RID: 50459 RVA: 0x001D2FBD File Offset: 0x001D11BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoRoleUnlockNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.kurotatoRoleInfos_.Add(other.kurotatoRoleInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C51C RID: 50460 RVA: 0x001D2FEB File Offset: 0x001D11EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C51D RID: 50461 RVA: 0x001D2FF4 File Offset: 0x001D11F4
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
					this.kurotatoRoleInfos_.AddEntriesFrom(ref input, KurotatoRoleUnlockNotify._repeated_kurotatoRoleInfos_codec);
				}
			}
		}

		// Token: 0x04005528 RID: 21800
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005529 RID: 21801
		public const int KurotatoRoleInfosFieldNumber = 2;

		// Token: 0x0400552A RID: 21802
		private static readonly FieldCodec<KurotatoRoleInfo> _repeated_kurotatoRoleInfos_codec = FieldCodec.ForMessage<KurotatoRoleInfo>(18U, KurotatoRoleInfo.Parser);

		// Token: 0x0400552B RID: 21803
		private readonly RepeatedField<KurotatoRoleInfo> kurotatoRoleInfos_ = new RepeatedField<KurotatoRoleInfo>();
	}
}
