using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CBF RID: 3263
	public sealed class PhantomBattleTakeTargetAttrEffectCtx : IMessage<PhantomBattleTakeTargetAttrEffectCtx>, IMessage, IEquatable<PhantomBattleTakeTargetAttrEffectCtx>, IDeepCloneable<PhantomBattleTakeTargetAttrEffectCtx>, IBufferMessage
	{
		// Token: 0x06011AC1 RID: 72385 RVA: 0x00296739 File Offset: 0x00294939
		[NullableContext(1)]
		public static PhantomBattleTakeTargetAttrEffectCtx Create()
		{
			return new PhantomBattleTakeTargetAttrEffectCtx();
		}

		// Token: 0x17003A8F RID: 14991
		// (get) Token: 0x06011AC2 RID: 72386 RVA: 0x00296740 File Offset: 0x00294940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003A90 RID: 14992
		// (get) Token: 0x06011AC3 RID: 72387 RVA: 0x00296743 File Offset: 0x00294943
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleTakeTargetAttrEffectCtx.Descriptor;
			}
		}

		// Token: 0x06011AC4 RID: 72388 RVA: 0x0029674A File Offset: 0x0029494A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleTakeTargetAttrEffectCtx()
		{
		}

		// Token: 0x06011AC5 RID: 72389 RVA: 0x00296754 File Offset: 0x00294954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleTakeTargetAttrEffectCtx(PhantomBattleTakeTargetAttrEffectCtx other) : this()
		{
			this.targetUid_ = other.targetUid_;
			this.takeAttrInfo_ = ((other.takeAttrInfo_ != null) ? other.takeAttrInfo_.Clone() : null);
			this.camp_ = other.camp_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011AC6 RID: 72390 RVA: 0x002967AC File Offset: 0x002949AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleTakeTargetAttrEffectCtx Clone()
		{
			return new PhantomBattleTakeTargetAttrEffectCtx(this);
		}

		// Token: 0x17003A91 RID: 14993
		// (get) Token: 0x06011AC7 RID: 72391 RVA: 0x002967B4 File Offset: 0x002949B4
		// (set) Token: 0x06011AC8 RID: 72392 RVA: 0x002967BC File Offset: 0x002949BC
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

		// Token: 0x17003A92 RID: 14994
		// (get) Token: 0x06011AC9 RID: 72393 RVA: 0x002967C5 File Offset: 0x002949C5
		// (set) Token: 0x06011ACA RID: 72394 RVA: 0x002967CD File Offset: 0x002949CD
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

		// Token: 0x17003A93 RID: 14995
		// (get) Token: 0x06011ACB RID: 72395 RVA: 0x002967D6 File Offset: 0x002949D6
		// (set) Token: 0x06011ACC RID: 72396 RVA: 0x002967DE File Offset: 0x002949DE
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

		// Token: 0x06011ACD RID: 72397 RVA: 0x002967E7 File Offset: 0x002949E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleTakeTargetAttrEffectCtx);
		}

		// Token: 0x06011ACE RID: 72398 RVA: 0x002967F8 File Offset: 0x002949F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleTakeTargetAttrEffectCtx other)
		{
			return other != null && (other == this || (this.TargetUid == other.TargetUid && object.Equals(this.TakeAttrInfo, other.TakeAttrInfo) && this.Camp == other.Camp && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011ACF RID: 72399 RVA: 0x00296858 File Offset: 0x00294A58
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

		// Token: 0x06011AD0 RID: 72400 RVA: 0x002968CC File Offset: 0x00294ACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011AD1 RID: 72401 RVA: 0x002968D9 File Offset: 0x00294AD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011AD2 RID: 72402 RVA: 0x002968E4 File Offset: 0x00294AE4
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

		// Token: 0x06011AD3 RID: 72403 RVA: 0x00296958 File Offset: 0x00294B58
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

		// Token: 0x06011AD4 RID: 72404 RVA: 0x002969C8 File Offset: 0x00294BC8
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

		// Token: 0x06011AD5 RID: 72405 RVA: 0x00296A44 File Offset: 0x00294C44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011AD6 RID: 72406 RVA: 0x00296A50 File Offset: 0x00294C50
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

		// Token: 0x04006F39 RID: 28473
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006F3A RID: 28474
		public const int TargetUidFieldNumber = 1;

		// Token: 0x04006F3B RID: 28475
		private int targetUid_;

		// Token: 0x04006F3C RID: 28476
		public const int TakeAttrInfoFieldNumber = 2;

		// Token: 0x04006F3D RID: 28477
		private NpcPhantomBattleCardAttrInfo takeAttrInfo_;

		// Token: 0x04006F3E RID: 28478
		public const int CampFieldNumber = 5;

		// Token: 0x04006F3F RID: 28479
		private PhantomBattleEffectCardCamp camp_;
	}
}
