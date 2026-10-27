using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A00 RID: 2560
	public sealed class MonsterInfo : IMessage<MonsterInfo>, IMessage, IEquatable<MonsterInfo>, IDeepCloneable<MonsterInfo>, IBufferMessage
	{
		// Token: 0x0600E00A RID: 57354 RVA: 0x0020D4A9 File Offset: 0x0020B6A9
		[NullableContext(1)]
		public static MonsterInfo Create()
		{
			return new MonsterInfo();
		}

		// Token: 0x17002D68 RID: 11624
		// (get) Token: 0x0600E00B RID: 57355 RVA: 0x0020D4B0 File Offset: 0x0020B6B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002D69 RID: 11625
		// (get) Token: 0x0600E00C RID: 57356 RVA: 0x0020D4B3 File Offset: 0x0020B6B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonsterInfo.Descriptor;
			}
		}

		// Token: 0x0600E00D RID: 57357 RVA: 0x0020D4BA File Offset: 0x0020B6BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterInfo()
		{
		}

		// Token: 0x0600E00E RID: 57358 RVA: 0x0020D4C2 File Offset: 0x0020B6C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterInfo(MonsterInfo other) : this()
		{
			this.monsterId_ = other.monsterId_;
			this.num_ = other.num_;
			this.genId_ = other.genId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E00F RID: 57359 RVA: 0x0020D4FF File Offset: 0x0020B6FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterInfo Clone()
		{
			return new MonsterInfo(this);
		}

		// Token: 0x17002D6A RID: 11626
		// (get) Token: 0x0600E010 RID: 57360 RVA: 0x0020D507 File Offset: 0x0020B707
		// (set) Token: 0x0600E011 RID: 57361 RVA: 0x0020D50F File Offset: 0x0020B70F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MonsterId
		{
			get
			{
				return this.monsterId_;
			}
			set
			{
				this.monsterId_ = value;
			}
		}

		// Token: 0x17002D6B RID: 11627
		// (get) Token: 0x0600E012 RID: 57362 RVA: 0x0020D518 File Offset: 0x0020B718
		// (set) Token: 0x0600E013 RID: 57363 RVA: 0x0020D520 File Offset: 0x0020B720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Num
		{
			get
			{
				return this.num_;
			}
			set
			{
				this.num_ = value;
			}
		}

		// Token: 0x17002D6C RID: 11628
		// (get) Token: 0x0600E014 RID: 57364 RVA: 0x0020D529 File Offset: 0x0020B729
		// (set) Token: 0x0600E015 RID: 57365 RVA: 0x0020D531 File Offset: 0x0020B731
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long GenId
		{
			get
			{
				return this.genId_;
			}
			set
			{
				this.genId_ = value;
			}
		}

		// Token: 0x0600E016 RID: 57366 RVA: 0x0020D53A File Offset: 0x0020B73A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonsterInfo);
		}

		// Token: 0x0600E017 RID: 57367 RVA: 0x0020D548 File Offset: 0x0020B748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonsterInfo other)
		{
			return other != null && (other == this || (this.MonsterId == other.MonsterId && this.Num == other.Num && this.GenId == other.GenId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E018 RID: 57368 RVA: 0x0020D5A4 File Offset: 0x0020B7A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MonsterId != 0)
			{
				num ^= this.MonsterId.GetHashCode();
			}
			if (this.Num != 0)
			{
				num ^= this.Num.GetHashCode();
			}
			if (this.GenId != 0L)
			{
				num ^= this.GenId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E019 RID: 57369 RVA: 0x0020D615 File Offset: 0x0020B815
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E01A RID: 57370 RVA: 0x0020D622 File Offset: 0x0020B822
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E01B RID: 57371 RVA: 0x0020D62C File Offset: 0x0020B82C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MonsterId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.MonsterId);
			}
			if (this.Num != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Num);
			}
			if (this.GenId != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.GenId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E01C RID: 57372 RVA: 0x0020D6A0 File Offset: 0x0020B8A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MonsterId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MonsterId);
			}
			if (this.Num != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Num);
			}
			if (this.GenId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.GenId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E01D RID: 57373 RVA: 0x0020D710 File Offset: 0x0020B910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonsterInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MonsterId != 0)
			{
				this.MonsterId = other.MonsterId;
			}
			if (other.Num != 0)
			{
				this.Num = other.Num;
			}
			if (other.GenId != 0L)
			{
				this.GenId = other.GenId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E01E RID: 57374 RVA: 0x0020D774 File Offset: 0x0020B974
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E01F RID: 57375 RVA: 0x0020D780 File Offset: 0x0020B980
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
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.GenId = input.ReadInt64();
						}
					}
					else
					{
						this.Num = input.ReadInt32();
					}
				}
				else
				{
					this.MonsterId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005C43 RID: 23619
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005C44 RID: 23620
		public const int MonsterIdFieldNumber = 1;

		// Token: 0x04005C45 RID: 23621
		private int monsterId_;

		// Token: 0x04005C46 RID: 23622
		public const int NumFieldNumber = 2;

		// Token: 0x04005C47 RID: 23623
		private int num_;

		// Token: 0x04005C48 RID: 23624
		public const int GenIdFieldNumber = 3;

		// Token: 0x04005C49 RID: 23625
		private long genId_;
	}
}
