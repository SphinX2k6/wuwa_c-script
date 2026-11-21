using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009BE RID: 2494
	[NetMessage(EMessageId.MaterialResponse)]
	public sealed class MaterialResponse : IMessage<MaterialResponse>, IMessage, IEquatable<MaterialResponse>, IDeepCloneable<MaterialResponse>, IBufferMessage
	{
		// Token: 0x0600DB27 RID: 56103 RVA: 0x00203626 File Offset: 0x00201826
		[NullableContext(1)]
		public static MaterialResponse Create()
		{
			return new MaterialResponse();
		}

		// Token: 0x17002C69 RID: 11369
		// (get) Token: 0x0600DB28 RID: 56104 RVA: 0x0020362D File Offset: 0x0020182D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002C6A RID: 11370
		// (get) Token: 0x0600DB29 RID: 56105 RVA: 0x00203630 File Offset: 0x00201830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MaterialResponse.Descriptor;
			}
		}

		// Token: 0x0600DB2A RID: 56106 RVA: 0x00203637 File Offset: 0x00201837
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MaterialResponse()
		{
		}

		// Token: 0x0600DB2B RID: 56107 RVA: 0x0020363F File Offset: 0x0020183F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MaterialResponse(MaterialResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DB2C RID: 56108 RVA: 0x00203664 File Offset: 0x00201864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MaterialResponse Clone()
		{
			return new MaterialResponse(this);
		}

		// Token: 0x17002C6B RID: 11371
		// (get) Token: 0x0600DB2D RID: 56109 RVA: 0x0020366C File Offset: 0x0020186C
		// (set) Token: 0x0600DB2E RID: 56110 RVA: 0x00203674 File Offset: 0x00201874
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

		// Token: 0x0600DB2F RID: 56111 RVA: 0x0020367D File Offset: 0x0020187D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MaterialResponse);
		}

		// Token: 0x0600DB30 RID: 56112 RVA: 0x0020368B File Offset: 0x0020188B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MaterialResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DB31 RID: 56113 RVA: 0x002036BC File Offset: 0x002018BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DB32 RID: 56114 RVA: 0x00203701 File Offset: 0x00201901
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DB33 RID: 56115 RVA: 0x0020370E File Offset: 0x0020190E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DB34 RID: 56116 RVA: 0x00203717 File Offset: 0x00201917
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
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

		// Token: 0x0600DB35 RID: 56117 RVA: 0x0020374C File Offset: 0x0020194C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DB36 RID: 56118 RVA: 0x0020378A File Offset: 0x0020198A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MaterialResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DB37 RID: 56119 RVA: 0x002037BB File Offset: 0x002019BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DB38 RID: 56120 RVA: 0x002037C4 File Offset: 0x002019C4
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005B53 RID: 23379
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B54 RID: 23380
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x04005B55 RID: 23381
		private ErrorCode errorCode_;
	}
}
