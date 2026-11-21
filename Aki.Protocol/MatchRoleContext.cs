using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009AD RID: 2477
	public sealed class MatchRoleContext : IMessage<MatchRoleContext>, IMessage, IEquatable<MatchRoleContext>, IDeepCloneable<MatchRoleContext>, IBufferMessage
	{
		// Token: 0x0600D9B4 RID: 55732 RVA: 0x001FFE30 File Offset: 0x001FE030
		[NullableContext(1)]
		public static MatchRoleContext Create()
		{
			return new MatchRoleContext();
		}

		// Token: 0x17002C15 RID: 11285
		// (get) Token: 0x0600D9B5 RID: 55733 RVA: 0x001FFE37 File Offset: 0x001FE037
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002C16 RID: 11286
		// (get) Token: 0x0600D9B6 RID: 55734 RVA: 0x001FFE3A File Offset: 0x001FE03A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MatchRoleContext.Descriptor;
			}
		}

		// Token: 0x0600D9B7 RID: 55735 RVA: 0x001FFE41 File Offset: 0x001FE041
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchRoleContext()
		{
		}

		// Token: 0x0600D9B8 RID: 55736 RVA: 0x001FFE49 File Offset: 0x001FE049
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchRoleContext(MatchRoleContext other) : this()
		{
			if (other.RoleCtxCase == MatchRoleContext.RoleCtxOneofCase.AbyssCtx)
			{
				this.AbyssCtx = other.AbyssCtx.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D9B9 RID: 55737 RVA: 0x001FFE7C File Offset: 0x001FE07C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchRoleContext Clone()
		{
			return new MatchRoleContext(this);
		}

		// Token: 0x17002C17 RID: 11287
		// (get) Token: 0x0600D9BA RID: 55738 RVA: 0x001FFE84 File Offset: 0x001FE084
		// (set) Token: 0x0600D9BB RID: 55739 RVA: 0x001FFE9C File Offset: 0x001FE09C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssMatchRoleContext AbyssCtx
		{
			get
			{
				if (this.roleCtxCase_ != MatchRoleContext.RoleCtxOneofCase.AbyssCtx)
				{
					return null;
				}
				return (AbyssMatchRoleContext)this.roleCtx_;
			}
			set
			{
				this.roleCtx_ = value;
				this.roleCtxCase_ = ((value == null) ? MatchRoleContext.RoleCtxOneofCase.None : MatchRoleContext.RoleCtxOneofCase.AbyssCtx);
			}
		}

		// Token: 0x17002C18 RID: 11288
		// (get) Token: 0x0600D9BC RID: 55740 RVA: 0x001FFEB2 File Offset: 0x001FE0B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchRoleContext.RoleCtxOneofCase RoleCtxCase
		{
			get
			{
				return this.roleCtxCase_;
			}
		}

		// Token: 0x0600D9BD RID: 55741 RVA: 0x001FFEBA File Offset: 0x001FE0BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearRoleCtx()
		{
			this.roleCtxCase_ = MatchRoleContext.RoleCtxOneofCase.None;
			this.roleCtx_ = null;
		}

		// Token: 0x0600D9BE RID: 55742 RVA: 0x001FFECA File Offset: 0x001FE0CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MatchRoleContext);
		}

		// Token: 0x0600D9BF RID: 55743 RVA: 0x001FFED8 File Offset: 0x001FE0D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MatchRoleContext other)
		{
			return other != null && (other == this || (object.Equals(this.AbyssCtx, other.AbyssCtx) && this.RoleCtxCase == other.RoleCtxCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D9C0 RID: 55744 RVA: 0x001FFF28 File Offset: 0x001FE128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.roleCtxCase_ == MatchRoleContext.RoleCtxOneofCase.AbyssCtx)
			{
				num ^= this.AbyssCtx.GetHashCode();
			}
			num ^= (int)this.roleCtxCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D9C1 RID: 55745 RVA: 0x001FFF6E File Offset: 0x001FE16E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D9C2 RID: 55746 RVA: 0x001FFF7B File Offset: 0x001FE17B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D9C3 RID: 55747 RVA: 0x001FFF84 File Offset: 0x001FE184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.roleCtxCase_ == MatchRoleContext.RoleCtxOneofCase.AbyssCtx)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AbyssCtx);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D9C4 RID: 55748 RVA: 0x001FFFB8 File Offset: 0x001FE1B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.roleCtxCase_ == MatchRoleContext.RoleCtxOneofCase.AbyssCtx)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AbyssCtx);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D9C5 RID: 55749 RVA: 0x001FFFF8 File Offset: 0x001FE1F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MatchRoleContext other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleCtxCase == MatchRoleContext.RoleCtxOneofCase.AbyssCtx)
			{
				if (this.AbyssCtx == null)
				{
					this.AbyssCtx = new AbyssMatchRoleContext();
				}
				this.AbyssCtx.MergeFrom(other.AbyssCtx);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D9C6 RID: 55750 RVA: 0x0020004D File Offset: 0x001FE24D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D9C7 RID: 55751 RVA: 0x00200058 File Offset: 0x001FE258
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
					AbyssMatchRoleContext abyssMatchRoleContext = new AbyssMatchRoleContext();
					if (this.roleCtxCase_ == MatchRoleContext.RoleCtxOneofCase.AbyssCtx)
					{
						abyssMatchRoleContext.MergeFrom(this.AbyssCtx);
					}
					input.ReadMessage(abyssMatchRoleContext);
					this.AbyssCtx = abyssMatchRoleContext;
				}
			}
		}

		// Token: 0x04005AE0 RID: 23264
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005AE1 RID: 23265
		public const int AbyssCtxFieldNumber = 1;

		// Token: 0x04005AE2 RID: 23266
		private object roleCtx_;

		// Token: 0x04005AE3 RID: 23267
		private MatchRoleContext.RoleCtxOneofCase roleCtxCase_;

		// Token: 0x020018A8 RID: 6312
		public enum RoleCtxOneofCase
		{
			// Token: 0x0400CD2A RID: 52522
			None,
			// Token: 0x0400CD2B RID: 52523
			AbyssCtx
		}
	}
}
