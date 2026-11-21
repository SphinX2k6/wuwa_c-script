using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A24 RID: 2596
	public sealed class MotorFightActivityPb : IMessage<MotorFightActivityPb>, IMessage, IEquatable<MotorFightActivityPb>, IDeepCloneable<MotorFightActivityPb>, IBufferMessage
	{
		// Token: 0x0600E31A RID: 58138 RVA: 0x00213DE7 File Offset: 0x00211FE7
		[NullableContext(1)]
		public static MotorFightActivityPb Create()
		{
			return new MotorFightActivityPb();
		}

		// Token: 0x17002E03 RID: 11779
		// (get) Token: 0x0600E31B RID: 58139 RVA: 0x00213DEE File Offset: 0x00211FEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002E04 RID: 11780
		// (get) Token: 0x0600E31C RID: 58140 RVA: 0x00213DF1 File Offset: 0x00211FF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightActivityPb.Descriptor;
			}
		}

		// Token: 0x0600E31D RID: 58141 RVA: 0x00213DF8 File Offset: 0x00211FF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightActivityPb()
		{
		}

		// Token: 0x0600E31E RID: 58142 RVA: 0x00213E2C File Offset: 0x0021202C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightActivityPb(MotorFightActivityPb other) : this()
		{
			this.motorFightLevelPb_ = other.motorFightLevelPb_.Clone();
			this.task_ = other.task_.Clone();
			this.talentTree_ = ((other.talentTree_ != null) ? other.talentTree_.Clone() : null);
			this.unlockedItem_ = other.unlockedItem_.Clone();
			this.unlockedRole_ = other.unlockedRole_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E31F RID: 58143 RVA: 0x00213EB0 File Offset: 0x002120B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightActivityPb Clone()
		{
			return new MotorFightActivityPb(this);
		}

		// Token: 0x17002E05 RID: 11781
		// (get) Token: 0x0600E320 RID: 58144 RVA: 0x00213EB8 File Offset: 0x002120B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MotorFightLevelPb> MotorFightLevelPb
		{
			get
			{
				return this.motorFightLevelPb_;
			}
		}

		// Token: 0x17002E06 RID: 11782
		// (get) Token: 0x0600E321 RID: 58145 RVA: 0x00213EC0 File Offset: 0x002120C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTask> Task
		{
			get
			{
				return this.task_;
			}
		}

		// Token: 0x17002E07 RID: 11783
		// (get) Token: 0x0600E322 RID: 58146 RVA: 0x00213EC8 File Offset: 0x002120C8
		// (set) Token: 0x0600E323 RID: 58147 RVA: 0x00213ED0 File Offset: 0x002120D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightTalentTreePb TalentTree
		{
			get
			{
				return this.talentTree_;
			}
			set
			{
				this.talentTree_ = value;
			}
		}

		// Token: 0x17002E08 RID: 11784
		// (get) Token: 0x0600E324 RID: 58148 RVA: 0x00213ED9 File Offset: 0x002120D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockedItem
		{
			get
			{
				return this.unlockedItem_;
			}
		}

		// Token: 0x17002E09 RID: 11785
		// (get) Token: 0x0600E325 RID: 58149 RVA: 0x00213EE1 File Offset: 0x002120E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockedRole
		{
			get
			{
				return this.unlockedRole_;
			}
		}

		// Token: 0x0600E326 RID: 58150 RVA: 0x00213EE9 File Offset: 0x002120E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightActivityPb);
		}

		// Token: 0x0600E327 RID: 58151 RVA: 0x00213EF8 File Offset: 0x002120F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightActivityPb other)
		{
			return other != null && (other == this || (this.motorFightLevelPb_.Equals(other.motorFightLevelPb_) && this.task_.Equals(other.task_) && object.Equals(this.TalentTree, other.TalentTree) && this.unlockedItem_.Equals(other.unlockedItem_) && this.unlockedRole_.Equals(other.unlockedRole_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E328 RID: 58152 RVA: 0x00213F8C File Offset: 0x0021218C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.motorFightLevelPb_.GetHashCode();
			num ^= this.task_.GetHashCode();
			if (this.talentTree_ != null)
			{
				num ^= this.TalentTree.GetHashCode();
			}
			num ^= this.unlockedItem_.GetHashCode();
			num ^= this.unlockedRole_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E329 RID: 58153 RVA: 0x00214000 File Offset: 0x00212200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E32A RID: 58154 RVA: 0x0021400D File Offset: 0x0021220D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E32B RID: 58155 RVA: 0x00214018 File Offset: 0x00212218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.motorFightLevelPb_.WriteTo(ref output, MotorFightActivityPb._repeated_motorFightLevelPb_codec);
			this.task_.WriteTo(ref output, MotorFightActivityPb._repeated_task_codec);
			if (this.talentTree_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.TalentTree);
			}
			this.unlockedItem_.WriteTo(ref output, MotorFightActivityPb._repeated_unlockedItem_codec);
			this.unlockedRole_.WriteTo(ref output, MotorFightActivityPb._repeated_unlockedRole_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E32C RID: 58156 RVA: 0x0021409C File Offset: 0x0021229C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.motorFightLevelPb_.CalculateSize(MotorFightActivityPb._repeated_motorFightLevelPb_codec);
			num += this.task_.CalculateSize(MotorFightActivityPb._repeated_task_codec);
			if (this.talentTree_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TalentTree);
			}
			num += this.unlockedItem_.CalculateSize(MotorFightActivityPb._repeated_unlockedItem_codec);
			num += this.unlockedRole_.CalculateSize(MotorFightActivityPb._repeated_unlockedRole_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E32D RID: 58157 RVA: 0x00214128 File Offset: 0x00212328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightActivityPb other)
		{
			if (other == null)
			{
				return;
			}
			this.motorFightLevelPb_.Add(other.motorFightLevelPb_);
			this.task_.Add(other.task_);
			if (other.talentTree_ != null)
			{
				if (this.talentTree_ == null)
				{
					this.TalentTree = new MotorFightTalentTreePb();
				}
				this.TalentTree.MergeFrom(other.TalentTree);
			}
			this.unlockedItem_.Add(other.unlockedItem_);
			this.unlockedRole_.Add(other.unlockedRole_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E32E RID: 58158 RVA: 0x002141C0 File Offset: 0x002123C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E32F RID: 58159 RVA: 0x002141CC File Offset: 0x002123CC
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
					if (num == 18U)
					{
						this.motorFightLevelPb_.AddEntriesFrom(ref input, MotorFightActivityPb._repeated_motorFightLevelPb_codec);
						continue;
					}
					if (num == 26U)
					{
						this.task_.AddEntriesFrom(ref input, MotorFightActivityPb._repeated_task_codec);
						continue;
					}
					if (num == 34U)
					{
						if (this.talentTree_ == null)
						{
							this.TalentTree = new MotorFightTalentTreePb();
						}
						input.ReadMessage(this.TalentTree);
						continue;
					}
				}
				else if (num <= 42U)
				{
					if (num == 40U || num == 42U)
					{
						this.unlockedItem_.AddEntriesFrom(ref input, MotorFightActivityPb._repeated_unlockedItem_codec);
						continue;
					}
				}
				else if (num == 48U || num == 50U)
				{
					this.unlockedRole_.AddEntriesFrom(ref input, MotorFightActivityPb._repeated_unlockedRole_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005D6A RID: 23914
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005D6B RID: 23915
		public const int MotorFightLevelPbFieldNumber = 2;

		// Token: 0x04005D6C RID: 23916
		private static readonly FieldCodec<MotorFightLevelPb> _repeated_motorFightLevelPb_codec = FieldCodec.ForMessage<MotorFightLevelPb>(18U, Aki.Protocol.MotorFightLevelPb.Parser);

		// Token: 0x04005D6D RID: 23917
		private readonly RepeatedField<MotorFightLevelPb> motorFightLevelPb_ = new RepeatedField<MotorFightLevelPb>();

		// Token: 0x04005D6E RID: 23918
		public const int TaskFieldNumber = 3;

		// Token: 0x04005D6F RID: 23919
		private static readonly FieldCodec<ConditionTask> _repeated_task_codec = FieldCodec.ForMessage<ConditionTask>(26U, ConditionTask.Parser);

		// Token: 0x04005D70 RID: 23920
		private readonly RepeatedField<ConditionTask> task_ = new RepeatedField<ConditionTask>();

		// Token: 0x04005D71 RID: 23921
		public const int TalentTreeFieldNumber = 4;

		// Token: 0x04005D72 RID: 23922
		private MotorFightTalentTreePb talentTree_;

		// Token: 0x04005D73 RID: 23923
		public const int UnlockedItemFieldNumber = 5;

		// Token: 0x04005D74 RID: 23924
		private static readonly FieldCodec<int> _repeated_unlockedItem_codec = FieldCodec.ForInt32(42U);

		// Token: 0x04005D75 RID: 23925
		private readonly RepeatedField<int> unlockedItem_ = new RepeatedField<int>();

		// Token: 0x04005D76 RID: 23926
		public const int UnlockedRoleFieldNumber = 6;

		// Token: 0x04005D77 RID: 23927
		private static readonly FieldCodec<int> _repeated_unlockedRole_codec = FieldCodec.ForInt32(50U);

		// Token: 0x04005D78 RID: 23928
		private readonly RepeatedField<int> unlockedRole_ = new RepeatedField<int>();
	}
}
