using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000503 RID: 1283
	public sealed class ExploreSkillCustomCtxPb : IMessage<ExploreSkillCustomCtxPb>, IMessage, IEquatable<ExploreSkillCustomCtxPb>, IDeepCloneable<ExploreSkillCustomCtxPb>, IBufferMessage
	{
		// Token: 0x060078E3 RID: 30947 RVA: 0x00126160 File Offset: 0x00124360
		[NullableContext(1)]
		public static ExploreSkillCustomCtxPb Create()
		{
			return new ExploreSkillCustomCtxPb();
		}

		// Token: 0x1700176C RID: 5996
		// (get) Token: 0x060078E4 RID: 30948 RVA: 0x00126167 File Offset: 0x00124367
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700176D RID: 5997
		// (get) Token: 0x060078E5 RID: 30949 RVA: 0x0012616A File Offset: 0x0012436A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExploreSkillCustomCtxPb.Descriptor;
			}
		}

		// Token: 0x060078E6 RID: 30950 RVA: 0x00126171 File Offset: 0x00124371
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillCustomCtxPb()
		{
		}

		// Token: 0x060078E7 RID: 30951 RVA: 0x00126179 File Offset: 0x00124379
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillCustomCtxPb(ExploreSkillCustomCtxPb other) : this()
		{
			this.entityCtx_ = ((other.entityCtx_ != null) ? other.entityCtx_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060078E8 RID: 30952 RVA: 0x001261AE File Offset: 0x001243AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillCustomCtxPb Clone()
		{
			return new ExploreSkillCustomCtxPb(this);
		}

		// Token: 0x1700176E RID: 5998
		// (get) Token: 0x060078E9 RID: 30953 RVA: 0x001261B6 File Offset: 0x001243B6
		// (set) Token: 0x060078EA RID: 30954 RVA: 0x001261BE File Offset: 0x001243BE
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

		// Token: 0x060078EB RID: 30955 RVA: 0x001261C7 File Offset: 0x001243C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExploreSkillCustomCtxPb);
		}

		// Token: 0x060078EC RID: 30956 RVA: 0x001261D5 File Offset: 0x001243D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExploreSkillCustomCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.EntityCtx, other.EntityCtx) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060078ED RID: 30957 RVA: 0x00126208 File Offset: 0x00124408
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

		// Token: 0x060078EE RID: 30958 RVA: 0x00126244 File Offset: 0x00124444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060078EF RID: 30959 RVA: 0x00126251 File Offset: 0x00124451
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060078F0 RID: 30960 RVA: 0x0012625A File Offset: 0x0012445A
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

		// Token: 0x060078F1 RID: 30961 RVA: 0x0012628C File Offset: 0x0012448C
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

		// Token: 0x060078F2 RID: 30962 RVA: 0x001262CC File Offset: 0x001244CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExploreSkillCustomCtxPb other)
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

		// Token: 0x060078F3 RID: 30963 RVA: 0x00126320 File Offset: 0x00124520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060078F4 RID: 30964 RVA: 0x0012632C File Offset: 0x0012452C
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

		// Token: 0x04003E82 RID: 16002
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E83 RID: 16003
		public const int EntityCtxFieldNumber = 1;

		// Token: 0x04003E84 RID: 16004
		private EntityCtxPb entityCtx_;
	}
}
