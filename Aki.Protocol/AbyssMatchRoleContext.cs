using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200002E RID: 46
	public sealed class AbyssMatchRoleContext : IMessage<AbyssMatchRoleContext>, IMessage, IEquatable<AbyssMatchRoleContext>, IDeepCloneable<AbyssMatchRoleContext>, IBufferMessage
	{
		// Token: 0x06001227 RID: 4647 RVA: 0x00032197 File Offset: 0x00030397
		[NullableContext(1)]
		public static AbyssMatchRoleContext Create()
		{
			return new AbyssMatchRoleContext();
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06001228 RID: 4648 RVA: 0x0003219E File Offset: 0x0003039E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06001229 RID: 4649 RVA: 0x000321A1 File Offset: 0x000303A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssMatchRoleContext.Descriptor;
			}
		}

		// Token: 0x0600122A RID: 4650 RVA: 0x000321A8 File Offset: 0x000303A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssMatchRoleContext()
		{
		}

		// Token: 0x0600122B RID: 4651 RVA: 0x000321B0 File Offset: 0x000303B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssMatchRoleContext(AbyssMatchRoleContext other) : this()
		{
			this.roleInfo_ = ((other.roleInfo_ != null) ? other.roleInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600122C RID: 4652 RVA: 0x000321E5 File Offset: 0x000303E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssMatchRoleContext Clone()
		{
			return new AbyssMatchRoleContext(this);
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x0600122D RID: 4653 RVA: 0x000321ED File Offset: 0x000303ED
		// (set) Token: 0x0600122E RID: 4654 RVA: 0x000321F5 File Offset: 0x000303F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssRoleInfo RoleInfo
		{
			get
			{
				return this.roleInfo_;
			}
			set
			{
				this.roleInfo_ = value;
			}
		}

		// Token: 0x0600122F RID: 4655 RVA: 0x000321FE File Offset: 0x000303FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssMatchRoleContext);
		}

		// Token: 0x06001230 RID: 4656 RVA: 0x0003220C File Offset: 0x0003040C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssMatchRoleContext other)
		{
			return other != null && (other == this || (object.Equals(this.RoleInfo, other.RoleInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001231 RID: 4657 RVA: 0x00032240 File Offset: 0x00030440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.roleInfo_ != null)
			{
				num ^= this.RoleInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001232 RID: 4658 RVA: 0x0003227C File Offset: 0x0003047C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001233 RID: 4659 RVA: 0x00032289 File Offset: 0x00030489
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001234 RID: 4660 RVA: 0x00032292 File Offset: 0x00030492
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.roleInfo_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.RoleInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001235 RID: 4661 RVA: 0x000322C4 File Offset: 0x000304C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.roleInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RoleInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001236 RID: 4662 RVA: 0x00032304 File Offset: 0x00030504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AbyssMatchRoleContext other)
		{
			if (other == null)
			{
				return;
			}
			if (other.roleInfo_ != null)
			{
				if (this.roleInfo_ == null)
				{
					this.RoleInfo = new AbyssRoleInfo();
				}
				this.RoleInfo.MergeFrom(other.RoleInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001237 RID: 4663 RVA: 0x00032358 File Offset: 0x00030558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001238 RID: 4664 RVA: 0x00032364 File Offset: 0x00030564
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
					if (this.roleInfo_ == null)
					{
						this.RoleInfo = new AbyssRoleInfo();
					}
					input.ReadMessage(this.RoleInfo);
				}
			}
		}

		// Token: 0x04001FB3 RID: 8115
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001FB4 RID: 8116
		public const int RoleInfoFieldNumber = 1;

		// Token: 0x04001FB5 RID: 8117
		private AbyssRoleInfo roleInfo_;
	}
}
