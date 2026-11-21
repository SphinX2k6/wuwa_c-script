using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003C4 RID: 964
	[NetMessage(EMessageId.DirectTrainInfoResponse)]
	public sealed class DirectTrainInfoResponse : IMessage<DirectTrainInfoResponse>, IMessage, IEquatable<DirectTrainInfoResponse>, IDeepCloneable<DirectTrainInfoResponse>, IBufferMessage
	{
		// Token: 0x06005E8B RID: 24203 RVA: 0x000E56AE File Offset: 0x000E38AE
		[NullableContext(1)]
		public static DirectTrainInfoResponse Create()
		{
			return new DirectTrainInfoResponse();
		}

		// Token: 0x17001193 RID: 4499
		// (get) Token: 0x06005E8C RID: 24204 RVA: 0x000E56B5 File Offset: 0x000E38B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001194 RID: 4500
		// (get) Token: 0x06005E8D RID: 24205 RVA: 0x000E56B8 File Offset: 0x000E38B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DirectTrainInfoResponse.Descriptor;
			}
		}

		// Token: 0x06005E8E RID: 24206 RVA: 0x000E56BF File Offset: 0x000E38BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DirectTrainInfoResponse()
		{
		}

		// Token: 0x06005E8F RID: 24207 RVA: 0x000E56D4 File Offset: 0x000E38D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DirectTrainInfoResponse(DirectTrainInfoResponse other) : this()
		{
			this.activitys_ = other.activitys_.Clone();
			this.mainActivity_ = ((other.mainActivity_ != null) ? other.mainActivity_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005E90 RID: 24208 RVA: 0x000E5725 File Offset: 0x000E3925
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DirectTrainInfoResponse Clone()
		{
			return new DirectTrainInfoResponse(this);
		}

		// Token: 0x17001195 RID: 4501
		// (get) Token: 0x06005E91 RID: 24209 RVA: 0x000E572D File Offset: 0x000E392D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ActivityData> Activitys
		{
			get
			{
				return this.activitys_;
			}
		}

		// Token: 0x17001196 RID: 4502
		// (get) Token: 0x06005E92 RID: 24210 RVA: 0x000E5735 File Offset: 0x000E3935
		// (set) Token: 0x06005E93 RID: 24211 RVA: 0x000E573D File Offset: 0x000E393D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityData MainActivity
		{
			get
			{
				return this.mainActivity_;
			}
			set
			{
				this.mainActivity_ = value;
			}
		}

		// Token: 0x06005E94 RID: 24212 RVA: 0x000E5746 File Offset: 0x000E3946
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DirectTrainInfoResponse);
		}

		// Token: 0x06005E95 RID: 24213 RVA: 0x000E5754 File Offset: 0x000E3954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DirectTrainInfoResponse other)
		{
			return other != null && (other == this || (this.activitys_.Equals(other.activitys_) && object.Equals(this.MainActivity, other.MainActivity) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005E96 RID: 24214 RVA: 0x000E57A8 File Offset: 0x000E39A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.activitys_.GetHashCode();
			if (this.mainActivity_ != null)
			{
				num ^= this.MainActivity.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005E97 RID: 24215 RVA: 0x000E57F2 File Offset: 0x000E39F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005E98 RID: 24216 RVA: 0x000E57FF File Offset: 0x000E39FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005E99 RID: 24217 RVA: 0x000E5808 File Offset: 0x000E3A08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.activitys_.WriteTo(ref output, DirectTrainInfoResponse._repeated_activitys_codec);
			if (this.mainActivity_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.MainActivity);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005E9A RID: 24218 RVA: 0x000E5858 File Offset: 0x000E3A58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.activitys_.CalculateSize(DirectTrainInfoResponse._repeated_activitys_codec);
			if (this.mainActivity_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MainActivity);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005E9B RID: 24219 RVA: 0x000E58AC File Offset: 0x000E3AAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DirectTrainInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.activitys_.Add(other.activitys_);
			if (other.mainActivity_ != null)
			{
				if (this.mainActivity_ == null)
				{
					this.MainActivity = new ActivityData();
				}
				this.MainActivity.MergeFrom(other.MainActivity);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005E9C RID: 24220 RVA: 0x000E5911 File Offset: 0x000E3B11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005E9D RID: 24221 RVA: 0x000E591C File Offset: 0x000E3B1C
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
				if (num != 10U)
				{
					if (num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.mainActivity_ == null)
						{
							this.MainActivity = new ActivityData();
						}
						input.ReadMessage(this.MainActivity);
					}
				}
				else
				{
					this.activitys_.AddEntriesFrom(ref input, DirectTrainInfoResponse._repeated_activitys_codec);
				}
			}
		}

		// Token: 0x0400373A RID: 14138
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400373B RID: 14139
		public const int ActivitysFieldNumber = 1;

		// Token: 0x0400373C RID: 14140
		private static readonly FieldCodec<ActivityData> _repeated_activitys_codec = FieldCodec.ForMessage<ActivityData>(10U, ActivityData.Parser);

		// Token: 0x0400373D RID: 14141
		private readonly RepeatedField<ActivityData> activitys_ = new RepeatedField<ActivityData>();

		// Token: 0x0400373E RID: 14142
		public const int MainActivityFieldNumber = 14;

		// Token: 0x0400373F RID: 14143
		private ActivityData mainActivity_;
	}
}
