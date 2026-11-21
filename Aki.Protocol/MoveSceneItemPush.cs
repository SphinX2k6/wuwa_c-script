using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AB1 RID: 2737
	[NetMessage(EMessageId.MoveSceneItemPush)]
	public sealed class MoveSceneItemPush : IMessage<MoveSceneItemPush>, IMessage, IEquatable<MoveSceneItemPush>, IDeepCloneable<MoveSceneItemPush>, IBufferMessage
	{
		// Token: 0x0600EEA5 RID: 61093 RVA: 0x0022E3BF File Offset: 0x0022C5BF
		[NullableContext(1)]
		public static MoveSceneItemPush Create()
		{
			return new MoveSceneItemPush();
		}

		// Token: 0x17003089 RID: 12425
		// (get) Token: 0x0600EEA6 RID: 61094 RVA: 0x0022E3C6 File Offset: 0x0022C5C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700308A RID: 12426
		// (get) Token: 0x0600EEA7 RID: 61095 RVA: 0x0022E3C9 File Offset: 0x0022C5C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MoveSceneItemPush.Descriptor;
			}
		}

		// Token: 0x0600EEA8 RID: 61096 RVA: 0x0022E3D0 File Offset: 0x0022C5D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoveSceneItemPush()
		{
		}

		// Token: 0x0600EEA9 RID: 61097 RVA: 0x0022E3E4 File Offset: 0x0022C5E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoveSceneItemPush(MoveSceneItemPush other) : this()
		{
			this.combatCommon_ = ((other.combatCommon_ != null) ? other.combatCommon_.Clone() : null);
			this.moveInfos_ = other.moveInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EEAA RID: 61098 RVA: 0x0022E435 File Offset: 0x0022C635
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoveSceneItemPush Clone()
		{
			return new MoveSceneItemPush(this);
		}

		// Token: 0x1700308B RID: 12427
		// (get) Token: 0x0600EEAB RID: 61099 RVA: 0x0022E43D File Offset: 0x0022C63D
		// (set) Token: 0x0600EEAC RID: 61100 RVA: 0x0022E445 File Offset: 0x0022C645
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

		// Token: 0x1700308C RID: 12428
		// (get) Token: 0x0600EEAD RID: 61101 RVA: 0x0022E44E File Offset: 0x0022C64E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MoveSampleSceneItem> MoveInfos
		{
			get
			{
				return this.moveInfos_;
			}
		}

		// Token: 0x0600EEAE RID: 61102 RVA: 0x0022E456 File Offset: 0x0022C656
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MoveSceneItemPush);
		}

		// Token: 0x0600EEAF RID: 61103 RVA: 0x0022E464 File Offset: 0x0022C664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MoveSceneItemPush other)
		{
			return other != null && (other == this || (object.Equals(this.CombatCommon, other.CombatCommon) && this.moveInfos_.Equals(other.moveInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EEB0 RID: 61104 RVA: 0x0022E4B8 File Offset: 0x0022C6B8
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

		// Token: 0x0600EEB1 RID: 61105 RVA: 0x0022E502 File Offset: 0x0022C702
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EEB2 RID: 61106 RVA: 0x0022E50F File Offset: 0x0022C70F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EEB3 RID: 61107 RVA: 0x0022E518 File Offset: 0x0022C718
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

		// Token: 0x0600EEB4 RID: 61108 RVA: 0x0022E568 File Offset: 0x0022C768
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

		// Token: 0x0600EEB5 RID: 61109 RVA: 0x0022E5BC File Offset: 0x0022C7BC
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

		// Token: 0x0600EEB6 RID: 61110 RVA: 0x0022E621 File Offset: 0x0022C821
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EEB7 RID: 61111 RVA: 0x0022E62C File Offset: 0x0022C82C
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
					if (num != 98U)
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

		// Token: 0x040060FD RID: 24829
		private UnknownFieldSet _unknownFields;

		// Token: 0x040060FE RID: 24830
		public const int CombatCommonFieldNumber = 5;

		// Token: 0x040060FF RID: 24831
		private CombatCommon combatCommon_;

		// Token: 0x04006100 RID: 24832
		public const int MoveInfosFieldNumber = 12;

		// Token: 0x04006101 RID: 24833
		private static readonly FieldCodec<MoveSampleSceneItem> _repeated_moveInfos_codec = FieldCodec.ForMessage<MoveSampleSceneItem>(98U, MoveSampleSceneItem.Parser);

		// Token: 0x04006102 RID: 24834
		private readonly RepeatedField<MoveSampleSceneItem> moveInfos_ = new RepeatedField<MoveSampleSceneItem>();
	}
}
