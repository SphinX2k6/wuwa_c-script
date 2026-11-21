using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FC6 RID: 4038
	[NetMessage(EMessageId.RogueResElementUpdateNotify)]
	public sealed class RogueResElementUpdateNotify : IMessage<RogueResElementUpdateNotify>, IMessage, IEquatable<RogueResElementUpdateNotify>, IDeepCloneable<RogueResElementUpdateNotify>, IBufferMessage
	{
		// Token: 0x060159CD RID: 88525 RVA: 0x00323A72 File Offset: 0x00321C72
		[NullableContext(1)]
		public static RogueResElementUpdateNotify Create()
		{
			return new RogueResElementUpdateNotify();
		}

		// Token: 0x17004819 RID: 18457
		// (get) Token: 0x060159CE RID: 88526 RVA: 0x00323A79 File Offset: 0x00321C79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700481A RID: 18458
		// (get) Token: 0x060159CF RID: 88527 RVA: 0x00323A7C File Offset: 0x00321C7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResElementUpdateNotify.Descriptor;
			}
		}

		// Token: 0x060159D0 RID: 88528 RVA: 0x00323A83 File Offset: 0x00321C83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResElementUpdateNotify()
		{
		}

		// Token: 0x060159D1 RID: 88529 RVA: 0x00323A96 File Offset: 0x00321C96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResElementUpdateNotify(RogueResElementUpdateNotify other) : this()
		{
			this.elementUnits_ = other.elementUnits_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060159D2 RID: 88530 RVA: 0x00323AC0 File Offset: 0x00321CC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResElementUpdateNotify Clone()
		{
			return new RogueResElementUpdateNotify(this);
		}

		// Token: 0x1700481B RID: 18459
		// (get) Token: 0x060159D3 RID: 88531 RVA: 0x00323AC8 File Offset: 0x00321CC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ElementUnit> ElementUnits
		{
			get
			{
				return this.elementUnits_;
			}
		}

		// Token: 0x060159D4 RID: 88532 RVA: 0x00323AD0 File Offset: 0x00321CD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResElementUpdateNotify);
		}

		// Token: 0x060159D5 RID: 88533 RVA: 0x00323ADE File Offset: 0x00321CDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResElementUpdateNotify other)
		{
			return other != null && (other == this || (this.elementUnits_.Equals(other.elementUnits_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060159D6 RID: 88534 RVA: 0x00323B14 File Offset: 0x00321D14
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

		// Token: 0x060159D7 RID: 88535 RVA: 0x00323B48 File Offset: 0x00321D48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060159D8 RID: 88536 RVA: 0x00323B55 File Offset: 0x00321D55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060159D9 RID: 88537 RVA: 0x00323B5E File Offset: 0x00321D5E
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

		// Token: 0x060159DA RID: 88538 RVA: 0x00323B88 File Offset: 0x00321D88
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

		// Token: 0x060159DB RID: 88539 RVA: 0x00323BC1 File Offset: 0x00321DC1
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

		// Token: 0x060159DC RID: 88540 RVA: 0x00323BEF File Offset: 0x00321DEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060159DD RID: 88541 RVA: 0x00323BF8 File Offset: 0x00321DF8
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
				if (num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.elementUnits_.AddEntriesFrom(ref input, RogueResElementUpdateNotify._repeated_elementUnits_codec);
				}
			}
		}

		// Token: 0x0400823B RID: 33339
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400823C RID: 33340
		public const int ElementUnitsFieldNumber = 13;

		// Token: 0x0400823D RID: 33341
		private static readonly FieldCodec<ElementUnit> _repeated_elementUnits_codec = FieldCodec.ForMessage<ElementUnit>(106U, ElementUnit.Parser);

		// Token: 0x0400823E RID: 33342
		private readonly RepeatedField<ElementUnit> elementUnits_ = new RepeatedField<ElementUnit>();
	}
}
