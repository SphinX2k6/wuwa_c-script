using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A35 RID: 2613
	public sealed class MotorFightActivityPb : IMessage<MotorFightActivityPb>, IMessage, IEquatable<MotorFightActivityPb>, IDeepCloneable<MotorFightActivityPb>, IBufferMessage
	{
		// Token: 0x0600E434 RID: 58420 RVA: 0x00215FD7 File Offset: 0x002141D7
		[NullableContext(1)]
		public static MotorFightActivityPb Create()
		{
			return new MotorFightActivityPb();
		}

		// Token: 0x17002E41 RID: 11841
		// (get) Token: 0x0600E435 RID: 58421 RVA: 0x00215FDE File Offset: 0x002141DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002E42 RID: 11842
		// (get) Token: 0x0600E436 RID: 58422 RVA: 0x00215FE1 File Offset: 0x002141E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightActivityPb.Descriptor;
			}
		}

		// Token: 0x0600E437 RID: 58423 RVA: 0x00215FE8 File Offset: 0x002141E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightActivityPb()
		{
		}

		// Token: 0x0600E438 RID: 58424 RVA: 0x0021601C File Offset: 0x0021421C
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

		// Token: 0x0600E439 RID: 58425 RVA: 0x002160A0 File Offset: 0x002142A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightActivityPb Clone()
		{
			return new MotorFightActivityPb(this);
		}

		// Token: 0x17002E43 RID: 11843
		// (get) Token: 0x0600E43A RID: 58426 RVA: 0x002160A8 File Offset: 0x002142A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MotorFightLevelPb> MotorFightLevelPb
		{
			get
			{
				return this.motorFightLevelPb_;
			}
		}

		// Token: 0x17002E44 RID: 11844
		// (get) Token: 0x0600E43B RID: 58427 RVA: 0x002160B0 File Offset: 0x002142B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTask> Task
		{
			get
			{
				return this.task_;
			}
		}

		// Token: 0x17002E45 RID: 11845
		// (get) Token: 0x0600E43C RID: 58428 RVA: 0x002160B8 File Offset: 0x002142B8
		// (set) Token: 0x0600E43D RID: 58429 RVA: 0x002160C0 File Offset: 0x002142C0
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

		// Token: 0x17002E46 RID: 11846
		// (get) Token: 0x0600E43E RID: 58430 RVA: 0x002160C9 File Offset: 0x002142C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockedItem
		{
			get
			{
				return this.unlockedItem_;
			}
		}

		// Token: 0x17002E47 RID: 11847
		// (get) Token: 0x0600E43F RID: 58431 RVA: 0x002160D1 File Offset: 0x002142D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockedRole
		{
			get
			{
				return this.unlockedRole_;
			}
		}

		// Token: 0x0600E440 RID: 58432 RVA: 0x002160D9 File Offset: 0x002142D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightActivityPb);
		}

		// Token: 0x0600E441 RID: 58433 RVA: 0x002160E8 File Offset: 0x002142E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightActivityPb other)
		{
			return other != null && (other == this || (this.motorFightLevelPb_.Equals(other.motorFightLevelPb_) && this.task_.Equals(other.task_) && object.Equals(this.TalentTree, other.TalentTree) && this.unlockedItem_.Equals(other.unlockedItem_) && this.unlockedRole_.Equals(other.unlockedRole_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E442 RID: 58434 RVA: 0x0021617C File Offset: 0x0021437C
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

		// Token: 0x0600E443 RID: 58435 RVA: 0x002161F0 File Offset: 0x002143F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E444 RID: 58436 RVA: 0x002161FD File Offset: 0x002143FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E445 RID: 58437 RVA: 0x00216208 File Offset: 0x00214408
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

		// Token: 0x0600E446 RID: 58438 RVA: 0x0021628C File Offset: 0x0021448C
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

		// Token: 0x0600E447 RID: 58439 RVA: 0x00216318 File Offset: 0x00214518
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

		// Token: 0x0600E448 RID: 58440 RVA: 0x002163B0 File Offset: 0x002145B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E449 RID: 58441 RVA: 0x002163BC File Offset: 0x002145BC
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

		// Token: 0x04005D61 RID: 23905
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005D62 RID: 23906
		public const int MotorFightLevelPbFieldNumber = 2;

		// Token: 0x04005D63 RID: 23907
		private static readonly FieldCodec<MotorFightLevelPb> _repeated_motorFightLevelPb_codec = FieldCodec.ForMessage<MotorFightLevelPb>(18U, Aki.Protocol.MotorFightLevelPb.Parser);

		// Token: 0x04005D64 RID: 23908
		private readonly RepeatedField<MotorFightLevelPb> motorFightLevelPb_ = new RepeatedField<MotorFightLevelPb>();

		// Token: 0x04005D65 RID: 23909
		public const int TaskFieldNumber = 3;

		// Token: 0x04005D66 RID: 23910
		private static readonly FieldCodec<ConditionTask> _repeated_task_codec = FieldCodec.ForMessage<ConditionTask>(26U, ConditionTask.Parser);

		// Token: 0x04005D67 RID: 23911
		private readonly RepeatedField<ConditionTask> task_ = new RepeatedField<ConditionTask>();

		// Token: 0x04005D68 RID: 23912
		public const int TalentTreeFieldNumber = 4;

		// Token: 0x04005D69 RID: 23913
		private MotorFightTalentTreePb talentTree_;

		// Token: 0x04005D6A RID: 23914
		public const int UnlockedItemFieldNumber = 5;

		// Token: 0x04005D6B RID: 23915
		private static readonly FieldCodec<int> _repeated_unlockedItem_codec = FieldCodec.ForInt32(42U);

		// Token: 0x04005D6C RID: 23916
		private readonly RepeatedField<int> unlockedItem_ = new RepeatedField<int>();

		// Token: 0x04005D6D RID: 23917
		public const int UnlockedRoleFieldNumber = 6;

		// Token: 0x04005D6E RID: 23918
		private static readonly FieldCodec<int> _repeated_unlockedRole_codec = FieldCodec.ForInt32(50U);

		// Token: 0x04005D6F RID: 23919
		private readonly RepeatedField<int> unlockedRole_ = new RepeatedField<int>();
	}
}
