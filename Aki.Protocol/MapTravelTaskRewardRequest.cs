using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009A5 RID: 2469
	[NetMessage(EMessageId.MapTravelTaskRewardRequest)]
	public sealed class MapTravelTaskRewardRequest : IMessage<MapTravelTaskRewardRequest>, IMessage, IEquatable<MapTravelTaskRewardRequest>, IDeepCloneable<MapTravelTaskRewardRequest>, IBufferMessage
	{
		// Token: 0x0600D8C5 RID: 55493 RVA: 0x001FD891 File Offset: 0x001FBA91
		[NullableContext(1)]
		public static MapTravelTaskRewardRequest Create()
		{
			return new MapTravelTaskRewardRequest();
		}

		// Token: 0x17002BE3 RID: 11235
		// (get) Token: 0x0600D8C6 RID: 55494 RVA: 0x001FD898 File Offset: 0x001FBA98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002BE4 RID: 11236
		// (get) Token: 0x0600D8C7 RID: 55495 RVA: 0x001FD89B File Offset: 0x001FBA9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MapTravelTaskRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600D8C8 RID: 55496 RVA: 0x001FD8A2 File Offset: 0x001FBAA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTravelTaskRewardRequest()
		{
		}

		// Token: 0x0600D8C9 RID: 55497 RVA: 0x001FD8AA File Offset: 0x001FBAAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTravelTaskRewardRequest(MapTravelTaskRewardRequest other) : this()
		{
			this.taskId_ = other.taskId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D8CA RID: 55498 RVA: 0x001FD8CF File Offset: 0x001FBACF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTravelTaskRewardRequest Clone()
		{
			return new MapTravelTaskRewardRequest(this);
		}

		// Token: 0x17002BE5 RID: 11237
		// (get) Token: 0x0600D8CB RID: 55499 RVA: 0x001FD8D7 File Offset: 0x001FBAD7
		// (set) Token: 0x0600D8CC RID: 55500 RVA: 0x001FD8DF File Offset: 0x001FBADF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TaskId
		{
			get
			{
				return this.taskId_;
			}
			set
			{
				this.taskId_ = value;
			}
		}

		// Token: 0x0600D8CD RID: 55501 RVA: 0x001FD8E8 File Offset: 0x001FBAE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MapTravelTaskRewardRequest);
		}

		// Token: 0x0600D8CE RID: 55502 RVA: 0x001FD8F6 File Offset: 0x001FBAF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MapTravelTaskRewardRequest other)
		{
			return other != null && (other == this || (this.TaskId == other.TaskId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D8CF RID: 55503 RVA: 0x001FD924 File Offset: 0x001FBB24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TaskId != 0)
			{
				num ^= this.TaskId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D8D0 RID: 55504 RVA: 0x001FD963 File Offset: 0x001FBB63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D8D1 RID: 55505 RVA: 0x001FD970 File Offset: 0x001FBB70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D8D2 RID: 55506 RVA: 0x001FD979 File Offset: 0x001FBB79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TaskId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TaskId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D8D3 RID: 55507 RVA: 0x001FD9AC File Offset: 0x001FBBAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TaskId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TaskId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D8D4 RID: 55508 RVA: 0x001FD9EA File Offset: 0x001FBBEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MapTravelTaskRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TaskId != 0)
			{
				this.TaskId = other.TaskId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D8D5 RID: 55509 RVA: 0x001FDA1B File Offset: 0x001FBC1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D8D6 RID: 55510 RVA: 0x001FDA24 File Offset: 0x001FBC24
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.TaskId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005A3E RID: 23102
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005A3F RID: 23103
		public const int TaskIdFieldNumber = 1;

		// Token: 0x04005A40 RID: 23104
		private int taskId_;
	}
}
