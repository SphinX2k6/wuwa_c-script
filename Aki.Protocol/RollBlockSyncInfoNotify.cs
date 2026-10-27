using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010E8 RID: 4328
	[NetMessage(EMessageId.RollBlockSyncInfoNotify)]
	public sealed class RollBlockSyncInfoNotify : IMessage<RollBlockSyncInfoNotify>, IMessage, IEquatable<RollBlockSyncInfoNotify>, IDeepCloneable<RollBlockSyncInfoNotify>, IBufferMessage
	{
		// Token: 0x06017151 RID: 94545 RVA: 0x003596CF File Offset: 0x003578CF
		[NullableContext(1)]
		public static RollBlockSyncInfoNotify Create()
		{
			return new RollBlockSyncInfoNotify();
		}

		// Token: 0x17004D4F RID: 19791
		// (get) Token: 0x06017152 RID: 94546 RVA: 0x003596D6 File Offset: 0x003578D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004D50 RID: 19792
		// (get) Token: 0x06017153 RID: 94547 RVA: 0x003596D9 File Offset: 0x003578D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RollBlockSyncInfoNotify.Descriptor;
			}
		}

		// Token: 0x06017154 RID: 94548 RVA: 0x003596E0 File Offset: 0x003578E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockSyncInfoNotify()
		{
		}

		// Token: 0x06017155 RID: 94549 RVA: 0x003596F3 File Offset: 0x003578F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockSyncInfoNotify(RollBlockSyncInfoNotify other) : this()
		{
			this.fullInfos_ = other.fullInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017156 RID: 94550 RVA: 0x0035971D File Offset: 0x0035791D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockSyncInfoNotify Clone()
		{
			return new RollBlockSyncInfoNotify(this);
		}

		// Token: 0x17004D51 RID: 19793
		// (get) Token: 0x06017157 RID: 94551 RVA: 0x00359725 File Offset: 0x00357925
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RollBlockGamePlayPbInfo> FullInfos
		{
			get
			{
				return this.fullInfos_;
			}
		}

		// Token: 0x06017158 RID: 94552 RVA: 0x0035972D File Offset: 0x0035792D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RollBlockSyncInfoNotify);
		}

		// Token: 0x06017159 RID: 94553 RVA: 0x0035973B File Offset: 0x0035793B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RollBlockSyncInfoNotify other)
		{
			return other != null && (other == this || (this.fullInfos_.Equals(other.fullInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601715A RID: 94554 RVA: 0x00359770 File Offset: 0x00357970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.fullInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601715B RID: 94555 RVA: 0x003597A4 File Offset: 0x003579A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601715C RID: 94556 RVA: 0x003597B1 File Offset: 0x003579B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601715D RID: 94557 RVA: 0x003597BA File Offset: 0x003579BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.fullInfos_.WriteTo(ref output, RollBlockSyncInfoNotify._repeated_fullInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601715E RID: 94558 RVA: 0x003597E4 File Offset: 0x003579E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.fullInfos_.CalculateSize(RollBlockSyncInfoNotify._repeated_fullInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601715F RID: 94559 RVA: 0x0035981D File Offset: 0x00357A1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RollBlockSyncInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.fullInfos_.Add(other.fullInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017160 RID: 94560 RVA: 0x0035984B File Offset: 0x00357A4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017161 RID: 94561 RVA: 0x00359854 File Offset: 0x00357A54
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
				if (num != 42U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.fullInfos_.AddEntriesFrom(ref input, RollBlockSyncInfoNotify._repeated_fullInfos_codec);
				}
			}
		}

		// Token: 0x0400894A RID: 35146
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400894B RID: 35147
		public const int FullInfosFieldNumber = 5;

		// Token: 0x0400894C RID: 35148
		private static readonly FieldCodec<RollBlockGamePlayPbInfo> _repeated_fullInfos_codec = FieldCodec.ForMessage<RollBlockGamePlayPbInfo>(42U, RollBlockGamePlayPbInfo.Parser);

		// Token: 0x0400894D RID: 35149
		private readonly RepeatedField<RollBlockGamePlayPbInfo> fullInfos_ = new RepeatedField<RollBlockGamePlayPbInfo>();
	}
}
