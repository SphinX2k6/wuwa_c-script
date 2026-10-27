using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013E5 RID: 5093
	[NetMessage(EMessageId.TrackMoonIllustratedRequest)]
	public sealed class TrackMoonIllustratedRequest : IMessage<TrackMoonIllustratedRequest>, IMessage, IEquatable<TrackMoonIllustratedRequest>, IDeepCloneable<TrackMoonIllustratedRequest>, IBufferMessage
	{
		// Token: 0x0601AFEB RID: 110571 RVA: 0x003E8F6D File Offset: 0x003E716D
		[NullableContext(1)]
		public static TrackMoonIllustratedRequest Create()
		{
			return new TrackMoonIllustratedRequest();
		}

		// Token: 0x17005AFC RID: 23292
		// (get) Token: 0x0601AFEC RID: 110572 RVA: 0x003E8F74 File Offset: 0x003E7174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005AFD RID: 23293
		// (get) Token: 0x0601AFED RID: 110573 RVA: 0x003E8F77 File Offset: 0x003E7177
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrackMoonIllustratedRequest.Descriptor;
			}
		}

		// Token: 0x0601AFEE RID: 110574 RVA: 0x003E8F7E File Offset: 0x003E717E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonIllustratedRequest()
		{
		}

		// Token: 0x0601AFEF RID: 110575 RVA: 0x003E8F91 File Offset: 0x003E7191
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonIllustratedRequest(TrackMoonIllustratedRequest other) : this()
		{
			this.ids_ = other.ids_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AFF0 RID: 110576 RVA: 0x003E8FBB File Offset: 0x003E71BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonIllustratedRequest Clone()
		{
			return new TrackMoonIllustratedRequest(this);
		}

		// Token: 0x17005AFE RID: 23294
		// (get) Token: 0x0601AFF1 RID: 110577 RVA: 0x003E8FC3 File Offset: 0x003E71C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Ids
		{
			get
			{
				return this.ids_;
			}
		}

		// Token: 0x0601AFF2 RID: 110578 RVA: 0x003E8FCB File Offset: 0x003E71CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrackMoonIllustratedRequest);
		}

		// Token: 0x0601AFF3 RID: 110579 RVA: 0x003E8FD9 File Offset: 0x003E71D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrackMoonIllustratedRequest other)
		{
			return other != null && (other == this || (this.ids_.Equals(other.ids_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AFF4 RID: 110580 RVA: 0x003E900C File Offset: 0x003E720C
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

		// Token: 0x0601AFF5 RID: 110581 RVA: 0x003E9040 File Offset: 0x003E7240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AFF6 RID: 110582 RVA: 0x003E904D File Offset: 0x003E724D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AFF7 RID: 110583 RVA: 0x003E9056 File Offset: 0x003E7256
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.ids_.WriteTo(ref output, TrackMoonIllustratedRequest._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AFF8 RID: 110584 RVA: 0x003E9080 File Offset: 0x003E7280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.ids_.CalculateSize(TrackMoonIllustratedRequest._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601AFF9 RID: 110585 RVA: 0x003E90B9 File Offset: 0x003E72B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrackMoonIllustratedRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.ids_.Add(other.ids_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601AFFA RID: 110586 RVA: 0x003E90E7 File Offset: 0x003E72E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AFFB RID: 110587 RVA: 0x003E90F0 File Offset: 0x003E72F0
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
				if (num != 48U && num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ids_.AddEntriesFrom(ref input, TrackMoonIllustratedRequest._repeated_ids_codec);
				}
			}
		}

		// Token: 0x04009C51 RID: 40017
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009C52 RID: 40018
		public const int IdsFieldNumber = 6;

		// Token: 0x04009C53 RID: 40019
		private static readonly FieldCodec<int> _repeated_ids_codec = FieldCodec.ForInt32(50U);

		// Token: 0x04009C54 RID: 40020
		private readonly RepeatedField<int> ids_ = new RepeatedField<int>();
	}
}
