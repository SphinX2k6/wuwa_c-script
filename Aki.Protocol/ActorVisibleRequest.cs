using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200009A RID: 154
	[NetMessage(EMessageId.ActorVisibleRequest)]
	public sealed class ActorVisibleRequest : IMessage<ActorVisibleRequest>, IMessage, IEquatable<ActorVisibleRequest>, IDeepCloneable<ActorVisibleRequest>, IBufferMessage
	{
		// Token: 0x06001BC9 RID: 7113 RVA: 0x0004D7F0 File Offset: 0x0004B9F0
		[NullableContext(1)]
		public static ActorVisibleRequest Create()
		{
			return new ActorVisibleRequest();
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06001BCA RID: 7114 RVA: 0x0004D7F7 File Offset: 0x0004B9F7
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
		// (get) Token: 0x06001BCB RID: 7115 RVA: 0x0004D7FA File Offset: 0x0004B9FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActorVisibleRequest.Descriptor;
			}
		}

		// Token: 0x06001BCC RID: 7116 RVA: 0x0004D801 File Offset: 0x0004BA01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActorVisibleRequest()
		{
		}

		// Token: 0x06001BCD RID: 7117 RVA: 0x0004D809 File Offset: 0x0004BA09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActorVisibleRequest(ActorVisibleRequest other) : this()
		{
			this.id_ = other.id_;
			this.isActorVisible_ = other.isActorVisible_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001BCE RID: 7118 RVA: 0x0004D83A File Offset: 0x0004BA3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActorVisibleRequest Clone()
		{
			return new ActorVisibleRequest(this);
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06001BCF RID: 7119 RVA: 0x0004D842 File Offset: 0x0004BA42
		// (set) Token: 0x06001BD0 RID: 7120 RVA: 0x0004D84A File Offset: 0x0004BA4A
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
		// (get) Token: 0x06001BD1 RID: 7121 RVA: 0x0004D853 File Offset: 0x0004BA53
		// (set) Token: 0x06001BD2 RID: 7122 RVA: 0x0004D85B File Offset: 0x0004BA5B
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

		// Token: 0x06001BD3 RID: 7123 RVA: 0x0004D864 File Offset: 0x0004BA64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActorVisibleRequest);
		}

		// Token: 0x06001BD4 RID: 7124 RVA: 0x0004D872 File Offset: 0x0004BA72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActorVisibleRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.IsActorVisible == other.IsActorVisible && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001BD5 RID: 7125 RVA: 0x0004D8B0 File Offset: 0x0004BAB0
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

		// Token: 0x06001BD6 RID: 7126 RVA: 0x0004D908 File Offset: 0x0004BB08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001BD7 RID: 7127 RVA: 0x0004D915 File Offset: 0x0004BB15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001BD8 RID: 7128 RVA: 0x0004D920 File Offset: 0x0004BB20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.Id);
			}
			if (this.IsActorVisible)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.IsActorVisible);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001BD9 RID: 7129 RVA: 0x0004D97C File Offset: 0x0004BB7C
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

		// Token: 0x06001BDA RID: 7130 RVA: 0x0004D9C8 File Offset: 0x0004BBC8
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

		// Token: 0x06001BDB RID: 7131 RVA: 0x0004DA18 File Offset: 0x0004BC18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001BDC RID: 7132 RVA: 0x0004DA24 File Offset: 0x0004BC24
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
					if (num != 40U)
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

		// Token: 0x040022B3 RID: 8883
		private UnknownFieldSet _unknownFields;

		// Token: 0x040022B4 RID: 8884
		public const int IdFieldNumber = 4;

		// Token: 0x040022B5 RID: 8885
		private long id_;

		// Token: 0x040022B6 RID: 8886
		public const int IsActorVisibleFieldNumber = 5;

		// Token: 0x040022B7 RID: 8887
		private bool isActorVisible_;
	}
}
