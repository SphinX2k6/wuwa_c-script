using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Ai
{
	// Token: 0x020016B1 RID: 5809
	[NetMessage(EMessageId.AiHateRequest)]
	public sealed class AiHateRequest : IMessage<AiHateRequest>, IMessage, IEquatable<AiHateRequest>, IDeepCloneable<AiHateRequest>, IBufferMessage
	{
		// Token: 0x0601D1AD RID: 119213 RVA: 0x00442239 File Offset: 0x00440439
		[NullableContext(1)]
		public static AiHateRequest Create()
		{
			return new AiHateRequest();
		}

		// Token: 0x170062BD RID: 25277
		// (get) Token: 0x0601D1AE RID: 119214 RVA: 0x00442240 File Offset: 0x00440440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170062BE RID: 25278
		// (get) Token: 0x0601D1AF RID: 119215 RVA: 0x00442243 File Offset: 0x00440443
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AiHateRequest.Descriptor;
			}
		}

		// Token: 0x0601D1B0 RID: 119216 RVA: 0x0044224A File Offset: 0x0044044A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiHateRequest()
		{
		}

		// Token: 0x0601D1B1 RID: 119217 RVA: 0x0044225D File Offset: 0x0044045D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiHateRequest(AiHateRequest other) : this()
		{
			this.hateList_ = other.hateList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D1B2 RID: 119218 RVA: 0x00442287 File Offset: 0x00440487
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiHateRequest Clone()
		{
			return new AiHateRequest(this);
		}

		// Token: 0x170062BF RID: 25279
		// (get) Token: 0x0601D1B3 RID: 119219 RVA: 0x0044228F File Offset: 0x0044048F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AiHateEntity> HateList
		{
			get
			{
				return this.hateList_;
			}
		}

		// Token: 0x0601D1B4 RID: 119220 RVA: 0x00442297 File Offset: 0x00440497
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AiHateRequest);
		}

		// Token: 0x0601D1B5 RID: 119221 RVA: 0x004422A5 File Offset: 0x004404A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AiHateRequest other)
		{
			return other != null && (other == this || (this.hateList_.Equals(other.hateList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D1B6 RID: 119222 RVA: 0x004422D8 File Offset: 0x004404D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.hateList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601D1B7 RID: 119223 RVA: 0x0044230C File Offset: 0x0044050C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D1B8 RID: 119224 RVA: 0x00442319 File Offset: 0x00440519
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D1B9 RID: 119225 RVA: 0x00442322 File Offset: 0x00440522
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.hateList_.WriteTo(ref output, AiHateRequest._repeated_hateList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D1BA RID: 119226 RVA: 0x0044234C File Offset: 0x0044054C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.hateList_.CalculateSize(AiHateRequest._repeated_hateList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601D1BB RID: 119227 RVA: 0x00442385 File Offset: 0x00440585
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AiHateRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.hateList_.Add(other.hateList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D1BC RID: 119228 RVA: 0x004423B3 File Offset: 0x004405B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D1BD RID: 119229 RVA: 0x004423BC File Offset: 0x004405BC
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
				if (num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.hateList_.AddEntriesFrom(ref input, AiHateRequest._repeated_hateList_codec);
				}
			}
		}

		// Token: 0x0400C448 RID: 50248
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C449 RID: 50249
		public const int HateListFieldNumber = 4;

		// Token: 0x0400C44A RID: 50250
		private static readonly FieldCodec<AiHateEntity> _repeated_hateList_codec = FieldCodec.ForMessage<AiHateEntity>(34U, AiHateEntity.Parser);

		// Token: 0x0400C44B RID: 50251
		private readonly RepeatedField<AiHateEntity> hateList_ = new RepeatedField<AiHateEntity>();
	}
}
