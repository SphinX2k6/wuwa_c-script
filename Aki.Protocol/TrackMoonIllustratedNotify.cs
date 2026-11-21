using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001457 RID: 5207
	[NetMessage(EMessageId.TrackMoonIllustratedNotify)]
	public sealed class TrackMoonIllustratedNotify : IMessage<TrackMoonIllustratedNotify>, IMessage, IEquatable<TrackMoonIllustratedNotify>, IDeepCloneable<TrackMoonIllustratedNotify>, IBufferMessage
	{
		// Token: 0x0601BA64 RID: 113252 RVA: 0x00404059 File Offset: 0x00402259
		[NullableContext(1)]
		public static TrackMoonIllustratedNotify Create()
		{
			return new TrackMoonIllustratedNotify();
		}

		// Token: 0x17005D8E RID: 23950
		// (get) Token: 0x0601BA65 RID: 113253 RVA: 0x00404060 File Offset: 0x00402260
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D8F RID: 23951
		// (get) Token: 0x0601BA66 RID: 113254 RVA: 0x00404063 File Offset: 0x00402263
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrackMoonIllustratedNotify.Descriptor;
			}
		}

		// Token: 0x0601BA67 RID: 113255 RVA: 0x0040406A File Offset: 0x0040226A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonIllustratedNotify()
		{
		}

		// Token: 0x0601BA68 RID: 113256 RVA: 0x0040407D File Offset: 0x0040227D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonIllustratedNotify(TrackMoonIllustratedNotify other) : this()
		{
			this.ids_ = other.ids_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BA69 RID: 113257 RVA: 0x004040A7 File Offset: 0x004022A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonIllustratedNotify Clone()
		{
			return new TrackMoonIllustratedNotify(this);
		}

		// Token: 0x17005D90 RID: 23952
		// (get) Token: 0x0601BA6A RID: 113258 RVA: 0x004040AF File Offset: 0x004022AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Ids
		{
			get
			{
				return this.ids_;
			}
		}

		// Token: 0x0601BA6B RID: 113259 RVA: 0x004040B7 File Offset: 0x004022B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrackMoonIllustratedNotify);
		}

		// Token: 0x0601BA6C RID: 113260 RVA: 0x004040C5 File Offset: 0x004022C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrackMoonIllustratedNotify other)
		{
			return other != null && (other == this || (this.ids_.Equals(other.ids_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BA6D RID: 113261 RVA: 0x004040F8 File Offset: 0x004022F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.ids_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BA6E RID: 113262 RVA: 0x0040412C File Offset: 0x0040232C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BA6F RID: 113263 RVA: 0x00404139 File Offset: 0x00402339
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BA70 RID: 113264 RVA: 0x00404142 File Offset: 0x00402342
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.ids_.WriteTo(ref output, TrackMoonIllustratedNotify._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BA71 RID: 113265 RVA: 0x0040416C File Offset: 0x0040236C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.ids_.CalculateSize(TrackMoonIllustratedNotify._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BA72 RID: 113266 RVA: 0x004041A5 File Offset: 0x004023A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrackMoonIllustratedNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.ids_.Add(other.ids_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BA73 RID: 113267 RVA: 0x004041D3 File Offset: 0x004023D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BA74 RID: 113268 RVA: 0x004041DC File Offset: 0x004023DC
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
				if (num != 120U && num != 122U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ids_.AddEntriesFrom(ref input, TrackMoonIllustratedNotify._repeated_ids_codec);
				}
			}
		}

		// Token: 0x0400A094 RID: 41108
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A095 RID: 41109
		public const int IdsFieldNumber = 15;

		// Token: 0x0400A096 RID: 41110
		private static readonly FieldCodec<int> _repeated_ids_codec = FieldCodec.ForInt32(122U);

		// Token: 0x0400A097 RID: 41111
		private readonly RepeatedField<int> ids_ = new RepeatedField<int>();
	}
}
