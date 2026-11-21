using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000626 RID: 1574
	public sealed class FoundationOperateActionCtxPb : IMessage<FoundationOperateActionCtxPb>, IMessage, IEquatable<FoundationOperateActionCtxPb>, IDeepCloneable<FoundationOperateActionCtxPb>, IBufferMessage
	{
		// Token: 0x06009189 RID: 37257 RVA: 0x00160B42 File Offset: 0x0015ED42
		[NullableContext(1)]
		public static FoundationOperateActionCtxPb Create()
		{
			return new FoundationOperateActionCtxPb();
		}

		// Token: 0x17001CF1 RID: 7409
		// (get) Token: 0x0600918A RID: 37258 RVA: 0x00160B49 File Offset: 0x0015ED49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001CF2 RID: 7410
		// (get) Token: 0x0600918B RID: 37259 RVA: 0x00160B4C File Offset: 0x0015ED4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FoundationOperateActionCtxPb.Descriptor;
			}
		}

		// Token: 0x0600918C RID: 37260 RVA: 0x00160B53 File Offset: 0x0015ED53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FoundationOperateActionCtxPb()
		{
		}

		// Token: 0x0600918D RID: 37261 RVA: 0x00160B5C File Offset: 0x0015ED5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FoundationOperateActionCtxPb(FoundationOperateActionCtxPb other) : this()
		{
			this.entityCtx_ = ((other.entityCtx_ != null) ? other.entityCtx_.Clone() : null);
			this.playerId_ = other.playerId_;
			this.isTakeOut_ = other.isTakeOut_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600918E RID: 37262 RVA: 0x00160BB4 File Offset: 0x0015EDB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FoundationOperateActionCtxPb Clone()
		{
			return new FoundationOperateActionCtxPb(this);
		}

		// Token: 0x17001CF3 RID: 7411
		// (get) Token: 0x0600918F RID: 37263 RVA: 0x00160BBC File Offset: 0x0015EDBC
		// (set) Token: 0x06009190 RID: 37264 RVA: 0x00160BC4 File Offset: 0x0015EDC4
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

		// Token: 0x17001CF4 RID: 7412
		// (get) Token: 0x06009191 RID: 37265 RVA: 0x00160BCD File Offset: 0x0015EDCD
		// (set) Token: 0x06009192 RID: 37266 RVA: 0x00160BD5 File Offset: 0x0015EDD5
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

		// Token: 0x17001CF5 RID: 7413
		// (get) Token: 0x06009193 RID: 37267 RVA: 0x00160BDE File Offset: 0x0015EDDE
		// (set) Token: 0x06009194 RID: 37268 RVA: 0x00160BE6 File Offset: 0x0015EDE6
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

		// Token: 0x06009195 RID: 37269 RVA: 0x00160BEF File Offset: 0x0015EDEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FoundationOperateActionCtxPb);
		}

		// Token: 0x06009196 RID: 37270 RVA: 0x00160C00 File Offset: 0x0015EE00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FoundationOperateActionCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.EntityCtx, other.EntityCtx) && this.PlayerId == other.PlayerId && this.IsTakeOut == other.IsTakeOut && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009197 RID: 37271 RVA: 0x00160C60 File Offset: 0x0015EE60
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

		// Token: 0x06009198 RID: 37272 RVA: 0x00160CCE File Offset: 0x0015EECE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009199 RID: 37273 RVA: 0x00160CDB File Offset: 0x0015EEDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600919A RID: 37274 RVA: 0x00160CE4 File Offset: 0x0015EEE4
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

		// Token: 0x0600919B RID: 37275 RVA: 0x00160D5C File Offset: 0x0015EF5C
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

		// Token: 0x0600919C RID: 37276 RVA: 0x00160DC0 File Offset: 0x0015EFC0
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

		// Token: 0x0600919D RID: 37277 RVA: 0x00160E3C File Offset: 0x0015F03C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600919E RID: 37278 RVA: 0x00160E48 File Offset: 0x0015F048
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

		// Token: 0x040046B5 RID: 18101
		private UnknownFieldSet _unknownFields;

		// Token: 0x040046B6 RID: 18102
		public const int EntityCtxFieldNumber = 1;

		// Token: 0x040046B7 RID: 18103
		private EntityCtxPb entityCtx_;

		// Token: 0x040046B8 RID: 18104
		public const int PlayerIdFieldNumber = 2;

		// Token: 0x040046B9 RID: 18105
		private int playerId_;

		// Token: 0x040046BA RID: 18106
		public const int IsTakeOutFieldNumber = 3;

		// Token: 0x040046BB RID: 18107
		private bool isTakeOut_;
	}
}
