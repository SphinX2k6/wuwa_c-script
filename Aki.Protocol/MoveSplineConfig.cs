using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AC5 RID: 2757
	public sealed class MoveSplineConfig : IMessage<MoveSplineConfig>, IMessage, IEquatable<MoveSplineConfig>, IDeepCloneable<MoveSplineConfig>, IBufferMessage
	{
		// Token: 0x0600EFFB RID: 61435 RVA: 0x00230DDD File Offset: 0x0022EFDD
		[NullableContext(1)]
		public static MoveSplineConfig Create()
		{
			return new MoveSplineConfig();
		}

		// Token: 0x170030D3 RID: 12499
		// (get) Token: 0x0600EFFC RID: 61436 RVA: 0x00230DE4 File Offset: 0x0022EFE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170030D4 RID: 12500
		// (get) Token: 0x0600EFFD RID: 61437 RVA: 0x00230DE7 File Offset: 0x0022EFE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MoveSplineConfig.Descriptor;
			}
		}

		// Token: 0x0600EFFE RID: 61438 RVA: 0x00230DEE File Offset: 0x0022EFEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoveSplineConfig()
		{
		}

		// Token: 0x0600EFFF RID: 61439 RVA: 0x00230DF8 File Offset: 0x0022EFF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoveSplineConfig(MoveSplineConfig other) : this()
		{
			this._hasBits0 = other._hasBits0;
			this.startPointIndex_ = other.startPointIndex_;
			this.endPointIndex_ = other.endPointIndex_;
			this.isLookDir_ = other.isLookDir_;
			this.cycleCount_ = other.cycleCount_;
			this.isCircle_ = other.isCircle_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F000 RID: 61440 RVA: 0x00230E64 File Offset: 0x0022F064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoveSplineConfig Clone()
		{
			return new MoveSplineConfig(this);
		}

		// Token: 0x170030D5 RID: 12501
		// (get) Token: 0x0600F001 RID: 61441 RVA: 0x00230E6C File Offset: 0x0022F06C
		// (set) Token: 0x0600F002 RID: 61442 RVA: 0x00230E84 File Offset: 0x0022F084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int StartPointIndex
		{
			get
			{
				if ((this._hasBits0 & 1) != 0)
				{
					return this.startPointIndex_;
				}
				return MoveSplineConfig.StartPointIndexDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.startPointIndex_ = value;
			}
		}

		// Token: 0x170030D6 RID: 12502
		// (get) Token: 0x0600F003 RID: 61443 RVA: 0x00230E9B File Offset: 0x0022F09B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasStartPointIndex
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600F004 RID: 61444 RVA: 0x00230EA8 File Offset: 0x0022F0A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearStartPointIndex()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170030D7 RID: 12503
		// (get) Token: 0x0600F005 RID: 61445 RVA: 0x00230EB9 File Offset: 0x0022F0B9
		// (set) Token: 0x0600F006 RID: 61446 RVA: 0x00230ED1 File Offset: 0x0022F0D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EndPointIndex
		{
			get
			{
				if ((this._hasBits0 & 2) != 0)
				{
					return this.endPointIndex_;
				}
				return MoveSplineConfig.EndPointIndexDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.endPointIndex_ = value;
			}
		}

		// Token: 0x170030D8 RID: 12504
		// (get) Token: 0x0600F007 RID: 61447 RVA: 0x00230EE8 File Offset: 0x0022F0E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasEndPointIndex
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600F008 RID: 61448 RVA: 0x00230EF5 File Offset: 0x0022F0F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearEndPointIndex()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170030D9 RID: 12505
		// (get) Token: 0x0600F009 RID: 61449 RVA: 0x00230F06 File Offset: 0x0022F106
		// (set) Token: 0x0600F00A RID: 61450 RVA: 0x00230F1E File Offset: 0x0022F11E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsLookDir
		{
			get
			{
				if ((this._hasBits0 & 4) != 0)
				{
					return this.isLookDir_;
				}
				return MoveSplineConfig.IsLookDirDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.isLookDir_ = value;
			}
		}

		// Token: 0x170030DA RID: 12506
		// (get) Token: 0x0600F00B RID: 61451 RVA: 0x00230F35 File Offset: 0x0022F135
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasIsLookDir
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600F00C RID: 61452 RVA: 0x00230F42 File Offset: 0x0022F142
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearIsLookDir()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x170030DB RID: 12507
		// (get) Token: 0x0600F00D RID: 61453 RVA: 0x00230F53 File Offset: 0x0022F153
		// (set) Token: 0x0600F00E RID: 61454 RVA: 0x00230F6B File Offset: 0x0022F16B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CycleCount
		{
			get
			{
				if ((this._hasBits0 & 8) != 0)
				{
					return this.cycleCount_;
				}
				return MoveSplineConfig.CycleCountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.cycleCount_ = value;
			}
		}

		// Token: 0x170030DC RID: 12508
		// (get) Token: 0x0600F00F RID: 61455 RVA: 0x00230F82 File Offset: 0x0022F182
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasCycleCount
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x0600F010 RID: 61456 RVA: 0x00230F8F File Offset: 0x0022F18F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearCycleCount()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x170030DD RID: 12509
		// (get) Token: 0x0600F011 RID: 61457 RVA: 0x00230FA0 File Offset: 0x0022F1A0
		// (set) Token: 0x0600F012 RID: 61458 RVA: 0x00230FB9 File Offset: 0x0022F1B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsCircle
		{
			get
			{
				if ((this._hasBits0 & 16) != 0)
				{
					return this.isCircle_;
				}
				return MoveSplineConfig.IsCircleDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.isCircle_ = value;
			}
		}

		// Token: 0x170030DE RID: 12510
		// (get) Token: 0x0600F013 RID: 61459 RVA: 0x00230FD1 File Offset: 0x0022F1D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasIsCircle
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x0600F014 RID: 61460 RVA: 0x00230FDF File Offset: 0x0022F1DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearIsCircle()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x0600F015 RID: 61461 RVA: 0x00230FF0 File Offset: 0x0022F1F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MoveSplineConfig);
		}

		// Token: 0x0600F016 RID: 61462 RVA: 0x00231000 File Offset: 0x0022F200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MoveSplineConfig other)
		{
			return other != null && (other == this || (this.StartPointIndex == other.StartPointIndex && this.EndPointIndex == other.EndPointIndex && this.IsLookDir == other.IsLookDir && this.CycleCount == other.CycleCount && this.IsCircle == other.IsCircle && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F017 RID: 61463 RVA: 0x0023107C File Offset: 0x0022F27C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HasStartPointIndex)
			{
				num ^= this.StartPointIndex.GetHashCode();
			}
			if (this.HasEndPointIndex)
			{
				num ^= this.EndPointIndex.GetHashCode();
			}
			if (this.HasIsLookDir)
			{
				num ^= this.IsLookDir.GetHashCode();
			}
			if (this.HasCycleCount)
			{
				num ^= this.CycleCount.GetHashCode();
			}
			if (this.HasIsCircle)
			{
				num ^= this.IsCircle.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F018 RID: 61464 RVA: 0x0023111F File Offset: 0x0022F31F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F019 RID: 61465 RVA: 0x0023112C File Offset: 0x0022F32C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F01A RID: 61466 RVA: 0x00231138 File Offset: 0x0022F338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HasStartPointIndex)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.StartPointIndex);
			}
			if (this.HasEndPointIndex)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.EndPointIndex);
			}
			if (this.HasIsLookDir)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsLookDir);
			}
			if (this.HasCycleCount)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.CycleCount);
			}
			if (this.HasIsCircle)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.IsCircle);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F01B RID: 61467 RVA: 0x002311E4 File Offset: 0x0022F3E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HasStartPointIndex)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StartPointIndex);
			}
			if (this.HasEndPointIndex)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EndPointIndex);
			}
			if (this.HasIsLookDir)
			{
				num += 2;
			}
			if (this.HasCycleCount)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CycleCount);
			}
			if (this.HasIsCircle)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F01C RID: 61468 RVA: 0x0023126C File Offset: 0x0022F46C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MoveSplineConfig other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HasStartPointIndex)
			{
				this.StartPointIndex = other.StartPointIndex;
			}
			if (other.HasEndPointIndex)
			{
				this.EndPointIndex = other.EndPointIndex;
			}
			if (other.HasIsLookDir)
			{
				this.IsLookDir = other.IsLookDir;
			}
			if (other.HasCycleCount)
			{
				this.CycleCount = other.CycleCount;
			}
			if (other.HasIsCircle)
			{
				this.IsCircle = other.IsCircle;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F01D RID: 61469 RVA: 0x002312F8 File Offset: 0x0022F4F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F01E RID: 61470 RVA: 0x00231304 File Offset: 0x0022F504
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.StartPointIndex = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.EndPointIndex = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.IsLookDir = input.ReadBool();
						continue;
					}
					if (num == 32U)
					{
						this.CycleCount = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.IsCircle = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006104 RID: 24836
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006105 RID: 24837
		private int _hasBits0;

		// Token: 0x04006106 RID: 24838
		public const int StartPointIndexFieldNumber = 1;

		// Token: 0x04006107 RID: 24839
		private static readonly int StartPointIndexDefaultValue;

		// Token: 0x04006108 RID: 24840
		private int startPointIndex_;

		// Token: 0x04006109 RID: 24841
		public const int EndPointIndexFieldNumber = 2;

		// Token: 0x0400610A RID: 24842
		private static readonly int EndPointIndexDefaultValue;

		// Token: 0x0400610B RID: 24843
		private int endPointIndex_;

		// Token: 0x0400610C RID: 24844
		public const int IsLookDirFieldNumber = 3;

		// Token: 0x0400610D RID: 24845
		private static readonly bool IsLookDirDefaultValue;

		// Token: 0x0400610E RID: 24846
		private bool isLookDir_;

		// Token: 0x0400610F RID: 24847
		public const int CycleCountFieldNumber = 4;

		// Token: 0x04006110 RID: 24848
		private static readonly int CycleCountDefaultValue;

		// Token: 0x04006111 RID: 24849
		private int cycleCount_;

		// Token: 0x04006112 RID: 24850
		public const int IsCircleFieldNumber = 5;

		// Token: 0x04006113 RID: 24851
		private static readonly bool IsCircleDefaultValue;

		// Token: 0x04006114 RID: 24852
		private bool isCircle_;
	}
}
