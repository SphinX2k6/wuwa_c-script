using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012AD RID: 4781
	public sealed class SolarSchoolIdCountPb : IMessage<SolarSchoolIdCountPb>, IMessage, IEquatable<SolarSchoolIdCountPb>, IDeepCloneable<SolarSchoolIdCountPb>, IBufferMessage
	{
		// Token: 0x06019855 RID: 104533 RVA: 0x003B90FF File Offset: 0x003B72FF
		[NullableContext(1)]
		public static SolarSchoolIdCountPb Create()
		{
			return new SolarSchoolIdCountPb();
		}

		// Token: 0x1700565F RID: 22111
		// (get) Token: 0x06019856 RID: 104534 RVA: 0x003B9106 File Offset: 0x003B7306
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SolarSchoolIdCountPb> Parser
		{
			get
			{
				return SolarSchoolIdCountPb._parser;
			}
		}

		// Token: 0x17005660 RID: 22112
		// (get) Token: 0x06019857 RID: 104535 RVA: 0x003B910D File Offset: 0x003B730D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005661 RID: 22113
		// (get) Token: 0x06019858 RID: 104536 RVA: 0x003B9110 File Offset: 0x003B7310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SolarSchoolIdCountPb.Descriptor;
			}
		}

		// Token: 0x06019859 RID: 104537 RVA: 0x003B9117 File Offset: 0x003B7317
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolIdCountPb()
		{
		}

		// Token: 0x0601985A RID: 104538 RVA: 0x003B911F File Offset: 0x003B731F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolIdCountPb(SolarSchoolIdCountPb other) : this()
		{
			this.id_ = other.id_;
			this.count_ = other.count_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601985B RID: 104539 RVA: 0x003B9150 File Offset: 0x003B7350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolIdCountPb Clone()
		{
			return new SolarSchoolIdCountPb(this);
		}

		// Token: 0x17005662 RID: 22114
		// (get) Token: 0x0601985C RID: 104540 RVA: 0x003B9158 File Offset: 0x003B7358
		// (set) Token: 0x0601985D RID: 104541 RVA: 0x003B9160 File Offset: 0x003B7360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17005663 RID: 22115
		// (get) Token: 0x0601985E RID: 104542 RVA: 0x003B9169 File Offset: 0x003B7369
		// (set) Token: 0x0601985F RID: 104543 RVA: 0x003B9171 File Offset: 0x003B7371
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

		// Token: 0x06019860 RID: 104544 RVA: 0x003B917A File Offset: 0x003B737A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SolarSchoolIdCountPb);
		}

		// Token: 0x06019861 RID: 104545 RVA: 0x003B9188 File Offset: 0x003B7388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SolarSchoolIdCountPb other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Count == other.Count && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019862 RID: 104546 RVA: 0x003B91C8 File Offset: 0x003B73C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
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

		// Token: 0x06019863 RID: 104547 RVA: 0x003B9220 File Offset: 0x003B7420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019864 RID: 104548 RVA: 0x003B922D File Offset: 0x003B742D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019865 RID: 104549 RVA: 0x003B9238 File Offset: 0x003B7438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
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

		// Token: 0x06019866 RID: 104550 RVA: 0x003B9290 File Offset: 0x003B7490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
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

		// Token: 0x06019867 RID: 104551 RVA: 0x003B92E8 File Offset: 0x003B74E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SolarSchoolIdCountPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Count != 0)
			{
				this.Count = other.Count;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019868 RID: 104552 RVA: 0x003B9338 File Offset: 0x003B7538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019869 RID: 104553 RVA: 0x003B9344 File Offset: 0x003B7544
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
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x040096D1 RID: 38609
		private static readonly MessageParser<SolarSchoolIdCountPb> _parser = new MessageParser<SolarSchoolIdCountPb>(() => new SolarSchoolIdCountPb());

		// Token: 0x040096D2 RID: 38610
		private UnknownFieldSet _unknownFields;

		// Token: 0x040096D3 RID: 38611
		public const int IdFieldNumber = 1;

		// Token: 0x040096D4 RID: 38612
		private int id_;

		// Token: 0x040096D5 RID: 38613
		public const int CountFieldNumber = 2;

		// Token: 0x040096D6 RID: 38614
		private int count_;
	}
}
