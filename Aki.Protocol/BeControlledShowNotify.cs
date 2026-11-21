using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000191 RID: 401
	[NetMessage(EMessageId.BeControlledShowNotify)]
	public sealed class BeControlledShowNotify : IMessage<BeControlledShowNotify>, IMessage, IEquatable<BeControlledShowNotify>, IDeepCloneable<BeControlledShowNotify>, IBufferMessage
	{
		// Token: 0x0600300E RID: 12302 RVA: 0x0007B1D5 File Offset: 0x000793D5
		[NullableContext(1)]
		public static BeControlledShowNotify Create()
		{
			return new BeControlledShowNotify();
		}

		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x0600300F RID: 12303 RVA: 0x0007B1DC File Offset: 0x000793DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x06003010 RID: 12304 RVA: 0x0007B1DF File Offset: 0x000793DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BeControlledShowNotify.Descriptor;
			}
		}

		// Token: 0x06003011 RID: 12305 RVA: 0x0007B1E6 File Offset: 0x000793E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledShowNotify()
		{
		}

		// Token: 0x06003012 RID: 12306 RVA: 0x0007B1EE File Offset: 0x000793EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledShowNotify(BeControlledShowNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.roleEntityId_ = other.roleEntityId_;
			this.isShow_ = other.isShow_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003013 RID: 12307 RVA: 0x0007B22B File Offset: 0x0007942B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledShowNotify Clone()
		{
			return new BeControlledShowNotify(this);
		}

		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x06003014 RID: 12308 RVA: 0x0007B233 File Offset: 0x00079433
		// (set) Token: 0x06003015 RID: 12309 RVA: 0x0007B23B File Offset: 0x0007943B
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

		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x06003016 RID: 12310 RVA: 0x0007B244 File Offset: 0x00079444
		// (set) Token: 0x06003017 RID: 12311 RVA: 0x0007B24C File Offset: 0x0007944C
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

		// Token: 0x17000765 RID: 1893
		// (get) Token: 0x06003018 RID: 12312 RVA: 0x0007B255 File Offset: 0x00079455
		// (set) Token: 0x06003019 RID: 12313 RVA: 0x0007B25D File Offset: 0x0007945D
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

		// Token: 0x0600301A RID: 12314 RVA: 0x0007B266 File Offset: 0x00079466
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BeControlledShowNotify);
		}

		// Token: 0x0600301B RID: 12315 RVA: 0x0007B274 File Offset: 0x00079474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BeControlledShowNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.RoleEntityId == other.RoleEntityId && this.IsShow == other.IsShow && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600301C RID: 12316 RVA: 0x0007B2D0 File Offset: 0x000794D0
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

		// Token: 0x0600301D RID: 12317 RVA: 0x0007B341 File Offset: 0x00079541
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600301E RID: 12318 RVA: 0x0007B34E File Offset: 0x0007954E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600301F RID: 12319 RVA: 0x0007B358 File Offset: 0x00079558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleEntityId != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.RoleEntityId);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.EntityId);
			}
			if (this.IsShow)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.IsShow);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003020 RID: 12320 RVA: 0x0007B3D0 File Offset: 0x000795D0
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

		// Token: 0x06003021 RID: 12321 RVA: 0x0007B434 File Offset: 0x00079634
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

		// Token: 0x06003022 RID: 12322 RVA: 0x0007B498 File Offset: 0x00079698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003023 RID: 12323 RVA: 0x0007B4A4 File Offset: 0x000796A4
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
				if (num != 24U)
				{
					if (num != 64U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.IsShow = input.ReadBool();
						}
					}
					else
					{
						this.EntityId = input.ReadInt64();
					}
				}
				else
				{
					this.RoleEntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400292E RID: 10542
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400292F RID: 10543
		public const int EntityIdFieldNumber = 8;

		// Token: 0x04002930 RID: 10544
		private long entityId_;

		// Token: 0x04002931 RID: 10545
		public const int RoleEntityIdFieldNumber = 3;

		// Token: 0x04002932 RID: 10546
		private long roleEntityId_;

		// Token: 0x04002933 RID: 10547
		public const int IsShowFieldNumber = 15;

		// Token: 0x04002934 RID: 10548
		private bool isShow_;
	}
}
