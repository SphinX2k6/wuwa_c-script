using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006B9 RID: 1721
	[NetMessage(EMessageId.GetLevelPlayRewardsRequest)]
	public sealed class GetLevelPlayRewardsRequest : IMessage<GetLevelPlayRewardsRequest>, IMessage, IEquatable<GetLevelPlayRewardsRequest>, IDeepCloneable<GetLevelPlayRewardsRequest>, IBufferMessage
	{
		// Token: 0x06009DD3 RID: 40403 RVA: 0x0017F421 File Offset: 0x0017D621
		[NullableContext(1)]
		public static GetLevelPlayRewardsRequest Create()
		{
			return new GetLevelPlayRewardsRequest();
		}

		// Token: 0x17001FAF RID: 8111
		// (get) Token: 0x06009DD4 RID: 40404 RVA: 0x0017F428 File Offset: 0x0017D628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001FB0 RID: 8112
		// (get) Token: 0x06009DD5 RID: 40405 RVA: 0x0017F42B File Offset: 0x0017D62B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetLevelPlayRewardsRequest.Descriptor;
			}
		}

		// Token: 0x06009DD6 RID: 40406 RVA: 0x0017F432 File Offset: 0x0017D632
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetLevelPlayRewardsRequest()
		{
		}

		// Token: 0x06009DD7 RID: 40407 RVA: 0x0017F43A File Offset: 0x0017D63A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetLevelPlayRewardsRequest(GetLevelPlayRewardsRequest other) : this()
		{
			this.instId_ = other.instId_;
			this.levelPlayId_ = other.levelPlayId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009DD8 RID: 40408 RVA: 0x0017F46B File Offset: 0x0017D66B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetLevelPlayRewardsRequest Clone()
		{
			return new GetLevelPlayRewardsRequest(this);
		}

		// Token: 0x17001FB1 RID: 8113
		// (get) Token: 0x06009DD9 RID: 40409 RVA: 0x0017F473 File Offset: 0x0017D673
		// (set) Token: 0x06009DDA RID: 40410 RVA: 0x0017F47B File Offset: 0x0017D67B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstId
		{
			get
			{
				return this.instId_;
			}
			set
			{
				this.instId_ = value;
			}
		}

		// Token: 0x17001FB2 RID: 8114
		// (get) Token: 0x06009DDB RID: 40411 RVA: 0x0017F484 File Offset: 0x0017D684
		// (set) Token: 0x06009DDC RID: 40412 RVA: 0x0017F48C File Offset: 0x0017D68C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LevelPlayId
		{
			get
			{
				return this.levelPlayId_;
			}
			set
			{
				this.levelPlayId_ = value;
			}
		}

		// Token: 0x06009DDD RID: 40413 RVA: 0x0017F495 File Offset: 0x0017D695
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetLevelPlayRewardsRequest);
		}

		// Token: 0x06009DDE RID: 40414 RVA: 0x0017F4A3 File Offset: 0x0017D6A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetLevelPlayRewardsRequest other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.LevelPlayId == other.LevelPlayId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009DDF RID: 40415 RVA: 0x0017F4E4 File Offset: 0x0017D6E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			if (this.LevelPlayId != 0)
			{
				num ^= this.LevelPlayId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009DE0 RID: 40416 RVA: 0x0017F53C File Offset: 0x0017D73C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009DE1 RID: 40417 RVA: 0x0017F549 File Offset: 0x0017D749
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009DE2 RID: 40418 RVA: 0x0017F554 File Offset: 0x0017D754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelPlayId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.LevelPlayId);
			}
			if (this.InstId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.InstId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009DE3 RID: 40419 RVA: 0x0017F5B0 File Offset: 0x0017D7B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			if (this.LevelPlayId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelPlayId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009DE4 RID: 40420 RVA: 0x0017F608 File Offset: 0x0017D808
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetLevelPlayRewardsRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			if (other.LevelPlayId != 0)
			{
				this.LevelPlayId = other.LevelPlayId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009DE5 RID: 40421 RVA: 0x0017F658 File Offset: 0x0017D858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009DE6 RID: 40422 RVA: 0x0017F664 File Offset: 0x0017D864
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
				if (num != 72U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.InstId = input.ReadInt32();
					}
				}
				else
				{
					this.LevelPlayId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004A54 RID: 19028
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A55 RID: 19029
		public const int InstIdFieldNumber = 15;

		// Token: 0x04004A56 RID: 19030
		private int instId_;

		// Token: 0x04004A57 RID: 19031
		public const int LevelPlayIdFieldNumber = 9;

		// Token: 0x04004A58 RID: 19032
		private int levelPlayId_;
	}
}
