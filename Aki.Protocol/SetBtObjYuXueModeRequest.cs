using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001205 RID: 4613
	[NetMessage(EMessageId.SetBtObjYuXueModeRequest)]
	public sealed class SetBtObjYuXueModeRequest : IMessage<SetBtObjYuXueModeRequest>, IMessage, IEquatable<SetBtObjYuXueModeRequest>, IDeepCloneable<SetBtObjYuXueModeRequest>, IBufferMessage
	{
		// Token: 0x06018A63 RID: 100963 RVA: 0x00398618 File Offset: 0x00396818
		[NullableContext(1)]
		public static SetBtObjYuXueModeRequest Create()
		{
			return new SetBtObjYuXueModeRequest();
		}

		// Token: 0x17005342 RID: 21314
		// (get) Token: 0x06018A64 RID: 100964 RVA: 0x0039861F File Offset: 0x0039681F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005343 RID: 21315
		// (get) Token: 0x06018A65 RID: 100965 RVA: 0x00398622 File Offset: 0x00396822
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetBtObjYuXueModeRequest.Descriptor;
			}
		}

		// Token: 0x06018A66 RID: 100966 RVA: 0x00398629 File Offset: 0x00396829
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetBtObjYuXueModeRequest()
		{
		}

		// Token: 0x06018A67 RID: 100967 RVA: 0x00398631 File Offset: 0x00396831
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetBtObjYuXueModeRequest(SetBtObjYuXueModeRequest other) : this()
		{
			this.btType_ = other.btType_;
			this.btObjId_ = other.btObjId_;
			this.btObjSetting_ = other.btObjSetting_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018A68 RID: 100968 RVA: 0x0039866E File Offset: 0x0039686E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetBtObjYuXueModeRequest Clone()
		{
			return new SetBtObjYuXueModeRequest(this);
		}

		// Token: 0x17005344 RID: 21316
		// (get) Token: 0x06018A69 RID: 100969 RVA: 0x00398676 File Offset: 0x00396876
		// (set) Token: 0x06018A6A RID: 100970 RVA: 0x0039867E File Offset: 0x0039687E
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

		// Token: 0x17005345 RID: 21317
		// (get) Token: 0x06018A6B RID: 100971 RVA: 0x00398687 File Offset: 0x00396887
		// (set) Token: 0x06018A6C RID: 100972 RVA: 0x0039868F File Offset: 0x0039688F
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

		// Token: 0x17005346 RID: 21318
		// (get) Token: 0x06018A6D RID: 100973 RVA: 0x00398698 File Offset: 0x00396898
		// (set) Token: 0x06018A6E RID: 100974 RVA: 0x003986A0 File Offset: 0x003968A0
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

		// Token: 0x06018A6F RID: 100975 RVA: 0x003986A9 File Offset: 0x003968A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetBtObjYuXueModeRequest);
		}

		// Token: 0x06018A70 RID: 100976 RVA: 0x003986B8 File Offset: 0x003968B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetBtObjYuXueModeRequest other)
		{
			return other != null && (other == this || (this.BtType == other.BtType && this.BtObjId == other.BtObjId && this.BtObjSetting == other.BtObjSetting && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018A71 RID: 100977 RVA: 0x00398714 File Offset: 0x00396914
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

		// Token: 0x06018A72 RID: 100978 RVA: 0x0039878B File Offset: 0x0039698B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018A73 RID: 100979 RVA: 0x00398798 File Offset: 0x00396998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018A74 RID: 100980 RVA: 0x003987A4 File Offset: 0x003969A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BtObjSetting != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.BtObjSetting);
			}
			if (this.BtType != BtType.Invalid)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.BtType);
			}
			if (this.BtObjId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.BtObjId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018A75 RID: 100981 RVA: 0x00398818 File Offset: 0x00396A18
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

		// Token: 0x06018A76 RID: 100982 RVA: 0x00398888 File Offset: 0x00396A88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetBtObjYuXueModeRequest other)
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

		// Token: 0x06018A77 RID: 100983 RVA: 0x003988EC File Offset: 0x00396AEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018A78 RID: 100984 RVA: 0x003988F8 File Offset: 0x00396AF8
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
					if (num != 40U)
					{
						if (num != 80U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.BtObjSetting = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009280 RID: 37504
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009281 RID: 37505
		public const int BtTypeFieldNumber = 5;

		// Token: 0x04009282 RID: 37506
		private BtType btType_;

		// Token: 0x04009283 RID: 37507
		public const int BtObjIdFieldNumber = 10;

		// Token: 0x04009284 RID: 37508
		private int btObjId_;

		// Token: 0x04009285 RID: 37509
		public const int BtObjSettingFieldNumber = 1;

		// Token: 0x04009286 RID: 37510
		private int btObjSetting_;
	}
}
