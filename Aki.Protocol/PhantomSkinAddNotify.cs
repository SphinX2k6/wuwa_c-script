using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CF6 RID: 3318
	[NetMessage(EMessageId.PhantomSkinAddNotify)]
	public sealed class PhantomSkinAddNotify : IMessage<PhantomSkinAddNotify>, IMessage, IEquatable<PhantomSkinAddNotify>, IDeepCloneable<PhantomSkinAddNotify>, IBufferMessage
	{
		// Token: 0x06011F4F RID: 73551 RVA: 0x002A0892 File Offset: 0x0029EA92
		[NullableContext(1)]
		public static PhantomSkinAddNotify Create()
		{
			return new PhantomSkinAddNotify();
		}

		// Token: 0x17003B7E RID: 15230
		// (get) Token: 0x06011F50 RID: 73552 RVA: 0x002A0899 File Offset: 0x0029EA99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003B7F RID: 15231
		// (get) Token: 0x06011F51 RID: 73553 RVA: 0x002A089C File Offset: 0x0029EA9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomSkinAddNotify.Descriptor;
			}
		}

		// Token: 0x06011F52 RID: 73554 RVA: 0x002A08A3 File Offset: 0x0029EAA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomSkinAddNotify()
		{
		}

		// Token: 0x06011F53 RID: 73555 RVA: 0x002A08B6 File Offset: 0x0029EAB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomSkinAddNotify(PhantomSkinAddNotify other) : this()
		{
			this.skinIds_ = other.skinIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011F54 RID: 73556 RVA: 0x002A08E0 File Offset: 0x0029EAE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomSkinAddNotify Clone()
		{
			return new PhantomSkinAddNotify(this);
		}

		// Token: 0x17003B80 RID: 15232
		// (get) Token: 0x06011F55 RID: 73557 RVA: 0x002A08E8 File Offset: 0x0029EAE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SkinIds
		{
			get
			{
				return this.skinIds_;
			}
		}

		// Token: 0x06011F56 RID: 73558 RVA: 0x002A08F0 File Offset: 0x0029EAF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomSkinAddNotify);
		}

		// Token: 0x06011F57 RID: 73559 RVA: 0x002A08FE File Offset: 0x0029EAFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomSkinAddNotify other)
		{
			return other != null && (other == this || (this.skinIds_.Equals(other.skinIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011F58 RID: 73560 RVA: 0x002A0934 File Offset: 0x0029EB34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.skinIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011F59 RID: 73561 RVA: 0x002A0968 File Offset: 0x0029EB68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011F5A RID: 73562 RVA: 0x002A0975 File Offset: 0x0029EB75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011F5B RID: 73563 RVA: 0x002A097E File Offset: 0x0029EB7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.skinIds_.WriteTo(ref output, PhantomSkinAddNotify._repeated_skinIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011F5C RID: 73564 RVA: 0x002A09A8 File Offset: 0x0029EBA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.skinIds_.CalculateSize(PhantomSkinAddNotify._repeated_skinIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011F5D RID: 73565 RVA: 0x002A09E1 File Offset: 0x0029EBE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomSkinAddNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.skinIds_.Add(other.skinIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011F5E RID: 73566 RVA: 0x002A0A0F File Offset: 0x0029EC0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011F5F RID: 73567 RVA: 0x002A0A18 File Offset: 0x0029EC18
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
				if (num != 32U && num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.skinIds_.AddEntriesFrom(ref input, PhantomSkinAddNotify._repeated_skinIds_codec);
				}
			}
		}

		// Token: 0x040070F0 RID: 28912
		private UnknownFieldSet _unknownFields;

		// Token: 0x040070F1 RID: 28913
		public const int SkinIdsFieldNumber = 4;

		// Token: 0x040070F2 RID: 28914
		private static readonly FieldCodec<int> _repeated_skinIds_codec = FieldCodec.ForInt32(34U);

		// Token: 0x040070F3 RID: 28915
		private readonly RepeatedField<int> skinIds_ = new RepeatedField<int>();
	}
}
