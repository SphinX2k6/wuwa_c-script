using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200041A RID: 1050
	public sealed class DynamicCreatureGen : IMessage<DynamicCreatureGen>, IMessage, IEquatable<DynamicCreatureGen>, IDeepCloneable<DynamicCreatureGen>, IBufferMessage
	{
		// Token: 0x060064E6 RID: 25830 RVA: 0x000F2083 File Offset: 0x000F0283
		[NullableContext(1)]
		public static DynamicCreatureGen Create()
		{
			return new DynamicCreatureGen();
		}

		// Token: 0x170012D6 RID: 4822
		// (get) Token: 0x060064E7 RID: 25831 RVA: 0x000F208A File Offset: 0x000F028A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170012D7 RID: 4823
		// (get) Token: 0x060064E8 RID: 25832 RVA: 0x000F208D File Offset: 0x000F028D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DynamicCreatureGen.Descriptor;
			}
		}

		// Token: 0x060064E9 RID: 25833 RVA: 0x000F2094 File Offset: 0x000F0294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DynamicCreatureGen()
		{
		}

		// Token: 0x060064EA RID: 25834 RVA: 0x000F209C File Offset: 0x000F029C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DynamicCreatureGen(DynamicCreatureGen other) : this()
		{
			this.creatureGenID_ = other.creatureGenID_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060064EB RID: 25835 RVA: 0x000F20C1 File Offset: 0x000F02C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DynamicCreatureGen Clone()
		{
			return new DynamicCreatureGen(this);
		}

		// Token: 0x170012D8 RID: 4824
		// (get) Token: 0x060064EC RID: 25836 RVA: 0x000F20C9 File Offset: 0x000F02C9
		// (set) Token: 0x060064ED RID: 25837 RVA: 0x000F20D1 File Offset: 0x000F02D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CreatureGenID
		{
			get
			{
				return this.creatureGenID_;
			}
			set
			{
				this.creatureGenID_ = value;
			}
		}

		// Token: 0x060064EE RID: 25838 RVA: 0x000F20DA File Offset: 0x000F02DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DynamicCreatureGen);
		}

		// Token: 0x060064EF RID: 25839 RVA: 0x000F20E8 File Offset: 0x000F02E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DynamicCreatureGen other)
		{
			return other != null && (other == this || (this.CreatureGenID == other.CreatureGenID && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060064F0 RID: 25840 RVA: 0x000F2118 File Offset: 0x000F0318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CreatureGenID != 0L)
			{
				num ^= this.CreatureGenID.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060064F1 RID: 25841 RVA: 0x000F2157 File Offset: 0x000F0357
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060064F2 RID: 25842 RVA: 0x000F2164 File Offset: 0x000F0364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060064F3 RID: 25843 RVA: 0x000F216D File Offset: 0x000F036D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CreatureGenID != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.CreatureGenID);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060064F4 RID: 25844 RVA: 0x000F21A0 File Offset: 0x000F03A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CreatureGenID != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.CreatureGenID);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060064F5 RID: 25845 RVA: 0x000F21DE File Offset: 0x000F03DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DynamicCreatureGen other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CreatureGenID != 0L)
			{
				this.CreatureGenID = other.CreatureGenID;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060064F6 RID: 25846 RVA: 0x000F220F File Offset: 0x000F040F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060064F7 RID: 25847 RVA: 0x000F2218 File Offset: 0x000F0418
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.CreatureGenID = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400387B RID: 14459
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400387C RID: 14460
		public const int CreatureGenIDFieldNumber = 1;

		// Token: 0x0400387D RID: 14461
		private long creatureGenID_;
	}
}
