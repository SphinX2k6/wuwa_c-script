using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200122D RID: 4653
	public sealed class SingleFoodFormulaInfo : IMessage<SingleFoodFormulaInfo>, IMessage, IEquatable<SingleFoodFormulaInfo>, IDeepCloneable<SingleFoodFormulaInfo>, IBufferMessage
	{
		// Token: 0x06018CB7 RID: 101559 RVA: 0x0039B894 File Offset: 0x00399A94
		[NullableContext(1)]
		public static SingleFoodFormulaInfo Create()
		{
			return new SingleFoodFormulaInfo();
		}

		// Token: 0x17005390 RID: 21392
		// (get) Token: 0x06018CB8 RID: 101560 RVA: 0x0039B89B File Offset: 0x00399A9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SingleFoodFormulaInfo> Parser
		{
			get
			{
				return SingleFoodFormulaInfo._parser;
			}
		}

		// Token: 0x17005391 RID: 21393
		// (get) Token: 0x06018CB9 RID: 101561 RVA: 0x0039B8A2 File Offset: 0x00399AA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005392 RID: 21394
		// (get) Token: 0x06018CBA RID: 101562 RVA: 0x0039B8A5 File Offset: 0x00399AA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SingleFoodFormulaInfo.Descriptor;
			}
		}

		// Token: 0x06018CBB RID: 101563 RVA: 0x0039B8AC File Offset: 0x00399AAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SingleFoodFormulaInfo()
		{
		}

		// Token: 0x06018CBC RID: 101564 RVA: 0x0039B8B4 File Offset: 0x00399AB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SingleFoodFormulaInfo(SingleFoodFormulaInfo other) : this()
		{
			this.id_ = other.id_;
			this.cookCount_ = other.cookCount_;
			this.lastRoleId_ = other.lastRoleId_;
			this.limitCount_ = other.limitCount_;
			this.limitCookCount_ = other.limitCookCount_;
			this.limitBeginTime_ = other.limitBeginTime_;
			this.limitEndTime_ = other.limitEndTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018CBD RID: 101565 RVA: 0x0039B92C File Offset: 0x00399B2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SingleFoodFormulaInfo Clone()
		{
			return new SingleFoodFormulaInfo(this);
		}

		// Token: 0x17005393 RID: 21395
		// (get) Token: 0x06018CBE RID: 101566 RVA: 0x0039B934 File Offset: 0x00399B34
		// (set) Token: 0x06018CBF RID: 101567 RVA: 0x0039B93C File Offset: 0x00399B3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17005394 RID: 21396
		// (get) Token: 0x06018CC0 RID: 101568 RVA: 0x0039B945 File Offset: 0x00399B45
		// (set) Token: 0x06018CC1 RID: 101569 RVA: 0x0039B94D File Offset: 0x00399B4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CookCount
		{
			get
			{
				return this.cookCount_;
			}
			set
			{
				this.cookCount_ = value;
			}
		}

		// Token: 0x17005395 RID: 21397
		// (get) Token: 0x06018CC2 RID: 101570 RVA: 0x0039B956 File Offset: 0x00399B56
		// (set) Token: 0x06018CC3 RID: 101571 RVA: 0x0039B95E File Offset: 0x00399B5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LastRoleId
		{
			get
			{
				return this.lastRoleId_;
			}
			set
			{
				this.lastRoleId_ = value;
			}
		}

		// Token: 0x17005396 RID: 21398
		// (get) Token: 0x06018CC4 RID: 101572 RVA: 0x0039B967 File Offset: 0x00399B67
		// (set) Token: 0x06018CC5 RID: 101573 RVA: 0x0039B96F File Offset: 0x00399B6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LimitCount
		{
			get
			{
				return this.limitCount_;
			}
			set
			{
				this.limitCount_ = value;
			}
		}

		// Token: 0x17005397 RID: 21399
		// (get) Token: 0x06018CC6 RID: 101574 RVA: 0x0039B978 File Offset: 0x00399B78
		// (set) Token: 0x06018CC7 RID: 101575 RVA: 0x0039B980 File Offset: 0x00399B80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LimitCookCount
		{
			get
			{
				return this.limitCookCount_;
			}
			set
			{
				this.limitCookCount_ = value;
			}
		}

		// Token: 0x17005398 RID: 21400
		// (get) Token: 0x06018CC8 RID: 101576 RVA: 0x0039B989 File Offset: 0x00399B89
		// (set) Token: 0x06018CC9 RID: 101577 RVA: 0x0039B991 File Offset: 0x00399B91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long LimitBeginTime
		{
			get
			{
				return this.limitBeginTime_;
			}
			set
			{
				this.limitBeginTime_ = value;
			}
		}

		// Token: 0x17005399 RID: 21401
		// (get) Token: 0x06018CCA RID: 101578 RVA: 0x0039B99A File Offset: 0x00399B9A
		// (set) Token: 0x06018CCB RID: 101579 RVA: 0x0039B9A2 File Offset: 0x00399BA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long LimitEndTime
		{
			get
			{
				return this.limitEndTime_;
			}
			set
			{
				this.limitEndTime_ = value;
			}
		}

		// Token: 0x06018CCC RID: 101580 RVA: 0x0039B9AB File Offset: 0x00399BAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SingleFoodFormulaInfo);
		}

		// Token: 0x06018CCD RID: 101581 RVA: 0x0039B9BC File Offset: 0x00399BBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SingleFoodFormulaInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.CookCount == other.CookCount && this.LastRoleId == other.LastRoleId && this.LimitCount == other.LimitCount && this.LimitCookCount == other.LimitCookCount && this.LimitBeginTime == other.LimitBeginTime && this.LimitEndTime == other.LimitEndTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018CCE RID: 101582 RVA: 0x0039BA58 File Offset: 0x00399C58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.CookCount != 0)
			{
				num ^= this.CookCount.GetHashCode();
			}
			if (this.LastRoleId != 0)
			{
				num ^= this.LastRoleId.GetHashCode();
			}
			if (this.LimitCount != 0)
			{
				num ^= this.LimitCount.GetHashCode();
			}
			if (this.LimitCookCount != 0)
			{
				num ^= this.LimitCookCount.GetHashCode();
			}
			if (this.LimitBeginTime != 0L)
			{
				num ^= this.LimitBeginTime.GetHashCode();
			}
			if (this.LimitEndTime != 0L)
			{
				num ^= this.LimitEndTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018CCF RID: 101583 RVA: 0x0039BB2D File Offset: 0x00399D2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018CD0 RID: 101584 RVA: 0x0039BB3A File Offset: 0x00399D3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018CD1 RID: 101585 RVA: 0x0039BB44 File Offset: 0x00399D44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.CookCount != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CookCount);
			}
			if (this.LastRoleId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.LastRoleId);
			}
			if (this.LimitCount != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.LimitCount);
			}
			if (this.LimitCookCount != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.LimitCookCount);
			}
			if (this.LimitBeginTime != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.LimitBeginTime);
			}
			if (this.LimitEndTime != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.LimitEndTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018CD2 RID: 101586 RVA: 0x0039BC28 File Offset: 0x00399E28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.CookCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CookCount);
			}
			if (this.LastRoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LastRoleId);
			}
			if (this.LimitCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LimitCount);
			}
			if (this.LimitCookCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LimitCookCount);
			}
			if (this.LimitBeginTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.LimitBeginTime);
			}
			if (this.LimitEndTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.LimitEndTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018CD3 RID: 101587 RVA: 0x0039BCF8 File Offset: 0x00399EF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SingleFoodFormulaInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.CookCount != 0)
			{
				this.CookCount = other.CookCount;
			}
			if (other.LastRoleId != 0)
			{
				this.LastRoleId = other.LastRoleId;
			}
			if (other.LimitCount != 0)
			{
				this.LimitCount = other.LimitCount;
			}
			if (other.LimitCookCount != 0)
			{
				this.LimitCookCount = other.LimitCookCount;
			}
			if (other.LimitBeginTime != 0L)
			{
				this.LimitBeginTime = other.LimitBeginTime;
			}
			if (other.LimitEndTime != 0L)
			{
				this.LimitEndTime = other.LimitEndTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018CD4 RID: 101588 RVA: 0x0039BDAC File Offset: 0x00399FAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018CD5 RID: 101589 RVA: 0x0039BDB8 File Offset: 0x00399FB8
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
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.CookCount = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.LastRoleId = input.ReadInt32();
						continue;
					}
				}
				else if (num <= 40U)
				{
					if (num == 32U)
					{
						this.LimitCount = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.LimitCookCount = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 48U)
					{
						this.LimitBeginTime = input.ReadInt64();
						continue;
					}
					if (num == 56U)
					{
						this.LimitEndTime = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009243 RID: 37443
		private static readonly MessageParser<SingleFoodFormulaInfo> _parser = new MessageParser<SingleFoodFormulaInfo>(() => new SingleFoodFormulaInfo());

		// Token: 0x04009244 RID: 37444
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009245 RID: 37445
		public const int IdFieldNumber = 1;

		// Token: 0x04009246 RID: 37446
		private int id_;

		// Token: 0x04009247 RID: 37447
		public const int CookCountFieldNumber = 2;

		// Token: 0x04009248 RID: 37448
		private int cookCount_;

		// Token: 0x04009249 RID: 37449
		public const int LastRoleIdFieldNumber = 3;

		// Token: 0x0400924A RID: 37450
		private int lastRoleId_;

		// Token: 0x0400924B RID: 37451
		public const int LimitCountFieldNumber = 4;

		// Token: 0x0400924C RID: 37452
		private int limitCount_;

		// Token: 0x0400924D RID: 37453
		public const int LimitCookCountFieldNumber = 5;

		// Token: 0x0400924E RID: 37454
		private int limitCookCount_;

		// Token: 0x0400924F RID: 37455
		public const int LimitBeginTimeFieldNumber = 6;

		// Token: 0x04009250 RID: 37456
		private long limitBeginTime_;

		// Token: 0x04009251 RID: 37457
		public const int LimitEndTimeFieldNumber = 7;

		// Token: 0x04009252 RID: 37458
		private long limitEndTime_;
	}
}
