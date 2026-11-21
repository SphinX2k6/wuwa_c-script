using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000656 RID: 1622
	public sealed class FsmCustomBlackboardDatas : IMessage<FsmCustomBlackboardDatas>, IMessage, IEquatable<FsmCustomBlackboardDatas>, IDeepCloneable<FsmCustomBlackboardDatas>, IBufferMessage
	{
		// Token: 0x0600954F RID: 38223 RVA: 0x00168C47 File Offset: 0x00166E47
		[NullableContext(1)]
		public static FsmCustomBlackboardDatas Create()
		{
			return new FsmCustomBlackboardDatas();
		}

		// Token: 0x17001DB6 RID: 7606
		// (get) Token: 0x06009550 RID: 38224 RVA: 0x00168C4E File Offset: 0x00166E4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001DB7 RID: 7607
		// (get) Token: 0x06009551 RID: 38225 RVA: 0x00168C51 File Offset: 0x00166E51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FsmCustomBlackboardDatas.Descriptor;
			}
		}

		// Token: 0x06009552 RID: 38226 RVA: 0x00168C58 File Offset: 0x00166E58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmCustomBlackboardDatas()
		{
		}

		// Token: 0x06009553 RID: 38227 RVA: 0x00168C6B File Offset: 0x00166E6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmCustomBlackboardDatas(FsmCustomBlackboardDatas other) : this()
		{
			this.blackboardIntValues_ = other.blackboardIntValues_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009554 RID: 38228 RVA: 0x00168C95 File Offset: 0x00166E95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmCustomBlackboardDatas Clone()
		{
			return new FsmCustomBlackboardDatas(this);
		}

		// Token: 0x17001DB8 RID: 7608
		// (get) Token: 0x06009555 RID: 38229 RVA: 0x00168C9D File Offset: 0x00166E9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DFsmBlackboardCustom> BlackboardIntValues
		{
			get
			{
				return this.blackboardIntValues_;
			}
		}

		// Token: 0x06009556 RID: 38230 RVA: 0x00168CA5 File Offset: 0x00166EA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FsmCustomBlackboardDatas);
		}

		// Token: 0x06009557 RID: 38231 RVA: 0x00168CB3 File Offset: 0x00166EB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FsmCustomBlackboardDatas other)
		{
			return other != null && (other == this || (this.blackboardIntValues_.Equals(other.blackboardIntValues_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009558 RID: 38232 RVA: 0x00168CE8 File Offset: 0x00166EE8
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

		// Token: 0x06009559 RID: 38233 RVA: 0x00168D1C File Offset: 0x00166F1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600955A RID: 38234 RVA: 0x00168D29 File Offset: 0x00166F29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600955B RID: 38235 RVA: 0x00168D32 File Offset: 0x00166F32
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

		// Token: 0x0600955C RID: 38236 RVA: 0x00168D5C File Offset: 0x00166F5C
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

		// Token: 0x0600955D RID: 38237 RVA: 0x00168D95 File Offset: 0x00166F95
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

		// Token: 0x0600955E RID: 38238 RVA: 0x00168DC3 File Offset: 0x00166FC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600955F RID: 38239 RVA: 0x00168DCC File Offset: 0x00166FCC
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

		// Token: 0x040047BB RID: 18363
		private UnknownFieldSet _unknownFields;

		// Token: 0x040047BC RID: 18364
		public const int BlackboardIntValuesFieldNumber = 1;

		// Token: 0x040047BD RID: 18365
		private static readonly FieldCodec<DFsmBlackboardCustom> _repeated_blackboardIntValues_codec = FieldCodec.ForMessage<DFsmBlackboardCustom>(10U, DFsmBlackboardCustom.Parser);

		// Token: 0x040047BE RID: 18366
		private readonly RepeatedField<DFsmBlackboardCustom> blackboardIntValues_ = new RepeatedField<DFsmBlackboardCustom>();
	}
}
