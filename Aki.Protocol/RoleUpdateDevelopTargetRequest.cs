using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010D1 RID: 4305
	[NetMessage(EMessageId.RoleUpdateDevelopTargetRequest)]
	public sealed class RoleUpdateDevelopTargetRequest : IMessage<RoleUpdateDevelopTargetRequest>, IMessage, IEquatable<RoleUpdateDevelopTargetRequest>, IDeepCloneable<RoleUpdateDevelopTargetRequest>, IBufferMessage
	{
		// Token: 0x06016F7E RID: 94078 RVA: 0x003557F7 File Offset: 0x003539F7
		[NullableContext(1)]
		public static RoleUpdateDevelopTargetRequest Create()
		{
			return new RoleUpdateDevelopTargetRequest();
		}

		// Token: 0x17004CEE RID: 19694
		// (get) Token: 0x06016F7F RID: 94079 RVA: 0x003557FE File Offset: 0x003539FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004CEF RID: 19695
		// (get) Token: 0x06016F80 RID: 94080 RVA: 0x00355801 File Offset: 0x00353A01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleUpdateDevelopTargetRequest.Descriptor;
			}
		}

		// Token: 0x06016F81 RID: 94081 RVA: 0x00355808 File Offset: 0x00353A08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleUpdateDevelopTargetRequest()
		{
		}

		// Token: 0x06016F82 RID: 94082 RVA: 0x00355810 File Offset: 0x00353A10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleUpdateDevelopTargetRequest(RoleUpdateDevelopTargetRequest other) : this()
		{
			this.roleId_ = other.roleId_;
			this.source_ = other.source_;
			this.planId_ = other.planId_;
			this.firstPhantomId_ = other.firstPhantomId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016F83 RID: 94083 RVA: 0x00355864 File Offset: 0x00353A64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleUpdateDevelopTargetRequest Clone()
		{
			return new RoleUpdateDevelopTargetRequest(this);
		}

		// Token: 0x17004CF0 RID: 19696
		// (get) Token: 0x06016F84 RID: 94084 RVA: 0x0035586C File Offset: 0x00353A6C
		// (set) Token: 0x06016F85 RID: 94085 RVA: 0x00355874 File Offset: 0x00353A74
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

		// Token: 0x17004CF1 RID: 19697
		// (get) Token: 0x06016F86 RID: 94086 RVA: 0x0035587D File Offset: 0x00353A7D
		// (set) Token: 0x06016F87 RID: 94087 RVA: 0x00355885 File Offset: 0x00353A85
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

		// Token: 0x17004CF2 RID: 19698
		// (get) Token: 0x06016F88 RID: 94088 RVA: 0x0035588E File Offset: 0x00353A8E
		// (set) Token: 0x06016F89 RID: 94089 RVA: 0x00355896 File Offset: 0x00353A96
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

		// Token: 0x17004CF3 RID: 19699
		// (get) Token: 0x06016F8A RID: 94090 RVA: 0x0035589F File Offset: 0x00353A9F
		// (set) Token: 0x06016F8B RID: 94091 RVA: 0x003558A7 File Offset: 0x00353AA7
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

		// Token: 0x06016F8C RID: 94092 RVA: 0x003558B0 File Offset: 0x00353AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleUpdateDevelopTargetRequest);
		}

		// Token: 0x06016F8D RID: 94093 RVA: 0x003558C0 File Offset: 0x00353AC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleUpdateDevelopTargetRequest other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.Source == other.Source && this.PlanId == other.PlanId && this.FirstPhantomId == other.FirstPhantomId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016F8E RID: 94094 RVA: 0x0035592C File Offset: 0x00353B2C
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
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016F8F RID: 94095 RVA: 0x003559B6 File Offset: 0x00353BB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016F90 RID: 94096 RVA: 0x003559C3 File Offset: 0x00353BC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016F91 RID: 94097 RVA: 0x003559CC File Offset: 0x00353BCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.RoleId);
			}
			if (this.PlanId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.PlanId);
			}
			if (this.Source != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.Source);
			}
			if (this.FirstPhantomId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.FirstPhantomId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016F92 RID: 94098 RVA: 0x00355A60 File Offset: 0x00353C60
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
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016F93 RID: 94099 RVA: 0x00355AE8 File Offset: 0x00353CE8
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016F94 RID: 94100 RVA: 0x00355B60 File Offset: 0x00353D60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016F95 RID: 94101 RVA: 0x00355B6C File Offset: 0x00353D6C
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
				if (num <= 56U)
				{
					if (num == 48U)
					{
						this.RoleId = input.ReadInt32();
						continue;
					}
					if (num == 56U)
					{
						this.PlanId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.Source = input.ReadInt32();
						continue;
					}
					if (num == 104U)
					{
						this.FirstPhantomId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040088CD RID: 35021
		private UnknownFieldSet _unknownFields;

		// Token: 0x040088CE RID: 35022
		public const int RoleIdFieldNumber = 6;

		// Token: 0x040088CF RID: 35023
		private int roleId_;

		// Token: 0x040088D0 RID: 35024
		public const int SourceFieldNumber = 11;

		// Token: 0x040088D1 RID: 35025
		private int source_;

		// Token: 0x040088D2 RID: 35026
		public const int PlanIdFieldNumber = 7;

		// Token: 0x040088D3 RID: 35027
		private int planId_;

		// Token: 0x040088D4 RID: 35028
		public const int FirstPhantomIdFieldNumber = 13;

		// Token: 0x040088D5 RID: 35029
		private int firstPhantomId_;
	}
}
