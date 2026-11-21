using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014B3 RID: 5299
	[NetMessage(EMessageId.TrapDefenseRewardGainingGroupsNotify)]
	public sealed class TrapDefenseRewardGainingGroupsNotify : IMessage<TrapDefenseRewardGainingGroupsNotify>, IMessage, IEquatable<TrapDefenseRewardGainingGroupsNotify>, IDeepCloneable<TrapDefenseRewardGainingGroupsNotify>, IBufferMessage
	{
		// Token: 0x0601C1E7 RID: 115175 RVA: 0x004151BA File Offset: 0x004133BA
		[NullableContext(1)]
		public static TrapDefenseRewardGainingGroupsNotify Create()
		{
			return new TrapDefenseRewardGainingGroupsNotify();
		}

		// Token: 0x17005F2F RID: 24367
		// (get) Token: 0x0601C1E8 RID: 115176 RVA: 0x004151C1 File Offset: 0x004133C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005F30 RID: 24368
		// (get) Token: 0x0601C1E9 RID: 115177 RVA: 0x004151C4 File Offset: 0x004133C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseRewardGainingGroupsNotify.Descriptor;
			}
		}

		// Token: 0x0601C1EA RID: 115178 RVA: 0x004151CB File Offset: 0x004133CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseRewardGainingGroupsNotify()
		{
		}

		// Token: 0x0601C1EB RID: 115179 RVA: 0x004151D3 File Offset: 0x004133D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseRewardGainingGroupsNotify(TrapDefenseRewardGainingGroupsNotify other) : this()
		{
			this.rewardInfo_ = ((other.rewardInfo_ != null) ? other.rewardInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C1EC RID: 115180 RVA: 0x00415208 File Offset: 0x00413408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseRewardGainingGroupsNotify Clone()
		{
			return new TrapDefenseRewardGainingGroupsNotify(this);
		}

		// Token: 0x17005F31 RID: 24369
		// (get) Token: 0x0601C1ED RID: 115181 RVA: 0x00415210 File Offset: 0x00413410
		// (set) Token: 0x0601C1EE RID: 115182 RVA: 0x00415218 File Offset: 0x00413418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RewardGainingPanelInfo RewardInfo
		{
			get
			{
				return this.rewardInfo_;
			}
			set
			{
				this.rewardInfo_ = value;
			}
		}

		// Token: 0x0601C1EF RID: 115183 RVA: 0x00415221 File Offset: 0x00413421
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseRewardGainingGroupsNotify);
		}

		// Token: 0x0601C1F0 RID: 115184 RVA: 0x0041522F File Offset: 0x0041342F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseRewardGainingGroupsNotify other)
		{
			return other != null && (other == this || (object.Equals(this.RewardInfo, other.RewardInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C1F1 RID: 115185 RVA: 0x00415264 File Offset: 0x00413464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.rewardInfo_ != null)
			{
				num ^= this.RewardInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C1F2 RID: 115186 RVA: 0x004152A0 File Offset: 0x004134A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C1F3 RID: 115187 RVA: 0x004152AD File Offset: 0x004134AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C1F4 RID: 115188 RVA: 0x004152B6 File Offset: 0x004134B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rewardInfo_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.RewardInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C1F5 RID: 115189 RVA: 0x004152E8 File Offset: 0x004134E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.rewardInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RewardInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C1F6 RID: 115190 RVA: 0x00415328 File Offset: 0x00413528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseRewardGainingGroupsNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.rewardInfo_ != null)
			{
				if (this.rewardInfo_ == null)
				{
					this.RewardInfo = new RewardGainingPanelInfo();
				}
				this.RewardInfo.MergeFrom(other.RewardInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C1F7 RID: 115191 RVA: 0x0041537C File Offset: 0x0041357C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C1F8 RID: 115192 RVA: 0x00415388 File Offset: 0x00413588
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
				if (num != 90U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.rewardInfo_ == null)
					{
						this.RewardInfo = new RewardGainingPanelInfo();
					}
					input.ReadMessage(this.RewardInfo);
				}
			}
		}

		// Token: 0x0400A2C1 RID: 41665
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A2C2 RID: 41666
		public const int RewardInfoFieldNumber = 11;

		// Token: 0x0400A2C3 RID: 41667
		private RewardGainingPanelInfo rewardInfo_;
	}
}
