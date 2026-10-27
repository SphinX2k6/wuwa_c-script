using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006D9 RID: 1753
	public sealed class GiantEcoInfoPb : IMessage<GiantEcoInfoPb>, IMessage, IEquatable<GiantEcoInfoPb>, IDeepCloneable<GiantEcoInfoPb>, IBufferMessage
	{
		// Token: 0x0600A00F RID: 40975 RVA: 0x00183B27 File Offset: 0x00181D27
		[NullableContext(1)]
		public static GiantEcoInfoPb Create()
		{
			return new GiantEcoInfoPb();
		}

		// Token: 0x17002025 RID: 8229
		// (get) Token: 0x0600A010 RID: 40976 RVA: 0x00183B2E File Offset: 0x00181D2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GiantEcoInfoPb> Parser
		{
			get
			{
				return GiantEcoInfoPb._parser;
			}
		}

		// Token: 0x17002026 RID: 8230
		// (get) Token: 0x0600A011 RID: 40977 RVA: 0x00183B35 File Offset: 0x00181D35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002027 RID: 8231
		// (get) Token: 0x0600A012 RID: 40978 RVA: 0x00183B38 File Offset: 0x00181D38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GiantEcoInfoPb.Descriptor;
			}
		}

		// Token: 0x0600A013 RID: 40979 RVA: 0x00183B3F File Offset: 0x00181D3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantEcoInfoPb()
		{
		}

		// Token: 0x0600A014 RID: 40980 RVA: 0x00183B48 File Offset: 0x00181D48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantEcoInfoPb(GiantEcoInfoPb other) : this()
		{
			this.giantEcoType_ = other.giantEcoType_;
			this.level_ = other.level_;
			this.stableValue_ = other.stableValue_;
			this.status_ = other.status_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A015 RID: 40981 RVA: 0x00183B9C File Offset: 0x00181D9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantEcoInfoPb Clone()
		{
			return new GiantEcoInfoPb(this);
		}

		// Token: 0x17002028 RID: 8232
		// (get) Token: 0x0600A016 RID: 40982 RVA: 0x00183BA4 File Offset: 0x00181DA4
		// (set) Token: 0x0600A017 RID: 40983 RVA: 0x00183BAC File Offset: 0x00181DAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantEcoNetType GiantEcoType
		{
			get
			{
				return this.giantEcoType_;
			}
			set
			{
				this.giantEcoType_ = value;
			}
		}

		// Token: 0x17002029 RID: 8233
		// (get) Token: 0x0600A018 RID: 40984 RVA: 0x00183BB5 File Offset: 0x00181DB5
		// (set) Token: 0x0600A019 RID: 40985 RVA: 0x00183BBD File Offset: 0x00181DBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x1700202A RID: 8234
		// (get) Token: 0x0600A01A RID: 40986 RVA: 0x00183BC6 File Offset: 0x00181DC6
		// (set) Token: 0x0600A01B RID: 40987 RVA: 0x00183BCE File Offset: 0x00181DCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int StableValue
		{
			get
			{
				return this.stableValue_;
			}
			set
			{
				this.stableValue_ = value;
			}
		}

		// Token: 0x1700202B RID: 8235
		// (get) Token: 0x0600A01C RID: 40988 RVA: 0x00183BD7 File Offset: 0x00181DD7
		// (set) Token: 0x0600A01D RID: 40989 RVA: 0x00183BDF File Offset: 0x00181DDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantEcoNetStatus Status
		{
			get
			{
				return this.status_;
			}
			set
			{
				this.status_ = value;
			}
		}

		// Token: 0x0600A01E RID: 40990 RVA: 0x00183BE8 File Offset: 0x00181DE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GiantEcoInfoPb);
		}

		// Token: 0x0600A01F RID: 40991 RVA: 0x00183BF8 File Offset: 0x00181DF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GiantEcoInfoPb other)
		{
			return other != null && (other == this || (this.GiantEcoType == other.GiantEcoType && this.Level == other.Level && this.StableValue == other.StableValue && this.Status == other.Status && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A020 RID: 40992 RVA: 0x00183C64 File Offset: 0x00181E64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GiantEcoType != GiantEcoNetType.Fire)
			{
				num ^= this.GiantEcoType.GetHashCode();
			}
			if (this.Level != 0)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.StableValue != 0)
			{
				num ^= this.StableValue.GetHashCode();
			}
			if (this.Status != GiantEcoNetStatus.Lock)
			{
				num ^= this.Status.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A021 RID: 40993 RVA: 0x00183CFA File Offset: 0x00181EFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A022 RID: 40994 RVA: 0x00183D07 File Offset: 0x00181F07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A023 RID: 40995 RVA: 0x00183D10 File Offset: 0x00181F10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GiantEcoType != GiantEcoNetType.Fire)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.GiantEcoType);
			}
			if (this.Level != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Level);
			}
			if (this.StableValue != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.StableValue);
			}
			if (this.Status != GiantEcoNetStatus.Lock)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.Status);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A024 RID: 40996 RVA: 0x00183DA0 File Offset: 0x00181FA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GiantEcoType != GiantEcoNetType.Fire)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.GiantEcoType);
			}
			if (this.Level != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			if (this.StableValue != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StableValue);
			}
			if (this.Status != GiantEcoNetStatus.Lock)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Status);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A025 RID: 40997 RVA: 0x00183E28 File Offset: 0x00182028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GiantEcoInfoPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GiantEcoType != GiantEcoNetType.Fire)
			{
				this.GiantEcoType = other.GiantEcoType;
			}
			if (other.Level != 0)
			{
				this.Level = other.Level;
			}
			if (other.StableValue != 0)
			{
				this.StableValue = other.StableValue;
			}
			if (other.Status != GiantEcoNetStatus.Lock)
			{
				this.Status = other.Status;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A026 RID: 40998 RVA: 0x00183EA0 File Offset: 0x001820A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A027 RID: 40999 RVA: 0x00183EAC File Offset: 0x001820AC
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
						this.GiantEcoType = (GiantEcoNetType)input.ReadEnum();
						continue;
					}
					if (num == 16U)
					{
						this.Level = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.StableValue = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.Status = (GiantEcoNetStatus)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004A95 RID: 19093
		private static readonly MessageParser<GiantEcoInfoPb> _parser = new MessageParser<GiantEcoInfoPb>(() => new GiantEcoInfoPb());

		// Token: 0x04004A96 RID: 19094
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A97 RID: 19095
		public const int GiantEcoTypeFieldNumber = 1;

		// Token: 0x04004A98 RID: 19096
		private GiantEcoNetType giantEcoType_;

		// Token: 0x04004A99 RID: 19097
		public const int LevelFieldNumber = 2;

		// Token: 0x04004A9A RID: 19098
		private int level_;

		// Token: 0x04004A9B RID: 19099
		public const int StableValueFieldNumber = 3;

		// Token: 0x04004A9C RID: 19100
		private int stableValue_;

		// Token: 0x04004A9D RID: 19101
		public const int StatusFieldNumber = 4;

		// Token: 0x04004A9E RID: 19102
		private GiantEcoNetStatus status_;
	}
}
