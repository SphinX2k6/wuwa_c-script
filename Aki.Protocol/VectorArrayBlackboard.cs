using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014C8 RID: 5320
	public sealed class VectorArrayBlackboard : IMessage<VectorArrayBlackboard>, IMessage, IEquatable<VectorArrayBlackboard>, IDeepCloneable<VectorArrayBlackboard>, IBufferMessage
	{
		// Token: 0x0601C235 RID: 115253 RVA: 0x004115F8 File Offset: 0x0040F7F8
		[NullableContext(1)]
		public static VectorArrayBlackboard Create()
		{
			return new VectorArrayBlackboard();
		}

		// Token: 0x17005EDF RID: 24287
		// (get) Token: 0x0601C236 RID: 115254 RVA: 0x004115FF File Offset: 0x0040F7FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005EE0 RID: 24288
		// (get) Token: 0x0601C237 RID: 115255 RVA: 0x00411602 File Offset: 0x0040F802
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VectorArrayBlackboard.Descriptor;
			}
		}

		// Token: 0x0601C238 RID: 115256 RVA: 0x00411609 File Offset: 0x0040F809
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VectorArrayBlackboard()
		{
		}

		// Token: 0x0601C239 RID: 115257 RVA: 0x0041161C File Offset: 0x0040F81C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VectorArrayBlackboard(VectorArrayBlackboard other) : this()
		{
			this.values_ = other.values_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C23A RID: 115258 RVA: 0x00411646 File Offset: 0x0040F846
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VectorArrayBlackboard Clone()
		{
			return new VectorArrayBlackboard(this);
		}

		// Token: 0x17005EE1 RID: 24289
		// (get) Token: 0x0601C23B RID: 115259 RVA: 0x0041164E File Offset: 0x0040F84E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Vector> Values
		{
			get
			{
				return this.values_;
			}
		}

		// Token: 0x0601C23C RID: 115260 RVA: 0x00411656 File Offset: 0x0040F856
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as VectorArrayBlackboard);
		}

		// Token: 0x0601C23D RID: 115261 RVA: 0x00411664 File Offset: 0x0040F864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(VectorArrayBlackboard other)
		{
			return other != null && (other == this || (this.values_.Equals(other.values_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C23E RID: 115262 RVA: 0x00411698 File Offset: 0x0040F898
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

		// Token: 0x0601C23F RID: 115263 RVA: 0x004116CC File Offset: 0x0040F8CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C240 RID: 115264 RVA: 0x004116D9 File Offset: 0x0040F8D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C241 RID: 115265 RVA: 0x004116E2 File Offset: 0x0040F8E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.values_.WriteTo(ref output, VectorArrayBlackboard._repeated_values_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C242 RID: 115266 RVA: 0x0041170C File Offset: 0x0040F90C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.values_.CalculateSize(VectorArrayBlackboard._repeated_values_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C243 RID: 115267 RVA: 0x00411745 File Offset: 0x0040F945
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(VectorArrayBlackboard other)
		{
			if (other == null)
			{
				return;
			}
			this.values_.Add(other.values_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C244 RID: 115268 RVA: 0x00411773 File Offset: 0x0040F973
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C245 RID: 115269 RVA: 0x0041177C File Offset: 0x0040F97C
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
					this.values_.AddEntriesFrom(ref input, VectorArrayBlackboard._repeated_values_codec);
				}
			}
		}

		// Token: 0x0400A17A RID: 41338
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A17B RID: 41339
		public const int ValuesFieldNumber = 1;

		// Token: 0x0400A17C RID: 41340
		private static readonly FieldCodec<Vector> _repeated_values_codec = FieldCodec.ForMessage<Vector>(10U, Vector.Parser);

		// Token: 0x0400A17D RID: 41341
		private readonly RepeatedField<Vector> values_ = new RepeatedField<Vector>();
	}
}
