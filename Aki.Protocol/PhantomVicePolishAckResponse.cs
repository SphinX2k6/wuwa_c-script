using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CFF RID: 3327
	[NetMessage(EMessageId.PhantomVicePolishAckResponse)]
	public sealed class PhantomVicePolishAckResponse : IMessage<PhantomVicePolishAckResponse>, IMessage, IEquatable<PhantomVicePolishAckResponse>, IDeepCloneable<PhantomVicePolishAckResponse>, IBufferMessage
	{
		// Token: 0x06012006 RID: 73734 RVA: 0x002A2040 File Offset: 0x002A0240
		[NullableContext(1)]
		public static PhantomVicePolishAckResponse Create()
		{
			return new PhantomVicePolishAckResponse();
		}

		// Token: 0x17003BA4 RID: 15268
		// (get) Token: 0x06012007 RID: 73735 RVA: 0x002A2047 File Offset: 0x002A0247
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003BA5 RID: 15269
		// (get) Token: 0x06012008 RID: 73736 RVA: 0x002A204A File Offset: 0x002A024A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomVicePolishAckResponse.Descriptor;
			}
		}

		// Token: 0x06012009 RID: 73737 RVA: 0x002A2051 File Offset: 0x002A0251
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomVicePolishAckResponse()
		{
		}

		// Token: 0x0601200A RID: 73738 RVA: 0x002A205C File Offset: 0x002A025C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomVicePolishAckResponse(PhantomVicePolishAckResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.updateInfo_ = ((other.updateInfo_ != null) ? other.updateInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601200B RID: 73739 RVA: 0x002A20A8 File Offset: 0x002A02A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomVicePolishAckResponse Clone()
		{
			return new PhantomVicePolishAckResponse(this);
		}

		// Token: 0x17003BA6 RID: 15270
		// (get) Token: 0x0601200C RID: 73740 RVA: 0x002A20B0 File Offset: 0x002A02B0
		// (set) Token: 0x0601200D RID: 73741 RVA: 0x002A20B8 File Offset: 0x002A02B8
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

		// Token: 0x17003BA7 RID: 15271
		// (get) Token: 0x0601200E RID: 73742 RVA: 0x002A20C1 File Offset: 0x002A02C1
		// (set) Token: 0x0601200F RID: 73743 RVA: 0x002A20C9 File Offset: 0x002A02C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomItem UpdateInfo
		{
			get
			{
				return this.updateInfo_;
			}
			set
			{
				this.updateInfo_ = value;
			}
		}

		// Token: 0x06012010 RID: 73744 RVA: 0x002A20D2 File Offset: 0x002A02D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomVicePolishAckResponse);
		}

		// Token: 0x06012011 RID: 73745 RVA: 0x002A20E0 File Offset: 0x002A02E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomVicePolishAckResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.UpdateInfo, other.UpdateInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012012 RID: 73746 RVA: 0x002A2130 File Offset: 0x002A0330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.updateInfo_ != null)
			{
				num ^= this.UpdateInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012013 RID: 73747 RVA: 0x002A218B File Offset: 0x002A038B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012014 RID: 73748 RVA: 0x002A2198 File Offset: 0x002A0398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012015 RID: 73749 RVA: 0x002A21A4 File Offset: 0x002A03A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.updateInfo_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.UpdateInfo);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012016 RID: 73750 RVA: 0x002A2200 File Offset: 0x002A0400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.updateInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.UpdateInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012017 RID: 73751 RVA: 0x002A2258 File Offset: 0x002A0458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomVicePolishAckResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.updateInfo_ != null)
			{
				if (this.updateInfo_ == null)
				{
					this.UpdateInfo = new PhantomItem();
				}
				this.UpdateInfo.MergeFrom(other.UpdateInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012018 RID: 73752 RVA: 0x002A22C0 File Offset: 0x002A04C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012019 RID: 73753 RVA: 0x002A22CC File Offset: 0x002A04CC
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
				if (num != 98U)
				{
					if (num != 112U)
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
					if (this.updateInfo_ == null)
					{
						this.UpdateInfo = new PhantomItem();
					}
					input.ReadMessage(this.UpdateInfo);
				}
			}
		}

		// Token: 0x04007121 RID: 28961
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007122 RID: 28962
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04007123 RID: 28963
		private ErrorCode errorCode_;

		// Token: 0x04007124 RID: 28964
		public const int UpdateInfoFieldNumber = 12;

		// Token: 0x04007125 RID: 28965
		private PhantomItem updateInfo_;
	}
}
