using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000885 RID: 2181
	public sealed class KurotatoActivityData : IMessage<KurotatoActivityData>, IMessage, IEquatable<KurotatoActivityData>, IDeepCloneable<KurotatoActivityData>, IBufferMessage
	{
		// Token: 0x0600C221 RID: 49697 RVA: 0x001CD15D File Offset: 0x001CB35D
		[NullableContext(1)]
		public static KurotatoActivityData Create()
		{
			return new KurotatoActivityData();
		}

		// Token: 0x17002740 RID: 10048
		// (get) Token: 0x0600C222 RID: 49698 RVA: 0x001CD164 File Offset: 0x001CB364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002741 RID: 10049
		// (get) Token: 0x0600C223 RID: 49699 RVA: 0x001CD167 File Offset: 0x001CB367
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoActivityData.Descriptor;
			}
		}

		// Token: 0x0600C224 RID: 49700 RVA: 0x001CD170 File Offset: 0x001CB370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoActivityData()
		{
		}

		// Token: 0x0600C225 RID: 49701 RVA: 0x001CD1D0 File Offset: 0x001CB3D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoActivityData(KurotatoActivityData other) : this()
		{
			this.kurotatoLevelInfos_ = other.kurotatoLevelInfos_.Clone();
			this.kurotatoRoleInfos_ = other.kurotatoRoleInfos_.Clone();
			this.unlockWeapons_ = other.unlockWeapons_.Clone();
			this.unlockItems_ = other.unlockItems_.Clone();
			this.scoreTasks_ = other.scoreTasks_.Clone();
			this.resTasks_ = other.resTasks_.Clone();
			this.limitTasks_ = other.limitTasks_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C226 RID: 49702 RVA: 0x001CD26B File Offset: 0x001CB46B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoActivityData Clone()
		{
			return new KurotatoActivityData(this);
		}

		// Token: 0x17002742 RID: 10050
		// (get) Token: 0x0600C227 RID: 49703 RVA: 0x001CD273 File Offset: 0x001CB473
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<KurotatoLevelInfo> KurotatoLevelInfos
		{
			get
			{
				return this.kurotatoLevelInfos_;
			}
		}

		// Token: 0x17002743 RID: 10051
		// (get) Token: 0x0600C228 RID: 49704 RVA: 0x001CD27B File Offset: 0x001CB47B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<KurotatoRoleInfo> KurotatoRoleInfos
		{
			get
			{
				return this.kurotatoRoleInfos_;
			}
		}

		// Token: 0x17002744 RID: 10052
		// (get) Token: 0x0600C229 RID: 49705 RVA: 0x001CD283 File Offset: 0x001CB483
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockWeapons
		{
			get
			{
				return this.unlockWeapons_;
			}
		}

		// Token: 0x17002745 RID: 10053
		// (get) Token: 0x0600C22A RID: 49706 RVA: 0x001CD28B File Offset: 0x001CB48B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockItems
		{
			get
			{
				return this.unlockItems_;
			}
		}

		// Token: 0x17002746 RID: 10054
		// (get) Token: 0x0600C22B RID: 49707 RVA: 0x001CD293 File Offset: 0x001CB493
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ScoreTasks
		{
			get
			{
				return this.scoreTasks_;
			}
		}

		// Token: 0x17002747 RID: 10055
		// (get) Token: 0x0600C22C RID: 49708 RVA: 0x001CD29B File Offset: 0x001CB49B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTask> ResTasks
		{
			get
			{
				return this.resTasks_;
			}
		}

		// Token: 0x17002748 RID: 10056
		// (get) Token: 0x0600C22D RID: 49709 RVA: 0x001CD2A3 File Offset: 0x001CB4A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTask> LimitTasks
		{
			get
			{
				return this.limitTasks_;
			}
		}

		// Token: 0x0600C22E RID: 49710 RVA: 0x001CD2AB File Offset: 0x001CB4AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoActivityData);
		}

		// Token: 0x0600C22F RID: 49711 RVA: 0x001CD2BC File Offset: 0x001CB4BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoActivityData other)
		{
			return other != null && (other == this || (this.kurotatoLevelInfos_.Equals(other.kurotatoLevelInfos_) && this.kurotatoRoleInfos_.Equals(other.kurotatoRoleInfos_) && this.unlockWeapons_.Equals(other.unlockWeapons_) && this.unlockItems_.Equals(other.unlockItems_) && this.scoreTasks_.Equals(other.scoreTasks_) && this.resTasks_.Equals(other.resTasks_) && this.limitTasks_.Equals(other.limitTasks_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C230 RID: 49712 RVA: 0x001CD378 File Offset: 0x001CB578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.kurotatoLevelInfos_.GetHashCode();
			num ^= this.kurotatoRoleInfos_.GetHashCode();
			num ^= this.unlockWeapons_.GetHashCode();
			num ^= this.unlockItems_.GetHashCode();
			num ^= this.scoreTasks_.GetHashCode();
			num ^= this.resTasks_.GetHashCode();
			num ^= this.limitTasks_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C231 RID: 49713 RVA: 0x001CD400 File Offset: 0x001CB600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C232 RID: 49714 RVA: 0x001CD40D File Offset: 0x001CB60D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C233 RID: 49715 RVA: 0x001CD418 File Offset: 0x001CB618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.kurotatoLevelInfos_.WriteTo(ref output, KurotatoActivityData._repeated_kurotatoLevelInfos_codec);
			this.kurotatoRoleInfos_.WriteTo(ref output, KurotatoActivityData._repeated_kurotatoRoleInfos_codec);
			this.unlockWeapons_.WriteTo(ref output, KurotatoActivityData._repeated_unlockWeapons_codec);
			this.unlockItems_.WriteTo(ref output, KurotatoActivityData._repeated_unlockItems_codec);
			this.scoreTasks_.WriteTo(ref output, KurotatoActivityData._repeated_scoreTasks_codec);
			this.resTasks_.WriteTo(ref output, KurotatoActivityData._repeated_resTasks_codec);
			this.limitTasks_.WriteTo(ref output, KurotatoActivityData._repeated_limitTasks_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C234 RID: 49716 RVA: 0x001CD4B0 File Offset: 0x001CB6B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.kurotatoLevelInfos_.CalculateSize(KurotatoActivityData._repeated_kurotatoLevelInfos_codec);
			num += this.kurotatoRoleInfos_.CalculateSize(KurotatoActivityData._repeated_kurotatoRoleInfos_codec);
			num += this.unlockWeapons_.CalculateSize(KurotatoActivityData._repeated_unlockWeapons_codec);
			num += this.unlockItems_.CalculateSize(KurotatoActivityData._repeated_unlockItems_codec);
			num += this.scoreTasks_.CalculateSize(KurotatoActivityData._repeated_scoreTasks_codec);
			num += this.resTasks_.CalculateSize(KurotatoActivityData._repeated_resTasks_codec);
			num += this.limitTasks_.CalculateSize(KurotatoActivityData._repeated_limitTasks_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C235 RID: 49717 RVA: 0x001CD55C File Offset: 0x001CB75C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoActivityData other)
		{
			if (other == null)
			{
				return;
			}
			this.kurotatoLevelInfos_.Add(other.kurotatoLevelInfos_);
			this.kurotatoRoleInfos_.Add(other.kurotatoRoleInfos_);
			this.unlockWeapons_.Add(other.unlockWeapons_);
			this.unlockItems_.Add(other.unlockItems_);
			this.scoreTasks_.Add(other.scoreTasks_);
			this.resTasks_.Add(other.resTasks_);
			this.limitTasks_.Add(other.limitTasks_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C236 RID: 49718 RVA: 0x001CD5FB File Offset: 0x001CB7FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C237 RID: 49719 RVA: 0x001CD604 File Offset: 0x001CB804
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
				if (num > 32U)
				{
					if (num <= 40U)
					{
						if (num == 34U)
						{
							goto IL_A6;
						}
						if (num != 40U)
						{
							goto IL_56;
						}
					}
					else if (num != 42U)
					{
						if (num == 50U)
						{
							this.resTasks_.AddEntriesFrom(ref input, KurotatoActivityData._repeated_resTasks_codec);
							continue;
						}
						if (num != 58U)
						{
							goto IL_56;
						}
						this.limitTasks_.AddEntriesFrom(ref input, KurotatoActivityData._repeated_limitTasks_codec);
						continue;
					}
					this.scoreTasks_.AddEntriesFrom(ref input, KurotatoActivityData._repeated_scoreTasks_codec);
					continue;
				}
				if (num <= 18U)
				{
					if (num == 10U)
					{
						this.kurotatoLevelInfos_.AddEntriesFrom(ref input, KurotatoActivityData._repeated_kurotatoLevelInfos_codec);
						continue;
					}
					if (num == 18U)
					{
						this.kurotatoRoleInfos_.AddEntriesFrom(ref input, KurotatoActivityData._repeated_kurotatoRoleInfos_codec);
						continue;
					}
				}
				else
				{
					if (num == 24U || num == 26U)
					{
						this.unlockWeapons_.AddEntriesFrom(ref input, KurotatoActivityData._repeated_unlockWeapons_codec);
						continue;
					}
					if (num == 32U)
					{
						goto IL_A6;
					}
				}
				IL_56:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_A6:
				this.unlockItems_.AddEntriesFrom(ref input, KurotatoActivityData._repeated_unlockItems_codec);
			}
		}

		// Token: 0x0400541D RID: 21533
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400541E RID: 21534
		public const int KurotatoLevelInfosFieldNumber = 1;

		// Token: 0x0400541F RID: 21535
		private static readonly FieldCodec<KurotatoLevelInfo> _repeated_kurotatoLevelInfos_codec = FieldCodec.ForMessage<KurotatoLevelInfo>(10U, KurotatoLevelInfo.Parser);

		// Token: 0x04005420 RID: 21536
		private readonly RepeatedField<KurotatoLevelInfo> kurotatoLevelInfos_ = new RepeatedField<KurotatoLevelInfo>();

		// Token: 0x04005421 RID: 21537
		public const int KurotatoRoleInfosFieldNumber = 2;

		// Token: 0x04005422 RID: 21538
		private static readonly FieldCodec<KurotatoRoleInfo> _repeated_kurotatoRoleInfos_codec = FieldCodec.ForMessage<KurotatoRoleInfo>(18U, KurotatoRoleInfo.Parser);

		// Token: 0x04005423 RID: 21539
		private readonly RepeatedField<KurotatoRoleInfo> kurotatoRoleInfos_ = new RepeatedField<KurotatoRoleInfo>();

		// Token: 0x04005424 RID: 21540
		public const int UnlockWeaponsFieldNumber = 3;

		// Token: 0x04005425 RID: 21541
		private static readonly FieldCodec<int> _repeated_unlockWeapons_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04005426 RID: 21542
		private readonly RepeatedField<int> unlockWeapons_ = new RepeatedField<int>();

		// Token: 0x04005427 RID: 21543
		public const int UnlockItemsFieldNumber = 4;

		// Token: 0x04005428 RID: 21544
		private static readonly FieldCodec<int> _repeated_unlockItems_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04005429 RID: 21545
		private readonly RepeatedField<int> unlockItems_ = new RepeatedField<int>();

		// Token: 0x0400542A RID: 21546
		public const int ScoreTasksFieldNumber = 5;

		// Token: 0x0400542B RID: 21547
		private static readonly FieldCodec<int> _repeated_scoreTasks_codec = FieldCodec.ForInt32(42U);

		// Token: 0x0400542C RID: 21548
		private readonly RepeatedField<int> scoreTasks_ = new RepeatedField<int>();

		// Token: 0x0400542D RID: 21549
		public const int ResTasksFieldNumber = 6;

		// Token: 0x0400542E RID: 21550
		private static readonly FieldCodec<ConditionTask> _repeated_resTasks_codec = FieldCodec.ForMessage<ConditionTask>(50U, ConditionTask.Parser);

		// Token: 0x0400542F RID: 21551
		private readonly RepeatedField<ConditionTask> resTasks_ = new RepeatedField<ConditionTask>();

		// Token: 0x04005430 RID: 21552
		public const int LimitTasksFieldNumber = 7;

		// Token: 0x04005431 RID: 21553
		private static readonly FieldCodec<ConditionTask> _repeated_limitTasks_codec = FieldCodec.ForMessage<ConditionTask>(58U, ConditionTask.Parser);

		// Token: 0x04005432 RID: 21554
		private readonly RepeatedField<ConditionTask> limitTasks_ = new RepeatedField<ConditionTask>();
	}
}
