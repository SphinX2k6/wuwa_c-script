using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000ABD RID: 2749
	[NetMessage(EMessageId.MowTowerLevelsRewardRequest)]
	public sealed class MowTowerLevelsRewardRequest : IMessage<MowTowerLevelsRewardRequest>, IMessage, IEquatable<MowTowerLevelsRewardRequest>, IDeepCloneable<MowTowerLevelsRewardRequest>, IBufferMessage
	{
		// Token: 0x0600EFBB RID: 61371 RVA: 0x00230F69 File Offset: 0x0022F169
		[NullableContext(1)]
		public static MowTowerLevelsRewardRequest Create()
		{
			return new MowTowerLevelsRewardRequest();
		}

		// Token: 0x170030CF RID: 12495
		// (get) Token: 0x0600EFBC RID: 61372 RVA: 0x00230F70 File Offset: 0x0022F170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170030D0 RID: 12496
		// (get) Token: 0x0600EFBD RID: 61373 RVA: 0x00230F73 File Offset: 0x0022F173
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MowTowerLevelsRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600EFBE RID: 61374 RVA: 0x00230F7A File Offset: 0x0022F17A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MowTowerLevelsRewardRequest()
		{
		}

		// Token: 0x0600EFBF RID: 61375 RVA: 0x00230F82 File Offset: 0x0022F182
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MowTowerLevelsRewardRequest(MowTowerLevelsRewardRequest other) : this()
		{
			this.rewardId_ = other.rewardId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EFC0 RID: 61376 RVA: 0x00230FA7 File Offset: 0x0022F1A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MowTowerLevelsRewardRequest Clone()
		{
			return new MowTowerLevelsRewardRequest(this);
		}

		// Token: 0x170030D1 RID: 12497
		// (get) Token: 0x0600EFC1 RID: 61377 RVA: 0x00230FAF File Offset: 0x0022F1AF
		// (set) Token: 0x0600EFC2 RID: 61378 RVA: 0x00230FB7 File Offset: 0x0022F1B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RewardId
		{
			get
			{
				return this.rewardId_;
			}
			set
			{
				this.rewardId_ = value;
			}
		}

		// Token: 0x0600EFC3 RID: 61379 RVA: 0x00230FC0 File Offset: 0x0022F1C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MowTowerLevelsRewardRequest);
		}

		// Token: 0x0600EFC4 RID: 61380 RVA: 0x00230FCE File Offset: 0x0022F1CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MowTowerLevelsRewardRequest other)
		{
			return other != null && (other == this || (this.RewardId == other.RewardId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EFC5 RID: 61381 RVA: 0x00230FFC File Offset: 0x0022F1FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RewardId != 0)
			{
				num ^= this.RewardId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600EFC6 RID: 61382 RVA: 0x0023103B File Offset: 0x0022F23B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EFC7 RID: 61383 RVA: 0x00231048 File Offset: 0x0022F248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EFC8 RID: 61384 RVA: 0x00231051 File Offset: 0x0022F251
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RewardId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.RewardId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EFC9 RID: 61385 RVA: 0x00231084 File Offset: 0x0022F284
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RewardId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RewardId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600EFCA RID: 61386 RVA: 0x002310C2 File Offset: 0x0022F2C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MowTowerLevelsRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RewardId != 0)
			{
				this.RewardId = other.RewardId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600EFCB RID: 61387 RVA: 0x002310F3 File Offset: 0x0022F2F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EFCC RID: 61388 RVA: 0x002310FC File Offset: 0x0022F2FC
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.RewardId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006168 RID: 24936
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006169 RID: 24937
		public const int RewardIdFieldNumber = 7;

		// Token: 0x0400616A RID: 24938
		private int rewardId_;
	}
}
