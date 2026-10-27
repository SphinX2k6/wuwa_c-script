using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200127A RID: 4730
	[NetMessage(EMessageId.SpringFestivalTaskRewardRequest)]
	public sealed class SpringFestivalTaskRewardRequest : IMessage<SpringFestivalTaskRewardRequest>, IMessage, IEquatable<SpringFestivalTaskRewardRequest>, IDeepCloneable<SpringFestivalTaskRewardRequest>, IBufferMessage
	{
		// Token: 0x06019320 RID: 103200 RVA: 0x003AA6C9 File Offset: 0x003A88C9
		[NullableContext(1)]
		public static SpringFestivalTaskRewardRequest Create()
		{
			return new SpringFestivalTaskRewardRequest();
		}

		// Token: 0x17005501 RID: 21761
		// (get) Token: 0x06019321 RID: 103201 RVA: 0x003AA6D0 File Offset: 0x003A88D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005502 RID: 21762
		// (get) Token: 0x06019322 RID: 103202 RVA: 0x003AA6D3 File Offset: 0x003A88D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpringFestivalTaskRewardRequest.Descriptor;
			}
		}

		// Token: 0x06019323 RID: 103203 RVA: 0x003AA6DA File Offset: 0x003A88DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringFestivalTaskRewardRequest()
		{
		}

		// Token: 0x06019324 RID: 103204 RVA: 0x003AA6ED File Offset: 0x003A88ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringFestivalTaskRewardRequest(SpringFestivalTaskRewardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.taskIds_ = other.taskIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019325 RID: 103205 RVA: 0x003AA723 File Offset: 0x003A8923
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringFestivalTaskRewardRequest Clone()
		{
			return new SpringFestivalTaskRewardRequest(this);
		}

		// Token: 0x17005503 RID: 21763
		// (get) Token: 0x06019326 RID: 103206 RVA: 0x003AA72B File Offset: 0x003A892B
		// (set) Token: 0x06019327 RID: 103207 RVA: 0x003AA733 File Offset: 0x003A8933
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

		// Token: 0x17005504 RID: 21764
		// (get) Token: 0x06019328 RID: 103208 RVA: 0x003AA73C File Offset: 0x003A893C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskIds
		{
			get
			{
				return this.taskIds_;
			}
		}

		// Token: 0x06019329 RID: 103209 RVA: 0x003AA744 File Offset: 0x003A8944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpringFestivalTaskRewardRequest);
		}

		// Token: 0x0601932A RID: 103210 RVA: 0x003AA754 File Offset: 0x003A8954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpringFestivalTaskRewardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.taskIds_.Equals(other.taskIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601932B RID: 103211 RVA: 0x003AA7A4 File Offset: 0x003A89A4
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

		// Token: 0x0601932C RID: 103212 RVA: 0x003AA7F1 File Offset: 0x003A89F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601932D RID: 103213 RVA: 0x003AA7FE File Offset: 0x003A89FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601932E RID: 103214 RVA: 0x003AA808 File Offset: 0x003A8A08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.taskIds_.WriteTo(ref output, SpringFestivalTaskRewardRequest._repeated_taskIds_codec);
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601932F RID: 103215 RVA: 0x003AA858 File Offset: 0x003A8A58
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

		// Token: 0x06019330 RID: 103216 RVA: 0x003AA8AC File Offset: 0x003A8AAC
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

		// Token: 0x06019331 RID: 103217 RVA: 0x003AA8F9 File Offset: 0x003A8AF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019332 RID: 103218 RVA: 0x003AA904 File Offset: 0x003A8B04
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
				if (num != 96U && num != 98U)
				{
					if (num != 120U)
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

		// Token: 0x04009452 RID: 37970
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009453 RID: 37971
		public const int ActivityIdFieldNumber = 15;

		// Token: 0x04009454 RID: 37972
		private int activityId_;

		// Token: 0x04009455 RID: 37973
		public const int TaskIdsFieldNumber = 12;

		// Token: 0x04009456 RID: 37974
		private static readonly FieldCodec<int> _repeated_taskIds_codec = FieldCodec.ForInt32(98U);

		// Token: 0x04009457 RID: 37975
		private readonly RepeatedField<int> taskIds_ = new RepeatedField<int>();
	}
}
