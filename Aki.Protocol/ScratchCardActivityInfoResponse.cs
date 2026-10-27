using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200119D RID: 4509
	[NetMessage(EMessageId.ScratchCardActivityInfoResponse)]
	public sealed class ScratchCardActivityInfoResponse : IMessage<ScratchCardActivityInfoResponse>, IMessage, IEquatable<ScratchCardActivityInfoResponse>, IDeepCloneable<ScratchCardActivityInfoResponse>, IBufferMessage
	{
		// Token: 0x0601806A RID: 98410 RVA: 0x0037D105 File Offset: 0x0037B305
		[NullableContext(1)]
		public static ScratchCardActivityInfoResponse Create()
		{
			return new ScratchCardActivityInfoResponse();
		}

		// Token: 0x170050BB RID: 20667
		// (get) Token: 0x0601806B RID: 98411 RVA: 0x0037D10C File Offset: 0x0037B30C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170050BC RID: 20668
		// (get) Token: 0x0601806C RID: 98412 RVA: 0x0037D10F File Offset: 0x0037B30F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ScratchCardActivityInfoResponse.Descriptor;
			}
		}

		// Token: 0x0601806D RID: 98413 RVA: 0x0037D116 File Offset: 0x0037B316
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScratchCardActivityInfoResponse()
		{
		}

		// Token: 0x0601806E RID: 98414 RVA: 0x0037D120 File Offset: 0x0037B320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScratchCardActivityInfoResponse(ScratchCardActivityInfoResponse other) : this()
		{
			this.info_ = ((other.info_ != null) ? other.info_.Clone() : null);
			this.error_ = other.error_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601806F RID: 98415 RVA: 0x0037D16C File Offset: 0x0037B36C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScratchCardActivityInfoResponse Clone()
		{
			return new ScratchCardActivityInfoResponse(this);
		}

		// Token: 0x170050BD RID: 20669
		// (get) Token: 0x06018070 RID: 98416 RVA: 0x0037D174 File Offset: 0x0037B374
		// (set) Token: 0x06018071 RID: 98417 RVA: 0x0037D17C File Offset: 0x0037B37C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScratchCardActivityInfo Info
		{
			get
			{
				return this.info_;
			}
			set
			{
				this.info_ = value;
			}
		}

		// Token: 0x170050BE RID: 20670
		// (get) Token: 0x06018072 RID: 98418 RVA: 0x0037D185 File Offset: 0x0037B385
		// (set) Token: 0x06018073 RID: 98419 RVA: 0x0037D18D File Offset: 0x0037B38D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Error
		{
			get
			{
				return this.error_;
			}
			set
			{
				this.error_ = value;
			}
		}

		// Token: 0x06018074 RID: 98420 RVA: 0x0037D196 File Offset: 0x0037B396
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ScratchCardActivityInfoResponse);
		}

		// Token: 0x06018075 RID: 98421 RVA: 0x0037D1A4 File Offset: 0x0037B3A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ScratchCardActivityInfoResponse other)
		{
			return other != null && (other == this || (object.Equals(this.Info, other.Info) && this.Error == other.Error && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018076 RID: 98422 RVA: 0x0037D1F4 File Offset: 0x0037B3F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.info_ != null)
			{
				num ^= this.Info.GetHashCode();
			}
			if (this.Error != ErrorCode.Success)
			{
				num ^= this.Error.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018077 RID: 98423 RVA: 0x0037D24F File Offset: 0x0037B44F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018078 RID: 98424 RVA: 0x0037D25C File Offset: 0x0037B45C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018079 RID: 98425 RVA: 0x0037D268 File Offset: 0x0037B468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Error != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.Error);
			}
			if (this.info_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.Info);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601807A RID: 98426 RVA: 0x0037D2C4 File Offset: 0x0037B4C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.info_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Info);
			}
			if (this.Error != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Error);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601807B RID: 98427 RVA: 0x0037D31C File Offset: 0x0037B51C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ScratchCardActivityInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.info_ != null)
			{
				if (this.info_ == null)
				{
					this.Info = new ScratchCardActivityInfo();
				}
				this.Info.MergeFrom(other.Info);
			}
			if (other.Error != ErrorCode.Success)
			{
				this.Error = other.Error;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601807C RID: 98428 RVA: 0x0037D384 File Offset: 0x0037B584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601807D RID: 98429 RVA: 0x0037D390 File Offset: 0x0037B590
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
					if (num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.info_ == null)
						{
							this.Info = new ScratchCardActivityInfo();
						}
						input.ReadMessage(this.Info);
					}
				}
				else
				{
					this.Error = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008E3E RID: 36414
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008E3F RID: 36415
		public const int InfoFieldNumber = 14;

		// Token: 0x04008E40 RID: 36416
		private ScratchCardActivityInfo info_;

		// Token: 0x04008E41 RID: 36417
		public const int ErrorFieldNumber = 6;

		// Token: 0x04008E42 RID: 36418
		private ErrorCode error_;
	}
}
