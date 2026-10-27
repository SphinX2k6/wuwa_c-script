using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000127 RID: 295
	public sealed class AttributeEventEffectData : IMessage<AttributeEventEffectData>, IMessage, IEquatable<AttributeEventEffectData>, IDeepCloneable<AttributeEventEffectData>, IBufferMessage
	{
		// Token: 0x06002773 RID: 10099 RVA: 0x00068637 File Offset: 0x00066837
		[NullableContext(1)]
		public static AttributeEventEffectData Create()
		{
			return new AttributeEventEffectData();
		}

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x06002774 RID: 10100 RVA: 0x0006863E File Offset: 0x0006683E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x06002775 RID: 10101 RVA: 0x00068641 File Offset: 0x00066841
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AttributeEventEffectData.Descriptor;
			}
		}

		// Token: 0x06002776 RID: 10102 RVA: 0x00068648 File Offset: 0x00066848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttributeEventEffectData()
		{
		}

		// Token: 0x06002777 RID: 10103 RVA: 0x0006865B File Offset: 0x0006685B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttributeEventEffectData(AttributeEventEffectData other) : this()
		{
			this.triggeredActiveHandles_ = other.triggeredActiveHandles_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002778 RID: 10104 RVA: 0x00068685 File Offset: 0x00066885
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttributeEventEffectData Clone()
		{
			return new AttributeEventEffectData(this);
		}

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x06002779 RID: 10105 RVA: 0x0006868D File Offset: 0x0006688D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TriggeredActiveHandles
		{
			get
			{
				return this.triggeredActiveHandles_;
			}
		}

		// Token: 0x0600277A RID: 10106 RVA: 0x00068695 File Offset: 0x00066895
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AttributeEventEffectData);
		}

		// Token: 0x0600277B RID: 10107 RVA: 0x000686A3 File Offset: 0x000668A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AttributeEventEffectData other)
		{
			return other != null && (other == this || (this.triggeredActiveHandles_.Equals(other.triggeredActiveHandles_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600277C RID: 10108 RVA: 0x000686D8 File Offset: 0x000668D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.triggeredActiveHandles_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600277D RID: 10109 RVA: 0x0006870C File Offset: 0x0006690C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600277E RID: 10110 RVA: 0x00068719 File Offset: 0x00066919
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600277F RID: 10111 RVA: 0x00068722 File Offset: 0x00066922
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.triggeredActiveHandles_.WriteTo(ref output, AttributeEventEffectData._repeated_triggeredActiveHandles_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002780 RID: 10112 RVA: 0x0006874C File Offset: 0x0006694C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.triggeredActiveHandles_.CalculateSize(AttributeEventEffectData._repeated_triggeredActiveHandles_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002781 RID: 10113 RVA: 0x00068785 File Offset: 0x00066985
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AttributeEventEffectData other)
		{
			if (other == null)
			{
				return;
			}
			this.triggeredActiveHandles_.Add(other.triggeredActiveHandles_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002782 RID: 10114 RVA: 0x000687B3 File Offset: 0x000669B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002783 RID: 10115 RVA: 0x000687BC File Offset: 0x000669BC
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
					this.triggeredActiveHandles_.AddEntriesFrom(ref input, AttributeEventEffectData._repeated_triggeredActiveHandles_codec);
				}
			}
		}

		// Token: 0x04002661 RID: 9825
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002662 RID: 9826
		public const int TriggeredActiveHandlesFieldNumber = 1;

		// Token: 0x04002663 RID: 9827
		private static readonly FieldCodec<int> _repeated_triggeredActiveHandles_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04002664 RID: 9828
		private readonly RepeatedField<int> triggeredActiveHandles_ = new RepeatedField<int>();
	}
}
