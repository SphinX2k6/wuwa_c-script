using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B0D RID: 2829
	[NetMessage(EMessageId.NewbieCourseV2RewardRequest)]
	public sealed class NewbieCourseV2RewardRequest : IMessage<NewbieCourseV2RewardRequest>, IMessage, IEquatable<NewbieCourseV2RewardRequest>, IDeepCloneable<NewbieCourseV2RewardRequest>, IBufferMessage
	{
		// Token: 0x0600F5C0 RID: 62912 RVA: 0x0023D990 File Offset: 0x0023BB90
		[NullableContext(1)]
		public static NewbieCourseV2RewardRequest Create()
		{
			return new NewbieCourseV2RewardRequest();
		}

		// Token: 0x1700320C RID: 12812
		// (get) Token: 0x0600F5C1 RID: 62913 RVA: 0x0023D997 File Offset: 0x0023BB97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700320D RID: 12813
		// (get) Token: 0x0600F5C2 RID: 62914 RVA: 0x0023D99A File Offset: 0x0023BB9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewbieCourseV2RewardRequest.Descriptor;
			}
		}

		// Token: 0x0600F5C3 RID: 62915 RVA: 0x0023D9A1 File Offset: 0x0023BBA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieCourseV2RewardRequest()
		{
		}

		// Token: 0x0600F5C4 RID: 62916 RVA: 0x0023D9B4 File Offset: 0x0023BBB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieCourseV2RewardRequest(NewbieCourseV2RewardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.level_ = other.level_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F5C5 RID: 62917 RVA: 0x0023D9EA File Offset: 0x0023BBEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieCourseV2RewardRequest Clone()
		{
			return new NewbieCourseV2RewardRequest(this);
		}

		// Token: 0x1700320E RID: 12814
		// (get) Token: 0x0600F5C6 RID: 62918 RVA: 0x0023D9F2 File Offset: 0x0023BBF2
		// (set) Token: 0x0600F5C7 RID: 62919 RVA: 0x0023D9FA File Offset: 0x0023BBFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x1700320F RID: 12815
		// (get) Token: 0x0600F5C8 RID: 62920 RVA: 0x0023DA03 File Offset: 0x0023BC03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Level
		{
			get
			{
				return this.level_;
			}
		}

		// Token: 0x0600F5C9 RID: 62921 RVA: 0x0023DA0B File Offset: 0x0023BC0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewbieCourseV2RewardRequest);
		}

		// Token: 0x0600F5CA RID: 62922 RVA: 0x0023DA1C File Offset: 0x0023BC1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewbieCourseV2RewardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.level_.Equals(other.level_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F5CB RID: 62923 RVA: 0x0023DA6C File Offset: 0x0023BC6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.level_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F5CC RID: 62924 RVA: 0x0023DAB9 File Offset: 0x0023BCB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F5CD RID: 62925 RVA: 0x0023DAC6 File Offset: 0x0023BCC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F5CE RID: 62926 RVA: 0x0023DAD0 File Offset: 0x0023BCD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ActivityId);
			}
			this.level_.WriteTo(ref output, NewbieCourseV2RewardRequest._repeated_level_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F5CF RID: 62927 RVA: 0x0023DB20 File Offset: 0x0023BD20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.level_.CalculateSize(NewbieCourseV2RewardRequest._repeated_level_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F5D0 RID: 62928 RVA: 0x0023DB74 File Offset: 0x0023BD74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewbieCourseV2RewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.level_.Add(other.level_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F5D1 RID: 62929 RVA: 0x0023DBC1 File Offset: 0x0023BDC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F5D2 RID: 62930 RVA: 0x0023DBCC File Offset: 0x0023BDCC
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
				if (num != 16U)
				{
					if (num != 56U && num != 58U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.level_.AddEntriesFrom(ref input, NewbieCourseV2RewardRequest._repeated_level_codec);
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040062C6 RID: 25286
		private UnknownFieldSet _unknownFields;

		// Token: 0x040062C7 RID: 25287
		public const int ActivityIdFieldNumber = 2;

		// Token: 0x040062C8 RID: 25288
		private int activityId_;

		// Token: 0x040062C9 RID: 25289
		public const int LevelFieldNumber = 7;

		// Token: 0x040062CA RID: 25290
		private static readonly FieldCodec<int> _repeated_level_codec = FieldCodec.ForInt32(58U);

		// Token: 0x040062CB RID: 25291
		private readonly RepeatedField<int> level_ = new RepeatedField<int>();
	}
}
