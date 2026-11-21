using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001331 RID: 4913
	public sealed class SurvivorsCombatStepPbData : IMessage<SurvivorsCombatStepPbData>, IMessage, IEquatable<SurvivorsCombatStepPbData>, IDeepCloneable<SurvivorsCombatStepPbData>, IBufferMessage
	{
		// Token: 0x0601A30B RID: 107275 RVA: 0x003D141D File Offset: 0x003CF61D
		[NullableContext(1)]
		public static SurvivorsCombatStepPbData Create()
		{
			return new SurvivorsCombatStepPbData();
		}

		// Token: 0x170058B1 RID: 22705
		// (get) Token: 0x0601A30C RID: 107276 RVA: 0x003D1424 File Offset: 0x003CF624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170058B2 RID: 22706
		// (get) Token: 0x0601A30D RID: 107277 RVA: 0x003D1427 File Offset: 0x003CF627
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsCombatStepPbData.Descriptor;
			}
		}

		// Token: 0x0601A30E RID: 107278 RVA: 0x003D142E File Offset: 0x003CF62E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsCombatStepPbData()
		{
		}

		// Token: 0x0601A30F RID: 107279 RVA: 0x003D1436 File Offset: 0x003CF636
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsCombatStepPbData(SurvivorsCombatStepPbData other) : this()
		{
			this.durationTime_ = other.durationTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A310 RID: 107280 RVA: 0x003D145B File Offset: 0x003CF65B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsCombatStepPbData Clone()
		{
			return new SurvivorsCombatStepPbData(this);
		}

		// Token: 0x170058B3 RID: 22707
		// (get) Token: 0x0601A311 RID: 107281 RVA: 0x003D1463 File Offset: 0x003CF663
		// (set) Token: 0x0601A312 RID: 107282 RVA: 0x003D146B File Offset: 0x003CF66B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DurationTime
		{
			get
			{
				return this.durationTime_;
			}
			set
			{
				this.durationTime_ = value;
			}
		}

		// Token: 0x0601A313 RID: 107283 RVA: 0x003D1474 File Offset: 0x003CF674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsCombatStepPbData);
		}

		// Token: 0x0601A314 RID: 107284 RVA: 0x003D1482 File Offset: 0x003CF682
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsCombatStepPbData other)
		{
			return other != null && (other == this || (this.DurationTime == other.DurationTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A315 RID: 107285 RVA: 0x003D14B0 File Offset: 0x003CF6B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DurationTime != 0)
			{
				num ^= this.DurationTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A316 RID: 107286 RVA: 0x003D14EF File Offset: 0x003CF6EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A317 RID: 107287 RVA: 0x003D14FC File Offset: 0x003CF6FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A318 RID: 107288 RVA: 0x003D1505 File Offset: 0x003CF705
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DurationTime != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.DurationTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A319 RID: 107289 RVA: 0x003D1538 File Offset: 0x003CF738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DurationTime != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DurationTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A31A RID: 107290 RVA: 0x003D1576 File Offset: 0x003CF776
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsCombatStepPbData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DurationTime != 0)
			{
				this.DurationTime = other.DurationTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A31B RID: 107291 RVA: 0x003D15A7 File Offset: 0x003CF7A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A31C RID: 107292 RVA: 0x003D15B0 File Offset: 0x003CF7B0
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.DurationTime = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009A14 RID: 39444
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009A15 RID: 39445
		public const int DurationTimeFieldNumber = 1;

		// Token: 0x04009A16 RID: 39446
		private int durationTime_;
	}
}
