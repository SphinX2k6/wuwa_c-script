using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000902 RID: 2306
	[NetMessage(EMessageId.LevelSequenceFrameEventActionRequest)]
	public sealed class LevelSequenceFrameEventActionRequest : IMessage<LevelSequenceFrameEventActionRequest>, IMessage, IEquatable<LevelSequenceFrameEventActionRequest>, IDeepCloneable<LevelSequenceFrameEventActionRequest>, IBufferMessage
	{
		// Token: 0x0600CBEE RID: 52206 RVA: 0x001E14BE File Offset: 0x001DF6BE
		[NullableContext(1)]
		public static LevelSequenceFrameEventActionRequest Create()
		{
			return new LevelSequenceFrameEventActionRequest();
		}

		// Token: 0x17002929 RID: 10537
		// (get) Token: 0x0600CBEF RID: 52207 RVA: 0x001E14C5 File Offset: 0x001DF6C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700292A RID: 10538
		// (get) Token: 0x0600CBF0 RID: 52208 RVA: 0x001E14C8 File Offset: 0x001DF6C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LevelSequenceFrameEventActionRequest.Descriptor;
			}
		}

		// Token: 0x0600CBF1 RID: 52209 RVA: 0x001E14CF File Offset: 0x001DF6CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelSequenceFrameEventActionRequest()
		{
		}

		// Token: 0x0600CBF2 RID: 52210 RVA: 0x001E14E2 File Offset: 0x001DF6E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelSequenceFrameEventActionRequest(LevelSequenceFrameEventActionRequest other) : this()
		{
			this.hostPlayerId_ = other.hostPlayerId_;
			this.entityId_ = other.entityId_;
			this.key_ = other.key_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CBF3 RID: 52211 RVA: 0x001E151F File Offset: 0x001DF71F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelSequenceFrameEventActionRequest Clone()
		{
			return new LevelSequenceFrameEventActionRequest(this);
		}

		// Token: 0x1700292B RID: 10539
		// (get) Token: 0x0600CBF4 RID: 52212 RVA: 0x001E1527 File Offset: 0x001DF727
		// (set) Token: 0x0600CBF5 RID: 52213 RVA: 0x001E152F File Offset: 0x001DF72F
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

		// Token: 0x1700292C RID: 10540
		// (get) Token: 0x0600CBF6 RID: 52214 RVA: 0x001E1538 File Offset: 0x001DF738
		// (set) Token: 0x0600CBF7 RID: 52215 RVA: 0x001E1540 File Offset: 0x001DF740
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

		// Token: 0x1700292D RID: 10541
		// (get) Token: 0x0600CBF8 RID: 52216 RVA: 0x001E1549 File Offset: 0x001DF749
		// (set) Token: 0x0600CBF9 RID: 52217 RVA: 0x001E1551 File Offset: 0x001DF751
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

		// Token: 0x0600CBFA RID: 52218 RVA: 0x001E1564 File Offset: 0x001DF764
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LevelSequenceFrameEventActionRequest);
		}

		// Token: 0x0600CBFB RID: 52219 RVA: 0x001E1574 File Offset: 0x001DF774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LevelSequenceFrameEventActionRequest other)
		{
			return other != null && (other == this || (this.HostPlayerId == other.HostPlayerId && this.EntityId == other.EntityId && !(this.Key != other.Key) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CBFC RID: 52220 RVA: 0x001E15D4 File Offset: 0x001DF7D4
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

		// Token: 0x0600CBFD RID: 52221 RVA: 0x001E1647 File Offset: 0x001DF847
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CBFE RID: 52222 RVA: 0x001E1654 File Offset: 0x001DF854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CBFF RID: 52223 RVA: 0x001E1660 File Offset: 0x001DF860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.EntityId);
			}
			if (this.HostPlayerId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.HostPlayerId);
			}
			if (this.Key.Length != 0)
			{
				output.WriteRawTag(122);
				output.WriteString(this.Key);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CC00 RID: 52224 RVA: 0x001E16DC File Offset: 0x001DF8DC
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

		// Token: 0x0600CC01 RID: 52225 RVA: 0x001E1750 File Offset: 0x001DF950
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

		// Token: 0x0600CC02 RID: 52226 RVA: 0x001E17B9 File Offset: 0x001DF9B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CC03 RID: 52227 RVA: 0x001E17C4 File Offset: 0x001DF9C4
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
					if (num != 64U)
					{
						if (num != 122U)
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

		// Token: 0x040056E0 RID: 22240
		private UnknownFieldSet _unknownFields;

		// Token: 0x040056E1 RID: 22241
		public const int HostPlayerIdFieldNumber = 8;

		// Token: 0x040056E2 RID: 22242
		private int hostPlayerId_;

		// Token: 0x040056E3 RID: 22243
		public const int EntityIdFieldNumber = 6;

		// Token: 0x040056E4 RID: 22244
		private long entityId_;

		// Token: 0x040056E5 RID: 22245
		public const int KeyFieldNumber = 15;

		// Token: 0x040056E6 RID: 22246
		private string key_ = "";
	}
}
