using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CFD RID: 3325
	[NetMessage(EMessageId.PhantomUpdateNotify)]
	public sealed class PhantomUpdateNotify : IMessage<PhantomUpdateNotify>, IMessage, IEquatable<PhantomUpdateNotify>, IDeepCloneable<PhantomUpdateNotify>, IBufferMessage
	{
		// Token: 0x06011FE0 RID: 73696 RVA: 0x002A1BD8 File Offset: 0x0029FDD8
		[NullableContext(1)]
		public static PhantomUpdateNotify Create()
		{
			return new PhantomUpdateNotify();
		}

		// Token: 0x17003B9D RID: 15261
		// (get) Token: 0x06011FE1 RID: 73697 RVA: 0x002A1BDF File Offset: 0x0029FDDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003B9E RID: 15262
		// (get) Token: 0x06011FE2 RID: 73698 RVA: 0x002A1BE2 File Offset: 0x0029FDE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06011FE3 RID: 73699 RVA: 0x002A1BE9 File Offset: 0x0029FDE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomUpdateNotify()
		{
		}

		// Token: 0x06011FE4 RID: 73700 RVA: 0x002A1BF1 File Offset: 0x0029FDF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomUpdateNotify(PhantomUpdateNotify other) : this()
		{
			this.totalCost_ = other.totalCost_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011FE5 RID: 73701 RVA: 0x002A1C16 File Offset: 0x0029FE16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomUpdateNotify Clone()
		{
			return new PhantomUpdateNotify(this);
		}

		// Token: 0x17003B9F RID: 15263
		// (get) Token: 0x06011FE6 RID: 73702 RVA: 0x002A1C1E File Offset: 0x0029FE1E
		// (set) Token: 0x06011FE7 RID: 73703 RVA: 0x002A1C26 File Offset: 0x0029FE26
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

		// Token: 0x06011FE8 RID: 73704 RVA: 0x002A1C2F File Offset: 0x0029FE2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomUpdateNotify);
		}

		// Token: 0x06011FE9 RID: 73705 RVA: 0x002A1C3D File Offset: 0x0029FE3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomUpdateNotify other)
		{
			return other != null && (other == this || (this.TotalCost == other.TotalCost && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011FEA RID: 73706 RVA: 0x002A1C6C File Offset: 0x0029FE6C
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

		// Token: 0x06011FEB RID: 73707 RVA: 0x002A1CAB File Offset: 0x0029FEAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011FEC RID: 73708 RVA: 0x002A1CB8 File Offset: 0x0029FEB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011FED RID: 73709 RVA: 0x002A1CC1 File Offset: 0x0029FEC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TotalCost != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.TotalCost);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011FEE RID: 73710 RVA: 0x002A1CF4 File Offset: 0x0029FEF4
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

		// Token: 0x06011FEF RID: 73711 RVA: 0x002A1D32 File Offset: 0x0029FF32
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

		// Token: 0x06011FF0 RID: 73712 RVA: 0x002A1D63 File Offset: 0x0029FF63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011FF1 RID: 73713 RVA: 0x002A1D6C File Offset: 0x0029FF6C
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.TotalCost = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007119 RID: 28953
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400711A RID: 28954
		public const int TotalCostFieldNumber = 14;

		// Token: 0x0400711B RID: 28955
		private int totalCost_;
	}
}
