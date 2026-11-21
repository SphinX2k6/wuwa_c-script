using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AB0 RID: 2736
	[NetMessage(EMessageId.MoveSceneItemNotify)]
	public sealed class MoveSceneItemNotify : IMessage<MoveSceneItemNotify>, IMessage, IEquatable<MoveSceneItemNotify>, IDeepCloneable<MoveSceneItemNotify>, IBufferMessage
	{
		// Token: 0x0600EE91 RID: 61073 RVA: 0x0022E0D0 File Offset: 0x0022C2D0
		[NullableContext(1)]
		public static MoveSceneItemNotify Create()
		{
			return new MoveSceneItemNotify();
		}

		// Token: 0x17003085 RID: 12421
		// (get) Token: 0x0600EE92 RID: 61074 RVA: 0x0022E0D7 File Offset: 0x0022C2D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003086 RID: 12422
		// (get) Token: 0x0600EE93 RID: 61075 RVA: 0x0022E0DA File Offset: 0x0022C2DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MoveSceneItemNotify.Descriptor;
			}
		}

		// Token: 0x0600EE94 RID: 61076 RVA: 0x0022E0E1 File Offset: 0x0022C2E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoveSceneItemNotify()
		{
		}

		// Token: 0x0600EE95 RID: 61077 RVA: 0x0022E0F4 File Offset: 0x0022C2F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoveSceneItemNotify(MoveSceneItemNotify other) : this()
		{
			this.combatCommon_ = ((other.combatCommon_ != null) ? other.combatCommon_.Clone() : null);
			this.moveInfos_ = other.moveInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EE96 RID: 61078 RVA: 0x0022E145 File Offset: 0x0022C345
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoveSceneItemNotify Clone()
		{
			return new MoveSceneItemNotify(this);
		}

		// Token: 0x17003087 RID: 12423
		// (get) Token: 0x0600EE97 RID: 61079 RVA: 0x0022E14D File Offset: 0x0022C34D
		// (set) Token: 0x0600EE98 RID: 61080 RVA: 0x0022E155 File Offset: 0x0022C355
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

		// Token: 0x17003088 RID: 12424
		// (get) Token: 0x0600EE99 RID: 61081 RVA: 0x0022E15E File Offset: 0x0022C35E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MoveSampleSceneItem> MoveInfos
		{
			get
			{
				return this.moveInfos_;
			}
		}

		// Token: 0x0600EE9A RID: 61082 RVA: 0x0022E166 File Offset: 0x0022C366
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MoveSceneItemNotify);
		}

		// Token: 0x0600EE9B RID: 61083 RVA: 0x0022E174 File Offset: 0x0022C374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MoveSceneItemNotify other)
		{
			return other != null && (other == this || (object.Equals(this.CombatCommon, other.CombatCommon) && this.moveInfos_.Equals(other.moveInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EE9C RID: 61084 RVA: 0x0022E1C8 File Offset: 0x0022C3C8
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

		// Token: 0x0600EE9D RID: 61085 RVA: 0x0022E212 File Offset: 0x0022C412
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EE9E RID: 61086 RVA: 0x0022E21F File Offset: 0x0022C41F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EE9F RID: 61087 RVA: 0x0022E228 File Offset: 0x0022C428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.moveInfos_.WriteTo(ref output, MoveSceneItemNotify._repeated_moveInfos_codec);
			if (this.combatCommon_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.CombatCommon);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EEA0 RID: 61088 RVA: 0x0022E278 File Offset: 0x0022C478
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

		// Token: 0x0600EEA1 RID: 61089 RVA: 0x0022E2CC File Offset: 0x0022C4CC
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

		// Token: 0x0600EEA2 RID: 61090 RVA: 0x0022E331 File Offset: 0x0022C531
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EEA3 RID: 61091 RVA: 0x0022E33C File Offset: 0x0022C53C
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
					if (num != 114U)
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

		// Token: 0x040060F7 RID: 24823
		private UnknownFieldSet _unknownFields;

		// Token: 0x040060F8 RID: 24824
		public const int CombatCommonFieldNumber = 14;

		// Token: 0x040060F9 RID: 24825
		private CombatCommon combatCommon_;

		// Token: 0x040060FA RID: 24826
		public const int MoveInfosFieldNumber = 1;

		// Token: 0x040060FB RID: 24827
		private static readonly FieldCodec<MoveSampleSceneItem> _repeated_moveInfos_codec = FieldCodec.ForMessage<MoveSampleSceneItem>(10U, MoveSampleSceneItem.Parser);

		// Token: 0x040060FC RID: 24828
		private readonly RepeatedField<MoveSampleSceneItem> moveInfos_ = new RepeatedField<MoveSampleSceneItem>();
	}
}
