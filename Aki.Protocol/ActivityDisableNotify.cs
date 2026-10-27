using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000084 RID: 132
	[NetMessage(EMessageId.ActivityDisableNotify)]
	public sealed class ActivityDisableNotify : IMessage<ActivityDisableNotify>, IMessage, IEquatable<ActivityDisableNotify>, IDeepCloneable<ActivityDisableNotify>, IBufferMessage
	{
		// Token: 0x06001A0F RID: 6671 RVA: 0x00049F53 File Offset: 0x00048153
		[NullableContext(1)]
		public static ActivityDisableNotify Create()
		{
			return new ActivityDisableNotify();
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x06001A10 RID: 6672 RVA: 0x00049F5A File Offset: 0x0004815A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x06001A11 RID: 6673 RVA: 0x00049F5D File Offset: 0x0004815D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActivityDisableNotify.Descriptor;
			}
		}

		// Token: 0x06001A12 RID: 6674 RVA: 0x00049F64 File Offset: 0x00048164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityDisableNotify()
		{
		}

		// Token: 0x06001A13 RID: 6675 RVA: 0x00049F77 File Offset: 0x00048177
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityDisableNotify(ActivityDisableNotify other) : this()
		{
			this.activityIds_ = other.activityIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001A14 RID: 6676 RVA: 0x00049FA1 File Offset: 0x000481A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityDisableNotify Clone()
		{
			return new ActivityDisableNotify(this);
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x06001A15 RID: 6677 RVA: 0x00049FA9 File Offset: 0x000481A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ActivityIds
		{
			get
			{
				return this.activityIds_;
			}
		}

		// Token: 0x06001A16 RID: 6678 RVA: 0x00049FB1 File Offset: 0x000481B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActivityDisableNotify);
		}

		// Token: 0x06001A17 RID: 6679 RVA: 0x00049FBF File Offset: 0x000481BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActivityDisableNotify other)
		{
			return other != null && (other == this || (this.activityIds_.Equals(other.activityIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001A18 RID: 6680 RVA: 0x00049FF4 File Offset: 0x000481F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.activityIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001A19 RID: 6681 RVA: 0x0004A028 File Offset: 0x00048228
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001A1A RID: 6682 RVA: 0x0004A035 File Offset: 0x00048235
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001A1B RID: 6683 RVA: 0x0004A03E File Offset: 0x0004823E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.activityIds_.WriteTo(ref output, ActivityDisableNotify._repeated_activityIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001A1C RID: 6684 RVA: 0x0004A068 File Offset: 0x00048268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.activityIds_.CalculateSize(ActivityDisableNotify._repeated_activityIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001A1D RID: 6685 RVA: 0x0004A0A1 File Offset: 0x000482A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ActivityDisableNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.activityIds_.Add(other.activityIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001A1E RID: 6686 RVA: 0x0004A0CF File Offset: 0x000482CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001A1F RID: 6687 RVA: 0x0004A0D8 File Offset: 0x000482D8
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
				if (num != 64U && num != 66U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.activityIds_.AddEntriesFrom(ref input, ActivityDisableNotify._repeated_activityIds_codec);
				}
			}
		}

		// Token: 0x04002239 RID: 8761
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400223A RID: 8762
		public const int ActivityIdsFieldNumber = 8;

		// Token: 0x0400223B RID: 8763
		private static readonly FieldCodec<int> _repeated_activityIds_codec = FieldCodec.ForInt32(66U);

		// Token: 0x0400223C RID: 8764
		private readonly RepeatedField<int> activityIds_ = new RepeatedField<int>();
	}
}
