using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002BC RID: 700
	public sealed class CombinePartInfo : IMessage<CombinePartInfo>, IMessage, IEquatable<CombinePartInfo>, IDeepCloneable<CombinePartInfo>, IBufferMessage
	{
		// Token: 0x0600487D RID: 18557 RVA: 0x000B2310 File Offset: 0x000B0510
		[NullableContext(1)]
		public static CombinePartInfo Create()
		{
			return new CombinePartInfo();
		}

		// Token: 0x17000CA8 RID: 3240
		// (get) Token: 0x0600487E RID: 18558 RVA: 0x000B2317 File Offset: 0x000B0517
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CombinePartInfo> Parser
		{
			get
			{
				return CombinePartInfo._parser;
			}
		}

		// Token: 0x17000CA9 RID: 3241
		// (get) Token: 0x0600487F RID: 18559 RVA: 0x000B231E File Offset: 0x000B051E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000CAA RID: 3242
		// (get) Token: 0x06004880 RID: 18560 RVA: 0x000B2321 File Offset: 0x000B0521
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CombinePartInfo.Descriptor;
			}
		}

		// Token: 0x06004881 RID: 18561 RVA: 0x000B2328 File Offset: 0x000B0528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombinePartInfo()
		{
		}

		// Token: 0x06004882 RID: 18562 RVA: 0x000B2330 File Offset: 0x000B0530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombinePartInfo(CombinePartInfo other) : this()
		{
			this.combinerEntityId_ = other.combinerEntityId_;
			this.offsetPos_ = ((other.offsetPos_ != null) ? other.offsetPos_.Clone() : null);
			this.offsetRotate_ = ((other.offsetRotate_ != null) ? other.offsetRotate_.Clone() : null);
			this.partId_ = other.partId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004883 RID: 18563 RVA: 0x000B23A4 File Offset: 0x000B05A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombinePartInfo Clone()
		{
			return new CombinePartInfo(this);
		}

		// Token: 0x17000CAB RID: 3243
		// (get) Token: 0x06004884 RID: 18564 RVA: 0x000B23AC File Offset: 0x000B05AC
		// (set) Token: 0x06004885 RID: 18565 RVA: 0x000B23B4 File Offset: 0x000B05B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CombinerEntityId
		{
			get
			{
				return this.combinerEntityId_;
			}
			set
			{
				this.combinerEntityId_ = value;
			}
		}

		// Token: 0x17000CAC RID: 3244
		// (get) Token: 0x06004886 RID: 18566 RVA: 0x000B23BD File Offset: 0x000B05BD
		// (set) Token: 0x06004887 RID: 18567 RVA: 0x000B23C5 File Offset: 0x000B05C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector OffsetPos
		{
			get
			{
				return this.offsetPos_;
			}
			set
			{
				this.offsetPos_ = value;
			}
		}

		// Token: 0x17000CAD RID: 3245
		// (get) Token: 0x06004888 RID: 18568 RVA: 0x000B23CE File Offset: 0x000B05CE
		// (set) Token: 0x06004889 RID: 18569 RVA: 0x000B23D6 File Offset: 0x000B05D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Rotator OffsetRotate
		{
			get
			{
				return this.offsetRotate_;
			}
			set
			{
				this.offsetRotate_ = value;
			}
		}

		// Token: 0x17000CAE RID: 3246
		// (get) Token: 0x0600488A RID: 18570 RVA: 0x000B23DF File Offset: 0x000B05DF
		// (set) Token: 0x0600488B RID: 18571 RVA: 0x000B23E7 File Offset: 0x000B05E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PartId
		{
			get
			{
				return this.partId_;
			}
			set
			{
				this.partId_ = value;
			}
		}

		// Token: 0x0600488C RID: 18572 RVA: 0x000B23F0 File Offset: 0x000B05F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CombinePartInfo);
		}

		// Token: 0x0600488D RID: 18573 RVA: 0x000B2400 File Offset: 0x000B0600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CombinePartInfo other)
		{
			return other != null && (other == this || (this.CombinerEntityId == other.CombinerEntityId && object.Equals(this.OffsetPos, other.OffsetPos) && object.Equals(this.OffsetRotate, other.OffsetRotate) && this.PartId == other.PartId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600488E RID: 18574 RVA: 0x000B2474 File Offset: 0x000B0674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CombinerEntityId != 0L)
			{
				num ^= this.CombinerEntityId.GetHashCode();
			}
			if (this.offsetPos_ != null)
			{
				num ^= this.OffsetPos.GetHashCode();
			}
			if (this.offsetRotate_ != null)
			{
				num ^= this.OffsetRotate.GetHashCode();
			}
			if (this.PartId != 0)
			{
				num ^= this.PartId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600488F RID: 18575 RVA: 0x000B24F8 File Offset: 0x000B06F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004890 RID: 18576 RVA: 0x000B2505 File Offset: 0x000B0705
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004891 RID: 18577 RVA: 0x000B2510 File Offset: 0x000B0710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CombinerEntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.CombinerEntityId);
			}
			if (this.offsetPos_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.OffsetPos);
			}
			if (this.offsetRotate_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.OffsetRotate);
			}
			if (this.PartId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.PartId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004892 RID: 18578 RVA: 0x000B25A0 File Offset: 0x000B07A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CombinerEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.CombinerEntityId);
			}
			if (this.offsetPos_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.OffsetPos);
			}
			if (this.offsetRotate_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.OffsetRotate);
			}
			if (this.PartId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PartId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004893 RID: 18579 RVA: 0x000B2628 File Offset: 0x000B0828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CombinePartInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CombinerEntityId != 0L)
			{
				this.CombinerEntityId = other.CombinerEntityId;
			}
			if (other.offsetPos_ != null)
			{
				if (this.offsetPos_ == null)
				{
					this.OffsetPos = new Vector();
				}
				this.OffsetPos.MergeFrom(other.OffsetPos);
			}
			if (other.offsetRotate_ != null)
			{
				if (this.offsetRotate_ == null)
				{
					this.OffsetRotate = new Rotator();
				}
				this.OffsetRotate.MergeFrom(other.OffsetRotate);
			}
			if (other.PartId != 0)
			{
				this.PartId = other.PartId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004894 RID: 18580 RVA: 0x000B26D0 File Offset: 0x000B08D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004895 RID: 18581 RVA: 0x000B26DC File Offset: 0x000B08DC
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
				if (num <= 18U)
				{
					if (num == 8U)
					{
						this.CombinerEntityId = input.ReadInt64();
						continue;
					}
					if (num == 18U)
					{
						if (this.offsetPos_ == null)
						{
							this.OffsetPos = new Vector();
						}
						input.ReadMessage(this.OffsetPos);
						continue;
					}
				}
				else
				{
					if (num == 26U)
					{
						if (this.offsetRotate_ == null)
						{
							this.OffsetRotate = new Rotator();
						}
						input.ReadMessage(this.OffsetRotate);
						continue;
					}
					if (num == 32U)
					{
						this.PartId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003047 RID: 12359
		private static readonly MessageParser<CombinePartInfo> _parser = new MessageParser<CombinePartInfo>(() => new CombinePartInfo());

		// Token: 0x04003048 RID: 12360
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003049 RID: 12361
		public const int CombinerEntityIdFieldNumber = 1;

		// Token: 0x0400304A RID: 12362
		private long combinerEntityId_;

		// Token: 0x0400304B RID: 12363
		public const int OffsetPosFieldNumber = 2;

		// Token: 0x0400304C RID: 12364
		private Vector offsetPos_;

		// Token: 0x0400304D RID: 12365
		public const int OffsetRotateFieldNumber = 3;

		// Token: 0x0400304E RID: 12366
		private Rotator offsetRotate_;

		// Token: 0x0400304F RID: 12367
		public const int PartIdFieldNumber = 4;

		// Token: 0x04003050 RID: 12368
		private int partId_;
	}
}
