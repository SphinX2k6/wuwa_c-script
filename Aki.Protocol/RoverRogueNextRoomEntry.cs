using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200114D RID: 4429
	public sealed class RoverRogueNextRoomEntry : IMessage<RoverRogueNextRoomEntry>, IMessage, IEquatable<RoverRogueNextRoomEntry>, IDeepCloneable<RoverRogueNextRoomEntry>, IBufferMessage
	{
		// Token: 0x06017AA1 RID: 96929 RVA: 0x00371BA4 File Offset: 0x0036FDA4
		[NullableContext(1)]
		public static RoverRogueNextRoomEntry Create()
		{
			return new RoverRogueNextRoomEntry();
		}

		// Token: 0x17004F9B RID: 20379
		// (get) Token: 0x06017AA2 RID: 96930 RVA: 0x00371BAB File Offset: 0x0036FDAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoverRogueNextRoomEntry> Parser
		{
			get
			{
				return RoverRogueNextRoomEntry._parser;
			}
		}

		// Token: 0x17004F9C RID: 20380
		// (get) Token: 0x06017AA3 RID: 96931 RVA: 0x00371BB2 File Offset: 0x0036FDB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004F9D RID: 20381
		// (get) Token: 0x06017AA4 RID: 96932 RVA: 0x00371BB5 File Offset: 0x0036FDB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueNextRoomEntry.Descriptor;
			}
		}

		// Token: 0x06017AA5 RID: 96933 RVA: 0x00371BBC File Offset: 0x0036FDBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueNextRoomEntry()
		{
		}

		// Token: 0x06017AA6 RID: 96934 RVA: 0x00371BC4 File Offset: 0x0036FDC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueNextRoomEntry(RoverRogueNextRoomEntry other) : this()
		{
			this.roomTypeId_ = other.roomTypeId_;
			this.roomId_ = other.roomId_;
			this.entityIncId_ = other.entityIncId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017AA7 RID: 96935 RVA: 0x00371C01 File Offset: 0x0036FE01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueNextRoomEntry Clone()
		{
			return new RoverRogueNextRoomEntry(this);
		}

		// Token: 0x17004F9E RID: 20382
		// (get) Token: 0x06017AA8 RID: 96936 RVA: 0x00371C09 File Offset: 0x0036FE09
		// (set) Token: 0x06017AA9 RID: 96937 RVA: 0x00371C11 File Offset: 0x0036FE11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoomTypeId
		{
			get
			{
				return this.roomTypeId_;
			}
			set
			{
				this.roomTypeId_ = value;
			}
		}

		// Token: 0x17004F9F RID: 20383
		// (get) Token: 0x06017AAA RID: 96938 RVA: 0x00371C1A File Offset: 0x0036FE1A
		// (set) Token: 0x06017AAB RID: 96939 RVA: 0x00371C22 File Offset: 0x0036FE22
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

		// Token: 0x17004FA0 RID: 20384
		// (get) Token: 0x06017AAC RID: 96940 RVA: 0x00371C2B File Offset: 0x0036FE2B
		// (set) Token: 0x06017AAD RID: 96941 RVA: 0x00371C33 File Offset: 0x0036FE33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityIncId
		{
			get
			{
				return this.entityIncId_;
			}
			set
			{
				this.entityIncId_ = value;
			}
		}

		// Token: 0x06017AAE RID: 96942 RVA: 0x00371C3C File Offset: 0x0036FE3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueNextRoomEntry);
		}

		// Token: 0x06017AAF RID: 96943 RVA: 0x00371C4C File Offset: 0x0036FE4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueNextRoomEntry other)
		{
			return other != null && (other == this || (this.RoomTypeId == other.RoomTypeId && this.RoomId == other.RoomId && this.EntityIncId == other.EntityIncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017AB0 RID: 96944 RVA: 0x00371CA8 File Offset: 0x0036FEA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoomTypeId != 0)
			{
				num ^= this.RoomTypeId.GetHashCode();
			}
			if (this.RoomId != 0)
			{
				num ^= this.RoomId.GetHashCode();
			}
			if (this.EntityIncId != 0L)
			{
				num ^= this.EntityIncId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017AB1 RID: 96945 RVA: 0x00371D19 File Offset: 0x0036FF19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017AB2 RID: 96946 RVA: 0x00371D26 File Offset: 0x0036FF26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017AB3 RID: 96947 RVA: 0x00371D30 File Offset: 0x0036FF30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoomTypeId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoomTypeId);
			}
			if (this.RoomId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.RoomId);
			}
			if (this.EntityIncId != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.EntityIncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017AB4 RID: 96948 RVA: 0x00371DA4 File Offset: 0x0036FFA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoomTypeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoomTypeId);
			}
			if (this.RoomId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoomId);
			}
			if (this.EntityIncId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityIncId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017AB5 RID: 96949 RVA: 0x00371E14 File Offset: 0x00370014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueNextRoomEntry other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoomTypeId != 0)
			{
				this.RoomTypeId = other.RoomTypeId;
			}
			if (other.RoomId != 0)
			{
				this.RoomId = other.RoomId;
			}
			if (other.EntityIncId != 0L)
			{
				this.EntityIncId = other.EntityIncId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017AB6 RID: 96950 RVA: 0x00371E78 File Offset: 0x00370078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017AB7 RID: 96951 RVA: 0x00371E84 File Offset: 0x00370084
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
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.EntityIncId = input.ReadInt64();
						}
					}
					else
					{
						this.RoomId = input.ReadInt32();
					}
				}
				else
				{
					this.RoomTypeId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008D3A RID: 36154
		private static readonly MessageParser<RoverRogueNextRoomEntry> _parser = new MessageParser<RoverRogueNextRoomEntry>(() => new RoverRogueNextRoomEntry());

		// Token: 0x04008D3B RID: 36155
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008D3C RID: 36156
		public const int RoomTypeIdFieldNumber = 1;

		// Token: 0x04008D3D RID: 36157
		private int roomTypeId_;

		// Token: 0x04008D3E RID: 36158
		public const int RoomIdFieldNumber = 2;

		// Token: 0x04008D3F RID: 36159
		private int roomId_;

		// Token: 0x04008D40 RID: 36160
		public const int EntityIncIdFieldNumber = 3;

		// Token: 0x04008D41 RID: 36161
		private long entityIncId_;
	}
}
