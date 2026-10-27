using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003E4 RID: 996
	[NetMessage(EMessageId.DodgeInfoPush)]
	public sealed class DodgeInfoPush : IMessage<DodgeInfoPush>, IMessage, IEquatable<DodgeInfoPush>, IDeepCloneable<DodgeInfoPush>, IBufferMessage
	{
		// Token: 0x060060C7 RID: 24775 RVA: 0x000E9DB1 File Offset: 0x000E7FB1
		[NullableContext(1)]
		public static DodgeInfoPush Create()
		{
			return new DodgeInfoPush();
		}

		// Token: 0x17001208 RID: 4616
		// (get) Token: 0x060060C8 RID: 24776 RVA: 0x000E9DB8 File Offset: 0x000E7FB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001209 RID: 4617
		// (get) Token: 0x060060C9 RID: 24777 RVA: 0x000E9DBB File Offset: 0x000E7FBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DodgeInfoPush.Descriptor;
			}
		}

		// Token: 0x060060CA RID: 24778 RVA: 0x000E9DC2 File Offset: 0x000E7FC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DodgeInfoPush()
		{
		}

		// Token: 0x060060CB RID: 24779 RVA: 0x000E9DCA File Offset: 0x000E7FCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DodgeInfoPush(DodgeInfoPush other) : this()
		{
			this.bulletOwnerId_ = other.bulletOwnerId_;
			this.bulletId_ = other.bulletId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060060CC RID: 24780 RVA: 0x000E9DFB File Offset: 0x000E7FFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DodgeInfoPush Clone()
		{
			return new DodgeInfoPush(this);
		}

		// Token: 0x1700120A RID: 4618
		// (get) Token: 0x060060CD RID: 24781 RVA: 0x000E9E03 File Offset: 0x000E8003
		// (set) Token: 0x060060CE RID: 24782 RVA: 0x000E9E0B File Offset: 0x000E800B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long BulletOwnerId
		{
			get
			{
				return this.bulletOwnerId_;
			}
			set
			{
				this.bulletOwnerId_ = value;
			}
		}

		// Token: 0x1700120B RID: 4619
		// (get) Token: 0x060060CF RID: 24783 RVA: 0x000E9E14 File Offset: 0x000E8014
		// (set) Token: 0x060060D0 RID: 24784 RVA: 0x000E9E1C File Offset: 0x000E801C
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

		// Token: 0x060060D1 RID: 24785 RVA: 0x000E9E25 File Offset: 0x000E8025
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DodgeInfoPush);
		}

		// Token: 0x060060D2 RID: 24786 RVA: 0x000E9E33 File Offset: 0x000E8033
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DodgeInfoPush other)
		{
			return other != null && (other == this || (this.BulletOwnerId == other.BulletOwnerId && this.BulletId == other.BulletId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060060D3 RID: 24787 RVA: 0x000E9E74 File Offset: 0x000E8074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BulletOwnerId != 0L)
			{
				num ^= this.BulletOwnerId.GetHashCode();
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

		// Token: 0x060060D4 RID: 24788 RVA: 0x000E9ECC File Offset: 0x000E80CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060060D5 RID: 24789 RVA: 0x000E9ED9 File Offset: 0x000E80D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060060D6 RID: 24790 RVA: 0x000E9EE4 File Offset: 0x000E80E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BulletOwnerId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.BulletOwnerId);
			}
			if (this.BulletId != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.BulletId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060060D7 RID: 24791 RVA: 0x000E9F40 File Offset: 0x000E8140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BulletOwnerId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.BulletOwnerId);
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

		// Token: 0x060060D8 RID: 24792 RVA: 0x000E9F98 File Offset: 0x000E8198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DodgeInfoPush other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BulletOwnerId != 0L)
			{
				this.BulletOwnerId = other.BulletOwnerId;
			}
			if (other.BulletId != 0L)
			{
				this.BulletId = other.BulletId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060060D9 RID: 24793 RVA: 0x000E9FE8 File Offset: 0x000E81E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060060DA RID: 24794 RVA: 0x000E9FF4 File Offset: 0x000E81F4
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
				if (num != 16U)
				{
					if (num != 96U)
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
					this.BulletOwnerId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003775 RID: 14197
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003776 RID: 14198
		public const int BulletOwnerIdFieldNumber = 2;

		// Token: 0x04003777 RID: 14199
		private long bulletOwnerId_;

		// Token: 0x04003778 RID: 14200
		public const int BulletIdFieldNumber = 12;

		// Token: 0x04003779 RID: 14201
		private long bulletId_;
	}
}
