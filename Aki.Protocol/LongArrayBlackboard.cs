using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200094E RID: 2382
	public sealed class LongArrayBlackboard : IMessage<LongArrayBlackboard>, IMessage, IEquatable<LongArrayBlackboard>, IDeepCloneable<LongArrayBlackboard>, IBufferMessage
	{
		// Token: 0x0600D1FC RID: 53756 RVA: 0x001EF375 File Offset: 0x001ED575
		[NullableContext(1)]
		public static LongArrayBlackboard Create()
		{
			return new LongArrayBlackboard();
		}

		// Token: 0x17002A80 RID: 10880
		// (get) Token: 0x0600D1FD RID: 53757 RVA: 0x001EF37C File Offset: 0x001ED57C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002A81 RID: 10881
		// (get) Token: 0x0600D1FE RID: 53758 RVA: 0x001EF37F File Offset: 0x001ED57F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LongArrayBlackboard.Descriptor;
			}
		}

		// Token: 0x0600D1FF RID: 53759 RVA: 0x001EF386 File Offset: 0x001ED586
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LongArrayBlackboard()
		{
		}

		// Token: 0x0600D200 RID: 53760 RVA: 0x001EF399 File Offset: 0x001ED599
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LongArrayBlackboard(LongArrayBlackboard other) : this()
		{
			this.values_ = other.values_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D201 RID: 53761 RVA: 0x001EF3C3 File Offset: 0x001ED5C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LongArrayBlackboard Clone()
		{
			return new LongArrayBlackboard(this);
		}

		// Token: 0x17002A82 RID: 10882
		// (get) Token: 0x0600D202 RID: 53762 RVA: 0x001EF3CB File Offset: 0x001ED5CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> Values
		{
			get
			{
				return this.values_;
			}
		}

		// Token: 0x0600D203 RID: 53763 RVA: 0x001EF3D3 File Offset: 0x001ED5D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LongArrayBlackboard);
		}

		// Token: 0x0600D204 RID: 53764 RVA: 0x001EF3E1 File Offset: 0x001ED5E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LongArrayBlackboard other)
		{
			return other != null && (other == this || (this.values_.Equals(other.values_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D205 RID: 53765 RVA: 0x001EF414 File Offset: 0x001ED614
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

		// Token: 0x0600D206 RID: 53766 RVA: 0x001EF448 File Offset: 0x001ED648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D207 RID: 53767 RVA: 0x001EF455 File Offset: 0x001ED655
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D208 RID: 53768 RVA: 0x001EF45E File Offset: 0x001ED65E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.values_.WriteTo(ref output, LongArrayBlackboard._repeated_values_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D209 RID: 53769 RVA: 0x001EF488 File Offset: 0x001ED688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.values_.CalculateSize(LongArrayBlackboard._repeated_values_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D20A RID: 53770 RVA: 0x001EF4C1 File Offset: 0x001ED6C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LongArrayBlackboard other)
		{
			if (other == null)
			{
				return;
			}
			this.values_.Add(other.values_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D20B RID: 53771 RVA: 0x001EF4EF File Offset: 0x001ED6EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D20C RID: 53772 RVA: 0x001EF4F8 File Offset: 0x001ED6F8
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
				if (num != 8U && num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.values_.AddEntriesFrom(ref input, LongArrayBlackboard._repeated_values_codec);
				}
			}
		}

		// Token: 0x04005864 RID: 22628
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005865 RID: 22629
		public const int ValuesFieldNumber = 1;

		// Token: 0x04005866 RID: 22630
		private static readonly FieldCodec<long> _repeated_values_codec = FieldCodec.ForInt64(10U);

		// Token: 0x04005867 RID: 22631
		private readonly RepeatedField<long> values_ = new RepeatedField<long>();
	}
}
