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
		// Token: 0x06000FF1 RID: 4081 RVA: 0x0002CD1C File Offset: 0x0002AF1C
		[NullableContext(1)]
		public static AbyssChallengeGotoNextRoomRequest Create()
		{
			return new AbyssChallengeGotoNextRoomRequest();
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000FF2 RID: 4082 RVA: 0x0002CD23 File Offset: 0x0002AF23
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
		// (get) Token: 0x06000FF3 RID: 4083 RVA: 0x0002CD26 File Offset: 0x0002AF26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssChallengeGotoNextRoomRequest.Descriptor;
			}
		}

		// Token: 0x06000FF4 RID: 4084 RVA: 0x0002CD2D File Offset: 0x0002AF2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeGotoNextRoomRequest()
		{
		}

		// Token: 0x06000FF5 RID: 4085 RVA: 0x0002CD35 File Offset: 0x0002AF35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeGotoNextRoomRequest(AbyssChallengeGotoNextRoomRequest other) : this()
		{
			this.roomId_ = other.roomId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000FF6 RID: 4086 RVA: 0x0002CD5A File Offset: 0x0002AF5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeGotoNextRoomRequest Clone()
		{
			return new AbyssChallengeGotoNextRoomRequest(this);
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000FF7 RID: 4087 RVA: 0x0002CD62 File Offset: 0x0002AF62
		// (set) Token: 0x06000FF8 RID: 4088 RVA: 0x0002CD6A File Offset: 0x0002AF6A
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

		// Token: 0x06000FF9 RID: 4089 RVA: 0x0002CD73 File Offset: 0x0002AF73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssChallengeGotoNextRoomRequest);
		}

		// Token: 0x06000FFA RID: 4090 RVA: 0x0002CD81 File Offset: 0x0002AF81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssChallengeGotoNextRoomRequest other)
		{
			return other != null && (other == this || (this.RoomId == other.RoomId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000FFB RID: 4091 RVA: 0x0002CDB0 File Offset: 0x0002AFB0
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

		// Token: 0x06000FFC RID: 4092 RVA: 0x0002CDEF File Offset: 0x0002AFEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06000FFD RID: 4093 RVA: 0x0002CDFC File Offset: 0x0002AFFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000FFE RID: 4094 RVA: 0x0002CE05 File Offset: 0x0002B005
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoomId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.RoomId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000FFF RID: 4095 RVA: 0x0002CE38 File Offset: 0x0002B038
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

		// Token: 0x06001000 RID: 4096 RVA: 0x0002CE76 File Offset: 0x0002B076
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

		// Token: 0x06001001 RID: 4097 RVA: 0x0002CEA7 File Offset: 0x0002B0A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001002 RID: 4098 RVA: 0x0002CEB0 File Offset: 0x0002B0B0
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.RoomId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04001EE6 RID: 7910
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001EE7 RID: 7911
		public const int RoomIdFieldNumber = 6;

		// Token: 0x04001EE8 RID: 7912
		private int roomId_;
	}
}
