using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CD2 RID: 3282
	[NetMessage(EMessageId.PhantomItemUpdateNotify)]
	public sealed class PhantomItemUpdateNotify : IMessage<PhantomItemUpdateNotify>, IMessage, IEquatable<PhantomItemUpdateNotify>, IDeepCloneable<PhantomItemUpdateNotify>, IBufferMessage
	{
		// Token: 0x06011C89 RID: 72841 RVA: 0x0029AAE8 File Offset: 0x00298CE8
		[NullableContext(1)]
		public static PhantomItemUpdateNotify Create()
		{
			return new PhantomItemUpdateNotify();
		}

		// Token: 0x17003AF0 RID: 15088
		// (get) Token: 0x06011C8A RID: 72842 RVA: 0x0029AAEF File Offset: 0x00298CEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003AF1 RID: 15089
		// (get) Token: 0x06011C8B RID: 72843 RVA: 0x0029AAF2 File Offset: 0x00298CF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomItemUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06011C8C RID: 72844 RVA: 0x0029AAF9 File Offset: 0x00298CF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomItemUpdateNotify()
		{
		}

		// Token: 0x06011C8D RID: 72845 RVA: 0x0029AB0C File Offset: 0x00298D0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomItemUpdateNotify(PhantomItemUpdateNotify other) : this()
		{
			this.updateInfo_ = other.updateInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011C8E RID: 72846 RVA: 0x0029AB36 File Offset: 0x00298D36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomItemUpdateNotify Clone()
		{
			return new PhantomItemUpdateNotify(this);
		}

		// Token: 0x17003AF2 RID: 15090
		// (get) Token: 0x06011C8F RID: 72847 RVA: 0x0029AB3E File Offset: 0x00298D3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomItem> UpdateInfo
		{
			get
			{
				return this.updateInfo_;
			}
		}

		// Token: 0x06011C90 RID: 72848 RVA: 0x0029AB46 File Offset: 0x00298D46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomItemUpdateNotify);
		}

		// Token: 0x06011C91 RID: 72849 RVA: 0x0029AB54 File Offset: 0x00298D54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomItemUpdateNotify other)
		{
			return other != null && (other == this || (this.updateInfo_.Equals(other.updateInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011C92 RID: 72850 RVA: 0x0029AB88 File Offset: 0x00298D88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.updateInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011C93 RID: 72851 RVA: 0x0029ABBC File Offset: 0x00298DBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011C94 RID: 72852 RVA: 0x0029ABC9 File Offset: 0x00298DC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011C95 RID: 72853 RVA: 0x0029ABD2 File Offset: 0x00298DD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.updateInfo_.WriteTo(ref output, PhantomItemUpdateNotify._repeated_updateInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011C96 RID: 72854 RVA: 0x0029ABFC File Offset: 0x00298DFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.updateInfo_.CalculateSize(PhantomItemUpdateNotify._repeated_updateInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011C97 RID: 72855 RVA: 0x0029AC35 File Offset: 0x00298E35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomItemUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.updateInfo_.Add(other.updateInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011C98 RID: 72856 RVA: 0x0029AC63 File Offset: 0x00298E63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011C99 RID: 72857 RVA: 0x0029AC6C File Offset: 0x00298E6C
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
					this.updateInfo_.AddEntriesFrom(ref input, PhantomItemUpdateNotify._repeated_updateInfo_codec);
				}
			}
		}

		// Token: 0x04007028 RID: 28712
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007029 RID: 28713
		public const int UpdateInfoFieldNumber = 11;

		// Token: 0x0400702A RID: 28714
		private static readonly FieldCodec<PhantomItem> _repeated_updateInfo_codec = FieldCodec.ForMessage<PhantomItem>(90U, PhantomItem.Parser);

		// Token: 0x0400702B RID: 28715
		private readonly RepeatedField<PhantomItem> updateInfo_ = new RepeatedField<PhantomItem>();
	}
}
