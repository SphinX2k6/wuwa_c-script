using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003A8 RID: 936
	[NetMessage(EMessageId.DeletePhantomEquipGroupRequest)]
	public sealed class DeletePhantomEquipGroupRequest : IMessage<DeletePhantomEquipGroupRequest>, IMessage, IEquatable<DeletePhantomEquipGroupRequest>, IDeepCloneable<DeletePhantomEquipGroupRequest>, IBufferMessage
	{
		// Token: 0x06005C4B RID: 23627 RVA: 0x000E06ED File Offset: 0x000DE8ED
		[NullableContext(1)]
		public static DeletePhantomEquipGroupRequest Create()
		{
			return new DeletePhantomEquipGroupRequest();
		}

		// Token: 0x17001119 RID: 4377
		// (get) Token: 0x06005C4C RID: 23628 RVA: 0x000E06F4 File Offset: 0x000DE8F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700111A RID: 4378
		// (get) Token: 0x06005C4D RID: 23629 RVA: 0x000E06F7 File Offset: 0x000DE8F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DeletePhantomEquipGroupRequest.Descriptor;
			}
		}

		// Token: 0x06005C4E RID: 23630 RVA: 0x000E06FE File Offset: 0x000DE8FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeletePhantomEquipGroupRequest()
		{
		}

		// Token: 0x06005C4F RID: 23631 RVA: 0x000E0706 File Offset: 0x000DE906
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeletePhantomEquipGroupRequest(DeletePhantomEquipGroupRequest other) : this()
		{
			this.index_ = other.index_;
			this.roleId_ = other.roleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005C50 RID: 23632 RVA: 0x000E0737 File Offset: 0x000DE937
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeletePhantomEquipGroupRequest Clone()
		{
			return new DeletePhantomEquipGroupRequest(this);
		}

		// Token: 0x1700111B RID: 4379
		// (get) Token: 0x06005C51 RID: 23633 RVA: 0x000E073F File Offset: 0x000DE93F
		// (set) Token: 0x06005C52 RID: 23634 RVA: 0x000E0747 File Offset: 0x000DE947
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x1700111C RID: 4380
		// (get) Token: 0x06005C53 RID: 23635 RVA: 0x000E0750 File Offset: 0x000DE950
		// (set) Token: 0x06005C54 RID: 23636 RVA: 0x000E0758 File Offset: 0x000DE958
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

		// Token: 0x06005C55 RID: 23637 RVA: 0x000E0761 File Offset: 0x000DE961
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DeletePhantomEquipGroupRequest);
		}

		// Token: 0x06005C56 RID: 23638 RVA: 0x000E076F File Offset: 0x000DE96F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DeletePhantomEquipGroupRequest other)
		{
			return other != null && (other == this || (this.Index == other.Index && this.RoleId == other.RoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005C57 RID: 23639 RVA: 0x000E07B0 File Offset: 0x000DE9B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005C58 RID: 23640 RVA: 0x000E0808 File Offset: 0x000DEA08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005C59 RID: 23641 RVA: 0x000E0815 File Offset: 0x000DEA15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005C5A RID: 23642 RVA: 0x000E0820 File Offset: 0x000DEA20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.RoleId);
			}
			if (this.Index != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.Index);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005C5B RID: 23643 RVA: 0x000E087C File Offset: 0x000DEA7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005C5C RID: 23644 RVA: 0x000E08D4 File Offset: 0x000DEAD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DeletePhantomEquipGroupRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005C5D RID: 23645 RVA: 0x000E0924 File Offset: 0x000DEB24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005C5E RID: 23646 RVA: 0x000E0930 File Offset: 0x000DEB30
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
				if (num != 48U)
				{
					if (num != 56U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Index = input.ReadInt32();
					}
				}
				else
				{
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003693 RID: 13971
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003694 RID: 13972
		public const int IndexFieldNumber = 7;

		// Token: 0x04003695 RID: 13973
		private int index_;

		// Token: 0x04003696 RID: 13974
		public const int RoleIdFieldNumber = 6;

		// Token: 0x04003697 RID: 13975
		private int roleId_;
	}
}
