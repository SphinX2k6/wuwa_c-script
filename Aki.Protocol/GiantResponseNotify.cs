using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006E2 RID: 1762
	[NetMessage(EMessageId.GiantResponseNotify)]
	public sealed class GiantResponseNotify : IMessage<GiantResponseNotify>, IMessage, IEquatable<GiantResponseNotify>, IDeepCloneable<GiantResponseNotify>, IBufferMessage
	{
		// Token: 0x0600A0C8 RID: 41160 RVA: 0x001853F5 File Offset: 0x001835F5
		[NullableContext(1)]
		public static GiantResponseNotify Create()
		{
			return new GiantResponseNotify();
		}

		// Token: 0x1700204C RID: 8268
		// (get) Token: 0x0600A0C9 RID: 41161 RVA: 0x001853FC File Offset: 0x001835FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700204D RID: 8269
		// (get) Token: 0x0600A0CA RID: 41162 RVA: 0x001853FF File Offset: 0x001835FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GiantResponseNotify.Descriptor;
			}
		}

		// Token: 0x0600A0CB RID: 41163 RVA: 0x00185406 File Offset: 0x00183606
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantResponseNotify()
		{
		}

		// Token: 0x0600A0CC RID: 41164 RVA: 0x00185419 File Offset: 0x00183619
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantResponseNotify(GiantResponseNotify other) : this()
		{
			this.giantIdleType_ = other.giantIdleType_;
			this.giantResponseInfos_ = other.giantResponseInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A0CD RID: 41165 RVA: 0x0018544F File Offset: 0x0018364F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantResponseNotify Clone()
		{
			return new GiantResponseNotify(this);
		}

		// Token: 0x1700204E RID: 8270
		// (get) Token: 0x0600A0CE RID: 41166 RVA: 0x00185457 File Offset: 0x00183657
		// (set) Token: 0x0600A0CF RID: 41167 RVA: 0x0018545F File Offset: 0x0018365F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantIdleNetType GiantIdleType
		{
			get
			{
				return this.giantIdleType_;
			}
			set
			{
				this.giantIdleType_ = value;
			}
		}

		// Token: 0x1700204F RID: 8271
		// (get) Token: 0x0600A0D0 RID: 41168 RVA: 0x00185468 File Offset: 0x00183668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GiantResponsePb> GiantResponseInfos
		{
			get
			{
				return this.giantResponseInfos_;
			}
		}

		// Token: 0x0600A0D1 RID: 41169 RVA: 0x00185470 File Offset: 0x00183670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GiantResponseNotify);
		}

		// Token: 0x0600A0D2 RID: 41170 RVA: 0x00185480 File Offset: 0x00183680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GiantResponseNotify other)
		{
			return other != null && (other == this || (this.GiantIdleType == other.GiantIdleType && this.giantResponseInfos_.Equals(other.giantResponseInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A0D3 RID: 41171 RVA: 0x001854D0 File Offset: 0x001836D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GiantIdleType != GiantIdleNetType.Common)
			{
				num ^= this.GiantIdleType.GetHashCode();
			}
			num ^= this.giantResponseInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A0D4 RID: 41172 RVA: 0x00185523 File Offset: 0x00183723
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A0D5 RID: 41173 RVA: 0x00185530 File Offset: 0x00183730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A0D6 RID: 41174 RVA: 0x0018553C File Offset: 0x0018373C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GiantIdleType != GiantIdleNetType.Common)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.GiantIdleType);
			}
			this.giantResponseInfos_.WriteTo(ref output, GiantResponseNotify._repeated_giantResponseInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A0D7 RID: 41175 RVA: 0x0018558C File Offset: 0x0018378C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GiantIdleType != GiantIdleNetType.Common)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.GiantIdleType);
			}
			num += this.giantResponseInfos_.CalculateSize(GiantResponseNotify._repeated_giantResponseInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A0D8 RID: 41176 RVA: 0x001855E0 File Offset: 0x001837E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GiantResponseNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GiantIdleType != GiantIdleNetType.Common)
			{
				this.GiantIdleType = other.GiantIdleType;
			}
			this.giantResponseInfos_.Add(other.giantResponseInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A0D9 RID: 41177 RVA: 0x0018562D File Offset: 0x0018382D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A0DA RID: 41178 RVA: 0x00185638 File Offset: 0x00183838
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
				if (num != 8U)
				{
					if (num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.giantResponseInfos_.AddEntriesFrom(ref input, GiantResponseNotify._repeated_giantResponseInfos_codec);
					}
				}
				else
				{
					this.GiantIdleType = (GiantIdleNetType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004ACA RID: 19146
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004ACB RID: 19147
		public const int GiantIdleTypeFieldNumber = 1;

		// Token: 0x04004ACC RID: 19148
		private GiantIdleNetType giantIdleType_;

		// Token: 0x04004ACD RID: 19149
		public const int GiantResponseInfosFieldNumber = 15;

		// Token: 0x04004ACE RID: 19150
		private static readonly FieldCodec<GiantResponsePb> _repeated_giantResponseInfos_codec = FieldCodec.ForMessage<GiantResponsePb>(122U, GiantResponsePb.Parser);

		// Token: 0x04004ACF RID: 19151
		private readonly RepeatedField<GiantResponsePb> giantResponseInfos_ = new RepeatedField<GiantResponsePb>();
	}
}
