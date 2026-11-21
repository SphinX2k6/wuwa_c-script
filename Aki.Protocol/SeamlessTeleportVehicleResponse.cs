using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011E3 RID: 4579
	[NetMessage(EMessageId.SeamlessTeleportVehicleResponse)]
	public sealed class SeamlessTeleportVehicleResponse : IMessage<SeamlessTeleportVehicleResponse>, IMessage, IEquatable<SeamlessTeleportVehicleResponse>, IDeepCloneable<SeamlessTeleportVehicleResponse>, IBufferMessage
	{
		// Token: 0x06018711 RID: 100113 RVA: 0x0038ED4C File Offset: 0x0038CF4C
		[NullableContext(1)]
		public static SeamlessTeleportVehicleResponse Create()
		{
			return new SeamlessTeleportVehicleResponse();
		}

		// Token: 0x17005264 RID: 21092
		// (get) Token: 0x06018712 RID: 100114 RVA: 0x0038ED53 File Offset: 0x0038CF53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005265 RID: 21093
		// (get) Token: 0x06018713 RID: 100115 RVA: 0x0038ED56 File Offset: 0x0038CF56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SeamlessTeleportVehicleResponse.Descriptor;
			}
		}

		// Token: 0x06018714 RID: 100116 RVA: 0x0038ED5D File Offset: 0x0038CF5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SeamlessTeleportVehicleResponse()
		{
		}

		// Token: 0x06018715 RID: 100117 RVA: 0x0038ED65 File Offset: 0x0038CF65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SeamlessTeleportVehicleResponse(SeamlessTeleportVehicleResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018716 RID: 100118 RVA: 0x0038ED8A File Offset: 0x0038CF8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SeamlessTeleportVehicleResponse Clone()
		{
			return new SeamlessTeleportVehicleResponse(this);
		}

		// Token: 0x17005266 RID: 21094
		// (get) Token: 0x06018717 RID: 100119 RVA: 0x0038ED92 File Offset: 0x0038CF92
		// (set) Token: 0x06018718 RID: 100120 RVA: 0x0038ED9A File Offset: 0x0038CF9A
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

		// Token: 0x06018719 RID: 100121 RVA: 0x0038EDA3 File Offset: 0x0038CFA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SeamlessTeleportVehicleResponse);
		}

		// Token: 0x0601871A RID: 100122 RVA: 0x0038EDB1 File Offset: 0x0038CFB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SeamlessTeleportVehicleResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601871B RID: 100123 RVA: 0x0038EDE0 File Offset: 0x0038CFE0
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

		// Token: 0x0601871C RID: 100124 RVA: 0x0038EE25 File Offset: 0x0038D025
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601871D RID: 100125 RVA: 0x0038EE32 File Offset: 0x0038D032
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601871E RID: 100126 RVA: 0x0038EE3B File Offset: 0x0038D03B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601871F RID: 100127 RVA: 0x0038EE70 File Offset: 0x0038D070
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

		// Token: 0x06018720 RID: 100128 RVA: 0x0038EEAE File Offset: 0x0038D0AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SeamlessTeleportVehicleResponse other)
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

		// Token: 0x06018721 RID: 100129 RVA: 0x0038EEDF File Offset: 0x0038D0DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018722 RID: 100130 RVA: 0x0038EEE8 File Offset: 0x0038D0E8
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009127 RID: 37159
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009128 RID: 37160
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04009129 RID: 37161
		private ErrorCode errorCode_;
	}
}
