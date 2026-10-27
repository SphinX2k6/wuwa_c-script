using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013DD RID: 5085
	[NetMessage(EMessageId.TrackMoonBuildFlowRequest)]
	public sealed class TrackMoonBuildFlowRequest : IMessage<TrackMoonBuildFlowRequest>, IMessage, IEquatable<TrackMoonBuildFlowRequest>, IDeepCloneable<TrackMoonBuildFlowRequest>, IBufferMessage
	{
		// Token: 0x0601AF5D RID: 110429 RVA: 0x003E80A5 File Offset: 0x003E62A5
		[NullableContext(1)]
		public static TrackMoonBuildFlowRequest Create()
		{
			return new TrackMoonBuildFlowRequest();
		}

		// Token: 0x17005AE5 RID: 23269
		// (get) Token: 0x0601AF5E RID: 110430 RVA: 0x003E80AC File Offset: 0x003E62AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005AE6 RID: 23270
		// (get) Token: 0x0601AF5F RID: 110431 RVA: 0x003E80AF File Offset: 0x003E62AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrackMoonBuildFlowRequest.Descriptor;
			}
		}

		// Token: 0x0601AF60 RID: 110432 RVA: 0x003E80B6 File Offset: 0x003E62B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonBuildFlowRequest()
		{
		}

		// Token: 0x0601AF61 RID: 110433 RVA: 0x003E80BE File Offset: 0x003E62BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonBuildFlowRequest(TrackMoonBuildFlowRequest other) : this()
		{
			this.buildingId_ = other.buildingId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AF62 RID: 110434 RVA: 0x003E80E3 File Offset: 0x003E62E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonBuildFlowRequest Clone()
		{
			return new TrackMoonBuildFlowRequest(this);
		}

		// Token: 0x17005AE7 RID: 23271
		// (get) Token: 0x0601AF63 RID: 110435 RVA: 0x003E80EB File Offset: 0x003E62EB
		// (set) Token: 0x0601AF64 RID: 110436 RVA: 0x003E80F3 File Offset: 0x003E62F3
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

		// Token: 0x0601AF65 RID: 110437 RVA: 0x003E80FC File Offset: 0x003E62FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrackMoonBuildFlowRequest);
		}

		// Token: 0x0601AF66 RID: 110438 RVA: 0x003E810A File Offset: 0x003E630A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrackMoonBuildFlowRequest other)
		{
			return other != null && (other == this || (this.BuildingId == other.BuildingId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AF67 RID: 110439 RVA: 0x003E8138 File Offset: 0x003E6338
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

		// Token: 0x0601AF68 RID: 110440 RVA: 0x003E8177 File Offset: 0x003E6377
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AF69 RID: 110441 RVA: 0x003E8184 File Offset: 0x003E6384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AF6A RID: 110442 RVA: 0x003E818D File Offset: 0x003E638D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BuildingId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.BuildingId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AF6B RID: 110443 RVA: 0x003E81C0 File Offset: 0x003E63C0
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

		// Token: 0x0601AF6C RID: 110444 RVA: 0x003E81FE File Offset: 0x003E63FE
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

		// Token: 0x0601AF6D RID: 110445 RVA: 0x003E822F File Offset: 0x003E642F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AF6E RID: 110446 RVA: 0x003E8238 File Offset: 0x003E6438
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.BuildingId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009C38 RID: 39992
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009C39 RID: 39993
		public const int BuildingIdFieldNumber = 9;

		// Token: 0x04009C3A RID: 39994
		private int buildingId_;
	}
}
