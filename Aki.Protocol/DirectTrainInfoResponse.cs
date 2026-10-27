using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003DB RID: 987
	[NetMessage(EMessageId.DirectTrainInfoResponse)]
	public sealed class DirectTrainInfoResponse : IMessage<DirectTrainInfoResponse>, IMessage, IEquatable<DirectTrainInfoResponse>, IDeepCloneable<DirectTrainInfoResponse>, IBufferMessage
	{
		// Token: 0x0600601B RID: 24603 RVA: 0x000E882E File Offset: 0x000E6A2E
		[NullableContext(1)]
		public static DirectTrainInfoResponse Create()
		{
			return new DirectTrainInfoResponse();
		}

		// Token: 0x170011E8 RID: 4584
		// (get) Token: 0x0600601C RID: 24604 RVA: 0x000E8835 File Offset: 0x000E6A35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170011E9 RID: 4585
		// (get) Token: 0x0600601D RID: 24605 RVA: 0x000E8838 File Offset: 0x000E6A38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DirectTrainInfoResponse.Descriptor;
			}
		}

		// Token: 0x0600601E RID: 24606 RVA: 0x000E883F File Offset: 0x000E6A3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DirectTrainInfoResponse()
		{
		}

		// Token: 0x0600601F RID: 24607 RVA: 0x000E8854 File Offset: 0x000E6A54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DirectTrainInfoResponse(DirectTrainInfoResponse other) : this()
		{
			this.activitys_ = other.activitys_.Clone();
			this.mainActivity_ = ((other.mainActivity_ != null) ? other.mainActivity_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006020 RID: 24608 RVA: 0x000E88A5 File Offset: 0x000E6AA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DirectTrainInfoResponse Clone()
		{
			return new DirectTrainInfoResponse(this);
		}

		// Token: 0x170011EA RID: 4586
		// (get) Token: 0x06006021 RID: 24609 RVA: 0x000E88AD File Offset: 0x000E6AAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ActivityData> Activitys
		{
			get
			{
				return this.activitys_;
			}
		}

		// Token: 0x170011EB RID: 4587
		// (get) Token: 0x06006022 RID: 24610 RVA: 0x000E88B5 File Offset: 0x000E6AB5
		// (set) Token: 0x06006023 RID: 24611 RVA: 0x000E88BD File Offset: 0x000E6ABD
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

		// Token: 0x06006024 RID: 24612 RVA: 0x000E88C6 File Offset: 0x000E6AC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DirectTrainInfoResponse);
		}

		// Token: 0x06006025 RID: 24613 RVA: 0x000E88D4 File Offset: 0x000E6AD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DirectTrainInfoResponse other)
		{
			return other != null && (other == this || (this.activitys_.Equals(other.activitys_) && object.Equals(this.MainActivity, other.MainActivity) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006026 RID: 24614 RVA: 0x000E8928 File Offset: 0x000E6B28
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

		// Token: 0x06006027 RID: 24615 RVA: 0x000E8972 File Offset: 0x000E6B72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006028 RID: 24616 RVA: 0x000E897F File Offset: 0x000E6B7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006029 RID: 24617 RVA: 0x000E8988 File Offset: 0x000E6B88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.mainActivity_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.MainActivity);
			}
			this.activitys_.WriteTo(ref output, DirectTrainInfoResponse._repeated_activitys_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600602A RID: 24618 RVA: 0x000E89D8 File Offset: 0x000E6BD8
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

		// Token: 0x0600602B RID: 24619 RVA: 0x000E8A2C File Offset: 0x000E6C2C
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

		// Token: 0x0600602C RID: 24620 RVA: 0x000E8A91 File Offset: 0x000E6C91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600602D RID: 24621 RVA: 0x000E8A9C File Offset: 0x000E6C9C
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
				if (num != 18U)
				{
					if (num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.activitys_.AddEntriesFrom(ref input, DirectTrainInfoResponse._repeated_activitys_codec);
					}
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
		}

		// Token: 0x0400374D RID: 14157
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400374E RID: 14158
		public const int ActivitysFieldNumber = 14;

		// Token: 0x0400374F RID: 14159
		private static readonly FieldCodec<ActivityData> _repeated_activitys_codec = FieldCodec.ForMessage<ActivityData>(114U, ActivityData.Parser);

		// Token: 0x04003750 RID: 14160
		private readonly RepeatedField<ActivityData> activitys_ = new RepeatedField<ActivityData>();

		// Token: 0x04003751 RID: 14161
		public const int MainActivityFieldNumber = 2;

		// Token: 0x04003752 RID: 14162
		private ActivityData mainActivity_;
	}
}
