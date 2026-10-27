using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200105D RID: 4189
	[NetMessage(EMessageId.RoleChangeNotify)]
	public sealed class RoleChangeNotify : IMessage<RoleChangeNotify>, IMessage, IEquatable<RoleChangeNotify>, IDeepCloneable<RoleChangeNotify>, IBufferMessage
	{
		// Token: 0x06016620 RID: 91680 RVA: 0x00340AC4 File Offset: 0x0033ECC4
		[NullableContext(1)]
		public static RoleChangeNotify Create()
		{
			return new RoleChangeNotify();
		}

		// Token: 0x17004AE2 RID: 19170
		// (get) Token: 0x06016621 RID: 91681 RVA: 0x00340ACB File Offset: 0x0033ECCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004AE3 RID: 19171
		// (get) Token: 0x06016622 RID: 91682 RVA: 0x00340ACE File Offset: 0x0033ECCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleChangeNotify.Descriptor;
			}
		}

		// Token: 0x06016623 RID: 91683 RVA: 0x00340AD5 File Offset: 0x0033ECD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleChangeNotify()
		{
		}

		// Token: 0x06016624 RID: 91684 RVA: 0x00340AE0 File Offset: 0x0033ECE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleChangeNotify(RoleChangeNotify other) : this()
		{
			this.sourceRoleId_ = other.sourceRoleId_;
			this.roleInfo_ = ((other.roleInfo_ != null) ? other.roleInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016625 RID: 91685 RVA: 0x00340B2C File Offset: 0x0033ED2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleChangeNotify Clone()
		{
			return new RoleChangeNotify(this);
		}

		// Token: 0x17004AE4 RID: 19172
		// (get) Token: 0x06016626 RID: 91686 RVA: 0x00340B34 File Offset: 0x0033ED34
		// (set) Token: 0x06016627 RID: 91687 RVA: 0x00340B3C File Offset: 0x0033ED3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SourceRoleId
		{
			get
			{
				return this.sourceRoleId_;
			}
			set
			{
				this.sourceRoleId_ = value;
			}
		}

		// Token: 0x17004AE5 RID: 19173
		// (get) Token: 0x06016628 RID: 91688 RVA: 0x00340B45 File Offset: 0x0033ED45
		// (set) Token: 0x06016629 RID: 91689 RVA: 0x00340B4D File Offset: 0x0033ED4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public roleInfo RoleInfo
		{
			get
			{
				return this.roleInfo_;
			}
			set
			{
				this.roleInfo_ = value;
			}
		}

		// Token: 0x0601662A RID: 91690 RVA: 0x00340B56 File Offset: 0x0033ED56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleChangeNotify);
		}

		// Token: 0x0601662B RID: 91691 RVA: 0x00340B64 File Offset: 0x0033ED64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleChangeNotify other)
		{
			return other != null && (other == this || (this.SourceRoleId == other.SourceRoleId && object.Equals(this.RoleInfo, other.RoleInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601662C RID: 91692 RVA: 0x00340BB4 File Offset: 0x0033EDB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SourceRoleId != 0)
			{
				num ^= this.SourceRoleId.GetHashCode();
			}
			if (this.roleInfo_ != null)
			{
				num ^= this.RoleInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601662D RID: 91693 RVA: 0x00340C09 File Offset: 0x0033EE09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601662E RID: 91694 RVA: 0x00340C16 File Offset: 0x0033EE16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601662F RID: 91695 RVA: 0x00340C20 File Offset: 0x0033EE20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.roleInfo_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.RoleInfo);
			}
			if (this.SourceRoleId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.SourceRoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016630 RID: 91696 RVA: 0x00340C7C File Offset: 0x0033EE7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SourceRoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SourceRoleId);
			}
			if (this.roleInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RoleInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016631 RID: 91697 RVA: 0x00340CD4 File Offset: 0x0033EED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleChangeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SourceRoleId != 0)
			{
				this.SourceRoleId = other.SourceRoleId;
			}
			if (other.roleInfo_ != null)
			{
				if (this.roleInfo_ == null)
				{
					this.RoleInfo = new roleInfo();
				}
				this.RoleInfo.MergeFrom(other.RoleInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016632 RID: 91698 RVA: 0x00340D3C File Offset: 0x0033EF3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016633 RID: 91699 RVA: 0x00340D48 File Offset: 0x0033EF48
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
				if (num != 82U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SourceRoleId = input.ReadInt32();
					}
				}
				else
				{
					if (this.roleInfo_ == null)
					{
						this.RoleInfo = new roleInfo();
					}
					input.ReadMessage(this.RoleInfo);
				}
			}
		}

		// Token: 0x040085DC RID: 34268
		private UnknownFieldSet _unknownFields;

		// Token: 0x040085DD RID: 34269
		public const int SourceRoleIdFieldNumber = 12;

		// Token: 0x040085DE RID: 34270
		private int sourceRoleId_;

		// Token: 0x040085DF RID: 34271
		public const int RoleInfoFieldNumber = 10;

		// Token: 0x040085E0 RID: 34272
		private roleInfo roleInfo_;
	}
}
