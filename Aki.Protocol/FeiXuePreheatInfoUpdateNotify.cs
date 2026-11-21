using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000520 RID: 1312
	[NetMessage(EMessageId.FeiXuePreheatInfoUpdateNotify)]
	public sealed class FeiXuePreheatInfoUpdateNotify : IMessage<FeiXuePreheatInfoUpdateNotify>, IMessage, IEquatable<FeiXuePreheatInfoUpdateNotify>, IDeepCloneable<FeiXuePreheatInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x06007B6A RID: 31594 RVA: 0x0012B7BD File Offset: 0x001299BD
		[NullableContext(1)]
		public static FeiXuePreheatInfoUpdateNotify Create()
		{
			return new FeiXuePreheatInfoUpdateNotify();
		}

		// Token: 0x170017EC RID: 6124
		// (get) Token: 0x06007B6B RID: 31595 RVA: 0x0012B7C4 File Offset: 0x001299C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170017ED RID: 6125
		// (get) Token: 0x06007B6C RID: 31596 RVA: 0x0012B7C7 File Offset: 0x001299C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FeiXuePreheatInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06007B6D RID: 31597 RVA: 0x0012B7CE File Offset: 0x001299CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FeiXuePreheatInfoUpdateNotify()
		{
		}

		// Token: 0x06007B6E RID: 31598 RVA: 0x0012B7E1 File Offset: 0x001299E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FeiXuePreheatInfoUpdateNotify(FeiXuePreheatInfoUpdateNotify other) : this()
		{
			this.feiXuePreheatInfos_ = other.feiXuePreheatInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007B6F RID: 31599 RVA: 0x0012B80B File Offset: 0x00129A0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FeiXuePreheatInfoUpdateNotify Clone()
		{
			return new FeiXuePreheatInfoUpdateNotify(this);
		}

		// Token: 0x170017EE RID: 6126
		// (get) Token: 0x06007B70 RID: 31600 RVA: 0x0012B813 File Offset: 0x00129A13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FeiXuePreheatInfo> FeiXuePreheatInfos
		{
			get
			{
				return this.feiXuePreheatInfos_;
			}
		}

		// Token: 0x06007B71 RID: 31601 RVA: 0x0012B81B File Offset: 0x00129A1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FeiXuePreheatInfoUpdateNotify);
		}

		// Token: 0x06007B72 RID: 31602 RVA: 0x0012B829 File Offset: 0x00129A29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FeiXuePreheatInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.feiXuePreheatInfos_.Equals(other.feiXuePreheatInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007B73 RID: 31603 RVA: 0x0012B85C File Offset: 0x00129A5C
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

		// Token: 0x06007B74 RID: 31604 RVA: 0x0012B890 File Offset: 0x00129A90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007B75 RID: 31605 RVA: 0x0012B89D File Offset: 0x00129A9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007B76 RID: 31606 RVA: 0x0012B8A6 File Offset: 0x00129AA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.feiXuePreheatInfos_.WriteTo(ref output, FeiXuePreheatInfoUpdateNotify._repeated_feiXuePreheatInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007B77 RID: 31607 RVA: 0x0012B8D0 File Offset: 0x00129AD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.feiXuePreheatInfos_.CalculateSize(FeiXuePreheatInfoUpdateNotify._repeated_feiXuePreheatInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007B78 RID: 31608 RVA: 0x0012B909 File Offset: 0x00129B09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FeiXuePreheatInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.feiXuePreheatInfos_.Add(other.feiXuePreheatInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007B79 RID: 31609 RVA: 0x0012B937 File Offset: 0x00129B37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007B7A RID: 31610 RVA: 0x0012B940 File Offset: 0x00129B40
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
					this.feiXuePreheatInfos_.AddEntriesFrom(ref input, FeiXuePreheatInfoUpdateNotify._repeated_feiXuePreheatInfos_codec);
				}
			}
		}

		// Token: 0x04003F7E RID: 16254
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F7F RID: 16255
		public const int FeiXuePreheatInfosFieldNumber = 6;

		// Token: 0x04003F80 RID: 16256
		private static readonly FieldCodec<FeiXuePreheatInfo> _repeated_feiXuePreheatInfos_codec = FieldCodec.ForMessage<FeiXuePreheatInfo>(50U, FeiXuePreheatInfo.Parser);

		// Token: 0x04003F81 RID: 16257
		private readonly RepeatedField<FeiXuePreheatInfo> feiXuePreheatInfos_ = new RepeatedField<FeiXuePreheatInfo>();
	}
}
