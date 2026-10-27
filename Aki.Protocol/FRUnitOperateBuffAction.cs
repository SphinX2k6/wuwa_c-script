using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000664 RID: 1636
	public sealed class FRUnitOperateBuffAction : IMessage<FRUnitOperateBuffAction>, IMessage, IEquatable<FRUnitOperateBuffAction>, IDeepCloneable<FRUnitOperateBuffAction>, IBufferMessage
	{
		// Token: 0x0600961B RID: 38427 RVA: 0x0016A155 File Offset: 0x00168355
		[NullableContext(1)]
		public static FRUnitOperateBuffAction Create()
		{
			return new FRUnitOperateBuffAction();
		}

		// Token: 0x17001DDF RID: 7647
		// (get) Token: 0x0600961C RID: 38428 RVA: 0x0016A15C File Offset: 0x0016835C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FRUnitOperateBuffAction> Parser
		{
			get
			{
				return FRUnitOperateBuffAction._parser;
			}
		}

		// Token: 0x17001DE0 RID: 7648
		// (get) Token: 0x0600961D RID: 38429 RVA: 0x0016A163 File Offset: 0x00168363
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001DE1 RID: 7649
		// (get) Token: 0x0600961E RID: 38430 RVA: 0x0016A166 File Offset: 0x00168366
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FRUnitOperateBuffAction.Descriptor;
			}
		}

		// Token: 0x0600961F RID: 38431 RVA: 0x0016A16D File Offset: 0x0016836D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRUnitOperateBuffAction()
		{
		}

		// Token: 0x06009620 RID: 38432 RVA: 0x0016A178 File Offset: 0x00168378
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRUnitOperateBuffAction(FRUnitOperateBuffAction other) : this()
		{
			this.type_ = other.type_;
			this.targetUnitIncId_ = other.targetUnitIncId_;
			this.buff_ = ((other.buff_ != null) ? other.buff_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009621 RID: 38433 RVA: 0x0016A1D0 File Offset: 0x001683D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRUnitOperateBuffAction Clone()
		{
			return new FRUnitOperateBuffAction(this);
		}

		// Token: 0x17001DE2 RID: 7650
		// (get) Token: 0x06009622 RID: 38434 RVA: 0x0016A1D8 File Offset: 0x001683D8
		// (set) Token: 0x06009623 RID: 38435 RVA: 0x0016A1E0 File Offset: 0x001683E0
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

		// Token: 0x17001DE3 RID: 7651
		// (get) Token: 0x06009624 RID: 38436 RVA: 0x0016A1E9 File Offset: 0x001683E9
		// (set) Token: 0x06009625 RID: 38437 RVA: 0x0016A1F1 File Offset: 0x001683F1
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

		// Token: 0x17001DE4 RID: 7652
		// (get) Token: 0x06009626 RID: 38438 RVA: 0x0016A1FA File Offset: 0x001683FA
		// (set) Token: 0x06009627 RID: 38439 RVA: 0x0016A202 File Offset: 0x00168402
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

		// Token: 0x06009628 RID: 38440 RVA: 0x0016A20B File Offset: 0x0016840B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FRUnitOperateBuffAction);
		}

		// Token: 0x06009629 RID: 38441 RVA: 0x0016A21C File Offset: 0x0016841C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FRUnitOperateBuffAction other)
		{
			return other != null && (other == this || (this.Type == other.Type && this.TargetUnitIncId == other.TargetUnitIncId && object.Equals(this.Buff, other.Buff) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600962A RID: 38442 RVA: 0x0016A27C File Offset: 0x0016847C
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

		// Token: 0x0600962B RID: 38443 RVA: 0x0016A2F0 File Offset: 0x001684F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600962C RID: 38444 RVA: 0x0016A2FD File Offset: 0x001684FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600962D RID: 38445 RVA: 0x0016A308 File Offset: 0x00168508
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

		// Token: 0x0600962E RID: 38446 RVA: 0x0016A37C File Offset: 0x0016857C
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

		// Token: 0x0600962F RID: 38447 RVA: 0x0016A3EC File Offset: 0x001685EC
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

		// Token: 0x06009630 RID: 38448 RVA: 0x0016A468 File Offset: 0x00168668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009631 RID: 38449 RVA: 0x0016A474 File Offset: 0x00168674
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

		// Token: 0x04004793 RID: 18323
		private static readonly MessageParser<FRUnitOperateBuffAction> _parser = new MessageParser<FRUnitOperateBuffAction>(() => new FRUnitOperateBuffAction());

		// Token: 0x04004794 RID: 18324
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004795 RID: 18325
		public const int TypeFieldNumber = 1;

		// Token: 0x04004796 RID: 18326
		private FRBuffOperate type_;

		// Token: 0x04004797 RID: 18327
		public const int TargetUnitIncIdFieldNumber = 2;

		// Token: 0x04004798 RID: 18328
		private int targetUnitIncId_;

		// Token: 0x04004799 RID: 18329
		public const int BuffFieldNumber = 3;

		// Token: 0x0400479A RID: 18330
		private FloroRanchPlayBuff buff_;
	}
}
