using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E53 RID: 3667
	public sealed class RacingBetsInstanceDangoRound : IMessage<RacingBetsInstanceDangoRound>, IMessage, IEquatable<RacingBetsInstanceDangoRound>, IDeepCloneable<RacingBetsInstanceDangoRound>, IBufferMessage
	{
		// Token: 0x06013B8D RID: 80781 RVA: 0x002DF0B8 File Offset: 0x002DD2B8
		[NullableContext(1)]
		public static RacingBetsInstanceDangoRound Create()
		{
			return new RacingBetsInstanceDangoRound();
		}

		// Token: 0x17004188 RID: 16776
		// (get) Token: 0x06013B8E RID: 80782 RVA: 0x002DF0BF File Offset: 0x002DD2BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RacingBetsInstanceDangoRound> Parser
		{
			get
			{
				return RacingBetsInstanceDangoRound._parser;
			}
		}

		// Token: 0x17004189 RID: 16777
		// (get) Token: 0x06013B8F RID: 80783 RVA: 0x002DF0C6 File Offset: 0x002DD2C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700418A RID: 16778
		// (get) Token: 0x06013B90 RID: 80784 RVA: 0x002DF0C9 File Offset: 0x002DD2C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsInstanceDangoRound.Descriptor;
			}
		}

		// Token: 0x06013B91 RID: 80785 RVA: 0x002DF0D0 File Offset: 0x002DD2D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsInstanceDangoRound()
		{
		}

		// Token: 0x06013B92 RID: 80786 RVA: 0x002DF0E3 File Offset: 0x002DD2E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsInstanceDangoRound(RacingBetsInstanceDangoRound other) : this()
		{
			this.dangoId_ = other.dangoId_;
			this.actionList_ = other.actionList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013B93 RID: 80787 RVA: 0x002DF119 File Offset: 0x002DD319
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsInstanceDangoRound Clone()
		{
			return new RacingBetsInstanceDangoRound(this);
		}

		// Token: 0x1700418B RID: 16779
		// (get) Token: 0x06013B94 RID: 80788 RVA: 0x002DF121 File Offset: 0x002DD321
		// (set) Token: 0x06013B95 RID: 80789 RVA: 0x002DF129 File Offset: 0x002DD329
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

		// Token: 0x1700418C RID: 16780
		// (get) Token: 0x06013B96 RID: 80790 RVA: 0x002DF132 File Offset: 0x002DD332
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RacingBetsInstanceDangoAction> ActionList
		{
			get
			{
				return this.actionList_;
			}
		}

		// Token: 0x06013B97 RID: 80791 RVA: 0x002DF13A File Offset: 0x002DD33A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsInstanceDangoRound);
		}

		// Token: 0x06013B98 RID: 80792 RVA: 0x002DF148 File Offset: 0x002DD348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsInstanceDangoRound other)
		{
			return other != null && (other == this || (this.DangoId == other.DangoId && this.actionList_.Equals(other.actionList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013B99 RID: 80793 RVA: 0x002DF198 File Offset: 0x002DD398
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

		// Token: 0x06013B9A RID: 80794 RVA: 0x002DF1E5 File Offset: 0x002DD3E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013B9B RID: 80795 RVA: 0x002DF1F2 File Offset: 0x002DD3F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013B9C RID: 80796 RVA: 0x002DF1FC File Offset: 0x002DD3FC
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

		// Token: 0x06013B9D RID: 80797 RVA: 0x002DF24C File Offset: 0x002DD44C
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

		// Token: 0x06013B9E RID: 80798 RVA: 0x002DF2A0 File Offset: 0x002DD4A0
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

		// Token: 0x06013B9F RID: 80799 RVA: 0x002DF2ED File Offset: 0x002DD4ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013BA0 RID: 80800 RVA: 0x002DF2F8 File Offset: 0x002DD4F8
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

		// Token: 0x04007920 RID: 31008
		private static readonly MessageParser<RacingBetsInstanceDangoRound> _parser = new MessageParser<RacingBetsInstanceDangoRound>(() => new RacingBetsInstanceDangoRound());

		// Token: 0x04007921 RID: 31009
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007922 RID: 31010
		public const int DangoIdFieldNumber = 1;

		// Token: 0x04007923 RID: 31011
		private int dangoId_;

		// Token: 0x04007924 RID: 31012
		public const int ActionListFieldNumber = 2;

		// Token: 0x04007925 RID: 31013
		private static readonly FieldCodec<RacingBetsInstanceDangoAction> _repeated_actionList_codec = FieldCodec.ForMessage<RacingBetsInstanceDangoAction>(18U, RacingBetsInstanceDangoAction.Parser);

		// Token: 0x04007926 RID: 31014
		private readonly RepeatedField<RacingBetsInstanceDangoAction> actionList_ = new RepeatedField<RacingBetsInstanceDangoAction>();
	}
}
