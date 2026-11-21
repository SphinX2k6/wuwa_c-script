using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200051E RID: 1310
	[NetMessage(EMessageId.FeiXuePreheatInfoRewardRequest)]
	public sealed class FeiXuePreheatInfoRewardRequest : IMessage<FeiXuePreheatInfoRewardRequest>, IMessage, IEquatable<FeiXuePreheatInfoRewardRequest>, IDeepCloneable<FeiXuePreheatInfoRewardRequest>, IBufferMessage
	{
		// Token: 0x06007B44 RID: 31556 RVA: 0x0012B332 File Offset: 0x00129532
		[NullableContext(1)]
		public static FeiXuePreheatInfoRewardRequest Create()
		{
			return new FeiXuePreheatInfoRewardRequest();
		}

		// Token: 0x170017E5 RID: 6117
		// (get) Token: 0x06007B45 RID: 31557 RVA: 0x0012B339 File Offset: 0x00129539
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170017E6 RID: 6118
		// (get) Token: 0x06007B46 RID: 31558 RVA: 0x0012B33C File Offset: 0x0012953C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FeiXuePreheatInfoRewardRequest.Descriptor;
			}
		}

		// Token: 0x06007B47 RID: 31559 RVA: 0x0012B343 File Offset: 0x00129543
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FeiXuePreheatInfoRewardRequest()
		{
		}

		// Token: 0x06007B48 RID: 31560 RVA: 0x0012B356 File Offset: 0x00129556
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FeiXuePreheatInfoRewardRequest(FeiXuePreheatInfoRewardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.feiXuePreheatInfoIds_ = other.feiXuePreheatInfoIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007B49 RID: 31561 RVA: 0x0012B38C File Offset: 0x0012958C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FeiXuePreheatInfoRewardRequest Clone()
		{
			return new FeiXuePreheatInfoRewardRequest(this);
		}

		// Token: 0x170017E7 RID: 6119
		// (get) Token: 0x06007B4A RID: 31562 RVA: 0x0012B394 File Offset: 0x00129594
		// (set) Token: 0x06007B4B RID: 31563 RVA: 0x0012B39C File Offset: 0x0012959C
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

		// Token: 0x170017E8 RID: 6120
		// (get) Token: 0x06007B4C RID: 31564 RVA: 0x0012B3A5 File Offset: 0x001295A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> FeiXuePreheatInfoIds
		{
			get
			{
				return this.feiXuePreheatInfoIds_;
			}
		}

		// Token: 0x06007B4D RID: 31565 RVA: 0x0012B3AD File Offset: 0x001295AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FeiXuePreheatInfoRewardRequest);
		}

		// Token: 0x06007B4E RID: 31566 RVA: 0x0012B3BC File Offset: 0x001295BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FeiXuePreheatInfoRewardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.feiXuePreheatInfoIds_.Equals(other.feiXuePreheatInfoIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007B4F RID: 31567 RVA: 0x0012B40C File Offset: 0x0012960C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.feiXuePreheatInfoIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007B50 RID: 31568 RVA: 0x0012B459 File Offset: 0x00129659
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007B51 RID: 31569 RVA: 0x0012B466 File Offset: 0x00129666
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007B52 RID: 31570 RVA: 0x0012B470 File Offset: 0x00129670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ActivityId);
			}
			this.feiXuePreheatInfoIds_.WriteTo(ref output, FeiXuePreheatInfoRewardRequest._repeated_feiXuePreheatInfoIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007B53 RID: 31571 RVA: 0x0012B4C0 File Offset: 0x001296C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.feiXuePreheatInfoIds_.CalculateSize(FeiXuePreheatInfoRewardRequest._repeated_feiXuePreheatInfoIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007B54 RID: 31572 RVA: 0x0012B514 File Offset: 0x00129714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FeiXuePreheatInfoRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.feiXuePreheatInfoIds_.Add(other.feiXuePreheatInfoIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007B55 RID: 31573 RVA: 0x0012B561 File Offset: 0x00129761
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007B56 RID: 31574 RVA: 0x0012B56C File Offset: 0x0012976C
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
				if (num != 32U)
				{
					if (num != 72U && num != 74U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.feiXuePreheatInfoIds_.AddEntriesFrom(ref input, FeiXuePreheatInfoRewardRequest._repeated_feiXuePreheatInfoIds_codec);
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003F75 RID: 16245
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F76 RID: 16246
		public const int ActivityIdFieldNumber = 4;

		// Token: 0x04003F77 RID: 16247
		private int activityId_;

		// Token: 0x04003F78 RID: 16248
		public const int FeiXuePreheatInfoIdsFieldNumber = 9;

		// Token: 0x04003F79 RID: 16249
		private static readonly FieldCodec<int> _repeated_feiXuePreheatInfoIds_codec = FieldCodec.ForInt32(74U);

		// Token: 0x04003F7A RID: 16250
		private readonly RepeatedField<int> feiXuePreheatInfoIds_ = new RepeatedField<int>();
	}
}
