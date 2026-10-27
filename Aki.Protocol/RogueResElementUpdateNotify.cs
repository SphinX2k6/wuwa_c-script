using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FD6 RID: 4054
	[NetMessage(EMessageId.RogueResElementUpdateNotify)]
	public sealed class RogueResElementUpdateNotify : IMessage<RogueResElementUpdateNotify>, IMessage, IEquatable<RogueResElementUpdateNotify>, IDeepCloneable<RogueResElementUpdateNotify>, IBufferMessage
	{
		// Token: 0x06015AB2 RID: 88754 RVA: 0x00325126 File Offset: 0x00323326
		[NullableContext(1)]
		public static RogueResElementUpdateNotify Create()
		{
			return new RogueResElementUpdateNotify();
		}

		// Token: 0x17004843 RID: 18499
		// (get) Token: 0x06015AB3 RID: 88755 RVA: 0x0032512D File Offset: 0x0032332D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004844 RID: 18500
		// (get) Token: 0x06015AB4 RID: 88756 RVA: 0x00325130 File Offset: 0x00323330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResElementUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06015AB5 RID: 88757 RVA: 0x00325137 File Offset: 0x00323337
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResElementUpdateNotify()
		{
		}

		// Token: 0x06015AB6 RID: 88758 RVA: 0x0032514A File Offset: 0x0032334A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResElementUpdateNotify(RogueResElementUpdateNotify other) : this()
		{
			this.elementUnits_ = other.elementUnits_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015AB7 RID: 88759 RVA: 0x00325174 File Offset: 0x00323374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResElementUpdateNotify Clone()
		{
			return new RogueResElementUpdateNotify(this);
		}

		// Token: 0x17004845 RID: 18501
		// (get) Token: 0x06015AB8 RID: 88760 RVA: 0x0032517C File Offset: 0x0032337C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ElementUnit> ElementUnits
		{
			get
			{
				return this.elementUnits_;
			}
		}

		// Token: 0x06015AB9 RID: 88761 RVA: 0x00325184 File Offset: 0x00323384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResElementUpdateNotify);
		}

		// Token: 0x06015ABA RID: 88762 RVA: 0x00325192 File Offset: 0x00323392
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResElementUpdateNotify other)
		{
			return other != null && (other == this || (this.elementUnits_.Equals(other.elementUnits_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015ABB RID: 88763 RVA: 0x003251C8 File Offset: 0x003233C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.elementUnits_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015ABC RID: 88764 RVA: 0x003251FC File Offset: 0x003233FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015ABD RID: 88765 RVA: 0x00325209 File Offset: 0x00323409
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015ABE RID: 88766 RVA: 0x00325212 File Offset: 0x00323412
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.elementUnits_.WriteTo(ref output, RogueResElementUpdateNotify._repeated_elementUnits_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015ABF RID: 88767 RVA: 0x0032523C File Offset: 0x0032343C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.elementUnits_.CalculateSize(RogueResElementUpdateNotify._repeated_elementUnits_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015AC0 RID: 88768 RVA: 0x00325275 File Offset: 0x00323475
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResElementUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.elementUnits_.Add(other.elementUnits_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015AC1 RID: 88769 RVA: 0x003252A3 File Offset: 0x003234A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015AC2 RID: 88770 RVA: 0x003252AC File Offset: 0x003234AC
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
				if (num != 90U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.elementUnits_.AddEntriesFrom(ref input, RogueResElementUpdateNotify._repeated_elementUnits_codec);
				}
			}
		}

		// Token: 0x04008211 RID: 33297
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008212 RID: 33298
		public const int ElementUnitsFieldNumber = 11;

		// Token: 0x04008213 RID: 33299
		private static readonly FieldCodec<ElementUnit> _repeated_elementUnits_codec = FieldCodec.ForMessage<ElementUnit>(90U, ElementUnit.Parser);

		// Token: 0x04008214 RID: 33300
		private readonly RepeatedField<ElementUnit> elementUnits_ = new RepeatedField<ElementUnit>();
	}
}
