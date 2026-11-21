using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200058F RID: 1423
	public sealed class FloatArrayBlackboard : IMessage<FloatArrayBlackboard>, IMessage, IEquatable<FloatArrayBlackboard>, IDeepCloneable<FloatArrayBlackboard>, IBufferMessage
	{
		// Token: 0x06008423 RID: 33827 RVA: 0x0013E3BE File Offset: 0x0013C5BE
		[NullableContext(1)]
		public static FloatArrayBlackboard Create()
		{
			return new FloatArrayBlackboard();
		}

		// Token: 0x170019BB RID: 6587
		// (get) Token: 0x06008424 RID: 33828 RVA: 0x0013E3C5 File Offset: 0x0013C5C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170019BC RID: 6588
		// (get) Token: 0x06008425 RID: 33829 RVA: 0x0013E3C8 File Offset: 0x0013C5C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloatArrayBlackboard.Descriptor;
			}
		}

		// Token: 0x06008426 RID: 33830 RVA: 0x0013E3CF File Offset: 0x0013C5CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloatArrayBlackboard()
		{
		}

		// Token: 0x06008427 RID: 33831 RVA: 0x0013E3E2 File Offset: 0x0013C5E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloatArrayBlackboard(FloatArrayBlackboard other) : this()
		{
			this.values_ = other.values_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008428 RID: 33832 RVA: 0x0013E40C File Offset: 0x0013C60C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloatArrayBlackboard Clone()
		{
			return new FloatArrayBlackboard(this);
		}

		// Token: 0x170019BD RID: 6589
		// (get) Token: 0x06008429 RID: 33833 RVA: 0x0013E414 File Offset: 0x0013C614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<float> Values
		{
			get
			{
				return this.values_;
			}
		}

		// Token: 0x0600842A RID: 33834 RVA: 0x0013E41C File Offset: 0x0013C61C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloatArrayBlackboard);
		}

		// Token: 0x0600842B RID: 33835 RVA: 0x0013E42A File Offset: 0x0013C62A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloatArrayBlackboard other)
		{
			return other != null && (other == this || (this.values_.Equals(other.values_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600842C RID: 33836 RVA: 0x0013E460 File Offset: 0x0013C660
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

		// Token: 0x0600842D RID: 33837 RVA: 0x0013E494 File Offset: 0x0013C694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600842E RID: 33838 RVA: 0x0013E4A1 File Offset: 0x0013C6A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600842F RID: 33839 RVA: 0x0013E4AA File Offset: 0x0013C6AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.values_.WriteTo(ref output, FloatArrayBlackboard._repeated_values_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008430 RID: 33840 RVA: 0x0013E4D4 File Offset: 0x0013C6D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.values_.CalculateSize(FloatArrayBlackboard._repeated_values_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008431 RID: 33841 RVA: 0x0013E50D File Offset: 0x0013C70D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloatArrayBlackboard other)
		{
			if (other == null)
			{
				return;
			}
			this.values_.Add(other.values_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008432 RID: 33842 RVA: 0x0013E53B File Offset: 0x0013C73B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008433 RID: 33843 RVA: 0x0013E544 File Offset: 0x0013C744
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
				if (num != 10U && num != 13U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.values_.AddEntriesFrom(ref input, FloatArrayBlackboard._repeated_values_codec);
				}
			}
		}

		// Token: 0x040041FA RID: 16890
		private UnknownFieldSet _unknownFields;

		// Token: 0x040041FB RID: 16891
		public const int ValuesFieldNumber = 1;

		// Token: 0x040041FC RID: 16892
		private static readonly FieldCodec<float> _repeated_values_codec = FieldCodec.ForFloat(10U);

		// Token: 0x040041FD RID: 16893
		private readonly RepeatedField<float> values_ = new RepeatedField<float>();
	}
}
