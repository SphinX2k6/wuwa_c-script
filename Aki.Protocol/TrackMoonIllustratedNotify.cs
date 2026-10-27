using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013E4 RID: 5092
	[NetMessage(EMessageId.TrackMoonIllustratedNotify)]
	public sealed class TrackMoonIllustratedNotify : IMessage<TrackMoonIllustratedNotify>, IMessage, IEquatable<TrackMoonIllustratedNotify>, IDeepCloneable<TrackMoonIllustratedNotify>, IBufferMessage
	{
		// Token: 0x0601AFD9 RID: 110553 RVA: 0x003E8D8D File Offset: 0x003E6F8D
		[NullableContext(1)]
		public static TrackMoonIllustratedNotify Create()
		{
			return new TrackMoonIllustratedNotify();
		}

		// Token: 0x17005AF9 RID: 23289
		// (get) Token: 0x0601AFDA RID: 110554 RVA: 0x003E8D94 File Offset: 0x003E6F94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005AFA RID: 23290
		// (get) Token: 0x0601AFDB RID: 110555 RVA: 0x003E8D97 File Offset: 0x003E6F97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrackMoonIllustratedNotify.Descriptor;
			}
		}

		// Token: 0x0601AFDC RID: 110556 RVA: 0x003E8D9E File Offset: 0x003E6F9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonIllustratedNotify()
		{
		}

		// Token: 0x0601AFDD RID: 110557 RVA: 0x003E8DB1 File Offset: 0x003E6FB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonIllustratedNotify(TrackMoonIllustratedNotify other) : this()
		{
			this.ids_ = other.ids_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AFDE RID: 110558 RVA: 0x003E8DDB File Offset: 0x003E6FDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonIllustratedNotify Clone()
		{
			return new TrackMoonIllustratedNotify(this);
		}

		// Token: 0x17005AFB RID: 23291
		// (get) Token: 0x0601AFDF RID: 110559 RVA: 0x003E8DE3 File Offset: 0x003E6FE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Ids
		{
			get
			{
				return this.ids_;
			}
		}

		// Token: 0x0601AFE0 RID: 110560 RVA: 0x003E8DEB File Offset: 0x003E6FEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrackMoonIllustratedNotify);
		}

		// Token: 0x0601AFE1 RID: 110561 RVA: 0x003E8DF9 File Offset: 0x003E6FF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrackMoonIllustratedNotify other)
		{
			return other != null && (other == this || (this.ids_.Equals(other.ids_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AFE2 RID: 110562 RVA: 0x003E8E2C File Offset: 0x003E702C
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

		// Token: 0x0601AFE3 RID: 110563 RVA: 0x003E8E60 File Offset: 0x003E7060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AFE4 RID: 110564 RVA: 0x003E8E6D File Offset: 0x003E706D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AFE5 RID: 110565 RVA: 0x003E8E76 File Offset: 0x003E7076
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

		// Token: 0x0601AFE6 RID: 110566 RVA: 0x003E8EA0 File Offset: 0x003E70A0
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

		// Token: 0x0601AFE7 RID: 110567 RVA: 0x003E8ED9 File Offset: 0x003E70D9
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

		// Token: 0x0601AFE8 RID: 110568 RVA: 0x003E8F07 File Offset: 0x003E7107
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AFE9 RID: 110569 RVA: 0x003E8F10 File Offset: 0x003E7110
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
				if (num != 112U && num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ids_.AddEntriesFrom(ref input, TrackMoonIllustratedNotify._repeated_ids_codec);
				}
			}
		}

		// Token: 0x04009C4D RID: 40013
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009C4E RID: 40014
		public const int IdsFieldNumber = 14;

		// Token: 0x04009C4F RID: 40015
		private static readonly FieldCodec<int> _repeated_ids_codec = FieldCodec.ForInt32(114U);

		// Token: 0x04009C50 RID: 40016
		private readonly RepeatedField<int> ids_ = new RepeatedField<int>();
	}
}
