using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010A0 RID: 4256
	public sealed class RoleSkillInfoPb : IMessage<RoleSkillInfoPb>, IMessage, IEquatable<RoleSkillInfoPb>, IDeepCloneable<RoleSkillInfoPb>, IBufferMessage
	{
		// Token: 0x06016C08 RID: 93192 RVA: 0x0034ECA1 File Offset: 0x0034CEA1
		[NullableContext(1)]
		public static RoleSkillInfoPb Create()
		{
			return new RoleSkillInfoPb();
		}

		// Token: 0x17004C3F RID: 19519
		// (get) Token: 0x06016C09 RID: 93193 RVA: 0x0034ECA8 File Offset: 0x0034CEA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoleSkillInfoPb> Parser
		{
			get
			{
				return RoleSkillInfoPb._parser;
			}
		}

		// Token: 0x17004C40 RID: 19520
		// (get) Token: 0x06016C0A RID: 93194 RVA: 0x0034ECAF File Offset: 0x0034CEAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004C41 RID: 19521
		// (get) Token: 0x06016C0B RID: 93195 RVA: 0x0034ECB2 File Offset: 0x0034CEB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleSkillInfoPb.Descriptor;
			}
		}

		// Token: 0x06016C0C RID: 93196 RVA: 0x0034ECB9 File Offset: 0x0034CEB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkillInfoPb()
		{
		}

		// Token: 0x06016C0D RID: 93197 RVA: 0x0034ECC4 File Offset: 0x0034CEC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkillInfoPb(RoleSkillInfoPb other) : this()
		{
			this.roleEntityConfigId_ = other.roleEntityConfigId_;
			this.skillInfoPb_ = ((other.skillInfoPb_ != null) ? other.skillInfoPb_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016C0E RID: 93198 RVA: 0x0034ED10 File Offset: 0x0034CF10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkillInfoPb Clone()
		{
			return new RoleSkillInfoPb(this);
		}

		// Token: 0x17004C42 RID: 19522
		// (get) Token: 0x06016C0F RID: 93199 RVA: 0x0034ED18 File Offset: 0x0034CF18
		// (set) Token: 0x06016C10 RID: 93200 RVA: 0x0034ED20 File Offset: 0x0034CF20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleEntityConfigId
		{
			get
			{
				return this.roleEntityConfigId_;
			}
			set
			{
				this.roleEntityConfigId_ = value;
			}
		}

		// Token: 0x17004C43 RID: 19523
		// (get) Token: 0x06016C11 RID: 93201 RVA: 0x0034ED29 File Offset: 0x0034CF29
		// (set) Token: 0x06016C12 RID: 93202 RVA: 0x0034ED31 File Offset: 0x0034CF31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillInfoPb SkillInfoPb
		{
			get
			{
				return this.skillInfoPb_;
			}
			set
			{
				this.skillInfoPb_ = value;
			}
		}

		// Token: 0x06016C13 RID: 93203 RVA: 0x0034ED3A File Offset: 0x0034CF3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleSkillInfoPb);
		}

		// Token: 0x06016C14 RID: 93204 RVA: 0x0034ED48 File Offset: 0x0034CF48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleSkillInfoPb other)
		{
			return other != null && (other == this || (this.RoleEntityConfigId == other.RoleEntityConfigId && object.Equals(this.SkillInfoPb, other.SkillInfoPb) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016C15 RID: 93205 RVA: 0x0034ED98 File Offset: 0x0034CF98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleEntityConfigId != 0)
			{
				num ^= this.RoleEntityConfigId.GetHashCode();
			}
			if (this.skillInfoPb_ != null)
			{
				num ^= this.SkillInfoPb.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016C16 RID: 93206 RVA: 0x0034EDED File Offset: 0x0034CFED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016C17 RID: 93207 RVA: 0x0034EDFA File Offset: 0x0034CFFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016C18 RID: 93208 RVA: 0x0034EE04 File Offset: 0x0034D004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleEntityConfigId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoleEntityConfigId);
			}
			if (this.skillInfoPb_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.SkillInfoPb);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016C19 RID: 93209 RVA: 0x0034EE5C File Offset: 0x0034D05C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleEntityConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleEntityConfigId);
			}
			if (this.skillInfoPb_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SkillInfoPb);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016C1A RID: 93210 RVA: 0x0034EEB4 File Offset: 0x0034D0B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleSkillInfoPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleEntityConfigId != 0)
			{
				this.RoleEntityConfigId = other.RoleEntityConfigId;
			}
			if (other.skillInfoPb_ != null)
			{
				if (this.skillInfoPb_ == null)
				{
					this.SkillInfoPb = new SkillInfoPb();
				}
				this.SkillInfoPb.MergeFrom(other.SkillInfoPb);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016C1B RID: 93211 RVA: 0x0034EF1C File Offset: 0x0034D11C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016C1C RID: 93212 RVA: 0x0034EF28 File Offset: 0x0034D128
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
				if (num != 8U)
				{
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.skillInfoPb_ == null)
						{
							this.SkillInfoPb = new SkillInfoPb();
						}
						input.ReadMessage(this.SkillInfoPb);
					}
				}
				else
				{
					this.RoleEntityConfigId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008845 RID: 34885
		private static readonly MessageParser<RoleSkillInfoPb> _parser = new MessageParser<RoleSkillInfoPb>(() => new RoleSkillInfoPb());

		// Token: 0x04008846 RID: 34886
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008847 RID: 34887
		public const int RoleEntityConfigIdFieldNumber = 1;

		// Token: 0x04008848 RID: 34888
		private int roleEntityConfigId_;

		// Token: 0x04008849 RID: 34889
		public const int SkillInfoPbFieldNumber = 2;

		// Token: 0x0400884A RID: 34890
		private SkillInfoPb skillInfoPb_;
	}
}
