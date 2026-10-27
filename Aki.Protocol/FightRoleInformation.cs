using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200053C RID: 1340
	public sealed class FightRoleInformation : IMessage<FightRoleInformation>, IMessage, IEquatable<FightRoleInformation>, IDeepCloneable<FightRoleInformation>, IBufferMessage
	{
		// Token: 0x06007D8B RID: 32139 RVA: 0x00130497 File Offset: 0x0012E697
		[NullableContext(1)]
		public static FightRoleInformation Create()
		{
			return new FightRoleInformation();
		}

		// Token: 0x1700186E RID: 6254
		// (get) Token: 0x06007D8C RID: 32140 RVA: 0x0013049E File Offset: 0x0012E69E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FightRoleInformation> Parser
		{
			get
			{
				return FightRoleInformation._parser;
			}
		}

		// Token: 0x1700186F RID: 6255
		// (get) Token: 0x06007D8D RID: 32141 RVA: 0x001304A5 File Offset: 0x0012E6A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001870 RID: 6256
		// (get) Token: 0x06007D8E RID: 32142 RVA: 0x001304A8 File Offset: 0x0012E6A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FightRoleInformation.Descriptor;
			}
		}

		// Token: 0x06007D8F RID: 32143 RVA: 0x001304AF File Offset: 0x0012E6AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightRoleInformation()
		{
		}

		// Token: 0x06007D90 RID: 32144 RVA: 0x001304B7 File Offset: 0x0012E6B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightRoleInformation(FightRoleInformation other) : this()
		{
			this.roleId_ = other.roleId_;
			this.entityId_ = other.entityId_;
			this.isControl_ = other.isControl_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007D91 RID: 32145 RVA: 0x001304F4 File Offset: 0x0012E6F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightRoleInformation Clone()
		{
			return new FightRoleInformation(this);
		}

		// Token: 0x17001871 RID: 6257
		// (get) Token: 0x06007D92 RID: 32146 RVA: 0x001304FC File Offset: 0x0012E6FC
		// (set) Token: 0x06007D93 RID: 32147 RVA: 0x00130504 File Offset: 0x0012E704
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

		// Token: 0x17001872 RID: 6258
		// (get) Token: 0x06007D94 RID: 32148 RVA: 0x0013050D File Offset: 0x0012E70D
		// (set) Token: 0x06007D95 RID: 32149 RVA: 0x00130515 File Offset: 0x0012E715
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

		// Token: 0x17001873 RID: 6259
		// (get) Token: 0x06007D96 RID: 32150 RVA: 0x0013051E File Offset: 0x0012E71E
		// (set) Token: 0x06007D97 RID: 32151 RVA: 0x00130526 File Offset: 0x0012E726
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

		// Token: 0x06007D98 RID: 32152 RVA: 0x0013052F File Offset: 0x0012E72F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FightRoleInformation);
		}

		// Token: 0x06007D99 RID: 32153 RVA: 0x00130540 File Offset: 0x0012E740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FightRoleInformation other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.EntityId == other.EntityId && this.IsControl == other.IsControl && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007D9A RID: 32154 RVA: 0x0013059C File Offset: 0x0012E79C
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

		// Token: 0x06007D9B RID: 32155 RVA: 0x0013060D File Offset: 0x0012E80D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007D9C RID: 32156 RVA: 0x0013061A File Offset: 0x0012E81A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007D9D RID: 32157 RVA: 0x00130624 File Offset: 0x0012E824
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

		// Token: 0x06007D9E RID: 32158 RVA: 0x00130698 File Offset: 0x0012E898
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

		// Token: 0x06007D9F RID: 32159 RVA: 0x001306FC File Offset: 0x0012E8FC
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

		// Token: 0x06007DA0 RID: 32160 RVA: 0x00130760 File Offset: 0x0012E960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007DA1 RID: 32161 RVA: 0x0013076C File Offset: 0x0012E96C
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

		// Token: 0x04003FDF RID: 16351
		private static readonly MessageParser<FightRoleInformation> _parser = new MessageParser<FightRoleInformation>(() => new FightRoleInformation());

		// Token: 0x04003FE0 RID: 16352
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003FE1 RID: 16353
		public const int RoleIdFieldNumber = 1;

		// Token: 0x04003FE2 RID: 16354
		private int roleId_;

		// Token: 0x04003FE3 RID: 16355
		public const int EntityIdFieldNumber = 2;

		// Token: 0x04003FE4 RID: 16356
		private long entityId_;

		// Token: 0x04003FE5 RID: 16357
		public const int IsControlFieldNumber = 5;

		// Token: 0x04003FE6 RID: 16358
		private bool isControl_;
	}
}
