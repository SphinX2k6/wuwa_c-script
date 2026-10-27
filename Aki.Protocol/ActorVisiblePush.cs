using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000099 RID: 153
	[NetMessage(EMessageId.ActorVisiblePush)]
	public sealed class ActorVisiblePush : IMessage<ActorVisiblePush>, IMessage, IEquatable<ActorVisiblePush>, IDeepCloneable<ActorVisiblePush>, IBufferMessage
	{
		// Token: 0x06001BB5 RID: 7093 RVA: 0x0004D564 File Offset: 0x0004B764
		[NullableContext(1)]
		public static ActorVisiblePush Create()
		{
			return new ActorVisiblePush();
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06001BB6 RID: 7094 RVA: 0x0004D56B File Offset: 0x0004B76B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06001BB7 RID: 7095 RVA: 0x0004D56E File Offset: 0x0004B76E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActorVisiblePush.Descriptor;
			}
		}

		// Token: 0x06001BB8 RID: 7096 RVA: 0x0004D575 File Offset: 0x0004B775
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActorVisiblePush()
		{
		}

		// Token: 0x06001BB9 RID: 7097 RVA: 0x0004D57D File Offset: 0x0004B77D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActorVisiblePush(ActorVisiblePush other) : this()
		{
			this.id_ = other.id_;
			this.isActorVisible_ = other.isActorVisible_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001BBA RID: 7098 RVA: 0x0004D5AE File Offset: 0x0004B7AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActorVisiblePush Clone()
		{
			return new ActorVisiblePush(this);
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06001BBB RID: 7099 RVA: 0x0004D5B6 File Offset: 0x0004B7B6
		// (set) Token: 0x06001BBC RID: 7100 RVA: 0x0004D5BE File Offset: 0x0004B7BE
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

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06001BBD RID: 7101 RVA: 0x0004D5C7 File Offset: 0x0004B7C7
		// (set) Token: 0x06001BBE RID: 7102 RVA: 0x0004D5CF File Offset: 0x0004B7CF
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

		// Token: 0x06001BBF RID: 7103 RVA: 0x0004D5D8 File Offset: 0x0004B7D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActorVisiblePush);
		}

		// Token: 0x06001BC0 RID: 7104 RVA: 0x0004D5E6 File Offset: 0x0004B7E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActorVisiblePush other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.IsActorVisible == other.IsActorVisible && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001BC1 RID: 7105 RVA: 0x0004D624 File Offset: 0x0004B824
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

		// Token: 0x06001BC2 RID: 7106 RVA: 0x0004D67C File Offset: 0x0004B87C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001BC3 RID: 7107 RVA: 0x0004D689 File Offset: 0x0004B889
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001BC4 RID: 7108 RVA: 0x0004D694 File Offset: 0x0004B894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsActorVisible)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.IsActorVisible);
			}
			if (this.Id != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001BC5 RID: 7109 RVA: 0x0004D6F0 File Offset: 0x0004B8F0
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

		// Token: 0x06001BC6 RID: 7110 RVA: 0x0004D73C File Offset: 0x0004B93C
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

		// Token: 0x06001BC7 RID: 7111 RVA: 0x0004D78C File Offset: 0x0004B98C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001BC8 RID: 7112 RVA: 0x0004D798 File Offset: 0x0004B998
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
				if (num != 80U)
				{
					if (num != 112U)
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

		// Token: 0x040022AE RID: 8878
		private UnknownFieldSet _unknownFields;

		// Token: 0x040022AF RID: 8879
		public const int IdFieldNumber = 14;

		// Token: 0x040022B0 RID: 8880
		private long id_;

		// Token: 0x040022B1 RID: 8881
		public const int IsActorVisibleFieldNumber = 10;

		// Token: 0x040022B2 RID: 8882
		private bool isActorVisible_;
	}
}
