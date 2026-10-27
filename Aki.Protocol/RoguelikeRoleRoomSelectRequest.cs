using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FB4 RID: 4020
	[NetMessage(EMessageId.RoguelikeRoleRoomSelectRequest)]
	public sealed class RoguelikeRoleRoomSelectRequest : IMessage<RoguelikeRoleRoomSelectRequest>, IMessage, IEquatable<RoguelikeRoleRoomSelectRequest>, IDeepCloneable<RoguelikeRoleRoomSelectRequest>, IBufferMessage
	{
		// Token: 0x060157ED RID: 88045 RVA: 0x0031ECF4 File Offset: 0x0031CEF4
		[NullableContext(1)]
		public static RoguelikeRoleRoomSelectRequest Create()
		{
			return new RoguelikeRoleRoomSelectRequest();
		}

		// Token: 0x170047AB RID: 18347
		// (get) Token: 0x060157EE RID: 88046 RVA: 0x0031ECFB File Offset: 0x0031CEFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170047AC RID: 18348
		// (get) Token: 0x060157EF RID: 88047 RVA: 0x0031ECFE File Offset: 0x0031CEFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeRoleRoomSelectRequest.Descriptor;
			}
		}

		// Token: 0x060157F0 RID: 88048 RVA: 0x0031ED05 File Offset: 0x0031CF05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeRoleRoomSelectRequest()
		{
		}

		// Token: 0x060157F1 RID: 88049 RVA: 0x0031ED0D File Offset: 0x0031CF0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeRoleRoomSelectRequest(RoguelikeRoleRoomSelectRequest other) : this()
		{
			this.index_ = other.index_;
			this.roleRoomId_ = other.roleRoomId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060157F2 RID: 88050 RVA: 0x0031ED3E File Offset: 0x0031CF3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeRoleRoomSelectRequest Clone()
		{
			return new RoguelikeRoleRoomSelectRequest(this);
		}

		// Token: 0x170047AD RID: 18349
		// (get) Token: 0x060157F3 RID: 88051 RVA: 0x0031ED46 File Offset: 0x0031CF46
		// (set) Token: 0x060157F4 RID: 88052 RVA: 0x0031ED4E File Offset: 0x0031CF4E
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

		// Token: 0x170047AE RID: 18350
		// (get) Token: 0x060157F5 RID: 88053 RVA: 0x0031ED57 File Offset: 0x0031CF57
		// (set) Token: 0x060157F6 RID: 88054 RVA: 0x0031ED5F File Offset: 0x0031CF5F
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

		// Token: 0x060157F7 RID: 88055 RVA: 0x0031ED68 File Offset: 0x0031CF68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeRoleRoomSelectRequest);
		}

		// Token: 0x060157F8 RID: 88056 RVA: 0x0031ED76 File Offset: 0x0031CF76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeRoleRoomSelectRequest other)
		{
			return other != null && (other == this || (this.Index == other.Index && this.RoleRoomId == other.RoleRoomId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060157F9 RID: 88057 RVA: 0x0031EDB4 File Offset: 0x0031CFB4
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

		// Token: 0x060157FA RID: 88058 RVA: 0x0031EE0C File Offset: 0x0031D00C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060157FB RID: 88059 RVA: 0x0031EE19 File Offset: 0x0031D019
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060157FC RID: 88060 RVA: 0x0031EE24 File Offset: 0x0031D024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleRoomId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.RoleRoomId);
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

		// Token: 0x060157FD RID: 88061 RVA: 0x0031EE80 File Offset: 0x0031D080
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

		// Token: 0x060157FE RID: 88062 RVA: 0x0031EED8 File Offset: 0x0031D0D8
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

		// Token: 0x060157FF RID: 88063 RVA: 0x0031EF28 File Offset: 0x0031D128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015800 RID: 88064 RVA: 0x0031EF34 File Offset: 0x0031D134
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
				if (num != 80U)
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
					this.RoleRoomId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400813A RID: 33082
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400813B RID: 33083
		public const int IndexFieldNumber = 12;

		// Token: 0x0400813C RID: 33084
		private int index_;

		// Token: 0x0400813D RID: 33085
		public const int RoleRoomIdFieldNumber = 10;

		// Token: 0x0400813E RID: 33086
		private int roleRoomId_;
	}
}
