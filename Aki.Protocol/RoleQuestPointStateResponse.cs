using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010A4 RID: 4260
	[NetMessage(EMessageId.RoleQuestPointStateResponse)]
	public sealed class RoleQuestPointStateResponse : IMessage<RoleQuestPointStateResponse>, IMessage, IEquatable<RoleQuestPointStateResponse>, IDeepCloneable<RoleQuestPointStateResponse>, IBufferMessage
	{
		// Token: 0x06016BFA RID: 93178 RVA: 0x0034E392 File Offset: 0x0034C592
		[NullableContext(1)]
		public static RoleQuestPointStateResponse Create()
		{
			return new RoleQuestPointStateResponse();
		}

		// Token: 0x17004C36 RID: 19510
		// (get) Token: 0x06016BFB RID: 93179 RVA: 0x0034E399 File Offset: 0x0034C599
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004C37 RID: 19511
		// (get) Token: 0x06016BFC RID: 93180 RVA: 0x0034E39C File Offset: 0x0034C59C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleQuestPointStateResponse.Descriptor;
			}
		}

		// Token: 0x06016BFD RID: 93181 RVA: 0x0034E3A3 File Offset: 0x0034C5A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleQuestPointStateResponse()
		{
		}

		// Token: 0x06016BFE RID: 93182 RVA: 0x0034E3AB File Offset: 0x0034C5AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleQuestPointStateResponse(RoleQuestPointStateResponse other) : this()
		{
			this.currPoint_ = other.currPoint_;
			this.maxPoint_ = other.maxPoint_;
			this.lastAddPointTime_ = other.lastAddPointTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016BFF RID: 93183 RVA: 0x0034E3E8 File Offset: 0x0034C5E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleQuestPointStateResponse Clone()
		{
			return new RoleQuestPointStateResponse(this);
		}

		// Token: 0x17004C38 RID: 19512
		// (get) Token: 0x06016C00 RID: 93184 RVA: 0x0034E3F0 File Offset: 0x0034C5F0
		// (set) Token: 0x06016C01 RID: 93185 RVA: 0x0034E3F8 File Offset: 0x0034C5F8
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

		// Token: 0x17004C39 RID: 19513
		// (get) Token: 0x06016C02 RID: 93186 RVA: 0x0034E401 File Offset: 0x0034C601
		// (set) Token: 0x06016C03 RID: 93187 RVA: 0x0034E409 File Offset: 0x0034C609
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

		// Token: 0x17004C3A RID: 19514
		// (get) Token: 0x06016C04 RID: 93188 RVA: 0x0034E412 File Offset: 0x0034C612
		// (set) Token: 0x06016C05 RID: 93189 RVA: 0x0034E41A File Offset: 0x0034C61A
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

		// Token: 0x06016C06 RID: 93190 RVA: 0x0034E423 File Offset: 0x0034C623
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleQuestPointStateResponse);
		}

		// Token: 0x06016C07 RID: 93191 RVA: 0x0034E434 File Offset: 0x0034C634
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleQuestPointStateResponse other)
		{
			return other != null && (other == this || (this.CurrPoint == other.CurrPoint && this.MaxPoint == other.MaxPoint && this.LastAddPointTime == other.LastAddPointTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016C08 RID: 93192 RVA: 0x0034E490 File Offset: 0x0034C690
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

		// Token: 0x06016C09 RID: 93193 RVA: 0x0034E501 File Offset: 0x0034C701
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016C0A RID: 93194 RVA: 0x0034E50E File Offset: 0x0034C70E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016C0B RID: 93195 RVA: 0x0034E518 File Offset: 0x0034C718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LastAddPointTime != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.LastAddPointTime);
			}
			if (this.MaxPoint != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.MaxPoint);
			}
			if (this.CurrPoint != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.CurrPoint);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016C0C RID: 93196 RVA: 0x0034E590 File Offset: 0x0034C790
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

		// Token: 0x06016C0D RID: 93197 RVA: 0x0034E600 File Offset: 0x0034C800
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

		// Token: 0x06016C0E RID: 93198 RVA: 0x0034E664 File Offset: 0x0034C864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016C0F RID: 93199 RVA: 0x0034E670 File Offset: 0x0034C870
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
				if (num != 40U)
				{
					if (num != 48U)
					{
						if (num != 80U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.CurrPoint = input.ReadInt32();
						}
					}
					else
					{
						this.MaxPoint = input.ReadInt32();
					}
				}
				else
				{
					this.LastAddPointTime = input.ReadInt64();
				}
			}
		}

		// Token: 0x040087D5 RID: 34773
		private UnknownFieldSet _unknownFields;

		// Token: 0x040087D6 RID: 34774
		public const int CurrPointFieldNumber = 10;

		// Token: 0x040087D7 RID: 34775
		private int currPoint_;

		// Token: 0x040087D8 RID: 34776
		public const int MaxPointFieldNumber = 6;

		// Token: 0x040087D9 RID: 34777
		private int maxPoint_;

		// Token: 0x040087DA RID: 34778
		public const int LastAddPointTimeFieldNumber = 5;

		// Token: 0x040087DB RID: 34779
		private long lastAddPointTime_;
	}
}
