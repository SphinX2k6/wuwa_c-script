using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001C7 RID: 455
	[NetMessage(EMessageId.BossPilingRewardRequest)]
	public sealed class BossPilingRewardRequest : IMessage<BossPilingRewardRequest>, IMessage, IEquatable<BossPilingRewardRequest>, IDeepCloneable<BossPilingRewardRequest>, IBufferMessage
	{
		// Token: 0x06003429 RID: 13353 RVA: 0x00083B95 File Offset: 0x00081D95
		[NullableContext(1)]
		public static BossPilingRewardRequest Create()
		{
			return new BossPilingRewardRequest();
		}

		// Token: 0x17000843 RID: 2115
		// (get) Token: 0x0600342A RID: 13354 RVA: 0x00083B9C File Offset: 0x00081D9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000844 RID: 2116
		// (get) Token: 0x0600342B RID: 13355 RVA: 0x00083B9F File Offset: 0x00081D9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BossPilingRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600342C RID: 13356 RVA: 0x00083BA6 File Offset: 0x00081DA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossPilingRewardRequest()
		{
		}

		// Token: 0x0600342D RID: 13357 RVA: 0x00083BB9 File Offset: 0x00081DB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossPilingRewardRequest(BossPilingRewardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.bossPilingTaskIds_ = other.bossPilingTaskIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600342E RID: 13358 RVA: 0x00083BEF File Offset: 0x00081DEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossPilingRewardRequest Clone()
		{
			return new BossPilingRewardRequest(this);
		}

		// Token: 0x17000845 RID: 2117
		// (get) Token: 0x0600342F RID: 13359 RVA: 0x00083BF7 File Offset: 0x00081DF7
		// (set) Token: 0x06003430 RID: 13360 RVA: 0x00083BFF File Offset: 0x00081DFF
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

		// Token: 0x17000846 RID: 2118
		// (get) Token: 0x06003431 RID: 13361 RVA: 0x00083C08 File Offset: 0x00081E08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> BossPilingTaskIds
		{
			get
			{
				return this.bossPilingTaskIds_;
			}
		}

		// Token: 0x06003432 RID: 13362 RVA: 0x00083C10 File Offset: 0x00081E10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BossPilingRewardRequest);
		}

		// Token: 0x06003433 RID: 13363 RVA: 0x00083C20 File Offset: 0x00081E20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BossPilingRewardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.bossPilingTaskIds_.Equals(other.bossPilingTaskIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003434 RID: 13364 RVA: 0x00083C70 File Offset: 0x00081E70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.bossPilingTaskIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003435 RID: 13365 RVA: 0x00083CBD File Offset: 0x00081EBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003436 RID: 13366 RVA: 0x00083CCA File Offset: 0x00081ECA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003437 RID: 13367 RVA: 0x00083CD4 File Offset: 0x00081ED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ActivityId);
			}
			this.bossPilingTaskIds_.WriteTo(ref output, BossPilingRewardRequest._repeated_bossPilingTaskIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003438 RID: 13368 RVA: 0x00083D24 File Offset: 0x00081F24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.bossPilingTaskIds_.CalculateSize(BossPilingRewardRequest._repeated_bossPilingTaskIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003439 RID: 13369 RVA: 0x00083D78 File Offset: 0x00081F78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BossPilingRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.bossPilingTaskIds_.Add(other.bossPilingTaskIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600343A RID: 13370 RVA: 0x00083DC5 File Offset: 0x00081FC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600343B RID: 13371 RVA: 0x00083DD0 File Offset: 0x00081FD0
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
				if (num != 24U)
				{
					if (num != 64U && num != 66U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.bossPilingTaskIds_.AddEntriesFrom(ref input, BossPilingRewardRequest._repeated_bossPilingTaskIds_codec);
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040029F5 RID: 10741
		private UnknownFieldSet _unknownFields;

		// Token: 0x040029F6 RID: 10742
		public const int ActivityIdFieldNumber = 3;

		// Token: 0x040029F7 RID: 10743
		private int activityId_;

		// Token: 0x040029F8 RID: 10744
		public const int BossPilingTaskIdsFieldNumber = 8;

		// Token: 0x040029F9 RID: 10745
		private static readonly FieldCodec<int> _repeated_bossPilingTaskIds_codec = FieldCodec.ForInt32(66U);

		// Token: 0x040029FA RID: 10746
		private readonly RepeatedField<int> bossPilingTaskIds_ = new RepeatedField<int>();
	}
}
