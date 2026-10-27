using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000675 RID: 1653
	[NetMessage(EMessageId.FuncOpenNotify)]
	public sealed class FuncOpenNotify : IMessage<FuncOpenNotify>, IMessage, IEquatable<FuncOpenNotify>, IDeepCloneable<FuncOpenNotify>, IBufferMessage
	{
		// Token: 0x0600978F RID: 38799 RVA: 0x0016D949 File Offset: 0x0016BB49
		[NullableContext(1)]
		public static FuncOpenNotify Create()
		{
			return new FuncOpenNotify();
		}

		// Token: 0x17001E33 RID: 7731
		// (get) Token: 0x06009790 RID: 38800 RVA: 0x0016D950 File Offset: 0x0016BB50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001E34 RID: 7732
		// (get) Token: 0x06009791 RID: 38801 RVA: 0x0016D953 File Offset: 0x0016BB53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FuncOpenNotify.Descriptor;
			}
		}

		// Token: 0x06009792 RID: 38802 RVA: 0x0016D95A File Offset: 0x0016BB5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FuncOpenNotify()
		{
		}

		// Token: 0x06009793 RID: 38803 RVA: 0x0016D96D File Offset: 0x0016BB6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FuncOpenNotify(FuncOpenNotify other) : this()
		{
			this.func_ = other.func_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009794 RID: 38804 RVA: 0x0016D997 File Offset: 0x0016BB97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FuncOpenNotify Clone()
		{
			return new FuncOpenNotify(this);
		}

		// Token: 0x17001E35 RID: 7733
		// (get) Token: 0x06009795 RID: 38805 RVA: 0x0016D99F File Offset: 0x0016BB9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Function> Func
		{
			get
			{
				return this.func_;
			}
		}

		// Token: 0x06009796 RID: 38806 RVA: 0x0016D9A7 File Offset: 0x0016BBA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FuncOpenNotify);
		}

		// Token: 0x06009797 RID: 38807 RVA: 0x0016D9B5 File Offset: 0x0016BBB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FuncOpenNotify other)
		{
			return other != null && (other == this || (this.func_.Equals(other.func_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009798 RID: 38808 RVA: 0x0016D9E8 File Offset: 0x0016BBE8
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

		// Token: 0x06009799 RID: 38809 RVA: 0x0016DA1C File Offset: 0x0016BC1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600979A RID: 38810 RVA: 0x0016DA29 File Offset: 0x0016BC29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600979B RID: 38811 RVA: 0x0016DA32 File Offset: 0x0016BC32
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

		// Token: 0x0600979C RID: 38812 RVA: 0x0016DA5C File Offset: 0x0016BC5C
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

		// Token: 0x0600979D RID: 38813 RVA: 0x0016DA95 File Offset: 0x0016BC95
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

		// Token: 0x0600979E RID: 38814 RVA: 0x0016DAC3 File Offset: 0x0016BCC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600979F RID: 38815 RVA: 0x0016DACC File Offset: 0x0016BCCC
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
				if (num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.func_.AddEntriesFrom(ref input, FuncOpenNotify._repeated_func_codec);
				}
			}
		}

		// Token: 0x04004808 RID: 18440
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004809 RID: 18441
		public const int FuncFieldNumber = 14;

		// Token: 0x0400480A RID: 18442
		private static readonly FieldCodec<Function> _repeated_func_codec = FieldCodec.ForMessage<Function>(114U, Function.Parser);

		// Token: 0x0400480B RID: 18443
		private readonly RepeatedField<Function> func_ = new RepeatedField<Function>();
	}
}
