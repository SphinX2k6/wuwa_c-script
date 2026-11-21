using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014DA RID: 5338
	[NetMessage(EMessageId.TrialRoleRewardRequest)]
	public sealed class TrialRoleRewardRequest : IMessage<TrialRoleRewardRequest>, IMessage, IEquatable<TrialRoleRewardRequest>, IDeepCloneable<TrialRoleRewardRequest>, IBufferMessage
	{
		// Token: 0x0601C50A RID: 115978 RVA: 0x0041C0BB File Offset: 0x0041A2BB
		[NullableContext(1)]
		public static TrialRoleRewardRequest Create()
		{
			return new TrialRoleRewardRequest();
		}

		// Token: 0x17005FDC RID: 24540
		// (get) Token: 0x0601C50B RID: 115979 RVA: 0x0041C0C2 File Offset: 0x0041A2C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005FDD RID: 24541
		// (get) Token: 0x0601C50C RID: 115980 RVA: 0x0041C0C5 File Offset: 0x0041A2C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrialRoleRewardRequest.Descriptor;
			}
		}

		// Token: 0x0601C50D RID: 115981 RVA: 0x0041C0CC File Offset: 0x0041A2CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrialRoleRewardRequest()
		{
		}

		// Token: 0x0601C50E RID: 115982 RVA: 0x0041C0D4 File Offset: 0x0041A2D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrialRoleRewardRequest(TrialRoleRewardRequest other) : this()
		{
			this.roleId_ = other.roleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C50F RID: 115983 RVA: 0x0041C0F9 File Offset: 0x0041A2F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrialRoleRewardRequest Clone()
		{
			return new TrialRoleRewardRequest(this);
		}

		// Token: 0x17005FDE RID: 24542
		// (get) Token: 0x0601C510 RID: 115984 RVA: 0x0041C101 File Offset: 0x0041A301
		// (set) Token: 0x0601C511 RID: 115985 RVA: 0x0041C109 File Offset: 0x0041A309
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

		// Token: 0x0601C512 RID: 115986 RVA: 0x0041C112 File Offset: 0x0041A312
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrialRoleRewardRequest);
		}

		// Token: 0x0601C513 RID: 115987 RVA: 0x0041C120 File Offset: 0x0041A320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrialRoleRewardRequest other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C514 RID: 115988 RVA: 0x0041C150 File Offset: 0x0041A350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x0601C515 RID: 115989 RVA: 0x0041C18F File Offset: 0x0041A38F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C516 RID: 115990 RVA: 0x0041C19C File Offset: 0x0041A39C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C517 RID: 115991 RVA: 0x0041C1A5 File Offset: 0x0041A3A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C518 RID: 115992 RVA: 0x0041C1D8 File Offset: 0x0041A3D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x0601C519 RID: 115993 RVA: 0x0041C216 File Offset: 0x0041A416
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrialRoleRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C51A RID: 115994 RVA: 0x0041C247 File Offset: 0x0041A447
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C51B RID: 115995 RVA: 0x0041C250 File Offset: 0x0041A450
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A3B0 RID: 41904
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A3B1 RID: 41905
		public const int RoleIdFieldNumber = 10;

		// Token: 0x0400A3B2 RID: 41906
		private int roleId_;
	}
}
