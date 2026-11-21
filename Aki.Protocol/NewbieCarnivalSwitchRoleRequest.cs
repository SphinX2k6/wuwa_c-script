using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AF2 RID: 2802
	[NetMessage(EMessageId.NewbieCarnivalSwitchRoleRequest)]
	public sealed class NewbieCarnivalSwitchRoleRequest : IMessage<NewbieCarnivalSwitchRoleRequest>, IMessage, IEquatable<NewbieCarnivalSwitchRoleRequest>, IDeepCloneable<NewbieCarnivalSwitchRoleRequest>, IBufferMessage
	{
		// Token: 0x0600F3EB RID: 62443 RVA: 0x0023A187 File Offset: 0x00238387
		[NullableContext(1)]
		public static NewbieCarnivalSwitchRoleRequest Create()
		{
			return new NewbieCarnivalSwitchRoleRequest();
		}

		// Token: 0x170031AC RID: 12716
		// (get) Token: 0x0600F3EC RID: 62444 RVA: 0x0023A18E File Offset: 0x0023838E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170031AD RID: 12717
		// (get) Token: 0x0600F3ED RID: 62445 RVA: 0x0023A191 File Offset: 0x00238391
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewbieCarnivalSwitchRoleRequest.Descriptor;
			}
		}

		// Token: 0x0600F3EE RID: 62446 RVA: 0x0023A198 File Offset: 0x00238398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieCarnivalSwitchRoleRequest()
		{
		}

		// Token: 0x0600F3EF RID: 62447 RVA: 0x0023A1A0 File Offset: 0x002383A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieCarnivalSwitchRoleRequest(NewbieCarnivalSwitchRoleRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.roleId_ = other.roleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F3F0 RID: 62448 RVA: 0x0023A1D1 File Offset: 0x002383D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieCarnivalSwitchRoleRequest Clone()
		{
			return new NewbieCarnivalSwitchRoleRequest(this);
		}

		// Token: 0x170031AE RID: 12718
		// (get) Token: 0x0600F3F1 RID: 62449 RVA: 0x0023A1D9 File Offset: 0x002383D9
		// (set) Token: 0x0600F3F2 RID: 62450 RVA: 0x0023A1E1 File Offset: 0x002383E1
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

		// Token: 0x170031AF RID: 12719
		// (get) Token: 0x0600F3F3 RID: 62451 RVA: 0x0023A1EA File Offset: 0x002383EA
		// (set) Token: 0x0600F3F4 RID: 62452 RVA: 0x0023A1F2 File Offset: 0x002383F2
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

		// Token: 0x0600F3F5 RID: 62453 RVA: 0x0023A1FB File Offset: 0x002383FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewbieCarnivalSwitchRoleRequest);
		}

		// Token: 0x0600F3F6 RID: 62454 RVA: 0x0023A209 File Offset: 0x00238409
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewbieCarnivalSwitchRoleRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.RoleId == other.RoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F3F7 RID: 62455 RVA: 0x0023A248 File Offset: 0x00238448
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

		// Token: 0x0600F3F8 RID: 62456 RVA: 0x0023A2A0 File Offset: 0x002384A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F3F9 RID: 62457 RVA: 0x0023A2AD File Offset: 0x002384AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F3FA RID: 62458 RVA: 0x0023A2B8 File Offset: 0x002384B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.ActivityId);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F3FB RID: 62459 RVA: 0x0023A314 File Offset: 0x00238514
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

		// Token: 0x0600F3FC RID: 62460 RVA: 0x0023A36C File Offset: 0x0023856C
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

		// Token: 0x0600F3FD RID: 62461 RVA: 0x0023A3BC File Offset: 0x002385BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F3FE RID: 62462 RVA: 0x0023A3C8 File Offset: 0x002385C8
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
				if (num != 40U)
				{
					if (num != 72U)
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

		// Token: 0x040062A3 RID: 25251
		private UnknownFieldSet _unknownFields;

		// Token: 0x040062A4 RID: 25252
		public const int ActivityIdFieldNumber = 5;

		// Token: 0x040062A5 RID: 25253
		private int activityId_;

		// Token: 0x040062A6 RID: 25254
		public const int RoleIdFieldNumber = 9;

		// Token: 0x040062A7 RID: 25255
		private int roleId_;
	}
}
