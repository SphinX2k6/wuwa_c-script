using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200129D RID: 4765
	public sealed class StringArrayBlackboard : IMessage<StringArrayBlackboard>, IMessage, IEquatable<StringArrayBlackboard>, IDeepCloneable<StringArrayBlackboard>, IBufferMessage
	{
		// Token: 0x060195D0 RID: 103888 RVA: 0x003AFE1C File Offset: 0x003AE01C
		[NullableContext(1)]
		public static StringArrayBlackboard Create()
		{
			return new StringArrayBlackboard();
		}

		// Token: 0x17005589 RID: 21897
		// (get) Token: 0x060195D1 RID: 103889 RVA: 0x003AFE23 File Offset: 0x003AE023
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700558A RID: 21898
		// (get) Token: 0x060195D2 RID: 103890 RVA: 0x003AFE26 File Offset: 0x003AE026
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StringArrayBlackboard.Descriptor;
			}
		}

		// Token: 0x060195D3 RID: 103891 RVA: 0x003AFE2D File Offset: 0x003AE02D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StringArrayBlackboard()
		{
		}

		// Token: 0x060195D4 RID: 103892 RVA: 0x003AFE40 File Offset: 0x003AE040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StringArrayBlackboard(StringArrayBlackboard other) : this()
		{
			this.values_ = other.values_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060195D5 RID: 103893 RVA: 0x003AFE6A File Offset: 0x003AE06A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StringArrayBlackboard Clone()
		{
			return new StringArrayBlackboard(this);
		}

		// Token: 0x1700558B RID: 21899
		// (get) Token: 0x060195D6 RID: 103894 RVA: 0x003AFE72 File Offset: 0x003AE072
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> Values
		{
			get
			{
				return this.values_;
			}
		}

		// Token: 0x060195D7 RID: 103895 RVA: 0x003AFE7A File Offset: 0x003AE07A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StringArrayBlackboard);
		}

		// Token: 0x060195D8 RID: 103896 RVA: 0x003AFE88 File Offset: 0x003AE088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StringArrayBlackboard other)
		{
			return other != null && (other == this || (this.values_.Equals(other.values_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060195D9 RID: 103897 RVA: 0x003AFEBC File Offset: 0x003AE0BC
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

		// Token: 0x060195DA RID: 103898 RVA: 0x003AFEF0 File Offset: 0x003AE0F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060195DB RID: 103899 RVA: 0x003AFEFD File Offset: 0x003AE0FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060195DC RID: 103900 RVA: 0x003AFF06 File Offset: 0x003AE106
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.values_.WriteTo(ref output, StringArrayBlackboard._repeated_values_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060195DD RID: 103901 RVA: 0x003AFF30 File Offset: 0x003AE130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.values_.CalculateSize(StringArrayBlackboard._repeated_values_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060195DE RID: 103902 RVA: 0x003AFF69 File Offset: 0x003AE169
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StringArrayBlackboard other)
		{
			if (other == null)
			{
				return;
			}
			this.values_.Add(other.values_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060195DF RID: 103903 RVA: 0x003AFF97 File Offset: 0x003AE197
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060195E0 RID: 103904 RVA: 0x003AFFA0 File Offset: 0x003AE1A0
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
					this.values_.AddEntriesFrom(ref input, StringArrayBlackboard._repeated_values_codec);
				}
			}
		}

		// Token: 0x040094FE RID: 38142
		private UnknownFieldSet _unknownFields;

		// Token: 0x040094FF RID: 38143
		public const int ValuesFieldNumber = 1;

		// Token: 0x04009500 RID: 38144
		private static readonly FieldCodec<string> _repeated_values_codec = FieldCodec.ForString(10U);

		// Token: 0x04009501 RID: 38145
		private readonly RepeatedField<string> values_ = new RepeatedField<string>();
	}
}
