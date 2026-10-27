using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E5C RID: 3676
	[NetMessage(EMessageId.RacingBetsGearRefundRequest)]
	public sealed class RacingBetsGearRefundRequest : IMessage<RacingBetsGearRefundRequest>, IMessage, IEquatable<RacingBetsGearRefundRequest>, IDeepCloneable<RacingBetsGearRefundRequest>, IBufferMessage
	{
		// Token: 0x06013BBA RID: 80826 RVA: 0x002DE308 File Offset: 0x002DC508
		[NullableContext(1)]
		public static RacingBetsGearRefundRequest Create()
		{
			return new RacingBetsGearRefundRequest();
		}

		// Token: 0x1700417E RID: 16766
		// (get) Token: 0x06013BBB RID: 80827 RVA: 0x002DE30F File Offset: 0x002DC50F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700417F RID: 16767
		// (get) Token: 0x06013BBC RID: 80828 RVA: 0x002DE312 File Offset: 0x002DC512
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsGearRefundRequest.Descriptor;
			}
		}

		// Token: 0x06013BBD RID: 80829 RVA: 0x002DE319 File Offset: 0x002DC519
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsGearRefundRequest()
		{
		}

		// Token: 0x06013BBE RID: 80830 RVA: 0x002DE321 File Offset: 0x002DC521
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsGearRefundRequest(RacingBetsGearRefundRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.legMatchId_ = other.legMatchId_;
			this.dangoId_ = other.dangoId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013BBF RID: 80831 RVA: 0x002DE35E File Offset: 0x002DC55E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsGearRefundRequest Clone()
		{
			return new RacingBetsGearRefundRequest(this);
		}

		// Token: 0x17004180 RID: 16768
		// (get) Token: 0x06013BC0 RID: 80832 RVA: 0x002DE366 File Offset: 0x002DC566
		// (set) Token: 0x06013BC1 RID: 80833 RVA: 0x002DE36E File Offset: 0x002DC56E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x17004181 RID: 16769
		// (get) Token: 0x06013BC2 RID: 80834 RVA: 0x002DE377 File Offset: 0x002DC577
		// (set) Token: 0x06013BC3 RID: 80835 RVA: 0x002DE37F File Offset: 0x002DC57F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LegMatchId
		{
			get
			{
				return this.legMatchId_;
			}
			set
			{
				this.legMatchId_ = value;
			}
		}

		// Token: 0x17004182 RID: 16770
		// (get) Token: 0x06013BC4 RID: 80836 RVA: 0x002DE388 File Offset: 0x002DC588
		// (set) Token: 0x06013BC5 RID: 80837 RVA: 0x002DE390 File Offset: 0x002DC590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DangoId
		{
			get
			{
				return this.dangoId_;
			}
			set
			{
				this.dangoId_ = value;
			}
		}

		// Token: 0x06013BC6 RID: 80838 RVA: 0x002DE399 File Offset: 0x002DC599
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsGearRefundRequest);
		}

		// Token: 0x06013BC7 RID: 80839 RVA: 0x002DE3A8 File Offset: 0x002DC5A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsGearRefundRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.LegMatchId == other.LegMatchId && this.DangoId == other.DangoId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013BC8 RID: 80840 RVA: 0x002DE404 File Offset: 0x002DC604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.LegMatchId != 0)
			{
				num ^= this.LegMatchId.GetHashCode();
			}
			if (this.DangoId != 0)
			{
				num ^= this.DangoId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013BC9 RID: 80841 RVA: 0x002DE475 File Offset: 0x002DC675
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013BCA RID: 80842 RVA: 0x002DE482 File Offset: 0x002DC682
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013BCB RID: 80843 RVA: 0x002DE48C File Offset: 0x002DC68C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ActivityId);
			}
			if (this.DangoId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.DangoId);
			}
			if (this.LegMatchId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.LegMatchId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013BCC RID: 80844 RVA: 0x002DE500 File Offset: 0x002DC700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.LegMatchId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LegMatchId);
			}
			if (this.DangoId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DangoId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013BCD RID: 80845 RVA: 0x002DE570 File Offset: 0x002DC770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsGearRefundRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.LegMatchId != 0)
			{
				this.LegMatchId = other.LegMatchId;
			}
			if (other.DangoId != 0)
			{
				this.DangoId = other.DangoId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013BCE RID: 80846 RVA: 0x002DE5D4 File Offset: 0x002DC7D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013BCF RID: 80847 RVA: 0x002DE5E0 File Offset: 0x002DC7E0
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
					if (num != 104U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.LegMatchId = input.ReadInt32();
						}
					}
					else
					{
						this.DangoId = input.ReadInt32();
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040078A9 RID: 30889
		private UnknownFieldSet _unknownFields;

		// Token: 0x040078AA RID: 30890
		public const int ActivityIdFieldNumber = 1;

		// Token: 0x040078AB RID: 30891
		private int activityId_;

		// Token: 0x040078AC RID: 30892
		public const int LegMatchIdFieldNumber = 15;

		// Token: 0x040078AD RID: 30893
		private int legMatchId_;

		// Token: 0x040078AE RID: 30894
		public const int DangoIdFieldNumber = 13;

		// Token: 0x040078AF RID: 30895
		private int dangoId_;
	}
}
