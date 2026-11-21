using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200018D RID: 397
	[NetMessage(EMessageId.BeControlledNotify)]
	public sealed class BeControlledNotify : IMessage<BeControlledNotify>, IMessage, IEquatable<BeControlledNotify>, IDeepCloneable<BeControlledNotify>, IBufferMessage
	{
		// Token: 0x06002FBA RID: 12218 RVA: 0x0007A631 File Offset: 0x00078831
		[NullableContext(1)]
		public static BeControlledNotify Create()
		{
			return new BeControlledNotify();
		}

		// Token: 0x1700074F RID: 1871
		// (get) Token: 0x06002FBB RID: 12219 RVA: 0x0007A638 File Offset: 0x00078838
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000750 RID: 1872
		// (get) Token: 0x06002FBC RID: 12220 RVA: 0x0007A63B File Offset: 0x0007883B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BeControlledNotify.Descriptor;
			}
		}

		// Token: 0x06002FBD RID: 12221 RVA: 0x0007A642 File Offset: 0x00078842
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledNotify()
		{
		}

		// Token: 0x06002FBE RID: 12222 RVA: 0x0007A64A File Offset: 0x0007884A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledNotify(BeControlledNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.roleEntityId_ = other.roleEntityId_;
			this.needReset_ = other.needReset_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002FBF RID: 12223 RVA: 0x0007A687 File Offset: 0x00078887
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledNotify Clone()
		{
			return new BeControlledNotify(this);
		}

		// Token: 0x17000751 RID: 1873
		// (get) Token: 0x06002FC0 RID: 12224 RVA: 0x0007A68F File Offset: 0x0007888F
		// (set) Token: 0x06002FC1 RID: 12225 RVA: 0x0007A697 File Offset: 0x00078897
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

		// Token: 0x17000752 RID: 1874
		// (get) Token: 0x06002FC2 RID: 12226 RVA: 0x0007A6A0 File Offset: 0x000788A0
		// (set) Token: 0x06002FC3 RID: 12227 RVA: 0x0007A6A8 File Offset: 0x000788A8
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

		// Token: 0x17000753 RID: 1875
		// (get) Token: 0x06002FC4 RID: 12228 RVA: 0x0007A6B1 File Offset: 0x000788B1
		// (set) Token: 0x06002FC5 RID: 12229 RVA: 0x0007A6B9 File Offset: 0x000788B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool NeedReset
		{
			get
			{
				return this.needReset_;
			}
			set
			{
				this.needReset_ = value;
			}
		}

		// Token: 0x06002FC6 RID: 12230 RVA: 0x0007A6C2 File Offset: 0x000788C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BeControlledNotify);
		}

		// Token: 0x06002FC7 RID: 12231 RVA: 0x0007A6D0 File Offset: 0x000788D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BeControlledNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.RoleEntityId == other.RoleEntityId && this.NeedReset == other.NeedReset && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002FC8 RID: 12232 RVA: 0x0007A72C File Offset: 0x0007892C
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
			if (this.NeedReset)
			{
				num ^= this.NeedReset.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002FC9 RID: 12233 RVA: 0x0007A79D File Offset: 0x0007899D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002FCA RID: 12234 RVA: 0x0007A7AA File Offset: 0x000789AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002FCB RID: 12235 RVA: 0x0007A7B4 File Offset: 0x000789B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NeedReset)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.NeedReset);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.EntityId);
			}
			if (this.RoleEntityId != 0L)
			{
				output.WriteRawTag(72);
				output.WriteInt64(this.RoleEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002FCC RID: 12236 RVA: 0x0007A82C File Offset: 0x00078A2C
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
			if (this.NeedReset)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002FCD RID: 12237 RVA: 0x0007A890 File Offset: 0x00078A90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BeControlledNotify other)
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
			if (other.NeedReset)
			{
				this.NeedReset = other.NeedReset;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002FCE RID: 12238 RVA: 0x0007A8F4 File Offset: 0x00078AF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002FCF RID: 12239 RVA: 0x0007A900 File Offset: 0x00078B00
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
					if (num != 40U)
					{
						if (num != 72U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.RoleEntityId = input.ReadInt64();
						}
					}
					else
					{
						this.EntityId = input.ReadInt64();
					}
				}
				else
				{
					this.NeedReset = input.ReadBool();
				}
			}
		}

		// Token: 0x04002916 RID: 10518
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002917 RID: 10519
		public const int EntityIdFieldNumber = 5;

		// Token: 0x04002918 RID: 10520
		private long entityId_;

		// Token: 0x04002919 RID: 10521
		public const int RoleEntityIdFieldNumber = 9;

		// Token: 0x0400291A RID: 10522
		private long roleEntityId_;

		// Token: 0x0400291B RID: 10523
		public const int NeedResetFieldNumber = 2;

		// Token: 0x0400291C RID: 10524
		private bool needReset_;
	}
}
