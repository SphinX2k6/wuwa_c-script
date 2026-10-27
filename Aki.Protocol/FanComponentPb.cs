using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200051B RID: 1307
	public sealed class FanComponentPb : IMessage<FanComponentPb>, IMessage, IEquatable<FanComponentPb>, IDeepCloneable<FanComponentPb>, IBufferMessage
	{
		// Token: 0x06007AC9 RID: 31433 RVA: 0x0012A156 File Offset: 0x00128356
		[NullableContext(1)]
		public static FanComponentPb Create()
		{
			return new FanComponentPb();
		}

		// Token: 0x170017D0 RID: 6096
		// (get) Token: 0x06007ACA RID: 31434 RVA: 0x0012A15D File Offset: 0x0012835D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170017D1 RID: 6097
		// (get) Token: 0x06007ACB RID: 31435 RVA: 0x0012A160 File Offset: 0x00128360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FanComponentPb.Descriptor;
			}
		}

		// Token: 0x06007ACC RID: 31436 RVA: 0x0012A167 File Offset: 0x00128367
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FanComponentPb()
		{
		}

		// Token: 0x06007ACD RID: 31437 RVA: 0x0012A16F File Offset: 0x0012836F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FanComponentPb(FanComponentPb other) : this()
		{
			this.numOfTurns_ = other.numOfTurns_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007ACE RID: 31438 RVA: 0x0012A194 File Offset: 0x00128394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FanComponentPb Clone()
		{
			return new FanComponentPb(this);
		}

		// Token: 0x170017D2 RID: 6098
		// (get) Token: 0x06007ACF RID: 31439 RVA: 0x0012A19C File Offset: 0x0012839C
		// (set) Token: 0x06007AD0 RID: 31440 RVA: 0x0012A1A4 File Offset: 0x001283A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int NumOfTurns
		{
			get
			{
				return this.numOfTurns_;
			}
			set
			{
				this.numOfTurns_ = value;
			}
		}

		// Token: 0x06007AD1 RID: 31441 RVA: 0x0012A1AD File Offset: 0x001283AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FanComponentPb);
		}

		// Token: 0x06007AD2 RID: 31442 RVA: 0x0012A1BB File Offset: 0x001283BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FanComponentPb other)
		{
			return other != null && (other == this || (this.NumOfTurns == other.NumOfTurns && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007AD3 RID: 31443 RVA: 0x0012A1EC File Offset: 0x001283EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.NumOfTurns != 0)
			{
				num ^= this.NumOfTurns.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007AD4 RID: 31444 RVA: 0x0012A22B File Offset: 0x0012842B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007AD5 RID: 31445 RVA: 0x0012A238 File Offset: 0x00128438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007AD6 RID: 31446 RVA: 0x0012A241 File Offset: 0x00128441
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NumOfTurns != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.NumOfTurns);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007AD7 RID: 31447 RVA: 0x0012A274 File Offset: 0x00128474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.NumOfTurns != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.NumOfTurns);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007AD8 RID: 31448 RVA: 0x0012A2B2 File Offset: 0x001284B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FanComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.NumOfTurns != 0)
			{
				this.NumOfTurns = other.NumOfTurns;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007AD9 RID: 31449 RVA: 0x0012A2E3 File Offset: 0x001284E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007ADA RID: 31450 RVA: 0x0012A2EC File Offset: 0x001284EC
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
					this.NumOfTurns = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003EFF RID: 16127
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F00 RID: 16128
		public const int NumOfTurnsFieldNumber = 1;

		// Token: 0x04003F01 RID: 16129
		private int numOfTurns_;
	}
}
