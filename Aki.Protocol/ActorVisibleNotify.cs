using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000098 RID: 152
	[NetMessage(EMessageId.ActorVisibleNotify)]
	public sealed class ActorVisibleNotify : IMessage<ActorVisibleNotify>, IMessage, IEquatable<ActorVisibleNotify>, IDeepCloneable<ActorVisibleNotify>, IBufferMessage
	{
		// Token: 0x06001BA1 RID: 7073 RVA: 0x0004D2D5 File Offset: 0x0004B4D5
		[NullableContext(1)]
		public static ActorVisibleNotify Create()
		{
			return new ActorVisibleNotify();
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06001BA2 RID: 7074 RVA: 0x0004D2DC File Offset: 0x0004B4DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06001BA3 RID: 7075 RVA: 0x0004D2DF File Offset: 0x0004B4DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActorVisibleNotify.Descriptor;
			}
		}

		// Token: 0x06001BA4 RID: 7076 RVA: 0x0004D2E6 File Offset: 0x0004B4E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActorVisibleNotify()
		{
		}

		// Token: 0x06001BA5 RID: 7077 RVA: 0x0004D2EE File Offset: 0x0004B4EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActorVisibleNotify(ActorVisibleNotify other) : this()
		{
			this.id_ = other.id_;
			this.isActorVisible_ = other.isActorVisible_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001BA6 RID: 7078 RVA: 0x0004D31F File Offset: 0x0004B51F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActorVisibleNotify Clone()
		{
			return new ActorVisibleNotify(this);
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06001BA7 RID: 7079 RVA: 0x0004D327 File Offset: 0x0004B527
		// (set) Token: 0x06001BA8 RID: 7080 RVA: 0x0004D32F File Offset: 0x0004B52F
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

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06001BA9 RID: 7081 RVA: 0x0004D338 File Offset: 0x0004B538
		// (set) Token: 0x06001BAA RID: 7082 RVA: 0x0004D340 File Offset: 0x0004B540
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

		// Token: 0x06001BAB RID: 7083 RVA: 0x0004D349 File Offset: 0x0004B549
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActorVisibleNotify);
		}

		// Token: 0x06001BAC RID: 7084 RVA: 0x0004D357 File Offset: 0x0004B557
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActorVisibleNotify other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.IsActorVisible == other.IsActorVisible && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001BAD RID: 7085 RVA: 0x0004D398 File Offset: 0x0004B598
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

		// Token: 0x06001BAE RID: 7086 RVA: 0x0004D3F0 File Offset: 0x0004B5F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001BAF RID: 7087 RVA: 0x0004D3FD File Offset: 0x0004B5FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001BB0 RID: 7088 RVA: 0x0004D408 File Offset: 0x0004B608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsActorVisible)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsActorVisible);
			}
			if (this.Id != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001BB1 RID: 7089 RVA: 0x0004D464 File Offset: 0x0004B664
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

		// Token: 0x06001BB2 RID: 7090 RVA: 0x0004D4B0 File Offset: 0x0004B6B0
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

		// Token: 0x06001BB3 RID: 7091 RVA: 0x0004D500 File Offset: 0x0004B700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001BB4 RID: 7092 RVA: 0x0004D50C File Offset: 0x0004B70C
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
					if (num != 32U)
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

		// Token: 0x040022A9 RID: 8873
		private UnknownFieldSet _unknownFields;

		// Token: 0x040022AA RID: 8874
		public const int IdFieldNumber = 4;

		// Token: 0x040022AB RID: 8875
		private long id_;

		// Token: 0x040022AC RID: 8876
		public const int IsActorVisibleFieldNumber = 2;

		// Token: 0x040022AD RID: 8877
		private bool isActorVisible_;
	}
}
