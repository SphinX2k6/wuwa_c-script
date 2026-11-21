using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CF1 RID: 3313
	public sealed class PhantomSettingInfo : IMessage<PhantomSettingInfo>, IMessage, IEquatable<PhantomSettingInfo>, IDeepCloneable<PhantomSettingInfo>, IBufferMessage
	{
		// Token: 0x06011EEE RID: 73454 RVA: 0x0029FBCF File Offset: 0x0029DDCF
		[NullableContext(1)]
		public static PhantomSettingInfo Create()
		{
			return new PhantomSettingInfo();
		}

		// Token: 0x17003B6B RID: 15211
		// (get) Token: 0x06011EEF RID: 73455 RVA: 0x0029FBD6 File Offset: 0x0029DDD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhantomSettingInfo> Parser
		{
			get
			{
				return PhantomSettingInfo._parser;
			}
		}

		// Token: 0x17003B6C RID: 15212
		// (get) Token: 0x06011EF0 RID: 73456 RVA: 0x0029FBDD File Offset: 0x0029DDDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003B6D RID: 15213
		// (get) Token: 0x06011EF1 RID: 73457 RVA: 0x0029FBE0 File Offset: 0x0029DDE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomSettingInfo.Descriptor;
			}
		}

		// Token: 0x06011EF2 RID: 73458 RVA: 0x0029FBE7 File Offset: 0x0029DDE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomSettingInfo()
		{
		}

		// Token: 0x06011EF3 RID: 73459 RVA: 0x0029FBF0 File Offset: 0x0029DDF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomSettingInfo(PhantomSettingInfo other) : this()
		{
			this.setting_ = ((other.setting_ != null) ? other.setting_.Clone() : null);
			this.settingType_ = other.settingType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011EF4 RID: 73460 RVA: 0x0029FC3C File Offset: 0x0029DE3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomSettingInfo Clone()
		{
			return new PhantomSettingInfo(this);
		}

		// Token: 0x17003B6E RID: 15214
		// (get) Token: 0x06011EF5 RID: 73461 RVA: 0x0029FC44 File Offset: 0x0029DE44
		// (set) Token: 0x06011EF6 RID: 73462 RVA: 0x0029FC4C File Offset: 0x0029DE4C
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

		// Token: 0x17003B6F RID: 15215
		// (get) Token: 0x06011EF7 RID: 73463 RVA: 0x0029FC55 File Offset: 0x0029DE55
		// (set) Token: 0x06011EF8 RID: 73464 RVA: 0x0029FC5D File Offset: 0x0029DE5D
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

		// Token: 0x06011EF9 RID: 73465 RVA: 0x0029FC66 File Offset: 0x0029DE66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomSettingInfo);
		}

		// Token: 0x06011EFA RID: 73466 RVA: 0x0029FC74 File Offset: 0x0029DE74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomSettingInfo other)
		{
			return other != null && (other == this || (object.Equals(this.Setting, other.Setting) && this.SettingType == other.SettingType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011EFB RID: 73467 RVA: 0x0029FCC4 File Offset: 0x0029DEC4
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

		// Token: 0x06011EFC RID: 73468 RVA: 0x0029FD1F File Offset: 0x0029DF1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011EFD RID: 73469 RVA: 0x0029FD2C File Offset: 0x0029DF2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011EFE RID: 73470 RVA: 0x0029FD38 File Offset: 0x0029DF38
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

		// Token: 0x06011EFF RID: 73471 RVA: 0x0029FD94 File Offset: 0x0029DF94
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

		// Token: 0x06011F00 RID: 73472 RVA: 0x0029FDEC File Offset: 0x0029DFEC
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

		// Token: 0x06011F01 RID: 73473 RVA: 0x0029FE54 File Offset: 0x0029E054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011F02 RID: 73474 RVA: 0x0029FE60 File Offset: 0x0029E060
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

		// Token: 0x040070D8 RID: 28888
		private static readonly MessageParser<PhantomSettingInfo> _parser = new MessageParser<PhantomSettingInfo>(() => new PhantomSettingInfo());

		// Token: 0x040070D9 RID: 28889
		private UnknownFieldSet _unknownFields;

		// Token: 0x040070DA RID: 28890
		public const int SettingFieldNumber = 1;

		// Token: 0x040070DB RID: 28891
		private OnePhantomSetting setting_;

		// Token: 0x040070DC RID: 28892
		public const int SettingTypeFieldNumber = 2;

		// Token: 0x040070DD RID: 28893
		private PhantomSettingType settingType_;
	}
}
