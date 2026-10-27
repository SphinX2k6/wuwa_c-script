using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C6F RID: 3183
	public sealed class PhantomBattleCopyCardEffectCtx : IMessage<PhantomBattleCopyCardEffectCtx>, IMessage, IEquatable<PhantomBattleCopyCardEffectCtx>, IDeepCloneable<PhantomBattleCopyCardEffectCtx>, IBufferMessage
	{
		// Token: 0x0601141C RID: 70684 RVA: 0x00286E42 File Offset: 0x00285042
		[NullableContext(1)]
		public static PhantomBattleCopyCardEffectCtx Create()
		{
			return new PhantomBattleCopyCardEffectCtx();
		}

		// Token: 0x17003917 RID: 14615
		// (get) Token: 0x0601141D RID: 70685 RVA: 0x00286E49 File Offset: 0x00285049
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003918 RID: 14616
		// (get) Token: 0x0601141E RID: 70686 RVA: 0x00286E4C File Offset: 0x0028504C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCopyCardEffectCtx.Descriptor;
			}
		}

		// Token: 0x0601141F RID: 70687 RVA: 0x00286E53 File Offset: 0x00285053
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCopyCardEffectCtx()
		{
		}

		// Token: 0x06011420 RID: 70688 RVA: 0x00286E66 File Offset: 0x00285066
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCopyCardEffectCtx(PhantomBattleCopyCardEffectCtx other) : this()
		{
			this.phantomBattleFighterInfo_ = other.phantomBattleFighterInfo_.Clone();
			this.camp_ = other.camp_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011421 RID: 70689 RVA: 0x00286E9C File Offset: 0x0028509C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCopyCardEffectCtx Clone()
		{
			return new PhantomBattleCopyCardEffectCtx(this);
		}

		// Token: 0x17003919 RID: 14617
		// (get) Token: 0x06011422 RID: 70690 RVA: 0x00286EA4 File Offset: 0x002850A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleFighterInfo> PhantomBattleFighterInfo
		{
			get
			{
				return this.phantomBattleFighterInfo_;
			}
		}

		// Token: 0x1700391A RID: 14618
		// (get) Token: 0x06011423 RID: 70691 RVA: 0x00286EAC File Offset: 0x002850AC
		// (set) Token: 0x06011424 RID: 70692 RVA: 0x00286EB4 File Offset: 0x002850B4
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

		// Token: 0x06011425 RID: 70693 RVA: 0x00286EBD File Offset: 0x002850BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCopyCardEffectCtx);
		}

		// Token: 0x06011426 RID: 70694 RVA: 0x00286ECC File Offset: 0x002850CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCopyCardEffectCtx other)
		{
			return other != null && (other == this || (this.phantomBattleFighterInfo_.Equals(other.phantomBattleFighterInfo_) && this.Camp == other.Camp && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011427 RID: 70695 RVA: 0x00286F1C File Offset: 0x0028511C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.phantomBattleFighterInfo_.GetHashCode();
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

		// Token: 0x06011428 RID: 70696 RVA: 0x00286F6F File Offset: 0x0028516F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011429 RID: 70697 RVA: 0x00286F7C File Offset: 0x0028517C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601142A RID: 70698 RVA: 0x00286F88 File Offset: 0x00285188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.phantomBattleFighterInfo_.WriteTo(ref output, PhantomBattleCopyCardEffectCtx._repeated_phantomBattleFighterInfo_codec);
			if (this.Camp != PhantomBattleEffectCardCamp.GamerFighterNpc)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.Camp);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601142B RID: 70699 RVA: 0x00286FD8 File Offset: 0x002851D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.phantomBattleFighterInfo_.CalculateSize(PhantomBattleCopyCardEffectCtx._repeated_phantomBattleFighterInfo_codec);
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

		// Token: 0x0601142C RID: 70700 RVA: 0x0028702C File Offset: 0x0028522C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleCopyCardEffectCtx other)
		{
			if (other == null)
			{
				return;
			}
			this.phantomBattleFighterInfo_.Add(other.phantomBattleFighterInfo_);
			if (other.Camp != PhantomBattleEffectCardCamp.GamerFighterNpc)
			{
				this.Camp = other.Camp;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601142D RID: 70701 RVA: 0x00287079 File Offset: 0x00285279
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601142E RID: 70702 RVA: 0x00287084 File Offset: 0x00285284
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
					if (num != 16U)
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
					this.phantomBattleFighterInfo_.AddEntriesFrom(ref input, PhantomBattleCopyCardEffectCtx._repeated_phantomBattleFighterInfo_codec);
				}
			}
		}

		// Token: 0x04006D28 RID: 27944
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006D29 RID: 27945
		public const int PhantomBattleFighterInfoFieldNumber = 1;

		// Token: 0x04006D2A RID: 27946
		private static readonly FieldCodec<PhantomBattleFighterInfo> _repeated_phantomBattleFighterInfo_codec = FieldCodec.ForMessage<PhantomBattleFighterInfo>(10U, Aki.Protocol.PhantomBattleFighterInfo.Parser);

		// Token: 0x04006D2B RID: 27947
		private readonly RepeatedField<PhantomBattleFighterInfo> phantomBattleFighterInfo_ = new RepeatedField<PhantomBattleFighterInfo>();

		// Token: 0x04006D2C RID: 27948
		public const int CampFieldNumber = 2;

		// Token: 0x04006D2D RID: 27949
		private PhantomBattleEffectCardCamp camp_;
	}
}
