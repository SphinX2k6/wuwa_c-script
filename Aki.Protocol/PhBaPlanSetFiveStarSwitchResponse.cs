using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D0E RID: 3342
	[NetMessage(EMessageId.PhBaPlanSetFiveStarSwitchResponse)]
	public sealed class PhBaPlanSetFiveStarSwitchResponse : IMessage<PhBaPlanSetFiveStarSwitchResponse>, IMessage, IEquatable<PhBaPlanSetFiveStarSwitchResponse>, IDeepCloneable<PhBaPlanSetFiveStarSwitchResponse>, IBufferMessage
	{
		// Token: 0x06012133 RID: 74035 RVA: 0x002A47E1 File Offset: 0x002A29E1
		[NullableContext(1)]
		public static PhBaPlanSetFiveStarSwitchResponse Create()
		{
			return new PhBaPlanSetFiveStarSwitchResponse();
		}

		// Token: 0x17003BE2 RID: 15330
		// (get) Token: 0x06012134 RID: 74036 RVA: 0x002A47E8 File Offset: 0x002A29E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003BE3 RID: 15331
		// (get) Token: 0x06012135 RID: 74037 RVA: 0x002A47EB File Offset: 0x002A29EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhBaPlanSetFiveStarSwitchResponse.Descriptor;
			}
		}

		// Token: 0x06012136 RID: 74038 RVA: 0x002A47F2 File Offset: 0x002A29F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanSetFiveStarSwitchResponse()
		{
		}

		// Token: 0x06012137 RID: 74039 RVA: 0x002A47FA File Offset: 0x002A29FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanSetFiveStarSwitchResponse(PhBaPlanSetFiveStarSwitchResponse other) : this()
		{
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012138 RID: 74040 RVA: 0x002A481F File Offset: 0x002A2A1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanSetFiveStarSwitchResponse Clone()
		{
			return new PhBaPlanSetFiveStarSwitchResponse(this);
		}

		// Token: 0x17003BE4 RID: 15332
		// (get) Token: 0x06012139 RID: 74041 RVA: 0x002A4827 File Offset: 0x002A2A27
		// (set) Token: 0x0601213A RID: 74042 RVA: 0x002A482F File Offset: 0x002A2A2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x0601213B RID: 74043 RVA: 0x002A4838 File Offset: 0x002A2A38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhBaPlanSetFiveStarSwitchResponse);
		}

		// Token: 0x0601213C RID: 74044 RVA: 0x002A4846 File Offset: 0x002A2A46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhBaPlanSetFiveStarSwitchResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601213D RID: 74045 RVA: 0x002A4874 File Offset: 0x002A2A74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601213E RID: 74046 RVA: 0x002A48B9 File Offset: 0x002A2AB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601213F RID: 74047 RVA: 0x002A48C6 File Offset: 0x002A2AC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012140 RID: 74048 RVA: 0x002A48CF File Offset: 0x002A2ACF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012141 RID: 74049 RVA: 0x002A4904 File Offset: 0x002A2B04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012142 RID: 74050 RVA: 0x002A4942 File Offset: 0x002A2B42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhBaPlanSetFiveStarSwitchResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012143 RID: 74051 RVA: 0x002A4973 File Offset: 0x002A2B73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012144 RID: 74052 RVA: 0x002A497C File Offset: 0x002A2B7C
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007173 RID: 29043
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007174 RID: 29044
		public const int CodeFieldNumber = 13;

		// Token: 0x04007175 RID: 29045
		private ErrorCode code_;
	}
}
