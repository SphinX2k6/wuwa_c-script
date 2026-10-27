using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AC1 RID: 2753
	[NetMessage(EMessageId.MoveSceneItemNotify)]
	public sealed class MoveSceneItemNotify : IMessage<MoveSceneItemNotify>, IMessage, IEquatable<MoveSceneItemNotify>, IDeepCloneable<MoveSceneItemNotify>, IBufferMessage
	{
		// Token: 0x0600EFAB RID: 61355 RVA: 0x002302D4 File Offset: 0x0022E4D4
		[NullableContext(1)]
		public static MoveSceneItemNotify Create()
		{
			return new MoveSceneItemNotify();
		}

		// Token: 0x170030C3 RID: 12483
		// (get) Token: 0x0600EFAC RID: 61356 RVA: 0x002302DB File Offset: 0x0022E4DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170030C4 RID: 12484
		// (get) Token: 0x0600EFAD RID: 61357 RVA: 0x002302DE File Offset: 0x0022E4DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MoveSceneItemNotify.Descriptor;
			}
		}

		// Token: 0x0600EFAE RID: 61358 RVA: 0x002302E5 File Offset: 0x0022E4E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoveSceneItemNotify()
		{
		}

		// Token: 0x0600EFAF RID: 61359 RVA: 0x002302F8 File Offset: 0x0022E4F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoveSceneItemNotify(MoveSceneItemNotify other) : this()
		{
			this.combatCommon_ = ((other.combatCommon_ != null) ? other.combatCommon_.Clone() : null);
			this.moveInfos_ = other.moveInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EFB0 RID: 61360 RVA: 0x00230349 File Offset: 0x0022E549
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoveSceneItemNotify Clone()
		{
			return new MoveSceneItemNotify(this);
		}

		// Token: 0x170030C5 RID: 12485
		// (get) Token: 0x0600EFB1 RID: 61361 RVA: 0x00230351 File Offset: 0x0022E551
		// (set) Token: 0x0600EFB2 RID: 61362 RVA: 0x00230359 File Offset: 0x0022E559
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatCommon CombatCommon
		{
			get
			{
				return this.combatCommon_;
			}
			set
			{
				this.combatCommon_ = value;
			}
		}

		// Token: 0x170030C6 RID: 12486
		// (get) Token: 0x0600EFB3 RID: 61363 RVA: 0x00230362 File Offset: 0x0022E562
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MoveSampleSceneItem> MoveInfos
		{
			get
			{
				return this.moveInfos_;
			}
		}

		// Token: 0x0600EFB4 RID: 61364 RVA: 0x0023036A File Offset: 0x0022E56A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MoveSceneItemNotify);
		}

		// Token: 0x0600EFB5 RID: 61365 RVA: 0x00230378 File Offset: 0x0022E578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MoveSceneItemNotify other)
		{
			return other != null && (other == this || (object.Equals(this.CombatCommon, other.CombatCommon) && this.moveInfos_.Equals(other.moveInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EFB6 RID: 61366 RVA: 0x002303CC File Offset: 0x0022E5CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.combatCommon_ != null)
			{
				num ^= this.CombatCommon.GetHashCode();
			}
			num ^= this.moveInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600EFB7 RID: 61367 RVA: 0x00230416 File Offset: 0x0022E616
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EFB8 RID: 61368 RVA: 0x00230423 File Offset: 0x0022E623
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EFB9 RID: 61369 RVA: 0x0023042C File Offset: 0x0022E62C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.moveInfos_.WriteTo(ref output, MoveSceneItemNotify._repeated_moveInfos_codec);
			if (this.combatCommon_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.CombatCommon);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EFBA RID: 61370 RVA: 0x0023047C File Offset: 0x0022E67C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.combatCommon_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CombatCommon);
			}
			num += this.moveInfos_.CalculateSize(MoveSceneItemNotify._repeated_moveInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600EFBB RID: 61371 RVA: 0x002304D0 File Offset: 0x0022E6D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MoveSceneItemNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.combatCommon_ != null)
			{
				if (this.combatCommon_ == null)
				{
					this.CombatCommon = new CombatCommon();
				}
				this.CombatCommon.MergeFrom(other.CombatCommon);
			}
			this.moveInfos_.Add(other.moveInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600EFBC RID: 61372 RVA: 0x00230535 File Offset: 0x0022E735
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EFBD RID: 61373 RVA: 0x00230540 File Offset: 0x0022E740
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
				if (num != 18U)
				{
					if (num != 34U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.combatCommon_ == null)
						{
							this.CombatCommon = new CombatCommon();
						}
						input.ReadMessage(this.CombatCommon);
					}
				}
				else
				{
					this.moveInfos_.AddEntriesFrom(ref input, MoveSceneItemNotify._repeated_moveInfos_codec);
				}
			}
		}

		// Token: 0x040060EE RID: 24814
		private UnknownFieldSet _unknownFields;

		// Token: 0x040060EF RID: 24815
		public const int CombatCommonFieldNumber = 4;

		// Token: 0x040060F0 RID: 24816
		private CombatCommon combatCommon_;

		// Token: 0x040060F1 RID: 24817
		public const int MoveInfosFieldNumber = 2;

		// Token: 0x040060F2 RID: 24818
		private static readonly FieldCodec<MoveSampleSceneItem> _repeated_moveInfos_codec = FieldCodec.ForMessage<MoveSampleSceneItem>(18U, MoveSampleSceneItem.Parser);

		// Token: 0x040060F3 RID: 24819
		private readonly RepeatedField<MoveSampleSceneItem> moveInfos_ = new RepeatedField<MoveSampleSceneItem>();
	}
}
