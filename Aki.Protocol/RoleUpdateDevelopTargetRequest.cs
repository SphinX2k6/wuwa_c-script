using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200110B RID: 4363
	[NetMessage(EMessageId.RoleUpdateDevelopTargetRequest)]
	public sealed class RoleUpdateDevelopTargetRequest : IMessage<RoleUpdateDevelopTargetRequest>, IMessage, IEquatable<RoleUpdateDevelopTargetRequest>, IDeepCloneable<RoleUpdateDevelopTargetRequest>, IBufferMessage
	{
		// Token: 0x0601751D RID: 95517 RVA: 0x00364AA6 File Offset: 0x00362CA6
		[NullableContext(1)]
		public static RoleUpdateDevelopTargetRequest Create()
		{
			return new RoleUpdateDevelopTargetRequest();
		}

		// Token: 0x17004E59 RID: 20057
		// (get) Token: 0x0601751E RID: 95518 RVA: 0x00364AAD File Offset: 0x00362CAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004E5A RID: 20058
		// (get) Token: 0x0601751F RID: 95519 RVA: 0x00364AB0 File Offset: 0x00362CB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleUpdateDevelopTargetRequest.Descriptor;
			}
		}

		// Token: 0x06017520 RID: 95520 RVA: 0x00364AB7 File Offset: 0x00362CB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleUpdateDevelopTargetRequest()
		{
		}

		// Token: 0x06017521 RID: 95521 RVA: 0x00364AC0 File Offset: 0x00362CC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleUpdateDevelopTargetRequest(RoleUpdateDevelopTargetRequest other) : this()
		{
			this.roleId_ = other.roleId_;
			this.source_ = other.source_;
			this.planId_ = other.planId_;
			this.firstPhantomId_ = other.firstPhantomId_;
			this.core_ = other.core_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017522 RID: 95522 RVA: 0x00364B20 File Offset: 0x00362D20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleUpdateDevelopTargetRequest Clone()
		{
			return new RoleUpdateDevelopTargetRequest(this);
		}

		// Token: 0x17004E5B RID: 20059
		// (get) Token: 0x06017523 RID: 95523 RVA: 0x00364B28 File Offset: 0x00362D28
		// (set) Token: 0x06017524 RID: 95524 RVA: 0x00364B30 File Offset: 0x00362D30
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

		// Token: 0x17004E5C RID: 20060
		// (get) Token: 0x06017525 RID: 95525 RVA: 0x00364B39 File Offset: 0x00362D39
		// (set) Token: 0x06017526 RID: 95526 RVA: 0x00364B41 File Offset: 0x00362D41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Source
		{
			get
			{
				return this.source_;
			}
			set
			{
				this.source_ = value;
			}
		}

		// Token: 0x17004E5D RID: 20061
		// (get) Token: 0x06017527 RID: 95527 RVA: 0x00364B4A File Offset: 0x00362D4A
		// (set) Token: 0x06017528 RID: 95528 RVA: 0x00364B52 File Offset: 0x00362D52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlanId
		{
			get
			{
				return this.planId_;
			}
			set
			{
				this.planId_ = value;
			}
		}

		// Token: 0x17004E5E RID: 20062
		// (get) Token: 0x06017529 RID: 95529 RVA: 0x00364B5B File Offset: 0x00362D5B
		// (set) Token: 0x0601752A RID: 95530 RVA: 0x00364B63 File Offset: 0x00362D63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FirstPhantomId
		{
			get
			{
				return this.firstPhantomId_;
			}
			set
			{
				this.firstPhantomId_ = value;
			}
		}

		// Token: 0x17004E5F RID: 20063
		// (get) Token: 0x0601752B RID: 95531 RVA: 0x00364B6C File Offset: 0x00362D6C
		// (set) Token: 0x0601752C RID: 95532 RVA: 0x00364B74 File Offset: 0x00362D74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Core
		{
			get
			{
				return this.core_;
			}
			set
			{
				this.core_ = value;
			}
		}

		// Token: 0x0601752D RID: 95533 RVA: 0x00364B7D File Offset: 0x00362D7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleUpdateDevelopTargetRequest);
		}

		// Token: 0x0601752E RID: 95534 RVA: 0x00364B8C File Offset: 0x00362D8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleUpdateDevelopTargetRequest other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.Source == other.Source && this.PlanId == other.PlanId && this.FirstPhantomId == other.FirstPhantomId && this.Core == other.Core && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601752F RID: 95535 RVA: 0x00364C08 File Offset: 0x00362E08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.Source != 0)
			{
				num ^= this.Source.GetHashCode();
			}
			if (this.PlanId != 0)
			{
				num ^= this.PlanId.GetHashCode();
			}
			if (this.FirstPhantomId != 0)
			{
				num ^= this.FirstPhantomId.GetHashCode();
			}
			if (this.Core != 0)
			{
				num ^= this.Core.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017530 RID: 95536 RVA: 0x00364CAB File Offset: 0x00362EAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017531 RID: 95537 RVA: 0x00364CB8 File Offset: 0x00362EB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017532 RID: 95538 RVA: 0x00364CC4 File Offset: 0x00362EC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.RoleId);
			}
			if (this.FirstPhantomId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.FirstPhantomId);
			}
			if (this.Core != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.Core);
			}
			if (this.PlanId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.PlanId);
			}
			if (this.Source != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.Source);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017533 RID: 95539 RVA: 0x00364D74 File Offset: 0x00362F74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.Source != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Source);
			}
			if (this.PlanId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlanId);
			}
			if (this.FirstPhantomId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FirstPhantomId);
			}
			if (this.Core != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Core);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017534 RID: 95540 RVA: 0x00364E14 File Offset: 0x00363014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleUpdateDevelopTargetRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.Source != 0)
			{
				this.Source = other.Source;
			}
			if (other.PlanId != 0)
			{
				this.PlanId = other.PlanId;
			}
			if (other.FirstPhantomId != 0)
			{
				this.FirstPhantomId = other.FirstPhantomId;
			}
			if (other.Core != 0)
			{
				this.Core = other.Core;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017535 RID: 95541 RVA: 0x00364EA0 File Offset: 0x003630A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017536 RID: 95542 RVA: 0x00364EAC File Offset: 0x003630AC
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
				if (num <= 32U)
				{
					if (num == 24U)
					{
						this.RoleId = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.FirstPhantomId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.Core = input.ReadInt32();
						continue;
					}
					if (num == 72U)
					{
						this.PlanId = input.ReadInt32();
						continue;
					}
					if (num == 88U)
					{
						this.Source = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008B5E RID: 35678
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008B5F RID: 35679
		public const int RoleIdFieldNumber = 3;

		// Token: 0x04008B60 RID: 35680
		private int roleId_;

		// Token: 0x04008B61 RID: 35681
		public const int SourceFieldNumber = 11;

		// Token: 0x04008B62 RID: 35682
		private int source_;

		// Token: 0x04008B63 RID: 35683
		public const int PlanIdFieldNumber = 9;

		// Token: 0x04008B64 RID: 35684
		private int planId_;

		// Token: 0x04008B65 RID: 35685
		public const int FirstPhantomIdFieldNumber = 4;

		// Token: 0x04008B66 RID: 35686
		private int firstPhantomId_;

		// Token: 0x04008B67 RID: 35687
		public const int CoreFieldNumber = 7;

		// Token: 0x04008B68 RID: 35688
		private int core_;
	}
}
