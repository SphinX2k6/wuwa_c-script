using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000199 RID: 409
	[NetMessage(EMessageId.BirthDayCardRoleResponse)]
	public sealed class BirthDayCardRoleResponse : IMessage<BirthDayCardRoleResponse>, IMessage, IEquatable<BirthDayCardRoleResponse>, IDeepCloneable<BirthDayCardRoleResponse>, IBufferMessage
	{
		// Token: 0x06003075 RID: 12405 RVA: 0x0007BAE4 File Offset: 0x00079CE4
		[NullableContext(1)]
		public static BirthDayCardRoleResponse Create()
		{
			return new BirthDayCardRoleResponse();
		}

		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x06003076 RID: 12406 RVA: 0x0007BAEB File Offset: 0x00079CEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x06003077 RID: 12407 RVA: 0x0007BAEE File Offset: 0x00079CEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BirthDayCardRoleResponse.Descriptor;
			}
		}

		// Token: 0x06003078 RID: 12408 RVA: 0x0007BAF5 File Offset: 0x00079CF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BirthDayCardRoleResponse()
		{
		}

		// Token: 0x06003079 RID: 12409 RVA: 0x0007BAFD File Offset: 0x00079CFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BirthDayCardRoleResponse(BirthDayCardRoleResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600307A RID: 12410 RVA: 0x0007BB22 File Offset: 0x00079D22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BirthDayCardRoleResponse Clone()
		{
			return new BirthDayCardRoleResponse(this);
		}

		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x0600307B RID: 12411 RVA: 0x0007BB2A File Offset: 0x00079D2A
		// (set) Token: 0x0600307C RID: 12412 RVA: 0x0007BB32 File Offset: 0x00079D32
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

		// Token: 0x0600307D RID: 12413 RVA: 0x0007BB3B File Offset: 0x00079D3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BirthDayCardRoleResponse);
		}

		// Token: 0x0600307E RID: 12414 RVA: 0x0007BB49 File Offset: 0x00079D49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BirthDayCardRoleResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600307F RID: 12415 RVA: 0x0007BB78 File Offset: 0x00079D78
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

		// Token: 0x06003080 RID: 12416 RVA: 0x0007BBBD File Offset: 0x00079DBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003081 RID: 12417 RVA: 0x0007BBCA File Offset: 0x00079DCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003082 RID: 12418 RVA: 0x0007BBD3 File Offset: 0x00079DD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003083 RID: 12419 RVA: 0x0007BC08 File Offset: 0x00079E08
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

		// Token: 0x06003084 RID: 12420 RVA: 0x0007BC46 File Offset: 0x00079E46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BirthDayCardRoleResponse other)
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

		// Token: 0x06003085 RID: 12421 RVA: 0x0007BC77 File Offset: 0x00079E77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003086 RID: 12422 RVA: 0x0007BC80 File Offset: 0x00079E80
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040028F5 RID: 10485
		private UnknownFieldSet _unknownFields;

		// Token: 0x040028F6 RID: 10486
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x040028F7 RID: 10487
		private ErrorCode errorCode_;
	}
}
