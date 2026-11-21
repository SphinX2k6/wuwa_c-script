using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001082 RID: 4226
	[NetMessage(EMessageId.RoleMotionUnLockResponse)]
	public sealed class RoleMotionUnLockResponse : IMessage<RoleMotionUnLockResponse>, IMessage, IEquatable<RoleMotionUnLockResponse>, IDeepCloneable<RoleMotionUnLockResponse>, IBufferMessage
	{
		// Token: 0x060169AD RID: 92589 RVA: 0x00349E13 File Offset: 0x00348013
		[NullableContext(1)]
		public static RoleMotionUnLockResponse Create()
		{
			return new RoleMotionUnLockResponse();
		}

		// Token: 0x17004BC0 RID: 19392
		// (get) Token: 0x060169AE RID: 92590 RVA: 0x00349E1A File Offset: 0x0034801A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004BC1 RID: 19393
		// (get) Token: 0x060169AF RID: 92591 RVA: 0x00349E1D File Offset: 0x0034801D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleMotionUnLockResponse.Descriptor;
			}
		}

		// Token: 0x060169B0 RID: 92592 RVA: 0x00349E24 File Offset: 0x00348024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleMotionUnLockResponse()
		{
		}

		// Token: 0x060169B1 RID: 92593 RVA: 0x00349E2C File Offset: 0x0034802C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleMotionUnLockResponse(RoleMotionUnLockResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this.roleId_ = other.roleId_;
			this.unLockId_ = other.unLockId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060169B2 RID: 92594 RVA: 0x00349E69 File Offset: 0x00348069
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleMotionUnLockResponse Clone()
		{
			return new RoleMotionUnLockResponse(this);
		}

		// Token: 0x17004BC2 RID: 19394
		// (get) Token: 0x060169B3 RID: 92595 RVA: 0x00349E71 File Offset: 0x00348071
		// (set) Token: 0x060169B4 RID: 92596 RVA: 0x00349E79 File Offset: 0x00348079
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

		// Token: 0x17004BC3 RID: 19395
		// (get) Token: 0x060169B5 RID: 92597 RVA: 0x00349E82 File Offset: 0x00348082
		// (set) Token: 0x060169B6 RID: 92598 RVA: 0x00349E8A File Offset: 0x0034808A
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

		// Token: 0x17004BC4 RID: 19396
		// (get) Token: 0x060169B7 RID: 92599 RVA: 0x00349E93 File Offset: 0x00348093
		// (set) Token: 0x060169B8 RID: 92600 RVA: 0x00349E9B File Offset: 0x0034809B
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

		// Token: 0x060169B9 RID: 92601 RVA: 0x00349EA4 File Offset: 0x003480A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleMotionUnLockResponse);
		}

		// Token: 0x060169BA RID: 92602 RVA: 0x00349EB4 File Offset: 0x003480B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleMotionUnLockResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && this.RoleId == other.RoleId && this.UnLockId == other.UnLockId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060169BB RID: 92603 RVA: 0x00349F10 File Offset: 0x00348110
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

		// Token: 0x060169BC RID: 92604 RVA: 0x00349F87 File Offset: 0x00348187
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060169BD RID: 92605 RVA: 0x00349F94 File Offset: 0x00348194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060169BE RID: 92606 RVA: 0x00349FA0 File Offset: 0x003481A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.RoleId);
			}
			if (this.UnLockId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.UnLockId);
			}
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060169BF RID: 92607 RVA: 0x0034A018 File Offset: 0x00348218
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

		// Token: 0x060169C0 RID: 92608 RVA: 0x0034A088 File Offset: 0x00348288
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

		// Token: 0x060169C1 RID: 92609 RVA: 0x0034A0EC File Offset: 0x003482EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060169C2 RID: 92610 RVA: 0x0034A0F8 File Offset: 0x003482F8
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
				if (num != 32U)
				{
					if (num != 88U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008797 RID: 34711
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008798 RID: 34712
		public const int ErrCodeFieldNumber = 15;

		// Token: 0x04008799 RID: 34713
		private ErrorCode errCode_;

		// Token: 0x0400879A RID: 34714
		public const int RoleIdFieldNumber = 4;

		// Token: 0x0400879B RID: 34715
		private int roleId_;

		// Token: 0x0400879C RID: 34716
		public const int UnLockIdFieldNumber = 11;

		// Token: 0x0400879D RID: 34717
		private int unLockId_;
	}
}
