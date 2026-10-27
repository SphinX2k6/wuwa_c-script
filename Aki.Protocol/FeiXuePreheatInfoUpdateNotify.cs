using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000535 RID: 1333
	[NetMessage(EMessageId.FeiXuePreheatInfoUpdateNotify)]
	public sealed class FeiXuePreheatInfoUpdateNotify : IMessage<FeiXuePreheatInfoUpdateNotify>, IMessage, IEquatable<FeiXuePreheatInfoUpdateNotify>, IDeepCloneable<FeiXuePreheatInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x06007CD2 RID: 31954 RVA: 0x0012E3C1 File Offset: 0x0012C5C1
		[NullableContext(1)]
		public static FeiXuePreheatInfoUpdateNotify Create()
		{
			return new FeiXuePreheatInfoUpdateNotify();
		}

		// Token: 0x17001839 RID: 6201
		// (get) Token: 0x06007CD3 RID: 31955 RVA: 0x0012E3C8 File Offset: 0x0012C5C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700183A RID: 6202
		// (get) Token: 0x06007CD4 RID: 31956 RVA: 0x0012E3CB File Offset: 0x0012C5CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FeiXuePreheatInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06007CD5 RID: 31957 RVA: 0x0012E3D2 File Offset: 0x0012C5D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FeiXuePreheatInfoUpdateNotify()
		{
		}

		// Token: 0x06007CD6 RID: 31958 RVA: 0x0012E3E5 File Offset: 0x0012C5E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FeiXuePreheatInfoUpdateNotify(FeiXuePreheatInfoUpdateNotify other) : this()
		{
			this.feiXuePreheatInfos_ = other.feiXuePreheatInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007CD7 RID: 31959 RVA: 0x0012E40F File Offset: 0x0012C60F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FeiXuePreheatInfoUpdateNotify Clone()
		{
			return new FeiXuePreheatInfoUpdateNotify(this);
		}

		// Token: 0x1700183B RID: 6203
		// (get) Token: 0x06007CD8 RID: 31960 RVA: 0x0012E417 File Offset: 0x0012C617
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FeiXuePreheatInfo> FeiXuePreheatInfos
		{
			get
			{
				return this.feiXuePreheatInfos_;
			}
		}

		// Token: 0x06007CD9 RID: 31961 RVA: 0x0012E41F File Offset: 0x0012C61F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FeiXuePreheatInfoUpdateNotify);
		}

		// Token: 0x06007CDA RID: 31962 RVA: 0x0012E42D File Offset: 0x0012C62D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FeiXuePreheatInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.feiXuePreheatInfos_.Equals(other.feiXuePreheatInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007CDB RID: 31963 RVA: 0x0012E460 File Offset: 0x0012C660
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

		// Token: 0x06007CDC RID: 31964 RVA: 0x0012E494 File Offset: 0x0012C694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007CDD RID: 31965 RVA: 0x0012E4A1 File Offset: 0x0012C6A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007CDE RID: 31966 RVA: 0x0012E4AA File Offset: 0x0012C6AA
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

		// Token: 0x06007CDF RID: 31967 RVA: 0x0012E4D4 File Offset: 0x0012C6D4
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

		// Token: 0x06007CE0 RID: 31968 RVA: 0x0012E50D File Offset: 0x0012C70D
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

		// Token: 0x06007CE1 RID: 31969 RVA: 0x0012E53B File Offset: 0x0012C73B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007CE2 RID: 31970 RVA: 0x0012E544 File Offset: 0x0012C744
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

		// Token: 0x04003F88 RID: 16264
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F89 RID: 16265
		public const int FeiXuePreheatInfosFieldNumber = 6;

		// Token: 0x04003F8A RID: 16266
		private static readonly FieldCodec<FeiXuePreheatInfo> _repeated_feiXuePreheatInfos_codec = FieldCodec.ForMessage<FeiXuePreheatInfo>(50U, FeiXuePreheatInfo.Parser);

		// Token: 0x04003F8B RID: 16267
		private readonly RepeatedField<FeiXuePreheatInfo> feiXuePreheatInfos_ = new RepeatedField<FeiXuePreheatInfo>();
	}
}
