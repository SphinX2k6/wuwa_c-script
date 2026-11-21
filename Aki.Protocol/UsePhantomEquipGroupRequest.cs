using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001529 RID: 5417
	[NetMessage(EMessageId.UsePhantomEquipGroupRequest)]
	public sealed class UsePhantomEquipGroupRequest : IMessage<UsePhantomEquipGroupRequest>, IMessage, IEquatable<UsePhantomEquipGroupRequest>, IDeepCloneable<UsePhantomEquipGroupRequest>, IBufferMessage
	{
		// Token: 0x0601CB22 RID: 117538 RVA: 0x004287DF File Offset: 0x004269DF
		[NullableContext(1)]
		public static UsePhantomEquipGroupRequest Create()
		{
			return new UsePhantomEquipGroupRequest();
		}

		// Token: 0x17006110 RID: 24848
		// (get) Token: 0x0601CB23 RID: 117539 RVA: 0x004287E6 File Offset: 0x004269E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006111 RID: 24849
		// (get) Token: 0x0601CB24 RID: 117540 RVA: 0x004287E9 File Offset: 0x004269E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UsePhantomEquipGroupRequest.Descriptor;
			}
		}

		// Token: 0x0601CB25 RID: 117541 RVA: 0x004287F0 File Offset: 0x004269F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UsePhantomEquipGroupRequest()
		{
		}

		// Token: 0x0601CB26 RID: 117542 RVA: 0x004287F8 File Offset: 0x004269F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UsePhantomEquipGroupRequest(UsePhantomEquipGroupRequest other) : this()
		{
			this.index_ = other.index_;
			this.roleId_ = other.roleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CB27 RID: 117543 RVA: 0x00428829 File Offset: 0x00426A29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UsePhantomEquipGroupRequest Clone()
		{
			return new UsePhantomEquipGroupRequest(this);
		}

		// Token: 0x17006112 RID: 24850
		// (get) Token: 0x0601CB28 RID: 117544 RVA: 0x00428831 File Offset: 0x00426A31
		// (set) Token: 0x0601CB29 RID: 117545 RVA: 0x00428839 File Offset: 0x00426A39
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

		// Token: 0x17006113 RID: 24851
		// (get) Token: 0x0601CB2A RID: 117546 RVA: 0x00428842 File Offset: 0x00426A42
		// (set) Token: 0x0601CB2B RID: 117547 RVA: 0x0042884A File Offset: 0x00426A4A
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

		// Token: 0x0601CB2C RID: 117548 RVA: 0x00428853 File Offset: 0x00426A53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UsePhantomEquipGroupRequest);
		}

		// Token: 0x0601CB2D RID: 117549 RVA: 0x00428861 File Offset: 0x00426A61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UsePhantomEquipGroupRequest other)
		{
			return other != null && (other == this || (this.Index == other.Index && this.RoleId == other.RoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CB2E RID: 117550 RVA: 0x004288A0 File Offset: 0x00426AA0
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

		// Token: 0x0601CB2F RID: 117551 RVA: 0x004288F8 File Offset: 0x00426AF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CB30 RID: 117552 RVA: 0x00428905 File Offset: 0x00426B05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CB31 RID: 117553 RVA: 0x00428910 File Offset: 0x00426B10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.RoleId);
			}
			if (this.Index != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.Index);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CB32 RID: 117554 RVA: 0x0042896C File Offset: 0x00426B6C
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

		// Token: 0x0601CB33 RID: 117555 RVA: 0x004289C4 File Offset: 0x00426BC4
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

		// Token: 0x0601CB34 RID: 117556 RVA: 0x00428A14 File Offset: 0x00426C14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CB35 RID: 117557 RVA: 0x00428A20 File Offset: 0x00426C20
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
				if (num != 56U)
				{
					if (num != 96U)
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

		// Token: 0x0400A545 RID: 42309
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A546 RID: 42310
		public const int IndexFieldNumber = 12;

		// Token: 0x0400A547 RID: 42311
		private int index_;

		// Token: 0x0400A548 RID: 42312
		public const int RoleIdFieldNumber = 7;

		// Token: 0x0400A549 RID: 42313
		private int roleId_;
	}
}
