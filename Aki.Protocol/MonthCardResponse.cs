using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A0D RID: 2573
	[NetMessage(EMessageId.MonthCardResponse)]
	public sealed class MonthCardResponse : IMessage<MonthCardResponse>, IMessage, IEquatable<MonthCardResponse>, IDeepCloneable<MonthCardResponse>, IBufferMessage
	{
		// Token: 0x0600E116 RID: 57622 RVA: 0x0020F7FE File Offset: 0x0020D9FE
		[NullableContext(1)]
		public static MonthCardResponse Create()
		{
			return new MonthCardResponse();
		}

		// Token: 0x17002DA0 RID: 11680
		// (get) Token: 0x0600E117 RID: 57623 RVA: 0x0020F805 File Offset: 0x0020DA05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002DA1 RID: 11681
		// (get) Token: 0x0600E118 RID: 57624 RVA: 0x0020F808 File Offset: 0x0020DA08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonthCardResponse.Descriptor;
			}
		}

		// Token: 0x0600E119 RID: 57625 RVA: 0x0020F80F File Offset: 0x0020DA0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonthCardResponse()
		{
		}

		// Token: 0x0600E11A RID: 57626 RVA: 0x0020F817 File Offset: 0x0020DA17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonthCardResponse(MonthCardResponse other) : this()
		{
			this.days_ = other.days_;
			this.isDailyGot_ = other.isDailyGot_;
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E11B RID: 57627 RVA: 0x0020F854 File Offset: 0x0020DA54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonthCardResponse Clone()
		{
			return new MonthCardResponse(this);
		}

		// Token: 0x17002DA2 RID: 11682
		// (get) Token: 0x0600E11C RID: 57628 RVA: 0x0020F85C File Offset: 0x0020DA5C
		// (set) Token: 0x0600E11D RID: 57629 RVA: 0x0020F864 File Offset: 0x0020DA64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Days
		{
			get
			{
				return this.days_;
			}
			set
			{
				this.days_ = value;
			}
		}

		// Token: 0x17002DA3 RID: 11683
		// (get) Token: 0x0600E11E RID: 57630 RVA: 0x0020F86D File Offset: 0x0020DA6D
		// (set) Token: 0x0600E11F RID: 57631 RVA: 0x0020F875 File Offset: 0x0020DA75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsDailyGot
		{
			get
			{
				return this.isDailyGot_;
			}
			set
			{
				this.isDailyGot_ = value;
			}
		}

		// Token: 0x17002DA4 RID: 11684
		// (get) Token: 0x0600E120 RID: 57632 RVA: 0x0020F87E File Offset: 0x0020DA7E
		// (set) Token: 0x0600E121 RID: 57633 RVA: 0x0020F886 File Offset: 0x0020DA86
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

		// Token: 0x0600E122 RID: 57634 RVA: 0x0020F88F File Offset: 0x0020DA8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonthCardResponse);
		}

		// Token: 0x0600E123 RID: 57635 RVA: 0x0020F8A0 File Offset: 0x0020DAA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonthCardResponse other)
		{
			return other != null && (other == this || (this.Days == other.Days && this.IsDailyGot == other.IsDailyGot && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E124 RID: 57636 RVA: 0x0020F8FC File Offset: 0x0020DAFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Days != 0)
			{
				num ^= this.Days.GetHashCode();
			}
			if (this.IsDailyGot)
			{
				num ^= this.IsDailyGot.GetHashCode();
			}
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

		// Token: 0x0600E125 RID: 57637 RVA: 0x0020F973 File Offset: 0x0020DB73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E126 RID: 57638 RVA: 0x0020F980 File Offset: 0x0020DB80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E127 RID: 57639 RVA: 0x0020F98C File Offset: 0x0020DB8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsDailyGot)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.IsDailyGot);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.Days != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.Days);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E128 RID: 57640 RVA: 0x0020FA04 File Offset: 0x0020DC04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Days != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Days);
			}
			if (this.IsDailyGot)
			{
				num += 2;
			}
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

		// Token: 0x0600E129 RID: 57641 RVA: 0x0020FA68 File Offset: 0x0020DC68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonthCardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Days != 0)
			{
				this.Days = other.Days;
			}
			if (other.IsDailyGot)
			{
				this.IsDailyGot = other.IsDailyGot;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E12A RID: 57642 RVA: 0x0020FACC File Offset: 0x0020DCCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E12B RID: 57643 RVA: 0x0020FAD8 File Offset: 0x0020DCD8
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
					if (num != 72U)
					{
						if (num != 96U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Days = input.ReadInt32();
						}
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.IsDailyGot = input.ReadBool();
				}
			}
		}

		// Token: 0x04005C8B RID: 23691
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005C8C RID: 23692
		public const int DaysFieldNumber = 12;

		// Token: 0x04005C8D RID: 23693
		private int days_;

		// Token: 0x04005C8E RID: 23694
		public const int IsDailyGotFieldNumber = 6;

		// Token: 0x04005C8F RID: 23695
		private bool isDailyGot_;

		// Token: 0x04005C90 RID: 23696
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x04005C91 RID: 23697
		private ErrorCode errorCode_;
	}
}
