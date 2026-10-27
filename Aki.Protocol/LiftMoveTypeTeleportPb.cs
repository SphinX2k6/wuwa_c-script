using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200091E RID: 2334
	public sealed class LiftMoveTypeTeleportPb : IMessage<LiftMoveTypeTeleportPb>, IMessage, IEquatable<LiftMoveTypeTeleportPb>, IDeepCloneable<LiftMoveTypeTeleportPb>, IBufferMessage
	{
		// Token: 0x0600CDE8 RID: 52712 RVA: 0x001E5508 File Offset: 0x001E3708
		[NullableContext(1)]
		public static LiftMoveTypeTeleportPb Create()
		{
			return new LiftMoveTypeTeleportPb();
		}

		// Token: 0x17002995 RID: 10645
		// (get) Token: 0x0600CDE9 RID: 52713 RVA: 0x001E550F File Offset: 0x001E370F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002996 RID: 10646
		// (get) Token: 0x0600CDEA RID: 52714 RVA: 0x001E5512 File Offset: 0x001E3712
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LiftMoveTypeTeleportPb.Descriptor;
			}
		}

		// Token: 0x0600CDEB RID: 52715 RVA: 0x001E5519 File Offset: 0x001E3719
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LiftMoveTypeTeleportPb()
		{
		}

		// Token: 0x0600CDEC RID: 52716 RVA: 0x001E5524 File Offset: 0x001E3724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LiftMoveTypeTeleportPb(LiftMoveTypeTeleportPb other) : this()
		{
			this.startTeleportOffsetDistance_ = other.startTeleportOffsetDistance_;
			this.endTeleportOffsetDistance_ = other.endTeleportOffsetDistance_;
			this.sendTeleportEvent_ = other.sendTeleportEvent_;
			this.teleportStartEventOffsetDistance_ = other.teleportStartEventOffsetDistance_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CDED RID: 52717 RVA: 0x001E5578 File Offset: 0x001E3778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LiftMoveTypeTeleportPb Clone()
		{
			return new LiftMoveTypeTeleportPb(this);
		}

		// Token: 0x17002997 RID: 10647
		// (get) Token: 0x0600CDEE RID: 52718 RVA: 0x001E5580 File Offset: 0x001E3780
		// (set) Token: 0x0600CDEF RID: 52719 RVA: 0x001E5588 File Offset: 0x001E3788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float StartTeleportOffsetDistance
		{
			get
			{
				return this.startTeleportOffsetDistance_;
			}
			set
			{
				this.startTeleportOffsetDistance_ = value;
			}
		}

		// Token: 0x17002998 RID: 10648
		// (get) Token: 0x0600CDF0 RID: 52720 RVA: 0x001E5591 File Offset: 0x001E3791
		// (set) Token: 0x0600CDF1 RID: 52721 RVA: 0x001E5599 File Offset: 0x001E3799
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float EndTeleportOffsetDistance
		{
			get
			{
				return this.endTeleportOffsetDistance_;
			}
			set
			{
				this.endTeleportOffsetDistance_ = value;
			}
		}

		// Token: 0x17002999 RID: 10649
		// (get) Token: 0x0600CDF2 RID: 52722 RVA: 0x001E55A2 File Offset: 0x001E37A2
		// (set) Token: 0x0600CDF3 RID: 52723 RVA: 0x001E55AA File Offset: 0x001E37AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool SendTeleportEvent
		{
			get
			{
				return this.sendTeleportEvent_;
			}
			set
			{
				this.sendTeleportEvent_ = value;
			}
		}

		// Token: 0x1700299A RID: 10650
		// (get) Token: 0x0600CDF4 RID: 52724 RVA: 0x001E55B3 File Offset: 0x001E37B3
		// (set) Token: 0x0600CDF5 RID: 52725 RVA: 0x001E55BB File Offset: 0x001E37BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float TeleportStartEventOffsetDistance
		{
			get
			{
				return this.teleportStartEventOffsetDistance_;
			}
			set
			{
				this.teleportStartEventOffsetDistance_ = value;
			}
		}

		// Token: 0x0600CDF6 RID: 52726 RVA: 0x001E55C4 File Offset: 0x001E37C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LiftMoveTypeTeleportPb);
		}

		// Token: 0x0600CDF7 RID: 52727 RVA: 0x001E55D4 File Offset: 0x001E37D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LiftMoveTypeTeleportPb other)
		{
			return other != null && (other == this || (ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.StartTeleportOffsetDistance, other.StartTeleportOffsetDistance) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.EndTeleportOffsetDistance, other.EndTeleportOffsetDistance) && this.SendTeleportEvent == other.SendTeleportEvent && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.TeleportStartEventOffsetDistance, other.TeleportStartEventOffsetDistance) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CDF8 RID: 52728 RVA: 0x001E565C File Offset: 0x001E385C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.StartTeleportOffsetDistance != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.StartTeleportOffsetDistance);
			}
			if (this.EndTeleportOffsetDistance != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.EndTeleportOffsetDistance);
			}
			if (this.SendTeleportEvent)
			{
				num ^= this.SendTeleportEvent.GetHashCode();
			}
			if (this.TeleportStartEventOffsetDistance != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.TeleportStartEventOffsetDistance);
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CDF9 RID: 52729 RVA: 0x001E56FB File Offset: 0x001E38FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CDFA RID: 52730 RVA: 0x001E5708 File Offset: 0x001E3908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CDFB RID: 52731 RVA: 0x001E5714 File Offset: 0x001E3914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.StartTeleportOffsetDistance != 0f)
			{
				output.WriteRawTag(13);
				output.WriteFloat(this.StartTeleportOffsetDistance);
			}
			if (this.EndTeleportOffsetDistance != 0f)
			{
				output.WriteRawTag(21);
				output.WriteFloat(this.EndTeleportOffsetDistance);
			}
			if (this.SendTeleportEvent)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.SendTeleportEvent);
			}
			if (this.TeleportStartEventOffsetDistance != 0f)
			{
				output.WriteRawTag(37);
				output.WriteFloat(this.TeleportStartEventOffsetDistance);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CDFC RID: 52732 RVA: 0x001E57B4 File Offset: 0x001E39B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.StartTeleportOffsetDistance != 0f)
			{
				num += 5;
			}
			if (this.EndTeleportOffsetDistance != 0f)
			{
				num += 5;
			}
			if (this.SendTeleportEvent)
			{
				num += 2;
			}
			if (this.TeleportStartEventOffsetDistance != 0f)
			{
				num += 5;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CDFD RID: 52733 RVA: 0x001E581C File Offset: 0x001E3A1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LiftMoveTypeTeleportPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.StartTeleportOffsetDistance != 0f)
			{
				this.StartTeleportOffsetDistance = other.StartTeleportOffsetDistance;
			}
			if (other.EndTeleportOffsetDistance != 0f)
			{
				this.EndTeleportOffsetDistance = other.EndTeleportOffsetDistance;
			}
			if (other.SendTeleportEvent)
			{
				this.SendTeleportEvent = other.SendTeleportEvent;
			}
			if (other.TeleportStartEventOffsetDistance != 0f)
			{
				this.TeleportStartEventOffsetDistance = other.TeleportStartEventOffsetDistance;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CDFE RID: 52734 RVA: 0x001E58A3 File Offset: 0x001E3AA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CDFF RID: 52735 RVA: 0x001E58AC File Offset: 0x001E3AAC
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
				if (num <= 21U)
				{
					if (num == 13U)
					{
						this.StartTeleportOffsetDistance = input.ReadFloat();
						continue;
					}
					if (num == 21U)
					{
						this.EndTeleportOffsetDistance = input.ReadFloat();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.SendTeleportEvent = input.ReadBool();
						continue;
					}
					if (num == 37U)
					{
						this.TeleportStartEventOffsetDistance = input.ReadFloat();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005710 RID: 22288
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005711 RID: 22289
		public const int StartTeleportOffsetDistanceFieldNumber = 1;

		// Token: 0x04005712 RID: 22290
		private float startTeleportOffsetDistance_;

		// Token: 0x04005713 RID: 22291
		public const int EndTeleportOffsetDistanceFieldNumber = 2;

		// Token: 0x04005714 RID: 22292
		private float endTeleportOffsetDistance_;

		// Token: 0x04005715 RID: 22293
		public const int SendTeleportEventFieldNumber = 3;

		// Token: 0x04005716 RID: 22294
		private bool sendTeleportEvent_;

		// Token: 0x04005717 RID: 22295
		public const int TeleportStartEventOffsetDistanceFieldNumber = 4;

		// Token: 0x04005718 RID: 22296
		private float teleportStartEventOffsetDistance_;
	}
}
