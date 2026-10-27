using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000581 RID: 1409
	[NetMessage(EMessageId.FishingShipInfoUpdateNotify)]
	public sealed class FishingShipInfoUpdateNotify : IMessage<FishingShipInfoUpdateNotify>, IMessage, IEquatable<FishingShipInfoUpdateNotify>, IDeepCloneable<FishingShipInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x060082E2 RID: 33506 RVA: 0x0013BA77 File Offset: 0x00139C77
		[NullableContext(1)]
		public static FishingShipInfoUpdateNotify Create()
		{
			return new FishingShipInfoUpdateNotify();
		}

		// Token: 0x17001984 RID: 6532
		// (get) Token: 0x060082E3 RID: 33507 RVA: 0x0013BA7E File Offset: 0x00139C7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001985 RID: 6533
		// (get) Token: 0x060082E4 RID: 33508 RVA: 0x0013BA81 File Offset: 0x00139C81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingShipInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x060082E5 RID: 33509 RVA: 0x0013BA88 File Offset: 0x00139C88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingShipInfoUpdateNotify()
		{
		}

		// Token: 0x060082E6 RID: 33510 RVA: 0x0013BA90 File Offset: 0x00139C90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingShipInfoUpdateNotify(FishingShipInfoUpdateNotify other) : this()
		{
			this.shipInfo_ = ((other.shipInfo_ != null) ? other.shipInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060082E7 RID: 33511 RVA: 0x0013BAC5 File Offset: 0x00139CC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingShipInfoUpdateNotify Clone()
		{
			return new FishingShipInfoUpdateNotify(this);
		}

		// Token: 0x17001986 RID: 6534
		// (get) Token: 0x060082E8 RID: 33512 RVA: 0x0013BACD File Offset: 0x00139CCD
		// (set) Token: 0x060082E9 RID: 33513 RVA: 0x0013BAD5 File Offset: 0x00139CD5
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

		// Token: 0x060082EA RID: 33514 RVA: 0x0013BADE File Offset: 0x00139CDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingShipInfoUpdateNotify);
		}

		// Token: 0x060082EB RID: 33515 RVA: 0x0013BAEC File Offset: 0x00139CEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingShipInfoUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.ShipInfo, other.ShipInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060082EC RID: 33516 RVA: 0x0013BB20 File Offset: 0x00139D20
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

		// Token: 0x060082ED RID: 33517 RVA: 0x0013BB5C File Offset: 0x00139D5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060082EE RID: 33518 RVA: 0x0013BB69 File Offset: 0x00139D69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060082EF RID: 33519 RVA: 0x0013BB72 File Offset: 0x00139D72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.shipInfo_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.ShipInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060082F0 RID: 33520 RVA: 0x0013BBA4 File Offset: 0x00139DA4
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

		// Token: 0x060082F1 RID: 33521 RVA: 0x0013BBE4 File Offset: 0x00139DE4
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

		// Token: 0x060082F2 RID: 33522 RVA: 0x0013BC38 File Offset: 0x00139E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060082F3 RID: 33523 RVA: 0x0013BC44 File Offset: 0x00139E44
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
				if (num != 90U)
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

		// Token: 0x0400415E RID: 16734
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400415F RID: 16735
		public const int ShipInfoFieldNumber = 11;

		// Token: 0x04004160 RID: 16736
		private FishingShipInfo shipInfo_;
	}
}
