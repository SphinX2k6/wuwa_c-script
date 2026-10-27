using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000913 RID: 2323
	[NetMessage(EMessageId.LevelSequenceFrameEventActionRequest)]
	public sealed class LevelSequenceFrameEventActionRequest : IMessage<LevelSequenceFrameEventActionRequest>, IMessage, IEquatable<LevelSequenceFrameEventActionRequest>, IDeepCloneable<LevelSequenceFrameEventActionRequest>, IBufferMessage
	{
		// Token: 0x0600CD0A RID: 52490 RVA: 0x001E378F File Offset: 0x001E198F
		[NullableContext(1)]
		public static LevelSequenceFrameEventActionRequest Create()
		{
			return new LevelSequenceFrameEventActionRequest();
		}

		// Token: 0x17002968 RID: 10600
		// (get) Token: 0x0600CD0B RID: 52491 RVA: 0x001E3796 File Offset: 0x001E1996
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002969 RID: 10601
		// (get) Token: 0x0600CD0C RID: 52492 RVA: 0x001E3799 File Offset: 0x001E1999
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LevelSequenceFrameEventActionRequest.Descriptor;
			}
		}

		// Token: 0x0600CD0D RID: 52493 RVA: 0x001E37A0 File Offset: 0x001E19A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelSequenceFrameEventActionRequest()
		{
		}

		// Token: 0x0600CD0E RID: 52494 RVA: 0x001E37B3 File Offset: 0x001E19B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelSequenceFrameEventActionRequest(LevelSequenceFrameEventActionRequest other) : this()
		{
			this.hostPlayerId_ = other.hostPlayerId_;
			this.entityId_ = other.entityId_;
			this.key_ = other.key_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CD0F RID: 52495 RVA: 0x001E37F0 File Offset: 0x001E19F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelSequenceFrameEventActionRequest Clone()
		{
			return new LevelSequenceFrameEventActionRequest(this);
		}

		// Token: 0x1700296A RID: 10602
		// (get) Token: 0x0600CD10 RID: 52496 RVA: 0x001E37F8 File Offset: 0x001E19F8
		// (set) Token: 0x0600CD11 RID: 52497 RVA: 0x001E3800 File Offset: 0x001E1A00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HostPlayerId
		{
			get
			{
				return this.hostPlayerId_;
			}
			set
			{
				this.hostPlayerId_ = value;
			}
		}

		// Token: 0x1700296B RID: 10603
		// (get) Token: 0x0600CD12 RID: 52498 RVA: 0x001E3809 File Offset: 0x001E1A09
		// (set) Token: 0x0600CD13 RID: 52499 RVA: 0x001E3811 File Offset: 0x001E1A11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x1700296C RID: 10604
		// (get) Token: 0x0600CD14 RID: 52500 RVA: 0x001E381A File Offset: 0x001E1A1A
		// (set) Token: 0x0600CD15 RID: 52501 RVA: 0x001E3822 File Offset: 0x001E1A22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Key
		{
			get
			{
				return this.key_;
			}
			set
			{
				this.key_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x0600CD16 RID: 52502 RVA: 0x001E3835 File Offset: 0x001E1A35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LevelSequenceFrameEventActionRequest);
		}

		// Token: 0x0600CD17 RID: 52503 RVA: 0x001E3844 File Offset: 0x001E1A44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LevelSequenceFrameEventActionRequest other)
		{
			return other != null && (other == this || (this.HostPlayerId == other.HostPlayerId && this.EntityId == other.EntityId && !(this.Key != other.Key) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CD18 RID: 52504 RVA: 0x001E38A4 File Offset: 0x001E1AA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HostPlayerId != 0)
			{
				num ^= this.HostPlayerId.GetHashCode();
			}
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.Key.Length != 0)
			{
				num ^= this.Key.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CD19 RID: 52505 RVA: 0x001E3917 File Offset: 0x001E1B17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CD1A RID: 52506 RVA: 0x001E3924 File Offset: 0x001E1B24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CD1B RID: 52507 RVA: 0x001E3930 File Offset: 0x001E1B30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.EntityId);
			}
			if (this.HostPlayerId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.HostPlayerId);
			}
			if (this.Key.Length != 0)
			{
				output.WriteRawTag(50);
				output.WriteString(this.Key);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CD1C RID: 52508 RVA: 0x001E39AC File Offset: 0x001E1BAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HostPlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HostPlayerId);
			}
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.Key.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Key);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CD1D RID: 52509 RVA: 0x001E3A20 File Offset: 0x001E1C20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LevelSequenceFrameEventActionRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HostPlayerId != 0)
			{
				this.HostPlayerId = other.HostPlayerId;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.Key.Length != 0)
			{
				this.Key = other.Key;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CD1E RID: 52510 RVA: 0x001E3A89 File Offset: 0x001E1C89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CD1F RID: 52511 RVA: 0x001E3A94 File Offset: 0x001E1C94
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
					if (num != 24U)
					{
						if (num != 50U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Key = input.ReadString();
						}
					}
					else
					{
						this.HostPlayerId = input.ReadInt32();
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x040056D9 RID: 22233
		private UnknownFieldSet _unknownFields;

		// Token: 0x040056DA RID: 22234
		public const int HostPlayerIdFieldNumber = 3;

		// Token: 0x040056DB RID: 22235
		private int hostPlayerId_;

		// Token: 0x040056DC RID: 22236
		public const int EntityIdFieldNumber = 1;

		// Token: 0x040056DD RID: 22237
		private long entityId_;

		// Token: 0x040056DE RID: 22238
		public const int KeyFieldNumber = 6;

		// Token: 0x040056DF RID: 22239
		private string key_ = "";
	}
}
