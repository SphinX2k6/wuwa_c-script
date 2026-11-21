using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C85 RID: 3205
	[NetMessage(EMessageId.PhantomBattleLeaveSlotResponse)]
	public sealed class PhantomBattleLeaveSlotResponse : IMessage<PhantomBattleLeaveSlotResponse>, IMessage, IEquatable<PhantomBattleLeaveSlotResponse>, IDeepCloneable<PhantomBattleLeaveSlotResponse>, IBufferMessage
	{
		// Token: 0x06011656 RID: 71254 RVA: 0x0028D055 File Offset: 0x0028B255
		[NullableContext(1)]
		public static PhantomBattleLeaveSlotResponse Create()
		{
			return new PhantomBattleLeaveSlotResponse();
		}

		// Token: 0x1700399D RID: 14749
		// (get) Token: 0x06011657 RID: 71255 RVA: 0x0028D05C File Offset: 0x0028B25C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700399E RID: 14750
		// (get) Token: 0x06011658 RID: 71256 RVA: 0x0028D05F File Offset: 0x0028B25F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleLeaveSlotResponse.Descriptor;
			}
		}

		// Token: 0x06011659 RID: 71257 RVA: 0x0028D066 File Offset: 0x0028B266
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleLeaveSlotResponse()
		{
		}

		// Token: 0x0601165A RID: 71258 RVA: 0x0028D070 File Offset: 0x0028B270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleLeaveSlotResponse(PhantomBattleLeaveSlotResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.phantomBattleHandCardInfo_ = ((other.phantomBattleHandCardInfo_ != null) ? other.phantomBattleHandCardInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601165B RID: 71259 RVA: 0x0028D0BC File Offset: 0x0028B2BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleLeaveSlotResponse Clone()
		{
			return new PhantomBattleLeaveSlotResponse(this);
		}

		// Token: 0x1700399F RID: 14751
		// (get) Token: 0x0601165C RID: 71260 RVA: 0x0028D0C4 File Offset: 0x0028B2C4
		// (set) Token: 0x0601165D RID: 71261 RVA: 0x0028D0CC File Offset: 0x0028B2CC
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

		// Token: 0x170039A0 RID: 14752
		// (get) Token: 0x0601165E RID: 71262 RVA: 0x0028D0D5 File Offset: 0x0028B2D5
		// (set) Token: 0x0601165F RID: 71263 RVA: 0x0028D0DD File Offset: 0x0028B2DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleHandCardInfo PhantomBattleHandCardInfo
		{
			get
			{
				return this.phantomBattleHandCardInfo_;
			}
			set
			{
				this.phantomBattleHandCardInfo_ = value;
			}
		}

		// Token: 0x06011660 RID: 71264 RVA: 0x0028D0E6 File Offset: 0x0028B2E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleLeaveSlotResponse);
		}

		// Token: 0x06011661 RID: 71265 RVA: 0x0028D0F4 File Offset: 0x0028B2F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleLeaveSlotResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.PhantomBattleHandCardInfo, other.PhantomBattleHandCardInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011662 RID: 71266 RVA: 0x0028D144 File Offset: 0x0028B344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.phantomBattleHandCardInfo_ != null)
			{
				num ^= this.PhantomBattleHandCardInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011663 RID: 71267 RVA: 0x0028D19F File Offset: 0x0028B39F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011664 RID: 71268 RVA: 0x0028D1AC File Offset: 0x0028B3AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011665 RID: 71269 RVA: 0x0028D1B8 File Offset: 0x0028B3B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.phantomBattleHandCardInfo_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.PhantomBattleHandCardInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011666 RID: 71270 RVA: 0x0028D214 File Offset: 0x0028B414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.phantomBattleHandCardInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PhantomBattleHandCardInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011667 RID: 71271 RVA: 0x0028D26C File Offset: 0x0028B46C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleLeaveSlotResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.phantomBattleHandCardInfo_ != null)
			{
				if (this.phantomBattleHandCardInfo_ == null)
				{
					this.PhantomBattleHandCardInfo = new PhantomBattleHandCardInfo();
				}
				this.PhantomBattleHandCardInfo.MergeFrom(other.PhantomBattleHandCardInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011668 RID: 71272 RVA: 0x0028D2D4 File Offset: 0x0028B4D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011669 RID: 71273 RVA: 0x0028D2E0 File Offset: 0x0028B4E0
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
					if (num != 66U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.phantomBattleHandCardInfo_ == null)
						{
							this.PhantomBattleHandCardInfo = new PhantomBattleHandCardInfo();
						}
						input.ReadMessage(this.PhantomBattleHandCardInfo);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04006E43 RID: 28227
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006E44 RID: 28228
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04006E45 RID: 28229
		private ErrorCode errorCode_;

		// Token: 0x04006E46 RID: 28230
		public const int PhantomBattleHandCardInfoFieldNumber = 8;

		// Token: 0x04006E47 RID: 28231
		private PhantomBattleHandCardInfo phantomBattleHandCardInfo_;
	}
}
