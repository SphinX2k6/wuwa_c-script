using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200047C RID: 1148
	public sealed class EntityGroupActionCtxPb : IMessage<EntityGroupActionCtxPb>, IMessage, IEquatable<EntityGroupActionCtxPb>, IDeepCloneable<EntityGroupActionCtxPb>, IBufferMessage
	{
		// Token: 0x06006E5C RID: 28252 RVA: 0x0010FAFC File Offset: 0x0010DCFC
		[NullableContext(1)]
		public static EntityGroupActionCtxPb Create()
		{
			return new EntityGroupActionCtxPb();
		}

		// Token: 0x17001539 RID: 5433
		// (get) Token: 0x06006E5D RID: 28253 RVA: 0x0010FB03 File Offset: 0x0010DD03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700153A RID: 5434
		// (get) Token: 0x06006E5E RID: 28254 RVA: 0x0010FB06 File Offset: 0x0010DD06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityGroupActionCtxPb.Descriptor;
			}
		}

		// Token: 0x06006E5F RID: 28255 RVA: 0x0010FB0D File Offset: 0x0010DD0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityGroupActionCtxPb()
		{
		}

		// Token: 0x06006E60 RID: 28256 RVA: 0x0010FB18 File Offset: 0x0010DD18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityGroupActionCtxPb(EntityGroupActionCtxPb other) : this()
		{
			this.entityCtx_ = ((other.entityCtx_ != null) ? other.entityCtx_.Clone() : null);
			this.triggerIndex_ = other.triggerIndex_;
			this.isMatch_ = other.isMatch_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006E61 RID: 28257 RVA: 0x0010FB70 File Offset: 0x0010DD70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityGroupActionCtxPb Clone()
		{
			return new EntityGroupActionCtxPb(this);
		}

		// Token: 0x1700153B RID: 5435
		// (get) Token: 0x06006E62 RID: 28258 RVA: 0x0010FB78 File Offset: 0x0010DD78
		// (set) Token: 0x06006E63 RID: 28259 RVA: 0x0010FB80 File Offset: 0x0010DD80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityCtxPb EntityCtx
		{
			get
			{
				return this.entityCtx_;
			}
			set
			{
				this.entityCtx_ = value;
			}
		}

		// Token: 0x1700153C RID: 5436
		// (get) Token: 0x06006E64 RID: 28260 RVA: 0x0010FB89 File Offset: 0x0010DD89
		// (set) Token: 0x06006E65 RID: 28261 RVA: 0x0010FB91 File Offset: 0x0010DD91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TriggerIndex
		{
			get
			{
				return this.triggerIndex_;
			}
			set
			{
				this.triggerIndex_ = value;
			}
		}

		// Token: 0x1700153D RID: 5437
		// (get) Token: 0x06006E66 RID: 28262 RVA: 0x0010FB9A File Offset: 0x0010DD9A
		// (set) Token: 0x06006E67 RID: 28263 RVA: 0x0010FBA2 File Offset: 0x0010DDA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsMatch
		{
			get
			{
				return this.isMatch_;
			}
			set
			{
				this.isMatch_ = value;
			}
		}

		// Token: 0x06006E68 RID: 28264 RVA: 0x0010FBAB File Offset: 0x0010DDAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityGroupActionCtxPb);
		}

		// Token: 0x06006E69 RID: 28265 RVA: 0x0010FBBC File Offset: 0x0010DDBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityGroupActionCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.EntityCtx, other.EntityCtx) && this.TriggerIndex == other.TriggerIndex && this.IsMatch == other.IsMatch && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006E6A RID: 28266 RVA: 0x0010FC1C File Offset: 0x0010DE1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.entityCtx_ != null)
			{
				num ^= this.EntityCtx.GetHashCode();
			}
			if (this.TriggerIndex != 0)
			{
				num ^= this.TriggerIndex.GetHashCode();
			}
			if (this.IsMatch)
			{
				num ^= this.IsMatch.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006E6B RID: 28267 RVA: 0x0010FC8A File Offset: 0x0010DE8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006E6C RID: 28268 RVA: 0x0010FC97 File Offset: 0x0010DE97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006E6D RID: 28269 RVA: 0x0010FCA0 File Offset: 0x0010DEA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.entityCtx_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.EntityCtx);
			}
			if (this.TriggerIndex != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.TriggerIndex);
			}
			if (this.IsMatch)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsMatch);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006E6E RID: 28270 RVA: 0x0010FD18 File Offset: 0x0010DF18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.entityCtx_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EntityCtx);
			}
			if (this.TriggerIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TriggerIndex);
			}
			if (this.IsMatch)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006E6F RID: 28271 RVA: 0x0010FD7C File Offset: 0x0010DF7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityGroupActionCtxPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.entityCtx_ != null)
			{
				if (this.entityCtx_ == null)
				{
					this.EntityCtx = new EntityCtxPb();
				}
				this.EntityCtx.MergeFrom(other.EntityCtx);
			}
			if (other.TriggerIndex != 0)
			{
				this.TriggerIndex = other.TriggerIndex;
			}
			if (other.IsMatch)
			{
				this.IsMatch = other.IsMatch;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006E70 RID: 28272 RVA: 0x0010FDF8 File Offset: 0x0010DFF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006E71 RID: 28273 RVA: 0x0010FE04 File Offset: 0x0010E004
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
				if (num != 10U)
				{
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.IsMatch = input.ReadBool();
						}
					}
					else
					{
						this.TriggerIndex = input.ReadInt32();
					}
				}
				else
				{
					if (this.entityCtx_ == null)
					{
						this.EntityCtx = new EntityCtxPb();
					}
					input.ReadMessage(this.EntityCtx);
				}
			}
		}

		// Token: 0x04003C01 RID: 15361
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C02 RID: 15362
		public const int EntityCtxFieldNumber = 1;

		// Token: 0x04003C03 RID: 15363
		private EntityCtxPb entityCtx_;

		// Token: 0x04003C04 RID: 15364
		public const int TriggerIndexFieldNumber = 2;

		// Token: 0x04003C05 RID: 15365
		private int triggerIndex_;

		// Token: 0x04003C06 RID: 15366
		public const int IsMatchFieldNumber = 3;

		// Token: 0x04003C07 RID: 15367
		private bool isMatch_;
	}
}
