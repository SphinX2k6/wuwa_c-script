using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D2F RID: 3375
	public sealed class PinballActivityData : IMessage<PinballActivityData>, IMessage, IEquatable<PinballActivityData>, IDeepCloneable<PinballActivityData>, IBufferMessage
	{
		// Token: 0x060123C7 RID: 74695 RVA: 0x002A9CAD File Offset: 0x002A7EAD
		[NullableContext(1)]
		public static PinballActivityData Create()
		{
			return new PinballActivityData();
		}

		// Token: 0x17003C69 RID: 15465
		// (get) Token: 0x060123C8 RID: 74696 RVA: 0x002A9CB4 File Offset: 0x002A7EB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003C6A RID: 15466
		// (get) Token: 0x060123C9 RID: 74697 RVA: 0x002A9CB7 File Offset: 0x002A7EB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballActivityData.Descriptor;
			}
		}

		// Token: 0x060123CA RID: 74698 RVA: 0x002A9CBE File Offset: 0x002A7EBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballActivityData()
		{
		}

		// Token: 0x060123CB RID: 74699 RVA: 0x002A9CF4 File Offset: 0x002A7EF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballActivityData(PinballActivityData other) : this()
		{
			this.chapters_ = other.chapters_.Clone();
			this.levels_ = other.levels_.Clone();
			this.weapons_ = ((other.weapons_ != null) ? other.weapons_.Clone() : null);
			this.roles_ = ((other.roles_ != null) ? other.roles_.Clone() : null);
			this.conditionTasks_ = other.conditionTasks_.Clone();
			this.groupFormations_ = other.groupFormations_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060123CC RID: 74700 RVA: 0x002A9D94 File Offset: 0x002A7F94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballActivityData Clone()
		{
			return new PinballActivityData(this);
		}

		// Token: 0x17003C6B RID: 15467
		// (get) Token: 0x060123CD RID: 74701 RVA: 0x002A9D9C File Offset: 0x002A7F9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PinballChapterData> Chapters
		{
			get
			{
				return this.chapters_;
			}
		}

		// Token: 0x17003C6C RID: 15468
		// (get) Token: 0x060123CE RID: 74702 RVA: 0x002A9DA4 File Offset: 0x002A7FA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PinballLevelData> Levels
		{
			get
			{
				return this.levels_;
			}
		}

		// Token: 0x17003C6D RID: 15469
		// (get) Token: 0x060123CF RID: 74703 RVA: 0x002A9DAC File Offset: 0x002A7FAC
		// (set) Token: 0x060123D0 RID: 74704 RVA: 0x002A9DB4 File Offset: 0x002A7FB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballWeapons Weapons
		{
			get
			{
				return this.weapons_;
			}
			set
			{
				this.weapons_ = value;
			}
		}

		// Token: 0x17003C6E RID: 15470
		// (get) Token: 0x060123D1 RID: 74705 RVA: 0x002A9DBD File Offset: 0x002A7FBD
		// (set) Token: 0x060123D2 RID: 74706 RVA: 0x002A9DC5 File Offset: 0x002A7FC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballRoles Roles
		{
			get
			{
				return this.roles_;
			}
			set
			{
				this.roles_ = value;
			}
		}

		// Token: 0x17003C6F RID: 15471
		// (get) Token: 0x060123D3 RID: 74707 RVA: 0x002A9DCE File Offset: 0x002A7FCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTask> ConditionTasks
		{
			get
			{
				return this.conditionTasks_;
			}
		}

		// Token: 0x17003C70 RID: 15472
		// (get) Token: 0x060123D4 RID: 74708 RVA: 0x002A9DD6 File Offset: 0x002A7FD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GroupFormation> GroupFormations
		{
			get
			{
				return this.groupFormations_;
			}
		}

		// Token: 0x060123D5 RID: 74709 RVA: 0x002A9DDE File Offset: 0x002A7FDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballActivityData);
		}

		// Token: 0x060123D6 RID: 74710 RVA: 0x002A9DEC File Offset: 0x002A7FEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballActivityData other)
		{
			return other != null && (other == this || (this.chapters_.Equals(other.chapters_) && this.levels_.Equals(other.levels_) && object.Equals(this.Weapons, other.Weapons) && object.Equals(this.Roles, other.Roles) && this.conditionTasks_.Equals(other.conditionTasks_) && this.groupFormations_.Equals(other.groupFormations_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060123D7 RID: 74711 RVA: 0x002A9E94 File Offset: 0x002A8094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.chapters_.GetHashCode();
			num ^= this.levels_.GetHashCode();
			if (this.weapons_ != null)
			{
				num ^= this.Weapons.GetHashCode();
			}
			if (this.roles_ != null)
			{
				num ^= this.Roles.GetHashCode();
			}
			num ^= this.conditionTasks_.GetHashCode();
			num ^= this.groupFormations_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060123D8 RID: 74712 RVA: 0x002A9F1E File Offset: 0x002A811E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060123D9 RID: 74713 RVA: 0x002A9F2B File Offset: 0x002A812B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060123DA RID: 74714 RVA: 0x002A9F34 File Offset: 0x002A8134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.chapters_.WriteTo(ref output, PinballActivityData._repeated_chapters_codec);
			this.levels_.WriteTo(ref output, PinballActivityData._repeated_levels_codec);
			if (this.weapons_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Weapons);
			}
			if (this.roles_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Roles);
			}
			this.conditionTasks_.WriteTo(ref output, PinballActivityData._repeated_conditionTasks_codec);
			this.groupFormations_.WriteTo(ref output, PinballActivityData._repeated_groupFormations_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060123DB RID: 74715 RVA: 0x002A9FD4 File Offset: 0x002A81D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.chapters_.CalculateSize(PinballActivityData._repeated_chapters_codec);
			num += this.levels_.CalculateSize(PinballActivityData._repeated_levels_codec);
			if (this.weapons_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Weapons);
			}
			if (this.roles_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Roles);
			}
			num += this.conditionTasks_.CalculateSize(PinballActivityData._repeated_conditionTasks_codec);
			num += this.groupFormations_.CalculateSize(PinballActivityData._repeated_groupFormations_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060123DC RID: 74716 RVA: 0x002AA078 File Offset: 0x002A8278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PinballActivityData other)
		{
			if (other == null)
			{
				return;
			}
			this.chapters_.Add(other.chapters_);
			this.levels_.Add(other.levels_);
			if (other.weapons_ != null)
			{
				if (this.weapons_ == null)
				{
					this.Weapons = new PinballWeapons();
				}
				this.Weapons.MergeFrom(other.Weapons);
			}
			if (other.roles_ != null)
			{
				if (this.roles_ == null)
				{
					this.Roles = new PinballRoles();
				}
				this.Roles.MergeFrom(other.Roles);
			}
			this.conditionTasks_.Add(other.conditionTasks_);
			this.groupFormations_.Add(other.groupFormations_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060123DD RID: 74717 RVA: 0x002AA13C File Offset: 0x002A833C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060123DE RID: 74718 RVA: 0x002AA148 File Offset: 0x002A8348
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
					if (num == 10U)
					{
						this.chapters_.AddEntriesFrom(ref input, PinballActivityData._repeated_chapters_codec);
						continue;
					}
					if (num == 18U)
					{
						this.levels_.AddEntriesFrom(ref input, PinballActivityData._repeated_levels_codec);
						continue;
					}
					if (num == 26U)
					{
						if (this.weapons_ == null)
						{
							this.Weapons = new PinballWeapons();
						}
						input.ReadMessage(this.Weapons);
						continue;
					}
				}
				else
				{
					if (num == 34U)
					{
						if (this.roles_ == null)
						{
							this.Roles = new PinballRoles();
						}
						input.ReadMessage(this.Roles);
						continue;
					}
					if (num == 42U)
					{
						this.conditionTasks_.AddEntriesFrom(ref input, PinballActivityData._repeated_conditionTasks_codec);
						continue;
					}
					if (num == 50U)
					{
						this.groupFormations_.AddEntriesFrom(ref input, PinballActivityData._repeated_groupFormations_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007226 RID: 29222
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007227 RID: 29223
		public const int ChaptersFieldNumber = 1;

		// Token: 0x04007228 RID: 29224
		private static readonly FieldCodec<PinballChapterData> _repeated_chapters_codec = FieldCodec.ForMessage<PinballChapterData>(10U, PinballChapterData.Parser);

		// Token: 0x04007229 RID: 29225
		private readonly RepeatedField<PinballChapterData> chapters_ = new RepeatedField<PinballChapterData>();

		// Token: 0x0400722A RID: 29226
		public const int LevelsFieldNumber = 2;

		// Token: 0x0400722B RID: 29227
		private static readonly FieldCodec<PinballLevelData> _repeated_levels_codec = FieldCodec.ForMessage<PinballLevelData>(18U, PinballLevelData.Parser);

		// Token: 0x0400722C RID: 29228
		private readonly RepeatedField<PinballLevelData> levels_ = new RepeatedField<PinballLevelData>();

		// Token: 0x0400722D RID: 29229
		public const int WeaponsFieldNumber = 3;

		// Token: 0x0400722E RID: 29230
		private PinballWeapons weapons_;

		// Token: 0x0400722F RID: 29231
		public const int RolesFieldNumber = 4;

		// Token: 0x04007230 RID: 29232
		private PinballRoles roles_;

		// Token: 0x04007231 RID: 29233
		public const int ConditionTasksFieldNumber = 5;

		// Token: 0x04007232 RID: 29234
		private static readonly FieldCodec<ConditionTask> _repeated_conditionTasks_codec = FieldCodec.ForMessage<ConditionTask>(42U, ConditionTask.Parser);

		// Token: 0x04007233 RID: 29235
		private readonly RepeatedField<ConditionTask> conditionTasks_ = new RepeatedField<ConditionTask>();

		// Token: 0x04007234 RID: 29236
		public const int GroupFormationsFieldNumber = 6;

		// Token: 0x04007235 RID: 29237
		private static readonly FieldCodec<GroupFormation> _repeated_groupFormations_codec = FieldCodec.ForMessage<GroupFormation>(50U, GroupFormation.Parser);

		// Token: 0x04007236 RID: 29238
		private readonly RepeatedField<GroupFormation> groupFormations_ = new RepeatedField<GroupFormation>();
	}
}
