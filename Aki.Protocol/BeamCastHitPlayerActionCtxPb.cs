using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000181 RID: 385
	public sealed class BeamCastHitPlayerActionCtxPb : IMessage<BeamCastHitPlayerActionCtxPb>, IMessage, IEquatable<BeamCastHitPlayerActionCtxPb>, IDeepCloneable<BeamCastHitPlayerActionCtxPb>, IBufferMessage
	{
		// Token: 0x06002E97 RID: 11927 RVA: 0x00077D91 File Offset: 0x00075F91
		[NullableContext(1)]
		public static BeamCastHitPlayerActionCtxPb Create()
		{
			return new BeamCastHitPlayerActionCtxPb();
		}

		// Token: 0x1700071B RID: 1819
		// (get) Token: 0x06002E98 RID: 11928 RVA: 0x00077D98 File Offset: 0x00075F98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700071C RID: 1820
		// (get) Token: 0x06002E99 RID: 11929 RVA: 0x00077D9B File Offset: 0x00075F9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BeamCastHitPlayerActionCtxPb.Descriptor;
			}
		}

		// Token: 0x06002E9A RID: 11930 RVA: 0x00077DA2 File Offset: 0x00075FA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeamCastHitPlayerActionCtxPb()
		{
		}

		// Token: 0x06002E9B RID: 11931 RVA: 0x00077DAA File Offset: 0x00075FAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeamCastHitPlayerActionCtxPb(BeamCastHitPlayerActionCtxPb other) : this()
		{
			this.entityCtx_ = ((other.entityCtx_ != null) ? other.entityCtx_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002E9C RID: 11932 RVA: 0x00077DDF File Offset: 0x00075FDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeamCastHitPlayerActionCtxPb Clone()
		{
			return new BeamCastHitPlayerActionCtxPb(this);
		}

		// Token: 0x1700071D RID: 1821
		// (get) Token: 0x06002E9D RID: 11933 RVA: 0x00077DE7 File Offset: 0x00075FE7
		// (set) Token: 0x06002E9E RID: 11934 RVA: 0x00077DEF File Offset: 0x00075FEF
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

		// Token: 0x06002E9F RID: 11935 RVA: 0x00077DF8 File Offset: 0x00075FF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BeamCastHitPlayerActionCtxPb);
		}

		// Token: 0x06002EA0 RID: 11936 RVA: 0x00077E06 File Offset: 0x00076006
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BeamCastHitPlayerActionCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.EntityCtx, other.EntityCtx) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002EA1 RID: 11937 RVA: 0x00077E3C File Offset: 0x0007603C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.entityCtx_ != null)
			{
				num ^= this.EntityCtx.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002EA2 RID: 11938 RVA: 0x00077E78 File Offset: 0x00076078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002EA3 RID: 11939 RVA: 0x00077E85 File Offset: 0x00076085
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002EA4 RID: 11940 RVA: 0x00077E8E File Offset: 0x0007608E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.entityCtx_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.EntityCtx);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002EA5 RID: 11941 RVA: 0x00077EC0 File Offset: 0x000760C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.entityCtx_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EntityCtx);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002EA6 RID: 11942 RVA: 0x00077F00 File Offset: 0x00076100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BeamCastHitPlayerActionCtxPb other)
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002EA7 RID: 11943 RVA: 0x00077F54 File Offset: 0x00076154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002EA8 RID: 11944 RVA: 0x00077F60 File Offset: 0x00076160
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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

		// Token: 0x0400287D RID: 10365
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400287E RID: 10366
		public const int EntityCtxFieldNumber = 1;

		// Token: 0x0400287F RID: 10367
		private EntityCtxPb entityCtx_;
	}
}
