using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E7E RID: 3710
	public sealed class RacingBetsTransmitData : IMessage<RacingBetsTransmitData>, IMessage, IEquatable<RacingBetsTransmitData>, IDeepCloneable<RacingBetsTransmitData>, IBufferMessage
	{
		// Token: 0x06013EC7 RID: 81607 RVA: 0x002E6867 File Offset: 0x002E4A67
		[NullableContext(1)]
		public static RacingBetsTransmitData Create()
		{
			return new RacingBetsTransmitData();
		}

		// Token: 0x1700423F RID: 16959
		// (get) Token: 0x06013EC8 RID: 81608 RVA: 0x002E686E File Offset: 0x002E4A6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RacingBetsTransmitData> Parser
		{
			get
			{
				return RacingBetsTransmitData._parser;
			}
		}

		// Token: 0x17004240 RID: 16960
		// (get) Token: 0x06013EC9 RID: 81609 RVA: 0x002E6875 File Offset: 0x002E4A75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004241 RID: 16961
		// (get) Token: 0x06013ECA RID: 81610 RVA: 0x002E6878 File Offset: 0x002E4A78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsTransmitData.Descriptor;
			}
		}

		// Token: 0x06013ECB RID: 81611 RVA: 0x002E687F File Offset: 0x002E4A7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsTransmitData()
		{
		}

		// Token: 0x06013ECC RID: 81612 RVA: 0x002E6887 File Offset: 0x002E4A87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsTransmitData(RacingBetsTransmitData other) : this()
		{
			this.dangoId_ = other.dangoId_;
			this.point_ = other.point_;
			this.high_ = other.high_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013ECD RID: 81613 RVA: 0x002E68C4 File Offset: 0x002E4AC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsTransmitData Clone()
		{
			return new RacingBetsTransmitData(this);
		}

		// Token: 0x17004242 RID: 16962
		// (get) Token: 0x06013ECE RID: 81614 RVA: 0x002E68CC File Offset: 0x002E4ACC
		// (set) Token: 0x06013ECF RID: 81615 RVA: 0x002E68D4 File Offset: 0x002E4AD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DangoId
		{
			get
			{
				return this.dangoId_;
			}
			set
			{
				this.dangoId_ = value;
			}
		}

		// Token: 0x17004243 RID: 16963
		// (get) Token: 0x06013ED0 RID: 81616 RVA: 0x002E68DD File Offset: 0x002E4ADD
		// (set) Token: 0x06013ED1 RID: 81617 RVA: 0x002E68E5 File Offset: 0x002E4AE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Point
		{
			get
			{
				return this.point_;
			}
			set
			{
				this.point_ = value;
			}
		}

		// Token: 0x17004244 RID: 16964
		// (get) Token: 0x06013ED2 RID: 81618 RVA: 0x002E68EE File Offset: 0x002E4AEE
		// (set) Token: 0x06013ED3 RID: 81619 RVA: 0x002E68F6 File Offset: 0x002E4AF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int High
		{
			get
			{
				return this.high_;
			}
			set
			{
				this.high_ = value;
			}
		}

		// Token: 0x06013ED4 RID: 81620 RVA: 0x002E68FF File Offset: 0x002E4AFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsTransmitData);
		}

		// Token: 0x06013ED5 RID: 81621 RVA: 0x002E6910 File Offset: 0x002E4B10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsTransmitData other)
		{
			return other != null && (other == this || (this.DangoId == other.DangoId && this.Point == other.Point && this.High == other.High && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013ED6 RID: 81622 RVA: 0x002E696C File Offset: 0x002E4B6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DangoId != 0)
			{
				num ^= this.DangoId.GetHashCode();
			}
			if (this.Point != 0)
			{
				num ^= this.Point.GetHashCode();
			}
			if (this.High != 0)
			{
				num ^= this.High.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013ED7 RID: 81623 RVA: 0x002E69DD File Offset: 0x002E4BDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013ED8 RID: 81624 RVA: 0x002E69EA File Offset: 0x002E4BEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013ED9 RID: 81625 RVA: 0x002E69F4 File Offset: 0x002E4BF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DangoId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.DangoId);
			}
			if (this.Point != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Point);
			}
			if (this.High != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.High);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013EDA RID: 81626 RVA: 0x002E6A68 File Offset: 0x002E4C68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DangoId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DangoId);
			}
			if (this.Point != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Point);
			}
			if (this.High != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.High);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013EDB RID: 81627 RVA: 0x002E6AD8 File Offset: 0x002E4CD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsTransmitData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DangoId != 0)
			{
				this.DangoId = other.DangoId;
			}
			if (other.Point != 0)
			{
				this.Point = other.Point;
			}
			if (other.High != 0)
			{
				this.High = other.High;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013EDC RID: 81628 RVA: 0x002E6B3C File Offset: 0x002E4D3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013EDD RID: 81629 RVA: 0x002E6B48 File Offset: 0x002E4D48
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
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.High = input.ReadInt32();
						}
					}
					else
					{
						this.Point = input.ReadInt32();
					}
				}
				else
				{
					this.DangoId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040079BB RID: 31163
		private static readonly MessageParser<RacingBetsTransmitData> _parser = new MessageParser<RacingBetsTransmitData>(() => new RacingBetsTransmitData());

		// Token: 0x040079BC RID: 31164
		private UnknownFieldSet _unknownFields;

		// Token: 0x040079BD RID: 31165
		public const int DangoIdFieldNumber = 1;

		// Token: 0x040079BE RID: 31166
		private int dangoId_;

		// Token: 0x040079BF RID: 31167
		public const int PointFieldNumber = 2;

		// Token: 0x040079C0 RID: 31168
		private int point_;

		// Token: 0x040079C1 RID: 31169
		public const int HighFieldNumber = 3;

		// Token: 0x040079C2 RID: 31170
		private int high_;
	}
}
