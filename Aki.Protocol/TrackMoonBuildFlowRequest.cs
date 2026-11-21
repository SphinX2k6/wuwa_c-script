using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001450 RID: 5200
	[NetMessage(EMessageId.TrackMoonBuildFlowRequest)]
	public sealed class TrackMoonBuildFlowRequest : IMessage<TrackMoonBuildFlowRequest>, IMessage, IEquatable<TrackMoonBuildFlowRequest>, IDeepCloneable<TrackMoonBuildFlowRequest>, IBufferMessage
	{
		// Token: 0x0601B9E8 RID: 113128 RVA: 0x00403371 File Offset: 0x00401571
		[NullableContext(1)]
		public static TrackMoonBuildFlowRequest Create()
		{
			return new TrackMoonBuildFlowRequest();
		}

		// Token: 0x17005D7A RID: 23930
		// (get) Token: 0x0601B9E9 RID: 113129 RVA: 0x00403378 File Offset: 0x00401578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D7B RID: 23931
		// (get) Token: 0x0601B9EA RID: 113130 RVA: 0x0040337B File Offset: 0x0040157B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrackMoonBuildFlowRequest.Descriptor;
			}
		}

		// Token: 0x0601B9EB RID: 113131 RVA: 0x00403382 File Offset: 0x00401582
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonBuildFlowRequest()
		{
		}

		// Token: 0x0601B9EC RID: 113132 RVA: 0x0040338A File Offset: 0x0040158A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonBuildFlowRequest(TrackMoonBuildFlowRequest other) : this()
		{
			this.buildingId_ = other.buildingId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B9ED RID: 113133 RVA: 0x004033AF File Offset: 0x004015AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonBuildFlowRequest Clone()
		{
			return new TrackMoonBuildFlowRequest(this);
		}

		// Token: 0x17005D7C RID: 23932
		// (get) Token: 0x0601B9EE RID: 113134 RVA: 0x004033B7 File Offset: 0x004015B7
		// (set) Token: 0x0601B9EF RID: 113135 RVA: 0x004033BF File Offset: 0x004015BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BuildingId
		{
			get
			{
				return this.buildingId_;
			}
			set
			{
				this.buildingId_ = value;
			}
		}

		// Token: 0x0601B9F0 RID: 113136 RVA: 0x004033C8 File Offset: 0x004015C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrackMoonBuildFlowRequest);
		}

		// Token: 0x0601B9F1 RID: 113137 RVA: 0x004033D6 File Offset: 0x004015D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrackMoonBuildFlowRequest other)
		{
			return other != null && (other == this || (this.BuildingId == other.BuildingId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B9F2 RID: 113138 RVA: 0x00403404 File Offset: 0x00401604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BuildingId != 0)
			{
				num ^= this.BuildingId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B9F3 RID: 113139 RVA: 0x00403443 File Offset: 0x00401643
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B9F4 RID: 113140 RVA: 0x00403450 File Offset: 0x00401650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B9F5 RID: 113141 RVA: 0x00403459 File Offset: 0x00401659
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BuildingId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.BuildingId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B9F6 RID: 113142 RVA: 0x0040348C File Offset: 0x0040168C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BuildingId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BuildingId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B9F7 RID: 113143 RVA: 0x004034CA File Offset: 0x004016CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrackMoonBuildFlowRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BuildingId != 0)
			{
				this.BuildingId = other.BuildingId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B9F8 RID: 113144 RVA: 0x004034FB File Offset: 0x004016FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B9F9 RID: 113145 RVA: 0x00403504 File Offset: 0x00401704
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
					this.BuildingId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A07F RID: 41087
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A080 RID: 41088
		public const int BuildingIdFieldNumber = 8;

		// Token: 0x0400A081 RID: 41089
		private int buildingId_;
	}
}
