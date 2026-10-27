using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200066A RID: 1642
	public sealed class FsmCustomBlackboardDatas : IMessage<FsmCustomBlackboardDatas>, IMessage, IEquatable<FsmCustomBlackboardDatas>, IDeepCloneable<FsmCustomBlackboardDatas>, IBufferMessage
	{
		// Token: 0x060096A5 RID: 38565 RVA: 0x0016B66F File Offset: 0x0016986F
		[NullableContext(1)]
		public static FsmCustomBlackboardDatas Create()
		{
			return new FsmCustomBlackboardDatas();
		}

		// Token: 0x17001E00 RID: 7680
		// (get) Token: 0x060096A6 RID: 38566 RVA: 0x0016B676 File Offset: 0x00169876
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001E01 RID: 7681
		// (get) Token: 0x060096A7 RID: 38567 RVA: 0x0016B679 File Offset: 0x00169879
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FsmCustomBlackboardDatas.Descriptor;
			}
		}

		// Token: 0x060096A8 RID: 38568 RVA: 0x0016B680 File Offset: 0x00169880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmCustomBlackboardDatas()
		{
		}

		// Token: 0x060096A9 RID: 38569 RVA: 0x0016B693 File Offset: 0x00169893
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmCustomBlackboardDatas(FsmCustomBlackboardDatas other) : this()
		{
			this.blackboardIntValues_ = other.blackboardIntValues_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060096AA RID: 38570 RVA: 0x0016B6BD File Offset: 0x001698BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmCustomBlackboardDatas Clone()
		{
			return new FsmCustomBlackboardDatas(this);
		}

		// Token: 0x17001E02 RID: 7682
		// (get) Token: 0x060096AB RID: 38571 RVA: 0x0016B6C5 File Offset: 0x001698C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DFsmBlackboardCustom> BlackboardIntValues
		{
			get
			{
				return this.blackboardIntValues_;
			}
		}

		// Token: 0x060096AC RID: 38572 RVA: 0x0016B6CD File Offset: 0x001698CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FsmCustomBlackboardDatas);
		}

		// Token: 0x060096AD RID: 38573 RVA: 0x0016B6DB File Offset: 0x001698DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FsmCustomBlackboardDatas other)
		{
			return other != null && (other == this || (this.blackboardIntValues_.Equals(other.blackboardIntValues_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060096AE RID: 38574 RVA: 0x0016B710 File Offset: 0x00169910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.blackboardIntValues_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060096AF RID: 38575 RVA: 0x0016B744 File Offset: 0x00169944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060096B0 RID: 38576 RVA: 0x0016B751 File Offset: 0x00169951
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060096B1 RID: 38577 RVA: 0x0016B75A File Offset: 0x0016995A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.blackboardIntValues_.WriteTo(ref output, FsmCustomBlackboardDatas._repeated_blackboardIntValues_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060096B2 RID: 38578 RVA: 0x0016B784 File Offset: 0x00169984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.blackboardIntValues_.CalculateSize(FsmCustomBlackboardDatas._repeated_blackboardIntValues_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060096B3 RID: 38579 RVA: 0x0016B7BD File Offset: 0x001699BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FsmCustomBlackboardDatas other)
		{
			if (other == null)
			{
				return;
			}
			this.blackboardIntValues_.Add(other.blackboardIntValues_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060096B4 RID: 38580 RVA: 0x0016B7EB File Offset: 0x001699EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060096B5 RID: 38581 RVA: 0x0016B7F4 File Offset: 0x001699F4
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
					this.blackboardIntValues_.AddEntriesFrom(ref input, FsmCustomBlackboardDatas._repeated_blackboardIntValues_codec);
				}
			}
		}

		// Token: 0x040047C2 RID: 18370
		private UnknownFieldSet _unknownFields;

		// Token: 0x040047C3 RID: 18371
		public const int BlackboardIntValuesFieldNumber = 1;

		// Token: 0x040047C4 RID: 18372
		private static readonly FieldCodec<DFsmBlackboardCustom> _repeated_blackboardIntValues_codec = FieldCodec.ForMessage<DFsmBlackboardCustom>(10U, DFsmBlackboardCustom.Parser);

		// Token: 0x040047C5 RID: 18373
		private readonly RepeatedField<DFsmBlackboardCustom> blackboardIntValues_ = new RepeatedField<DFsmBlackboardCustom>();
	}
}
