using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009D3 RID: 2515
	[NetMessage(EMessageId.MobileButtonSettingUpdateResponse)]
	public sealed class MobileButtonSettingUpdateResponse : IMessage<MobileButtonSettingUpdateResponse>, IMessage, IEquatable<MobileButtonSettingUpdateResponse>, IDeepCloneable<MobileButtonSettingUpdateResponse>, IBufferMessage
	{
		// Token: 0x0600DCC5 RID: 56517 RVA: 0x00206989 File Offset: 0x00204B89
		[NullableContext(1)]
		public static MobileButtonSettingUpdateResponse Create()
		{
			return new MobileButtonSettingUpdateResponse();
		}

		// Token: 0x17002CBB RID: 11451
		// (get) Token: 0x0600DCC6 RID: 56518 RVA: 0x00206990 File Offset: 0x00204B90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002CBC RID: 11452
		// (get) Token: 0x0600DCC7 RID: 56519 RVA: 0x00206993 File Offset: 0x00204B93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MobileButtonSettingUpdateResponse.Descriptor;
			}
		}

		// Token: 0x0600DCC8 RID: 56520 RVA: 0x0020699A File Offset: 0x00204B9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MobileButtonSettingUpdateResponse()
		{
		}

		// Token: 0x0600DCC9 RID: 56521 RVA: 0x002069A2 File Offset: 0x00204BA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MobileButtonSettingUpdateResponse(MobileButtonSettingUpdateResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DCCA RID: 56522 RVA: 0x002069C7 File Offset: 0x00204BC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MobileButtonSettingUpdateResponse Clone()
		{
			return new MobileButtonSettingUpdateResponse(this);
		}

		// Token: 0x17002CBD RID: 11453
		// (get) Token: 0x0600DCCB RID: 56523 RVA: 0x002069CF File Offset: 0x00204BCF
		// (set) Token: 0x0600DCCC RID: 56524 RVA: 0x002069D7 File Offset: 0x00204BD7
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

		// Token: 0x0600DCCD RID: 56525 RVA: 0x002069E0 File Offset: 0x00204BE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MobileButtonSettingUpdateResponse);
		}

		// Token: 0x0600DCCE RID: 56526 RVA: 0x002069EE File Offset: 0x00204BEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MobileButtonSettingUpdateResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DCCF RID: 56527 RVA: 0x00206A1C File Offset: 0x00204C1C
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

		// Token: 0x0600DCD0 RID: 56528 RVA: 0x00206A61 File Offset: 0x00204C61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DCD1 RID: 56529 RVA: 0x00206A6E File Offset: 0x00204C6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DCD2 RID: 56530 RVA: 0x00206A77 File Offset: 0x00204C77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DCD3 RID: 56531 RVA: 0x00206AAC File Offset: 0x00204CAC
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

		// Token: 0x0600DCD4 RID: 56532 RVA: 0x00206AEA File Offset: 0x00204CEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MobileButtonSettingUpdateResponse other)
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

		// Token: 0x0600DCD5 RID: 56533 RVA: 0x00206B1B File Offset: 0x00204D1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DCD6 RID: 56534 RVA: 0x00206B24 File Offset: 0x00204D24
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005BBB RID: 23483
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005BBC RID: 23484
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x04005BBD RID: 23485
		private ErrorCode errorCode_;
	}
}
