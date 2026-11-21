using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011FD RID: 4605
	[NetMessage(EMessageId.SelfPortraitStateResponse)]
	public sealed class SelfPortraitStateResponse : IMessage<SelfPortraitStateResponse>, IMessage, IEquatable<SelfPortraitStateResponse>, IDeepCloneable<SelfPortraitStateResponse>, IBufferMessage
	{
		// Token: 0x060189CB RID: 100811 RVA: 0x003973FD File Offset: 0x003955FD
		[NullableContext(1)]
		public static SelfPortraitStateResponse Create()
		{
			return new SelfPortraitStateResponse();
		}

		// Token: 0x17005326 RID: 21286
		// (get) Token: 0x060189CC RID: 100812 RVA: 0x00397404 File Offset: 0x00395604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005327 RID: 21287
		// (get) Token: 0x060189CD RID: 100813 RVA: 0x00397407 File Offset: 0x00395607
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SelfPortraitStateResponse.Descriptor;
			}
		}

		// Token: 0x060189CE RID: 100814 RVA: 0x0039740E File Offset: 0x0039560E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelfPortraitStateResponse()
		{
		}

		// Token: 0x060189CF RID: 100815 RVA: 0x00397416 File Offset: 0x00395616
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelfPortraitStateResponse(SelfPortraitStateResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060189D0 RID: 100816 RVA: 0x0039743B File Offset: 0x0039563B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelfPortraitStateResponse Clone()
		{
			return new SelfPortraitStateResponse(this);
		}

		// Token: 0x17005328 RID: 21288
		// (get) Token: 0x060189D1 RID: 100817 RVA: 0x00397443 File Offset: 0x00395643
		// (set) Token: 0x060189D2 RID: 100818 RVA: 0x0039744B File Offset: 0x0039564B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrCode
		{
			get
			{
				return this.errCode_;
			}
			set
			{
				this.errCode_ = value;
			}
		}

		// Token: 0x060189D3 RID: 100819 RVA: 0x00397454 File Offset: 0x00395654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SelfPortraitStateResponse);
		}

		// Token: 0x060189D4 RID: 100820 RVA: 0x00397462 File Offset: 0x00395662
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SelfPortraitStateResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060189D5 RID: 100821 RVA: 0x00397490 File Offset: 0x00395690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060189D6 RID: 100822 RVA: 0x003974D5 File Offset: 0x003956D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060189D7 RID: 100823 RVA: 0x003974E2 File Offset: 0x003956E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060189D8 RID: 100824 RVA: 0x003974EB File Offset: 0x003956EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060189D9 RID: 100825 RVA: 0x00397520 File Offset: 0x00395720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060189DA RID: 100826 RVA: 0x0039755E File Offset: 0x0039575E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SelfPortraitStateResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060189DB RID: 100827 RVA: 0x0039758F File Offset: 0x0039578F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060189DC RID: 100828 RVA: 0x00397598 File Offset: 0x00395798
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009260 RID: 37472
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009261 RID: 37473
		public const int ErrCodeFieldNumber = 13;

		// Token: 0x04009262 RID: 37474
		private ErrorCode errCode_;
	}
}
