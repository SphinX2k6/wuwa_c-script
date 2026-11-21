using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000825 RID: 2085
	public sealed class InterruptSkillInfo : IMessage<InterruptSkillInfo>, IMessage, IEquatable<InterruptSkillInfo>, IDeepCloneable<InterruptSkillInfo>, IBufferMessage
	{
		// Token: 0x0600BAAA RID: 47786 RVA: 0x001BCE6C File Offset: 0x001BB06C
		[NullableContext(1)]
		public static InterruptSkillInfo Create()
		{
			return new InterruptSkillInfo();
		}

		// Token: 0x170025AB RID: 9643
		// (get) Token: 0x0600BAAB RID: 47787 RVA: 0x001BCE73 File Offset: 0x001BB073
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170025AC RID: 9644
		// (get) Token: 0x0600BAAC RID: 47788 RVA: 0x001BCE76 File Offset: 0x001BB076
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InterruptSkillInfo.Descriptor;
			}
		}

		// Token: 0x0600BAAD RID: 47789 RVA: 0x001BCE7D File Offset: 0x001BB07D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InterruptSkillInfo()
		{
		}

		// Token: 0x0600BAAE RID: 47790 RVA: 0x001BCE85 File Offset: 0x001BB085
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InterruptSkillInfo(InterruptSkillInfo other) : this()
		{
			this.entityId_ = other.entityId_;
			this.skillId_ = other.skillId_;
			this.bulletId_ = other.bulletId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BAAF RID: 47791 RVA: 0x001BCEC2 File Offset: 0x001BB0C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InterruptSkillInfo Clone()
		{
			return new InterruptSkillInfo(this);
		}

		// Token: 0x170025AD RID: 9645
		// (get) Token: 0x0600BAB0 RID: 47792 RVA: 0x001BCECA File Offset: 0x001BB0CA
		// (set) Token: 0x0600BAB1 RID: 47793 RVA: 0x001BCED2 File Offset: 0x001BB0D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x170025AE RID: 9646
		// (get) Token: 0x0600BAB2 RID: 47794 RVA: 0x001BCEDB File Offset: 0x001BB0DB
		// (set) Token: 0x0600BAB3 RID: 47795 RVA: 0x001BCEE3 File Offset: 0x001BB0E3
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

		// Token: 0x170025AF RID: 9647
		// (get) Token: 0x0600BAB4 RID: 47796 RVA: 0x001BCEEC File Offset: 0x001BB0EC
		// (set) Token: 0x0600BAB5 RID: 47797 RVA: 0x001BCEF4 File Offset: 0x001BB0F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long BulletId
		{
			get
			{
				return this.bulletId_;
			}
			set
			{
				this.bulletId_ = value;
			}
		}

		// Token: 0x0600BAB6 RID: 47798 RVA: 0x001BCEFD File Offset: 0x001BB0FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InterruptSkillInfo);
		}

		// Token: 0x0600BAB7 RID: 47799 RVA: 0x001BCF0C File Offset: 0x001BB10C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InterruptSkillInfo other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.SkillId == other.SkillId && this.BulletId == other.BulletId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BAB8 RID: 47800 RVA: 0x001BCF68 File Offset: 0x001BB168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.SkillId != 0L)
			{
				num ^= this.SkillId.GetHashCode();
			}
			if (this.BulletId != 0L)
			{
				num ^= this.BulletId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BAB9 RID: 47801 RVA: 0x001BCFD9 File Offset: 0x001BB1D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BABA RID: 47802 RVA: 0x001BCFE6 File Offset: 0x001BB1E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BABB RID: 47803 RVA: 0x001BCFF0 File Offset: 0x001BB1F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.EntityId);
			}
			if (this.SkillId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.SkillId);
			}
			if (this.BulletId != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.BulletId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BABC RID: 47804 RVA: 0x001BD064 File Offset: 0x001BB264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.SkillId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.SkillId);
			}
			if (this.BulletId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.BulletId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BABD RID: 47805 RVA: 0x001BD0D4 File Offset: 0x001BB2D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InterruptSkillInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.SkillId != 0L)
			{
				this.SkillId = other.SkillId;
			}
			if (other.BulletId != 0L)
			{
				this.BulletId = other.BulletId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BABE RID: 47806 RVA: 0x001BD138 File Offset: 0x001BB338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BABF RID: 47807 RVA: 0x001BD144 File Offset: 0x001BB344
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
				if (num != 8U)
				{
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.BulletId = input.ReadInt64();
						}
					}
					else
					{
						this.SkillId = input.ReadInt64();
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04005260 RID: 21088
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005261 RID: 21089
		public const int EntityIdFieldNumber = 1;

		// Token: 0x04005262 RID: 21090
		private long entityId_;

		// Token: 0x04005263 RID: 21091
		public const int SkillIdFieldNumber = 2;

		// Token: 0x04005264 RID: 21092
		private long skillId_;

		// Token: 0x04005265 RID: 21093
		public const int BulletIdFieldNumber = 3;

		// Token: 0x04005266 RID: 21094
		private long bulletId_;
	}
}
