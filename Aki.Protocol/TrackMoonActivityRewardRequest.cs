using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013DB RID: 5083
	[NetMessage(EMessageId.TrackMoonActivityRewardRequest)]
	public sealed class TrackMoonActivityRewardRequest : IMessage<TrackMoonActivityRewardRequest>, IMessage, IEquatable<TrackMoonActivityRewardRequest>, IDeepCloneable<TrackMoonActivityRewardRequest>, IBufferMessage
	{
		// Token: 0x0601AF37 RID: 110391 RVA: 0x003E7C29 File Offset: 0x003E5E29
		[NullableContext(1)]
		public static TrackMoonActivityRewardRequest Create()
		{
			return new TrackMoonActivityRewardRequest();
		}

		// Token: 0x17005ADE RID: 23262
		// (get) Token: 0x0601AF38 RID: 110392 RVA: 0x003E7C30 File Offset: 0x003E5E30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005ADF RID: 23263
		// (get) Token: 0x0601AF39 RID: 110393 RVA: 0x003E7C33 File Offset: 0x003E5E33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrackMoonActivityRewardRequest.Descriptor;
			}
		}

		// Token: 0x0601AF3A RID: 110394 RVA: 0x003E7C3A File Offset: 0x003E5E3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonActivityRewardRequest()
		{
		}

		// Token: 0x0601AF3B RID: 110395 RVA: 0x003E7C42 File Offset: 0x003E5E42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonActivityRewardRequest(TrackMoonActivityRewardRequest other) : this()
		{
			this.id_ = other.id_;
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AF3C RID: 110396 RVA: 0x003E7C73 File Offset: 0x003E5E73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonActivityRewardRequest Clone()
		{
			return new TrackMoonActivityRewardRequest(this);
		}

		// Token: 0x17005AE0 RID: 23264
		// (get) Token: 0x0601AF3D RID: 110397 RVA: 0x003E7C7B File Offset: 0x003E5E7B
		// (set) Token: 0x0601AF3E RID: 110398 RVA: 0x003E7C83 File Offset: 0x003E5E83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17005AE1 RID: 23265
		// (get) Token: 0x0601AF3F RID: 110399 RVA: 0x003E7C8C File Offset: 0x003E5E8C
		// (set) Token: 0x0601AF40 RID: 110400 RVA: 0x003E7C94 File Offset: 0x003E5E94
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

		// Token: 0x0601AF41 RID: 110401 RVA: 0x003E7C9D File Offset: 0x003E5E9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrackMoonActivityRewardRequest);
		}

		// Token: 0x0601AF42 RID: 110402 RVA: 0x003E7CAB File Offset: 0x003E5EAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrackMoonActivityRewardRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AF43 RID: 110403 RVA: 0x003E7CEC File Offset: 0x003E5EEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601AF44 RID: 110404 RVA: 0x003E7D44 File Offset: 0x003E5F44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AF45 RID: 110405 RVA: 0x003E7D51 File Offset: 0x003E5F51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AF46 RID: 110406 RVA: 0x003E7D5C File Offset: 0x003E5F5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.ActivityId);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AF47 RID: 110407 RVA: 0x003E7DB8 File Offset: 0x003E5FB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601AF48 RID: 110408 RVA: 0x003E7E10 File Offset: 0x003E6010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrackMoonActivityRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601AF49 RID: 110409 RVA: 0x003E7E60 File Offset: 0x003E6060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AF4A RID: 110410 RVA: 0x003E7E6C File Offset: 0x003E606C
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
				if (num != 56U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Id = input.ReadInt32();
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009C30 RID: 39984
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009C31 RID: 39985
		public const int IdFieldNumber = 11;

		// Token: 0x04009C32 RID: 39986
		private int id_;

		// Token: 0x04009C33 RID: 39987
		public const int ActivityIdFieldNumber = 7;

		// Token: 0x04009C34 RID: 39988
		private int activityId_;
	}
}
