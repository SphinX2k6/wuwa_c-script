using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002C8 RID: 712
	public sealed class CompleteInstProgress : IMessage<CompleteInstProgress>, IMessage, IEquatable<CompleteInstProgress>, IDeepCloneable<CompleteInstProgress>, IBufferMessage
	{
		// Token: 0x0600496B RID: 18795 RVA: 0x000B4001 File Offset: 0x000B2201
		[NullableContext(1)]
		public static CompleteInstProgress Create()
		{
			return new CompleteInstProgress();
		}

		// Token: 0x17000CD7 RID: 3287
		// (get) Token: 0x0600496C RID: 18796 RVA: 0x000B4008 File Offset: 0x000B2208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000CD8 RID: 3288
		// (get) Token: 0x0600496D RID: 18797 RVA: 0x000B400B File Offset: 0x000B220B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CompleteInstProgress.Descriptor;
			}
		}

		// Token: 0x0600496E RID: 18798 RVA: 0x000B4012 File Offset: 0x000B2212
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CompleteInstProgress()
		{
		}

		// Token: 0x0600496F RID: 18799 RVA: 0x000B401A File Offset: 0x000B221A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CompleteInstProgress(CompleteInstProgress other) : this()
		{
			this.instId_ = other.instId_;
			this.count_ = other.count_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004970 RID: 18800 RVA: 0x000B404B File Offset: 0x000B224B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CompleteInstProgress Clone()
		{
			return new CompleteInstProgress(this);
		}

		// Token: 0x17000CD9 RID: 3289
		// (get) Token: 0x06004971 RID: 18801 RVA: 0x000B4053 File Offset: 0x000B2253
		// (set) Token: 0x06004972 RID: 18802 RVA: 0x000B405B File Offset: 0x000B225B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstId
		{
			get
			{
				return this.instId_;
			}
			set
			{
				this.instId_ = value;
			}
		}

		// Token: 0x17000CDA RID: 3290
		// (get) Token: 0x06004973 RID: 18803 RVA: 0x000B4064 File Offset: 0x000B2264
		// (set) Token: 0x06004974 RID: 18804 RVA: 0x000B406C File Offset: 0x000B226C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Count
		{
			get
			{
				return this.count_;
			}
			set
			{
				this.count_ = value;
			}
		}

		// Token: 0x06004975 RID: 18805 RVA: 0x000B4075 File Offset: 0x000B2275
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CompleteInstProgress);
		}

		// Token: 0x06004976 RID: 18806 RVA: 0x000B4083 File Offset: 0x000B2283
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CompleteInstProgress other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.Count == other.Count && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004977 RID: 18807 RVA: 0x000B40C4 File Offset: 0x000B22C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			if (this.Count != 0)
			{
				num ^= this.Count.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004978 RID: 18808 RVA: 0x000B411C File Offset: 0x000B231C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004979 RID: 18809 RVA: 0x000B4129 File Offset: 0x000B2329
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600497A RID: 18810 RVA: 0x000B4134 File Offset: 0x000B2334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InstId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.InstId);
			}
			if (this.Count != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Count);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600497B RID: 18811 RVA: 0x000B418C File Offset: 0x000B238C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			if (this.Count != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Count);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600497C RID: 18812 RVA: 0x000B41E4 File Offset: 0x000B23E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CompleteInstProgress other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			if (other.Count != 0)
			{
				this.Count = other.Count;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600497D RID: 18813 RVA: 0x000B4234 File Offset: 0x000B2434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600497E RID: 18814 RVA: 0x000B4240 File Offset: 0x000B2440
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Count = input.ReadInt32();
					}
				}
				else
				{
					this.InstId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003080 RID: 12416
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003081 RID: 12417
		public const int InstIdFieldNumber = 1;

		// Token: 0x04003082 RID: 12418
		private int instId_;

		// Token: 0x04003083 RID: 12419
		public const int CountFieldNumber = 2;

		// Token: 0x04003084 RID: 12420
		private int count_;
	}
}
