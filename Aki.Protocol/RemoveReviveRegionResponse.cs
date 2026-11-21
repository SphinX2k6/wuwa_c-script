using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EF9 RID: 3833
	[NetMessage(EMessageId.RemoveReviveRegionResponse)]
	public sealed class RemoveReviveRegionResponse : IMessage<RemoveReviveRegionResponse>, IMessage, IEquatable<RemoveReviveRegionResponse>, IDeepCloneable<RemoveReviveRegionResponse>, IBufferMessage
	{
		// Token: 0x060148EB RID: 84203 RVA: 0x002FCE19 File Offset: 0x002FB019
		[NullableContext(1)]
		public static RemoveReviveRegionResponse Create()
		{
			return new RemoveReviveRegionResponse();
		}

		// Token: 0x1700445F RID: 17503
		// (get) Token: 0x060148EC RID: 84204 RVA: 0x002FCE20 File Offset: 0x002FB020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004460 RID: 17504
		// (get) Token: 0x060148ED RID: 84205 RVA: 0x002FCE23 File Offset: 0x002FB023
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemoveReviveRegionResponse.Descriptor;
			}
		}

		// Token: 0x060148EE RID: 84206 RVA: 0x002FCE2A File Offset: 0x002FB02A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveReviveRegionResponse()
		{
		}

		// Token: 0x060148EF RID: 84207 RVA: 0x002FCE32 File Offset: 0x002FB032
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveReviveRegionResponse(RemoveReviveRegionResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060148F0 RID: 84208 RVA: 0x002FCE57 File Offset: 0x002FB057
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveReviveRegionResponse Clone()
		{
			return new RemoveReviveRegionResponse(this);
		}

		// Token: 0x17004461 RID: 17505
		// (get) Token: 0x060148F1 RID: 84209 RVA: 0x002FCE5F File Offset: 0x002FB05F
		// (set) Token: 0x060148F2 RID: 84210 RVA: 0x002FCE67 File Offset: 0x002FB067
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

		// Token: 0x060148F3 RID: 84211 RVA: 0x002FCE70 File Offset: 0x002FB070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemoveReviveRegionResponse);
		}

		// Token: 0x060148F4 RID: 84212 RVA: 0x002FCE7E File Offset: 0x002FB07E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RemoveReviveRegionResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060148F5 RID: 84213 RVA: 0x002FCEAC File Offset: 0x002FB0AC
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

		// Token: 0x060148F6 RID: 84214 RVA: 0x002FCEF1 File Offset: 0x002FB0F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060148F7 RID: 84215 RVA: 0x002FCEFE File Offset: 0x002FB0FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060148F8 RID: 84216 RVA: 0x002FCF07 File Offset: 0x002FB107
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

		// Token: 0x060148F9 RID: 84217 RVA: 0x002FCF3C File Offset: 0x002FB13C
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

		// Token: 0x060148FA RID: 84218 RVA: 0x002FCF7A File Offset: 0x002FB17A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RemoveReviveRegionResponse other)
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

		// Token: 0x060148FB RID: 84219 RVA: 0x002FCFAB File Offset: 0x002FB1AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060148FC RID: 84220 RVA: 0x002FCFB4 File Offset: 0x002FB1B4
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

		// Token: 0x04007CF1 RID: 31985
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007CF2 RID: 31986
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x04007CF3 RID: 31987
		private ErrorCode errorCode_;
	}
}
