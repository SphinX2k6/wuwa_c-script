using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001233 RID: 4659
	[NetMessage(EMessageId.SitChairRequest)]
	public sealed class SitChairRequest : IMessage<SitChairRequest>, IMessage, IEquatable<SitChairRequest>, IDeepCloneable<SitChairRequest>, IBufferMessage
	{
		// Token: 0x06018D43 RID: 101699 RVA: 0x0039CE73 File Offset: 0x0039B073
		[NullableContext(1)]
		public static SitChairRequest Create()
		{
			return new SitChairRequest();
		}

		// Token: 0x170053B4 RID: 21428
		// (get) Token: 0x06018D44 RID: 101700 RVA: 0x0039CE7A File Offset: 0x0039B07A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170053B5 RID: 21429
		// (get) Token: 0x06018D45 RID: 101701 RVA: 0x0039CE7D File Offset: 0x0039B07D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SitChairRequest.Descriptor;
			}
		}

		// Token: 0x06018D46 RID: 101702 RVA: 0x0039CE84 File Offset: 0x0039B084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SitChairRequest()
		{
		}

		// Token: 0x06018D47 RID: 101703 RVA: 0x0039CE8C File Offset: 0x0039B08C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SitChairRequest(SitChairRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.isSitDown_ = other.isSitDown_;
			this.data_ = ((other.data_ != null) ? other.data_.Clone() : null);
			this.request_ = ((other.request_ != null) ? other.request_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018D48 RID: 101704 RVA: 0x0039CF00 File Offset: 0x0039B100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SitChairRequest Clone()
		{
			return new SitChairRequest(this);
		}

		// Token: 0x170053B6 RID: 21430
		// (get) Token: 0x06018D49 RID: 101705 RVA: 0x0039CF08 File Offset: 0x0039B108
		// (set) Token: 0x06018D4A RID: 101706 RVA: 0x0039CF10 File Offset: 0x0039B110
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

		// Token: 0x170053B7 RID: 21431
		// (get) Token: 0x06018D4B RID: 101707 RVA: 0x0039CF19 File Offset: 0x0039B119
		// (set) Token: 0x06018D4C RID: 101708 RVA: 0x0039CF21 File Offset: 0x0039B121
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsSitDown
		{
			get
			{
				return this.isSitDown_;
			}
			set
			{
				this.isSitDown_ = value;
			}
		}

		// Token: 0x170053B8 RID: 21432
		// (get) Token: 0x06018D4D RID: 101709 RVA: 0x0039CF2A File Offset: 0x0039B12A
		// (set) Token: 0x06018D4E RID: 101710 RVA: 0x0039CF32 File Offset: 0x0039B132
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatCommon Data
		{
			get
			{
				return this.data_;
			}
			set
			{
				this.data_ = value;
			}
		}

		// Token: 0x170053B9 RID: 21433
		// (get) Token: 0x06018D4F RID: 101711 RVA: 0x0039CF3B File Offset: 0x0039B13B
		// (set) Token: 0x06018D50 RID: 101712 RVA: 0x0039CF43 File Offset: 0x0039B143
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationStateChangedRequest Request
		{
			get
			{
				return this.request_;
			}
			set
			{
				this.request_ = value;
			}
		}

		// Token: 0x06018D51 RID: 101713 RVA: 0x0039CF4C File Offset: 0x0039B14C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SitChairRequest);
		}

		// Token: 0x06018D52 RID: 101714 RVA: 0x0039CF5C File Offset: 0x0039B15C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SitChairRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.IsSitDown == other.IsSitDown && object.Equals(this.Data, other.Data) && object.Equals(this.Request, other.Request) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018D53 RID: 101715 RVA: 0x0039CFD0 File Offset: 0x0039B1D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.IsSitDown)
			{
				num ^= this.IsSitDown.GetHashCode();
			}
			if (this.data_ != null)
			{
				num ^= this.Data.GetHashCode();
			}
			if (this.request_ != null)
			{
				num ^= this.Request.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018D54 RID: 101716 RVA: 0x0039D054 File Offset: 0x0039B254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018D55 RID: 101717 RVA: 0x0039D061 File Offset: 0x0039B261
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018D56 RID: 101718 RVA: 0x0039D06C File Offset: 0x0039B26C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.data_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Data);
			}
			if (this.IsSitDown)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.IsSitDown);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.EntityId);
			}
			if (this.request_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.Request);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018D57 RID: 101719 RVA: 0x0039D100 File Offset: 0x0039B300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.IsSitDown)
			{
				num += 2;
			}
			if (this.data_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Data);
			}
			if (this.request_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Request);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018D58 RID: 101720 RVA: 0x0039D17C File Offset: 0x0039B37C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SitChairRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.IsSitDown)
			{
				this.IsSitDown = other.IsSitDown;
			}
			if (other.data_ != null)
			{
				if (this.data_ == null)
				{
					this.Data = new CombatCommon();
				}
				this.Data.MergeFrom(other.Data);
			}
			if (other.request_ != null)
			{
				if (this.request_ == null)
				{
					this.Request = new AnimationStateChangedRequest();
				}
				this.Request.MergeFrom(other.Request);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018D59 RID: 101721 RVA: 0x0039D224 File Offset: 0x0039B424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018D5A RID: 101722 RVA: 0x0039D230 File Offset: 0x0039B430
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
				if (num <= 48U)
				{
					if (num == 10U)
					{
						if (this.data_ == null)
						{
							this.Data = new CombatCommon();
						}
						input.ReadMessage(this.Data);
						continue;
					}
					if (num == 48U)
					{
						this.IsSitDown = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.EntityId = input.ReadInt64();
						continue;
					}
					if (num == 122U)
					{
						if (this.request_ == null)
						{
							this.Request = new AnimationStateChangedRequest();
						}
						input.ReadMessage(this.Request);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400927A RID: 37498
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400927B RID: 37499
		public const int EntityIdFieldNumber = 7;

		// Token: 0x0400927C RID: 37500
		private long entityId_;

		// Token: 0x0400927D RID: 37501
		public const int IsSitDownFieldNumber = 6;

		// Token: 0x0400927E RID: 37502
		private bool isSitDown_;

		// Token: 0x0400927F RID: 37503
		public const int DataFieldNumber = 1;

		// Token: 0x04009280 RID: 37504
		private CombatCommon data_;

		// Token: 0x04009281 RID: 37505
		public const int RequestFieldNumber = 15;

		// Token: 0x04009282 RID: 37506
		private AnimationStateChangedRequest request_;
	}
}
