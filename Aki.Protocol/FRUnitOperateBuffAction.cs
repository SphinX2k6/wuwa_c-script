using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000650 RID: 1616
	public sealed class FRUnitOperateBuffAction : IMessage<FRUnitOperateBuffAction>, IMessage, IEquatable<FRUnitOperateBuffAction>, IDeepCloneable<FRUnitOperateBuffAction>, IBufferMessage
	{
		// Token: 0x060094C5 RID: 38085 RVA: 0x00167729 File Offset: 0x00165929
		[NullableContext(1)]
		public static FRUnitOperateBuffAction Create()
		{
			return new FRUnitOperateBuffAction();
		}

		// Token: 0x17001D95 RID: 7573
		// (get) Token: 0x060094C6 RID: 38086 RVA: 0x00167730 File Offset: 0x00165930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FRUnitOperateBuffAction> Parser
		{
			get
			{
				return FRUnitOperateBuffAction._parser;
			}
		}

		// Token: 0x17001D96 RID: 7574
		// (get) Token: 0x060094C7 RID: 38087 RVA: 0x00167737 File Offset: 0x00165937
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D97 RID: 7575
		// (get) Token: 0x060094C8 RID: 38088 RVA: 0x0016773A File Offset: 0x0016593A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FRUnitOperateBuffAction.Descriptor;
			}
		}

		// Token: 0x060094C9 RID: 38089 RVA: 0x00167741 File Offset: 0x00165941
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRUnitOperateBuffAction()
		{
		}

		// Token: 0x060094CA RID: 38090 RVA: 0x0016774C File Offset: 0x0016594C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRUnitOperateBuffAction(FRUnitOperateBuffAction other) : this()
		{
			this.type_ = other.type_;
			this.targetUnitIncId_ = other.targetUnitIncId_;
			this.buff_ = ((other.buff_ != null) ? other.buff_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060094CB RID: 38091 RVA: 0x001677A4 File Offset: 0x001659A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRUnitOperateBuffAction Clone()
		{
			return new FRUnitOperateBuffAction(this);
		}

		// Token: 0x17001D98 RID: 7576
		// (get) Token: 0x060094CC RID: 38092 RVA: 0x001677AC File Offset: 0x001659AC
		// (set) Token: 0x060094CD RID: 38093 RVA: 0x001677B4 File Offset: 0x001659B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRBuffOperate Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x17001D99 RID: 7577
		// (get) Token: 0x060094CE RID: 38094 RVA: 0x001677BD File Offset: 0x001659BD
		// (set) Token: 0x060094CF RID: 38095 RVA: 0x001677C5 File Offset: 0x001659C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TargetUnitIncId
		{
			get
			{
				return this.targetUnitIncId_;
			}
			set
			{
				this.targetUnitIncId_ = value;
			}
		}

		// Token: 0x17001D9A RID: 7578
		// (get) Token: 0x060094D0 RID: 38096 RVA: 0x001677CE File Offset: 0x001659CE
		// (set) Token: 0x060094D1 RID: 38097 RVA: 0x001677D6 File Offset: 0x001659D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayBuff Buff
		{
			get
			{
				return this.buff_;
			}
			set
			{
				this.buff_ = value;
			}
		}

		// Token: 0x060094D2 RID: 38098 RVA: 0x001677DF File Offset: 0x001659DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FRUnitOperateBuffAction);
		}

		// Token: 0x060094D3 RID: 38099 RVA: 0x001677F0 File Offset: 0x001659F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FRUnitOperateBuffAction other)
		{
			return other != null && (other == this || (this.Type == other.Type && this.TargetUnitIncId == other.TargetUnitIncId && object.Equals(this.Buff, other.Buff) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060094D4 RID: 38100 RVA: 0x00167850 File Offset: 0x00165A50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Type != FRBuffOperate.BuffOpAdd)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.TargetUnitIncId != 0)
			{
				num ^= this.TargetUnitIncId.GetHashCode();
			}
			if (this.buff_ != null)
			{
				num ^= this.Buff.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060094D5 RID: 38101 RVA: 0x001678C4 File Offset: 0x00165AC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060094D6 RID: 38102 RVA: 0x001678D1 File Offset: 0x00165AD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060094D7 RID: 38103 RVA: 0x001678DC File Offset: 0x00165ADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Type != FRBuffOperate.BuffOpAdd)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.Type);
			}
			if (this.TargetUnitIncId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.TargetUnitIncId);
			}
			if (this.buff_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Buff);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060094D8 RID: 38104 RVA: 0x00167950 File Offset: 0x00165B50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Type != FRBuffOperate.BuffOpAdd)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this.TargetUnitIncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TargetUnitIncId);
			}
			if (this.buff_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Buff);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060094D9 RID: 38105 RVA: 0x001679C0 File Offset: 0x00165BC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FRUnitOperateBuffAction other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Type != FRBuffOperate.BuffOpAdd)
			{
				this.Type = other.Type;
			}
			if (other.TargetUnitIncId != 0)
			{
				this.TargetUnitIncId = other.TargetUnitIncId;
			}
			if (other.buff_ != null)
			{
				if (this.buff_ == null)
				{
					this.Buff = new FloroRanchPlayBuff();
				}
				this.Buff.MergeFrom(other.Buff);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060094DA RID: 38106 RVA: 0x00167A3C File Offset: 0x00165C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060094DB RID: 38107 RVA: 0x00167A48 File Offset: 0x00165C48
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
					if (num != 16U)
					{
						if (num != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.buff_ == null)
							{
								this.Buff = new FloroRanchPlayBuff();
							}
							input.ReadMessage(this.Buff);
						}
					}
					else
					{
						this.TargetUnitIncId = input.ReadInt32();
					}
				}
				else
				{
					this.Type = (FRBuffOperate)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400478C RID: 18316
		private static readonly MessageParser<FRUnitOperateBuffAction> _parser = new MessageParser<FRUnitOperateBuffAction>(() => new FRUnitOperateBuffAction());

		// Token: 0x0400478D RID: 18317
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400478E RID: 18318
		public const int TypeFieldNumber = 1;

		// Token: 0x0400478F RID: 18319
		private FRBuffOperate type_;

		// Token: 0x04004790 RID: 18320
		public const int TargetUnitIncIdFieldNumber = 2;

		// Token: 0x04004791 RID: 18321
		private int targetUnitIncId_;

		// Token: 0x04004792 RID: 18322
		public const int BuffFieldNumber = 3;

		// Token: 0x04004793 RID: 18323
		private FloroRanchPlayBuff buff_;
	}
}
