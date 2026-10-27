using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000AD RID: 173
	[NetMessage(EMessageId.AddReviveRegionResponse)]
	public sealed class AddReviveRegionResponse : IMessage<AddReviveRegionResponse>, IMessage, IEquatable<AddReviveRegionResponse>, IDeepCloneable<AddReviveRegionResponse>, IBufferMessage
	{
		// Token: 0x06001D41 RID: 7489 RVA: 0x00050935 File Offset: 0x0004EB35
		[NullableContext(1)]
		public static AddReviveRegionResponse Create()
		{
			return new AddReviveRegionResponse();
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x06001D42 RID: 7490 RVA: 0x0005093C File Offset: 0x0004EB3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06001D43 RID: 7491 RVA: 0x0005093F File Offset: 0x0004EB3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AddReviveRegionResponse.Descriptor;
			}
		}

		// Token: 0x06001D44 RID: 7492 RVA: 0x00050946 File Offset: 0x0004EB46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddReviveRegionResponse()
		{
		}

		// Token: 0x06001D45 RID: 7493 RVA: 0x0005094E File Offset: 0x0004EB4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddReviveRegionResponse(AddReviveRegionResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001D46 RID: 7494 RVA: 0x00050973 File Offset: 0x0004EB73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddReviveRegionResponse Clone()
		{
			return new AddReviveRegionResponse(this);
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x06001D47 RID: 7495 RVA: 0x0005097B File Offset: 0x0004EB7B
		// (set) Token: 0x06001D48 RID: 7496 RVA: 0x00050983 File Offset: 0x0004EB83
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

		// Token: 0x06001D49 RID: 7497 RVA: 0x0005098C File Offset: 0x0004EB8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AddReviveRegionResponse);
		}

		// Token: 0x06001D4A RID: 7498 RVA: 0x0005099A File Offset: 0x0004EB9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AddReviveRegionResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001D4B RID: 7499 RVA: 0x000509C8 File Offset: 0x0004EBC8
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

		// Token: 0x06001D4C RID: 7500 RVA: 0x00050A0D File Offset: 0x0004EC0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001D4D RID: 7501 RVA: 0x00050A1A File Offset: 0x0004EC1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001D4E RID: 7502 RVA: 0x00050A23 File Offset: 0x0004EC23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001D4F RID: 7503 RVA: 0x00050A58 File Offset: 0x0004EC58
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

		// Token: 0x06001D50 RID: 7504 RVA: 0x00050A96 File Offset: 0x0004EC96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AddReviveRegionResponse other)
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

		// Token: 0x06001D51 RID: 7505 RVA: 0x00050AC7 File Offset: 0x0004ECC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001D52 RID: 7506 RVA: 0x00050AD0 File Offset: 0x0004ECD0
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002311 RID: 8977
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002312 RID: 8978
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04002313 RID: 8979
		private ErrorCode errorCode_;
	}
}
