using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001092 RID: 4242
	[NetMessage(EMessageId.RoleMotionUnLockResponse)]
	public sealed class RoleMotionUnLockResponse : IMessage<RoleMotionUnLockResponse>, IMessage, IEquatable<RoleMotionUnLockResponse>, IDeepCloneable<RoleMotionUnLockResponse>, IBufferMessage
	{
		// Token: 0x06016A92 RID: 92818 RVA: 0x0034B4F0 File Offset: 0x003496F0
		[NullableContext(1)]
		public static RoleMotionUnLockResponse Create()
		{
			return new RoleMotionUnLockResponse();
		}

		// Token: 0x17004BEA RID: 19434
		// (get) Token: 0x06016A93 RID: 92819 RVA: 0x0034B4F7 File Offset: 0x003496F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004BEB RID: 19435
		// (get) Token: 0x06016A94 RID: 92820 RVA: 0x0034B4FA File Offset: 0x003496FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleMotionUnLockResponse.Descriptor;
			}
		}

		// Token: 0x06016A95 RID: 92821 RVA: 0x0034B501 File Offset: 0x00349701
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleMotionUnLockResponse()
		{
		}

		// Token: 0x06016A96 RID: 92822 RVA: 0x0034B509 File Offset: 0x00349709
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleMotionUnLockResponse(RoleMotionUnLockResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this.roleId_ = other.roleId_;
			this.unLockId_ = other.unLockId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016A97 RID: 92823 RVA: 0x0034B546 File Offset: 0x00349746
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleMotionUnLockResponse Clone()
		{
			return new RoleMotionUnLockResponse(this);
		}

		// Token: 0x17004BEC RID: 19436
		// (get) Token: 0x06016A98 RID: 92824 RVA: 0x0034B54E File Offset: 0x0034974E
		// (set) Token: 0x06016A99 RID: 92825 RVA: 0x0034B556 File Offset: 0x00349756
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrCode
		{
			get
			{
				return this.errCode_;
			}
			set
			{
				this.errCode_ = value;
			}
		}

		// Token: 0x17004BED RID: 19437
		// (get) Token: 0x06016A9A RID: 92826 RVA: 0x0034B55F File Offset: 0x0034975F
		// (set) Token: 0x06016A9B RID: 92827 RVA: 0x0034B567 File Offset: 0x00349767
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

		// Token: 0x17004BEE RID: 19438
		// (get) Token: 0x06016A9C RID: 92828 RVA: 0x0034B570 File Offset: 0x00349770
		// (set) Token: 0x06016A9D RID: 92829 RVA: 0x0034B578 File Offset: 0x00349778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int UnLockId
		{
			get
			{
				return this.unLockId_;
			}
			set
			{
				this.unLockId_ = value;
			}
		}

		// Token: 0x06016A9E RID: 92830 RVA: 0x0034B581 File Offset: 0x00349781
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleMotionUnLockResponse);
		}

		// Token: 0x06016A9F RID: 92831 RVA: 0x0034B590 File Offset: 0x00349790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleMotionUnLockResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && this.RoleId == other.RoleId && this.UnLockId == other.UnLockId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016AA0 RID: 92832 RVA: 0x0034B5EC File Offset: 0x003497EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.UnLockId != 0)
			{
				num ^= this.UnLockId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016AA1 RID: 92833 RVA: 0x0034B663 File Offset: 0x00349863
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016AA2 RID: 92834 RVA: 0x0034B670 File Offset: 0x00349870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016AA3 RID: 92835 RVA: 0x0034B67C File Offset: 0x0034987C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.UnLockId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.UnLockId);
			}
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrCode);
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

		// Token: 0x06016AA4 RID: 92836 RVA: 0x0034B6F4 File Offset: 0x003498F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
			}
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.UnLockId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.UnLockId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016AA5 RID: 92837 RVA: 0x0034B764 File Offset: 0x00349964
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleMotionUnLockResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.UnLockId != 0)
			{
				this.UnLockId = other.UnLockId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016AA6 RID: 92838 RVA: 0x0034B7C8 File Offset: 0x003499C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016AA7 RID: 92839 RVA: 0x0034B7D4 File Offset: 0x003499D4
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
					if (num != 88U)
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
						this.ErrCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.UnLockId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400876D RID: 34669
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400876E RID: 34670
		public const int ErrCodeFieldNumber = 11;

		// Token: 0x0400876F RID: 34671
		private ErrorCode errCode_;

		// Token: 0x04008770 RID: 34672
		public const int RoleIdFieldNumber = 12;

		// Token: 0x04008771 RID: 34673
		private int roleId_;

		// Token: 0x04008772 RID: 34674
		public const int UnLockIdFieldNumber = 10;

		// Token: 0x04008773 RID: 34675
		private int unLockId_;
	}
}
