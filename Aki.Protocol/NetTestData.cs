using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AE1 RID: 2785
	public sealed class NetTestData : IMessage<NetTestData>, IMessage, IEquatable<NetTestData>, IDeepCloneable<NetTestData>, IBufferMessage
	{
		// Token: 0x0600F283 RID: 62083 RVA: 0x00236D30 File Offset: 0x00234F30
		[NullableContext(1)]
		public static NetTestData Create()
		{
			return new NetTestData();
		}

		// Token: 0x1700315D RID: 12637
		// (get) Token: 0x0600F284 RID: 62084 RVA: 0x00236D37 File Offset: 0x00234F37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700315E RID: 12638
		// (get) Token: 0x0600F285 RID: 62085 RVA: 0x00236D3A File Offset: 0x00234F3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NetTestData.Descriptor;
			}
		}

		// Token: 0x0600F286 RID: 62086 RVA: 0x00236D41 File Offset: 0x00234F41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NetTestData()
		{
		}

		// Token: 0x0600F287 RID: 62087 RVA: 0x00236D60 File Offset: 0x00234F60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NetTestData(NetTestData other) : this()
		{
			this.dataDouble_ = other.dataDouble_;
			this.dataFloat_ = other.dataFloat_;
			this.dataInt32_ = other.dataInt32_;
			this.dataSInt32_ = other.dataSInt32_;
			this.dataUInt32_ = other.dataUInt32_;
			this.dataInt64_ = other.dataInt64_;
			this.dataSInt64_ = other.dataSInt64_;
			this.dataUInt64_ = other.dataUInt64_;
			this.dataFixed32_ = other.dataFixed32_;
			this.dataFixed64_ = other.dataFixed64_;
			this.dataSFixed32_ = other.dataSFixed32_;
			this.dataSFixed64_ = other.dataSFixed64_;
			this.dataBool_ = other.dataBool_;
			this.dataString_ = other.dataString_;
			this.dataBytes_ = other.dataBytes_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F288 RID: 62088 RVA: 0x00236E38 File Offset: 0x00235038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NetTestData Clone()
		{
			return new NetTestData(this);
		}

		// Token: 0x1700315F RID: 12639
		// (get) Token: 0x0600F289 RID: 62089 RVA: 0x00236E40 File Offset: 0x00235040
		// (set) Token: 0x0600F28A RID: 62090 RVA: 0x00236E48 File Offset: 0x00235048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public double DataDouble
		{
			get
			{
				return this.dataDouble_;
			}
			set
			{
				this.dataDouble_ = value;
			}
		}

		// Token: 0x17003160 RID: 12640
		// (get) Token: 0x0600F28B RID: 62091 RVA: 0x00236E51 File Offset: 0x00235051
		// (set) Token: 0x0600F28C RID: 62092 RVA: 0x00236E59 File Offset: 0x00235059
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float DataFloat
		{
			get
			{
				return this.dataFloat_;
			}
			set
			{
				this.dataFloat_ = value;
			}
		}

		// Token: 0x17003161 RID: 12641
		// (get) Token: 0x0600F28D RID: 62093 RVA: 0x00236E62 File Offset: 0x00235062
		// (set) Token: 0x0600F28E RID: 62094 RVA: 0x00236E6A File Offset: 0x0023506A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DataInt32
		{
			get
			{
				return this.dataInt32_;
			}
			set
			{
				this.dataInt32_ = value;
			}
		}

		// Token: 0x17003162 RID: 12642
		// (get) Token: 0x0600F28F RID: 62095 RVA: 0x00236E73 File Offset: 0x00235073
		// (set) Token: 0x0600F290 RID: 62096 RVA: 0x00236E7B File Offset: 0x0023507B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DataSInt32
		{
			get
			{
				return this.dataSInt32_;
			}
			set
			{
				this.dataSInt32_ = value;
			}
		}

		// Token: 0x17003163 RID: 12643
		// (get) Token: 0x0600F291 RID: 62097 RVA: 0x00236E84 File Offset: 0x00235084
		// (set) Token: 0x0600F292 RID: 62098 RVA: 0x00236E8C File Offset: 0x0023508C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DataUInt32
		{
			get
			{
				return this.dataUInt32_;
			}
			set
			{
				this.dataUInt32_ = value;
			}
		}

		// Token: 0x17003164 RID: 12644
		// (get) Token: 0x0600F293 RID: 62099 RVA: 0x00236E95 File Offset: 0x00235095
		// (set) Token: 0x0600F294 RID: 62100 RVA: 0x00236E9D File Offset: 0x0023509D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long DataInt64
		{
			get
			{
				return this.dataInt64_;
			}
			set
			{
				this.dataInt64_ = value;
			}
		}

		// Token: 0x17003165 RID: 12645
		// (get) Token: 0x0600F295 RID: 62101 RVA: 0x00236EA6 File Offset: 0x002350A6
		// (set) Token: 0x0600F296 RID: 62102 RVA: 0x00236EAE File Offset: 0x002350AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long DataSInt64
		{
			get
			{
				return this.dataSInt64_;
			}
			set
			{
				this.dataSInt64_ = value;
			}
		}

		// Token: 0x17003166 RID: 12646
		// (get) Token: 0x0600F297 RID: 62103 RVA: 0x00236EB7 File Offset: 0x002350B7
		// (set) Token: 0x0600F298 RID: 62104 RVA: 0x00236EBF File Offset: 0x002350BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ulong DataUInt64
		{
			get
			{
				return this.dataUInt64_;
			}
			set
			{
				this.dataUInt64_ = value;
			}
		}

		// Token: 0x17003167 RID: 12647
		// (get) Token: 0x0600F299 RID: 62105 RVA: 0x00236EC8 File Offset: 0x002350C8
		// (set) Token: 0x0600F29A RID: 62106 RVA: 0x00236ED0 File Offset: 0x002350D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DataFixed32
		{
			get
			{
				return this.dataFixed32_;
			}
			set
			{
				this.dataFixed32_ = value;
			}
		}

		// Token: 0x17003168 RID: 12648
		// (get) Token: 0x0600F29B RID: 62107 RVA: 0x00236ED9 File Offset: 0x002350D9
		// (set) Token: 0x0600F29C RID: 62108 RVA: 0x00236EE1 File Offset: 0x002350E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ulong DataFixed64
		{
			get
			{
				return this.dataFixed64_;
			}
			set
			{
				this.dataFixed64_ = value;
			}
		}

		// Token: 0x17003169 RID: 12649
		// (get) Token: 0x0600F29D RID: 62109 RVA: 0x00236EEA File Offset: 0x002350EA
		// (set) Token: 0x0600F29E RID: 62110 RVA: 0x00236EF2 File Offset: 0x002350F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DataSFixed32
		{
			get
			{
				return this.dataSFixed32_;
			}
			set
			{
				this.dataSFixed32_ = value;
			}
		}

		// Token: 0x1700316A RID: 12650
		// (get) Token: 0x0600F29F RID: 62111 RVA: 0x00236EFB File Offset: 0x002350FB
		// (set) Token: 0x0600F2A0 RID: 62112 RVA: 0x00236F03 File Offset: 0x00235103
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long DataSFixed64
		{
			get
			{
				return this.dataSFixed64_;
			}
			set
			{
				this.dataSFixed64_ = value;
			}
		}

		// Token: 0x1700316B RID: 12651
		// (get) Token: 0x0600F2A1 RID: 62113 RVA: 0x00236F0C File Offset: 0x0023510C
		// (set) Token: 0x0600F2A2 RID: 62114 RVA: 0x00236F14 File Offset: 0x00235114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool DataBool
		{
			get
			{
				return this.dataBool_;
			}
			set
			{
				this.dataBool_ = value;
			}
		}

		// Token: 0x1700316C RID: 12652
		// (get) Token: 0x0600F2A3 RID: 62115 RVA: 0x00236F1D File Offset: 0x0023511D
		// (set) Token: 0x0600F2A4 RID: 62116 RVA: 0x00236F25 File Offset: 0x00235125
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string DataString
		{
			get
			{
				return this.dataString_;
			}
			set
			{
				this.dataString_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700316D RID: 12653
		// (get) Token: 0x0600F2A5 RID: 62117 RVA: 0x00236F38 File Offset: 0x00235138
		// (set) Token: 0x0600F2A6 RID: 62118 RVA: 0x00236F40 File Offset: 0x00235140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ByteString DataBytes
		{
			get
			{
				return this.dataBytes_;
			}
			set
			{
				this.dataBytes_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x0600F2A7 RID: 62119 RVA: 0x00236F53 File Offset: 0x00235153
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NetTestData);
		}

		// Token: 0x0600F2A8 RID: 62120 RVA: 0x00236F64 File Offset: 0x00235164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NetTestData other)
		{
			return other != null && (other == this || (ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.DataDouble, other.DataDouble) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.DataFloat, other.DataFloat) && this.DataInt32 == other.DataInt32 && this.DataSInt32 == other.DataSInt32 && this.DataUInt32 == other.DataUInt32 && this.DataInt64 == other.DataInt64 && this.DataSInt64 == other.DataSInt64 && this.DataUInt64 == other.DataUInt64 && this.DataFixed32 == other.DataFixed32 && this.DataFixed64 == other.DataFixed64 && this.DataSFixed32 == other.DataSFixed32 && this.DataSFixed64 == other.DataSFixed64 && this.DataBool == other.DataBool && !(this.DataString != other.DataString) && !(this.DataBytes != other.DataBytes) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F2A9 RID: 62121 RVA: 0x0023709C File Offset: 0x0023529C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DataDouble != 0.0)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.DataDouble);
			}
			if (this.DataFloat != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.DataFloat);
			}
			if (this.DataInt32 != 0)
			{
				num ^= this.DataInt32.GetHashCode();
			}
			if (this.DataSInt32 != 0)
			{
				num ^= this.DataSInt32.GetHashCode();
			}
			if (this.DataUInt32 != 0U)
			{
				num ^= this.DataUInt32.GetHashCode();
			}
			if (this.DataInt64 != 0L)
			{
				num ^= this.DataInt64.GetHashCode();
			}
			if (this.DataSInt64 != 0L)
			{
				num ^= this.DataSInt64.GetHashCode();
			}
			if (this.DataUInt64 != 0UL)
			{
				num ^= this.DataUInt64.GetHashCode();
			}
			if (this.DataFixed32 != 0U)
			{
				num ^= this.DataFixed32.GetHashCode();
			}
			if (this.DataFixed64 != 0UL)
			{
				num ^= this.DataFixed64.GetHashCode();
			}
			if (this.DataSFixed32 != 0)
			{
				num ^= this.DataSFixed32.GetHashCode();
			}
			if (this.DataSFixed64 != 0L)
			{
				num ^= this.DataSFixed64.GetHashCode();
			}
			if (this.DataBool)
			{
				num ^= this.DataBool.GetHashCode();
			}
			if (this.DataString.Length != 0)
			{
				num ^= this.DataString.GetHashCode();
			}
			if (this.DataBytes.Length != 0)
			{
				num ^= this.DataBytes.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F2AA RID: 62122 RVA: 0x00237252 File Offset: 0x00235452
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F2AB RID: 62123 RVA: 0x0023725F File Offset: 0x0023545F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F2AC RID: 62124 RVA: 0x00237268 File Offset: 0x00235468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DataDouble != 0.0)
			{
				output.WriteRawTag(9);
				output.WriteDouble(this.DataDouble);
			}
			if (this.DataFloat != 0f)
			{
				output.WriteRawTag(21);
				output.WriteFloat(this.DataFloat);
			}
			if (this.DataInt32 != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.DataInt32);
			}
			if (this.DataSInt32 != 0)
			{
				output.WriteRawTag(32);
				output.WriteSInt32(this.DataSInt32);
			}
			if (this.DataUInt32 != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.DataUInt32);
			}
			if (this.DataInt64 != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.DataInt64);
			}
			if (this.DataSInt64 != 0L)
			{
				output.WriteRawTag(56);
				output.WriteSInt64(this.DataSInt64);
			}
			if (this.DataUInt64 != 0UL)
			{
				output.WriteRawTag(64);
				output.WriteUInt64(this.DataUInt64);
			}
			if (this.DataFixed32 != 0U)
			{
				output.WriteRawTag(77);
				output.WriteFixed32(this.DataFixed32);
			}
			if (this.DataFixed64 != 0UL)
			{
				output.WriteRawTag(81);
				output.WriteFixed64(this.DataFixed64);
			}
			if (this.DataSFixed32 != 0)
			{
				output.WriteRawTag(93);
				output.WriteSFixed32(this.DataSFixed32);
			}
			if (this.DataSFixed64 != 0L)
			{
				output.WriteRawTag(97);
				output.WriteSFixed64(this.DataSFixed64);
			}
			if (this.DataBool)
			{
				output.WriteRawTag(104);
				output.WriteBool(this.DataBool);
			}
			if (this.DataString.Length != 0)
			{
				output.WriteRawTag(114);
				output.WriteString(this.DataString);
			}
			if (this.DataBytes.Length != 0)
			{
				output.WriteRawTag(122);
				output.WriteBytes(this.DataBytes);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F2AD RID: 62125 RVA: 0x00237448 File Offset: 0x00235648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DataDouble != 0.0)
			{
				num += 9;
			}
			if (this.DataFloat != 0f)
			{
				num += 5;
			}
			if (this.DataInt32 != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DataInt32);
			}
			if (this.DataSInt32 != 0)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.DataSInt32);
			}
			if (this.DataUInt32 != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DataUInt32);
			}
			if (this.DataInt64 != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.DataInt64);
			}
			if (this.DataSInt64 != 0L)
			{
				num += 1 + CodedOutputStream.ComputeSInt64Size(this.DataSInt64);
			}
			if (this.DataUInt64 != 0UL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.DataUInt64);
			}
			if (this.DataFixed32 != 0U)
			{
				num += 5;
			}
			if (this.DataFixed64 != 0UL)
			{
				num += 9;
			}
			if (this.DataSFixed32 != 0)
			{
				num += 5;
			}
			if (this.DataSFixed64 != 0L)
			{
				num += 9;
			}
			if (this.DataBool)
			{
				num += 2;
			}
			if (this.DataString.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.DataString);
			}
			if (this.DataBytes.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.DataBytes);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F2AE RID: 62126 RVA: 0x002375A0 File Offset: 0x002357A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NetTestData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DataDouble != 0.0)
			{
				this.DataDouble = other.DataDouble;
			}
			if (other.DataFloat != 0f)
			{
				this.DataFloat = other.DataFloat;
			}
			if (other.DataInt32 != 0)
			{
				this.DataInt32 = other.DataInt32;
			}
			if (other.DataSInt32 != 0)
			{
				this.DataSInt32 = other.DataSInt32;
			}
			if (other.DataUInt32 != 0U)
			{
				this.DataUInt32 = other.DataUInt32;
			}
			if (other.DataInt64 != 0L)
			{
				this.DataInt64 = other.DataInt64;
			}
			if (other.DataSInt64 != 0L)
			{
				this.DataSInt64 = other.DataSInt64;
			}
			if (other.DataUInt64 != 0UL)
			{
				this.DataUInt64 = other.DataUInt64;
			}
			if (other.DataFixed32 != 0U)
			{
				this.DataFixed32 = other.DataFixed32;
			}
			if (other.DataFixed64 != 0UL)
			{
				this.DataFixed64 = other.DataFixed64;
			}
			if (other.DataSFixed32 != 0)
			{
				this.DataSFixed32 = other.DataSFixed32;
			}
			if (other.DataSFixed64 != 0L)
			{
				this.DataSFixed64 = other.DataSFixed64;
			}
			if (other.DataBool)
			{
				this.DataBool = other.DataBool;
			}
			if (other.DataString.Length != 0)
			{
				this.DataString = other.DataString;
			}
			if (other.DataBytes.Length != 0)
			{
				this.DataBytes = other.DataBytes;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F2AF RID: 62127 RVA: 0x0023770C File Offset: 0x0023590C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F2B0 RID: 62128 RVA: 0x00237718 File Offset: 0x00235918
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
				if (num <= 56U)
				{
					if (num <= 24U)
					{
						if (num == 9U)
						{
							this.DataDouble = input.ReadDouble();
							continue;
						}
						if (num == 21U)
						{
							this.DataFloat = input.ReadFloat();
							continue;
						}
						if (num == 24U)
						{
							this.DataInt32 = input.ReadInt32();
							continue;
						}
					}
					else if (num <= 40U)
					{
						if (num == 32U)
						{
							this.DataSInt32 = input.ReadSInt32();
							continue;
						}
						if (num == 40U)
						{
							this.DataUInt32 = input.ReadUInt32();
							continue;
						}
					}
					else
					{
						if (num == 48U)
						{
							this.DataInt64 = input.ReadInt64();
							continue;
						}
						if (num == 56U)
						{
							this.DataSInt64 = input.ReadSInt64();
							continue;
						}
					}
				}
				else if (num <= 93U)
				{
					if (num <= 77U)
					{
						if (num == 64U)
						{
							this.DataUInt64 = input.ReadUInt64();
							continue;
						}
						if (num == 77U)
						{
							this.DataFixed32 = input.ReadFixed32();
							continue;
						}
					}
					else
					{
						if (num == 81U)
						{
							this.DataFixed64 = input.ReadFixed64();
							continue;
						}
						if (num == 93U)
						{
							this.DataSFixed32 = input.ReadSFixed32();
							continue;
						}
					}
				}
				else if (num <= 104U)
				{
					if (num == 97U)
					{
						this.DataSFixed64 = input.ReadSFixed64();
						continue;
					}
					if (num == 104U)
					{
						this.DataBool = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 114U)
					{
						this.DataString = input.ReadString();
						continue;
					}
					if (num == 122U)
					{
						this.DataBytes = input.ReadBytes();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006233 RID: 25139
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006234 RID: 25140
		public const int DataDoubleFieldNumber = 1;

		// Token: 0x04006235 RID: 25141
		private double dataDouble_;

		// Token: 0x04006236 RID: 25142
		public const int DataFloatFieldNumber = 2;

		// Token: 0x04006237 RID: 25143
		private float dataFloat_;

		// Token: 0x04006238 RID: 25144
		public const int DataInt32FieldNumber = 3;

		// Token: 0x04006239 RID: 25145
		private int dataInt32_;

		// Token: 0x0400623A RID: 25146
		public const int DataSInt32FieldNumber = 4;

		// Token: 0x0400623B RID: 25147
		private int dataSInt32_;

		// Token: 0x0400623C RID: 25148
		public const int DataUInt32FieldNumber = 5;

		// Token: 0x0400623D RID: 25149
		private uint dataUInt32_;

		// Token: 0x0400623E RID: 25150
		public const int DataInt64FieldNumber = 6;

		// Token: 0x0400623F RID: 25151
		private long dataInt64_;

		// Token: 0x04006240 RID: 25152
		public const int DataSInt64FieldNumber = 7;

		// Token: 0x04006241 RID: 25153
		private long dataSInt64_;

		// Token: 0x04006242 RID: 25154
		public const int DataUInt64FieldNumber = 8;

		// Token: 0x04006243 RID: 25155
		private ulong dataUInt64_;

		// Token: 0x04006244 RID: 25156
		public const int DataFixed32FieldNumber = 9;

		// Token: 0x04006245 RID: 25157
		private uint dataFixed32_;

		// Token: 0x04006246 RID: 25158
		public const int DataFixed64FieldNumber = 10;

		// Token: 0x04006247 RID: 25159
		private ulong dataFixed64_;

		// Token: 0x04006248 RID: 25160
		public const int DataSFixed32FieldNumber = 11;

		// Token: 0x04006249 RID: 25161
		private int dataSFixed32_;

		// Token: 0x0400624A RID: 25162
		public const int DataSFixed64FieldNumber = 12;

		// Token: 0x0400624B RID: 25163
		private long dataSFixed64_;

		// Token: 0x0400624C RID: 25164
		public const int DataBoolFieldNumber = 13;

		// Token: 0x0400624D RID: 25165
		private bool dataBool_;

		// Token: 0x0400624E RID: 25166
		public const int DataStringFieldNumber = 14;

		// Token: 0x0400624F RID: 25167
		private string dataString_ = "";

		// Token: 0x04006250 RID: 25168
		public const int DataBytesFieldNumber = 15;

		// Token: 0x04006251 RID: 25169
		private ByteString dataBytes_ = ByteString.Empty;
	}
}
