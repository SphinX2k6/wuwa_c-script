using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000014 RID: 20
	[NetMessage(EMessageId.AbyssChallengeGotoNextRoomRequest)]
	public sealed class AbyssChallengeGotoNextRoomRequest : IMessage<AbyssChallengeGotoNextRoomRequest>, IMessage, IEquatable<AbyssChallengeGotoNextRoomRequest>, IDeepCloneable<AbyssChallengeGotoNextRoomRequest>, IBufferMessage
	{
		// Token: 0x0600101C RID: 4124 RVA: 0x0002D2CC File Offset: 0x0002B4CC
		[NullableContext(1)]
		public static AbyssChallengeGotoNextRoomRequest Create()
		{
			return new AbyssChallengeGotoNextRoomRequest();
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600101D RID: 4125 RVA: 0x0002D2D3 File Offset: 0x0002B4D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600101E RID: 4126 RVA: 0x0002D2D6 File Offset: 0x0002B4D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssChallengeGotoNextRoomRequest.Descriptor;
			}
		}

		// Token: 0x0600101F RID: 4127 RVA: 0x0002D2DD File Offset: 0x0002B4DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeGotoNextRoomRequest()
		{
		}

		// Token: 0x06001020 RID: 4128 RVA: 0x0002D2E5 File Offset: 0x0002B4E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeGotoNextRoomRequest(AbyssChallengeGotoNextRoomRequest other) : this()
		{
			this.roomId_ = other.roomId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001021 RID: 4129 RVA: 0x0002D30A File Offset: 0x0002B50A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeGotoNextRoomRequest Clone()
		{
			return new AbyssChallengeGotoNextRoomRequest(this);
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06001022 RID: 4130 RVA: 0x0002D312 File Offset: 0x0002B512
		// (set) Token: 0x06001023 RID: 4131 RVA: 0x0002D31A File Offset: 0x0002B51A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoomId
		{
			get
			{
				return this.roomId_;
			}
			set
			{
				this.roomId_ = value;
			}
		}

		// Token: 0x06001024 RID: 4132 RVA: 0x0002D323 File Offset: 0x0002B523
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssChallengeGotoNextRoomRequest);
		}

		// Token: 0x06001025 RID: 4133 RVA: 0x0002D331 File Offset: 0x0002B531
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssChallengeGotoNextRoomRequest other)
		{
			return other != null && (other == this || (this.RoomId == other.RoomId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001026 RID: 4134 RVA: 0x0002D360 File Offset: 0x0002B560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoomId != 0)
			{
				num ^= this.RoomId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001027 RID: 4135 RVA: 0x0002D39F File Offset: 0x0002B59F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001028 RID: 4136 RVA: 0x0002D3AC File Offset: 0x0002B5AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001029 RID: 4137 RVA: 0x0002D3B5 File Offset: 0x0002B5B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoomId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.RoomId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600102A RID: 4138 RVA: 0x0002D3E8 File Offset: 0x0002B5E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoomId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoomId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600102B RID: 4139 RVA: 0x0002D426 File Offset: 0x0002B626
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AbyssChallengeGotoNextRoomRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoomId != 0)
			{
				this.RoomId = other.RoomId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600102C RID: 4140 RVA: 0x0002D457 File Offset: 0x0002B657
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600102D RID: 4141 RVA: 0x0002D460 File Offset: 0x0002B660
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.RoomId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04001F3C RID: 7996
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F3D RID: 7997
		public const int RoomIdFieldNumber = 14;

		// Token: 0x04001F3E RID: 7998
		private int roomId_;
	}
}
