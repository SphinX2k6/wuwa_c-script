using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004B5 RID: 1205
	[NetMessage(EMessageId.EntityVarUpdateNotify)]
	public sealed class EntityVarUpdateNotify : IMessage<EntityVarUpdateNotify>, IMessage, IEquatable<EntityVarUpdateNotify>, IDeepCloneable<EntityVarUpdateNotify>, IBufferMessage
	{
		// Token: 0x06007328 RID: 29480 RVA: 0x0011AEC3 File Offset: 0x001190C3
		[NullableContext(1)]
		public static EntityVarUpdateNotify Create()
		{
			return new EntityVarUpdateNotify();
		}

		// Token: 0x1700164A RID: 5706
		// (get) Token: 0x06007329 RID: 29481 RVA: 0x0011AECA File Offset: 0x001190CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700164B RID: 5707
		// (get) Token: 0x0600732A RID: 29482 RVA: 0x0011AECD File Offset: 0x001190CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityVarUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600732B RID: 29483 RVA: 0x0011AED4 File Offset: 0x001190D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityVarUpdateNotify()
		{
		}

		// Token: 0x0600732C RID: 29484 RVA: 0x0011AEE8 File Offset: 0x001190E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityVarUpdateNotify(EntityVarUpdateNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.varName_ = other.varName_;
			this.varDefine_ = ((other.varDefine_ != null) ? other.varDefine_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600732D RID: 29485 RVA: 0x0011AF40 File Offset: 0x00119140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityVarUpdateNotify Clone()
		{
			return new EntityVarUpdateNotify(this);
		}

		// Token: 0x1700164C RID: 5708
		// (get) Token: 0x0600732E RID: 29486 RVA: 0x0011AF48 File Offset: 0x00119148
		// (set) Token: 0x0600732F RID: 29487 RVA: 0x0011AF50 File Offset: 0x00119150
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

		// Token: 0x1700164D RID: 5709
		// (get) Token: 0x06007330 RID: 29488 RVA: 0x0011AF59 File Offset: 0x00119159
		// (set) Token: 0x06007331 RID: 29489 RVA: 0x0011AF61 File Offset: 0x00119161
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string VarName
		{
			get
			{
				return this.varName_;
			}
			set
			{
				this.varName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700164E RID: 5710
		// (get) Token: 0x06007332 RID: 29490 RVA: 0x0011AF74 File Offset: 0x00119174
		// (set) Token: 0x06007333 RID: 29491 RVA: 0x0011AF7C File Offset: 0x0011917C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VarDefinePb VarDefine
		{
			get
			{
				return this.varDefine_;
			}
			set
			{
				this.varDefine_ = value;
			}
		}

		// Token: 0x06007334 RID: 29492 RVA: 0x0011AF85 File Offset: 0x00119185
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityVarUpdateNotify);
		}

		// Token: 0x06007335 RID: 29493 RVA: 0x0011AF94 File Offset: 0x00119194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityVarUpdateNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && !(this.VarName != other.VarName) && object.Equals(this.VarDefine, other.VarDefine) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007336 RID: 29494 RVA: 0x0011AFF8 File Offset: 0x001191F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.VarName.Length != 0)
			{
				num ^= this.VarName.GetHashCode();
			}
			if (this.varDefine_ != null)
			{
				num ^= this.VarDefine.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007337 RID: 29495 RVA: 0x0011B068 File Offset: 0x00119268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007338 RID: 29496 RVA: 0x0011B075 File Offset: 0x00119275
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007339 RID: 29497 RVA: 0x0011B080 File Offset: 0x00119280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.EntityId);
			}
			if (this.VarName.Length != 0)
			{
				output.WriteRawTag(50);
				output.WriteString(this.VarName);
			}
			if (this.varDefine_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.VarDefine);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600733A RID: 29498 RVA: 0x0011B0FC File Offset: 0x001192FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.VarName.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.VarName);
			}
			if (this.varDefine_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.VarDefine);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600733B RID: 29499 RVA: 0x0011B170 File Offset: 0x00119370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityVarUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.VarName.Length != 0)
			{
				this.VarName = other.VarName;
			}
			if (other.varDefine_ != null)
			{
				if (this.varDefine_ == null)
				{
					this.VarDefine = new VarDefinePb();
				}
				this.VarDefine.MergeFrom(other.VarDefine);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600733C RID: 29500 RVA: 0x0011B1F1 File Offset: 0x001193F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600733D RID: 29501 RVA: 0x0011B1FC File Offset: 0x001193FC
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
					if (num != 50U)
					{
						if (num != 58U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.varDefine_ == null)
							{
								this.VarDefine = new VarDefinePb();
							}
							input.ReadMessage(this.VarDefine);
						}
					}
					else
					{
						this.VarName = input.ReadString();
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003D6D RID: 15725
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D6E RID: 15726
		public const int EntityIdFieldNumber = 1;

		// Token: 0x04003D6F RID: 15727
		private long entityId_;

		// Token: 0x04003D70 RID: 15728
		public const int VarNameFieldNumber = 6;

		// Token: 0x04003D71 RID: 15729
		private string varName_ = "";

		// Token: 0x04003D72 RID: 15730
		public const int VarDefineFieldNumber = 7;

		// Token: 0x04003D73 RID: 15731
		private VarDefinePb varDefine_;
	}
}
