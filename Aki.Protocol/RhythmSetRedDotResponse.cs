using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F47 RID: 3911
	[NetMessage(EMessageId.RhythmSetRedDotResponse)]
	public sealed class RhythmSetRedDotResponse : IMessage<RhythmSetRedDotResponse>, IMessage, IEquatable<RhythmSetRedDotResponse>, IDeepCloneable<RhythmSetRedDotResponse>, IBufferMessage
	{
		// Token: 0x06014ECB RID: 85707 RVA: 0x0030927F File Offset: 0x0030747F
		[NullableContext(1)]
		public static RhythmSetRedDotResponse Create()
		{
			return new RhythmSetRedDotResponse();
		}

		// Token: 0x17004596 RID: 17814
		// (get) Token: 0x06014ECC RID: 85708 RVA: 0x00309286 File Offset: 0x00307486
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004597 RID: 17815
		// (get) Token: 0x06014ECD RID: 85709 RVA: 0x00309289 File Offset: 0x00307489
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RhythmSetRedDotResponse.Descriptor;
			}
		}

		// Token: 0x06014ECE RID: 85710 RVA: 0x00309290 File Offset: 0x00307490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmSetRedDotResponse()
		{
		}

		// Token: 0x06014ECF RID: 85711 RVA: 0x00309298 File Offset: 0x00307498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmSetRedDotResponse(RhythmSetRedDotResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.redDot_ = ((other.redDot_ != null) ? other.redDot_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014ED0 RID: 85712 RVA: 0x003092E4 File Offset: 0x003074E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmSetRedDotResponse Clone()
		{
			return new RhythmSetRedDotResponse(this);
		}

		// Token: 0x17004598 RID: 17816
		// (get) Token: 0x06014ED1 RID: 85713 RVA: 0x003092EC File Offset: 0x003074EC
		// (set) Token: 0x06014ED2 RID: 85714 RVA: 0x003092F4 File Offset: 0x003074F4
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

		// Token: 0x17004599 RID: 17817
		// (get) Token: 0x06014ED3 RID: 85715 RVA: 0x003092FD File Offset: 0x003074FD
		// (set) Token: 0x06014ED4 RID: 85716 RVA: 0x00309305 File Offset: 0x00307505
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmRedDotPb RedDot
		{
			get
			{
				return this.redDot_;
			}
			set
			{
				this.redDot_ = value;
			}
		}

		// Token: 0x06014ED5 RID: 85717 RVA: 0x0030930E File Offset: 0x0030750E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RhythmSetRedDotResponse);
		}

		// Token: 0x06014ED6 RID: 85718 RVA: 0x0030931C File Offset: 0x0030751C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RhythmSetRedDotResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.RedDot, other.RedDot) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014ED7 RID: 85719 RVA: 0x0030936C File Offset: 0x0030756C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.redDot_ != null)
			{
				num ^= this.RedDot.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014ED8 RID: 85720 RVA: 0x003093C7 File Offset: 0x003075C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014ED9 RID: 85721 RVA: 0x003093D4 File Offset: 0x003075D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014EDA RID: 85722 RVA: 0x003093E0 File Offset: 0x003075E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.redDot_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.RedDot);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014EDB RID: 85723 RVA: 0x0030943C File Offset: 0x0030763C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.redDot_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RedDot);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014EDC RID: 85724 RVA: 0x00309494 File Offset: 0x00307694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RhythmSetRedDotResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.redDot_ != null)
			{
				if (this.redDot_ == null)
				{
					this.RedDot = new RhythmRedDotPb();
				}
				this.RedDot.MergeFrom(other.RedDot);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014EDD RID: 85725 RVA: 0x003094FC File Offset: 0x003076FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014EDE RID: 85726 RVA: 0x00309508 File Offset: 0x00307708
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
				if (num != 34U)
				{
					if (num != 40U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					if (this.redDot_ == null)
					{
						this.RedDot = new RhythmRedDotPb();
					}
					input.ReadMessage(this.RedDot);
				}
			}
		}

		// Token: 0x04007E2F RID: 32303
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007E30 RID: 32304
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x04007E31 RID: 32305
		private ErrorCode errorCode_;

		// Token: 0x04007E32 RID: 32306
		public const int RedDotFieldNumber = 4;

		// Token: 0x04007E33 RID: 32307
		private RhythmRedDotPb redDot_;
	}
}
