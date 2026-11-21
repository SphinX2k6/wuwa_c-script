using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200090D RID: 2317
	public sealed class LiftMoveTypeTeleportPb : IMessage<LiftMoveTypeTeleportPb>, IMessage, IEquatable<LiftMoveTypeTeleportPb>, IDeepCloneable<LiftMoveTypeTeleportPb>, IBufferMessage
	{
		// Token: 0x0600CCCC RID: 52428 RVA: 0x001E3238 File Offset: 0x001E1438
		[NullableContext(1)]
		public static LiftMoveTypeTeleportPb Create()
		{
			return new LiftMoveTypeTeleportPb();
		}

		// Token: 0x17002956 RID: 10582
		// (get) Token: 0x0600CCCD RID: 52429 RVA: 0x001E323F File Offset: 0x001E143F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002957 RID: 10583
		// (get) Token: 0x0600CCCE RID: 52430 RVA: 0x001E3242 File Offset: 0x001E1442
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LiftMoveTypeTeleportPb.Descriptor;
			}
		}

		// Token: 0x0600CCCF RID: 52431 RVA: 0x001E3249 File Offset: 0x001E1449
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LiftMoveTypeTeleportPb()
		{
		}

		// Token: 0x0600CCD0 RID: 52432 RVA: 0x001E3254 File Offset: 0x001E1454
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

		// Token: 0x0600CCD1 RID: 52433 RVA: 0x001E32A8 File Offset: 0x001E14A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LiftMoveTypeTeleportPb Clone()
		{
			return new LiftMoveTypeTeleportPb(this);
		}

		// Token: 0x17002958 RID: 10584
		// (get) Token: 0x0600CCD2 RID: 52434 RVA: 0x001E32B0 File Offset: 0x001E14B0
		// (set) Token: 0x0600CCD3 RID: 52435 RVA: 0x001E32B8 File Offset: 0x001E14B8
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

		// Token: 0x17002959 RID: 10585
		// (get) Token: 0x0600CCD4 RID: 52436 RVA: 0x001E32C1 File Offset: 0x001E14C1
		// (set) Token: 0x0600CCD5 RID: 52437 RVA: 0x001E32C9 File Offset: 0x001E14C9
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

		// Token: 0x1700295A RID: 10586
		// (get) Token: 0x0600CCD6 RID: 52438 RVA: 0x001E32D2 File Offset: 0x001E14D2
		// (set) Token: 0x0600CCD7 RID: 52439 RVA: 0x001E32DA File Offset: 0x001E14DA
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

		// Token: 0x1700295B RID: 10587
		// (get) Token: 0x0600CCD8 RID: 52440 RVA: 0x001E32E3 File Offset: 0x001E14E3
		// (set) Token: 0x0600CCD9 RID: 52441 RVA: 0x001E32EB File Offset: 0x001E14EB
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

		// Token: 0x0600CCDA RID: 52442 RVA: 0x001E32F4 File Offset: 0x001E14F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LiftMoveTypeTeleportPb);
		}

		// Token: 0x0600CCDB RID: 52443 RVA: 0x001E3304 File Offset: 0x001E1504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LiftMoveTypeTeleportPb other)
		{
			return other != null && (other == this || (ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.StartTeleportOffsetDistance, other.StartTeleportOffsetDistance) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.EndTeleportOffsetDistance, other.EndTeleportOffsetDistance) && this.SendTeleportEvent == other.SendTeleportEvent && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.TeleportStartEventOffsetDistance, other.TeleportStartEventOffsetDistance) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CCDC RID: 52444 RVA: 0x001E338C File Offset: 0x001E158C
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

		// Token: 0x0600CCDD RID: 52445 RVA: 0x001E342B File Offset: 0x001E162B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CCDE RID: 52446 RVA: 0x001E3438 File Offset: 0x001E1638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CCDF RID: 52447 RVA: 0x001E3444 File Offset: 0x001E1644
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

		// Token: 0x0600CCE0 RID: 52448 RVA: 0x001E34E4 File Offset: 0x001E16E4
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

		// Token: 0x0600CCE1 RID: 52449 RVA: 0x001E354C File Offset: 0x001E174C
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

		// Token: 0x0600CCE2 RID: 52450 RVA: 0x001E35D3 File Offset: 0x001E17D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CCE3 RID: 52451 RVA: 0x001E35DC File Offset: 0x001E17DC
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

		// Token: 0x04005717 RID: 22295
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005718 RID: 22296
		public const int StartTeleportOffsetDistanceFieldNumber = 1;

		// Token: 0x04005719 RID: 22297
		private float startTeleportOffsetDistance_;

		// Token: 0x0400571A RID: 22298
		public const int EndTeleportOffsetDistanceFieldNumber = 2;

		// Token: 0x0400571B RID: 22299
		private float endTeleportOffsetDistance_;

		// Token: 0x0400571C RID: 22300
		public const int SendTeleportEventFieldNumber = 3;

		// Token: 0x0400571D RID: 22301
		private bool sendTeleportEvent_;

		// Token: 0x0400571E RID: 22302
		public const int TeleportStartEventOffsetDistanceFieldNumber = 4;

		// Token: 0x0400571F RID: 22303
		private float teleportStartEventOffsetDistance_;
	}
}
