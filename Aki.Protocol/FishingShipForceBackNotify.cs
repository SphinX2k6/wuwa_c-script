using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200056A RID: 1386
	[NetMessage(EMessageId.FishingShipForceBackNotify)]
	public sealed class FishingShipForceBackNotify : IMessage<FishingShipForceBackNotify>, IMessage, IEquatable<FishingShipForceBackNotify>, IDeepCloneable<FishingShipForceBackNotify>, IBufferMessage
	{
		// Token: 0x06008148 RID: 33096 RVA: 0x00138585 File Offset: 0x00136785
		[NullableContext(1)]
		public static FishingShipForceBackNotify Create()
		{
			return new FishingShipForceBackNotify();
		}

		// Token: 0x1700192A RID: 6442
		// (get) Token: 0x06008149 RID: 33097 RVA: 0x0013858C File Offset: 0x0013678C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700192B RID: 6443
		// (get) Token: 0x0600814A RID: 33098 RVA: 0x0013858F File Offset: 0x0013678F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingShipForceBackNotify.Descriptor;
			}
		}

		// Token: 0x0600814B RID: 33099 RVA: 0x00138596 File Offset: 0x00136796
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingShipForceBackNotify()
		{
		}

		// Token: 0x0600814C RID: 33100 RVA: 0x0013859E File Offset: 0x0013679E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingShipForceBackNotify(FishingShipForceBackNotify other) : this()
		{
			this.shipInfo_ = ((other.shipInfo_ != null) ? other.shipInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600814D RID: 33101 RVA: 0x001385D3 File Offset: 0x001367D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingShipForceBackNotify Clone()
		{
			return new FishingShipForceBackNotify(this);
		}

		// Token: 0x1700192C RID: 6444
		// (get) Token: 0x0600814E RID: 33102 RVA: 0x001385DB File Offset: 0x001367DB
		// (set) Token: 0x0600814F RID: 33103 RVA: 0x001385E3 File Offset: 0x001367E3
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

		// Token: 0x06008150 RID: 33104 RVA: 0x001385EC File Offset: 0x001367EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingShipForceBackNotify);
		}

		// Token: 0x06008151 RID: 33105 RVA: 0x001385FA File Offset: 0x001367FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingShipForceBackNotify other)
		{
			return other != null && (other == this || (object.Equals(this.ShipInfo, other.ShipInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008152 RID: 33106 RVA: 0x00138630 File Offset: 0x00136830
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

		// Token: 0x06008153 RID: 33107 RVA: 0x0013866C File Offset: 0x0013686C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008154 RID: 33108 RVA: 0x00138679 File Offset: 0x00136879
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008155 RID: 33109 RVA: 0x00138682 File Offset: 0x00136882
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.shipInfo_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.ShipInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008156 RID: 33110 RVA: 0x001386B4 File Offset: 0x001368B4
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

		// Token: 0x06008157 RID: 33111 RVA: 0x001386F4 File Offset: 0x001368F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingShipForceBackNotify other)
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

		// Token: 0x06008158 RID: 33112 RVA: 0x00138748 File Offset: 0x00136948
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008159 RID: 33113 RVA: 0x00138754 File Offset: 0x00136954
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
				if (num != 82U)
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

		// Token: 0x04004140 RID: 16704
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004141 RID: 16705
		public const int ShipInfoFieldNumber = 10;

		// Token: 0x04004142 RID: 16706
		private FishingShipInfo shipInfo_;
	}
}
