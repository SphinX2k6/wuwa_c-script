using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200012A RID: 298
	[NetMessage(EMessageId.AttributeInitResponse)]
	public sealed class AttributeInitResponse : IMessage<AttributeInitResponse>, IMessage, IEquatable<AttributeInitResponse>, IDeepCloneable<AttributeInitResponse>, IBufferMessage
	{
		// Token: 0x060027AD RID: 10157 RVA: 0x00068D6C File Offset: 0x00066F6C
		[NullableContext(1)]
		public static AttributeInitResponse Create()
		{
			return new AttributeInitResponse();
		}

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x060027AE RID: 10158 RVA: 0x00068D73 File Offset: 0x00066F73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x060027AF RID: 10159 RVA: 0x00068D76 File Offset: 0x00066F76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AttributeInitResponse.Descriptor;
			}
		}

		// Token: 0x060027B0 RID: 10160 RVA: 0x00068D7D File Offset: 0x00066F7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttributeInitResponse()
		{
		}

		// Token: 0x060027B1 RID: 10161 RVA: 0x00068D85 File Offset: 0x00066F85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttributeInitResponse(AttributeInitResponse other) : this()
		{
			this.success_ = other.success_;
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060027B2 RID: 10162 RVA: 0x00068DB6 File Offset: 0x00066FB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttributeInitResponse Clone()
		{
			return new AttributeInitResponse(this);
		}

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x060027B3 RID: 10163 RVA: 0x00068DBE File Offset: 0x00066FBE
		// (set) Token: 0x060027B4 RID: 10164 RVA: 0x00068DC6 File Offset: 0x00066FC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Success
		{
			get
			{
				return this.success_;
			}
			set
			{
				this.success_ = value;
			}
		}

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x060027B5 RID: 10165 RVA: 0x00068DCF File Offset: 0x00066FCF
		// (set) Token: 0x060027B6 RID: 10166 RVA: 0x00068DD7 File Offset: 0x00066FD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x060027B7 RID: 10167 RVA: 0x00068DE0 File Offset: 0x00066FE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AttributeInitResponse);
		}

		// Token: 0x060027B8 RID: 10168 RVA: 0x00068DEE File Offset: 0x00066FEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AttributeInitResponse other)
		{
			return other != null && (other == this || (this.Success == other.Success && this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060027B9 RID: 10169 RVA: 0x00068E2C File Offset: 0x0006702C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Success)
			{
				num ^= this.Success.GetHashCode();
			}
			if (this.Id != 0L)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060027BA RID: 10170 RVA: 0x00068E84 File Offset: 0x00067084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060027BB RID: 10171 RVA: 0x00068E91 File Offset: 0x00067091
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060027BC RID: 10172 RVA: 0x00068E9C File Offset: 0x0006709C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.Id);
			}
			if (this.Success)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.Success);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060027BD RID: 10173 RVA: 0x00068EF4 File Offset: 0x000670F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Success)
			{
				num += 2;
			}
			if (this.Id != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060027BE RID: 10174 RVA: 0x00068F40 File Offset: 0x00067140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AttributeInitResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Success)
			{
				this.Success = other.Success;
			}
			if (other.Id != 0L)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060027BF RID: 10175 RVA: 0x00068F90 File Offset: 0x00067190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060027C0 RID: 10176 RVA: 0x00068F9C File Offset: 0x0006719C
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
				if (num != 8U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Success = input.ReadBool();
					}
				}
				else
				{
					this.Id = input.ReadInt64();
				}
			}
		}

		// Token: 0x04002671 RID: 9841
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002672 RID: 9842
		public const int SuccessFieldNumber = 12;

		// Token: 0x04002673 RID: 9843
		private bool success_;

		// Token: 0x04002674 RID: 9844
		public const int IdFieldNumber = 1;

		// Token: 0x04002675 RID: 9845
		private long id_;
	}
}
