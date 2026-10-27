using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200136B RID: 4971
	[NetMessage(EMessageId.ThrowDamageResponse)]
	public sealed class ThrowDamageResponse : IMessage<ThrowDamageResponse>, IMessage, IEquatable<ThrowDamageResponse>, IDeepCloneable<ThrowDamageResponse>, IBufferMessage
	{
		// Token: 0x0601A654 RID: 108116 RVA: 0x003D5090 File Offset: 0x003D3290
		[NullableContext(1)]
		public static ThrowDamageResponse Create()
		{
			return new ThrowDamageResponse();
		}

		// Token: 0x17005906 RID: 22790
		// (get) Token: 0x0601A655 RID: 108117 RVA: 0x003D5097 File Offset: 0x003D3297
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005907 RID: 22791
		// (get) Token: 0x0601A656 RID: 108118 RVA: 0x003D509A File Offset: 0x003D329A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ThrowDamageResponse.Descriptor;
			}
		}

		// Token: 0x0601A657 RID: 108119 RVA: 0x003D50A1 File Offset: 0x003D32A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThrowDamageResponse()
		{
		}

		// Token: 0x0601A658 RID: 108120 RVA: 0x003D50A9 File Offset: 0x003D32A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThrowDamageResponse(ThrowDamageResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A659 RID: 108121 RVA: 0x003D50CE File Offset: 0x003D32CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThrowDamageResponse Clone()
		{
			return new ThrowDamageResponse(this);
		}

		// Token: 0x17005908 RID: 22792
		// (get) Token: 0x0601A65A RID: 108122 RVA: 0x003D50D6 File Offset: 0x003D32D6
		// (set) Token: 0x0601A65B RID: 108123 RVA: 0x003D50DE File Offset: 0x003D32DE
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

		// Token: 0x0601A65C RID: 108124 RVA: 0x003D50E7 File Offset: 0x003D32E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ThrowDamageResponse);
		}

		// Token: 0x0601A65D RID: 108125 RVA: 0x003D50F5 File Offset: 0x003D32F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ThrowDamageResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A65E RID: 108126 RVA: 0x003D5124 File Offset: 0x003D3324
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

		// Token: 0x0601A65F RID: 108127 RVA: 0x003D5169 File Offset: 0x003D3369
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A660 RID: 108128 RVA: 0x003D5176 File Offset: 0x003D3376
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A661 RID: 108129 RVA: 0x003D517F File Offset: 0x003D337F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A662 RID: 108130 RVA: 0x003D51B4 File Offset: 0x003D33B4
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

		// Token: 0x0601A663 RID: 108131 RVA: 0x003D51F2 File Offset: 0x003D33F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ThrowDamageResponse other)
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

		// Token: 0x0601A664 RID: 108132 RVA: 0x003D5223 File Offset: 0x003D3423
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A665 RID: 108133 RVA: 0x003D522C File Offset: 0x003D342C
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040099B7 RID: 39351
		private UnknownFieldSet _unknownFields;

		// Token: 0x040099B8 RID: 39352
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x040099B9 RID: 39353
		private ErrorCode errorCode_;
	}
}
