using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010D1 RID: 4305
	[NetMessage(EMessageId.RoleTowerPhantomAddAttrsUpdateNotify)]
	public sealed class RoleTowerPhantomAddAttrsUpdateNotify : IMessage<RoleTowerPhantomAddAttrsUpdateNotify>, IMessage, IEquatable<RoleTowerPhantomAddAttrsUpdateNotify>, IDeepCloneable<RoleTowerPhantomAddAttrsUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601702A RID: 94250 RVA: 0x00358AC8 File Offset: 0x00356CC8
		[NullableContext(1)]
		public static RoleTowerPhantomAddAttrsUpdateNotify Create()
		{
			return new RoleTowerPhantomAddAttrsUpdateNotify();
		}

		// Token: 0x17004D33 RID: 19763
		// (get) Token: 0x0601702B RID: 94251 RVA: 0x00358ACF File Offset: 0x00356CCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004D34 RID: 19764
		// (get) Token: 0x0601702C RID: 94252 RVA: 0x00358AD2 File Offset: 0x00356CD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTowerPhantomAddAttrsUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601702D RID: 94253 RVA: 0x00358AD9 File Offset: 0x00356CD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerPhantomAddAttrsUpdateNotify()
		{
		}

		// Token: 0x0601702E RID: 94254 RVA: 0x00358AF7 File Offset: 0x00356CF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerPhantomAddAttrsUpdateNotify(RoleTowerPhantomAddAttrsUpdateNotify other) : this()
		{
			this.phantomAddAttrs_ = other.phantomAddAttrs_.Clone();
			this.phantomAddAttrInfos_ = other.phantomAddAttrInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601702F RID: 94255 RVA: 0x00358B32 File Offset: 0x00356D32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerPhantomAddAttrsUpdateNotify Clone()
		{
			return new RoleTowerPhantomAddAttrsUpdateNotify(this);
		}

		// Token: 0x17004D35 RID: 19765
		// (get) Token: 0x06017030 RID: 94256 RVA: 0x00358B3A File Offset: 0x00356D3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> PhantomAddAttrs
		{
			get
			{
				return this.phantomAddAttrs_;
			}
		}

		// Token: 0x17004D36 RID: 19766
		// (get) Token: 0x06017031 RID: 94257 RVA: 0x00358B42 File Offset: 0x00356D42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleTowerPhantomAddAttr> PhantomAddAttrInfos
		{
			get
			{
				return this.phantomAddAttrInfos_;
			}
		}

		// Token: 0x06017032 RID: 94258 RVA: 0x00358B4A File Offset: 0x00356D4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTowerPhantomAddAttrsUpdateNotify);
		}

		// Token: 0x06017033 RID: 94259 RVA: 0x00358B58 File Offset: 0x00356D58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTowerPhantomAddAttrsUpdateNotify other)
		{
			return other != null && (other == this || (this.PhantomAddAttrs.Equals(other.PhantomAddAttrs) && this.phantomAddAttrInfos_.Equals(other.phantomAddAttrInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017034 RID: 94260 RVA: 0x00358BAC File Offset: 0x00356DAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.PhantomAddAttrs.GetHashCode();
			num ^= this.phantomAddAttrInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017035 RID: 94261 RVA: 0x00358BEE File Offset: 0x00356DEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017036 RID: 94262 RVA: 0x00358BFB File Offset: 0x00356DFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017037 RID: 94263 RVA: 0x00358C04 File Offset: 0x00356E04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.phantomAddAttrInfos_.WriteTo(ref output, RoleTowerPhantomAddAttrsUpdateNotify._repeated_phantomAddAttrInfos_codec);
			this.phantomAddAttrs_.WriteTo(ref output, RoleTowerPhantomAddAttrsUpdateNotify._map_phantomAddAttrs_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017038 RID: 94264 RVA: 0x00358C3C File Offset: 0x00356E3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.phantomAddAttrs_.CalculateSize(RoleTowerPhantomAddAttrsUpdateNotify._map_phantomAddAttrs_codec);
			num += this.phantomAddAttrInfos_.CalculateSize(RoleTowerPhantomAddAttrsUpdateNotify._repeated_phantomAddAttrInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017039 RID: 94265 RVA: 0x00358C88 File Offset: 0x00356E88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTowerPhantomAddAttrsUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.phantomAddAttrs_.MergeFrom(other.phantomAddAttrs_);
			this.phantomAddAttrInfos_.Add(other.phantomAddAttrInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601703A RID: 94266 RVA: 0x00358CC7 File Offset: 0x00356EC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601703B RID: 94267 RVA: 0x00358CD0 File Offset: 0x00356ED0
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
					if (num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.phantomAddAttrs_.AddEntriesFrom(ref input, RoleTowerPhantomAddAttrsUpdateNotify._map_phantomAddAttrs_codec);
					}
				}
				else
				{
					this.phantomAddAttrInfos_.AddEntriesFrom(ref input, RoleTowerPhantomAddAttrsUpdateNotify._repeated_phantomAddAttrInfos_codec);
				}
			}
		}

		// Token: 0x040089B5 RID: 35253
		private UnknownFieldSet _unknownFields;

		// Token: 0x040089B6 RID: 35254
		public const int PhantomAddAttrsFieldNumber = 15;

		// Token: 0x040089B7 RID: 35255
		private static readonly MapField<int, int>.Codec _map_phantomAddAttrs_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 122U);

		// Token: 0x040089B8 RID: 35256
		private readonly MapField<int, int> phantomAddAttrs_ = new MapField<int, int>();

		// Token: 0x040089B9 RID: 35257
		public const int PhantomAddAttrInfosFieldNumber = 5;

		// Token: 0x040089BA RID: 35258
		private static readonly FieldCodec<RoleTowerPhantomAddAttr> _repeated_phantomAddAttrInfos_codec = FieldCodec.ForMessage<RoleTowerPhantomAddAttr>(42U, RoleTowerPhantomAddAttr.Parser);

		// Token: 0x040089BB RID: 35259
		private readonly RepeatedField<RoleTowerPhantomAddAttr> phantomAddAttrInfos_ = new RepeatedField<RoleTowerPhantomAddAttr>();
	}
}
