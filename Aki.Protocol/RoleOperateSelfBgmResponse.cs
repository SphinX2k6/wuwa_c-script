using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001094 RID: 4244
	[NetMessage(EMessageId.RoleOperateSelfBgmResponse)]
	public sealed class RoleOperateSelfBgmResponse : IMessage<RoleOperateSelfBgmResponse>, IMessage, IEquatable<RoleOperateSelfBgmResponse>, IDeepCloneable<RoleOperateSelfBgmResponse>, IBufferMessage
	{
		// Token: 0x06016ABC RID: 92860 RVA: 0x0034BACC File Offset: 0x00349CCC
		[NullableContext(1)]
		public static RoleOperateSelfBgmResponse Create()
		{
			return new RoleOperateSelfBgmResponse();
		}

		// Token: 0x17004BF3 RID: 19443
		// (get) Token: 0x06016ABD RID: 92861 RVA: 0x0034BAD3 File Offset: 0x00349CD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004BF4 RID: 19444
		// (get) Token: 0x06016ABE RID: 92862 RVA: 0x0034BAD6 File Offset: 0x00349CD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleOperateSelfBgmResponse.Descriptor;
			}
		}

		// Token: 0x06016ABF RID: 92863 RVA: 0x0034BADD File Offset: 0x00349CDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleOperateSelfBgmResponse()
		{
		}

		// Token: 0x06016AC0 RID: 92864 RVA: 0x0034BAE5 File Offset: 0x00349CE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleOperateSelfBgmResponse(RoleOperateSelfBgmResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.roleId_ = other.roleId_;
			this.isOpen_ = other.isOpen_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016AC1 RID: 92865 RVA: 0x0034BB22 File Offset: 0x00349D22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleOperateSelfBgmResponse Clone()
		{
			return new RoleOperateSelfBgmResponse(this);
		}

		// Token: 0x17004BF5 RID: 19445
		// (get) Token: 0x06016AC2 RID: 92866 RVA: 0x0034BB2A File Offset: 0x00349D2A
		// (set) Token: 0x06016AC3 RID: 92867 RVA: 0x0034BB32 File Offset: 0x00349D32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x17004BF6 RID: 19446
		// (get) Token: 0x06016AC4 RID: 92868 RVA: 0x0034BB3B File Offset: 0x00349D3B
		// (set) Token: 0x06016AC5 RID: 92869 RVA: 0x0034BB43 File Offset: 0x00349D43
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

		// Token: 0x17004BF7 RID: 19447
		// (get) Token: 0x06016AC6 RID: 92870 RVA: 0x0034BB4C File Offset: 0x00349D4C
		// (set) Token: 0x06016AC7 RID: 92871 RVA: 0x0034BB54 File Offset: 0x00349D54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsOpen
		{
			get
			{
				return this.isOpen_;
			}
			set
			{
				this.isOpen_ = value;
			}
		}

		// Token: 0x06016AC8 RID: 92872 RVA: 0x0034BB5D File Offset: 0x00349D5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleOperateSelfBgmResponse);
		}

		// Token: 0x06016AC9 RID: 92873 RVA: 0x0034BB6C File Offset: 0x00349D6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleOperateSelfBgmResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.RoleId == other.RoleId && this.IsOpen == other.IsOpen && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016ACA RID: 92874 RVA: 0x0034BBC8 File Offset: 0x00349DC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.IsOpen)
			{
				num ^= this.IsOpen.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016ACB RID: 92875 RVA: 0x0034BC3F File Offset: 0x00349E3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016ACC RID: 92876 RVA: 0x0034BC4C File Offset: 0x00349E4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016ACD RID: 92877 RVA: 0x0034BC58 File Offset: 0x00349E58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.IsOpen)
			{
				output.WriteRawTag(104);
				output.WriteBool(this.IsOpen);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016ACE RID: 92878 RVA: 0x0034BCD0 File Offset: 0x00349ED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.IsOpen)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016ACF RID: 92879 RVA: 0x0034BD34 File Offset: 0x00349F34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleOperateSelfBgmResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.IsOpen)
			{
				this.IsOpen = other.IsOpen;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016AD0 RID: 92880 RVA: 0x0034BD98 File Offset: 0x00349F98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016AD1 RID: 92881 RVA: 0x0034BDA4 File Offset: 0x00349FA4
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
					if (num != 104U)
					{
						if (num != 112U)
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
						this.IsOpen = input.ReadBool();
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008779 RID: 34681
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400877A RID: 34682
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x0400877B RID: 34683
		private ErrorCode errorCode_;

		// Token: 0x0400877C RID: 34684
		public const int RoleIdFieldNumber = 14;

		// Token: 0x0400877D RID: 34685
		private int roleId_;

		// Token: 0x0400877E RID: 34686
		public const int IsOpenFieldNumber = 13;

		// Token: 0x0400877F RID: 34687
		private bool isOpen_;
	}
}
