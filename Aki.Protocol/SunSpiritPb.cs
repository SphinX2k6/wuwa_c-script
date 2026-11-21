using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200132A RID: 4906
	public sealed class SunSpiritPb : IMessage<SunSpiritPb>, IMessage, IEquatable<SunSpiritPb>, IDeepCloneable<SunSpiritPb>, IBufferMessage
	{
		// Token: 0x0601A26E RID: 107118 RVA: 0x003CFA61 File Offset: 0x003CDC61
		[NullableContext(1)]
		public static SunSpiritPb Create()
		{
			return new SunSpiritPb();
		}

		// Token: 0x1700588A RID: 22666
		// (get) Token: 0x0601A26F RID: 107119 RVA: 0x003CFA68 File Offset: 0x003CDC68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SunSpiritPb> Parser
		{
			get
			{
				return SunSpiritPb._parser;
			}
		}

		// Token: 0x1700588B RID: 22667
		// (get) Token: 0x0601A270 RID: 107120 RVA: 0x003CFA6F File Offset: 0x003CDC6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700588C RID: 22668
		// (get) Token: 0x0601A271 RID: 107121 RVA: 0x003CFA72 File Offset: 0x003CDC72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SunSpiritPb.Descriptor;
			}
		}

		// Token: 0x0601A272 RID: 107122 RVA: 0x003CFA79 File Offset: 0x003CDC79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SunSpiritPb()
		{
		}

		// Token: 0x0601A273 RID: 107123 RVA: 0x003CFA84 File Offset: 0x003CDC84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SunSpiritPb(SunSpiritPb other) : this()
		{
			this.instId_ = other.instId_;
			this.entityConfigId_ = other.entityConfigId_;
			this.takeUpData_ = ((other.takeUpData_ != null) ? other.takeUpData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A274 RID: 107124 RVA: 0x003CFADC File Offset: 0x003CDCDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SunSpiritPb Clone()
		{
			return new SunSpiritPb(this);
		}

		// Token: 0x1700588D RID: 22669
		// (get) Token: 0x0601A275 RID: 107125 RVA: 0x003CFAE4 File Offset: 0x003CDCE4
		// (set) Token: 0x0601A276 RID: 107126 RVA: 0x003CFAEC File Offset: 0x003CDCEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstId
		{
			get
			{
				return this.instId_;
			}
			set
			{
				this.instId_ = value;
			}
		}

		// Token: 0x1700588E RID: 22670
		// (get) Token: 0x0601A277 RID: 107127 RVA: 0x003CFAF5 File Offset: 0x003CDCF5
		// (set) Token: 0x0601A278 RID: 107128 RVA: 0x003CFAFD File Offset: 0x003CDCFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EntityConfigId
		{
			get
			{
				return this.entityConfigId_;
			}
			set
			{
				this.entityConfigId_ = value;
			}
		}

		// Token: 0x1700588F RID: 22671
		// (get) Token: 0x0601A279 RID: 107129 RVA: 0x003CFB06 File Offset: 0x003CDD06
		// (set) Token: 0x0601A27A RID: 107130 RVA: 0x003CFB0E File Offset: 0x003CDD0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SunSpiritTakeUpPb TakeUpData
		{
			get
			{
				return this.takeUpData_;
			}
			set
			{
				this.takeUpData_ = value;
			}
		}

		// Token: 0x0601A27B RID: 107131 RVA: 0x003CFB17 File Offset: 0x003CDD17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SunSpiritPb);
		}

		// Token: 0x0601A27C RID: 107132 RVA: 0x003CFB28 File Offset: 0x003CDD28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SunSpiritPb other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.EntityConfigId == other.EntityConfigId && object.Equals(this.TakeUpData, other.TakeUpData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A27D RID: 107133 RVA: 0x003CFB88 File Offset: 0x003CDD88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			if (this.EntityConfigId != 0)
			{
				num ^= this.EntityConfigId.GetHashCode();
			}
			if (this.takeUpData_ != null)
			{
				num ^= this.TakeUpData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A27E RID: 107134 RVA: 0x003CFBF6 File Offset: 0x003CDDF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A27F RID: 107135 RVA: 0x003CFC03 File Offset: 0x003CDE03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A280 RID: 107136 RVA: 0x003CFC0C File Offset: 0x003CDE0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InstId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.InstId);
			}
			if (this.EntityConfigId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.EntityConfigId);
			}
			if (this.takeUpData_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.TakeUpData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A281 RID: 107137 RVA: 0x003CFC80 File Offset: 0x003CDE80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			if (this.EntityConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EntityConfigId);
			}
			if (this.takeUpData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TakeUpData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A282 RID: 107138 RVA: 0x003CFCF0 File Offset: 0x003CDEF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SunSpiritPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			if (other.EntityConfigId != 0)
			{
				this.EntityConfigId = other.EntityConfigId;
			}
			if (other.takeUpData_ != null)
			{
				if (this.takeUpData_ == null)
				{
					this.TakeUpData = new SunSpiritTakeUpPb();
				}
				this.TakeUpData.MergeFrom(other.TakeUpData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A283 RID: 107139 RVA: 0x003CFD6C File Offset: 0x003CDF6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A284 RID: 107140 RVA: 0x003CFD78 File Offset: 0x003CDF78
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
						if (num != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.takeUpData_ == null)
							{
								this.TakeUpData = new SunSpiritTakeUpPb();
							}
							input.ReadMessage(this.TakeUpData);
						}
					}
					else
					{
						this.EntityConfigId = input.ReadInt32();
					}
				}
				else
				{
					this.InstId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040099D5 RID: 39381
		private static readonly MessageParser<SunSpiritPb> _parser = new MessageParser<SunSpiritPb>(() => new SunSpiritPb());

		// Token: 0x040099D6 RID: 39382
		private UnknownFieldSet _unknownFields;

		// Token: 0x040099D7 RID: 39383
		public const int InstIdFieldNumber = 1;

		// Token: 0x040099D8 RID: 39384
		private int instId_;

		// Token: 0x040099D9 RID: 39385
		public const int EntityConfigIdFieldNumber = 2;

		// Token: 0x040099DA RID: 39386
		private int entityConfigId_;

		// Token: 0x040099DB RID: 39387
		public const int TakeUpDataFieldNumber = 3;

		// Token: 0x040099DC RID: 39388
		private SunSpiritTakeUpPb takeUpData_;
	}
}
