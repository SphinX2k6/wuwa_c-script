using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CAF RID: 3247
	public sealed class PhantomBattleTakeTargetAttrEffectCtx : IMessage<PhantomBattleTakeTargetAttrEffectCtx>, IMessage, IEquatable<PhantomBattleTakeTargetAttrEffectCtx>, IDeepCloneable<PhantomBattleTakeTargetAttrEffectCtx>, IBufferMessage
	{
		// Token: 0x060119C1 RID: 72129 RVA: 0x002949D9 File Offset: 0x00292BD9
		[NullableContext(1)]
		public static PhantomBattleTakeTargetAttrEffectCtx Create()
		{
			return new PhantomBattleTakeTargetAttrEffectCtx();
		}

		// Token: 0x17003A58 RID: 14936
		// (get) Token: 0x060119C2 RID: 72130 RVA: 0x002949E0 File Offset: 0x00292BE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003A59 RID: 14937
		// (get) Token: 0x060119C3 RID: 72131 RVA: 0x002949E3 File Offset: 0x00292BE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleTakeTargetAttrEffectCtx.Descriptor;
			}
		}

		// Token: 0x060119C4 RID: 72132 RVA: 0x002949EA File Offset: 0x00292BEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleTakeTargetAttrEffectCtx()
		{
		}

		// Token: 0x060119C5 RID: 72133 RVA: 0x002949F4 File Offset: 0x00292BF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleTakeTargetAttrEffectCtx(PhantomBattleTakeTargetAttrEffectCtx other) : this()
		{
			this.targetUid_ = other.targetUid_;
			this.takeAttrInfo_ = ((other.takeAttrInfo_ != null) ? other.takeAttrInfo_.Clone() : null);
			this.camp_ = other.camp_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060119C6 RID: 72134 RVA: 0x00294A4C File Offset: 0x00292C4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleTakeTargetAttrEffectCtx Clone()
		{
			return new PhantomBattleTakeTargetAttrEffectCtx(this);
		}

		// Token: 0x17003A5A RID: 14938
		// (get) Token: 0x060119C7 RID: 72135 RVA: 0x00294A54 File Offset: 0x00292C54
		// (set) Token: 0x060119C8 RID: 72136 RVA: 0x00294A5C File Offset: 0x00292C5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TargetUid
		{
			get
			{
				return this.targetUid_;
			}
			set
			{
				this.targetUid_ = value;
			}
		}

		// Token: 0x17003A5B RID: 14939
		// (get) Token: 0x060119C9 RID: 72137 RVA: 0x00294A65 File Offset: 0x00292C65
		// (set) Token: 0x060119CA RID: 72138 RVA: 0x00294A6D File Offset: 0x00292C6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleCardAttrInfo TakeAttrInfo
		{
			get
			{
				return this.takeAttrInfo_;
			}
			set
			{
				this.takeAttrInfo_ = value;
			}
		}

		// Token: 0x17003A5C RID: 14940
		// (get) Token: 0x060119CB RID: 72139 RVA: 0x00294A76 File Offset: 0x00292C76
		// (set) Token: 0x060119CC RID: 72140 RVA: 0x00294A7E File Offset: 0x00292C7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleEffectCardCamp Camp
		{
			get
			{
				return this.camp_;
			}
			set
			{
				this.camp_ = value;
			}
		}

		// Token: 0x060119CD RID: 72141 RVA: 0x00294A87 File Offset: 0x00292C87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleTakeTargetAttrEffectCtx);
		}

		// Token: 0x060119CE RID: 72142 RVA: 0x00294A98 File Offset: 0x00292C98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleTakeTargetAttrEffectCtx other)
		{
			return other != null && (other == this || (this.TargetUid == other.TargetUid && object.Equals(this.TakeAttrInfo, other.TakeAttrInfo) && this.Camp == other.Camp && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060119CF RID: 72143 RVA: 0x00294AF8 File Offset: 0x00292CF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TargetUid != 0)
			{
				num ^= this.TargetUid.GetHashCode();
			}
			if (this.takeAttrInfo_ != null)
			{
				num ^= this.TakeAttrInfo.GetHashCode();
			}
			if (this.Camp != PhantomBattleEffectCardCamp.GamerFighterNpc)
			{
				num ^= this.Camp.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060119D0 RID: 72144 RVA: 0x00294B6C File Offset: 0x00292D6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060119D1 RID: 72145 RVA: 0x00294B79 File Offset: 0x00292D79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060119D2 RID: 72146 RVA: 0x00294B84 File Offset: 0x00292D84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TargetUid != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TargetUid);
			}
			if (this.takeAttrInfo_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.TakeAttrInfo);
			}
			if (this.Camp != PhantomBattleEffectCardCamp.GamerFighterNpc)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.Camp);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060119D3 RID: 72147 RVA: 0x00294BF8 File Offset: 0x00292DF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TargetUid != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TargetUid);
			}
			if (this.takeAttrInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TakeAttrInfo);
			}
			if (this.Camp != PhantomBattleEffectCardCamp.GamerFighterNpc)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Camp);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060119D4 RID: 72148 RVA: 0x00294C68 File Offset: 0x00292E68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleTakeTargetAttrEffectCtx other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TargetUid != 0)
			{
				this.TargetUid = other.TargetUid;
			}
			if (other.takeAttrInfo_ != null)
			{
				if (this.takeAttrInfo_ == null)
				{
					this.TakeAttrInfo = new NpcPhantomBattleCardAttrInfo();
				}
				this.TakeAttrInfo.MergeFrom(other.TakeAttrInfo);
			}
			if (other.Camp != PhantomBattleEffectCardCamp.GamerFighterNpc)
			{
				this.Camp = other.Camp;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060119D5 RID: 72149 RVA: 0x00294CE4 File Offset: 0x00292EE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060119D6 RID: 72150 RVA: 0x00294CF0 File Offset: 0x00292EF0
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
						if (num != 40U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Camp = (PhantomBattleEffectCardCamp)input.ReadEnum();
						}
					}
					else
					{
						if (this.takeAttrInfo_ == null)
						{
							this.TakeAttrInfo = new NpcPhantomBattleCardAttrInfo();
						}
						input.ReadMessage(this.TakeAttrInfo);
					}
				}
				else
				{
					this.TargetUid = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006F4D RID: 28493
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006F4E RID: 28494
		public const int TargetUidFieldNumber = 1;

		// Token: 0x04006F4F RID: 28495
		private int targetUid_;

		// Token: 0x04006F50 RID: 28496
		public const int TakeAttrInfoFieldNumber = 2;

		// Token: 0x04006F51 RID: 28497
		private NpcPhantomBattleCardAttrInfo takeAttrInfo_;

		// Token: 0x04006F52 RID: 28498
		public const int CampFieldNumber = 5;

		// Token: 0x04006F53 RID: 28499
		private PhantomBattleEffectCardCamp camp_;
	}
}
