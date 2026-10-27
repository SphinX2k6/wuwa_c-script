using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200018E RID: 398
	[NetMessage(EMessageId.BeControlledShowNotify)]
	public sealed class BeControlledShowNotify : IMessage<BeControlledShowNotify>, IMessage, IEquatable<BeControlledShowNotify>, IDeepCloneable<BeControlledShowNotify>, IBufferMessage
	{
		// Token: 0x06002F97 RID: 12183 RVA: 0x00079DA1 File Offset: 0x00077FA1
		[NullableContext(1)]
		public static BeControlledShowNotify Create()
		{
			return new BeControlledShowNotify();
		}

		// Token: 0x1700074D RID: 1869
		// (get) Token: 0x06002F98 RID: 12184 RVA: 0x00079DA8 File Offset: 0x00077FA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x06002F99 RID: 12185 RVA: 0x00079DAB File Offset: 0x00077FAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BeControlledShowNotify.Descriptor;
			}
		}

		// Token: 0x06002F9A RID: 12186 RVA: 0x00079DB2 File Offset: 0x00077FB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledShowNotify()
		{
		}

		// Token: 0x06002F9B RID: 12187 RVA: 0x00079DBA File Offset: 0x00077FBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledShowNotify(BeControlledShowNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.roleEntityId_ = other.roleEntityId_;
			this.isShow_ = other.isShow_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002F9C RID: 12188 RVA: 0x00079DF7 File Offset: 0x00077FF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledShowNotify Clone()
		{
			return new BeControlledShowNotify(this);
		}

		// Token: 0x1700074F RID: 1871
		// (get) Token: 0x06002F9D RID: 12189 RVA: 0x00079DFF File Offset: 0x00077FFF
		// (set) Token: 0x06002F9E RID: 12190 RVA: 0x00079E07 File Offset: 0x00078007
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

		// Token: 0x17000750 RID: 1872
		// (get) Token: 0x06002F9F RID: 12191 RVA: 0x00079E10 File Offset: 0x00078010
		// (set) Token: 0x06002FA0 RID: 12192 RVA: 0x00079E18 File Offset: 0x00078018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long RoleEntityId
		{
			get
			{
				return this.roleEntityId_;
			}
			set
			{
				this.roleEntityId_ = value;
			}
		}

		// Token: 0x17000751 RID: 1873
		// (get) Token: 0x06002FA1 RID: 12193 RVA: 0x00079E21 File Offset: 0x00078021
		// (set) Token: 0x06002FA2 RID: 12194 RVA: 0x00079E29 File Offset: 0x00078029
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsShow
		{
			get
			{
				return this.isShow_;
			}
			set
			{
				this.isShow_ = value;
			}
		}

		// Token: 0x06002FA3 RID: 12195 RVA: 0x00079E32 File Offset: 0x00078032
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BeControlledShowNotify);
		}

		// Token: 0x06002FA4 RID: 12196 RVA: 0x00079E40 File Offset: 0x00078040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BeControlledShowNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.RoleEntityId == other.RoleEntityId && this.IsShow == other.IsShow && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002FA5 RID: 12197 RVA: 0x00079E9C File Offset: 0x0007809C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.RoleEntityId != 0L)
			{
				num ^= this.RoleEntityId.GetHashCode();
			}
			if (this.IsShow)
			{
				num ^= this.IsShow.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002FA6 RID: 12198 RVA: 0x00079F0D File Offset: 0x0007810D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002FA7 RID: 12199 RVA: 0x00079F1A File Offset: 0x0007811A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002FA8 RID: 12200 RVA: 0x00079F24 File Offset: 0x00078124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleEntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.RoleEntityId);
			}
			if (this.IsShow)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.IsShow);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002FA9 RID: 12201 RVA: 0x00079F98 File Offset: 0x00078198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.RoleEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.RoleEntityId);
			}
			if (this.IsShow)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002FAA RID: 12202 RVA: 0x00079FFC File Offset: 0x000781FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BeControlledShowNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.RoleEntityId != 0L)
			{
				this.RoleEntityId = other.RoleEntityId;
			}
			if (other.IsShow)
			{
				this.IsShow = other.IsShow;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002FAB RID: 12203 RVA: 0x0007A060 File Offset: 0x00078260
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002FAC RID: 12204 RVA: 0x0007A06C File Offset: 0x0007826C
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
					if (num != 40U)
					{
						if (num != 56U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.EntityId = input.ReadInt64();
						}
					}
					else
					{
						this.IsShow = input.ReadBool();
					}
				}
				else
				{
					this.RoleEntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x040028BA RID: 10426
		private UnknownFieldSet _unknownFields;

		// Token: 0x040028BB RID: 10427
		public const int EntityIdFieldNumber = 7;

		// Token: 0x040028BC RID: 10428
		private long entityId_;

		// Token: 0x040028BD RID: 10429
		public const int RoleEntityIdFieldNumber = 1;

		// Token: 0x040028BE RID: 10430
		private long roleEntityId_;

		// Token: 0x040028BF RID: 10431
		public const int IsShowFieldNumber = 5;

		// Token: 0x040028C0 RID: 10432
		private bool isShow_;
	}
}
