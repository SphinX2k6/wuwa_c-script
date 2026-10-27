using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001EB RID: 491
	public sealed class BtObjYuXueModeInfo : IMessage<BtObjYuXueModeInfo>, IMessage, IEquatable<BtObjYuXueModeInfo>, IDeepCloneable<BtObjYuXueModeInfo>, IBufferMessage
	{
		// Token: 0x060036F1 RID: 14065 RVA: 0x00089899 File Offset: 0x00087A99
		[NullableContext(1)]
		public static BtObjYuXueModeInfo Create()
		{
			return new BtObjYuXueModeInfo();
		}

		// Token: 0x170008D4 RID: 2260
		// (get) Token: 0x060036F2 RID: 14066 RVA: 0x000898A0 File Offset: 0x00087AA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BtObjYuXueModeInfo> Parser
		{
			get
			{
				return BtObjYuXueModeInfo._parser;
			}
		}

		// Token: 0x170008D5 RID: 2261
		// (get) Token: 0x060036F3 RID: 14067 RVA: 0x000898A7 File Offset: 0x00087AA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170008D6 RID: 2262
		// (get) Token: 0x060036F4 RID: 14068 RVA: 0x000898AA File Offset: 0x00087AAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BtObjYuXueModeInfo.Descriptor;
			}
		}

		// Token: 0x060036F5 RID: 14069 RVA: 0x000898B1 File Offset: 0x00087AB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtObjYuXueModeInfo()
		{
		}

		// Token: 0x060036F6 RID: 14070 RVA: 0x000898B9 File Offset: 0x00087AB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtObjYuXueModeInfo(BtObjYuXueModeInfo other) : this()
		{
			this.btType_ = other.btType_;
			this.btObjId_ = other.btObjId_;
			this.btObjSetting_ = other.btObjSetting_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060036F7 RID: 14071 RVA: 0x000898F6 File Offset: 0x00087AF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtObjYuXueModeInfo Clone()
		{
			return new BtObjYuXueModeInfo(this);
		}

		// Token: 0x170008D7 RID: 2263
		// (get) Token: 0x060036F8 RID: 14072 RVA: 0x000898FE File Offset: 0x00087AFE
		// (set) Token: 0x060036F9 RID: 14073 RVA: 0x00089906 File Offset: 0x00087B06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtType BtType
		{
			get
			{
				return this.btType_;
			}
			set
			{
				this.btType_ = value;
			}
		}

		// Token: 0x170008D8 RID: 2264
		// (get) Token: 0x060036FA RID: 14074 RVA: 0x0008990F File Offset: 0x00087B0F
		// (set) Token: 0x060036FB RID: 14075 RVA: 0x00089917 File Offset: 0x00087B17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BtObjId
		{
			get
			{
				return this.btObjId_;
			}
			set
			{
				this.btObjId_ = value;
			}
		}

		// Token: 0x170008D9 RID: 2265
		// (get) Token: 0x060036FC RID: 14076 RVA: 0x00089920 File Offset: 0x00087B20
		// (set) Token: 0x060036FD RID: 14077 RVA: 0x00089928 File Offset: 0x00087B28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BtObjSetting
		{
			get
			{
				return this.btObjSetting_;
			}
			set
			{
				this.btObjSetting_ = value;
			}
		}

		// Token: 0x060036FE RID: 14078 RVA: 0x00089931 File Offset: 0x00087B31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BtObjYuXueModeInfo);
		}

		// Token: 0x060036FF RID: 14079 RVA: 0x00089940 File Offset: 0x00087B40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BtObjYuXueModeInfo other)
		{
			return other != null && (other == this || (this.BtType == other.BtType && this.BtObjId == other.BtObjId && this.BtObjSetting == other.BtObjSetting && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003700 RID: 14080 RVA: 0x0008999C File Offset: 0x00087B9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BtType != BtType.Invalid)
			{
				num ^= this.BtType.GetHashCode();
			}
			if (this.BtObjId != 0)
			{
				num ^= this.BtObjId.GetHashCode();
			}
			if (this.BtObjSetting != 0)
			{
				num ^= this.BtObjSetting.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003701 RID: 14081 RVA: 0x00089A13 File Offset: 0x00087C13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003702 RID: 14082 RVA: 0x00089A20 File Offset: 0x00087C20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003703 RID: 14083 RVA: 0x00089A2C File Offset: 0x00087C2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BtType != BtType.Invalid)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.BtType);
			}
			if (this.BtObjId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.BtObjId);
			}
			if (this.BtObjSetting != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.BtObjSetting);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003704 RID: 14084 RVA: 0x00089AA0 File Offset: 0x00087CA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BtType != BtType.Invalid)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.BtType);
			}
			if (this.BtObjId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BtObjId);
			}
			if (this.BtObjSetting != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BtObjSetting);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003705 RID: 14085 RVA: 0x00089B10 File Offset: 0x00087D10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BtObjYuXueModeInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BtType != BtType.Invalid)
			{
				this.BtType = other.BtType;
			}
			if (other.BtObjId != 0)
			{
				this.BtObjId = other.BtObjId;
			}
			if (other.BtObjSetting != 0)
			{
				this.BtObjSetting = other.BtObjSetting;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003706 RID: 14086 RVA: 0x00089B74 File Offset: 0x00087D74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003707 RID: 14087 RVA: 0x00089B80 File Offset: 0x00087D80
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
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.BtObjSetting = input.ReadInt32();
						}
					}
					else
					{
						this.BtObjId = input.ReadInt32();
					}
				}
				else
				{
					this.BtType = (BtType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002ABD RID: 10941
		private static readonly MessageParser<BtObjYuXueModeInfo> _parser = new MessageParser<BtObjYuXueModeInfo>(() => new BtObjYuXueModeInfo());

		// Token: 0x04002ABE RID: 10942
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002ABF RID: 10943
		public const int BtTypeFieldNumber = 1;

		// Token: 0x04002AC0 RID: 10944
		private BtType btType_;

		// Token: 0x04002AC1 RID: 10945
		public const int BtObjIdFieldNumber = 2;

		// Token: 0x04002AC2 RID: 10946
		private int btObjId_;

		// Token: 0x04002AC3 RID: 10947
		public const int BtObjSettingFieldNumber = 3;

		// Token: 0x04002AC4 RID: 10948
		private int btObjSetting_;
	}
}
