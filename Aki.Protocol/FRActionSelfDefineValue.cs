using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200062A RID: 1578
	public sealed class FRActionSelfDefineValue : IMessage<FRActionSelfDefineValue>, IMessage, IEquatable<FRActionSelfDefineValue>, IDeepCloneable<FRActionSelfDefineValue>, IBufferMessage
	{
		// Token: 0x060091E1 RID: 37345 RVA: 0x0016190F File Offset: 0x0015FB0F
		[NullableContext(1)]
		public static FRActionSelfDefineValue Create()
		{
			return new FRActionSelfDefineValue();
		}

		// Token: 0x17001D05 RID: 7429
		// (get) Token: 0x060091E2 RID: 37346 RVA: 0x00161916 File Offset: 0x0015FB16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D06 RID: 7430
		// (get) Token: 0x060091E3 RID: 37347 RVA: 0x00161919 File Offset: 0x0015FB19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FRActionSelfDefineValue.Descriptor;
			}
		}

		// Token: 0x060091E4 RID: 37348 RVA: 0x00161920 File Offset: 0x0015FB20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRActionSelfDefineValue()
		{
		}

		// Token: 0x060091E5 RID: 37349 RVA: 0x00161928 File Offset: 0x0015FB28
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

		// Token: 0x060091E6 RID: 37350 RVA: 0x0016197C File Offset: 0x0015FB7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRActionSelfDefineValue Clone()
		{
			return new FRActionSelfDefineValue(this);
		}

		// Token: 0x17001D07 RID: 7431
		// (get) Token: 0x060091E7 RID: 37351 RVA: 0x00161984 File Offset: 0x0015FB84
		// (set) Token: 0x060091E8 RID: 37352 RVA: 0x0016198C File Offset: 0x0015FB8C
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

		// Token: 0x17001D08 RID: 7432
		// (get) Token: 0x060091E9 RID: 37353 RVA: 0x00161995 File Offset: 0x0015FB95
		// (set) Token: 0x060091EA RID: 37354 RVA: 0x0016199D File Offset: 0x0015FB9D
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

		// Token: 0x17001D09 RID: 7433
		// (get) Token: 0x060091EB RID: 37355 RVA: 0x001619A6 File Offset: 0x0015FBA6
		// (set) Token: 0x060091EC RID: 37356 RVA: 0x001619AE File Offset: 0x0015FBAE
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

		// Token: 0x17001D0A RID: 7434
		// (get) Token: 0x060091ED RID: 37357 RVA: 0x001619B7 File Offset: 0x0015FBB7
		// (set) Token: 0x060091EE RID: 37358 RVA: 0x001619BF File Offset: 0x0015FBBF
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

		// Token: 0x060091EF RID: 37359 RVA: 0x001619C8 File Offset: 0x0015FBC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FRActionSelfDefineValue);
		}

		// Token: 0x060091F0 RID: 37360 RVA: 0x001619D8 File Offset: 0x0015FBD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FRActionSelfDefineValue other)
		{
			return other != null && (other == this || (this.UnitIncId == other.UnitIncId && this.N == other.N && this.M == other.M && this.P == other.P && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060091F1 RID: 37361 RVA: 0x00161A44 File Offset: 0x0015FC44
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

		// Token: 0x060091F2 RID: 37362 RVA: 0x00161ACE File Offset: 0x0015FCCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060091F3 RID: 37363 RVA: 0x00161ADB File Offset: 0x0015FCDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060091F4 RID: 37364 RVA: 0x00161AE4 File Offset: 0x0015FCE4
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

		// Token: 0x060091F5 RID: 37365 RVA: 0x00161B74 File Offset: 0x0015FD74
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

		// Token: 0x060091F6 RID: 37366 RVA: 0x00161BFC File Offset: 0x0015FDFC
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

		// Token: 0x060091F7 RID: 37367 RVA: 0x00161C74 File Offset: 0x0015FE74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060091F8 RID: 37368 RVA: 0x00161C80 File Offset: 0x0015FE80
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

		// Token: 0x040046D1 RID: 18129
		private UnknownFieldSet _unknownFields;

		// Token: 0x040046D2 RID: 18130
		public const int UnitIncIdFieldNumber = 1;

		// Token: 0x040046D3 RID: 18131
		private int unitIncId_;

		// Token: 0x040046D4 RID: 18132
		public const int NFieldNumber = 2;

		// Token: 0x040046D5 RID: 18133
		private long n_;

		// Token: 0x040046D6 RID: 18134
		public const int MFieldNumber = 3;

		// Token: 0x040046D7 RID: 18135
		private long m_;

		// Token: 0x040046D8 RID: 18136
		public const int PFieldNumber = 4;

		// Token: 0x040046D9 RID: 18137
		private long p_;
	}
}
