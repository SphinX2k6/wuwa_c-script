using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001113 RID: 4371
	public sealed class RoverRogueNextRoomEntry : IMessage<RoverRogueNextRoomEntry>, IMessage, IEquatable<RoverRogueNextRoomEntry>, IDeepCloneable<RoverRogueNextRoomEntry>, IBufferMessage
	{
		// Token: 0x06017500 RID: 95488 RVA: 0x00362858 File Offset: 0x00360A58
		[NullableContext(1)]
		public static RoverRogueNextRoomEntry Create()
		{
			return new RoverRogueNextRoomEntry();
		}

		// Token: 0x17004E2F RID: 20015
		// (get) Token: 0x06017501 RID: 95489 RVA: 0x0036285F File Offset: 0x00360A5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoverRogueNextRoomEntry> Parser
		{
			get
			{
				return RoverRogueNextRoomEntry._parser;
			}
		}

		// Token: 0x17004E30 RID: 20016
		// (get) Token: 0x06017502 RID: 95490 RVA: 0x00362866 File Offset: 0x00360A66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004E31 RID: 20017
		// (get) Token: 0x06017503 RID: 95491 RVA: 0x00362869 File Offset: 0x00360A69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueNextRoomEntry.Descriptor;
			}
		}

		// Token: 0x06017504 RID: 95492 RVA: 0x00362870 File Offset: 0x00360A70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueNextRoomEntry()
		{
		}

		// Token: 0x06017505 RID: 95493 RVA: 0x00362878 File Offset: 0x00360A78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueNextRoomEntry(RoverRogueNextRoomEntry other) : this()
		{
			this.roomTypeId_ = other.roomTypeId_;
			this.roomId_ = other.roomId_;
			this.entityIncId_ = other.entityIncId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017506 RID: 95494 RVA: 0x003628B5 File Offset: 0x00360AB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueNextRoomEntry Clone()
		{
			return new RoverRogueNextRoomEntry(this);
		}

		// Token: 0x17004E32 RID: 20018
		// (get) Token: 0x06017507 RID: 95495 RVA: 0x003628BD File Offset: 0x00360ABD
		// (set) Token: 0x06017508 RID: 95496 RVA: 0x003628C5 File Offset: 0x00360AC5
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

		// Token: 0x17004E33 RID: 20019
		// (get) Token: 0x06017509 RID: 95497 RVA: 0x003628CE File Offset: 0x00360ACE
		// (set) Token: 0x0601750A RID: 95498 RVA: 0x003628D6 File Offset: 0x00360AD6
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

		// Token: 0x17004E34 RID: 20020
		// (get) Token: 0x0601750B RID: 95499 RVA: 0x003628DF File Offset: 0x00360ADF
		// (set) Token: 0x0601750C RID: 95500 RVA: 0x003628E7 File Offset: 0x00360AE7
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

		// Token: 0x0601750D RID: 95501 RVA: 0x003628F0 File Offset: 0x00360AF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueNextRoomEntry);
		}

		// Token: 0x0601750E RID: 95502 RVA: 0x00362900 File Offset: 0x00360B00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueNextRoomEntry other)
		{
			return other != null && (other == this || (this.RoomTypeId == other.RoomTypeId && this.RoomId == other.RoomId && this.EntityIncId == other.EntityIncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601750F RID: 95503 RVA: 0x0036295C File Offset: 0x00360B5C
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

		// Token: 0x06017510 RID: 95504 RVA: 0x003629CD File Offset: 0x00360BCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017511 RID: 95505 RVA: 0x003629DA File Offset: 0x00360BDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017512 RID: 95506 RVA: 0x003629E4 File Offset: 0x00360BE4
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

		// Token: 0x06017513 RID: 95507 RVA: 0x00362A58 File Offset: 0x00360C58
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

		// Token: 0x06017514 RID: 95508 RVA: 0x00362AC8 File Offset: 0x00360CC8
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

		// Token: 0x06017515 RID: 95509 RVA: 0x00362B2C File Offset: 0x00360D2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017516 RID: 95510 RVA: 0x00362B38 File Offset: 0x00360D38
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

		// Token: 0x04008AA7 RID: 35495
		private static readonly MessageParser<RoverRogueNextRoomEntry> _parser = new MessageParser<RoverRogueNextRoomEntry>(() => new RoverRogueNextRoomEntry());

		// Token: 0x04008AA8 RID: 35496
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008AA9 RID: 35497
		public const int RoomTypeIdFieldNumber = 1;

		// Token: 0x04008AAA RID: 35498
		private int roomTypeId_;

		// Token: 0x04008AAB RID: 35499
		public const int RoomIdFieldNumber = 2;

		// Token: 0x04008AAC RID: 35500
		private int roomId_;

		// Token: 0x04008AAD RID: 35501
		public const int EntityIncIdFieldNumber = 3;

		// Token: 0x04008AAE RID: 35502
		private long entityIncId_;
	}
}
