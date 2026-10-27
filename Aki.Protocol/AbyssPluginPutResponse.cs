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
		// Token: 0x060012CD RID: 4813 RVA: 0x000337C8 File Offset: 0x000319C8
		[NullableContext(1)]
		public static AbyssPluginPutResponse Create()
		{
			return new AbyssPluginPutResponse();
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060012CE RID: 4814 RVA: 0x000337CF File Offset: 0x000319CF
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
		// (get) Token: 0x060012CF RID: 4815 RVA: 0x000337D2 File Offset: 0x000319D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssPluginPutResponse.Descriptor;
			}
		}

		// Token: 0x060012D0 RID: 4816 RVA: 0x000337D9 File Offset: 0x000319D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssPluginPutResponse()
		{
		}

		// Token: 0x060012D1 RID: 4817 RVA: 0x000337E1 File Offset: 0x000319E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssPluginPutResponse(AbyssPluginPutResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060012D2 RID: 4818 RVA: 0x00033806 File Offset: 0x00031A06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssPluginPutResponse Clone()
		{
			return new AbyssPluginPutResponse(this);
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060012D3 RID: 4819 RVA: 0x0003380E File Offset: 0x00031A0E
		// (set) Token: 0x060012D4 RID: 4820 RVA: 0x00033816 File Offset: 0x00031A16
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

		// Token: 0x060012D5 RID: 4821 RVA: 0x0003381F File Offset: 0x00031A1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssPluginPutResponse);
		}

		// Token: 0x060012D6 RID: 4822 RVA: 0x0003382D File Offset: 0x00031A2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssPluginPutResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060012D7 RID: 4823 RVA: 0x0003385C File Offset: 0x00031A5C
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

		// Token: 0x060012D8 RID: 4824 RVA: 0x000338A1 File Offset: 0x00031AA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060012D9 RID: 4825 RVA: 0x000338AE File Offset: 0x00031AAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060012DA RID: 4826 RVA: 0x000338B7 File Offset: 0x00031AB7
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

		// Token: 0x060012DB RID: 4827 RVA: 0x000338EC File Offset: 0x00031AEC
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

		// Token: 0x060012DC RID: 4828 RVA: 0x0003392A File Offset: 0x00031B2A
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

		// Token: 0x060012DD RID: 4829 RVA: 0x0003395B File Offset: 0x00031B5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060012DE RID: 4830 RVA: 0x00033964 File Offset: 0x00031B64
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

		// Token: 0x04001FE6 RID: 8166
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001FE7 RID: 8167
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x04001FE8 RID: 8168
		private ErrorCode errorCode_;
	}
}
