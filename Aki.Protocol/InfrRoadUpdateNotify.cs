using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007DC RID: 2012
	[NetMessage(EMessageId.InfrRoadUpdateNotify)]
	public sealed class InfrRoadUpdateNotify : IMessage<InfrRoadUpdateNotify>, IMessage, IEquatable<InfrRoadUpdateNotify>, IDeepCloneable<InfrRoadUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600B4DE RID: 46302 RVA: 0x001B058B File Offset: 0x001AE78B
		[NullableContext(1)]
		public static InfrRoadUpdateNotify Create()
		{
			return new InfrRoadUpdateNotify();
		}

		// Token: 0x17002474 RID: 9332
		// (get) Token: 0x0600B4DF RID: 46303 RVA: 0x001B0592 File Offset: 0x001AE792
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002475 RID: 9333
		// (get) Token: 0x0600B4E0 RID: 46304 RVA: 0x001B0595 File Offset: 0x001AE795
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrRoadUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600B4E1 RID: 46305 RVA: 0x001B059C File Offset: 0x001AE79C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrRoadUpdateNotify()
		{
		}

		// Token: 0x0600B4E2 RID: 46306 RVA: 0x001B05A4 File Offset: 0x001AE7A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrRoadUpdateNotify(InfrRoadUpdateNotify other) : this()
		{
			this.roadInfo_ = ((other.roadInfo_ != null) ? other.roadInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B4E3 RID: 46307 RVA: 0x001B05D9 File Offset: 0x001AE7D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrRoadUpdateNotify Clone()
		{
			return new InfrRoadUpdateNotify(this);
		}

		// Token: 0x17002476 RID: 9334
		// (get) Token: 0x0600B4E4 RID: 46308 RVA: 0x001B05E1 File Offset: 0x001AE7E1
		// (set) Token: 0x0600B4E5 RID: 46309 RVA: 0x001B05E9 File Offset: 0x001AE7E9
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

		// Token: 0x0600B4E6 RID: 46310 RVA: 0x001B05F2 File Offset: 0x001AE7F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrRoadUpdateNotify);
		}

		// Token: 0x0600B4E7 RID: 46311 RVA: 0x001B0600 File Offset: 0x001AE800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrRoadUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.RoadInfo, other.RoadInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B4E8 RID: 46312 RVA: 0x001B0634 File Offset: 0x001AE834
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

		// Token: 0x0600B4E9 RID: 46313 RVA: 0x001B0670 File Offset: 0x001AE870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B4EA RID: 46314 RVA: 0x001B067D File Offset: 0x001AE87D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B4EB RID: 46315 RVA: 0x001B0686 File Offset: 0x001AE886
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.roadInfo_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.RoadInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B4EC RID: 46316 RVA: 0x001B06B8 File Offset: 0x001AE8B8
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

		// Token: 0x0600B4ED RID: 46317 RVA: 0x001B06F8 File Offset: 0x001AE8F8
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

		// Token: 0x0600B4EE RID: 46318 RVA: 0x001B074C File Offset: 0x001AE94C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B4EF RID: 46319 RVA: 0x001B0758 File Offset: 0x001AE958
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
				if (num != 106U)
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

		// Token: 0x040050B6 RID: 20662
		private UnknownFieldSet _unknownFields;

		// Token: 0x040050B7 RID: 20663
		public const int RoadInfoFieldNumber = 13;

		// Token: 0x040050B8 RID: 20664
		private InfrRoadPb roadInfo_;
	}
}
