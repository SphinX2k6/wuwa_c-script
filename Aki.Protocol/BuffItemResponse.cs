using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000209 RID: 521
	[NetMessage(EMessageId.BuffItemResponse)]
	public sealed class BuffItemResponse : IMessage<BuffItemResponse>, IMessage, IEquatable<BuffItemResponse>, IDeepCloneable<BuffItemResponse>, IBufferMessage
	{
		// Token: 0x060039AC RID: 14764 RVA: 0x0009001B File Offset: 0x0008E21B
		[NullableContext(1)]
		public static BuffItemResponse Create()
		{
			return new BuffItemResponse();
		}

		// Token: 0x17000969 RID: 2409
		// (get) Token: 0x060039AD RID: 14765 RVA: 0x00090022 File Offset: 0x0008E222
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700096A RID: 2410
		// (get) Token: 0x060039AE RID: 14766 RVA: 0x00090025 File Offset: 0x0008E225
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BuffItemResponse.Descriptor;
			}
		}

		// Token: 0x060039AF RID: 14767 RVA: 0x0009002C File Offset: 0x0008E22C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffItemResponse()
		{
		}

		// Token: 0x060039B0 RID: 14768 RVA: 0x00090034 File Offset: 0x0008E234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffItemResponse(BuffItemResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.buffItemInfo_ = ((other.buffItemInfo_ != null) ? other.buffItemInfo_.Clone() : null);
			this.roleId_ = other.roleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060039B1 RID: 14769 RVA: 0x0009008C File Offset: 0x0008E28C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffItemResponse Clone()
		{
			return new BuffItemResponse(this);
		}

		// Token: 0x1700096B RID: 2411
		// (get) Token: 0x060039B2 RID: 14770 RVA: 0x00090094 File Offset: 0x0008E294
		// (set) Token: 0x060039B3 RID: 14771 RVA: 0x0009009C File Offset: 0x0008E29C
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

		// Token: 0x1700096C RID: 2412
		// (get) Token: 0x060039B4 RID: 14772 RVA: 0x000900A5 File Offset: 0x0008E2A5
		// (set) Token: 0x060039B5 RID: 14773 RVA: 0x000900AD File Offset: 0x0008E2AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffItem BuffItemInfo
		{
			get
			{
				return this.buffItemInfo_;
			}
			set
			{
				this.buffItemInfo_ = value;
			}
		}

		// Token: 0x1700096D RID: 2413
		// (get) Token: 0x060039B6 RID: 14774 RVA: 0x000900B6 File Offset: 0x0008E2B6
		// (set) Token: 0x060039B7 RID: 14775 RVA: 0x000900BE File Offset: 0x0008E2BE
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

		// Token: 0x060039B8 RID: 14776 RVA: 0x000900C7 File Offset: 0x0008E2C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BuffItemResponse);
		}

		// Token: 0x060039B9 RID: 14777 RVA: 0x000900D8 File Offset: 0x0008E2D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BuffItemResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.BuffItemInfo, other.BuffItemInfo) && this.RoleId == other.RoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060039BA RID: 14778 RVA: 0x00090138 File Offset: 0x0008E338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.buffItemInfo_ != null)
			{
				num ^= this.BuffItemInfo.GetHashCode();
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

		// Token: 0x060039BB RID: 14779 RVA: 0x000901AC File Offset: 0x0008E3AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060039BC RID: 14780 RVA: 0x000901B9 File Offset: 0x0008E3B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060039BD RID: 14781 RVA: 0x000901C4 File Offset: 0x0008E3C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.buffItemInfo_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.BuffItemInfo);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.RoleId);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060039BE RID: 14782 RVA: 0x0009023C File Offset: 0x0008E43C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.buffItemInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BuffItemInfo);
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

		// Token: 0x060039BF RID: 14783 RVA: 0x000902AC File Offset: 0x0008E4AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BuffItemResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.buffItemInfo_ != null)
			{
				if (this.buffItemInfo_ == null)
				{
					this.BuffItemInfo = new BuffItem();
				}
				this.BuffItemInfo.MergeFrom(other.BuffItemInfo);
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060039C0 RID: 14784 RVA: 0x00090328 File Offset: 0x0008E528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060039C1 RID: 14785 RVA: 0x00090334 File Offset: 0x0008E534
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
				if (num != 98U)
				{
					if (num != 104U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ErrorCode = (ErrorCode)input.ReadEnum();
						}
					}
					else
					{
						this.RoleId = input.ReadInt32();
					}
				}
				else
				{
					if (this.buffItemInfo_ == null)
					{
						this.BuffItemInfo = new BuffItem();
					}
					input.ReadMessage(this.BuffItemInfo);
				}
			}
		}

		// Token: 0x04002BE0 RID: 11232
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002BE1 RID: 11233
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04002BE2 RID: 11234
		private ErrorCode errorCode_;

		// Token: 0x04002BE3 RID: 11235
		public const int BuffItemInfoFieldNumber = 12;

		// Token: 0x04002BE4 RID: 11236
		private BuffItem buffItemInfo_;

		// Token: 0x04002BE5 RID: 11237
		public const int RoleIdFieldNumber = 13;

		// Token: 0x04002BE6 RID: 11238
		private int roleId_;
	}
}
