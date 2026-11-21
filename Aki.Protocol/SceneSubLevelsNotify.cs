using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011C9 RID: 4553
	[NetMessage(EMessageId.SceneSubLevelsNotify)]
	public sealed class SceneSubLevelsNotify : IMessage<SceneSubLevelsNotify>, IMessage, IEquatable<SceneSubLevelsNotify>, IDeepCloneable<SceneSubLevelsNotify>, IBufferMessage
	{
		// Token: 0x060184F7 RID: 99575 RVA: 0x0038A045 File Offset: 0x00388245
		[NullableContext(1)]
		public static SceneSubLevelsNotify Create()
		{
			return new SceneSubLevelsNotify();
		}

		// Token: 0x170051EF RID: 20975
		// (get) Token: 0x060184F8 RID: 99576 RVA: 0x0038A04C File Offset: 0x0038824C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170051F0 RID: 20976
		// (get) Token: 0x060184F9 RID: 99577 RVA: 0x0038A04F File Offset: 0x0038824F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneSubLevelsNotify.Descriptor;
			}
		}

		// Token: 0x060184FA RID: 99578 RVA: 0x0038A056 File Offset: 0x00388256
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneSubLevelsNotify()
		{
		}

		// Token: 0x060184FB RID: 99579 RVA: 0x0038A074 File Offset: 0x00388274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneSubLevelsNotify(SceneSubLevelsNotify other) : this()
		{
			this.curLoaded_ = other.curLoaded_.Clone();
			this.curHideLoaded_ = other.curHideLoaded_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060184FC RID: 99580 RVA: 0x0038A0AF File Offset: 0x003882AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneSubLevelsNotify Clone()
		{
			return new SceneSubLevelsNotify(this);
		}

		// Token: 0x170051F1 RID: 20977
		// (get) Token: 0x060184FD RID: 99581 RVA: 0x0038A0B7 File Offset: 0x003882B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> CurLoaded
		{
			get
			{
				return this.curLoaded_;
			}
		}

		// Token: 0x170051F2 RID: 20978
		// (get) Token: 0x060184FE RID: 99582 RVA: 0x0038A0BF File Offset: 0x003882BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> CurHideLoaded
		{
			get
			{
				return this.curHideLoaded_;
			}
		}

		// Token: 0x060184FF RID: 99583 RVA: 0x0038A0C7 File Offset: 0x003882C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneSubLevelsNotify);
		}

		// Token: 0x06018500 RID: 99584 RVA: 0x0038A0D8 File Offset: 0x003882D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneSubLevelsNotify other)
		{
			return other != null && (other == this || (this.curLoaded_.Equals(other.curLoaded_) && this.curHideLoaded_.Equals(other.curHideLoaded_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018501 RID: 99585 RVA: 0x0038A12C File Offset: 0x0038832C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.curLoaded_.GetHashCode();
			num ^= this.curHideLoaded_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018502 RID: 99586 RVA: 0x0038A16E File Offset: 0x0038836E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018503 RID: 99587 RVA: 0x0038A17B File Offset: 0x0038837B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018504 RID: 99588 RVA: 0x0038A184 File Offset: 0x00388384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.curHideLoaded_.WriteTo(ref output, SceneSubLevelsNotify._repeated_curHideLoaded_codec);
			this.curLoaded_.WriteTo(ref output, SceneSubLevelsNotify._repeated_curLoaded_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018505 RID: 99589 RVA: 0x0038A1BC File Offset: 0x003883BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.curLoaded_.CalculateSize(SceneSubLevelsNotify._repeated_curLoaded_codec);
			num += this.curHideLoaded_.CalculateSize(SceneSubLevelsNotify._repeated_curHideLoaded_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018506 RID: 99590 RVA: 0x0038A208 File Offset: 0x00388408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneSubLevelsNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.curLoaded_.Add(other.curLoaded_);
			this.curHideLoaded_.Add(other.curHideLoaded_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018507 RID: 99591 RVA: 0x0038A247 File Offset: 0x00388447
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018508 RID: 99592 RVA: 0x0038A250 File Offset: 0x00388450
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
						this.curLoaded_.AddEntriesFrom(ref input, SceneSubLevelsNotify._repeated_curLoaded_codec);
					}
				}
				else
				{
					this.curHideLoaded_.AddEntriesFrom(ref input, SceneSubLevelsNotify._repeated_curHideLoaded_codec);
				}
			}
		}

		// Token: 0x04009084 RID: 36996
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009085 RID: 36997
		public const int CurLoadedFieldNumber = 12;

		// Token: 0x04009086 RID: 36998
		private static readonly FieldCodec<string> _repeated_curLoaded_codec = FieldCodec.ForString(98U);

		// Token: 0x04009087 RID: 36999
		private readonly RepeatedField<string> curLoaded_ = new RepeatedField<string>();

		// Token: 0x04009088 RID: 37000
		public const int CurHideLoadedFieldNumber = 5;

		// Token: 0x04009089 RID: 37001
		private static readonly FieldCodec<string> _repeated_curHideLoaded_codec = FieldCodec.ForString(42U);

		// Token: 0x0400908A RID: 37002
		private readonly RepeatedField<string> curHideLoaded_ = new RepeatedField<string>();
	}
}
