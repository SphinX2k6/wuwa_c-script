using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013EF RID: 5103
	[NetMessage(EMessageId.TrackMoonTargetUpdateNotify)]
	public sealed class TrackMoonTargetUpdateNotify : IMessage<TrackMoonTargetUpdateNotify>, IMessage, IEquatable<TrackMoonTargetUpdateNotify>, IDeepCloneable<TrackMoonTargetUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601B0B1 RID: 110769 RVA: 0x003EA895 File Offset: 0x003E8A95
		[NullableContext(1)]
		public static TrackMoonTargetUpdateNotify Create()
		{
			return new TrackMoonTargetUpdateNotify();
		}

		// Token: 0x17005B23 RID: 23331
		// (get) Token: 0x0601B0B2 RID: 110770 RVA: 0x003EA89C File Offset: 0x003E8A9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005B24 RID: 23332
		// (get) Token: 0x0601B0B3 RID: 110771 RVA: 0x003EA89F File Offset: 0x003E8A9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrackMoonTargetUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601B0B4 RID: 110772 RVA: 0x003EA8A6 File Offset: 0x003E8AA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonTargetUpdateNotify()
		{
		}

		// Token: 0x0601B0B5 RID: 110773 RVA: 0x003EA8B9 File Offset: 0x003E8AB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonTargetUpdateNotify(TrackMoonTargetUpdateNotify other) : this()
		{
			this.trackMoonTargets_ = other.trackMoonTargets_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B0B6 RID: 110774 RVA: 0x003EA8E3 File Offset: 0x003E8AE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonTargetUpdateNotify Clone()
		{
			return new TrackMoonTargetUpdateNotify(this);
		}

		// Token: 0x17005B25 RID: 23333
		// (get) Token: 0x0601B0B7 RID: 110775 RVA: 0x003EA8EB File Offset: 0x003E8AEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TrackMoonTarget> TrackMoonTargets
		{
			get
			{
				return this.trackMoonTargets_;
			}
		}

		// Token: 0x0601B0B8 RID: 110776 RVA: 0x003EA8F3 File Offset: 0x003E8AF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrackMoonTargetUpdateNotify);
		}

		// Token: 0x0601B0B9 RID: 110777 RVA: 0x003EA901 File Offset: 0x003E8B01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrackMoonTargetUpdateNotify other)
		{
			return other != null && (other == this || (this.trackMoonTargets_.Equals(other.trackMoonTargets_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B0BA RID: 110778 RVA: 0x003EA934 File Offset: 0x003E8B34
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

		// Token: 0x0601B0BB RID: 110779 RVA: 0x003EA968 File Offset: 0x003E8B68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B0BC RID: 110780 RVA: 0x003EA975 File Offset: 0x003E8B75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B0BD RID: 110781 RVA: 0x003EA97E File Offset: 0x003E8B7E
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

		// Token: 0x0601B0BE RID: 110782 RVA: 0x003EA9A8 File Offset: 0x003E8BA8
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

		// Token: 0x0601B0BF RID: 110783 RVA: 0x003EA9E1 File Offset: 0x003E8BE1
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

		// Token: 0x0601B0C0 RID: 110784 RVA: 0x003EAA0F File Offset: 0x003E8C0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B0C1 RID: 110785 RVA: 0x003EAA18 File Offset: 0x003E8C18
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
				if (num != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.trackMoonTargets_.AddEntriesFrom(ref input, TrackMoonTargetUpdateNotify._repeated_trackMoonTargets_codec);
				}
			}
		}

		// Token: 0x04009C84 RID: 40068
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009C85 RID: 40069
		public const int TrackMoonTargetsFieldNumber = 2;

		// Token: 0x04009C86 RID: 40070
		private static readonly FieldCodec<TrackMoonTarget> _repeated_trackMoonTargets_codec = FieldCodec.ForMessage<TrackMoonTarget>(18U, TrackMoonTarget.Parser);

		// Token: 0x04009C87 RID: 40071
		private readonly RepeatedField<TrackMoonTarget> trackMoonTargets_ = new RepeatedField<TrackMoonTarget>();
	}
}
