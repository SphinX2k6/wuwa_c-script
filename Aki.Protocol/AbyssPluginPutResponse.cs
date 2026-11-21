using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000036 RID: 54
	[NetMessage(EMessageId.AbyssPluginPutResponse)]
	public sealed class AbyssPluginPutResponse : IMessage<AbyssPluginPutResponse>, IMessage, IEquatable<AbyssPluginPutResponse>, IDeepCloneable<AbyssPluginPutResponse>, IBufferMessage
	{
		// Token: 0x060012F8 RID: 4856 RVA: 0x00033D7C File Offset: 0x00031F7C
		[NullableContext(1)]
		public static AbyssPluginPutResponse Create()
		{
			return new AbyssPluginPutResponse();
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060012F9 RID: 4857 RVA: 0x00033D83 File Offset: 0x00031F83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060012FA RID: 4858 RVA: 0x00033D86 File Offset: 0x00031F86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssPluginPutResponse.Descriptor;
			}
		}

		// Token: 0x060012FB RID: 4859 RVA: 0x00033D8D File Offset: 0x00031F8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssPluginPutResponse()
		{
		}

		// Token: 0x060012FC RID: 4860 RVA: 0x00033D95 File Offset: 0x00031F95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssPluginPutResponse(AbyssPluginPutResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060012FD RID: 4861 RVA: 0x00033DBA File Offset: 0x00031FBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssPluginPutResponse Clone()
		{
			return new AbyssPluginPutResponse(this);
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060012FE RID: 4862 RVA: 0x00033DC2 File Offset: 0x00031FC2
		// (set) Token: 0x060012FF RID: 4863 RVA: 0x00033DCA File Offset: 0x00031FCA
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

		// Token: 0x06001300 RID: 4864 RVA: 0x00033DD3 File Offset: 0x00031FD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssPluginPutResponse);
		}

		// Token: 0x06001301 RID: 4865 RVA: 0x00033DE1 File Offset: 0x00031FE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssPluginPutResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001302 RID: 4866 RVA: 0x00033E10 File Offset: 0x00032010
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

		// Token: 0x06001303 RID: 4867 RVA: 0x00033E55 File Offset: 0x00032055
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001304 RID: 4868 RVA: 0x00033E62 File Offset: 0x00032062
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001305 RID: 4869 RVA: 0x00033E6B File Offset: 0x0003206B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001306 RID: 4870 RVA: 0x00033EA0 File Offset: 0x000320A0
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

		// Token: 0x06001307 RID: 4871 RVA: 0x00033EDE File Offset: 0x000320DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AbyssPluginPutResponse other)
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

		// Token: 0x06001308 RID: 4872 RVA: 0x00033F0F File Offset: 0x0003210F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001309 RID: 4873 RVA: 0x00033F18 File Offset: 0x00032118
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400203C RID: 8252
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400203D RID: 8253
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x0400203E RID: 8254
		private ErrorCode errorCode_;
	}
}
