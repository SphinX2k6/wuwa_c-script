using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B03 RID: 2819
	[NetMessage(EMessageId.NewbieCarnivalSwitchRoleRequest)]
	public sealed class NewbieCarnivalSwitchRoleRequest : IMessage<NewbieCarnivalSwitchRoleRequest>, IMessage, IEquatable<NewbieCarnivalSwitchRoleRequest>, IDeepCloneable<NewbieCarnivalSwitchRoleRequest>, IBufferMessage
	{
		// Token: 0x0600F505 RID: 62725 RVA: 0x0023C393 File Offset: 0x0023A593
		[NullableContext(1)]
		public static NewbieCarnivalSwitchRoleRequest Create()
		{
			return new NewbieCarnivalSwitchRoleRequest();
		}

		// Token: 0x170031EA RID: 12778
		// (get) Token: 0x0600F506 RID: 62726 RVA: 0x0023C39A File Offset: 0x0023A59A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170031EB RID: 12779
		// (get) Token: 0x0600F507 RID: 62727 RVA: 0x0023C39D File Offset: 0x0023A59D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewbieCarnivalSwitchRoleRequest.Descriptor;
			}
		}

		// Token: 0x0600F508 RID: 62728 RVA: 0x0023C3A4 File Offset: 0x0023A5A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieCarnivalSwitchRoleRequest()
		{
		}

		// Token: 0x0600F509 RID: 62729 RVA: 0x0023C3AC File Offset: 0x0023A5AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieCarnivalSwitchRoleRequest(NewbieCarnivalSwitchRoleRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.roleId_ = other.roleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F50A RID: 62730 RVA: 0x0023C3DD File Offset: 0x0023A5DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieCarnivalSwitchRoleRequest Clone()
		{
			return new NewbieCarnivalSwitchRoleRequest(this);
		}

		// Token: 0x170031EC RID: 12780
		// (get) Token: 0x0600F50B RID: 62731 RVA: 0x0023C3E5 File Offset: 0x0023A5E5
		// (set) Token: 0x0600F50C RID: 62732 RVA: 0x0023C3ED File Offset: 0x0023A5ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x170031ED RID: 12781
		// (get) Token: 0x0600F50D RID: 62733 RVA: 0x0023C3F6 File Offset: 0x0023A5F6
		// (set) Token: 0x0600F50E RID: 62734 RVA: 0x0023C3FE File Offset: 0x0023A5FE
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

		// Token: 0x0600F50F RID: 62735 RVA: 0x0023C407 File Offset: 0x0023A607
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewbieCarnivalSwitchRoleRequest);
		}

		// Token: 0x0600F510 RID: 62736 RVA: 0x0023C415 File Offset: 0x0023A615
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewbieCarnivalSwitchRoleRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.RoleId == other.RoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F511 RID: 62737 RVA: 0x0023C454 File Offset: 0x0023A654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
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

		// Token: 0x0600F512 RID: 62738 RVA: 0x0023C4AC File Offset: 0x0023A6AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F513 RID: 62739 RVA: 0x0023C4B9 File Offset: 0x0023A6B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F514 RID: 62740 RVA: 0x0023C4C4 File Offset: 0x0023A6C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.ActivityId);
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

		// Token: 0x0600F515 RID: 62741 RVA: 0x0023C520 File Offset: 0x0023A720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
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

		// Token: 0x0600F516 RID: 62742 RVA: 0x0023C578 File Offset: 0x0023A778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewbieCarnivalSwitchRoleRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F517 RID: 62743 RVA: 0x0023C5C8 File Offset: 0x0023A7C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F518 RID: 62744 RVA: 0x0023C5D4 File Offset: 0x0023A7D4
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
				if (num != 64U)
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
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400629A RID: 25242
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400629B RID: 25243
		public const int ActivityIdFieldNumber = 8;

		// Token: 0x0400629C RID: 25244
		private int activityId_;

		// Token: 0x0400629D RID: 25245
		public const int RoleIdFieldNumber = 12;

		// Token: 0x0400629E RID: 25246
		private int roleId_;
	}
}
