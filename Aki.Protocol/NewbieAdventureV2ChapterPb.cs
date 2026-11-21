using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AED RID: 2797
	public sealed class NewbieAdventureV2ChapterPb : IMessage<NewbieAdventureV2ChapterPb>, IMessage, IEquatable<NewbieAdventureV2ChapterPb>, IDeepCloneable<NewbieAdventureV2ChapterPb>, IBufferMessage
	{
		// Token: 0x0600F381 RID: 62337 RVA: 0x0023923C File Offset: 0x0023743C
		[NullableContext(1)]
		public static NewbieAdventureV2ChapterPb Create()
		{
			return new NewbieAdventureV2ChapterPb();
		}

		// Token: 0x17003194 RID: 12692
		// (get) Token: 0x0600F382 RID: 62338 RVA: 0x00239243 File Offset: 0x00237443
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<NewbieAdventureV2ChapterPb> Parser
		{
			get
			{
				return NewbieAdventureV2ChapterPb._parser;
			}
		}

		// Token: 0x17003195 RID: 12693
		// (get) Token: 0x0600F383 RID: 62339 RVA: 0x0023924A File Offset: 0x0023744A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003196 RID: 12694
		// (get) Token: 0x0600F384 RID: 62340 RVA: 0x0023924D File Offset: 0x0023744D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewbieAdventureV2ChapterPb.Descriptor;
			}
		}

		// Token: 0x0600F385 RID: 62341 RVA: 0x00239254 File Offset: 0x00237454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieAdventureV2ChapterPb()
		{
		}

		// Token: 0x0600F386 RID: 62342 RVA: 0x00239268 File Offset: 0x00237468
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

		// Token: 0x0600F387 RID: 62343 RVA: 0x002392CD File Offset: 0x002374CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieAdventureV2ChapterPb Clone()
		{
			return new NewbieAdventureV2ChapterPb(this);
		}

		// Token: 0x17003197 RID: 12695
		// (get) Token: 0x0600F388 RID: 62344 RVA: 0x002392D5 File Offset: 0x002374D5
		// (set) Token: 0x0600F389 RID: 62345 RVA: 0x002392DD File Offset: 0x002374DD
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

		// Token: 0x17003198 RID: 12696
		// (get) Token: 0x0600F38A RID: 62346 RVA: 0x002392E6 File Offset: 0x002374E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTask> Task
		{
			get
			{
				return this.task_;
			}
		}

		// Token: 0x17003199 RID: 12697
		// (get) Token: 0x0600F38B RID: 62347 RVA: 0x002392EE File Offset: 0x002374EE
		// (set) Token: 0x0600F38C RID: 62348 RVA: 0x002392F6 File Offset: 0x002374F6
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

		// Token: 0x1700319A RID: 12698
		// (get) Token: 0x0600F38D RID: 62349 RVA: 0x002392FF File Offset: 0x002374FF
		// (set) Token: 0x0600F38E RID: 62350 RVA: 0x00239307 File Offset: 0x00237507
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

		// Token: 0x1700319B RID: 12699
		// (get) Token: 0x0600F38F RID: 62351 RVA: 0x00239310 File Offset: 0x00237510
		// (set) Token: 0x0600F390 RID: 62352 RVA: 0x00239318 File Offset: 0x00237518
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

		// Token: 0x0600F391 RID: 62353 RVA: 0x00239321 File Offset: 0x00237521
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewbieAdventureV2ChapterPb);
		}

		// Token: 0x0600F392 RID: 62354 RVA: 0x00239330 File Offset: 0x00237530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewbieAdventureV2ChapterPb other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.task_.Equals(other.task_) && this.RewardRoleId == other.RewardRoleId && this.RewardedRoleId == other.RewardedRoleId && this.RewardDrop == other.RewardDrop && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F393 RID: 62355 RVA: 0x002393B0 File Offset: 0x002375B0
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

		// Token: 0x0600F394 RID: 62356 RVA: 0x00239448 File Offset: 0x00237648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F395 RID: 62357 RVA: 0x00239455 File Offset: 0x00237655
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F396 RID: 62358 RVA: 0x00239460 File Offset: 0x00237660
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

		// Token: 0x0600F397 RID: 62359 RVA: 0x00239504 File Offset: 0x00237704
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

		// Token: 0x0600F398 RID: 62360 RVA: 0x00239588 File Offset: 0x00237788
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

		// Token: 0x0600F399 RID: 62361 RVA: 0x00239611 File Offset: 0x00237811
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F39A RID: 62362 RVA: 0x0023961C File Offset: 0x0023781C
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

		// Token: 0x0400627F RID: 25215
		private static readonly MessageParser<NewbieAdventureV2ChapterPb> _parser = new MessageParser<NewbieAdventureV2ChapterPb>(() => new NewbieAdventureV2ChapterPb());

		// Token: 0x04006280 RID: 25216
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006281 RID: 25217
		public const int IdFieldNumber = 1;

		// Token: 0x04006282 RID: 25218
		private int id_;

		// Token: 0x04006283 RID: 25219
		public const int TaskFieldNumber = 2;

		// Token: 0x04006284 RID: 25220
		private static readonly FieldCodec<ConditionTask> _repeated_task_codec = FieldCodec.ForMessage<ConditionTask>(18U, ConditionTask.Parser);

		// Token: 0x04006285 RID: 25221
		private readonly RepeatedField<ConditionTask> task_ = new RepeatedField<ConditionTask>();

		// Token: 0x04006286 RID: 25222
		public const int RewardRoleIdFieldNumber = 3;

		// Token: 0x04006287 RID: 25223
		private bool rewardRoleId_;

		// Token: 0x04006288 RID: 25224
		public const int RewardedRoleIdFieldNumber = 4;

		// Token: 0x04006289 RID: 25225
		private int rewardedRoleId_;

		// Token: 0x0400628A RID: 25226
		public const int RewardDropFieldNumber = 5;

		// Token: 0x0400628B RID: 25227
		private bool rewardDrop_;
	}
}
