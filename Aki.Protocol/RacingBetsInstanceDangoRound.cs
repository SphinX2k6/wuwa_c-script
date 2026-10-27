using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E63 RID: 3683
	public sealed class RacingBetsInstanceDangoRound : IMessage<RacingBetsInstanceDangoRound>, IMessage, IEquatable<RacingBetsInstanceDangoRound>, IDeepCloneable<RacingBetsInstanceDangoRound>, IBufferMessage
	{
		// Token: 0x06013C72 RID: 81010 RVA: 0x002E0774 File Offset: 0x002DE974
		[NullableContext(1)]
		public static RacingBetsInstanceDangoRound Create()
		{
			return new RacingBetsInstanceDangoRound();
		}

		// Token: 0x170041B2 RID: 16818
		// (get) Token: 0x06013C73 RID: 81011 RVA: 0x002E077B File Offset: 0x002DE97B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RacingBetsInstanceDangoRound> Parser
		{
			get
			{
				return RacingBetsInstanceDangoRound._parser;
			}
		}

		// Token: 0x170041B3 RID: 16819
		// (get) Token: 0x06013C74 RID: 81012 RVA: 0x002E0782 File Offset: 0x002DE982
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170041B4 RID: 16820
		// (get) Token: 0x06013C75 RID: 81013 RVA: 0x002E0785 File Offset: 0x002DE985
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsInstanceDangoRound.Descriptor;
			}
		}

		// Token: 0x06013C76 RID: 81014 RVA: 0x002E078C File Offset: 0x002DE98C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsInstanceDangoRound()
		{
		}

		// Token: 0x06013C77 RID: 81015 RVA: 0x002E079F File Offset: 0x002DE99F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsInstanceDangoRound(RacingBetsInstanceDangoRound other) : this()
		{
			this.dangoId_ = other.dangoId_;
			this.actionList_ = other.actionList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013C78 RID: 81016 RVA: 0x002E07D5 File Offset: 0x002DE9D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsInstanceDangoRound Clone()
		{
			return new RacingBetsInstanceDangoRound(this);
		}

		// Token: 0x170041B5 RID: 16821
		// (get) Token: 0x06013C79 RID: 81017 RVA: 0x002E07DD File Offset: 0x002DE9DD
		// (set) Token: 0x06013C7A RID: 81018 RVA: 0x002E07E5 File Offset: 0x002DE9E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DangoId
		{
			get
			{
				return this.dangoId_;
			}
			set
			{
				this.dangoId_ = value;
			}
		}

		// Token: 0x170041B6 RID: 16822
		// (get) Token: 0x06013C7B RID: 81019 RVA: 0x002E07EE File Offset: 0x002DE9EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RacingBetsInstanceDangoAction> ActionList
		{
			get
			{
				return this.actionList_;
			}
		}

		// Token: 0x06013C7C RID: 81020 RVA: 0x002E07F6 File Offset: 0x002DE9F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsInstanceDangoRound);
		}

		// Token: 0x06013C7D RID: 81021 RVA: 0x002E0804 File Offset: 0x002DEA04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsInstanceDangoRound other)
		{
			return other != null && (other == this || (this.DangoId == other.DangoId && this.actionList_.Equals(other.actionList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013C7E RID: 81022 RVA: 0x002E0854 File Offset: 0x002DEA54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DangoId != 0)
			{
				num ^= this.DangoId.GetHashCode();
			}
			num ^= this.actionList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013C7F RID: 81023 RVA: 0x002E08A1 File Offset: 0x002DEAA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013C80 RID: 81024 RVA: 0x002E08AE File Offset: 0x002DEAAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013C81 RID: 81025 RVA: 0x002E08B8 File Offset: 0x002DEAB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DangoId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.DangoId);
			}
			this.actionList_.WriteTo(ref output, RacingBetsInstanceDangoRound._repeated_actionList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013C82 RID: 81026 RVA: 0x002E0908 File Offset: 0x002DEB08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DangoId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DangoId);
			}
			num += this.actionList_.CalculateSize(RacingBetsInstanceDangoRound._repeated_actionList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013C83 RID: 81027 RVA: 0x002E095C File Offset: 0x002DEB5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsInstanceDangoRound other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DangoId != 0)
			{
				this.DangoId = other.DangoId;
			}
			this.actionList_.Add(other.actionList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013C84 RID: 81028 RVA: 0x002E09A9 File Offset: 0x002DEBA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013C85 RID: 81029 RVA: 0x002E09B4 File Offset: 0x002DEBB4
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.actionList_.AddEntriesFrom(ref input, RacingBetsInstanceDangoRound._repeated_actionList_codec);
					}
				}
				else
				{
					this.DangoId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040078F6 RID: 30966
		private static readonly MessageParser<RacingBetsInstanceDangoRound> _parser = new MessageParser<RacingBetsInstanceDangoRound>(() => new RacingBetsInstanceDangoRound());

		// Token: 0x040078F7 RID: 30967
		private UnknownFieldSet _unknownFields;

		// Token: 0x040078F8 RID: 30968
		public const int DangoIdFieldNumber = 1;

		// Token: 0x040078F9 RID: 30969
		private int dangoId_;

		// Token: 0x040078FA RID: 30970
		public const int ActionListFieldNumber = 2;

		// Token: 0x040078FB RID: 30971
		private static readonly FieldCodec<RacingBetsInstanceDangoAction> _repeated_actionList_codec = FieldCodec.ForMessage<RacingBetsInstanceDangoAction>(18U, RacingBetsInstanceDangoAction.Parser);

		// Token: 0x040078FC RID: 30972
		private readonly RepeatedField<RacingBetsInstanceDangoAction> actionList_ = new RepeatedField<RacingBetsInstanceDangoAction>();
	}
}
