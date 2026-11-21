using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200088F RID: 2191
	[NetMessage(EMessageId.KurotatoLevelDataUpdateNotify)]
	public sealed class KurotatoLevelDataUpdateNotify : IMessage<KurotatoLevelDataUpdateNotify>, IMessage, IEquatable<KurotatoLevelDataUpdateNotify>, IDeepCloneable<KurotatoLevelDataUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600C316 RID: 49942 RVA: 0x001CF20A File Offset: 0x001CD40A
		[NullableContext(1)]
		public static KurotatoLevelDataUpdateNotify Create()
		{
			return new KurotatoLevelDataUpdateNotify();
		}

		// Token: 0x1700276B RID: 10091
		// (get) Token: 0x0600C317 RID: 49943 RVA: 0x001CF211 File Offset: 0x001CD411
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700276C RID: 10092
		// (get) Token: 0x0600C318 RID: 49944 RVA: 0x001CF214 File Offset: 0x001CD414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoLevelDataUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600C319 RID: 49945 RVA: 0x001CF21B File Offset: 0x001CD41B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoLevelDataUpdateNotify()
		{
		}

		// Token: 0x0600C31A RID: 49946 RVA: 0x001CF22E File Offset: 0x001CD42E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoLevelDataUpdateNotify(KurotatoLevelDataUpdateNotify other) : this()
		{
			this.kurotatoLevelInfos_ = other.kurotatoLevelInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C31B RID: 49947 RVA: 0x001CF258 File Offset: 0x001CD458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoLevelDataUpdateNotify Clone()
		{
			return new KurotatoLevelDataUpdateNotify(this);
		}

		// Token: 0x1700276D RID: 10093
		// (get) Token: 0x0600C31C RID: 49948 RVA: 0x001CF260 File Offset: 0x001CD460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<KurotatoLevelInfo> KurotatoLevelInfos
		{
			get
			{
				return this.kurotatoLevelInfos_;
			}
		}

		// Token: 0x0600C31D RID: 49949 RVA: 0x001CF268 File Offset: 0x001CD468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoLevelDataUpdateNotify);
		}

		// Token: 0x0600C31E RID: 49950 RVA: 0x001CF276 File Offset: 0x001CD476
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoLevelDataUpdateNotify other)
		{
			return other != null && (other == this || (this.kurotatoLevelInfos_.Equals(other.kurotatoLevelInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C31F RID: 49951 RVA: 0x001CF2AC File Offset: 0x001CD4AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.kurotatoLevelInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C320 RID: 49952 RVA: 0x001CF2E0 File Offset: 0x001CD4E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C321 RID: 49953 RVA: 0x001CF2ED File Offset: 0x001CD4ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C322 RID: 49954 RVA: 0x001CF2F6 File Offset: 0x001CD4F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.kurotatoLevelInfos_.WriteTo(ref output, KurotatoLevelDataUpdateNotify._repeated_kurotatoLevelInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C323 RID: 49955 RVA: 0x001CF320 File Offset: 0x001CD520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.kurotatoLevelInfos_.CalculateSize(KurotatoLevelDataUpdateNotify._repeated_kurotatoLevelInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C324 RID: 49956 RVA: 0x001CF359 File Offset: 0x001CD559
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoLevelDataUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.kurotatoLevelInfos_.Add(other.kurotatoLevelInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C325 RID: 49957 RVA: 0x001CF387 File Offset: 0x001CD587
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C326 RID: 49958 RVA: 0x001CF390 File Offset: 0x001CD590
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
				if (num != 66U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.kurotatoLevelInfos_.AddEntriesFrom(ref input, KurotatoLevelDataUpdateNotify._repeated_kurotatoLevelInfos_codec);
				}
			}
		}

		// Token: 0x040054B0 RID: 21680
		private UnknownFieldSet _unknownFields;

		// Token: 0x040054B1 RID: 21681
		public const int KurotatoLevelInfosFieldNumber = 8;

		// Token: 0x040054B2 RID: 21682
		private static readonly FieldCodec<KurotatoLevelInfo> _repeated_kurotatoLevelInfos_codec = FieldCodec.ForMessage<KurotatoLevelInfo>(66U, KurotatoLevelInfo.Parser);

		// Token: 0x040054B3 RID: 21683
		private readonly RepeatedField<KurotatoLevelInfo> kurotatoLevelInfos_ = new RepeatedField<KurotatoLevelInfo>();
	}
}
