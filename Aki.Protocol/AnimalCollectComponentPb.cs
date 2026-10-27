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
		// Token: 0x0600213C RID: 8508 RVA: 0x00059235 File Offset: 0x00057435
		[NullableContext(1)]
		public static AnimalCollectComponentPb Create()
		{
			return new AnimalCollectComponentPb();
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x0600213D RID: 8509 RVA: 0x0005923C File Offset: 0x0005743C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x0600213E RID: 8510 RVA: 0x0005923F File Offset: 0x0005743F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AnimalCollectComponentPb.Descriptor;
			}
		}

		// Token: 0x0600213F RID: 8511 RVA: 0x00059246 File Offset: 0x00057446
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimalCollectComponentPb()
		{
		}

		// Token: 0x06002140 RID: 8512 RVA: 0x00059259 File Offset: 0x00057459
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimalCollectComponentPb(AnimalCollectComponentPb other) : this()
		{
			this.partIds_ = other.partIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002141 RID: 8513 RVA: 0x00059283 File Offset: 0x00057483
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimalCollectComponentPb Clone()
		{
			return new AnimalCollectComponentPb(this);
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06002142 RID: 8514 RVA: 0x0005928B File Offset: 0x0005748B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PartIds
		{
			get
			{
				return this.partIds_;
			}
		}

		// Token: 0x06002143 RID: 8515 RVA: 0x00059293 File Offset: 0x00057493
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AnimalCollectComponentPb);
		}

		// Token: 0x06002144 RID: 8516 RVA: 0x000592A1 File Offset: 0x000574A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AnimalCollectComponentPb other)
		{
			return other != null && (other == this || (this.partIds_.Equals(other.partIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002145 RID: 8517 RVA: 0x000592D4 File Offset: 0x000574D4
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

		// Token: 0x06002146 RID: 8518 RVA: 0x00059308 File Offset: 0x00057508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002147 RID: 8519 RVA: 0x00059315 File Offset: 0x00057515
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002148 RID: 8520 RVA: 0x0005931E File Offset: 0x0005751E
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

		// Token: 0x06002149 RID: 8521 RVA: 0x00059348 File Offset: 0x00057548
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

		// Token: 0x0600214A RID: 8522 RVA: 0x00059381 File Offset: 0x00057581
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

		// Token: 0x0600214B RID: 8523 RVA: 0x000593AF File Offset: 0x000575AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600214C RID: 8524 RVA: 0x000593B8 File Offset: 0x000575B8
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

		// Token: 0x04002430 RID: 9264
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002431 RID: 9265
		public const int PartIdsFieldNumber = 1;

		// Token: 0x04002432 RID: 9266
		private static readonly FieldCodec<int> _repeated_partIds_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04002433 RID: 9267
		private readonly RepeatedField<int> partIds_ = new RepeatedField<int>();
	}
}
