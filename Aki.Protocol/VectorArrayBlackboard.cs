using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200153E RID: 5438
	public sealed class VectorArrayBlackboard : IMessage<VectorArrayBlackboard>, IMessage, IEquatable<VectorArrayBlackboard>, IDeepCloneable<VectorArrayBlackboard>, IBufferMessage
	{
		// Token: 0x0601CCFC RID: 118012 RVA: 0x0042D0B4 File Offset: 0x0042B2B4
		[NullableContext(1)]
		public static VectorArrayBlackboard Create()
		{
			return new VectorArrayBlackboard();
		}

		// Token: 0x17006180 RID: 24960
		// (get) Token: 0x0601CCFD RID: 118013 RVA: 0x0042D0BB File Offset: 0x0042B2BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006181 RID: 24961
		// (get) Token: 0x0601CCFE RID: 118014 RVA: 0x0042D0BE File Offset: 0x0042B2BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VectorArrayBlackboard.Descriptor;
			}
		}

		// Token: 0x0601CCFF RID: 118015 RVA: 0x0042D0C5 File Offset: 0x0042B2C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VectorArrayBlackboard()
		{
		}

		// Token: 0x0601CD00 RID: 118016 RVA: 0x0042D0D8 File Offset: 0x0042B2D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VectorArrayBlackboard(VectorArrayBlackboard other) : this()
		{
			this.values_ = other.values_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CD01 RID: 118017 RVA: 0x0042D102 File Offset: 0x0042B302
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VectorArrayBlackboard Clone()
		{
			return new VectorArrayBlackboard(this);
		}

		// Token: 0x17006182 RID: 24962
		// (get) Token: 0x0601CD02 RID: 118018 RVA: 0x0042D10A File Offset: 0x0042B30A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Vector> Values
		{
			get
			{
				return this.values_;
			}
		}

		// Token: 0x0601CD03 RID: 118019 RVA: 0x0042D112 File Offset: 0x0042B312
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as VectorArrayBlackboard);
		}

		// Token: 0x0601CD04 RID: 118020 RVA: 0x0042D120 File Offset: 0x0042B320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(VectorArrayBlackboard other)
		{
			return other != null && (other == this || (this.values_.Equals(other.values_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CD05 RID: 118021 RVA: 0x0042D154 File Offset: 0x0042B354
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

		// Token: 0x0601CD06 RID: 118022 RVA: 0x0042D188 File Offset: 0x0042B388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CD07 RID: 118023 RVA: 0x0042D195 File Offset: 0x0042B395
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CD08 RID: 118024 RVA: 0x0042D19E File Offset: 0x0042B39E
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

		// Token: 0x0601CD09 RID: 118025 RVA: 0x0042D1C8 File Offset: 0x0042B3C8
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

		// Token: 0x0601CD0A RID: 118026 RVA: 0x0042D201 File Offset: 0x0042B401
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

		// Token: 0x0601CD0B RID: 118027 RVA: 0x0042D22F File Offset: 0x0042B42F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CD0C RID: 118028 RVA: 0x0042D238 File Offset: 0x0042B438
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

		// Token: 0x0400A5D3 RID: 42451
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A5D4 RID: 42452
		public const int ValuesFieldNumber = 1;

		// Token: 0x0400A5D5 RID: 42453
		private static readonly FieldCodec<Vector> _repeated_values_codec = FieldCodec.ForMessage<Vector>(10U, Vector.Parser);

		// Token: 0x0400A5D6 RID: 42454
		private readonly RepeatedField<Vector> values_ = new RepeatedField<Vector>();
	}
}
