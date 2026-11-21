using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004C0 RID: 1216
	[NetMessage(EMessageId.EquipSkinUnLoadRequest)]
	public sealed class EquipSkinUnLoadRequest : IMessage<EquipSkinUnLoadRequest>, IMessage, IEquatable<EquipSkinUnLoadRequest>, IDeepCloneable<EquipSkinUnLoadRequest>, IBufferMessage
	{
		// Token: 0x0600740A RID: 29706 RVA: 0x0011CC98 File Offset: 0x0011AE98
		[NullableContext(1)]
		public static EquipSkinUnLoadRequest Create()
		{
			return new EquipSkinUnLoadRequest();
		}

		// Token: 0x17001679 RID: 5753
		// (get) Token: 0x0600740B RID: 29707 RVA: 0x0011CC9F File Offset: 0x0011AE9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700167A RID: 5754
		// (get) Token: 0x0600740C RID: 29708 RVA: 0x0011CCA2 File Offset: 0x0011AEA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EquipSkinUnLoadRequest.Descriptor;
			}
		}

		// Token: 0x0600740D RID: 29709 RVA: 0x0011CCA9 File Offset: 0x0011AEA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EquipSkinUnLoadRequest()
		{
		}

		// Token: 0x0600740E RID: 29710 RVA: 0x0011CCB1 File Offset: 0x0011AEB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EquipSkinUnLoadRequest(EquipSkinUnLoadRequest other) : this()
		{
			this.roleID_ = other.roleID_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600740F RID: 29711 RVA: 0x0011CCD6 File Offset: 0x0011AED6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EquipSkinUnLoadRequest Clone()
		{
			return new EquipSkinUnLoadRequest(this);
		}

		// Token: 0x1700167B RID: 5755
		// (get) Token: 0x06007410 RID: 29712 RVA: 0x0011CCDE File Offset: 0x0011AEDE
		// (set) Token: 0x06007411 RID: 29713 RVA: 0x0011CCE6 File Offset: 0x0011AEE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleID
		{
			get
			{
				return this.roleID_;
			}
			set
			{
				this.roleID_ = value;
			}
		}

		// Token: 0x06007412 RID: 29714 RVA: 0x0011CCEF File Offset: 0x0011AEEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EquipSkinUnLoadRequest);
		}

		// Token: 0x06007413 RID: 29715 RVA: 0x0011CCFD File Offset: 0x0011AEFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EquipSkinUnLoadRequest other)
		{
			return other != null && (other == this || (this.RoleID == other.RoleID && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007414 RID: 29716 RVA: 0x0011CD2C File Offset: 0x0011AF2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleID != 0)
			{
				num ^= this.RoleID.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007415 RID: 29717 RVA: 0x0011CD6B File Offset: 0x0011AF6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007416 RID: 29718 RVA: 0x0011CD78 File Offset: 0x0011AF78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007417 RID: 29719 RVA: 0x0011CD81 File Offset: 0x0011AF81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleID != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.RoleID);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007418 RID: 29720 RVA: 0x0011CDB4 File Offset: 0x0011AFB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleID != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleID);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007419 RID: 29721 RVA: 0x0011CDF2 File Offset: 0x0011AFF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EquipSkinUnLoadRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleID != 0)
			{
				this.RoleID = other.RoleID;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600741A RID: 29722 RVA: 0x0011CE23 File Offset: 0x0011B023
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600741B RID: 29723 RVA: 0x0011CE2C File Offset: 0x0011B02C
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.RoleID = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003DA8 RID: 15784
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003DA9 RID: 15785
		public const int RoleIDFieldNumber = 7;

		// Token: 0x04003DAA RID: 15786
		private int roleID_;
	}
}
