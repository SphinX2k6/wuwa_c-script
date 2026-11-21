using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000128 RID: 296
	[NetMessage(EMessageId.AttributeChangedResponse)]
	public sealed class AttributeChangedResponse : IMessage<AttributeChangedResponse>, IMessage, IEquatable<AttributeChangedResponse>, IDeepCloneable<AttributeChangedResponse>, IBufferMessage
	{
		// Token: 0x060027C2 RID: 10178 RVA: 0x0006951C File Offset: 0x0006771C
		[NullableContext(1)]
		public static AttributeChangedResponse Create()
		{
			return new AttributeChangedResponse();
		}

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x060027C3 RID: 10179 RVA: 0x00069523 File Offset: 0x00067723
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x060027C4 RID: 10180 RVA: 0x00069526 File Offset: 0x00067726
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AttributeChangedResponse.Descriptor;
			}
		}

		// Token: 0x060027C5 RID: 10181 RVA: 0x0006952D File Offset: 0x0006772D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttributeChangedResponse()
		{
		}

		// Token: 0x060027C6 RID: 10182 RVA: 0x00069535 File Offset: 0x00067735
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttributeChangedResponse(AttributeChangedResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060027C7 RID: 10183 RVA: 0x0006955A File Offset: 0x0006775A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttributeChangedResponse Clone()
		{
			return new AttributeChangedResponse(this);
		}

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x060027C8 RID: 10184 RVA: 0x00069562 File Offset: 0x00067762
		// (set) Token: 0x060027C9 RID: 10185 RVA: 0x0006956A File Offset: 0x0006776A
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

		// Token: 0x060027CA RID: 10186 RVA: 0x00069573 File Offset: 0x00067773
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AttributeChangedResponse);
		}

		// Token: 0x060027CB RID: 10187 RVA: 0x00069581 File Offset: 0x00067781
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AttributeChangedResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060027CC RID: 10188 RVA: 0x000695B0 File Offset: 0x000677B0
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

		// Token: 0x060027CD RID: 10189 RVA: 0x000695F5 File Offset: 0x000677F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060027CE RID: 10190 RVA: 0x00069602 File Offset: 0x00067802
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060027CF RID: 10191 RVA: 0x0006960B File Offset: 0x0006780B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060027D0 RID: 10192 RVA: 0x00069640 File Offset: 0x00067840
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

		// Token: 0x060027D1 RID: 10193 RVA: 0x0006967E File Offset: 0x0006787E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AttributeChangedResponse other)
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

		// Token: 0x060027D2 RID: 10194 RVA: 0x000696AF File Offset: 0x000678AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060027D3 RID: 10195 RVA: 0x000696B8 File Offset: 0x000678B8
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040026CA RID: 9930
		private UnknownFieldSet _unknownFields;

		// Token: 0x040026CB RID: 9931
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x040026CC RID: 9932
		private ErrorCode errorCode_;
	}
}
