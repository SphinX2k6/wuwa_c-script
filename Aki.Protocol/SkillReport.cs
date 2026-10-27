using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200123E RID: 4670
	public sealed class SkillReport : IMessage<SkillReport>, IMessage, IEquatable<SkillReport>, IDeepCloneable<SkillReport>, IBufferMessage
	{
		// Token: 0x06018E39 RID: 101945 RVA: 0x0039F4FE File Offset: 0x0039D6FE
		[NullableContext(1)]
		public static SkillReport Create()
		{
			return new SkillReport();
		}

		// Token: 0x170053EF RID: 21487
		// (get) Token: 0x06018E3A RID: 101946 RVA: 0x0039F505 File Offset: 0x0039D705
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170053F0 RID: 21488
		// (get) Token: 0x06018E3B RID: 101947 RVA: 0x0039F508 File Offset: 0x0039D708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SkillReport.Descriptor;
			}
		}

		// Token: 0x06018E3C RID: 101948 RVA: 0x0039F50F File Offset: 0x0039D70F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillReport()
		{
		}

		// Token: 0x06018E3D RID: 101949 RVA: 0x0039F518 File Offset: 0x0039D718
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

		// Token: 0x06018E3E RID: 101950 RVA: 0x0039F584 File Offset: 0x0039D784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillReport Clone()
		{
			return new SkillReport(this);
		}

		// Token: 0x170053F1 RID: 21489
		// (get) Token: 0x06018E3F RID: 101951 RVA: 0x0039F58C File Offset: 0x0039D78C
		// (set) Token: 0x06018E40 RID: 101952 RVA: 0x0039F594 File Offset: 0x0039D794
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

		// Token: 0x170053F2 RID: 21490
		// (get) Token: 0x06018E41 RID: 101953 RVA: 0x0039F59D File Offset: 0x0039D79D
		// (set) Token: 0x06018E42 RID: 101954 RVA: 0x0039F5A5 File Offset: 0x0039D7A5
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

		// Token: 0x170053F3 RID: 21491
		// (get) Token: 0x06018E43 RID: 101955 RVA: 0x0039F5AE File Offset: 0x0039D7AE
		// (set) Token: 0x06018E44 RID: 101956 RVA: 0x0039F5B6 File Offset: 0x0039D7B6
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

		// Token: 0x170053F4 RID: 21492
		// (get) Token: 0x06018E45 RID: 101957 RVA: 0x0039F5BF File Offset: 0x0039D7BF
		// (set) Token: 0x06018E46 RID: 101958 RVA: 0x0039F5C7 File Offset: 0x0039D7C7
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

		// Token: 0x170053F5 RID: 21493
		// (get) Token: 0x06018E47 RID: 101959 RVA: 0x0039F5D0 File Offset: 0x0039D7D0
		// (set) Token: 0x06018E48 RID: 101960 RVA: 0x0039F5D8 File Offset: 0x0039D7D8
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

		// Token: 0x170053F6 RID: 21494
		// (get) Token: 0x06018E49 RID: 101961 RVA: 0x0039F5E1 File Offset: 0x0039D7E1
		// (set) Token: 0x06018E4A RID: 101962 RVA: 0x0039F5E9 File Offset: 0x0039D7E9
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

		// Token: 0x06018E4B RID: 101963 RVA: 0x0039F5F2 File Offset: 0x0039D7F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SkillReport);
		}

		// Token: 0x06018E4C RID: 101964 RVA: 0x0039F600 File Offset: 0x0039D800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SkillReport other)
		{
			return other != null && (other == this || (this.SkillId == other.SkillId && this.UseCount == other.UseCount && this.HitCount == other.HitCount && this.ExpectHitCount == other.ExpectHitCount && this.RealHitCount == other.RealHitCount && this.Damage == other.Damage && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018E4D RID: 101965 RVA: 0x0039F68C File Offset: 0x0039D88C
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

		// Token: 0x06018E4E RID: 101966 RVA: 0x0039F748 File Offset: 0x0039D948
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018E4F RID: 101967 RVA: 0x0039F755 File Offset: 0x0039D955
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018E50 RID: 101968 RVA: 0x0039F760 File Offset: 0x0039D960
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

		// Token: 0x06018E51 RID: 101969 RVA: 0x0039F828 File Offset: 0x0039DA28
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

		// Token: 0x06018E52 RID: 101970 RVA: 0x0039F8E0 File Offset: 0x0039DAE0
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

		// Token: 0x06018E53 RID: 101971 RVA: 0x0039F980 File Offset: 0x0039DB80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018E54 RID: 101972 RVA: 0x0039F98C File Offset: 0x0039DB8C
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

		// Token: 0x040092D1 RID: 37585
		private UnknownFieldSet _unknownFields;

		// Token: 0x040092D2 RID: 37586
		public const int SkillIdFieldNumber = 1;

		// Token: 0x040092D3 RID: 37587
		private long skillId_;

		// Token: 0x040092D4 RID: 37588
		public const int UseCountFieldNumber = 2;

		// Token: 0x040092D5 RID: 37589
		private int useCount_;

		// Token: 0x040092D6 RID: 37590
		public const int HitCountFieldNumber = 3;

		// Token: 0x040092D7 RID: 37591
		private int hitCount_;

		// Token: 0x040092D8 RID: 37592
		public const int ExpectHitCountFieldNumber = 4;

		// Token: 0x040092D9 RID: 37593
		private int expectHitCount_;

		// Token: 0x040092DA RID: 37594
		public const int RealHitCountFieldNumber = 5;

		// Token: 0x040092DB RID: 37595
		private int realHitCount_;

		// Token: 0x040092DC RID: 37596
		public const int DamageFieldNumber = 6;

		// Token: 0x040092DD RID: 37597
		private long damage_;
	}
}
