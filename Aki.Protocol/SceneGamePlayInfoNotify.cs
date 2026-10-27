using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001153 RID: 4435
	[NetMessage(EMessageId.SceneGamePlayInfoNotify)]
	public sealed class SceneGamePlayInfoNotify : IMessage<SceneGamePlayInfoNotify>, IMessage, IEquatable<SceneGamePlayInfoNotify>, IDeepCloneable<SceneGamePlayInfoNotify>, IBufferMessage
	{
		// Token: 0x06017A47 RID: 96839 RVA: 0x0036E9AC File Offset: 0x0036CBAC
		[NullableContext(1)]
		public static SceneGamePlayInfoNotify Create()
		{
			return new SceneGamePlayInfoNotify();
		}

		// Token: 0x17004F5A RID: 20314
		// (get) Token: 0x06017A48 RID: 96840 RVA: 0x0036E9B3 File Offset: 0x0036CBB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004F5B RID: 20315
		// (get) Token: 0x06017A49 RID: 96841 RVA: 0x0036E9B6 File Offset: 0x0036CBB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneGamePlayInfoNotify.Descriptor;
			}
		}

		// Token: 0x06017A4A RID: 96842 RVA: 0x0036E9BD File Offset: 0x0036CBBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneGamePlayInfoNotify()
		{
		}

		// Token: 0x06017A4B RID: 96843 RVA: 0x0036E9D0 File Offset: 0x0036CBD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneGamePlayInfoNotify(SceneGamePlayInfoNotify other) : this()
		{
			this.gamePlayInfo_ = other.gamePlayInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017A4C RID: 96844 RVA: 0x0036E9FA File Offset: 0x0036CBFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneGamePlayInfoNotify Clone()
		{
			return new SceneGamePlayInfoNotify(this);
		}

		// Token: 0x17004F5C RID: 20316
		// (get) Token: 0x06017A4D RID: 96845 RVA: 0x0036EA02 File Offset: 0x0036CC02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SceneGamePlayInfo> GamePlayInfo
		{
			get
			{
				return this.gamePlayInfo_;
			}
		}

		// Token: 0x06017A4E RID: 96846 RVA: 0x0036EA0A File Offset: 0x0036CC0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneGamePlayInfoNotify);
		}

		// Token: 0x06017A4F RID: 96847 RVA: 0x0036EA18 File Offset: 0x0036CC18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneGamePlayInfoNotify other)
		{
			return other != null && (other == this || (this.gamePlayInfo_.Equals(other.gamePlayInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017A50 RID: 96848 RVA: 0x0036EA4C File Offset: 0x0036CC4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.gamePlayInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017A51 RID: 96849 RVA: 0x0036EA80 File Offset: 0x0036CC80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017A52 RID: 96850 RVA: 0x0036EA8D File Offset: 0x0036CC8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017A53 RID: 96851 RVA: 0x0036EA96 File Offset: 0x0036CC96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.gamePlayInfo_.WriteTo(ref output, SceneGamePlayInfoNotify._repeated_gamePlayInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017A54 RID: 96852 RVA: 0x0036EAC0 File Offset: 0x0036CCC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.gamePlayInfo_.CalculateSize(SceneGamePlayInfoNotify._repeated_gamePlayInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017A55 RID: 96853 RVA: 0x0036EAF9 File Offset: 0x0036CCF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneGamePlayInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.gamePlayInfo_.Add(other.gamePlayInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017A56 RID: 96854 RVA: 0x0036EB27 File Offset: 0x0036CD27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017A57 RID: 96855 RVA: 0x0036EB30 File Offset: 0x0036CD30
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
				if (num != 98U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.gamePlayInfo_.AddEntriesFrom(ref input, SceneGamePlayInfoNotify._repeated_gamePlayInfo_codec);
				}
			}
		}

		// Token: 0x04008C54 RID: 35924
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008C55 RID: 35925
		public const int GamePlayInfoFieldNumber = 12;

		// Token: 0x04008C56 RID: 35926
		private static readonly FieldCodec<SceneGamePlayInfo> _repeated_gamePlayInfo_codec = FieldCodec.ForMessage<SceneGamePlayInfo>(98U, SceneGamePlayInfo.Parser);

		// Token: 0x04008C57 RID: 35927
		private readonly RepeatedField<SceneGamePlayInfo> gamePlayInfo_ = new RepeatedField<SceneGamePlayInfo>();
	}
}
