using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004F0 RID: 1264
	public sealed class ExploreSkillPullGiantCtxPb : IMessage<ExploreSkillPullGiantCtxPb>, IMessage, IEquatable<ExploreSkillPullGiantCtxPb>, IDeepCloneable<ExploreSkillPullGiantCtxPb>, IBufferMessage
	{
		// Token: 0x0600779F RID: 30623 RVA: 0x00123968 File Offset: 0x00121B68
		[NullableContext(1)]
		public static ExploreSkillPullGiantCtxPb Create()
		{
			return new ExploreSkillPullGiantCtxPb();
		}

		// Token: 0x17001725 RID: 5925
		// (get) Token: 0x060077A0 RID: 30624 RVA: 0x0012396F File Offset: 0x00121B6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001726 RID: 5926
		// (get) Token: 0x060077A1 RID: 30625 RVA: 0x00123972 File Offset: 0x00121B72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExploreSkillPullGiantCtxPb.Descriptor;
			}
		}

		// Token: 0x060077A2 RID: 30626 RVA: 0x00123979 File Offset: 0x00121B79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillPullGiantCtxPb()
		{
		}

		// Token: 0x060077A3 RID: 30627 RVA: 0x00123981 File Offset: 0x00121B81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillPullGiantCtxPb(ExploreSkillPullGiantCtxPb other) : this()
		{
			this.entityCtx_ = ((other.entityCtx_ != null) ? other.entityCtx_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060077A4 RID: 30628 RVA: 0x001239B6 File Offset: 0x00121BB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillPullGiantCtxPb Clone()
		{
			return new ExploreSkillPullGiantCtxPb(this);
		}

		// Token: 0x17001727 RID: 5927
		// (get) Token: 0x060077A5 RID: 30629 RVA: 0x001239BE File Offset: 0x00121BBE
		// (set) Token: 0x060077A6 RID: 30630 RVA: 0x001239C6 File Offset: 0x00121BC6
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

		// Token: 0x060077A7 RID: 30631 RVA: 0x001239CF File Offset: 0x00121BCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExploreSkillPullGiantCtxPb);
		}

		// Token: 0x060077A8 RID: 30632 RVA: 0x001239DD File Offset: 0x00121BDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExploreSkillPullGiantCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.EntityCtx, other.EntityCtx) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060077A9 RID: 30633 RVA: 0x00123A10 File Offset: 0x00121C10
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

		// Token: 0x060077AA RID: 30634 RVA: 0x00123A4C File Offset: 0x00121C4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060077AB RID: 30635 RVA: 0x00123A59 File Offset: 0x00121C59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060077AC RID: 30636 RVA: 0x00123A62 File Offset: 0x00121C62
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

		// Token: 0x060077AD RID: 30637 RVA: 0x00123A94 File Offset: 0x00121C94
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

		// Token: 0x060077AE RID: 30638 RVA: 0x00123AD4 File Offset: 0x00121CD4
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

		// Token: 0x060077AF RID: 30639 RVA: 0x00123B28 File Offset: 0x00121D28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060077B0 RID: 30640 RVA: 0x00123B34 File Offset: 0x00121D34
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

		// Token: 0x04003E7E RID: 15998
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E7F RID: 15999
		public const int EntityCtxFieldNumber = 1;

		// Token: 0x04003E80 RID: 16000
		private EntityCtxPb entityCtx_;
	}
}
