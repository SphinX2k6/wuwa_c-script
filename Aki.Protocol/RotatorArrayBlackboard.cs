using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010EE RID: 4334
	public sealed class RotatorArrayBlackboard : IMessage<RotatorArrayBlackboard>, IMessage, IEquatable<RotatorArrayBlackboard>, IDeepCloneable<RotatorArrayBlackboard>, IBufferMessage
	{
		// Token: 0x060171C5 RID: 94661 RVA: 0x0035A5CE File Offset: 0x003587CE
		[NullableContext(1)]
		public static RotatorArrayBlackboard Create()
		{
			return new RotatorArrayBlackboard();
		}

		// Token: 0x17004D65 RID: 19813
		// (get) Token: 0x060171C6 RID: 94662 RVA: 0x0035A5D5 File Offset: 0x003587D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004D66 RID: 19814
		// (get) Token: 0x060171C7 RID: 94663 RVA: 0x0035A5D8 File Offset: 0x003587D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RotatorArrayBlackboard.Descriptor;
			}
		}

		// Token: 0x060171C8 RID: 94664 RVA: 0x0035A5DF File Offset: 0x003587DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RotatorArrayBlackboard()
		{
		}

		// Token: 0x060171C9 RID: 94665 RVA: 0x0035A5F2 File Offset: 0x003587F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RotatorArrayBlackboard(RotatorArrayBlackboard other) : this()
		{
			this.values_ = other.values_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060171CA RID: 94666 RVA: 0x0035A61C File Offset: 0x0035881C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RotatorArrayBlackboard Clone()
		{
			return new RotatorArrayBlackboard(this);
		}

		// Token: 0x17004D67 RID: 19815
		// (get) Token: 0x060171CB RID: 94667 RVA: 0x0035A624 File Offset: 0x00358824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Rotator> Values
		{
			get
			{
				return this.values_;
			}
		}

		// Token: 0x060171CC RID: 94668 RVA: 0x0035A62C File Offset: 0x0035882C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RotatorArrayBlackboard);
		}

		// Token: 0x060171CD RID: 94669 RVA: 0x0035A63A File Offset: 0x0035883A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RotatorArrayBlackboard other)
		{
			return other != null && (other == this || (this.values_.Equals(other.values_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060171CE RID: 94670 RVA: 0x0035A670 File Offset: 0x00358870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.values_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060171CF RID: 94671 RVA: 0x0035A6A4 File Offset: 0x003588A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060171D0 RID: 94672 RVA: 0x0035A6B1 File Offset: 0x003588B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060171D1 RID: 94673 RVA: 0x0035A6BA File Offset: 0x003588BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.values_.WriteTo(ref output, RotatorArrayBlackboard._repeated_values_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060171D2 RID: 94674 RVA: 0x0035A6E4 File Offset: 0x003588E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.values_.CalculateSize(RotatorArrayBlackboard._repeated_values_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060171D3 RID: 94675 RVA: 0x0035A71D File Offset: 0x0035891D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RotatorArrayBlackboard other)
		{
			if (other == null)
			{
				return;
			}
			this.values_.Add(other.values_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060171D4 RID: 94676 RVA: 0x0035A74B File Offset: 0x0035894B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060171D5 RID: 94677 RVA: 0x0035A754 File Offset: 0x00358954
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
					this.values_.AddEntriesFrom(ref input, RotatorArrayBlackboard._repeated_values_codec);
				}
			}
		}

		// Token: 0x04008967 RID: 35175
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008968 RID: 35176
		public const int ValuesFieldNumber = 1;

		// Token: 0x04008969 RID: 35177
		private static readonly FieldCodec<Rotator> _repeated_values_codec = FieldCodec.ForMessage<Rotator>(10U, Rotator.Parser);

		// Token: 0x0400896A RID: 35178
		private readonly RepeatedField<Rotator> values_ = new RepeatedField<Rotator>();
	}
}
