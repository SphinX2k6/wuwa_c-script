using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B06 RID: 2822
	[NetMessage(EMessageId.NewbieCarnivalTaskJumpUpdateNotify)]
	public sealed class NewbieCarnivalTaskJumpUpdateNotify : IMessage<NewbieCarnivalTaskJumpUpdateNotify>, IMessage, IEquatable<NewbieCarnivalTaskJumpUpdateNotify>, IDeepCloneable<NewbieCarnivalTaskJumpUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600F53D RID: 62781 RVA: 0x0023CA34 File Offset: 0x0023AC34
		[NullableContext(1)]
		public static NewbieCarnivalTaskJumpUpdateNotify Create()
		{
			return new NewbieCarnivalTaskJumpUpdateNotify();
		}

		// Token: 0x170031F4 RID: 12788
		// (get) Token: 0x0600F53E RID: 62782 RVA: 0x0023CA3B File Offset: 0x0023AC3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170031F5 RID: 12789
		// (get) Token: 0x0600F53F RID: 62783 RVA: 0x0023CA3E File Offset: 0x0023AC3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewbieCarnivalTaskJumpUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600F540 RID: 62784 RVA: 0x0023CA45 File Offset: 0x0023AC45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieCarnivalTaskJumpUpdateNotify()
		{
		}

		// Token: 0x0600F541 RID: 62785 RVA: 0x0023CA63 File Offset: 0x0023AC63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieCarnivalTaskJumpUpdateNotify(NewbieCarnivalTaskJumpUpdateNotify other) : this()
		{
			this.jumpTaskIds_ = other.jumpTaskIds_.Clone();
			this.jumpTaskCondInfos_ = other.jumpTaskCondInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F542 RID: 62786 RVA: 0x0023CA9E File Offset: 0x0023AC9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieCarnivalTaskJumpUpdateNotify Clone()
		{
			return new NewbieCarnivalTaskJumpUpdateNotify(this);
		}

		// Token: 0x170031F6 RID: 12790
		// (get) Token: 0x0600F543 RID: 62787 RVA: 0x0023CAA6 File Offset: 0x0023ACA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> JumpTaskIds
		{
			get
			{
				return this.jumpTaskIds_;
			}
		}

		// Token: 0x170031F7 RID: 12791
		// (get) Token: 0x0600F544 RID: 62788 RVA: 0x0023CAAE File Offset: 0x0023ACAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<JumpTaskCondInfo> JumpTaskCondInfos
		{
			get
			{
				return this.jumpTaskCondInfos_;
			}
		}

		// Token: 0x0600F545 RID: 62789 RVA: 0x0023CAB6 File Offset: 0x0023ACB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewbieCarnivalTaskJumpUpdateNotify);
		}

		// Token: 0x0600F546 RID: 62790 RVA: 0x0023CAC4 File Offset: 0x0023ACC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewbieCarnivalTaskJumpUpdateNotify other)
		{
			return other != null && (other == this || (this.jumpTaskIds_.Equals(other.jumpTaskIds_) && this.jumpTaskCondInfos_.Equals(other.jumpTaskCondInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F547 RID: 62791 RVA: 0x0023CB18 File Offset: 0x0023AD18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.jumpTaskIds_.GetHashCode();
			num ^= this.jumpTaskCondInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F548 RID: 62792 RVA: 0x0023CB5A File Offset: 0x0023AD5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F549 RID: 62793 RVA: 0x0023CB67 File Offset: 0x0023AD67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F54A RID: 62794 RVA: 0x0023CB70 File Offset: 0x0023AD70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.jumpTaskIds_.WriteTo(ref output, NewbieCarnivalTaskJumpUpdateNotify._repeated_jumpTaskIds_codec);
			this.jumpTaskCondInfos_.WriteTo(ref output, NewbieCarnivalTaskJumpUpdateNotify._repeated_jumpTaskCondInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F54B RID: 62795 RVA: 0x0023CBA8 File Offset: 0x0023ADA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.jumpTaskIds_.CalculateSize(NewbieCarnivalTaskJumpUpdateNotify._repeated_jumpTaskIds_codec);
			num += this.jumpTaskCondInfos_.CalculateSize(NewbieCarnivalTaskJumpUpdateNotify._repeated_jumpTaskCondInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F54C RID: 62796 RVA: 0x0023CBF4 File Offset: 0x0023ADF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewbieCarnivalTaskJumpUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.jumpTaskIds_.Add(other.jumpTaskIds_);
			this.jumpTaskCondInfos_.Add(other.jumpTaskCondInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F54D RID: 62797 RVA: 0x0023CC33 File Offset: 0x0023AE33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F54E RID: 62798 RVA: 0x0023CC3C File Offset: 0x0023AE3C
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
				if (num != 56U && num != 58U)
				{
					if (num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.jumpTaskCondInfos_.AddEntriesFrom(ref input, NewbieCarnivalTaskJumpUpdateNotify._repeated_jumpTaskCondInfos_codec);
					}
				}
				else
				{
					this.jumpTaskIds_.AddEntriesFrom(ref input, NewbieCarnivalTaskJumpUpdateNotify._repeated_jumpTaskIds_codec);
				}
			}
		}

		// Token: 0x040062A5 RID: 25253
		private UnknownFieldSet _unknownFields;

		// Token: 0x040062A6 RID: 25254
		public const int JumpTaskIdsFieldNumber = 7;

		// Token: 0x040062A7 RID: 25255
		private static readonly FieldCodec<int> _repeated_jumpTaskIds_codec = FieldCodec.ForInt32(58U);

		// Token: 0x040062A8 RID: 25256
		private readonly RepeatedField<int> jumpTaskIds_ = new RepeatedField<int>();

		// Token: 0x040062A9 RID: 25257
		public const int JumpTaskCondInfosFieldNumber = 14;

		// Token: 0x040062AA RID: 25258
		private static readonly FieldCodec<JumpTaskCondInfo> _repeated_jumpTaskCondInfos_codec = FieldCodec.ForMessage<JumpTaskCondInfo>(114U, JumpTaskCondInfo.Parser);

		// Token: 0x040062AB RID: 25259
		private readonly RepeatedField<JumpTaskCondInfo> jumpTaskCondInfos_ = new RepeatedField<JumpTaskCondInfo>();
	}
}
