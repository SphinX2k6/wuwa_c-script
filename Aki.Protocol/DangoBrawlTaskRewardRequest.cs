using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000384 RID: 900
	[NetMessage(EMessageId.DangoBrawlTaskRewardRequest)]
	public sealed class DangoBrawlTaskRewardRequest : IMessage<DangoBrawlTaskRewardRequest>, IMessage, IEquatable<DangoBrawlTaskRewardRequest>, IDeepCloneable<DangoBrawlTaskRewardRequest>, IBufferMessage
	{
		// Token: 0x06005961 RID: 22881 RVA: 0x000DA079 File Offset: 0x000D8279
		[NullableContext(1)]
		public static DangoBrawlTaskRewardRequest Create()
		{
			return new DangoBrawlTaskRewardRequest();
		}

		// Token: 0x17001079 RID: 4217
		// (get) Token: 0x06005962 RID: 22882 RVA: 0x000DA080 File Offset: 0x000D8280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700107A RID: 4218
		// (get) Token: 0x06005963 RID: 22883 RVA: 0x000DA083 File Offset: 0x000D8283
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlTaskRewardRequest.Descriptor;
			}
		}

		// Token: 0x06005964 RID: 22884 RVA: 0x000DA08A File Offset: 0x000D828A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlTaskRewardRequest()
		{
		}

		// Token: 0x06005965 RID: 22885 RVA: 0x000DA09D File Offset: 0x000D829D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlTaskRewardRequest(DangoBrawlTaskRewardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.taskIds_ = other.taskIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005966 RID: 22886 RVA: 0x000DA0D3 File Offset: 0x000D82D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlTaskRewardRequest Clone()
		{
			return new DangoBrawlTaskRewardRequest(this);
		}

		// Token: 0x1700107B RID: 4219
		// (get) Token: 0x06005967 RID: 22887 RVA: 0x000DA0DB File Offset: 0x000D82DB
		// (set) Token: 0x06005968 RID: 22888 RVA: 0x000DA0E3 File Offset: 0x000D82E3
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

		// Token: 0x1700107C RID: 4220
		// (get) Token: 0x06005969 RID: 22889 RVA: 0x000DA0EC File Offset: 0x000D82EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskIds
		{
			get
			{
				return this.taskIds_;
			}
		}

		// Token: 0x0600596A RID: 22890 RVA: 0x000DA0F4 File Offset: 0x000D82F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlTaskRewardRequest);
		}

		// Token: 0x0600596B RID: 22891 RVA: 0x000DA104 File Offset: 0x000D8304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlTaskRewardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.taskIds_.Equals(other.taskIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600596C RID: 22892 RVA: 0x000DA154 File Offset: 0x000D8354
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

		// Token: 0x0600596D RID: 22893 RVA: 0x000DA1A1 File Offset: 0x000D83A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600596E RID: 22894 RVA: 0x000DA1AE File Offset: 0x000D83AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600596F RID: 22895 RVA: 0x000DA1B8 File Offset: 0x000D83B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.ActivityId);
			}
			this.taskIds_.WriteTo(ref output, DangoBrawlTaskRewardRequest._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005970 RID: 22896 RVA: 0x000DA208 File Offset: 0x000D8408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.taskIds_.CalculateSize(DangoBrawlTaskRewardRequest._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005971 RID: 22897 RVA: 0x000DA25C File Offset: 0x000D845C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlTaskRewardRequest other)
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

		// Token: 0x06005972 RID: 22898 RVA: 0x000DA2A9 File Offset: 0x000D84A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005973 RID: 22899 RVA: 0x000DA2B4 File Offset: 0x000D84B4
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
				if (num != 72U)
				{
					if (num != 80U && num != 82U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.taskIds_.AddEntriesFrom(ref input, DangoBrawlTaskRewardRequest._repeated_taskIds_codec);
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040035AE RID: 13742
		private UnknownFieldSet _unknownFields;

		// Token: 0x040035AF RID: 13743
		public const int ActivityIdFieldNumber = 9;

		// Token: 0x040035B0 RID: 13744
		private int activityId_;

		// Token: 0x040035B1 RID: 13745
		public const int TaskIdsFieldNumber = 10;

		// Token: 0x040035B2 RID: 13746
		private static readonly FieldCodec<int> _repeated_taskIds_codec = FieldCodec.ForInt32(82U);

		// Token: 0x040035B3 RID: 13747
		private readonly RepeatedField<int> taskIds_ = new RepeatedField<int>();
	}
}
