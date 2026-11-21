using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200132B RID: 4907
	public sealed class SunSpiritTakeUpPb : IMessage<SunSpiritTakeUpPb>, IMessage, IEquatable<SunSpiritTakeUpPb>, IDeepCloneable<SunSpiritTakeUpPb>, IBufferMessage
	{
		// Token: 0x0601A286 RID: 107142 RVA: 0x003CFE11 File Offset: 0x003CE011
		[NullableContext(1)]
		public static SunSpiritTakeUpPb Create()
		{
			return new SunSpiritTakeUpPb();
		}

		// Token: 0x17005890 RID: 22672
		// (get) Token: 0x0601A287 RID: 107143 RVA: 0x003CFE18 File Offset: 0x003CE018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005891 RID: 22673
		// (get) Token: 0x0601A288 RID: 107144 RVA: 0x003CFE1B File Offset: 0x003CE01B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SunSpiritTakeUpPb.Descriptor;
			}
		}

		// Token: 0x0601A289 RID: 107145 RVA: 0x003CFE22 File Offset: 0x003CE022
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SunSpiritTakeUpPb()
		{
		}

		// Token: 0x0601A28A RID: 107146 RVA: 0x003CFE2A File Offset: 0x003CE02A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SunSpiritTakeUpPb(SunSpiritTakeUpPb other) : this()
		{
			this.trapEntityConfigId_ = other.trapEntityConfigId_;
			this.index_ = other.index_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A28B RID: 107147 RVA: 0x003CFE5B File Offset: 0x003CE05B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SunSpiritTakeUpPb Clone()
		{
			return new SunSpiritTakeUpPb(this);
		}

		// Token: 0x17005892 RID: 22674
		// (get) Token: 0x0601A28C RID: 107148 RVA: 0x003CFE63 File Offset: 0x003CE063
		// (set) Token: 0x0601A28D RID: 107149 RVA: 0x003CFE6B File Offset: 0x003CE06B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TrapEntityConfigId
		{
			get
			{
				return this.trapEntityConfigId_;
			}
			set
			{
				this.trapEntityConfigId_ = value;
			}
		}

		// Token: 0x17005893 RID: 22675
		// (get) Token: 0x0601A28E RID: 107150 RVA: 0x003CFE74 File Offset: 0x003CE074
		// (set) Token: 0x0601A28F RID: 107151 RVA: 0x003CFE7C File Offset: 0x003CE07C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x0601A290 RID: 107152 RVA: 0x003CFE85 File Offset: 0x003CE085
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SunSpiritTakeUpPb);
		}

		// Token: 0x0601A291 RID: 107153 RVA: 0x003CFE93 File Offset: 0x003CE093
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SunSpiritTakeUpPb other)
		{
			return other != null && (other == this || (this.TrapEntityConfigId == other.TrapEntityConfigId && this.Index == other.Index && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A292 RID: 107154 RVA: 0x003CFED4 File Offset: 0x003CE0D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TrapEntityConfigId != 0)
			{
				num ^= this.TrapEntityConfigId.GetHashCode();
			}
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A293 RID: 107155 RVA: 0x003CFF2C File Offset: 0x003CE12C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A294 RID: 107156 RVA: 0x003CFF39 File Offset: 0x003CE139
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A295 RID: 107157 RVA: 0x003CFF44 File Offset: 0x003CE144
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TrapEntityConfigId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TrapEntityConfigId);
			}
			if (this.Index != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Index);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A296 RID: 107158 RVA: 0x003CFF9C File Offset: 0x003CE19C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TrapEntityConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TrapEntityConfigId);
			}
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A297 RID: 107159 RVA: 0x003CFFF4 File Offset: 0x003CE1F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SunSpiritTakeUpPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TrapEntityConfigId != 0)
			{
				this.TrapEntityConfigId = other.TrapEntityConfigId;
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A298 RID: 107160 RVA: 0x003D0044 File Offset: 0x003CE244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A299 RID: 107161 RVA: 0x003D0050 File Offset: 0x003CE250
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
						this.Index = input.ReadInt32();
					}
				}
				else
				{
					this.TrapEntityConfigId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040099DD RID: 39389
		private UnknownFieldSet _unknownFields;

		// Token: 0x040099DE RID: 39390
		public const int TrapEntityConfigIdFieldNumber = 1;

		// Token: 0x040099DF RID: 39391
		private int trapEntityConfigId_;

		// Token: 0x040099E0 RID: 39392
		public const int IndexFieldNumber = 2;

		// Token: 0x040099E1 RID: 39393
		private int index_;
	}
}
