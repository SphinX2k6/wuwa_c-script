using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200043E RID: 1086
	public sealed class EndlessBattleRecord : IMessage<EndlessBattleRecord>, IMessage, IEquatable<EndlessBattleRecord>, IDeepCloneable<EndlessBattleRecord>, IBufferMessage
	{
		// Token: 0x060067F7 RID: 26615 RVA: 0x000F981D File Offset: 0x000F7A1D
		[NullableContext(1)]
		public static EndlessBattleRecord Create()
		{
			return new EndlessBattleRecord();
		}

		// Token: 0x1700138E RID: 5006
		// (get) Token: 0x060067F8 RID: 26616 RVA: 0x000F9824 File Offset: 0x000F7A24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700138F RID: 5007
		// (get) Token: 0x060067F9 RID: 26617 RVA: 0x000F9827 File Offset: 0x000F7A27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EndlessBattleRecord.Descriptor;
			}
		}

		// Token: 0x060067FA RID: 26618 RVA: 0x000F982E File Offset: 0x000F7A2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EndlessBattleRecord()
		{
		}

		// Token: 0x060067FB RID: 26619 RVA: 0x000F9838 File Offset: 0x000F7A38
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

		// Token: 0x060067FC RID: 26620 RVA: 0x000F98AC File Offset: 0x000F7AAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EndlessBattleRecord Clone()
		{
			return new EndlessBattleRecord(this);
		}

		// Token: 0x17001390 RID: 5008
		// (get) Token: 0x060067FD RID: 26621 RVA: 0x000F98B4 File Offset: 0x000F7AB4
		// (set) Token: 0x060067FE RID: 26622 RVA: 0x000F98BC File Offset: 0x000F7ABC
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

		// Token: 0x17001391 RID: 5009
		// (get) Token: 0x060067FF RID: 26623 RVA: 0x000F98C5 File Offset: 0x000F7AC5
		// (set) Token: 0x06006800 RID: 26624 RVA: 0x000F98CD File Offset: 0x000F7ACD
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

		// Token: 0x17001392 RID: 5010
		// (get) Token: 0x06006801 RID: 26625 RVA: 0x000F98D6 File Offset: 0x000F7AD6
		// (set) Token: 0x06006802 RID: 26626 RVA: 0x000F98DE File Offset: 0x000F7ADE
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

		// Token: 0x17001393 RID: 5011
		// (get) Token: 0x06006803 RID: 26627 RVA: 0x000F98E7 File Offset: 0x000F7AE7
		// (set) Token: 0x06006804 RID: 26628 RVA: 0x000F98EF File Offset: 0x000F7AEF
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

		// Token: 0x06006805 RID: 26629 RVA: 0x000F98F8 File Offset: 0x000F7AF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EndlessBattleRecord);
		}

		// Token: 0x06006806 RID: 26630 RVA: 0x000F9908 File Offset: 0x000F7B08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EndlessBattleRecord other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this.FirstRecord, other.FirstRecord) && object.Equals(this.SecondRecord, other.SecondRecord) && this.SaveTime == other.SaveTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006807 RID: 26631 RVA: 0x000F997C File Offset: 0x000F7B7C
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

		// Token: 0x06006808 RID: 26632 RVA: 0x000F9A00 File Offset: 0x000F7C00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006809 RID: 26633 RVA: 0x000F9A0D File Offset: 0x000F7C0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600680A RID: 26634 RVA: 0x000F9A18 File Offset: 0x000F7C18
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

		// Token: 0x0600680B RID: 26635 RVA: 0x000F9AA8 File Offset: 0x000F7CA8
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

		// Token: 0x0600680C RID: 26636 RVA: 0x000F9B30 File Offset: 0x000F7D30
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

		// Token: 0x0600680D RID: 26637 RVA: 0x000F9BD8 File Offset: 0x000F7DD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600680E RID: 26638 RVA: 0x000F9BE4 File Offset: 0x000F7DE4
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

		// Token: 0x0400398B RID: 14731
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400398C RID: 14732
		public const int IdFieldNumber = 1;

		// Token: 0x0400398D RID: 14733
		private int id_;

		// Token: 0x0400398E RID: 14734
		public const int FirstRecordFieldNumber = 2;

		// Token: 0x0400398F RID: 14735
		private HalfEndlessBattleRecord firstRecord_;

		// Token: 0x04003990 RID: 14736
		public const int SecondRecordFieldNumber = 3;

		// Token: 0x04003991 RID: 14737
		private HalfEndlessBattleRecord secondRecord_;

		// Token: 0x04003992 RID: 14738
		public const int SaveTimeFieldNumber = 4;

		// Token: 0x04003993 RID: 14739
		private long saveTime_;
	}
}
