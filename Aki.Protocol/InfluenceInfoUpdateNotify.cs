using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007BD RID: 1981
	[NetMessage(EMessageId.InfluenceInfoUpdateNotify)]
	public sealed class InfluenceInfoUpdateNotify : IMessage<InfluenceInfoUpdateNotify>, IMessage, IEquatable<InfluenceInfoUpdateNotify>, IDeepCloneable<InfluenceInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600B288 RID: 45704 RVA: 0x001ABB05 File Offset: 0x001A9D05
		[NullableContext(1)]
		public static InfluenceInfoUpdateNotify Create()
		{
			return new InfluenceInfoUpdateNotify();
		}

		// Token: 0x17002401 RID: 9217
		// (get) Token: 0x0600B289 RID: 45705 RVA: 0x001ABB0C File Offset: 0x001A9D0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002402 RID: 9218
		// (get) Token: 0x0600B28A RID: 45706 RVA: 0x001ABB0F File Offset: 0x001A9D0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfluenceInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600B28B RID: 45707 RVA: 0x001ABB16 File Offset: 0x001A9D16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfluenceInfoUpdateNotify()
		{
		}

		// Token: 0x0600B28C RID: 45708 RVA: 0x001ABB29 File Offset: 0x001A9D29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfluenceInfoUpdateNotify(InfluenceInfoUpdateNotify other) : this()
		{
			this.influenceInfos_ = other.influenceInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B28D RID: 45709 RVA: 0x001ABB53 File Offset: 0x001A9D53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfluenceInfoUpdateNotify Clone()
		{
			return new InfluenceInfoUpdateNotify(this);
		}

		// Token: 0x17002403 RID: 9219
		// (get) Token: 0x0600B28E RID: 45710 RVA: 0x001ABB5B File Offset: 0x001A9D5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OneInfluenceInfo> InfluenceInfos
		{
			get
			{
				return this.influenceInfos_;
			}
		}

		// Token: 0x0600B28F RID: 45711 RVA: 0x001ABB63 File Offset: 0x001A9D63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfluenceInfoUpdateNotify);
		}

		// Token: 0x0600B290 RID: 45712 RVA: 0x001ABB71 File Offset: 0x001A9D71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfluenceInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.influenceInfos_.Equals(other.influenceInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B291 RID: 45713 RVA: 0x001ABBA4 File Offset: 0x001A9DA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.influenceInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B292 RID: 45714 RVA: 0x001ABBD8 File Offset: 0x001A9DD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B293 RID: 45715 RVA: 0x001ABBE5 File Offset: 0x001A9DE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B294 RID: 45716 RVA: 0x001ABBEE File Offset: 0x001A9DEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.influenceInfos_.WriteTo(ref output, InfluenceInfoUpdateNotify._repeated_influenceInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B295 RID: 45717 RVA: 0x001ABC18 File Offset: 0x001A9E18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.influenceInfos_.CalculateSize(InfluenceInfoUpdateNotify._repeated_influenceInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B296 RID: 45718 RVA: 0x001ABC51 File Offset: 0x001A9E51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfluenceInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.influenceInfos_.Add(other.influenceInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B297 RID: 45719 RVA: 0x001ABC7F File Offset: 0x001A9E7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B298 RID: 45720 RVA: 0x001ABC88 File Offset: 0x001A9E88
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
				if (num != 58U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.influenceInfos_.AddEntriesFrom(ref input, InfluenceInfoUpdateNotify._repeated_influenceInfos_codec);
				}
			}
		}

		// Token: 0x04005022 RID: 20514
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005023 RID: 20515
		public const int InfluenceInfosFieldNumber = 7;

		// Token: 0x04005024 RID: 20516
		private static readonly FieldCodec<OneInfluenceInfo> _repeated_influenceInfos_codec = FieldCodec.ForMessage<OneInfluenceInfo>(58U, OneInfluenceInfo.Parser);

		// Token: 0x04005025 RID: 20517
		private readonly RepeatedField<OneInfluenceInfo> influenceInfos_ = new RepeatedField<OneInfluenceInfo>();
	}
}
