using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200023F RID: 575
	[NetMessage(EMessageId.CaughtResponse)]
	public sealed class CaughtResponse : IMessage<CaughtResponse>, IMessage, IEquatable<CaughtResponse>, IDeepCloneable<CaughtResponse>, IBufferMessage
	{
		// Token: 0x06003DD7 RID: 15831 RVA: 0x00098FC8 File Offset: 0x000971C8
		[NullableContext(1)]
		public static CaughtResponse Create()
		{
			return new CaughtResponse();
		}

		// Token: 0x17000A52 RID: 2642
		// (get) Token: 0x06003DD8 RID: 15832 RVA: 0x00098FCF File Offset: 0x000971CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A53 RID: 2643
		// (get) Token: 0x06003DD9 RID: 15833 RVA: 0x00098FD2 File Offset: 0x000971D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CaughtResponse.Descriptor;
			}
		}

		// Token: 0x06003DDA RID: 15834 RVA: 0x00098FD9 File Offset: 0x000971D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CaughtResponse()
		{
		}

		// Token: 0x06003DDB RID: 15835 RVA: 0x00098FE1 File Offset: 0x000971E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CaughtResponse(CaughtResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003DDC RID: 15836 RVA: 0x00099006 File Offset: 0x00097206
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CaughtResponse Clone()
		{
			return new CaughtResponse(this);
		}

		// Token: 0x17000A54 RID: 2644
		// (get) Token: 0x06003DDD RID: 15837 RVA: 0x0009900E File Offset: 0x0009720E
		// (set) Token: 0x06003DDE RID: 15838 RVA: 0x00099016 File Offset: 0x00097216
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

		// Token: 0x06003DDF RID: 15839 RVA: 0x0009901F File Offset: 0x0009721F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CaughtResponse);
		}

		// Token: 0x06003DE0 RID: 15840 RVA: 0x0009902D File Offset: 0x0009722D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CaughtResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003DE1 RID: 15841 RVA: 0x0009905C File Offset: 0x0009725C
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

		// Token: 0x06003DE2 RID: 15842 RVA: 0x000990A1 File Offset: 0x000972A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003DE3 RID: 15843 RVA: 0x000990AE File Offset: 0x000972AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003DE4 RID: 15844 RVA: 0x000990B7 File Offset: 0x000972B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003DE5 RID: 15845 RVA: 0x000990EC File Offset: 0x000972EC
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

		// Token: 0x06003DE6 RID: 15846 RVA: 0x0009912A File Offset: 0x0009732A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CaughtResponse other)
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

		// Token: 0x06003DE7 RID: 15847 RVA: 0x0009915B File Offset: 0x0009735B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003DE8 RID: 15848 RVA: 0x00099164 File Offset: 0x00097364
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002CC3 RID: 11459
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002CC4 RID: 11460
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x04002CC5 RID: 11461
		private ErrorCode errorCode_;
	}
}
