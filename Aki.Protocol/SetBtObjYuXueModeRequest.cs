using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011CB RID: 4555
	[NetMessage(EMessageId.SetBtObjYuXueModeRequest)]
	public sealed class SetBtObjYuXueModeRequest : IMessage<SetBtObjYuXueModeRequest>, IMessage, IEquatable<SetBtObjYuXueModeRequest>, IDeepCloneable<SetBtObjYuXueModeRequest>, IBufferMessage
	{
		// Token: 0x060184C2 RID: 99522 RVA: 0x003892E0 File Offset: 0x003874E0
		[NullableContext(1)]
		public static SetBtObjYuXueModeRequest Create()
		{
			return new SetBtObjYuXueModeRequest();
		}

		// Token: 0x170051D6 RID: 20950
		// (get) Token: 0x060184C3 RID: 99523 RVA: 0x003892E7 File Offset: 0x003874E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170051D7 RID: 20951
		// (get) Token: 0x060184C4 RID: 99524 RVA: 0x003892EA File Offset: 0x003874EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetBtObjYuXueModeRequest.Descriptor;
			}
		}

		// Token: 0x060184C5 RID: 99525 RVA: 0x003892F1 File Offset: 0x003874F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetBtObjYuXueModeRequest()
		{
		}

		// Token: 0x060184C6 RID: 99526 RVA: 0x003892F9 File Offset: 0x003874F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetBtObjYuXueModeRequest(SetBtObjYuXueModeRequest other) : this()
		{
			this.btType_ = other.btType_;
			this.btObjId_ = other.btObjId_;
			this.btObjSetting_ = other.btObjSetting_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060184C7 RID: 99527 RVA: 0x00389336 File Offset: 0x00387536
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetBtObjYuXueModeRequest Clone()
		{
			return new SetBtObjYuXueModeRequest(this);
		}

		// Token: 0x170051D8 RID: 20952
		// (get) Token: 0x060184C8 RID: 99528 RVA: 0x0038933E File Offset: 0x0038753E
		// (set) Token: 0x060184C9 RID: 99529 RVA: 0x00389346 File Offset: 0x00387546
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

		// Token: 0x170051D9 RID: 20953
		// (get) Token: 0x060184CA RID: 99530 RVA: 0x0038934F File Offset: 0x0038754F
		// (set) Token: 0x060184CB RID: 99531 RVA: 0x00389357 File Offset: 0x00387557
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

		// Token: 0x170051DA RID: 20954
		// (get) Token: 0x060184CC RID: 99532 RVA: 0x00389360 File Offset: 0x00387560
		// (set) Token: 0x060184CD RID: 99533 RVA: 0x00389368 File Offset: 0x00387568
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

		// Token: 0x060184CE RID: 99534 RVA: 0x00389371 File Offset: 0x00387571
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetBtObjYuXueModeRequest);
		}

		// Token: 0x060184CF RID: 99535 RVA: 0x00389380 File Offset: 0x00387580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetBtObjYuXueModeRequest other)
		{
			return other != null && (other == this || (this.BtType == other.BtType && this.BtObjId == other.BtObjId && this.BtObjSetting == other.BtObjSetting && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060184D0 RID: 99536 RVA: 0x003893DC File Offset: 0x003875DC
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

		// Token: 0x060184D1 RID: 99537 RVA: 0x00389453 File Offset: 0x00387653
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060184D2 RID: 99538 RVA: 0x00389460 File Offset: 0x00387660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060184D3 RID: 99539 RVA: 0x0038946C File Offset: 0x0038766C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BtType != BtType.Invalid)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.BtType);
			}
			if (this.BtObjId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.BtObjId);
			}
			if (this.BtObjSetting != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.BtObjSetting);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060184D4 RID: 99540 RVA: 0x003894E4 File Offset: 0x003876E4
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

		// Token: 0x060184D5 RID: 99541 RVA: 0x00389554 File Offset: 0x00387754
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

		// Token: 0x060184D6 RID: 99542 RVA: 0x003895B8 File Offset: 0x003877B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060184D7 RID: 99543 RVA: 0x003895C4 File Offset: 0x003877C4
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
				if (num != 40U)
				{
					if (num != 104U)
					{
						if (num != 120U)
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

		// Token: 0x04008FED RID: 36845
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008FEE RID: 36846
		public const int BtTypeFieldNumber = 5;

		// Token: 0x04008FEF RID: 36847
		private BtType btType_;

		// Token: 0x04008FF0 RID: 36848
		public const int BtObjIdFieldNumber = 13;

		// Token: 0x04008FF1 RID: 36849
		private int btObjId_;

		// Token: 0x04008FF2 RID: 36850
		public const int BtObjSettingFieldNumber = 15;

		// Token: 0x04008FF3 RID: 36851
		private int btObjSetting_;
	}
}
