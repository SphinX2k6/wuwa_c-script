using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F66 RID: 3942
	[NetMessage(EMessageId.RiskHarvestSettleResponse)]
	public sealed class RiskHarvestSettleResponse : IMessage<RiskHarvestSettleResponse>, IMessage, IEquatable<RiskHarvestSettleResponse>, IDeepCloneable<RiskHarvestSettleResponse>, IBufferMessage
	{
		// Token: 0x06015142 RID: 86338 RVA: 0x0030E7BE File Offset: 0x0030C9BE
		[NullableContext(1)]
		public static RiskHarvestSettleResponse Create()
		{
			return new RiskHarvestSettleResponse();
		}

		// Token: 0x1700461C RID: 17948
		// (get) Token: 0x06015143 RID: 86339 RVA: 0x0030E7C5 File Offset: 0x0030C9C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700461D RID: 17949
		// (get) Token: 0x06015144 RID: 86340 RVA: 0x0030E7C8 File Offset: 0x0030C9C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RiskHarvestSettleResponse.Descriptor;
			}
		}

		// Token: 0x06015145 RID: 86341 RVA: 0x0030E7CF File Offset: 0x0030C9CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestSettleResponse()
		{
		}

		// Token: 0x06015146 RID: 86342 RVA: 0x0030E7D7 File Offset: 0x0030C9D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestSettleResponse(RiskHarvestSettleResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015147 RID: 86343 RVA: 0x0030E7FC File Offset: 0x0030C9FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestSettleResponse Clone()
		{
			return new RiskHarvestSettleResponse(this);
		}

		// Token: 0x1700461E RID: 17950
		// (get) Token: 0x06015148 RID: 86344 RVA: 0x0030E804 File Offset: 0x0030CA04
		// (set) Token: 0x06015149 RID: 86345 RVA: 0x0030E80C File Offset: 0x0030CA0C
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

		// Token: 0x0601514A RID: 86346 RVA: 0x0030E815 File Offset: 0x0030CA15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RiskHarvestSettleResponse);
		}

		// Token: 0x0601514B RID: 86347 RVA: 0x0030E823 File Offset: 0x0030CA23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RiskHarvestSettleResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601514C RID: 86348 RVA: 0x0030E854 File Offset: 0x0030CA54
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

		// Token: 0x0601514D RID: 86349 RVA: 0x0030E899 File Offset: 0x0030CA99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601514E RID: 86350 RVA: 0x0030E8A6 File Offset: 0x0030CAA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601514F RID: 86351 RVA: 0x0030E8AF File Offset: 0x0030CAAF
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

		// Token: 0x06015150 RID: 86352 RVA: 0x0030E8E4 File Offset: 0x0030CAE4
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

		// Token: 0x06015151 RID: 86353 RVA: 0x0030E922 File Offset: 0x0030CB22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RiskHarvestSettleResponse other)
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

		// Token: 0x06015152 RID: 86354 RVA: 0x0030E953 File Offset: 0x0030CB53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015153 RID: 86355 RVA: 0x0030E95C File Offset: 0x0030CB5C
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

		// Token: 0x04007EE9 RID: 32489
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007EEA RID: 32490
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04007EEB RID: 32491
		private ErrorCode errorCode_;
	}
}
