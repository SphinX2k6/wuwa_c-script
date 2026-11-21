using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Debug
{
	// Token: 0x02001711 RID: 5905
	[NetMessage(EMessageId.DebugDrawPosNotify)]
	public sealed class DebugDrawPosNotify : IMessage<DebugDrawPosNotify>, IMessage, IEquatable<DebugDrawPosNotify>, IDeepCloneable<DebugDrawPosNotify>, IBufferMessage
	{
		// Token: 0x0601DA6C RID: 121452 RVA: 0x00459C69 File Offset: 0x00457E69
		[NullableContext(1)]
		public static DebugDrawPosNotify Create()
		{
			return new DebugDrawPosNotify();
		}

		// Token: 0x170064F9 RID: 25849
		// (get) Token: 0x0601DA6D RID: 121453 RVA: 0x00459C70 File Offset: 0x00457E70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170064FA RID: 25850
		// (get) Token: 0x0601DA6E RID: 121454 RVA: 0x00459C73 File Offset: 0x00457E73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DebugDrawPosNotify.Descriptor;
			}
		}

		// Token: 0x0601DA6F RID: 121455 RVA: 0x00459C7A File Offset: 0x00457E7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DebugDrawPosNotify()
		{
		}

		// Token: 0x0601DA70 RID: 121456 RVA: 0x00459C90 File Offset: 0x00457E90
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

		// Token: 0x0601DA71 RID: 121457 RVA: 0x00459CE9 File Offset: 0x00457EE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DebugDrawPosNotify Clone()
		{
			return new DebugDrawPosNotify(this);
		}

		// Token: 0x170064FB RID: 25851
		// (get) Token: 0x0601DA72 RID: 121458 RVA: 0x00459CF1 File Offset: 0x00457EF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Vector> PosList
		{
			get
			{
				return this.posList_;
			}
		}

		// Token: 0x170064FC RID: 25852
		// (get) Token: 0x0601DA73 RID: 121459 RVA: 0x00459CF9 File Offset: 0x00457EF9
		// (set) Token: 0x0601DA74 RID: 121460 RVA: 0x00459D01 File Offset: 0x00457F01
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

		// Token: 0x170064FD RID: 25853
		// (get) Token: 0x0601DA75 RID: 121461 RVA: 0x00459D0A File Offset: 0x00457F0A
		// (set) Token: 0x0601DA76 RID: 121462 RVA: 0x00459D12 File Offset: 0x00457F12
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

		// Token: 0x170064FE RID: 25854
		// (get) Token: 0x0601DA77 RID: 121463 RVA: 0x00459D1B File Offset: 0x00457F1B
		// (set) Token: 0x0601DA78 RID: 121464 RVA: 0x00459D23 File Offset: 0x00457F23
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

		// Token: 0x0601DA79 RID: 121465 RVA: 0x00459D2C File Offset: 0x00457F2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DebugDrawPosNotify);
		}

		// Token: 0x0601DA7A RID: 121466 RVA: 0x00459D3C File Offset: 0x00457F3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DebugDrawPosNotify other)
		{
			return other != null && (other == this || (this.posList_.Equals(other.posList_) && this.Duration == other.Duration && this.Radius == other.Radius && this.MapId == other.MapId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601DA7B RID: 121467 RVA: 0x00459DAC File Offset: 0x00457FAC
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

		// Token: 0x0601DA7C RID: 121468 RVA: 0x00459E2B File Offset: 0x0045802B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601DA7D RID: 121469 RVA: 0x00459E38 File Offset: 0x00458038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601DA7E RID: 121470 RVA: 0x00459E44 File Offset: 0x00458044
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
			if (this.Duration != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.Duration);
			}
			if (this.MapId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.MapId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601DA7F RID: 121471 RVA: 0x00459ECC File Offset: 0x004580CC
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

		// Token: 0x0601DA80 RID: 121472 RVA: 0x00459F50 File Offset: 0x00458150
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

		// Token: 0x0601DA81 RID: 121473 RVA: 0x00459FC5 File Offset: 0x004581C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601DA82 RID: 121474 RVA: 0x00459FD0 File Offset: 0x004581D0
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
					if (num == 88U)
					{
						this.Duration = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.MapId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400C8E5 RID: 51429
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C8E6 RID: 51430
		public const int PosListFieldNumber = 4;

		// Token: 0x0400C8E7 RID: 51431
		private static readonly FieldCodec<Vector> _repeated_posList_codec = FieldCodec.ForMessage<Vector>(34U, Vector.Parser);

		// Token: 0x0400C8E8 RID: 51432
		private readonly RepeatedField<Vector> posList_ = new RepeatedField<Vector>();

		// Token: 0x0400C8E9 RID: 51433
		public const int DurationFieldNumber = 11;

		// Token: 0x0400C8EA RID: 51434
		private int duration_;

		// Token: 0x0400C8EB RID: 51435
		public const int RadiusFieldNumber = 2;

		// Token: 0x0400C8EC RID: 51436
		private int radius_;

		// Token: 0x0400C8ED RID: 51437
		public const int MapIdFieldNumber = 15;

		// Token: 0x0400C8EE RID: 51438
		private int mapId_;
	}
}
