using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200021F RID: 543
	[NetMessage(EMessageId.CalabashLevelRewardResponse)]
	public sealed class CalabashLevelRewardResponse : IMessage<CalabashLevelRewardResponse>, IMessage, IEquatable<CalabashLevelRewardResponse>, IDeepCloneable<CalabashLevelRewardResponse>, IBufferMessage
	{
		// Token: 0x06003B5C RID: 15196 RVA: 0x00093C11 File Offset: 0x00091E11
		[NullableContext(1)]
		public static CalabashLevelRewardResponse Create()
		{
			return new CalabashLevelRewardResponse();
		}

		// Token: 0x170009D4 RID: 2516
		// (get) Token: 0x06003B5D RID: 15197 RVA: 0x00093C18 File Offset: 0x00091E18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170009D5 RID: 2517
		// (get) Token: 0x06003B5E RID: 15198 RVA: 0x00093C1B File Offset: 0x00091E1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CalabashLevelRewardResponse.Descriptor;
			}
		}

		// Token: 0x06003B5F RID: 15199 RVA: 0x00093C22 File Offset: 0x00091E22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashLevelRewardResponse()
		{
		}

		// Token: 0x06003B60 RID: 15200 RVA: 0x00093C2A File Offset: 0x00091E2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashLevelRewardResponse(CalabashLevelRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003B61 RID: 15201 RVA: 0x00093C4F File Offset: 0x00091E4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashLevelRewardResponse Clone()
		{
			return new CalabashLevelRewardResponse(this);
		}

		// Token: 0x170009D6 RID: 2518
		// (get) Token: 0x06003B62 RID: 15202 RVA: 0x00093C57 File Offset: 0x00091E57
		// (set) Token: 0x06003B63 RID: 15203 RVA: 0x00093C5F File Offset: 0x00091E5F
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

		// Token: 0x06003B64 RID: 15204 RVA: 0x00093C68 File Offset: 0x00091E68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CalabashLevelRewardResponse);
		}

		// Token: 0x06003B65 RID: 15205 RVA: 0x00093C76 File Offset: 0x00091E76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CalabashLevelRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003B66 RID: 15206 RVA: 0x00093CA4 File Offset: 0x00091EA4
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

		// Token: 0x06003B67 RID: 15207 RVA: 0x00093CE9 File Offset: 0x00091EE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003B68 RID: 15208 RVA: 0x00093CF6 File Offset: 0x00091EF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003B69 RID: 15209 RVA: 0x00093CFF File Offset: 0x00091EFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003B6A RID: 15210 RVA: 0x00093D34 File Offset: 0x00091F34
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

		// Token: 0x06003B6B RID: 15211 RVA: 0x00093D72 File Offset: 0x00091F72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CalabashLevelRewardResponse other)
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

		// Token: 0x06003B6C RID: 15212 RVA: 0x00093DA3 File Offset: 0x00091FA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003B6D RID: 15213 RVA: 0x00093DAC File Offset: 0x00091FAC
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002C22 RID: 11298
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C23 RID: 11299
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04002C24 RID: 11300
		private ErrorCode errorCode_;
	}
}
