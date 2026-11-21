using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AFC RID: 2812
	[NetMessage(EMessageId.NewbieCourseV2RewardRequest)]
	public sealed class NewbieCourseV2RewardRequest : IMessage<NewbieCourseV2RewardRequest>, IMessage, IEquatable<NewbieCourseV2RewardRequest>, IDeepCloneable<NewbieCourseV2RewardRequest>, IBufferMessage
	{
		// Token: 0x0600F4A6 RID: 62630 RVA: 0x0023B784 File Offset: 0x00239984
		[NullableContext(1)]
		public static NewbieCourseV2RewardRequest Create()
		{
			return new NewbieCourseV2RewardRequest();
		}

		// Token: 0x170031CE RID: 12750
		// (get) Token: 0x0600F4A7 RID: 62631 RVA: 0x0023B78B File Offset: 0x0023998B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170031CF RID: 12751
		// (get) Token: 0x0600F4A8 RID: 62632 RVA: 0x0023B78E File Offset: 0x0023998E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewbieCourseV2RewardRequest.Descriptor;
			}
		}

		// Token: 0x0600F4A9 RID: 62633 RVA: 0x0023B795 File Offset: 0x00239995
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieCourseV2RewardRequest()
		{
		}

		// Token: 0x0600F4AA RID: 62634 RVA: 0x0023B7A8 File Offset: 0x002399A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieCourseV2RewardRequest(NewbieCourseV2RewardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.level_ = other.level_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F4AB RID: 62635 RVA: 0x0023B7DE File Offset: 0x002399DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieCourseV2RewardRequest Clone()
		{
			return new NewbieCourseV2RewardRequest(this);
		}

		// Token: 0x170031D0 RID: 12752
		// (get) Token: 0x0600F4AC RID: 62636 RVA: 0x0023B7E6 File Offset: 0x002399E6
		// (set) Token: 0x0600F4AD RID: 62637 RVA: 0x0023B7EE File Offset: 0x002399EE
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

		// Token: 0x170031D1 RID: 12753
		// (get) Token: 0x0600F4AE RID: 62638 RVA: 0x0023B7F7 File Offset: 0x002399F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Level
		{
			get
			{
				return this.level_;
			}
		}

		// Token: 0x0600F4AF RID: 62639 RVA: 0x0023B7FF File Offset: 0x002399FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewbieCourseV2RewardRequest);
		}

		// Token: 0x0600F4B0 RID: 62640 RVA: 0x0023B810 File Offset: 0x00239A10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewbieCourseV2RewardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.level_.Equals(other.level_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F4B1 RID: 62641 RVA: 0x0023B860 File Offset: 0x00239A60
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

		// Token: 0x0600F4B2 RID: 62642 RVA: 0x0023B8AD File Offset: 0x00239AAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F4B3 RID: 62643 RVA: 0x0023B8BA File Offset: 0x00239ABA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F4B4 RID: 62644 RVA: 0x0023B8C4 File Offset: 0x00239AC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.level_.WriteTo(ref output, NewbieCourseV2RewardRequest._repeated_level_codec);
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F4B5 RID: 62645 RVA: 0x0023B914 File Offset: 0x00239B14
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

		// Token: 0x0600F4B6 RID: 62646 RVA: 0x0023B968 File Offset: 0x00239B68
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

		// Token: 0x0600F4B7 RID: 62647 RVA: 0x0023B9B5 File Offset: 0x00239BB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F4B8 RID: 62648 RVA: 0x0023B9C0 File Offset: 0x00239BC0
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
				if (num != 8U && num != 10U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ActivityId = input.ReadInt32();
					}
				}
				else
				{
					this.level_.AddEntriesFrom(ref input, NewbieCourseV2RewardRequest._repeated_level_codec);
				}
			}
		}

		// Token: 0x040062CF RID: 25295
		private UnknownFieldSet _unknownFields;

		// Token: 0x040062D0 RID: 25296
		public const int ActivityIdFieldNumber = 11;

		// Token: 0x040062D1 RID: 25297
		private int activityId_;

		// Token: 0x040062D2 RID: 25298
		public const int LevelFieldNumber = 1;

		// Token: 0x040062D3 RID: 25299
		private static readonly FieldCodec<int> _repeated_level_codec = FieldCodec.ForInt32(10U);

		// Token: 0x040062D4 RID: 25300
		private readonly RepeatedField<int> level_ = new RepeatedField<int>();
	}
}
