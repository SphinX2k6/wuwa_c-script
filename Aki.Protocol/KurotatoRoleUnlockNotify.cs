using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008BA RID: 2234
	[NetMessage(EMessageId.KurotatoRoleUnlockNotify)]
	public sealed class KurotatoRoleUnlockNotify : IMessage<KurotatoRoleUnlockNotify>, IMessage, IEquatable<KurotatoRoleUnlockNotify>, IDeepCloneable<KurotatoRoleUnlockNotify>, IBufferMessage
	{
		// Token: 0x0600C629 RID: 50729 RVA: 0x001D5159 File Offset: 0x001D3359
		[NullableContext(1)]
		public static KurotatoRoleUnlockNotify Create()
		{
			return new KurotatoRoleUnlockNotify();
		}

		// Token: 0x1700280A RID: 10250
		// (get) Token: 0x0600C62A RID: 50730 RVA: 0x001D5160 File Offset: 0x001D3360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700280B RID: 10251
		// (get) Token: 0x0600C62B RID: 50731 RVA: 0x001D5163 File Offset: 0x001D3363
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoRoleUnlockNotify.Descriptor;
			}
		}

		// Token: 0x0600C62C RID: 50732 RVA: 0x001D516A File Offset: 0x001D336A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoRoleUnlockNotify()
		{
		}

		// Token: 0x0600C62D RID: 50733 RVA: 0x001D517D File Offset: 0x001D337D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoRoleUnlockNotify(KurotatoRoleUnlockNotify other) : this()
		{
			this.kurotatoRoleInfos_ = other.kurotatoRoleInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C62E RID: 50734 RVA: 0x001D51A7 File Offset: 0x001D33A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoRoleUnlockNotify Clone()
		{
			return new KurotatoRoleUnlockNotify(this);
		}

		// Token: 0x1700280C RID: 10252
		// (get) Token: 0x0600C62F RID: 50735 RVA: 0x001D51AF File Offset: 0x001D33AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<KurotatoRoleInfo> KurotatoRoleInfos
		{
			get
			{
				return this.kurotatoRoleInfos_;
			}
		}

		// Token: 0x0600C630 RID: 50736 RVA: 0x001D51B7 File Offset: 0x001D33B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoRoleUnlockNotify);
		}

		// Token: 0x0600C631 RID: 50737 RVA: 0x001D51C5 File Offset: 0x001D33C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoRoleUnlockNotify other)
		{
			return other != null && (other == this || (this.kurotatoRoleInfos_.Equals(other.kurotatoRoleInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C632 RID: 50738 RVA: 0x001D51F8 File Offset: 0x001D33F8
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

		// Token: 0x0600C633 RID: 50739 RVA: 0x001D522C File Offset: 0x001D342C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C634 RID: 50740 RVA: 0x001D5239 File Offset: 0x001D3439
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C635 RID: 50741 RVA: 0x001D5242 File Offset: 0x001D3442
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

		// Token: 0x0600C636 RID: 50742 RVA: 0x001D526C File Offset: 0x001D346C
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

		// Token: 0x0600C637 RID: 50743 RVA: 0x001D52A5 File Offset: 0x001D34A5
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

		// Token: 0x0600C638 RID: 50744 RVA: 0x001D52D3 File Offset: 0x001D34D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C639 RID: 50745 RVA: 0x001D52DC File Offset: 0x001D34DC
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
					this.kurotatoRoleInfos_.AddEntriesFrom(ref input, KurotatoRoleUnlockNotify._repeated_kurotatoRoleInfos_codec);
				}
			}
		}

		// Token: 0x04005521 RID: 21793
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005522 RID: 21794
		public const int KurotatoRoleInfosFieldNumber = 6;

		// Token: 0x04005523 RID: 21795
		private static readonly FieldCodec<KurotatoRoleInfo> _repeated_kurotatoRoleInfos_codec = FieldCodec.ForMessage<KurotatoRoleInfo>(50U, KurotatoRoleInfo.Parser);

		// Token: 0x04005524 RID: 21796
		private readonly RepeatedField<KurotatoRoleInfo> kurotatoRoleInfos_ = new RepeatedField<KurotatoRoleInfo>();
	}
}
