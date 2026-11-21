using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001CA RID: 458
	[NetMessage(EMessageId.BossPilingLevelInfoUpdateNotify)]
	public sealed class BossPilingLevelInfoUpdateNotify : IMessage<BossPilingLevelInfoUpdateNotify>, IMessage, IEquatable<BossPilingLevelInfoUpdateNotify>, IDeepCloneable<BossPilingLevelInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x060034A4 RID: 13476 RVA: 0x00085124 File Offset: 0x00083324
		[NullableContext(1)]
		public static BossPilingLevelInfoUpdateNotify Create()
		{
			return new BossPilingLevelInfoUpdateNotify();
		}

		// Token: 0x17000859 RID: 2137
		// (get) Token: 0x060034A5 RID: 13477 RVA: 0x0008512B File Offset: 0x0008332B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700085A RID: 2138
		// (get) Token: 0x060034A6 RID: 13478 RVA: 0x0008512E File Offset: 0x0008332E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BossPilingLevelInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x060034A7 RID: 13479 RVA: 0x00085135 File Offset: 0x00083335
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossPilingLevelInfoUpdateNotify()
		{
		}

		// Token: 0x060034A8 RID: 13480 RVA: 0x00085148 File Offset: 0x00083348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossPilingLevelInfoUpdateNotify(BossPilingLevelInfoUpdateNotify other) : this()
		{
			this.bossPilingLevelInfo_ = other.bossPilingLevelInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060034A9 RID: 13481 RVA: 0x00085172 File Offset: 0x00083372
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossPilingLevelInfoUpdateNotify Clone()
		{
			return new BossPilingLevelInfoUpdateNotify(this);
		}

		// Token: 0x1700085B RID: 2139
		// (get) Token: 0x060034AA RID: 13482 RVA: 0x0008517A File Offset: 0x0008337A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BossPilingLevelInfo> BossPilingLevelInfo
		{
			get
			{
				return this.bossPilingLevelInfo_;
			}
		}

		// Token: 0x060034AB RID: 13483 RVA: 0x00085182 File Offset: 0x00083382
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BossPilingLevelInfoUpdateNotify);
		}

		// Token: 0x060034AC RID: 13484 RVA: 0x00085190 File Offset: 0x00083390
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BossPilingLevelInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.bossPilingLevelInfo_.Equals(other.bossPilingLevelInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060034AD RID: 13485 RVA: 0x000851C4 File Offset: 0x000833C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.bossPilingLevelInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060034AE RID: 13486 RVA: 0x000851F8 File Offset: 0x000833F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060034AF RID: 13487 RVA: 0x00085205 File Offset: 0x00083405
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060034B0 RID: 13488 RVA: 0x0008520E File Offset: 0x0008340E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.bossPilingLevelInfo_.WriteTo(ref output, BossPilingLevelInfoUpdateNotify._repeated_bossPilingLevelInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060034B1 RID: 13489 RVA: 0x00085238 File Offset: 0x00083438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.bossPilingLevelInfo_.CalculateSize(BossPilingLevelInfoUpdateNotify._repeated_bossPilingLevelInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060034B2 RID: 13490 RVA: 0x00085271 File Offset: 0x00083471
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BossPilingLevelInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.bossPilingLevelInfo_.Add(other.bossPilingLevelInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060034B3 RID: 13491 RVA: 0x0008529F File Offset: 0x0008349F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060034B4 RID: 13492 RVA: 0x000852A8 File Offset: 0x000834A8
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
				if (num != 90U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.bossPilingLevelInfo_.AddEntriesFrom(ref input, BossPilingLevelInfoUpdateNotify._repeated_bossPilingLevelInfo_codec);
				}
			}
		}

		// Token: 0x04002A6C RID: 10860
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002A6D RID: 10861
		public const int BossPilingLevelInfoFieldNumber = 11;

		// Token: 0x04002A6E RID: 10862
		private static readonly FieldCodec<BossPilingLevelInfo> _repeated_bossPilingLevelInfo_codec = FieldCodec.ForMessage<BossPilingLevelInfo>(90U, Aki.Protocol.BossPilingLevelInfo.Parser);

		// Token: 0x04002A6F RID: 10863
		private readonly RepeatedField<BossPilingLevelInfo> bossPilingLevelInfo_ = new RepeatedField<BossPilingLevelInfo>();
	}
}
