using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000427 RID: 1063
	public sealed class EndlessBattleRecord : IMessage<EndlessBattleRecord>, IMessage, IEquatable<EndlessBattleRecord>, IDeepCloneable<EndlessBattleRecord>, IBufferMessage
	{
		// Token: 0x06006667 RID: 26215 RVA: 0x000F66A1 File Offset: 0x000F48A1
		[NullableContext(1)]
		public static EndlessBattleRecord Create()
		{
			return new EndlessBattleRecord();
		}

		// Token: 0x17001339 RID: 4921
		// (get) Token: 0x06006668 RID: 26216 RVA: 0x000F66A8 File Offset: 0x000F48A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700133A RID: 4922
		// (get) Token: 0x06006669 RID: 26217 RVA: 0x000F66AB File Offset: 0x000F48AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EndlessBattleRecord.Descriptor;
			}
		}

		// Token: 0x0600666A RID: 26218 RVA: 0x000F66B2 File Offset: 0x000F48B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EndlessBattleRecord()
		{
		}

		// Token: 0x0600666B RID: 26219 RVA: 0x000F66BC File Offset: 0x000F48BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EndlessBattleRecord(EndlessBattleRecord other) : this()
		{
			this.id_ = other.id_;
			this.firstRecord_ = ((other.firstRecord_ != null) ? other.firstRecord_.Clone() : null);
			this.secondRecord_ = ((other.secondRecord_ != null) ? other.secondRecord_.Clone() : null);
			this.saveTime_ = other.saveTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600666C RID: 26220 RVA: 0x000F6730 File Offset: 0x000F4930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EndlessBattleRecord Clone()
		{
			return new EndlessBattleRecord(this);
		}

		// Token: 0x1700133B RID: 4923
		// (get) Token: 0x0600666D RID: 26221 RVA: 0x000F6738 File Offset: 0x000F4938
		// (set) Token: 0x0600666E RID: 26222 RVA: 0x000F6740 File Offset: 0x000F4940
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

		// Token: 0x1700133C RID: 4924
		// (get) Token: 0x0600666F RID: 26223 RVA: 0x000F6749 File Offset: 0x000F4949
		// (set) Token: 0x06006670 RID: 26224 RVA: 0x000F6751 File Offset: 0x000F4951
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HalfEndlessBattleRecord FirstRecord
		{
			get
			{
				return this.firstRecord_;
			}
			set
			{
				this.firstRecord_ = value;
			}
		}

		// Token: 0x1700133D RID: 4925
		// (get) Token: 0x06006671 RID: 26225 RVA: 0x000F675A File Offset: 0x000F495A
		// (set) Token: 0x06006672 RID: 26226 RVA: 0x000F6762 File Offset: 0x000F4962
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HalfEndlessBattleRecord SecondRecord
		{
			get
			{
				return this.secondRecord_;
			}
			set
			{
				this.secondRecord_ = value;
			}
		}

		// Token: 0x1700133E RID: 4926
		// (get) Token: 0x06006673 RID: 26227 RVA: 0x000F676B File Offset: 0x000F496B
		// (set) Token: 0x06006674 RID: 26228 RVA: 0x000F6773 File Offset: 0x000F4973
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long SaveTime
		{
			get
			{
				return this.saveTime_;
			}
			set
			{
				this.saveTime_ = value;
			}
		}

		// Token: 0x06006675 RID: 26229 RVA: 0x000F677C File Offset: 0x000F497C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EndlessBattleRecord);
		}

		// Token: 0x06006676 RID: 26230 RVA: 0x000F678C File Offset: 0x000F498C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EndlessBattleRecord other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this.FirstRecord, other.FirstRecord) && object.Equals(this.SecondRecord, other.SecondRecord) && this.SaveTime == other.SaveTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006677 RID: 26231 RVA: 0x000F6800 File Offset: 0x000F4A00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.firstRecord_ != null)
			{
				num ^= this.FirstRecord.GetHashCode();
			}
			if (this.secondRecord_ != null)
			{
				num ^= this.SecondRecord.GetHashCode();
			}
			if (this.SaveTime != 0L)
			{
				num ^= this.SaveTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006678 RID: 26232 RVA: 0x000F6884 File Offset: 0x000F4A84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006679 RID: 26233 RVA: 0x000F6891 File Offset: 0x000F4A91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600667A RID: 26234 RVA: 0x000F689C File Offset: 0x000F4A9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.firstRecord_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.FirstRecord);
			}
			if (this.secondRecord_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.SecondRecord);
			}
			if (this.SaveTime != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.SaveTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600667B RID: 26235 RVA: 0x000F692C File Offset: 0x000F4B2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.firstRecord_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FirstRecord);
			}
			if (this.secondRecord_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SecondRecord);
			}
			if (this.SaveTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.SaveTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600667C RID: 26236 RVA: 0x000F69B4 File Offset: 0x000F4BB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EndlessBattleRecord other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.firstRecord_ != null)
			{
				if (this.firstRecord_ == null)
				{
					this.FirstRecord = new HalfEndlessBattleRecord();
				}
				this.FirstRecord.MergeFrom(other.FirstRecord);
			}
			if (other.secondRecord_ != null)
			{
				if (this.secondRecord_ == null)
				{
					this.SecondRecord = new HalfEndlessBattleRecord();
				}
				this.SecondRecord.MergeFrom(other.SecondRecord);
			}
			if (other.SaveTime != 0L)
			{
				this.SaveTime = other.SaveTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600667D RID: 26237 RVA: 0x000F6A5C File Offset: 0x000F4C5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600667E RID: 26238 RVA: 0x000F6A68 File Offset: 0x000F4C68
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
				if (num <= 18U)
				{
					if (num == 8U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
					if (num == 18U)
					{
						if (this.firstRecord_ == null)
						{
							this.FirstRecord = new HalfEndlessBattleRecord();
						}
						input.ReadMessage(this.FirstRecord);
						continue;
					}
				}
				else
				{
					if (num == 26U)
					{
						if (this.secondRecord_ == null)
						{
							this.SecondRecord = new HalfEndlessBattleRecord();
						}
						input.ReadMessage(this.SecondRecord);
						continue;
					}
					if (num == 32U)
					{
						this.SaveTime = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003978 RID: 14712
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003979 RID: 14713
		public const int IdFieldNumber = 1;

		// Token: 0x0400397A RID: 14714
		private int id_;

		// Token: 0x0400397B RID: 14715
		public const int FirstRecordFieldNumber = 2;

		// Token: 0x0400397C RID: 14716
		private HalfEndlessBattleRecord firstRecord_;

		// Token: 0x0400397D RID: 14717
		public const int SecondRecordFieldNumber = 3;

		// Token: 0x0400397E RID: 14718
		private HalfEndlessBattleRecord secondRecord_;

		// Token: 0x0400397F RID: 14719
		public const int SaveTimeFieldNumber = 4;

		// Token: 0x04003980 RID: 14720
		private long saveTime_;
	}
}
