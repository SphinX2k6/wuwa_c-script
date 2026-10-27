using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012BF RID: 4799
	public sealed class SurvivorsActivityData : IMessage<SurvivorsActivityData>, IMessage, IEquatable<SurvivorsActivityData>, IDeepCloneable<SurvivorsActivityData>, IBufferMessage
	{
		// Token: 0x06019890 RID: 104592 RVA: 0x003B5FDE File Offset: 0x003B41DE
		[NullableContext(1)]
		public static SurvivorsActivityData Create()
		{
			return new SurvivorsActivityData();
		}

		// Token: 0x1700561D RID: 22045
		// (get) Token: 0x06019891 RID: 104593 RVA: 0x003B5FE5 File Offset: 0x003B41E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700561E RID: 22046
		// (get) Token: 0x06019892 RID: 104594 RVA: 0x003B5FE8 File Offset: 0x003B41E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsActivityData.Descriptor;
			}
		}

		// Token: 0x06019893 RID: 104595 RVA: 0x003B5FF0 File Offset: 0x003B41F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsActivityData()
		{
		}

		// Token: 0x06019894 RID: 104596 RVA: 0x003B6048 File Offset: 0x003B4248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsActivityData(SurvivorsActivityData other) : this()
		{
			this.normalTaskData_ = ((other.normalTaskData_ != null) ? other.normalTaskData_.Clone() : null);
			this.scoreTaskDatas_ = other.scoreTaskDatas_.Clone();
			this.unlockWeaponHandBooks_ = other.unlockWeaponHandBooks_.Clone();
			this.unlockRoleHandBooks_ = other.unlockRoleHandBooks_.Clone();
			this.unlockItemHandBooks_ = other.unlockItemHandBooks_.Clone();
			this.talentSkillDict_ = other.talentSkillDict_.Clone();
			this.survivorsChallengeInfos_ = other.survivorsChallengeInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019895 RID: 104597 RVA: 0x003B60EE File Offset: 0x003B42EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsActivityData Clone()
		{
			return new SurvivorsActivityData(this);
		}

		// Token: 0x1700561F RID: 22047
		// (get) Token: 0x06019896 RID: 104598 RVA: 0x003B60F6 File Offset: 0x003B42F6
		// (set) Token: 0x06019897 RID: 104599 RVA: 0x003B60FE File Offset: 0x003B42FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityTaskData NormalTaskData
		{
			get
			{
				return this.normalTaskData_;
			}
			set
			{
				this.normalTaskData_ = value;
			}
		}

		// Token: 0x17005620 RID: 22048
		// (get) Token: 0x06019898 RID: 104600 RVA: 0x003B6107 File Offset: 0x003B4307
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ScoreTaskDatas
		{
			get
			{
				return this.scoreTaskDatas_;
			}
		}

		// Token: 0x17005621 RID: 22049
		// (get) Token: 0x06019899 RID: 104601 RVA: 0x003B610F File Offset: 0x003B430F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockWeaponHandBooks
		{
			get
			{
				return this.unlockWeaponHandBooks_;
			}
		}

		// Token: 0x17005622 RID: 22050
		// (get) Token: 0x0601989A RID: 104602 RVA: 0x003B6117 File Offset: 0x003B4317
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockRoleHandBooks
		{
			get
			{
				return this.unlockRoleHandBooks_;
			}
		}

		// Token: 0x17005623 RID: 22051
		// (get) Token: 0x0601989B RID: 104603 RVA: 0x003B611F File Offset: 0x003B431F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockItemHandBooks
		{
			get
			{
				return this.unlockItemHandBooks_;
			}
		}

		// Token: 0x17005624 RID: 22052
		// (get) Token: 0x0601989C RID: 104604 RVA: 0x003B6127 File Offset: 0x003B4327
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> TalentSkillDict
		{
			get
			{
				return this.talentSkillDict_;
			}
		}

		// Token: 0x17005625 RID: 22053
		// (get) Token: 0x0601989D RID: 104605 RVA: 0x003B612F File Offset: 0x003B432F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SurvivorsChallengeInfo> SurvivorsChallengeInfos
		{
			get
			{
				return this.survivorsChallengeInfos_;
			}
		}

		// Token: 0x0601989E RID: 104606 RVA: 0x003B6137 File Offset: 0x003B4337
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsActivityData);
		}

		// Token: 0x0601989F RID: 104607 RVA: 0x003B6148 File Offset: 0x003B4348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsActivityData other)
		{
			return other != null && (other == this || (object.Equals(this.NormalTaskData, other.NormalTaskData) && this.scoreTaskDatas_.Equals(other.scoreTaskDatas_) && this.unlockWeaponHandBooks_.Equals(other.unlockWeaponHandBooks_) && this.unlockRoleHandBooks_.Equals(other.unlockRoleHandBooks_) && this.unlockItemHandBooks_.Equals(other.unlockItemHandBooks_) && this.TalentSkillDict.Equals(other.TalentSkillDict) && this.survivorsChallengeInfos_.Equals(other.survivorsChallengeInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060198A0 RID: 104608 RVA: 0x003B6204 File Offset: 0x003B4404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.normalTaskData_ != null)
			{
				num ^= this.NormalTaskData.GetHashCode();
			}
			num ^= this.scoreTaskDatas_.GetHashCode();
			num ^= this.unlockWeaponHandBooks_.GetHashCode();
			num ^= this.unlockRoleHandBooks_.GetHashCode();
			num ^= this.unlockItemHandBooks_.GetHashCode();
			num ^= this.TalentSkillDict.GetHashCode();
			num ^= this.survivorsChallengeInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060198A1 RID: 104609 RVA: 0x003B6294 File Offset: 0x003B4494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060198A2 RID: 104610 RVA: 0x003B62A1 File Offset: 0x003B44A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060198A3 RID: 104611 RVA: 0x003B62AC File Offset: 0x003B44AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.normalTaskData_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.NormalTaskData);
			}
			this.scoreTaskDatas_.WriteTo(ref output, SurvivorsActivityData._repeated_scoreTaskDatas_codec);
			this.unlockWeaponHandBooks_.WriteTo(ref output, SurvivorsActivityData._repeated_unlockWeaponHandBooks_codec);
			this.unlockRoleHandBooks_.WriteTo(ref output, SurvivorsActivityData._repeated_unlockRoleHandBooks_codec);
			this.unlockItemHandBooks_.WriteTo(ref output, SurvivorsActivityData._repeated_unlockItemHandBooks_codec);
			this.talentSkillDict_.WriteTo(ref output, SurvivorsActivityData._map_talentSkillDict_codec);
			this.survivorsChallengeInfos_.WriteTo(ref output, SurvivorsActivityData._repeated_survivorsChallengeInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060198A4 RID: 104612 RVA: 0x003B6350 File Offset: 0x003B4550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.normalTaskData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.NormalTaskData);
			}
			num += this.scoreTaskDatas_.CalculateSize(SurvivorsActivityData._repeated_scoreTaskDatas_codec);
			num += this.unlockWeaponHandBooks_.CalculateSize(SurvivorsActivityData._repeated_unlockWeaponHandBooks_codec);
			num += this.unlockRoleHandBooks_.CalculateSize(SurvivorsActivityData._repeated_unlockRoleHandBooks_codec);
			num += this.unlockItemHandBooks_.CalculateSize(SurvivorsActivityData._repeated_unlockItemHandBooks_codec);
			num += this.talentSkillDict_.CalculateSize(SurvivorsActivityData._map_talentSkillDict_codec);
			num += this.survivorsChallengeInfos_.CalculateSize(SurvivorsActivityData._repeated_survivorsChallengeInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060198A5 RID: 104613 RVA: 0x003B6400 File Offset: 0x003B4600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsActivityData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.normalTaskData_ != null)
			{
				if (this.normalTaskData_ == null)
				{
					this.NormalTaskData = new ActivityTaskData();
				}
				this.NormalTaskData.MergeFrom(other.NormalTaskData);
			}
			this.scoreTaskDatas_.Add(other.scoreTaskDatas_);
			this.unlockWeaponHandBooks_.Add(other.unlockWeaponHandBooks_);
			this.unlockRoleHandBooks_.Add(other.unlockRoleHandBooks_);
			this.unlockItemHandBooks_.Add(other.unlockItemHandBooks_);
			this.talentSkillDict_.MergeFrom(other.talentSkillDict_);
			this.survivorsChallengeInfos_.Add(other.survivorsChallengeInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060198A6 RID: 104614 RVA: 0x003B64BA File Offset: 0x003B46BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060198A7 RID: 104615 RVA: 0x003B64C4 File Offset: 0x003B46C4
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
				if (num <= 26U)
				{
					if (num <= 16U)
					{
						if (num == 10U)
						{
							if (this.normalTaskData_ == null)
							{
								this.NormalTaskData = new ActivityTaskData();
							}
							input.ReadMessage(this.NormalTaskData);
							continue;
						}
						if (num != 16U)
						{
							goto IL_76;
						}
					}
					else if (num != 18U)
					{
						if (num != 24U && num != 26U)
						{
							goto IL_76;
						}
						this.unlockWeaponHandBooks_.AddEntriesFrom(ref input, SurvivorsActivityData._repeated_unlockWeaponHandBooks_codec);
						continue;
					}
					this.scoreTaskDatas_.AddEntriesFrom(ref input, SurvivorsActivityData._repeated_scoreTaskDatas_codec);
					continue;
				}
				if (num <= 40U)
				{
					if (num == 32U || num == 34U)
					{
						this.unlockRoleHandBooks_.AddEntriesFrom(ref input, SurvivorsActivityData._repeated_unlockRoleHandBooks_codec);
						continue;
					}
					if (num != 40U)
					{
						goto IL_76;
					}
				}
				else if (num != 42U)
				{
					if (num == 50U)
					{
						this.talentSkillDict_.AddEntriesFrom(ref input, SurvivorsActivityData._map_talentSkillDict_codec);
						continue;
					}
					if (num != 58U)
					{
						goto IL_76;
					}
					this.survivorsChallengeInfos_.AddEntriesFrom(ref input, SurvivorsActivityData._repeated_survivorsChallengeInfos_codec);
					continue;
				}
				this.unlockItemHandBooks_.AddEntriesFrom(ref input, SurvivorsActivityData._repeated_unlockItemHandBooks_codec);
				continue;
				IL_76:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040095C7 RID: 38343
		private UnknownFieldSet _unknownFields;

		// Token: 0x040095C8 RID: 38344
		public const int NormalTaskDataFieldNumber = 1;

		// Token: 0x040095C9 RID: 38345
		private ActivityTaskData normalTaskData_;

		// Token: 0x040095CA RID: 38346
		public const int ScoreTaskDatasFieldNumber = 2;

		// Token: 0x040095CB RID: 38347
		private static readonly FieldCodec<int> _repeated_scoreTaskDatas_codec = FieldCodec.ForInt32(18U);

		// Token: 0x040095CC RID: 38348
		private readonly RepeatedField<int> scoreTaskDatas_ = new RepeatedField<int>();

		// Token: 0x040095CD RID: 38349
		public const int UnlockWeaponHandBooksFieldNumber = 3;

		// Token: 0x040095CE RID: 38350
		private static readonly FieldCodec<int> _repeated_unlockWeaponHandBooks_codec = FieldCodec.ForInt32(26U);

		// Token: 0x040095CF RID: 38351
		private readonly RepeatedField<int> unlockWeaponHandBooks_ = new RepeatedField<int>();

		// Token: 0x040095D0 RID: 38352
		public const int UnlockRoleHandBooksFieldNumber = 4;

		// Token: 0x040095D1 RID: 38353
		private static readonly FieldCodec<int> _repeated_unlockRoleHandBooks_codec = FieldCodec.ForInt32(34U);

		// Token: 0x040095D2 RID: 38354
		private readonly RepeatedField<int> unlockRoleHandBooks_ = new RepeatedField<int>();

		// Token: 0x040095D3 RID: 38355
		public const int UnlockItemHandBooksFieldNumber = 5;

		// Token: 0x040095D4 RID: 38356
		private static readonly FieldCodec<int> _repeated_unlockItemHandBooks_codec = FieldCodec.ForInt32(42U);

		// Token: 0x040095D5 RID: 38357
		private readonly RepeatedField<int> unlockItemHandBooks_ = new RepeatedField<int>();

		// Token: 0x040095D6 RID: 38358
		public const int TalentSkillDictFieldNumber = 6;

		// Token: 0x040095D7 RID: 38359
		private static readonly MapField<int, int>.Codec _map_talentSkillDict_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 50U);

		// Token: 0x040095D8 RID: 38360
		private readonly MapField<int, int> talentSkillDict_ = new MapField<int, int>();

		// Token: 0x040095D9 RID: 38361
		public const int SurvivorsChallengeInfosFieldNumber = 7;

		// Token: 0x040095DA RID: 38362
		private static readonly FieldCodec<SurvivorsChallengeInfo> _repeated_survivorsChallengeInfos_codec = FieldCodec.ForMessage<SurvivorsChallengeInfo>(58U, SurvivorsChallengeInfo.Parser);

		// Token: 0x040095DB RID: 38363
		private readonly RepeatedField<SurvivorsChallengeInfo> survivorsChallengeInfos_ = new RepeatedField<SurvivorsChallengeInfo>();
	}
}
