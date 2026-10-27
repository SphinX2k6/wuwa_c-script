using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200047A RID: 1146
	[NetMessage(EMessageId.EntityCalabashSkinChangeNotify)]
	public sealed class EntityCalabashSkinChangeNotify : IMessage<EntityCalabashSkinChangeNotify>, IMessage, IEquatable<EntityCalabashSkinChangeNotify>, IDeepCloneable<EntityCalabashSkinChangeNotify>, IBufferMessage
	{
		// Token: 0x06006D1E RID: 27934 RVA: 0x00107338 File Offset: 0x00105538
		[NullableContext(1)]
		public static EntityCalabashSkinChangeNotify Create()
		{
			return new EntityCalabashSkinChangeNotify();
		}

		// Token: 0x170014BC RID: 5308
		// (get) Token: 0x06006D1F RID: 27935 RVA: 0x0010733F File Offset: 0x0010553F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170014BD RID: 5309
		// (get) Token: 0x06006D20 RID: 27936 RVA: 0x00107342 File Offset: 0x00105542
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityCalabashSkinChangeNotify.Descriptor;
			}
		}

		// Token: 0x06006D21 RID: 27937 RVA: 0x00107349 File Offset: 0x00105549
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityCalabashSkinChangeNotify()
		{
		}

		// Token: 0x06006D22 RID: 27938 RVA: 0x00107354 File Offset: 0x00105554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityCalabashSkinChangeNotify(EntityCalabashSkinChangeNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.calabashSkinComponent_ = ((other.calabashSkinComponent_ != null) ? other.calabashSkinComponent_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006D23 RID: 27939 RVA: 0x001073A0 File Offset: 0x001055A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityCalabashSkinChangeNotify Clone()
		{
			return new EntityCalabashSkinChangeNotify(this);
		}

		// Token: 0x170014BE RID: 5310
		// (get) Token: 0x06006D24 RID: 27940 RVA: 0x001073A8 File Offset: 0x001055A8
		// (set) Token: 0x06006D25 RID: 27941 RVA: 0x001073B0 File Offset: 0x001055B0
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

		// Token: 0x170014BF RID: 5311
		// (get) Token: 0x06006D26 RID: 27942 RVA: 0x001073B9 File Offset: 0x001055B9
		// (set) Token: 0x06006D27 RID: 27943 RVA: 0x001073C1 File Offset: 0x001055C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashSkinComponentPb CalabashSkinComponent
		{
			get
			{
				return this.calabashSkinComponent_;
			}
			set
			{
				this.calabashSkinComponent_ = value;
			}
		}

		// Token: 0x06006D28 RID: 27944 RVA: 0x001073CA File Offset: 0x001055CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityCalabashSkinChangeNotify);
		}

		// Token: 0x06006D29 RID: 27945 RVA: 0x001073D8 File Offset: 0x001055D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityCalabashSkinChangeNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this.CalabashSkinComponent, other.CalabashSkinComponent) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006D2A RID: 27946 RVA: 0x00107428 File Offset: 0x00105628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.calabashSkinComponent_ != null)
			{
				num ^= this.CalabashSkinComponent.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006D2B RID: 27947 RVA: 0x0010747D File Offset: 0x0010567D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006D2C RID: 27948 RVA: 0x0010748A File Offset: 0x0010568A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006D2D RID: 27949 RVA: 0x00107494 File Offset: 0x00105694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.EntityId);
			}
			if (this.calabashSkinComponent_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.CalabashSkinComponent);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006D2E RID: 27950 RVA: 0x001074F0 File Offset: 0x001056F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.calabashSkinComponent_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CalabashSkinComponent);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006D2F RID: 27951 RVA: 0x00107548 File Offset: 0x00105748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityCalabashSkinChangeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.calabashSkinComponent_ != null)
			{
				if (this.calabashSkinComponent_ == null)
				{
					this.CalabashSkinComponent = new CalabashSkinComponentPb();
				}
				this.CalabashSkinComponent.MergeFrom(other.CalabashSkinComponent);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006D30 RID: 27952 RVA: 0x001075B0 File Offset: 0x001057B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006D31 RID: 27953 RVA: 0x001075BC File Offset: 0x001057BC
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
					if (num != 98U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.calabashSkinComponent_ == null)
						{
							this.CalabashSkinComponent = new CalabashSkinComponentPb();
						}
						input.ReadMessage(this.CalabashSkinComponent);
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003B1C RID: 15132
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003B1D RID: 15133
		public const int EntityIdFieldNumber = 10;

		// Token: 0x04003B1E RID: 15134
		private long entityId_;

		// Token: 0x04003B1F RID: 15135
		public const int CalabashSkinComponentFieldNumber = 12;

		// Token: 0x04003B20 RID: 15136
		private CalabashSkinComponentPb calabashSkinComponent_;
	}
}
