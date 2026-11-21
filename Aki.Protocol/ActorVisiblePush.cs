using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200009A RID: 154
	[NetMessage(EMessageId.ActorVisiblePush)]
	public sealed class ActorVisiblePush : IMessage<ActorVisiblePush>, IMessage, IEquatable<ActorVisiblePush>, IDeepCloneable<ActorVisiblePush>, IBufferMessage
	{
		// Token: 0x06001BFC RID: 7164 RVA: 0x0004E174 File Offset: 0x0004C374
		[NullableContext(1)]
		public static ActorVisiblePush Create()
		{
			return new ActorVisiblePush();
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06001BFD RID: 7165 RVA: 0x0004E17B File Offset: 0x0004C37B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06001BFE RID: 7166 RVA: 0x0004E17E File Offset: 0x0004C37E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActorVisiblePush.Descriptor;
			}
		}

		// Token: 0x06001BFF RID: 7167 RVA: 0x0004E185 File Offset: 0x0004C385
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActorVisiblePush()
		{
		}

		// Token: 0x06001C00 RID: 7168 RVA: 0x0004E18D File Offset: 0x0004C38D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActorVisiblePush(ActorVisiblePush other) : this()
		{
			this.id_ = other.id_;
			this.isActorVisible_ = other.isActorVisible_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001C01 RID: 7169 RVA: 0x0004E1BE File Offset: 0x0004C3BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActorVisiblePush Clone()
		{
			return new ActorVisiblePush(this);
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06001C02 RID: 7170 RVA: 0x0004E1C6 File Offset: 0x0004C3C6
		// (set) Token: 0x06001C03 RID: 7171 RVA: 0x0004E1CE File Offset: 0x0004C3CE
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

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06001C04 RID: 7172 RVA: 0x0004E1D7 File Offset: 0x0004C3D7
		// (set) Token: 0x06001C05 RID: 7173 RVA: 0x0004E1DF File Offset: 0x0004C3DF
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

		// Token: 0x06001C06 RID: 7174 RVA: 0x0004E1E8 File Offset: 0x0004C3E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActorVisiblePush);
		}

		// Token: 0x06001C07 RID: 7175 RVA: 0x0004E1F6 File Offset: 0x0004C3F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActorVisiblePush other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.IsActorVisible == other.IsActorVisible && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001C08 RID: 7176 RVA: 0x0004E234 File Offset: 0x0004C434
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

		// Token: 0x06001C09 RID: 7177 RVA: 0x0004E28C File Offset: 0x0004C48C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001C0A RID: 7178 RVA: 0x0004E299 File Offset: 0x0004C499
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001C0B RID: 7179 RVA: 0x0004E2A4 File Offset: 0x0004C4A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.Id);
			}
			if (this.IsActorVisible)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsActorVisible);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001C0C RID: 7180 RVA: 0x0004E300 File Offset: 0x0004C500
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

		// Token: 0x06001C0D RID: 7181 RVA: 0x0004E34C File Offset: 0x0004C54C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ActorVisiblePush other)
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

		// Token: 0x06001C0E RID: 7182 RVA: 0x0004E39C File Offset: 0x0004C59C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001C0F RID: 7183 RVA: 0x0004E3A8 File Offset: 0x0004C5A8
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
				if (num != 16U)
				{
					if (num != 24U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IsActorVisible = input.ReadBool();
					}
				}
				else
				{
					this.Id = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400230F RID: 8975
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002310 RID: 8976
		public const int IdFieldNumber = 2;

		// Token: 0x04002311 RID: 8977
		private long id_;

		// Token: 0x04002312 RID: 8978
		public const int IsActorVisibleFieldNumber = 3;

		// Token: 0x04002313 RID: 8979
		private bool isActorVisible_;
	}
}
