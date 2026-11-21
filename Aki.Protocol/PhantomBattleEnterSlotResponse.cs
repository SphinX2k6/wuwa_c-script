using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C74 RID: 3188
	[NetMessage(EMessageId.PhantomBattleEnterSlotResponse)]
	public sealed class PhantomBattleEnterSlotResponse : IMessage<PhantomBattleEnterSlotResponse>, IMessage, IEquatable<PhantomBattleEnterSlotResponse>, IDeepCloneable<PhantomBattleEnterSlotResponse>, IBufferMessage
	{
		// Token: 0x060114E8 RID: 70888 RVA: 0x00289B70 File Offset: 0x00287D70
		[NullableContext(1)]
		public static PhantomBattleEnterSlotResponse Create()
		{
			return new PhantomBattleEnterSlotResponse();
		}

		// Token: 0x1700394B RID: 14667
		// (get) Token: 0x060114E9 RID: 70889 RVA: 0x00289B77 File Offset: 0x00287D77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700394C RID: 14668
		// (get) Token: 0x060114EA RID: 70890 RVA: 0x00289B7A File Offset: 0x00287D7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleEnterSlotResponse.Descriptor;
			}
		}

		// Token: 0x060114EB RID: 70891 RVA: 0x00289B81 File Offset: 0x00287D81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleEnterSlotResponse()
		{
		}

		// Token: 0x060114EC RID: 70892 RVA: 0x00289B8C File Offset: 0x00287D8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleEnterSlotResponse(PhantomBattleEnterSlotResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.phantomBattleFighterInfo_ = ((other.phantomBattleFighterInfo_ != null) ? other.phantomBattleFighterInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060114ED RID: 70893 RVA: 0x00289BD8 File Offset: 0x00287DD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleEnterSlotResponse Clone()
		{
			return new PhantomBattleEnterSlotResponse(this);
		}

		// Token: 0x1700394D RID: 14669
		// (get) Token: 0x060114EE RID: 70894 RVA: 0x00289BE0 File Offset: 0x00287DE0
		// (set) Token: 0x060114EF RID: 70895 RVA: 0x00289BE8 File Offset: 0x00287DE8
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

		// Token: 0x1700394E RID: 14670
		// (get) Token: 0x060114F0 RID: 70896 RVA: 0x00289BF1 File Offset: 0x00287DF1
		// (set) Token: 0x060114F1 RID: 70897 RVA: 0x00289BF9 File Offset: 0x00287DF9
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

		// Token: 0x060114F2 RID: 70898 RVA: 0x00289C02 File Offset: 0x00287E02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleEnterSlotResponse);
		}

		// Token: 0x060114F3 RID: 70899 RVA: 0x00289C10 File Offset: 0x00287E10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleEnterSlotResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.PhantomBattleFighterInfo, other.PhantomBattleFighterInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060114F4 RID: 70900 RVA: 0x00289C60 File Offset: 0x00287E60
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

		// Token: 0x060114F5 RID: 70901 RVA: 0x00289CBB File Offset: 0x00287EBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060114F6 RID: 70902 RVA: 0x00289CC8 File Offset: 0x00287EC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060114F7 RID: 70903 RVA: 0x00289CD4 File Offset: 0x00287ED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.phantomBattleFighterInfo_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.PhantomBattleFighterInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060114F8 RID: 70904 RVA: 0x00289D30 File Offset: 0x00287F30
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

		// Token: 0x060114F9 RID: 70905 RVA: 0x00289D88 File Offset: 0x00287F88
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

		// Token: 0x060114FA RID: 70906 RVA: 0x00289DF0 File Offset: 0x00287FF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060114FB RID: 70907 RVA: 0x00289DFC File Offset: 0x00287FFC
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
				if (num != 64U)
				{
					if (num != 74U)
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

		// Token: 0x04006DD2 RID: 28114
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006DD3 RID: 28115
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04006DD4 RID: 28116
		private ErrorCode errorCode_;

		// Token: 0x04006DD5 RID: 28117
		public const int PhantomBattleFighterInfoFieldNumber = 9;

		// Token: 0x04006DD6 RID: 28118
		private PhantomBattleFighterInfo phantomBattleFighterInfo_;
	}
}
