using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000126 RID: 294
	[NetMessage(EMessageId.AttributeChangedNotify)]
	public sealed class AttributeChangedNotify : IMessage<AttributeChangedNotify>, IMessage, IEquatable<AttributeChangedNotify>, IDeepCloneable<AttributeChangedNotify>, IBufferMessage
	{
		// Token: 0x0600279C RID: 10140 RVA: 0x00069090 File Offset: 0x00067290
		[NullableContext(1)]
		public static AttributeChangedNotify Create()
		{
			return new AttributeChangedNotify();
		}

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x0600279D RID: 10141 RVA: 0x00069097 File Offset: 0x00067297
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x0600279E RID: 10142 RVA: 0x0006909A File Offset: 0x0006729A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AttributeChangedNotify.Descriptor;
			}
		}

		// Token: 0x0600279F RID: 10143 RVA: 0x000690A1 File Offset: 0x000672A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttributeChangedNotify()
		{
		}

		// Token: 0x060027A0 RID: 10144 RVA: 0x000690B4 File Offset: 0x000672B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttributeChangedNotify(AttributeChangedNotify other) : this()
		{
			this.attributes_ = other.attributes_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060027A1 RID: 10145 RVA: 0x000690DE File Offset: 0x000672DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttributeChangedNotify Clone()
		{
			return new AttributeChangedNotify(this);
		}

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x060027A2 RID: 10146 RVA: 0x000690E6 File Offset: 0x000672E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GameplayAttributeData> Attributes
		{
			get
			{
				return this.attributes_;
			}
		}

		// Token: 0x060027A3 RID: 10147 RVA: 0x000690EE File Offset: 0x000672EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AttributeChangedNotify);
		}

		// Token: 0x060027A4 RID: 10148 RVA: 0x000690FC File Offset: 0x000672FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AttributeChangedNotify other)
		{
			return other != null && (other == this || (this.attributes_.Equals(other.attributes_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060027A5 RID: 10149 RVA: 0x00069130 File Offset: 0x00067330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.attributes_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060027A6 RID: 10150 RVA: 0x00069164 File Offset: 0x00067364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060027A7 RID: 10151 RVA: 0x00069171 File Offset: 0x00067371
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060027A8 RID: 10152 RVA: 0x0006917A File Offset: 0x0006737A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.attributes_.WriteTo(ref output, AttributeChangedNotify._repeated_attributes_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060027A9 RID: 10153 RVA: 0x000691A4 File Offset: 0x000673A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.attributes_.CalculateSize(AttributeChangedNotify._repeated_attributes_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060027AA RID: 10154 RVA: 0x000691DD File Offset: 0x000673DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AttributeChangedNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.attributes_.Add(other.attributes_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060027AB RID: 10155 RVA: 0x0006920B File Offset: 0x0006740B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060027AC RID: 10156 RVA: 0x00069214 File Offset: 0x00067414
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
				if (num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.attributes_.AddEntriesFrom(ref input, AttributeChangedNotify._repeated_attributes_codec);
				}
			}
		}

		// Token: 0x040026C0 RID: 9920
		private UnknownFieldSet _unknownFields;

		// Token: 0x040026C1 RID: 9921
		public const int AttributesFieldNumber = 6;

		// Token: 0x040026C2 RID: 9922
		private static readonly FieldCodec<GameplayAttributeData> _repeated_attributes_codec = FieldCodec.ForMessage<GameplayAttributeData>(50U, GameplayAttributeData.Parser);

		// Token: 0x040026C3 RID: 9923
		private readonly RepeatedField<GameplayAttributeData> attributes_ = new RepeatedField<GameplayAttributeData>();
	}
}
