using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D3F RID: 3391
	public sealed class PinballActivityData : IMessage<PinballActivityData>, IMessage, IEquatable<PinballActivityData>, IDeepCloneable<PinballActivityData>, IBufferMessage
	{
		// Token: 0x060124C3 RID: 74947 RVA: 0x002AB8D1 File Offset: 0x002A9AD1
		[NullableContext(1)]
		public static PinballActivityData Create()
		{
			return new PinballActivityData();
		}

		// Token: 0x17003C9E RID: 15518
		// (get) Token: 0x060124C4 RID: 74948 RVA: 0x002AB8D8 File Offset: 0x002A9AD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003C9F RID: 15519
		// (get) Token: 0x060124C5 RID: 74949 RVA: 0x002AB8DB File Offset: 0x002A9ADB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballActivityData.Descriptor;
			}
		}

		// Token: 0x060124C6 RID: 74950 RVA: 0x002AB8E2 File Offset: 0x002A9AE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballActivityData()
		{
		}

		// Token: 0x060124C7 RID: 74951 RVA: 0x002AB918 File Offset: 0x002A9B18
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

		// Token: 0x060124C8 RID: 74952 RVA: 0x002AB9B8 File Offset: 0x002A9BB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballActivityData Clone()
		{
			return new PinballActivityData(this);
		}

		// Token: 0x17003CA0 RID: 15520
		// (get) Token: 0x060124C9 RID: 74953 RVA: 0x002AB9C0 File Offset: 0x002A9BC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PinballChapterData> Chapters
		{
			get
			{
				return this.chapters_;
			}
		}

		// Token: 0x17003CA1 RID: 15521
		// (get) Token: 0x060124CA RID: 74954 RVA: 0x002AB9C8 File Offset: 0x002A9BC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PinballLevelData> Levels
		{
			get
			{
				return this.levels_;
			}
		}

		// Token: 0x17003CA2 RID: 15522
		// (get) Token: 0x060124CB RID: 74955 RVA: 0x002AB9D0 File Offset: 0x002A9BD0
		// (set) Token: 0x060124CC RID: 74956 RVA: 0x002AB9D8 File Offset: 0x002A9BD8
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

		// Token: 0x17003CA3 RID: 15523
		// (get) Token: 0x060124CD RID: 74957 RVA: 0x002AB9E1 File Offset: 0x002A9BE1
		// (set) Token: 0x060124CE RID: 74958 RVA: 0x002AB9E9 File Offset: 0x002A9BE9
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

		// Token: 0x17003CA4 RID: 15524
		// (get) Token: 0x060124CF RID: 74959 RVA: 0x002AB9F2 File Offset: 0x002A9BF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTask> ConditionTasks
		{
			get
			{
				return this.conditionTasks_;
			}
		}

		// Token: 0x17003CA5 RID: 15525
		// (get) Token: 0x060124D0 RID: 74960 RVA: 0x002AB9FA File Offset: 0x002A9BFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GroupFormation> GroupFormations
		{
			get
			{
				return this.groupFormations_;
			}
		}

		// Token: 0x060124D1 RID: 74961 RVA: 0x002ABA02 File Offset: 0x002A9C02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballActivityData);
		}

		// Token: 0x060124D2 RID: 74962 RVA: 0x002ABA10 File Offset: 0x002A9C10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballActivityData other)
		{
			return other != null && (other == this || (this.chapters_.Equals(other.chapters_) && this.levels_.Equals(other.levels_) && object.Equals(this.Weapons, other.Weapons) && object.Equals(this.Roles, other.Roles) && this.conditionTasks_.Equals(other.conditionTasks_) && this.groupFormations_.Equals(other.groupFormations_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060124D3 RID: 74963 RVA: 0x002ABAB8 File Offset: 0x002A9CB8
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

		// Token: 0x060124D4 RID: 74964 RVA: 0x002ABB42 File Offset: 0x002A9D42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060124D5 RID: 74965 RVA: 0x002ABB4F File Offset: 0x002A9D4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060124D6 RID: 74966 RVA: 0x002ABB58 File Offset: 0x002A9D58
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

		// Token: 0x060124D7 RID: 74967 RVA: 0x002ABBF8 File Offset: 0x002A9DF8
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

		// Token: 0x060124D8 RID: 74968 RVA: 0x002ABC9C File Offset: 0x002A9E9C
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

		// Token: 0x060124D9 RID: 74969 RVA: 0x002ABD60 File Offset: 0x002A9F60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060124DA RID: 74970 RVA: 0x002ABD6C File Offset: 0x002A9F6C
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

		// Token: 0x0400720E RID: 29198
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400720F RID: 29199
		public const int ChaptersFieldNumber = 1;

		// Token: 0x04007210 RID: 29200
		private static readonly FieldCodec<PinballChapterData> _repeated_chapters_codec = FieldCodec.ForMessage<PinballChapterData>(10U, PinballChapterData.Parser);

		// Token: 0x04007211 RID: 29201
		private readonly RepeatedField<PinballChapterData> chapters_ = new RepeatedField<PinballChapterData>();

		// Token: 0x04007212 RID: 29202
		public const int LevelsFieldNumber = 2;

		// Token: 0x04007213 RID: 29203
		private static readonly FieldCodec<PinballLevelData> _repeated_levels_codec = FieldCodec.ForMessage<PinballLevelData>(18U, PinballLevelData.Parser);

		// Token: 0x04007214 RID: 29204
		private readonly RepeatedField<PinballLevelData> levels_ = new RepeatedField<PinballLevelData>();

		// Token: 0x04007215 RID: 29205
		public const int WeaponsFieldNumber = 3;

		// Token: 0x04007216 RID: 29206
		private PinballWeapons weapons_;

		// Token: 0x04007217 RID: 29207
		public const int RolesFieldNumber = 4;

		// Token: 0x04007218 RID: 29208
		private PinballRoles roles_;

		// Token: 0x04007219 RID: 29209
		public const int ConditionTasksFieldNumber = 5;

		// Token: 0x0400721A RID: 29210
		private static readonly FieldCodec<ConditionTask> _repeated_conditionTasks_codec = FieldCodec.ForMessage<ConditionTask>(42U, ConditionTask.Parser);

		// Token: 0x0400721B RID: 29211
		private readonly RepeatedField<ConditionTask> conditionTasks_ = new RepeatedField<ConditionTask>();

		// Token: 0x0400721C RID: 29212
		public const int GroupFormationsFieldNumber = 6;

		// Token: 0x0400721D RID: 29213
		private static readonly FieldCodec<GroupFormation> _repeated_groupFormations_codec = FieldCodec.ForMessage<GroupFormation>(50U, GroupFormation.Parser);

		// Token: 0x0400721E RID: 29214
		private readonly RepeatedField<GroupFormation> groupFormations_ = new RepeatedField<GroupFormation>();
	}
}
