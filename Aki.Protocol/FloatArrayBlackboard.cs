using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005A4 RID: 1444
	public sealed class FloatArrayBlackboard : IMessage<FloatArrayBlackboard>, IMessage, IEquatable<FloatArrayBlackboard>, IDeepCloneable<FloatArrayBlackboard>, IBufferMessage
	{
		// Token: 0x0600858B RID: 34187 RVA: 0x00140FC6 File Offset: 0x0013F1C6
		[NullableContext(1)]
		public static FloatArrayBlackboard Create()
		{
			return new FloatArrayBlackboard();
		}

		// Token: 0x17001A08 RID: 6664
		// (get) Token: 0x0600858C RID: 34188 RVA: 0x00140FCD File Offset: 0x0013F1CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001A09 RID: 6665
		// (get) Token: 0x0600858D RID: 34189 RVA: 0x00140FD0 File Offset: 0x0013F1D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloatArrayBlackboard.Descriptor;
			}
		}

		// Token: 0x0600858E RID: 34190 RVA: 0x00140FD7 File Offset: 0x0013F1D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloatArrayBlackboard()
		{
		}

		// Token: 0x0600858F RID: 34191 RVA: 0x00140FEA File Offset: 0x0013F1EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloatArrayBlackboard(FloatArrayBlackboard other) : this()
		{
			this.values_ = other.values_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008590 RID: 34192 RVA: 0x00141014 File Offset: 0x0013F214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloatArrayBlackboard Clone()
		{
			return new FloatArrayBlackboard(this);
		}

		// Token: 0x17001A0A RID: 6666
		// (get) Token: 0x06008591 RID: 34193 RVA: 0x0014101C File Offset: 0x0013F21C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<float> Values
		{
			get
			{
				return this.values_;
			}
		}

		// Token: 0x06008592 RID: 34194 RVA: 0x00141024 File Offset: 0x0013F224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloatArrayBlackboard);
		}

		// Token: 0x06008593 RID: 34195 RVA: 0x00141032 File Offset: 0x0013F232
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloatArrayBlackboard other)
		{
			return other != null && (other == this || (this.values_.Equals(other.values_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008594 RID: 34196 RVA: 0x00141068 File Offset: 0x0013F268
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

		// Token: 0x06008595 RID: 34197 RVA: 0x0014109C File Offset: 0x0013F29C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008596 RID: 34198 RVA: 0x001410A9 File Offset: 0x0013F2A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008597 RID: 34199 RVA: 0x001410B2 File Offset: 0x0013F2B2
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

		// Token: 0x06008598 RID: 34200 RVA: 0x001410DC File Offset: 0x0013F2DC
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

		// Token: 0x06008599 RID: 34201 RVA: 0x00141115 File Offset: 0x0013F315
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

		// Token: 0x0600859A RID: 34202 RVA: 0x00141143 File Offset: 0x0013F343
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600859B RID: 34203 RVA: 0x0014114C File Offset: 0x0013F34C
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

		// Token: 0x04004204 RID: 16900
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004205 RID: 16901
		public const int ValuesFieldNumber = 1;

		// Token: 0x04004206 RID: 16902
		private static readonly FieldCodec<float> _repeated_values_codec = FieldCodec.ForFloat(10U);

		// Token: 0x04004207 RID: 16903
		private readonly RepeatedField<float> values_ = new RepeatedField<float>();
	}
}
