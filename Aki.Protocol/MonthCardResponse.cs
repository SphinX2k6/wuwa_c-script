using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009FC RID: 2556
	[NetMessage(EMessageId.MonthCardResponse)]
	public sealed class MonthCardResponse : IMessage<MonthCardResponse>, IMessage, IEquatable<MonthCardResponse>, IDeepCloneable<MonthCardResponse>, IBufferMessage
	{
		// Token: 0x0600DFFC RID: 57340 RVA: 0x0020D612 File Offset: 0x0020B812
		[NullableContext(1)]
		public static MonthCardResponse Create()
		{
			return new MonthCardResponse();
		}

		// Token: 0x17002D62 RID: 11618
		// (get) Token: 0x0600DFFD RID: 57341 RVA: 0x0020D619 File Offset: 0x0020B819
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002D63 RID: 11619
		// (get) Token: 0x0600DFFE RID: 57342 RVA: 0x0020D61C File Offset: 0x0020B81C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonthCardResponse.Descriptor;
			}
		}

		// Token: 0x0600DFFF RID: 57343 RVA: 0x0020D623 File Offset: 0x0020B823
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonthCardResponse()
		{
		}

		// Token: 0x0600E000 RID: 57344 RVA: 0x0020D62B File Offset: 0x0020B82B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonthCardResponse(MonthCardResponse other) : this()
		{
			this.days_ = other.days_;
			this.isDailyGot_ = other.isDailyGot_;
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E001 RID: 57345 RVA: 0x0020D668 File Offset: 0x0020B868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonthCardResponse Clone()
		{
			return new MonthCardResponse(this);
		}

		// Token: 0x17002D64 RID: 11620
		// (get) Token: 0x0600E002 RID: 57346 RVA: 0x0020D670 File Offset: 0x0020B870
		// (set) Token: 0x0600E003 RID: 57347 RVA: 0x0020D678 File Offset: 0x0020B878
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

		// Token: 0x17002D65 RID: 11621
		// (get) Token: 0x0600E004 RID: 57348 RVA: 0x0020D681 File Offset: 0x0020B881
		// (set) Token: 0x0600E005 RID: 57349 RVA: 0x0020D689 File Offset: 0x0020B889
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

		// Token: 0x17002D66 RID: 11622
		// (get) Token: 0x0600E006 RID: 57350 RVA: 0x0020D692 File Offset: 0x0020B892
		// (set) Token: 0x0600E007 RID: 57351 RVA: 0x0020D69A File Offset: 0x0020B89A
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

		// Token: 0x0600E008 RID: 57352 RVA: 0x0020D6A3 File Offset: 0x0020B8A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonthCardResponse);
		}

		// Token: 0x0600E009 RID: 57353 RVA: 0x0020D6B4 File Offset: 0x0020B8B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonthCardResponse other)
		{
			return other != null && (other == this || (this.Days == other.Days && this.IsDailyGot == other.IsDailyGot && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E00A RID: 57354 RVA: 0x0020D710 File Offset: 0x0020B910
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

		// Token: 0x0600E00B RID: 57355 RVA: 0x0020D787 File Offset: 0x0020B987
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E00C RID: 57356 RVA: 0x0020D794 File Offset: 0x0020B994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E00D RID: 57357 RVA: 0x0020D7A0 File Offset: 0x0020B9A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Days != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.Days);
			}
			if (this.IsDailyGot)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.IsDailyGot);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E00E RID: 57358 RVA: 0x0020D818 File Offset: 0x0020BA18
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

		// Token: 0x0600E00F RID: 57359 RVA: 0x0020D87C File Offset: 0x0020BA7C
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

		// Token: 0x0600E010 RID: 57360 RVA: 0x0020D8E0 File Offset: 0x0020BAE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E011 RID: 57361 RVA: 0x0020D8EC File Offset: 0x0020BAEC
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
				if (num != 56U)
				{
					if (num != 88U)
					{
						if (num != 120U)
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
						this.IsDailyGot = input.ReadBool();
					}
				}
				else
				{
					this.Days = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005C94 RID: 23700
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005C95 RID: 23701
		public const int DaysFieldNumber = 7;

		// Token: 0x04005C96 RID: 23702
		private int days_;

		// Token: 0x04005C97 RID: 23703
		public const int IsDailyGotFieldNumber = 11;

		// Token: 0x04005C98 RID: 23704
		private bool isDailyGot_;

		// Token: 0x04005C99 RID: 23705
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x04005C9A RID: 23706
		private ErrorCode errorCode_;
	}
}
