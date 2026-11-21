using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004AD RID: 1197
	[NetMessage(EMessageId.EntityStateReadyNotify)]
	public sealed class EntityStateReadyNotify : IMessage<EntityStateReadyNotify>, IMessage, IEquatable<EntityStateReadyNotify>, IDeepCloneable<EntityStateReadyNotify>, IBufferMessage
	{
		// Token: 0x0600726C RID: 29292 RVA: 0x00119118 File Offset: 0x00117318
		[NullableContext(1)]
		public static EntityStateReadyNotify Create()
		{
			return new EntityStateReadyNotify();
		}

		// Token: 0x1700161C RID: 5660
		// (get) Token: 0x0600726D RID: 29293 RVA: 0x0011911F File Offset: 0x0011731F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700161D RID: 5661
		// (get) Token: 0x0600726E RID: 29294 RVA: 0x00119122 File Offset: 0x00117322
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityStateReadyNotify.Descriptor;
			}
		}

		// Token: 0x0600726F RID: 29295 RVA: 0x00119129 File Offset: 0x00117329
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityStateReadyNotify()
		{
		}

		// Token: 0x06007270 RID: 29296 RVA: 0x00119131 File Offset: 0x00117331
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityStateReadyNotify(EntityStateReadyNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.tagId_ = other.tagId_;
			this.ready_ = other.ready_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007271 RID: 29297 RVA: 0x0011916E File Offset: 0x0011736E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityStateReadyNotify Clone()
		{
			return new EntityStateReadyNotify(this);
		}

		// Token: 0x1700161E RID: 5662
		// (get) Token: 0x06007272 RID: 29298 RVA: 0x00119176 File Offset: 0x00117376
		// (set) Token: 0x06007273 RID: 29299 RVA: 0x0011917E File Offset: 0x0011737E
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

		// Token: 0x1700161F RID: 5663
		// (get) Token: 0x06007274 RID: 29300 RVA: 0x00119187 File Offset: 0x00117387
		// (set) Token: 0x06007275 RID: 29301 RVA: 0x0011918F File Offset: 0x0011738F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TagId
		{
			get
			{
				return this.tagId_;
			}
			set
			{
				this.tagId_ = value;
			}
		}

		// Token: 0x17001620 RID: 5664
		// (get) Token: 0x06007276 RID: 29302 RVA: 0x00119198 File Offset: 0x00117398
		// (set) Token: 0x06007277 RID: 29303 RVA: 0x001191A0 File Offset: 0x001173A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Ready
		{
			get
			{
				return this.ready_;
			}
			set
			{
				this.ready_ = value;
			}
		}

		// Token: 0x06007278 RID: 29304 RVA: 0x001191A9 File Offset: 0x001173A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityStateReadyNotify);
		}

		// Token: 0x06007279 RID: 29305 RVA: 0x001191B8 File Offset: 0x001173B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityStateReadyNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.TagId == other.TagId && this.Ready == other.Ready && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600727A RID: 29306 RVA: 0x00119214 File Offset: 0x00117414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.TagId != 0)
			{
				num ^= this.TagId.GetHashCode();
			}
			if (this.Ready)
			{
				num ^= this.Ready.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600727B RID: 29307 RVA: 0x00119285 File Offset: 0x00117485
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600727C RID: 29308 RVA: 0x00119292 File Offset: 0x00117492
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600727D RID: 29309 RVA: 0x0011929C File Offset: 0x0011749C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TagId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.TagId);
			}
			if (this.Ready)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.Ready);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600727E RID: 29310 RVA: 0x00119314 File Offset: 0x00117514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.TagId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TagId);
			}
			if (this.Ready)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600727F RID: 29311 RVA: 0x00119378 File Offset: 0x00117578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityStateReadyNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.TagId != 0)
			{
				this.TagId = other.TagId;
			}
			if (other.Ready)
			{
				this.Ready = other.Ready;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007280 RID: 29312 RVA: 0x001193DC File Offset: 0x001175DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007281 RID: 29313 RVA: 0x001193E8 File Offset: 0x001175E8
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
					if (num != 96U)
					{
						if (num != 120U)
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
						this.Ready = input.ReadBool();
					}
				}
				else
				{
					this.TagId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003D35 RID: 15669
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D36 RID: 15670
		public const int EntityIdFieldNumber = 15;

		// Token: 0x04003D37 RID: 15671
		private long entityId_;

		// Token: 0x04003D38 RID: 15672
		public const int TagIdFieldNumber = 11;

		// Token: 0x04003D39 RID: 15673
		private int tagId_;

		// Token: 0x04003D3A RID: 15674
		public const int ReadyFieldNumber = 12;

		// Token: 0x04003D3B RID: 15675
		private bool ready_;
	}
}
