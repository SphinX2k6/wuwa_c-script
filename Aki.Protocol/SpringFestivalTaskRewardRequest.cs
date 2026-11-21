using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012E9 RID: 4841
	[NetMessage(EMessageId.SpringFestivalTaskRewardRequest)]
	public sealed class SpringFestivalTaskRewardRequest : IMessage<SpringFestivalTaskRewardRequest>, IMessage, IEquatable<SpringFestivalTaskRewardRequest>, IDeepCloneable<SpringFestivalTaskRewardRequest>, IBufferMessage
	{
		// Token: 0x06019D56 RID: 105814 RVA: 0x003C4E1D File Offset: 0x003C301D
		[NullableContext(1)]
		public static SpringFestivalTaskRewardRequest Create()
		{
			return new SpringFestivalTaskRewardRequest();
		}

		// Token: 0x17005782 RID: 22402
		// (get) Token: 0x06019D57 RID: 105815 RVA: 0x003C4E24 File Offset: 0x003C3024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005783 RID: 22403
		// (get) Token: 0x06019D58 RID: 105816 RVA: 0x003C4E27 File Offset: 0x003C3027
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpringFestivalTaskRewardRequest.Descriptor;
			}
		}

		// Token: 0x06019D59 RID: 105817 RVA: 0x003C4E2E File Offset: 0x003C302E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringFestivalTaskRewardRequest()
		{
		}

		// Token: 0x06019D5A RID: 105818 RVA: 0x003C4E41 File Offset: 0x003C3041
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringFestivalTaskRewardRequest(SpringFestivalTaskRewardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.taskIds_ = other.taskIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019D5B RID: 105819 RVA: 0x003C4E77 File Offset: 0x003C3077
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringFestivalTaskRewardRequest Clone()
		{
			return new SpringFestivalTaskRewardRequest(this);
		}

		// Token: 0x17005784 RID: 22404
		// (get) Token: 0x06019D5C RID: 105820 RVA: 0x003C4E7F File Offset: 0x003C307F
		// (set) Token: 0x06019D5D RID: 105821 RVA: 0x003C4E87 File Offset: 0x003C3087
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

		// Token: 0x17005785 RID: 22405
		// (get) Token: 0x06019D5E RID: 105822 RVA: 0x003C4E90 File Offset: 0x003C3090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskIds
		{
			get
			{
				return this.taskIds_;
			}
		}

		// Token: 0x06019D5F RID: 105823 RVA: 0x003C4E98 File Offset: 0x003C3098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpringFestivalTaskRewardRequest);
		}

		// Token: 0x06019D60 RID: 105824 RVA: 0x003C4EA8 File Offset: 0x003C30A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpringFestivalTaskRewardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.taskIds_.Equals(other.taskIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019D61 RID: 105825 RVA: 0x003C4EF8 File Offset: 0x003C30F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.taskIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019D62 RID: 105826 RVA: 0x003C4F45 File Offset: 0x003C3145
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019D63 RID: 105827 RVA: 0x003C4F52 File Offset: 0x003C3152
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019D64 RID: 105828 RVA: 0x003C4F5C File Offset: 0x003C315C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.taskIds_.WriteTo(ref output, SpringFestivalTaskRewardRequest._repeated_taskIds_codec);
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019D65 RID: 105829 RVA: 0x003C4FAC File Offset: 0x003C31AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.taskIds_.CalculateSize(SpringFestivalTaskRewardRequest._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019D66 RID: 105830 RVA: 0x003C5000 File Offset: 0x003C3200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SpringFestivalTaskRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.taskIds_.Add(other.taskIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019D67 RID: 105831 RVA: 0x003C504D File Offset: 0x003C324D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019D68 RID: 105832 RVA: 0x003C5058 File Offset: 0x003C3258
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
				if (num != 32U && num != 34U)
				{
					if (num != 104U)
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
					this.taskIds_.AddEntriesFrom(ref input, SpringFestivalTaskRewardRequest._repeated_taskIds_codec);
				}
			}
		}

		// Token: 0x0400987C RID: 39036
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400987D RID: 39037
		public const int ActivityIdFieldNumber = 13;

		// Token: 0x0400987E RID: 39038
		private int activityId_;

		// Token: 0x0400987F RID: 39039
		public const int TaskIdsFieldNumber = 4;

		// Token: 0x04009880 RID: 39040
		private static readonly FieldCodec<int> _repeated_taskIds_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04009881 RID: 39041
		private readonly RepeatedField<int> taskIds_ = new RepeatedField<int>();
	}
}
