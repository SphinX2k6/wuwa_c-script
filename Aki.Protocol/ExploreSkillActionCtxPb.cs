using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000500 RID: 1280
	public sealed class ExploreSkillActionCtxPb : IMessage<ExploreSkillActionCtxPb>, IMessage, IEquatable<ExploreSkillActionCtxPb>, IDeepCloneable<ExploreSkillActionCtxPb>, IBufferMessage
	{
		// Token: 0x060078AB RID: 30891 RVA: 0x00125AC5 File Offset: 0x00123CC5
		[NullableContext(1)]
		public static ExploreSkillActionCtxPb Create()
		{
			return new ExploreSkillActionCtxPb();
		}

		// Token: 0x17001762 RID: 5986
		// (get) Token: 0x060078AC RID: 30892 RVA: 0x00125ACC File Offset: 0x00123CCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001763 RID: 5987
		// (get) Token: 0x060078AD RID: 30893 RVA: 0x00125ACF File Offset: 0x00123CCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExploreSkillActionCtxPb.Descriptor;
			}
		}

		// Token: 0x060078AE RID: 30894 RVA: 0x00125AD6 File Offset: 0x00123CD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillActionCtxPb()
		{
		}

		// Token: 0x060078AF RID: 30895 RVA: 0x00125ADE File Offset: 0x00123CDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillActionCtxPb(ExploreSkillActionCtxPb other) : this()
		{
			this.entityCtx_ = ((other.entityCtx_ != null) ? other.entityCtx_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060078B0 RID: 30896 RVA: 0x00125B13 File Offset: 0x00123D13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillActionCtxPb Clone()
		{
			return new ExploreSkillActionCtxPb(this);
		}

		// Token: 0x17001764 RID: 5988
		// (get) Token: 0x060078B1 RID: 30897 RVA: 0x00125B1B File Offset: 0x00123D1B
		// (set) Token: 0x060078B2 RID: 30898 RVA: 0x00125B23 File Offset: 0x00123D23
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

		// Token: 0x060078B3 RID: 30899 RVA: 0x00125B2C File Offset: 0x00123D2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExploreSkillActionCtxPb);
		}

		// Token: 0x060078B4 RID: 30900 RVA: 0x00125B3A File Offset: 0x00123D3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExploreSkillActionCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.EntityCtx, other.EntityCtx) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060078B5 RID: 30901 RVA: 0x00125B70 File Offset: 0x00123D70
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

		// Token: 0x060078B6 RID: 30902 RVA: 0x00125BAC File Offset: 0x00123DAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060078B7 RID: 30903 RVA: 0x00125BB9 File Offset: 0x00123DB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060078B8 RID: 30904 RVA: 0x00125BC2 File Offset: 0x00123DC2
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

		// Token: 0x060078B9 RID: 30905 RVA: 0x00125BF4 File Offset: 0x00123DF4
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

		// Token: 0x060078BA RID: 30906 RVA: 0x00125C34 File Offset: 0x00123E34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExploreSkillActionCtxPb other)
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

		// Token: 0x060078BB RID: 30907 RVA: 0x00125C88 File Offset: 0x00123E88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060078BC RID: 30908 RVA: 0x00125C94 File Offset: 0x00123E94
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

		// Token: 0x04003E77 RID: 15991
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E78 RID: 15992
		public const int EntityCtxFieldNumber = 1;

		// Token: 0x04003E79 RID: 15993
		private EntityCtxPb entityCtx_;
	}
}
