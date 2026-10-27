using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D18 RID: 3352
	[NetMessage(EMessageId.PhBaPlanBatchOperResponse)]
	public sealed class PhBaPlanBatchOperResponse : IMessage<PhBaPlanBatchOperResponse>, IMessage, IEquatable<PhBaPlanBatchOperResponse>, IDeepCloneable<PhBaPlanBatchOperResponse>, IBufferMessage
	{
		// Token: 0x060121BB RID: 74171 RVA: 0x002A5535 File Offset: 0x002A3735
		[NullableContext(1)]
		public static PhBaPlanBatchOperResponse Create()
		{
			return new PhBaPlanBatchOperResponse();
		}

		// Token: 0x17003C01 RID: 15361
		// (get) Token: 0x060121BC RID: 74172 RVA: 0x002A553C File Offset: 0x002A373C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003C02 RID: 15362
		// (get) Token: 0x060121BD RID: 74173 RVA: 0x002A553F File Offset: 0x002A373F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhBaPlanBatchOperResponse.Descriptor;
			}
		}

		// Token: 0x060121BE RID: 74174 RVA: 0x002A5546 File Offset: 0x002A3746
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanBatchOperResponse()
		{
		}

		// Token: 0x060121BF RID: 74175 RVA: 0x002A554E File Offset: 0x002A374E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanBatchOperResponse(PhBaPlanBatchOperResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060121C0 RID: 74176 RVA: 0x002A5573 File Offset: 0x002A3773
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanBatchOperResponse Clone()
		{
			return new PhBaPlanBatchOperResponse(this);
		}

		// Token: 0x17003C03 RID: 15363
		// (get) Token: 0x060121C1 RID: 74177 RVA: 0x002A557B File Offset: 0x002A377B
		// (set) Token: 0x060121C2 RID: 74178 RVA: 0x002A5583 File Offset: 0x002A3783
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrCode
		{
			get
			{
				return this.errCode_;
			}
			set
			{
				this.errCode_ = value;
			}
		}

		// Token: 0x060121C3 RID: 74179 RVA: 0x002A558C File Offset: 0x002A378C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhBaPlanBatchOperResponse);
		}

		// Token: 0x060121C4 RID: 74180 RVA: 0x002A559A File Offset: 0x002A379A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhBaPlanBatchOperResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060121C5 RID: 74181 RVA: 0x002A55C8 File Offset: 0x002A37C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060121C6 RID: 74182 RVA: 0x002A560D File Offset: 0x002A380D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060121C7 RID: 74183 RVA: 0x002A561A File Offset: 0x002A381A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060121C8 RID: 74184 RVA: 0x002A5623 File Offset: 0x002A3823
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060121C9 RID: 74185 RVA: 0x002A5658 File Offset: 0x002A3858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060121CA RID: 74186 RVA: 0x002A5696 File Offset: 0x002A3896
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhBaPlanBatchOperResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060121CB RID: 74187 RVA: 0x002A56C7 File Offset: 0x002A38C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060121CC RID: 74188 RVA: 0x002A56D0 File Offset: 0x002A38D0
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
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007141 RID: 28993
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007142 RID: 28994
		public const int ErrCodeFieldNumber = 9;

		// Token: 0x04007143 RID: 28995
		private ErrorCode errCode_;
	}
}
