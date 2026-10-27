using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000295 RID: 661
	[NetMessage(EMessageId.CircumFluenceTaskRewardRequest)]
	public sealed class CircumFluenceTaskRewardRequest : IMessage<CircumFluenceTaskRewardRequest>, IMessage, IEquatable<CircumFluenceTaskRewardRequest>, IDeepCloneable<CircumFluenceTaskRewardRequest>, IBufferMessage
	{
		// Token: 0x060044E6 RID: 17638 RVA: 0x000A9100 File Offset: 0x000A7300
		[NullableContext(1)]
		public static CircumFluenceTaskRewardRequest Create()
		{
			return new CircumFluenceTaskRewardRequest();
		}

		// Token: 0x17000BD9 RID: 3033
		// (get) Token: 0x060044E7 RID: 17639 RVA: 0x000A9107 File Offset: 0x000A7307
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000BDA RID: 3034
		// (get) Token: 0x060044E8 RID: 17640 RVA: 0x000A910A File Offset: 0x000A730A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CircumFluenceTaskRewardRequest.Descriptor;
			}
		}

		// Token: 0x060044E9 RID: 17641 RVA: 0x000A9111 File Offset: 0x000A7311
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CircumFluenceTaskRewardRequest()
		{
		}

		// Token: 0x060044EA RID: 17642 RVA: 0x000A9124 File Offset: 0x000A7324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CircumFluenceTaskRewardRequest(CircumFluenceTaskRewardRequest other) : this()
		{
			this.rewardType_ = other.rewardType_;
			this.ids_ = other.ids_.Clone();
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060044EB RID: 17643 RVA: 0x000A9171 File Offset: 0x000A7371
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CircumFluenceTaskRewardRequest Clone()
		{
			return new CircumFluenceTaskRewardRequest(this);
		}

		// Token: 0x17000BDB RID: 3035
		// (get) Token: 0x060044EC RID: 17644 RVA: 0x000A9179 File Offset: 0x000A7379
		// (set) Token: 0x060044ED RID: 17645 RVA: 0x000A9181 File Offset: 0x000A7381
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CircumFluenceRewardType RewardType
		{
			get
			{
				return this.rewardType_;
			}
			set
			{
				this.rewardType_ = value;
			}
		}

		// Token: 0x17000BDC RID: 3036
		// (get) Token: 0x060044EE RID: 17646 RVA: 0x000A918A File Offset: 0x000A738A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Ids
		{
			get
			{
				return this.ids_;
			}
		}

		// Token: 0x17000BDD RID: 3037
		// (get) Token: 0x060044EF RID: 17647 RVA: 0x000A9192 File Offset: 0x000A7392
		// (set) Token: 0x060044F0 RID: 17648 RVA: 0x000A919A File Offset: 0x000A739A
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

		// Token: 0x060044F1 RID: 17649 RVA: 0x000A91A3 File Offset: 0x000A73A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CircumFluenceTaskRewardRequest);
		}

		// Token: 0x060044F2 RID: 17650 RVA: 0x000A91B4 File Offset: 0x000A73B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CircumFluenceTaskRewardRequest other)
		{
			return other != null && (other == this || (this.RewardType == other.RewardType && this.ids_.Equals(other.ids_) && this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060044F3 RID: 17651 RVA: 0x000A9214 File Offset: 0x000A7414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RewardType != CircumFluenceRewardType.TaskReward)
			{
				num ^= this.RewardType.GetHashCode();
			}
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

		// Token: 0x060044F4 RID: 17652 RVA: 0x000A9280 File Offset: 0x000A7480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060044F5 RID: 17653 RVA: 0x000A928D File Offset: 0x000A748D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060044F6 RID: 17654 RVA: 0x000A9298 File Offset: 0x000A7498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RewardType != CircumFluenceRewardType.TaskReward)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.RewardType);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.ActivityId);
			}
			this.ids_.WriteTo(ref output, CircumFluenceTaskRewardRequest._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060044F7 RID: 17655 RVA: 0x000A9304 File Offset: 0x000A7504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RewardType != CircumFluenceRewardType.TaskReward)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.RewardType);
			}
			num += this.ids_.CalculateSize(CircumFluenceTaskRewardRequest._repeated_ids_codec);
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

		// Token: 0x060044F8 RID: 17656 RVA: 0x000A9370 File Offset: 0x000A7570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CircumFluenceTaskRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RewardType != CircumFluenceRewardType.TaskReward)
			{
				this.RewardType = other.RewardType;
			}
			this.ids_.Add(other.ids_);
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060044F9 RID: 17657 RVA: 0x000A93D1 File Offset: 0x000A75D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060044FA RID: 17658 RVA: 0x000A93DC File Offset: 0x000A75DC
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
				if (num <= 64U)
				{
					if (num == 24U)
					{
						this.RewardType = (CircumFluenceRewardType)input.ReadEnum();
						continue;
					}
					if (num == 64U)
					{
						this.ActivityId = input.ReadInt32();
						continue;
					}
				}
				else if (num == 96U || num == 98U)
				{
					this.ids_.AddEntriesFrom(ref input, CircumFluenceTaskRewardRequest._repeated_ids_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002ED0 RID: 11984
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002ED1 RID: 11985
		public const int RewardTypeFieldNumber = 3;

		// Token: 0x04002ED2 RID: 11986
		private CircumFluenceRewardType rewardType_;

		// Token: 0x04002ED3 RID: 11987
		public const int IdsFieldNumber = 12;

		// Token: 0x04002ED4 RID: 11988
		private static readonly FieldCodec<int> _repeated_ids_codec = FieldCodec.ForInt32(98U);

		// Token: 0x04002ED5 RID: 11989
		private readonly RepeatedField<int> ids_ = new RepeatedField<int>();

		// Token: 0x04002ED6 RID: 11990
		public const int ActivityIdFieldNumber = 8;

		// Token: 0x04002ED7 RID: 11991
		private int activityId_;
	}
}
