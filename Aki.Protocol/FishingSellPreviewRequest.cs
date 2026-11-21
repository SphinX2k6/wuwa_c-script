using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000564 RID: 1380
	[NetMessage(EMessageId.FishingSellPreviewRequest)]
	public sealed class FishingSellPreviewRequest : IMessage<FishingSellPreviewRequest>, IMessage, IEquatable<FishingSellPreviewRequest>, IDeepCloneable<FishingSellPreviewRequest>, IBufferMessage
	{
		// Token: 0x060080DC RID: 32988 RVA: 0x00137A0B File Offset: 0x00135C0B
		[NullableContext(1)]
		public static FishingSellPreviewRequest Create()
		{
			return new FishingSellPreviewRequest();
		}

		// Token: 0x17001918 RID: 6424
		// (get) Token: 0x060080DD RID: 32989 RVA: 0x00137A12 File Offset: 0x00135C12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001919 RID: 6425
		// (get) Token: 0x060080DE RID: 32990 RVA: 0x00137A15 File Offset: 0x00135C15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingSellPreviewRequest.Descriptor;
			}
		}

		// Token: 0x060080DF RID: 32991 RVA: 0x00137A1C File Offset: 0x00135C1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSellPreviewRequest()
		{
		}

		// Token: 0x060080E0 RID: 32992 RVA: 0x00137A2F File Offset: 0x00135C2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSellPreviewRequest(FishingSellPreviewRequest other) : this()
		{
			this.incrIds_ = other.incrIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060080E1 RID: 32993 RVA: 0x00137A59 File Offset: 0x00135C59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSellPreviewRequest Clone()
		{
			return new FishingSellPreviewRequest(this);
		}

		// Token: 0x1700191A RID: 6426
		// (get) Token: 0x060080E2 RID: 32994 RVA: 0x00137A61 File Offset: 0x00135C61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> IncrIds
		{
			get
			{
				return this.incrIds_;
			}
		}

		// Token: 0x060080E3 RID: 32995 RVA: 0x00137A69 File Offset: 0x00135C69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingSellPreviewRequest);
		}

		// Token: 0x060080E4 RID: 32996 RVA: 0x00137A77 File Offset: 0x00135C77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingSellPreviewRequest other)
		{
			return other != null && (other == this || (this.incrIds_.Equals(other.incrIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060080E5 RID: 32997 RVA: 0x00137AAC File Offset: 0x00135CAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.incrIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060080E6 RID: 32998 RVA: 0x00137AE0 File Offset: 0x00135CE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060080E7 RID: 32999 RVA: 0x00137AED File Offset: 0x00135CED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060080E8 RID: 33000 RVA: 0x00137AF6 File Offset: 0x00135CF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.incrIds_.WriteTo(ref output, FishingSellPreviewRequest._repeated_incrIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060080E9 RID: 33001 RVA: 0x00137B20 File Offset: 0x00135D20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.incrIds_.CalculateSize(FishingSellPreviewRequest._repeated_incrIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060080EA RID: 33002 RVA: 0x00137B59 File Offset: 0x00135D59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingSellPreviewRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.incrIds_.Add(other.incrIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060080EB RID: 33003 RVA: 0x00137B87 File Offset: 0x00135D87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060080EC RID: 33004 RVA: 0x00137B90 File Offset: 0x00135D90
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
					this.incrIds_.AddEntriesFrom(ref input, FishingSellPreviewRequest._repeated_incrIds_codec);
				}
			}
		}

		// Token: 0x0400412B RID: 16683
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400412C RID: 16684
		public const int IncrIdsFieldNumber = 15;

		// Token: 0x0400412D RID: 16685
		private static readonly FieldCodec<int> _repeated_incrIds_codec = FieldCodec.ForInt32(122U);

		// Token: 0x0400412E RID: 16686
		private readonly RepeatedField<int> incrIds_ = new RepeatedField<int>();
	}
}
