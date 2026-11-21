using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000631 RID: 1585
	public sealed class FRDebugActionInfo : IMessage<FRDebugActionInfo>, IMessage, IEquatable<FRDebugActionInfo>, IDeepCloneable<FRDebugActionInfo>, IBufferMessage
	{
		// Token: 0x06009269 RID: 37481 RVA: 0x001629C5 File Offset: 0x00160BC5
		[NullableContext(1)]
		public static FRDebugActionInfo Create()
		{
			return new FRDebugActionInfo();
		}

		// Token: 0x17001D1F RID: 7455
		// (get) Token: 0x0600926A RID: 37482 RVA: 0x001629CC File Offset: 0x00160BCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D20 RID: 7456
		// (get) Token: 0x0600926B RID: 37483 RVA: 0x001629CF File Offset: 0x00160BCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FRDebugActionInfo.Descriptor;
			}
		}

		// Token: 0x0600926C RID: 37484 RVA: 0x001629D6 File Offset: 0x00160BD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRDebugActionInfo()
		{
		}

		// Token: 0x0600926D RID: 37485 RVA: 0x001629F4 File Offset: 0x00160BF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRDebugActionInfo(FRDebugActionInfo other) : this()
		{
			this.actionId_ = other.actionId_;
			this.targetIncId_ = other.targetIncId_.Clone();
			this.exInfo_ = other.exInfo_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600926E RID: 37486 RVA: 0x00162A41 File Offset: 0x00160C41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRDebugActionInfo Clone()
		{
			return new FRDebugActionInfo(this);
		}

		// Token: 0x17001D21 RID: 7457
		// (get) Token: 0x0600926F RID: 37487 RVA: 0x00162A49 File Offset: 0x00160C49
		// (set) Token: 0x06009270 RID: 37488 RVA: 0x00162A51 File Offset: 0x00160C51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActionId
		{
			get
			{
				return this.actionId_;
			}
			set
			{
				this.actionId_ = value;
			}
		}

		// Token: 0x17001D22 RID: 7458
		// (get) Token: 0x06009271 RID: 37489 RVA: 0x00162A5A File Offset: 0x00160C5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TargetIncId
		{
			get
			{
				return this.targetIncId_;
			}
		}

		// Token: 0x17001D23 RID: 7459
		// (get) Token: 0x06009272 RID: 37490 RVA: 0x00162A62 File Offset: 0x00160C62
		// (set) Token: 0x06009273 RID: 37491 RVA: 0x00162A6A File Offset: 0x00160C6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string ExInfo
		{
			get
			{
				return this.exInfo_;
			}
			set
			{
				this.exInfo_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x06009274 RID: 37492 RVA: 0x00162A7D File Offset: 0x00160C7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FRDebugActionInfo);
		}

		// Token: 0x06009275 RID: 37493 RVA: 0x00162A8C File Offset: 0x00160C8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FRDebugActionInfo other)
		{
			return other != null && (other == this || (this.ActionId == other.ActionId && this.targetIncId_.Equals(other.targetIncId_) && !(this.ExInfo != other.ExInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009276 RID: 37494 RVA: 0x00162AF0 File Offset: 0x00160CF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActionId != 0)
			{
				num ^= this.ActionId.GetHashCode();
			}
			num ^= this.targetIncId_.GetHashCode();
			if (this.ExInfo.Length != 0)
			{
				num ^= this.ExInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009277 RID: 37495 RVA: 0x00162B58 File Offset: 0x00160D58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009278 RID: 37496 RVA: 0x00162B65 File Offset: 0x00160D65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009279 RID: 37497 RVA: 0x00162B70 File Offset: 0x00160D70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActionId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ActionId);
			}
			this.targetIncId_.WriteTo(ref output, FRDebugActionInfo._repeated_targetIncId_codec);
			if (this.ExInfo.Length != 0)
			{
				output.WriteRawTag(26);
				output.WriteString(this.ExInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600927A RID: 37498 RVA: 0x00162BE0 File Offset: 0x00160DE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActionId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActionId);
			}
			num += this.targetIncId_.CalculateSize(FRDebugActionInfo._repeated_targetIncId_codec);
			if (this.ExInfo.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ExInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600927B RID: 37499 RVA: 0x00162C50 File Offset: 0x00160E50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FRDebugActionInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActionId != 0)
			{
				this.ActionId = other.ActionId;
			}
			this.targetIncId_.Add(other.targetIncId_);
			if (other.ExInfo.Length != 0)
			{
				this.ExInfo = other.ExInfo;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600927C RID: 37500 RVA: 0x00162CB6 File Offset: 0x00160EB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600927D RID: 37501 RVA: 0x00162CC0 File Offset: 0x00160EC0
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.ActionId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						goto IL_45;
					}
				}
				else
				{
					if (num == 18U)
					{
						goto IL_45;
					}
					if (num == 26U)
					{
						this.ExInfo = input.ReadString();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_45:
				this.targetIncId_.AddEntriesFrom(ref input, FRDebugActionInfo._repeated_targetIncId_codec);
			}
		}

		// Token: 0x040046F1 RID: 18161
		private UnknownFieldSet _unknownFields;

		// Token: 0x040046F2 RID: 18162
		public const int ActionIdFieldNumber = 1;

		// Token: 0x040046F3 RID: 18163
		private int actionId_;

		// Token: 0x040046F4 RID: 18164
		public const int TargetIncIdFieldNumber = 2;

		// Token: 0x040046F5 RID: 18165
		private static readonly FieldCodec<int> _repeated_targetIncId_codec = FieldCodec.ForInt32(18U);

		// Token: 0x040046F6 RID: 18166
		private readonly RepeatedField<int> targetIncId_ = new RepeatedField<int>();

		// Token: 0x040046F7 RID: 18167
		public const int ExInfoFieldNumber = 3;

		// Token: 0x040046F8 RID: 18168
		private string exInfo_ = "";
	}
}
