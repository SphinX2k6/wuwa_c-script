using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200130C RID: 4876
	public sealed class StringArrayBlackboard : IMessage<StringArrayBlackboard>, IMessage, IEquatable<StringArrayBlackboard>, IDeepCloneable<StringArrayBlackboard>, IBufferMessage
	{
		// Token: 0x0601A006 RID: 106502 RVA: 0x003CA54D File Offset: 0x003C874D
		[NullableContext(1)]
		public static StringArrayBlackboard Create()
		{
			return new StringArrayBlackboard();
		}

		// Token: 0x1700580A RID: 22538
		// (get) Token: 0x0601A007 RID: 106503 RVA: 0x003CA554 File Offset: 0x003C8754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700580B RID: 22539
		// (get) Token: 0x0601A008 RID: 106504 RVA: 0x003CA557 File Offset: 0x003C8757
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StringArrayBlackboard.Descriptor;
			}
		}

		// Token: 0x0601A009 RID: 106505 RVA: 0x003CA55E File Offset: 0x003C875E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StringArrayBlackboard()
		{
		}

		// Token: 0x0601A00A RID: 106506 RVA: 0x003CA571 File Offset: 0x003C8771
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StringArrayBlackboard(StringArrayBlackboard other) : this()
		{
			this.values_ = other.values_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A00B RID: 106507 RVA: 0x003CA59B File Offset: 0x003C879B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StringArrayBlackboard Clone()
		{
			return new StringArrayBlackboard(this);
		}

		// Token: 0x1700580C RID: 22540
		// (get) Token: 0x0601A00C RID: 106508 RVA: 0x003CA5A3 File Offset: 0x003C87A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> Values
		{
			get
			{
				return this.values_;
			}
		}

		// Token: 0x0601A00D RID: 106509 RVA: 0x003CA5AB File Offset: 0x003C87AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StringArrayBlackboard);
		}

		// Token: 0x0601A00E RID: 106510 RVA: 0x003CA5B9 File Offset: 0x003C87B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StringArrayBlackboard other)
		{
			return other != null && (other == this || (this.values_.Equals(other.values_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A00F RID: 106511 RVA: 0x003CA5EC File Offset: 0x003C87EC
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

		// Token: 0x0601A010 RID: 106512 RVA: 0x003CA620 File Offset: 0x003C8820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A011 RID: 106513 RVA: 0x003CA62D File Offset: 0x003C882D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A012 RID: 106514 RVA: 0x003CA636 File Offset: 0x003C8836
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

		// Token: 0x0601A013 RID: 106515 RVA: 0x003CA660 File Offset: 0x003C8860
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

		// Token: 0x0601A014 RID: 106516 RVA: 0x003CA699 File Offset: 0x003C8899
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

		// Token: 0x0601A015 RID: 106517 RVA: 0x003CA6C7 File Offset: 0x003C88C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A016 RID: 106518 RVA: 0x003CA6D0 File Offset: 0x003C88D0
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

		// Token: 0x04009928 RID: 39208
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009929 RID: 39209
		public const int ValuesFieldNumber = 1;

		// Token: 0x0400992A RID: 39210
		private static readonly FieldCodec<string> _repeated_values_codec = FieldCodec.ForString(10U);

		// Token: 0x0400992B RID: 39211
		private readonly RepeatedField<string> values_ = new RepeatedField<string>();
	}
}
