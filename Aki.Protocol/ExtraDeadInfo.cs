using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004FB RID: 1275
	public sealed class ExtraDeadInfo : IMessage<ExtraDeadInfo>, IMessage, IEquatable<ExtraDeadInfo>, IDeepCloneable<ExtraDeadInfo>, IBufferMessage
	{
		// Token: 0x0600787D RID: 30845 RVA: 0x0012571B File Offset: 0x0012391B
		[NullableContext(1)]
		public static ExtraDeadInfo Create()
		{
			return new ExtraDeadInfo();
		}

		// Token: 0x17001753 RID: 5971
		// (get) Token: 0x0600787E RID: 30846 RVA: 0x00125722 File Offset: 0x00123922
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExtraDeadInfo> Parser
		{
			get
			{
				return ExtraDeadInfo._parser;
			}
		}

		// Token: 0x17001754 RID: 5972
		// (get) Token: 0x0600787F RID: 30847 RVA: 0x00125729 File Offset: 0x00123929
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001755 RID: 5973
		// (get) Token: 0x06007880 RID: 30848 RVA: 0x0012572C File Offset: 0x0012392C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExtraDeadInfo.Descriptor;
			}
		}

		// Token: 0x06007881 RID: 30849 RVA: 0x00125733 File Offset: 0x00123933
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExtraDeadInfo()
		{
		}

		// Token: 0x06007882 RID: 30850 RVA: 0x0012573B File Offset: 0x0012393B
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

		// Token: 0x06007883 RID: 30851 RVA: 0x0012576E File Offset: 0x0012396E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExtraDeadInfo Clone()
		{
			return new ExtraDeadInfo(this);
		}

		// Token: 0x17001756 RID: 5974
		// (get) Token: 0x06007884 RID: 30852 RVA: 0x00125776 File Offset: 0x00123976
		// (set) Token: 0x06007885 RID: 30853 RVA: 0x0012578E File Offset: 0x0012398E
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

		// Token: 0x17001757 RID: 5975
		// (get) Token: 0x06007886 RID: 30854 RVA: 0x001257A4 File Offset: 0x001239A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExtraDeadInfo.MessageOneofCase MessageCase
		{
			get
			{
				return this.messageCase_;
			}
		}

		// Token: 0x06007887 RID: 30855 RVA: 0x001257AC File Offset: 0x001239AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearMessage()
		{
			this.messageCase_ = ExtraDeadInfo.MessageOneofCase.None;
			this.message_ = null;
		}

		// Token: 0x06007888 RID: 30856 RVA: 0x001257BC File Offset: 0x001239BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExtraDeadInfo);
		}

		// Token: 0x06007889 RID: 30857 RVA: 0x001257CC File Offset: 0x001239CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExtraDeadInfo other)
		{
			return other != null && (other == this || (object.Equals(this.BtObjYuXueModeInfo, other.BtObjYuXueModeInfo) && this.MessageCase == other.MessageCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600788A RID: 30858 RVA: 0x0012581C File Offset: 0x00123A1C
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

		// Token: 0x0600788B RID: 30859 RVA: 0x00125862 File Offset: 0x00123A62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600788C RID: 30860 RVA: 0x0012586F File Offset: 0x00123A6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600788D RID: 30861 RVA: 0x00125878 File Offset: 0x00123A78
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

		// Token: 0x0600788E RID: 30862 RVA: 0x001258AC File Offset: 0x00123AAC
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

		// Token: 0x0600788F RID: 30863 RVA: 0x001258EC File Offset: 0x00123AEC
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

		// Token: 0x06007890 RID: 30864 RVA: 0x00125941 File Offset: 0x00123B41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007891 RID: 30865 RVA: 0x0012594C File Offset: 0x00123B4C
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

		// Token: 0x04003EBE RID: 16062
		private static readonly MessageParser<ExtraDeadInfo> _parser = new MessageParser<ExtraDeadInfo>(() => new ExtraDeadInfo());

		// Token: 0x04003EBF RID: 16063
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003EC0 RID: 16064
		public const int BtObjYuXueModeInfoFieldNumber = 1;

		// Token: 0x04003EC1 RID: 16065
		private object message_;

		// Token: 0x04003EC2 RID: 16066
		private ExtraDeadInfo.MessageOneofCase messageCase_;

		// Token: 0x020017FF RID: 6143
		public enum MessageOneofCase
		{
			// Token: 0x0400CBCD RID: 52173
			None,
			// Token: 0x0400CBCE RID: 52174
			BtObjYuXueModeInfo
		}
	}
}
