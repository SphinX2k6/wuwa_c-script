using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012C2 RID: 4802
	public sealed class SurvivorsCombatStepPbData : IMessage<SurvivorsCombatStepPbData>, IMessage, IEquatable<SurvivorsCombatStepPbData>, IDeepCloneable<SurvivorsCombatStepPbData>, IBufferMessage
	{
		// Token: 0x060198D5 RID: 104661 RVA: 0x003B6CE1 File Offset: 0x003B4EE1
		[NullableContext(1)]
		public static SurvivorsCombatStepPbData Create()
		{
			return new SurvivorsCombatStepPbData();
		}

		// Token: 0x17005630 RID: 22064
		// (get) Token: 0x060198D6 RID: 104662 RVA: 0x003B6CE8 File Offset: 0x003B4EE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005631 RID: 22065
		// (get) Token: 0x060198D7 RID: 104663 RVA: 0x003B6CEB File Offset: 0x003B4EEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsCombatStepPbData.Descriptor;
			}
		}

		// Token: 0x060198D8 RID: 104664 RVA: 0x003B6CF2 File Offset: 0x003B4EF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsCombatStepPbData()
		{
		}

		// Token: 0x060198D9 RID: 104665 RVA: 0x003B6CFA File Offset: 0x003B4EFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsCombatStepPbData(SurvivorsCombatStepPbData other) : this()
		{
			this.durationTime_ = other.durationTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060198DA RID: 104666 RVA: 0x003B6D1F File Offset: 0x003B4F1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsCombatStepPbData Clone()
		{
			return new SurvivorsCombatStepPbData(this);
		}

		// Token: 0x17005632 RID: 22066
		// (get) Token: 0x060198DB RID: 104667 RVA: 0x003B6D27 File Offset: 0x003B4F27
		// (set) Token: 0x060198DC RID: 104668 RVA: 0x003B6D2F File Offset: 0x003B4F2F
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

		// Token: 0x060198DD RID: 104669 RVA: 0x003B6D38 File Offset: 0x003B4F38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsCombatStepPbData);
		}

		// Token: 0x060198DE RID: 104670 RVA: 0x003B6D46 File Offset: 0x003B4F46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsCombatStepPbData other)
		{
			return other != null && (other == this || (this.DurationTime == other.DurationTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060198DF RID: 104671 RVA: 0x003B6D74 File Offset: 0x003B4F74
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

		// Token: 0x060198E0 RID: 104672 RVA: 0x003B6DB3 File Offset: 0x003B4FB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060198E1 RID: 104673 RVA: 0x003B6DC0 File Offset: 0x003B4FC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060198E2 RID: 104674 RVA: 0x003B6DC9 File Offset: 0x003B4FC9
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

		// Token: 0x060198E3 RID: 104675 RVA: 0x003B6DFC File Offset: 0x003B4FFC
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

		// Token: 0x060198E4 RID: 104676 RVA: 0x003B6E3A File Offset: 0x003B503A
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

		// Token: 0x060198E5 RID: 104677 RVA: 0x003B6E6B File Offset: 0x003B506B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060198E6 RID: 104678 RVA: 0x003B6E74 File Offset: 0x003B5074
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

		// Token: 0x040095EA RID: 38378
		private UnknownFieldSet _unknownFields;

		// Token: 0x040095EB RID: 38379
		public const int DurationTimeFieldNumber = 1;

		// Token: 0x040095EC RID: 38380
		private int durationTime_;
	}
}
