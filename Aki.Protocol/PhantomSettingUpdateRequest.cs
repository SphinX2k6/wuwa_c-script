using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D04 RID: 3332
	[NetMessage(EMessageId.PhantomSettingUpdateRequest)]
	public sealed class PhantomSettingUpdateRequest : IMessage<PhantomSettingUpdateRequest>, IMessage, IEquatable<PhantomSettingUpdateRequest>, IDeepCloneable<PhantomSettingUpdateRequest>, IBufferMessage
	{
		// Token: 0x06012023 RID: 73763 RVA: 0x002A1ECA File Offset: 0x002A00CA
		[NullableContext(1)]
		public static PhantomSettingUpdateRequest Create()
		{
			return new PhantomSettingUpdateRequest();
		}

		// Token: 0x17003BAB RID: 15275
		// (get) Token: 0x06012024 RID: 73764 RVA: 0x002A1ED1 File Offset: 0x002A00D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003BAC RID: 15276
		// (get) Token: 0x06012025 RID: 73765 RVA: 0x002A1ED4 File Offset: 0x002A00D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomSettingUpdateRequest.Descriptor;
			}
		}

		// Token: 0x06012026 RID: 73766 RVA: 0x002A1EDB File Offset: 0x002A00DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomSettingUpdateRequest()
		{
		}

		// Token: 0x06012027 RID: 73767 RVA: 0x002A1EE4 File Offset: 0x002A00E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomSettingUpdateRequest(PhantomSettingUpdateRequest other) : this()
		{
			this.setting_ = ((other.setting_ != null) ? other.setting_.Clone() : null);
			this.settingType_ = other.settingType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012028 RID: 73768 RVA: 0x002A1F30 File Offset: 0x002A0130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomSettingUpdateRequest Clone()
		{
			return new PhantomSettingUpdateRequest(this);
		}

		// Token: 0x17003BAD RID: 15277
		// (get) Token: 0x06012029 RID: 73769 RVA: 0x002A1F38 File Offset: 0x002A0138
		// (set) Token: 0x0601202A RID: 73770 RVA: 0x002A1F40 File Offset: 0x002A0140
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

		// Token: 0x17003BAE RID: 15278
		// (get) Token: 0x0601202B RID: 73771 RVA: 0x002A1F49 File Offset: 0x002A0149
		// (set) Token: 0x0601202C RID: 73772 RVA: 0x002A1F51 File Offset: 0x002A0151
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

		// Token: 0x0601202D RID: 73773 RVA: 0x002A1F5A File Offset: 0x002A015A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomSettingUpdateRequest);
		}

		// Token: 0x0601202E RID: 73774 RVA: 0x002A1F68 File Offset: 0x002A0168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomSettingUpdateRequest other)
		{
			return other != null && (other == this || (object.Equals(this.Setting, other.Setting) && this.SettingType == other.SettingType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601202F RID: 73775 RVA: 0x002A1FB8 File Offset: 0x002A01B8
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

		// Token: 0x06012030 RID: 73776 RVA: 0x002A2013 File Offset: 0x002A0213
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012031 RID: 73777 RVA: 0x002A2020 File Offset: 0x002A0220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012032 RID: 73778 RVA: 0x002A202C File Offset: 0x002A022C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.setting_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.Setting);
			}
			if (this.SettingType != PhantomSettingType.AutoLock)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.SettingType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012033 RID: 73779 RVA: 0x002A2088 File Offset: 0x002A0288
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

		// Token: 0x06012034 RID: 73780 RVA: 0x002A20E0 File Offset: 0x002A02E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomSettingUpdateRequest other)
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

		// Token: 0x06012035 RID: 73781 RVA: 0x002A2148 File Offset: 0x002A0348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012036 RID: 73782 RVA: 0x002A2154 File Offset: 0x002A0354
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
				if (num != 50U)
				{
					if (num != 120U)
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

		// Token: 0x040070CE RID: 28878
		private UnknownFieldSet _unknownFields;

		// Token: 0x040070CF RID: 28879
		public const int SettingFieldNumber = 6;

		// Token: 0x040070D0 RID: 28880
		private OnePhantomSetting setting_;

		// Token: 0x040070D1 RID: 28881
		public const int SettingTypeFieldNumber = 15;

		// Token: 0x040070D2 RID: 28882
		private PhantomSettingType settingType_;
	}
}
