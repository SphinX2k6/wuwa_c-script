using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F44 RID: 3908
	[NetMessage(EMessageId.RiskHarvestActivityUpdateNotify)]
	public sealed class RiskHarvestActivityUpdateNotify : IMessage<RiskHarvestActivityUpdateNotify>, IMessage, IEquatable<RiskHarvestActivityUpdateNotify>, IDeepCloneable<RiskHarvestActivityUpdateNotify>, IBufferMessage
	{
		// Token: 0x06014EF9 RID: 85753 RVA: 0x0030A412 File Offset: 0x00308612
		[NullableContext(1)]
		public static RiskHarvestActivityUpdateNotify Create()
		{
			return new RiskHarvestActivityUpdateNotify();
		}

		// Token: 0x170045AB RID: 17835
		// (get) Token: 0x06014EFA RID: 85754 RVA: 0x0030A419 File Offset: 0x00308619
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170045AC RID: 17836
		// (get) Token: 0x06014EFB RID: 85755 RVA: 0x0030A41C File Offset: 0x0030861C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RiskHarvestActivityUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06014EFC RID: 85756 RVA: 0x0030A423 File Offset: 0x00308623
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestActivityUpdateNotify()
		{
		}

		// Token: 0x06014EFD RID: 85757 RVA: 0x0030A42B File Offset: 0x0030862B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestActivityUpdateNotify(RiskHarvestActivityUpdateNotify other) : this()
		{
			this.activityInfo_ = ((other.activityInfo_ != null) ? other.activityInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014EFE RID: 85758 RVA: 0x0030A460 File Offset: 0x00308660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestActivityUpdateNotify Clone()
		{
			return new RiskHarvestActivityUpdateNotify(this);
		}

		// Token: 0x170045AD RID: 17837
		// (get) Token: 0x06014EFF RID: 85759 RVA: 0x0030A468 File Offset: 0x00308668
		// (set) Token: 0x06014F00 RID: 85760 RVA: 0x0030A470 File Offset: 0x00308670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestActivityInfo ActivityInfo
		{
			get
			{
				return this.activityInfo_;
			}
			set
			{
				this.activityInfo_ = value;
			}
		}

		// Token: 0x06014F01 RID: 85761 RVA: 0x0030A479 File Offset: 0x00308679
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RiskHarvestActivityUpdateNotify);
		}

		// Token: 0x06014F02 RID: 85762 RVA: 0x0030A487 File Offset: 0x00308687
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RiskHarvestActivityUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.ActivityInfo, other.ActivityInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014F03 RID: 85763 RVA: 0x0030A4BC File Offset: 0x003086BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.activityInfo_ != null)
			{
				num ^= this.ActivityInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014F04 RID: 85764 RVA: 0x0030A4F8 File Offset: 0x003086F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014F05 RID: 85765 RVA: 0x0030A505 File Offset: 0x00308705
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014F06 RID: 85766 RVA: 0x0030A50E File Offset: 0x0030870E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.activityInfo_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.ActivityInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014F07 RID: 85767 RVA: 0x0030A540 File Offset: 0x00308740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.activityInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ActivityInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014F08 RID: 85768 RVA: 0x0030A580 File Offset: 0x00308780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RiskHarvestActivityUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.activityInfo_ != null)
			{
				if (this.activityInfo_ == null)
				{
					this.ActivityInfo = new RiskHarvestActivityInfo();
				}
				this.ActivityInfo.MergeFrom(other.ActivityInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014F09 RID: 85769 RVA: 0x0030A5D4 File Offset: 0x003087D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014F0A RID: 85770 RVA: 0x0030A5E0 File Offset: 0x003087E0
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
					if (this.activityInfo_ == null)
					{
						this.ActivityInfo = new RiskHarvestActivityInfo();
					}
					input.ReadMessage(this.ActivityInfo);
				}
			}
		}

		// Token: 0x04007EB7 RID: 32439
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007EB8 RID: 32440
		public const int ActivityInfoFieldNumber = 10;

		// Token: 0x04007EB9 RID: 32441
		private RiskHarvestActivityInfo activityInfo_;
	}
}
