using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C93 RID: 3219
	[NetMessage(EMessageId.PhantomBattleHandCardInfoUpdateNotify)]
	public sealed class PhantomBattleHandCardInfoUpdateNotify : IMessage<PhantomBattleHandCardInfoUpdateNotify>, IMessage, IEquatable<PhantomBattleHandCardInfoUpdateNotify>, IDeepCloneable<PhantomBattleHandCardInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x06011732 RID: 71474 RVA: 0x0028EA06 File Offset: 0x0028CC06
		[NullableContext(1)]
		public static PhantomBattleHandCardInfoUpdateNotify Create()
		{
			return new PhantomBattleHandCardInfoUpdateNotify();
		}

		// Token: 0x170039CE RID: 14798
		// (get) Token: 0x06011733 RID: 71475 RVA: 0x0028EA0D File Offset: 0x0028CC0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170039CF RID: 14799
		// (get) Token: 0x06011734 RID: 71476 RVA: 0x0028EA10 File Offset: 0x0028CC10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleHandCardInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06011735 RID: 71477 RVA: 0x0028EA17 File Offset: 0x0028CC17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleHandCardInfoUpdateNotify()
		{
		}

		// Token: 0x06011736 RID: 71478 RVA: 0x0028EA2A File Offset: 0x0028CC2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleHandCardInfoUpdateNotify(PhantomBattleHandCardInfoUpdateNotify other) : this()
		{
			this.phantomBattleHandCardInfo_ = other.phantomBattleHandCardInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011737 RID: 71479 RVA: 0x0028EA54 File Offset: 0x0028CC54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleHandCardInfoUpdateNotify Clone()
		{
			return new PhantomBattleHandCardInfoUpdateNotify(this);
		}

		// Token: 0x170039D0 RID: 14800
		// (get) Token: 0x06011738 RID: 71480 RVA: 0x0028EA5C File Offset: 0x0028CC5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleHandCardInfo> PhantomBattleHandCardInfo
		{
			get
			{
				return this.phantomBattleHandCardInfo_;
			}
		}

		// Token: 0x06011739 RID: 71481 RVA: 0x0028EA64 File Offset: 0x0028CC64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleHandCardInfoUpdateNotify);
		}

		// Token: 0x0601173A RID: 71482 RVA: 0x0028EA72 File Offset: 0x0028CC72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleHandCardInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.phantomBattleHandCardInfo_.Equals(other.phantomBattleHandCardInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601173B RID: 71483 RVA: 0x0028EAA8 File Offset: 0x0028CCA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.phantomBattleHandCardInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601173C RID: 71484 RVA: 0x0028EADC File Offset: 0x0028CCDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601173D RID: 71485 RVA: 0x0028EAE9 File Offset: 0x0028CCE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601173E RID: 71486 RVA: 0x0028EAF2 File Offset: 0x0028CCF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.phantomBattleHandCardInfo_.WriteTo(ref output, PhantomBattleHandCardInfoUpdateNotify._repeated_phantomBattleHandCardInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601173F RID: 71487 RVA: 0x0028EB1C File Offset: 0x0028CD1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.phantomBattleHandCardInfo_.CalculateSize(PhantomBattleHandCardInfoUpdateNotify._repeated_phantomBattleHandCardInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011740 RID: 71488 RVA: 0x0028EB55 File Offset: 0x0028CD55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleHandCardInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.phantomBattleHandCardInfo_.Add(other.phantomBattleHandCardInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011741 RID: 71489 RVA: 0x0028EB83 File Offset: 0x0028CD83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011742 RID: 71490 RVA: 0x0028EB8C File Offset: 0x0028CD8C
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
					this.phantomBattleHandCardInfo_.AddEntriesFrom(ref input, PhantomBattleHandCardInfoUpdateNotify._repeated_phantomBattleHandCardInfo_codec);
				}
			}
		}

		// Token: 0x04006E28 RID: 28200
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006E29 RID: 28201
		public const int PhantomBattleHandCardInfoFieldNumber = 4;

		// Token: 0x04006E2A RID: 28202
		private static readonly FieldCodec<PhantomBattleHandCardInfo> _repeated_phantomBattleHandCardInfo_codec = FieldCodec.ForMessage<PhantomBattleHandCardInfo>(34U, Aki.Protocol.PhantomBattleHandCardInfo.Parser);

		// Token: 0x04006E2B RID: 28203
		private readonly RepeatedField<PhantomBattleHandCardInfo> phantomBattleHandCardInfo_ = new RepeatedField<PhantomBattleHandCardInfo>();
	}
}
