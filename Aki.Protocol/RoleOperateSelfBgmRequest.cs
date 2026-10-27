using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001093 RID: 4243
	[NetMessage(EMessageId.RoleOperateSelfBgmRequest)]
	public sealed class RoleOperateSelfBgmRequest : IMessage<RoleOperateSelfBgmRequest>, IMessage, IEquatable<RoleOperateSelfBgmRequest>, IDeepCloneable<RoleOperateSelfBgmRequest>, IBufferMessage
	{
		// Token: 0x06016AA8 RID: 92840 RVA: 0x0034B83F File Offset: 0x00349A3F
		[NullableContext(1)]
		public static RoleOperateSelfBgmRequest Create()
		{
			return new RoleOperateSelfBgmRequest();
		}

		// Token: 0x17004BEF RID: 19439
		// (get) Token: 0x06016AA9 RID: 92841 RVA: 0x0034B846 File Offset: 0x00349A46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004BF0 RID: 19440
		// (get) Token: 0x06016AAA RID: 92842 RVA: 0x0034B849 File Offset: 0x00349A49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleOperateSelfBgmRequest.Descriptor;
			}
		}

		// Token: 0x06016AAB RID: 92843 RVA: 0x0034B850 File Offset: 0x00349A50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleOperateSelfBgmRequest()
		{
		}

		// Token: 0x06016AAC RID: 92844 RVA: 0x0034B858 File Offset: 0x00349A58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleOperateSelfBgmRequest(RoleOperateSelfBgmRequest other) : this()
		{
			this.roleId_ = other.roleId_;
			this.isOpen_ = other.isOpen_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016AAD RID: 92845 RVA: 0x0034B889 File Offset: 0x00349A89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleOperateSelfBgmRequest Clone()
		{
			return new RoleOperateSelfBgmRequest(this);
		}

		// Token: 0x17004BF1 RID: 19441
		// (get) Token: 0x06016AAE RID: 92846 RVA: 0x0034B891 File Offset: 0x00349A91
		// (set) Token: 0x06016AAF RID: 92847 RVA: 0x0034B899 File Offset: 0x00349A99
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

		// Token: 0x17004BF2 RID: 19442
		// (get) Token: 0x06016AB0 RID: 92848 RVA: 0x0034B8A2 File Offset: 0x00349AA2
		// (set) Token: 0x06016AB1 RID: 92849 RVA: 0x0034B8AA File Offset: 0x00349AAA
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

		// Token: 0x06016AB2 RID: 92850 RVA: 0x0034B8B3 File Offset: 0x00349AB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleOperateSelfBgmRequest);
		}

		// Token: 0x06016AB3 RID: 92851 RVA: 0x0034B8C1 File Offset: 0x00349AC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleOperateSelfBgmRequest other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.IsOpen == other.IsOpen && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016AB4 RID: 92852 RVA: 0x0034B900 File Offset: 0x00349B00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x06016AB5 RID: 92853 RVA: 0x0034B958 File Offset: 0x00349B58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016AB6 RID: 92854 RVA: 0x0034B965 File Offset: 0x00349B65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016AB7 RID: 92855 RVA: 0x0034B970 File Offset: 0x00349B70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.RoleId);
			}
			if (this.IsOpen)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.IsOpen);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016AB8 RID: 92856 RVA: 0x0034B9CC File Offset: 0x00349BCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x06016AB9 RID: 92857 RVA: 0x0034BA18 File Offset: 0x00349C18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleOperateSelfBgmRequest other)
		{
			if (other == null)
			{
				return;
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

		// Token: 0x06016ABA RID: 92858 RVA: 0x0034BA68 File Offset: 0x00349C68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016ABB RID: 92859 RVA: 0x0034BA74 File Offset: 0x00349C74
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
				if (num != 48U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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

		// Token: 0x04008774 RID: 34676
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008775 RID: 34677
		public const int RoleIdFieldNumber = 6;

		// Token: 0x04008776 RID: 34678
		private int roleId_;

		// Token: 0x04008777 RID: 34679
		public const int IsOpenFieldNumber = 14;

		// Token: 0x04008778 RID: 34680
		private bool isOpen_;
	}
}
