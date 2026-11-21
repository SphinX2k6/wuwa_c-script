using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AF1 RID: 2801
	public sealed class NewbieCarnivalData : IMessage<NewbieCarnivalData>, IMessage, IEquatable<NewbieCarnivalData>, IDeepCloneable<NewbieCarnivalData>, IBufferMessage
	{
		// Token: 0x0600F3D4 RID: 62420 RVA: 0x00239D49 File Offset: 0x00237F49
		[NullableContext(1)]
		public static NewbieCarnivalData Create()
		{
			return new NewbieCarnivalData();
		}

		// Token: 0x170031A6 RID: 12710
		// (get) Token: 0x0600F3D5 RID: 62421 RVA: 0x00239D50 File Offset: 0x00237F50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170031A7 RID: 12711
		// (get) Token: 0x0600F3D6 RID: 62422 RVA: 0x00239D53 File Offset: 0x00237F53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewbieCarnivalData.Descriptor;
			}
		}

		// Token: 0x0600F3D7 RID: 62423 RVA: 0x00239D5A File Offset: 0x00237F5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieCarnivalData()
		{
		}

		// Token: 0x0600F3D8 RID: 62424 RVA: 0x00239D78 File Offset: 0x00237F78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieCarnivalData(NewbieCarnivalData other) : this()
		{
			this.roleId_ = other.roleId_;
			this.activityTaskData_ = ((other.activityTaskData_ != null) ? other.activityTaskData_.Clone() : null);
			this.jumpTaskIds_ = other.jumpTaskIds_.Clone();
			this.jumpTaskCondInfos_ = other.jumpTaskCondInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F3D9 RID: 62425 RVA: 0x00239DE6 File Offset: 0x00237FE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieCarnivalData Clone()
		{
			return new NewbieCarnivalData(this);
		}

		// Token: 0x170031A8 RID: 12712
		// (get) Token: 0x0600F3DA RID: 62426 RVA: 0x00239DEE File Offset: 0x00237FEE
		// (set) Token: 0x0600F3DB RID: 62427 RVA: 0x00239DF6 File Offset: 0x00237FF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleId
		{
			get
			{
				return this.roleId_;
			}
			set
			{
				this.roleId_ = value;
			}
		}

		// Token: 0x170031A9 RID: 12713
		// (get) Token: 0x0600F3DC RID: 62428 RVA: 0x00239DFF File Offset: 0x00237FFF
		// (set) Token: 0x0600F3DD RID: 62429 RVA: 0x00239E07 File Offset: 0x00238007
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityTaskData ActivityTaskData
		{
			get
			{
				return this.activityTaskData_;
			}
			set
			{
				this.activityTaskData_ = value;
			}
		}

		// Token: 0x170031AA RID: 12714
		// (get) Token: 0x0600F3DE RID: 62430 RVA: 0x00239E10 File Offset: 0x00238010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> JumpTaskIds
		{
			get
			{
				return this.jumpTaskIds_;
			}
		}

		// Token: 0x170031AB RID: 12715
		// (get) Token: 0x0600F3DF RID: 62431 RVA: 0x00239E18 File Offset: 0x00238018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<JumpTaskCondInfo> JumpTaskCondInfos
		{
			get
			{
				return this.jumpTaskCondInfos_;
			}
		}

		// Token: 0x0600F3E0 RID: 62432 RVA: 0x00239E20 File Offset: 0x00238020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewbieCarnivalData);
		}

		// Token: 0x0600F3E1 RID: 62433 RVA: 0x00239E30 File Offset: 0x00238030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewbieCarnivalData other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && object.Equals(this.ActivityTaskData, other.ActivityTaskData) && this.jumpTaskIds_.Equals(other.jumpTaskIds_) && this.jumpTaskCondInfos_.Equals(other.jumpTaskCondInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F3E2 RID: 62434 RVA: 0x00239EA8 File Offset: 0x002380A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.activityTaskData_ != null)
			{
				num ^= this.ActivityTaskData.GetHashCode();
			}
			num ^= this.jumpTaskIds_.GetHashCode();
			num ^= this.jumpTaskCondInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F3E3 RID: 62435 RVA: 0x00239F19 File Offset: 0x00238119
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F3E4 RID: 62436 RVA: 0x00239F26 File Offset: 0x00238126
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F3E5 RID: 62437 RVA: 0x00239F30 File Offset: 0x00238130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoleId);
			}
			if (this.activityTaskData_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.ActivityTaskData);
			}
			this.jumpTaskIds_.WriteTo(ref output, NewbieCarnivalData._repeated_jumpTaskIds_codec);
			this.jumpTaskCondInfos_.WriteTo(ref output, NewbieCarnivalData._repeated_jumpTaskCondInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F3E6 RID: 62438 RVA: 0x00239FAC File Offset: 0x002381AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.activityTaskData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ActivityTaskData);
			}
			num += this.jumpTaskIds_.CalculateSize(NewbieCarnivalData._repeated_jumpTaskIds_codec);
			num += this.jumpTaskCondInfos_.CalculateSize(NewbieCarnivalData._repeated_jumpTaskCondInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F3E7 RID: 62439 RVA: 0x0023A028 File Offset: 0x00238228
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewbieCarnivalData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.activityTaskData_ != null)
			{
				if (this.activityTaskData_ == null)
				{
					this.ActivityTaskData = new ActivityTaskData();
				}
				this.ActivityTaskData.MergeFrom(other.ActivityTaskData);
			}
			this.jumpTaskIds_.Add(other.jumpTaskIds_);
			this.jumpTaskCondInfos_.Add(other.jumpTaskCondInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F3E8 RID: 62440 RVA: 0x0023A0B2 File Offset: 0x002382B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F3E9 RID: 62441 RVA: 0x0023A0BC File Offset: 0x002382BC
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
						this.RoleId = input.ReadInt32();
						continue;
					}
					if (num == 18U)
					{
						if (this.activityTaskData_ == null)
						{
							this.ActivityTaskData = new ActivityTaskData();
						}
						input.ReadMessage(this.ActivityTaskData);
						continue;
					}
				}
				else
				{
					if (num == 24U || num == 26U)
					{
						this.jumpTaskIds_.AddEntriesFrom(ref input, NewbieCarnivalData._repeated_jumpTaskIds_codec);
						continue;
					}
					if (num == 34U)
					{
						this.jumpTaskCondInfos_.AddEntriesFrom(ref input, NewbieCarnivalData._repeated_jumpTaskCondInfos_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006298 RID: 25240
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006299 RID: 25241
		public const int RoleIdFieldNumber = 1;

		// Token: 0x0400629A RID: 25242
		private int roleId_;

		// Token: 0x0400629B RID: 25243
		public const int ActivityTaskDataFieldNumber = 2;

		// Token: 0x0400629C RID: 25244
		private ActivityTaskData activityTaskData_;

		// Token: 0x0400629D RID: 25245
		public const int JumpTaskIdsFieldNumber = 3;

		// Token: 0x0400629E RID: 25246
		private static readonly FieldCodec<int> _repeated_jumpTaskIds_codec = FieldCodec.ForInt32(26U);

		// Token: 0x0400629F RID: 25247
		private readonly RepeatedField<int> jumpTaskIds_ = new RepeatedField<int>();

		// Token: 0x040062A0 RID: 25248
		public const int JumpTaskCondInfosFieldNumber = 4;

		// Token: 0x040062A1 RID: 25249
		private static readonly FieldCodec<JumpTaskCondInfo> _repeated_jumpTaskCondInfos_codec = FieldCodec.ForMessage<JumpTaskCondInfo>(34U, JumpTaskCondInfo.Parser);

		// Token: 0x040062A2 RID: 25250
		private readonly RepeatedField<JumpTaskCondInfo> jumpTaskCondInfos_ = new RepeatedField<JumpTaskCondInfo>();
	}
}
