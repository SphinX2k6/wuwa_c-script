using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C84 RID: 3204
	[NetMessage(EMessageId.PhantomBattleEnterSlotResponse)]
	public sealed class PhantomBattleEnterSlotResponse : IMessage<PhantomBattleEnterSlotResponse>, IMessage, IEquatable<PhantomBattleEnterSlotResponse>, IDeepCloneable<PhantomBattleEnterSlotResponse>, IBufferMessage
	{
		// Token: 0x060115E8 RID: 71144 RVA: 0x0028B8E0 File Offset: 0x00289AE0
		[NullableContext(1)]
		public static PhantomBattleEnterSlotResponse Create()
		{
			return new PhantomBattleEnterSlotResponse();
		}

		// Token: 0x17003982 RID: 14722
		// (get) Token: 0x060115E9 RID: 71145 RVA: 0x0028B8E7 File Offset: 0x00289AE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003983 RID: 14723
		// (get) Token: 0x060115EA RID: 71146 RVA: 0x0028B8EA File Offset: 0x00289AEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleEnterSlotResponse.Descriptor;
			}
		}

		// Token: 0x060115EB RID: 71147 RVA: 0x0028B8F1 File Offset: 0x00289AF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleEnterSlotResponse()
		{
		}

		// Token: 0x060115EC RID: 71148 RVA: 0x0028B8FC File Offset: 0x00289AFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleEnterSlotResponse(PhantomBattleEnterSlotResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.phantomBattleFighterInfo_ = ((other.phantomBattleFighterInfo_ != null) ? other.phantomBattleFighterInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060115ED RID: 71149 RVA: 0x0028B948 File Offset: 0x00289B48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleEnterSlotResponse Clone()
		{
			return new PhantomBattleEnterSlotResponse(this);
		}

		// Token: 0x17003984 RID: 14724
		// (get) Token: 0x060115EE RID: 71150 RVA: 0x0028B950 File Offset: 0x00289B50
		// (set) Token: 0x060115EF RID: 71151 RVA: 0x0028B958 File Offset: 0x00289B58
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

		// Token: 0x17003985 RID: 14725
		// (get) Token: 0x060115F0 RID: 71152 RVA: 0x0028B961 File Offset: 0x00289B61
		// (set) Token: 0x060115F1 RID: 71153 RVA: 0x0028B969 File Offset: 0x00289B69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleFighterInfo PhantomBattleFighterInfo
		{
			get
			{
				return this.phantomBattleFighterInfo_;
			}
			set
			{
				this.phantomBattleFighterInfo_ = value;
			}
		}

		// Token: 0x060115F2 RID: 71154 RVA: 0x0028B972 File Offset: 0x00289B72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleEnterSlotResponse);
		}

		// Token: 0x060115F3 RID: 71155 RVA: 0x0028B980 File Offset: 0x00289B80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleEnterSlotResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.PhantomBattleFighterInfo, other.PhantomBattleFighterInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060115F4 RID: 71156 RVA: 0x0028B9D0 File Offset: 0x00289BD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.phantomBattleFighterInfo_ != null)
			{
				num ^= this.PhantomBattleFighterInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060115F5 RID: 71157 RVA: 0x0028BA2B File Offset: 0x00289C2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060115F6 RID: 71158 RVA: 0x0028BA38 File Offset: 0x00289C38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060115F7 RID: 71159 RVA: 0x0028BA44 File Offset: 0x00289C44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.phantomBattleFighterInfo_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.PhantomBattleFighterInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060115F8 RID: 71160 RVA: 0x0028BA9C File Offset: 0x00289C9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.phantomBattleFighterInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PhantomBattleFighterInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060115F9 RID: 71161 RVA: 0x0028BAF4 File Offset: 0x00289CF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleEnterSlotResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.phantomBattleFighterInfo_ != null)
			{
				if (this.phantomBattleFighterInfo_ == null)
				{
					this.PhantomBattleFighterInfo = new PhantomBattleFighterInfo();
				}
				this.PhantomBattleFighterInfo.MergeFrom(other.PhantomBattleFighterInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060115FA RID: 71162 RVA: 0x0028BB5C File Offset: 0x00289D5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060115FB RID: 71163 RVA: 0x0028BB68 File Offset: 0x00289D68
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
					if (num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.phantomBattleFighterInfo_ == null)
						{
							this.PhantomBattleFighterInfo = new PhantomBattleFighterInfo();
						}
						input.ReadMessage(this.PhantomBattleFighterInfo);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04006DBE RID: 28094
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006DBF RID: 28095
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x04006DC0 RID: 28096
		private ErrorCode errorCode_;

		// Token: 0x04006DC1 RID: 28097
		public const int PhantomBattleFighterInfoFieldNumber = 15;

		// Token: 0x04006DC2 RID: 28098
		private PhantomBattleFighterInfo phantomBattleFighterInfo_;
	}
}
