using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001459 RID: 5209
	[NetMessage(EMessageId.TrackMoonIllustratedResponse)]
	public sealed class TrackMoonIllustratedResponse : IMessage<TrackMoonIllustratedResponse>, IMessage, IEquatable<TrackMoonIllustratedResponse>, IDeepCloneable<TrackMoonIllustratedResponse>, IBufferMessage
	{
		// Token: 0x0601BA88 RID: 113288 RVA: 0x00404419 File Offset: 0x00402619
		[NullableContext(1)]
		public static TrackMoonIllustratedResponse Create()
		{
			return new TrackMoonIllustratedResponse();
		}

		// Token: 0x17005D94 RID: 23956
		// (get) Token: 0x0601BA89 RID: 113289 RVA: 0x00404420 File Offset: 0x00402620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D95 RID: 23957
		// (get) Token: 0x0601BA8A RID: 113290 RVA: 0x00404423 File Offset: 0x00402623
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrackMoonIllustratedResponse.Descriptor;
			}
		}

		// Token: 0x0601BA8B RID: 113291 RVA: 0x0040442A File Offset: 0x0040262A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonIllustratedResponse()
		{
		}

		// Token: 0x0601BA8C RID: 113292 RVA: 0x0040443D File Offset: 0x0040263D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonIllustratedResponse(TrackMoonIllustratedResponse other) : this()
		{
			this.ids_ = other.ids_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BA8D RID: 113293 RVA: 0x00404467 File Offset: 0x00402667
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonIllustratedResponse Clone()
		{
			return new TrackMoonIllustratedResponse(this);
		}

		// Token: 0x17005D96 RID: 23958
		// (get) Token: 0x0601BA8E RID: 113294 RVA: 0x0040446F File Offset: 0x0040266F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Ids
		{
			get
			{
				return this.ids_;
			}
		}

		// Token: 0x0601BA8F RID: 113295 RVA: 0x00404477 File Offset: 0x00402677
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrackMoonIllustratedResponse);
		}

		// Token: 0x0601BA90 RID: 113296 RVA: 0x00404485 File Offset: 0x00402685
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrackMoonIllustratedResponse other)
		{
			return other != null && (other == this || (this.ids_.Equals(other.ids_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BA91 RID: 113297 RVA: 0x004044B8 File Offset: 0x004026B8
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

		// Token: 0x0601BA92 RID: 113298 RVA: 0x004044EC File Offset: 0x004026EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BA93 RID: 113299 RVA: 0x004044F9 File Offset: 0x004026F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BA94 RID: 113300 RVA: 0x00404502 File Offset: 0x00402702
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.ids_.WriteTo(ref output, TrackMoonIllustratedResponse._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BA95 RID: 113301 RVA: 0x0040452C File Offset: 0x0040272C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.ids_.CalculateSize(TrackMoonIllustratedResponse._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BA96 RID: 113302 RVA: 0x00404565 File Offset: 0x00402765
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrackMoonIllustratedResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.ids_.Add(other.ids_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BA97 RID: 113303 RVA: 0x00404593 File Offset: 0x00402793
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BA98 RID: 113304 RVA: 0x0040459C File Offset: 0x0040279C
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
				if (num != 24U && num != 26U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ids_.AddEntriesFrom(ref input, TrackMoonIllustratedResponse._repeated_ids_codec);
				}
			}
		}

		// Token: 0x0400A09C RID: 41116
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A09D RID: 41117
		public const int IdsFieldNumber = 3;

		// Token: 0x0400A09E RID: 41118
		private static readonly FieldCodec<int> _repeated_ids_codec = FieldCodec.ForInt32(26U);

		// Token: 0x0400A09F RID: 41119
		private readonly RepeatedField<int> ids_ = new RepeatedField<int>();
	}
}
