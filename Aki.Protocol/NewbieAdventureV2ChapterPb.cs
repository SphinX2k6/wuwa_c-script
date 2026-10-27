using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AFE RID: 2814
	public sealed class NewbieAdventureV2ChapterPb : IMessage<NewbieAdventureV2ChapterPb>, IMessage, IEquatable<NewbieAdventureV2ChapterPb>, IDeepCloneable<NewbieAdventureV2ChapterPb>, IBufferMessage
	{
		// Token: 0x0600F49B RID: 62619 RVA: 0x0023B448 File Offset: 0x00239648
		[NullableContext(1)]
		public static NewbieAdventureV2ChapterPb Create()
		{
			return new NewbieAdventureV2ChapterPb();
		}

		// Token: 0x170031D2 RID: 12754
		// (get) Token: 0x0600F49C RID: 62620 RVA: 0x0023B44F File Offset: 0x0023964F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<NewbieAdventureV2ChapterPb> Parser
		{
			get
			{
				return NewbieAdventureV2ChapterPb._parser;
			}
		}

		// Token: 0x170031D3 RID: 12755
		// (get) Token: 0x0600F49D RID: 62621 RVA: 0x0023B456 File Offset: 0x00239656
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170031D4 RID: 12756
		// (get) Token: 0x0600F49E RID: 62622 RVA: 0x0023B459 File Offset: 0x00239659
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewbieAdventureV2ChapterPb.Descriptor;
			}
		}

		// Token: 0x0600F49F RID: 62623 RVA: 0x0023B460 File Offset: 0x00239660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieAdventureV2ChapterPb()
		{
		}

		// Token: 0x0600F4A0 RID: 62624 RVA: 0x0023B474 File Offset: 0x00239674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieAdventureV2ChapterPb(NewbieAdventureV2ChapterPb other) : this()
		{
			this.id_ = other.id_;
			this.task_ = other.task_.Clone();
			this.rewardRoleId_ = other.rewardRoleId_;
			this.rewardedRoleId_ = other.rewardedRoleId_;
			this.rewardDrop_ = other.rewardDrop_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F4A1 RID: 62625 RVA: 0x0023B4D9 File Offset: 0x002396D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieAdventureV2ChapterPb Clone()
		{
			return new NewbieAdventureV2ChapterPb(this);
		}

		// Token: 0x170031D5 RID: 12757
		// (get) Token: 0x0600F4A2 RID: 62626 RVA: 0x0023B4E1 File Offset: 0x002396E1
		// (set) Token: 0x0600F4A3 RID: 62627 RVA: 0x0023B4E9 File Offset: 0x002396E9
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

		// Token: 0x170031D6 RID: 12758
		// (get) Token: 0x0600F4A4 RID: 62628 RVA: 0x0023B4F2 File Offset: 0x002396F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTask> Task
		{
			get
			{
				return this.task_;
			}
		}

		// Token: 0x170031D7 RID: 12759
		// (get) Token: 0x0600F4A5 RID: 62629 RVA: 0x0023B4FA File Offset: 0x002396FA
		// (set) Token: 0x0600F4A6 RID: 62630 RVA: 0x0023B502 File Offset: 0x00239702
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool RewardRoleId
		{
			get
			{
				return this.rewardRoleId_;
			}
			set
			{
				this.rewardRoleId_ = value;
			}
		}

		// Token: 0x170031D8 RID: 12760
		// (get) Token: 0x0600F4A7 RID: 62631 RVA: 0x0023B50B File Offset: 0x0023970B
		// (set) Token: 0x0600F4A8 RID: 62632 RVA: 0x0023B513 File Offset: 0x00239713
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RewardedRoleId
		{
			get
			{
				return this.rewardedRoleId_;
			}
			set
			{
				this.rewardedRoleId_ = value;
			}
		}

		// Token: 0x170031D9 RID: 12761
		// (get) Token: 0x0600F4A9 RID: 62633 RVA: 0x0023B51C File Offset: 0x0023971C
		// (set) Token: 0x0600F4AA RID: 62634 RVA: 0x0023B524 File Offset: 0x00239724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool RewardDrop
		{
			get
			{
				return this.rewardDrop_;
			}
			set
			{
				this.rewardDrop_ = value;
			}
		}

		// Token: 0x0600F4AB RID: 62635 RVA: 0x0023B52D File Offset: 0x0023972D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewbieAdventureV2ChapterPb);
		}

		// Token: 0x0600F4AC RID: 62636 RVA: 0x0023B53C File Offset: 0x0023973C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewbieAdventureV2ChapterPb other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.task_.Equals(other.task_) && this.RewardRoleId == other.RewardRoleId && this.RewardedRoleId == other.RewardedRoleId && this.RewardDrop == other.RewardDrop && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F4AD RID: 62637 RVA: 0x0023B5BC File Offset: 0x002397BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			num ^= this.task_.GetHashCode();
			if (this.RewardRoleId)
			{
				num ^= this.RewardRoleId.GetHashCode();
			}
			if (this.RewardedRoleId != 0)
			{
				num ^= this.RewardedRoleId.GetHashCode();
			}
			if (this.RewardDrop)
			{
				num ^= this.RewardDrop.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F4AE RID: 62638 RVA: 0x0023B654 File Offset: 0x00239854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F4AF RID: 62639 RVA: 0x0023B661 File Offset: 0x00239861
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F4B0 RID: 62640 RVA: 0x0023B66C File Offset: 0x0023986C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			this.task_.WriteTo(ref output, NewbieAdventureV2ChapterPb._repeated_task_codec);
			if (this.RewardRoleId)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.RewardRoleId);
			}
			if (this.RewardedRoleId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.RewardedRoleId);
			}
			if (this.RewardDrop)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.RewardDrop);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F4B1 RID: 62641 RVA: 0x0023B710 File Offset: 0x00239910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			num += this.task_.CalculateSize(NewbieAdventureV2ChapterPb._repeated_task_codec);
			if (this.RewardRoleId)
			{
				num += 2;
			}
			if (this.RewardedRoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RewardedRoleId);
			}
			if (this.RewardDrop)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F4B2 RID: 62642 RVA: 0x0023B794 File Offset: 0x00239994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewbieAdventureV2ChapterPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this.task_.Add(other.task_);
			if (other.RewardRoleId)
			{
				this.RewardRoleId = other.RewardRoleId;
			}
			if (other.RewardedRoleId != 0)
			{
				this.RewardedRoleId = other.RewardedRoleId;
			}
			if (other.RewardDrop)
			{
				this.RewardDrop = other.RewardDrop;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F4B3 RID: 62643 RVA: 0x0023B81D File Offset: 0x00239A1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F4B4 RID: 62644 RVA: 0x0023B828 File Offset: 0x00239A28
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
				if (num <= 18U)
				{
					if (num == 8U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
					if (num == 18U)
					{
						this.task_.AddEntriesFrom(ref input, NewbieAdventureV2ChapterPb._repeated_task_codec);
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.RewardRoleId = input.ReadBool();
						continue;
					}
					if (num == 32U)
					{
						this.RewardedRoleId = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.RewardDrop = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006276 RID: 25206
		private static readonly MessageParser<NewbieAdventureV2ChapterPb> _parser = new MessageParser<NewbieAdventureV2ChapterPb>(() => new NewbieAdventureV2ChapterPb());

		// Token: 0x04006277 RID: 25207
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006278 RID: 25208
		public const int IdFieldNumber = 1;

		// Token: 0x04006279 RID: 25209
		private int id_;

		// Token: 0x0400627A RID: 25210
		public const int TaskFieldNumber = 2;

		// Token: 0x0400627B RID: 25211
		private static readonly FieldCodec<ConditionTask> _repeated_task_codec = FieldCodec.ForMessage<ConditionTask>(18U, ConditionTask.Parser);

		// Token: 0x0400627C RID: 25212
		private readonly RepeatedField<ConditionTask> task_ = new RepeatedField<ConditionTask>();

		// Token: 0x0400627D RID: 25213
		public const int RewardRoleIdFieldNumber = 3;

		// Token: 0x0400627E RID: 25214
		private bool rewardRoleId_;

		// Token: 0x0400627F RID: 25215
		public const int RewardedRoleIdFieldNumber = 4;

		// Token: 0x04006280 RID: 25216
		private int rewardedRoleId_;

		// Token: 0x04006281 RID: 25217
		public const int RewardDropFieldNumber = 5;

		// Token: 0x04006282 RID: 25218
		private bool rewardDrop_;
	}
}
