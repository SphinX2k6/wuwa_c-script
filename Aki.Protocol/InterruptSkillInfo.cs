using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000839 RID: 2105
	public sealed class InterruptSkillInfo : IMessage<InterruptSkillInfo>, IMessage, IEquatable<InterruptSkillInfo>, IDeepCloneable<InterruptSkillInfo>, IBufferMessage
	{
		// Token: 0x0600BC00 RID: 48128 RVA: 0x001BF8A8 File Offset: 0x001BDAA8
		[NullableContext(1)]
		public static InterruptSkillInfo Create()
		{
			return new InterruptSkillInfo();
		}

		// Token: 0x170025F5 RID: 9717
		// (get) Token: 0x0600BC01 RID: 48129 RVA: 0x001BF8AF File Offset: 0x001BDAAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170025F6 RID: 9718
		// (get) Token: 0x0600BC02 RID: 48130 RVA: 0x001BF8B2 File Offset: 0x001BDAB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InterruptSkillInfo.Descriptor;
			}
		}

		// Token: 0x0600BC03 RID: 48131 RVA: 0x001BF8B9 File Offset: 0x001BDAB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InterruptSkillInfo()
		{
		}

		// Token: 0x0600BC04 RID: 48132 RVA: 0x001BF8C1 File Offset: 0x001BDAC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InterruptSkillInfo(InterruptSkillInfo other) : this()
		{
			this.entityId_ = other.entityId_;
			this.skillId_ = other.skillId_;
			this.bulletId_ = other.bulletId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BC05 RID: 48133 RVA: 0x001BF8FE File Offset: 0x001BDAFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InterruptSkillInfo Clone()
		{
			return new InterruptSkillInfo(this);
		}

		// Token: 0x170025F7 RID: 9719
		// (get) Token: 0x0600BC06 RID: 48134 RVA: 0x001BF906 File Offset: 0x001BDB06
		// (set) Token: 0x0600BC07 RID: 48135 RVA: 0x001BF90E File Offset: 0x001BDB0E
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

		// Token: 0x170025F8 RID: 9720
		// (get) Token: 0x0600BC08 RID: 48136 RVA: 0x001BF917 File Offset: 0x001BDB17
		// (set) Token: 0x0600BC09 RID: 48137 RVA: 0x001BF91F File Offset: 0x001BDB1F
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

		// Token: 0x170025F9 RID: 9721
		// (get) Token: 0x0600BC0A RID: 48138 RVA: 0x001BF928 File Offset: 0x001BDB28
		// (set) Token: 0x0600BC0B RID: 48139 RVA: 0x001BF930 File Offset: 0x001BDB30
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

		// Token: 0x0600BC0C RID: 48140 RVA: 0x001BF939 File Offset: 0x001BDB39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InterruptSkillInfo);
		}

		// Token: 0x0600BC0D RID: 48141 RVA: 0x001BF948 File Offset: 0x001BDB48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InterruptSkillInfo other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.SkillId == other.SkillId && this.BulletId == other.BulletId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BC0E RID: 48142 RVA: 0x001BF9A4 File Offset: 0x001BDBA4
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

		// Token: 0x0600BC0F RID: 48143 RVA: 0x001BFA15 File Offset: 0x001BDC15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BC10 RID: 48144 RVA: 0x001BFA22 File Offset: 0x001BDC22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BC11 RID: 48145 RVA: 0x001BFA2C File Offset: 0x001BDC2C
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

		// Token: 0x0600BC12 RID: 48146 RVA: 0x001BFAA0 File Offset: 0x001BDCA0
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

		// Token: 0x0600BC13 RID: 48147 RVA: 0x001BFB10 File Offset: 0x001BDD10
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

		// Token: 0x0600BC14 RID: 48148 RVA: 0x001BFB74 File Offset: 0x001BDD74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BC15 RID: 48149 RVA: 0x001BFB80 File Offset: 0x001BDD80
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

		// Token: 0x04005267 RID: 21095
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005268 RID: 21096
		public const int EntityIdFieldNumber = 1;

		// Token: 0x04005269 RID: 21097
		private long entityId_;

		// Token: 0x0400526A RID: 21098
		public const int SkillIdFieldNumber = 2;

		// Token: 0x0400526B RID: 21099
		private long skillId_;

		// Token: 0x0400526C RID: 21100
		public const int BulletIdFieldNumber = 3;

		// Token: 0x0400526D RID: 21101
		private long bulletId_;
	}
}
