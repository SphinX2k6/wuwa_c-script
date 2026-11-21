using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005D8 RID: 1496
	[NetMessage(EMessageId.FloroRanchUnlockTechPointResponse)]
	public sealed class FloroRanchUnlockTechPointResponse : IMessage<FloroRanchUnlockTechPointResponse>, IMessage, IEquatable<FloroRanchUnlockTechPointResponse>, IDeepCloneable<FloroRanchUnlockTechPointResponse>, IBufferMessage
	{
		// Token: 0x06008B0E RID: 35598 RVA: 0x00151B2C File Offset: 0x0014FD2C
		[NullableContext(1)]
		public static FloroRanchUnlockTechPointResponse Create()
		{
			return new FloroRanchUnlockTechPointResponse();
		}

		// Token: 0x17001B83 RID: 7043
		// (get) Token: 0x06008B0F RID: 35599 RVA: 0x00151B33 File Offset: 0x0014FD33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001B84 RID: 7044
		// (get) Token: 0x06008B10 RID: 35600 RVA: 0x00151B36 File Offset: 0x0014FD36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchUnlockTechPointResponse.Descriptor;
			}
		}

		// Token: 0x06008B11 RID: 35601 RVA: 0x00151B3D File Offset: 0x0014FD3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchUnlockTechPointResponse()
		{
		}

		// Token: 0x06008B12 RID: 35602 RVA: 0x00151B45 File Offset: 0x0014FD45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchUnlockTechPointResponse(FloroRanchUnlockTechPointResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008B13 RID: 35603 RVA: 0x00151B6A File Offset: 0x0014FD6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchUnlockTechPointResponse Clone()
		{
			return new FloroRanchUnlockTechPointResponse(this);
		}

		// Token: 0x17001B85 RID: 7045
		// (get) Token: 0x06008B14 RID: 35604 RVA: 0x00151B72 File Offset: 0x0014FD72
		// (set) Token: 0x06008B15 RID: 35605 RVA: 0x00151B7A File Offset: 0x0014FD7A
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

		// Token: 0x06008B16 RID: 35606 RVA: 0x00151B83 File Offset: 0x0014FD83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchUnlockTechPointResponse);
		}

		// Token: 0x06008B17 RID: 35607 RVA: 0x00151B91 File Offset: 0x0014FD91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchUnlockTechPointResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008B18 RID: 35608 RVA: 0x00151BC0 File Offset: 0x0014FDC0
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

		// Token: 0x06008B19 RID: 35609 RVA: 0x00151C05 File Offset: 0x0014FE05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008B1A RID: 35610 RVA: 0x00151C12 File Offset: 0x0014FE12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008B1B RID: 35611 RVA: 0x00151C1B File Offset: 0x0014FE1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008B1C RID: 35612 RVA: 0x00151C4C File Offset: 0x0014FE4C
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

		// Token: 0x06008B1D RID: 35613 RVA: 0x00151C8A File Offset: 0x0014FE8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchUnlockTechPointResponse other)
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

		// Token: 0x06008B1E RID: 35614 RVA: 0x00151CBB File Offset: 0x0014FEBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008B1F RID: 35615 RVA: 0x00151CC4 File Offset: 0x0014FEC4
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040044B8 RID: 17592
		private UnknownFieldSet _unknownFields;

		// Token: 0x040044B9 RID: 17593
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x040044BA RID: 17594
		private ErrorCode errorCode_;
	}
}
