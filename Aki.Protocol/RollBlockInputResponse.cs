using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010DE RID: 4318
	[NetMessage(EMessageId.RollBlockInputResponse)]
	public sealed class RollBlockInputResponse : IMessage<RollBlockInputResponse>, IMessage, IEquatable<RollBlockInputResponse>, IDeepCloneable<RollBlockInputResponse>, IBufferMessage
	{
		// Token: 0x06017095 RID: 94357 RVA: 0x0035805F File Offset: 0x0035625F
		[NullableContext(1)]
		public static RollBlockInputResponse Create()
		{
			return new RollBlockInputResponse();
		}

		// Token: 0x17004D2D RID: 19757
		// (get) Token: 0x06017096 RID: 94358 RVA: 0x00358066 File Offset: 0x00356266
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004D2E RID: 19758
		// (get) Token: 0x06017097 RID: 94359 RVA: 0x00358069 File Offset: 0x00356269
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RollBlockInputResponse.Descriptor;
			}
		}

		// Token: 0x06017098 RID: 94360 RVA: 0x00358070 File Offset: 0x00356270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockInputResponse()
		{
		}

		// Token: 0x06017099 RID: 94361 RVA: 0x00358078 File Offset: 0x00356278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockInputResponse(RollBlockInputResponse other) : this()
		{
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601709A RID: 94362 RVA: 0x0035809D File Offset: 0x0035629D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockInputResponse Clone()
		{
			return new RollBlockInputResponse(this);
		}

		// Token: 0x17004D2F RID: 19759
		// (get) Token: 0x0601709B RID: 94363 RVA: 0x003580A5 File Offset: 0x003562A5
		// (set) Token: 0x0601709C RID: 94364 RVA: 0x003580AD File Offset: 0x003562AD
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

		// Token: 0x0601709D RID: 94365 RVA: 0x003580B6 File Offset: 0x003562B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RollBlockInputResponse);
		}

		// Token: 0x0601709E RID: 94366 RVA: 0x003580C4 File Offset: 0x003562C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RollBlockInputResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601709F RID: 94367 RVA: 0x003580F4 File Offset: 0x003562F4
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

		// Token: 0x060170A0 RID: 94368 RVA: 0x00358139 File Offset: 0x00356339
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060170A1 RID: 94369 RVA: 0x00358146 File Offset: 0x00356346
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060170A2 RID: 94370 RVA: 0x0035814F File Offset: 0x0035634F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060170A3 RID: 94371 RVA: 0x00358184 File Offset: 0x00356384
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

		// Token: 0x060170A4 RID: 94372 RVA: 0x003581C2 File Offset: 0x003563C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RollBlockInputResponse other)
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

		// Token: 0x060170A5 RID: 94373 RVA: 0x003581F3 File Offset: 0x003563F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060170A6 RID: 94374 RVA: 0x003581FC File Offset: 0x003563FC
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
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008924 RID: 35108
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008925 RID: 35109
		public const int CodeFieldNumber = 2;

		// Token: 0x04008926 RID: 35110
		private ErrorCode code_;
	}
}
