using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001148 RID: 4424
	[NetMessage(EMessageId.RoverRogueLootChangeResponse)]
	public sealed class RoverRogueLootChangeResponse : IMessage<RoverRogueLootChangeResponse>, IMessage, IEquatable<RoverRogueLootChangeResponse>, IDeepCloneable<RoverRogueLootChangeResponse>, IBufferMessage
	{
		// Token: 0x06017A37 RID: 96823 RVA: 0x00370D3F File Offset: 0x0036EF3F
		[NullableContext(1)]
		public static RoverRogueLootChangeResponse Create()
		{
			return new RoverRogueLootChangeResponse();
		}

		// Token: 0x17004F84 RID: 20356
		// (get) Token: 0x06017A38 RID: 96824 RVA: 0x00370D46 File Offset: 0x0036EF46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004F85 RID: 20357
		// (get) Token: 0x06017A39 RID: 96825 RVA: 0x00370D49 File Offset: 0x0036EF49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueLootChangeResponse.Descriptor;
			}
		}

		// Token: 0x06017A3A RID: 96826 RVA: 0x00370D50 File Offset: 0x0036EF50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueLootChangeResponse()
		{
		}

		// Token: 0x06017A3B RID: 96827 RVA: 0x00370D58 File Offset: 0x0036EF58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueLootChangeResponse(RoverRogueLootChangeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017A3C RID: 96828 RVA: 0x00370D7D File Offset: 0x0036EF7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueLootChangeResponse Clone()
		{
			return new RoverRogueLootChangeResponse(this);
		}

		// Token: 0x17004F86 RID: 20358
		// (get) Token: 0x06017A3D RID: 96829 RVA: 0x00370D85 File Offset: 0x0036EF85
		// (set) Token: 0x06017A3E RID: 96830 RVA: 0x00370D8D File Offset: 0x0036EF8D
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

		// Token: 0x06017A3F RID: 96831 RVA: 0x00370D96 File Offset: 0x0036EF96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueLootChangeResponse);
		}

		// Token: 0x06017A40 RID: 96832 RVA: 0x00370DA4 File Offset: 0x0036EFA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueLootChangeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017A41 RID: 96833 RVA: 0x00370DD4 File Offset: 0x0036EFD4
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

		// Token: 0x06017A42 RID: 96834 RVA: 0x00370E19 File Offset: 0x0036F019
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017A43 RID: 96835 RVA: 0x00370E26 File Offset: 0x0036F026
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017A44 RID: 96836 RVA: 0x00370E2F File Offset: 0x0036F02F
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

		// Token: 0x06017A45 RID: 96837 RVA: 0x00370E64 File Offset: 0x0036F064
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

		// Token: 0x06017A46 RID: 96838 RVA: 0x00370EA2 File Offset: 0x0036F0A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueLootChangeResponse other)
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

		// Token: 0x06017A47 RID: 96839 RVA: 0x00370ED3 File Offset: 0x0036F0D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017A48 RID: 96840 RVA: 0x00370EDC File Offset: 0x0036F0DC
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

		// Token: 0x04008D1B RID: 36123
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008D1C RID: 36124
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04008D1D RID: 36125
		private ErrorCode errorCode_;
	}
}
