using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000634 RID: 1588
	[NetMessage(EMessageId.FormationSwitchRoleRequest)]
	public sealed class FormationSwitchRoleRequest : IMessage<FormationSwitchRoleRequest>, IMessage, IEquatable<FormationSwitchRoleRequest>, IDeepCloneable<FormationSwitchRoleRequest>, IBufferMessage
	{
		// Token: 0x0600925E RID: 37470 RVA: 0x001621DF File Offset: 0x001603DF
		[NullableContext(1)]
		public static FormationSwitchRoleRequest Create()
		{
			return new FormationSwitchRoleRequest();
		}

		// Token: 0x17001D1E RID: 7454
		// (get) Token: 0x0600925F RID: 37471 RVA: 0x001621E6 File Offset: 0x001603E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D1F RID: 7455
		// (get) Token: 0x06009260 RID: 37472 RVA: 0x001621E9 File Offset: 0x001603E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FormationSwitchRoleRequest.Descriptor;
			}
		}

		// Token: 0x06009261 RID: 37473 RVA: 0x001621F0 File Offset: 0x001603F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationSwitchRoleRequest()
		{
		}

		// Token: 0x06009262 RID: 37474 RVA: 0x001621F8 File Offset: 0x001603F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationSwitchRoleRequest(FormationSwitchRoleRequest other) : this()
		{
			this.roleIndex_ = other.roleIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009263 RID: 37475 RVA: 0x0016221D File Offset: 0x0016041D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationSwitchRoleRequest Clone()
		{
			return new FormationSwitchRoleRequest(this);
		}

		// Token: 0x17001D20 RID: 7456
		// (get) Token: 0x06009264 RID: 37476 RVA: 0x00162225 File Offset: 0x00160425
		// (set) Token: 0x06009265 RID: 37477 RVA: 0x0016222D File Offset: 0x0016042D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleIndex
		{
			get
			{
				return this.roleIndex_;
			}
			set
			{
				this.roleIndex_ = value;
			}
		}

		// Token: 0x06009266 RID: 37478 RVA: 0x00162236 File Offset: 0x00160436
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FormationSwitchRoleRequest);
		}

		// Token: 0x06009267 RID: 37479 RVA: 0x00162244 File Offset: 0x00160444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FormationSwitchRoleRequest other)
		{
			return other != null && (other == this || (this.RoleIndex == other.RoleIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009268 RID: 37480 RVA: 0x00162274 File Offset: 0x00160474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleIndex != 0)
			{
				num ^= this.RoleIndex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009269 RID: 37481 RVA: 0x001622B3 File Offset: 0x001604B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600926A RID: 37482 RVA: 0x001622C0 File Offset: 0x001604C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600926B RID: 37483 RVA: 0x001622C9 File Offset: 0x001604C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleIndex != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.RoleIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600926C RID: 37484 RVA: 0x001622FC File Offset: 0x001604FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleIndex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600926D RID: 37485 RVA: 0x0016233A File Offset: 0x0016053A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FormationSwitchRoleRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleIndex != 0)
			{
				this.RoleIndex = other.RoleIndex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600926E RID: 37486 RVA: 0x0016236B File Offset: 0x0016056B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600926F RID: 37487 RVA: 0x00162374 File Offset: 0x00160574
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.RoleIndex = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004692 RID: 18066
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004693 RID: 18067
		public const int RoleIndexFieldNumber = 13;

		// Token: 0x04004694 RID: 18068
		private int roleIndex_;
	}
}
