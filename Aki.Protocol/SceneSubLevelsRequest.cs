using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001190 RID: 4496
	[NetMessage(EMessageId.SceneSubLevelsRequest)]
	public sealed class SceneSubLevelsRequest : IMessage<SceneSubLevelsRequest>, IMessage, IEquatable<SceneSubLevelsRequest>, IDeepCloneable<SceneSubLevelsRequest>, IBufferMessage
	{
		// Token: 0x06017F69 RID: 98153 RVA: 0x0037AF8C File Offset: 0x0037918C
		[NullableContext(1)]
		public static SceneSubLevelsRequest Create()
		{
			return new SceneSubLevelsRequest();
		}

		// Token: 0x17005087 RID: 20615
		// (get) Token: 0x06017F6A RID: 98154 RVA: 0x0037AF93 File Offset: 0x00379193
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005088 RID: 20616
		// (get) Token: 0x06017F6B RID: 98155 RVA: 0x0037AF96 File Offset: 0x00379196
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneSubLevelsRequest.Descriptor;
			}
		}

		// Token: 0x06017F6C RID: 98156 RVA: 0x0037AF9D File Offset: 0x0037919D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneSubLevelsRequest()
		{
		}

		// Token: 0x06017F6D RID: 98157 RVA: 0x0037AFBB File Offset: 0x003791BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneSubLevelsRequest(SceneSubLevelsRequest other) : this()
		{
			this.showSubLevels_ = other.showSubLevels_.Clone();
			this.hideSubLevels_ = other.hideSubLevels_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017F6E RID: 98158 RVA: 0x0037AFF6 File Offset: 0x003791F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneSubLevelsRequest Clone()
		{
			return new SceneSubLevelsRequest(this);
		}

		// Token: 0x17005089 RID: 20617
		// (get) Token: 0x06017F6F RID: 98159 RVA: 0x0037AFFE File Offset: 0x003791FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> ShowSubLevels
		{
			get
			{
				return this.showSubLevels_;
			}
		}

		// Token: 0x1700508A RID: 20618
		// (get) Token: 0x06017F70 RID: 98160 RVA: 0x0037B006 File Offset: 0x00379206
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> HideSubLevels
		{
			get
			{
				return this.hideSubLevels_;
			}
		}

		// Token: 0x06017F71 RID: 98161 RVA: 0x0037B00E File Offset: 0x0037920E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneSubLevelsRequest);
		}

		// Token: 0x06017F72 RID: 98162 RVA: 0x0037B01C File Offset: 0x0037921C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneSubLevelsRequest other)
		{
			return other != null && (other == this || (this.showSubLevels_.Equals(other.showSubLevels_) && this.hideSubLevels_.Equals(other.hideSubLevels_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017F73 RID: 98163 RVA: 0x0037B070 File Offset: 0x00379270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.showSubLevels_.GetHashCode();
			num ^= this.hideSubLevels_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017F74 RID: 98164 RVA: 0x0037B0B2 File Offset: 0x003792B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017F75 RID: 98165 RVA: 0x0037B0BF File Offset: 0x003792BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017F76 RID: 98166 RVA: 0x0037B0C8 File Offset: 0x003792C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.showSubLevels_.WriteTo(ref output, SceneSubLevelsRequest._repeated_showSubLevels_codec);
			this.hideSubLevels_.WriteTo(ref output, SceneSubLevelsRequest._repeated_hideSubLevels_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017F77 RID: 98167 RVA: 0x0037B100 File Offset: 0x00379300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.showSubLevels_.CalculateSize(SceneSubLevelsRequest._repeated_showSubLevels_codec);
			num += this.hideSubLevels_.CalculateSize(SceneSubLevelsRequest._repeated_hideSubLevels_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017F78 RID: 98168 RVA: 0x0037B14C File Offset: 0x0037934C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneSubLevelsRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.showSubLevels_.Add(other.showSubLevels_);
			this.hideSubLevels_.Add(other.hideSubLevels_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017F79 RID: 98169 RVA: 0x0037B18B File Offset: 0x0037938B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017F7A RID: 98170 RVA: 0x0037B194 File Offset: 0x00379394
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
						this.hideSubLevels_.AddEntriesFrom(ref input, SceneSubLevelsRequest._repeated_hideSubLevels_codec);
					}
				}
				else
				{
					this.showSubLevels_.AddEntriesFrom(ref input, SceneSubLevelsRequest._repeated_showSubLevels_codec);
				}
			}
		}

		// Token: 0x04008DF8 RID: 36344
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008DF9 RID: 36345
		public const int ShowSubLevelsFieldNumber = 9;

		// Token: 0x04008DFA RID: 36346
		private static readonly FieldCodec<string> _repeated_showSubLevels_codec = FieldCodec.ForString(74U);

		// Token: 0x04008DFB RID: 36347
		private readonly RepeatedField<string> showSubLevels_ = new RepeatedField<string>();

		// Token: 0x04008DFC RID: 36348
		public const int HideSubLevelsFieldNumber = 15;

		// Token: 0x04008DFD RID: 36349
		private static readonly FieldCodec<string> _repeated_hideSubLevels_codec = FieldCodec.ForString(122U);

		// Token: 0x04008DFE RID: 36350
		private readonly RepeatedField<string> hideSubLevels_ = new RepeatedField<string>();
	}
}
