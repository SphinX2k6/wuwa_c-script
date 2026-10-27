using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200057F RID: 1407
	[NetMessage(EMessageId.FishingShipForceBackNotify)]
	public sealed class FishingShipForceBackNotify : IMessage<FishingShipForceBackNotify>, IMessage, IEquatable<FishingShipForceBackNotify>, IDeepCloneable<FishingShipForceBackNotify>, IBufferMessage
	{
		// Token: 0x060082B0 RID: 33456 RVA: 0x0013B18D File Offset: 0x0013938D
		[NullableContext(1)]
		public static FishingShipForceBackNotify Create()
		{
			return new FishingShipForceBackNotify();
		}

		// Token: 0x17001977 RID: 6519
		// (get) Token: 0x060082B1 RID: 33457 RVA: 0x0013B194 File Offset: 0x00139394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001978 RID: 6520
		// (get) Token: 0x060082B2 RID: 33458 RVA: 0x0013B197 File Offset: 0x00139397
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingShipForceBackNotify.Descriptor;
			}
		}

		// Token: 0x060082B3 RID: 33459 RVA: 0x0013B19E File Offset: 0x0013939E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingShipForceBackNotify()
		{
		}

		// Token: 0x060082B4 RID: 33460 RVA: 0x0013B1A6 File Offset: 0x001393A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingShipForceBackNotify(FishingShipForceBackNotify other) : this()
		{
			this.shipInfo_ = ((other.shipInfo_ != null) ? other.shipInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060082B5 RID: 33461 RVA: 0x0013B1DB File Offset: 0x001393DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingShipForceBackNotify Clone()
		{
			return new FishingShipForceBackNotify(this);
		}

		// Token: 0x17001979 RID: 6521
		// (get) Token: 0x060082B6 RID: 33462 RVA: 0x0013B1E3 File Offset: 0x001393E3
		// (set) Token: 0x060082B7 RID: 33463 RVA: 0x0013B1EB File Offset: 0x001393EB
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

		// Token: 0x060082B8 RID: 33464 RVA: 0x0013B1F4 File Offset: 0x001393F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingShipForceBackNotify);
		}

		// Token: 0x060082B9 RID: 33465 RVA: 0x0013B202 File Offset: 0x00139402
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingShipForceBackNotify other)
		{
			return other != null && (other == this || (object.Equals(this.ShipInfo, other.ShipInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060082BA RID: 33466 RVA: 0x0013B238 File Offset: 0x00139438
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

		// Token: 0x060082BB RID: 33467 RVA: 0x0013B274 File Offset: 0x00139474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060082BC RID: 33468 RVA: 0x0013B281 File Offset: 0x00139481
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060082BD RID: 33469 RVA: 0x0013B28A File Offset: 0x0013948A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.shipInfo_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.ShipInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060082BE RID: 33470 RVA: 0x0013B2BC File Offset: 0x001394BC
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

		// Token: 0x060082BF RID: 33471 RVA: 0x0013B2FC File Offset: 0x001394FC
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

		// Token: 0x060082C0 RID: 33472 RVA: 0x0013B350 File Offset: 0x00139550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060082C1 RID: 33473 RVA: 0x0013B35C File Offset: 0x0013955C
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
				if (num != 74U)
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

		// Token: 0x0400414A RID: 16714
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400414B RID: 16715
		public const int ShipInfoFieldNumber = 9;

		// Token: 0x0400414C RID: 16716
		private FishingShipInfo shipInfo_;
	}
}
