using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006BA RID: 1722
	[NetMessage(EMessageId.GatherClueInfoNotify)]
	public sealed class GatherClueInfoNotify : IMessage<GatherClueInfoNotify>, IMessage, IEquatable<GatherClueInfoNotify>, IDeepCloneable<GatherClueInfoNotify>, IBufferMessage
	{
		// Token: 0x06009DBA RID: 40378 RVA: 0x0017F321 File Offset: 0x0017D521
		[NullableContext(1)]
		public static GatherClueInfoNotify Create()
		{
			return new GatherClueInfoNotify();
		}

		// Token: 0x17001FB3 RID: 8115
		// (get) Token: 0x06009DBB RID: 40379 RVA: 0x0017F328 File Offset: 0x0017D528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001FB4 RID: 8116
		// (get) Token: 0x06009DBC RID: 40380 RVA: 0x0017F32B File Offset: 0x0017D52B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GatherClueInfoNotify.Descriptor;
			}
		}

		// Token: 0x06009DBD RID: 40381 RVA: 0x0017F332 File Offset: 0x0017D532
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GatherClueInfoNotify()
		{
		}

		// Token: 0x06009DBE RID: 40382 RVA: 0x0017F345 File Offset: 0x0017D545
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GatherClueInfoNotify(GatherClueInfoNotify other) : this()
		{
			this.unLockClueIds_ = other.unLockClueIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009DBF RID: 40383 RVA: 0x0017F36F File Offset: 0x0017D56F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GatherClueInfoNotify Clone()
		{
			return new GatherClueInfoNotify(this);
		}

		// Token: 0x17001FB5 RID: 8117
		// (get) Token: 0x06009DC0 RID: 40384 RVA: 0x0017F377 File Offset: 0x0017D577
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnLockClueIds
		{
			get
			{
				return this.unLockClueIds_;
			}
		}

		// Token: 0x06009DC1 RID: 40385 RVA: 0x0017F37F File Offset: 0x0017D57F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GatherClueInfoNotify);
		}

		// Token: 0x06009DC2 RID: 40386 RVA: 0x0017F38D File Offset: 0x0017D58D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GatherClueInfoNotify other)
		{
			return other != null && (other == this || (this.unLockClueIds_.Equals(other.unLockClueIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009DC3 RID: 40387 RVA: 0x0017F3C0 File Offset: 0x0017D5C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.unLockClueIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009DC4 RID: 40388 RVA: 0x0017F3F4 File Offset: 0x0017D5F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009DC5 RID: 40389 RVA: 0x0017F401 File Offset: 0x0017D601
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009DC6 RID: 40390 RVA: 0x0017F40A File Offset: 0x0017D60A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.unLockClueIds_.WriteTo(ref output, GatherClueInfoNotify._repeated_unLockClueIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009DC7 RID: 40391 RVA: 0x0017F434 File Offset: 0x0017D634
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.unLockClueIds_.CalculateSize(GatherClueInfoNotify._repeated_unLockClueIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009DC8 RID: 40392 RVA: 0x0017F46D File Offset: 0x0017D66D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GatherClueInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.unLockClueIds_.Add(other.unLockClueIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009DC9 RID: 40393 RVA: 0x0017F49B File Offset: 0x0017D69B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009DCA RID: 40394 RVA: 0x0017F4A4 File Offset: 0x0017D6A4
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
				if (num != 16U && num != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.unLockClueIds_.AddEntriesFrom(ref input, GatherClueInfoNotify._repeated_unLockClueIds_codec);
				}
			}
		}

		// Token: 0x04004A06 RID: 18950
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A07 RID: 18951
		public const int UnLockClueIdsFieldNumber = 2;

		// Token: 0x04004A08 RID: 18952
		private static readonly FieldCodec<int> _repeated_unLockClueIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04004A09 RID: 18953
		private readonly RepeatedField<int> unLockClueIds_ = new RepeatedField<int>();
	}
}
