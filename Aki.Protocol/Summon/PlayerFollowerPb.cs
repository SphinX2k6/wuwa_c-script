using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Summon
{
	// Token: 0x020016F3 RID: 5875
	public sealed class PlayerFollowerPb : IMessage<PlayerFollowerPb>, IMessage, IEquatable<PlayerFollowerPb>, IDeepCloneable<PlayerFollowerPb>, IBufferMessage
	{
		// Token: 0x0601D5D6 RID: 120278 RVA: 0x0043FF34 File Offset: 0x0043E134
		[NullableContext(1)]
		public static PlayerFollowerPb Create()
		{
			return new PlayerFollowerPb();
		}

		// Token: 0x17006355 RID: 25429
		// (get) Token: 0x0601D5D7 RID: 120279 RVA: 0x0043FF3B File Offset: 0x0043E13B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PlayerFollowerPb> Parser
		{
			get
			{
				return PlayerFollowerPb._parser;
			}
		}

		// Token: 0x17006356 RID: 25430
		// (get) Token: 0x0601D5D8 RID: 120280 RVA: 0x0043FF42 File Offset: 0x0043E142
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006357 RID: 25431
		// (get) Token: 0x0601D5D9 RID: 120281 RVA: 0x0043FF45 File Offset: 0x0043E145
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerFollowerPb.Descriptor;
			}
		}

		// Token: 0x0601D5DA RID: 120282 RVA: 0x0043FF4C File Offset: 0x0043E14C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerFollowerPb()
		{
		}

		// Token: 0x0601D5DB RID: 120283 RVA: 0x0043FF54 File Offset: 0x0043E154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerFollowerPb(PlayerFollowerPb other) : this()
		{
			this.type_ = other.type_;
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D5DC RID: 120284 RVA: 0x0043FF85 File Offset: 0x0043E185
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerFollowerPb Clone()
		{
			return new PlayerFollowerPb(this);
		}

		// Token: 0x17006358 RID: 25432
		// (get) Token: 0x0601D5DD RID: 120285 RVA: 0x0043FF8D File Offset: 0x0043E18D
		// (set) Token: 0x0601D5DE RID: 120286 RVA: 0x0043FF95 File Offset: 0x0043E195
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EPlayerFollower Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x17006359 RID: 25433
		// (get) Token: 0x0601D5DF RID: 120287 RVA: 0x0043FF9E File Offset: 0x0043E19E
		// (set) Token: 0x0601D5E0 RID: 120288 RVA: 0x0043FFA6 File Offset: 0x0043E1A6
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

		// Token: 0x0601D5E1 RID: 120289 RVA: 0x0043FFAF File Offset: 0x0043E1AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerFollowerPb);
		}

		// Token: 0x0601D5E2 RID: 120290 RVA: 0x0043FFBD File Offset: 0x0043E1BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerFollowerPb other)
		{
			return other != null && (other == this || (this.Type == other.Type && this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D5E3 RID: 120291 RVA: 0x0043FFFC File Offset: 0x0043E1FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Type != EPlayerFollower.Default)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601D5E4 RID: 120292 RVA: 0x0044005A File Offset: 0x0043E25A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D5E5 RID: 120293 RVA: 0x00440067 File Offset: 0x0043E267
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D5E6 RID: 120294 RVA: 0x00440070 File Offset: 0x0043E270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Type != EPlayerFollower.Default)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.Type);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D5E7 RID: 120295 RVA: 0x004400C8 File Offset: 0x0043E2C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Type != EPlayerFollower.Default)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601D5E8 RID: 120296 RVA: 0x00440120 File Offset: 0x0043E320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerFollowerPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Type != EPlayerFollower.Default)
			{
				this.Type = other.Type;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D5E9 RID: 120297 RVA: 0x00440170 File Offset: 0x0043E370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D5EA RID: 120298 RVA: 0x0044017C File Offset: 0x0043E37C
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EntityId = input.ReadInt64();
					}
				}
				else
				{
					this.Type = (EPlayerFollower)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400C6FD RID: 50941
		private static readonly MessageParser<PlayerFollowerPb> _parser = new MessageParser<PlayerFollowerPb>(() => new PlayerFollowerPb());

		// Token: 0x0400C6FE RID: 50942
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C6FF RID: 50943
		public const int TypeFieldNumber = 1;

		// Token: 0x0400C700 RID: 50944
		private EPlayerFollower type_;

		// Token: 0x0400C701 RID: 50945
		public const int EntityIdFieldNumber = 2;

		// Token: 0x0400C702 RID: 50946
		private long entityId_;
	}
}
