using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001116 RID: 4374
	[NetMessage(EMessageId.RoverRogueQuitResponse)]
	public sealed class RoverRogueQuitResponse : IMessage<RoverRogueQuitResponse>, IMessage, IEquatable<RoverRogueQuitResponse>, IDeepCloneable<RoverRogueQuitResponse>, IBufferMessage
	{
		// Token: 0x0601753E RID: 95550 RVA: 0x0036302D File Offset: 0x0036122D
		[NullableContext(1)]
		public static RoverRogueQuitResponse Create()
		{
			return new RoverRogueQuitResponse();
		}

		// Token: 0x17004E3C RID: 20028
		// (get) Token: 0x0601753F RID: 95551 RVA: 0x00363034 File Offset: 0x00361234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004E3D RID: 20029
		// (get) Token: 0x06017540 RID: 95552 RVA: 0x00363037 File Offset: 0x00361237
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueQuitResponse.Descriptor;
			}
		}

		// Token: 0x06017541 RID: 95553 RVA: 0x0036303E File Offset: 0x0036123E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueQuitResponse()
		{
		}

		// Token: 0x06017542 RID: 95554 RVA: 0x00363046 File Offset: 0x00361246
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueQuitResponse(RoverRogueQuitResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017543 RID: 95555 RVA: 0x0036306B File Offset: 0x0036126B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueQuitResponse Clone()
		{
			return new RoverRogueQuitResponse(this);
		}

		// Token: 0x17004E3E RID: 20030
		// (get) Token: 0x06017544 RID: 95556 RVA: 0x00363073 File Offset: 0x00361273
		// (set) Token: 0x06017545 RID: 95557 RVA: 0x0036307B File Offset: 0x0036127B
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

		// Token: 0x06017546 RID: 95558 RVA: 0x00363084 File Offset: 0x00361284
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueQuitResponse);
		}

		// Token: 0x06017547 RID: 95559 RVA: 0x00363092 File Offset: 0x00361292
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueQuitResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017548 RID: 95560 RVA: 0x003630C0 File Offset: 0x003612C0
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

		// Token: 0x06017549 RID: 95561 RVA: 0x00363105 File Offset: 0x00361305
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601754A RID: 95562 RVA: 0x00363112 File Offset: 0x00361312
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601754B RID: 95563 RVA: 0x0036311B File Offset: 0x0036131B
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

		// Token: 0x0601754C RID: 95564 RVA: 0x0036314C File Offset: 0x0036134C
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

		// Token: 0x0601754D RID: 95565 RVA: 0x0036318A File Offset: 0x0036138A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueQuitResponse other)
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

		// Token: 0x0601754E RID: 95566 RVA: 0x003631BB File Offset: 0x003613BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601754F RID: 95567 RVA: 0x003631C4 File Offset: 0x003613C4
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

		// Token: 0x04008AB7 RID: 35511
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008AB8 RID: 35512
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x04008AB9 RID: 35513
		private ErrorCode errorCode_;
	}
}
