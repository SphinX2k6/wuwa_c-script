using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003F5 RID: 1013
	[NetMessage(EMessageId.DropCatchLevelRewardRequest)]
	public sealed class DropCatchLevelRewardRequest : IMessage<DropCatchLevelRewardRequest>, IMessage, IEquatable<DropCatchLevelRewardRequest>, IDeepCloneable<DropCatchLevelRewardRequest>, IBufferMessage
	{
		// Token: 0x0600624C RID: 25164 RVA: 0x000ECF22 File Offset: 0x000EB122
		[NullableContext(1)]
		public static DropCatchLevelRewardRequest Create()
		{
			return new DropCatchLevelRewardRequest();
		}

		// Token: 0x17001250 RID: 4688
		// (get) Token: 0x0600624D RID: 25165 RVA: 0x000ECF29 File Offset: 0x000EB129
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001251 RID: 4689
		// (get) Token: 0x0600624E RID: 25166 RVA: 0x000ECF2C File Offset: 0x000EB12C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DropCatchLevelRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600624F RID: 25167 RVA: 0x000ECF33 File Offset: 0x000EB133
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DropCatchLevelRewardRequest()
		{
		}

		// Token: 0x06006250 RID: 25168 RVA: 0x000ECF46 File Offset: 0x000EB146
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DropCatchLevelRewardRequest(DropCatchLevelRewardRequest other) : this()
		{
			this.dropCatchId_ = other.dropCatchId_;
			this.rewardIdxs_ = other.rewardIdxs_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006251 RID: 25169 RVA: 0x000ECF7C File Offset: 0x000EB17C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DropCatchLevelRewardRequest Clone()
		{
			return new DropCatchLevelRewardRequest(this);
		}

		// Token: 0x17001252 RID: 4690
		// (get) Token: 0x06006252 RID: 25170 RVA: 0x000ECF84 File Offset: 0x000EB184
		// (set) Token: 0x06006253 RID: 25171 RVA: 0x000ECF8C File Offset: 0x000EB18C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DropCatchId
		{
			get
			{
				return this.dropCatchId_;
			}
			set
			{
				this.dropCatchId_ = value;
			}
		}

		// Token: 0x17001253 RID: 4691
		// (get) Token: 0x06006254 RID: 25172 RVA: 0x000ECF95 File Offset: 0x000EB195
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RewardIdxs
		{
			get
			{
				return this.rewardIdxs_;
			}
		}

		// Token: 0x06006255 RID: 25173 RVA: 0x000ECF9D File Offset: 0x000EB19D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DropCatchLevelRewardRequest);
		}

		// Token: 0x06006256 RID: 25174 RVA: 0x000ECFAC File Offset: 0x000EB1AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DropCatchLevelRewardRequest other)
		{
			return other != null && (other == this || (this.DropCatchId == other.DropCatchId && this.rewardIdxs_.Equals(other.rewardIdxs_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006257 RID: 25175 RVA: 0x000ECFFC File Offset: 0x000EB1FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DropCatchId != 0)
			{
				num ^= this.DropCatchId.GetHashCode();
			}
			num ^= this.rewardIdxs_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006258 RID: 25176 RVA: 0x000ED049 File Offset: 0x000EB249
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006259 RID: 25177 RVA: 0x000ED056 File Offset: 0x000EB256
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600625A RID: 25178 RVA: 0x000ED060 File Offset: 0x000EB260
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DropCatchId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.DropCatchId);
			}
			this.rewardIdxs_.WriteTo(ref output, DropCatchLevelRewardRequest._repeated_rewardIdxs_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600625B RID: 25179 RVA: 0x000ED0B0 File Offset: 0x000EB2B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DropCatchId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DropCatchId);
			}
			num += this.rewardIdxs_.CalculateSize(DropCatchLevelRewardRequest._repeated_rewardIdxs_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600625C RID: 25180 RVA: 0x000ED104 File Offset: 0x000EB304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DropCatchLevelRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DropCatchId != 0)
			{
				this.DropCatchId = other.DropCatchId;
			}
			this.rewardIdxs_.Add(other.rewardIdxs_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600625D RID: 25181 RVA: 0x000ED151 File Offset: 0x000EB351
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600625E RID: 25182 RVA: 0x000ED15C File Offset: 0x000EB35C
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
					if (num != 112U && num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.rewardIdxs_.AddEntriesFrom(ref input, DropCatchLevelRewardRequest._repeated_rewardIdxs_codec);
					}
				}
				else
				{
					this.DropCatchId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400382E RID: 14382
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400382F RID: 14383
		public const int DropCatchIdFieldNumber = 4;

		// Token: 0x04003830 RID: 14384
		private int dropCatchId_;

		// Token: 0x04003831 RID: 14385
		public const int RewardIdxsFieldNumber = 14;

		// Token: 0x04003832 RID: 14386
		private static readonly FieldCodec<int> _repeated_rewardIdxs_codec = FieldCodec.ForInt32(114U);

		// Token: 0x04003833 RID: 14387
		private readonly RepeatedField<int> rewardIdxs_ = new RepeatedField<int>();
	}
}
