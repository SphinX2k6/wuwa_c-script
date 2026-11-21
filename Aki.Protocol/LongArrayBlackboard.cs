using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200093D RID: 2365
	public sealed class LongArrayBlackboard : IMessage<LongArrayBlackboard>, IMessage, IEquatable<LongArrayBlackboard>, IDeepCloneable<LongArrayBlackboard>, IBufferMessage
	{
		// Token: 0x0600D0E2 RID: 53474 RVA: 0x001ED18D File Offset: 0x001EB38D
		[NullableContext(1)]
		public static LongArrayBlackboard Create()
		{
			return new LongArrayBlackboard();
		}

		// Token: 0x17002A42 RID: 10818
		// (get) Token: 0x0600D0E3 RID: 53475 RVA: 0x001ED194 File Offset: 0x001EB394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002A43 RID: 10819
		// (get) Token: 0x0600D0E4 RID: 53476 RVA: 0x001ED197 File Offset: 0x001EB397
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LongArrayBlackboard.Descriptor;
			}
		}

		// Token: 0x0600D0E5 RID: 53477 RVA: 0x001ED19E File Offset: 0x001EB39E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LongArrayBlackboard()
		{
		}

		// Token: 0x0600D0E6 RID: 53478 RVA: 0x001ED1B1 File Offset: 0x001EB3B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LongArrayBlackboard(LongArrayBlackboard other) : this()
		{
			this.values_ = other.values_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D0E7 RID: 53479 RVA: 0x001ED1DB File Offset: 0x001EB3DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LongArrayBlackboard Clone()
		{
			return new LongArrayBlackboard(this);
		}

		// Token: 0x17002A44 RID: 10820
		// (get) Token: 0x0600D0E8 RID: 53480 RVA: 0x001ED1E3 File Offset: 0x001EB3E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> Values
		{
			get
			{
				return this.values_;
			}
		}

		// Token: 0x0600D0E9 RID: 53481 RVA: 0x001ED1EB File Offset: 0x001EB3EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LongArrayBlackboard);
		}

		// Token: 0x0600D0EA RID: 53482 RVA: 0x001ED1F9 File Offset: 0x001EB3F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LongArrayBlackboard other)
		{
			return other != null && (other == this || (this.values_.Equals(other.values_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D0EB RID: 53483 RVA: 0x001ED22C File Offset: 0x001EB42C
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

		// Token: 0x0600D0EC RID: 53484 RVA: 0x001ED260 File Offset: 0x001EB460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D0ED RID: 53485 RVA: 0x001ED26D File Offset: 0x001EB46D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D0EE RID: 53486 RVA: 0x001ED276 File Offset: 0x001EB476
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

		// Token: 0x0600D0EF RID: 53487 RVA: 0x001ED2A0 File Offset: 0x001EB4A0
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

		// Token: 0x0600D0F0 RID: 53488 RVA: 0x001ED2D9 File Offset: 0x001EB4D9
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

		// Token: 0x0600D0F1 RID: 53489 RVA: 0x001ED307 File Offset: 0x001EB507
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D0F2 RID: 53490 RVA: 0x001ED310 File Offset: 0x001EB510
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

		// Token: 0x0400586D RID: 22637
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400586E RID: 22638
		public const int ValuesFieldNumber = 1;

		// Token: 0x0400586F RID: 22639
		private static readonly FieldCodec<long> _repeated_values_codec = FieldCodec.ForInt64(10U);

		// Token: 0x04005870 RID: 22640
		private readonly RepeatedField<long> values_ = new RepeatedField<long>();
	}
}
