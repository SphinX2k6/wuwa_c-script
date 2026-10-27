using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014B3 RID: 5299
	[NetMessage(EMessageId.UsePhantomEquipGroupRequest)]
	public sealed class UsePhantomEquipGroupRequest : IMessage<UsePhantomEquipGroupRequest>, IMessage, IEquatable<UsePhantomEquipGroupRequest>, IDeepCloneable<UsePhantomEquipGroupRequest>, IBufferMessage
	{
		// Token: 0x0601C05B RID: 114779 RVA: 0x0040CD27 File Offset: 0x0040AF27
		[NullableContext(1)]
		public static UsePhantomEquipGroupRequest Create()
		{
			return new UsePhantomEquipGroupRequest();
		}

		// Token: 0x17005E6F RID: 24175
		// (get) Token: 0x0601C05C RID: 114780 RVA: 0x0040CD2E File Offset: 0x0040AF2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005E70 RID: 24176
		// (get) Token: 0x0601C05D RID: 114781 RVA: 0x0040CD31 File Offset: 0x0040AF31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UsePhantomEquipGroupRequest.Descriptor;
			}
		}

		// Token: 0x0601C05E RID: 114782 RVA: 0x0040CD38 File Offset: 0x0040AF38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UsePhantomEquipGroupRequest()
		{
		}

		// Token: 0x0601C05F RID: 114783 RVA: 0x0040CD40 File Offset: 0x0040AF40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UsePhantomEquipGroupRequest(UsePhantomEquipGroupRequest other) : this()
		{
			this.index_ = other.index_;
			this.roleId_ = other.roleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C060 RID: 114784 RVA: 0x0040CD71 File Offset: 0x0040AF71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UsePhantomEquipGroupRequest Clone()
		{
			return new UsePhantomEquipGroupRequest(this);
		}

		// Token: 0x17005E71 RID: 24177
		// (get) Token: 0x0601C061 RID: 114785 RVA: 0x0040CD79 File Offset: 0x0040AF79
		// (set) Token: 0x0601C062 RID: 114786 RVA: 0x0040CD81 File Offset: 0x0040AF81
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

		// Token: 0x17005E72 RID: 24178
		// (get) Token: 0x0601C063 RID: 114787 RVA: 0x0040CD8A File Offset: 0x0040AF8A
		// (set) Token: 0x0601C064 RID: 114788 RVA: 0x0040CD92 File Offset: 0x0040AF92
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

		// Token: 0x0601C065 RID: 114789 RVA: 0x0040CD9B File Offset: 0x0040AF9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UsePhantomEquipGroupRequest);
		}

		// Token: 0x0601C066 RID: 114790 RVA: 0x0040CDA9 File Offset: 0x0040AFA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UsePhantomEquipGroupRequest other)
		{
			return other != null && (other == this || (this.Index == other.Index && this.RoleId == other.RoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C067 RID: 114791 RVA: 0x0040CDE8 File Offset: 0x0040AFE8
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

		// Token: 0x0601C068 RID: 114792 RVA: 0x0040CE40 File Offset: 0x0040B040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C069 RID: 114793 RVA: 0x0040CE4D File Offset: 0x0040B04D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C06A RID: 114794 RVA: 0x0040CE58 File Offset: 0x0040B058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Index != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Index);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C06B RID: 114795 RVA: 0x0040CEB4 File Offset: 0x0040B0B4
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

		// Token: 0x0601C06C RID: 114796 RVA: 0x0040CF0C File Offset: 0x0040B10C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UsePhantomEquipGroupRequest other)
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

		// Token: 0x0601C06D RID: 114797 RVA: 0x0040CF5C File Offset: 0x0040B15C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C06E RID: 114798 RVA: 0x0040CF68 File Offset: 0x0040B168
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
				if (num != 32U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.RoleId = input.ReadInt32();
					}
				}
				else
				{
					this.Index = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A0EC RID: 41196
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A0ED RID: 41197
		public const int IndexFieldNumber = 4;

		// Token: 0x0400A0EE RID: 41198
		private int index_;

		// Token: 0x0400A0EF RID: 41199
		public const int RoleIdFieldNumber = 12;

		// Token: 0x0400A0F0 RID: 41200
		private int roleId_;
	}
}
