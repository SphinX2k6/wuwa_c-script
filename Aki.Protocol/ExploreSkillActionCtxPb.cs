using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004EA RID: 1258
	public sealed class ExploreSkillActionCtxPb : IMessage<ExploreSkillActionCtxPb>, IMessage, IEquatable<ExploreSkillActionCtxPb>, IDeepCloneable<ExploreSkillActionCtxPb>, IBufferMessage
	{
		// Token: 0x0600772F RID: 30511 RVA: 0x00122C2D File Offset: 0x00120E2D
		[NullableContext(1)]
		public static ExploreSkillActionCtxPb Create()
		{
			return new ExploreSkillActionCtxPb();
		}

		// Token: 0x17001711 RID: 5905
		// (get) Token: 0x06007730 RID: 30512 RVA: 0x00122C34 File Offset: 0x00120E34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001712 RID: 5906
		// (get) Token: 0x06007731 RID: 30513 RVA: 0x00122C37 File Offset: 0x00120E37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExploreSkillActionCtxPb.Descriptor;
			}
		}

		// Token: 0x06007732 RID: 30514 RVA: 0x00122C3E File Offset: 0x00120E3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillActionCtxPb()
		{
		}

		// Token: 0x06007733 RID: 30515 RVA: 0x00122C46 File Offset: 0x00120E46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillActionCtxPb(ExploreSkillActionCtxPb other) : this()
		{
			this.entityCtx_ = ((other.entityCtx_ != null) ? other.entityCtx_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007734 RID: 30516 RVA: 0x00122C7B File Offset: 0x00120E7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillActionCtxPb Clone()
		{
			return new ExploreSkillActionCtxPb(this);
		}

		// Token: 0x17001713 RID: 5907
		// (get) Token: 0x06007735 RID: 30517 RVA: 0x00122C83 File Offset: 0x00120E83
		// (set) Token: 0x06007736 RID: 30518 RVA: 0x00122C8B File Offset: 0x00120E8B
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

		// Token: 0x06007737 RID: 30519 RVA: 0x00122C94 File Offset: 0x00120E94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExploreSkillActionCtxPb);
		}

		// Token: 0x06007738 RID: 30520 RVA: 0x00122CA2 File Offset: 0x00120EA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExploreSkillActionCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.EntityCtx, other.EntityCtx) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007739 RID: 30521 RVA: 0x00122CD8 File Offset: 0x00120ED8
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

		// Token: 0x0600773A RID: 30522 RVA: 0x00122D14 File Offset: 0x00120F14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600773B RID: 30523 RVA: 0x00122D21 File Offset: 0x00120F21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600773C RID: 30524 RVA: 0x00122D2A File Offset: 0x00120F2A
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

		// Token: 0x0600773D RID: 30525 RVA: 0x00122D5C File Offset: 0x00120F5C
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

		// Token: 0x0600773E RID: 30526 RVA: 0x00122D9C File Offset: 0x00120F9C
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

		// Token: 0x0600773F RID: 30527 RVA: 0x00122DF0 File Offset: 0x00120FF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007740 RID: 30528 RVA: 0x00122DFC File Offset: 0x00120FFC
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

		// Token: 0x04003E68 RID: 15976
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E69 RID: 15977
		public const int EntityCtxFieldNumber = 1;

		// Token: 0x04003E6A RID: 15978
		private EntityCtxPb entityCtx_;
	}
}
