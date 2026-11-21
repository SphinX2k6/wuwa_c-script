using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000817 RID: 2071
	[NetMessage(EMessageId.InstSaveDataNotify)]
	public sealed class InstSaveDataNotify : IMessage<InstSaveDataNotify>, IMessage, IEquatable<InstSaveDataNotify>, IDeepCloneable<InstSaveDataNotify>, IBufferMessage
	{
		// Token: 0x0600B99F RID: 47519 RVA: 0x001BAE7F File Offset: 0x001B907F
		[NullableContext(1)]
		public static InstSaveDataNotify Create()
		{
			return new InstSaveDataNotify();
		}

		// Token: 0x17002579 RID: 9593
		// (get) Token: 0x0600B9A0 RID: 47520 RVA: 0x001BAE86 File Offset: 0x001B9086
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700257A RID: 9594
		// (get) Token: 0x0600B9A1 RID: 47521 RVA: 0x001BAE89 File Offset: 0x001B9089
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InstSaveDataNotify.Descriptor;
			}
		}

		// Token: 0x0600B9A2 RID: 47522 RVA: 0x001BAE90 File Offset: 0x001B9090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstSaveDataNotify()
		{
		}

		// Token: 0x0600B9A3 RID: 47523 RVA: 0x001BAEA3 File Offset: 0x001B90A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstSaveDataNotify(InstSaveDataNotify other) : this()
		{
			this.ids_ = other.ids_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B9A4 RID: 47524 RVA: 0x001BAECD File Offset: 0x001B90CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstSaveDataNotify Clone()
		{
			return new InstSaveDataNotify(this);
		}

		// Token: 0x1700257B RID: 9595
		// (get) Token: 0x0600B9A5 RID: 47525 RVA: 0x001BAED5 File Offset: 0x001B90D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> Ids
		{
			get
			{
				return this.ids_;
			}
		}

		// Token: 0x0600B9A6 RID: 47526 RVA: 0x001BAEDD File Offset: 0x001B90DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InstSaveDataNotify);
		}

		// Token: 0x0600B9A7 RID: 47527 RVA: 0x001BAEEB File Offset: 0x001B90EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InstSaveDataNotify other)
		{
			return other != null && (other == this || (this.ids_.Equals(other.ids_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B9A8 RID: 47528 RVA: 0x001BAF20 File Offset: 0x001B9120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.ids_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B9A9 RID: 47529 RVA: 0x001BAF54 File Offset: 0x001B9154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B9AA RID: 47530 RVA: 0x001BAF61 File Offset: 0x001B9161
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B9AB RID: 47531 RVA: 0x001BAF6A File Offset: 0x001B916A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.ids_.WriteTo(ref output, InstSaveDataNotify._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B9AC RID: 47532 RVA: 0x001BAF94 File Offset: 0x001B9194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.ids_.CalculateSize(InstSaveDataNotify._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B9AD RID: 47533 RVA: 0x001BAFCD File Offset: 0x001B91CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InstSaveDataNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.ids_.Add(other.ids_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B9AE RID: 47534 RVA: 0x001BAFFB File Offset: 0x001B91FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B9AF RID: 47535 RVA: 0x001BB004 File Offset: 0x001B9204
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
				if (num != 120U && num != 122U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ids_.AddEntriesFrom(ref input, InstSaveDataNotify._repeated_ids_codec);
				}
			}
		}

		// Token: 0x04005220 RID: 21024
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005221 RID: 21025
		public const int IdsFieldNumber = 15;

		// Token: 0x04005222 RID: 21026
		private static readonly FieldCodec<long> _repeated_ids_codec = FieldCodec.ForInt64(122U);

		// Token: 0x04005223 RID: 21027
		private readonly RepeatedField<long> ids_ = new RepeatedField<long>();
	}
}
