using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003D0 RID: 976
	public sealed class DetectionTarget : IMessage<DetectionTarget>, IMessage, IEquatable<DetectionTarget>, IDeepCloneable<DetectionTarget>, IBufferMessage
	{
		// Token: 0x06005F28 RID: 24360 RVA: 0x000E646F File Offset: 0x000E466F
		[NullableContext(1)]
		public static DetectionTarget Create()
		{
			return new DetectionTarget();
		}

		// Token: 0x170011AF RID: 4527
		// (get) Token: 0x06005F29 RID: 24361 RVA: 0x000E6476 File Offset: 0x000E4676
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DetectionTarget> Parser
		{
			get
			{
				return DetectionTarget._parser;
			}
		}

		// Token: 0x170011B0 RID: 4528
		// (get) Token: 0x06005F2A RID: 24362 RVA: 0x000E647D File Offset: 0x000E467D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170011B1 RID: 4529
		// (get) Token: 0x06005F2B RID: 24363 RVA: 0x000E6480 File Offset: 0x000E4680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DetectionTarget.Descriptor;
			}
		}

		// Token: 0x06005F2C RID: 24364 RVA: 0x000E6487 File Offset: 0x000E4687
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DetectionTarget()
		{
		}

		// Token: 0x06005F2D RID: 24365 RVA: 0x000E6490 File Offset: 0x000E4690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DetectionTarget(DetectionTarget other) : this()
		{
			this.id_ = other.id_;
			this.type_ = other.type_;
			this.unlockState_ = other.unlockState_;
			this.refresherTime_ = other.refresherTime_;
			this.detectionId_ = other.detectionId_;
			this.mapId_ = other.mapId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005F2E RID: 24366 RVA: 0x000E64FC File Offset: 0x000E46FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DetectionTarget Clone()
		{
			return new DetectionTarget(this);
		}

		// Token: 0x170011B2 RID: 4530
		// (get) Token: 0x06005F2F RID: 24367 RVA: 0x000E6504 File Offset: 0x000E4704
		// (set) Token: 0x06005F30 RID: 24368 RVA: 0x000E650C File Offset: 0x000E470C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x170011B3 RID: 4531
		// (get) Token: 0x06005F31 RID: 24369 RVA: 0x000E6515 File Offset: 0x000E4715
		// (set) Token: 0x06005F32 RID: 24370 RVA: 0x000E651D File Offset: 0x000E471D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DetectionType Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x170011B4 RID: 4532
		// (get) Token: 0x06005F33 RID: 24371 RVA: 0x000E6526 File Offset: 0x000E4726
		// (set) Token: 0x06005F34 RID: 24372 RVA: 0x000E652E File Offset: 0x000E472E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool UnlockState
		{
			get
			{
				return this.unlockState_;
			}
			set
			{
				this.unlockState_ = value;
			}
		}

		// Token: 0x170011B5 RID: 4533
		// (get) Token: 0x06005F35 RID: 24373 RVA: 0x000E6537 File Offset: 0x000E4737
		// (set) Token: 0x06005F36 RID: 24374 RVA: 0x000E653F File Offset: 0x000E473F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long RefresherTime
		{
			get
			{
				return this.refresherTime_;
			}
			set
			{
				this.refresherTime_ = value;
			}
		}

		// Token: 0x170011B6 RID: 4534
		// (get) Token: 0x06005F37 RID: 24375 RVA: 0x000E6548 File Offset: 0x000E4748
		// (set) Token: 0x06005F38 RID: 24376 RVA: 0x000E6550 File Offset: 0x000E4750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DetectionId
		{
			get
			{
				return this.detectionId_;
			}
			set
			{
				this.detectionId_ = value;
			}
		}

		// Token: 0x170011B7 RID: 4535
		// (get) Token: 0x06005F39 RID: 24377 RVA: 0x000E6559 File Offset: 0x000E4759
		// (set) Token: 0x06005F3A RID: 24378 RVA: 0x000E6561 File Offset: 0x000E4761
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

		// Token: 0x06005F3B RID: 24379 RVA: 0x000E656A File Offset: 0x000E476A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DetectionTarget);
		}

		// Token: 0x06005F3C RID: 24380 RVA: 0x000E6578 File Offset: 0x000E4778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DetectionTarget other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Type == other.Type && this.UnlockState == other.UnlockState && this.RefresherTime == other.RefresherTime && this.DetectionId == other.DetectionId && this.MapId == other.MapId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005F3D RID: 24381 RVA: 0x000E6604 File Offset: 0x000E4804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Type != DetectionType.NormalMonster)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.UnlockState)
			{
				num ^= this.UnlockState.GetHashCode();
			}
			if (this.RefresherTime != 0L)
			{
				num ^= this.RefresherTime.GetHashCode();
			}
			if (this.DetectionId != 0)
			{
				num ^= this.DetectionId.GetHashCode();
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

		// Token: 0x06005F3E RID: 24382 RVA: 0x000E66C7 File Offset: 0x000E48C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005F3F RID: 24383 RVA: 0x000E66D4 File Offset: 0x000E48D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005F40 RID: 24384 RVA: 0x000E66E0 File Offset: 0x000E48E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.Type != DetectionType.NormalMonster)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.Type);
			}
			if (this.UnlockState)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.UnlockState);
			}
			if (this.RefresherTime != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.RefresherTime);
			}
			if (this.DetectionId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.DetectionId);
			}
			if (this.MapId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.MapId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005F41 RID: 24385 RVA: 0x000E67A8 File Offset: 0x000E49A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Type != DetectionType.NormalMonster)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this.UnlockState)
			{
				num += 2;
			}
			if (this.RefresherTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.RefresherTime);
			}
			if (this.DetectionId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DetectionId);
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

		// Token: 0x06005F42 RID: 24386 RVA: 0x000E6854 File Offset: 0x000E4A54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DetectionTarget other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Type != DetectionType.NormalMonster)
			{
				this.Type = other.Type;
			}
			if (other.UnlockState)
			{
				this.UnlockState = other.UnlockState;
			}
			if (other.RefresherTime != 0L)
			{
				this.RefresherTime = other.RefresherTime;
			}
			if (other.DetectionId != 0)
			{
				this.DetectionId = other.DetectionId;
			}
			if (other.MapId != 0)
			{
				this.MapId = other.MapId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005F43 RID: 24387 RVA: 0x000E68F4 File Offset: 0x000E4AF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005F44 RID: 24388 RVA: 0x000E6900 File Offset: 0x000E4B00
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
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.Type = (DetectionType)input.ReadEnum();
						continue;
					}
					if (num == 24U)
					{
						this.UnlockState = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 32U)
					{
						this.RefresherTime = input.ReadInt64();
						continue;
					}
					if (num == 40U)
					{
						this.DetectionId = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.MapId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040036FD RID: 14077
		private static readonly MessageParser<DetectionTarget> _parser = new MessageParser<DetectionTarget>(() => new DetectionTarget());

		// Token: 0x040036FE RID: 14078
		private UnknownFieldSet _unknownFields;

		// Token: 0x040036FF RID: 14079
		public const int IdFieldNumber = 1;

		// Token: 0x04003700 RID: 14080
		private int id_;

		// Token: 0x04003701 RID: 14081
		public const int TypeFieldNumber = 2;

		// Token: 0x04003702 RID: 14082
		private DetectionType type_;

		// Token: 0x04003703 RID: 14083
		public const int UnlockStateFieldNumber = 3;

		// Token: 0x04003704 RID: 14084
		private bool unlockState_;

		// Token: 0x04003705 RID: 14085
		public const int RefresherTimeFieldNumber = 4;

		// Token: 0x04003706 RID: 14086
		private long refresherTime_;

		// Token: 0x04003707 RID: 14087
		public const int DetectionIdFieldNumber = 5;

		// Token: 0x04003708 RID: 14088
		private int detectionId_;

		// Token: 0x04003709 RID: 14089
		public const int MapIdFieldNumber = 6;

		// Token: 0x0400370A RID: 14090
		private int mapId_;
	}
}
