using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000830 RID: 2096
	public sealed class IntArrayBlackboard : IMessage<IntArrayBlackboard>, IMessage, IEquatable<IntArrayBlackboard>, IDeepCloneable<IntArrayBlackboard>, IBufferMessage
	{
		// Token: 0x0600BB55 RID: 47957 RVA: 0x001BE435 File Offset: 0x001BC635
		[NullableContext(1)]
		public static IntArrayBlackboard Create()
		{
			return new IntArrayBlackboard();
		}

		// Token: 0x170025D5 RID: 9685
		// (get) Token: 0x0600BB56 RID: 47958 RVA: 0x001BE43C File Offset: 0x001BC63C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170025D6 RID: 9686
		// (get) Token: 0x0600BB57 RID: 47959 RVA: 0x001BE43F File Offset: 0x001BC63F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return IntArrayBlackboard.Descriptor;
			}
		}

		// Token: 0x0600BB58 RID: 47960 RVA: 0x001BE446 File Offset: 0x001BC646
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IntArrayBlackboard()
		{
		}

		// Token: 0x0600BB59 RID: 47961 RVA: 0x001BE459 File Offset: 0x001BC659
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IntArrayBlackboard(IntArrayBlackboard other) : this()
		{
			this.values_ = other.values_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BB5A RID: 47962 RVA: 0x001BE483 File Offset: 0x001BC683
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IntArrayBlackboard Clone()
		{
			return new IntArrayBlackboard(this);
		}

		// Token: 0x170025D7 RID: 9687
		// (get) Token: 0x0600BB5B RID: 47963 RVA: 0x001BE48B File Offset: 0x001BC68B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Values
		{
			get
			{
				return this.values_;
			}
		}

		// Token: 0x0600BB5C RID: 47964 RVA: 0x001BE493 File Offset: 0x001BC693
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as IntArrayBlackboard);
		}

		// Token: 0x0600BB5D RID: 47965 RVA: 0x001BE4A1 File Offset: 0x001BC6A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(IntArrayBlackboard other)
		{
			return other != null && (other == this || (this.values_.Equals(other.values_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BB5E RID: 47966 RVA: 0x001BE4D4 File Offset: 0x001BC6D4
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

		// Token: 0x0600BB5F RID: 47967 RVA: 0x001BE508 File Offset: 0x001BC708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BB60 RID: 47968 RVA: 0x001BE515 File Offset: 0x001BC715
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BB61 RID: 47969 RVA: 0x001BE51E File Offset: 0x001BC71E
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

		// Token: 0x0600BB62 RID: 47970 RVA: 0x001BE548 File Offset: 0x001BC748
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

		// Token: 0x0600BB63 RID: 47971 RVA: 0x001BE581 File Offset: 0x001BC781
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

		// Token: 0x0600BB64 RID: 47972 RVA: 0x001BE5AF File Offset: 0x001BC7AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BB65 RID: 47973 RVA: 0x001BE5B8 File Offset: 0x001BC7B8
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

		// Token: 0x0400523E RID: 21054
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400523F RID: 21055
		public const int ValuesFieldNumber = 1;

		// Token: 0x04005240 RID: 21056
		private static readonly FieldCodec<int> _repeated_values_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04005241 RID: 21057
		private readonly RepeatedField<int> values_ = new RepeatedField<int>();
	}
}
