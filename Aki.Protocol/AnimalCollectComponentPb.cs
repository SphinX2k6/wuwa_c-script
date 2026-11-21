using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000E0 RID: 224
	public sealed class AnimalCollectComponentPb : IMessage<AnimalCollectComponentPb>, IMessage, IEquatable<AnimalCollectComponentPb>, IDeepCloneable<AnimalCollectComponentPb>, IBufferMessage
	{
		// Token: 0x06002173 RID: 8563 RVA: 0x00059D09 File Offset: 0x00057F09
		[NullableContext(1)]
		public static AnimalCollectComponentPb Create()
		{
			return new AnimalCollectComponentPb();
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06002174 RID: 8564 RVA: 0x00059D10 File Offset: 0x00057F10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06002175 RID: 8565 RVA: 0x00059D13 File Offset: 0x00057F13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AnimalCollectComponentPb.Descriptor;
			}
		}

		// Token: 0x06002176 RID: 8566 RVA: 0x00059D1A File Offset: 0x00057F1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimalCollectComponentPb()
		{
		}

		// Token: 0x06002177 RID: 8567 RVA: 0x00059D2D File Offset: 0x00057F2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimalCollectComponentPb(AnimalCollectComponentPb other) : this()
		{
			this.partIds_ = other.partIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002178 RID: 8568 RVA: 0x00059D57 File Offset: 0x00057F57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimalCollectComponentPb Clone()
		{
			return new AnimalCollectComponentPb(this);
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06002179 RID: 8569 RVA: 0x00059D5F File Offset: 0x00057F5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PartIds
		{
			get
			{
				return this.partIds_;
			}
		}

		// Token: 0x0600217A RID: 8570 RVA: 0x00059D67 File Offset: 0x00057F67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AnimalCollectComponentPb);
		}

		// Token: 0x0600217B RID: 8571 RVA: 0x00059D75 File Offset: 0x00057F75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AnimalCollectComponentPb other)
		{
			return other != null && (other == this || (this.partIds_.Equals(other.partIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600217C RID: 8572 RVA: 0x00059DA8 File Offset: 0x00057FA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.partIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600217D RID: 8573 RVA: 0x00059DDC File Offset: 0x00057FDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600217E RID: 8574 RVA: 0x00059DE9 File Offset: 0x00057FE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600217F RID: 8575 RVA: 0x00059DF2 File Offset: 0x00057FF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.partIds_.WriteTo(ref output, AnimalCollectComponentPb._repeated_partIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002180 RID: 8576 RVA: 0x00059E1C File Offset: 0x0005801C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.partIds_.CalculateSize(AnimalCollectComponentPb._repeated_partIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002181 RID: 8577 RVA: 0x00059E55 File Offset: 0x00058055
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AnimalCollectComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			this.partIds_.Add(other.partIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002182 RID: 8578 RVA: 0x00059E83 File Offset: 0x00058083
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002183 RID: 8579 RVA: 0x00059E8C File Offset: 0x0005808C
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
				if (num != 8U && num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.partIds_.AddEntriesFrom(ref input, AnimalCollectComponentPb._repeated_partIds_codec);
				}
			}
		}

		// Token: 0x0400248F RID: 9359
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002490 RID: 9360
		public const int PartIdsFieldNumber = 1;

		// Token: 0x04002491 RID: 9361
		private static readonly FieldCodec<int> _repeated_partIds_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04002492 RID: 9362
		private readonly RepeatedField<int> partIds_ = new RepeatedField<int>();
	}
}
