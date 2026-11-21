using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001128 RID: 4392
	public sealed class RotatorArrayBlackboard : IMessage<RotatorArrayBlackboard>, IMessage, IEquatable<RotatorArrayBlackboard>, IDeepCloneable<RotatorArrayBlackboard>, IBufferMessage
	{
		// Token: 0x06017766 RID: 96102 RVA: 0x00369926 File Offset: 0x00367B26
		[NullableContext(1)]
		public static RotatorArrayBlackboard Create()
		{
			return new RotatorArrayBlackboard();
		}

		// Token: 0x17004ED1 RID: 20177
		// (get) Token: 0x06017767 RID: 96103 RVA: 0x0036992D File Offset: 0x00367B2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004ED2 RID: 20178
		// (get) Token: 0x06017768 RID: 96104 RVA: 0x00369930 File Offset: 0x00367B30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RotatorArrayBlackboard.Descriptor;
			}
		}

		// Token: 0x06017769 RID: 96105 RVA: 0x00369937 File Offset: 0x00367B37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RotatorArrayBlackboard()
		{
		}

		// Token: 0x0601776A RID: 96106 RVA: 0x0036994A File Offset: 0x00367B4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RotatorArrayBlackboard(RotatorArrayBlackboard other) : this()
		{
			this.values_ = other.values_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601776B RID: 96107 RVA: 0x00369974 File Offset: 0x00367B74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RotatorArrayBlackboard Clone()
		{
			return new RotatorArrayBlackboard(this);
		}

		// Token: 0x17004ED3 RID: 20179
		// (get) Token: 0x0601776C RID: 96108 RVA: 0x0036997C File Offset: 0x00367B7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Rotator> Values
		{
			get
			{
				return this.values_;
			}
		}

		// Token: 0x0601776D RID: 96109 RVA: 0x00369984 File Offset: 0x00367B84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RotatorArrayBlackboard);
		}

		// Token: 0x0601776E RID: 96110 RVA: 0x00369992 File Offset: 0x00367B92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RotatorArrayBlackboard other)
		{
			return other != null && (other == this || (this.values_.Equals(other.values_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601776F RID: 96111 RVA: 0x003699C8 File Offset: 0x00367BC8
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

		// Token: 0x06017770 RID: 96112 RVA: 0x003699FC File Offset: 0x00367BFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017771 RID: 96113 RVA: 0x00369A09 File Offset: 0x00367C09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017772 RID: 96114 RVA: 0x00369A12 File Offset: 0x00367C12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.values_.WriteTo(ref output, RotatorArrayBlackboard._repeated_values_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017773 RID: 96115 RVA: 0x00369A3C File Offset: 0x00367C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.values_.CalculateSize(RotatorArrayBlackboard._repeated_values_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017774 RID: 96116 RVA: 0x00369A75 File Offset: 0x00367C75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RotatorArrayBlackboard other)
		{
			if (other == null)
			{
				return;
			}
			this.values_.Add(other.values_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017775 RID: 96117 RVA: 0x00369AA3 File Offset: 0x00367CA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017776 RID: 96118 RVA: 0x00369AAC File Offset: 0x00367CAC
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
					this.values_.AddEntriesFrom(ref input, RotatorArrayBlackboard._repeated_values_codec);
				}
			}
		}

		// Token: 0x04008BFA RID: 35834
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008BFB RID: 35835
		public const int ValuesFieldNumber = 1;

		// Token: 0x04008BFC RID: 35836
		private static readonly FieldCodec<Rotator> _repeated_values_codec = FieldCodec.ForMessage<Rotator>(10U, Rotator.Parser);

		// Token: 0x04008BFD RID: 35837
		private readonly RepeatedField<Rotator> values_ = new RepeatedField<Rotator>();
	}
}
