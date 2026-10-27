using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000952 RID: 2386
	[NetMessage(EMessageId.LongShanScoreRewardRequest)]
	public sealed class LongShanScoreRewardRequest : IMessage<LongShanScoreRewardRequest>, IMessage, IEquatable<LongShanScoreRewardRequest>, IDeepCloneable<LongShanScoreRewardRequest>, IBufferMessage
	{
		// Token: 0x0600D24B RID: 53835 RVA: 0x001EFE62 File Offset: 0x001EE062
		[NullableContext(1)]
		public static LongShanScoreRewardRequest Create()
		{
			return new LongShanScoreRewardRequest();
		}

		// Token: 0x17002A90 RID: 10896
		// (get) Token: 0x0600D24C RID: 53836 RVA: 0x001EFE69 File Offset: 0x001EE069
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002A91 RID: 10897
		// (get) Token: 0x0600D24D RID: 53837 RVA: 0x001EFE6C File Offset: 0x001EE06C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LongShanScoreRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600D24E RID: 53838 RVA: 0x001EFE73 File Offset: 0x001EE073
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LongShanScoreRewardRequest()
		{
		}

		// Token: 0x0600D24F RID: 53839 RVA: 0x001EFE86 File Offset: 0x001EE086
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LongShanScoreRewardRequest(LongShanScoreRewardRequest other) : this()
		{
			this.ids_ = other.ids_.Clone();
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D250 RID: 53840 RVA: 0x001EFEBC File Offset: 0x001EE0BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LongShanScoreRewardRequest Clone()
		{
			return new LongShanScoreRewardRequest(this);
		}

		// Token: 0x17002A92 RID: 10898
		// (get) Token: 0x0600D251 RID: 53841 RVA: 0x001EFEC4 File Offset: 0x001EE0C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Ids
		{
			get
			{
				return this.ids_;
			}
		}

		// Token: 0x17002A93 RID: 10899
		// (get) Token: 0x0600D252 RID: 53842 RVA: 0x001EFECC File Offset: 0x001EE0CC
		// (set) Token: 0x0600D253 RID: 53843 RVA: 0x001EFED4 File Offset: 0x001EE0D4
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

		// Token: 0x0600D254 RID: 53844 RVA: 0x001EFEDD File Offset: 0x001EE0DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LongShanScoreRewardRequest);
		}

		// Token: 0x0600D255 RID: 53845 RVA: 0x001EFEEC File Offset: 0x001EE0EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LongShanScoreRewardRequest other)
		{
			return other != null && (other == this || (this.ids_.Equals(other.ids_) && this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D256 RID: 53846 RVA: 0x001EFF3C File Offset: 0x001EE13C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.ids_.GetHashCode();
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D257 RID: 53847 RVA: 0x001EFF89 File Offset: 0x001EE189
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D258 RID: 53848 RVA: 0x001EFF96 File Offset: 0x001EE196
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D259 RID: 53849 RVA: 0x001EFFA0 File Offset: 0x001EE1A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.ids_.WriteTo(ref output, LongShanScoreRewardRequest._repeated_ids_codec);
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D25A RID: 53850 RVA: 0x001EFFF0 File Offset: 0x001EE1F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.ids_.CalculateSize(LongShanScoreRewardRequest._repeated_ids_codec);
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D25B RID: 53851 RVA: 0x001F0044 File Offset: 0x001EE244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LongShanScoreRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.ids_.Add(other.ids_);
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D25C RID: 53852 RVA: 0x001F0091 File Offset: 0x001EE291
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D25D RID: 53853 RVA: 0x001F009C File Offset: 0x001EE29C
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
					if (num != 112U)
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
					this.ids_.AddEntriesFrom(ref input, LongShanScoreRewardRequest._repeated_ids_codec);
				}
			}
		}

		// Token: 0x0400587B RID: 22651
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400587C RID: 22652
		public const int IdsFieldNumber = 8;

		// Token: 0x0400587D RID: 22653
		private static readonly FieldCodec<int> _repeated_ids_codec = FieldCodec.ForInt32(66U);

		// Token: 0x0400587E RID: 22654
		private readonly RepeatedField<int> ids_ = new RepeatedField<int>();

		// Token: 0x0400587F RID: 22655
		public const int ActivityIdFieldNumber = 14;

		// Token: 0x04005880 RID: 22656
		private int activityId_;
	}
}
