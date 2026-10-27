using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007F0 RID: 2032
	[NetMessage(EMessageId.InfrRoadUpdateNotify)]
	public sealed class InfrRoadUpdateNotify : IMessage<InfrRoadUpdateNotify>, IMessage, IEquatable<InfrRoadUpdateNotify>, IDeepCloneable<InfrRoadUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600B634 RID: 46644 RVA: 0x001B2FC3 File Offset: 0x001B11C3
		[NullableContext(1)]
		public static InfrRoadUpdateNotify Create()
		{
			return new InfrRoadUpdateNotify();
		}

		// Token: 0x170024BE RID: 9406
		// (get) Token: 0x0600B635 RID: 46645 RVA: 0x001B2FCA File Offset: 0x001B11CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170024BF RID: 9407
		// (get) Token: 0x0600B636 RID: 46646 RVA: 0x001B2FCD File Offset: 0x001B11CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrRoadUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600B637 RID: 46647 RVA: 0x001B2FD4 File Offset: 0x001B11D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrRoadUpdateNotify()
		{
		}

		// Token: 0x0600B638 RID: 46648 RVA: 0x001B2FDC File Offset: 0x001B11DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrRoadUpdateNotify(InfrRoadUpdateNotify other) : this()
		{
			this.roadInfo_ = ((other.roadInfo_ != null) ? other.roadInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B639 RID: 46649 RVA: 0x001B3011 File Offset: 0x001B1211
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrRoadUpdateNotify Clone()
		{
			return new InfrRoadUpdateNotify(this);
		}

		// Token: 0x170024C0 RID: 9408
		// (get) Token: 0x0600B63A RID: 46650 RVA: 0x001B3019 File Offset: 0x001B1219
		// (set) Token: 0x0600B63B RID: 46651 RVA: 0x001B3021 File Offset: 0x001B1221
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrRoadPb RoadInfo
		{
			get
			{
				return this.roadInfo_;
			}
			set
			{
				this.roadInfo_ = value;
			}
		}

		// Token: 0x0600B63C RID: 46652 RVA: 0x001B302A File Offset: 0x001B122A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrRoadUpdateNotify);
		}

		// Token: 0x0600B63D RID: 46653 RVA: 0x001B3038 File Offset: 0x001B1238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrRoadUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.RoadInfo, other.RoadInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B63E RID: 46654 RVA: 0x001B306C File Offset: 0x001B126C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.roadInfo_ != null)
			{
				num ^= this.RoadInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B63F RID: 46655 RVA: 0x001B30A8 File Offset: 0x001B12A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B640 RID: 46656 RVA: 0x001B30B5 File Offset: 0x001B12B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B641 RID: 46657 RVA: 0x001B30BE File Offset: 0x001B12BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.roadInfo_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.RoadInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B642 RID: 46658 RVA: 0x001B30F0 File Offset: 0x001B12F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.roadInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RoadInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B643 RID: 46659 RVA: 0x001B3130 File Offset: 0x001B1330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrRoadUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.roadInfo_ != null)
			{
				if (this.roadInfo_ == null)
				{
					this.RoadInfo = new InfrRoadPb();
				}
				this.RoadInfo.MergeFrom(other.RoadInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B644 RID: 46660 RVA: 0x001B3184 File Offset: 0x001B1384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B645 RID: 46661 RVA: 0x001B3190 File Offset: 0x001B1390
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
				if (num != 58U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.roadInfo_ == null)
					{
						this.RoadInfo = new InfrRoadPb();
					}
					input.ReadMessage(this.RoadInfo);
				}
			}
		}

		// Token: 0x040050BD RID: 20669
		private UnknownFieldSet _unknownFields;

		// Token: 0x040050BE RID: 20670
		public const int RoadInfoFieldNumber = 7;

		// Token: 0x040050BF RID: 20671
		private InfrRoadPb roadInfo_;
	}
}
