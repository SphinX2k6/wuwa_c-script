using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D01 RID: 3329
	public sealed class PhantomSettingInfo : IMessage<PhantomSettingInfo>, IMessage, IEquatable<PhantomSettingInfo>, IDeepCloneable<PhantomSettingInfo>, IBufferMessage
	{
		// Token: 0x06011FEA RID: 73706 RVA: 0x002A17E7 File Offset: 0x0029F9E7
		[NullableContext(1)]
		public static PhantomSettingInfo Create()
		{
			return new PhantomSettingInfo();
		}

		// Token: 0x17003BA0 RID: 15264
		// (get) Token: 0x06011FEB RID: 73707 RVA: 0x002A17EE File Offset: 0x0029F9EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhantomSettingInfo> Parser
		{
			get
			{
				return PhantomSettingInfo._parser;
			}
		}

		// Token: 0x17003BA1 RID: 15265
		// (get) Token: 0x06011FEC RID: 73708 RVA: 0x002A17F5 File Offset: 0x0029F9F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003BA2 RID: 15266
		// (get) Token: 0x06011FED RID: 73709 RVA: 0x002A17F8 File Offset: 0x0029F9F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomSettingInfo.Descriptor;
			}
		}

		// Token: 0x06011FEE RID: 73710 RVA: 0x002A17FF File Offset: 0x0029F9FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomSettingInfo()
		{
		}

		// Token: 0x06011FEF RID: 73711 RVA: 0x002A1808 File Offset: 0x0029FA08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomSettingInfo(PhantomSettingInfo other) : this()
		{
			this.setting_ = ((other.setting_ != null) ? other.setting_.Clone() : null);
			this.settingType_ = other.settingType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011FF0 RID: 73712 RVA: 0x002A1854 File Offset: 0x0029FA54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomSettingInfo Clone()
		{
			return new PhantomSettingInfo(this);
		}

		// Token: 0x17003BA3 RID: 15267
		// (get) Token: 0x06011FF1 RID: 73713 RVA: 0x002A185C File Offset: 0x0029FA5C
		// (set) Token: 0x06011FF2 RID: 73714 RVA: 0x002A1864 File Offset: 0x0029FA64
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

		// Token: 0x17003BA4 RID: 15268
		// (get) Token: 0x06011FF3 RID: 73715 RVA: 0x002A186D File Offset: 0x0029FA6D
		// (set) Token: 0x06011FF4 RID: 73716 RVA: 0x002A1875 File Offset: 0x0029FA75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomSettingType SettingType
		{
			get
			{
				return this.settingType_;
			}
			set
			{
				this.settingType_ = value;
			}
		}

		// Token: 0x06011FF5 RID: 73717 RVA: 0x002A187E File Offset: 0x0029FA7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomSettingInfo);
		}

		// Token: 0x06011FF6 RID: 73718 RVA: 0x002A188C File Offset: 0x0029FA8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomSettingInfo other)
		{
			return other != null && (other == this || (object.Equals(this.Setting, other.Setting) && this.SettingType == other.SettingType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011FF7 RID: 73719 RVA: 0x002A18DC File Offset: 0x0029FADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.setting_ != null)
			{
				num ^= this.Setting.GetHashCode();
			}
			if (this.SettingType != PhantomSettingType.AutoLock)
			{
				num ^= this.SettingType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011FF8 RID: 73720 RVA: 0x002A1937 File Offset: 0x0029FB37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011FF9 RID: 73721 RVA: 0x002A1944 File Offset: 0x0029FB44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011FFA RID: 73722 RVA: 0x002A1950 File Offset: 0x0029FB50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.setting_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Setting);
			}
			if (this.SettingType != PhantomSettingType.AutoLock)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.SettingType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011FFB RID: 73723 RVA: 0x002A19AC File Offset: 0x0029FBAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.setting_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Setting);
			}
			if (this.SettingType != PhantomSettingType.AutoLock)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.SettingType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011FFC RID: 73724 RVA: 0x002A1A04 File Offset: 0x0029FC04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomSettingInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.setting_ != null)
			{
				if (this.setting_ == null)
				{
					this.Setting = new OnePhantomSetting();
				}
				this.Setting.MergeFrom(other.Setting);
			}
			if (other.SettingType != PhantomSettingType.AutoLock)
			{
				this.SettingType = other.SettingType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011FFD RID: 73725 RVA: 0x002A1A6C File Offset: 0x0029FC6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011FFE RID: 73726 RVA: 0x002A1A78 File Offset: 0x0029FC78
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
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SettingType = (PhantomSettingType)input.ReadEnum();
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

		// Token: 0x040070C0 RID: 28864
		private static readonly MessageParser<PhantomSettingInfo> _parser = new MessageParser<PhantomSettingInfo>(() => new PhantomSettingInfo());

		// Token: 0x040070C1 RID: 28865
		private UnknownFieldSet _unknownFields;

		// Token: 0x040070C2 RID: 28866
		public const int SettingFieldNumber = 1;

		// Token: 0x040070C3 RID: 28867
		private OnePhantomSetting setting_;

		// Token: 0x040070C4 RID: 28868
		public const int SettingTypeFieldNumber = 2;

		// Token: 0x040070C5 RID: 28869
		private PhantomSettingType settingType_;
	}
}
