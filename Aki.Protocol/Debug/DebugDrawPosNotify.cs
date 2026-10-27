using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Debug
{
	// Token: 0x02001695 RID: 5781
	[NetMessage(EMessageId.DebugDrawPosNotify)]
	public sealed class DebugDrawPosNotify : IMessage<DebugDrawPosNotify>, IMessage, IEquatable<DebugDrawPosNotify>, IDeepCloneable<DebugDrawPosNotify>, IBufferMessage
	{
		// Token: 0x0601CF9D RID: 118685 RVA: 0x0043DF2D File Offset: 0x0043C12D
		[NullableContext(1)]
		public static DebugDrawPosNotify Create()
		{
			return new DebugDrawPosNotify();
		}

		// Token: 0x17006254 RID: 25172
		// (get) Token: 0x0601CF9E RID: 118686 RVA: 0x0043DF34 File Offset: 0x0043C134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006255 RID: 25173
		// (get) Token: 0x0601CF9F RID: 118687 RVA: 0x0043DF37 File Offset: 0x0043C137
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DebugDrawPosNotify.Descriptor;
			}
		}

		// Token: 0x0601CFA0 RID: 118688 RVA: 0x0043DF3E File Offset: 0x0043C13E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DebugDrawPosNotify()
		{
		}

		// Token: 0x0601CFA1 RID: 118689 RVA: 0x0043DF54 File Offset: 0x0043C154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DebugDrawPosNotify(DebugDrawPosNotify other) : this()
		{
			this.posList_ = other.posList_.Clone();
			this.duration_ = other.duration_;
			this.radius_ = other.radius_;
			this.mapId_ = other.mapId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CFA2 RID: 118690 RVA: 0x0043DFAD File Offset: 0x0043C1AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DebugDrawPosNotify Clone()
		{
			return new DebugDrawPosNotify(this);
		}

		// Token: 0x17006256 RID: 25174
		// (get) Token: 0x0601CFA3 RID: 118691 RVA: 0x0043DFB5 File Offset: 0x0043C1B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Vector> PosList
		{
			get
			{
				return this.posList_;
			}
		}

		// Token: 0x17006257 RID: 25175
		// (get) Token: 0x0601CFA4 RID: 118692 RVA: 0x0043DFBD File Offset: 0x0043C1BD
		// (set) Token: 0x0601CFA5 RID: 118693 RVA: 0x0043DFC5 File Offset: 0x0043C1C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Duration
		{
			get
			{
				return this.duration_;
			}
			set
			{
				this.duration_ = value;
			}
		}

		// Token: 0x17006258 RID: 25176
		// (get) Token: 0x0601CFA6 RID: 118694 RVA: 0x0043DFCE File Offset: 0x0043C1CE
		// (set) Token: 0x0601CFA7 RID: 118695 RVA: 0x0043DFD6 File Offset: 0x0043C1D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Radius
		{
			get
			{
				return this.radius_;
			}
			set
			{
				this.radius_ = value;
			}
		}

		// Token: 0x17006259 RID: 25177
		// (get) Token: 0x0601CFA8 RID: 118696 RVA: 0x0043DFDF File Offset: 0x0043C1DF
		// (set) Token: 0x0601CFA9 RID: 118697 RVA: 0x0043DFE7 File Offset: 0x0043C1E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MapId
		{
			get
			{
				return this.mapId_;
			}
			set
			{
				this.mapId_ = value;
			}
		}

		// Token: 0x0601CFAA RID: 118698 RVA: 0x0043DFF0 File Offset: 0x0043C1F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DebugDrawPosNotify);
		}

		// Token: 0x0601CFAB RID: 118699 RVA: 0x0043E000 File Offset: 0x0043C200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DebugDrawPosNotify other)
		{
			return other != null && (other == this || (this.posList_.Equals(other.posList_) && this.Duration == other.Duration && this.Radius == other.Radius && this.MapId == other.MapId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CFAC RID: 118700 RVA: 0x0043E070 File Offset: 0x0043C270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.posList_.GetHashCode();
			if (this.Duration != 0)
			{
				num ^= this.Duration.GetHashCode();
			}
			if (this.Radius != 0)
			{
				num ^= this.Radius.GetHashCode();
			}
			if (this.MapId != 0)
			{
				num ^= this.MapId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601CFAD RID: 118701 RVA: 0x0043E0EF File Offset: 0x0043C2EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CFAE RID: 118702 RVA: 0x0043E0FC File Offset: 0x0043C2FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CFAF RID: 118703 RVA: 0x0043E108 File Offset: 0x0043C308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Radius != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Radius);
			}
			this.posList_.WriteTo(ref output, DebugDrawPosNotify._repeated_posList_codec);
			if (this.MapId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.MapId);
			}
			if (this.Duration != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.Duration);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CFB0 RID: 118704 RVA: 0x0043E190 File Offset: 0x0043C390
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.posList_.CalculateSize(DebugDrawPosNotify._repeated_posList_codec);
			if (this.Duration != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Duration);
			}
			if (this.Radius != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Radius);
			}
			if (this.MapId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MapId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601CFB1 RID: 118705 RVA: 0x0043E214 File Offset: 0x0043C414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DebugDrawPosNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.posList_.Add(other.posList_);
			if (other.Duration != 0)
			{
				this.Duration = other.Duration;
			}
			if (other.Radius != 0)
			{
				this.Radius = other.Radius;
			}
			if (other.MapId != 0)
			{
				this.MapId = other.MapId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601CFB2 RID: 118706 RVA: 0x0043E289 File Offset: 0x0043C489
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CFB3 RID: 118707 RVA: 0x0043E294 File Offset: 0x0043C494
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
				if (num <= 34U)
				{
					if (num == 16U)
					{
						this.Radius = input.ReadInt32();
						continue;
					}
					if (num == 34U)
					{
						this.posList_.AddEntriesFrom(ref input, DebugDrawPosNotify._repeated_posList_codec);
						continue;
					}
				}
				else
				{
					if (num == 112U)
					{
						this.MapId = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.Duration = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400C3B6 RID: 50102
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C3B7 RID: 50103
		public const int PosListFieldNumber = 4;

		// Token: 0x0400C3B8 RID: 50104
		private static readonly FieldCodec<Vector> _repeated_posList_codec = FieldCodec.ForMessage<Vector>(34U, Vector.Parser);

		// Token: 0x0400C3B9 RID: 50105
		private readonly RepeatedField<Vector> posList_ = new RepeatedField<Vector>();

		// Token: 0x0400C3BA RID: 50106
		public const int DurationFieldNumber = 15;

		// Token: 0x0400C3BB RID: 50107
		private int duration_;

		// Token: 0x0400C3BC RID: 50108
		public const int RadiusFieldNumber = 2;

		// Token: 0x0400C3BD RID: 50109
		private int radius_;

		// Token: 0x0400C3BE RID: 50110
		public const int MapIdFieldNumber = 14;

		// Token: 0x0400C3BF RID: 50111
		private int mapId_;
	}
}
