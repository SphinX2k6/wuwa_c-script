using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200118B RID: 4491
	[NetMessage(EMessageId.SceneGamePlayFirstNotify)]
	public sealed class SceneGamePlayFirstNotify : IMessage<SceneGamePlayFirstNotify>, IMessage, IEquatable<SceneGamePlayFirstNotify>, IDeepCloneable<SceneGamePlayFirstNotify>, IBufferMessage
	{
		// Token: 0x06017FBC RID: 98236 RVA: 0x0037D70E File Offset: 0x0037B90E
		[NullableContext(1)]
		public static SceneGamePlayFirstNotify Create()
		{
			return new SceneGamePlayFirstNotify();
		}

		// Token: 0x170050BC RID: 20668
		// (get) Token: 0x06017FBD RID: 98237 RVA: 0x0037D715 File Offset: 0x0037B915
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170050BD RID: 20669
		// (get) Token: 0x06017FBE RID: 98238 RVA: 0x0037D718 File Offset: 0x0037B918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneGamePlayFirstNotify.Descriptor;
			}
		}

		// Token: 0x06017FBF RID: 98239 RVA: 0x0037D71F File Offset: 0x0037B91F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneGamePlayFirstNotify()
		{
		}

		// Token: 0x06017FC0 RID: 98240 RVA: 0x0037D727 File Offset: 0x0037B927
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneGamePlayFirstNotify(SceneGamePlayFirstNotify other) : this()
		{
			this.gamePlayId_ = other.gamePlayId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017FC1 RID: 98241 RVA: 0x0037D74C File Offset: 0x0037B94C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneGamePlayFirstNotify Clone()
		{
			return new SceneGamePlayFirstNotify(this);
		}

		// Token: 0x170050BE RID: 20670
		// (get) Token: 0x06017FC2 RID: 98242 RVA: 0x0037D754 File Offset: 0x0037B954
		// (set) Token: 0x06017FC3 RID: 98243 RVA: 0x0037D75C File Offset: 0x0037B95C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GamePlayId
		{
			get
			{
				return this.gamePlayId_;
			}
			set
			{
				this.gamePlayId_ = value;
			}
		}

		// Token: 0x06017FC4 RID: 98244 RVA: 0x0037D765 File Offset: 0x0037B965
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneGamePlayFirstNotify);
		}

		// Token: 0x06017FC5 RID: 98245 RVA: 0x0037D773 File Offset: 0x0037B973
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneGamePlayFirstNotify other)
		{
			return other != null && (other == this || (this.GamePlayId == other.GamePlayId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017FC6 RID: 98246 RVA: 0x0037D7A4 File Offset: 0x0037B9A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GamePlayId != 0)
			{
				num ^= this.GamePlayId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017FC7 RID: 98247 RVA: 0x0037D7E3 File Offset: 0x0037B9E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017FC8 RID: 98248 RVA: 0x0037D7F0 File Offset: 0x0037B9F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017FC9 RID: 98249 RVA: 0x0037D7F9 File Offset: 0x0037B9F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GamePlayId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.GamePlayId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017FCA RID: 98250 RVA: 0x0037D82C File Offset: 0x0037BA2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GamePlayId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GamePlayId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017FCB RID: 98251 RVA: 0x0037D86A File Offset: 0x0037BA6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneGamePlayFirstNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GamePlayId != 0)
			{
				this.GamePlayId = other.GamePlayId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017FCC RID: 98252 RVA: 0x0037D89B File Offset: 0x0037BA9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017FCD RID: 98253 RVA: 0x0037D8A4 File Offset: 0x0037BAA4
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.GamePlayId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008EDA RID: 36570
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008EDB RID: 36571
		public const int GamePlayIdFieldNumber = 10;

		// Token: 0x04008EDC RID: 36572
		private int gamePlayId_;
	}
}
