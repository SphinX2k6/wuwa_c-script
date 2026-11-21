using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000099 RID: 153
	[NetMessage(EMessageId.ActorVisibleNotify)]
	public sealed class ActorVisibleNotify : IMessage<ActorVisibleNotify>, IMessage, IEquatable<ActorVisibleNotify>, IDeepCloneable<ActorVisibleNotify>, IBufferMessage
	{
		// Token: 0x06001BE8 RID: 7144 RVA: 0x0004DEE5 File Offset: 0x0004C0E5
		[NullableContext(1)]
		public static ActorVisibleNotify Create()
		{
			return new ActorVisibleNotify();
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06001BE9 RID: 7145 RVA: 0x0004DEEC File Offset: 0x0004C0EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06001BEA RID: 7146 RVA: 0x0004DEEF File Offset: 0x0004C0EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActorVisibleNotify.Descriptor;
			}
		}

		// Token: 0x06001BEB RID: 7147 RVA: 0x0004DEF6 File Offset: 0x0004C0F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActorVisibleNotify()
		{
		}

		// Token: 0x06001BEC RID: 7148 RVA: 0x0004DEFE File Offset: 0x0004C0FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActorVisibleNotify(ActorVisibleNotify other) : this()
		{
			this.id_ = other.id_;
			this.isActorVisible_ = other.isActorVisible_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001BED RID: 7149 RVA: 0x0004DF2F File Offset: 0x0004C12F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActorVisibleNotify Clone()
		{
			return new ActorVisibleNotify(this);
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06001BEE RID: 7150 RVA: 0x0004DF37 File Offset: 0x0004C137
		// (set) Token: 0x06001BEF RID: 7151 RVA: 0x0004DF3F File Offset: 0x0004C13F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06001BF0 RID: 7152 RVA: 0x0004DF48 File Offset: 0x0004C148
		// (set) Token: 0x06001BF1 RID: 7153 RVA: 0x0004DF50 File Offset: 0x0004C150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsActorVisible
		{
			get
			{
				return this.isActorVisible_;
			}
			set
			{
				this.isActorVisible_ = value;
			}
		}

		// Token: 0x06001BF2 RID: 7154 RVA: 0x0004DF59 File Offset: 0x0004C159
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActorVisibleNotify);
		}

		// Token: 0x06001BF3 RID: 7155 RVA: 0x0004DF67 File Offset: 0x0004C167
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActorVisibleNotify other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.IsActorVisible == other.IsActorVisible && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001BF4 RID: 7156 RVA: 0x0004DFA8 File Offset: 0x0004C1A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0L)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.IsActorVisible)
			{
				num ^= this.IsActorVisible.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001BF5 RID: 7157 RVA: 0x0004E000 File Offset: 0x0004C200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001BF6 RID: 7158 RVA: 0x0004E00D File Offset: 0x0004C20D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001BF7 RID: 7159 RVA: 0x0004E018 File Offset: 0x0004C218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsActorVisible)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.IsActorVisible);
			}
			if (this.Id != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001BF8 RID: 7160 RVA: 0x0004E074 File Offset: 0x0004C274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Id);
			}
			if (this.IsActorVisible)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001BF9 RID: 7161 RVA: 0x0004E0C0 File Offset: 0x0004C2C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ActorVisibleNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0L)
			{
				this.Id = other.Id;
			}
			if (other.IsActorVisible)
			{
				this.IsActorVisible = other.IsActorVisible;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001BFA RID: 7162 RVA: 0x0004E110 File Offset: 0x0004C310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001BFB RID: 7163 RVA: 0x0004E11C File Offset: 0x0004C31C
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
				if (num != 88U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Id = input.ReadInt64();
					}
				}
				else
				{
					this.IsActorVisible = input.ReadBool();
				}
			}
		}

		// Token: 0x0400230A RID: 8970
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400230B RID: 8971
		public const int IdFieldNumber = 15;

		// Token: 0x0400230C RID: 8972
		private long id_;

		// Token: 0x0400230D RID: 8973
		public const int IsActorVisibleFieldNumber = 11;

		// Token: 0x0400230E RID: 8974
		private bool isActorVisible_;
	}
}
