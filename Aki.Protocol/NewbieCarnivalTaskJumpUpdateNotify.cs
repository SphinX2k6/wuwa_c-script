using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AF5 RID: 2805
	[NetMessage(EMessageId.NewbieCarnivalTaskJumpUpdateNotify)]
	public sealed class NewbieCarnivalTaskJumpUpdateNotify : IMessage<NewbieCarnivalTaskJumpUpdateNotify>, IMessage, IEquatable<NewbieCarnivalTaskJumpUpdateNotify>, IDeepCloneable<NewbieCarnivalTaskJumpUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600F423 RID: 62499 RVA: 0x0023A828 File Offset: 0x00238A28
		[NullableContext(1)]
		public static NewbieCarnivalTaskJumpUpdateNotify Create()
		{
			return new NewbieCarnivalTaskJumpUpdateNotify();
		}

		// Token: 0x170031B6 RID: 12726
		// (get) Token: 0x0600F424 RID: 62500 RVA: 0x0023A82F File Offset: 0x00238A2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170031B7 RID: 12727
		// (get) Token: 0x0600F425 RID: 62501 RVA: 0x0023A832 File Offset: 0x00238A32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewbieCarnivalTaskJumpUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600F426 RID: 62502 RVA: 0x0023A839 File Offset: 0x00238A39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieCarnivalTaskJumpUpdateNotify()
		{
		}

		// Token: 0x0600F427 RID: 62503 RVA: 0x0023A857 File Offset: 0x00238A57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieCarnivalTaskJumpUpdateNotify(NewbieCarnivalTaskJumpUpdateNotify other) : this()
		{
			this.jumpTaskIds_ = other.jumpTaskIds_.Clone();
			this.jumpTaskCondInfos_ = other.jumpTaskCondInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F428 RID: 62504 RVA: 0x0023A892 File Offset: 0x00238A92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieCarnivalTaskJumpUpdateNotify Clone()
		{
			return new NewbieCarnivalTaskJumpUpdateNotify(this);
		}

		// Token: 0x170031B8 RID: 12728
		// (get) Token: 0x0600F429 RID: 62505 RVA: 0x0023A89A File Offset: 0x00238A9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> JumpTaskIds
		{
			get
			{
				return this.jumpTaskIds_;
			}
		}

		// Token: 0x170031B9 RID: 12729
		// (get) Token: 0x0600F42A RID: 62506 RVA: 0x0023A8A2 File Offset: 0x00238AA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<JumpTaskCondInfo> JumpTaskCondInfos
		{
			get
			{
				return this.jumpTaskCondInfos_;
			}
		}

		// Token: 0x0600F42B RID: 62507 RVA: 0x0023A8AA File Offset: 0x00238AAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewbieCarnivalTaskJumpUpdateNotify);
		}

		// Token: 0x0600F42C RID: 62508 RVA: 0x0023A8B8 File Offset: 0x00238AB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewbieCarnivalTaskJumpUpdateNotify other)
		{
			return other != null && (other == this || (this.jumpTaskIds_.Equals(other.jumpTaskIds_) && this.jumpTaskCondInfos_.Equals(other.jumpTaskCondInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F42D RID: 62509 RVA: 0x0023A90C File Offset: 0x00238B0C
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

		// Token: 0x0600F42E RID: 62510 RVA: 0x0023A94E File Offset: 0x00238B4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F42F RID: 62511 RVA: 0x0023A95B File Offset: 0x00238B5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F430 RID: 62512 RVA: 0x0023A964 File Offset: 0x00238B64
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

		// Token: 0x0600F431 RID: 62513 RVA: 0x0023A99C File Offset: 0x00238B9C
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

		// Token: 0x0600F432 RID: 62514 RVA: 0x0023A9E8 File Offset: 0x00238BE8
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

		// Token: 0x0600F433 RID: 62515 RVA: 0x0023AA27 File Offset: 0x00238C27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F434 RID: 62516 RVA: 0x0023AA30 File Offset: 0x00238C30
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
				if (num != 24U && num != 26U)
				{
					if (num != 82U)
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

		// Token: 0x040062AE RID: 25262
		private UnknownFieldSet _unknownFields;

		// Token: 0x040062AF RID: 25263
		public const int JumpTaskIdsFieldNumber = 3;

		// Token: 0x040062B0 RID: 25264
		private static readonly FieldCodec<int> _repeated_jumpTaskIds_codec = FieldCodec.ForInt32(26U);

		// Token: 0x040062B1 RID: 25265
		private readonly RepeatedField<int> jumpTaskIds_ = new RepeatedField<int>();

		// Token: 0x040062B2 RID: 25266
		public const int JumpTaskCondInfosFieldNumber = 10;

		// Token: 0x040062B3 RID: 25267
		private static readonly FieldCodec<JumpTaskCondInfo> _repeated_jumpTaskCondInfos_codec = FieldCodec.ForMessage<JumpTaskCondInfo>(82U, JumpTaskCondInfo.Parser);

		// Token: 0x040062B4 RID: 25268
		private readonly RepeatedField<JumpTaskCondInfo> jumpTaskCondInfos_ = new RepeatedField<JumpTaskCondInfo>();
	}
}
