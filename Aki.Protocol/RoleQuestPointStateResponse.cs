using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001094 RID: 4244
	[NetMessage(EMessageId.RoleQuestPointStateResponse)]
	public sealed class RoleQuestPointStateResponse : IMessage<RoleQuestPointStateResponse>, IMessage, IEquatable<RoleQuestPointStateResponse>, IDeepCloneable<RoleQuestPointStateResponse>, IBufferMessage
	{
		// Token: 0x06016B15 RID: 92949 RVA: 0x0034CCB6 File Offset: 0x0034AEB6
		[NullableContext(1)]
		public static RoleQuestPointStateResponse Create()
		{
			return new RoleQuestPointStateResponse();
		}

		// Token: 0x17004C0C RID: 19468
		// (get) Token: 0x06016B16 RID: 92950 RVA: 0x0034CCBD File Offset: 0x0034AEBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004C0D RID: 19469
		// (get) Token: 0x06016B17 RID: 92951 RVA: 0x0034CCC0 File Offset: 0x0034AEC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleQuestPointStateResponse.Descriptor;
			}
		}

		// Token: 0x06016B18 RID: 92952 RVA: 0x0034CCC7 File Offset: 0x0034AEC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleQuestPointStateResponse()
		{
		}

		// Token: 0x06016B19 RID: 92953 RVA: 0x0034CCCF File Offset: 0x0034AECF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleQuestPointStateResponse(RoleQuestPointStateResponse other) : this()
		{
			this.currPoint_ = other.currPoint_;
			this.maxPoint_ = other.maxPoint_;
			this.lastAddPointTime_ = other.lastAddPointTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016B1A RID: 92954 RVA: 0x0034CD0C File Offset: 0x0034AF0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleQuestPointStateResponse Clone()
		{
			return new RoleQuestPointStateResponse(this);
		}

		// Token: 0x17004C0E RID: 19470
		// (get) Token: 0x06016B1B RID: 92955 RVA: 0x0034CD14 File Offset: 0x0034AF14
		// (set) Token: 0x06016B1C RID: 92956 RVA: 0x0034CD1C File Offset: 0x0034AF1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurrPoint
		{
			get
			{
				return this.currPoint_;
			}
			set
			{
				this.currPoint_ = value;
			}
		}

		// Token: 0x17004C0F RID: 19471
		// (get) Token: 0x06016B1D RID: 92957 RVA: 0x0034CD25 File Offset: 0x0034AF25
		// (set) Token: 0x06016B1E RID: 92958 RVA: 0x0034CD2D File Offset: 0x0034AF2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxPoint
		{
			get
			{
				return this.maxPoint_;
			}
			set
			{
				this.maxPoint_ = value;
			}
		}

		// Token: 0x17004C10 RID: 19472
		// (get) Token: 0x06016B1F RID: 92959 RVA: 0x0034CD36 File Offset: 0x0034AF36
		// (set) Token: 0x06016B20 RID: 92960 RVA: 0x0034CD3E File Offset: 0x0034AF3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long LastAddPointTime
		{
			get
			{
				return this.lastAddPointTime_;
			}
			set
			{
				this.lastAddPointTime_ = value;
			}
		}

		// Token: 0x06016B21 RID: 92961 RVA: 0x0034CD47 File Offset: 0x0034AF47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleQuestPointStateResponse);
		}

		// Token: 0x06016B22 RID: 92962 RVA: 0x0034CD58 File Offset: 0x0034AF58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleQuestPointStateResponse other)
		{
			return other != null && (other == this || (this.CurrPoint == other.CurrPoint && this.MaxPoint == other.MaxPoint && this.LastAddPointTime == other.LastAddPointTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016B23 RID: 92963 RVA: 0x0034CDB4 File Offset: 0x0034AFB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CurrPoint != 0)
			{
				num ^= this.CurrPoint.GetHashCode();
			}
			if (this.MaxPoint != 0)
			{
				num ^= this.MaxPoint.GetHashCode();
			}
			if (this.LastAddPointTime != 0L)
			{
				num ^= this.LastAddPointTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016B24 RID: 92964 RVA: 0x0034CE25 File Offset: 0x0034B025
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016B25 RID: 92965 RVA: 0x0034CE32 File Offset: 0x0034B032
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016B26 RID: 92966 RVA: 0x0034CE3C File Offset: 0x0034B03C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurrPoint != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.CurrPoint);
			}
			if (this.MaxPoint != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.MaxPoint);
			}
			if (this.LastAddPointTime != 0L)
			{
				output.WriteRawTag(104);
				output.WriteInt64(this.LastAddPointTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016B27 RID: 92967 RVA: 0x0034CEB4 File Offset: 0x0034B0B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CurrPoint != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurrPoint);
			}
			if (this.MaxPoint != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxPoint);
			}
			if (this.LastAddPointTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.LastAddPointTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016B28 RID: 92968 RVA: 0x0034CF24 File Offset: 0x0034B124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleQuestPointStateResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CurrPoint != 0)
			{
				this.CurrPoint = other.CurrPoint;
			}
			if (other.MaxPoint != 0)
			{
				this.MaxPoint = other.MaxPoint;
			}
			if (other.LastAddPointTime != 0L)
			{
				this.LastAddPointTime = other.LastAddPointTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016B29 RID: 92969 RVA: 0x0034CF88 File Offset: 0x0034B188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016B2A RID: 92970 RVA: 0x0034CF94 File Offset: 0x0034B194
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
				if (num != 32U)
				{
					if (num != 40U)
					{
						if (num != 104U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.LastAddPointTime = input.ReadInt64();
						}
					}
					else
					{
						this.MaxPoint = input.ReadInt32();
					}
				}
				else
				{
					this.CurrPoint = input.ReadInt32();
				}
			}
		}

		// Token: 0x040087FF RID: 34815
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008800 RID: 34816
		public const int CurrPointFieldNumber = 4;

		// Token: 0x04008801 RID: 34817
		private int currPoint_;

		// Token: 0x04008802 RID: 34818
		public const int MaxPointFieldNumber = 5;

		// Token: 0x04008803 RID: 34819
		private int maxPoint_;

		// Token: 0x04008804 RID: 34820
		public const int LastAddPointTimeFieldNumber = 13;

		// Token: 0x04008805 RID: 34821
		private long lastAddPointTime_;
	}
}
