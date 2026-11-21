using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000994 RID: 2452
	[NetMessage(EMessageId.MapTravelTaskRewardRequest)]
	public sealed class MapTravelTaskRewardRequest : IMessage<MapTravelTaskRewardRequest>, IMessage, IEquatable<MapTravelTaskRewardRequest>, IDeepCloneable<MapTravelTaskRewardRequest>, IBufferMessage
	{
		// Token: 0x0600D7AB RID: 55211 RVA: 0x001FB69D File Offset: 0x001F989D
		[NullableContext(1)]
		public static MapTravelTaskRewardRequest Create()
		{
			return new MapTravelTaskRewardRequest();
		}

		// Token: 0x17002BA5 RID: 11173
		// (get) Token: 0x0600D7AC RID: 55212 RVA: 0x001FB6A4 File Offset: 0x001F98A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002BA6 RID: 11174
		// (get) Token: 0x0600D7AD RID: 55213 RVA: 0x001FB6A7 File Offset: 0x001F98A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MapTravelTaskRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600D7AE RID: 55214 RVA: 0x001FB6AE File Offset: 0x001F98AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTravelTaskRewardRequest()
		{
		}

		// Token: 0x0600D7AF RID: 55215 RVA: 0x001FB6B6 File Offset: 0x001F98B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTravelTaskRewardRequest(MapTravelTaskRewardRequest other) : this()
		{
			this.taskId_ = other.taskId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D7B0 RID: 55216 RVA: 0x001FB6DB File Offset: 0x001F98DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTravelTaskRewardRequest Clone()
		{
			return new MapTravelTaskRewardRequest(this);
		}

		// Token: 0x17002BA7 RID: 11175
		// (get) Token: 0x0600D7B1 RID: 55217 RVA: 0x001FB6E3 File Offset: 0x001F98E3
		// (set) Token: 0x0600D7B2 RID: 55218 RVA: 0x001FB6EB File Offset: 0x001F98EB
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

		// Token: 0x0600D7B3 RID: 55219 RVA: 0x001FB6F4 File Offset: 0x001F98F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MapTravelTaskRewardRequest);
		}

		// Token: 0x0600D7B4 RID: 55220 RVA: 0x001FB702 File Offset: 0x001F9902
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MapTravelTaskRewardRequest other)
		{
			return other != null && (other == this || (this.TaskId == other.TaskId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D7B5 RID: 55221 RVA: 0x001FB730 File Offset: 0x001F9930
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

		// Token: 0x0600D7B6 RID: 55222 RVA: 0x001FB76F File Offset: 0x001F996F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D7B7 RID: 55223 RVA: 0x001FB77C File Offset: 0x001F997C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D7B8 RID: 55224 RVA: 0x001FB785 File Offset: 0x001F9985
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

		// Token: 0x0600D7B9 RID: 55225 RVA: 0x001FB7B8 File Offset: 0x001F99B8
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

		// Token: 0x0600D7BA RID: 55226 RVA: 0x001FB7F6 File Offset: 0x001F99F6
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

		// Token: 0x0600D7BB RID: 55227 RVA: 0x001FB827 File Offset: 0x001F9A27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D7BC RID: 55228 RVA: 0x001FB830 File Offset: 0x001F9A30
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

		// Token: 0x04005A47 RID: 23111
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005A48 RID: 23112
		public const int TaskIdFieldNumber = 1;

		// Token: 0x04005A49 RID: 23113
		private int taskId_;
	}
}
