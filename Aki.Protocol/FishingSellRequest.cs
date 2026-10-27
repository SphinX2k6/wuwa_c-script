using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200057B RID: 1403
	[NetMessage(EMessageId.FishingSellRequest)]
	public sealed class FishingSellRequest : IMessage<FishingSellRequest>, IMessage, IEquatable<FishingSellRequest>, IDeepCloneable<FishingSellRequest>, IBufferMessage
	{
		// Token: 0x0600826A RID: 33386 RVA: 0x0013AAAE File Offset: 0x00138CAE
		[NullableContext(1)]
		public static FishingSellRequest Create()
		{
			return new FishingSellRequest();
		}

		// Token: 0x1700196C RID: 6508
		// (get) Token: 0x0600826B RID: 33387 RVA: 0x0013AAB5 File Offset: 0x00138CB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700196D RID: 6509
		// (get) Token: 0x0600826C RID: 33388 RVA: 0x0013AAB8 File Offset: 0x00138CB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingSellRequest.Descriptor;
			}
		}

		// Token: 0x0600826D RID: 33389 RVA: 0x0013AABF File Offset: 0x00138CBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSellRequest()
		{
		}

		// Token: 0x0600826E RID: 33390 RVA: 0x0013AAD2 File Offset: 0x00138CD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSellRequest(FishingSellRequest other) : this()
		{
			this.incrIds_ = other.incrIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600826F RID: 33391 RVA: 0x0013AAFC File Offset: 0x00138CFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSellRequest Clone()
		{
			return new FishingSellRequest(this);
		}

		// Token: 0x1700196E RID: 6510
		// (get) Token: 0x06008270 RID: 33392 RVA: 0x0013AB04 File Offset: 0x00138D04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> IncrIds
		{
			get
			{
				return this.incrIds_;
			}
		}

		// Token: 0x06008271 RID: 33393 RVA: 0x0013AB0C File Offset: 0x00138D0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingSellRequest);
		}

		// Token: 0x06008272 RID: 33394 RVA: 0x0013AB1A File Offset: 0x00138D1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingSellRequest other)
		{
			return other != null && (other == this || (this.incrIds_.Equals(other.incrIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008273 RID: 33395 RVA: 0x0013AB50 File Offset: 0x00138D50
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

		// Token: 0x06008274 RID: 33396 RVA: 0x0013AB84 File Offset: 0x00138D84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008275 RID: 33397 RVA: 0x0013AB91 File Offset: 0x00138D91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008276 RID: 33398 RVA: 0x0013AB9A File Offset: 0x00138D9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.incrIds_.WriteTo(ref output, FishingSellRequest._repeated_incrIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008277 RID: 33399 RVA: 0x0013ABC4 File Offset: 0x00138DC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.incrIds_.CalculateSize(FishingSellRequest._repeated_incrIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008278 RID: 33400 RVA: 0x0013ABFD File Offset: 0x00138DFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingSellRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.incrIds_.Add(other.incrIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008279 RID: 33401 RVA: 0x0013AC2B File Offset: 0x00138E2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600827A RID: 33402 RVA: 0x0013AC34 File Offset: 0x00138E34
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
				if (num != 48U && num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.incrIds_.AddEntriesFrom(ref input, FishingSellRequest._repeated_incrIds_codec);
				}
			}
		}

		// Token: 0x0400413F RID: 16703
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004140 RID: 16704
		public const int IncrIdsFieldNumber = 6;

		// Token: 0x04004141 RID: 16705
		private static readonly FieldCodec<int> _repeated_incrIds_codec = FieldCodec.ForInt32(50U);

		// Token: 0x04004142 RID: 16706
		private readonly RepeatedField<int> incrIds_ = new RepeatedField<int>();
	}
}
