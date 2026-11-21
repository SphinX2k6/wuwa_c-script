using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001084 RID: 4228
	[NetMessage(EMessageId.RoleOperateSelfBgmResponse)]
	public sealed class RoleOperateSelfBgmResponse : IMessage<RoleOperateSelfBgmResponse>, IMessage, IEquatable<RoleOperateSelfBgmResponse>, IDeepCloneable<RoleOperateSelfBgmResponse>, IBufferMessage
	{
		// Token: 0x060169D7 RID: 92631 RVA: 0x0034A3F0 File Offset: 0x003485F0
		[NullableContext(1)]
		public static RoleOperateSelfBgmResponse Create()
		{
			return new RoleOperateSelfBgmResponse();
		}

		// Token: 0x17004BC9 RID: 19401
		// (get) Token: 0x060169D8 RID: 92632 RVA: 0x0034A3F7 File Offset: 0x003485F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004BCA RID: 19402
		// (get) Token: 0x060169D9 RID: 92633 RVA: 0x0034A3FA File Offset: 0x003485FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleOperateSelfBgmResponse.Descriptor;
			}
		}

		// Token: 0x060169DA RID: 92634 RVA: 0x0034A401 File Offset: 0x00348601
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleOperateSelfBgmResponse()
		{
		}

		// Token: 0x060169DB RID: 92635 RVA: 0x0034A409 File Offset: 0x00348609
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleOperateSelfBgmResponse(RoleOperateSelfBgmResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.roleId_ = other.roleId_;
			this.isOpen_ = other.isOpen_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060169DC RID: 92636 RVA: 0x0034A446 File Offset: 0x00348646
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleOperateSelfBgmResponse Clone()
		{
			return new RoleOperateSelfBgmResponse(this);
		}

		// Token: 0x17004BCB RID: 19403
		// (get) Token: 0x060169DD RID: 92637 RVA: 0x0034A44E File Offset: 0x0034864E
		// (set) Token: 0x060169DE RID: 92638 RVA: 0x0034A456 File Offset: 0x00348656
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

		// Token: 0x17004BCC RID: 19404
		// (get) Token: 0x060169DF RID: 92639 RVA: 0x0034A45F File Offset: 0x0034865F
		// (set) Token: 0x060169E0 RID: 92640 RVA: 0x0034A467 File Offset: 0x00348667
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

		// Token: 0x17004BCD RID: 19405
		// (get) Token: 0x060169E1 RID: 92641 RVA: 0x0034A470 File Offset: 0x00348670
		// (set) Token: 0x060169E2 RID: 92642 RVA: 0x0034A478 File Offset: 0x00348678
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

		// Token: 0x060169E3 RID: 92643 RVA: 0x0034A481 File Offset: 0x00348681
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleOperateSelfBgmResponse);
		}

		// Token: 0x060169E4 RID: 92644 RVA: 0x0034A490 File Offset: 0x00348690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleOperateSelfBgmResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.RoleId == other.RoleId && this.IsOpen == other.IsOpen && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060169E5 RID: 92645 RVA: 0x0034A4EC File Offset: 0x003486EC
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

		// Token: 0x060169E6 RID: 92646 RVA: 0x0034A563 File Offset: 0x00348763
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060169E7 RID: 92647 RVA: 0x0034A570 File Offset: 0x00348770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060169E8 RID: 92648 RVA: 0x0034A57C File Offset: 0x0034877C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.RoleId);
			}
			if (this.IsOpen)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsOpen);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060169E9 RID: 92649 RVA: 0x0034A5F4 File Offset: 0x003487F4
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

		// Token: 0x060169EA RID: 92650 RVA: 0x0034A658 File Offset: 0x00348858
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

		// Token: 0x060169EB RID: 92651 RVA: 0x0034A6BC File Offset: 0x003488BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060169EC RID: 92652 RVA: 0x0034A6C8 File Offset: 0x003488C8
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
				if (num != 24U)
				{
					if (num != 32U)
					{
						if (num != 120U)
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
						this.IsOpen = input.ReadBool();
					}
				}
				else
				{
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040087A3 RID: 34723
		private UnknownFieldSet _unknownFields;

		// Token: 0x040087A4 RID: 34724
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x040087A5 RID: 34725
		private ErrorCode errorCode_;

		// Token: 0x040087A6 RID: 34726
		public const int RoleIdFieldNumber = 3;

		// Token: 0x040087A7 RID: 34727
		private int roleId_;

		// Token: 0x040087A8 RID: 34728
		public const int IsOpenFieldNumber = 4;

		// Token: 0x040087A9 RID: 34729
		private bool isOpen_;
	}
}
