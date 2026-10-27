using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008A0 RID: 2208
	[NetMessage(EMessageId.KurotatoLevelDataUpdateNotify)]
	public sealed class KurotatoLevelDataUpdateNotify : IMessage<KurotatoLevelDataUpdateNotify>, IMessage, IEquatable<KurotatoLevelDataUpdateNotify>, IDeepCloneable<KurotatoLevelDataUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600C432 RID: 50226 RVA: 0x001D14EE File Offset: 0x001CF6EE
		[NullableContext(1)]
		public static KurotatoLevelDataUpdateNotify Create()
		{
			return new KurotatoLevelDataUpdateNotify();
		}

		// Token: 0x170027AA RID: 10154
		// (get) Token: 0x0600C433 RID: 50227 RVA: 0x001D14F5 File Offset: 0x001CF6F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170027AB RID: 10155
		// (get) Token: 0x0600C434 RID: 50228 RVA: 0x001D14F8 File Offset: 0x001CF6F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoLevelDataUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600C435 RID: 50229 RVA: 0x001D14FF File Offset: 0x001CF6FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoLevelDataUpdateNotify()
		{
		}

		// Token: 0x0600C436 RID: 50230 RVA: 0x001D1512 File Offset: 0x001CF712
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoLevelDataUpdateNotify(KurotatoLevelDataUpdateNotify other) : this()
		{
			this.kurotatoLevelInfos_ = other.kurotatoLevelInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C437 RID: 50231 RVA: 0x001D153C File Offset: 0x001CF73C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoLevelDataUpdateNotify Clone()
		{
			return new KurotatoLevelDataUpdateNotify(this);
		}

		// Token: 0x170027AC RID: 10156
		// (get) Token: 0x0600C438 RID: 50232 RVA: 0x001D1544 File Offset: 0x001CF744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<KurotatoLevelInfo> KurotatoLevelInfos
		{
			get
			{
				return this.kurotatoLevelInfos_;
			}
		}

		// Token: 0x0600C439 RID: 50233 RVA: 0x001D154C File Offset: 0x001CF74C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoLevelDataUpdateNotify);
		}

		// Token: 0x0600C43A RID: 50234 RVA: 0x001D155A File Offset: 0x001CF75A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoLevelDataUpdateNotify other)
		{
			return other != null && (other == this || (this.kurotatoLevelInfos_.Equals(other.kurotatoLevelInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C43B RID: 50235 RVA: 0x001D1590 File Offset: 0x001CF790
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

		// Token: 0x0600C43C RID: 50236 RVA: 0x001D15C4 File Offset: 0x001CF7C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C43D RID: 50237 RVA: 0x001D15D1 File Offset: 0x001CF7D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C43E RID: 50238 RVA: 0x001D15DA File Offset: 0x001CF7DA
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

		// Token: 0x0600C43F RID: 50239 RVA: 0x001D1604 File Offset: 0x001CF804
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

		// Token: 0x0600C440 RID: 50240 RVA: 0x001D163D File Offset: 0x001CF83D
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

		// Token: 0x0600C441 RID: 50241 RVA: 0x001D166B File Offset: 0x001CF86B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C442 RID: 50242 RVA: 0x001D1674 File Offset: 0x001CF874
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
					this.kurotatoLevelInfos_.AddEntriesFrom(ref input, KurotatoLevelDataUpdateNotify._repeated_kurotatoLevelInfos_codec);
				}
			}
		}

		// Token: 0x040054A9 RID: 21673
		private UnknownFieldSet _unknownFields;

		// Token: 0x040054AA RID: 21674
		public const int KurotatoLevelInfosFieldNumber = 4;

		// Token: 0x040054AB RID: 21675
		private static readonly FieldCodec<KurotatoLevelInfo> _repeated_kurotatoLevelInfos_codec = FieldCodec.ForMessage<KurotatoLevelInfo>(34U, KurotatoLevelInfo.Parser);

		// Token: 0x040054AC RID: 21676
		private readonly RepeatedField<KurotatoLevelInfo> kurotatoLevelInfos_ = new RepeatedField<KurotatoLevelInfo>();
	}
}
