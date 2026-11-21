using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B1C RID: 2844
	[NetMessage(EMessageId.NewTowerClearRecordResponse)]
	public sealed class NewTowerClearRecordResponse : IMessage<NewTowerClearRecordResponse>, IMessage, IEquatable<NewTowerClearRecordResponse>, IDeepCloneable<NewTowerClearRecordResponse>, IBufferMessage
	{
		// Token: 0x0600F738 RID: 63288 RVA: 0x002412E5 File Offset: 0x0023F4E5
		[NullableContext(1)]
		public static NewTowerClearRecordResponse Create()
		{
			return new NewTowerClearRecordResponse();
		}

		// Token: 0x17003259 RID: 12889
		// (get) Token: 0x0600F739 RID: 63289 RVA: 0x002412EC File Offset: 0x0023F4EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700325A RID: 12890
		// (get) Token: 0x0600F73A RID: 63290 RVA: 0x002412EF File Offset: 0x0023F4EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerClearRecordResponse.Descriptor;
			}
		}

		// Token: 0x0600F73B RID: 63291 RVA: 0x002412F6 File Offset: 0x0023F4F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerClearRecordResponse()
		{
		}

		// Token: 0x0600F73C RID: 63292 RVA: 0x002412FE File Offset: 0x0023F4FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerClearRecordResponse(NewTowerClearRecordResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F73D RID: 63293 RVA: 0x00241323 File Offset: 0x0023F523
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerClearRecordResponse Clone()
		{
			return new NewTowerClearRecordResponse(this);
		}

		// Token: 0x1700325B RID: 12891
		// (get) Token: 0x0600F73E RID: 63294 RVA: 0x0024132B File Offset: 0x0023F52B
		// (set) Token: 0x0600F73F RID: 63295 RVA: 0x00241333 File Offset: 0x0023F533
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

		// Token: 0x0600F740 RID: 63296 RVA: 0x0024133C File Offset: 0x0023F53C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerClearRecordResponse);
		}

		// Token: 0x0600F741 RID: 63297 RVA: 0x0024134A File Offset: 0x0023F54A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerClearRecordResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F742 RID: 63298 RVA: 0x00241378 File Offset: 0x0023F578
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

		// Token: 0x0600F743 RID: 63299 RVA: 0x002413BD File Offset: 0x0023F5BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F744 RID: 63300 RVA: 0x002413CA File Offset: 0x0023F5CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F745 RID: 63301 RVA: 0x002413D3 File Offset: 0x0023F5D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F746 RID: 63302 RVA: 0x00241408 File Offset: 0x0023F608
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

		// Token: 0x0600F747 RID: 63303 RVA: 0x00241446 File Offset: 0x0023F646
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewTowerClearRecordResponse other)
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

		// Token: 0x0600F748 RID: 63304 RVA: 0x00241477 File Offset: 0x0023F677
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F749 RID: 63305 RVA: 0x00241480 File Offset: 0x0023F680
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04006394 RID: 25492
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006395 RID: 25493
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04006396 RID: 25494
		private ErrorCode errorCode_;
	}
}
