using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012A6 RID: 4774
	public sealed class SolarSchoolBehaviorCountPb : IMessage<SolarSchoolBehaviorCountPb>, IMessage, IEquatable<SolarSchoolBehaviorCountPb>, IDeepCloneable<SolarSchoolBehaviorCountPb>, IBufferMessage
	{
		// Token: 0x060197BC RID: 104380 RVA: 0x003B7C58 File Offset: 0x003B5E58
		[NullableContext(1)]
		public static SolarSchoolBehaviorCountPb Create()
		{
			return new SolarSchoolBehaviorCountPb();
		}

		// Token: 0x1700563C RID: 22076
		// (get) Token: 0x060197BD RID: 104381 RVA: 0x003B7C5F File Offset: 0x003B5E5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SolarSchoolBehaviorCountPb> Parser
		{
			get
			{
				return SolarSchoolBehaviorCountPb._parser;
			}
		}

		// Token: 0x1700563D RID: 22077
		// (get) Token: 0x060197BE RID: 104382 RVA: 0x003B7C66 File Offset: 0x003B5E66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700563E RID: 22078
		// (get) Token: 0x060197BF RID: 104383 RVA: 0x003B7C69 File Offset: 0x003B5E69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SolarSchoolBehaviorCountPb.Descriptor;
			}
		}

		// Token: 0x060197C0 RID: 104384 RVA: 0x003B7C70 File Offset: 0x003B5E70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolBehaviorCountPb()
		{
		}

		// Token: 0x060197C1 RID: 104385 RVA: 0x003B7C78 File Offset: 0x003B5E78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolBehaviorCountPb(SolarSchoolBehaviorCountPb other) : this()
		{
			this.behaviorId_ = other.behaviorId_;
			this.totalCount_ = other.totalCount_;
			this.successCount_ = other.successCount_;
			this.specialState_ = other.specialState_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060197C2 RID: 104386 RVA: 0x003B7CCC File Offset: 0x003B5ECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolBehaviorCountPb Clone()
		{
			return new SolarSchoolBehaviorCountPb(this);
		}

		// Token: 0x1700563F RID: 22079
		// (get) Token: 0x060197C3 RID: 104387 RVA: 0x003B7CD4 File Offset: 0x003B5ED4
		// (set) Token: 0x060197C4 RID: 104388 RVA: 0x003B7CDC File Offset: 0x003B5EDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BehaviorId
		{
			get
			{
				return this.behaviorId_;
			}
			set
			{
				this.behaviorId_ = value;
			}
		}

		// Token: 0x17005640 RID: 22080
		// (get) Token: 0x060197C5 RID: 104389 RVA: 0x003B7CE5 File Offset: 0x003B5EE5
		// (set) Token: 0x060197C6 RID: 104390 RVA: 0x003B7CED File Offset: 0x003B5EED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TotalCount
		{
			get
			{
				return this.totalCount_;
			}
			set
			{
				this.totalCount_ = value;
			}
		}

		// Token: 0x17005641 RID: 22081
		// (get) Token: 0x060197C7 RID: 104391 RVA: 0x003B7CF6 File Offset: 0x003B5EF6
		// (set) Token: 0x060197C8 RID: 104392 RVA: 0x003B7CFE File Offset: 0x003B5EFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SuccessCount
		{
			get
			{
				return this.successCount_;
			}
			set
			{
				this.successCount_ = value;
			}
		}

		// Token: 0x17005642 RID: 22082
		// (get) Token: 0x060197C9 RID: 104393 RVA: 0x003B7D07 File Offset: 0x003B5F07
		// (set) Token: 0x060197CA RID: 104394 RVA: 0x003B7D0F File Offset: 0x003B5F0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SpecialState
		{
			get
			{
				return this.specialState_;
			}
			set
			{
				this.specialState_ = value;
			}
		}

		// Token: 0x060197CB RID: 104395 RVA: 0x003B7D18 File Offset: 0x003B5F18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SolarSchoolBehaviorCountPb);
		}

		// Token: 0x060197CC RID: 104396 RVA: 0x003B7D28 File Offset: 0x003B5F28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SolarSchoolBehaviorCountPb other)
		{
			return other != null && (other == this || (this.BehaviorId == other.BehaviorId && this.TotalCount == other.TotalCount && this.SuccessCount == other.SuccessCount && this.SpecialState == other.SpecialState && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060197CD RID: 104397 RVA: 0x003B7D94 File Offset: 0x003B5F94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BehaviorId != 0)
			{
				num ^= this.BehaviorId.GetHashCode();
			}
			if (this.TotalCount != 0)
			{
				num ^= this.TotalCount.GetHashCode();
			}
			if (this.SuccessCount != 0)
			{
				num ^= this.SuccessCount.GetHashCode();
			}
			if (this.SpecialState != 0)
			{
				num ^= this.SpecialState.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060197CE RID: 104398 RVA: 0x003B7E1E File Offset: 0x003B601E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060197CF RID: 104399 RVA: 0x003B7E2B File Offset: 0x003B602B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060197D0 RID: 104400 RVA: 0x003B7E34 File Offset: 0x003B6034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BehaviorId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.BehaviorId);
			}
			if (this.TotalCount != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.TotalCount);
			}
			if (this.SuccessCount != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.SuccessCount);
			}
			if (this.SpecialState != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.SpecialState);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060197D1 RID: 104401 RVA: 0x003B7EC4 File Offset: 0x003B60C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BehaviorId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BehaviorId);
			}
			if (this.TotalCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TotalCount);
			}
			if (this.SuccessCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SuccessCount);
			}
			if (this.SpecialState != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SpecialState);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060197D2 RID: 104402 RVA: 0x003B7F4C File Offset: 0x003B614C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SolarSchoolBehaviorCountPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BehaviorId != 0)
			{
				this.BehaviorId = other.BehaviorId;
			}
			if (other.TotalCount != 0)
			{
				this.TotalCount = other.TotalCount;
			}
			if (other.SuccessCount != 0)
			{
				this.SuccessCount = other.SuccessCount;
			}
			if (other.SpecialState != 0)
			{
				this.SpecialState = other.SpecialState;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060197D3 RID: 104403 RVA: 0x003B7FC4 File Offset: 0x003B61C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060197D4 RID: 104404 RVA: 0x003B7FD0 File Offset: 0x003B61D0
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
						this.BehaviorId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.TotalCount = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.SuccessCount = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.SpecialState = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040096A0 RID: 38560
		private static readonly MessageParser<SolarSchoolBehaviorCountPb> _parser = new MessageParser<SolarSchoolBehaviorCountPb>(() => new SolarSchoolBehaviorCountPb());

		// Token: 0x040096A1 RID: 38561
		private UnknownFieldSet _unknownFields;

		// Token: 0x040096A2 RID: 38562
		public const int BehaviorIdFieldNumber = 1;

		// Token: 0x040096A3 RID: 38563
		private int behaviorId_;

		// Token: 0x040096A4 RID: 38564
		public const int TotalCountFieldNumber = 2;

		// Token: 0x040096A5 RID: 38565
		private int totalCount_;

		// Token: 0x040096A6 RID: 38566
		public const int SuccessCountFieldNumber = 3;

		// Token: 0x040096A7 RID: 38567
		private int successCount_;

		// Token: 0x040096A8 RID: 38568
		public const int SpecialStateFieldNumber = 4;

		// Token: 0x040096A9 RID: 38569
		private int specialState_;
	}
}
