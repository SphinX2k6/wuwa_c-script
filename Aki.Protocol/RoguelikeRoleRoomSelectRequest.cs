using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FA4 RID: 4004
	[NetMessage(EMessageId.RoguelikeRoleRoomSelectRequest)]
	public sealed class RoguelikeRoleRoomSelectRequest : IMessage<RoguelikeRoleRoomSelectRequest>, IMessage, IEquatable<RoguelikeRoleRoomSelectRequest>, IDeepCloneable<RoguelikeRoleRoomSelectRequest>, IBufferMessage
	{
		// Token: 0x06015708 RID: 87816 RVA: 0x0031D648 File Offset: 0x0031B848
		[NullableContext(1)]
		public static RoguelikeRoleRoomSelectRequest Create()
		{
			return new RoguelikeRoleRoomSelectRequest();
		}

		// Token: 0x17004781 RID: 18305
		// (get) Token: 0x06015709 RID: 87817 RVA: 0x0031D64F File Offset: 0x0031B84F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004782 RID: 18306
		// (get) Token: 0x0601570A RID: 87818 RVA: 0x0031D652 File Offset: 0x0031B852
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeRoleRoomSelectRequest.Descriptor;
			}
		}

		// Token: 0x0601570B RID: 87819 RVA: 0x0031D659 File Offset: 0x0031B859
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeRoleRoomSelectRequest()
		{
		}

		// Token: 0x0601570C RID: 87820 RVA: 0x0031D661 File Offset: 0x0031B861
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeRoleRoomSelectRequest(RoguelikeRoleRoomSelectRequest other) : this()
		{
			this.index_ = other.index_;
			this.roleRoomId_ = other.roleRoomId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601570D RID: 87821 RVA: 0x0031D692 File Offset: 0x0031B892
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeRoleRoomSelectRequest Clone()
		{
			return new RoguelikeRoleRoomSelectRequest(this);
		}

		// Token: 0x17004783 RID: 18307
		// (get) Token: 0x0601570E RID: 87822 RVA: 0x0031D69A File Offset: 0x0031B89A
		// (set) Token: 0x0601570F RID: 87823 RVA: 0x0031D6A2 File Offset: 0x0031B8A2
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

		// Token: 0x17004784 RID: 18308
		// (get) Token: 0x06015710 RID: 87824 RVA: 0x0031D6AB File Offset: 0x0031B8AB
		// (set) Token: 0x06015711 RID: 87825 RVA: 0x0031D6B3 File Offset: 0x0031B8B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleRoomId
		{
			get
			{
				return this.roleRoomId_;
			}
			set
			{
				this.roleRoomId_ = value;
			}
		}

		// Token: 0x06015712 RID: 87826 RVA: 0x0031D6BC File Offset: 0x0031B8BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeRoleRoomSelectRequest);
		}

		// Token: 0x06015713 RID: 87827 RVA: 0x0031D6CA File Offset: 0x0031B8CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeRoleRoomSelectRequest other)
		{
			return other != null && (other == this || (this.Index == other.Index && this.RoleRoomId == other.RoleRoomId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015714 RID: 87828 RVA: 0x0031D708 File Offset: 0x0031B908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this.RoleRoomId != 0)
			{
				num ^= this.RoleRoomId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015715 RID: 87829 RVA: 0x0031D760 File Offset: 0x0031B960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015716 RID: 87830 RVA: 0x0031D76D File Offset: 0x0031B96D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015717 RID: 87831 RVA: 0x0031D778 File Offset: 0x0031B978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleRoomId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoleRoomId);
			}
			if (this.Index != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.Index);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015718 RID: 87832 RVA: 0x0031D7D0 File Offset: 0x0031B9D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this.RoleRoomId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleRoomId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015719 RID: 87833 RVA: 0x0031D828 File Offset: 0x0031BA28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeRoleRoomSelectRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			if (other.RoleRoomId != 0)
			{
				this.RoleRoomId = other.RoleRoomId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601571A RID: 87834 RVA: 0x0031D878 File Offset: 0x0031BA78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601571B RID: 87835 RVA: 0x0031D884 File Offset: 0x0031BA84
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
					if (num != 72U)
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
					this.RoleRoomId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008164 RID: 33124
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008165 RID: 33125
		public const int IndexFieldNumber = 9;

		// Token: 0x04008166 RID: 33126
		private int index_;

		// Token: 0x04008167 RID: 33127
		public const int RoleRoomIdFieldNumber = 1;

		// Token: 0x04008168 RID: 33128
		private int roleRoomId_;
	}
}
