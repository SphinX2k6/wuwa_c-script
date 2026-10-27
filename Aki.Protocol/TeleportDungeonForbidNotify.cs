using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001338 RID: 4920
	[NetMessage(EMessageId.TeleportDungeonForbidNotify)]
	public sealed class TeleportDungeonForbidNotify : IMessage<TeleportDungeonForbidNotify>, IMessage, IEquatable<TeleportDungeonForbidNotify>, IDeepCloneable<TeleportDungeonForbidNotify>, IBufferMessage
	{
		// Token: 0x0601A23B RID: 107067 RVA: 0x003CBF1D File Offset: 0x003CA11D
		[NullableContext(1)]
		public static TeleportDungeonForbidNotify Create()
		{
			return new TeleportDungeonForbidNotify();
		}

		// Token: 0x17005829 RID: 22569
		// (get) Token: 0x0601A23C RID: 107068 RVA: 0x003CBF24 File Offset: 0x003CA124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700582A RID: 22570
		// (get) Token: 0x0601A23D RID: 107069 RVA: 0x003CBF27 File Offset: 0x003CA127
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TeleportDungeonForbidNotify.Descriptor;
			}
		}

		// Token: 0x0601A23E RID: 107070 RVA: 0x003CBF2E File Offset: 0x003CA12E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportDungeonForbidNotify()
		{
		}

		// Token: 0x0601A23F RID: 107071 RVA: 0x003CBF36 File Offset: 0x003CA136
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportDungeonForbidNotify(TeleportDungeonForbidNotify other) : this()
		{
			this.dungeonId_ = other.dungeonId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A240 RID: 107072 RVA: 0x003CBF5B File Offset: 0x003CA15B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportDungeonForbidNotify Clone()
		{
			return new TeleportDungeonForbidNotify(this);
		}

		// Token: 0x1700582B RID: 22571
		// (get) Token: 0x0601A241 RID: 107073 RVA: 0x003CBF63 File Offset: 0x003CA163
		// (set) Token: 0x0601A242 RID: 107074 RVA: 0x003CBF6B File Offset: 0x003CA16B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DungeonId
		{
			get
			{
				return this.dungeonId_;
			}
			set
			{
				this.dungeonId_ = value;
			}
		}

		// Token: 0x0601A243 RID: 107075 RVA: 0x003CBF74 File Offset: 0x003CA174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TeleportDungeonForbidNotify);
		}

		// Token: 0x0601A244 RID: 107076 RVA: 0x003CBF82 File Offset: 0x003CA182
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TeleportDungeonForbidNotify other)
		{
			return other != null && (other == this || (this.DungeonId == other.DungeonId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A245 RID: 107077 RVA: 0x003CBFB0 File Offset: 0x003CA1B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DungeonId != 0)
			{
				num ^= this.DungeonId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A246 RID: 107078 RVA: 0x003CBFEF File Offset: 0x003CA1EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A247 RID: 107079 RVA: 0x003CBFFC File Offset: 0x003CA1FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A248 RID: 107080 RVA: 0x003CC005 File Offset: 0x003CA205
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DungeonId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.DungeonId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A249 RID: 107081 RVA: 0x003CC038 File Offset: 0x003CA238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DungeonId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DungeonId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A24A RID: 107082 RVA: 0x003CC076 File Offset: 0x003CA276
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TeleportDungeonForbidNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DungeonId != 0)
			{
				this.DungeonId = other.DungeonId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A24B RID: 107083 RVA: 0x003CC0A7 File Offset: 0x003CA2A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A24C RID: 107084 RVA: 0x003CC0B0 File Offset: 0x003CA2B0
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.DungeonId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400988D RID: 39053
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400988E RID: 39054
		public const int DungeonIdFieldNumber = 4;

		// Token: 0x0400988F RID: 39055
		private int dungeonId_;
	}
}
