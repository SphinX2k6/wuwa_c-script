using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000B8 RID: 184
	[NetMessage(EMessageId.AddUnlockedGuideNotify)]
	public sealed class AddUnlockedGuideNotify : IMessage<AddUnlockedGuideNotify>, IMessage, IEquatable<AddUnlockedGuideNotify>, IDeepCloneable<AddUnlockedGuideNotify>, IBufferMessage
	{
		// Token: 0x06001E4A RID: 7754 RVA: 0x00052EED File Offset: 0x000510ED
		[NullableContext(1)]
		public static AddUnlockedGuideNotify Create()
		{
			return new AddUnlockedGuideNotify();
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06001E4B RID: 7755 RVA: 0x00052EF4 File Offset: 0x000510F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06001E4C RID: 7756 RVA: 0x00052EF7 File Offset: 0x000510F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AddUnlockedGuideNotify.Descriptor;
			}
		}

		// Token: 0x06001E4D RID: 7757 RVA: 0x00052EFE File Offset: 0x000510FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddUnlockedGuideNotify()
		{
		}

		// Token: 0x06001E4E RID: 7758 RVA: 0x00052F11 File Offset: 0x00051111
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddUnlockedGuideNotify(AddUnlockedGuideNotify other) : this()
		{
			this.unlockedGuideIds_ = other.unlockedGuideIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001E4F RID: 7759 RVA: 0x00052F3B File Offset: 0x0005113B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddUnlockedGuideNotify Clone()
		{
			return new AddUnlockedGuideNotify(this);
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06001E50 RID: 7760 RVA: 0x00052F43 File Offset: 0x00051143
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockedGuideIds
		{
			get
			{
				return this.unlockedGuideIds_;
			}
		}

		// Token: 0x06001E51 RID: 7761 RVA: 0x00052F4B File Offset: 0x0005114B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AddUnlockedGuideNotify);
		}

		// Token: 0x06001E52 RID: 7762 RVA: 0x00052F59 File Offset: 0x00051159
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AddUnlockedGuideNotify other)
		{
			return other != null && (other == this || (this.unlockedGuideIds_.Equals(other.unlockedGuideIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001E53 RID: 7763 RVA: 0x00052F8C File Offset: 0x0005118C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.unlockedGuideIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001E54 RID: 7764 RVA: 0x00052FC0 File Offset: 0x000511C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001E55 RID: 7765 RVA: 0x00052FCD File Offset: 0x000511CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001E56 RID: 7766 RVA: 0x00052FD6 File Offset: 0x000511D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.unlockedGuideIds_.WriteTo(ref output, AddUnlockedGuideNotify._repeated_unlockedGuideIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001E57 RID: 7767 RVA: 0x00053000 File Offset: 0x00051200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.unlockedGuideIds_.CalculateSize(AddUnlockedGuideNotify._repeated_unlockedGuideIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001E58 RID: 7768 RVA: 0x00053039 File Offset: 0x00051239
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AddUnlockedGuideNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.unlockedGuideIds_.Add(other.unlockedGuideIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001E59 RID: 7769 RVA: 0x00053067 File Offset: 0x00051267
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001E5A RID: 7770 RVA: 0x00053070 File Offset: 0x00051270
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
				if (num != 72U && num != 74U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.unlockedGuideIds_.AddEntriesFrom(ref input, AddUnlockedGuideNotify._repeated_unlockedGuideIds_codec);
				}
			}
		}

		// Token: 0x040023A1 RID: 9121
		private UnknownFieldSet _unknownFields;

		// Token: 0x040023A2 RID: 9122
		public const int UnlockedGuideIdsFieldNumber = 9;

		// Token: 0x040023A3 RID: 9123
		private static readonly FieldCodec<int> _repeated_unlockedGuideIds_codec = FieldCodec.ForSInt32(74U);

		// Token: 0x040023A4 RID: 9124
		private readonly RepeatedField<int> unlockedGuideIds_ = new RepeatedField<int>();
	}
}
