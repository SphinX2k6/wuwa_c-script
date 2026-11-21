using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001324 RID: 4900
	[NetMessage(EMessageId.SummonResponse)]
	public sealed class SummonResponse : IMessage<SummonResponse>, IMessage, IEquatable<SummonResponse>, IDeepCloneable<SummonResponse>, IBufferMessage
	{
		// Token: 0x0601A1F4 RID: 106996 RVA: 0x003CEA09 File Offset: 0x003CCC09
		[NullableContext(1)]
		public static SummonResponse Create()
		{
			return new SummonResponse();
		}

		// Token: 0x17005871 RID: 22641
		// (get) Token: 0x0601A1F5 RID: 106997 RVA: 0x003CEA10 File Offset: 0x003CCC10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005872 RID: 22642
		// (get) Token: 0x0601A1F6 RID: 106998 RVA: 0x003CEA13 File Offset: 0x003CCC13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SummonResponse.Descriptor;
			}
		}

		// Token: 0x0601A1F7 RID: 106999 RVA: 0x003CEA1A File Offset: 0x003CCC1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SummonResponse()
		{
		}

		// Token: 0x0601A1F8 RID: 107000 RVA: 0x003CEA22 File Offset: 0x003CCC22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SummonResponse(SummonResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A1F9 RID: 107001 RVA: 0x003CEA47 File Offset: 0x003CCC47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SummonResponse Clone()
		{
			return new SummonResponse(this);
		}

		// Token: 0x17005873 RID: 22643
		// (get) Token: 0x0601A1FA RID: 107002 RVA: 0x003CEA4F File Offset: 0x003CCC4F
		// (set) Token: 0x0601A1FB RID: 107003 RVA: 0x003CEA57 File Offset: 0x003CCC57
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

		// Token: 0x0601A1FC RID: 107004 RVA: 0x003CEA60 File Offset: 0x003CCC60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SummonResponse);
		}

		// Token: 0x0601A1FD RID: 107005 RVA: 0x003CEA6E File Offset: 0x003CCC6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SummonResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A1FE RID: 107006 RVA: 0x003CEA9C File Offset: 0x003CCC9C
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

		// Token: 0x0601A1FF RID: 107007 RVA: 0x003CEAE1 File Offset: 0x003CCCE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A200 RID: 107008 RVA: 0x003CEAEE File Offset: 0x003CCCEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A201 RID: 107009 RVA: 0x003CEAF7 File Offset: 0x003CCCF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A202 RID: 107010 RVA: 0x003CEB2C File Offset: 0x003CCD2C
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

		// Token: 0x0601A203 RID: 107011 RVA: 0x003CEB6A File Offset: 0x003CCD6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SummonResponse other)
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

		// Token: 0x0601A204 RID: 107012 RVA: 0x003CEB9B File Offset: 0x003CCD9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A205 RID: 107013 RVA: 0x003CEBA4 File Offset: 0x003CCDA4
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
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040099B2 RID: 39346
		private UnknownFieldSet _unknownFields;

		// Token: 0x040099B3 RID: 39347
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x040099B4 RID: 39348
		private ErrorCode errorCode_;
	}
}
