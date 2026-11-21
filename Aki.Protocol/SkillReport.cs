using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200127B RID: 4731
	public sealed class SkillReport : IMessage<SkillReport>, IMessage, IEquatable<SkillReport>, IDeepCloneable<SkillReport>, IBufferMessage
	{
		// Token: 0x06019423 RID: 103459 RVA: 0x003AF45E File Offset: 0x003AD65E
		[NullableContext(1)]
		public static SkillReport Create()
		{
			return new SkillReport();
		}

		// Token: 0x1700556E RID: 21870
		// (get) Token: 0x06019424 RID: 103460 RVA: 0x003AF465 File Offset: 0x003AD665
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700556F RID: 21871
		// (get) Token: 0x06019425 RID: 103461 RVA: 0x003AF468 File Offset: 0x003AD668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SkillReport.Descriptor;
			}
		}

		// Token: 0x06019426 RID: 103462 RVA: 0x003AF46F File Offset: 0x003AD66F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillReport()
		{
		}

		// Token: 0x06019427 RID: 103463 RVA: 0x003AF478 File Offset: 0x003AD678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillReport(SkillReport other) : this()
		{
			this.skillId_ = other.skillId_;
			this.useCount_ = other.useCount_;
			this.hitCount_ = other.hitCount_;
			this.expectHitCount_ = other.expectHitCount_;
			this.realHitCount_ = other.realHitCount_;
			this.damage_ = other.damage_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019428 RID: 103464 RVA: 0x003AF4E4 File Offset: 0x003AD6E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillReport Clone()
		{
			return new SkillReport(this);
		}

		// Token: 0x17005570 RID: 21872
		// (get) Token: 0x06019429 RID: 103465 RVA: 0x003AF4EC File Offset: 0x003AD6EC
		// (set) Token: 0x0601942A RID: 103466 RVA: 0x003AF4F4 File Offset: 0x003AD6F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long SkillId
		{
			get
			{
				return this.skillId_;
			}
			set
			{
				this.skillId_ = value;
			}
		}

		// Token: 0x17005571 RID: 21873
		// (get) Token: 0x0601942B RID: 103467 RVA: 0x003AF4FD File Offset: 0x003AD6FD
		// (set) Token: 0x0601942C RID: 103468 RVA: 0x003AF505 File Offset: 0x003AD705
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int UseCount
		{
			get
			{
				return this.useCount_;
			}
			set
			{
				this.useCount_ = value;
			}
		}

		// Token: 0x17005572 RID: 21874
		// (get) Token: 0x0601942D RID: 103469 RVA: 0x003AF50E File Offset: 0x003AD70E
		// (set) Token: 0x0601942E RID: 103470 RVA: 0x003AF516 File Offset: 0x003AD716
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HitCount
		{
			get
			{
				return this.hitCount_;
			}
			set
			{
				this.hitCount_ = value;
			}
		}

		// Token: 0x17005573 RID: 21875
		// (get) Token: 0x0601942F RID: 103471 RVA: 0x003AF51F File Offset: 0x003AD71F
		// (set) Token: 0x06019430 RID: 103472 RVA: 0x003AF527 File Offset: 0x003AD727
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ExpectHitCount
		{
			get
			{
				return this.expectHitCount_;
			}
			set
			{
				this.expectHitCount_ = value;
			}
		}

		// Token: 0x17005574 RID: 21876
		// (get) Token: 0x06019431 RID: 103473 RVA: 0x003AF530 File Offset: 0x003AD730
		// (set) Token: 0x06019432 RID: 103474 RVA: 0x003AF538 File Offset: 0x003AD738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RealHitCount
		{
			get
			{
				return this.realHitCount_;
			}
			set
			{
				this.realHitCount_ = value;
			}
		}

		// Token: 0x17005575 RID: 21877
		// (get) Token: 0x06019433 RID: 103475 RVA: 0x003AF541 File Offset: 0x003AD741
		// (set) Token: 0x06019434 RID: 103476 RVA: 0x003AF549 File Offset: 0x003AD749
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Damage
		{
			get
			{
				return this.damage_;
			}
			set
			{
				this.damage_ = value;
			}
		}

		// Token: 0x06019435 RID: 103477 RVA: 0x003AF552 File Offset: 0x003AD752
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SkillReport);
		}

		// Token: 0x06019436 RID: 103478 RVA: 0x003AF560 File Offset: 0x003AD760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SkillReport other)
		{
			return other != null && (other == this || (this.SkillId == other.SkillId && this.UseCount == other.UseCount && this.HitCount == other.HitCount && this.ExpectHitCount == other.ExpectHitCount && this.RealHitCount == other.RealHitCount && this.Damage == other.Damage && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019437 RID: 103479 RVA: 0x003AF5EC File Offset: 0x003AD7EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SkillId != 0L)
			{
				num ^= this.SkillId.GetHashCode();
			}
			if (this.UseCount != 0)
			{
				num ^= this.UseCount.GetHashCode();
			}
			if (this.HitCount != 0)
			{
				num ^= this.HitCount.GetHashCode();
			}
			if (this.ExpectHitCount != 0)
			{
				num ^= this.ExpectHitCount.GetHashCode();
			}
			if (this.RealHitCount != 0)
			{
				num ^= this.RealHitCount.GetHashCode();
			}
			if (this.Damage != 0L)
			{
				num ^= this.Damage.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019438 RID: 103480 RVA: 0x003AF6A8 File Offset: 0x003AD8A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019439 RID: 103481 RVA: 0x003AF6B5 File Offset: 0x003AD8B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601943A RID: 103482 RVA: 0x003AF6C0 File Offset: 0x003AD8C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkillId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.SkillId);
			}
			if (this.UseCount != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.UseCount);
			}
			if (this.HitCount != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.HitCount);
			}
			if (this.ExpectHitCount != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ExpectHitCount);
			}
			if (this.RealHitCount != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.RealHitCount);
			}
			if (this.Damage != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.Damage);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601943B RID: 103483 RVA: 0x003AF788 File Offset: 0x003AD988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SkillId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.SkillId);
			}
			if (this.UseCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.UseCount);
			}
			if (this.HitCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HitCount);
			}
			if (this.ExpectHitCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ExpectHitCount);
			}
			if (this.RealHitCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RealHitCount);
			}
			if (this.Damage != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Damage);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601943C RID: 103484 RVA: 0x003AF840 File Offset: 0x003ADA40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SkillReport other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SkillId != 0L)
			{
				this.SkillId = other.SkillId;
			}
			if (other.UseCount != 0)
			{
				this.UseCount = other.UseCount;
			}
			if (other.HitCount != 0)
			{
				this.HitCount = other.HitCount;
			}
			if (other.ExpectHitCount != 0)
			{
				this.ExpectHitCount = other.ExpectHitCount;
			}
			if (other.RealHitCount != 0)
			{
				this.RealHitCount = other.RealHitCount;
			}
			if (other.Damage != 0L)
			{
				this.Damage = other.Damage;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601943D RID: 103485 RVA: 0x003AF8E0 File Offset: 0x003ADAE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601943E RID: 103486 RVA: 0x003AF8EC File Offset: 0x003ADAEC
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
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.SkillId = input.ReadInt64();
						continue;
					}
					if (num == 16U)
					{
						this.UseCount = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.HitCount = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 32U)
					{
						this.ExpectHitCount = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.RealHitCount = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.Damage = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009583 RID: 38275
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009584 RID: 38276
		public const int SkillIdFieldNumber = 1;

		// Token: 0x04009585 RID: 38277
		private long skillId_;

		// Token: 0x04009586 RID: 38278
		public const int UseCountFieldNumber = 2;

		// Token: 0x04009587 RID: 38279
		private int useCount_;

		// Token: 0x04009588 RID: 38280
		public const int HitCountFieldNumber = 3;

		// Token: 0x04009589 RID: 38281
		private int hitCount_;

		// Token: 0x0400958A RID: 38282
		public const int ExpectHitCountFieldNumber = 4;

		// Token: 0x0400958B RID: 38283
		private int expectHitCount_;

		// Token: 0x0400958C RID: 38284
		public const int RealHitCountFieldNumber = 5;

		// Token: 0x0400958D RID: 38285
		private int realHitCount_;

		// Token: 0x0400958E RID: 38286
		public const int DamageFieldNumber = 6;

		// Token: 0x0400958F RID: 38287
		private long damage_;
	}
}
