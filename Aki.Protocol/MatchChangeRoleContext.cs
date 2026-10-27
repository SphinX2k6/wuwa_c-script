using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009B3 RID: 2483
	public sealed class MatchChangeRoleContext : IMessage<MatchChangeRoleContext>, IMessage, IEquatable<MatchChangeRoleContext>, IDeepCloneable<MatchChangeRoleContext>, IBufferMessage
	{
		// Token: 0x0600D9E9 RID: 55785 RVA: 0x001FFFA1 File Offset: 0x001FE1A1
		[NullableContext(1)]
		public static MatchChangeRoleContext Create()
		{
			return new MatchChangeRoleContext();
		}

		// Token: 0x17002C21 RID: 11297
		// (get) Token: 0x0600D9EA RID: 55786 RVA: 0x001FFFA8 File Offset: 0x001FE1A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002C22 RID: 11298
		// (get) Token: 0x0600D9EB RID: 55787 RVA: 0x001FFFAB File Offset: 0x001FE1AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MatchChangeRoleContext.Descriptor;
			}
		}

		// Token: 0x0600D9EC RID: 55788 RVA: 0x001FFFB2 File Offset: 0x001FE1B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchChangeRoleContext()
		{
		}

		// Token: 0x0600D9ED RID: 55789 RVA: 0x001FFFBA File Offset: 0x001FE1BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchChangeRoleContext(MatchChangeRoleContext other) : this()
		{
			if (other.RoleCtxCase == MatchChangeRoleContext.RoleCtxOneofCase.AbyssCtx)
			{
				this.AbyssCtx = other.AbyssCtx.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D9EE RID: 55790 RVA: 0x001FFFED File Offset: 0x001FE1ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchChangeRoleContext Clone()
		{
			return new MatchChangeRoleContext(this);
		}

		// Token: 0x17002C23 RID: 11299
		// (get) Token: 0x0600D9EF RID: 55791 RVA: 0x001FFFF5 File Offset: 0x001FE1F5
		// (set) Token: 0x0600D9F0 RID: 55792 RVA: 0x0020000D File Offset: 0x001FE20D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssMatchChangeRoleContext AbyssCtx
		{
			get
			{
				if (this.roleCtxCase_ != MatchChangeRoleContext.RoleCtxOneofCase.AbyssCtx)
				{
					return null;
				}
				return (AbyssMatchChangeRoleContext)this.roleCtx_;
			}
			set
			{
				this.roleCtx_ = value;
				this.roleCtxCase_ = ((value == null) ? MatchChangeRoleContext.RoleCtxOneofCase.None : MatchChangeRoleContext.RoleCtxOneofCase.AbyssCtx);
			}
		}

		// Token: 0x17002C24 RID: 11300
		// (get) Token: 0x0600D9F1 RID: 55793 RVA: 0x00200023 File Offset: 0x001FE223
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchChangeRoleContext.RoleCtxOneofCase RoleCtxCase
		{
			get
			{
				return this.roleCtxCase_;
			}
		}

		// Token: 0x0600D9F2 RID: 55794 RVA: 0x0020002B File Offset: 0x001FE22B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearRoleCtx()
		{
			this.roleCtxCase_ = MatchChangeRoleContext.RoleCtxOneofCase.None;
			this.roleCtx_ = null;
		}

		// Token: 0x0600D9F3 RID: 55795 RVA: 0x0020003B File Offset: 0x001FE23B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MatchChangeRoleContext);
		}

		// Token: 0x0600D9F4 RID: 55796 RVA: 0x0020004C File Offset: 0x001FE24C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MatchChangeRoleContext other)
		{
			return other != null && (other == this || (object.Equals(this.AbyssCtx, other.AbyssCtx) && this.RoleCtxCase == other.RoleCtxCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D9F5 RID: 55797 RVA: 0x0020009C File Offset: 0x001FE29C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.roleCtxCase_ == MatchChangeRoleContext.RoleCtxOneofCase.AbyssCtx)
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

		// Token: 0x0600D9F6 RID: 55798 RVA: 0x002000E2 File Offset: 0x001FE2E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D9F7 RID: 55799 RVA: 0x002000EF File Offset: 0x001FE2EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D9F8 RID: 55800 RVA: 0x002000F8 File Offset: 0x001FE2F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.roleCtxCase_ == MatchChangeRoleContext.RoleCtxOneofCase.AbyssCtx)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AbyssCtx);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D9F9 RID: 55801 RVA: 0x0020012C File Offset: 0x001FE32C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.roleCtxCase_ == MatchChangeRoleContext.RoleCtxOneofCase.AbyssCtx)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AbyssCtx);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D9FA RID: 55802 RVA: 0x0020016C File Offset: 0x001FE36C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MatchChangeRoleContext other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleCtxCase == MatchChangeRoleContext.RoleCtxOneofCase.AbyssCtx)
			{
				if (this.AbyssCtx == null)
				{
					this.AbyssCtx = new AbyssMatchChangeRoleContext();
				}
				this.AbyssCtx.MergeFrom(other.AbyssCtx);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D9FB RID: 55803 RVA: 0x002001C1 File Offset: 0x001FE3C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D9FC RID: 55804 RVA: 0x002001CC File Offset: 0x001FE3CC
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
					AbyssMatchChangeRoleContext abyssMatchChangeRoleContext = new AbyssMatchChangeRoleContext();
					if (this.roleCtxCase_ == MatchChangeRoleContext.RoleCtxOneofCase.AbyssCtx)
					{
						abyssMatchChangeRoleContext.MergeFrom(this.AbyssCtx);
					}
					input.ReadMessage(abyssMatchChangeRoleContext);
					this.AbyssCtx = abyssMatchChangeRoleContext;
				}
			}
		}

		// Token: 0x04005A90 RID: 23184
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005A91 RID: 23185
		public const int AbyssCtxFieldNumber = 1;

		// Token: 0x04005A92 RID: 23186
		private object roleCtx_;

		// Token: 0x04005A93 RID: 23187
		private MatchChangeRoleContext.RoleCtxOneofCase roleCtxCase_;

		// Token: 0x0200182E RID: 6190
		public enum RoleCtxOneofCase
		{
			// Token: 0x0400C7FB RID: 51195
			None,
			// Token: 0x0400C7FC RID: 51196
			AbyssCtx
		}
	}
}
