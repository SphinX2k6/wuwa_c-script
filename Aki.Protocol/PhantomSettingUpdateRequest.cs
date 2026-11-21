using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CF4 RID: 3316
	[NetMessage(EMessageId.PhantomSettingUpdateRequest)]
	public sealed class PhantomSettingUpdateRequest : IMessage<PhantomSettingUpdateRequest>, IMessage, IEquatable<PhantomSettingUpdateRequest>, IDeepCloneable<PhantomSettingUpdateRequest>, IBufferMessage
	{
		// Token: 0x06011F27 RID: 73511 RVA: 0x002A02B2 File Offset: 0x0029E4B2
		[NullableContext(1)]
		public static PhantomSettingUpdateRequest Create()
		{
			return new PhantomSettingUpdateRequest();
		}

		// Token: 0x17003B76 RID: 15222
		// (get) Token: 0x06011F28 RID: 73512 RVA: 0x002A02B9 File Offset: 0x0029E4B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003B77 RID: 15223
		// (get) Token: 0x06011F29 RID: 73513 RVA: 0x002A02BC File Offset: 0x0029E4BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomSettingUpdateRequest.Descriptor;
			}
		}

		// Token: 0x06011F2A RID: 73514 RVA: 0x002A02C3 File Offset: 0x0029E4C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomSettingUpdateRequest()
		{
		}

		// Token: 0x06011F2B RID: 73515 RVA: 0x002A02CC File Offset: 0x0029E4CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomSettingUpdateRequest(PhantomSettingUpdateRequest other) : this()
		{
			this.setting_ = ((other.setting_ != null) ? other.setting_.Clone() : null);
			this.settingType_ = other.settingType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011F2C RID: 73516 RVA: 0x002A0318 File Offset: 0x0029E518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomSettingUpdateRequest Clone()
		{
			return new PhantomSettingUpdateRequest(this);
		}

		// Token: 0x17003B78 RID: 15224
		// (get) Token: 0x06011F2D RID: 73517 RVA: 0x002A0320 File Offset: 0x0029E520
		// (set) Token: 0x06011F2E RID: 73518 RVA: 0x002A0328 File Offset: 0x0029E528
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

		// Token: 0x17003B79 RID: 15225
		// (get) Token: 0x06011F2F RID: 73519 RVA: 0x002A0331 File Offset: 0x0029E531
		// (set) Token: 0x06011F30 RID: 73520 RVA: 0x002A0339 File Offset: 0x0029E539
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

		// Token: 0x06011F31 RID: 73521 RVA: 0x002A0342 File Offset: 0x0029E542
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomSettingUpdateRequest);
		}

		// Token: 0x06011F32 RID: 73522 RVA: 0x002A0350 File Offset: 0x0029E550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomSettingUpdateRequest other)
		{
			return other != null && (other == this || (object.Equals(this.Setting, other.Setting) && this.SettingType == other.SettingType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011F33 RID: 73523 RVA: 0x002A03A0 File Offset: 0x0029E5A0
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

		// Token: 0x06011F34 RID: 73524 RVA: 0x002A03FB File Offset: 0x0029E5FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011F35 RID: 73525 RVA: 0x002A0408 File Offset: 0x0029E608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011F36 RID: 73526 RVA: 0x002A0414 File Offset: 0x0029E614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SettingType != PhantomSettingType.AutoLock)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.SettingType);
			}
			if (this.setting_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.Setting);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011F37 RID: 73527 RVA: 0x002A046C File Offset: 0x0029E66C
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

		// Token: 0x06011F38 RID: 73528 RVA: 0x002A04C4 File Offset: 0x0029E6C4
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

		// Token: 0x06011F39 RID: 73529 RVA: 0x002A052C File Offset: 0x0029E72C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011F3A RID: 73530 RVA: 0x002A0538 File Offset: 0x0029E738
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
				if (num != 8U)
				{
					if (num != 66U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.SettingType = (PhantomSettingType)input.ReadEnum();
				}
			}
		}

		// Token: 0x040070E6 RID: 28902
		private UnknownFieldSet _unknownFields;

		// Token: 0x040070E7 RID: 28903
		public const int SettingFieldNumber = 8;

		// Token: 0x040070E8 RID: 28904
		private OnePhantomSetting setting_;

		// Token: 0x040070E9 RID: 28905
		public const int SettingTypeFieldNumber = 1;

		// Token: 0x040070EA RID: 28906
		private PhantomSettingType settingType_;
	}
}
