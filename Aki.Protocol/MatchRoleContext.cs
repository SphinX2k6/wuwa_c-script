using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009BE RID: 2494
	public sealed class MatchRoleContext : IMessage<MatchRoleContext>, IMessage, IEquatable<MatchRoleContext>, IDeepCloneable<MatchRoleContext>, IBufferMessage
	{
		// Token: 0x0600DACE RID: 56014 RVA: 0x00202024 File Offset: 0x00200224
		[NullableContext(1)]
		public static MatchRoleContext Create()
		{
			return new MatchRoleContext();
		}

		// Token: 0x17002C53 RID: 11347
		// (get) Token: 0x0600DACF RID: 56015 RVA: 0x0020202B File Offset: 0x0020022B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002C54 RID: 11348
		// (get) Token: 0x0600DAD0 RID: 56016 RVA: 0x0020202E File Offset: 0x0020022E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MatchRoleContext.Descriptor;
			}
		}

		// Token: 0x0600DAD1 RID: 56017 RVA: 0x00202035 File Offset: 0x00200235
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchRoleContext()
		{
		}

		// Token: 0x0600DAD2 RID: 56018 RVA: 0x0020203D File Offset: 0x0020023D
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

		// Token: 0x0600DAD3 RID: 56019 RVA: 0x00202070 File Offset: 0x00200270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchRoleContext Clone()
		{
			return new MatchRoleContext(this);
		}

		// Token: 0x17002C55 RID: 11349
		// (get) Token: 0x0600DAD4 RID: 56020 RVA: 0x00202078 File Offset: 0x00200278
		// (set) Token: 0x0600DAD5 RID: 56021 RVA: 0x00202090 File Offset: 0x00200290
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

		// Token: 0x17002C56 RID: 11350
		// (get) Token: 0x0600DAD6 RID: 56022 RVA: 0x002020A6 File Offset: 0x002002A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchRoleContext.RoleCtxOneofCase RoleCtxCase
		{
			get
			{
				return this.roleCtxCase_;
			}
		}

		// Token: 0x0600DAD7 RID: 56023 RVA: 0x002020AE File Offset: 0x002002AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearRoleCtx()
		{
			this.roleCtxCase_ = MatchRoleContext.RoleCtxOneofCase.None;
			this.roleCtx_ = null;
		}

		// Token: 0x0600DAD8 RID: 56024 RVA: 0x002020BE File Offset: 0x002002BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MatchRoleContext);
		}

		// Token: 0x0600DAD9 RID: 56025 RVA: 0x002020CC File Offset: 0x002002CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MatchRoleContext other)
		{
			return other != null && (other == this || (object.Equals(this.AbyssCtx, other.AbyssCtx) && this.RoleCtxCase == other.RoleCtxCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DADA RID: 56026 RVA: 0x0020211C File Offset: 0x0020031C
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

		// Token: 0x0600DADB RID: 56027 RVA: 0x00202162 File Offset: 0x00200362
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DADC RID: 56028 RVA: 0x0020216F File Offset: 0x0020036F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DADD RID: 56029 RVA: 0x00202178 File Offset: 0x00200378
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

		// Token: 0x0600DADE RID: 56030 RVA: 0x002021AC File Offset: 0x002003AC
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

		// Token: 0x0600DADF RID: 56031 RVA: 0x002021EC File Offset: 0x002003EC
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

		// Token: 0x0600DAE0 RID: 56032 RVA: 0x00202241 File Offset: 0x00200441
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DAE1 RID: 56033 RVA: 0x0020224C File Offset: 0x0020044C
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

		// Token: 0x04005AD7 RID: 23255
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005AD8 RID: 23256
		public const int AbyssCtxFieldNumber = 1;

		// Token: 0x04005AD9 RID: 23257
		private object roleCtx_;

		// Token: 0x04005ADA RID: 23258
		private MatchRoleContext.RoleCtxOneofCase roleCtxCase_;

		// Token: 0x02001830 RID: 6192
		public enum RoleCtxOneofCase
		{
			// Token: 0x0400C7FF RID: 51199
			None,
			// Token: 0x0400C800 RID: 51200
			AbyssCtx
		}
	}
}
