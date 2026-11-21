using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200056C RID: 1388
	[NetMessage(EMessageId.FishingShipInfoUpdateNotify)]
	public sealed class FishingShipInfoUpdateNotify : IMessage<FishingShipInfoUpdateNotify>, IMessage, IEquatable<FishingShipInfoUpdateNotify>, IDeepCloneable<FishingShipInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600817A RID: 33146 RVA: 0x00138E6F File Offset: 0x0013706F
		[NullableContext(1)]
		public static FishingShipInfoUpdateNotify Create()
		{
			return new FishingShipInfoUpdateNotify();
		}

		// Token: 0x17001937 RID: 6455
		// (get) Token: 0x0600817B RID: 33147 RVA: 0x00138E76 File Offset: 0x00137076
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001938 RID: 6456
		// (get) Token: 0x0600817C RID: 33148 RVA: 0x00138E79 File Offset: 0x00137079
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingShipInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600817D RID: 33149 RVA: 0x00138E80 File Offset: 0x00137080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingShipInfoUpdateNotify()
		{
		}

		// Token: 0x0600817E RID: 33150 RVA: 0x00138E88 File Offset: 0x00137088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingShipInfoUpdateNotify(FishingShipInfoUpdateNotify other) : this()
		{
			this.shipInfo_ = ((other.shipInfo_ != null) ? other.shipInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600817F RID: 33151 RVA: 0x00138EBD File Offset: 0x001370BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingShipInfoUpdateNotify Clone()
		{
			return new FishingShipInfoUpdateNotify(this);
		}

		// Token: 0x17001939 RID: 6457
		// (get) Token: 0x06008180 RID: 33152 RVA: 0x00138EC5 File Offset: 0x001370C5
		// (set) Token: 0x06008181 RID: 33153 RVA: 0x00138ECD File Offset: 0x001370CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingShipInfo ShipInfo
		{
			get
			{
				return this.shipInfo_;
			}
			set
			{
				this.shipInfo_ = value;
			}
		}

		// Token: 0x06008182 RID: 33154 RVA: 0x00138ED6 File Offset: 0x001370D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingShipInfoUpdateNotify);
		}

		// Token: 0x06008183 RID: 33155 RVA: 0x00138EE4 File Offset: 0x001370E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingShipInfoUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.ShipInfo, other.ShipInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008184 RID: 33156 RVA: 0x00138F18 File Offset: 0x00137118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.shipInfo_ != null)
			{
				num ^= this.ShipInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008185 RID: 33157 RVA: 0x00138F54 File Offset: 0x00137154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008186 RID: 33158 RVA: 0x00138F61 File Offset: 0x00137161
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008187 RID: 33159 RVA: 0x00138F6A File Offset: 0x0013716A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.shipInfo_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.ShipInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008188 RID: 33160 RVA: 0x00138F9C File Offset: 0x0013719C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.shipInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ShipInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008189 RID: 33161 RVA: 0x00138FDC File Offset: 0x001371DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingShipInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.shipInfo_ != null)
			{
				if (this.shipInfo_ == null)
				{
					this.ShipInfo = new FishingShipInfo();
				}
				this.ShipInfo.MergeFrom(other.ShipInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600818A RID: 33162 RVA: 0x00139030 File Offset: 0x00137230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600818B RID: 33163 RVA: 0x0013903C File Offset: 0x0013723C
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
				if (num != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.shipInfo_ == null)
					{
						this.ShipInfo = new FishingShipInfo();
					}
					input.ReadMessage(this.ShipInfo);
				}
			}
		}

		// Token: 0x04004154 RID: 16724
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004155 RID: 16725
		public const int ShipInfoFieldNumber = 2;

		// Token: 0x04004156 RID: 16726
		private FishingShipInfo shipInfo_;
	}
}
