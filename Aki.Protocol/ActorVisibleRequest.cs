using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200009B RID: 155
	[NetMessage(EMessageId.ActorVisibleRequest)]
	public sealed class ActorVisibleRequest : IMessage<ActorVisibleRequest>, IMessage, IEquatable<ActorVisibleRequest>, IDeepCloneable<ActorVisibleRequest>, IBufferMessage
	{
		// Token: 0x06001C10 RID: 7184 RVA: 0x0004E400 File Offset: 0x0004C600
		[NullableContext(1)]
		public static ActorVisibleRequest Create()
		{
			return new ActorVisibleRequest();
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06001C11 RID: 7185 RVA: 0x0004E407 File Offset: 0x0004C607
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06001C12 RID: 7186 RVA: 0x0004E40A File Offset: 0x0004C60A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActorVisibleRequest.Descriptor;
			}
		}

		// Token: 0x06001C13 RID: 7187 RVA: 0x0004E411 File Offset: 0x0004C611
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActorVisibleRequest()
		{
		}

		// Token: 0x06001C14 RID: 7188 RVA: 0x0004E419 File Offset: 0x0004C619
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActorVisibleRequest(ActorVisibleRequest other) : this()
		{
			this.id_ = other.id_;
			this.isActorVisible_ = other.isActorVisible_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001C15 RID: 7189 RVA: 0x0004E44A File Offset: 0x0004C64A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActorVisibleRequest Clone()
		{
			return new ActorVisibleRequest(this);
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06001C16 RID: 7190 RVA: 0x0004E452 File Offset: 0x0004C652
		// (set) Token: 0x06001C17 RID: 7191 RVA: 0x0004E45A File Offset: 0x0004C65A
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

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06001C18 RID: 7192 RVA: 0x0004E463 File Offset: 0x0004C663
		// (set) Token: 0x06001C19 RID: 7193 RVA: 0x0004E46B File Offset: 0x0004C66B
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

		// Token: 0x06001C1A RID: 7194 RVA: 0x0004E474 File Offset: 0x0004C674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActorVisibleRequest);
		}

		// Token: 0x06001C1B RID: 7195 RVA: 0x0004E482 File Offset: 0x0004C682
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActorVisibleRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.IsActorVisible == other.IsActorVisible && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001C1C RID: 7196 RVA: 0x0004E4C0 File Offset: 0x0004C6C0
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

		// Token: 0x06001C1D RID: 7197 RVA: 0x0004E518 File Offset: 0x0004C718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001C1E RID: 7198 RVA: 0x0004E525 File Offset: 0x0004C725
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001C1F RID: 7199 RVA: 0x0004E530 File Offset: 0x0004C730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsActorVisible)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.IsActorVisible);
			}
			if (this.Id != 0L)
			{
				output.WriteRawTag(72);
				output.WriteInt64(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001C20 RID: 7200 RVA: 0x0004E58C File Offset: 0x0004C78C
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

		// Token: 0x06001C21 RID: 7201 RVA: 0x0004E5D8 File Offset: 0x0004C7D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ActorVisibleRequest other)
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

		// Token: 0x06001C22 RID: 7202 RVA: 0x0004E628 File Offset: 0x0004C828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001C23 RID: 7203 RVA: 0x0004E634 File Offset: 0x0004C834
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
				if (num != 56U)
				{
					if (num != 72U)
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

		// Token: 0x04002314 RID: 8980
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002315 RID: 8981
		public const int IdFieldNumber = 9;

		// Token: 0x04002316 RID: 8982
		private long id_;

		// Token: 0x04002317 RID: 8983
		public const int IsActorVisibleFieldNumber = 7;

		// Token: 0x04002318 RID: 8984
		private bool isActorVisible_;
	}
}
