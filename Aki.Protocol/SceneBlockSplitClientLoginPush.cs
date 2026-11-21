using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200117E RID: 4478
	[NetMessage(EMessageId.SceneBlockSplitClientLoginPush)]
	public sealed class SceneBlockSplitClientLoginPush : IMessage<SceneBlockSplitClientLoginPush>, IMessage, IEquatable<SceneBlockSplitClientLoginPush>, IDeepCloneable<SceneBlockSplitClientLoginPush>, IBufferMessage
	{
		// Token: 0x06017EB2 RID: 97970 RVA: 0x0037B1E5 File Offset: 0x003793E5
		[NullableContext(1)]
		public static SceneBlockSplitClientLoginPush Create()
		{
			return new SceneBlockSplitClientLoginPush();
		}

		// Token: 0x17005082 RID: 20610
		// (get) Token: 0x06017EB3 RID: 97971 RVA: 0x0037B1EC File Offset: 0x003793EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005083 RID: 20611
		// (get) Token: 0x06017EB4 RID: 97972 RVA: 0x0037B1EF File Offset: 0x003793EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneBlockSplitClientLoginPush.Descriptor;
			}
		}

		// Token: 0x06017EB5 RID: 97973 RVA: 0x0037B1F6 File Offset: 0x003793F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneBlockSplitClientLoginPush()
		{
		}

		// Token: 0x06017EB6 RID: 97974 RVA: 0x0037B209 File Offset: 0x00379409
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneBlockSplitClientLoginPush(SceneBlockSplitClientLoginPush other) : this()
		{
			this.downloadBlockId_ = other.downloadBlockId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017EB7 RID: 97975 RVA: 0x0037B233 File Offset: 0x00379433
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneBlockSplitClientLoginPush Clone()
		{
			return new SceneBlockSplitClientLoginPush(this);
		}

		// Token: 0x17005084 RID: 20612
		// (get) Token: 0x06017EB8 RID: 97976 RVA: 0x0037B23B File Offset: 0x0037943B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> DownloadBlockId
		{
			get
			{
				return this.downloadBlockId_;
			}
		}

		// Token: 0x06017EB9 RID: 97977 RVA: 0x0037B243 File Offset: 0x00379443
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneBlockSplitClientLoginPush);
		}

		// Token: 0x06017EBA RID: 97978 RVA: 0x0037B251 File Offset: 0x00379451
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneBlockSplitClientLoginPush other)
		{
			return other != null && (other == this || (this.downloadBlockId_.Equals(other.downloadBlockId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017EBB RID: 97979 RVA: 0x0037B284 File Offset: 0x00379484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.downloadBlockId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017EBC RID: 97980 RVA: 0x0037B2B8 File Offset: 0x003794B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017EBD RID: 97981 RVA: 0x0037B2C5 File Offset: 0x003794C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017EBE RID: 97982 RVA: 0x0037B2CE File Offset: 0x003794CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.downloadBlockId_.WriteTo(ref output, SceneBlockSplitClientLoginPush._repeated_downloadBlockId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017EBF RID: 97983 RVA: 0x0037B2F8 File Offset: 0x003794F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.downloadBlockId_.CalculateSize(SceneBlockSplitClientLoginPush._repeated_downloadBlockId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017EC0 RID: 97984 RVA: 0x0037B331 File Offset: 0x00379531
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneBlockSplitClientLoginPush other)
		{
			if (other == null)
			{
				return;
			}
			this.downloadBlockId_.Add(other.downloadBlockId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017EC1 RID: 97985 RVA: 0x0037B35F File Offset: 0x0037955F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017EC2 RID: 97986 RVA: 0x0037B368 File Offset: 0x00379568
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.downloadBlockId_.AddEntriesFrom(ref input, SceneBlockSplitClientLoginPush._repeated_downloadBlockId_codec);
				}
			}
		}

		// Token: 0x04008E85 RID: 36485
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008E86 RID: 36486
		public const int DownloadBlockIdFieldNumber = 3;

		// Token: 0x04008E87 RID: 36487
		private static readonly FieldCodec<int> _repeated_downloadBlockId_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04008E88 RID: 36488
		private readonly RepeatedField<int> downloadBlockId_ = new RepeatedField<int>();
	}
}
