using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003B9 RID: 953
	public sealed class DetectionTarget : IMessage<DetectionTarget>, IMessage, IEquatable<DetectionTarget>, IDeepCloneable<DetectionTarget>, IBufferMessage
	{
		// Token: 0x06005D98 RID: 23960 RVA: 0x000E32EB File Offset: 0x000E14EB
		[NullableContext(1)]
		public static DetectionTarget Create()
		{
			return new DetectionTarget();
		}

		// Token: 0x1700115A RID: 4442
		// (get) Token: 0x06005D99 RID: 23961 RVA: 0x000E32F2 File Offset: 0x000E14F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DetectionTarget> Parser
		{
			get
			{
				return DetectionTarget._parser;
			}
		}

		// Token: 0x1700115B RID: 4443
		// (get) Token: 0x06005D9A RID: 23962 RVA: 0x000E32F9 File Offset: 0x000E14F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700115C RID: 4444
		// (get) Token: 0x06005D9B RID: 23963 RVA: 0x000E32FC File Offset: 0x000E14FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DetectionTarget.Descriptor;
			}
		}

		// Token: 0x06005D9C RID: 23964 RVA: 0x000E3303 File Offset: 0x000E1503
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DetectionTarget()
		{
		}

		// Token: 0x06005D9D RID: 23965 RVA: 0x000E330C File Offset: 0x000E150C
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

		// Token: 0x06005D9E RID: 23966 RVA: 0x000E3378 File Offset: 0x000E1578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DetectionTarget Clone()
		{
			return new DetectionTarget(this);
		}

		// Token: 0x1700115D RID: 4445
		// (get) Token: 0x06005D9F RID: 23967 RVA: 0x000E3380 File Offset: 0x000E1580
		// (set) Token: 0x06005DA0 RID: 23968 RVA: 0x000E3388 File Offset: 0x000E1588
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

		// Token: 0x1700115E RID: 4446
		// (get) Token: 0x06005DA1 RID: 23969 RVA: 0x000E3391 File Offset: 0x000E1591
		// (set) Token: 0x06005DA2 RID: 23970 RVA: 0x000E3399 File Offset: 0x000E1599
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

		// Token: 0x1700115F RID: 4447
		// (get) Token: 0x06005DA3 RID: 23971 RVA: 0x000E33A2 File Offset: 0x000E15A2
		// (set) Token: 0x06005DA4 RID: 23972 RVA: 0x000E33AA File Offset: 0x000E15AA
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

		// Token: 0x17001160 RID: 4448
		// (get) Token: 0x06005DA5 RID: 23973 RVA: 0x000E33B3 File Offset: 0x000E15B3
		// (set) Token: 0x06005DA6 RID: 23974 RVA: 0x000E33BB File Offset: 0x000E15BB
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

		// Token: 0x17001161 RID: 4449
		// (get) Token: 0x06005DA7 RID: 23975 RVA: 0x000E33C4 File Offset: 0x000E15C4
		// (set) Token: 0x06005DA8 RID: 23976 RVA: 0x000E33CC File Offset: 0x000E15CC
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

		// Token: 0x17001162 RID: 4450
		// (get) Token: 0x06005DA9 RID: 23977 RVA: 0x000E33D5 File Offset: 0x000E15D5
		// (set) Token: 0x06005DAA RID: 23978 RVA: 0x000E33DD File Offset: 0x000E15DD
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

		// Token: 0x06005DAB RID: 23979 RVA: 0x000E33E6 File Offset: 0x000E15E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DetectionTarget);
		}

		// Token: 0x06005DAC RID: 23980 RVA: 0x000E33F4 File Offset: 0x000E15F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DetectionTarget other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Type == other.Type && this.UnlockState == other.UnlockState && this.RefresherTime == other.RefresherTime && this.DetectionId == other.DetectionId && this.MapId == other.MapId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005DAD RID: 23981 RVA: 0x000E3480 File Offset: 0x000E1680
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

		// Token: 0x06005DAE RID: 23982 RVA: 0x000E3543 File Offset: 0x000E1743
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005DAF RID: 23983 RVA: 0x000E3550 File Offset: 0x000E1750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005DB0 RID: 23984 RVA: 0x000E355C File Offset: 0x000E175C
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

		// Token: 0x06005DB1 RID: 23985 RVA: 0x000E3624 File Offset: 0x000E1824
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

		// Token: 0x06005DB2 RID: 23986 RVA: 0x000E36D0 File Offset: 0x000E18D0
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

		// Token: 0x06005DB3 RID: 23987 RVA: 0x000E3770 File Offset: 0x000E1970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005DB4 RID: 23988 RVA: 0x000E377C File Offset: 0x000E197C
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

		// Token: 0x040036EA RID: 14058
		private static readonly MessageParser<DetectionTarget> _parser = new MessageParser<DetectionTarget>(() => new DetectionTarget());

		// Token: 0x040036EB RID: 14059
		private UnknownFieldSet _unknownFields;

		// Token: 0x040036EC RID: 14060
		public const int IdFieldNumber = 1;

		// Token: 0x040036ED RID: 14061
		private int id_;

		// Token: 0x040036EE RID: 14062
		public const int TypeFieldNumber = 2;

		// Token: 0x040036EF RID: 14063
		private DetectionType type_;

		// Token: 0x040036F0 RID: 14064
		public const int UnlockStateFieldNumber = 3;

		// Token: 0x040036F1 RID: 14065
		private bool unlockState_;

		// Token: 0x040036F2 RID: 14066
		public const int RefresherTimeFieldNumber = 4;

		// Token: 0x040036F3 RID: 14067
		private long refresherTime_;

		// Token: 0x040036F4 RID: 14068
		public const int DetectionIdFieldNumber = 5;

		// Token: 0x040036F5 RID: 14069
		private int detectionId_;

		// Token: 0x040036F6 RID: 14070
		public const int MapIdFieldNumber = 6;

		// Token: 0x040036F7 RID: 14071
		private int mapId_;
	}
}
