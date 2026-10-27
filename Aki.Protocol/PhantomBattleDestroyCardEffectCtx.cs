using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C7C RID: 3196
	public sealed class PhantomBattleDestroyCardEffectCtx : IMessage<PhantomBattleDestroyCardEffectCtx>, IMessage, IEquatable<PhantomBattleDestroyCardEffectCtx>, IDeepCloneable<PhantomBattleDestroyCardEffectCtx>, IBufferMessage
	{
		// Token: 0x06011526 RID: 70950 RVA: 0x00289312 File Offset: 0x00287512
		[NullableContext(1)]
		public static PhantomBattleDestroyCardEffectCtx Create()
		{
			return new PhantomBattleDestroyCardEffectCtx();
		}

		// Token: 0x17003951 RID: 14673
		// (get) Token: 0x06011527 RID: 70951 RVA: 0x00289319 File Offset: 0x00287519
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003952 RID: 14674
		// (get) Token: 0x06011528 RID: 70952 RVA: 0x0028931C File Offset: 0x0028751C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleDestroyCardEffectCtx.Descriptor;
			}
		}

		// Token: 0x06011529 RID: 70953 RVA: 0x00289323 File Offset: 0x00287523
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDestroyCardEffectCtx()
		{
		}

		// Token: 0x0601152A RID: 70954 RVA: 0x0028932C File Offset: 0x0028752C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDestroyCardEffectCtx(PhantomBattleDestroyCardEffectCtx other) : this()
		{
			this.phantomBattleFighterInfo_ = ((other.phantomBattleFighterInfo_ != null) ? other.phantomBattleFighterInfo_.Clone() : null);
			this.camp_ = other.camp_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601152B RID: 70955 RVA: 0x00289378 File Offset: 0x00287578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDestroyCardEffectCtx Clone()
		{
			return new PhantomBattleDestroyCardEffectCtx(this);
		}

		// Token: 0x17003953 RID: 14675
		// (get) Token: 0x0601152C RID: 70956 RVA: 0x00289380 File Offset: 0x00287580
		// (set) Token: 0x0601152D RID: 70957 RVA: 0x00289388 File Offset: 0x00287588
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

		// Token: 0x17003954 RID: 14676
		// (get) Token: 0x0601152E RID: 70958 RVA: 0x00289391 File Offset: 0x00287591
		// (set) Token: 0x0601152F RID: 70959 RVA: 0x00289399 File Offset: 0x00287599
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

		// Token: 0x06011530 RID: 70960 RVA: 0x002893A2 File Offset: 0x002875A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleDestroyCardEffectCtx);
		}

		// Token: 0x06011531 RID: 70961 RVA: 0x002893B0 File Offset: 0x002875B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleDestroyCardEffectCtx other)
		{
			return other != null && (other == this || (object.Equals(this.PhantomBattleFighterInfo, other.PhantomBattleFighterInfo) && this.Camp == other.Camp && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011532 RID: 70962 RVA: 0x00289400 File Offset: 0x00287600
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

		// Token: 0x06011533 RID: 70963 RVA: 0x0028945B File Offset: 0x0028765B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011534 RID: 70964 RVA: 0x00289468 File Offset: 0x00287668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011535 RID: 70965 RVA: 0x00289474 File Offset: 0x00287674
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

		// Token: 0x06011536 RID: 70966 RVA: 0x002894D0 File Offset: 0x002876D0
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

		// Token: 0x06011537 RID: 70967 RVA: 0x00289528 File Offset: 0x00287728
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

		// Token: 0x06011538 RID: 70968 RVA: 0x00289590 File Offset: 0x00287790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011539 RID: 70969 RVA: 0x0028959C File Offset: 0x0028779C
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

		// Token: 0x04006D7E RID: 28030
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006D7F RID: 28031
		public const int PhantomBattleFighterInfoFieldNumber = 1;

		// Token: 0x04006D80 RID: 28032
		private PhantomBattleFighterInfo phantomBattleFighterInfo_;

		// Token: 0x04006D81 RID: 28033
		public const int CampFieldNumber = 5;

		// Token: 0x04006D82 RID: 28034
		private PhantomBattleEffectCardCamp camp_;
	}
}
