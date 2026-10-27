using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009A3 RID: 2467
	[NetMessage(EMessageId.MapTravelSoarRewardRequest)]
	public sealed class MapTravelSoarRewardRequest : IMessage<MapTravelSoarRewardRequest>, IMessage, IEquatable<MapTravelSoarRewardRequest>, IDeepCloneable<MapTravelSoarRewardRequest>, IBufferMessage
	{
		// Token: 0x0600D8A1 RID: 55457 RVA: 0x001FD4D9 File Offset: 0x001FB6D9
		[NullableContext(1)]
		public static MapTravelSoarRewardRequest Create()
		{
			return new MapTravelSoarRewardRequest();
		}

		// Token: 0x17002BDD RID: 11229
		// (get) Token: 0x0600D8A2 RID: 55458 RVA: 0x001FD4E0 File Offset: 0x001FB6E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002BDE RID: 11230
		// (get) Token: 0x0600D8A3 RID: 55459 RVA: 0x001FD4E3 File Offset: 0x001FB6E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MapTravelSoarRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600D8A4 RID: 55460 RVA: 0x001FD4EA File Offset: 0x001FB6EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTravelSoarRewardRequest()
		{
		}

		// Token: 0x0600D8A5 RID: 55461 RVA: 0x001FD4F2 File Offset: 0x001FB6F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTravelSoarRewardRequest(MapTravelSoarRewardRequest other) : this()
		{
			this.taskId_ = other.taskId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D8A6 RID: 55462 RVA: 0x001FD517 File Offset: 0x001FB717
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTravelSoarRewardRequest Clone()
		{
			return new MapTravelSoarRewardRequest(this);
		}

		// Token: 0x17002BDF RID: 11231
		// (get) Token: 0x0600D8A7 RID: 55463 RVA: 0x001FD51F File Offset: 0x001FB71F
		// (set) Token: 0x0600D8A8 RID: 55464 RVA: 0x001FD527 File Offset: 0x001FB727
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

		// Token: 0x0600D8A9 RID: 55465 RVA: 0x001FD530 File Offset: 0x001FB730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MapTravelSoarRewardRequest);
		}

		// Token: 0x0600D8AA RID: 55466 RVA: 0x001FD53E File Offset: 0x001FB73E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MapTravelSoarRewardRequest other)
		{
			return other != null && (other == this || (this.TaskId == other.TaskId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D8AB RID: 55467 RVA: 0x001FD56C File Offset: 0x001FB76C
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

		// Token: 0x0600D8AC RID: 55468 RVA: 0x001FD5AB File Offset: 0x001FB7AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D8AD RID: 55469 RVA: 0x001FD5B8 File Offset: 0x001FB7B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D8AE RID: 55470 RVA: 0x001FD5C1 File Offset: 0x001FB7C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TaskId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.TaskId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D8AF RID: 55471 RVA: 0x001FD5F4 File Offset: 0x001FB7F4
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

		// Token: 0x0600D8B0 RID: 55472 RVA: 0x001FD632 File Offset: 0x001FB832
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MapTravelSoarRewardRequest other)
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

		// Token: 0x0600D8B1 RID: 55473 RVA: 0x001FD663 File Offset: 0x001FB863
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D8B2 RID: 55474 RVA: 0x001FD66C File Offset: 0x001FB86C
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
					this.TaskId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005A38 RID: 23096
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005A39 RID: 23097
		public const int TaskIdFieldNumber = 9;

		// Token: 0x04005A3A RID: 23098
		private int taskId_;
	}
}
