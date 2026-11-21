using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C6C RID: 3180
	public sealed class PhantomBattleDestroyCardEffectCtx : IMessage<PhantomBattleDestroyCardEffectCtx>, IMessage, IEquatable<PhantomBattleDestroyCardEffectCtx>, IDeepCloneable<PhantomBattleDestroyCardEffectCtx>, IBufferMessage
	{
		// Token: 0x06011426 RID: 70694 RVA: 0x002875A2 File Offset: 0x002857A2
		[NullableContext(1)]
		public static PhantomBattleDestroyCardEffectCtx Create()
		{
			return new PhantomBattleDestroyCardEffectCtx();
		}

		// Token: 0x1700391A RID: 14618
		// (get) Token: 0x06011427 RID: 70695 RVA: 0x002875A9 File Offset: 0x002857A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700391B RID: 14619
		// (get) Token: 0x06011428 RID: 70696 RVA: 0x002875AC File Offset: 0x002857AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleDestroyCardEffectCtx.Descriptor;
			}
		}

		// Token: 0x06011429 RID: 70697 RVA: 0x002875B3 File Offset: 0x002857B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDestroyCardEffectCtx()
		{
		}

		// Token: 0x0601142A RID: 70698 RVA: 0x002875BC File Offset: 0x002857BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDestroyCardEffectCtx(PhantomBattleDestroyCardEffectCtx other) : this()
		{
			this.phantomBattleFighterInfo_ = ((other.phantomBattleFighterInfo_ != null) ? other.phantomBattleFighterInfo_.Clone() : null);
			this.camp_ = other.camp_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601142B RID: 70699 RVA: 0x00287608 File Offset: 0x00285808
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDestroyCardEffectCtx Clone()
		{
			return new PhantomBattleDestroyCardEffectCtx(this);
		}

		// Token: 0x1700391C RID: 14620
		// (get) Token: 0x0601142C RID: 70700 RVA: 0x00287610 File Offset: 0x00285810
		// (set) Token: 0x0601142D RID: 70701 RVA: 0x00287618 File Offset: 0x00285818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleFighterInfo PhantomBattleFighterInfo
		{
			get
			{
				return this.phantomBattleFighterInfo_;
			}
			set
			{
				this.phantomBattleFighterInfo_ = value;
			}
		}

		// Token: 0x1700391D RID: 14621
		// (get) Token: 0x0601142E RID: 70702 RVA: 0x00287621 File Offset: 0x00285821
		// (set) Token: 0x0601142F RID: 70703 RVA: 0x00287629 File Offset: 0x00285829
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

		// Token: 0x06011430 RID: 70704 RVA: 0x00287632 File Offset: 0x00285832
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleDestroyCardEffectCtx);
		}

		// Token: 0x06011431 RID: 70705 RVA: 0x00287640 File Offset: 0x00285840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleDestroyCardEffectCtx other)
		{
			return other != null && (other == this || (object.Equals(this.PhantomBattleFighterInfo, other.PhantomBattleFighterInfo) && this.Camp == other.Camp && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011432 RID: 70706 RVA: 0x00287690 File Offset: 0x00285890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.phantomBattleFighterInfo_ != null)
			{
				num ^= this.PhantomBattleFighterInfo.GetHashCode();
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

		// Token: 0x06011433 RID: 70707 RVA: 0x002876EB File Offset: 0x002858EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011434 RID: 70708 RVA: 0x002876F8 File Offset: 0x002858F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011435 RID: 70709 RVA: 0x00287704 File Offset: 0x00285904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.phantomBattleFighterInfo_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.PhantomBattleFighterInfo);
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

		// Token: 0x06011436 RID: 70710 RVA: 0x00287760 File Offset: 0x00285960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.phantomBattleFighterInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PhantomBattleFighterInfo);
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

		// Token: 0x06011437 RID: 70711 RVA: 0x002877B8 File Offset: 0x002859B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleDestroyCardEffectCtx other)
		{
			if (other == null)
			{
				return;
			}
			if (other.phantomBattleFighterInfo_ != null)
			{
				if (this.phantomBattleFighterInfo_ == null)
				{
					this.PhantomBattleFighterInfo = new PhantomBattleFighterInfo();
				}
				this.PhantomBattleFighterInfo.MergeFrom(other.PhantomBattleFighterInfo);
			}
			if (other.Camp != PhantomBattleEffectCardCamp.GamerFighterNpc)
			{
				this.Camp = other.Camp;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011438 RID: 70712 RVA: 0x00287820 File Offset: 0x00285A20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011439 RID: 70713 RVA: 0x0028782C File Offset: 0x00285A2C
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
				if (num != 10U)
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
					if (this.phantomBattleFighterInfo_ == null)
					{
						this.PhantomBattleFighterInfo = new PhantomBattleFighterInfo();
					}
					input.ReadMessage(this.PhantomBattleFighterInfo);
				}
			}
		}

		// Token: 0x04006D92 RID: 28050
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006D93 RID: 28051
		public const int PhantomBattleFighterInfoFieldNumber = 1;

		// Token: 0x04006D94 RID: 28052
		private PhantomBattleFighterInfo phantomBattleFighterInfo_;

		// Token: 0x04006D95 RID: 28053
		public const int CampFieldNumber = 5;

		// Token: 0x04006D96 RID: 28054
		private PhantomBattleEffectCardCamp camp_;
	}
}
