using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001446 RID: 5190
	[NetMessage(EMessageId.TraceMoonPhaseRewardRequest)]
	public sealed class TraceMoonPhaseRewardRequest : IMessage<TraceMoonPhaseRewardRequest>, IMessage, IEquatable<TraceMoonPhaseRewardRequest>, IDeepCloneable<TraceMoonPhaseRewardRequest>, IBufferMessage
	{
		// Token: 0x0601B92A RID: 112938 RVA: 0x00401D3C File Offset: 0x003FFF3C
		[NullableContext(1)]
		public static TraceMoonPhaseRewardRequest Create()
		{
			return new TraceMoonPhaseRewardRequest();
		}

		// Token: 0x17005D57 RID: 23895
		// (get) Token: 0x0601B92B RID: 112939 RVA: 0x00401D43 File Offset: 0x003FFF43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D58 RID: 23896
		// (get) Token: 0x0601B92C RID: 112940 RVA: 0x00401D46 File Offset: 0x003FFF46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TraceMoonPhaseRewardRequest.Descriptor;
			}
		}

		// Token: 0x0601B92D RID: 112941 RVA: 0x00401D4D File Offset: 0x003FFF4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TraceMoonPhaseRewardRequest()
		{
		}

		// Token: 0x0601B92E RID: 112942 RVA: 0x00401D55 File Offset: 0x003FFF55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TraceMoonPhaseRewardRequest(TraceMoonPhaseRewardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B92F RID: 112943 RVA: 0x00401D7A File Offset: 0x003FFF7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TraceMoonPhaseRewardRequest Clone()
		{
			return new TraceMoonPhaseRewardRequest(this);
		}

		// Token: 0x17005D59 RID: 23897
		// (get) Token: 0x0601B930 RID: 112944 RVA: 0x00401D82 File Offset: 0x003FFF82
		// (set) Token: 0x0601B931 RID: 112945 RVA: 0x00401D8A File Offset: 0x003FFF8A
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

		// Token: 0x0601B932 RID: 112946 RVA: 0x00401D93 File Offset: 0x003FFF93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TraceMoonPhaseRewardRequest);
		}

		// Token: 0x0601B933 RID: 112947 RVA: 0x00401DA1 File Offset: 0x003FFFA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TraceMoonPhaseRewardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B934 RID: 112948 RVA: 0x00401DD0 File Offset: 0x003FFFD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x0601B935 RID: 112949 RVA: 0x00401E0F File Offset: 0x0040000F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B936 RID: 112950 RVA: 0x00401E1C File Offset: 0x0040001C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B937 RID: 112951 RVA: 0x00401E25 File Offset: 0x00400025
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B938 RID: 112952 RVA: 0x00401E58 File Offset: 0x00400058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x0601B939 RID: 112953 RVA: 0x00401E96 File Offset: 0x00400096
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TraceMoonPhaseRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B93A RID: 112954 RVA: 0x00401EC7 File Offset: 0x004000C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B93B RID: 112955 RVA: 0x00401ED0 File Offset: 0x004000D0
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A057 RID: 41047
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A058 RID: 41048
		public const int ActivityIdFieldNumber = 10;

		// Token: 0x0400A059 RID: 41049
		private int activityId_;
	}
}
