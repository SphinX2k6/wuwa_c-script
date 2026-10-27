using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005EC RID: 1516
	[NetMessage(EMessageId.FloroRanchUnlockTechPointRequest)]
	public sealed class FloroRanchUnlockTechPointRequest : IMessage<FloroRanchUnlockTechPointRequest>, IMessage, IEquatable<FloroRanchUnlockTechPointRequest>, IDeepCloneable<FloroRanchUnlockTechPointRequest>, IBufferMessage
	{
		// Token: 0x06008C62 RID: 35938 RVA: 0x001544A5 File Offset: 0x001526A5
		[NullableContext(1)]
		public static FloroRanchUnlockTechPointRequest Create()
		{
			return new FloroRanchUnlockTechPointRequest();
		}

		// Token: 0x17001BCC RID: 7116
		// (get) Token: 0x06008C63 RID: 35939 RVA: 0x001544AC File Offset: 0x001526AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001BCD RID: 7117
		// (get) Token: 0x06008C64 RID: 35940 RVA: 0x001544AF File Offset: 0x001526AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchUnlockTechPointRequest.Descriptor;
			}
		}

		// Token: 0x06008C65 RID: 35941 RVA: 0x001544B6 File Offset: 0x001526B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchUnlockTechPointRequest()
		{
		}

		// Token: 0x06008C66 RID: 35942 RVA: 0x001544BE File Offset: 0x001526BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchUnlockTechPointRequest(FloroRanchUnlockTechPointRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.techPoint_ = other.techPoint_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008C67 RID: 35943 RVA: 0x001544EF File Offset: 0x001526EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchUnlockTechPointRequest Clone()
		{
			return new FloroRanchUnlockTechPointRequest(this);
		}

		// Token: 0x17001BCE RID: 7118
		// (get) Token: 0x06008C68 RID: 35944 RVA: 0x001544F7 File Offset: 0x001526F7
		// (set) Token: 0x06008C69 RID: 35945 RVA: 0x001544FF File Offset: 0x001526FF
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

		// Token: 0x17001BCF RID: 7119
		// (get) Token: 0x06008C6A RID: 35946 RVA: 0x00154508 File Offset: 0x00152708
		// (set) Token: 0x06008C6B RID: 35947 RVA: 0x00154510 File Offset: 0x00152710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TechPoint
		{
			get
			{
				return this.techPoint_;
			}
			set
			{
				this.techPoint_ = value;
			}
		}

		// Token: 0x06008C6C RID: 35948 RVA: 0x00154519 File Offset: 0x00152719
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchUnlockTechPointRequest);
		}

		// Token: 0x06008C6D RID: 35949 RVA: 0x00154527 File Offset: 0x00152727
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchUnlockTechPointRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.TechPoint == other.TechPoint && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008C6E RID: 35950 RVA: 0x00154568 File Offset: 0x00152768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.TechPoint != 0)
			{
				num ^= this.TechPoint.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008C6F RID: 35951 RVA: 0x001545C0 File Offset: 0x001527C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008C70 RID: 35952 RVA: 0x001545CD File Offset: 0x001527CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008C71 RID: 35953 RVA: 0x001545D8 File Offset: 0x001527D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TechPoint != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.TechPoint);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008C72 RID: 35954 RVA: 0x00154634 File Offset: 0x00152834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.TechPoint != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TechPoint);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008C73 RID: 35955 RVA: 0x0015468C File Offset: 0x0015288C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchUnlockTechPointRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.TechPoint != 0)
			{
				this.TechPoint = other.TechPoint;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008C74 RID: 35956 RVA: 0x001546DC File Offset: 0x001528DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008C75 RID: 35957 RVA: 0x001546E8 File Offset: 0x001528E8
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
				if (num != 24U)
				{
					if (num != 48U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ActivityId = input.ReadInt32();
					}
				}
				else
				{
					this.TechPoint = input.ReadInt32();
				}
			}
		}

		// Token: 0x040044BD RID: 17597
		private UnknownFieldSet _unknownFields;

		// Token: 0x040044BE RID: 17598
		public const int ActivityIdFieldNumber = 6;

		// Token: 0x040044BF RID: 17599
		private int activityId_;

		// Token: 0x040044C0 RID: 17600
		public const int TechPointFieldNumber = 3;

		// Token: 0x040044C1 RID: 17601
		private int techPoint_;
	}
}
