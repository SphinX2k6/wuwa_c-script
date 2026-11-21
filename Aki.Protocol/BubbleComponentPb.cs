using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001FB RID: 507
	public sealed class BubbleComponentPb : IMessage<BubbleComponentPb>, IMessage, IEquatable<BubbleComponentPb>, IDeepCloneable<BubbleComponentPb>, IBufferMessage
	{
		// Token: 0x06003890 RID: 14480 RVA: 0x0008DB73 File Offset: 0x0008BD73
		[NullableContext(1)]
		public static BubbleComponentPb Create()
		{
			return new BubbleComponentPb();
		}

		// Token: 0x1700092E RID: 2350
		// (get) Token: 0x06003891 RID: 14481 RVA: 0x0008DB7A File Offset: 0x0008BD7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700092F RID: 2351
		// (get) Token: 0x06003892 RID: 14482 RVA: 0x0008DB7D File Offset: 0x0008BD7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BubbleComponentPb.Descriptor;
			}
		}

		// Token: 0x06003893 RID: 14483 RVA: 0x0008DB84 File Offset: 0x0008BD84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BubbleComponentPb()
		{
		}

		// Token: 0x06003894 RID: 14484 RVA: 0x0008DB97 File Offset: 0x0008BD97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BubbleComponentPb(BubbleComponentPb other) : this()
		{
			this.bubbleInfos_ = other.bubbleInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003895 RID: 14485 RVA: 0x0008DBC1 File Offset: 0x0008BDC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BubbleComponentPb Clone()
		{
			return new BubbleComponentPb(this);
		}

		// Token: 0x17000930 RID: 2352
		// (get) Token: 0x06003896 RID: 14486 RVA: 0x0008DBC9 File Offset: 0x0008BDC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BubbleInfo> BubbleInfos
		{
			get
			{
				return this.bubbleInfos_;
			}
		}

		// Token: 0x06003897 RID: 14487 RVA: 0x0008DBD1 File Offset: 0x0008BDD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BubbleComponentPb);
		}

		// Token: 0x06003898 RID: 14488 RVA: 0x0008DBDF File Offset: 0x0008BDDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BubbleComponentPb other)
		{
			return other != null && (other == this || (this.bubbleInfos_.Equals(other.bubbleInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003899 RID: 14489 RVA: 0x0008DC14 File Offset: 0x0008BE14
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

		// Token: 0x0600389A RID: 14490 RVA: 0x0008DC48 File Offset: 0x0008BE48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600389B RID: 14491 RVA: 0x0008DC55 File Offset: 0x0008BE55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600389C RID: 14492 RVA: 0x0008DC5E File Offset: 0x0008BE5E
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

		// Token: 0x0600389D RID: 14493 RVA: 0x0008DC88 File Offset: 0x0008BE88
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

		// Token: 0x0600389E RID: 14494 RVA: 0x0008DCC1 File Offset: 0x0008BEC1
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

		// Token: 0x0600389F RID: 14495 RVA: 0x0008DCEF File Offset: 0x0008BEEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060038A0 RID: 14496 RVA: 0x0008DCF8 File Offset: 0x0008BEF8
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

		// Token: 0x04002B94 RID: 11156
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002B95 RID: 11157
		public const int BubbleInfosFieldNumber = 1;

		// Token: 0x04002B96 RID: 11158
		private static readonly FieldCodec<BubbleInfo> _repeated_bubbleInfos_codec = FieldCodec.ForMessage<BubbleInfo>(10U, BubbleInfo.Parser);

		// Token: 0x04002B97 RID: 11159
		private readonly RepeatedField<BubbleInfo> bubbleInfos_ = new RepeatedField<BubbleInfo>();
	}
}
