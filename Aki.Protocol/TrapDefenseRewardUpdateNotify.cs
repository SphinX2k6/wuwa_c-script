using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001443 RID: 5187
	[NetMessage(EMessageId.TrapDefenseRewardUpdateNotify)]
	public sealed class TrapDefenseRewardUpdateNotify : IMessage<TrapDefenseRewardUpdateNotify>, IMessage, IEquatable<TrapDefenseRewardUpdateNotify>, IDeepCloneable<TrapDefenseRewardUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601B796 RID: 112534 RVA: 0x003FA5F6 File Offset: 0x003F87F6
		[NullableContext(1)]
		public static TrapDefenseRewardUpdateNotify Create()
		{
			return new TrapDefenseRewardUpdateNotify();
		}

		// Token: 0x17005CA5 RID: 23717
		// (get) Token: 0x0601B797 RID: 112535 RVA: 0x003FA5FD File Offset: 0x003F87FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005CA6 RID: 23718
		// (get) Token: 0x0601B798 RID: 112536 RVA: 0x003FA600 File Offset: 0x003F8800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseRewardUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601B799 RID: 112537 RVA: 0x003FA607 File Offset: 0x003F8807
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseRewardUpdateNotify()
		{
		}

		// Token: 0x0601B79A RID: 112538 RVA: 0x003FA61A File Offset: 0x003F881A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseRewardUpdateNotify(TrapDefenseRewardUpdateNotify other) : this()
		{
			this.rewards_ = other.rewards_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B79B RID: 112539 RVA: 0x003FA644 File Offset: 0x003F8844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseRewardUpdateNotify Clone()
		{
			return new TrapDefenseRewardUpdateNotify(this);
		}

		// Token: 0x17005CA7 RID: 23719
		// (get) Token: 0x0601B79C RID: 112540 RVA: 0x003FA64C File Offset: 0x003F884C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TrapDefenseRewardInfo> Rewards
		{
			get
			{
				return this.rewards_;
			}
		}

		// Token: 0x0601B79D RID: 112541 RVA: 0x003FA654 File Offset: 0x003F8854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseRewardUpdateNotify);
		}

		// Token: 0x0601B79E RID: 112542 RVA: 0x003FA662 File Offset: 0x003F8862
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseRewardUpdateNotify other)
		{
			return other != null && (other == this || (this.rewards_.Equals(other.rewards_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B79F RID: 112543 RVA: 0x003FA698 File Offset: 0x003F8898
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.rewards_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B7A0 RID: 112544 RVA: 0x003FA6CC File Offset: 0x003F88CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B7A1 RID: 112545 RVA: 0x003FA6D9 File Offset: 0x003F88D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B7A2 RID: 112546 RVA: 0x003FA6E2 File Offset: 0x003F88E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.rewards_.WriteTo(ref output, TrapDefenseRewardUpdateNotify._repeated_rewards_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B7A3 RID: 112547 RVA: 0x003FA70C File Offset: 0x003F890C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.rewards_.CalculateSize(TrapDefenseRewardUpdateNotify._repeated_rewards_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B7A4 RID: 112548 RVA: 0x003FA745 File Offset: 0x003F8945
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseRewardUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.rewards_.Add(other.rewards_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B7A5 RID: 112549 RVA: 0x003FA773 File Offset: 0x003F8973
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B7A6 RID: 112550 RVA: 0x003FA77C File Offset: 0x003F897C
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
				if (num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.rewards_.AddEntriesFrom(ref input, TrapDefenseRewardUpdateNotify._repeated_rewards_codec);
				}
			}
		}

		// Token: 0x04009E86 RID: 40582
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009E87 RID: 40583
		public const int RewardsFieldNumber = 6;

		// Token: 0x04009E88 RID: 40584
		private static readonly FieldCodec<TrapDefenseRewardInfo> _repeated_rewards_codec = FieldCodec.ForMessage<TrapDefenseRewardInfo>(50U, TrapDefenseRewardInfo.Parser);

		// Token: 0x04009E89 RID: 40585
		private readonly RepeatedField<TrapDefenseRewardInfo> rewards_ = new RepeatedField<TrapDefenseRewardInfo>();
	}
}
