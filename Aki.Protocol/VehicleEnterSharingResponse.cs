using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001542 RID: 5442
	[NetMessage(EMessageId.VehicleEnterSharingResponse)]
	public sealed class VehicleEnterSharingResponse : IMessage<VehicleEnterSharingResponse>, IMessage, IEquatable<VehicleEnterSharingResponse>, IDeepCloneable<VehicleEnterSharingResponse>, IBufferMessage
	{
		// Token: 0x0601CD48 RID: 118088 RVA: 0x0042D9A4 File Offset: 0x0042BBA4
		[NullableContext(1)]
		public static VehicleEnterSharingResponse Create()
		{
			return new VehicleEnterSharingResponse();
		}

		// Token: 0x1700618E RID: 24974
		// (get) Token: 0x0601CD49 RID: 118089 RVA: 0x0042D9AB File Offset: 0x0042BBAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700618F RID: 24975
		// (get) Token: 0x0601CD4A RID: 118090 RVA: 0x0042D9AE File Offset: 0x0042BBAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VehicleEnterSharingResponse.Descriptor;
			}
		}

		// Token: 0x0601CD4B RID: 118091 RVA: 0x0042D9B5 File Offset: 0x0042BBB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleEnterSharingResponse()
		{
		}

		// Token: 0x0601CD4C RID: 118092 RVA: 0x0042D9BD File Offset: 0x0042BBBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleEnterSharingResponse(VehicleEnterSharingResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CD4D RID: 118093 RVA: 0x0042D9E2 File Offset: 0x0042BBE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleEnterSharingResponse Clone()
		{
			return new VehicleEnterSharingResponse(this);
		}

		// Token: 0x17006190 RID: 24976
		// (get) Token: 0x0601CD4E RID: 118094 RVA: 0x0042D9EA File Offset: 0x0042BBEA
		// (set) Token: 0x0601CD4F RID: 118095 RVA: 0x0042D9F2 File Offset: 0x0042BBF2
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

		// Token: 0x0601CD50 RID: 118096 RVA: 0x0042D9FB File Offset: 0x0042BBFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as VehicleEnterSharingResponse);
		}

		// Token: 0x0601CD51 RID: 118097 RVA: 0x0042DA09 File Offset: 0x0042BC09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(VehicleEnterSharingResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CD52 RID: 118098 RVA: 0x0042DA38 File Offset: 0x0042BC38
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

		// Token: 0x0601CD53 RID: 118099 RVA: 0x0042DA7D File Offset: 0x0042BC7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CD54 RID: 118100 RVA: 0x0042DA8A File Offset: 0x0042BC8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CD55 RID: 118101 RVA: 0x0042DA93 File Offset: 0x0042BC93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CD56 RID: 118102 RVA: 0x0042DAC8 File Offset: 0x0042BCC8
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

		// Token: 0x0601CD57 RID: 118103 RVA: 0x0042DB06 File Offset: 0x0042BD06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(VehicleEnterSharingResponse other)
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

		// Token: 0x0601CD58 RID: 118104 RVA: 0x0042DB37 File Offset: 0x0042BD37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CD59 RID: 118105 RVA: 0x0042DB40 File Offset: 0x0042BD40
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400A5E4 RID: 42468
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A5E5 RID: 42469
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x0400A5E6 RID: 42470
		private ErrorCode errorCode_;
	}
}
