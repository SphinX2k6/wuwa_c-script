using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AC2 RID: 2754
	[NetMessage(EMessageId.MoveSceneItemPush)]
	public sealed class MoveSceneItemPush : IMessage<MoveSceneItemPush>, IMessage, IEquatable<MoveSceneItemPush>, IDeepCloneable<MoveSceneItemPush>, IBufferMessage
	{
		// Token: 0x0600EFBF RID: 61375 RVA: 0x002305C3 File Offset: 0x0022E7C3
		[NullableContext(1)]
		public static MoveSceneItemPush Create()
		{
			return new MoveSceneItemPush();
		}

		// Token: 0x170030C7 RID: 12487
		// (get) Token: 0x0600EFC0 RID: 61376 RVA: 0x002305CA File Offset: 0x0022E7CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170030C8 RID: 12488
		// (get) Token: 0x0600EFC1 RID: 61377 RVA: 0x002305CD File Offset: 0x0022E7CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MoveSceneItemPush.Descriptor;
			}
		}

		// Token: 0x0600EFC2 RID: 61378 RVA: 0x002305D4 File Offset: 0x0022E7D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoveSceneItemPush()
		{
		}

		// Token: 0x0600EFC3 RID: 61379 RVA: 0x002305E8 File Offset: 0x0022E7E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoveSceneItemPush(MoveSceneItemPush other) : this()
		{
			this.combatCommon_ = ((other.combatCommon_ != null) ? other.combatCommon_.Clone() : null);
			this.moveInfos_ = other.moveInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EFC4 RID: 61380 RVA: 0x00230639 File Offset: 0x0022E839
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoveSceneItemPush Clone()
		{
			return new MoveSceneItemPush(this);
		}

		// Token: 0x170030C9 RID: 12489
		// (get) Token: 0x0600EFC5 RID: 61381 RVA: 0x00230641 File Offset: 0x0022E841
		// (set) Token: 0x0600EFC6 RID: 61382 RVA: 0x00230649 File Offset: 0x0022E849
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

		// Token: 0x170030CA RID: 12490
		// (get) Token: 0x0600EFC7 RID: 61383 RVA: 0x00230652 File Offset: 0x0022E852
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MoveSampleSceneItem> MoveInfos
		{
			get
			{
				return this.moveInfos_;
			}
		}

		// Token: 0x0600EFC8 RID: 61384 RVA: 0x0023065A File Offset: 0x0022E85A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MoveSceneItemPush);
		}

		// Token: 0x0600EFC9 RID: 61385 RVA: 0x00230668 File Offset: 0x0022E868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MoveSceneItemPush other)
		{
			return other != null && (other == this || (object.Equals(this.CombatCommon, other.CombatCommon) && this.moveInfos_.Equals(other.moveInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EFCA RID: 61386 RVA: 0x002306BC File Offset: 0x0022E8BC
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

		// Token: 0x0600EFCB RID: 61387 RVA: 0x00230706 File Offset: 0x0022E906
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EFCC RID: 61388 RVA: 0x00230713 File Offset: 0x0022E913
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EFCD RID: 61389 RVA: 0x0023071C File Offset: 0x0022E91C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.combatCommon_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.CombatCommon);
			}
			this.moveInfos_.WriteTo(ref output, MoveSceneItemPush._repeated_moveInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EFCE RID: 61390 RVA: 0x0023076C File Offset: 0x0022E96C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.combatCommon_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CombatCommon);
			}
			num += this.moveInfos_.CalculateSize(MoveSceneItemPush._repeated_moveInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600EFCF RID: 61391 RVA: 0x002307C0 File Offset: 0x0022E9C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MoveSceneItemPush other)
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

		// Token: 0x0600EFD0 RID: 61392 RVA: 0x00230825 File Offset: 0x0022EA25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EFD1 RID: 61393 RVA: 0x00230830 File Offset: 0x0022EA30
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
				if (num != 42U)
				{
					if (num != 90U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.moveInfos_.AddEntriesFrom(ref input, MoveSceneItemPush._repeated_moveInfos_codec);
					}
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
		}

		// Token: 0x040060F4 RID: 24820
		private UnknownFieldSet _unknownFields;

		// Token: 0x040060F5 RID: 24821
		public const int CombatCommonFieldNumber = 5;

		// Token: 0x040060F6 RID: 24822
		private CombatCommon combatCommon_;

		// Token: 0x040060F7 RID: 24823
		public const int MoveInfosFieldNumber = 11;

		// Token: 0x040060F8 RID: 24824
		private static readonly FieldCodec<MoveSampleSceneItem> _repeated_moveInfos_codec = FieldCodec.ForMessage<MoveSampleSceneItem>(90U, MoveSampleSceneItem.Parser);

		// Token: 0x040060F9 RID: 24825
		private readonly RepeatedField<MoveSampleSceneItem> moveInfos_ = new RepeatedField<MoveSampleSceneItem>();
	}
}
