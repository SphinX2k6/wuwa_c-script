using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000122 RID: 290
	public sealed class AttachTargetEntityInfo : IMessage<AttachTargetEntityInfo>, IMessage, IEquatable<AttachTargetEntityInfo>, IDeepCloneable<AttachTargetEntityInfo>, IBufferMessage
	{
		// Token: 0x06002711 RID: 10001 RVA: 0x000679A5 File Offset: 0x00065BA5
		[NullableContext(1)]
		public static AttachTargetEntityInfo Create()
		{
			return new AttachTargetEntityInfo();
		}

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x06002712 RID: 10002 RVA: 0x000679AC File Offset: 0x00065BAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x06002713 RID: 10003 RVA: 0x000679AF File Offset: 0x00065BAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AttachTargetEntityInfo.Descriptor;
			}
		}

		// Token: 0x06002714 RID: 10004 RVA: 0x000679B6 File Offset: 0x00065BB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttachTargetEntityInfo()
		{
		}

		// Token: 0x06002715 RID: 10005 RVA: 0x000679C9 File Offset: 0x00065BC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttachTargetEntityInfo(AttachTargetEntityInfo other) : this()
		{
			this.targetConfigId_ = other.targetConfigId_;
			this.actor_ = other.actor_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002716 RID: 10006 RVA: 0x000679FA File Offset: 0x00065BFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttachTargetEntityInfo Clone()
		{
			return new AttachTargetEntityInfo(this);
		}

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x06002717 RID: 10007 RVA: 0x00067A02 File Offset: 0x00065C02
		// (set) Token: 0x06002718 RID: 10008 RVA: 0x00067A0A File Offset: 0x00065C0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TargetConfigId
		{
			get
			{
				return this.targetConfigId_;
			}
			set
			{
				this.targetConfigId_ = value;
			}
		}

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x06002719 RID: 10009 RVA: 0x00067A13 File Offset: 0x00065C13
		// (set) Token: 0x0600271A RID: 10010 RVA: 0x00067A1B File Offset: 0x00065C1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Actor
		{
			get
			{
				return this.actor_;
			}
			set
			{
				this.actor_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x0600271B RID: 10011 RVA: 0x00067A2E File Offset: 0x00065C2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AttachTargetEntityInfo);
		}

		// Token: 0x0600271C RID: 10012 RVA: 0x00067A3C File Offset: 0x00065C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AttachTargetEntityInfo other)
		{
			return other != null && (other == this || (this.TargetConfigId == other.TargetConfigId && !(this.Actor != other.Actor) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600271D RID: 10013 RVA: 0x00067A8C File Offset: 0x00065C8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TargetConfigId != 0)
			{
				num ^= this.TargetConfigId.GetHashCode();
			}
			if (this.Actor.Length != 0)
			{
				num ^= this.Actor.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600271E RID: 10014 RVA: 0x00067AE6 File Offset: 0x00065CE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600271F RID: 10015 RVA: 0x00067AF3 File Offset: 0x00065CF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002720 RID: 10016 RVA: 0x00067AFC File Offset: 0x00065CFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TargetConfigId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TargetConfigId);
			}
			if (this.Actor.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Actor);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002721 RID: 10017 RVA: 0x00067B5C File Offset: 0x00065D5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TargetConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TargetConfigId);
			}
			if (this.Actor.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Actor);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002722 RID: 10018 RVA: 0x00067BB8 File Offset: 0x00065DB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AttachTargetEntityInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TargetConfigId != 0)
			{
				this.TargetConfigId = other.TargetConfigId;
			}
			if (other.Actor.Length != 0)
			{
				this.Actor = other.Actor;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002723 RID: 10019 RVA: 0x00067C0D File Offset: 0x00065E0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002724 RID: 10020 RVA: 0x00067C18 File Offset: 0x00065E18
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
						this.Actor = input.ReadString();
					}
				}
				else
				{
					this.TargetConfigId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002647 RID: 9799
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002648 RID: 9800
		public const int TargetConfigIdFieldNumber = 1;

		// Token: 0x04002649 RID: 9801
		private int targetConfigId_;

		// Token: 0x0400264A RID: 9802
		public const int ActorFieldNumber = 2;

		// Token: 0x0400264B RID: 9803
		private string actor_ = "";
	}
}
