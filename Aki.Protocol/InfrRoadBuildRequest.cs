using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007ED RID: 2029
	[NetMessage(EMessageId.InfrRoadBuildRequest)]
	public sealed class InfrRoadBuildRequest : IMessage<InfrRoadBuildRequest>, IMessage, IEquatable<InfrRoadBuildRequest>, IDeepCloneable<InfrRoadBuildRequest>, IBufferMessage
	{
		// Token: 0x0600B5F9 RID: 46585 RVA: 0x001B280D File Offset: 0x001B0A0D
		[NullableContext(1)]
		public static InfrRoadBuildRequest Create()
		{
			return new InfrRoadBuildRequest();
		}

		// Token: 0x170024B2 RID: 9394
		// (get) Token: 0x0600B5FA RID: 46586 RVA: 0x001B2814 File Offset: 0x001B0A14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170024B3 RID: 9395
		// (get) Token: 0x0600B5FB RID: 46587 RVA: 0x001B2817 File Offset: 0x001B0A17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrRoadBuildRequest.Descriptor;
			}
		}

		// Token: 0x0600B5FC RID: 46588 RVA: 0x001B281E File Offset: 0x001B0A1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrRoadBuildRequest()
		{
		}

		// Token: 0x0600B5FD RID: 46589 RVA: 0x001B2826 File Offset: 0x001B0A26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrRoadBuildRequest(InfrRoadBuildRequest other) : this()
		{
			this.roadId_ = other.roadId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B5FE RID: 46590 RVA: 0x001B284B File Offset: 0x001B0A4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrRoadBuildRequest Clone()
		{
			return new InfrRoadBuildRequest(this);
		}

		// Token: 0x170024B4 RID: 9396
		// (get) Token: 0x0600B5FF RID: 46591 RVA: 0x001B2853 File Offset: 0x001B0A53
		// (set) Token: 0x0600B600 RID: 46592 RVA: 0x001B285B File Offset: 0x001B0A5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoadId
		{
			get
			{
				return this.roadId_;
			}
			set
			{
				this.roadId_ = value;
			}
		}

		// Token: 0x0600B601 RID: 46593 RVA: 0x001B2864 File Offset: 0x001B0A64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrRoadBuildRequest);
		}

		// Token: 0x0600B602 RID: 46594 RVA: 0x001B2872 File Offset: 0x001B0A72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrRoadBuildRequest other)
		{
			return other != null && (other == this || (this.RoadId == other.RoadId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B603 RID: 46595 RVA: 0x001B28A0 File Offset: 0x001B0AA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoadId != 0)
			{
				num ^= this.RoadId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B604 RID: 46596 RVA: 0x001B28DF File Offset: 0x001B0ADF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B605 RID: 46597 RVA: 0x001B28EC File Offset: 0x001B0AEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B606 RID: 46598 RVA: 0x001B28F5 File Offset: 0x001B0AF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoadId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.RoadId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B607 RID: 46599 RVA: 0x001B2928 File Offset: 0x001B0B28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoadId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoadId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B608 RID: 46600 RVA: 0x001B2966 File Offset: 0x001B0B66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrRoadBuildRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoadId != 0)
			{
				this.RoadId = other.RoadId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B609 RID: 46601 RVA: 0x001B2997 File Offset: 0x001B0B97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B60A RID: 46602 RVA: 0x001B29A0 File Offset: 0x001B0BA0
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.RoadId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040050AC RID: 20652
		private UnknownFieldSet _unknownFields;

		// Token: 0x040050AD RID: 20653
		public const int RoadIdFieldNumber = 8;

		// Token: 0x040050AE RID: 20654
		private int roadId_;
	}
}
