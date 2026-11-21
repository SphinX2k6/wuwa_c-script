using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000527 RID: 1319
	public sealed class FightRoleInformation : IMessage<FightRoleInformation>, IMessage, IEquatable<FightRoleInformation>, IDeepCloneable<FightRoleInformation>, IBufferMessage
	{
		// Token: 0x06007C23 RID: 31779 RVA: 0x0012D893 File Offset: 0x0012BA93
		[NullableContext(1)]
		public static FightRoleInformation Create()
		{
			return new FightRoleInformation();
		}

		// Token: 0x17001821 RID: 6177
		// (get) Token: 0x06007C24 RID: 31780 RVA: 0x0012D89A File Offset: 0x0012BA9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FightRoleInformation> Parser
		{
			get
			{
				return FightRoleInformation._parser;
			}
		}

		// Token: 0x17001822 RID: 6178
		// (get) Token: 0x06007C25 RID: 31781 RVA: 0x0012D8A1 File Offset: 0x0012BAA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001823 RID: 6179
		// (get) Token: 0x06007C26 RID: 31782 RVA: 0x0012D8A4 File Offset: 0x0012BAA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FightRoleInformation.Descriptor;
			}
		}

		// Token: 0x06007C27 RID: 31783 RVA: 0x0012D8AB File Offset: 0x0012BAAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightRoleInformation()
		{
		}

		// Token: 0x06007C28 RID: 31784 RVA: 0x0012D8B3 File Offset: 0x0012BAB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightRoleInformation(FightRoleInformation other) : this()
		{
			this.roleId_ = other.roleId_;
			this.entityId_ = other.entityId_;
			this.isControl_ = other.isControl_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007C29 RID: 31785 RVA: 0x0012D8F0 File Offset: 0x0012BAF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightRoleInformation Clone()
		{
			return new FightRoleInformation(this);
		}

		// Token: 0x17001824 RID: 6180
		// (get) Token: 0x06007C2A RID: 31786 RVA: 0x0012D8F8 File Offset: 0x0012BAF8
		// (set) Token: 0x06007C2B RID: 31787 RVA: 0x0012D900 File Offset: 0x0012BB00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleId
		{
			get
			{
				return this.roleId_;
			}
			set
			{
				this.roleId_ = value;
			}
		}

		// Token: 0x17001825 RID: 6181
		// (get) Token: 0x06007C2C RID: 31788 RVA: 0x0012D909 File Offset: 0x0012BB09
		// (set) Token: 0x06007C2D RID: 31789 RVA: 0x0012D911 File Offset: 0x0012BB11
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

		// Token: 0x17001826 RID: 6182
		// (get) Token: 0x06007C2E RID: 31790 RVA: 0x0012D91A File Offset: 0x0012BB1A
		// (set) Token: 0x06007C2F RID: 31791 RVA: 0x0012D922 File Offset: 0x0012BB22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsControl
		{
			get
			{
				return this.isControl_;
			}
			set
			{
				this.isControl_ = value;
			}
		}

		// Token: 0x06007C30 RID: 31792 RVA: 0x0012D92B File Offset: 0x0012BB2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FightRoleInformation);
		}

		// Token: 0x06007C31 RID: 31793 RVA: 0x0012D93C File Offset: 0x0012BB3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FightRoleInformation other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.EntityId == other.EntityId && this.IsControl == other.IsControl && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007C32 RID: 31794 RVA: 0x0012D998 File Offset: 0x0012BB98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.IsControl)
			{
				num ^= this.IsControl.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007C33 RID: 31795 RVA: 0x0012DA09 File Offset: 0x0012BC09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007C34 RID: 31796 RVA: 0x0012DA16 File Offset: 0x0012BC16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007C35 RID: 31797 RVA: 0x0012DA20 File Offset: 0x0012BC20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoleId);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.EntityId);
			}
			if (this.IsControl)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.IsControl);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007C36 RID: 31798 RVA: 0x0012DA94 File Offset: 0x0012BC94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.IsControl)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007C37 RID: 31799 RVA: 0x0012DAF8 File Offset: 0x0012BCF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FightRoleInformation other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.IsControl)
			{
				this.IsControl = other.IsControl;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007C38 RID: 31800 RVA: 0x0012DB5C File Offset: 0x0012BD5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007C39 RID: 31801 RVA: 0x0012DB68 File Offset: 0x0012BD68
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
						if (num != 40U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.IsControl = input.ReadBool();
						}
					}
					else
					{
						this.EntityId = input.ReadInt64();
					}
				}
				else
				{
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003FD5 RID: 16341
		private static readonly MessageParser<FightRoleInformation> _parser = new MessageParser<FightRoleInformation>(() => new FightRoleInformation());

		// Token: 0x04003FD6 RID: 16342
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003FD7 RID: 16343
		public const int RoleIdFieldNumber = 1;

		// Token: 0x04003FD8 RID: 16344
		private int roleId_;

		// Token: 0x04003FD9 RID: 16345
		public const int EntityIdFieldNumber = 2;

		// Token: 0x04003FDA RID: 16346
		private long entityId_;

		// Token: 0x04003FDB RID: 16347
		public const int IsControlFieldNumber = 5;

		// Token: 0x04003FDC RID: 16348
		private bool isControl_;
	}
}
