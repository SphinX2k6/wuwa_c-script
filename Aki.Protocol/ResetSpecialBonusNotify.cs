using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F17 RID: 3863
	[NetMessage(EMessageId.ResetSpecialBonusNotify)]
	public sealed class ResetSpecialBonusNotify : IMessage<ResetSpecialBonusNotify>, IMessage, IEquatable<ResetSpecialBonusNotify>, IDeepCloneable<ResetSpecialBonusNotify>, IBufferMessage
	{
		// Token: 0x06014B3B RID: 84795 RVA: 0x00301A99 File Offset: 0x002FFC99
		[NullableContext(1)]
		public static ResetSpecialBonusNotify Create()
		{
			return new ResetSpecialBonusNotify();
		}

		// Token: 0x170044D3 RID: 17619
		// (get) Token: 0x06014B3C RID: 84796 RVA: 0x00301AA0 File Offset: 0x002FFCA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170044D4 RID: 17620
		// (get) Token: 0x06014B3D RID: 84797 RVA: 0x00301AA3 File Offset: 0x002FFCA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ResetSpecialBonusNotify.Descriptor;
			}
		}

		// Token: 0x06014B3E RID: 84798 RVA: 0x00301AAA File Offset: 0x002FFCAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResetSpecialBonusNotify()
		{
		}

		// Token: 0x06014B3F RID: 84799 RVA: 0x00301ABD File Offset: 0x002FFCBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResetSpecialBonusNotify(ResetSpecialBonusNotify other) : this()
		{
			this.ids_ = other.ids_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014B40 RID: 84800 RVA: 0x00301AE7 File Offset: 0x002FFCE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResetSpecialBonusNotify Clone()
		{
			return new ResetSpecialBonusNotify(this);
		}

		// Token: 0x170044D5 RID: 17621
		// (get) Token: 0x06014B41 RID: 84801 RVA: 0x00301AEF File Offset: 0x002FFCEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Ids
		{
			get
			{
				return this.ids_;
			}
		}

		// Token: 0x06014B42 RID: 84802 RVA: 0x00301AF7 File Offset: 0x002FFCF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ResetSpecialBonusNotify);
		}

		// Token: 0x06014B43 RID: 84803 RVA: 0x00301B05 File Offset: 0x002FFD05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ResetSpecialBonusNotify other)
		{
			return other != null && (other == this || (this.ids_.Equals(other.ids_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014B44 RID: 84804 RVA: 0x00301B38 File Offset: 0x002FFD38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.ids_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014B45 RID: 84805 RVA: 0x00301B6C File Offset: 0x002FFD6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014B46 RID: 84806 RVA: 0x00301B79 File Offset: 0x002FFD79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014B47 RID: 84807 RVA: 0x00301B82 File Offset: 0x002FFD82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.ids_.WriteTo(ref output, ResetSpecialBonusNotify._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014B48 RID: 84808 RVA: 0x00301BAC File Offset: 0x002FFDAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.ids_.CalculateSize(ResetSpecialBonusNotify._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014B49 RID: 84809 RVA: 0x00301BE5 File Offset: 0x002FFDE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ResetSpecialBonusNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.ids_.Add(other.ids_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014B4A RID: 84810 RVA: 0x00301C13 File Offset: 0x002FFE13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014B4B RID: 84811 RVA: 0x00301C1C File Offset: 0x002FFE1C
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
				if (num != 64U && num != 66U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ids_.AddEntriesFrom(ref input, ResetSpecialBonusNotify._repeated_ids_codec);
				}
			}
		}

		// Token: 0x04007D80 RID: 32128
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007D81 RID: 32129
		public const int IdsFieldNumber = 8;

		// Token: 0x04007D82 RID: 32130
		private static readonly FieldCodec<int> _repeated_ids_codec = FieldCodec.ForInt32(66U);

		// Token: 0x04007D83 RID: 32131
		private readonly RepeatedField<int> ids_ = new RepeatedField<int>();
	}
}
