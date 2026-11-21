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
		// Token: 0x06001252 RID: 4690 RVA: 0x0003274B File Offset: 0x0003094B
		[NullableContext(1)]
		public static AbyssMatchRoleContext Create()
		{
			return new AbyssMatchRoleContext();
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06001253 RID: 4691 RVA: 0x00032752 File Offset: 0x00030952
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
		// (get) Token: 0x06001254 RID: 4692 RVA: 0x00032755 File Offset: 0x00030955
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssMatchRoleContext.Descriptor;
			}
		}

		// Token: 0x06001255 RID: 4693 RVA: 0x0003275C File Offset: 0x0003095C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssMatchRoleContext()
		{
		}

		// Token: 0x06001256 RID: 4694 RVA: 0x00032764 File Offset: 0x00030964
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssMatchRoleContext(AbyssMatchRoleContext other) : this()
		{
			this.roleInfo_ = ((other.roleInfo_ != null) ? other.roleInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001257 RID: 4695 RVA: 0x00032799 File Offset: 0x00030999
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssMatchRoleContext Clone()
		{
			return new AbyssMatchRoleContext(this);
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06001258 RID: 4696 RVA: 0x000327A1 File Offset: 0x000309A1
		// (set) Token: 0x06001259 RID: 4697 RVA: 0x000327A9 File Offset: 0x000309A9
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

		// Token: 0x0600125A RID: 4698 RVA: 0x000327B2 File Offset: 0x000309B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssMatchRoleContext);
		}

		// Token: 0x0600125B RID: 4699 RVA: 0x000327C0 File Offset: 0x000309C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssMatchRoleContext other)
		{
			return other != null && (other == this || (object.Equals(this.RoleInfo, other.RoleInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600125C RID: 4700 RVA: 0x000327F4 File Offset: 0x000309F4
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

		// Token: 0x0600125D RID: 4701 RVA: 0x00032830 File Offset: 0x00030A30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600125E RID: 4702 RVA: 0x0003283D File Offset: 0x00030A3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600125F RID: 4703 RVA: 0x00032846 File Offset: 0x00030A46
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

		// Token: 0x06001260 RID: 4704 RVA: 0x00032878 File Offset: 0x00030A78
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

		// Token: 0x06001261 RID: 4705 RVA: 0x000328B8 File Offset: 0x00030AB8
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

		// Token: 0x06001262 RID: 4706 RVA: 0x0003290C File Offset: 0x00030B0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001263 RID: 4707 RVA: 0x00032918 File Offset: 0x00030B18
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

		// Token: 0x04002009 RID: 8201
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400200A RID: 8202
		public const int RoleInfoFieldNumber = 1;

		// Token: 0x0400200B RID: 8203
		private AbyssRoleInfo roleInfo_;
	}
}
