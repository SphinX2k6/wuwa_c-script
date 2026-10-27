using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AF2 RID: 2802
	public sealed class NetTestData : IMessage<NetTestData>, IMessage, IEquatable<NetTestData>, IDeepCloneable<NetTestData>, IBufferMessage
	{
		// Token: 0x0600F39D RID: 62365 RVA: 0x00238F38 File Offset: 0x00237138
		[NullableContext(1)]
		public static NetTestData Create()
		{
			return new NetTestData();
		}

		// Token: 0x1700319B RID: 12699
		// (get) Token: 0x0600F39E RID: 62366 RVA: 0x00238F3F File Offset: 0x0023713F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700319C RID: 12700
		// (get) Token: 0x0600F39F RID: 62367 RVA: 0x00238F42 File Offset: 0x00237142
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NetTestData.Descriptor;
			}
		}

		// Token: 0x0600F3A0 RID: 62368 RVA: 0x00238F49 File Offset: 0x00237149
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NetTestData()
		{
		}

		// Token: 0x0600F3A1 RID: 62369 RVA: 0x00238F68 File Offset: 0x00237168
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

		// Token: 0x0600F3A2 RID: 62370 RVA: 0x00239040 File Offset: 0x00237240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NetTestData Clone()
		{
			return new NetTestData(this);
		}

		// Token: 0x1700319D RID: 12701
		// (get) Token: 0x0600F3A3 RID: 62371 RVA: 0x00239048 File Offset: 0x00237248
		// (set) Token: 0x0600F3A4 RID: 62372 RVA: 0x00239050 File Offset: 0x00237250
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

		// Token: 0x1700319E RID: 12702
		// (get) Token: 0x0600F3A5 RID: 62373 RVA: 0x00239059 File Offset: 0x00237259
		// (set) Token: 0x0600F3A6 RID: 62374 RVA: 0x00239061 File Offset: 0x00237261
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

		// Token: 0x1700319F RID: 12703
		// (get) Token: 0x0600F3A7 RID: 62375 RVA: 0x0023906A File Offset: 0x0023726A
		// (set) Token: 0x0600F3A8 RID: 62376 RVA: 0x00239072 File Offset: 0x00237272
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

		// Token: 0x170031A0 RID: 12704
		// (get) Token: 0x0600F3A9 RID: 62377 RVA: 0x0023907B File Offset: 0x0023727B
		// (set) Token: 0x0600F3AA RID: 62378 RVA: 0x00239083 File Offset: 0x00237283
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

		// Token: 0x170031A1 RID: 12705
		// (get) Token: 0x0600F3AB RID: 62379 RVA: 0x0023908C File Offset: 0x0023728C
		// (set) Token: 0x0600F3AC RID: 62380 RVA: 0x00239094 File Offset: 0x00237294
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

		// Token: 0x170031A2 RID: 12706
		// (get) Token: 0x0600F3AD RID: 62381 RVA: 0x0023909D File Offset: 0x0023729D
		// (set) Token: 0x0600F3AE RID: 62382 RVA: 0x002390A5 File Offset: 0x002372A5
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

		// Token: 0x170031A3 RID: 12707
		// (get) Token: 0x0600F3AF RID: 62383 RVA: 0x002390AE File Offset: 0x002372AE
		// (set) Token: 0x0600F3B0 RID: 62384 RVA: 0x002390B6 File Offset: 0x002372B6
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

		// Token: 0x170031A4 RID: 12708
		// (get) Token: 0x0600F3B1 RID: 62385 RVA: 0x002390BF File Offset: 0x002372BF
		// (set) Token: 0x0600F3B2 RID: 62386 RVA: 0x002390C7 File Offset: 0x002372C7
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

		// Token: 0x170031A5 RID: 12709
		// (get) Token: 0x0600F3B3 RID: 62387 RVA: 0x002390D0 File Offset: 0x002372D0
		// (set) Token: 0x0600F3B4 RID: 62388 RVA: 0x002390D8 File Offset: 0x002372D8
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

		// Token: 0x170031A6 RID: 12710
		// (get) Token: 0x0600F3B5 RID: 62389 RVA: 0x002390E1 File Offset: 0x002372E1
		// (set) Token: 0x0600F3B6 RID: 62390 RVA: 0x002390E9 File Offset: 0x002372E9
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

		// Token: 0x170031A7 RID: 12711
		// (get) Token: 0x0600F3B7 RID: 62391 RVA: 0x002390F2 File Offset: 0x002372F2
		// (set) Token: 0x0600F3B8 RID: 62392 RVA: 0x002390FA File Offset: 0x002372FA
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

		// Token: 0x170031A8 RID: 12712
		// (get) Token: 0x0600F3B9 RID: 62393 RVA: 0x00239103 File Offset: 0x00237303
		// (set) Token: 0x0600F3BA RID: 62394 RVA: 0x0023910B File Offset: 0x0023730B
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

		// Token: 0x170031A9 RID: 12713
		// (get) Token: 0x0600F3BB RID: 62395 RVA: 0x00239114 File Offset: 0x00237314
		// (set) Token: 0x0600F3BC RID: 62396 RVA: 0x0023911C File Offset: 0x0023731C
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

		// Token: 0x170031AA RID: 12714
		// (get) Token: 0x0600F3BD RID: 62397 RVA: 0x00239125 File Offset: 0x00237325
		// (set) Token: 0x0600F3BE RID: 62398 RVA: 0x0023912D File Offset: 0x0023732D
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

		// Token: 0x170031AB RID: 12715
		// (get) Token: 0x0600F3BF RID: 62399 RVA: 0x00239140 File Offset: 0x00237340
		// (set) Token: 0x0600F3C0 RID: 62400 RVA: 0x00239148 File Offset: 0x00237348
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

		// Token: 0x0600F3C1 RID: 62401 RVA: 0x0023915B File Offset: 0x0023735B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NetTestData);
		}

		// Token: 0x0600F3C2 RID: 62402 RVA: 0x0023916C File Offset: 0x0023736C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NetTestData other)
		{
			return other != null && (other == this || (ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.DataDouble, other.DataDouble) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.DataFloat, other.DataFloat) && this.DataInt32 == other.DataInt32 && this.DataSInt32 == other.DataSInt32 && this.DataUInt32 == other.DataUInt32 && this.DataInt64 == other.DataInt64 && this.DataSInt64 == other.DataSInt64 && this.DataUInt64 == other.DataUInt64 && this.DataFixed32 == other.DataFixed32 && this.DataFixed64 == other.DataFixed64 && this.DataSFixed32 == other.DataSFixed32 && this.DataSFixed64 == other.DataSFixed64 && this.DataBool == other.DataBool && !(this.DataString != other.DataString) && !(this.DataBytes != other.DataBytes) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F3C3 RID: 62403 RVA: 0x002392A4 File Offset: 0x002374A4
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

		// Token: 0x0600F3C4 RID: 62404 RVA: 0x0023945A File Offset: 0x0023765A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F3C5 RID: 62405 RVA: 0x00239467 File Offset: 0x00237667
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F3C6 RID: 62406 RVA: 0x00239470 File Offset: 0x00237670
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

		// Token: 0x0600F3C7 RID: 62407 RVA: 0x00239650 File Offset: 0x00237850
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

		// Token: 0x0600F3C8 RID: 62408 RVA: 0x002397A8 File Offset: 0x002379A8
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

		// Token: 0x0600F3C9 RID: 62409 RVA: 0x00239914 File Offset: 0x00237B14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F3CA RID: 62410 RVA: 0x00239920 File Offset: 0x00237B20
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

		// Token: 0x0400622A RID: 25130
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400622B RID: 25131
		public const int DataDoubleFieldNumber = 1;

		// Token: 0x0400622C RID: 25132
		private double dataDouble_;

		// Token: 0x0400622D RID: 25133
		public const int DataFloatFieldNumber = 2;

		// Token: 0x0400622E RID: 25134
		private float dataFloat_;

		// Token: 0x0400622F RID: 25135
		public const int DataInt32FieldNumber = 3;

		// Token: 0x04006230 RID: 25136
		private int dataInt32_;

		// Token: 0x04006231 RID: 25137
		public const int DataSInt32FieldNumber = 4;

		// Token: 0x04006232 RID: 25138
		private int dataSInt32_;

		// Token: 0x04006233 RID: 25139
		public const int DataUInt32FieldNumber = 5;

		// Token: 0x04006234 RID: 25140
		private uint dataUInt32_;

		// Token: 0x04006235 RID: 25141
		public const int DataInt64FieldNumber = 6;

		// Token: 0x04006236 RID: 25142
		private long dataInt64_;

		// Token: 0x04006237 RID: 25143
		public const int DataSInt64FieldNumber = 7;

		// Token: 0x04006238 RID: 25144
		private long dataSInt64_;

		// Token: 0x04006239 RID: 25145
		public const int DataUInt64FieldNumber = 8;

		// Token: 0x0400623A RID: 25146
		private ulong dataUInt64_;

		// Token: 0x0400623B RID: 25147
		public const int DataFixed32FieldNumber = 9;

		// Token: 0x0400623C RID: 25148
		private uint dataFixed32_;

		// Token: 0x0400623D RID: 25149
		public const int DataFixed64FieldNumber = 10;

		// Token: 0x0400623E RID: 25150
		private ulong dataFixed64_;

		// Token: 0x0400623F RID: 25151
		public const int DataSFixed32FieldNumber = 11;

		// Token: 0x04006240 RID: 25152
		private int dataSFixed32_;

		// Token: 0x04006241 RID: 25153
		public const int DataSFixed64FieldNumber = 12;

		// Token: 0x04006242 RID: 25154
		private long dataSFixed64_;

		// Token: 0x04006243 RID: 25155
		public const int DataBoolFieldNumber = 13;

		// Token: 0x04006244 RID: 25156
		private bool dataBool_;

		// Token: 0x04006245 RID: 25157
		public const int DataStringFieldNumber = 14;

		// Token: 0x04006246 RID: 25158
		private string dataString_ = "";

		// Token: 0x04006247 RID: 25159
		public const int DataBytesFieldNumber = 15;

		// Token: 0x04006248 RID: 25160
		private ByteString dataBytes_ = ByteString.Empty;
	}
}
