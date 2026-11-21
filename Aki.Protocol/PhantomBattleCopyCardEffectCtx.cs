using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C5F RID: 3167
	public sealed class PhantomBattleCopyCardEffectCtx : IMessage<PhantomBattleCopyCardEffectCtx>, IMessage, IEquatable<PhantomBattleCopyCardEffectCtx>, IDeepCloneable<PhantomBattleCopyCardEffectCtx>, IBufferMessage
	{
		// Token: 0x0601131C RID: 70428 RVA: 0x002850D2 File Offset: 0x002832D2
		[NullableContext(1)]
		public static PhantomBattleCopyCardEffectCtx Create()
		{
			return new PhantomBattleCopyCardEffectCtx();
		}

		// Token: 0x170038E0 RID: 14560
		// (get) Token: 0x0601131D RID: 70429 RVA: 0x002850D9 File Offset: 0x002832D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170038E1 RID: 14561
		// (get) Token: 0x0601131E RID: 70430 RVA: 0x002850DC File Offset: 0x002832DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCopyCardEffectCtx.Descriptor;
			}
		}

		// Token: 0x0601131F RID: 70431 RVA: 0x002850E3 File Offset: 0x002832E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCopyCardEffectCtx()
		{
		}

		// Token: 0x06011320 RID: 70432 RVA: 0x002850F6 File Offset: 0x002832F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCopyCardEffectCtx(PhantomBattleCopyCardEffectCtx other) : this()
		{
			this.phantomBattleFighterInfo_ = other.phantomBattleFighterInfo_.Clone();
			this.camp_ = other.camp_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011321 RID: 70433 RVA: 0x0028512C File Offset: 0x0028332C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCopyCardEffectCtx Clone()
		{
			return new PhantomBattleCopyCardEffectCtx(this);
		}

		// Token: 0x170038E2 RID: 14562
		// (get) Token: 0x06011322 RID: 70434 RVA: 0x00285134 File Offset: 0x00283334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleFighterInfo> PhantomBattleFighterInfo
		{
			get
			{
				return this.phantomBattleFighterInfo_;
			}
		}

		// Token: 0x170038E3 RID: 14563
		// (get) Token: 0x06011323 RID: 70435 RVA: 0x0028513C File Offset: 0x0028333C
		// (set) Token: 0x06011324 RID: 70436 RVA: 0x00285144 File Offset: 0x00283344
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

		// Token: 0x06011325 RID: 70437 RVA: 0x0028514D File Offset: 0x0028334D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCopyCardEffectCtx);
		}

		// Token: 0x06011326 RID: 70438 RVA: 0x0028515C File Offset: 0x0028335C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCopyCardEffectCtx other)
		{
			return other != null && (other == this || (this.phantomBattleFighterInfo_.Equals(other.phantomBattleFighterInfo_) && this.Camp == other.Camp && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011327 RID: 70439 RVA: 0x002851AC File Offset: 0x002833AC
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

		// Token: 0x06011328 RID: 70440 RVA: 0x002851FF File Offset: 0x002833FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011329 RID: 70441 RVA: 0x0028520C File Offset: 0x0028340C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601132A RID: 70442 RVA: 0x00285218 File Offset: 0x00283418
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

		// Token: 0x0601132B RID: 70443 RVA: 0x00285268 File Offset: 0x00283468
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

		// Token: 0x0601132C RID: 70444 RVA: 0x002852BC File Offset: 0x002834BC
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

		// Token: 0x0601132D RID: 70445 RVA: 0x00285309 File Offset: 0x00283509
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601132E RID: 70446 RVA: 0x00285314 File Offset: 0x00283514
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

		// Token: 0x04006D3C RID: 27964
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006D3D RID: 27965
		public const int PhantomBattleFighterInfoFieldNumber = 1;

		// Token: 0x04006D3E RID: 27966
		private static readonly FieldCodec<PhantomBattleFighterInfo> _repeated_phantomBattleFighterInfo_codec = FieldCodec.ForMessage<PhantomBattleFighterInfo>(10U, Aki.Protocol.PhantomBattleFighterInfo.Parser);

		// Token: 0x04006D3F RID: 27967
		private readonly RepeatedField<PhantomBattleFighterInfo> phantomBattleFighterInfo_ = new RepeatedField<PhantomBattleFighterInfo>();

		// Token: 0x04006D40 RID: 27968
		public const int CampFieldNumber = 2;

		// Token: 0x04006D41 RID: 27969
		private PhantomBattleEffectCardCamp camp_;
	}
}
