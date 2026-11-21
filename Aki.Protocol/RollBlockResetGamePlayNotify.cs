using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200111D RID: 4381
	[NetMessage(EMessageId.RollBlockResetGamePlayNotify)]
	public sealed class RollBlockResetGamePlayNotify : IMessage<RollBlockResetGamePlayNotify>, IMessage, IEquatable<RollBlockResetGamePlayNotify>, IDeepCloneable<RollBlockResetGamePlayNotify>, IBufferMessage
	{
		// Token: 0x06017694 RID: 95892 RVA: 0x00367F28 File Offset: 0x00366128
		[NullableContext(1)]
		public static RollBlockResetGamePlayNotify Create()
		{
			return new RollBlockResetGamePlayNotify();
		}

		// Token: 0x17004EAA RID: 20138
		// (get) Token: 0x06017695 RID: 95893 RVA: 0x00367F2F File Offset: 0x0036612F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004EAB RID: 20139
		// (get) Token: 0x06017696 RID: 95894 RVA: 0x00367F32 File Offset: 0x00366132
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RollBlockResetGamePlayNotify.Descriptor;
			}
		}

		// Token: 0x06017697 RID: 95895 RVA: 0x00367F39 File Offset: 0x00366139
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockResetGamePlayNotify()
		{
		}

		// Token: 0x06017698 RID: 95896 RVA: 0x00367F41 File Offset: 0x00366141
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockResetGamePlayNotify(RollBlockResetGamePlayNotify other) : this()
		{
			this.info_ = ((other.info_ != null) ? other.info_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017699 RID: 95897 RVA: 0x00367F76 File Offset: 0x00366176
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockResetGamePlayNotify Clone()
		{
			return new RollBlockResetGamePlayNotify(this);
		}

		// Token: 0x17004EAC RID: 20140
		// (get) Token: 0x0601769A RID: 95898 RVA: 0x00367F7E File Offset: 0x0036617E
		// (set) Token: 0x0601769B RID: 95899 RVA: 0x00367F86 File Offset: 0x00366186
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockGamePlayPbInfo Info
		{
			get
			{
				return this.info_;
			}
			set
			{
				this.info_ = value;
			}
		}

		// Token: 0x0601769C RID: 95900 RVA: 0x00367F8F File Offset: 0x0036618F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RollBlockResetGamePlayNotify);
		}

		// Token: 0x0601769D RID: 95901 RVA: 0x00367F9D File Offset: 0x0036619D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RollBlockResetGamePlayNotify other)
		{
			return other != null && (other == this || (object.Equals(this.Info, other.Info) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601769E RID: 95902 RVA: 0x00367FD0 File Offset: 0x003661D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.info_ != null)
			{
				num ^= this.Info.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601769F RID: 95903 RVA: 0x0036800C File Offset: 0x0036620C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060176A0 RID: 95904 RVA: 0x00368019 File Offset: 0x00366219
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060176A1 RID: 95905 RVA: 0x00368022 File Offset: 0x00366222
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.info_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.Info);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060176A2 RID: 95906 RVA: 0x00368054 File Offset: 0x00366254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.info_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Info);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060176A3 RID: 95907 RVA: 0x00368094 File Offset: 0x00366294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RollBlockResetGamePlayNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.info_ != null)
			{
				if (this.info_ == null)
				{
					this.Info = new RollBlockGamePlayPbInfo();
				}
				this.Info.MergeFrom(other.Info);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060176A4 RID: 95908 RVA: 0x003680E8 File Offset: 0x003662E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060176A5 RID: 95909 RVA: 0x003680F4 File Offset: 0x003662F4
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.info_ == null)
					{
						this.Info = new RollBlockGamePlayPbInfo();
					}
					input.ReadMessage(this.Info);
				}
			}
		}

		// Token: 0x04008BCA RID: 35786
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008BCB RID: 35787
		public const int InfoFieldNumber = 5;

		// Token: 0x04008BCC RID: 35788
		private RollBlockGamePlayPbInfo info_;
	}
}
