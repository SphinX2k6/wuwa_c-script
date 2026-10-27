using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001F6 RID: 502
	public sealed class BubbleComponentPb : IMessage<BubbleComponentPb>, IMessage, IEquatable<BubbleComponentPb>, IDeepCloneable<BubbleComponentPb>, IBufferMessage
	{
		// Token: 0x060037EB RID: 14315 RVA: 0x0008BF63 File Offset: 0x0008A163
		[NullableContext(1)]
		public static BubbleComponentPb Create()
		{
			return new BubbleComponentPb();
		}

		// Token: 0x1700090F RID: 2319
		// (get) Token: 0x060037EC RID: 14316 RVA: 0x0008BF6A File Offset: 0x0008A16A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000910 RID: 2320
		// (get) Token: 0x060037ED RID: 14317 RVA: 0x0008BF6D File Offset: 0x0008A16D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BubbleComponentPb.Descriptor;
			}
		}

		// Token: 0x060037EE RID: 14318 RVA: 0x0008BF74 File Offset: 0x0008A174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BubbleComponentPb()
		{
		}

		// Token: 0x060037EF RID: 14319 RVA: 0x0008BF87 File Offset: 0x0008A187
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BubbleComponentPb(BubbleComponentPb other) : this()
		{
			this.bubbleInfos_ = other.bubbleInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060037F0 RID: 14320 RVA: 0x0008BFB1 File Offset: 0x0008A1B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BubbleComponentPb Clone()
		{
			return new BubbleComponentPb(this);
		}

		// Token: 0x17000911 RID: 2321
		// (get) Token: 0x060037F1 RID: 14321 RVA: 0x0008BFB9 File Offset: 0x0008A1B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BubbleInfo> BubbleInfos
		{
			get
			{
				return this.bubbleInfos_;
			}
		}

		// Token: 0x060037F2 RID: 14322 RVA: 0x0008BFC1 File Offset: 0x0008A1C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BubbleComponentPb);
		}

		// Token: 0x060037F3 RID: 14323 RVA: 0x0008BFCF File Offset: 0x0008A1CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BubbleComponentPb other)
		{
			return other != null && (other == this || (this.bubbleInfos_.Equals(other.bubbleInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060037F4 RID: 14324 RVA: 0x0008C004 File Offset: 0x0008A204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.bubbleInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060037F5 RID: 14325 RVA: 0x0008C038 File Offset: 0x0008A238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060037F6 RID: 14326 RVA: 0x0008C045 File Offset: 0x0008A245
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060037F7 RID: 14327 RVA: 0x0008C04E File Offset: 0x0008A24E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.bubbleInfos_.WriteTo(ref output, BubbleComponentPb._repeated_bubbleInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060037F8 RID: 14328 RVA: 0x0008C078 File Offset: 0x0008A278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.bubbleInfos_.CalculateSize(BubbleComponentPb._repeated_bubbleInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060037F9 RID: 14329 RVA: 0x0008C0B1 File Offset: 0x0008A2B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BubbleComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			this.bubbleInfos_.Add(other.bubbleInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060037FA RID: 14330 RVA: 0x0008C0DF File Offset: 0x0008A2DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060037FB RID: 14331 RVA: 0x0008C0E8 File Offset: 0x0008A2E8
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.bubbleInfos_.AddEntriesFrom(ref input, BubbleComponentPb._repeated_bubbleInfos_codec);
				}
			}
		}

		// Token: 0x04002B12 RID: 11026
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002B13 RID: 11027
		public const int BubbleInfosFieldNumber = 1;

		// Token: 0x04002B14 RID: 11028
		private static readonly FieldCodec<BubbleInfo> _repeated_bubbleInfos_codec = FieldCodec.ForMessage<BubbleInfo>(10U, BubbleInfo.Parser);

		// Token: 0x04002B15 RID: 11029
		private readonly RepeatedField<BubbleInfo> bubbleInfos_ = new RepeatedField<BubbleInfo>();
	}
}
