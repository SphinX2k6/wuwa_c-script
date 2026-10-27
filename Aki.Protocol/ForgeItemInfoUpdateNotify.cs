using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000621 RID: 1569
	[NetMessage(EMessageId.ForgeItemInfoUpdateNotify)]
	public sealed class ForgeItemInfoUpdateNotify : IMessage<ForgeItemInfoUpdateNotify>, IMessage, IEquatable<ForgeItemInfoUpdateNotify>, IDeepCloneable<ForgeItemInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x060090C0 RID: 37056 RVA: 0x0015E517 File Offset: 0x0015C717
		[NullableContext(1)]
		public static ForgeItemInfoUpdateNotify Create()
		{
			return new ForgeItemInfoUpdateNotify();
		}

		// Token: 0x17001CBF RID: 7359
		// (get) Token: 0x060090C1 RID: 37057 RVA: 0x0015E51E File Offset: 0x0015C71E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001CC0 RID: 7360
		// (get) Token: 0x060090C2 RID: 37058 RVA: 0x0015E521 File Offset: 0x0015C721
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ForgeItemInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x060090C3 RID: 37059 RVA: 0x0015E528 File Offset: 0x0015C728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ForgeItemInfoUpdateNotify()
		{
		}

		// Token: 0x060090C4 RID: 37060 RVA: 0x0015E53B File Offset: 0x0015C73B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ForgeItemInfoUpdateNotify(ForgeItemInfoUpdateNotify other) : this()
		{
			this.forgeInfoList_ = other.forgeInfoList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060090C5 RID: 37061 RVA: 0x0015E565 File Offset: 0x0015C765
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ForgeItemInfoUpdateNotify Clone()
		{
			return new ForgeItemInfoUpdateNotify(this);
		}

		// Token: 0x17001CC1 RID: 7361
		// (get) Token: 0x060090C6 RID: 37062 RVA: 0x0015E56D File Offset: 0x0015C76D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OneForgeInfo> ForgeInfoList
		{
			get
			{
				return this.forgeInfoList_;
			}
		}

		// Token: 0x060090C7 RID: 37063 RVA: 0x0015E575 File Offset: 0x0015C775
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ForgeItemInfoUpdateNotify);
		}

		// Token: 0x060090C8 RID: 37064 RVA: 0x0015E583 File Offset: 0x0015C783
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ForgeItemInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.forgeInfoList_.Equals(other.forgeInfoList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060090C9 RID: 37065 RVA: 0x0015E5B8 File Offset: 0x0015C7B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.forgeInfoList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060090CA RID: 37066 RVA: 0x0015E5EC File Offset: 0x0015C7EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060090CB RID: 37067 RVA: 0x0015E5F9 File Offset: 0x0015C7F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060090CC RID: 37068 RVA: 0x0015E602 File Offset: 0x0015C802
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.forgeInfoList_.WriteTo(ref output, ForgeItemInfoUpdateNotify._repeated_forgeInfoList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060090CD RID: 37069 RVA: 0x0015E62C File Offset: 0x0015C82C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.forgeInfoList_.CalculateSize(ForgeItemInfoUpdateNotify._repeated_forgeInfoList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060090CE RID: 37070 RVA: 0x0015E665 File Offset: 0x0015C865
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ForgeItemInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.forgeInfoList_.Add(other.forgeInfoList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060090CF RID: 37071 RVA: 0x0015E693 File Offset: 0x0015C893
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060090D0 RID: 37072 RVA: 0x0015E69C File Offset: 0x0015C89C
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
				if (num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.forgeInfoList_.AddEntriesFrom(ref input, ForgeItemInfoUpdateNotify._repeated_forgeInfoList_codec);
				}
			}
		}

		// Token: 0x04004604 RID: 17924
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004605 RID: 17925
		public const int ForgeInfoListFieldNumber = 4;

		// Token: 0x04004606 RID: 17926
		private static readonly FieldCodec<OneForgeInfo> _repeated_forgeInfoList_codec = FieldCodec.ForMessage<OneForgeInfo>(34U, OneForgeInfo.Parser);

		// Token: 0x04004607 RID: 17927
		private readonly RepeatedField<OneForgeInfo> forgeInfoList_ = new RepeatedField<OneForgeInfo>();
	}
}
