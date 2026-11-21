using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009EF RID: 2543
	public sealed class MonsterInfo : IMessage<MonsterInfo>, IMessage, IEquatable<MonsterInfo>, IDeepCloneable<MonsterInfo>, IBufferMessage
	{
		// Token: 0x0600DEF0 RID: 57072 RVA: 0x0020B2BD File Offset: 0x002094BD
		[NullableContext(1)]
		public static MonsterInfo Create()
		{
			return new MonsterInfo();
		}

		// Token: 0x17002D2A RID: 11562
		// (get) Token: 0x0600DEF1 RID: 57073 RVA: 0x0020B2C4 File Offset: 0x002094C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002D2B RID: 11563
		// (get) Token: 0x0600DEF2 RID: 57074 RVA: 0x0020B2C7 File Offset: 0x002094C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonsterInfo.Descriptor;
			}
		}

		// Token: 0x0600DEF3 RID: 57075 RVA: 0x0020B2CE File Offset: 0x002094CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterInfo()
		{
		}

		// Token: 0x0600DEF4 RID: 57076 RVA: 0x0020B2D6 File Offset: 0x002094D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterInfo(MonsterInfo other) : this()
		{
			this.monsterId_ = other.monsterId_;
			this.num_ = other.num_;
			this.genId_ = other.genId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DEF5 RID: 57077 RVA: 0x0020B313 File Offset: 0x00209513
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterInfo Clone()
		{
			return new MonsterInfo(this);
		}

		// Token: 0x17002D2C RID: 11564
		// (get) Token: 0x0600DEF6 RID: 57078 RVA: 0x0020B31B File Offset: 0x0020951B
		// (set) Token: 0x0600DEF7 RID: 57079 RVA: 0x0020B323 File Offset: 0x00209523
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

		// Token: 0x17002D2D RID: 11565
		// (get) Token: 0x0600DEF8 RID: 57080 RVA: 0x0020B32C File Offset: 0x0020952C
		// (set) Token: 0x0600DEF9 RID: 57081 RVA: 0x0020B334 File Offset: 0x00209534
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

		// Token: 0x17002D2E RID: 11566
		// (get) Token: 0x0600DEFA RID: 57082 RVA: 0x0020B33D File Offset: 0x0020953D
		// (set) Token: 0x0600DEFB RID: 57083 RVA: 0x0020B345 File Offset: 0x00209545
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

		// Token: 0x0600DEFC RID: 57084 RVA: 0x0020B34E File Offset: 0x0020954E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonsterInfo);
		}

		// Token: 0x0600DEFD RID: 57085 RVA: 0x0020B35C File Offset: 0x0020955C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonsterInfo other)
		{
			return other != null && (other == this || (this.MonsterId == other.MonsterId && this.Num == other.Num && this.GenId == other.GenId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DEFE RID: 57086 RVA: 0x0020B3B8 File Offset: 0x002095B8
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

		// Token: 0x0600DEFF RID: 57087 RVA: 0x0020B429 File Offset: 0x00209629
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DF00 RID: 57088 RVA: 0x0020B436 File Offset: 0x00209636
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DF01 RID: 57089 RVA: 0x0020B440 File Offset: 0x00209640
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

		// Token: 0x0600DF02 RID: 57090 RVA: 0x0020B4B4 File Offset: 0x002096B4
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

		// Token: 0x0600DF03 RID: 57091 RVA: 0x0020B524 File Offset: 0x00209724
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

		// Token: 0x0600DF04 RID: 57092 RVA: 0x0020B588 File Offset: 0x00209788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DF05 RID: 57093 RVA: 0x0020B594 File Offset: 0x00209794
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

		// Token: 0x04005C4C RID: 23628
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005C4D RID: 23629
		public const int MonsterIdFieldNumber = 1;

		// Token: 0x04005C4E RID: 23630
		private int monsterId_;

		// Token: 0x04005C4F RID: 23631
		public const int NumFieldNumber = 2;

		// Token: 0x04005C50 RID: 23632
		private int num_;

		// Token: 0x04005C51 RID: 23633
		public const int GenIdFieldNumber = 3;

		// Token: 0x04005C52 RID: 23634
		private long genId_;
	}
}
