using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000992 RID: 2450
	[NetMessage(EMessageId.MapTravelSoarRewardRequest)]
	public sealed class MapTravelSoarRewardRequest : IMessage<MapTravelSoarRewardRequest>, IMessage, IEquatable<MapTravelSoarRewardRequest>, IDeepCloneable<MapTravelSoarRewardRequest>, IBufferMessage
	{
		// Token: 0x0600D787 RID: 55175 RVA: 0x001FB2E5 File Offset: 0x001F94E5
		[NullableContext(1)]
		public static MapTravelSoarRewardRequest Create()
		{
			return new MapTravelSoarRewardRequest();
		}

		// Token: 0x17002B9F RID: 11167
		// (get) Token: 0x0600D788 RID: 55176 RVA: 0x001FB2EC File Offset: 0x001F94EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002BA0 RID: 11168
		// (get) Token: 0x0600D789 RID: 55177 RVA: 0x001FB2EF File Offset: 0x001F94EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MapTravelSoarRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600D78A RID: 55178 RVA: 0x001FB2F6 File Offset: 0x001F94F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTravelSoarRewardRequest()
		{
		}

		// Token: 0x0600D78B RID: 55179 RVA: 0x001FB2FE File Offset: 0x001F94FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTravelSoarRewardRequest(MapTravelSoarRewardRequest other) : this()
		{
			this.taskId_ = other.taskId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D78C RID: 55180 RVA: 0x001FB323 File Offset: 0x001F9523
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTravelSoarRewardRequest Clone()
		{
			return new MapTravelSoarRewardRequest(this);
		}

		// Token: 0x17002BA1 RID: 11169
		// (get) Token: 0x0600D78D RID: 55181 RVA: 0x001FB32B File Offset: 0x001F952B
		// (set) Token: 0x0600D78E RID: 55182 RVA: 0x001FB333 File Offset: 0x001F9533
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

		// Token: 0x0600D78F RID: 55183 RVA: 0x001FB33C File Offset: 0x001F953C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MapTravelSoarRewardRequest);
		}

		// Token: 0x0600D790 RID: 55184 RVA: 0x001FB34A File Offset: 0x001F954A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MapTravelSoarRewardRequest other)
		{
			return other != null && (other == this || (this.TaskId == other.TaskId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D791 RID: 55185 RVA: 0x001FB378 File Offset: 0x001F9578
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

		// Token: 0x0600D792 RID: 55186 RVA: 0x001FB3B7 File Offset: 0x001F95B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D793 RID: 55187 RVA: 0x001FB3C4 File Offset: 0x001F95C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D794 RID: 55188 RVA: 0x001FB3CD File Offset: 0x001F95CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TaskId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.TaskId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D795 RID: 55189 RVA: 0x001FB400 File Offset: 0x001F9600
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

		// Token: 0x0600D796 RID: 55190 RVA: 0x001FB43E File Offset: 0x001F963E
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

		// Token: 0x0600D797 RID: 55191 RVA: 0x001FB46F File Offset: 0x001F966F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D798 RID: 55192 RVA: 0x001FB478 File Offset: 0x001F9678
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.TaskId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005A41 RID: 23105
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005A42 RID: 23106
		public const int TaskIdFieldNumber = 3;

		// Token: 0x04005A43 RID: 23107
		private int taskId_;
	}
}
