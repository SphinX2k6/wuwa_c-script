using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014A0 RID: 5280
	public sealed class TrapDefenseItemPbData : IMessage<TrapDefenseItemPbData>, IMessage, IEquatable<TrapDefenseItemPbData>, IDeepCloneable<TrapDefenseItemPbData>, IBufferMessage
	{
		// Token: 0x0601C066 RID: 114790 RVA: 0x00411D50 File Offset: 0x0040FF50
		[NullableContext(1)]
		public static TrapDefenseItemPbData Create()
		{
			return new TrapDefenseItemPbData();
		}

		// Token: 0x17005EDD RID: 24285
		// (get) Token: 0x0601C067 RID: 114791 RVA: 0x00411D57 File Offset: 0x0040FF57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TrapDefenseItemPbData> Parser
		{
			get
			{
				return TrapDefenseItemPbData._parser;
			}
		}

		// Token: 0x17005EDE RID: 24286
		// (get) Token: 0x0601C068 RID: 114792 RVA: 0x00411D5E File Offset: 0x0040FF5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005EDF RID: 24287
		// (get) Token: 0x0601C069 RID: 114793 RVA: 0x00411D61 File Offset: 0x0040FF61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseItemPbData.Descriptor;
			}
		}

		// Token: 0x0601C06A RID: 114794 RVA: 0x00411D68 File Offset: 0x0040FF68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseItemPbData()
		{
		}

		// Token: 0x0601C06B RID: 114795 RVA: 0x00411D70 File Offset: 0x0040FF70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseItemPbData(TrapDefenseItemPbData other) : this()
		{
			this.configId_ = other.configId_;
			this.carryCount_ = other.carryCount_;
			this.carryLimit_ = other.carryLimit_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C06C RID: 114796 RVA: 0x00411DAD File Offset: 0x0040FFAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseItemPbData Clone()
		{
			return new TrapDefenseItemPbData(this);
		}

		// Token: 0x17005EE0 RID: 24288
		// (get) Token: 0x0601C06D RID: 114797 RVA: 0x00411DB5 File Offset: 0x0040FFB5
		// (set) Token: 0x0601C06E RID: 114798 RVA: 0x00411DBD File Offset: 0x0040FFBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConfigId
		{
			get
			{
				return this.configId_;
			}
			set
			{
				this.configId_ = value;
			}
		}

		// Token: 0x17005EE1 RID: 24289
		// (get) Token: 0x0601C06F RID: 114799 RVA: 0x00411DC6 File Offset: 0x0040FFC6
		// (set) Token: 0x0601C070 RID: 114800 RVA: 0x00411DCE File Offset: 0x0040FFCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CarryCount
		{
			get
			{
				return this.carryCount_;
			}
			set
			{
				this.carryCount_ = value;
			}
		}

		// Token: 0x17005EE2 RID: 24290
		// (get) Token: 0x0601C071 RID: 114801 RVA: 0x00411DD7 File Offset: 0x0040FFD7
		// (set) Token: 0x0601C072 RID: 114802 RVA: 0x00411DDF File Offset: 0x0040FFDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CarryLimit
		{
			get
			{
				return this.carryLimit_;
			}
			set
			{
				this.carryLimit_ = value;
			}
		}

		// Token: 0x0601C073 RID: 114803 RVA: 0x00411DE8 File Offset: 0x0040FFE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseItemPbData);
		}

		// Token: 0x0601C074 RID: 114804 RVA: 0x00411DF8 File Offset: 0x0040FFF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseItemPbData other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && this.CarryCount == other.CarryCount && this.CarryLimit == other.CarryLimit && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C075 RID: 114805 RVA: 0x00411E54 File Offset: 0x00410054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ConfigId != 0)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this.CarryCount != 0)
			{
				num ^= this.CarryCount.GetHashCode();
			}
			if (this.CarryLimit != 0)
			{
				num ^= this.CarryLimit.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C076 RID: 114806 RVA: 0x00411EC5 File Offset: 0x004100C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C077 RID: 114807 RVA: 0x00411ED2 File Offset: 0x004100D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C078 RID: 114808 RVA: 0x00411EDC File Offset: 0x004100DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ConfigId);
			}
			if (this.CarryCount != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CarryCount);
			}
			if (this.CarryLimit != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.CarryLimit);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C079 RID: 114809 RVA: 0x00411F50 File Offset: 0x00410150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfigId);
			}
			if (this.CarryCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CarryCount);
			}
			if (this.CarryLimit != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CarryLimit);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C07A RID: 114810 RVA: 0x00411FC0 File Offset: 0x004101C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseItemPbData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ConfigId != 0)
			{
				this.ConfigId = other.ConfigId;
			}
			if (other.CarryCount != 0)
			{
				this.CarryCount = other.CarryCount;
			}
			if (other.CarryLimit != 0)
			{
				this.CarryLimit = other.CarryLimit;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C07B RID: 114811 RVA: 0x00412024 File Offset: 0x00410224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C07C RID: 114812 RVA: 0x00412030 File Offset: 0x00410230
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
							this.CarryLimit = input.ReadInt32();
						}
					}
					else
					{
						this.CarryCount = input.ReadInt32();
					}
				}
				else
				{
					this.ConfigId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A24E RID: 41550
		private static readonly MessageParser<TrapDefenseItemPbData> _parser = new MessageParser<TrapDefenseItemPbData>(() => new TrapDefenseItemPbData());

		// Token: 0x0400A24F RID: 41551
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A250 RID: 41552
		public const int ConfigIdFieldNumber = 1;

		// Token: 0x0400A251 RID: 41553
		private int configId_;

		// Token: 0x0400A252 RID: 41554
		public const int CarryCountFieldNumber = 2;

		// Token: 0x0400A253 RID: 41555
		private int carryCount_;

		// Token: 0x0400A254 RID: 41556
		public const int CarryLimitFieldNumber = 3;

		// Token: 0x0400A255 RID: 41557
		private int carryLimit_;
	}
}
