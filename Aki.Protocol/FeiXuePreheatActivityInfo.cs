using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000531 RID: 1329
	public sealed class FeiXuePreheatActivityInfo : IMessage<FeiXuePreheatActivityInfo>, IMessage, IEquatable<FeiXuePreheatActivityInfo>, IDeepCloneable<FeiXuePreheatActivityInfo>, IBufferMessage
	{
		// Token: 0x06007C82 RID: 31874 RVA: 0x0012D9EF File Offset: 0x0012BBEF
		[NullableContext(1)]
		public static FeiXuePreheatActivityInfo Create()
		{
			return new FeiXuePreheatActivityInfo();
		}

		// Token: 0x17001829 RID: 6185
		// (get) Token: 0x06007C83 RID: 31875 RVA: 0x0012D9F6 File Offset: 0x0012BBF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700182A RID: 6186
		// (get) Token: 0x06007C84 RID: 31876 RVA: 0x0012D9F9 File Offset: 0x0012BBF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FeiXuePreheatActivityInfo.Descriptor;
			}
		}

		// Token: 0x06007C85 RID: 31877 RVA: 0x0012DA00 File Offset: 0x0012BC00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FeiXuePreheatActivityInfo()
		{
		}

		// Token: 0x06007C86 RID: 31878 RVA: 0x0012DA13 File Offset: 0x0012BC13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FeiXuePreheatActivityInfo(FeiXuePreheatActivityInfo other) : this()
		{
			this.feiXuePreheatInfos_ = other.feiXuePreheatInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007C87 RID: 31879 RVA: 0x0012DA3D File Offset: 0x0012BC3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FeiXuePreheatActivityInfo Clone()
		{
			return new FeiXuePreheatActivityInfo(this);
		}

		// Token: 0x1700182B RID: 6187
		// (get) Token: 0x06007C88 RID: 31880 RVA: 0x0012DA45 File Offset: 0x0012BC45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FeiXuePreheatInfo> FeiXuePreheatInfos
		{
			get
			{
				return this.feiXuePreheatInfos_;
			}
		}

		// Token: 0x06007C89 RID: 31881 RVA: 0x0012DA4D File Offset: 0x0012BC4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FeiXuePreheatActivityInfo);
		}

		// Token: 0x06007C8A RID: 31882 RVA: 0x0012DA5B File Offset: 0x0012BC5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FeiXuePreheatActivityInfo other)
		{
			return other != null && (other == this || (this.feiXuePreheatInfos_.Equals(other.feiXuePreheatInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007C8B RID: 31883 RVA: 0x0012DA90 File Offset: 0x0012BC90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.feiXuePreheatInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007C8C RID: 31884 RVA: 0x0012DAC4 File Offset: 0x0012BCC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007C8D RID: 31885 RVA: 0x0012DAD1 File Offset: 0x0012BCD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007C8E RID: 31886 RVA: 0x0012DADA File Offset: 0x0012BCDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.feiXuePreheatInfos_.WriteTo(ref output, FeiXuePreheatActivityInfo._repeated_feiXuePreheatInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007C8F RID: 31887 RVA: 0x0012DB04 File Offset: 0x0012BD04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.feiXuePreheatInfos_.CalculateSize(FeiXuePreheatActivityInfo._repeated_feiXuePreheatInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007C90 RID: 31888 RVA: 0x0012DB3D File Offset: 0x0012BD3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FeiXuePreheatActivityInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.feiXuePreheatInfos_.Add(other.feiXuePreheatInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007C91 RID: 31889 RVA: 0x0012DB6B File Offset: 0x0012BD6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007C92 RID: 31890 RVA: 0x0012DB74 File Offset: 0x0012BD74
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.feiXuePreheatInfos_.AddEntriesFrom(ref input, FeiXuePreheatActivityInfo._repeated_feiXuePreheatInfos_codec);
				}
			}
		}

		// Token: 0x04003F73 RID: 16243
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F74 RID: 16244
		public const int FeiXuePreheatInfosFieldNumber = 1;

		// Token: 0x04003F75 RID: 16245
		private static readonly FieldCodec<FeiXuePreheatInfo> _repeated_feiXuePreheatInfos_codec = FieldCodec.ForMessage<FeiXuePreheatInfo>(10U, FeiXuePreheatInfo.Parser);

		// Token: 0x04003F76 RID: 16246
		private readonly RepeatedField<FeiXuePreheatInfo> feiXuePreheatInfos_ = new RepeatedField<FeiXuePreheatInfo>();
	}
}
