using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001EF RID: 495
	public sealed class BtObjYuXueModeInfo : IMessage<BtObjYuXueModeInfo>, IMessage, IEquatable<BtObjYuXueModeInfo>, IDeepCloneable<BtObjYuXueModeInfo>, IBufferMessage
	{
		// Token: 0x0600377E RID: 14206 RVA: 0x0008B011 File Offset: 0x00089211
		[NullableContext(1)]
		public static BtObjYuXueModeInfo Create()
		{
			return new BtObjYuXueModeInfo();
		}

		// Token: 0x170008ED RID: 2285
		// (get) Token: 0x0600377F RID: 14207 RVA: 0x0008B018 File Offset: 0x00089218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BtObjYuXueModeInfo> Parser
		{
			get
			{
				return BtObjYuXueModeInfo._parser;
			}
		}

		// Token: 0x170008EE RID: 2286
		// (get) Token: 0x06003780 RID: 14208 RVA: 0x0008B01F File Offset: 0x0008921F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170008EF RID: 2287
		// (get) Token: 0x06003781 RID: 14209 RVA: 0x0008B022 File Offset: 0x00089222
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BtObjYuXueModeInfo.Descriptor;
			}
		}

		// Token: 0x06003782 RID: 14210 RVA: 0x0008B029 File Offset: 0x00089229
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtObjYuXueModeInfo()
		{
		}

		// Token: 0x06003783 RID: 14211 RVA: 0x0008B031 File Offset: 0x00089231
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtObjYuXueModeInfo(BtObjYuXueModeInfo other) : this()
		{
			this.btType_ = other.btType_;
			this.btObjId_ = other.btObjId_;
			this.btObjSetting_ = other.btObjSetting_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003784 RID: 14212 RVA: 0x0008B06E File Offset: 0x0008926E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtObjYuXueModeInfo Clone()
		{
			return new BtObjYuXueModeInfo(this);
		}

		// Token: 0x170008F0 RID: 2288
		// (get) Token: 0x06003785 RID: 14213 RVA: 0x0008B076 File Offset: 0x00089276
		// (set) Token: 0x06003786 RID: 14214 RVA: 0x0008B07E File Offset: 0x0008927E
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

		// Token: 0x170008F1 RID: 2289
		// (get) Token: 0x06003787 RID: 14215 RVA: 0x0008B087 File Offset: 0x00089287
		// (set) Token: 0x06003788 RID: 14216 RVA: 0x0008B08F File Offset: 0x0008928F
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

		// Token: 0x170008F2 RID: 2290
		// (get) Token: 0x06003789 RID: 14217 RVA: 0x0008B098 File Offset: 0x00089298
		// (set) Token: 0x0600378A RID: 14218 RVA: 0x0008B0A0 File Offset: 0x000892A0
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

		// Token: 0x0600378B RID: 14219 RVA: 0x0008B0A9 File Offset: 0x000892A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BtObjYuXueModeInfo);
		}

		// Token: 0x0600378C RID: 14220 RVA: 0x0008B0B8 File Offset: 0x000892B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BtObjYuXueModeInfo other)
		{
			return other != null && (other == this || (this.BtType == other.BtType && this.BtObjId == other.BtObjId && this.BtObjSetting == other.BtObjSetting && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600378D RID: 14221 RVA: 0x0008B114 File Offset: 0x00089314
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

		// Token: 0x0600378E RID: 14222 RVA: 0x0008B18B File Offset: 0x0008938B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600378F RID: 14223 RVA: 0x0008B198 File Offset: 0x00089398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003790 RID: 14224 RVA: 0x0008B1A4 File Offset: 0x000893A4
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

		// Token: 0x06003791 RID: 14225 RVA: 0x0008B218 File Offset: 0x00089418
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

		// Token: 0x06003792 RID: 14226 RVA: 0x0008B288 File Offset: 0x00089488
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

		// Token: 0x06003793 RID: 14227 RVA: 0x0008B2EC File Offset: 0x000894EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003794 RID: 14228 RVA: 0x0008B2F8 File Offset: 0x000894F8
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

		// Token: 0x04002B38 RID: 11064
		private static readonly MessageParser<BtObjYuXueModeInfo> _parser = new MessageParser<BtObjYuXueModeInfo>(() => new BtObjYuXueModeInfo());

		// Token: 0x04002B39 RID: 11065
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002B3A RID: 11066
		public const int BtTypeFieldNumber = 1;

		// Token: 0x04002B3B RID: 11067
		private BtType btType_;

		// Token: 0x04002B3C RID: 11068
		public const int BtObjIdFieldNumber = 2;

		// Token: 0x04002B3D RID: 11069
		private int btObjId_;

		// Token: 0x04002B3E RID: 11070
		public const int BtObjSettingFieldNumber = 3;

		// Token: 0x04002B3F RID: 11071
		private int btObjSetting_;
	}
}
