using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200063A RID: 1594
	public sealed class FoundationOperateActionCtxPb : IMessage<FoundationOperateActionCtxPb>, IMessage, IEquatable<FoundationOperateActionCtxPb>, IDeepCloneable<FoundationOperateActionCtxPb>, IBufferMessage
	{
		// Token: 0x060092DF RID: 37599 RVA: 0x0016356E File Offset: 0x0016176E
		[NullableContext(1)]
		public static FoundationOperateActionCtxPb Create()
		{
			return new FoundationOperateActionCtxPb();
		}

		// Token: 0x17001D3B RID: 7483
		// (get) Token: 0x060092E0 RID: 37600 RVA: 0x00163575 File Offset: 0x00161775
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D3C RID: 7484
		// (get) Token: 0x060092E1 RID: 37601 RVA: 0x00163578 File Offset: 0x00161778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FoundationOperateActionCtxPb.Descriptor;
			}
		}

		// Token: 0x060092E2 RID: 37602 RVA: 0x0016357F File Offset: 0x0016177F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FoundationOperateActionCtxPb()
		{
		}

		// Token: 0x060092E3 RID: 37603 RVA: 0x00163588 File Offset: 0x00161788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FoundationOperateActionCtxPb(FoundationOperateActionCtxPb other) : this()
		{
			this.entityCtx_ = ((other.entityCtx_ != null) ? other.entityCtx_.Clone() : null);
			this.playerId_ = other.playerId_;
			this.isTakeOut_ = other.isTakeOut_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060092E4 RID: 37604 RVA: 0x001635E0 File Offset: 0x001617E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FoundationOperateActionCtxPb Clone()
		{
			return new FoundationOperateActionCtxPb(this);
		}

		// Token: 0x17001D3D RID: 7485
		// (get) Token: 0x060092E5 RID: 37605 RVA: 0x001635E8 File Offset: 0x001617E8
		// (set) Token: 0x060092E6 RID: 37606 RVA: 0x001635F0 File Offset: 0x001617F0
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

		// Token: 0x17001D3E RID: 7486
		// (get) Token: 0x060092E7 RID: 37607 RVA: 0x001635F9 File Offset: 0x001617F9
		// (set) Token: 0x060092E8 RID: 37608 RVA: 0x00163601 File Offset: 0x00161801
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x17001D3F RID: 7487
		// (get) Token: 0x060092E9 RID: 37609 RVA: 0x0016360A File Offset: 0x0016180A
		// (set) Token: 0x060092EA RID: 37610 RVA: 0x00163612 File Offset: 0x00161812
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsTakeOut
		{
			get
			{
				return this.isTakeOut_;
			}
			set
			{
				this.isTakeOut_ = value;
			}
		}

		// Token: 0x060092EB RID: 37611 RVA: 0x0016361B File Offset: 0x0016181B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FoundationOperateActionCtxPb);
		}

		// Token: 0x060092EC RID: 37612 RVA: 0x0016362C File Offset: 0x0016182C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FoundationOperateActionCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.EntityCtx, other.EntityCtx) && this.PlayerId == other.PlayerId && this.IsTakeOut == other.IsTakeOut && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060092ED RID: 37613 RVA: 0x0016368C File Offset: 0x0016188C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.entityCtx_ != null)
			{
				num ^= this.EntityCtx.GetHashCode();
			}
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.IsTakeOut)
			{
				num ^= this.IsTakeOut.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060092EE RID: 37614 RVA: 0x001636FA File Offset: 0x001618FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060092EF RID: 37615 RVA: 0x00163707 File Offset: 0x00161907
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060092F0 RID: 37616 RVA: 0x00163710 File Offset: 0x00161910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.entityCtx_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.EntityCtx);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.PlayerId);
			}
			if (this.IsTakeOut)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsTakeOut);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060092F1 RID: 37617 RVA: 0x00163788 File Offset: 0x00161988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.entityCtx_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EntityCtx);
			}
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.IsTakeOut)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060092F2 RID: 37618 RVA: 0x001637EC File Offset: 0x001619EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FoundationOperateActionCtxPb other)
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
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.IsTakeOut)
			{
				this.IsTakeOut = other.IsTakeOut;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060092F3 RID: 37619 RVA: 0x00163868 File Offset: 0x00161A68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060092F4 RID: 37620 RVA: 0x00163874 File Offset: 0x00161A74
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
							this.IsTakeOut = input.ReadBool();
						}
					}
					else
					{
						this.PlayerId = input.ReadInt32();
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

		// Token: 0x040046BC RID: 18108
		private UnknownFieldSet _unknownFields;

		// Token: 0x040046BD RID: 18109
		public const int EntityCtxFieldNumber = 1;

		// Token: 0x040046BE RID: 18110
		private EntityCtxPb entityCtx_;

		// Token: 0x040046BF RID: 18111
		public const int PlayerIdFieldNumber = 2;

		// Token: 0x040046C0 RID: 18112
		private int playerId_;

		// Token: 0x040046C1 RID: 18113
		public const int IsTakeOutFieldNumber = 3;

		// Token: 0x040046C2 RID: 18114
		private bool isTakeOut_;
	}
}
