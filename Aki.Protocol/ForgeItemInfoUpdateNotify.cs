using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200060D RID: 1549
	[NetMessage(EMessageId.ForgeItemInfoUpdateNotify)]
	public sealed class ForgeItemInfoUpdateNotify : IMessage<ForgeItemInfoUpdateNotify>, IMessage, IEquatable<ForgeItemInfoUpdateNotify>, IDeepCloneable<ForgeItemInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x06008F6A RID: 36714 RVA: 0x0015BAE3 File Offset: 0x00159CE3
		[NullableContext(1)]
		public static ForgeItemInfoUpdateNotify Create()
		{
			return new ForgeItemInfoUpdateNotify();
		}

		// Token: 0x17001C75 RID: 7285
		// (get) Token: 0x06008F6B RID: 36715 RVA: 0x0015BAEA File Offset: 0x00159CEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001C76 RID: 7286
		// (get) Token: 0x06008F6C RID: 36716 RVA: 0x0015BAED File Offset: 0x00159CED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ForgeItemInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06008F6D RID: 36717 RVA: 0x0015BAF4 File Offset: 0x00159CF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ForgeItemInfoUpdateNotify()
		{
		}

		// Token: 0x06008F6E RID: 36718 RVA: 0x0015BB07 File Offset: 0x00159D07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ForgeItemInfoUpdateNotify(ForgeItemInfoUpdateNotify other) : this()
		{
			this.forgeInfoList_ = other.forgeInfoList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008F6F RID: 36719 RVA: 0x0015BB31 File Offset: 0x00159D31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ForgeItemInfoUpdateNotify Clone()
		{
			return new ForgeItemInfoUpdateNotify(this);
		}

		// Token: 0x17001C77 RID: 7287
		// (get) Token: 0x06008F70 RID: 36720 RVA: 0x0015BB39 File Offset: 0x00159D39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OneForgeInfo> ForgeInfoList
		{
			get
			{
				return this.forgeInfoList_;
			}
		}

		// Token: 0x06008F71 RID: 36721 RVA: 0x0015BB41 File Offset: 0x00159D41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ForgeItemInfoUpdateNotify);
		}

		// Token: 0x06008F72 RID: 36722 RVA: 0x0015BB4F File Offset: 0x00159D4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ForgeItemInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.forgeInfoList_.Equals(other.forgeInfoList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008F73 RID: 36723 RVA: 0x0015BB84 File Offset: 0x00159D84
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

		// Token: 0x06008F74 RID: 36724 RVA: 0x0015BBB8 File Offset: 0x00159DB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008F75 RID: 36725 RVA: 0x0015BBC5 File Offset: 0x00159DC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008F76 RID: 36726 RVA: 0x0015BBCE File Offset: 0x00159DCE
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

		// Token: 0x06008F77 RID: 36727 RVA: 0x0015BBF8 File Offset: 0x00159DF8
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

		// Token: 0x06008F78 RID: 36728 RVA: 0x0015BC31 File Offset: 0x00159E31
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

		// Token: 0x06008F79 RID: 36729 RVA: 0x0015BC5F File Offset: 0x00159E5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008F7A RID: 36730 RVA: 0x0015BC68 File Offset: 0x00159E68
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
					this.forgeInfoList_.AddEntriesFrom(ref input, ForgeItemInfoUpdateNotify._repeated_forgeInfoList_codec);
				}
			}
		}

		// Token: 0x040045FD RID: 17917
		private UnknownFieldSet _unknownFields;

		// Token: 0x040045FE RID: 17918
		public const int ForgeInfoListFieldNumber = 13;

		// Token: 0x040045FF RID: 17919
		private static readonly FieldCodec<OneForgeInfo> _repeated_forgeInfoList_codec = FieldCodec.ForMessage<OneForgeInfo>(106U, OneForgeInfo.Parser);

		// Token: 0x04004600 RID: 17920
		private readonly RepeatedField<OneForgeInfo> forgeInfoList_ = new RepeatedField<OneForgeInfo>();
	}
}
