using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000874 RID: 2164
	public sealed class KurotatoActivityData : IMessage<KurotatoActivityData>, IMessage, IEquatable<KurotatoActivityData>, IDeepCloneable<KurotatoActivityData>, IBufferMessage
	{
		// Token: 0x0600C105 RID: 49413 RVA: 0x001CAE75 File Offset: 0x001C9075
		[NullableContext(1)]
		public static KurotatoActivityData Create()
		{
			return new KurotatoActivityData();
		}

		// Token: 0x17002701 RID: 9985
		// (get) Token: 0x0600C106 RID: 49414 RVA: 0x001CAE7C File Offset: 0x001C907C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002702 RID: 9986
		// (get) Token: 0x0600C107 RID: 49415 RVA: 0x001CAE7F File Offset: 0x001C907F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoActivityData.Descriptor;
			}
		}

		// Token: 0x0600C108 RID: 49416 RVA: 0x001CAE88 File Offset: 0x001C9088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoActivityData()
		{
		}

		// Token: 0x0600C109 RID: 49417 RVA: 0x001CAEE8 File Offset: 0x001C90E8
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

		// Token: 0x0600C10A RID: 49418 RVA: 0x001CAF83 File Offset: 0x001C9183
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoActivityData Clone()
		{
			return new KurotatoActivityData(this);
		}

		// Token: 0x17002703 RID: 9987
		// (get) Token: 0x0600C10B RID: 49419 RVA: 0x001CAF8B File Offset: 0x001C918B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<KurotatoLevelInfo> KurotatoLevelInfos
		{
			get
			{
				return this.kurotatoLevelInfos_;
			}
		}

		// Token: 0x17002704 RID: 9988
		// (get) Token: 0x0600C10C RID: 49420 RVA: 0x001CAF93 File Offset: 0x001C9193
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<KurotatoRoleInfo> KurotatoRoleInfos
		{
			get
			{
				return this.kurotatoRoleInfos_;
			}
		}

		// Token: 0x17002705 RID: 9989
		// (get) Token: 0x0600C10D RID: 49421 RVA: 0x001CAF9B File Offset: 0x001C919B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockWeapons
		{
			get
			{
				return this.unlockWeapons_;
			}
		}

		// Token: 0x17002706 RID: 9990
		// (get) Token: 0x0600C10E RID: 49422 RVA: 0x001CAFA3 File Offset: 0x001C91A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockItems
		{
			get
			{
				return this.unlockItems_;
			}
		}

		// Token: 0x17002707 RID: 9991
		// (get) Token: 0x0600C10F RID: 49423 RVA: 0x001CAFAB File Offset: 0x001C91AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ScoreTasks
		{
			get
			{
				return this.scoreTasks_;
			}
		}

		// Token: 0x17002708 RID: 9992
		// (get) Token: 0x0600C110 RID: 49424 RVA: 0x001CAFB3 File Offset: 0x001C91B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTask> ResTasks
		{
			get
			{
				return this.resTasks_;
			}
		}

		// Token: 0x17002709 RID: 9993
		// (get) Token: 0x0600C111 RID: 49425 RVA: 0x001CAFBB File Offset: 0x001C91BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTask> LimitTasks
		{
			get
			{
				return this.limitTasks_;
			}
		}

		// Token: 0x0600C112 RID: 49426 RVA: 0x001CAFC3 File Offset: 0x001C91C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoActivityData);
		}

		// Token: 0x0600C113 RID: 49427 RVA: 0x001CAFD4 File Offset: 0x001C91D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoActivityData other)
		{
			return other != null && (other == this || (this.kurotatoLevelInfos_.Equals(other.kurotatoLevelInfos_) && this.kurotatoRoleInfos_.Equals(other.kurotatoRoleInfos_) && this.unlockWeapons_.Equals(other.unlockWeapons_) && this.unlockItems_.Equals(other.unlockItems_) && this.scoreTasks_.Equals(other.scoreTasks_) && this.resTasks_.Equals(other.resTasks_) && this.limitTasks_.Equals(other.limitTasks_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C114 RID: 49428 RVA: 0x001CB090 File Offset: 0x001C9290
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

		// Token: 0x0600C115 RID: 49429 RVA: 0x001CB118 File Offset: 0x001C9318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C116 RID: 49430 RVA: 0x001CB125 File Offset: 0x001C9325
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C117 RID: 49431 RVA: 0x001CB130 File Offset: 0x001C9330
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

		// Token: 0x0600C118 RID: 49432 RVA: 0x001CB1C8 File Offset: 0x001C93C8
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

		// Token: 0x0600C119 RID: 49433 RVA: 0x001CB274 File Offset: 0x001C9474
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

		// Token: 0x0600C11A RID: 49434 RVA: 0x001CB313 File Offset: 0x001C9513
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C11B RID: 49435 RVA: 0x001CB31C File Offset: 0x001C951C
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

		// Token: 0x04005424 RID: 21540
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005425 RID: 21541
		public const int KurotatoLevelInfosFieldNumber = 1;

		// Token: 0x04005426 RID: 21542
		private static readonly FieldCodec<KurotatoLevelInfo> _repeated_kurotatoLevelInfos_codec = FieldCodec.ForMessage<KurotatoLevelInfo>(10U, KurotatoLevelInfo.Parser);

		// Token: 0x04005427 RID: 21543
		private readonly RepeatedField<KurotatoLevelInfo> kurotatoLevelInfos_ = new RepeatedField<KurotatoLevelInfo>();

		// Token: 0x04005428 RID: 21544
		public const int KurotatoRoleInfosFieldNumber = 2;

		// Token: 0x04005429 RID: 21545
		private static readonly FieldCodec<KurotatoRoleInfo> _repeated_kurotatoRoleInfos_codec = FieldCodec.ForMessage<KurotatoRoleInfo>(18U, KurotatoRoleInfo.Parser);

		// Token: 0x0400542A RID: 21546
		private readonly RepeatedField<KurotatoRoleInfo> kurotatoRoleInfos_ = new RepeatedField<KurotatoRoleInfo>();

		// Token: 0x0400542B RID: 21547
		public const int UnlockWeaponsFieldNumber = 3;

		// Token: 0x0400542C RID: 21548
		private static readonly FieldCodec<int> _repeated_unlockWeapons_codec = FieldCodec.ForInt32(26U);

		// Token: 0x0400542D RID: 21549
		private readonly RepeatedField<int> unlockWeapons_ = new RepeatedField<int>();

		// Token: 0x0400542E RID: 21550
		public const int UnlockItemsFieldNumber = 4;

		// Token: 0x0400542F RID: 21551
		private static readonly FieldCodec<int> _repeated_unlockItems_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04005430 RID: 21552
		private readonly RepeatedField<int> unlockItems_ = new RepeatedField<int>();

		// Token: 0x04005431 RID: 21553
		public const int ScoreTasksFieldNumber = 5;

		// Token: 0x04005432 RID: 21554
		private static readonly FieldCodec<int> _repeated_scoreTasks_codec = FieldCodec.ForInt32(42U);

		// Token: 0x04005433 RID: 21555
		private readonly RepeatedField<int> scoreTasks_ = new RepeatedField<int>();

		// Token: 0x04005434 RID: 21556
		public const int ResTasksFieldNumber = 6;

		// Token: 0x04005435 RID: 21557
		private static readonly FieldCodec<ConditionTask> _repeated_resTasks_codec = FieldCodec.ForMessage<ConditionTask>(50U, ConditionTask.Parser);

		// Token: 0x04005436 RID: 21558
		private readonly RepeatedField<ConditionTask> resTasks_ = new RepeatedField<ConditionTask>();

		// Token: 0x04005437 RID: 21559
		public const int LimitTasksFieldNumber = 7;

		// Token: 0x04005438 RID: 21560
		private static readonly FieldCodec<ConditionTask> _repeated_limitTasks_codec = FieldCodec.ForMessage<ConditionTask>(58U, ConditionTask.Parser);

		// Token: 0x04005439 RID: 21561
		private readonly RepeatedField<ConditionTask> limitTasks_ = new RepeatedField<ConditionTask>();
	}
}
