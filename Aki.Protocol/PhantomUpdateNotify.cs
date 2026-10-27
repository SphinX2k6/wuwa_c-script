using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D0D RID: 3341
	[NetMessage(EMessageId.PhantomUpdateNotify)]
	public sealed class PhantomUpdateNotify : IMessage<PhantomUpdateNotify>, IMessage, IEquatable<PhantomUpdateNotify>, IDeepCloneable<PhantomUpdateNotify>, IBufferMessage
	{
		// Token: 0x060120DC RID: 73948 RVA: 0x002A37FD File Offset: 0x002A19FD
		[NullableContext(1)]
		public static PhantomUpdateNotify Create()
		{
			return new PhantomUpdateNotify();
		}

		// Token: 0x17003BD2 RID: 15314
		// (get) Token: 0x060120DD RID: 73949 RVA: 0x002A3804 File Offset: 0x002A1A04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003BD3 RID: 15315
		// (get) Token: 0x060120DE RID: 73950 RVA: 0x002A3807 File Offset: 0x002A1A07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomUpdateNotify.Descriptor;
			}
		}

		// Token: 0x060120DF RID: 73951 RVA: 0x002A380E File Offset: 0x002A1A0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomUpdateNotify()
		{
		}

		// Token: 0x060120E0 RID: 73952 RVA: 0x002A3816 File Offset: 0x002A1A16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomUpdateNotify(PhantomUpdateNotify other) : this()
		{
			this.totalCost_ = other.totalCost_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060120E1 RID: 73953 RVA: 0x002A383B File Offset: 0x002A1A3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomUpdateNotify Clone()
		{
			return new PhantomUpdateNotify(this);
		}

		// Token: 0x17003BD4 RID: 15316
		// (get) Token: 0x060120E2 RID: 73954 RVA: 0x002A3843 File Offset: 0x002A1A43
		// (set) Token: 0x060120E3 RID: 73955 RVA: 0x002A384B File Offset: 0x002A1A4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TotalCost
		{
			get
			{
				return this.totalCost_;
			}
			set
			{
				this.totalCost_ = value;
			}
		}

		// Token: 0x060120E4 RID: 73956 RVA: 0x002A3854 File Offset: 0x002A1A54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomUpdateNotify);
		}

		// Token: 0x060120E5 RID: 73957 RVA: 0x002A3862 File Offset: 0x002A1A62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomUpdateNotify other)
		{
			return other != null && (other == this || (this.TotalCost == other.TotalCost && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060120E6 RID: 73958 RVA: 0x002A3890 File Offset: 0x002A1A90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TotalCost != 0)
			{
				num ^= this.TotalCost.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060120E7 RID: 73959 RVA: 0x002A38CF File Offset: 0x002A1ACF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060120E8 RID: 73960 RVA: 0x002A38DC File Offset: 0x002A1ADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060120E9 RID: 73961 RVA: 0x002A38E5 File Offset: 0x002A1AE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TotalCost != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.TotalCost);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060120EA RID: 73962 RVA: 0x002A3918 File Offset: 0x002A1B18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TotalCost != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TotalCost);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060120EB RID: 73963 RVA: 0x002A3956 File Offset: 0x002A1B56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TotalCost != 0)
			{
				this.TotalCost = other.TotalCost;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060120EC RID: 73964 RVA: 0x002A3987 File Offset: 0x002A1B87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060120ED RID: 73965 RVA: 0x002A3990 File Offset: 0x002A1B90
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.TotalCost = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007101 RID: 28929
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007102 RID: 28930
		public const int TotalCostFieldNumber = 6;

		// Token: 0x04007103 RID: 28931
		private int totalCost_;
	}
}
