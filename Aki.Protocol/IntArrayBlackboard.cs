using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200081C RID: 2076
	public sealed class IntArrayBlackboard : IMessage<IntArrayBlackboard>, IMessage, IEquatable<IntArrayBlackboard>, IDeepCloneable<IntArrayBlackboard>, IBufferMessage
	{
		// Token: 0x0600B9FF RID: 47615 RVA: 0x001BB9F9 File Offset: 0x001B9BF9
		[NullableContext(1)]
		public static IntArrayBlackboard Create()
		{
			return new IntArrayBlackboard();
		}

		// Token: 0x1700258B RID: 9611
		// (get) Token: 0x0600BA00 RID: 47616 RVA: 0x001BBA00 File Offset: 0x001B9C00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700258C RID: 9612
		// (get) Token: 0x0600BA01 RID: 47617 RVA: 0x001BBA03 File Offset: 0x001B9C03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return IntArrayBlackboard.Descriptor;
			}
		}

		// Token: 0x0600BA02 RID: 47618 RVA: 0x001BBA0A File Offset: 0x001B9C0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IntArrayBlackboard()
		{
		}

		// Token: 0x0600BA03 RID: 47619 RVA: 0x001BBA1D File Offset: 0x001B9C1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IntArrayBlackboard(IntArrayBlackboard other) : this()
		{
			this.values_ = other.values_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BA04 RID: 47620 RVA: 0x001BBA47 File Offset: 0x001B9C47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IntArrayBlackboard Clone()
		{
			return new IntArrayBlackboard(this);
		}

		// Token: 0x1700258D RID: 9613
		// (get) Token: 0x0600BA05 RID: 47621 RVA: 0x001BBA4F File Offset: 0x001B9C4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Values
		{
			get
			{
				return this.values_;
			}
		}

		// Token: 0x0600BA06 RID: 47622 RVA: 0x001BBA57 File Offset: 0x001B9C57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as IntArrayBlackboard);
		}

		// Token: 0x0600BA07 RID: 47623 RVA: 0x001BBA65 File Offset: 0x001B9C65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(IntArrayBlackboard other)
		{
			return other != null && (other == this || (this.values_.Equals(other.values_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BA08 RID: 47624 RVA: 0x001BBA98 File Offset: 0x001B9C98
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

		// Token: 0x0600BA09 RID: 47625 RVA: 0x001BBACC File Offset: 0x001B9CCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BA0A RID: 47626 RVA: 0x001BBAD9 File Offset: 0x001B9CD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BA0B RID: 47627 RVA: 0x001BBAE2 File Offset: 0x001B9CE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.values_.WriteTo(ref output, IntArrayBlackboard._repeated_values_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BA0C RID: 47628 RVA: 0x001BBB0C File Offset: 0x001B9D0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.values_.CalculateSize(IntArrayBlackboard._repeated_values_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BA0D RID: 47629 RVA: 0x001BBB45 File Offset: 0x001B9D45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(IntArrayBlackboard other)
		{
			if (other == null)
			{
				return;
			}
			this.values_.Add(other.values_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BA0E RID: 47630 RVA: 0x001BBB73 File Offset: 0x001B9D73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BA0F RID: 47631 RVA: 0x001BBB7C File Offset: 0x001B9D7C
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
					this.values_.AddEntriesFrom(ref input, IntArrayBlackboard._repeated_values_codec);
				}
			}
		}

		// Token: 0x04005237 RID: 21047
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005238 RID: 21048
		public const int ValuesFieldNumber = 1;

		// Token: 0x04005239 RID: 21049
		private static readonly FieldCodec<int> _repeated_values_codec = FieldCodec.ForInt32(10U);

		// Token: 0x0400523A RID: 21050
		private readonly RepeatedField<int> values_ = new RepeatedField<int>();
	}
}
