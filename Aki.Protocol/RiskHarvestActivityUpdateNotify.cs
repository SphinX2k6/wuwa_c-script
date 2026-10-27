using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F54 RID: 3924
	[NetMessage(EMessageId.RiskHarvestActivityUpdateNotify)]
	public sealed class RiskHarvestActivityUpdateNotify : IMessage<RiskHarvestActivityUpdateNotify>, IMessage, IEquatable<RiskHarvestActivityUpdateNotify>, IDeepCloneable<RiskHarvestActivityUpdateNotify>, IBufferMessage
	{
		// Token: 0x06014FDE RID: 85982 RVA: 0x0030BACE File Offset: 0x00309CCE
		[NullableContext(1)]
		public static RiskHarvestActivityUpdateNotify Create()
		{
			return new RiskHarvestActivityUpdateNotify();
		}

		// Token: 0x170045D5 RID: 17877
		// (get) Token: 0x06014FDF RID: 85983 RVA: 0x0030BAD5 File Offset: 0x00309CD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170045D6 RID: 17878
		// (get) Token: 0x06014FE0 RID: 85984 RVA: 0x0030BAD8 File Offset: 0x00309CD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RiskHarvestActivityUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06014FE1 RID: 85985 RVA: 0x0030BADF File Offset: 0x00309CDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestActivityUpdateNotify()
		{
		}

		// Token: 0x06014FE2 RID: 85986 RVA: 0x0030BAE7 File Offset: 0x00309CE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestActivityUpdateNotify(RiskHarvestActivityUpdateNotify other) : this()
		{
			this.activityInfo_ = ((other.activityInfo_ != null) ? other.activityInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014FE3 RID: 85987 RVA: 0x0030BB1C File Offset: 0x00309D1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestActivityUpdateNotify Clone()
		{
			return new RiskHarvestActivityUpdateNotify(this);
		}

		// Token: 0x170045D7 RID: 17879
		// (get) Token: 0x06014FE4 RID: 85988 RVA: 0x0030BB24 File Offset: 0x00309D24
		// (set) Token: 0x06014FE5 RID: 85989 RVA: 0x0030BB2C File Offset: 0x00309D2C
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

		// Token: 0x06014FE6 RID: 85990 RVA: 0x0030BB35 File Offset: 0x00309D35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RiskHarvestActivityUpdateNotify);
		}

		// Token: 0x06014FE7 RID: 85991 RVA: 0x0030BB43 File Offset: 0x00309D43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RiskHarvestActivityUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.ActivityInfo, other.ActivityInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014FE8 RID: 85992 RVA: 0x0030BB78 File Offset: 0x00309D78
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

		// Token: 0x06014FE9 RID: 85993 RVA: 0x0030BBB4 File Offset: 0x00309DB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014FEA RID: 85994 RVA: 0x0030BBC1 File Offset: 0x00309DC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014FEB RID: 85995 RVA: 0x0030BBCA File Offset: 0x00309DCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.activityInfo_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.ActivityInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014FEC RID: 85996 RVA: 0x0030BBFC File Offset: 0x00309DFC
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

		// Token: 0x06014FED RID: 85997 RVA: 0x0030BC3C File Offset: 0x00309E3C
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

		// Token: 0x06014FEE RID: 85998 RVA: 0x0030BC90 File Offset: 0x00309E90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014FEF RID: 85999 RVA: 0x0030BC9C File Offset: 0x00309E9C
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
					if (this.activityInfo_ == null)
					{
						this.ActivityInfo = new RiskHarvestActivityInfo();
					}
					input.ReadMessage(this.ActivityInfo);
				}
			}
		}

		// Token: 0x04007E8D RID: 32397
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007E8E RID: 32398
		public const int ActivityInfoFieldNumber = 11;

		// Token: 0x04007E8F RID: 32399
		private RiskHarvestActivityInfo activityInfo_;
	}
}
