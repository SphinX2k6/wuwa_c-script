using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000661 RID: 1633
	[NetMessage(EMessageId.FuncOpenNotify)]
	public sealed class FuncOpenNotify : IMessage<FuncOpenNotify>, IMessage, IEquatable<FuncOpenNotify>, IDeepCloneable<FuncOpenNotify>, IBufferMessage
	{
		// Token: 0x06009639 RID: 38457 RVA: 0x0016AF15 File Offset: 0x00169115
		[NullableContext(1)]
		public static FuncOpenNotify Create()
		{
			return new FuncOpenNotify();
		}

		// Token: 0x17001DE9 RID: 7657
		// (get) Token: 0x0600963A RID: 38458 RVA: 0x0016AF1C File Offset: 0x0016911C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001DEA RID: 7658
		// (get) Token: 0x0600963B RID: 38459 RVA: 0x0016AF1F File Offset: 0x0016911F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FuncOpenNotify.Descriptor;
			}
		}

		// Token: 0x0600963C RID: 38460 RVA: 0x0016AF26 File Offset: 0x00169126
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FuncOpenNotify()
		{
		}

		// Token: 0x0600963D RID: 38461 RVA: 0x0016AF39 File Offset: 0x00169139
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FuncOpenNotify(FuncOpenNotify other) : this()
		{
			this.func_ = other.func_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600963E RID: 38462 RVA: 0x0016AF63 File Offset: 0x00169163
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FuncOpenNotify Clone()
		{
			return new FuncOpenNotify(this);
		}

		// Token: 0x17001DEB RID: 7659
		// (get) Token: 0x0600963F RID: 38463 RVA: 0x0016AF6B File Offset: 0x0016916B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Function> Func
		{
			get
			{
				return this.func_;
			}
		}

		// Token: 0x06009640 RID: 38464 RVA: 0x0016AF73 File Offset: 0x00169173
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FuncOpenNotify);
		}

		// Token: 0x06009641 RID: 38465 RVA: 0x0016AF81 File Offset: 0x00169181
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FuncOpenNotify other)
		{
			return other != null && (other == this || (this.func_.Equals(other.func_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009642 RID: 38466 RVA: 0x0016AFB4 File Offset: 0x001691B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.func_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009643 RID: 38467 RVA: 0x0016AFE8 File Offset: 0x001691E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009644 RID: 38468 RVA: 0x0016AFF5 File Offset: 0x001691F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009645 RID: 38469 RVA: 0x0016AFFE File Offset: 0x001691FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.func_.WriteTo(ref output, FuncOpenNotify._repeated_func_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009646 RID: 38470 RVA: 0x0016B028 File Offset: 0x00169228
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.func_.CalculateSize(FuncOpenNotify._repeated_func_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009647 RID: 38471 RVA: 0x0016B061 File Offset: 0x00169261
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FuncOpenNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.func_.Add(other.func_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009648 RID: 38472 RVA: 0x0016B08F File Offset: 0x0016928F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009649 RID: 38473 RVA: 0x0016B098 File Offset: 0x00169298
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
				if (num != 26U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.func_.AddEntriesFrom(ref input, FuncOpenNotify._repeated_func_codec);
				}
			}
		}

		// Token: 0x04004801 RID: 18433
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004802 RID: 18434
		public const int FuncFieldNumber = 3;

		// Token: 0x04004803 RID: 18435
		private static readonly FieldCodec<Function> _repeated_func_codec = FieldCodec.ForMessage<Function>(26U, Function.Parser);

		// Token: 0x04004804 RID: 18436
		private readonly RepeatedField<Function> func_ = new RepeatedField<Function>();
	}
}
