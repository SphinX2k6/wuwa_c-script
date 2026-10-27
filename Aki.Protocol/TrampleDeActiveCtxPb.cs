using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013F3 RID: 5107
	public sealed class TrampleDeActiveCtxPb : IMessage<TrampleDeActiveCtxPb>, IMessage, IEquatable<TrampleDeActiveCtxPb>, IDeepCloneable<TrampleDeActiveCtxPb>, IBufferMessage
	{
		// Token: 0x0601B0FF RID: 110847 RVA: 0x003EB334 File Offset: 0x003E9534
		[NullableContext(1)]
		public static TrampleDeActiveCtxPb Create()
		{
			return new TrampleDeActiveCtxPb();
		}

		// Token: 0x17005B32 RID: 23346
		// (get) Token: 0x0601B100 RID: 110848 RVA: 0x003EB33B File Offset: 0x003E953B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005B33 RID: 23347
		// (get) Token: 0x0601B101 RID: 110849 RVA: 0x003EB33E File Offset: 0x003E953E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrampleDeActiveCtxPb.Descriptor;
			}
		}

		// Token: 0x0601B102 RID: 110850 RVA: 0x003EB345 File Offset: 0x003E9545
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrampleDeActiveCtxPb()
		{
		}

		// Token: 0x0601B103 RID: 110851 RVA: 0x003EB34D File Offset: 0x003E954D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrampleDeActiveCtxPb(TrampleDeActiveCtxPb other) : this()
		{
			this.entityCtx_ = ((other.entityCtx_ != null) ? other.entityCtx_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B104 RID: 110852 RVA: 0x003EB382 File Offset: 0x003E9582
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrampleDeActiveCtxPb Clone()
		{
			return new TrampleDeActiveCtxPb(this);
		}

		// Token: 0x17005B34 RID: 23348
		// (get) Token: 0x0601B105 RID: 110853 RVA: 0x003EB38A File Offset: 0x003E958A
		// (set) Token: 0x0601B106 RID: 110854 RVA: 0x003EB392 File Offset: 0x003E9592
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

		// Token: 0x0601B107 RID: 110855 RVA: 0x003EB39B File Offset: 0x003E959B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrampleDeActiveCtxPb);
		}

		// Token: 0x0601B108 RID: 110856 RVA: 0x003EB3A9 File Offset: 0x003E95A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrampleDeActiveCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.EntityCtx, other.EntityCtx) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B109 RID: 110857 RVA: 0x003EB3DC File Offset: 0x003E95DC
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

		// Token: 0x0601B10A RID: 110858 RVA: 0x003EB418 File Offset: 0x003E9618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B10B RID: 110859 RVA: 0x003EB425 File Offset: 0x003E9625
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B10C RID: 110860 RVA: 0x003EB42E File Offset: 0x003E962E
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

		// Token: 0x0601B10D RID: 110861 RVA: 0x003EB460 File Offset: 0x003E9660
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

		// Token: 0x0601B10E RID: 110862 RVA: 0x003EB4A0 File Offset: 0x003E96A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrampleDeActiveCtxPb other)
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

		// Token: 0x0601B10F RID: 110863 RVA: 0x003EB4F4 File Offset: 0x003E96F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B110 RID: 110864 RVA: 0x003EB500 File Offset: 0x003E9700
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

		// Token: 0x04009C94 RID: 40084
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009C95 RID: 40085
		public const int EntityCtxFieldNumber = 1;

		// Token: 0x04009C96 RID: 40086
		private EntityCtxPb entityCtx_;
	}
}
