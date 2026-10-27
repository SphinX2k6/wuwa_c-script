using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000506 RID: 1286
	public sealed class ExploreSkillPullGiantCtxPb : IMessage<ExploreSkillPullGiantCtxPb>, IMessage, IEquatable<ExploreSkillPullGiantCtxPb>, IDeepCloneable<ExploreSkillPullGiantCtxPb>, IBufferMessage
	{
		// Token: 0x0600791B RID: 31003 RVA: 0x001267FC File Offset: 0x001249FC
		[NullableContext(1)]
		public static ExploreSkillPullGiantCtxPb Create()
		{
			return new ExploreSkillPullGiantCtxPb();
		}

		// Token: 0x17001776 RID: 6006
		// (get) Token: 0x0600791C RID: 31004 RVA: 0x00126803 File Offset: 0x00124A03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001777 RID: 6007
		// (get) Token: 0x0600791D RID: 31005 RVA: 0x00126806 File Offset: 0x00124A06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExploreSkillPullGiantCtxPb.Descriptor;
			}
		}

		// Token: 0x0600791E RID: 31006 RVA: 0x0012680D File Offset: 0x00124A0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillPullGiantCtxPb()
		{
		}

		// Token: 0x0600791F RID: 31007 RVA: 0x00126815 File Offset: 0x00124A15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillPullGiantCtxPb(ExploreSkillPullGiantCtxPb other) : this()
		{
			this.entityCtx_ = ((other.entityCtx_ != null) ? other.entityCtx_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007920 RID: 31008 RVA: 0x0012684A File Offset: 0x00124A4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillPullGiantCtxPb Clone()
		{
			return new ExploreSkillPullGiantCtxPb(this);
		}

		// Token: 0x17001778 RID: 6008
		// (get) Token: 0x06007921 RID: 31009 RVA: 0x00126852 File Offset: 0x00124A52
		// (set) Token: 0x06007922 RID: 31010 RVA: 0x0012685A File Offset: 0x00124A5A
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

		// Token: 0x06007923 RID: 31011 RVA: 0x00126863 File Offset: 0x00124A63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExploreSkillPullGiantCtxPb);
		}

		// Token: 0x06007924 RID: 31012 RVA: 0x00126871 File Offset: 0x00124A71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExploreSkillPullGiantCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.EntityCtx, other.EntityCtx) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007925 RID: 31013 RVA: 0x001268A4 File Offset: 0x00124AA4
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

		// Token: 0x06007926 RID: 31014 RVA: 0x001268E0 File Offset: 0x00124AE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007927 RID: 31015 RVA: 0x001268ED File Offset: 0x00124AED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007928 RID: 31016 RVA: 0x001268F6 File Offset: 0x00124AF6
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

		// Token: 0x06007929 RID: 31017 RVA: 0x00126928 File Offset: 0x00124B28
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

		// Token: 0x0600792A RID: 31018 RVA: 0x00126968 File Offset: 0x00124B68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExploreSkillPullGiantCtxPb other)
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

		// Token: 0x0600792B RID: 31019 RVA: 0x001269BC File Offset: 0x00124BBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600792C RID: 31020 RVA: 0x001269C8 File Offset: 0x00124BC8
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

		// Token: 0x04003E8D RID: 16013
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E8E RID: 16014
		public const int EntityCtxFieldNumber = 1;

		// Token: 0x04003E8F RID: 16015
		private EntityCtxPb entityCtx_;
	}
}
