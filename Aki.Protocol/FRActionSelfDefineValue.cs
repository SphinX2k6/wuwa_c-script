using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200063E RID: 1598
	public sealed class FRActionSelfDefineValue : IMessage<FRActionSelfDefineValue>, IMessage, IEquatable<FRActionSelfDefineValue>, IDeepCloneable<FRActionSelfDefineValue>, IBufferMessage
	{
		// Token: 0x06009337 RID: 37687 RVA: 0x0016433B File Offset: 0x0016253B
		[NullableContext(1)]
		public static FRActionSelfDefineValue Create()
		{
			return new FRActionSelfDefineValue();
		}

		// Token: 0x17001D4F RID: 7503
		// (get) Token: 0x06009338 RID: 37688 RVA: 0x00164342 File Offset: 0x00162542
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D50 RID: 7504
		// (get) Token: 0x06009339 RID: 37689 RVA: 0x00164345 File Offset: 0x00162545
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FRActionSelfDefineValue.Descriptor;
			}
		}

		// Token: 0x0600933A RID: 37690 RVA: 0x0016434C File Offset: 0x0016254C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRActionSelfDefineValue()
		{
		}

		// Token: 0x0600933B RID: 37691 RVA: 0x00164354 File Offset: 0x00162554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRActionSelfDefineValue(FRActionSelfDefineValue other) : this()
		{
			this.unitIncId_ = other.unitIncId_;
			this.n_ = other.n_;
			this.m_ = other.m_;
			this.p_ = other.p_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600933C RID: 37692 RVA: 0x001643A8 File Offset: 0x001625A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRActionSelfDefineValue Clone()
		{
			return new FRActionSelfDefineValue(this);
		}

		// Token: 0x17001D51 RID: 7505
		// (get) Token: 0x0600933D RID: 37693 RVA: 0x001643B0 File Offset: 0x001625B0
		// (set) Token: 0x0600933E RID: 37694 RVA: 0x001643B8 File Offset: 0x001625B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int UnitIncId
		{
			get
			{
				return this.unitIncId_;
			}
			set
			{
				this.unitIncId_ = value;
			}
		}

		// Token: 0x17001D52 RID: 7506
		// (get) Token: 0x0600933F RID: 37695 RVA: 0x001643C1 File Offset: 0x001625C1
		// (set) Token: 0x06009340 RID: 37696 RVA: 0x001643C9 File Offset: 0x001625C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long N
		{
			get
			{
				return this.n_;
			}
			set
			{
				this.n_ = value;
			}
		}

		// Token: 0x17001D53 RID: 7507
		// (get) Token: 0x06009341 RID: 37697 RVA: 0x001643D2 File Offset: 0x001625D2
		// (set) Token: 0x06009342 RID: 37698 RVA: 0x001643DA File Offset: 0x001625DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long M
		{
			get
			{
				return this.m_;
			}
			set
			{
				this.m_ = value;
			}
		}

		// Token: 0x17001D54 RID: 7508
		// (get) Token: 0x06009343 RID: 37699 RVA: 0x001643E3 File Offset: 0x001625E3
		// (set) Token: 0x06009344 RID: 37700 RVA: 0x001643EB File Offset: 0x001625EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long P
		{
			get
			{
				return this.p_;
			}
			set
			{
				this.p_ = value;
			}
		}

		// Token: 0x06009345 RID: 37701 RVA: 0x001643F4 File Offset: 0x001625F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FRActionSelfDefineValue);
		}

		// Token: 0x06009346 RID: 37702 RVA: 0x00164404 File Offset: 0x00162604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FRActionSelfDefineValue other)
		{
			return other != null && (other == this || (this.UnitIncId == other.UnitIncId && this.N == other.N && this.M == other.M && this.P == other.P && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009347 RID: 37703 RVA: 0x00164470 File Offset: 0x00162670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.UnitIncId != 0)
			{
				num ^= this.UnitIncId.GetHashCode();
			}
			if (this.N != 0L)
			{
				num ^= this.N.GetHashCode();
			}
			if (this.M != 0L)
			{
				num ^= this.M.GetHashCode();
			}
			if (this.P != 0L)
			{
				num ^= this.P.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009348 RID: 37704 RVA: 0x001644FA File Offset: 0x001626FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009349 RID: 37705 RVA: 0x00164507 File Offset: 0x00162707
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600934A RID: 37706 RVA: 0x00164510 File Offset: 0x00162710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.UnitIncId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.UnitIncId);
			}
			if (this.N != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.N);
			}
			if (this.M != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.M);
			}
			if (this.P != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.P);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600934B RID: 37707 RVA: 0x001645A0 File Offset: 0x001627A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.UnitIncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.UnitIncId);
			}
			if (this.N != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.N);
			}
			if (this.M != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.M);
			}
			if (this.P != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.P);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600934C RID: 37708 RVA: 0x00164628 File Offset: 0x00162828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FRActionSelfDefineValue other)
		{
			if (other == null)
			{
				return;
			}
			if (other.UnitIncId != 0)
			{
				this.UnitIncId = other.UnitIncId;
			}
			if (other.N != 0L)
			{
				this.N = other.N;
			}
			if (other.M != 0L)
			{
				this.M = other.M;
			}
			if (other.P != 0L)
			{
				this.P = other.P;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600934D RID: 37709 RVA: 0x001646A0 File Offset: 0x001628A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600934E RID: 37710 RVA: 0x001646AC File Offset: 0x001628AC
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.UnitIncId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.N = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.M = input.ReadInt64();
						continue;
					}
					if (num == 32U)
					{
						this.P = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040046D8 RID: 18136
		private UnknownFieldSet _unknownFields;

		// Token: 0x040046D9 RID: 18137
		public const int UnitIncIdFieldNumber = 1;

		// Token: 0x040046DA RID: 18138
		private int unitIncId_;

		// Token: 0x040046DB RID: 18139
		public const int NFieldNumber = 2;

		// Token: 0x040046DC RID: 18140
		private long n_;

		// Token: 0x040046DD RID: 18141
		public const int MFieldNumber = 3;

		// Token: 0x040046DE RID: 18142
		private long m_;

		// Token: 0x040046DF RID: 18143
		public const int PFieldNumber = 4;

		// Token: 0x040046E0 RID: 18144
		private long p_;
	}
}
