using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200118F RID: 4495
	[NetMessage(EMessageId.SceneSubLevelsNotify)]
	public sealed class SceneSubLevelsNotify : IMessage<SceneSubLevelsNotify>, IMessage, IEquatable<SceneSubLevelsNotify>, IDeepCloneable<SceneSubLevelsNotify>, IBufferMessage
	{
		// Token: 0x06017F56 RID: 98134 RVA: 0x0037AD05 File Offset: 0x00378F05
		[NullableContext(1)]
		public static SceneSubLevelsNotify Create()
		{
			return new SceneSubLevelsNotify();
		}

		// Token: 0x17005083 RID: 20611
		// (get) Token: 0x06017F57 RID: 98135 RVA: 0x0037AD0C File Offset: 0x00378F0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005084 RID: 20612
		// (get) Token: 0x06017F58 RID: 98136 RVA: 0x0037AD0F File Offset: 0x00378F0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneSubLevelsNotify.Descriptor;
			}
		}

		// Token: 0x06017F59 RID: 98137 RVA: 0x0037AD16 File Offset: 0x00378F16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneSubLevelsNotify()
		{
		}

		// Token: 0x06017F5A RID: 98138 RVA: 0x0037AD34 File Offset: 0x00378F34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneSubLevelsNotify(SceneSubLevelsNotify other) : this()
		{
			this.curLoaded_ = other.curLoaded_.Clone();
			this.curHideLoaded_ = other.curHideLoaded_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017F5B RID: 98139 RVA: 0x0037AD6F File Offset: 0x00378F6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneSubLevelsNotify Clone()
		{
			return new SceneSubLevelsNotify(this);
		}

		// Token: 0x17005085 RID: 20613
		// (get) Token: 0x06017F5C RID: 98140 RVA: 0x0037AD77 File Offset: 0x00378F77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> CurLoaded
		{
			get
			{
				return this.curLoaded_;
			}
		}

		// Token: 0x17005086 RID: 20614
		// (get) Token: 0x06017F5D RID: 98141 RVA: 0x0037AD7F File Offset: 0x00378F7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> CurHideLoaded
		{
			get
			{
				return this.curHideLoaded_;
			}
		}

		// Token: 0x06017F5E RID: 98142 RVA: 0x0037AD87 File Offset: 0x00378F87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneSubLevelsNotify);
		}

		// Token: 0x06017F5F RID: 98143 RVA: 0x0037AD98 File Offset: 0x00378F98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneSubLevelsNotify other)
		{
			return other != null && (other == this || (this.curLoaded_.Equals(other.curLoaded_) && this.curHideLoaded_.Equals(other.curHideLoaded_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017F60 RID: 98144 RVA: 0x0037ADEC File Offset: 0x00378FEC
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

		// Token: 0x06017F61 RID: 98145 RVA: 0x0037AE2E File Offset: 0x0037902E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017F62 RID: 98146 RVA: 0x0037AE3B File Offset: 0x0037903B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017F63 RID: 98147 RVA: 0x0037AE44 File Offset: 0x00379044
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

		// Token: 0x06017F64 RID: 98148 RVA: 0x0037AE7C File Offset: 0x0037907C
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

		// Token: 0x06017F65 RID: 98149 RVA: 0x0037AEC8 File Offset: 0x003790C8
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

		// Token: 0x06017F66 RID: 98150 RVA: 0x0037AF07 File Offset: 0x00379107
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017F67 RID: 98151 RVA: 0x0037AF10 File Offset: 0x00379110
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
				if (num != 74U)
				{
					if (num != 122U)
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

		// Token: 0x04008DF1 RID: 36337
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008DF2 RID: 36338
		public const int CurLoadedFieldNumber = 15;

		// Token: 0x04008DF3 RID: 36339
		private static readonly FieldCodec<string> _repeated_curLoaded_codec = FieldCodec.ForString(122U);

		// Token: 0x04008DF4 RID: 36340
		private readonly RepeatedField<string> curLoaded_ = new RepeatedField<string>();

		// Token: 0x04008DF5 RID: 36341
		public const int CurHideLoadedFieldNumber = 9;

		// Token: 0x04008DF6 RID: 36342
		private static readonly FieldCodec<string> _repeated_curHideLoaded_codec = FieldCodec.ForString(74U);

		// Token: 0x04008DF7 RID: 36343
		private readonly RepeatedField<string> curHideLoaded_ = new RepeatedField<string>();
	}
}
