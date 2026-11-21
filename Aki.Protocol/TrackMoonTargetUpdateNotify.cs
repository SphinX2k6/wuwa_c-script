using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001462 RID: 5218
	[NetMessage(EMessageId.TrackMoonTargetUpdateNotify)]
	public sealed class TrackMoonTargetUpdateNotify : IMessage<TrackMoonTargetUpdateNotify>, IMessage, IEquatable<TrackMoonTargetUpdateNotify>, IDeepCloneable<TrackMoonTargetUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601BB3C RID: 113468 RVA: 0x00405B69 File Offset: 0x00403D69
		[NullableContext(1)]
		public static TrackMoonTargetUpdateNotify Create()
		{
			return new TrackMoonTargetUpdateNotify();
		}

		// Token: 0x17005DB8 RID: 23992
		// (get) Token: 0x0601BB3D RID: 113469 RVA: 0x00405B70 File Offset: 0x00403D70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005DB9 RID: 23993
		// (get) Token: 0x0601BB3E RID: 113470 RVA: 0x00405B73 File Offset: 0x00403D73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrackMoonTargetUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601BB3F RID: 113471 RVA: 0x00405B7A File Offset: 0x00403D7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonTargetUpdateNotify()
		{
		}

		// Token: 0x0601BB40 RID: 113472 RVA: 0x00405B8D File Offset: 0x00403D8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonTargetUpdateNotify(TrackMoonTargetUpdateNotify other) : this()
		{
			this.trackMoonTargets_ = other.trackMoonTargets_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BB41 RID: 113473 RVA: 0x00405BB7 File Offset: 0x00403DB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonTargetUpdateNotify Clone()
		{
			return new TrackMoonTargetUpdateNotify(this);
		}

		// Token: 0x17005DBA RID: 23994
		// (get) Token: 0x0601BB42 RID: 113474 RVA: 0x00405BBF File Offset: 0x00403DBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TrackMoonTarget> TrackMoonTargets
		{
			get
			{
				return this.trackMoonTargets_;
			}
		}

		// Token: 0x0601BB43 RID: 113475 RVA: 0x00405BC7 File Offset: 0x00403DC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrackMoonTargetUpdateNotify);
		}

		// Token: 0x0601BB44 RID: 113476 RVA: 0x00405BD5 File Offset: 0x00403DD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrackMoonTargetUpdateNotify other)
		{
			return other != null && (other == this || (this.trackMoonTargets_.Equals(other.trackMoonTargets_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BB45 RID: 113477 RVA: 0x00405C08 File Offset: 0x00403E08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.trackMoonTargets_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BB46 RID: 113478 RVA: 0x00405C3C File Offset: 0x00403E3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BB47 RID: 113479 RVA: 0x00405C49 File Offset: 0x00403E49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BB48 RID: 113480 RVA: 0x00405C52 File Offset: 0x00403E52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.trackMoonTargets_.WriteTo(ref output, TrackMoonTargetUpdateNotify._repeated_trackMoonTargets_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BB49 RID: 113481 RVA: 0x00405C7C File Offset: 0x00403E7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.trackMoonTargets_.CalculateSize(TrackMoonTargetUpdateNotify._repeated_trackMoonTargets_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BB4A RID: 113482 RVA: 0x00405CB5 File Offset: 0x00403EB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrackMoonTargetUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.trackMoonTargets_.Add(other.trackMoonTargets_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BB4B RID: 113483 RVA: 0x00405CE3 File Offset: 0x00403EE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BB4C RID: 113484 RVA: 0x00405CEC File Offset: 0x00403EEC
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
				if (num != 98U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.trackMoonTargets_.AddEntriesFrom(ref input, TrackMoonTargetUpdateNotify._repeated_trackMoonTargets_codec);
				}
			}
		}

		// Token: 0x0400A0CB RID: 41163
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A0CC RID: 41164
		public const int TrackMoonTargetsFieldNumber = 12;

		// Token: 0x0400A0CD RID: 41165
		private static readonly FieldCodec<TrackMoonTarget> _repeated_trackMoonTargets_codec = FieldCodec.ForMessage<TrackMoonTarget>(98U, TrackMoonTarget.Parser);

		// Token: 0x0400A0CE RID: 41166
		private readonly RepeatedField<TrackMoonTarget> trackMoonTargets_ = new RepeatedField<TrackMoonTarget>();
	}
}
