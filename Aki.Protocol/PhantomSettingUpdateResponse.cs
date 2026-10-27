using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D05 RID: 3333
	[NetMessage(EMessageId.PhantomSettingUpdateResponse)]
	public sealed class PhantomSettingUpdateResponse : IMessage<PhantomSettingUpdateResponse>, IMessage, IEquatable<PhantomSettingUpdateResponse>, IDeepCloneable<PhantomSettingUpdateResponse>, IBufferMessage
	{
		// Token: 0x06012037 RID: 73783 RVA: 0x002A21BF File Offset: 0x002A03BF
		[NullableContext(1)]
		public static PhantomSettingUpdateResponse Create()
		{
			return new PhantomSettingUpdateResponse();
		}

		// Token: 0x17003BAF RID: 15279
		// (get) Token: 0x06012038 RID: 73784 RVA: 0x002A21C6 File Offset: 0x002A03C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003BB0 RID: 15280
		// (get) Token: 0x06012039 RID: 73785 RVA: 0x002A21C9 File Offset: 0x002A03C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomSettingUpdateResponse.Descriptor;
			}
		}

		// Token: 0x0601203A RID: 73786 RVA: 0x002A21D0 File Offset: 0x002A03D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomSettingUpdateResponse()
		{
		}

		// Token: 0x0601203B RID: 73787 RVA: 0x002A21D8 File Offset: 0x002A03D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomSettingUpdateResponse(PhantomSettingUpdateResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.setting_ = ((other.setting_ != null) ? other.setting_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601203C RID: 73788 RVA: 0x002A2224 File Offset: 0x002A0424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomSettingUpdateResponse Clone()
		{
			return new PhantomSettingUpdateResponse(this);
		}

		// Token: 0x17003BB1 RID: 15281
		// (get) Token: 0x0601203D RID: 73789 RVA: 0x002A222C File Offset: 0x002A042C
		// (set) Token: 0x0601203E RID: 73790 RVA: 0x002A2234 File Offset: 0x002A0434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x17003BB2 RID: 15282
		// (get) Token: 0x0601203F RID: 73791 RVA: 0x002A223D File Offset: 0x002A043D
		// (set) Token: 0x06012040 RID: 73792 RVA: 0x002A2245 File Offset: 0x002A0445
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OnePhantomSetting Setting
		{
			get
			{
				return this.setting_;
			}
			set
			{
				this.setting_ = value;
			}
		}

		// Token: 0x06012041 RID: 73793 RVA: 0x002A224E File Offset: 0x002A044E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomSettingUpdateResponse);
		}

		// Token: 0x06012042 RID: 73794 RVA: 0x002A225C File Offset: 0x002A045C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomSettingUpdateResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.Setting, other.Setting) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012043 RID: 73795 RVA: 0x002A22AC File Offset: 0x002A04AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.setting_ != null)
			{
				num ^= this.Setting.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012044 RID: 73796 RVA: 0x002A2307 File Offset: 0x002A0507
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012045 RID: 73797 RVA: 0x002A2314 File Offset: 0x002A0514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012046 RID: 73798 RVA: 0x002A2320 File Offset: 0x002A0520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.setting_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Setting);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012047 RID: 73799 RVA: 0x002A237C File Offset: 0x002A057C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.setting_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Setting);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012048 RID: 73800 RVA: 0x002A23D4 File Offset: 0x002A05D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomSettingUpdateResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.setting_ != null)
			{
				if (this.setting_ == null)
				{
					this.Setting = new OnePhantomSetting();
				}
				this.Setting.MergeFrom(other.Setting);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012049 RID: 73801 RVA: 0x002A243C File Offset: 0x002A063C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601204A RID: 73802 RVA: 0x002A2448 File Offset: 0x002A0648
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
				if (num != 18U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					if (this.setting_ == null)
					{
						this.Setting = new OnePhantomSetting();
					}
					input.ReadMessage(this.Setting);
				}
			}
		}

		// Token: 0x040070D3 RID: 28883
		private UnknownFieldSet _unknownFields;

		// Token: 0x040070D4 RID: 28884
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x040070D5 RID: 28885
		private ErrorCode errorCode_;

		// Token: 0x040070D6 RID: 28886
		public const int SettingFieldNumber = 2;

		// Token: 0x040070D7 RID: 28887
		private OnePhantomSetting setting_;
	}
}
