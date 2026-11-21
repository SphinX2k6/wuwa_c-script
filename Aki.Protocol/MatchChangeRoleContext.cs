using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009A2 RID: 2466
	public sealed class MatchChangeRoleContext : IMessage<MatchChangeRoleContext>, IMessage, IEquatable<MatchChangeRoleContext>, IDeepCloneable<MatchChangeRoleContext>, IBufferMessage
	{
		// Token: 0x0600D8CF RID: 55503 RVA: 0x001FDDAD File Offset: 0x001FBFAD
		[NullableContext(1)]
		public static MatchChangeRoleContext Create()
		{
			return new MatchChangeRoleContext();
		}

		// Token: 0x17002BE3 RID: 11235
		// (get) Token: 0x0600D8D0 RID: 55504 RVA: 0x001FDDB4 File Offset: 0x001FBFB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002BE4 RID: 11236
		// (get) Token: 0x0600D8D1 RID: 55505 RVA: 0x001FDDB7 File Offset: 0x001FBFB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MatchChangeRoleContext.Descriptor;
			}
		}

		// Token: 0x0600D8D2 RID: 55506 RVA: 0x001FDDBE File Offset: 0x001FBFBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchChangeRoleContext()
		{
		}

		// Token: 0x0600D8D3 RID: 55507 RVA: 0x001FDDC6 File Offset: 0x001FBFC6
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

		// Token: 0x0600D8D4 RID: 55508 RVA: 0x001FDDF9 File Offset: 0x001FBFF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchChangeRoleContext Clone()
		{
			return new MatchChangeRoleContext(this);
		}

		// Token: 0x17002BE5 RID: 11237
		// (get) Token: 0x0600D8D5 RID: 55509 RVA: 0x001FDE01 File Offset: 0x001FC001
		// (set) Token: 0x0600D8D6 RID: 55510 RVA: 0x001FDE19 File Offset: 0x001FC019
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

		// Token: 0x17002BE6 RID: 11238
		// (get) Token: 0x0600D8D7 RID: 55511 RVA: 0x001FDE2F File Offset: 0x001FC02F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchChangeRoleContext.RoleCtxOneofCase RoleCtxCase
		{
			get
			{
				return this.roleCtxCase_;
			}
		}

		// Token: 0x0600D8D8 RID: 55512 RVA: 0x001FDE37 File Offset: 0x001FC037
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearRoleCtx()
		{
			this.roleCtxCase_ = MatchChangeRoleContext.RoleCtxOneofCase.None;
			this.roleCtx_ = null;
		}

		// Token: 0x0600D8D9 RID: 55513 RVA: 0x001FDE47 File Offset: 0x001FC047
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MatchChangeRoleContext);
		}

		// Token: 0x0600D8DA RID: 55514 RVA: 0x001FDE58 File Offset: 0x001FC058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MatchChangeRoleContext other)
		{
			return other != null && (other == this || (object.Equals(this.AbyssCtx, other.AbyssCtx) && this.RoleCtxCase == other.RoleCtxCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D8DB RID: 55515 RVA: 0x001FDEA8 File Offset: 0x001FC0A8
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

		// Token: 0x0600D8DC RID: 55516 RVA: 0x001FDEEE File Offset: 0x001FC0EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D8DD RID: 55517 RVA: 0x001FDEFB File Offset: 0x001FC0FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D8DE RID: 55518 RVA: 0x001FDF04 File Offset: 0x001FC104
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

		// Token: 0x0600D8DF RID: 55519 RVA: 0x001FDF38 File Offset: 0x001FC138
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

		// Token: 0x0600D8E0 RID: 55520 RVA: 0x001FDF78 File Offset: 0x001FC178
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

		// Token: 0x0600D8E1 RID: 55521 RVA: 0x001FDFCD File Offset: 0x001FC1CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D8E2 RID: 55522 RVA: 0x001FDFD8 File Offset: 0x001FC1D8
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

		// Token: 0x04005A99 RID: 23193
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005A9A RID: 23194
		public const int AbyssCtxFieldNumber = 1;

		// Token: 0x04005A9B RID: 23195
		private object roleCtx_;

		// Token: 0x04005A9C RID: 23196
		private MatchChangeRoleContext.RoleCtxOneofCase roleCtxCase_;

		// Token: 0x020018A6 RID: 6310
		public enum RoleCtxOneofCase
		{
			// Token: 0x0400CD26 RID: 52518
			None,
			// Token: 0x0400CD27 RID: 52519
			AbyssCtx
		}
	}
}
