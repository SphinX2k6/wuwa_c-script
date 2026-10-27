using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001467 RID: 5223
	[NetMessage(EMessageId.TrialRoleRewardRequest)]
	public sealed class TrialRoleRewardRequest : IMessage<TrialRoleRewardRequest>, IMessage, IEquatable<TrialRoleRewardRequest>, IDeepCloneable<TrialRoleRewardRequest>, IBufferMessage
	{
		// Token: 0x0601BA7F RID: 113279 RVA: 0x00400DEB File Offset: 0x003FEFEB
		[NullableContext(1)]
		public static TrialRoleRewardRequest Create()
		{
			return new TrialRoleRewardRequest();
		}

		// Token: 0x17005D47 RID: 23879
		// (get) Token: 0x0601BA80 RID: 113280 RVA: 0x00400DF2 File Offset: 0x003FEFF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D48 RID: 23880
		// (get) Token: 0x0601BA81 RID: 113281 RVA: 0x00400DF5 File Offset: 0x003FEFF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrialRoleRewardRequest.Descriptor;
			}
		}

		// Token: 0x0601BA82 RID: 113282 RVA: 0x00400DFC File Offset: 0x003FEFFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrialRoleRewardRequest()
		{
		}

		// Token: 0x0601BA83 RID: 113283 RVA: 0x00400E04 File Offset: 0x003FF004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrialRoleRewardRequest(TrialRoleRewardRequest other) : this()
		{
			this.roleId_ = other.roleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BA84 RID: 113284 RVA: 0x00400E29 File Offset: 0x003FF029
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrialRoleRewardRequest Clone()
		{
			return new TrialRoleRewardRequest(this);
		}

		// Token: 0x17005D49 RID: 23881
		// (get) Token: 0x0601BA85 RID: 113285 RVA: 0x00400E31 File Offset: 0x003FF031
		// (set) Token: 0x0601BA86 RID: 113286 RVA: 0x00400E39 File Offset: 0x003FF039
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleId
		{
			get
			{
				return this.roleId_;
			}
			set
			{
				this.roleId_ = value;
			}
		}

		// Token: 0x0601BA87 RID: 113287 RVA: 0x00400E42 File Offset: 0x003FF042
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrialRoleRewardRequest);
		}

		// Token: 0x0601BA88 RID: 113288 RVA: 0x00400E50 File Offset: 0x003FF050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrialRoleRewardRequest other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BA89 RID: 113289 RVA: 0x00400E80 File Offset: 0x003FF080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BA8A RID: 113290 RVA: 0x00400EBF File Offset: 0x003FF0BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BA8B RID: 113291 RVA: 0x00400ECC File Offset: 0x003FF0CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BA8C RID: 113292 RVA: 0x00400ED5 File Offset: 0x003FF0D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BA8D RID: 113293 RVA: 0x00400F08 File Offset: 0x003FF108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BA8E RID: 113294 RVA: 0x00400F46 File Offset: 0x003FF146
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrialRoleRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BA8F RID: 113295 RVA: 0x00400F77 File Offset: 0x003FF177
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BA90 RID: 113296 RVA: 0x00400F80 File Offset: 0x003FF180
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009F69 RID: 40809
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009F6A RID: 40810
		public const int RoleIdFieldNumber = 3;

		// Token: 0x04009F6B RID: 40811
		private int roleId_;
	}
}
