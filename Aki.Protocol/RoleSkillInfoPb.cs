using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010B0 RID: 4272
	public sealed class RoleSkillInfoPb : IMessage<RoleSkillInfoPb>, IMessage, IEquatable<RoleSkillInfoPb>, IDeepCloneable<RoleSkillInfoPb>, IBufferMessage
	{
		// Token: 0x06016CED RID: 93421 RVA: 0x0035037D File Offset: 0x0034E57D
		[NullableContext(1)]
		public static RoleSkillInfoPb Create()
		{
			return new RoleSkillInfoPb();
		}

		// Token: 0x17004C69 RID: 19561
		// (get) Token: 0x06016CEE RID: 93422 RVA: 0x00350384 File Offset: 0x0034E584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoleSkillInfoPb> Parser
		{
			get
			{
				return RoleSkillInfoPb._parser;
			}
		}

		// Token: 0x17004C6A RID: 19562
		// (get) Token: 0x06016CEF RID: 93423 RVA: 0x0035038B File Offset: 0x0034E58B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004C6B RID: 19563
		// (get) Token: 0x06016CF0 RID: 93424 RVA: 0x0035038E File Offset: 0x0034E58E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleSkillInfoPb.Descriptor;
			}
		}

		// Token: 0x06016CF1 RID: 93425 RVA: 0x00350395 File Offset: 0x0034E595
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkillInfoPb()
		{
		}

		// Token: 0x06016CF2 RID: 93426 RVA: 0x003503A0 File Offset: 0x0034E5A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkillInfoPb(RoleSkillInfoPb other) : this()
		{
			this.roleEntityConfigId_ = other.roleEntityConfigId_;
			this.skillInfoPb_ = ((other.skillInfoPb_ != null) ? other.skillInfoPb_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016CF3 RID: 93427 RVA: 0x003503EC File Offset: 0x0034E5EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkillInfoPb Clone()
		{
			return new RoleSkillInfoPb(this);
		}

		// Token: 0x17004C6C RID: 19564
		// (get) Token: 0x06016CF4 RID: 93428 RVA: 0x003503F4 File Offset: 0x0034E5F4
		// (set) Token: 0x06016CF5 RID: 93429 RVA: 0x003503FC File Offset: 0x0034E5FC
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

		// Token: 0x17004C6D RID: 19565
		// (get) Token: 0x06016CF6 RID: 93430 RVA: 0x00350405 File Offset: 0x0034E605
		// (set) Token: 0x06016CF7 RID: 93431 RVA: 0x0035040D File Offset: 0x0034E60D
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

		// Token: 0x06016CF8 RID: 93432 RVA: 0x00350416 File Offset: 0x0034E616
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleSkillInfoPb);
		}

		// Token: 0x06016CF9 RID: 93433 RVA: 0x00350424 File Offset: 0x0034E624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleSkillInfoPb other)
		{
			return other != null && (other == this || (this.RoleEntityConfigId == other.RoleEntityConfigId && object.Equals(this.SkillInfoPb, other.SkillInfoPb) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016CFA RID: 93434 RVA: 0x00350474 File Offset: 0x0034E674
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

		// Token: 0x06016CFB RID: 93435 RVA: 0x003504C9 File Offset: 0x0034E6C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016CFC RID: 93436 RVA: 0x003504D6 File Offset: 0x0034E6D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016CFD RID: 93437 RVA: 0x003504E0 File Offset: 0x0034E6E0
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

		// Token: 0x06016CFE RID: 93438 RVA: 0x00350538 File Offset: 0x0034E738
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

		// Token: 0x06016CFF RID: 93439 RVA: 0x00350590 File Offset: 0x0034E790
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

		// Token: 0x06016D00 RID: 93440 RVA: 0x003505F8 File Offset: 0x0034E7F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016D01 RID: 93441 RVA: 0x00350604 File Offset: 0x0034E804
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

		// Token: 0x0400881B RID: 34843
		private static readonly MessageParser<RoleSkillInfoPb> _parser = new MessageParser<RoleSkillInfoPb>(() => new RoleSkillInfoPb());

		// Token: 0x0400881C RID: 34844
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400881D RID: 34845
		public const int RoleEntityConfigIdFieldNumber = 1;

		// Token: 0x0400881E RID: 34846
		private int roleEntityConfigId_;

		// Token: 0x0400881F RID: 34847
		public const int SkillInfoPbFieldNumber = 2;

		// Token: 0x04008820 RID: 34848
		private SkillInfoPb skillInfoPb_;
	}
}
