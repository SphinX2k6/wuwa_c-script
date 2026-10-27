using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000511 RID: 1297
	public sealed class ExtraDeadInfo : IMessage<ExtraDeadInfo>, IMessage, IEquatable<ExtraDeadInfo>, IDeepCloneable<ExtraDeadInfo>, IBufferMessage
	{
		// Token: 0x060079F9 RID: 31225 RVA: 0x001285AF File Offset: 0x001267AF
		[NullableContext(1)]
		public static ExtraDeadInfo Create()
		{
			return new ExtraDeadInfo();
		}

		// Token: 0x170017A4 RID: 6052
		// (get) Token: 0x060079FA RID: 31226 RVA: 0x001285B6 File Offset: 0x001267B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExtraDeadInfo> Parser
		{
			get
			{
				return ExtraDeadInfo._parser;
			}
		}

		// Token: 0x170017A5 RID: 6053
		// (get) Token: 0x060079FB RID: 31227 RVA: 0x001285BD File Offset: 0x001267BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170017A6 RID: 6054
		// (get) Token: 0x060079FC RID: 31228 RVA: 0x001285C0 File Offset: 0x001267C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExtraDeadInfo.Descriptor;
			}
		}

		// Token: 0x060079FD RID: 31229 RVA: 0x001285C7 File Offset: 0x001267C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExtraDeadInfo()
		{
		}

		// Token: 0x060079FE RID: 31230 RVA: 0x001285CF File Offset: 0x001267CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExtraDeadInfo(ExtraDeadInfo other) : this()
		{
			if (other.MessageCase == ExtraDeadInfo.MessageOneofCase.BtObjYuXueModeInfo)
			{
				this.BtObjYuXueModeInfo = other.BtObjYuXueModeInfo.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060079FF RID: 31231 RVA: 0x00128602 File Offset: 0x00126802
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExtraDeadInfo Clone()
		{
			return new ExtraDeadInfo(this);
		}

		// Token: 0x170017A7 RID: 6055
		// (get) Token: 0x06007A00 RID: 31232 RVA: 0x0012860A File Offset: 0x0012680A
		// (set) Token: 0x06007A01 RID: 31233 RVA: 0x00128622 File Offset: 0x00126822
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtObjYuXueModeInfo BtObjYuXueModeInfo
		{
			get
			{
				if (this.messageCase_ != ExtraDeadInfo.MessageOneofCase.BtObjYuXueModeInfo)
				{
					return null;
				}
				return (BtObjYuXueModeInfo)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? ExtraDeadInfo.MessageOneofCase.None : ExtraDeadInfo.MessageOneofCase.BtObjYuXueModeInfo);
			}
		}

		// Token: 0x170017A8 RID: 6056
		// (get) Token: 0x06007A02 RID: 31234 RVA: 0x00128638 File Offset: 0x00126838
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExtraDeadInfo.MessageOneofCase MessageCase
		{
			get
			{
				return this.messageCase_;
			}
		}

		// Token: 0x06007A03 RID: 31235 RVA: 0x00128640 File Offset: 0x00126840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearMessage()
		{
			this.messageCase_ = ExtraDeadInfo.MessageOneofCase.None;
			this.message_ = null;
		}

		// Token: 0x06007A04 RID: 31236 RVA: 0x00128650 File Offset: 0x00126850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExtraDeadInfo);
		}

		// Token: 0x06007A05 RID: 31237 RVA: 0x00128660 File Offset: 0x00126860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExtraDeadInfo other)
		{
			return other != null && (other == this || (object.Equals(this.BtObjYuXueModeInfo, other.BtObjYuXueModeInfo) && this.MessageCase == other.MessageCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007A06 RID: 31238 RVA: 0x001286B0 File Offset: 0x001268B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.messageCase_ == ExtraDeadInfo.MessageOneofCase.BtObjYuXueModeInfo)
			{
				num ^= this.BtObjYuXueModeInfo.GetHashCode();
			}
			num ^= (int)this.messageCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007A07 RID: 31239 RVA: 0x001286F6 File Offset: 0x001268F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007A08 RID: 31240 RVA: 0x00128703 File Offset: 0x00126903
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007A09 RID: 31241 RVA: 0x0012870C File Offset: 0x0012690C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.messageCase_ == ExtraDeadInfo.MessageOneofCase.BtObjYuXueModeInfo)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.BtObjYuXueModeInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007A0A RID: 31242 RVA: 0x00128740 File Offset: 0x00126940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.messageCase_ == ExtraDeadInfo.MessageOneofCase.BtObjYuXueModeInfo)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BtObjYuXueModeInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007A0B RID: 31243 RVA: 0x00128780 File Offset: 0x00126980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExtraDeadInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MessageCase == ExtraDeadInfo.MessageOneofCase.BtObjYuXueModeInfo)
			{
				if (this.BtObjYuXueModeInfo == null)
				{
					this.BtObjYuXueModeInfo = new BtObjYuXueModeInfo();
				}
				this.BtObjYuXueModeInfo.MergeFrom(other.BtObjYuXueModeInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007A0C RID: 31244 RVA: 0x001287D5 File Offset: 0x001269D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007A0D RID: 31245 RVA: 0x001287E0 File Offset: 0x001269E0
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					BtObjYuXueModeInfo btObjYuXueModeInfo = new BtObjYuXueModeInfo();
					if (this.messageCase_ == ExtraDeadInfo.MessageOneofCase.BtObjYuXueModeInfo)
					{
						btObjYuXueModeInfo.MergeFrom(this.BtObjYuXueModeInfo);
					}
					input.ReadMessage(btObjYuXueModeInfo);
					this.BtObjYuXueModeInfo = btObjYuXueModeInfo;
				}
			}
		}

		// Token: 0x04003ECD RID: 16077
		private static readonly MessageParser<ExtraDeadInfo> _parser = new MessageParser<ExtraDeadInfo>(() => new ExtraDeadInfo());

		// Token: 0x04003ECE RID: 16078
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003ECF RID: 16079
		public const int BtObjYuXueModeInfoFieldNumber = 1;

		// Token: 0x04003ED0 RID: 16080
		private object message_;

		// Token: 0x04003ED1 RID: 16081
		private ExtraDeadInfo.MessageOneofCase messageCase_;

		// Token: 0x02001787 RID: 6023
		public enum MessageOneofCase
		{
			// Token: 0x0400C6A2 RID: 50850
			None,
			// Token: 0x0400C6A3 RID: 50851
			BtObjYuXueModeInfo
		}
	}
}
